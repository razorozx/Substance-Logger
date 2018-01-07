﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Substance_Logger.Objects;

namespace Substance_Logger
{
    public partial class Settings : Form
    {
        UserSettings userSettings;
        FolderBrowserDialog filePath;

        public Settings(ref UserSettings _set)
        {
            filePath = new FolderBrowserDialog();
            InitializeComponent();
            userSettings = _set;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            // the following code copied from stack overflow.
            if (e.CloseReason == CloseReason.UserClosing)   // don't close, just hide
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void disable_chkbx_CheckedChanged(object sender, EventArgs e)
        {
            userSettings.disableClose = !userSettings.disableClose;     // toggle
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // add substance
            userSettings.AddSubstance(add_txtbx.Text);
            refresh_cmbbox();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            // remove substance
            userSettings.RemoveSubstance(sbstnc_cmbbx.Text);
            refresh_cmbbox();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            filePath.ShowDialog();
            userSettings.filePath = filePath.SelectedPath;
            save_txtbx.Text = userSettings.filePath;
        }

        private void name_btn_Click(object sender, EventArgs e)
        {
            string name = name_txtbx.Text;

            // is valid name?
            if (name_txtbx.Text.Length < 1 || name_txtbx.Text == "File Name")
            {
                MessageBox.Show("Not a valid file name!");
                return;
            }

            // replace invalid file chars
            foreach (var chara in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(chara, '_');
            }

            name += ".txt";
            userSettings.fileName = name;
        }

        private void refresh_cmbbox()
        {
            // clear cmbbx and readd everything from substance settings
            sbstnc_cmbbx.Items.Clear();

            foreach (var sub in userSettings.substances)
            {
                sbstnc_cmbbx.Items.Add(sub);
            }
        }

        #region Polish

        private void name_txtbx_Enter(object sender, EventArgs e)
        {
            if (name_txtbx.Text == "File Name")
                name_txtbx.Text = "";
        }

        private void name_txtbx_Leave(object sender, EventArgs e)
        {
            if (name_txtbx.Text == "")
                name_txtbx.Text = "File Name";
        }

        private void add_txtbx_Enter(object sender, EventArgs e)
        {
            if (add_txtbx.Text == "Substance Name")
                add_txtbx.Text = "";
        }

        private void add_txtbx_Leave(object sender, EventArgs e)
        {
            if (add_txtbx.Text == "")
                add_txtbx.Text = "Substance Name";
        }

        private void sbstnc_cmbbx_Enter(object sender, EventArgs e)
        {
            if (sbstnc_cmbbx.Text == "Substance Name")
                sbstnc_cmbbx.Text = "";
        }

        private void sbstnc_cmbbx_Leave(object sender, EventArgs e)
        {
            if (sbstnc_cmbbx.Text == "")
                sbstnc_cmbbx.Text = "Substance Name";
        }

        #endregion

    }
}
