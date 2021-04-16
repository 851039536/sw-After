using System;
using System.Collections.Generic;
using System.Windows.Forms;
using After.Model;
using After.Model.DBUtility;
using DBUtility;

namespace After.Manager.Manager
{
    //继承DbContext
    public class ModelsManager : DbContext
    {
        /// <summary>
        /// 加载测试机型
        /// </summary>
        /// <returns>data</returns>
        public List<string> GetJx(user u)
        {
            try
            {
                if (u.权限 == 1)
                {
                    List<string> result = Db.Queryable<alltestitem>().GroupBy(it => new
                    {
                        it.机型
                    })
                .Select(f => f.机型).ToList();
                    return result;
                }
                else
                {
                    List<string> result2 = Db.Queryable<models>().GroupBy(it => new
                    {
                        it.id
                    })
                .Where(it => it.username == u.用户)
                .Select(f => f.modelname).ToList();
                    return result2;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;

            }
        }

        public List<string> SelectByUsername(string username)
        {
            List<string> data = Db.Queryable<models>()
            .Where(it => it.username == username)
            .Select(f => f.modelname).ToList();
            return data;
        }

        public bool InsertModels(string username, List<string> models)
        {
            foreach (var model in models)
            {
                int result = Db.Insertable(new models()
                {
                    username = username,
                    modelname = model
                }).ExecuteCommand();
            }
            return true;
        }

        public bool DeleteModels(string username, List<string> models)
        {
            foreach (var model in models)
            {
                int result = Db.Deleteable<models>().Where(it => it.username == username && it.modelname == model).ExecuteCommand();
            }
            return true;
        }
    }
}
