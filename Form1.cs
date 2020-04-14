using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using After.Generic;
using After_Test.Forms;
using After_Test.Generic;
using CCWin;
using DBUtility;

namespace After_Test
{
    public partial class Form1 : Skin_Mac
    {
        public static Form1 form1;
        private AlltestitemManager alltestitem = new AlltestitemManager();
        private ClassControl ctl = new ClassControl();
        private GenericForm genericForm = new GenericForm();
        private TestitemManager testitem = new TestitemManager();
        private UserManager user = new UserManager();

        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            genericForm.Firstload();
            ctl.setTag(this);
            form1.WindowState = FormWindowState.Normal;

            GenericForm.DisplaylistboxMsg("控件初始化完成！！！");
            genericForm.Loadcontrol();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ClassControl control = new ClassControl();
            float newX = form1.Width;
            float newY = form1.Height;
            control.setControls(newX / GenericForm._x, newY / GenericForm._y, this);
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

        private void SAVE_Click(object sender, EventArgs e)
        {
            genericForm.SaveStaion();
        }

       


        private async void skinButton1_Click(object sender, EventArgs e)
        {
            if (Type2.TypeName != null)
            {
                StationForms st = new StationForms(Type2.TypeName);
                await Task.Run(() => st.ShowDialog());
            }
            else
            {
                MessageBox.Show(@"未选择站别");
            }
        }

        private void skinListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.SelectindxChanListbox3();
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.ComboBox1SelectedIndexChanged();
        }

        private void skinListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            genericForm.butAdd();
        }

        private async void config配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type2.Miscellaneous = 2;
            DateGridviews date = new DateGridviews();
            await Task.Run(() => date.ShowDialog());
        }

        private async void 功能配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alltestitem a = new Alltestitem();
            await Task.Run(() => a.ShowDialog());
        }

        private void 文件上传ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FilesUpload f = new FilesUpload();
            f.ShowDialog();
        }

        private void listBoxControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void 文件配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
              FileConfiguration f = new FileConfiguration();
              f.ShowDialog();
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions instructions = new Instructions();
            instructions.Show();
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genericForm.SqlBackups(out var result);
        }

      

        private void 数据还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         DataRestore dataRestore = new DataRestore();
         dataRestore.ShowDialog();
        
        }
    }
}