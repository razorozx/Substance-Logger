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

            close_questions.GetRandomQuestion();
            qstn_lbl.Text = close_questions.selected.Item1;
            answer_txtbx.Text = "";
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            close_questions.GetRandomQuestion();
            qstn_lbl.Text = close_questions.selected.Item1;
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            if (answer_txtbx.Text == close_questions.selected.Item2)
                Environment.Exit(0);
            else
                MessageBox.Show("Wrong answer");
        }

        private void Close_FormClosing(object sender, FormClosingEventArgs e)
        {
            // don't close the form, just hide it
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }
    }
}
