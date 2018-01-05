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

namespace Substance_Logger.Forms
{
    public partial class Close : Form
    {
        Questions close_questions = new Questions();

        public Close()
        {
            InitializeComponent();
            // reset all text to nothing for a cleaner look
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            // get new questions
            // replace label with question
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            // check if answer is correct
            // if it is, close window and main form
            // if it isn't, give a pop-up to user saying it's wrong
            Environment.Exit(0);        // should force close the application?
        }
    }
}
