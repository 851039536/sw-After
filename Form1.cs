using After.Generic;
using After.Model;
using After_Test.Forms;
using After_Test.Generic;
using DBUtility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }
      
        GenericForm genericForm = new GenericForm();

        /// <summary>
        /// 权限
        /// </summary>
        private void Jurisdiction()
        {
            if (Type2.Jurisdiction == 0)
            {
                文件路径配置ToolStripMenuItem.Enabled = true;
                工具ToolStripMenuItem.Enabled = false;
               // button1.Enabled = false;
            }
        }
        ClassControl ctl = new ClassControl();




        UserManager user = new UserManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Jurisdiction();
            genericForm.Firstload();
            ctl.setTag(this);
            form1.WindowState = FormWindowState.Normal;
            genericForm.Loadcontrol();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ClassControl ctl = new ClassControl();
            float newX = form1.Width;
            float newY = form1.Height;
            ctl.setControls(newX / GenericForm._x, newY / GenericForm._y, this);
          
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.SelectindxChan();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.ComboBox1SelectedIndexChanged();
        }

        /// <summary>
        /// 增加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ADD_Click(object sender, EventArgs e)
        {
            genericForm.butAdd();
        }

        private void listBoxControl3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            genericForm.butAdd();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            genericForm.butDelete();
        }

        private void UP_Click(object sender, EventArgs e)
        {
            genericForm.butUP();
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            genericForm.butDOWN();
        }

        private void LOCK_Click(object sender, EventArgs e)
        {
            genericForm.butLock();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Type2.Type1 == null)
            {
                MessageBox.Show(@"未选择站别");
            }
            else
            {
                StationForms st = new StationForms(Type2.Type1);
                await Task.Run(() => st.ShowDialog());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.SelectindxChanListbox3();
        }
        TestitemManager testitem = new TestitemManager();
        AlltestitemManager alltestitem = new AlltestitemManager();
        private void SAVE_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show(@"站别不能为空");
                return;
            }

            bool test = testitem.DeleteSave(comboBox1.Text, Type2.Type1);
            if (test)
            {
                LinkedList<string> ate = new LinkedList<string>() ;
            int i = 0;
            foreach (string item in listBoxControl2.Items)
            {
                    ate.AddLast(item);
                    i++;
            }
            int zt= alltestitem.Sqlselect(comboBox1.Text, Type2.Type1, ate);
            if (zt==1)
            {
                DisplaylistboxMsg("更新完成");
                   
            }
            else
            {
                DisplaylistboxMsg("更新失败");
            }
            }

            genericForm.SelectindxChanListbox3();
        }

        /// <summary>
        /// 输出提示
        /// </summary>
        /// <param name="msg"></param>
        private void DisplaylistboxMsg(String msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<String>(DisplaylistboxMsg), new Object[] { msg });
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    listBox2.Items.Add("\r\n");
                }
                else
                {
                    listBox2.Items.Add(String.Format("At {0:hh:mm:ss},{1}", DateTime.Now, msg));
                }
                if (listBox2.Items.Count > 0) listBox2.SelectedIndex = listBox2.Items.Count - 1;
                Application.DoEvents();
            }
        }

        private async void 路径配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type2.Miscellaneous = 2;
            DateGridviews date = new DateGridviews();
            await Task.Run(() => date.ShowDialog());
        }
    }
}
