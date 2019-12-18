using Microsoft.AspNetCore.Components;
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
        [CascadingParameter] PlayerData playerdata { get; set; }
        
        protected override async void OnParametersSet()
        {
            if(SaveId != null)
            {
                PlayerData data;
                using (HttpClient client = new HttpClient())
                {
                    String response = await client.GetStringAsync($"https://api.ngusav.es/load/{SaveId}");

                    data = Newtonsoft.Json.JsonConvert.DeserializeObject<PlayerData>(response);
                }

                mainlayout.SetPlayerData(data);
                NavigationManager.NavigateTo("/summary");
            }

        }
    }
}
