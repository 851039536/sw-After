using System;
using System.Collections.Generic;
using System.Windows.Forms;
using After.Model;
using DBUtility;
using SqlSugar;

namespace After.Manager.Manager
{
    public class UserManager : DbContext//继承DbContext
    {
        public void query()
        {

            var data2 = Userdb.GetList();//查询所有
            var data1 = Userdb.GetById(1);//根据ID查询
        }

        public void SearchDemo()
        {


            var data2 = Userdb.GetList();//查询所有
            var data3 = Userdb.GetList(it => it.id == 1);  //根据条件查询  
            var data4 = Userdb.GetSingle(it => it.id == 1);//根据条件查询一条

            var p = new PageModel() { PageIndex = 1, PageSize = 2 };// 分页查询
            var data5 = Userdb.GetPageList(it => it.用户 == "xx", p);
            Console.Write(p.PageCount);//返回总数


            // 分页查询加排序
            var data6 = Userdb.GetPageList(it => it.用户 == "xx", p, it => it.用户, OrderByType.Asc);
            Console.Write(p.PageCount);//返回总数


            //组装条件查询作为条件实现 分页查询加排序
            List<IConditionalModel> conModels = new List<IConditionalModel>();
            conModels.Add(new ConditionalModel() { FieldName = "id", ConditionalType = ConditionalType.Equal, FieldValue = "1" });//id=1
            var data7 = Userdb.GetPageList(conModels, p, it => it.用户, OrderByType.Asc);

            //4.9.7.5支持了转换成queryable,我们可以用queryable实现复杂功能
            Userdb.AsQueryable().Where(x => x.id == 1).ToList();
        }


        //插入例子
        public void InsertDemo()
        {

            var student = new user() { 用户 = "jack" };
            var studentArray = new user[] { student };

            Userdb.Insert(student);//插入

            Userdb.InsertRange(studentArray);//批量插入

            var id = Userdb.InsertReturnIdentity(student);//插入返回自增列

            //4.9.7.5我们可以转成 Insertable实现复杂插入
            // Userdb.AsInsertable(insertObj).ExecuteCommand();
        }


        //更新例子
        public void UpdateDemo()
        {
            var student = new user() { id = 1, 用户 = "jack" };
            var studentArray = new user[] { student };

            Userdb.Update(student);//根据实体更新

            Userdb.UpdateRange(studentArray);//批量更新

            // Userdb.Update(it => new User() { 用户 = "a", CreateTime = DateTime.Now }, it => it.Id == 1);// 只更新Name列和CreateTime列，其它列不更新，条件id=1

            //支持Userdb.AsUpdateable(student)
        }

        //删除例子
        public void DeleteDemo()
        {
            var student = new user() { id = 1, 用户 = "jack" };

            Userdb.Delete(student);//根据实体删除
            Userdb.DeleteById(1);//根据主键删除
            Userdb.DeleteById(new[] { 1, 2 });//根据主键数组删除
            Userdb.Delete(it => it.id == 1);//根据条件删除

            //支持Userdb.AsDeleteable()
        }

        //使用事务的例子
        public void TranDemo()
        {

            var result = Db.Ado.UseTran(() =>
            {
                //这里写你的逻辑
            });
            if (result.IsSuccess)
            {
                //成功
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        //多表查询
        public void JoinDemo()
        {
            Db.Queryable<user, user>((st, sc) => new object[] {
                JoinType.Left,
                st.用户==sc.用户
            }).Select<user>().ToList();
        }

		/// <summary>
		/// 加载测试机型
		/// </summary>
		/// <returns>data</returns>
		public List<string> SelectUsers() {
			try {
				List<string> data = Db.Queryable<user>()
				.Select(f => f.用户).ToList();
				return data;
			}
			catch ( Exception e ) {
				MessageBox.Show(e.Message);
				throw;
			}
		}



          public List<user> Login(string username, string password)
        {
            //var result = Db.Queryable<user>().Where(it => it.用户 == username && it.密码 == password).Any();
            List<user> result = new List<user>();
            try
            {
                result = Db.Queryable<user>().Where(it => it.用户 == username && it.密码 == password).ToList();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
               
            }
           
            return result;
        }
	}
}
