using System;
using System.Collections.Generic;
using System.Windows.Forms;
using After.Model;
using DBUtility;

namespace After.Manager.Manager
{
    public class configManager : DbContext //继承DbContext
    {

		/// <summary>
		/// 加载用户相应的数据
		/// </summary>
		/// <param name="u">用户</param>
		/// <returns></returns>
		public List<config> GetAllByUser(user u) {
			var mm = new ModelsManager();
			var models = mm.GetJx(u);
			var data = Db.Queryable<config>().Where(c => models.Contains(c.ConfigText)).ToList();
			return data;
		}

        /// <summary>
        /// Config机型
        /// </summary>
        /// <returns>data</returns>
        public List<string> QueryConfig(user u)
        {
			//List<string> data = Db.Queryable<config>().GroupBy(it => new
			//{
			//    it.ConfigText
			//}).Select(f => f.ConfigText).ToList();
			//return data;

			try {
				if ( u.权限 == 1 ) {
					List<string> data2 = Db.Queryable<config>().GroupBy(it => new {
						it.ConfigText
					})
				.Select(f => f.ConfigText).ToList();
					return data2;
				}
				else {
					var am = new AlltestitemManager();
					var modelList = am.QueryJx(u);

					List<string> data = Db.Queryable<config>().GroupBy(it => new {
						it.id
					})
				.Where(it => modelList.Contains(it.ConfigText))
				.Select(f => f.ConfigText).ToList();
					return data;
				}
			}
			catch ( Exception e ) {
				MessageBox.Show(e.Message);
				throw;

			}
        }

		/// <summary>
		/// Config机型 周
		/// </summary>
		/// <returns>data</returns>
		public List<string> SelectConfig() {
			List<string> data = Db.Queryable<config>().GroupBy(it => new {
				it.ConfigText
			}).Select(f => f.ConfigText).ToList();
			return data;
		}

		/// <summary>
		/// 查询站别机型
		/// </summary>
		/// <returns>data</returns>
		public List<string> QueryConfigText()
        {
            List<string> data = Db.Queryable<config>().GroupBy(it => new
            {
                it.ConfigText
            }).Select(f => f.ConfigText).ToList();
            return data;
        }
    }
}