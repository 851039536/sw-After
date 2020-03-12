using After.Model;
using System.Collections.Generic;
using System.Data;

namespace DBUtility
{
    public class TestitemManager : DbContext//继承DbContext
    {
        /// <summary>
        /// 机型站别
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
        /// 机型站别
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

        /// <summary>
        /// 查询机型站别
        /// </summary>
        /// <param name="staion"></param>
        /// <returns></returns>
        public DataTable QueryStaion(string staion)
        {
            DataTable dt = Db.Queryable<testitem>()
                .Where(it => it.机型 == staion)
                .GroupBy(g => new
                {
                    g.机型,
                    g.测试站别
                })
                .Select(f => new
                {
                    f.机型,
                    f.测试站别
                })
                .ToDataTable();
            return dt;
        }


        /// <summary>
        /// 查询站别机型
        /// </summary>
        /// <returns></returns>
        public List<string> QueryCobox()
        {
            List<string> data = Db.Queryable<testitem>()
                .GroupBy(it => new { it.机型 })
                .Select(f => f.机型)
                .ToList();
            return data;

        }

        /// <summary>
        /// 对应机型增加站别
        /// </summary>
        /// <returns></returns>
        public int InstStation(string jx, string station)
        {
            int ints = Db.Insertable<testitem>(new
            {
                机型 = jx,
                测试项目 = "延时1",
                测试站别 = station,
                耳机指令 = "0",
                单位 = "0",
                数值上限 = "0",
                数值下限 = "0",
                编号 = "0",
                allid = "0",
                自动测试 = 0
            }).ExecuteCommand();

            return ints;
        }
    }
}
