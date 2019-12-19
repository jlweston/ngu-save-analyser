using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NGUSaveAnalyser.Shared;

namespace NGUSaveAnalyser.Pages
{
    public class ShareLoadedFileBase : ComponentBase
    {
        [CascadingParameter] string playerdatajson { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }
        [CascadingParameter] MainLayout mainlayout { get; set; }
        protected string saveId = null;


        protected override async void OnParametersSet()
        {
            saveId = mainlayout.saveId;
            if (mainlayout.ownSaveLoaded && !mainlayout.ownSaveShared)
            {
                saveId = await JSRuntime.InvokeAsync<string>("postPlayerData", playerdatajson);
                mainlayout.SetOwnSaveShared(true);
                mainlayout.SetOwnSaveId(saveId);
                StateHasChanged();
            }
        }
    }
}
