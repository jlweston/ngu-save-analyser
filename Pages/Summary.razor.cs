using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Pages
{
    public class SummaryBase : ComponentBase
    {
        [Inject] NavigationManager NavigationManager { get; set; }
        [CascadingParameter] protected PlayerData playerdata { get; set; }

        protected async override void OnInitialized()
        {
            if (playerdata == null)
            {
                await Task.Delay(2500);
                NavigationManager.NavigateTo("/");
            }
        }

        public static string SentenceCase(string input)
        {
            if (input.Length < 1)
                return input;

            string sentence = input.ToLower();
            return sentence[0].ToString().ToUpper() +
                sentence.Substring(1);
        }

        protected string GetHighestBoss()
        {
            switch (playerdata.settings.rebirthDifficulty)
            {
                case difficulty.normal:
                    return $"{playerdata.highestBoss} ({playerdata.settings.rebirthDifficulty})";
                case difficulty.evil:
                    return $"{playerdata.highestHardBoss} ({playerdata.settings.rebirthDifficulty})";
                case difficulty.sadistic:
                    return $"{playerdata.highestSadisticBoss} ({playerdata.settings.rebirthDifficulty})";
                default:
                    return "";
            }
        }
    }
}
