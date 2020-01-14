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

        public After.BLL.alltestitem alltestBLL = new After.BLL.alltestitem();
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


       /// <summary>
       /// 加载测试机型
       /// </summary>
       public void Loadcontrol()
       {
          // List<After.Model.alltestitem> miscelist = alltestBLL.GetModelList("");
           List<After.Model.alltestitem> miscelist = alltestBLL.GetModelList("");
            int i = 0;
            foreach (After.Model.alltestitem item in miscelist)
           {
               string y = item.机型;
              Form1.form1.型号ToolStripMenuItem.DropDownItems.Add(y);
                // 型号ToolStripMenuItem.DropDownItems[i].Image = image;
                Form1.form1.型号ToolStripMenuItem.DropDownItems[i].Click += Tests;
               i++;
           }

        }

       /// <summary>
       /// 点击事件
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void Tests(object sender, EventArgs e)
       {
           Form1.form1.listBoxControl2.Visible = true;
           Form1.form1.listBox1.Items.Clear();
           ToolStripItem items = (ToolStripItem)sender;
           Type2.Type1 = Convert.ToString(items);
           TextName(Type2.Type1);
           try
           {
               string dete = "select distinct 测试站别 from testitem where 机型 = '" + Type2.Type1 + "'";
              // LinkedList<string[]> a = Sqlselect(dete);
               Form1.form1.comboBox1.Items.Clear();
               //foreach (string[] item in a)
               //{
               //    Form1.form1.comboBox1.Items.Add(item[0]);
               //}
               Form1.form1.comboBox1.SelectedIndex = 0;
              // Querycheck();
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }
       private void TextName(string name)
       {
           Form1.form1.contextMenuStrip2.Enabled = true;
           Form1.form1.listBox1.Items.Add(name + "测试项目");
           Form1.form1.listBox1.Items.Add(name + "数据");
           Form1.form1.listBox1.SelectedIndex = 0;
       }
    }
}
