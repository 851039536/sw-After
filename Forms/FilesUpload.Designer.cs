﻿namespace After_Test.Forms
{
    partial class FilesUpload
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.User = new CCWin.SkinControl.SkinTextBox();
            this.Pwd = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.登录 = new CCWin.SkinControl.SkinButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.foldertozip = new System.Windows.Forms.TextBox();
            this.zipedfilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(121, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 75);
            this.textBox1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 85;
            this.label3.Text = "上传路径";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 22);
            this.comboBox1.TabIndex = 84;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 24);
            this.button3.TabIndex = 83;
            this.button3.Text = "上传文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 81;
            this.label1.Text = "机型";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(120, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 31);
            this.button1.TabIndex = 80;
            this.button1.Text = "上传";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "E:\\0.HDT0000";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 21);
            this.button4.TabIndex = 92;
            this.button4.Text = "下载路径";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox4.Location = new System.Drawing.Point(688, 440);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 17);
            this.textBox4.TabIndex = 91;
            this.textBox4.Text = "D:\\程序\\HDT608";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(752, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 90;
            this.label2.Text = "下载路径";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(832, 216);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 80);
            this.textBox2.TabIndex = 89;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(800, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 27);
            this.button2.TabIndex = 88;
            this.button2.Text = "下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.DownBack = null;
            this.User.Icon = null;
            this.User.IconIsButton = false;
            this.User.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.User.IsPasswordChat = '\0';
            this.User.IsSystemPasswordChar = false;
            this.User.Lines = new string[] {
        "mech\\ch"};
            this.User.Location = new System.Drawing.Point(832, 104);
            this.User.Margin = new System.Windows.Forms.Padding(0);
            this.User.MaxLength = 32767;
            this.User.MinimumSize = new System.Drawing.Size(28, 28);
            this.User.MouseBack = null;
            this.User.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.User.Multiline = false;
            this.User.Name = "User";
            this.User.NormlBack = null;
            this.User.Padding = new System.Windows.Forms.Padding(5);
            this.User.ReadOnly = false;
            this.User.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User.Size = new System.Drawing.Size(120, 28);
            // 
            // 
            // 
            this.User.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User.SkinTxt.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.User.SkinTxt.Name = "BaseText";
            this.User.SkinTxt.Size = new System.Drawing.Size(110, 17);
            this.User.SkinTxt.TabIndex = 0;
            this.User.SkinTxt.Text = "mech\\ch";
            this.User.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.User.SkinTxt.WaterText = "";
            this.User.TabIndex = 93;
            this.User.Text = "mech\\ch";
            this.User.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.User.WaterText = "";
            this.User.WordWrap = true;
            // 
            // Pwd
            // 
            this.Pwd.BackColor = System.Drawing.Color.Transparent;
            this.Pwd.DownBack = null;
            this.Pwd.Icon = null;
            this.Pwd.IconIsButton = false;
            this.Pwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.Pwd.IsPasswordChat = '*';
            this.Pwd.IsSystemPasswordChar = false;
            this.Pwd.Lines = new string[0];
            this.Pwd.Location = new System.Drawing.Point(832, 144);
            this.Pwd.Margin = new System.Windows.Forms.Padding(0);
            this.Pwd.MaxLength = 32767;
            this.Pwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.Pwd.MouseBack = null;
            this.Pwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.Pwd.Multiline = false;
            this.Pwd.Name = "Pwd";
            this.Pwd.NormlBack = null;
            this.Pwd.Padding = new System.Windows.Forms.Padding(5);
            this.Pwd.ReadOnly = false;
            this.Pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pwd.Size = new System.Drawing.Size(120, 28);
            // 
            // 
            // 
            this.Pwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pwd.SkinTxt.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.Pwd.SkinTxt.Name = "BaseText";
            this.Pwd.SkinTxt.PasswordChar = '*';
            this.Pwd.SkinTxt.Size = new System.Drawing.Size(110, 17);
            this.Pwd.SkinTxt.TabIndex = 0;
            this.Pwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Pwd.SkinTxt.WaterText = "";
            this.Pwd.TabIndex = 94;
            this.Pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Pwd.WaterText = "";
            this.Pwd.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel1.Location = new System.Drawing.Point(752, 112);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(35, 14);
            this.skinLabel1.TabIndex = 95;
            this.skinLabel1.Text = "用户";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel2.Location = new System.Drawing.Point(752, 152);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(35, 14);
            this.skinLabel2.TabIndex = 96;
            this.skinLabel2.Text = "密码";
            // 
            // 登录
            // 
            this.登录.BackColor = System.Drawing.Color.Transparent;
            this.登录.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.登录.DownBack = null;
            this.登录.Location = new System.Drawing.Point(872, 184);
            this.登录.MouseBack = null;
            this.登录.Name = "登录";
            this.登录.NormlBack = null;
            this.登录.Size = new System.Drawing.Size(75, 23);
            this.登录.TabIndex = 97;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = false;
            this.登录.Click += new System.EventHandler(this.登录_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(121, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 17);
            this.textBox3.TabIndex = 82;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(464, 264);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(72, 23);
            this.skinButton1.TabIndex = 98;
            this.skinButton1.Text = "文件压缩";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // foldertozip
            // 
            this.foldertozip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foldertozip.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.foldertozip.Location = new System.Drawing.Point(344, 88);
            this.foldertozip.Multiline = true;
            this.foldertozip.Name = "foldertozip";
            this.foldertozip.Size = new System.Drawing.Size(189, 72);
            this.foldertozip.TabIndex = 99;
            // 
            // zipedfilename
            // 
            this.zipedfilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.zipedfilename.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zipedfilename.Location = new System.Drawing.Point(344, 192);
            this.zipedfilename.Multiline = true;
            this.zipedfilename.Name = "zipedfilename";
            this.zipedfilename.Size = new System.Drawing.Size(189, 56);
            this.zipedfilename.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(360, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 101;
            this.label4.Text = "压缩的文件夹";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(344, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 14);
            this.label5.TabIndex = 102;
            this.label5.Text = "压缩后的路径及文件名称";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(352, 264);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(72, 23);
            this.skinButton2.TabIndex = 103;
            this.skinButton2.Text = "文件解压";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // FilesUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 317);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zipedfilename);
            this.Controls.Add(this.foldertozip);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.登录);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.User);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "FilesUpload";
            this.Text = "FilesUpload";
            this.Load += new System.EventHandler(this.FilesUpload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private CCWin.SkinControl.SkinTextBox User;
        private CCWin.SkinControl.SkinTextBox Pwd;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton 登录;
        public System.Windows.Forms.TextBox textBox3;
        private CCWin.SkinControl.SkinButton skinButton1;
        public System.Windows.Forms.TextBox foldertozip;
        public System.Windows.Forms.TextBox zipedfilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}