using After.Model;
using After_Test.Additional;
using CCWin;
using Controller;
using System;
using System.Windows.Forms;

namespace After_Test {
	public partial class LoginForm : Skin_Mac {
		Util util = new Util();
		UserController userController = new UserController();
		public static string ip;

		public LoginForm() {
			InitializeComponent();
			textBox2.PasswordChar = '*';
		}

		private void LoginForm_Load(object sender, EventArgs e) {
			if ( util.checkIpInList() ) {
				var u = new user();
				u.name = "超级管理员";
				u.权限 = 1;
				toForm(u);
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			string username = textBox1.Text;
			string password = textBox2.Text;

			textBox1.Enabled = false;
			textBox2.Enabled = false;
			button1.Enabled = false;
			button1.Text = "登录中";

			var u = userController.Login(username, password);
		
			textBox1.Enabled = true;
			textBox2.Enabled = true;
			button1.Enabled = true;
			button1.Text = "登录";
			if ( u == null ) return;

			toForm(u);
		}

		
		public void toForm(user u) {
			Form1.nowUser = u;
			Opacity = 0;
			Hide();
			new Form1().Show();
		}

		private void LoginForm_Shown(object sender, EventArgs e) {
			if (util.checkIpInList() ) {
				Hide();
				Visible = false;
			}
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e) {
			if ( e.KeyCode != Keys.Enter ) return;
			textBox2.Focus();
		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e) {
			if ( e.KeyCode != Keys.Enter ) return;
			button1_Click(sender, e);
		}
	}
}
