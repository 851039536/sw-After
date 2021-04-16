using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.IService.IService;
using After.Model;
using After.Repository.Repository;

namespace After.Service.Sevice
{
   public class TestitemService : Repository<testitem>, ITestitemService
    {
        public async Task<List<string>> GetStation(string jx)
        {
           var data = await Context.Queryable<testitem>().Where(it => it.机型 == jx).GroupBy(it => new
            {
                it.测试站别
            }).Select(f => f.测试站别).ToListAsync();
            return data;
        }

        /// <summary>
        /// 查询机型测试项
        /// </summary>
        /// <param name="jx">机型</param>
        /// <param name="station">站别</param>
        /// <returns></returns>
        public async Task<List<string>> GetJxTestItem(string jx, string station)
        {
           var result = await Context.Queryable<testitem>().Where(it => it.机型 == jx && it.测试站别 == station).Select(f => f.测试项目).OrderBy("编号 ASC").ToListAsync();
            return result;
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="station">站别</param>
        /// <param name="jx">机型</param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(string station, string jx)
        {
              var result = await base.DeleteAsync(it => it.测试站别 == station && it.机型 == jx); //根据条件删除
            return result;
        }
    }
}
