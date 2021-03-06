using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using After.Model;
using After.Model.DBUtility;
using DBUtility;

namespace After.Manager.Manager
{
    public class AlltestitemManager : DbContext //继承DbContext
    {

        /// <summary>
        /// 加载用户对应的数据
        /// </summary>
        /// <param name="u">用户</param>
        /// <returns></returns>
        public List<alltestitem> GetAllByUser(user u)
        {
            var models = QueryJx(u);
            var data = Db.Queryable<alltestitem>().Where(a => models.Contains(a.机型)).ToList();
            return data;
        }


        /// <summary>
        /// 加载测试机型
        /// </summary>
        /// <returns>data</returns>
        public List<string> QueryJx(user u)
        {

            try
            {
                if (u.权限 == 1)
                {
                    List<string> data2 = Db.Queryable<alltestitem>().GroupBy(it => new
                    {
                        it.机型
                    })
                .Select(f => f.机型).ToList();
                    return data2;
                }
                else
                {
                    List<string> data = Db.Queryable<models>().GroupBy(it => new
                    {
                        it.id
                    })
                .Where(it => it.username == u.用户)
                .Select(f => f.modelname).ToList();
                    return data;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;

            }
        }



        /// <summary>
        ///删除更新
        /// </summary>
        /// <returns>ints</returns>
        public async Task<int> Sqlselect(string zb, string jx, LinkedList<string> xm)
        {
            int k = 1;
            int ints = 0;
            for (int i = 0; i < xm.Count; i--)
            {
                if (xm.Count == 0) break;
                string name = xm.First();
                xm.RemoveFirst();
                var data = await Db.Queryable<alltestitem>()
                   .Where(w => w.机型 == jx && w.测试项目 == name)
                   .Select(f => new alltestitem
                   {
                       单位 = f.单位,
                       数值上限 = f.数值上限,
                       数值下限 = f.数值下限,
                       编号 = f.编号,
                       耳机指令 = f.耳机指令

                   }).ToListAsync();
                string[] 单位1 = data.Select(x => x.单位).ToArray();
                string[] 数值上限1 = data.Select(x => x.数值上限).ToArray();
                string[] 数值下限1 = data.Select(x => x.数值下限).ToArray();
                int[] 编号1 = data.Select(x => x.编号).ToArray();
                string[] 指令 = data.Select(x => x.耳机指令).ToArray();

                ints = await Db.Insertable<testitem>(new
                {
                    机型 = jx,
                    测试项目 = name,
                    测试站别 = zb,
                    耳机指令 = 指令[0],
                    单位 = 单位1[0],
                    数值上限 = 数值上限1[0],
                    数值下限 = 数值下限1[0],
                    编号 = k,
                    allid = 编号1[0],
                    自动测试 = 0
                }).ExecuteCommandAsync();
                k++;
            }

            return ints;
        }
    }
}