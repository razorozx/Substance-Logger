﻿using System;
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
        Timer timer;

        // time elapsed
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        string entryTime;
        bool inProgress = false;                        // is the program recording?

        public LoggerForm()
        {
            InitializeComponent();

            settings = new UserSettings();
            settingsForm = new Settings(ref settings);
            closeForm = new Forms.Close();
            entries = new List<Entry>();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;                 // set timer to seconds
            timer.Enabled = true;

            settingsForm.Hide();
            closeForm.Hide();

            // load substances into combobox
            foreach (string sub in settings.substances)
            {
                sbstnc_nm_cmbbx.Items.Add(sub);
            }

            // when form is loaded, do checks (ie. does saved directory exist?)
            //      assuming that the file was loaded before
            // for the sake of the user, reset all the fields so it's blank
        }

        // ticker
        private void timer_Tick(object sender, EventArgs e)
        {
            // do something for each tick -- in minutes
            if (inProgress)
            {
                // manual time tracking
                seconds++;

                if (seconds >= 60)
                {
                    seconds -= 60;
                    minutes++;
                }
                if (minutes >= 60)
                {
                    minutes -= 60;
                    hours++;
                }

                // special formatting for minutes
                string curMin = "0";
                if (minutes < 10)
                {
                    // single digit number
                    curMin += minutes.ToString();           // ie. 01, 02, ... , 08, 09
                }
                else
                    curMin = minutes.ToString();            // ie. 10, 11, 12, ... , 18, 19, 20

                entryTime = "T+" + hours + ":" + curMin;    // format T+X:XX
                new_entry_grpBx.Text = "New Entry | " + entryTime;
            }

            // set local time
            DateTime localTime = DateTime.Now;
            curTime_lbl.Text = localTime.ToLongTimeString();

            // refresh combobox?
            sbstnc_nm_cmbbx.Refresh();
            refresh_cmbbox();

            // refresh stuff
            curTime_lbl.Refresh();
            new_entry_grpBx.Refresh();

            if (settings.fileName != null)
                filename_lbl.Text = "File Name: " + settings.fileName;
            else
                filename_lbl.Text = "File Name: No name set!";

            // refresh experience
            // refresh combobox (substance list can be altered)
            //      check if redose, if so, use redose list instead (from entry)
            //      if redose, clear cmbbx text and user is forced to pick from list (can't make up own)
        }

        private void refresh_cmbbox()
        {
            // clear cmbbx and readd everything from substance settings
            sbstnc_nm_cmbbx.Items.Clear();

            foreach (var sub in settings.substances)
            {
                sbstnc_nm_cmbbx.Items.Add(sub);
            }
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            settingsForm.BringToFront();
        }

        private void strtstp_btn_Click(object sender, EventArgs e)
        {
            if (inProgress)     // inProgress -> Idle
            {
                save_Work();

                inProgress = false;
                status_lbl.Text = "Status: Idle";
                strtstp_btn.Text = "Start";
                add_btn.Enabled = false;
                status_lbl.ForeColor = Color.Black;

            }
            else                // Idle -> inProgress
            {
                if (settings.fileName == null)
                {
                    MessageBox.Show("No filename set!");
                    return;
                }
                if (settings.filePath == null)
                {
                    MessageBox.Show("No save location set!");
                    return;
                }

                add_btn.Enabled = true;
                inProgress = true;
                status_lbl.Text = "Status: In Progress";
                strtstp_btn.Text = "Stop";
                status_lbl.ForeColor = Color.Red;

                // reset experience boxes
                exprnc1_txtbx.Text = "";
                exprnc2_txtbx.Text = "";
                exprnc3_txtbx.Text = "";
                info1_txtbx.Text = "";
                info2_txtbx.Text = "";
                info3_txtbx.Text = "";
            }

        }

        private void save_Work()
        {
            // save file under directory + file name

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // create and add entry to list
            Entry entry = new Entry();

            entry.entryTime = this.entryTime;
            entry.realTime = DateTime.Now.ToLongTimeString();
            entry.experience = exprnc_txtbx.Text;
            entry.dose = newdose_chkbx.Checked;
            entry.redose = redose_chkbx.Checked;
            entry.dosage.substance = sbstnc_nm_cmbbx.Text;
            entry.dosage.chosenUnit = msrmnt_unit_cmbbx.Text;
            entry.dosage.amount = amount_txtbx.Text;

            entries.Add(entry);

            // refresh fields
            refresh_Experience();
            settings.AddSubstance(sbstnc_nm_cmbbx.Text);
        }

        private void refresh_Experience()
        {
            string createDose(string info, Entry z)
            {
                string nl = Environment.NewLine;
                info = z.entryTime + nl;

                if (z.dose)
                {
                    info += "Dose: " + z.dosage.substance + nl;
                    info += "Redose: " + ((z.redose) ? "Y" : "N") + nl;
                    info += "Amount: " + z.dosage.amount + nl;
                }

                return info;
            }
            // refresh experience boxes with previous experiences
            // reset other fields too
            Entry i;

            i = entries[entries.Count - 1];             // get last created entry
            info1_txtbx.Text = createDose(info1_txtbx.Text, i);
            info1_txtbx.Refresh();

            exprnc1_txtbx.Text = i.experience;
            exprnc1_txtbx.Refresh();

            if (entries.Count > 1)
            {
                i = entries[entries.Count - 2];           // get last created entry - 1
                info2_txtbx.Text = createDose(info2_txtbx.Text, i);
                info2_txtbx.Refresh();

                exprnc2_txtbx.Text = i.experience;
                exprnc2_txtbx.Refresh();
            }
            if (entries.Count > 2)
            {
                i = entries[entries.Count - 3];           // get last created entry - 2
                info3_txtbx.Text = createDose(info3_txtbx.Text, i);
                info3_txtbx.Refresh();

                exprnc3_txtbx.Text = i.experience;
                exprnc3_txtbx.Refresh();
            }

        }

        private void newdose_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            // set states: redose, substance name, amount, and unit type
            // must be set, not toggle
            if (newdose_chkbx.Checked)
            {
                // unchecked -> checked
                sbstnc_nm_cmbbx.Enabled = true;
                redose_chkbx.Enabled = true;            // check if there is anything to redose, if none, don't enable
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

                // get previously used substance, amount, and units and place in approprate fields
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
                if (inProgress && settings.disableClose == false)
                {
                    e.Cancel = true;        // don't close yet.
                    closeForm.Show();       // show question window
                    return;
                }
                // assuming the if statement got skipped, means that user disabled close window

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
            if (sbstnc_nm_cmbbx.Text == "Substance Name")
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
