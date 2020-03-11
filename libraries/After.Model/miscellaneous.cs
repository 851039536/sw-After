using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Model
{
    [SugarTable("miscellaneous")]
    public class miscellaneous
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        public string 型号 { get; set; }

        public string 程序路径 { get; set; }

        public string 数据路径 { get; set; }

    }
}
