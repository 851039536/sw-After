using After.Generic;
using After.Manager;
using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Forms
{
    public partial class FileConfiguration : Skin_Mac
    {
       public static FileConfiguration fileConfiguration; 
        public FileConfiguration()
        {
            InitializeComponent();
            fileConfiguration =this;
        }

        UploadingManager uploading = new UploadingManager();
        private void FileConfiguration_Load(object sender, EventArgs e)
        {
             try
            {
                var data = uploading.uploadingdb.GetList();
                dataGridView1.DoubleBuffered(true);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
