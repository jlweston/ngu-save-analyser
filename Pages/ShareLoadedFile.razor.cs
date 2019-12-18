using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Text;

namespace NGUSaveAnalyser.Pages
{
    public class ShareLoadedFileBase : ComponentBase
    {
        public string SaveId = null;
        [CascadingParameter] string playerdatajson { get; set; }
        [CascadingParameter] PlayerData playerdata { get; set; }
        [Inject] HttpClient HttpClient { get; set; }

        bool loading = false;

        protected override async void OnParametersSet()
        {
            if (playerdata != null && loading == false)
            {
                loading = true;
                var response = string.Empty;
                Uri u = new Uri("https://api.ngusav.es/save");

                HttpContent c = new StringContent(playerdatajson, Encoding.UTF8, "text/plain");

                string result = await HttpClient.PostJsonAsync<string>("https://api.ngusav.es/save", playerdatajson);
                //if (result.IsSuccessStatusCode)
                //{
                //response = result.Content.ToString();
                SaveId = result;
                //}
            }
        }
    }
}
