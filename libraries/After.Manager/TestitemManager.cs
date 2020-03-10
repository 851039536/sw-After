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

        /// <summary>
        /// //机型站别<string>
        /// </summary>
        /// <returns></returns>
        public List<string> GetTestitemProjectList(string strWhere, string comb)
        {
            List<string> data = Db.Queryable<testitem>()
                .Where(it => it.机型 == strWhere && it.测试站别 == comb)
                .Select(f => f.测试项目)
                .OrderBy("编号 ASC")
                .ToList();
            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> LoadTestStation(string strWhere)
        {
            List<string> data = Db.Queryable<testitem>()
                .Where(it => it.机型 == strWhere)
                .Select(f => f.测试站别)
                .ToList();
            return data;
        }

        /// <summary>
        /// 删除记录添加新记录
        /// </summary>
        public bool DeleteSave(string station, string jx)
        {
           var num = testitemdb.Delete(it => it.测试站别 == station && it.机型 == jx);//根据条件删除

            return num;
        }
    }
}
