namespace After_Test {
	partial class LoginForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "TE程序管理系统";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Location = new System.Drawing.Point(432, 120);
            this.uiPanel1.Size = new System.Drawing.Size(208, 256);
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(-124, 421);
            this.lblSubText.Text = "TE-SW V1.0";
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiCheckBox1.Location = new System.Drawing.Point(416, 376);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(150, 24);
            this.uiCheckBox1.TabIndex = 9;
            this.uiCheckBox1.Text = "测试模式";
            this.uiCheckBox1.Click += new System.EventHandler(this.uiCheckBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.uiCheckBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1250, 788);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "LoginForm";
            this.SubText = "TE-SW V1.0";
            this.Text = "LoginForm";
            this.Title = "TE程序管理系统";
            this.ButtonLoginClick += new System.EventHandler(this.LoginForm_ButtonLoginClick);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblSubText, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            this.Controls.SetChildIndex(this.uiCheckBox1, 0);
            this.ResumeLayout(false);

		}

        #endregion

        private Sunny.UI.UICheckBox uiCheckBox1;
    }
}