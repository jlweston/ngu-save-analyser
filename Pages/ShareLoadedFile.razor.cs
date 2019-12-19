using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;

namespace NGUSaveAnalyser.Pages
{
    public class ShareLoadedFileBase : ComponentBase
    {
        protected string SaveId = "";
        [CascadingParameter] string playerdatajson { get; set; }
        [CascadingParameter] PlayerData playerdata { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }

        bool loading = false;

        protected override async void OnParametersSet()
        {
            if (playerdata != null && loading == false)
            {
                loading = true;
                SaveId = await JSRuntime.InvokeAsync<string>("postPlayerData", playerdatajson);
                StateHasChanged();
            }
        }
    }
}
