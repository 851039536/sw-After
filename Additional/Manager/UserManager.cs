using System;
using DBUtility;
using System.Windows.Forms;
using After.Model;
using System.Collections.Generic;

namespace Manager {
	public class UserManager : DbContext {
		public List<user> Login(string username, string password) {
			//var result = Db.Queryable<user>().Where(it => it.用户 == username && it.密码 == password).Any();
			var result = Db.Queryable<user>().Where(it => it.用户 == username && it.密码 == password).ToList();
			return result;
		}
	}
}

