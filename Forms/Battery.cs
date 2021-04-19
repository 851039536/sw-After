using After.Generic.Generic;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Forms
{
    public partial class Battery : Form
    {
        public Battery()
        {
            InitializeComponent();
        }

        private ClassControl ctl = new ClassControl();
        private float _x;
        private float _x1;
        private float _y;
        private float _y1;
        String strCon = "Data Source=10.175.12.91;Initial Catalog=battery;User ID=battery;Password=batterysql";
        private void Battery_Load(object sender, EventArgs e)
        {

            Control();
            //   uiComboBox1.Items.Add("dbo.[001_00A]");
            uiComboBox1.Items.Add("dbo.[001_05A]");
            uiComboBox1.Items.Add("dbo.BCP002001_00A");
            //   uiComboBox1.Items.Add("dbo.BCP002001_01A");
            uiComboBox1.Items.Add("dbo.BCP002001_02A");
            uiComboBox1.Items.Add("dbo.BCP002001_03A");
            uiComboBox1.Items.Add("dbo.BCP002001_04A");
            uiComboBox1.Items.Add("dbo.BCP002001_05A");
            uiComboBox1.Items.Add("dbo.BCP002001_06A");
            uiComboBox1.Items.Add("dbo.BCP002001_07A");
            uiComboBox1.Items.Add("dbo.BCP002001_08A");
            uiComboBox1.Items.Add("dbo.BCP002001_09A");
            uiComboBox1.Items.Add("dbo.BCP002001_10A");
            //  uiComboBox1.Items.Add("dbo.BCP002001_11A");
            //    uiComboBox1.Items.Add("dbo.BCP002001_12A");
            //     uiComboBox1.Items.Add("dbo.BCP002001_13A");
            //    uiComboBox1.Items.Add("dbo.BCP002001_14A");
            //  uiComboBox1.Items.Add("dbo.BCP002001_OQC");
            //    uiComboBox1.Items.Add("dbo.BCP002001_OQC");
            //     uiComboBox1.Items.Add("dbo.MesBurn");
            //    uiComboBox1.Items.Add("dbo.NewAreBurnIn_Set");
        }

        private void Control()
        {
            dataGridView1.ReadOnly = true;
            //      dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //对齐
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _x = Width;
            _y = Height;
            _x1 = _x;
            _y1 = _y;

            ctl.setTag(this);
            WindowState = FormWindowState.Normal;
        }
        public async Task Commsqls(string name)
        {
            SqlConnection con = new SqlConnection(strCon);
            await con.OpenAsync();
            string sql = "SELECT * FROM" + " " + name;
            //创建命令对象，指定要执行sql语句与连接对象conn
            SqlCommand cmd = new SqlCommand(sql, con);
            //执行查询返回结果集
            SqlDataReader sdr = await cmd.ExecuteReaderAsync();

            BindingSource bs = new BindingSource();
            bs.DataSource = sdr;
            dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = bs;

            con.Close();
        }

        private async void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = uiComboBox1.SelectedItem.ToString();
            await Commsqls(data);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"Excel files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = @"导出Excel文件到";

            DateTime now = DateTime.Now;
            saveFileDialog.FileName = now.Year.ToString().PadLeft(2) + now.Month.ToString().PadLeft(2, '0') + now.Day.ToString().PadLeft(2, '0') + "-" + now.Hour.ToString().PadLeft(2, '0') + now.Minute.ToString().PadLeft(2, '0') + now.Second.ToString().PadLeft(2, '0');
            saveFileDialog.ShowDialog();

            Stream myStream = saveFileDialog.OpenFile();
            StreamWriter sw = new StreamWriter(myStream, Encoding.GetEncoding("utf-8"));
            string str = "";
            try
            {
                //写标题     
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += ",";
                    }

                    str += dataGridView1.Columns[i].HeaderText;
                }

                sw.WriteLine(str);
                //写内容   
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += ",";
                        }

                        tempStr += dataGridView1.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(tempStr);
                }

                sw.Close();
                myStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }
        }
        private void Resizes()
        {
            float newX = Width;
            float newY = Height;
            ctl.setControls(newX / _x, newY / _y, this);
            foreach (DataGridViewTextBoxColumn item in dataGridView1.Columns)
            {
                item.Width = Convert.ToInt16(item.Width * newX / _x1);
            }
            _x1 = newX;
        }
        private void Battery_Resize(object sender, EventArgs e)
        {
            Resizes();
        }
    }
}
