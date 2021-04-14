using After.IService.IService;
using After.Model;
using After.Repository.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace After.Service
{
    public class ConfigService : Repository<config>, IConfigService
    {
        public ConfigService()
        {
        }
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>

        public async Task<List<config>> GetAllAsync()
        {
            return await base.GetListAsync();
        }
    }
}
