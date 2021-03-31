using MySql.Data.MySqlClient;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace After.Generic
{
    public static class Type2
    {
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string INIPath);

        /// <summary>
        /// 型号名称
        /// </summary>
        public static string TypeName = null;


        /// <summary>
        /// 用户
        /// </summary>
        public static string User1 = "";

        public static string User2 = "";

        /// <summary>
        /// 权限
        /// </summary>
        public static int Jurisdiction = 0;

        /// <summary>
        /// 杂项
        /// </summary>
        public static int Miscellaneous = 0;

        ///
        public static int Testflag = 0;
        public static string SqlTest = "";
        public static string SqlPath = @".\config\config.ini";

        /// <summary>
        /// 获取本地数据库连接 | 0：mysql | 1：sqlserver|
        /// </summary>
        /// <returns></returns>
        public static string[] SqlText()
        {
            StringBuilder temp = new StringBuilder(500);
            GetPrivateProfileString("config", "sqlserver", "", temp, 500, SqlPath);
            string[] sql= temp.ToString().Split(',');
            return sql;
        }
        /// <summary>
        /// 获取备份数据连接字符串
        /// </summary>
        /// <returns></returns>
         public static string MysqlBackups()
        {
           StringBuilder temp = new StringBuilder(500);
            GetPrivateProfileString("config", "MysqlBackups", "", temp, 500, SqlPath);
           return temp.ToString();
        }


        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (pi != null) pi.SetValue(dgv, setting, null);
        }
        // public static string constr = "server=10.55.22.34;uid=root;pwd=merryte;database=test-1";
        public static string constr = MysqlBackups();
        public static MySqlConnection conn = new MySqlConnection(constr);
    }
}