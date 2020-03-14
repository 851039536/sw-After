using After.Model;
using DBUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Manager
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
                        path = f.path
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

        public List<string> GetName(string name)
        {
            List<string> data = Db.Queryable<uploading>()
                .Where(w=>w.name== name)
                .Select(f => f.path)
                .ToList();
            return data;

        }
    }
}
