using DBUtility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.DAL
{
    public partial class alltestitem
    {
		public alltestitem()
		{ }
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.alltestitem model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("insert into alltestitem(");
			strSql.Append("id,name,age)");
			strSql.Append(" values (");
			strSql.Append("@id,@name,@age)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,8),
					new MySqlParameter("@name", MySqlDbType.VarChar,255),
					new MySqlParameter("@age", MySqlDbType.Int32,8)};
			//parameters[0].Value = model.用户;
			//parameters[1].Value = model.密码;
			//parameters[2].Value = model.权限;

			int rows = DbHelperMySql.ExecuteSql(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.alltestitem model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("update alltestitem set ");
			strSql.Append("name=@name,");
			strSql.Append("age=@age");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@name", MySqlDbType.VarChar,255),
					new MySqlParameter("@age", MySqlDbType.Int32,8),
					new MySqlParameter("@id", MySqlDbType.Int32,8)};
			//parameters[0].Value = model.用户;
			//parameters[1].Value = model.密码;
			//parameters[2].Value = model.权限;

			int rows = DbHelperMySql.ExecuteSql(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long id)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql = new StringBuilder();
			strSql.Append("delete from alltestitem ");
			strSql.Append(" where id=@userID");
			MySqlParameter[] parameters = {
				 new MySqlParameter("@@userID", SqlDbType.BigInt)
			};

			parameters[0].Value = id;

			int rows = DbHelperMySql.ExecuteSql(strSql.ToString(), parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.alltestitem GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select id,name,age from alltestitem ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			Model.alltestitem model = new Model.alltestitem();
			DataSet ds = DbHelperMySql.Query(strSql.ToString(), parameters);
			if (ds.Tables[0].Rows.Count > 0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体 返回model
		/// </summary>
		public Model.alltestitem DataRowToModel(DataRow row)
		{
			Model.alltestitem model = new Model.alltestitem();
			if (row != null)
			{
				if (row["机型"] != null && row["机型"].ToString() != "")
				{
					model.机型 = row["机型"].ToString();
				}
				//if (row["测试项目"] != null)
				//{
				//	model.测试项目 = row["测试项目"].ToString();
				//}
    //            if (row["耳机指令"] != null)
    //            {
    //                model.耳机指令 = row["耳机指令"].ToString();
    //            }
    //            if (row["单位"] != null)
    //            {
    //                model.单位 = row["单位"].ToString();
    //            }
    //            if (row["数值下限"] != null)
    //            {
    //                model.数值下限 = row["数值下限"].ToString();
    //            }
    //            if (row["数值上限"] != null)
    //            {
    //                model.数值上限 = row["数值上限"].ToString();
    //            }
				//if (row["编号"] != null && row["编号"].ToString() != "")
				//{
				//	model.编号 = int.Parse(row["编号"].ToString());
				//}
			}
			return model;
		}


		/// <summary>
		/// 加载测试机型 返回model
		/// </summary>
		/// <param name="row"></param>
		/// <returns></returns>
        public Model.alltestitem LoadTestModel(DataRow row)
        {
            Model.alltestitem model = new Model.alltestitem();
            if (row != null)
            {
                if (row["机型"] != null && row["机型"].ToString() != "")
                {
                    model.机型 = row["机型"].ToString();
                }
               
            }
            return model;
        }

        /// <summary>
        /// 加载测试项目 返回model
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public Model.alltestitem LoadTestProject(DataRow row)
        {
            Model.alltestitem model = new Model.alltestitem();
            if (row != null)
            {
                if (row["测试项目"] != null && row["测试项目"].ToString() != "")
                {
                    model.测试项目 = row["测试项目"].ToString();
                }

            }
            return model;
        }

		/// <summary>
		/// 获得Project数据列表 DataSet
		/// </summary>
		public DataSet GetTestProject(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append(" select 测试项目 ");
			strSql.Append(" FROM alltestitem ");
			if (strWhere.Trim() != "")
			{
				strSql.Append("where 机型 = '" + strWhere + "'");
			}
			return DbHelperMySql.Query(strSql.ToString());
		}

        /// <summary>
        /// 获得数据列表 DataSet
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct 机型");
            strSql.Append(" FROM alltestitem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySql.Query(strSql.ToString());
        }
		/// <summary>
		/// 加载测试机型
		/// </summary>
		public DataSet LoadTestModel(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct 机型");
            strSql.Append(" FROM alltestitem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySql.Query(strSql.ToString());
        }
		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) FROM alltestitem ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby);
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from alltestitem T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySql.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "alltestitem";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
