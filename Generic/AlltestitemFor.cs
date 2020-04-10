using System;
using System.Threading;
using System.Windows.Forms;
using After.Generic;
using After.Model;
using After_Test.Forms;
using DBUtility;
using SqlSugar;

namespace After_Test.Generic
{
    public class AlltestitemFor
    {
        private AlltestitemManager alltestitem = new AlltestitemManager();

        /// <summary>
        /// //加载测试机型
        /// </summary>
        /// <returns></returns>
        public void QueryJx()
        {
            try
            {

          
                Alltestitem.Alltest.comboBox1.Items.Clear();
                var data = alltestitem.QueryJx();
                for (int i = 0; i < data.Count; i++)
                {
                    Alltestitem.Alltest.comboBox1.Items.Add(data[i]);
                }

                Alltestitem.Alltest.comboBox1.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                 MessageBox.Show(e.Message);
            }
        }


        /// <summary>
        /// 查询所有
        /// </summary>
        public void QueryConfig()
        {
            try
            {
                var data = alltestitem.alltestitemdb.GetList();
                Alltestitem.Alltest.dataGridView1.DoubleBuffered(true);
                Alltestitem.Alltest.dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询alltestitem 条件 机型
        /// </summary>
        public void QueryIfJx()
        {
            var data = alltestitem.alltestitemdb.GetList(it => it.机型 == Alltestitem.Alltest.comboBox1.Text); //根据条件查询     
            Alltestitem.Alltest.dataGridView1.DoubleBuffered(true);
            Alltestitem.Alltest.dataGridView1.DataSource = data;
        }

        /// <summary>
        /// 更新 w：id
        /// </summary>
        public void UpdateAlltestitem()
        {
            Alltestitem.Alltest.skinButton6.Enabled = false;
            Thread.Sleep(1000);
            Alltestitem.Alltest.skinButton6.Enabled = true;
            // 只更新Name列和CreateTime列，其它列不更新，条件id=1
            bool test = alltestitem.alltestitemdb.Update(it => new alltestitem
            {
                机型 = Alltestitem.Alltest.机型.Text,
                单位 = Alltestitem.Alltest.单位.Text,
                数值上限 = Alltestitem.Alltest.数值上限.Text,
                数值下限 = Alltestitem.Alltest.数值下限.Text,
                测试项目 = Alltestitem.Alltest.测试项目.Text,
                耳机指令 = Alltestitem.Alltest.耳机指令.Text
            }, it => it.id == Convert.ToInt32(Alltestitem.Alltest.id.Text));
            if (test)
            {
                Alltestitem.Alltest.panel1.Visible = false;
                GenericForm.DisplaylistboxMsg("已更新："+ Alltestitem.Alltest.comboBox1.Text+" 机型测试项："+Alltestitem.Alltest.id.Text);
              QueryIfJx();
            }
        }

        /// <summary>
        /// 查询所有 w:id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void QueryListIfId(object sender, DataGridViewCellEventArgs e)
        {
            int ids = Alltestitem.Alltest.dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ObjToInt(); //获取选中行指定列的值
            Alltestitem.Alltest.panel1.Visible = true;
            var data = alltestitem.alltestitemdb.GetById(ids);
            Alltestitem.Alltest.机型.Text = data.机型;
            Alltestitem.Alltest.单位.Text = data.单位;
            Alltestitem.Alltest.数值上限.Text = data.数值上限;
            Alltestitem.Alltest.数值下限.Text = data.数值下限;
            Alltestitem.Alltest.测试项目.Text = data.测试项目;
            Alltestitem.Alltest.编号.Text = data.编号.ToString();
            Alltestitem.Alltest.耳机指令.Text = data.耳机指令;
            Alltestitem.Alltest.id.Text = data.id.ToString();
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        public void InstAlltestitem()
        {
            int ints = alltestitem.Db.Insertable<alltestitem>(new
            {
                机型 = Alltestitem.Alltest.机型.Text,
                单位 = Alltestitem.Alltest.单位.Text,
                数值上限 = Alltestitem.Alltest.数值上限.Text,
                数值下限 = Alltestitem.Alltest.数值下限.Text,
                测试项目 = Alltestitem.Alltest.测试项目.Text,
                耳机指令 = Alltestitem.Alltest.耳机指令.Text,
                编号 = Alltestitem.Alltest.编号.Text
            }).ExecuteCommand();

            if (ints > 0)
            {
                GenericForm.DisplaylistboxMsg("新增成功："+ Alltestitem.Alltest.comboBox1.Text+" 机型测试项："+Alltestitem.Alltest.测试项目.Text);
            }

            QueryIfJx();
        }


        /// <summary>
        /// 删除当前id数据
        /// </summary>
        public void DelectAlltestitem()
        {
            DialogResult result = MessageBox.Show(@"确定删除吗？", @"删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //删除操作
                    if (Alltestitem.Alltest.dataGridView1.CurrentRow != null)
                    {
                        int index = Alltestitem.Alltest.dataGridView1.CurrentRow.Index; //取得选中行的索引
                        int id = Alltestitem.Alltest.dataGridView1.Rows[index].Cells["id"].Value.ObjToInt(); //获取单元格列名为‘Id’的值        
                        alltestitem.alltestitemdb.DeleteById(id); //根据主键删除
                    }

                    QueryIfJx();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}