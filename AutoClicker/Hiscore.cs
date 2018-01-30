using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AutoClicker
{
    public class Hiscore
    {
        private string username;
        private int rank;
        private string baseUrl = "http://services.runescape.com/m=hiscore_oldschool/index_lite.ws?player=";
        private string[] hiscoreMap;
        private const int NUM_SKILLS = 24;
        private const int NUM_PROPERTIES = 3;


        public Hiscore (string username)
        {
            this.username = username;
            this.hiscoreMap = new string[]
            {
                "total", "attack", "defence", "strength", "hitpoints",
                "ranged", "prayer", "magic", "cooking", "woodcutting",
                "fletching", "fishing", "firemaking", "crafting", "smithing",
                "mining", "herblore", "agility", "thieving", "slayer",
                "farming", "runecraft", "hunter", "construction"
            };
        }

        public Dictionary<string, Skill> GetSkills()
        {
            Dictionary<string, Skill> skills = new Dictionary<string, Skill>();
            string hiscoresRaw = GetPlayerHiscores();
            string[] hiscoresSplit = hiscoresRaw.Replace("-1", "").Split(',', '\n').Take(GetHiscoreLength()).ToArray();
            int[] hiscores = hiscoresSplit.Select(i => int.Parse(i)).ToArray();
            int j = 0;
            for (int i = 0; i < hiscores.Length/NUM_PROPERTIES; i++)
            {
                skills[hiscoreMap[i]] = new Skill(hiscores[j], hiscores[j += 1], hiscores[j += 1]);
                j += 1;
            }
            return skills;
        }

        private int GetHiscoreLength()
        {
            return NUM_PROPERTIES * NUM_SKILLS;
        }

        private string GetPlayerHiscores()
        {
            using (WebClient hiscoreConnection = new WebClient())
            {
                return hiscoreConnection.DownloadString(PlayerUrl());
            }
        }

        private string PlayerUrl()
        {
            try
            {
                return baseUrl + username;
            }
            catch
            {
                throw new Exception("username not found");
            }
        }
    }
}
