﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Substance_Logger.Forms
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void Support_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)   // don't close, just hide
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
