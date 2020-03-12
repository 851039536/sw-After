using After.Model;
using DBUtility;
using System.Collections.Generic;

namespace After.Manager
{
    public class MiscellaneousManager : DbContext//继承DbContext
    {
        /// <summary>
        /// 机型站别
        /// </summary>
        /// <returns></returns>
        public List<string> QueryType()
        {
            List<string> data = Db.Queryable<miscellaneous>()
                .GroupBy(it => new { it.型号 })
                .Select(f => f.型号)
                .ToList();
            return data;
        }

    }
}
