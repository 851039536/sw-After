using System.Collections.Generic;
using After.Model;
using DBUtility;

namespace After.Manager
{
    public class configManager : DbContext //继承DbContext
    {
        /// <summary>
        /// Config机型
        /// </summary>
        /// <returns></returns>
        public List<string> QueryConfig()
        {
            List<string> data = Db.Queryable<config>().GroupBy(it => new
            {
                it.ConfigText
            }).Select(f => f.ConfigText).ToList();
            return data;
        }
    }
}