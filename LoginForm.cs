using After.Model;
using After.Service.Sevice;
using After_Test.Additional;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace After_Test
{
    public partial class LoginForm : UILoginForm
    {
        Util util = new Util();
        UserService _userService = new UserService();
        public static string ip;

        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (util.checkIpInList())
            {
                var u = new user();
                u.name = "超级管理员";
                u.权限 = 1;
                Form1.nowUser = u;
                Hide();
                new Form1().Show();
            }
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (util.checkIpInList())
            {
                Hide();
                Visible = false;
            }
        }
        private async void LoginForm_ButtonLoginClick(object sender, EventArgs e)
        {
            var data = await _userService.LoginAsycn(UserName, Password);
            if (data == null)
            {
                MessageBox.Show("账号或密码错误");
                return;
            }
            Form1.nowUser = data;
            Hide();
            new Form1().Show();
        }
    }
}
