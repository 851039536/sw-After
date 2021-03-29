using After.Model;
using After.Model.DBUtility;
using DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility {
	public class LogsManager : DbContext {
		public bool insertLog(user u, string msg, string afterModels, string beforeModels, int type) {
			return logsdb.Insert(new logs() {
				uid = u.id,
				msg = msg,
				afterModels = afterModels,
				beforeModels = beforeModels,
				type = type
			});
		}

		public List<logs> selectLogByUid(int uid) {
			var result = logsdb.GetList().Take(10).Where(it => it.uid == uid && it.type != 2).ToList();
			return result;
		}
	}
}
