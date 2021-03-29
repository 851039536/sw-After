﻿using After.Model;
using After.Model.DBUtility;
using DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After.Manager {
	//继承DbContext
	public class ModelsManager : DbContext {
		/// <summary>
		/// 加载测试机型
		/// </summary>
		/// <returns>data</returns>
		public List<string> QueryJx(user u) {
			try {
				if ( u.权限 == 1 ) {
					List<string> data2 = Db.Queryable<alltestitem>().GroupBy(it => new {
						it.机型
					})
				.Select(f => f.机型).ToList();
					return data2;
				}
				else {
					List<string> data = Db.Queryable<models>().GroupBy(it => new {
						it.id
					})
				.Where(it => it.username == u.用户)
				.Select(f => f.modelname).ToList();
					return data;
				}
			}
			catch ( Exception e ) {
				MessageBox.Show(e.Message);
				throw;

			}
		}

		public List<string> selectByUsername(string username) {
			List<string> data = Db.Queryable<models>()
			.Where(it => it.username == username)
			.Select(f => f.modelname).ToList();
			return data;
		}

		public bool insertModels(string username, List<string> models) {
			foreach ( var model in models ) {
				int result = Db.Insertable(new models() {
					username = username,
					modelname = model
				}).ExecuteCommand();
			}
			return true;
		}

		public bool deleteModels(string username, List<string> models) {
			foreach ( var model in models ) {
				int result = Db.Deleteable<models>().Where(it => it.username == username && it.modelname == model).ExecuteCommand();
			}
			return true;
		}
	}
}
