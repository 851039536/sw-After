
using After.Model;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
    public class AlltestitemManager : DbContext//继承DbContext
    {

        /// <summary>
        /// //加载测试机型<string>
        /// </summary>
        /// <returns></returns>
        public List<string> QueryJX()
        {
            List<string> data = Db.Queryable<alltestitem>()
                .GroupBy(it => new { it.机型 })
                .Select(f => f.机型)
                .ToList();
            return data;
        }
        /// <summary>
        /// //加载测试项目<string>
        /// </summary>
        /// <returns></returns>
        public List<string> LoadTestProject(string strWhere)
        {
            List<string> data = Db.Queryable<alltestitem>()
                 .Where(w => w.机型 == strWhere)
                .Select(f => f.测试项目)
                .ToList();
            return data;
        }

    }
}
