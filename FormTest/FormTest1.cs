using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.FormTest
{
    public partial class FormTest1 : Form
    {
        public FormTest1()
        {
            InitializeComponent();
        }

          //重写API函数
        [DllImport("user32.dll", EntryPoint = "GetDoubleClickTime")]
        public extern static int GetDoubleClickTime();
        private void FormTest1_Load(object sender, EventArgs e)
        {
            label1.Text = GetDoubleClickTime()+"毫秒";//显示双击鼠标的时间间隔
        }
    }
}
