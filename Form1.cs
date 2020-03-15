﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using After.Generic;
using After_Test.Forms;
using After_Test.Generic;
using CCWin;
using CCWin.SkinControl;
using DBUtility;

namespace After_Test
{
    public partial class Form1 : Skin_Mac
    {
        public static Form1 form1;
        private AlltestitemManager alltestitem = new AlltestitemManager();

        private ClassControl ctl = new ClassControl();

        private GenericForm genericForm = new GenericForm();

        private TestitemManager testitem = new TestitemManager();
        private UserManager user = new UserManager();

        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        /// <summary>
        /// 权限
        /// </summary>
        private void Jurisdiction()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Jurisdiction();
            genericForm.Firstload();
            ctl.setTag(this);
            form1.WindowState = FormWindowState.Normal;

            genericForm.DisplaylistboxMsg("初始化完成！！！");
            genericForm.Loadcontrol();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ClassControl control = new ClassControl();
            float newX = form1.Width;
            float newY = form1.Height;
            control.setControls(newX / GenericForm._x, newY / GenericForm._y, this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.ComboBox1SelectedIndexChanged();
        }

        /// <summary>
        /// 增加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ADD_Click(object sender, EventArgs e)
        {
            genericForm.butAdd();
        }

        private void listBoxControl3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            genericForm.butAdd();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            genericForm.butDelete();
        }

        private void UP_Click(object sender, EventArgs e)
        {
            genericForm.butUP();
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            genericForm.butDOWN();
        }

        private void LOCK_Click(object sender, EventArgs e)
        {
            genericForm.butLock();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Type2.Type1 == null)
            {
                MessageBox.Show(@"未选择站别");
            }
            else
            {
                StationForms st = new StationForms(Type2.Type1);
                await Task.Run(() => st.ShowDialog());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.SelectindxChanListbox3();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (skinComboBox1.Text.Equals(""))
            {
                MessageBox.Show(@"站别不能为空");
                return;
            }

            bool test = testitem.DeleteSave(skinComboBox1.Text, Type2.Type1);
            if (test)
            {
                LinkedList<string> ate = new LinkedList<string>();

                SkinListBoxItemCollection ss = form1.skinListBox2.Items;

                for (int i = 0; i < ss.Count; i++)
                {
                    ate.AddLast(ss[i].ToString());
                }

                //foreach (string item in listBoxControl2.Items)
                //{
                //    ate.AddLast(item);
                //}

                int zt = alltestitem.Sqlselect(skinComboBox1.Text, Type2.Type1, ate);
                if (zt == 1)
                {
                    genericForm.DisplaylistboxMsg("站别：" + skinComboBox1.Text + "," + "机型：" + Type2.Type1 + "," + "更新完成");
                }
                else
                {
                    genericForm.DisplaylistboxMsg("更新失败,站别被删除");
                }
            }

            //genericForm.SelectindxChanListbox3();
        }


        private async void 路径配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type2.Miscellaneous = 2;
            DateGridviews date = new DateGridviews();
            await Task.Run(() => date.ShowDialog());
        }

        private async void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alltestitem a = new Alltestitem();
            await Task.Run(() => a.ShowDialog());
        }

        private void 云盘ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 文件上传ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilesUpload f = new FilesUpload();
            f.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private async void skinButton1_Click(object sender, EventArgs e)
        {
            if (Type2.Type1 == null)
            {
                MessageBox.Show(@"未选择站别");
            }
            else
            {
                StationForms st = new StationForms(Type2.Type1);
                await Task.Run(() => st.ShowDialog());
            }
        }

        private void skinListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.SelectindxChanListbox3();
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genericForm.ComboBox1SelectedIndexChanged();
        }

        private void skinListBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            genericForm.butAdd();
        }

        private async void config配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type2.Miscellaneous = 2;
            DateGridviews date = new DateGridviews();
            await Task.Run(() => date.ShowDialog());
        }

        private async void 功能配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alltestitem a = new Alltestitem();
            await Task.Run(() => a.ShowDialog());
        }

        private void 文件上传ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FilesUpload f = new FilesUpload();
            f.ShowDialog();
        }

        private void listBoxControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}