
namespace After_Test.Forms.Interface
{
    partial class MevnServices
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
            this.uiList = new Sunny.UI.UIListBox();
            this.describe = new Sunny.UI.UITextBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.parameter = new Sunny.UI.UITextBox();
            this.MsgBox = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiList
            // 
            this.uiList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiList.FormatString = "";
            this.uiList.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiList.Location = new System.Drawing.Point(8, 56);
            this.uiList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiList.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiList.Name = "uiList";
            this.uiList.Padding = new System.Windows.Forms.Padding(2);
            this.uiList.Size = new System.Drawing.Size(320, 464);
            this.uiList.TabIndex = 0;
            this.uiList.Text = "uiList";
            this.uiList.SelectedIndexChanged += new System.EventHandler(this.uiList_SelectedIndexChanged);
            // 
            // describe
            // 
            this.describe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.describe.FillColor = System.Drawing.Color.White;
            this.describe.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.describe.Location = new System.Drawing.Point(344, 56);
            this.describe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.describe.Maximum = 2147483647D;
            this.describe.Minimum = -2147483648D;
            this.describe.MinimumSize = new System.Drawing.Size(1, 1);
            this.describe.Multiline = true;
            this.describe.Name = "describe";
            this.describe.Padding = new System.Windows.Forms.Padding(5);
            this.describe.Size = new System.Drawing.Size(384, 144);
            this.describe.TabIndex = 1;
            this.describe.Text = "uiTextBox1";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(624, 288);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "Text";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // parameter
            // 
            this.parameter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parameter.FillColor = System.Drawing.Color.White;
            this.parameter.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.parameter.Location = new System.Drawing.Point(344, 232);
            this.parameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parameter.Maximum = 2147483647D;
            this.parameter.Minimum = -2147483648D;
            this.parameter.MinimumSize = new System.Drawing.Size(1, 1);
            this.parameter.Name = "parameter";
            this.parameter.Padding = new System.Windows.Forms.Padding(5);
            this.parameter.Size = new System.Drawing.Size(384, 29);
            this.parameter.TabIndex = 3;
            this.parameter.Text = "parameter";
            // 
            // MsgBox
            // 
            this.MsgBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MsgBox.FillColor = System.Drawing.Color.White;
            this.MsgBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MsgBox.Location = new System.Drawing.Point(336, 328);
            this.MsgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MsgBox.Maximum = 2147483647D;
            this.MsgBox.Minimum = -2147483648D;
            this.MsgBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.MsgBox.Multiline = true;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.Padding = new System.Windows.Forms.Padding(5);
            this.MsgBox.Size = new System.Drawing.Size(392, 192);
            this.MsgBox.TabIndex = 2;
            this.MsgBox.Text = "MsgBox";
            // 
            // MevnServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 523);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.parameter);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.uiList);
            this.Name = "MevnServices";
            this.Text = "MevnService";
            this.Load += new System.EventHandler(this.MevnService_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox uiList;
        private Sunny.UI.UITextBox describe;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UITextBox parameter;
        private Sunny.UI.UITextBox MsgBox;
    }
}