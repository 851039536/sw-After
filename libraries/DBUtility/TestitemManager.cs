using After.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility
{
   public class TestitemManager : DbContext//继承DbContext
    {
        /// <summary>
        /// //机型站别<string>
        /// </summary>
        /// <returns></returns>
        public List<string> QueryStation(string jx)
        {
            List<string> data = Db.Queryable<testitem>()
                .Where(it => it.机型 == jx)
                .GroupBy(it => new { it.测试站别 })
                .Select(f => f.测试站别)
                .ToList();
            return data;
        }
    }
}
