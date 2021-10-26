namespace After_Test.Forms.Interface
{
    partial class BatteryUnbundle
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
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiTextPcba = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiTextDcx = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(379, 70);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 100;
            this.uiLabel4.Text = "PCBA";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextPcba
            // 
            this.uiTextPcba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextPcba.FillColor = System.Drawing.Color.White;
            this.uiTextPcba.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextPcba.Location = new System.Drawing.Point(51, 70);
            this.uiTextPcba.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.uiTextPcba.Maximum = 2147483647D;
            this.uiTextPcba.Minimum = -2147483648D;
            this.uiTextPcba.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiTextPcba.Name = "uiTextPcba";
            this.uiTextPcba.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uiTextPcba.Size = new System.Drawing.Size(320, 29);
            this.uiTextPcba.TabIndex = 99;
            this.uiTextPcba.Text = "\'xxx\'";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(271, 192);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 101;
            this.uiButton1.Text = "解绑";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(51, 192);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 102;
            this.uiButton2.Text = "查询";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(379, 126);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 104;
            this.uiLabel6.Text = "Result";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextDcx
            // 
            this.uiTextDcx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextDcx.FillColor = System.Drawing.Color.White;
            this.uiTextDcx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextDcx.Location = new System.Drawing.Point(51, 126);
            this.uiTextDcx.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.uiTextDcx.Maximum = 2147483647D;
            this.uiTextDcx.Minimum = -2147483648D;
            this.uiTextDcx.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiTextDcx.Name = "uiTextDcx";
            this.uiTextDcx.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uiTextDcx.Size = new System.Drawing.Size(320, 29);
            this.uiTextDcx.TabIndex = 103;
            this.uiTextDcx.Text = "result";
            // 
            // BatteryUnbundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 259);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiTextDcx);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiTextPcba);
            this.Name = "BatteryUnbundle";
            this.Text = "BatteryUnbundle";
            this.Load += new System.EventHandler(this.BatteryUnbundle_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox uiTextDcx;
        public Sunny.UI.UITextBox uiTextPcba;
    }
}