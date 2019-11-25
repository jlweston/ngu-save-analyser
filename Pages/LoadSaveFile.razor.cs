using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using NGUSaveAnalyser.Shared;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Pages
{
    public class LoadSaveFileBase : ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        [Inject] HttpClient Http { get; set; }
        [CascadingParameter] MainLayout mainlayout { get; set; }
        [CascadingParameter] PlayerData playerdata { get; set; }

        const string DefaultStatus = "Drop a text file here to view it, or click to choose a file";
        const int MaxFileSize = 1 * 1024 * 1024; // 1MB
        protected string status = DefaultStatus;

        protected async Task HandleFileSelected(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file == null)
            {
                return;
            }
            else if (file.Size > MaxFileSize)
            {
                status = $"That's too big. Max size: {MaxFileSize} bytes.";
            }
            else
            {
                status = "Loading...";

                using (var reader = new StreamReader(file.Data))
                {
                    string fileRawContents = await reader.ReadToEndAsync();
                    mainlayout.SetPlayerData(DecodeToJSON(fileRawContents));
                }

                status = DefaultStatus;
                NavigationManager.NavigateTo("/summary");
            }
        }

        private static T DeserializeBase64<T>(string base64Data)
        {
            byte[] bytes = Convert.FromBase64String(base64Data);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Binder = new CustomBinder();

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                return (T)formatter.Deserialize(memoryStream);
            }
        }

        private static string GetChecksum(string data)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            return Convert.ToBase64String(md5.ComputeHash(Convert.FromBase64String(data)));
        }

        public PlayerData DecodeToJSON(string contents)
        {

            SaveData saveData = DeserializeBase64<SaveData>(contents);

            string checksum = GetChecksum(saveData.playerData);
            if (saveData.checksum != checksum)
            {
                throw new Exception("checksum mismatch");
            }

            return DeserializeBase64<PlayerData>(saveData.playerData);
        }

        sealed class CustomBinder : SerializationBinder
        {
            public override Type BindToType(string assemblyName, string typeName)
            {
                // Force assembly name so we can use 'wrong' assembly in BinaryFormatter
                assemblyName = assemblyName.Replace("1.0.0.0", "0.0.0.0");
                assemblyName = assemblyName.Replace("Assembly-CSharp", "NGUSaveAnalyser");

                // The following line of code returns the type.
                Type typeToDeserialize = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName));

                return typeToDeserialize;
            }
        }

        protected async override void OnInitialized()
        {
            var bytes = await Http.GetByteArrayAsync("/Assembly-CSharp.dll");
            System.Reflection.Assembly.Load(bytes);
        }
    }
}
