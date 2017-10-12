using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class ThievingControl : UserControl
    {
        public ThievingControl()
        {
            InitializeComponent();
        }

        public void UpdateHPLabel(Hitpoints hitpoints)
        {
            hpLabel.ForeColor = hitpoints.color;
            hpLabel.Text = hitpoints.amount.ToString();
        }
    }
}
