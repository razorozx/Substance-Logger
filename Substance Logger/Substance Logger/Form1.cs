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
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();
            // when form is loaded, do checks (ie. does saved directory exist?)
            //      assuming that the file was loaded before
        }

        private void Form_Closing(object sender, FormClosedEventArgs e)
        {
            // if logger is in progress
            // do question closing window
            // (it wouldn't make sense to do the question if they aren't recording)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add entry
        }
    }
}
