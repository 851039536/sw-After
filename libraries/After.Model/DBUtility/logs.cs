using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Model.DBUtility {

	[SugarTable("logs")]
	public class logs {

		public logs() {}

		public logs(int uid, string msg) {
			this.uid = uid;
			this.msg = msg;
		}


		[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
		public int id {get; set;}

		public int uid {get; set;}

		public string msg {get; set;}

		[SugarColumn(IsOnlyIgnoreInsert = true, IsOnlyIgnoreUpdate = true, ColumnName = "create_time")]
		public DateTime createTime {
			get; set;
		}

		[SugarColumn(ColumnName = "after_models")]
		public string afterModels {
			get; set;
		}

		[SugarColumn(ColumnName = "before_models")]
		public string beforeModels {
			get; set;
		}

		public int type {
			get; set;
		}
	}
}
