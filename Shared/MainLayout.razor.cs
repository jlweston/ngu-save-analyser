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
        public bool ownSaveLoaded { get; private set; }
        public bool ownSaveShared { get; private set; }
        public string saveId { get; private set; }

        public void SetPlayerData(PlayerData pd)
        {
            playerdata = pd;
            playerdataJSON = JsonConvert.SerializeObject(playerdata, Formatting.Indented);
            ownSaveLoaded = true;
            ownSaveShared = false;
            StateHasChanged();
        }

        public void SetOwnSaveShared(bool shared)
        {
            ownSaveShared = shared;
        }

        public void SetOwnSaveId(string ownSaveId)
        {
            saveId = ownSaveId;
        }
    }
}
