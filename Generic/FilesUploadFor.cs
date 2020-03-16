using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using After.Manager;
using After.Model;
using After_Test.Forms;
using CCWin.SkinControl;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip;

namespace After_Test.Generic
{
    internal class FilesUploadFor
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
        public bool ConnectState(string path, string userName, string passWord)
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
               GenericForm.DisplaylistboxMsg(ex.Message);
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }

            return Flag;
        }


        // public void DisplaylistboxMsg(string msg)
        // {
        //     if (FilesUpload.filesUpload.InvokeRequired)
        //     {
        //         FilesUpload.filesUpload.Invoke(new Action<string>(DisplaylistboxMsg), msg);
        //     }
        //     else
        //     {
        //         if (msg.Contains("\r\n"))
        //         {
        //             FilesUpload.filesUpload.skinListBox1.Items.Add(new SkinListBoxItem("\r\n"));
        //         }
        //         else
        //         {
        //             FilesUpload.filesUpload.skinListBox1.Items.Add(new SkinListBoxItem(string.Format("At {0:hh:mm:ss},{1}", DateTime.Now, msg)));
        //         }
        //
        //         if (FilesUpload.filesUpload.skinListBox1.Items.Count > 0) FilesUpload.filesUpload.skinListBox1.SelectedIndex = FilesUpload.filesUpload.skinListBox1.Items.Count - 1;
        //         Application.DoEvents();
        //     }
        // }


       //===================================================压缩用的是库函数
       /// <summary>
       /// 压缩文件夹
       /// </summary>
       /// <param name="folderToZip">需要压缩的文件夹</param>
       /// <param name="zipedFileName">压缩后的Zip完整文件名</param>
        public static void ZipDirectory(string folderToZip, string zipedFileName)
        {
            ZipDirectory(folderToZip, zipedFileName, string.Empty, true, string.Empty, string.Empty, true);
        }
 
 
        /// <summary>
        /// 压缩文件夹
        /// </summary>
        /// <param name="folderToZip">需要压缩的文件夹</param>
        /// <param name="zipedFileName">压缩后的Zip完整文件名（如D:\test.zip）</param>
        /// <param name="isRecurse">如果文件夹下有子文件夹，是否递归压缩</param>
        /// <param name="password">解压时需要提供的密码</param>
        /// <param name="fileRegexFilter">文件过滤正则表达式</param>
        /// <param name="directoryRegexFilter">文件夹过滤正则表达式</param>
        /// <param name="isCreateEmptyDirectories">是否压缩文件中的空文件夹</param>
 
        public static void ZipDirectory(string folderToZip, string zipedFileName, string password, bool isRecurse, string fileRegexFilter, string directoryRegexFilter, bool isCreateEmptyDirectories)
        {
            FastZip fastZip = new FastZip();
            fastZip.CreateEmptyDirectories = isCreateEmptyDirectories;
            fastZip.Password = password;
            fastZip.CreateZip(zipedFileName, folderToZip, isRecurse, fileRegexFilter, directoryRegexFilter);
        }



         //===================================================解压用的是库函数
        /// <summary>  
        /// 功能：解压zip格式的文件。  
        /// </summary>  
        /// <param name="zipFilePath">压缩文件路径</param>  
        /// <param name="unZipDir">解压文件存放路径,为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹</param>  
        /// <returns>解压是否成功</returns>  
        public void UnZip(string zipFilePath, string unZipDir)
        {
            if (zipFilePath == string.Empty)
            {
                throw new Exception("压缩文件不能为空！");
            }
            if (!File.Exists(zipFilePath))
            {
                throw new FileNotFoundException("压缩文件不存在！");
            }
            //解压文件夹为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹  
            if (unZipDir == string.Empty)
                unZipDir = zipFilePath.Replace(Path.GetFileName(zipFilePath), Path.GetFileNameWithoutExtension(zipFilePath));
            if (!unZipDir.EndsWith("/"))
                unZipDir += "/";
            if (!Directory.Exists(unZipDir))
                Directory.CreateDirectory(unZipDir);
 
            using (var s = new ZipInputStream(File.OpenRead(zipFilePath)))
            {
 
                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);
                    if (!string.IsNullOrEmpty(directoryName))
                    {
                        Directory.CreateDirectory(unZipDir + directoryName);
                    }
                    if (directoryName != null && !directoryName.EndsWith("/"))
                    {
                    }
                    if (fileName != String.Empty)
                    {
                        using (FileStream streamWriter = File.Create(unZipDir + theEntry.Name))
                        {
 
                            int size;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = s.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    streamWriter.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }


    }
}