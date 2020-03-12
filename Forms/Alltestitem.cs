using After.Generic;
using System;
using System.Windows.Forms;
using After_Test.Generic;

namespace After_Test.Forms
{
    public partial class Alltestitem : Form
    {

        public static Alltestitem alltest;
        public Alltestitem()
        {
            InitializeComponent();
            alltest = this;
        }
        AlltestitemFor alltestitemFor = new AlltestitemFor();
        ClassControl ctl = new ClassControl();
        private void Alltestitem_Load(object sender, EventArgs e)
        {
            alltestitemFor.QueryJx();
            alltestitemFor.QueryConfig();
            Control();
        }
        float X = 0;
        float Y = 0;
        float x1 = 0;
        float y1 = 0;


     
        /// <summary>
        /// 初始化
        /// </summary>
        public void Control()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//对齐
            X = Width;
            Y = Height;
            x1 = X;
            y1 = Y;
            
            ctl.setTag(this);
            WindowState = FormWindowState.Normal;
        }

        private void Alltestitem_Resize(object sender, EventArgs e)
        {
            float newX = Width;
            float newY = Height;
            ctl.setControls(newX / X, newY / Y, this);
            foreach (DataGridViewTextBoxColumn item in dataGridView1.Columns)
            {
                item.Width = Convert.ToInt16((item.Width * newX) / x1);
            }
            x1 = newX;
        }

      
       
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            alltestitemFor.QueryConfig();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            alltestitemFor.QueryIfJx();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            alltestitemFor.QueryListIfId(sender,e);
           
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alltestitemFor.UpdateAlltestitem();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alltestitemFor.InstAlltestitem();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            机型.Enabled = true;
           // 机型.Text = "";
            单位.Text = "";
            数值上限.Text = "";
            数值下限.Text = "";
            测试项目.Text="";
            耳机指令.Text = "";
            编号.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           alltestitemFor.DelectAlltestitem();
        }

       
    }
}
