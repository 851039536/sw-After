
namespace After_Test.Forms.Interface
{
    partial class SwSendData
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextPcba = new Sunny.UI.UITextBox();
            this.uiTextLd = new Sunny.UI.UITextBox();
            this.uiTextDcx = new Sunny.UI.UITextBox();
            this.uiComboGh = new Sunny.UI.UIComboBox();
            this.uiButtonTest = new Sunny.UI.UIButton();
            this.uiComboZb = new Sunny.UI.UIComboBox();
            this.MsgBox = new CCWin.SkinControl.SkinListBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLine1 = new Sunny.UI.UILine();
            this.SuspendLayout();
            // 
            // uiList
            // 
            this.uiList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiList.FormatString = "";
            this.uiList.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiList.Location = new System.Drawing.Point(24, 104);
            this.uiList.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.uiList.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiList.Name = "uiList";
            this.uiList.Padding = new System.Windows.Forms.Padding(3);
            this.uiList.Size = new System.Drawing.Size(181, 304);
            this.uiList.TabIndex = 0;
            this.uiList.Text = "uiListBox1";
            this.uiList.SelectedIndexChanged += new System.EventHandler(this.uiList_SelectedIndexChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(24, 56);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(133, 34);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "SwSendData";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextPcba
            // 
            this.uiTextPcba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextPcba.FillColor = System.Drawing.Color.White;
            this.uiTextPcba.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextPcba.Location = new System.Drawing.Point(248, 216);
            this.uiTextPcba.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.uiTextPcba.Maximum = 2147483647D;
            this.uiTextPcba.Minimum = -2147483648D;
            this.uiTextPcba.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiTextPcba.Name = "uiTextPcba";
            this.uiTextPcba.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uiTextPcba.Size = new System.Drawing.Size(320, 29);
            this.uiTextPcba.TabIndex = 4;
            this.uiTextPcba.Text = "PCBA";
            // 
            // uiTextLd
            // 
            this.uiTextLd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextLd.FillColor = System.Drawing.Color.White;
            this.uiTextLd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextLd.Location = new System.Drawing.Point(248, 272);
            this.uiTextLd.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.uiTextLd.Maximum = 2147483647D;
            this.uiTextLd.Minimum = -2147483648D;
            this.uiTextLd.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiTextLd.Name = "uiTextLd";
            this.uiTextLd.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uiTextLd.Size = new System.Drawing.Size(320, 29);
            this.uiTextLd.TabIndex = 4;
            this.uiTextLd.Text = "镭雕码";
            // 
            // uiTextDcx
            // 
            this.uiTextDcx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextDcx.FillColor = System.Drawing.Color.White;
            this.uiTextDcx.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextDcx.Location = new System.Drawing.Point(248, 328);
            this.uiTextDcx.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.uiTextDcx.Maximum = 2147483647D;
            this.uiTextDcx.Minimum = -2147483648D;
            this.uiTextDcx.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiTextDcx.Name = "uiTextDcx";
            this.uiTextDcx.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.uiTextDcx.Size = new System.Drawing.Size(320, 29);
            this.uiTextDcx.TabIndex = 4;
            this.uiTextDcx.Text = "电池芯";
            // 
            // uiComboGh
            // 
            this.uiComboGh.FillColor = System.Drawing.Color.White;
            this.uiComboGh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboGh.Location = new System.Drawing.Point(248, 104);
            this.uiComboGh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboGh.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboGh.Name = "uiComboGh";
            this.uiComboGh.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboGh.Size = new System.Drawing.Size(144, 29);
            this.uiComboGh.TabIndex = 5;
            this.uiComboGh.Text = "001";
            this.uiComboGh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboGh.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiButtonTest
            // 
            this.uiButtonTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButtonTest.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButtonTest.Location = new System.Drawing.Point(568, 376);
            this.uiButtonTest.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButtonTest.Name = "uiButtonTest";
            this.uiButtonTest.Size = new System.Drawing.Size(84, 35);
            this.uiButtonTest.TabIndex = 6;
            this.uiButtonTest.Text = "Test";
            this.uiButtonTest.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiComboZb
            // 
            this.uiComboZb.FillColor = System.Drawing.Color.White;
            this.uiComboZb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboZb.Location = new System.Drawing.Point(248, 160);
            this.uiComboZb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboZb.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboZb.Name = "uiComboZb";
            this.uiComboZb.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboZb.Size = new System.Drawing.Size(144, 29);
            this.uiComboZb.TabIndex = 6;
            this.uiComboZb.Text = "请选择";
            this.uiComboZb.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MsgBox
            // 
            this.MsgBox.Back = null;
            this.MsgBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.MsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MsgBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MsgBox.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MsgBox.ForeColor = System.Drawing.SystemColors.Info;
            this.MsgBox.FormattingEnabled = true;
            this.MsgBox.Location = new System.Drawing.Point(8, 424);
            this.MsgBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MsgBox.MouseColor = System.Drawing.Color.Black;
            this.MsgBox.Name = "MsgBox";
            this.MsgBox.RowBackColor1 = System.Drawing.Color.Black;
            this.MsgBox.RowBackColor2 = System.Drawing.Color.Black;
            this.MsgBox.SelectedColor = System.Drawing.Color.Black;
            this.MsgBox.Size = new System.Drawing.Size(672, 117);
            this.MsgBox.TabIndex = 91;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(408, 104);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 92;
            this.uiLabel2.Text = "工号";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(408, 160);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 93;
            this.uiLabel3.Text = "站别";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(576, 216);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 94;
            this.uiLabel4.Text = "PCBA";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(576, 272);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 23);
            this.uiLabel5.TabIndex = 95;
            this.uiLabel5.Text = "镭雕码";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(576, 328);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 23);
            this.uiLabel6.TabIndex = 96;
            this.uiLabel6.Text = "电池芯码";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.Location = new System.Drawing.Point(208, 392);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 29);
            this.uiLine1.TabIndex = 97;
            this.uiLine1.Text = "Result";
            // 
            // SwSendData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 546);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.MsgBox);
            this.Controls.Add(this.uiComboZb);
            this.Controls.Add(this.uiButtonTest);
            this.Controls.Add(this.uiComboGh);
            this.Controls.Add(this.uiTextDcx);
            this.Controls.Add(this.uiTextLd);
            this.Controls.Add(this.uiTextPcba);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiList);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SwSendData";
            this.Text = "SwSendData";
            this.Load += new System.EventHandler(this.SwSendData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIListBox uiList;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextPcba;
        private Sunny.UI.UITextBox uiTextLd;
        private Sunny.UI.UITextBox uiTextDcx;
        private Sunny.UI.UIComboBox uiComboGh;
        private Sunny.UI.UIButton uiButtonTest;
        private Sunny.UI.UIComboBox uiComboZb;
        public CCWin.SkinControl.SkinListBox MsgBox;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILine uiLine1;
    }
}