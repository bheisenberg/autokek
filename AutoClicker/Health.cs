using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoClicker
{
    class Health
    {
        public Health(int maxHealth)
        {

        }

        public void GetHealthLevelFromHiscores()
        {
            Hiscore playerHiscore = new Hiscore();
        }

        public void GetHealthLocation()
        {
            Color correct = Color.FromArgb(253, 221, 152);
            Bitmap screen = CaptureFullScreen();
            Color currentPixel = screen.GetPixel(0, 0);
            int x = 0;
            int y = 0;
            while (currentPixel != correct)
            {
                if (x < screen.Width)
                {
                    currentPixel = screen.GetPixel(x, y);
                    x++;
                }
                else if (x >= screen.Width)
                {
                    x = 0;
                    y++;
                }
            }
            Console.WriteLine("found!");
        }

        private Color GetHealthColor(Bitmap image)
        {
            GetHealthLocation();
            int startX = 7;
            int startY = 12;
            Color[] badColors = new Color[] { Color.FromArgb(104, 90, 75), Color.FromArgb(0, 0, 0) };
            var color = image.GetPixel(startX, startY);
            int count = 0;
            while (badColors.Contains(color))
            {
                count++;
                color = image.GetPixel(startX + count, startY);
            }
            return color;
        }

        public Hitpoints getHealth()
        {
            Color color = GetHealthColor(CaptureApplication());
            float hpConstant = 0.00196079f;
            int amount = (int)Math.Round(((maxHealth / 2f) - (maxHealth * hpConstant * color.R) + (maxHealth * hpConstant * color.G)));
            return new Hitpoints(amount, color);
        }
    }
}
}
