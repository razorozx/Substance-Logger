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
using System.IO;                    // file IO

namespace Substance_Logger
{
    public partial class LoggerForm : Form
    {
        UserSettings settings;
        Settings settingsForm;
        Forms.Close closeForm;
        List<Entry> entries;
        Timer timer;
        List<string> substances;

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
            closeForm = new Forms.Close(ref settings);
            entries = new List<Entry>();
            substances = new List<string>();

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;                      // set timer to seconds
            timer.Enabled = true;

            settingsForm.Hide();
            closeForm.Hide();

            // load substances into combobox
            foreach (string sub in settings.substances)
                sbstnc_nm_cmbbx.Items.Add(sub);
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

            // refresh stuff
            curTime_lbl.Refresh();
            new_entry_grpBx.Refresh();

            if (settings.fileName != null)
                filename_lbl.Text = "File Name: " + settings.fileName;
            else
                filename_lbl.Text = "File Name: No name set!";

            // refresh combobox
            if (settings.tick_refreshSubList)
                refresh_cmbbox();


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
                if (sub == null)
                    continue;
                else
                    sbstnc_nm_cmbbx.Items.Add(sub);
            }

            sbstnc_nm_cmbbx.Refresh();
            settings.tick_refreshSubList = false;
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
            string nl = Environment.NewLine;
            string lnbreak = "--------------------------------------------------";
            string path = settings.filePath + "\\" + settings.fileName;

            string EntryToString(Entry _entry)
            {
                // simple entry to a single string
                string returnVal = null;
                string dosageStuff = null;
                string experienceStuff = null;

                if (_entry.dose)
                {
                    dosageStuff += nl + "Dosage: " + _entry.dosage.amount + " " + _entry.dosage.chosenUnit + " of " + _entry.dosage.substance + nl;

                    if (_entry.redose)
                        dosageStuff += "Redose of " + _entry.dosage.substance + nl;
                }

                experienceStuff += _entry.entryTime + " (" + _entry.realTime + ") - " + _entry.experience + nl + nl + lnbreak + nl;

                returnVal = dosageStuff + experienceStuff;

                return returnVal;
            }

            // save file under directory + file name
            FileStream file = File.Create(@path);

            string meta = "Recorded on: " + DateTime.Now.ToString() + nl;

            // write meta
            foreach (char character in meta)
            {
                file.WriteByte((byte)character);
            }

            // write entries
            foreach (var entry in entries)
            {
                string print_str = EntryToString(entry);

                foreach (char character in print_str)
                {
                    file.WriteByte((byte)character);
                }
            }

            file.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // check if the entry is the default stuff, if it is, do nothing
            if (sbstnc_nm_cmbbx.Text == "Substance Name" &&
                exprnc_txtbx.Text == "Experience" &&
                sbstnc_nm_cmbbx.Text == "Substance Name")
                return;

            // create and add entry to list
            Entry entry = new Entry();

            entry.entryTime = this.entryTime;
            entry.realTime = DateTime.Now.ToLongTimeString();
            entry.experience = (exprnc_txtbx.Text == "Experience") ? null : exprnc_txtbx.Text;
            entry.dose = newdose_chkbx.Checked;
            entry.redose = redose_chkbx.Checked;
            entry.dosage.substance = (sbstnc_nm_cmbbx.Text == "Substance Name") ? null : sbstnc_nm_cmbbx.Text;
            entry.dosage.chosenUnit = (msrmnt_unit_cmbbx.Text == "Unit") ? null : msrmnt_unit_cmbbx.Text;
            entry.dosage.amount = (amount_txtbx.Text == "Amount") ? null : amount_txtbx.Text;

            entries.Add(entry);

