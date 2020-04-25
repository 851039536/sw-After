namespace After_Test.Forms
{
    partial class StationForms
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
            this.deleteBut = new System.Windows.Forms.Button();
            this.StaionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaBut = new System.Windows.Forms.Button();
            this.Station = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBut
            // 
            this.deleteBut.Location = new System.Drawing.Point(6, 35);
            this.deleteBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBut.Name = "deleteBut";
            this.deleteBut.Size = new System.Drawing.Size(50, 22);
            this.deleteBut.TabIndex = 58;
            this.deleteBut.Text = "删除";
            this.deleteBut.UseVisualStyleBackColor = true;
            this.deleteBut.Click += new System.EventHandler(this.button3_Click);
            // 
            // StaionBox
            // 
            this.StaionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaionBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.StaionBox.FormattingEnabled = true;
            this.StaionBox.Location = new System.Drawing.Point(101, 35);
            this.StaionBox.Margin = new System.Windows.Forms.Padding(2);
            this.StaionBox.Name = "StaionBox";
            this.StaionBox.Size = new System.Drawing.Size(68, 22);
            this.StaionBox.TabIndex = 56;
            this.StaionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "站别";
            // 
            // SaBut
            // 
            this.SaBut.Location = new System.Drawing.Point(280, 35);
            this.SaBut.Margin = new System.Windows.Forms.Padding(2);
            this.SaBut.Name = "SaBut";
            this.SaBut.Size = new System.Drawing.Size(56, 24);
            this.SaBut.TabIndex = 63;
            this.SaBut.Text = "确定";
            this.SaBut.UseVisualStyleBackColor = true;
            this.SaBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // Station
            // 
            this.Station.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Station.Location = new System.Drawing.Point(212, 40);
            this.Station.Margin = new System.Windows.Forms.Padding(2);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(63, 17);
            this.Station.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 59;
            this.label1.Text = "机型";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(328, 264);
            this.dataGridView1.TabIndex = 65;
            // 
            // StationForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 343);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaBut);
            this.Controls.Add(this.Station);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBut);
            this.Controls.Add(this.StaionBox);
            this.Font = new System.Drawing.Font("新細明體", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StationForms";
            this.Text = "站别窗口";
            this.Load += new System.EventHandler(this.StationForms_Load);
            this.Resize += new System.EventHandler(this.StationForms_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button deleteBut;
        public System.Windows.Forms.ComboBox StaionBox;
        public System.Windows.Forms.Button SaBut;
        public System.Windows.Forms.TextBox Station;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}