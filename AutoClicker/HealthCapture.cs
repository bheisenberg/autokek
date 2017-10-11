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
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
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
            result.Save("c:/tmp/test/img.png");
            return result;
        }

        private Color GetHealthColor (Bitmap image)
        {
            int startX = 7;
            int startY = 13;
            Color[] badColors = new Color[] { Color.FromArgb(104, 90, 75), Color.FromArgb(0, 0, 0) };
            var color = image.GetPixel(startX, startY);
            int count = 0;
            while (badColors.Contains(color))
            {
                count++;
                color = image.GetPixel(startX + count, startY - count);
                Console.WriteLine("R: " + color.R + ", G: " + color.G);
            }
            return color;
        }

        public int getHealth()
        {
            Color color = GetHealthColor(CaptureApplication());
            int max = 85;
            float hpConstant = 0.1626262626f;
            return (int)((max / 2) - (hpConstant * color.R) + (hpConstant * color.G));
        }
    }
}
