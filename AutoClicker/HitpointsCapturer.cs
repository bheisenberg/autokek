using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AutoClicker
{
    public class HitpointsCapturer
    {
        /*private const float HEALTHCONSTANT = 0.00196079f;
        private GameScreen gameScreen;
        private int hitpointsLevel;
        public Color HitpointsColor { get; }
        public int CurrentHitpoints { get; }

        public HitpointsCapturer(int hitpointsLevel, GameScreen gameScreen)
        {
            this.gameScreen = gameScreen;
            this.hitpointsLevel = hitpointsLevel;
            this.HitpointsColor = GetHitpointsColor();
            this.CurrentHitpoints = CalculateCurrentHitpointsAmount();
        }

        public int CalculateCurrentHitpointsAmount()
        {
            return (int)Math.Round(((hitpointsLevel / 2f)
                - (hitpointsLevel * HEALTHCONSTANT * HitpointsColor.R)
                + (hitpointsLevel * HEALTHCONSTANT * HitpointsColor.G)));
        }

        private Color GetHitpointsColor()
        {
            Color correctPixel = Color.FromArgb(253, 221, 152);
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
            return new Color();
        }*/


    }
}
