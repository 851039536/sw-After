using After.IService.IService;
using After.Model;
using After.Repository.Repository;
using SqlSugar;
using System.Threading.Tasks;

namespace After.Service.Sevice
{
    public class UserService : Repository<user>, IUserService
    {
        public UserService(ISqlSugarClient context = null) : base(context)
        {
        }

        public async Task<user> LoginAsycn(string name, string pwd)
        {
            return await base.GetSingleAsync(s => s.用户 == name && s.密码 == pwd);
        }
    }
}
