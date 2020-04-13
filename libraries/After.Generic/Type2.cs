using MySql.Data.MySqlClient;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace After.Generic
{
    public static class Type2
    {
        /// <summary>
        /// 型号名称
        /// </summary>
        public static string Type1 = null;

        public static string Station = null;

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

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (pi != null) pi.SetValue(dgv, setting, null);
        }

          public static string constr = "server=localhost;uid=root;pwd=woshishui;database=test";
          public static MySqlConnection conn = new MySqlConnection(constr);
    }
}