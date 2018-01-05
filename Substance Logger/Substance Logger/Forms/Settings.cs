using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Substance_Logger.Objects;

namespace Substance_Logger
{
    public partial class Settings : Form
    {
        UserSettings userSettings;
        public Settings(ref UserSettings _set)
        {
            InitializeComponent();
            userSettings = _set;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // the following code copied from stack overflow.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void disable_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            userSettings.disableClose = !userSettings.disableClose;     // toggle
        }
    }
}
