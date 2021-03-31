using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using After.Generic;
using After_Test.Forms;
using After_Test.Generic;
using CCWin;
using DBUtility;
using After.Model;
using After.Manager;
using CCWin.SkinControl;

namespace After_Test {
	public partial class Form1 : Skin_Mac {

		public static user nowUser;
		private AlltestitemManager alltestitem = new AlltestitemManager();
		private ClassControl ctl = new ClassControl();
		private GenericForm genericForm = new GenericForm();
		private TestitemManager testitem = new TestitemManager();
		private UserManager user = new UserManager();
		LogsManager logs = new LogsManager();

		public Form1() {
			this.Hide();
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            GenericForm.Form1 = this;

            intro.Text = nowUser.name;

            if (nowUser == null)
            {
                MessageBox.Show("登录失败，请重新登录");
                Hide();
                new LoginForm().Show();
                return;
            }

            label4.Text = nowUser.用户;

            switch (nowUser.权限)
            {
                case 1:
                    break;
                case 3:
                    skinButton1.Enabled = false;
                    功能配置ToolStripMenuItem1.Enabled = false;
                    config配置ToolStripMenuItem1.Enabled = false;
                    goto case 2;
                case 2:
                    配置ToolStripMenuItem.Enabled = false;
                    用户ToolStripMenuItem.Enabled = false;
                    帮助ToolStripMenuItem1.Enabled = false;
                    break;
            }

            loadLogByDb();

            genericForm.Loadcontrol();

            CheckForIllegalCrossThreadCalls = false;
            genericForm.Firstload();
            ctl.setTag(this);
            GenericForm.Form1.WindowState = FormWindowState.Normal;
            //GenericForm.DisplaylistboxMsg("控件初始化完成！！！");
            //异步执行防止主线程假死
            //await Task.Run(() => genericForm.Loadcontrol(name);
        }


        /// <summary>
        /// 更新操作之前的list取值
        /// </summary>
        public void resetAfterModels() {
			afterModels = "";
			foreach ( var item in StaionType.Items ) {
				afterModels += item.ToString() + ",";
			}
		}


		/// <summary>
		/// 写入日志到数据库
		/// </summary>
		public void loadLogByDb() {
			var list = logs.selectLogByUid(nowUser.id);
			foreach ( var item in list ) {
				MsgBox.Items.Add(new SkinListBoxItem(item.msg));
			}
			MsgBox.Items.Add(new SkinListBoxItem(""));
			MsgBox.Items.Add(new SkinListBoxItem("-----------\t以上为上次打开程序产生的日志\t-----------"));
			MsgBox.Items.Add(new SkinListBoxItem(""));
		}

		private void Form1_Resize(object sender, EventArgs e) {
			ClassControl control = new ClassControl();
			float newX = GenericForm.Form1.Width;
			float newY = GenericForm.Form1.Height;
			control.setControls(newX / GenericForm._x, newY / GenericForm._y, this);
		}

		/// <summary>
		/// 增加按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ADD_Click(object sender, EventArgs e) {
			genericForm.butAdd();

		}

		private void DELETE_Click(object sender, EventArgs e) {
			genericForm.butDelete();
		}

		private void UP_Click(object sender, EventArgs e) {
			genericForm.butUP();
		}

		private void DOWN_Click(object sender, EventArgs e) {
			genericForm.butDOWN();
		}

		private void LOCK_Click(object sender, EventArgs e) {
			genericForm.ButLock();
		}

		private void SAVE_Click(object sender, EventArgs e) {
			genericForm.SaveStaion();
			resetAfterModels();
		}

		private async void skinButton1_Click(object sender, EventArgs e) {
			if ( Type2.TypeName != null ) {
				StationForms st = new StationForms(Type2.TypeName);
				await Task.Run(() => st.ShowDialog());
			}
			else {
				MessageBox.Show(@"未选择站别");
			}
		}

		private void skinListBox3_SelectedIndexChanged(object sender, EventArgs e) {
			genericForm.SelectindxChanListbox3();
			resetAfterModels();
		}

		public static string afterModels = "";

		private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			genericForm.ComboBox1SelectedIndexChanged();
			resetAfterModels();
		}

		private void skinListBox2_MouseDoubleClick(object sender, MouseEventArgs e) {
			genericForm.butAdd();
		}

		private async void config配置ToolStripMenuItem_Click(object sender, EventArgs e) {
			Type2.Miscellaneous = 2;
			DateGridviews date = new DateGridviews();
			await Task.Run(() => date.ShowDialog());
		}

		private async void 功能配置ToolStripMenuItem_Click(object sender, EventArgs e) {
			Alltestitem a = new Alltestitem();
			await Task.Run(() => a.ShowDialog());
		}

		private void 文件上传ToolStripMenuItem1_Click(object sender, EventArgs e) {
			FilesUpload f = new FilesUpload();
			f.ShowDialog();
		}

		private void listBoxControl3_SelectedIndexChanged(object sender, EventArgs e) {
		}

		private void 文件配置ToolStripMenuItem_Click(object sender, EventArgs e) {
			FileConfiguration f = new FileConfiguration();
			f.ShowDialog();
		}

		private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e) {
			Instructions instructions = new Instructions();
			instructions.Show();
		}

		private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e) {
			//genericForm.SqlBackups(out var result);;
		}



		private void 数据还原ToolStripMenuItem_Click(object sender, EventArgs e) {
			DataRestore dataRestore = new DataRestore();
			dataRestore.ShowDialog();

		}

		private void testToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void StationBox2_SelectedIndexChanged(object sender, EventArgs e) {
			genericForm.ComboBox1SelectedIndexChanged2();
		}

		private async void config配置ToolStripMenuItem1_Click(object sender, EventArgs e) {
			Type2.Miscellaneous = 2;
			DateGridviews date = new DateGridviews();
			await Task.Run(() => date.ShowDialog());
		}

		private async void 功能配置ToolStripMenuItem1_Click(object sender, EventArgs e) {
			Alltestitem a = new Alltestitem();
			await Task.Run(() => a.ShowDialog());
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			Environment.Exit(0);
		}

		private void skinMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

		}

		private async void 配置ToolStripMenuItem_Click(object sender, EventArgs e) {
			var models = new ModelsForm();
			await Task.Run(() => models.ShowDialog());
		}

		private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e) {

		}

		private void MsgBox_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void StaionType_SelectedIndexChanged(object sender, EventArgs e) {

		}
		
	}
}