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
        UserSettings userSettings;

        public Close(ref UserSettings _settings)
        {
            InitializeComponent();
            userSettings = _settings;

            qstn_lbl.Text = close_questions.selected.Item1;
            close_questions.GetRandomQuestion();
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
    }
}
