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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "TE程序管理系统";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(-124, 421);
            this.lblSubText.Text = "TE-SW V1.0";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1250, 788);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "LoginForm";
            this.SubText = "TE-SW V1.0";
            this.Text = "LoginForm";
            this.Title = "TE程序管理系统";
            this.ButtonLoginClick += new System.EventHandler(this.LoginForm_ButtonLoginClick);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.ResumeLayout(false);

		}

		#endregion
	}
}