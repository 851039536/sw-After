using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using After.Generic;
using CCWin.SkinControl;
using DBUtility;
using MySql.Data.MySqlClient;
using After.Manager;

namespace After_Test.Generic
{
    public class GenericForm
    {
        public static float _x;
        public static float _y;
        public static float _x1;
        public static float _y1;

        private bool _locker = true;
        private AlltestitemManager alltestitem = new AlltestitemManager();
        private ModelsManager models = new ModelsManager();
        private static LogsManager logs = new LogsManager();
        private TestitemManager testitem = new TestitemManager();
        public static Form1 Form1;

        /// <summary>
        /// 首次加载初始化
        /// </summary>
        public void Firstload()
        {
            Form1.SAVE.Enabled = false;
            //GenericForm.form1.label1.Text = Type2.User1; //用户
            Form1.label4.Text = @"注:左边为待选功能，右边为需要测试的功能先锁定再更新保存";
            Form1.label4.ForeColor = Color.Red;
            _x = Form1.Width;
            _y = Form1.Height;
            _x1 = _x;
            _y1 = _y;
        }

        /// <summary>
        /// 加载测试机型
        /// </summary>
        public void GetModels()
        {
            List<string> model = models.GetJX(Form1.nowUser);
            int i = 0;
            foreach (var y in model)
            {
                Form1.TypeNameBox.Items.Add(new SkinListBoxItem(y));
                i++;
            }
            Form1.TypeNameBox.SelectedIndex = -1;
        }

