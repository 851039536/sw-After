using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using After.Generic;
using After_Test.Forms;
using DBUtility;

namespace After_Test.Generic
{
    public class StationFor
    {
        private TestitemManager testitem = new TestitemManager();

        /// <summary>
        /// 查询机型和站别
        /// </summary>
        public void QueryStaion(string staion)
        {
            DataTable data = testitem.QueryStaion(staion);
            StationForms.Stationgorms.dataGridView1.DoubleBuffered(true);
            StationForms.Stationgorms.dataGridView1.DataSource = data;
        }

        /// <summary>
        /// 查询站别
        /// </summary>
        public void QueryCobox()
        {
            List<string> data1 = testitem.QueryCobox();
            StationForms.Stationgorms.comboBox1.Items.Clear();
            for (int i = 0; i < data1.Count; i++)
            {
                StationForms.Stationgorms.comboBox1.Items.Add(data1[i]);
            }

            StationForms.Stationgorms.comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// 新增站别
        /// </summary>
        public void IntStaion(string staiongs)
        {
            try
            {
                string jx = StationForms.Stationgorms.comboBox1.Text;
                string stationt = StationForms.Stationgorms.Station.Text;

                if (jx == "" || stationt == "")
                {
                    MessageBox.Show(@"不能为空");
                    return;
                }

                int iRet = testitem.InstStation(jx, stationt);

                if (iRet > 0)
                {
                    MessageBox.Show(@"增加站别成功");
                    StationForms.Stationgorms.comboBox1.Text = "";
                    StationForms.Stationgorms.Station.Text = "";
                }
                else
                {
                    MessageBox.Show(@"插入失败");
                }

                QueryStaion(staiongs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除站别
        /// </summary>
        public void DelectStaion(string staiongs)
        {
            DialogResult result = MessageBox.Show(@"确定删除吗？", @"删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //删除操作
                    if (StationForms.Stationgorms.dataGridView1.CurrentRow != null)
                    {
                        int index = StationForms.Stationgorms.dataGridView1.CurrentRow.Index; //取得选中行的索引
                        string zb = StationForms.Stationgorms.dataGridView1.Rows[index].Cells["测试站别"].Value.ToString(); //获取单元格列名为‘Id’的值 
                        string jx = StationForms.Stationgorms.dataGridView1.Rows[index].Cells["机型"].Value.ToString();

                        bool test = testitem.DeleteSave(zb, jx);
                        if (test)
                        {
                            QueryStaion(staiongs);
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