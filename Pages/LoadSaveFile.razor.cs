using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using NGUSaveAnalyser.Shared;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Pages
{
    public class LoadSaveFileBase : ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }
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
                    mainlayout.SetRawData(fileRawContents);
                    mainlayout.SetPlayerData(mainlayout.DecodeToJSON(fileRawContents));
                }

                status = DefaultStatus;
                NavigationManager.NavigateTo("/summary");
            }
        }
    }
}
