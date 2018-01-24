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
        private string baseUrl = "http://services.runescape.com/m=hiscore_oldschool/index_lite.ws?player=";
        private const int HITPOINTS = 9;

        public int GetHitpoints()
        {
            string[] hiscore = getPlayerHiscores();
            return (int.Parse(hiscore[HITPOINTS]));
        }

        private string[] getPlayerHiscores()
        {
            using (WebClient hiscoreConnection = new WebClient())
            {
                string hiscoreJson = hiscoreConnection.DownloadString(PlayerUrl());
                return hiscoreJson.Split(',');
            }
        }

        public string PlayerUrl()
        {
            try
            {
                return baseUrl + Window.GetUsername();
            }
            catch
            {
                throw new Exception("username not found");
            }
        }

    }
}
