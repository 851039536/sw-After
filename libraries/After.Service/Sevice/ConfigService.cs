﻿using System.Collections.Generic;
using System.Threading.Tasks;
using After.IService.IService;
using After.Model;
using After.Repository.Repository;

namespace After.Service.Sevice
{
    public class ConfigService : Repository<config>, IConfigService
    {
        /// <summary>
        /// 查询机型
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetJxAsync()
        {
              var result = Context.Queryable<config>().GroupBy(it => new
                    {
                        it.ConfigText
                    })
                .Select(f => f.ConfigText).ToListAsync();
                    return await result;
        }
    }
}
