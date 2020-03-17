using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using After.Manager;
using After.Model;
using After_Test.Generic;
using CCWin;

namespace After_Test.Forms
{
    public partial class FilesUpload : Skin_Mac
    {
        private UploadingManager uploading = new UploadingManager();

        public static FilesUpload filesUpload;
        public FilesUpload()
        {
            InitializeComponent();
            filesUpload = this;
        }
        FilesUploadFor filesUploadFor = new FilesUploadFor();
        private void FilesUpload_Load(object sender, EventArgs e)
        {
            filesUploadFor.AddCombBox();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //浏览文件夹
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Trim() != "")
                textBox3.Text = folderBrowserDialog1.SelectedPath.Trim();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<uploading> data = uploading.GetName(comboBox1.Text);

            foreach (var sj in data)
            {
                  textBox1.Text = sj.path;
                  textBox3.Text = sj.filepath;
                  foldertozip.Text = sj.foldertozip;
                  zipedfilename.Text = sj.zipedfilename;
            }
            // for (int i = 0; i < data.Count; i++)
            // {
            //      textBox1.Text = data[0];
            //      textBox2.Text = data[0];
            // }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             button1.Text=@"上传中，请稍等";
             button1.Enabled=false;
            string path = textBox1.Text;
            CopyDirs(textBox3.Text, path);
             button1.Text=@"上传";
              button1.Enabled=true;
        }

        private void CopyDirs(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    aimPath += Path.DirectorySeparatorChar;
                }

                // 判断目标目录是否存在如果不存在则新建
                if (!Directory.Exists(aimPath))
                {
                    Directory.CreateDirectory(aimPath);
                }

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles（srcPath）；
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));

                        GenericForm.DisplaylistboxMsg("上传成功");
                    }
                    // 否则直接Copy文件
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                         GenericForm.DisplaylistboxMsg("上传成功");
                    }
                }
            }
            catch (Exception e)
            {
                 GenericForm.DisplaylistboxMsg("上传失败" + e.Message);
            }
        }

        private void CopyDir(string srcPath, string aimPath)
        {
            // 检查目标目录是否以目录分割字符结束如果不是则添加
            if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
            {
                aimPath += Path.DirectorySeparatorChar;
            }

            // 判断目标目录是否存在如果不存在则新建
            if (!Directory.Exists(aimPath))
            {
                Directory.CreateDirectory(aimPath);
            }

            // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
            // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
            // string[] fileList = Directory.GetFiles（srcPath）；
            string[] fileList = Directory.GetFileSystemEntries(srcPath);
            // 遍历所有的文件和目录
            foreach (string file in fileList)
            {
                // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                if (Directory.Exists(file))
                {
                    CopyDir(file, aimPath + Path.GetFileName(file));
                     GenericForm.DisplaylistboxMsg("下载成功");
                }
                // 否则直接Copy文件
                else
                {
                    File.Copy(file, aimPath + Path.GetFileName(file), true);
                     GenericForm.DisplaylistboxMsg("下载成功");
                }
            }
        }

       

        private void 登录_Click(object sender, EventArgs e)
        {
           bool userbool = filesUploadFor.ConnectState(@"\\10.55.2.3",User.Text,Pwd.Text);
           if (userbool)
           {
                GenericForm.DisplaylistboxMsg("登录成功："+User.Text);
           }
           else
           {
                GenericForm.DisplaylistboxMsg("登录失败");
           }
        }

        private void button4_Click(object sender, EventArgs e)
        {
               //浏览文件夹
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Trim() != "")
                textBox4.Text = folderBrowserDialog1.SelectedPath.Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              CopyDir(textBox2.Text, textBox4.Text);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            FilesUploadFor.ZipDirectory(foldertozip.Text,zipedfilename.Text);
            GenericForm.DisplaylistboxMsg("压缩完成");
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            filesUploadFor.UnZip(zipedfilename.Text,"");
             GenericForm.DisplaylistboxMsg("解压缩完成");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FilesUploadFor.ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(textBox1.Text), new StringBuilder(""), new StringBuilder(textBox1.Text), 1);
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FilesUploadFor.ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(foldertozip.Text), new StringBuilder(""), new StringBuilder(foldertozip.Text), 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
             FilesUploadFor.ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(zipedfilename.Text), new StringBuilder(""), new StringBuilder(zipedfilename.Text), 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
             FilesUploadFor.ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(textBox3.Text), new StringBuilder(""), new StringBuilder(textBox3.Text), 1);
        }
    }
}