using After.Generic;
using System;
using System.Windows.Forms;
using DBUtility;
using After.Model;
using SqlSugar;
using System.Threading;

namespace After_Test.Forms
{
    public partial class Alltestitem : Form
    {
        public Alltestitem()
        {
            InitializeComponent();
        }
        ClassControl ctl = new ClassControl();
        AlltestitemManager alltestitem = new AlltestitemManager();
        private void Alltestitem_Load(object sender, EventArgs e)
        {
            QueryJX();
            QueryConfig();
            Control();
        }
        float X = 0;
        float Y = 0;
        float x1 = 0;
        float y1 = 0;


        /// <summary>
        /// //加载测试机型
        /// </summary>
        /// <returns></returns>
        public void QueryJX()
        {
            comboBox1.Items.Clear();
            var data = alltestitem.QueryJX();
            for (int i = 0; i < data.Count; i++)
            {
                comboBox1.Items.Add(data[i]);
            }
            comboBox1.SelectedIndex = 0;
        }
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


        public void QueryIfJX()
        {
            var data = alltestitem.alltestitemdb.GetList(it => it.机型 == comboBox1.Text);  //根据条件查询     
            dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = data;
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        public void QueryConfig()
        {
            try
            {
                var data = alltestitem.alltestitemdb.GetList();
                dataGridView1.DoubleBuffered(true);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            QueryConfig();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryIfJX();
        }
        bool _databaseflag = false;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            //if (_databaseflag)
            //{
            //    dataGridView1.ReadOnly = true;
            //    simpleButton1.Text = @"修改";
            //    _databaseflag = false;
            //    修改ToolStripMenuItem.Text = @"修改";
            //}
            //else
            //{
            //    dataGridView1.ReadOnly = false;
            //    dataGridView1.Columns[0].ReadOnly = true;
            //    dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            //    _databaseflag = true;
            //    simpleButton1.Text = @"修改中..";
            //    修改ToolStripMenuItem.Text = @"修改中..";
            //}
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                string assetsId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string assetsId1 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                string value = dataGridView1.CurrentCell.Value.ToString();
                string strcomm = "update alltestitem set " + strcolumn + "='" + value + "'where 机型 = '" + assetsId + "' and 编号='" + assetsId1 + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           int ids= dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ObjToInt();//获取选中行指定列的值
            panel1.Visible = true;
            var data = alltestitem.alltestitemdb.GetById(ids);
              机型.Text = data.机型;
              单位.Text= data.单位;
              数值上限.Text= data.数值上限;
              数值下限.Text= data.数值下限;
              测试项目.Text= data.测试项目;
              编号.Text=data.编号.ToString();
              耳机指令.Text=data.耳机指令;
              id.Text= data.id.ToString();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread.Sleep(1000);
            button1.Enabled = true;
            // 只更新Name列和CreateTime列，其它列不更新，条件id=1
            bool test = alltestitem.alltestitemdb.Update(it => new alltestitem()
            {
                机型= 机型.Text,
                单位 = 单位.Text,
                数值上限=数值上限.Text,
                数值下限= 数值下限.Text,
                测试项目= 测试项目.Text,
                耳机指令=耳机指令.Text ,
        }, it => it.id == Convert.ToInt32(id.Text));
            if (test)
            {
                panel1.Visible = false;
                QueryJX();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ints = alltestitem.Db.Insertable<alltestitem>(new
            {
                    机型 = 机型.Text,
                    单位 = 单位.Text,
                数值上限 = 数值上限.Text,
                数值下限 = 数值下限.Text,
                测试项目 = 测试项目.Text,
                耳机指令 = 耳机指令.Text,
                    编号 = 编号.Text
            }).ExecuteCommand();

            if (ints > 0)
            {
                MessageBox.Show("新增成功");

            }
            QueryIfJX();
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
            Delect();
        }

        private void Delect()
        {

            DialogResult result = MessageBox.Show(@"确定删除吗？", @"删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //删除操作
                    if (dataGridView1.CurrentRow != null)
                    {
                        int index = dataGridView1.CurrentRow.Index;    //取得选中行的索引
                        int id = dataGridView1.Rows[index].Cells["id"].Value.ObjToInt();   //获取单元格列名为‘Id’的值        
                        alltestitem.alltestitemdb.DeleteById(id);//根据主键删除
                    }
                    QueryIfJX();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
