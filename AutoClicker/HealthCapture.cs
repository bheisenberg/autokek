using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoClicker
{
    public class HealthCapture
    {
        public int maxHealth { get; set; }
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        public HealthCapture(int maxHealth)
        {
            this.maxHealth = maxHealth;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private Bitmap CaptureApplication()
        {
            var rect = new Rect();
            GetWindowRect(GetForegroundWindow(), ref rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var result = new Bitmap(20, 20);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left + 525, bounds.Top + 85), Point.Empty, bounds.Size);
            }
            result.Save("c:/tmp/test/imgnew.png");
            return result;
        }

        private static Bitmap CaptureLocation(int x, int y, int size)
        {
            var rect = new Rect();
            GetWindowRect(GetForegroundWindow(), ref rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var result = new Bitmap(size, size);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left + 525, bounds.Top + 85), Point.Empty, bounds.Size);
            }
            result.Save("c:/tmp/test/imgnew.png");
            return result;
        }

        private static Bitmap CaptureFullScreen()
        {
            var rect = new Rect();
            GetWindowRect(GetForegroundWindow(), ref rect);
            var bounds = new Rectangle(rect.left, rect.top, rect.right - rect.left, rect.bottom - rect.top);
            var result = new Bitmap(bounds.Width, bounds.Height);
            using (var graphics = Graphics.FromImage(result))
            {
                graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }
            result.Save("c:/tmp/test/imgnew.png");
            return result;
        }

        public static void GetHealthLocation ()
        {
            Color correct = Color.FromArgb(253, 221, 152);
            Bitmap screen = CaptureFullScreen();
            Color currentPixel = screen.GetPixel(0, 0);
            int x = 0;
            int y = 0;
            while(currentPixel != correct)
            {
                if(x < screen.Width) {
                    currentPixel = screen.GetPixel(x, y);
                    x++;
                } else if(x >= screen.Width)
                {
                    x = 0;
                    y++;
                }
            }
            Console.WriteLine("found!");
        }

        private Color GetHealthColor (Bitmap image)
        {
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
            int amount =  (int)Math.Round(((maxHealth / 2f) - (maxHealth * hpConstant * color.R) + (maxHealth * hpConstant * color.G)));
            return new Hitpoints(amount, color);
        }
    }
}
