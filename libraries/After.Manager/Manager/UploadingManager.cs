using System;
using System.Collections.Generic;
using After.Model;
using After.Model.DBUtility;
using DBUtility;

namespace After.Manager.Manager
{
    public class UploadingManager : DbContext
    {

        public List<uploading> Query()
        {
            try
            {
                List<uploading> data = Db.Queryable<uploading>()
                    .Select(f => new uploading
                    {
                        name = f.name,
                        path = f.path,
                        filepath = f.filepath

                    })
                    .ToList();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        /// <summary>
        /// 按机型读取数据
        /// </summary>
        /// <param name="name">机型</param>
        /// <returns></returns>
        public List<uploading> GetName(string name)
        {
            List<uploading> data = Db.Queryable<uploading>()
                .Where(w => w.name == name)
                .Select(f => new uploading
                {
                    name = f.name,
                    path = f.path,
                    filepath = f.filepath,
                    foldertozip = f.foldertozip,
                    zipedfilename = f.zipedfilename
                })
                .ToList();
            return data;

        }
    }
}
