using After.Generic;
using After_Test.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
