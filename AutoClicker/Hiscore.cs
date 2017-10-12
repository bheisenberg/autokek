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
        public string username { get; set; }

        public Hiscore(string username)
        {
            this.username = username;
        }



        public int getMaxHP ()
        {
            string url = "http://services.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + username;
            Console.WriteLine(url);
            using(WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(url);
                string[] hiscore = json.Split(',');
                Console.WriteLine("HP: "+hiscore[9]);
                return (int.Parse(hiscore[9]));
            }
        }
    }
}
