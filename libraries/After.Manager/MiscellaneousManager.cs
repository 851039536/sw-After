using After.Model;
using DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Manager
{
   public class MiscellaneousManager : DbContext//继承DbContext
    {
        /// <summary>
        /// //机型站别<string>
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
