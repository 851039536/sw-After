using After.Service.Sevice;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace After_Test
{
    public partial class LoginForm : UILoginForm
    {
        UserService _userService = new UserService();
        public static string ip;

        public LoginForm()
        {
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
         
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            
        }
        private async void LoginForm_ButtonLoginClick(object sender, EventArgs e)
        {
            var data = await _userService.LoginAsycn(UserName, Password);
            if (data == null)
            {
                MessageBox.Show(@"账号或密码错误");
                return;
            }
            Form1.nowUser = data;
            Hide();
            new Form1().Show();
        }
    }
}
