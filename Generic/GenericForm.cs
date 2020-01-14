using After.Generic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Generic
{
   public class GenericForm
    {
       
        
        /// <summary>
        /// 首次加载初始化
        /// </summary>
        public void Firstload()
        {
           
           Form1.form1.contextMenuStrip2.Enabled = false;
           Form1.form1.SAVE.Enabled = false;
           Form1.form1.timer1.Interval = 1000;
           Form1.form1.timer1.Enabled = true;
           Form1.form1.label1.Text = After.Generic.Type2.User1; //用户
           Form1.form1.label4.Text = @"注:左边为待选功能，右边为需要测试的功能先锁定再更新保存";
           Form1.form1.label4.ForeColor = Color.Red;
            _x = Form1.form1.Width;
            _y = Form1.form1.Height;
            _x1 = _x;
            _y1 = _y;
          
        }

       
       public static float _x = 0;
       public static float _y = 0;
       public static float _x1 = 0;
       public static float _y1 = 0;
    }
}
