using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Substance_Logger
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void dsblClose_mouse_hover(object sender, EventArgs e)
        {
            // create a tooltip to describe what this is for
            // protip: it's meant to prevent the user from accidentally closing the program
        }
    }
}
