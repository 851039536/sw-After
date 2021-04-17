using System;
using System.Windows.Forms;
using After_Test.Generic;
using System.Collections.Generic;
using CCWin;
using System.IO;
using System.Threading;
using After.Generic.Generic;
using After.Manager.Manager;

namespace After_Test.Forms {
	public partial class ModelsForm : Skin_Mac {
		public static ModelsForm Modeltest;
		public static DateGridviews Dategridviews;

		private float X;
		private float x1;
		private float Y;
		private float y1;
		private List<string> dataSource;

		private DateGridviewsFor date = new DateGridviewsFor();
		private ClassControl ctl = new ClassControl();
		private configManager config = new configManager();
		private UserManager user = new UserManager();
		private ModelsManager models = new ModelsManager();

		List<string> toInsertModels = new List<string>();
		List<string> toDeleteModels = new List<string>();

		public ModelsForm() {
			InitializeComponent();
			Modeltest = this;
			Type2.Miscellaneous = 2;
		}

		private void ModelsForm_Load(object sender, EventArgs e) {
			X = Width;
			Y = Height;
			x1 = X;
			y1 = Y;

			ctl.setTag(this);
			WindowState = FormWindowState.Normal;

			LoadUsersData();
			Log("导入用户数据完成");
			LoadConfigData();
			Log("导入机型数据完成");
			button6.Enabled = false;
		}

		/// <summary>
		/// 查询用户
		/// </summary>
		public void LoadUsersData() {
			var result = user.SelectUsers();
			foreach ( var r in result ) {
				numberList.Items.Add(r);
			}
		}

		/// <summary>
		/// 查询机型
		/// </summary>
		public void LoadConfigData() {
			try {
				dataSource = config.SelectConfig();
				foreach ( var item in dataSource ) {
					configLen.Items.Add(item);
				}
			}
			catch ( Exception ex ) {
				MessageBox.Show(ex.Message);
			}
		}

		private void ModelsForm_Resize(object sender, EventArgs e) {
			float newX = Width;
			float newY = Height;
			ctl.setControls(newX / X, newY / Y, this);
			x1 = newX;
		}

		private void configLen_MouseDoubleClick(object sender, MouseEventArgs e) {
			var nowItem = Convert.ToString(configLen.SelectedItem);
			//检测是否重复插入
			var ss = selectedModel.Items;

			for ( int i = 0; i < ss.Count; i++ ) {
				if ( nowItem == ss[ i ].ToString() ) return;
			}
			toInsertModels.Add(nowItem);
			toDeleteModels.Remove(nowItem);
			selectedModel.Items.Add(nowItem);
			Log("添加机型 -> " + nowItem);
		}

		private void numberList_MouseClick(object sender, MouseEventArgs e) {
			string username =  numberList.SelectedItem.ToString();

			var result = models.SelectByUsername(username);
			selectedModel.Items.Clear();
			foreach ( var r in result ) {
				selectedModel.Items.Add(r);
			}
		}

		public void Log(string msg) {
			msg = string.Format("{0:hh:mm:ss},{1}\r\n", DateTime.Now, msg);
			controlBox.Items.Add(msg);
			AddLog2File(msg);
			if ( controlBox.Items.Count > 0 )
				controlBox.SelectedIndex = controlBox.Items.Count - 1;
			Application.DoEvents();
		}
		
		public void AddLog2File(string msg) {
			string filename = string.Format("\\{0:yyyy-MM-dd}", DateTime.Now) + ".log";
			string path = Environment.CurrentDirectory + @"\log";

			StreamWriter sw = null;
			try {
				Directory.CreateDirectory(path);
				path += filename;

				if ( !File.Exists(path) ) {
					File.Create(path).Dispose();
				}
				sw = new StreamWriter(path, true);
				sw.Write(msg);
				sw.Close();
			}
			catch ( Exception e ) {
				MessageBox.Show(@"写入Log到文件失败
" + e);
				//throw;
			}
			finally {
				if ( sw != null ) {
					sw.Close();
				}
			}
		}

		//增加
		private void button1_Click(object sender, EventArgs e) {
			configLen_MouseDoubleClick(sender, ( MouseEventArgs ) e);
		}

		//删除
		private void button2_Click(object sender, EventArgs e) {
			//TODO 点击保存后会从数据库中删除相应机型
			if ( selectedModel.SelectedIndex > -1 ) {
				var sltItem = selectedModel.SelectedItem;
				toDeleteModels.Add(sltItem.ToString());
				toInsertModels.Remove(sltItem.ToString());
				selectedModel.Items.Remove(sltItem);
			}
				
		}

		//上移
		private void button3_Click(object sender, EventArgs e) {
			try {
				int index1 = selectedModel.SelectedIndex;
				if ( index1 > 0 ) {
					var item = selectedModel.SelectedItem;
					selectedModel.Items.RemoveAt(index1);
					selectedModel.Items.Insert(index1 - 1, item);
					selectedModel.SelectedIndex = index1 - 1;
				}
			}
			catch ( Exception ex) {
				MessageBox.Show(@"未选中" + ex);
				throw;
			}
		}

		//下移
		private void button4_Click(object sender, EventArgs e) {
			try {
				int index1 = selectedModel.SelectedIndex;
				if ( index1 < selectedModel.Items.Count - 1 ) {
					var item = selectedModel.SelectedItem;
					selectedModel.Items.RemoveAt(index1);
					selectedModel.Items.Insert(index1 + 1, item);
					selectedModel.SelectedIndex = index1 + 1;
				}
			}
			catch ( Exception ex) {
				MessageBox.Show(@"未选中" + ex);
			}
		}

		//锁定/解锁
		private void button5_Click(object sender, EventArgs e) {
			if ( button5.Text.Equals("锁定") ) {
				configLen.Enabled = false;
				selectedModel.Enabled = false;
				numberList.Enabled = false;
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button5.Text = @"解除锁定";
				button6.Enabled = true;
			}
			else {
				configLen.Enabled = true;
				selectedModel.Enabled = true;
				numberList.Enabled = true;
				button1.Enabled = true;
				button2.Enabled = true;
				button3.Enabled = true;
				button4.Enabled = true;
				button5.Text = @"锁定";
				button6.Enabled = false;
			}
		}

		//更新
		private void button6_Click(object sender, EventArgs e) {
			if ( numberList.SelectedIndex == -1 ) {
				Log("请至少选择一个用户");
				return;
			}

			button6.Text = @"正在更新";
			button6.Enabled = false;
			Thread.Sleep(1000);

			//添加数据
			var sUser = numberList.SelectedItem.ToString();
			var result = models.InsertModels(sUser, toInsertModels);

			if ( result ) {
				Log("添加机型成功");
			}
			else {
				Log("添加机型失败");
			}

			toInsertModels.Clear();

			result = models.DeleteModels(sUser, toDeleteModels);
			if ( result ) {
				Log("删除机型成功");
			}
			else {
				Log("删除机型失败");
			}

			toDeleteModels.Clear();

			button6.Text = @"更新";
			button6.Enabled = true;
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
