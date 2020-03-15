using After.Manager;
using After.Model;
using After_Test.Forms;
using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Generic
{
    class FilesUploadFor
    {
        private UploadingManager uploading = new UploadingManager();

        /// <summary>
        /// 加載name
        /// </summary>
        public void AddCombBox()
        {
             List<uploading> data = uploading.Query();
            foreach (var data1 in data)
            {
                FilesUpload.filesUpload.comboBox1.Items.Add(data1.name);
            }
             FilesUpload.filesUpload.comboBox1.SelectedIndex = 0;
        }

        /// <summary>
        /// 登录权限
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
          public  bool ConnectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
              DisplaylistboxMsg(ex.Message);
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }


         public void DisplaylistboxMsg(string msg)
        {
            if (FilesUpload.filesUpload.InvokeRequired)
            {
                FilesUpload.filesUpload.Invoke(new Action<string>(DisplaylistboxMsg), msg);
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    FilesUpload.filesUpload.skinListBox1.Items.Add(new SkinListBoxItem("\r\n"));
                }
                else
                {
                    FilesUpload.filesUpload.skinListBox1.Items.Add(new SkinListBoxItem(string.Format("At {0:hh:mm:ss},{1}", DateTime.Now, msg)));
                }

                if (FilesUpload.filesUpload.skinListBox1.Items.Count > 0) FilesUpload.filesUpload.skinListBox1.SelectedIndex = FilesUpload.filesUpload.skinListBox1.Items.Count - 1;
                Application.DoEvents();
            }
        }
    }
}
