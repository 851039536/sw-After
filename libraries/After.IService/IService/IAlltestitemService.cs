using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.Model;

namespace After.IService.IService
{
    public interface IAlltestitemService
    {
        /// <summary>
        /// //查询机型测试项
        /// </summary>
        /// <param name="jx">机型</param>
        /// <returns></returns>
         Task<List<string>> GetJxTestItem(string jx);

          /// <summary>
        /// //查询机型测试项
        /// </summary>
        /// <param name="jx">机型</param>
        /// <returns></returns>
         Task<List<alltestitem>> GetAllAsync(string jx);

          /// <summary>
          /// 主键删除
          /// </summary>
          /// <param name="id">主键</param>
          /// <returns></returns>
        Task<bool> DeleteById(int id);
    }
}
