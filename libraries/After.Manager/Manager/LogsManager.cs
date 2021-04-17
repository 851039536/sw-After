using After.Model;
using After.Model.DBUtility;
using System.Collections.Generic;
using System.Linq;

namespace DBUtility {
	public class LogsManager : DbContext {
		public bool insertLog(user u, string msg, string afterModels, string beforeModels, int type) {
			return Logsdb.Insert(new logs() {
				uid = u.id,
				msg = msg,
				afterModels = afterModels,
				beforeModels = beforeModels,
				type = type
			});
		}

		public List<logs> SelectLogByUid(int uid) {
			var result = Logsdb.GetList().Take(10).Where(it => it.uid == uid && it.type != 2).ToList();
			return result;
		}
	}
}
