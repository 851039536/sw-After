using After.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace After.IService.IService
{
    public interface IConfigService
    {
        Task<List<config>> GetAllAsync();
    }
}
