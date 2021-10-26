
namespace After_Test.Forms
{
    partial class ComplexCell
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 604);
            this.dataGridView1.TabIndex = 72;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(326, 11);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(102, 32);
            this.uiButton1.TabIndex = 75;
            this.uiButton1.Text = "导出数据";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(15, 13);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(64, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(302, 29);
            this.uiComboBox1.TabIndex = 74;
            this.uiComboBox1.Text = "选择数据表";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(448, 11);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(102, 32);
            this.uiButton2.TabIndex = 76;
            this.uiButton2.Text = "翻页";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton3.Location = new System.Drawing.Point(573, 11);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(133, 32);
            this.uiButton3.TabIndex = 77;
            this.uiButton3.Text = "中文转英文:1.2";
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton4.Location = new System.Drawing.Point(729, 11);
            this.uiButton4.Margin = new System.Windows.Forms.Padding(4);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 2);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Size = new System.Drawing.Size(116, 32);
            this.uiButton4.TabIndex = 78;
            this.uiButton4.Text = "中文转英文:3.1";
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // ComplexCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 666);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComplexCell";
            this.Text = "ComplexCell";
            this.Load += new System.EventHandler(this.ComplexCell_Load);
            this.Resize += new System.EventHandler(this.ComplexCell_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
    }
}