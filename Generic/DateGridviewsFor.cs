using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using After.Generic;
using After.Manager;
using After.Model;
using After_Test.Forms;
using SqlSugar;

namespace After_Test.Generic
{
    public class DateGridviewsFor
    {
        private configManager config = new configManager();

        /// <summary>
        /// Config机型
        /// </summary>
        public void Cobox()
        {
            var types = config.QueryConfig();
            DateGridviews.Dategridviews.comboBox1.Items.Clear();
            DateGridviews.Dategridviews.comboBox2.Items.Clear();
            for (int i = 0; i < types.Count; i++)
            {
                DateGridviews.Dategridviews.comboBox1.Items.Add(types[i]);
                DateGridviews.Dategridviews.comboBox2.Items.Add(types[i]);
            }

            DateGridviews.Dategridviews.comboBox1.SelectedIndex = 0;
            DateGridviews.Dategridviews.comboBox2.SelectedIndex = 0;
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        public void QueryConfig()
        {
            try
            {
                var data = config.configDb.GetList();
                
                DateGridviews.Dategridviews.skinDataGridView1.DoubleBuffered(true);
                DateGridviews.Dategridviews.skinDataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 删除Config
        /// </summary>
        public void DelectConfig()
        {
            DialogResult result = MessageBox.Show(@"确定删除吗？", @"删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //删除操作
                    if (DateGridviews.Dategridviews.skinDataGridView1.CurrentRow != null)
                    {
                        int index = DateGridviews.Dategridviews.skinDataGridView1.CurrentRow.Index; //取得选中行的索引
                        int id = DateGridviews.Dategridviews.skinDataGridView1.Rows[index].Cells["id"].Value.ObjToInt(); //获取单元格列名为‘Id’的值        
                        config.configDb.DeleteById(id); //根据主键删除
                    }

                    QueryConfig();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 查询数据  条件机型
        /// </summary>
        public void QueryIfJx()
        {
            try
            {
                var data = config.configDb.GetList(c => c.ConfigText == DateGridviews.Dategridviews.comboBox1.Text);
                // MySqlDataAdapter sda = new MySqlDataAdapter("select * from config where ConfigText='" + comboBox1.Text + "'", mysql.conn);//
                DateGridviews.Dategridviews.skinDataGridView1.DoubleBuffered(true);
                DateGridviews.Dategridviews.skinDataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 查询数据  条件机型
        /// </summary>
        public void QueryListIfJX()
        {
            List<config> data = config.configDb.GetList(c => c.ConfigText == DateGridviews.Dategridviews.comboBox2.Text);
            foreach (var data1 in data)
            {
                DateGridviews.Dategridviews.id.Text = data1.id.ToString();
                DateGridviews.Dategridviews.ConfigText.Text = data1.ConfigText;
                DateGridviews.Dategridviews.HPID.Text = data1.HPID;
                DateGridviews.Dategridviews.HVID.Text = data1.HVID;
                DateGridviews.Dategridviews.Music.Text = data1.Music;
                DateGridviews.Dategridviews.NAME.Text = data1.NAME;
                DateGridviews.Dategridviews.Player.Text = data1.Player;
                DateGridviews.Dategridviews.DPID.Text = data1.DPID;
                DateGridviews.Dategridviews.DVID.Text = data1.DVID;
                DateGridviews.Dategridviews.Delay.Text = data1.Delay.ToString();
                DateGridviews.Dategridviews.barcode.Text = data1.barcode.ToString();
                DateGridviews.Dategridviews.count.Text = data1.count.ToString();
                DateGridviews.Dategridviews.testflag.Text = data1.testflag.ToString();
            }
        }

        public void UpdateConfig()
        {
            DateGridviews.Dategridviews.button1.Enabled = false;
            Thread.Sleep(1000);
            DateGridviews.Dategridviews.button1.Enabled = true;
            // 只更新Name列和CreateTime列，其它列不更新，条件id=1
            bool test = config.configDb.Update(it => new config
            {
                ConfigText = DateGridviews.Dategridviews.ConfigText.Text,
                HPID = DateGridviews.Dategridviews.HPID.Text,
                HVID = DateGridviews.Dategridviews.HVID.Text,
                Music = DateGridviews.Dategridviews.Music.Text,
                NAME = DateGridviews.Dategridviews.NAME.Text,
                Player = DateGridviews.Dategridviews.Player.Text,
                DPID = DateGridviews.Dategridviews.DPID.Text,
                DVID = DateGridviews.Dategridviews.DVID.Text,
                Delay = Convert.ToInt32(DateGridviews.Dategridviews.Delay.Text),
                barcode = Convert.ToInt32(DateGridviews.Dategridviews.barcode.Text),
                count = Convert.ToInt32(DateGridviews.Dategridviews.count.Text),
                testflag = Convert.ToInt32(DateGridviews.Dategridviews.testflag.Text)
            }, it => it.id == Convert.ToInt32(DateGridviews.Dategridviews.id.Text));
            if (test)
            {
                MessageBox.Show("成功");
            }
        }


        /// <summary>
        /// 添加机型配置
        /// </summary>
        public void InstConfig()
        {
            int ints = config.Db.Insertable<config>(new
            {
                ConfigText = DateGridviews.Dategridviews.ConfigText.Text,
                HPID = DateGridviews.Dategridviews.HPID.Text,
                HVID = DateGridviews.Dategridviews.HVID.Text,
                Music = DateGridviews.Dategridviews.Music.Text,
                NAME = DateGridviews.Dategridviews.NAME.Text,
                Player = DateGridviews.Dategridviews.Player.Text,
                DPID = DateGridviews.Dategridviews.DPID.Text,
                DVID = DateGridviews.Dategridviews.DVID.Text,
                Delay = Convert.ToInt32(DateGridviews.Dategridviews.Delay.Text),
                barcode = Convert.ToInt32(DateGridviews.Dategridviews.barcode.Text),
                count = Convert.ToInt32(DateGridviews.Dategridviews.count.Text),
                testflag = Convert.ToInt32(DateGridviews.Dategridviews.testflag.Text)
            }).ExecuteCommand();

            if (ints > 0)
            {
                MessageBox.Show("新增成功");
            }
        }
    }
}