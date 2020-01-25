using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NGUSaveAnalyser.Shared;
using System;
using System.Net.Http;

namespace NGUSaveAnalyser.Pages
{
    public class LoadSharedFileBase : ComponentBase
    {
        [Parameter]
        public string SaveId { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Inject] HttpClient Http { get; set; }
        [CascadingParameter] MainLayout mainlayout { get; set; }
        [Inject] IJSRuntime JSRuntime { get; set; }

        protected override async void OnParametersSet()
        {
            if(SaveId != null && !mainlayout.loadingFromApi)
            {
                mainlayout.loadingFromApi = true;
                var response = await JSRuntime.InvokeAsync<string>("getPlayerData", SaveId);
                //PlayerData data = Newtonsoft.Json.JsonConvert.DeserializeObject<PlayerData>(response);
                
                mainlayout.SetPlayerData(mainlayout.DecodeToJSON(response));
                NavigationManager.NavigateTo("/summary");
                StateHasChanged();
            }
        }
    }
}
