namespace Substance_Logger
{
    partial class Settings
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
            this.disable_chkbx = new System.Windows.Forms.CheckBox();
            this.save_txtbx = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.save_lbl = new System.Windows.Forms.Label();
            this.add_lbl = new System.Windows.Forms.Label();
            this.remove_lbl = new System.Windows.Forms.Label();
            this.add_txtbx = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.sbstnc_cmbbx = new System.Windows.Forms.ComboBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disable_chkbx
            // 
            this.disable_chkbx.AutoSize = true;
            this.disable_chkbx.Location = new System.Drawing.Point(13, 13);
            this.disable_chkbx.Name = "disable_chkbx";
            this.disable_chkbx.Size = new System.Drawing.Size(132, 17);
            this.disable_chkbx.TabIndex = 0;
            this.disable_chkbx.Text = "Disable Close Window";
            this.disable_chkbx.UseVisualStyleBackColor = true;
            this.disable_chkbx.MouseHover += new System.EventHandler(this.dsblClose_mouse_hover);
            // 
            // save_txtbx
            // 
            this.save_txtbx.Enabled = false;
            this.save_txtbx.Location = new System.Drawing.Point(85, 128);
            this.save_txtbx.Name = "save_txtbx";
            this.save_txtbx.ReadOnly = true;
            this.save_txtbx.Size = new System.Drawing.Size(202, 20);
            this.save_txtbx.TabIndex = 1;
            this.save_txtbx.Text = "Save Directory";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(292, 127);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(40, 22);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "...";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // save_lbl
            // 
            this.save_lbl.AutoSize = true;
            this.save_lbl.Location = new System.Drawing.Point(12, 132);
            this.save_lbl.Name = "save_lbl";
            this.save_lbl.Size = new System.Drawing.Size(67, 13);
            this.save_lbl.TabIndex = 3;
            this.save_lbl.Text = "Save Folder:";
            // 
            // add_lbl
            // 
            this.add_lbl.AutoSize = true;
            this.add_lbl.Location = new System.Drawing.Point(10, 65);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(86, 13);
            this.add_lbl.TabIndex = 4;
            this.add_lbl.Text = "Add Substance: ";
            // 
            // remove_lbl
            // 
            this.remove_lbl.AutoSize = true;
            this.remove_lbl.Location = new System.Drawing.Point(10, 40);
            this.remove_lbl.Name = "remove_lbl";
            this.remove_lbl.Size = new System.Drawing.Size(107, 13);
            this.remove_lbl.TabIndex = 5;
            this.remove_lbl.Text = "Remove Substance: ";
            // 
            // add_txtbx
            // 
            this.add_txtbx.Location = new System.Drawing.Point(104, 62);
            this.add_txtbx.Name = "add_txtbx";
            this.add_txtbx.Size = new System.Drawing.Size(146, 20);
            this.add_txtbx.TabIndex = 6;
            this.add_txtbx.Text = "Substance Name";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(256, 61);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(63, 22);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // sbstnc_cmbbx
            // 
            this.sbstnc_cmbbx.FormattingEnabled = true;
            this.sbstnc_cmbbx.Location = new System.Drawing.Point(123, 37);
            this.sbstnc_cmbbx.Name = "sbstnc_cmbbx";
            this.sbstnc_cmbbx.Size = new System.Drawing.Size(127, 21);
            this.sbstnc_cmbbx.TabIndex = 8;
            this.sbstnc_cmbbx.Text = "Substance Name";
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(256, 37);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(63, 22);
            this.remove_btn.TabIndex = 9;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 161);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.sbstnc_cmbbx);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.add_txtbx);
            this.Controls.Add(this.remove_lbl);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.save_lbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.save_txtbx);
            this.Controls.Add(this.disable_chkbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox disable_chkbx;
        private System.Windows.Forms.TextBox save_txtbx;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label save_lbl;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.Label remove_lbl;
        private System.Windows.Forms.TextBox add_txtbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ComboBox sbstnc_cmbbx;
        private System.Windows.Forms.Button remove_btn;
    }
}