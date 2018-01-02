namespace Substance_Logger
{
    partial class LoggerForm
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
            this.settings_btn = new System.Windows.Forms.Button();
            this.strtstp_btn = new System.Windows.Forms.Button();
            this.filename_lbl = new System.Windows.Forms.Label();
            this.curTime_lbl = new System.Windows.Forms.Label();
            this.new_entry_grpBx = new System.Windows.Forms.GroupBox();
            this.exprnc_txtbx = new System.Windows.Forms.TextBox();
            this.amount_txtbx = new System.Windows.Forms.TextBox();
            this.msrmnt_unit_cmbbx = new System.Windows.Forms.ComboBox();
            this.sbstnc_nm_cmbbx = new System.Windows.Forms.ComboBox();
            this.redose_chkbx = new System.Windows.Forms.CheckBox();
            this.newdose_chkbx = new System.Windows.Forms.CheckBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.prev_entry_grpBx = new System.Windows.Forms.GroupBox();
            this.exprnc3_txtbx = new System.Windows.Forms.TextBox();
            this.info3_txtbx = new System.Windows.Forms.TextBox();
            this.exprnc2_txtbx = new System.Windows.Forms.TextBox();
            this.info2_txtbx = new System.Windows.Forms.TextBox();
            this.exprnc1_txtbx = new System.Windows.Forms.TextBox();
            this.info1_txtbx = new System.Windows.Forms.TextBox();
            this.entry_lbl = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            this.new_entry_grpBx.SuspendLayout();
            this.prev_entry_grpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // settings_btn
            // 
            this.settings_btn.Location = new System.Drawing.Point(13, 13);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(75, 23);
            this.settings_btn.TabIndex = 0;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.settings_btn_Click);
            // 
            // strtstp_btn
            // 
            this.strtstp_btn.Location = new System.Drawing.Point(13, 43);
            this.strtstp_btn.Name = "strtstp_btn";
            this.strtstp_btn.Size = new System.Drawing.Size(75, 23);
            this.strtstp_btn.TabIndex = 1;
            this.strtstp_btn.Text = "<Start/Stop> placeholder";
            this.strtstp_btn.UseVisualStyleBackColor = true;
            // 
            // filename_lbl
            // 
            this.filename_lbl.AutoSize = true;
            this.filename_lbl.Location = new System.Drawing.Point(94, 18);
            this.filename_lbl.Name = "filename_lbl";
            this.filename_lbl.Size = new System.Drawing.Size(60, 13);
            this.filename_lbl.TabIndex = 2;
            this.filename_lbl.Text = "File Name: ";
            // 
            // curTime_lbl
            // 
            this.curTime_lbl.AutoSize = true;
            this.curTime_lbl.Location = new System.Drawing.Point(335, 18);
            this.curTime_lbl.Name = "curTime_lbl";
            this.curTime_lbl.Size = new System.Drawing.Size(100, 13);
            this.curTime_lbl.TabIndex = 3;
            this.curTime_lbl.Text = "Current Time (24-hr)";
            // 
            // new_entry_grpBx
            // 
            this.new_entry_grpBx.Controls.Add(this.exprnc_txtbx);
            this.new_entry_grpBx.Controls.Add(this.amount_txtbx);
            this.new_entry_grpBx.Controls.Add(this.msrmnt_unit_cmbbx);
            this.new_entry_grpBx.Controls.Add(this.sbstnc_nm_cmbbx);
            this.new_entry_grpBx.Controls.Add(this.redose_chkbx);
            this.new_entry_grpBx.Controls.Add(this.newdose_chkbx);
            this.new_entry_grpBx.Controls.Add(this.add_btn);
            this.new_entry_grpBx.Location = new System.Drawing.Point(13, 72);
            this.new_entry_grpBx.Name = "new_entry_grpBx";
            this.new_entry_grpBx.Size = new System.Drawing.Size(459, 172);
            this.new_entry_grpBx.TabIndex = 4;
            this.new_entry_grpBx.TabStop = false;
            this.new_entry_grpBx.Text = "New Entry | T+0:00";
            // 
            // exprnc_txtbx
            // 
            this.exprnc_txtbx.Location = new System.Drawing.Point(7, 68);
            this.exprnc_txtbx.Multiline = true;
            this.exprnc_txtbx.Name = "exprnc_txtbx";
            this.exprnc_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exprnc_txtbx.Size = new System.Drawing.Size(446, 98);
            this.exprnc_txtbx.TabIndex = 6;
            this.exprnc_txtbx.Text = "User Experience";
            // 
            // amount_txtbx
            // 
            this.amount_txtbx.Location = new System.Drawing.Point(197, 43);
            this.amount_txtbx.Name = "amount_txtbx";
            this.amount_txtbx.Size = new System.Drawing.Size(175, 20);
            this.amount_txtbx.TabIndex = 5;
            this.amount_txtbx.Text = "Amount";
            // 
            // msrmnt_unit_cmbbx
            // 
            this.msrmnt_unit_cmbbx.FormattingEnabled = true;
            this.msrmnt_unit_cmbbx.Location = new System.Drawing.Point(378, 43);
            this.msrmnt_unit_cmbbx.Name = "msrmnt_unit_cmbbx";
            this.msrmnt_unit_cmbbx.Size = new System.Drawing.Size(75, 21);
            this.msrmnt_unit_cmbbx.TabIndex = 4;
            this.msrmnt_unit_cmbbx.Text = "Unit Type";
            // 
            // sbstnc_nm_cmbbx
            // 
            this.sbstnc_nm_cmbbx.FormattingEnabled = true;
            this.sbstnc_nm_cmbbx.Location = new System.Drawing.Point(197, 16);
            this.sbstnc_nm_cmbbx.Name = "sbstnc_nm_cmbbx";
            this.sbstnc_nm_cmbbx.Size = new System.Drawing.Size(225, 21);
            this.sbstnc_nm_cmbbx.TabIndex = 3;
            this.sbstnc_nm_cmbbx.Text = "Substance Name";
            // 
            // redose_chkbx
            // 
            this.redose_chkbx.AutoSize = true;
            this.redose_chkbx.Location = new System.Drawing.Point(26, 44);
            this.redose_chkbx.Name = "redose_chkbx";
            this.redose_chkbx.Size = new System.Drawing.Size(63, 17);
            this.redose_chkbx.TabIndex = 2;
            this.redose_chkbx.Text = "Redose";
            this.redose_chkbx.UseVisualStyleBackColor = true;
            // 
            // newdose_chkbx
            // 
            this.newdose_chkbx.AutoSize = true;
            this.newdose_chkbx.Location = new System.Drawing.Point(7, 20);
            this.newdose_chkbx.Name = "newdose_chkbx";
            this.newdose_chkbx.Size = new System.Drawing.Size(76, 17);
            this.newdose_chkbx.TabIndex = 1;
            this.newdose_chkbx.Text = "New Dose";
            this.newdose_chkbx.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(430, 16);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(22, 22);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // prev_entry_grpBx
            // 
            this.prev_entry_grpBx.Controls.Add(this.exprnc3_txtbx);
            this.prev_entry_grpBx.Controls.Add(this.info3_txtbx);
            this.prev_entry_grpBx.Controls.Add(this.exprnc2_txtbx);
            this.prev_entry_grpBx.Controls.Add(this.info2_txtbx);
            this.prev_entry_grpBx.Controls.Add(this.exprnc1_txtbx);
            this.prev_entry_grpBx.Controls.Add(this.info1_txtbx);
            this.prev_entry_grpBx.Controls.Add(this.entry_lbl);
            this.prev_entry_grpBx.Controls.Add(this.info_lbl);
            this.prev_entry_grpBx.Location = new System.Drawing.Point(13, 250);
            this.prev_entry_grpBx.Name = "prev_entry_grpBx";
            this.prev_entry_grpBx.Size = new System.Drawing.Size(459, 359);
            this.prev_entry_grpBx.TabIndex = 5;
            this.prev_entry_grpBx.TabStop = false;
            this.prev_entry_grpBx.Text = "Previous Entries";
            // 
            // exprnc3_txtbx
            // 
            this.exprnc3_txtbx.Location = new System.Drawing.Point(149, 249);
            this.exprnc3_txtbx.Multiline = true;
            this.exprnc3_txtbx.Name = "exprnc3_txtbx";
            this.exprnc3_txtbx.ReadOnly = true;
            this.exprnc3_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exprnc3_txtbx.Size = new System.Drawing.Size(304, 100);
            this.exprnc3_txtbx.TabIndex = 7;
            this.exprnc3_txtbx.Text = "Experience";
            // 
            // info3_txtbx
            // 
            this.info3_txtbx.Enabled = false;
            this.info3_txtbx.Location = new System.Drawing.Point(7, 249);
            this.info3_txtbx.Multiline = true;
            this.info3_txtbx.Name = "info3_txtbx";
            this.info3_txtbx.ReadOnly = true;
            this.info3_txtbx.Size = new System.Drawing.Size(120, 58);
            this.info3_txtbx.TabIndex = 6;
            this.info3_txtbx.Text = "T+0:00\r\nDose: Substance\r\nRedose: Y/N\r\nAmount: 1000 mg";
            // 
            // exprnc2_txtbx
            // 
            this.exprnc2_txtbx.Location = new System.Drawing.Point(149, 143);
            this.exprnc2_txtbx.Multiline = true;
            this.exprnc2_txtbx.Name = "exprnc2_txtbx";
            this.exprnc2_txtbx.ReadOnly = true;
            this.exprnc2_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exprnc2_txtbx.Size = new System.Drawing.Size(304, 100);
            this.exprnc2_txtbx.TabIndex = 5;
            this.exprnc2_txtbx.Text = "Experience";
            // 
            // info2_txtbx
            // 
            this.info2_txtbx.Enabled = false;
            this.info2_txtbx.Location = new System.Drawing.Point(7, 143);
            this.info2_txtbx.Multiline = true;
            this.info2_txtbx.Name = "info2_txtbx";
            this.info2_txtbx.ReadOnly = true;
            this.info2_txtbx.Size = new System.Drawing.Size(120, 58);
            this.info2_txtbx.TabIndex = 4;
            this.info2_txtbx.Text = "T+0:30\r\nDose: Substance\r\nRedose: Y/N\r\nAmount: 1000 mg";
            // 
            // exprnc1_txtbx
            // 
            this.exprnc1_txtbx.Location = new System.Drawing.Point(149, 37);
            this.exprnc1_txtbx.Multiline = true;
            this.exprnc1_txtbx.Name = "exprnc1_txtbx";
            this.exprnc1_txtbx.ReadOnly = true;
            this.exprnc1_txtbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exprnc1_txtbx.Size = new System.Drawing.Size(304, 100);
            this.exprnc1_txtbx.TabIndex = 3;
            this.exprnc1_txtbx.Text = "Experience";
            // 
            // info1_txtbx
            // 
            this.info1_txtbx.Enabled = false;
            this.info1_txtbx.Location = new System.Drawing.Point(7, 37);
            this.info1_txtbx.Multiline = true;
            this.info1_txtbx.Name = "info1_txtbx";
            this.info1_txtbx.ReadOnly = true;
            this.info1_txtbx.Size = new System.Drawing.Size(120, 58);
            this.info1_txtbx.TabIndex = 2;
            this.info1_txtbx.Text = "T+1:00\r\nDose: Substance\r\nRedose: Y/N\r\nAmount: 1000 mg";
            // 
            // entry_lbl
            // 
            this.entry_lbl.AutoSize = true;
            this.entry_lbl.Location = new System.Drawing.Point(146, 20);
            this.entry_lbl.Name = "entry_lbl";
            this.entry_lbl.Size = new System.Drawing.Size(31, 13);
            this.entry_lbl.TabIndex = 1;
            this.entry_lbl.Text = "Entry";
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(26, 20);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(25, 13);
            this.info_lbl.TabIndex = 0;
            this.info_lbl.Text = "Info";
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 617);
            this.Controls.Add(this.prev_entry_grpBx);
            this.Controls.Add(this.new_entry_grpBx);
            this.Controls.Add(this.curTime_lbl);
            this.Controls.Add(this.filename_lbl);
            this.Controls.Add(this.strtstp_btn);
            this.Controls.Add(this.settings_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoggerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Substance Logger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closing);
            this.new_entry_grpBx.ResumeLayout(false);
            this.new_entry_grpBx.PerformLayout();
            this.prev_entry_grpBx.ResumeLayout(false);
            this.prev_entry_grpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button strtstp_btn;
        private System.Windows.Forms.Label filename_lbl;
        private System.Windows.Forms.Label curTime_lbl;
        private System.Windows.Forms.GroupBox new_entry_grpBx;
        private System.Windows.Forms.GroupBox prev_entry_grpBx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox amount_txtbx;
        private System.Windows.Forms.ComboBox msrmnt_unit_cmbbx;
        private System.Windows.Forms.ComboBox sbstnc_nm_cmbbx;
        private System.Windows.Forms.CheckBox redose_chkbx;
        private System.Windows.Forms.CheckBox newdose_chkbx;
        private System.Windows.Forms.TextBox exprnc_txtbx;
        private System.Windows.Forms.Label entry_lbl;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.TextBox exprnc1_txtbx;
        private System.Windows.Forms.TextBox info1_txtbx;
        private System.Windows.Forms.TextBox exprnc3_txtbx;
        private System.Windows.Forms.TextBox info3_txtbx;
        private System.Windows.Forms.TextBox exprnc2_txtbx;
        private System.Windows.Forms.TextBox info2_txtbx;
    }
}

