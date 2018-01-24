using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoClicker
{
    class HitpointsCapturer
    {
        private const float HEALTHCONSTANT = 0.00196079f;
        private int hitpointsLevel;
        public Color HitpointsColor { get; }
        public int currentHitpoints { get; }

        public HitpointsCapturer()
        {
            this.hitpointsLevel = GetHitpointsFromHiscores();
            this.HitpointsColor = GetHitpointsColor();
            this.currentHitpoints = CalculateCurrentHitpointsAmount();
        }

        public int CalculateCurrentHitpointsAmount()
        {
            return (int)Math.Round(((hitpointsLevel / 2f) 
                - (hitpointsLevel * HEALTHCONSTANT * HitpointsColor.R) 
                + (hitpointsLevel * HEALTHCONSTANT * HitpointsColor.G)));
        }

        public int GetHitpointsFromHiscores()
        {
            Hiscore playerHiscore = new Hiscore();
            return playerHiscore.GetHitpoints();
        }

        private Color GetHitpointsColor()
        {
            FindHealthLocation();
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

        public void FindHealthLocation()
        {
            Color correctPixel = Color.FromArgb(253, 221, 152);
            Bitmap screen = CaptureFullScreen();
            Color currentPixel = screen.GetPixel(0, 0);
            int x = 0;
            int y = 0;
            while (currentPixel != correctPixel)
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
    }
}
