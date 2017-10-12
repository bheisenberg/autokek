using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoClicker
{
    public class Hitpoints
    {
        public int amount { get; set; }
        public Color color { get; set; }

        public Hitpoints (int amount, Color color)
        {
            this.amount = amount;
            this.color = color;
        }
    }
}
