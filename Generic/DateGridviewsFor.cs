using After.Generic;
using After.Manager;
using After.Model;
using After_Test.Forms;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

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
            DateGridviews.dategridviews.comboBox1.Items.Clear();
            DateGridviews.dategridviews.comboBox2.Items.Clear();
            for (int i = 0; i < types.Count; i++)
            {
                DateGridviews.dategridviews.comboBox1.Items.Add(types[i]);
                DateGridviews.dategridviews.comboBox2.Items.Add(types[i]);

            }
            DateGridviews.dategridviews.comboBox1.SelectedIndex = 0;
            DateGridviews.dategridviews.comboBox2.SelectedIndex = 0;

        }

        /// <summary>
        /// 查询所有
        /// </summary>
        public void QueryConfig()
        {
            try
            {
                var data = config.configDb.GetList();
                DateGridviews.dategridviews.dataGridView1.DoubleBuffered(true);
                DateGridviews.dategridviews.dataGridView1.DataSource = data;
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
                    if (DateGridviews.dategridviews.dataGridView1.CurrentRow != null)
                    {
                        int index = DateGridviews.dategridviews.dataGridView1.CurrentRow.Index;    //取得选中行的索引
                        int id = DateGridviews.dategridviews.dataGridView1.Rows[index].Cells["id"].Value.ObjToInt();   //获取单元格列名为‘Id’的值        
                        config.configDb.DeleteById(id);//根据主键删除
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
                var data = config.configDb.GetList(c => c.ConfigText == DateGridviews.dategridviews.comboBox1.Text);
                // MySqlDataAdapter sda = new MySqlDataAdapter("select * from config where ConfigText='" + comboBox1.Text + "'", mysql.conn);//
                DateGridviews.dategridviews.dataGridView1.DoubleBuffered(true);
                DateGridviews.dategridviews.dataGridView1.DataSource = data;
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
            List<config> data = config.configDb.GetList(c => c.ConfigText == DateGridviews.dategridviews.comboBox2.Text);
            foreach (var data1 in data)
            {
                DateGridviews.dategridviews.id.Text = data1.id.ToString();
                DateGridviews.dategridviews.ConfigText.Text = data1.ConfigText;
                DateGridviews.dategridviews.HPID.Text = data1.HPID;
                DateGridviews.dategridviews.HVID.Text = data1.HVID;
                DateGridviews.dategridviews.Music.Text = data1.Music;
                DateGridviews.dategridviews.NAME.Text = data1.NAME;
                DateGridviews.dategridviews.Player.Text = data1.Player;
                DateGridviews.dategridviews.DPID.Text = data1.DPID;
                DateGridviews.dategridviews.DVID.Text = data1.DVID;
                DateGridviews.dategridviews.Delay.Text = data1.Delay.ToString();
                DateGridviews.dategridviews.barcode.Text = data1.barcode.ToString();
                DateGridviews.dategridviews.count.Text = data1.count.ToString();
                DateGridviews.dategridviews.testflag.Text = data1.testflag.ToString();

            }
        }

        public void UpdateConfig()
        {
            DateGridviews.dategridviews.button1.Enabled = false;
            Thread.Sleep(1000);
            DateGridviews.dategridviews.button1.Enabled = true;
            // 只更新Name列和CreateTime列，其它列不更新，条件id=1
            bool test = config.configDb.Update(it => new config()
            {
                ConfigText = DateGridviews.dategridviews.ConfigText.Text,
                HPID = DateGridviews.dategridviews.HPID.Text,
                HVID = DateGridviews.dategridviews.HVID.Text,
                Music = DateGridviews.dategridviews.Music.Text,
                NAME = DateGridviews.dategridviews.NAME.Text,
                Player = DateGridviews.dategridviews.Player.Text,
                DPID = DateGridviews.dategridviews.DPID.Text,
                DVID = DateGridviews.dategridviews.DVID.Text,
                Delay = Convert.ToInt32(DateGridviews.dategridviews.Delay.Text),
                barcode = Convert.ToInt32(DateGridviews.dategridviews.barcode.Text),
                count = Convert.ToInt32(DateGridviews.dategridviews.count.Text),
                testflag = Convert.ToInt32(DateGridviews.dategridviews.testflag.Text)
            }, it => it.id == Convert.ToInt32(DateGridviews.dategridviews.id.Text));
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
                ConfigText = DateGridviews.dategridviews.ConfigText.Text,
                HPID = DateGridviews.dategridviews.HPID.Text,
                HVID = DateGridviews.dategridviews.HVID.Text,
                Music = DateGridviews.dategridviews.Music.Text,
                NAME = DateGridviews.dategridviews.NAME.Text,
                Player = DateGridviews.dategridviews.Player.Text,
                DPID = DateGridviews.dategridviews.DPID.Text,
                DVID = DateGridviews.dategridviews.DVID.Text,
                Delay = Convert.ToInt32(DateGridviews.dategridviews.Delay.Text),
                barcode = Convert.ToInt32(DateGridviews.dategridviews.barcode.Text),
                count = Convert.ToInt32(DateGridviews.dategridviews.count.Text),
                testflag = Convert.ToInt32(DateGridviews.dategridviews.testflag.Text)
            }).ExecuteCommand();

            if (ints > 0)
            {
                MessageBox.Show("新增成功");

            }
        }
    }
}
