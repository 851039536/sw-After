﻿using After.Generic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Generic
{
   public class GenericForm
    {

        public After.BLL.alltestitem alltestBLL = new After.BLL.alltestitem();
        public After.BLL.testitem testBLL = new After.BLL.testitem();
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
           List<After.Model.alltestitem> miscelist = alltestBLL.LoadTestModel("");
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
               List<After.Model.testitem> miscelist = testBLL.LoadTestStation(Type2.Type1);
                Form1.form1.comboBox1.Items.Clear();
               foreach (After.Model.testitem item in miscelist)
               {
                   Form1.form1.comboBox1.Items.Add(item.测试站别);
               }
               Form1.form1.comboBox1.SelectedIndex = 0;
              // Querycheck(); 自动测试本地修改 暂时废弃
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

        /// <summary>
        /// 加载测试项目
        /// </summary>
        public void SelectindxChan()
        {
            try
            {
                string _testistBox;
                _testistBox = Convert.ToString(Form1.form1.listBox1.SelectedItem); //单击获取当前选中行的内容
                if (_testistBox != "")
                {
                    Form1.form1.listBoxControl3.Items.Clear();
                    Form1.form1.listBoxControl2.Items.Clear();
                     ComboBox1SelectedIndexChanged();
                    // Querycheck();
                    List<After.Model.alltestitem> alllist = alltestBLL.LoadTestProject(Type2.Type1);
                    foreach (After.Model.alltestitem item in alllist)
                    {
                        Form1.form1.listBoxControl3.Items.Add(item.测试项目);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 测试项目  条件（测试站别）
        /// </summary>
        public void ComboBox1SelectedIndexChanged()
        {
            Form1.form1.listBoxControl2.Items.Clear();
            List<After.Model.testitem> alllist = testBLL.GetTestitemProject(Type2.Type1, Form1.form1.comboBox1.Text);
          //  string dete = "select 测试项目 from testitem where 测试站别 = '" + comboBox1.Text + "'and 机型 = '" + Type2.Type1 + "'order by 编号 ASC";
          foreach (var testitem in alllist)
          {
              Form1.form1.listBoxControl2.Items.Add(testitem.测试项目);
            }
        }

        /// <summary>
        /// 增加按钮
        /// </summary>
        public void butAdd()
        {
            string name = Convert.ToString(Form1.form1.listBoxControl3.SelectedItem); //双击击获取当前选中行的内容
            foreach (string item in Form1.form1.listBoxControl2.Items)
            {
                if (name == item)
                {
                    return;
                }

            }
            Form1.form1.listBoxControl2.Items.Add(name);
        }

        /// <summary>
        /// 删除按键
        /// </summary>
        public void butDelete()
        {
            if (Form1.form1.listBoxControl2.SelectedItem != null)
            {
                Form1.form1.listBoxControl2.Items.Remove(Form1.form1.listBoxControl2.SelectedItem);
                if (Form1.form1.listBoxControl2.Items.Count > 0)
                {
                    //默认选中第一行
                    Form1.form1.listBoxControl2.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show(@"未选中");
            }
        }

        /// <summary>
        /// 上移按键
        /// </summary>
        public void butUP()
        {
            int index = Form1.form1.listBoxControl2.SelectedIndex;
            if (index > 0)
            {
                object item = Form1.form1.listBoxControl2.SelectedItem;
                Form1.form1.listBoxControl2.Items.Remove(item);
                Form1.form1.listBoxControl2.Items.Insert(index - 1, item);
                Form1.form1.listBoxControl2.SelectedIndex = index - 1;
            }
        }

        /// <summary>
        /// 下移按键
        /// </summary>
        public void butDOWN()
        {
            try
            {
                int index = Form1.form1.listBoxControl2.SelectedIndex;
                if (index < Form1.form1.listBoxControl2.Items.Count - 1)
                {

                    object item = Form1.form1.listBoxControl2.SelectedItem;
                    Form1.form1.listBoxControl2.Items.Remove(item);
                    Form1.form1.listBoxControl2.Items.Insert(index + 1, item);
                    Form1.form1.listBoxControl2.SelectedIndex = index + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool _locker = true;
        /// <summary>
        /// 锁定按钮
        /// </summary>
        public void butLock()
        {
           
            if (_locker)
            {
                Form1.form1.listBoxControl2.Enabled = false;
                Form1.form1.listBoxControl3.Enabled = false;
                Form1.form1.ADD.Enabled = false;
                Form1.form1.DELETE.Enabled = false;
                Form1.form1.UP.Enabled = false;
                Form1.form1.DOWN.Enabled = false;
                Form1.form1.SAVE.Enabled = true;
                Form1.form1.LOCK.Text = @"解除锁定";
                _locker = false;
                Form1.form1.checkBox1.Enabled = false;
                Form1.form1.comboBox1.Enabled = false;
            }
            else
            {
                Form1.form1.listBoxControl2.Enabled = true;
                Form1.form1.listBoxControl3.Enabled = true;
                Form1.form1.ADD.Enabled = true;
                Form1.form1.DELETE.Enabled = true;
                Form1.form1.UP.Enabled = true;
                Form1.form1.DOWN.Enabled = true;
                Form1.form1.SAVE.Enabled = false;
                Form1.form1.LOCK.Text = @"锁定";
                _locker = true;
                Form1.form1.checkBox1.Enabled = true;
                Form1.form1.comboBox1.Enabled = true;
            }
        }
    }
}
