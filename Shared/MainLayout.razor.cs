using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace NGUSaveAnalyser.Shared
{
    public class MainLayoutBase : LayoutComponentBase
    {
        [Inject] HttpClient Http { get; set; }
        public PlayerData playerdata { get; private set; }
        public string playerdataJSON { get; private set; }
        public bool ownSaveLoaded { get; private set; }
        public bool ownSaveShared { get; private set; }
        public string saveId { get; private set; }
        public string rawData { get; private set; }
        public bool loadingFromApi { get; set; }

        protected async override void OnInitialized()
        {
            var bytes = await Http.GetByteArrayAsync("/Assembly-CSharp.dll");
            System.Reflection.Assembly.Load(bytes);
        }

        public void SetPlayerData(PlayerData pd)
        {
            playerdata = pd;
            playerdataJSON = JsonConvert.SerializeObject(playerdata, Formatting.Indented);
            ownSaveLoaded = true;
            StateHasChanged();
        }

        public void SetRawData(string raw)
        {
            rawData = raw;
        }

        public void SetOwnSaveShared(bool shared)
        {
            ownSaveShared = shared;
        }

        public void SetOwnSaveId(string ownSaveId)
        {
            saveId = ownSaveId;
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
                Type typeToDeserialize = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName), true);

                return typeToDeserialize;
            }
        }
    }
}
