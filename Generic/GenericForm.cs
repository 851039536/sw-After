using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using After.Generic;
using DBUtility;

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

        private TestitemManager testitem = new TestitemManager();


        /// <summary>
        /// 首次加载初始化
        /// </summary>
        public void Firstload()
        {
            Form1.form1.contextMenuStrip2.Enabled = false;
            Form1.form1.SAVE.Enabled = false;
            Form1.form1.timer1.Interval = 1000;
            Form1.form1.timer1.Enabled = true;
            Form1.form1.label1.Text = Type2.User1; //用户
            Form1.form1.label4.Text = @"注:左边为待选功能，右边为需要测试的功能先锁定再更新保存";
            Form1.form1.label4.ForeColor = Color.Red;
            _x = Form1.form1.Width;
            _y = Form1.form1.Height;
            _x1 = _x;
            _y1 = _y;
        }

        /// <summary>
        /// 加载测试机型
        /// </summary>
        public void Loadcontrol()
        {
            List<string> allstring = alltestitem.QueryJx();
            int i = 0;
            for (int j = 0; j < allstring.Count; j++)
            {
                string y = allstring[j];
                Form1.form1.型号ToolStripMenuItem.DropDownItems.Add(y);
                Form1.form1.listBox3.Items.Add(y);
                Form1.form1.型号ToolStripMenuItem.DropDownItems[i].Click += Tests;
                i++;
            }

            Form1.form1.listBox3.SelectedIndex = 0;

            DisplaylistboxMsg("加载测试机型完成！！！");
        }

        /// <summary>
        /// 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tests(object sender, EventArgs e)
        {
            Form1.form1.listBoxControl2.Visible = true;
            Form1.form1.listBox3.Items.Clear();
            ToolStripItem items = (ToolStripItem) sender;
            Type2.Type1 = Convert.ToString(items);
            TextName(Type2.Type1);
            try
            {
                List<string> miscelist1 = testitem.LoadTestStation(Type2.Type1);
                Form1.form1.comboBox1.Items.Clear();
                for (int i = 0; i < miscelist1.Count; i++)
                {
                    Form1.form1.comboBox1.Items.Add(miscelist1[i]);
                }

                Form1.form1.comboBox1.SelectedIndex = 0;
                // Querycheck(); 自动测试本地修改 暂时废弃
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 加载listBox1参数
        /// </summary>
        /// <param name="name"></param>
        private void TextName(string name)
        {
            Form1.form1.contextMenuStrip2.Enabled = true;
            Form1.form1.listBox3.Items.Add(name + "测试项目");
            // Form1.form1.listBox1.Items.Add(name + "数据");
            Form1.form1.listBox3.SelectedIndex = 0;
        }

        /// <summary>
        /// 加载listBoxControl3测试项目
        /// </summary>
        public void SelectindxChan()
        {
            try
            {
                string _testistBox;
                _testistBox = Convert.ToString(Form1.form1.listBox3.SelectedItem); //单击获取当前选中行的内容
                if (_testistBox != "")
                {
                    Form1.form1.listBoxControl3.Items.Clear();
                    Form1.form1.listBoxControl2.Items.Clear();

                    ComboBox1SelectedIndexChanged();
                    // Querycheck();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SelectindxChanListbox3()
        {
            try
            {
                string _testistBox;
                _testistBox = Convert.ToString(Form1.form1.listBox3.SelectedItem); //单击获取当前选中行的内容
                Type2.Type1 = _testistBox;
                List<string> miscelistS = testitem.QueryStation(Type2.Type1);
                Form1.form1.comboBox1.Items.Clear();
                for (int i = 0; i < miscelistS.Count; i++)
                {
                    Form1.form1.comboBox1.Items.Add(miscelistS[i]);
                }

                Form1.form1.comboBox1.SelectedIndex = 0;
                if (_testistBox != "")
                {
                    Form1.form1.listBoxControl3.Items.Clear();
                    Form1.form1.listBoxControl2.Items.Clear();

                    ComboBox1SelectedIndexChanged();
                    List<string> alllist1 = alltestitem.LoadTestProject(Type2.Type1);
                    for (int i = 0; i < alllist1.Count; i++)
                    {
                        Form1.form1.listBoxControl3.Items.Add(alllist1[i]);
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
        public void ComboBox1SelectedIndexChanged()
        {
            Form1.form1.listBoxControl2.Items.Clear();
            List<string> alllist1 = testitem.GetTestitemProjectList(Type2.Type1, Form1.form1.comboBox1.Text);
            for (int i = 0; i < alllist1.Count; i++)
            {
                Form1.form1.listBoxControl2.Items.Add(alllist1[i]);
            }
        }

        /// <summary>
        /// 增加按钮
        /// </summary>
        public void butAdd()
        {
            string name = Convert.ToString(Form1.form1.listBoxControl3.SelectedItem); //双击击获取当前选中行的内容
            foreach (string item in Form1.form1.listBoxControl2.Items)
            {
                if (name == item)
                {
                    return;
                }
            }

            Form1.form1.listBoxControl2.Items.Add(name);
        }

        /// <summary>
        /// 删除按键
        /// </summary>
        public void butDelete()
        {
            if (Form1.form1.listBoxControl2.SelectedItem != null)
            {
                Form1.form1.listBoxControl2.Items.Remove(Form1.form1.listBoxControl2.SelectedItem);
                if (Form1.form1.listBoxControl2.Items.Count > 0)
                {
                    //默认选中第一行
                    Form1.form1.listBoxControl2.SelectedIndex = 0;
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
            int index = Form1.form1.listBoxControl2.SelectedIndex;
            if (index > 0)
            {
                object item = Form1.form1.listBoxControl2.SelectedItem;
                Form1.form1.listBoxControl2.Items.Remove(item);
                Form1.form1.listBoxControl2.Items.Insert(index - 1, item);
                Form1.form1.listBoxControl2.SelectedIndex = index - 1;
            }
        }

        /// <summary>
        /// 下移按键
        /// </summary>
        public void butDOWN()
        {
            try
            {
                int index = Form1.form1.listBoxControl2.SelectedIndex;
                if (index < Form1.form1.listBoxControl2.Items.Count - 1)
                {
                    object item = Form1.form1.listBoxControl2.SelectedItem;
                    Form1.form1.listBoxControl2.Items.Remove(item);
                    Form1.form1.listBoxControl2.Items.Insert(index + 1, item);
                    Form1.form1.listBoxControl2.SelectedIndex = index + 1;
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
        public void butLock()
        {
            if (_locker)
            {
                Form1.form1.listBoxControl2.Enabled = false;
                Form1.form1.listBoxControl3.Enabled = false;
                Form1.form1.ADD.Enabled = false;
                Form1.form1.DELETE.Enabled = false;
                Form1.form1.UP.Enabled = false;
                Form1.form1.DOWN.Enabled = false;
                Form1.form1.SAVE.Enabled = true;
                Form1.form1.LOCK.Text = @"解除锁定";
                _locker = false;
                Form1.form1.comboBox1.Enabled = false;
            }
            else
            {
                Form1.form1.listBoxControl2.Enabled = true;
                Form1.form1.listBoxControl3.Enabled = true;
                Form1.form1.ADD.Enabled = true;
                Form1.form1.DELETE.Enabled = true;
                Form1.form1.UP.Enabled = true;
                Form1.form1.DOWN.Enabled = true;
                Form1.form1.SAVE.Enabled = false;
                Form1.form1.LOCK.Text = @"锁定";
                _locker = true;
                Form1.form1.comboBox1.Enabled = true;
            }
        }

        /// <summary>
        /// 输出提示
        /// </summary>
        /// <param name="msg"></param>
        public void DisplaylistboxMsg(string msg)
        {
            if (Form1.form1.InvokeRequired)
            {
                Form1.form1.Invoke(new Action<string>(DisplaylistboxMsg), msg);
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    Form1.form1.listBox2.Items.Add("\r\n");
                }
                else
                {
                    Form1.form1.listBox2.Items.Add(string.Format("At {0:hh:mm:ss},{1}", DateTime.Now, msg));
                }

                if (Form1.form1.listBox2.Items.Count > 0) Form1.form1.listBox2.SelectedIndex = Form1.form1.listBox2.Items.Count - 1;
                Application.DoEvents();
            }
        }
    }
}