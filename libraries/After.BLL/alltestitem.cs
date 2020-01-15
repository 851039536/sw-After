﻿using Maticsoft.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.BLL
{
	public partial class alltestitem
	{
		private readonly DAL.alltestitem dal = new DAL.alltestitem();
		public alltestitem()
		{ }
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Model.alltestitem model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.alltestitem model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long id)
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete(id);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.alltestitem GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Model.alltestitem GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "userModel-";
			object objModel = DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch { }
			}
			return (Model.alltestitem)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 加载测试项目 返回model
		/// </summary>
		public List<Model.alltestitem> LoadTestProject(string strWhere)
		{
			DataSet ds = dal.GetTestProject(strWhere);
			return DataTestProject(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.alltestitem> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
		/// <summary>
		/// 加载测试机型
		/// </summary>
		/// <param name="strWhere"></param>
		/// <returns></returns>
		public List<Model.alltestitem> LoadTestModel(string strWhere)
        {
            DataSet ds = dal.LoadTestModel(strWhere);//dal
            return DataTestModel(ds.Tables[0]); //bll
        }
		/// <summary>
		/// 加载测试机型
		/// </summary>
		public List<Model.alltestitem> DataTestModel(DataTable dt)
		{
			List<Model.alltestitem> modelList = new List<Model.alltestitem>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.alltestitem model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.LoadTestModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}
		/// <summary>
		/// 获取测试项目
		/// </summary>
		public List<Model.alltestitem> DataTestProject(DataTable dt)
        {
            List<Model.alltestitem> modelList = new List<Model.alltestitem>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.alltestitem model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.LoadTestProject(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.alltestitem> DataTableToList(DataTable dt)
        {
            List<Model.alltestitem> modelList = new List<Model.alltestitem>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.alltestitem model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.LoadTestProject(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
		//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
