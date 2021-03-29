using After_Test;
using Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controller {
	public class UserController {
		public static Form1 Form1;
		UserManager manager = new UserManager();

		public After.Model.user Login(string username, string password) {
			username = username.Trim();
			password = password.Trim();

			if ( string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ) {
				MessageBox.Show("账号或密码不能为空");
				return null;
			}
			var list = manager.Login(username, password);

			if ( list.Count == 0 ) {
				MessageBox.Show("账号或密码错误");
				return null;
			}

			return list[0];
		}
	}
}

