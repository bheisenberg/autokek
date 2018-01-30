using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class Player
    {
        public string UserName { get; }
        public Dictionary<string, Skill> skills;
        public int HitpointsLevel { get; set; }

        public Player()
        {
            UserName = "";
            skills = new Dictionary<string, Skill>();
        }

        public Player(string username)
        {
            this.UserName = username;
            GetSkills();
        }

        public bool HasSkills()
        {
            return skills.Count > 0;
        }

        private void GetSkills()
        {
            Hiscore hiscores = new Hiscore(UserName);
            skills = hiscores.GetSkills();
        }
    }
}
