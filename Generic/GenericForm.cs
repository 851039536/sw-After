using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using After.Generic.Generic;
using After.Manager.Manager;
using After.Service.Sevice;
using CCWin.SkinControl;
using DBUtility;
using MySql.Data.MySqlClient;

namespace After_Test.Generic
{
    public class GenericForm
    {
        public static float x;
        public static float y;
        public static float x1;
        public static float y1;
        private static LogsManager logs = new LogsManager();
        public static Form1 Form1;
        readonly ModelsService _modelsService = new ModelsService();
        private bool _locker = true;
        private AlltestitemManager alltestitem = new AlltestitemManager();
        private TestitemManager testitem = new TestitemManager();
        TestitemService _testitemService = new TestitemService();
        AlltestitemService _alltestitemService = new AlltestitemService();
        /// <summary>
        /// 首次加载初始化
        /// </summary>
        public void Firstload()
        {
            Form1.SAVE.Enabled = false;
            //GenericForm.form1.label1.Text = Type2.User1; //用户
            Form1.label4.Text = @"注:左边为待选功能，右边为需要测试的功能先锁定再更新保存";
            Form1.label4.ForeColor = Color.Red;
            x = Form1.Width;
            y = Form1.Height;
            x1 = x;
            y1 = y;
        }


        /// <summary>
        /// 加载测试机型
        /// </summary>
        public async Task GetJxAsync()
        {
            var result = await _modelsService.GetJxAsync(Form1.nowUser);
            foreach (var jx in result)
            {
                Form1.TypeNameBox.Items.Add(new SkinListBoxItem(jx));
            }
            Form1.TypeNameBox.SelectedIndex = 0;
        }

