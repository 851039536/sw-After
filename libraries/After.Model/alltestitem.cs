using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Model
{
    [SugarTable("alltestitem")]
    public class alltestitem
    {

        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public string 机型 { get; set; }
        public string 测试项目 { get; set; }
        public string 耳机指令 { get; set; }
        public string 单位 { get; set; }
        public string 数值上限 { get; set; }
        public string 数值下限 { get; set; }
        public int 编号 { get; set; }

        public static implicit operator List<object>(alltestitem v)
        {
            throw new NotImplementedException();
        }
    }
}
