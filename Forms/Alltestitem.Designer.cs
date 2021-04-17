namespace After_Test.Forms
{
    partial class Alltestitem
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinButton7 = new CCWin.SkinControl.SkinButton();
            this.skinButton6 = new CCWin.SkinControl.SkinButton();
            this.label8 = new System.Windows.Forms.Label();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.编号 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.数值下限 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.数值上限 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.单位 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.耳机指令 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.测试项目 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.机型 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(360, 56);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 26);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 600);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.Silver;
            this.skinButton1.BorderColor = System.Drawing.Color.Silver;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skinButton1.Location = new System.Drawing.Point(8, 45);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(135, 44);
            this.skinButton1.TabIndex = 88;
            this.skinButton1.Text = "添加";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.Silver;
            this.skinButton2.BorderColor = System.Drawing.Color.Silver;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.skinButton2.Location = new System.Drawing.Point(184, 45);
            this.skinButton2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(135, 44);
            this.skinButton2.TabIndex = 89;
            this.skinButton2.Text = "删除";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skinButton7);
            this.panel1.Controls.Add(this.skinButton6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.skinButton5);
            this.panel1.Controls.Add(this.编号);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.skinButton4);
            this.panel1.Controls.Add(this.数值下限);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.数值上限);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.单位);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.耳机指令);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.测试项目);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.机型);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.id);
            this.panel1.Location = new System.Drawing.Point(216, 232);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 272);
            this.panel1.TabIndex = 72;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // skinButton7
            // 
            this.skinButton7.BackColor = System.Drawing.Color.Transparent;
            this.skinButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton7.DownBack = null;
            this.skinButton7.Location = new System.Drawing.Point(416, 232);
            this.skinButton7.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton7.MouseBack = null;
            this.skinButton7.Name = "skinButton7";
            this.skinButton7.NormlBack = null;
            this.skinButton7.Size = new System.Drawing.Size(74, 26);
            this.skinButton7.TabIndex = 99;
            this.skinButton7.Text = "退出";
            this.skinButton7.UseVisualStyleBackColor = false;
            this.skinButton7.Click += new System.EventHandler(this.skinButton7_Click);
            // 
            // skinButton6
            // 
            this.skinButton6.BackColor = System.Drawing.Color.Transparent;
            this.skinButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton6.DownBack = null;
            this.skinButton6.Location = new System.Drawing.Point(328, 232);
            this.skinButton6.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton6.MouseBack = null;
            this.skinButton6.Name = "skinButton6";
            this.skinButton6.NormlBack = null;
            this.skinButton6.Size = new System.Drawing.Size(72, 26);
            this.skinButton6.TabIndex = 98;
            this.skinButton6.Text = "更新";
            this.skinButton6.UseVisualStyleBackColor = false;
            this.skinButton6.Click += new System.EventHandler(this.skinButton6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "编号";
            // 
            // skinButton5
            // 
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = null;
            this.skinButton5.Location = new System.Drawing.Point(240, 232);
            this.skinButton5.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton5.MouseBack = null;
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = null;
            this.skinButton5.Size = new System.Drawing.Size(72, 26);
            this.skinButton5.TabIndex = 97;
            this.skinButton5.Text = "添加项目";
            this.skinButton5.UseVisualStyleBackColor = false;
            this.skinButton5.Click += new System.EventHandler(this.skinButton5_Click);
            // 
            // 编号
            // 
            this.编号.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.编号.Location = new System.Drawing.Point(265, 196);
            this.编号.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.编号.Name = "编号";
            this.编号.Size = new System.Drawing.Size(231, 19);
            this.编号.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "数值下限";
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(152, 232);
            this.skinButton4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(72, 26);
            this.skinButton4.TabIndex = 96;
            this.skinButton4.Text = "清空";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // 数值下限
            // 
            this.数值下限.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.数值下限.Location = new System.Drawing.Point(25, 196);
            this.数值下限.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.数值下限.Name = "数值下限";
            this.数值下限.Size = new System.Drawing.Size(183, 19);
            this.数值下限.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "数值上限";
            // 
            // 数值上限
            // 
            this.数值上限.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.数值上限.Location = new System.Drawing.Point(264, 140);
            this.数值上限.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.数值上限.Name = "数值上限";
            this.数值上限.Size = new System.Drawing.Size(232, 19);
            this.数值上限.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "单位";
            // 
            // 单位
            // 
            this.单位.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.单位.Location = new System.Drawing.Point(24, 83);
            this.单位.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.单位.Name = "单位";
            this.单位.Size = new System.Drawing.Size(182, 19);
            this.单位.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "耳机指令";
            // 
            // 耳机指令
            // 
            this.耳机指令.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.耳机指令.Location = new System.Drawing.Point(24, 139);
            this.耳机指令.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.耳机指令.Name = "耳机指令";
            this.耳机指令.Size = new System.Drawing.Size(184, 19);
            this.耳机指令.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "测试项目";
            // 
            // 测试项目
            // 
            this.测试项目.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.测试项目.Location = new System.Drawing.Point(263, 83);
            this.测试项目.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.测试项目.Name = "测试项目";
            this.测试项目.Size = new System.Drawing.Size(233, 19);
            this.测试项目.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "机型";
            // 
            // 机型
            // 
            this.机型.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.机型.Enabled = false;
            this.机型.Location = new System.Drawing.Point(264, 32);
            this.机型.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.机型.Name = "机型";
            this.机型.Size = new System.Drawing.Size(232, 19);
            this.机型.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            // 
            // id
            // 
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(24, 32);
            this.id.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(184, 19);
            this.id.TabIndex = 0;
            // 
            // Alltestitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 700);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Alltestitem";
            this.Text = "Alltestitem";
            this.Load += new System.EventHandler(this.Alltestitem_Load);
            this.Resize += new System.EventHandler(this.Alltestitem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox 编号;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox 数值下限;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox 数值上限;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox 单位;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox 耳机指令;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox 测试项目;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox 机型;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox id;
        private CCWin.SkinControl.SkinButton skinButton7;
        private CCWin.SkinControl.SkinButton skinButton5;
        private CCWin.SkinControl.SkinButton skinButton4;
        public CCWin.SkinControl.SkinButton skinButton6;
    }
}