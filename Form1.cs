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

             List<After.Model.user> userlist = userBLL.GetModelList("");
             foreach (After.Model.user item in userlist)
             {
                 DataGridViewRow row = new DataGridViewRow();

                 DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                 cell.Value = item.用户;
                 DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                 cell2.Value = item.密码;
                 DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                 cell3.Value = item.权限;
                 row.Cells.Add(cell);
                 row.Cells.Add(cell2);
                 row.Cells.Add(cell3);

                 this.dataGridView1.Rows.Add(row);
             }

             CheckForIllegalCrossThreadCalls = false;
            Jurisdiction();
            genericForm.Firstload();

           
            ctl.setTag(this);
            form1.WindowState = FormWindowState.Normal;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ClassControl ctl = new ClassControl();
            float newX = Form1.form1.Width;
            float newY = Form1.form1.Height;
            ctl.setControls(newX / GenericForm._x, newY / GenericForm._y, this);
          
        }
    }
}
