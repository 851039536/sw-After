using After.Service.Sevice;
using Sunny.UI;
using System;
using System.Windows.Forms;
using After.Generic.Generic;

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

            // uiComboboxEx1.Items.Add("测试模式");
            // uiComboboxEx1.Items.Add("生产模式");
            // uiComboboxEx1.DropDownStyle = ComboBoxStyle.DropDownList;
            // uiComboboxEx1.SelectedIndex = 0;

         
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {

        }
        private async void LoginForm_ButtonLoginClick(object sender, EventArgs e)
        {
            if (uiCheckBox1.Checked)
            {
                Util.TestMode = 1;
                Hide();
                new Form1().Show();
                return;
            }

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

        private void uiComboboxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uiCheckBox1_Click(object sender, EventArgs e)
        {
            if (uiCheckBox1.Checked)
            {
                
            }
        }
    }
}
