using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.IService.IService
{
   public interface ITestitemService
    {
        /// <summary>
        /// 查询站别
        /// </summary>
        /// <param name="jx">机型</param>
        /// <returns></returns>
         Task<List<string>> GetStation(string jx);
        /// <summary>
        /// 查询机型测试项
        /// </summary>
        /// <param name="jx">机型</param>
        /// <param name="station">站别</param>
        /// <returns></returns>
         Task<List<string>> GetJxTestItem(string jx, string station);

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="station">站别</param>
        /// <param name="jx">机型</param>
        /// <returns></returns>
        Task<bool> DeleteAsync(string station, string jx);
    }
}
