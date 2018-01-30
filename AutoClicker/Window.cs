using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public class Window
    {
        public IntPtr window { get; }
        public string title { get; }

        public Window(IntPtr window, string title)
        {
            this.window = window;
            this.title = title;
        }
    }
}
