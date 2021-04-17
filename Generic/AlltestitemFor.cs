using System;
using System.Threading;
using System.Windows.Forms;
using After.Model;
using After_Test.Forms;
using DBUtility;
using System.Collections.Generic;
using After.Generic.Generic;
using After.Manager.Manager;
using After.Service.Sevice;
using SqlSugar.Extensions;
using System.Threading.Tasks;

namespace After_Test.Generic
{
    public class AlltestitemFor
    {
        private AlltestitemManager alltestitem = new AlltestitemManager();

        ConfigService _configService = new ConfigService();
        ModelsService _modelsService = new ModelsService();
        AlltestitemService _alltestitemService = new AlltestitemService();
        /// <summary>
        /// //加载测试机型
        /// </summary>
        /// <returns></returns>
        public async void LoadJx()
        {
            try
            {
                Alltestitem.Alltest.comboBox1.Items.Clear();
                List<string> data;
                if (Form1.nowUser.权限 == 1)
                {
                    data = await _configService.GetJxAsync();
                }
                else
                {
                    data = await _modelsService.GetJxAsync(Form1.nowUser);
                }

                foreach (var t in data)
                {
                    Alltestitem.Alltest.comboBox1.Items.Add(t);
                }
                Alltestitem.Alltest.comboBox1.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


       

        /// <summary>
        /// 查询alltestitem
        /// </summary>
        public async void GetAll()
        {
            var data = await _alltestitemService.GetAllAsync(Alltestitem.Alltest.comboBox1.Text);
            Alltestitem.Alltest.dataGridView1.DoubleBuffered(true);
            Alltestitem.Alltest.dataGridView1.DataSource = data;

        }

        public LogsManager logManager = new LogsManager();

        /// <summary>
        /// 更新 w：id
        /// </summary>
        public async Task UpdateAlltestitem()
        {
            Alltestitem.Alltest.skinButton6.Enabled = false;
            Thread.Sleep(1000);
            Alltestitem.Alltest.skinButton6.Enabled = true;
            // 只更新Name列和CreateTime列，其它列不更新，条件id=1

            bool test = await alltestitem.Alltestitemdb.UpdateAsync(it => new alltestitem
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
                GenericForm.DisplaylistboxMsg("已更新：" + Alltestitem.Alltest.comboBox1.Text + " 机型测试项：" + Alltestitem.Alltest.id.Text);
                GetAll();

                var beforeModels =
                    "机型:" + Alltestitem.Alltest.机型.Text +
                    ",单位:" + Alltestitem.Alltest.单位.Text +
                    ",数值上限:" + Alltestitem.Alltest.数值上限.Text +
                    ",数值下限:" + Alltestitem.Alltest.数值下限.Text +
                    ",测试项目:" + Alltestitem.Alltest.测试项目.Text +
                    ",耳机指令:" + Alltestitem.Alltest.耳机指令.Text +
                    ",ID:" + Alltestitem.Alltest.id.Text;

                logManager.insertLog(Form1.nowUser, Form1.nowUser.name, afterModels, beforeModels, 2);
                afterModels = beforeModels;
            }
        }

        public string afterModels;

        /// <summary>
        /// 查询所有 w:id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void QueryListIfId(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int ids = Alltestitem.Alltest.dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ObjToInt(); //获取选中行指定列的值
                Alltestitem.Alltest.panel1.Visible = true;
                var data = alltestitem.Alltestitemdb.GetById(ids);
                Alltestitem.Alltest.机型.Text = data.机型;
                Alltestitem.Alltest.单位.Text = data.单位;
                Alltestitem.Alltest.数值上限.Text = data.数值上限;
                Alltestitem.Alltest.数值下限.Text = data.数值下限;
                Alltestitem.Alltest.测试项目.Text = data.测试项目;
                Alltestitem.Alltest.编号.Text = data.编号.ToString();
                Alltestitem.Alltest.耳机指令.Text = data.耳机指令;
                Alltestitem.Alltest.id.Text = data.id.ToString();

                afterModels = "";
                afterModels = "机型:" + data.机型 + ",单位:" + data.单位 + ",数值上限:" + data.数值上限 + ",数值下限:" + data.数值下限 + ",测试项目:" + data.测试项目 + ",耳机指令:" + data.耳机指令 + ",ID:" + data.id;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                GenericForm.DisplaylistboxMsg(ex.Message);
            }
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        public async Task InstAlltestitem()
        {
            int command = await alltestitem.Db.Insertable<alltestitem>(new
            {
                机型 = Alltestitem.Alltest.机型.Text,
                单位 = Alltestitem.Alltest.单位.Text,
                数值上限 = Alltestitem.Alltest.数值上限.Text,
                数值下限 = Alltestitem.Alltest.数值下限.Text,
                测试项目 = Alltestitem.Alltest.测试项目.Text,
                耳机指令 = Alltestitem.Alltest.耳机指令.Text,
                编号 = Alltestitem.Alltest.编号.Text
            }).ExecuteCommandAsync();
            if (command > 0)
            {
                GenericForm.DisplaylistboxMsg("新增成功：" + Alltestitem.Alltest.comboBox1.Text + " 机型测试项：" + Alltestitem.Alltest.测试项目.Text);
            }
            else
            {
                   GenericForm.DisplaylistboxMsg("false");
            }
            GetAll();
        }


        /// <summary>
        /// 删除当前id数据
        /// </summary>
        public async void DelectAlltestitem()
        {
            DialogResult result = MessageBox.Show(@"确定删除吗？", @"删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //删除操作
                if (Alltestitem.Alltest.dataGridView1.CurrentRow != null)
                {
                    int index = Alltestitem.Alltest.dataGridView1.CurrentRow.Index; //取得选中行的索引
                    int id = Alltestitem.Alltest.dataGridView1.Rows[index].Cells["id"].Value.ObjToInt(); //获取单元格列名为‘Id’的值        
                   var deleteById=  await _alltestitemService.DeleteById(id);
                    if (deleteById)
                    {
                         GenericForm.DisplaylistboxMsg("以删除id为：" + id + " 机型测试项");
                    }
                }
                GetAll();

            }
        }
    }
}