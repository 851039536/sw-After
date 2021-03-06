using SqlSugar;
using System;
using System.Collections.Generic;
using After.Generic.Generic;

namespace After.Repository.Repository
{
    public class Repository<T> : SimpleClient<T> where T : class, new()
    {
        public Repository(ISqlSugarClient context = null) : base(context)//注意这里要有默认值等于null
        {
            if (context == null)
            {
                string[] sqlText = Util.SqlText();
                Context = new SqlSugarClient(new ConnectionConfig()
                {
                    //DbType = SqlSugar.DbType.SqlServer,
                    DbType = (DbType)Convert.ToSByte(sqlText[1]),
                    InitKeyType = InitKeyType.Attribute,
                    IsAutoCloseConnection = true,
                    ConnectionString = sqlText[0]
                });
            }
        }

        /// <summary>
        /// 扩展方法，自带方法不能满足的时候可以添加新方法
        /// </summary>
        /// <returns></returns>
        public List<T> CommQuery(string json)
        {
            //base.Context.Queryable<T>().ToList();可以拿到SqlSugarClient 做复杂操作
            return null;
        }

    }
}
