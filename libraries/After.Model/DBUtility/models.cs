using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Model.DBUtility {
	[SugarTable("models")]
	public class models {
		//指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
		[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
		public int id {
			get; set;
		}

		public string modelname {
			get; set;
		}
		public string username {
			get; set;
		}
	}
}
