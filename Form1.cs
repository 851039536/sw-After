using After.Generic;
using After_Test.Generic;
using System;
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
        public After.BLL.user userBLL = new After.BLL.user();
        public After.BLL.miscellaneous miscellaneousBLL = new After.BLL.miscellaneous();
        GenericForm genericForm = new GenericForm();

        /// <summary>
        /// 权限
        /// </summary>
        private void Jurisdiction()
        {
            if (After.Generic.Type2.Jurisdiction == 0)
            {
                文件路径配置ToolStripMenuItem.Enabled = false;
                工具ToolStripMenuItem.Enabled = false;
                button1.Enabled = false;
            }
        }
        ClassControl ctl = new ClassControl();
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
            float newX = Form1.form1.Width;
            float newY = Form1.form1.Height;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Type2.Type1 == null)
            {
                MessageBox.Show(@"未选择站别");
            }
            else
            {
                //Buttonshow();
            }
        }
    }
}
