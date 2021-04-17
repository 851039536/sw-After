using After.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace After.IService.IService
{
    public interface IConfigService
    {
        Task<List<string>> GetJxAsync();

        /// <summary>
        /// 查询机型
        /// </summary>
        /// <param name="jx"></param>
        /// <returns></returns>
        Task<config> GetTypeJxAsync(string jx);
    }
}
