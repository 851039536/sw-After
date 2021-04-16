using System.Collections.Generic;
using System.Threading.Tasks;
using After.IService.IService;
using After.Model;
using After.Model.DBUtility;
using After.Repository.Repository;

namespace After.Service.Sevice
{
    public class ModelsService: Repository<models>, IModelsService
    {

        ConfigService config = new ConfigService();
        /// <summary>
        /// 查询机型
        /// </summary>
        /// <param name="id">权限id</param>
        /// <returns></returns>
        public async Task<List<string>> GetJxAsync(user user)
        {
            if (user.权限 !=1)
            {
              List<string> result2 = await Context.Queryable<models>().GroupBy(it => new
                    {
                        it.id
                    })
                .Where(it => it.username == user.用户)
                .Select(f => f.modelname).ToListAsync();
                 return result2;
            }
            else
            {
                 return await  config.GetJxAsync();
            }
           
           
        }
    }
}