            // refresh fields
            refresh_Experience();
            settings.AddSubstance(entry.dosage.substance);
            refresh_cmbbox();
        }

        private void refresh_Experience()
        {
            string createDose(string info, Entry z)
            {
                // formatting the text for info box
                string nl = Environment.NewLine;
                info = z.entryTime + nl;

                if (z.dose)
                {
                    // Dose: substance
                    info += ((z.dosage.substance == null) ? "" : ("Dose: " + z.dosage.substance + nl));

                    // Redose: Y/N
                    if (z.redose)
                        info += "Redose: " + ((z.redose) ? "Y" : "N") + nl;

                    // Amount: 100 mg(s)
                    info += ((z.dosage.amount == null) ? "" : ("Amount: " + z.dosage.amount + " " + z.dosage.chosenUnit + nl));
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

            // if there was a substance just added, reset fields like we're expecting no substance added in the next entry
            if (i.dosage.substance != null)
                newdose_chkbx.Checked = false;
            exprnc_txtbx.Text = "Experience";
        }

        private void newdose_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            // set states: redose, substance name, amount, and unit type
            // must be set, not toggle
            if (newdose_chkbx.Checked)
            {
                // unchecked -> checked
                sbstnc_nm_cmbbx.Enabled = true;
                redose_chkbx.Enabled = true;
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

            // check if there is anything to redose. if none return, else continue
            if (redose_chkbx.Checked)
            {
                List<string> substances = new List<string>();

                foreach (var entry in entries)
                {
                    substances.Add(entry.dosage.substance);
                }

                if (substances.Count == 0)
                    return;
            }


            sbstnc_nm_cmbbx.Items.Clear();
            if (redose_chkbx.Checked)           // unchecked -> checked
            {
                List<string> substances = new List<string>();

                // place previous entry substances into list
                foreach (var entry in entries)
                {
                    substances.Add(entry.dosage.substance);
                }

                // remove duplicates
                for (int i = 0; i < substances.Count; i++)
                {
                    if (substances[i] == null || substances[i] == "")
                    {
                        substances.RemoveAt(i);
                        continue;
                    }
                    if (i != substances.Count)  // making sure it isn't the end
                    {
                        for (int j = i + 1; j < substances.Count; j++)
                        {
                            if (substances[i] == substances[j])
                                substances.RemoveAt(j);
                        }
                    }
                }

                // add substances to combobox
                foreach (string sub in substances)
                {
                    sbstnc_nm_cmbbx.Items.Add(sub);
                }
            }
            else                                // checked -> unchecked
            {
                // reset substance cmbbx to originally saved substances
                foreach (var sub in settings.substances)
                {
                    if (sub == null)
                        continue;
                    else
                        sbstnc_nm_cmbbx.Items.Add(sub);
                }
            }
            sbstnc_nm_cmbbx.Refresh();
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
                    // close_quit will be modified when close form checks
                    e.Cancel = !settings.close_quit; // inverse because the way e.Cancel works
                }
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
            else
            {
                List<int> removePos = new List<int>();

                // check for any invalid characters (non-digits)
                for (int i = 0; i < amount_txtbx.Text.Length; i++)
                {
                    // check if every character is numerical
                    switch (amount_txtbx.Text[i])
                    {
                        case '0':
                            continue;
                        case '1':
                            continue;
                        case '2':
                            continue;
                        case '3':
                            continue;
                        case '4':
                            continue;
                        case '5':
                            continue;
                        case '6':
                            continue;
                        case '7':
                            continue;
                        case '8':
                            continue;
                        case '9':
                            continue;
                        default:
                            // if alphabetical char found, add to remove list
                            removePos.Add(i);
                            continue;
                    }
                }

                // must go backwards
                for (int i = removePos.Count; i > 0; i--)
                {
                    // remove invalid text
                    amount_txtbx.Text = amount_txtbx.Text.Remove(removePos[i - 1], 1);
                }
            }
        }

        private void amount_txtbx_Enter(object sender, EventArgs e)
        {
            if (amount_txtbx.Text == "Amount")
                amount_txtbx.Text = "";

        }

        private void exprnc_txtbx_Enter(object sender, EventArgs e)
        {
            if (exprnc_txtbx.Text == "Experience")
                exprnc_txtbx.Text = "";
        }

        private void exprnc_txtbx_Leave(object sender, EventArgs e)
        {
            if (exprnc_txtbx.Text == "")
                exprnc_txtbx.Text = "Experience";
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
