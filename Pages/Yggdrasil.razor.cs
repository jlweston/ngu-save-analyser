using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Pages
{
    public class YggdrasilBase: ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        [CascadingParameter] protected PlayerData playerdata { get; set; }

        private readonly int[] baseCosts = new int[] { 1, 10, 25, 40, 60, 100, 150, 170, 200, 2000, 15000, 30000, 50000, 100000, 25000, 250000, 250000, 250000, 250000, 250000, 250000 };
        protected List<Fruit> fruits;

        protected async override void OnInitialized()
        {
            if (playerdata == null)
            {
                await Task.Delay(2500);
                NavigationManager.NavigateTo("/");
            }
        }

        protected override void OnParametersSet()
        {
            if (playerdata != null)
            {
                fruits = playerdata.yggdrasil.fruits;
            }
        }

        protected string CheckHarvestMode(Fruit fruit)
        {
            if (fruit.eatFruit)
            {
                return "Eat";
            }
            else
            {
                return "Harvest";
            }
        }

        protected int TotalSeedsSpent(int fruit)
        {
            var tiers = fruits[fruit].maxTier;
            var total = (int)(tiers * (tiers + 1) * ((2 * tiers) + 1) / 6);
            var baseCost = baseCosts[fruit];
            return baseCost * total;
        }
    }
}
