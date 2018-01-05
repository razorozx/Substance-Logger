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
        UserSettings settings;
        Settings settingsForm;
        Forms.Close closeForm;
        List<Entry> entries;

        bool inProgress = false;                        // is the program recording?

        public LoggerForm()
        {
            InitializeComponent();

            settings = new UserSettings();
            settingsForm = new Settings(ref settings);
            closeForm = new Forms.Close();
            entries = new List<Entry>();

            settingsForm.Hide();
            closeForm.Hide();
            // when form is loaded, do checks (ie. does saved directory exist?)
            //      assuming that the file was loaded before
            // create a ticker for the time
            // for the sake of the user, reset all the fields so it's blank
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            settingsForm.BringToFront();
        }

        private void strtstp_btn_Click(object sender, EventArgs e)
        {
            if (inProgress)
            {
                // stop -> start
                //  check if everything's good
                //  if it's all good: start
                //  else warn user why and do nothing
            }
            else
            {
                // start -> stop
                //  check if everything's good
                //  if it's all good: stop & save entries to file
                //  else warn user why and do nothing
            }

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
            // set states: redose, substance name, amount, and unit type
            // must be set, not toggle
            if (newdose_chkbx.Checked)
            {
                // unchecked -> checked
                sbstnc_nm_cmbbx.Enabled = true;
                redose_chkbx.Enabled = true;        // check if there is anything to redose, if none, don't enable
                amount_txtbx.Enabled = true;
                msrmnt_unit_cmbbx.Enabled = true;
            }
            else
            {
                // checked -> unchecked
                sbstnc_nm_cmbbx.Enabled = false;
                redose_chkbx.Enabled = false;
                amount_txtbx.Enabled = false;
                msrmnt_unit_cmbbx.Enabled = false;

                redose_chkbx.Checked = false;
                sbstnc_nm_cmbbx.Text = "Substance Name";
                amount_txtbx.Text = "Amount";
                msrmnt_unit_cmbbx.Text = "Unit";
            }
        }

        private void redose_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            // disable "substance name" and fill it in with the initial substance
            // and set the items inside the dropdown to previous substances used during
            if (redose_chkbx.Checked)
            {
                // unchecked -> checked
                
                // get last used substance, amount, and units and place in approprate fields
            }
            else
            {
                // checked -> unchecked

                // reset stuff just like newdose_changed()
            }
        }

        private void LoggerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // if logger is in progress (aka taking time)
                if (inProgress && !settings.disableClose)
                {
                    e.Cancel = true;        // don't close yet.
                    closeForm.Show();       // show question window
                    return;
                }
                // assuming the if statement got skipped, means that user disabled close form

                // stop everything and close window

            }
        }

        #region Polish

        private void sbstnc_nm_cmbbx_Leave(object sender, EventArgs e)
        {
            if (sbstnc_nm_cmbbx.Text == "")
                sbstnc_nm_cmbbx.Text = "Substance Name";
        }

        private void sbstnc_nm_cmbbx_Enter(object sender, EventArgs e)
        {
            if(sbstnc_nm_cmbbx.Text == "Substance Name")
                sbstnc_nm_cmbbx.Text = "";
        }

        private void amount_txtbx_Leave(object sender, EventArgs e)
        {
            if (amount_txtbx.Text == "")
                amount_txtbx.Text = "Amount";
        }

        private void amount_txtbx_Enter(object sender, EventArgs e)
        {
            if (amount_txtbx.Text == "Amount")
                amount_txtbx.Text = "";

        }

        private void exprnc_txtbx_Enter(object sender, EventArgs e)
        {
            if (exprnc_txtbx.Text == "User Experience")
                exprnc_txtbx.Text = "";
        }

        private void exprnc_txtbx_Leave(object sender, EventArgs e)
        {
            if (exprnc_txtbx.Text == "")
                exprnc_txtbx.Text = "User Experience";
        }

        private void msrmnt_unit_cmbbx_Enter(object sender, EventArgs e)
        {
            if (msrmnt_unit_cmbbx.Text == "Unit")
                msrmnt_unit_cmbbx.Text = "";
        }

        private void msrmnt_unit_cmbbx_Leave(object sender, EventArgs e)
        {
            if (msrmnt_unit_cmbbx.Text == "")
                msrmnt_unit_cmbbx.Text = "Unit";
        }

        #endregion

    }
}
