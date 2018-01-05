using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Substance_Logger.Objects;     // objects

namespace Substance_Logger
{
    public partial class LoggerForm : Form
    {
        UserSettings settings = new UserSettings();
        List<Entry> entries = new List<Entry>();
        bool inProgress = false;                        // is the program recording?

        public LoggerForm()
        {
            InitializeComponent();
            // when form is loaded, do checks (ie. does saved directory exist?)
            //      assuming that the file was loaded before
            // create a ticker for the time
            // for the sake of the user, reset all the fields so it's blank
        }

        private void Form_Closing(object sender, FormClosedEventArgs e)
        {
            // if logger is in progress (aka taking time)
            // check settings for closing window
            // if so
            //      do question closing window
            // else, stop everything and close window
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            // open up settings form in same thread
        }

        private void strtstp_btn_Click(object sender, EventArgs e)
        {
            // stop -> start
            //  check if everything's good
            //  if it's all good: start
            //  else warn user why and do nothing

            // start -> stop
            //  check if everything's good
            //  if it's all good: stop & save entries to file
            //  else warn user why and do nothing
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // if they're dosing before hitting start/stop button
            //  simply make the time T+0:00 and replace the first entry with it
            //  keep replacing the first one with it until they hit start
            // 

            // store user's entry into the List of Entries
            // reset adding fields
        }

        private void newdose_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            // toggle: redose, substance name, amount, and unit type
        }

        private void redose_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            // disable "substance name" and fill it in with the initial substance
            // and set the items inside the dropdown to previous substances used during
        }
    }
}
