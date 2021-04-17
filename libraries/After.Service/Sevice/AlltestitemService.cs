using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using After.IService.IService;
using After.Model;
using After.Repository.Repository;

namespace After.Service.Sevice
{
    public class AlltestitemService : Repository<alltestitem>, IAlltestitemService
    {
        public async Task<List<string>> GetJxTestItem(string jx)
        {
           var result = await Context.Queryable<alltestitem>().Where(w => w.机型 == jx).Select(f => f.测试项目).ToListAsync();
            return result;
        }

        /// <summary>
        /// //查询机型测试项
        /// </summary>
        /// <param name="jx">机型</param>
        /// <returns></returns>
        public async Task<List<alltestitem>> GetAllAsync(string jx)
        {
            var data = await base.GetListAsync(it => it.机型 ==jx);
            return  data;
        }

        /// <summary>
        /// 主键删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<bool> DeleteById(int id)
        {
            return await  base.DeleteByIdAsync(id);
        }
    }
}
