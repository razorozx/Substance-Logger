namespace Substance_Logger.Forms
{
    partial class Close
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qstn_lbl = new System.Windows.Forms.Label();
            this.answer_txtbx = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qstn_lbl
            // 
            this.qstn_lbl.AutoSize = true;
            this.qstn_lbl.Location = new System.Drawing.Point(9, 44);
            this.qstn_lbl.Name = "qstn_lbl";
            this.qstn_lbl.Size = new System.Drawing.Size(99, 13);
            this.qstn_lbl.TabIndex = 0;
            this.qstn_lbl.Text = "Question goes here";
            // 
            // answer_txtbx
            // 
            this.answer_txtbx.Location = new System.Drawing.Point(12, 60);
            this.answer_txtbx.Name = "answer_txtbx";
            this.answer_txtbx.Size = new System.Drawing.Size(276, 20);
            this.answer_txtbx.TabIndex = 1;
            this.answer_txtbx.Text = "User answer goes here";
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(12, 86);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 2;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            // 
            // new_btn
            // 
            this.new_btn.Location = new System.Drawing.Point(204, 86);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(84, 23);
            this.new_btn.TabIndex = 3;
            this.new_btn.Text = "New Question";
            this.new_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The program is still running, answer this question to close!\r\n";
            // 
            // Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.answer_txtbx);
            this.Controls.Add(this.qstn_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Close";
            this.Text = "Close";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label qstn_lbl;
        private System.Windows.Forms.TextBox answer_txtbx;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Label label1;
    }
}