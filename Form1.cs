using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using After.Generic.Generic;
using After_Test.Forms;
using After_Test.Generic;
using CCWin;
using DBUtility;
using After.Model;
using CCWin.SkinControl;
using System.Text;
using System.Threading;
using After_Test.Forms.Interface;

namespace After_Test
{
    public partial class Form1 : Skin_Mac
    {

        public static user nowUser;
        private readonly ClassControl _ctl = new ClassControl();
        private readonly GenericForm _genericForm = new GenericForm();
        public readonly LogsManager logs = new LogsManager();

        public Form1()
        {
            Hide();
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            GenericForm.Form1 = this;
            CheckForIllegalCrossThreadCalls = false;
            _ctl.setTag(this);
            _genericForm.Firstload();
            if (Util.TestMode != 1)
            {
                await Task.Run(Authority);
                LoadLogByDb();
                await _genericForm.GetJxAsync();
            }
            else
            {
                配置ToolStripMenuItem.Enabled = false;
                用户ToolStripMenuItem.Enabled = false;
                帮助ToolStripMenuItem1.Enabled = false;
                config配置ToolStripMenuItem1.Enabled = false;
                功能配置ToolStripMenuItem1.Enabled = false;
                配置ToolStripMenuItem.Enabled = false;
                帮助ToolStripMenuItem1.Enabled = false;
                用户ToolStripMenuItem.Enabled = false;
                StaionType.Enabled = false;
                ContentBox.Enabled = false;
                ADD.Enabled = false;
                DELETE.Enabled = false;
                UP.Enabled = false;
                DOWN.Enabled = false;
                SAVE.Enabled = false;
                StationBox.Enabled = false;
                LOCK.Enabled = false;
            }


            GenericForm.Form1.WindowState = FormWindowState.Normal;

         
        }
        /// <summary>
        /// 用户权限
        /// </summary>
        private void Authority()
        {
            intro.Text = nowUser.name;
            label4.Text = nowUser.用户;
            switch (nowUser.权限)
            {
                case 1:
                    break;
                case 3:
                    uiButton1.Enabled = false;
                    功能配置ToolStripMenuItem1.Enabled = false;
                    config配置ToolStripMenuItem1.Enabled = false;
                    goto case 2;
                case 2:
                    配置ToolStripMenuItem.Enabled = false;
                    用户ToolStripMenuItem.Enabled = false;
                    帮助ToolStripMenuItem1.Enabled = false;
                    break;
            }
        }


        /// <summary>
        /// 更新操作之前的list取值
        /// </summary>
        private void ResetAfterModels()
        {
            afterModels = "";
            foreach (var item in StaionType.Items)
            {
                afterModels += item + ",";
            }
        }


        /// <summary>
        /// 写入日志到数据库
        /// </summary>
        public void LoadLogByDb()
        {
            var list = logs.SelectLogByUid(nowUser.id);
            foreach (var item in list)
            {
                MsgBox.Items.Add(new SkinListBoxItem(item.msg));
            }
            MsgBox.Items.Add(new SkinListBoxItem(""));
            MsgBox.Items.Add(new SkinListBoxItem("-----------\t以上为上次打开程序产生的日志\t-----------"));
            MsgBox.Items.Add(new SkinListBoxItem(""));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ClassControl control = new ClassControl();
            float newX = GenericForm.Form1.Width;
            float newY = GenericForm.Form1.Height;
            control.setControls(newX / GenericForm.x, newY / GenericForm.y, this);
        }

        private async void skinListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            await _genericForm.GetJxData();
            ResetAfterModels();
        }

        public static string afterModels = "";

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genericForm.ComboBoxGetTestItem();
            ResetAfterModels();
        }

        private async void skinListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            await Task.Run(() => _genericForm.ButAdd());
        }

        private void 文件上传ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FilesUpload f = new FilesUpload();
            f.ShowDialog();
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
            _genericForm.SqlBackups(out var result); ;
        }



        private void 数据还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRestore dataRestore = new DataRestore();
            dataRestore.ShowDialog();
        }

        private void StationBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genericForm.ComboBox1SelectedIndexChanged2();
        }

        private async void config配置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.Miscellaneous = 2;
            DateGridviews date = new DateGridviews();
            await Task.Run(() => date.ShowDialog());
        }

        private async void 功能配置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Alltestitem a = new Alltestitem();
            await Task.Run(() => a.ShowDialog());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void skinMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var models = new ModelsForm();
            await Task.Run(() => models.ShowDialog());
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MsgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mEVN盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string path = @".\procedure\LoginMevn\Debug";
            mEVN盘ToolStripMenuItem.Enabled = false;
            Util.ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder("LoginMech-1.exe"), new StringBuilder(""), new StringBuilder(path), 1);
            Thread.Sleep(1000);
            mEVN盘ToolStripMenuItem.Enabled = true;


        }

        private void batteryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Battery battery = new Battery();
            battery.Show();
        }

        private void case接口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwSendData swSend = new SwSendData();
            swSend.Show();
        }

        private void aTE接口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MevnServices _mevn = new MevnServices();
            _mevn.Show();
        }

        private async void uiButton1_Click(object sender, EventArgs e)
        {
            if (Util.jx != null)
            {
                StationForms st = new StationForms(Util.jx);
                await Task.Run(() => st.ShowDialog());
            }
            else
            {
                MessageBox.Show(@"未选择站别");
            }
        }

        private async void ADD_Click_1(object sender, EventArgs e)
        {
            await Task.Run(() => _genericForm.ButAdd());
        }

        private async void DELETE_Click_1(object sender, EventArgs e)
        {
            await Task.Run(() => _genericForm.ButDelete());
        }

        private async void UP_Click_1(object sender, EventArgs e)
        {
            await Task.Run(() => _genericForm.ButUp());
        }

        private async void DOWN_Click_1(object sender, EventArgs e)
        {
            await Task.Run(() => _genericForm.ButDown());
        }

        private async void LOCK_Click_1(object sender, EventArgs e)
        {
            await Task.Run(() => _genericForm.ButLock());
        }

        private void SAVE_Click_1(object sender, EventArgs e)
        {
            _genericForm.SaveStaion();
            ResetAfterModels();
        }

        private void uiComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
              _genericForm.ComboBoxGetTestItem();
            ResetAfterModels();
        }

        private  void uiImageListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  await _genericForm.GetJxData();
            //ResetAfterModels();
        }

        private async void uiListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             await _genericForm.GetJxData();
              ResetAfterModels();
        }

        private async void uiListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            await Task.Run(() => _genericForm.ButAdd());
        }

        private void complexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplexCell cell = new ComplexCell();
            cell.Show();
        }

        private void 电池芯解绑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatteryUnbundle battery = new BatteryUnbundle();
            battery.Show();
        }
    }
}