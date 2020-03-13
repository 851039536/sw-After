using SqlSugar;

namespace After.Model
{
    [SugarTable("user")]
    public class user
    {
        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }

        public string 用户 { get; set; }
        public string 密码 { get; set; }
        public int 权限 { get; set; }
    }
}