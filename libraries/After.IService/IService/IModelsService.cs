using After.Model;
using After.Model.DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.IService.IService
{
   public interface IModelsService
    {
        /// <summary>
        /// 查询机型
        /// </summary>
        /// <param name="id">权限id</param>
        /// <returns></returns>
         Task<List<string>> GetJxAsync(user user);
    }
}
