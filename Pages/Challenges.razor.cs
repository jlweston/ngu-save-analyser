using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NGUSaveAnalyser.Pages
{
    public class ChallengesBase : ComponentBase
    {
        [CascadingParameter] protected PlayerData playerdata { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        private Dictionary<string, Challenge> challenges = new Dictionary<string, Challenge>();

        protected async override void OnInitialized()
        {
            if (playerdata == null)
            {
                await Task.Delay(2500);
                NavigationManager.NavigateTo("/");
            }
            else
            {
                challenges.Add("basicChallenge", playerdata.challenges.basicChallenge);
                challenges.Add("noAugsChallenge", playerdata.challenges.noAugsChallenge);
                challenges.Add("hour24Challenge", playerdata.challenges.hour24Challenge);
                challenges.Add("levelChallenge10k", playerdata.challenges.levelChallenge10k);
                challenges.Add("noEquipmentChallenge", playerdata.challenges.noEquipmentChallenge);
                challenges.Add("noRebirthChallenge", playerdata.challenges.noRebirthChallenge);
                challenges.Add("trollChallenge", playerdata.challenges.trollChallenge);
                challenges.Add("laserSwordChallenge", playerdata.challenges.laserSwordChallenge);
                challenges.Add("blindChallenge", playerdata.challenges.blindChallenge);
                challenges.Add("nguChallenge", playerdata.challenges.nguChallenge);
                challenges.Add("timeMachineChallenge", playerdata.challenges.timeMachineChallenge);
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

        protected string GetChallengeProgress(string challengeName, int completionsPerDifficulty)
        {
            // normal difficulty
            string toReturn = "";
            toReturn += "<span class=\"progress-wrapper\">";

            int sadisticCompletions = Math.Min(challenges[challengeName].curSadisticCompletions, completionsPerDifficulty);
            int evilCompletions = Math.Min(challenges[challengeName].curEvilCompletions, completionsPerDifficulty);
            int normalCompletions = Math.Min(challenges[challengeName].curCompletions, completionsPerDifficulty);

            for (int i = 0; i < normalCompletions; i++)
            {
                toReturn += "<div class=\"pip normal\"></div>";
            }

            if (normalCompletions < completionsPerDifficulty)
            {
                int missingNormalCompletions = completionsPerDifficulty - normalCompletions;
                for (int i = 0; i < missingNormalCompletions; i++)
                {
                    toReturn += "<div class=\"pip incomplete\"></div>";
                }
            }

            toReturn += "</span>";

            // evil difficulty
            toReturn += "<span class=\"progress-wrapper\">";

            for (int i = 0; i < evilCompletions; i++)
            {
                toReturn += "<div class=\"pip evil\"></div>";
            }

            if (evilCompletions < completionsPerDifficulty)
            {
                int missingEvilCompletions = completionsPerDifficulty - evilCompletions;
                for (int i = 0; i < missingEvilCompletions; i++)
                {
                    toReturn += "<div class=\"pip incomplete\"></div>";
                }
            }

            toReturn += "</span>";

            // sadistic difficulty
            toReturn += "<span class=\"progress-wrapper\">";

            for (int i = 0; i < sadisticCompletions; i++)
            {
                toReturn += "<div class=\"pip sadistic\"></div>";
            }

            if (sadisticCompletions < completionsPerDifficulty)
            {
                int missingSadisticCompletions = completionsPerDifficulty - sadisticCompletions;
                for (int i = 0; i < missingSadisticCompletions; i++)
                {
                    toReturn += "<div class=\"pip incomplete\"></div>";
                }
            }

            toReturn += "</span>";

            return toReturn;
        }

        protected string asMinutesAndSeconds(int secs)
        {
            if (secs > 2100000000 || secs == 0) // account for default completion time when no completions
            {
                return "N/A";
            }
            int minutes = (int)Math.Floor(secs / 60d);
            string seconds = (secs % 60).ToString().PadLeft(2, '0');

            return $"{minutes}:{seconds}";
        }
    }
}