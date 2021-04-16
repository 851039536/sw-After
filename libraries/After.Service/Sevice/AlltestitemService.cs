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
    }
}
