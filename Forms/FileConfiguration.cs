using System;
using System.Threading;
using System.Windows.Forms;
using After.Generic.Generic;
using After.Manager.Manager;
using After.Model;
using After_Test.Generic;
using CCWin;
using SqlSugar.Extensions;

namespace After_Test.Forms
{
    public partial class FileConfiguration : Skin_Mac
    {
        public static FileConfiguration fileConfiguration;

        private UploadingManager uploading = new UploadingManager();

        public FileConfiguration()
        {
            InitializeComponent();
            fileConfiguration = this;
        }
         private ClassControl ctl = new ClassControl();
        private void FileConfiguration_Load(object sender, EventArgs e)
        {
             GenericForm.x = GenericForm.Form1.Width;
             GenericForm.y = GenericForm.Form1.Height;
             GenericForm.x1 =GenericForm .x;
             GenericForm.y1 = GenericForm.y;
             ctl.setTag(this);

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //对齐
            Query();
        }

        public void Query()
        {
            try
            {
                var data = uploading.Uploadingdb.GetList();
                dataGridView1.DoubleBuffered(true);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButInst();
        }

        public void ButInst()
        {
            skinButton1.Visible = true;
            skinPanel1.Visible = true;
            skinButton2.Visible = false;
            name.Text = "";
            foldertozip.Text = "";
            localitypath.Text = "";
            zipedfilename.Text = "";
            filepath.Text = "";
            zipedfilename2.Text = @"D:\程序";
            path.Text = @"\\10.55.2.3\mech部門資料夾\工程部\工程課\TE測試文件\1_MECH產線測試程序匯總-2018-2019\";
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            skinPanel1.Visible = false;
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinButton2.Visible = true;
            skinButton1.Visible = false;
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            Updateuploading();
        }

        /// <summary>
        /// 更新 w：id
        /// </summary>
        public void Updateuploading()
        {
            Thread.Sleep(1000);
            // 只更新Name列和CreateTime列，其它列不更新，条件id=1
            bool test = uploading.Uploadingdb.Update(it => new uploading
            {
                name = name.Text,
                foldertozip = foldertozip.Text,
                localitypath = localitypath.Text,
                zipedfilename = zipedfilename.Text,
                filepath = filepath.Text,
                zipedfilename2 = zipedfilename2.Text,
                path = path.Text
            }, it => it.id == Convert.ToInt32(id.Text));
            if (test)
            {
                GenericForm.DisplaylistboxMsg("已更新：" + name.Text + " id值：" + id.Text);
                Query();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdataGrid(e);
        }

        private void UpdataGrid(DataGridViewCellEventArgs e)
        {
            skinButton2.Visible = true;
            skinButton1.Visible = false;
            skinPanel1.Visible = true;
            int ids = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ObjToInt(); //获取选中行指定列的值
            id.Text = ids.ToString();
            var data = uploading.Uploadingdb.GetById(ids);
            name.Text = data.name;
            foldertozip.Text = data.foldertozip;
            localitypath.Text = data.localitypath;
            zipedfilename.Text = data.zipedfilename;
            filepath.Text = data.filepath;
            zipedfilename2.Text = data.zipedfilename2;
            path.Text = data.path;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (Isnull())
            {
                return;
            }

            InstFile();
        }

        private bool Isnull()
        {
            if (name.Text == "" || foldertozip.Text == "" || localitypath.Text == "" || zipedfilename.Text == "" || filepath.Text == "" || zipedfilename2.Text == "" || path.Text == "")
            {
                MessageBox.Show(@"不能为空");
                return true;
            }

            return false;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        public void InstFile()
        {
            int ints = uploading.Db.Insertable<uploading>(new
            {
                name = name.Text,
                foldertozip = foldertozip.Text,
                localitypath = localitypath.Text,
                zipedfilename = zipedfilename.Text,
                filepath = filepath.Text,
                zipedfilename2 = zipedfilename2.Text,
                path = path.Text
            }).ExecuteCommand();

            if (ints > 0)
            {
                GenericForm.DisplaylistboxMsg("新增成功：" + name.Text);
            }

            Query();
        }

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void FileConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FileConfiguration_Resize(object sender, EventArgs e)
        {
            ClassControl control = new ClassControl();
            float newX =Width;
            float newY =Height;
            control.setControls(newX / GenericForm.x, newY / GenericForm.y, this);
        }
    }
}