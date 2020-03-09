using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Model
{
    [SugarTable("testitem")]
    public class testitem
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public string 机型 { get; set; }
        public string 测试项目 { get; set; }
        public string 测试站别 { get; set; }
        public string 耳机指令 { get; set; }
        public string 单位 { get; set; }
        public string 数值上限 { get; set; }
        public string 数值下限 { get; set; }
        public int 编号 { get; set; }
        public int allid { get; set; }
        public int 自动测试 { get; set; }


    }
}
