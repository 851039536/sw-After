﻿using System;
using System.Windows.Forms;

namespace After_Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());
			Application.Run(new LoginForm());
			//Application.Run(new Forms.ModelsForm());
		}
    }
}