        /// <summary>
        /// 加载listBoxControl3测试项目
        /// </summary>
        public void SelectindxChan()
        {
            try
            {
                string _testistBox;
                _testistBox = Convert.ToString(GenericForm.Form1.TypeNameBox.SelectedItem); //单击获取当前选中行的内容
                if (_testistBox != "")
                {
                    GenericForm.Form1.ContentBox.Items.Clear();
                    //GenericForm.form1.listBoxControl2.Items.Clear();
                    ComboBox1SelectedIndexChanged();
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
        public void SelectindxChanListbox3()
        {
            try
            {
                string _testistBox;
                _testistBox = Convert.ToString(GenericForm.Form1.TypeNameBox.SelectedItem); //单击获取当前选中行的内容
                Type2.TypeName = _testistBox;
                List<string> miscelistS = testitem.QueryStation(Type2.TypeName);
                GenericForm.Form1.StationBox.Items.Clear();
                GenericForm.Form1.StationBox2.Items.Clear();
                foreach (var t in miscelistS)
                {
                    GenericForm.Form1.StationBox.Items.Add(t);
                    GenericForm.Form1.StationBox2.Items.Add(new SkinListBoxItem(t));
                }

                GenericForm.Form1.StationBox.SelectedIndex = -1;
                //GenericForm.Form1.StationBox.SelectedIndex = -1;
                if (_testistBox != "")
                {
                    GenericForm.Form1.ContentBox.Items.Clear();
                    GenericForm.Form1.StaionType.Items.Clear();

                    ComboBox1SelectedIndexChanged();
                    List<string> alllist1 = alltestitem.LoadTestProject(Type2.TypeName);
                    for (int i = 0; i < alllist1.Count; i++)
                    {
                        GenericForm.Form1.ContentBox.Items.Add(new SkinListBoxItem(alllist1[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// 测试项目  条件（测试站别）
        /// </summary>
        /// 
        public void ComboBox1SelectedIndexChanged()
        {
            GenericForm.Form1.StaionType.Items.Clear();
            List<string> alllist1 = testitem.GetTestitemProjectList(Type2.TypeName, GenericForm.Form1.StationBox.Text);

            for (int i = 0; i < alllist1.Count; i++)
            {

                GenericForm.Form1.StaionType.Items.Add(new SkinListBoxItem(alllist1[i]));
            }
        }
        public void ComboBox1SelectedIndexChanged2()
        {
            GenericForm.Form1.StaionType.Items.Clear();
            List<string> alllist1 = testitem.GetTestitemProjectList(Type2.TypeName, GenericForm.Form1.StationBox2.SelectedItem.ToString());
            for (int i = 0; i < alllist1.Count; i++)
            {
                GenericForm.Form1.StaionType.Items.Add(new SkinListBoxItem(alllist1[i]));
            }
        }

        /// <summary>
        /// 增加按钮
        /// </summary>
        public void butAdd()
        {
            string listBoxControl3 = Convert.ToString(GenericForm.Form1.ContentBox.SelectedItem);

            //双击击获取当前选中行的内容
            SkinListBoxItemCollection ss = GenericForm.Form1.StaionType.Items;

            for (int i = 0; i < ss.Count; i++)
            {
                if (listBoxControl3 == ss[i].ToString())
                {
                    return;
                }
            }
            //foreach (SkinListBoxItemCollection item in ss)
            //{
            //    if (listBoxControl3 == item.ToString())
            //    {
            //        return;
            //    }
            //}

            GenericForm.Form1.StaionType.Items.Add(new SkinListBoxItem(listBoxControl3));
        }

        /// <summary>
        /// 删除按键
        /// </summary>
        public void butDelete()
        {
            int index1 = GenericForm.Form1.StaionType.SelectedIndex;
            if (GenericForm.Form1.StaionType.SelectedItem != null)
            {
                GenericForm.Form1.StaionType.Items.RemoveAt(index1);
                if (GenericForm.Form1.StaionType.Items.Count > 0)
                {
                    //默认选中第一行
                    GenericForm.Form1.StaionType.SelectedIndex = 0;
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
        public void butUP()
        {
            //int index =GenericForm.form1.listBoxControl2.SelectedIndex;
            //if (index > 0)
            //{
            //    object item =GenericForm.form1.listBoxControl2.SelectedItem;
            //   GenericForm.form1.listBoxControl2.Items.Remove(item);
            //   GenericForm.form1.listBoxControl2.Items.Insert(index - 1, item);
            //   GenericForm.form1.listBoxControl2.SelectedIndex = index - 1;
            //}

            int index1 = GenericForm.Form1.StaionType.SelectedIndex;
            if (index1 > 0)
            {
                SkinListBoxItem item = new SkinListBoxItem(GenericForm.Form1.StaionType.SelectedItem.ToString());
                GenericForm.Form1.StaionType.Items.RemoveAt(index1);
                GenericForm.Form1.StaionType.Items.Insert(index1 - 1, item);
                GenericForm.Form1.StaionType.SelectedIndex = index1 - 1;
            }

        }

        /// <summary>
        /// 下移按键
        /// </summary>
        public void butDOWN()
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

                int index1 = GenericForm.Form1.StaionType.SelectedIndex;
                if (index1 < GenericForm.Form1.StaionType.Items.Count - 1)
                {
                    SkinListBoxItem item = new SkinListBoxItem(GenericForm.Form1.StaionType.SelectedItem.ToString());
                    GenericForm.Form1.StaionType.Items.RemoveAt(index1);
                    GenericForm.Form1.StaionType.Items.Insert(index1 + 1, item);
                    GenericForm.Form1.StaionType.SelectedIndex = index1 + 1;
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
                GenericForm.Form1.StaionType.Enabled = false;
                GenericForm.Form1.ContentBox.Enabled = false;
                GenericForm.Form1.ADD.Enabled = false;
                GenericForm.Form1.DELETE.Enabled = false;
                GenericForm.Form1.UP.Enabled = false;
                GenericForm.Form1.DOWN.Enabled = false;
                GenericForm.Form1.SAVE.Enabled = true;
                GenericForm.Form1.LOCK.Text = @"解除锁定";
                _locker = false;
                GenericForm.Form1.StationBox.Enabled = false;
            }
            else
            {
                GenericForm.Form1.StaionType.Enabled = true;
                GenericForm.Form1.ContentBox.Enabled = true;
                GenericForm.Form1.ADD.Enabled = true;
                GenericForm.Form1.DELETE.Enabled = true;
                GenericForm.Form1.UP.Enabled = true;
                GenericForm.Form1.DOWN.Enabled = true;
                GenericForm.Form1.SAVE.Enabled = false;
                GenericForm.Form1.LOCK.Text = @"锁定";
                _locker = true;
                GenericForm.Form1.StationBox.Enabled = true;
            }
        }



        /// <summary>
        /// 输出提示
        /// </summary>
        /// <param name="msg"></param>
        public static void DisplaylistboxMsg(string msg)
        {
            if (GenericForm.Form1.InvokeRequired)
            {
                GenericForm.Form1.Invoke(new Action<string>(DisplaylistboxMsg), msg);
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    GenericForm.Form1.MsgBox.Items.Add(new SkinListBoxItem("\r\n"));
                }
                else
                {
                    msg = string.Format("{0} At {1:hh:mm:ss},{2}", Form1.nowUser.name, DateTime.Now, msg);



                    string beforeModels = "";
                    foreach (var item in Form1.StaionType.Items)
                    {
                        beforeModels += item + ",";
                    }

                    logs.insertLog(Form1.nowUser, msg, Form1.afterModels, beforeModels, 1);
                    GenericForm.Form1.MsgBox.Items.Add(new SkinListBoxItem(msg));
                }

                if (GenericForm.Form1.MsgBox.Items.Count > 0) GenericForm.Form1.MsgBox.SelectedIndex = GenericForm.Form1.MsgBox.Items.Count - 1;
                Application.DoEvents();
            }
        }



        /// <summary>
        /// 新增站别
        /// </summary>
        public void SaveStaion()
        {



            if (GenericForm.Form1.StationBox.Text.Equals(""))
            {
                MessageBox.Show(@"站别不能为空");
                return;
            }

            bool test = testitem.DeleteSave(GenericForm.Form1.StationBox.Text, Type2.TypeName);
            if (test)
            {
                LinkedList<string> ate = new LinkedList<string>();
                SkinListBoxItemCollection ss = GenericForm.Form1.StaionType.Items;

                for (int i = 0; i < ss.Count; i++)
                {
                    ate.AddLast(ss[i].ToString());
                }



                var zt = alltestitem.Sqlselect(GenericForm.Form1.StationBox.Text, Type2.TypeName, ate);
                if (zt == 1)
                {
                    GenericForm.DisplaylistboxMsg("[" + Form1.nowUser.name + "] -> " + "[站别] -> " + GenericForm.Form1.StationBox.Text + "," + "[机型] -> " + Type2.TypeName + "," + "已更新");
                }
                else
                {
                    GenericForm.DisplaylistboxMsg("更新失败,站别被删除");
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
                using (MySqlCommand cmd = new MySqlCommand())
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