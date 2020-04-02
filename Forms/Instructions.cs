using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace After_Test.Forms
{
    public partial class Instructions : Skin_Mac
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
       
              webBrowser1.Navigate( @"C:\Users\CH190006\Desktop\Test\winfrom\After\After-Test\bin\Debug\mysql\测试后台管理系统.html");

        }
    }
}
