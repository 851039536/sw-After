using System;
using System.Linq;
using After.Model;
using SqlSugar;

namespace DBUtility
{
    public class DbContext
    {
        //注意：不能写成静态的，不能写成静态的
        public SqlSugarClient Db; //用来处理事务多表查询和复杂的操作

        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig
            {
                 ConnectionString = "server=localhost;uid=root;pwd=woshishui;database=test",
                 // ConnectionString = "server=10.55.22.34;uid=root;pwd=merryte;database=test",
                DbType = DbType.MySql,
                InitKeyType = InitKeyType.Attribute, //从特性读取主键和自增列信息
                IsAutoCloseConnection = true //开启自动释放模式和EF原理一样我就不多解释了
            });;
            //调式代码 用来打印SQL 
            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }
         public SimpleClient<uploading> uploadingdb { get { return new SimpleClient<uploading>(Db); } }//用来处理Student表的常用操作
        public SimpleClient<user> Userdb => new SimpleClient<user>(Db); //用来处理Student表的常用操作
        public SimpleClient<alltestitem> alltestitemdb => new SimpleClient<alltestitem>(Db);
        public SimpleClient<testitem> testitemdb => new SimpleClient<testitem>(Db);
        public SimpleClient<miscellaneous> miscellaneousdb => new SimpleClient<miscellaneous>(Db);

        public SimpleClient<config> configDb => new SimpleClient<config>(Db); //用来处理config表的常用操作
        // public SimpleClient<School> SchoolDb { get { return new SimpleClient<School>(Db); } }//用来处理School表的常用操作
    }
}