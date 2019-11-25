using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Shared
{
    public class MainLayoutBase : LayoutComponentBase
    {
        public PlayerData playerdata { get; private set; }
        public string playerdataJSON;

        public void SetPlayerData(PlayerData pd)
        {
            playerdata = pd;
            playerdataJSON = JsonConvert.SerializeObject(playerdata, Formatting.Indented);
            StateHasChanged();
        }
    }
}
