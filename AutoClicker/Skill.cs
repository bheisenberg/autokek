using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker
{
    public class Skill
    {
        public int Rank { get; }
        public int Level { get; }
        public int Xp { get; }

        public Skill(int rank, int level, int xp)
        {
            Rank = rank;
            Level = level;
            Xp = xp;
        }
    }
}
