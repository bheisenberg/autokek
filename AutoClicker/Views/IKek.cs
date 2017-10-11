using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker.Views
{
    public interface IKek
    {
        int startRange { get; set; }
        int endRange { get; set; }
        int duration { get; set; }
        int startup { get; set; }
    }
}
