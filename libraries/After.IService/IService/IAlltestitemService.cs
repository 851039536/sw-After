using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