        /// <summary>
        /// 加载listBoxControl3测试项目
        /// </summary>
        public void SelectindxChan()
        {
            try
            {
                string _testistBox;
                _testistBox = Convert.ToString(Form1.TypeNameBox.SelectedItem); //单击获取当前选中行的内容
                if (_testistBox != "")
                {
                    Form1.ContentBox.Items.Clear();
                    //GenericForm.form1.listBoxControl2.Items.Clear();
                    ComboBoxGetTestItem();
                    // Querycheck();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 加载站别数据
        /// </summary>
        public async Task GetJxData()
        {
            try
            {
                var jx = Convert.ToString(Form1.TypeNameBox.SelectedItem);
                Type2.jx = jx;
                Form1.StationBox.Items.Clear();
                Form1.StationBox2.Items.Clear();
                //加载站别
                var result = await _testitemService.GetStation(jx);

                foreach (var data in result)
                {
                    Form1.StationBox.Items.Add(data);
                    Form1.StationBox2.Items.Add(new SkinListBoxItem(data));
                }
                Form1.StationBox.SelectedIndex = 0;

                if (jx != "")
                {
                    Form1.ContentBox.Items.Clear();
                    Form1.StaionType.Items.Clear();
                    //查询机型测试项
                    ComboBoxGetTestItem();
                    var result1 = await _alltestitemService.GetJxTestItem(Type2.jx);
                    foreach (var t in result1)
                    {
                        Form1.ContentBox.Items.Add(new SkinListBoxItem(t));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 查询机型测试项
        /// </summary>
        public async void ComboBoxGetTestItem()
        {
            Form1.StaionType.Items.Clear();
            var result = await _testitemService.GetJxTestItem(Type2.jx, Form1.StationBox.Text);
            foreach (var data in result)
            {
                Form1.StaionType.Items.Add(new SkinListBoxItem(data));
            }
        }

        public void ComboBox1SelectedIndexChanged2()
        {
            Form1.StaionType.Items.Clear();
            var alllist1 = testitem.GetTestitemProjectList(Type2.jx, Form1.StationBox2.SelectedItem.ToString());
            foreach (var t in alllist1)
            {
                Form1.StaionType.Items.Add(new SkinListBoxItem(t));
            }
        }

        /// <summary>
        /// 增加按钮
        /// </summary>
        public void ButAdd()
        {
            string listBoxResult = Convert.ToString(Form1.ContentBox.SelectedItem);
            //双击击获取当前选中行的内容
            SkinListBoxItemCollection Items = Form1.StaionType.Items;
            for (int i = 0; i < Items.Count; i++)
            {
                if (listBoxResult == Items[i].ToString())
                {
                    return;
                }
            }

            Form1.StaionType.Items.Add(new SkinListBoxItem(listBoxResult));
        }

        /// <summary>
        /// 删除按键
        /// </summary>
        public void ButDelete()
        {
            int index = Form1.StaionType.SelectedIndex;
            if (Form1.StaionType.SelectedItem != null)
            {
                Form1.StaionType.Items.RemoveAt(index);
                if (Form1.StaionType.Items.Count > 0)
                {
                    //默认选中第一行
                    Form1.StaionType.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show(@"未选中");
            }
        }

        /// <summary>
        /// 上移按键
        /// </summary>
        public void ButUp()
        {
            //int index =GenericForm.form1.listBoxControl2.SelectedIndex;
            //if (index > 0)
            //{
            //    object item =GenericForm.form1.listBoxControl2.SelectedItem;
            //   GenericForm.form1.listBoxControl2.Items.Remove(item);
            //   GenericForm.form1.listBoxControl2.Items.Insert(index - 1, item);
            //   GenericForm.form1.listBoxControl2.SelectedIndex = index - 1;
            //}

            int i = Form1.StaionType.SelectedIndex;
            if (i > 0)
            {
                SkinListBoxItem item = new SkinListBoxItem(Form1.StaionType.SelectedItem.ToString());
                Form1.StaionType.Items.RemoveAt(i);
                Form1.StaionType.Items.Insert(i - 1, item);
                Form1.StaionType.SelectedIndex = i - 1;
            }
        }

        /// <summary>
        /// 下移按键
        /// </summary>
        public void ButDown()
        {
            try
            {
                // int index =GenericForm.form1.listBoxControl2.SelectedIndex;
                // if (index <GenericForm.form1.listBoxControl2.Items.Count - 1)
                // {
                //     object item =GenericForm.form1.listBoxControl2.SelectedItem;
                //    GenericForm.form1.listBoxControl2.Items.Remove(item);
                //    GenericForm.form1.listBoxControl2.Items.Insert(index + 1, item);
                //    GenericForm.form1.listBoxControl2.SelectedIndex = index + 1;
                // }

                int i = Form1.StaionType.SelectedIndex;
                if (i < Form1.StaionType.Items.Count - 1)
                {
                    SkinListBoxItem item = new SkinListBoxItem(Form1.StaionType.SelectedItem.ToString());
                    Form1.StaionType.Items.RemoveAt(i);
                    Form1.StaionType.Items.Insert(i + 1, item);
                    Form1.StaionType.SelectedIndex = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 锁定按钮
        /// </summary>
        public void ButLock()
        {
            if (_locker)
            {
                Form1.StaionType.Enabled = false;
                Form1.ContentBox.Enabled = false;
                Form1.ADD.Enabled = false;
                Form1.DELETE.Enabled = false;
                Form1.UP.Enabled = false;
                Form1.DOWN.Enabled = false;
                Form1.SAVE.Enabled = true;
                Form1.LOCK.Text = @"解除锁定";
                _locker = false;
                Form1.StationBox.Enabled = false;
            }
            else
            {
                Form1.StaionType.Enabled = true;
                Form1.ContentBox.Enabled = true;
                Form1.ADD.Enabled = true;
                Form1.DELETE.Enabled = true;
                Form1.UP.Enabled = true;
                Form1.DOWN.Enabled = true;
                Form1.SAVE.Enabled = false;
                Form1.LOCK.Text = @"锁定";
                _locker = true;
                Form1.StationBox.Enabled = true;
            }
        }


        /// <summary>
        /// 输出提示
        /// </summary>
        /// <param name="msg"></param>
        public static void DisplaylistboxMsg(string msg)
        {
            if (Form1.InvokeRequired)
            {
                Form1.Invoke(new Action<string>(DisplaylistboxMsg), msg);
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    Form1.MsgBox.Items.Add(new SkinListBoxItem("\r\n"));
                }
                else
                {
                    msg = $"{Form1.nowUser.name} At {DateTime.Now:hh:mm:ss},{msg}";


                    string beforeModels = "";
                    foreach (var item in Form1.StaionType.Items)
                    {
                        beforeModels += item + ",";
                    }

                    logs.insertLog(Form1.nowUser, msg, Form1.afterModels, beforeModels, 1);
                    Form1.MsgBox.Items.Add(new SkinListBoxItem(msg));
                }

                if (Form1.MsgBox.Items.Count > 0) Form1.MsgBox.SelectedIndex = Form1.MsgBox.Items.Count - 1;
                Application.DoEvents();
            }
        }


        /// <summary>
        /// 新增站别
        /// </summary>
        public async void SaveStaion()
        {
            if (Form1.StationBox.Text.Equals(""))
            {
                MessageBox.Show(@"站别不能为空");
                return;
            }
            //  bool result = testitem.DeleteSave(Form1.StationBox.Text, Type2.jx);
            bool result = await _testitemService.DeleteAsync(Form1.StationBox.Text, Type2.jx);
            if (result)
            {
                LinkedList<string> ate = new LinkedList<string>();
                SkinListBoxItemCollection items = Form1.StaionType.Items;
                for (int i = 0; i < items.Count; i++)
                {
                    ate.AddLast(items[i].ToString());
                }
                var sqlselect = alltestitem.Sqlselect(Form1.StationBox.Text, Type2.jx, ate);

                if (sqlselect == 1)
                {
                    DisplaylistboxMsg("[" + Form1.nowUser.name + "] -> " + "[站别] -> " + Form1.StationBox.Text + "," + "[机型] -> " + Type2.jx + "," + "已更新");
                }
                else
                {
                    DisplaylistboxMsg("更新失败,站别被删除");
                }
            }
        }


        public void SqlBackups(out DialogResult result)
        {
            MessageBox.Show(@"重要数据谨慎修改", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            result = MessageBox.Show(@"备份路径默认在当前程序下", @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string time1 = DateTime.Now.ToString("d").Replace("/", "-");
                string file = ".//mysql/" + time1 + "_test.sql";
                using (var cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = Type2.conn;
                        Type2.conn.Open();
                        mb.ExportToFile(file);
                        Type2.conn.Close();
                        MessageBox.Show(@"已备份");
                    }
                }
            }
        }
    }
}