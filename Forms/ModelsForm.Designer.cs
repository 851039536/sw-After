namespace After_Test.Forms {
	partial class ModelsForm {
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
			this.configLen = new System.Windows.Forms.ListBox();
			this.numberList = new System.Windows.Forms.ListBox();
			this.controlBox = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.selectedModel = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// configLen
			// 
			this.configLen.FormattingEnabled = true;
			this.configLen.ItemHeight = 12;
			this.configLen.Location = new System.Drawing.Point(7, 42);
			this.configLen.Name = "configLen";
			this.configLen.Size = new System.Drawing.Size(168, 352);
			this.configLen.TabIndex = 3;
			this.configLen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.configLen_MouseDoubleClick);
			// 
			// numberList
			// 
			this.numberList.FormattingEnabled = true;
			this.numberList.ItemHeight = 12;
			this.numberList.Location = new System.Drawing.Point(398, 137);
			this.numberList.Name = "numberList";
			this.numberList.Size = new System.Drawing.Size(176, 256);
			this.numberList.TabIndex = 5;
			this.numberList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numberList_MouseClick);
			// 
			// controlBox
			// 
			this.controlBox.FormattingEnabled = true;
			this.controlBox.ItemHeight = 12;
			this.controlBox.Location = new System.Drawing.Point(7, 402);
			this.controlBox.Name = "controlBox";
			this.controlBox.Size = new System.Drawing.Size(568, 88);
			this.controlBox.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(191, 42);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(384, 84);
			this.panel1.TabIndex = 7;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(310, 45);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(63, 32);
			this.button6.TabIndex = 5;
			this.button6.Text = "更新";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(310, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(63, 33);
			this.button5.TabIndex = 4;
			this.button5.Text = "锁定";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(234, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(63, 33);
			this.button4.TabIndex = 3;
			this.button4.Text = "下移";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(160, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(63, 33);
			this.button3.TabIndex = 2;
			this.button3.Text = "上移";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(85, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(63, 33);
			this.button2.TabIndex = 1;
			this.button2.Text = "删除";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 33);
			this.button1.TabIndex = 0;
			this.button1.Text = "增加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// selectedModel
			// 
			this.selectedModel.FormattingEnabled = true;
			this.selectedModel.ItemHeight = 12;
			this.selectedModel.Location = new System.Drawing.Point(200, 136);
			this.selectedModel.Name = "selectedModel";
			this.selectedModel.Size = new System.Drawing.Size(176, 256);
			this.selectedModel.TabIndex = 8;
			// 
			// ModelsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 498);
			this.Controls.Add(this.selectedModel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.controlBox);
			this.Controls.Add(this.numberList);
			this.Controls.Add(this.configLen);
			this.Name = "ModelsForm";
			this.Text = "ModelsForm";
			this.Load += new System.EventHandler(this.ModelsForm_Load);
			this.Resize += new System.EventHandler(this.ModelsForm_Resize);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox configLen;
		private System.Windows.Forms.ListBox numberList;
		private System.Windows.Forms.ListBox controlBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox selectedModel;
	}
}