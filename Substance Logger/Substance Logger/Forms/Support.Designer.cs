namespace Substance_Logger.Forms
{
    partial class Support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Support));
            this.message_lbl = new System.Windows.Forms.Label();
            this.donate_grp_bx = new System.Windows.Forms.GroupBox();
            this.BTC_lbl = new System.Windows.Forms.Label();
            this.LTC_lbl = new System.Windows.Forms.Label();
            this.ETH_lbl = new System.Windows.Forms.Label();
            this.paypal_lbl = new System.Windows.Forms.Label();
            this.BTC_txtbx = new System.Windows.Forms.TextBox();
            this.LTC_txtbx = new System.Windows.Forms.TextBox();
            this.paypal_txtbx = new System.Windows.Forms.TextBox();
            this.ETH_txtbx = new System.Windows.Forms.TextBox();
            this.donate_grp_bx.SuspendLayout();
            this.SuspendLayout();
            // 
            // message_lbl
            // 
            this.message_lbl.AutoSize = true;
            this.message_lbl.Location = new System.Drawing.Point(13, 13);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(251, 104);
            this.message_lbl.TabIndex = 0;
            this.message_lbl.Text = resources.GetString("message_lbl.Text");
            // 
            // donate_grp_bx
            // 
            this.donate_grp_bx.Controls.Add(this.paypal_txtbx);
            this.donate_grp_bx.Controls.Add(this.ETH_txtbx);
            this.donate_grp_bx.Controls.Add(this.LTC_txtbx);
            this.donate_grp_bx.Controls.Add(this.BTC_txtbx);
            this.donate_grp_bx.Controls.Add(this.paypal_lbl);
            this.donate_grp_bx.Controls.Add(this.ETH_lbl);
            this.donate_grp_bx.Controls.Add(this.LTC_lbl);
            this.donate_grp_bx.Controls.Add(this.BTC_lbl);
            this.donate_grp_bx.Location = new System.Drawing.Point(16, 132);
            this.donate_grp_bx.Name = "donate_grp_bx";
            this.donate_grp_bx.Size = new System.Drawing.Size(248, 117);
            this.donate_grp_bx.TabIndex = 3;
            this.donate_grp_bx.TabStop = false;
            this.donate_grp_bx.Text = "Donate";
            // 
            // BTC_lbl
            // 
            this.BTC_lbl.AutoSize = true;
            this.BTC_lbl.Location = new System.Drawing.Point(7, 20);
            this.BTC_lbl.Name = "BTC_lbl";
            this.BTC_lbl.Size = new System.Drawing.Size(28, 13);
            this.BTC_lbl.TabIndex = 0;
            this.BTC_lbl.Text = "BTC";
            // 
            // LTC_lbl
            // 
            this.LTC_lbl.AutoSize = true;
            this.LTC_lbl.Location = new System.Drawing.Point(7, 46);
            this.LTC_lbl.Name = "LTC_lbl";
            this.LTC_lbl.Size = new System.Drawing.Size(27, 13);
            this.LTC_lbl.TabIndex = 1;
            this.LTC_lbl.Text = "LTC";
            // 
            // ETH_lbl
            // 
            this.ETH_lbl.AutoSize = true;
            this.ETH_lbl.Location = new System.Drawing.Point(7, 70);
            this.ETH_lbl.Name = "ETH_lbl";
            this.ETH_lbl.Size = new System.Drawing.Size(29, 13);
            this.ETH_lbl.TabIndex = 2;
            this.ETH_lbl.Text = "ETH";
            // 
            // paypal_lbl
            // 
            this.paypal_lbl.AutoSize = true;
            this.paypal_lbl.Location = new System.Drawing.Point(7, 92);
            this.paypal_lbl.Name = "paypal_lbl";
            this.paypal_lbl.Size = new System.Drawing.Size(39, 13);
            this.paypal_lbl.TabIndex = 3;
            this.paypal_lbl.Text = "Paypal";
            // 
            // BTC_txtbx
            // 
            this.BTC_txtbx.Location = new System.Drawing.Point(57, 17);
            this.BTC_txtbx.Name = "BTC_txtbx";
            this.BTC_txtbx.ReadOnly = true;
            this.BTC_txtbx.Size = new System.Drawing.Size(185, 20);
            this.BTC_txtbx.TabIndex = 4;
            this.BTC_txtbx.Text = "12Uq2z47RYWbPEgPwA8wX79gDmmVTMxTV3";
            // 
            // LTC_txtbx
            // 
            this.LTC_txtbx.Location = new System.Drawing.Point(57, 43);
            this.LTC_txtbx.Name = "LTC_txtbx";
            this.LTC_txtbx.ReadOnly = true;
            this.LTC_txtbx.Size = new System.Drawing.Size(185, 20);
            this.LTC_txtbx.TabIndex = 5;
            this.LTC_txtbx.Text = "0xb22da97d17c222592d893116ead2550135da8df0";
            // 
            // paypal_txtbx
            // 
            this.paypal_txtbx.Location = new System.Drawing.Point(57, 89);
            this.paypal_txtbx.Name = "paypal_txtbx";
            this.paypal_txtbx.ReadOnly = true;
            this.paypal_txtbx.Size = new System.Drawing.Size(185, 20);
            this.paypal_txtbx.TabIndex = 7;
            this.paypal_txtbx.Text = "paypal.me/razorozx";
            // 
            // ETH_txtbx
            // 
            this.ETH_txtbx.Location = new System.Drawing.Point(57, 67);
            this.ETH_txtbx.Name = "ETH_txtbx";
            this.ETH_txtbx.ReadOnly = true;
            this.ETH_txtbx.Size = new System.Drawing.Size(185, 20);
            this.ETH_txtbx.TabIndex = 6;
            this.ETH_txtbx.Text = "LXKVZsy79h9acmPDufYv1GLtdMo47rvSDF";
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.donate_grp_bx);
            this.Controls.Add(this.message_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Support";
            this.Text = "Support";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Support_FormClosing);
            this.donate_grp_bx.ResumeLayout(false);
            this.donate_grp_bx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.GroupBox donate_grp_bx;
        private System.Windows.Forms.TextBox paypal_txtbx;
        private System.Windows.Forms.TextBox ETH_txtbx;
        private System.Windows.Forms.TextBox LTC_txtbx;
        private System.Windows.Forms.TextBox BTC_txtbx;
        private System.Windows.Forms.Label paypal_lbl;
        private System.Windows.Forms.Label ETH_lbl;
        private System.Windows.Forms.Label LTC_lbl;
        private System.Windows.Forms.Label BTC_lbl;
    }
}