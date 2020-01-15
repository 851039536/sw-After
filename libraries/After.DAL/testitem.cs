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
	/// <summary>
	/// 数据访问类:user
	/// </summary>
	public partial class testitem
	{
		public testitem()
		{ }
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.user model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("insert into user(");
			strSql.Append("id,name,age)");
			strSql.Append(" values (");
			strSql.Append("@id,@name,@age)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32,8),
					new MySqlParameter("@name", MySqlDbType.VarChar,255),
					new MySqlParameter("@age", MySqlDbType.Int32,8)};
			parameters[0].Value = model.用户;
			parameters[1].Value = model.密码;
			parameters[2].Value = model.权限;

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
		public bool Update(Model.user model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("update user set ");
			strSql.Append("name=@name,");
			strSql.Append("age=@age");
			strSql.Append(" where id=@id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@name", MySqlDbType.VarChar,255),
					new MySqlParameter("@age", MySqlDbType.Int32,8),
					new MySqlParameter("@id", MySqlDbType.Int32,8)};
			parameters[0].Value = model.用户;
			parameters[1].Value = model.密码;
			parameters[2].Value = model.权限;

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
			strSql.Append("delete from user ");
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
		public Model.testitem GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select id,name,age from user ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			Model.testitem model = new Model.testitem();
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
		/// 得到一个对象实体
		/// </summary>
		public Model.testitem LoadTestStationList(DataRow row)
		{
			Model.testitem model = new Model.testitem();
			if (row != null)
			{
				if (row["测试站别"] != null && row["测试站别"].ToString() != "")
				{
					model.测试站别 = row["测试站别"].ToString();
				}
		
			}
			return model;
		}

		/// <summary>
		/// 得到Testitem对象实体
		/// </summary>
		public Model.testitem LoadTestitemProjectList(DataRow row)
        {
            Model.testitem model = new Model.testitem();
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
		/// 得到一个对象实体
		/// </summary>
		public Model.testitem DataRowToModel(DataRow row)
        {
            Model.testitem model = new Model.testitem();
            if (row != null)
            {
                if (row["测试站别"] != null && row["测试站别"].ToString() != "")
                {
                    model.测试站别 = row["测试站别"].ToString();
                }
                //				if (row["密码"] != null)
                //				{
                //					model.密码 = row["密码"].ToString();
                //				}
                //				if (row["权限"] != null && row["权限"].ToString() != "")
                //				{
                //					model.权限 = int.Parse(row["权限"].ToString());
                //				}
            }
            return model;
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select distinct 测试站别 ");
			strSql.Append(" FROM testitem ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where 机型= '" + strWhere + "'");
			}
			return DbHelperMySql.Query(strSql.ToString());
		}

		/// <summary>
		/// 测试项目  条件（测试站别）
		/// </summary>
		public DataSet GetTestitemProjectList(string strWhere, string comb)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select 测试项目 ");
            strSql.Append(" FROM testitem ");
            if (strWhere.Trim() != "" && comb.Trim()!="")
            {
                strSql.Append(" where 测试站别 = '" + comb + "'and 机型 = '" + strWhere + "'order by 编号 ASC" );

			}
            return DbHelperMySql.Query(strSql.ToString());
        }
		

		/// <summary>
		/// 获得站别数据
		/// </summary>
		public DataSet LoadTestStationList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct 测试站别 ");
            strSql.Append(" FROM testitem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where 机型= '" + strWhere + "'");
            }
            return DbHelperMySql.Query(strSql.ToString());
        }

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("select count(1) FROM user ");
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
			strSql.Append(")AS Row, T.*  from user T ");
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
			parameters[0].Value = "user";
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
