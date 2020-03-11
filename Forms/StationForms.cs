using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace After_Test.Forms
{
    public partial class StationForms : Form
    {
        public StationForms(string station)
        {
            InitializeComponent();
            Staiongs = station;
        }
        TestitemManager testitem = new TestitemManager();
        public static string Staiongs;
        private void StationForms_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//对齐

            QueryStaion(Staiongs);

            List<string> data1 =testitem.QueryCobox();
            comboBox1.Items.Clear();
            for (int i = 0; i < data1.Count; i++)
            {
                comboBox1.Items.Add(data1[i]);
            }
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询机型站别
        /// </summary>
        public void QueryStaion(string staion)
        {
            DataTable data = testitem.QueryStaion(staion);
            //dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = data;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staiongs = comboBox1.Text;
            QueryStaion(Staiongs);
         
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string jx = comboBox1.Text;
                string stationt = Station.Text;

                if (jx == "" || stationt == "")
                {
                    MessageBox.Show(@"不能为空");
                    return;
                }
                int iRet= testitem.InstStation(jx,stationt);
              
                if (iRet > 0)
                {
                    MessageBox.Show(@"增加站别成功");
                    comboBox1.Text = "";
                    Station.Text = "";
                }
                else
                {
                    MessageBox.Show(@"插入失败");
                }

                QueryStaion(Staiongs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                        string zb = dataGridView1.Rows[index].Cells["测试站别"].Value.ToString();   //获取单元格列名为‘Id’的值 
                        string jx = dataGridView1.Rows[index].Cells["机型"].Value.ToString();

                        bool test = testitem.DeleteSave(zb, jx);
                        if (test)
                        {
                            QueryStaion(Staiongs);
                        }
                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
