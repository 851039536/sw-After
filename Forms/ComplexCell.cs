using After.Generic.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Forms
{
    public partial class ComplexCell : Form
    {
        public ComplexCell()
        {
            InitializeComponent();
        }
        private ClassControl ctl = new ClassControl();
        private float _x;
        private float _x1;
        private float _y;
        private float _y1;
        String strCon = "Data Source=10.175.12.91;Initial Catalog=ComplexCell;User ID=battery;Password=batterysql";
        String strCon1 = "Data Source=127.0.0.1;Initial Catalog=ComplexCell;User ID=sa;Password=woshishui";
        private void ComplexCell_Load(object sender, EventArgs e)
        {
            Control();
            uiComboBox1.Items.Add("dbo.BCP002_T1_0");
            uiComboBox1.Items.Add("dbo.BCP002_T1_2");
            uiComboBox1.Items.Add("dbo.BCP002_T1_3");
            uiComboBox1.Items.Add("dbo.BCP002_T1_4");
            uiComboBox1.Items.Add("dbo.BCP002_T3_0");
            uiComboBox1.Items.Add("dbo.BCP002_T3_1");

        }

        private void Control()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _x = Width;
            _y = Height;
            _x1 = _x;
            _y1 = _y;

            ctl.setTag(this);
            WindowState = FormWindowState.Normal;
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
        private void ComplexCell_Resize(object sender, EventArgs e)
        {
            Resizes();
        }

        private async void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            num = 0;
            var data = uiComboBox1.SelectedItem.ToString();
            await Commsqls(data, num);
        }
        public async Task Commsqls(string name, int num)
        {
            SqlConnection con = new SqlConnection(strCon);
            await con.OpenAsync();
            string sql = "SELECT  * FROM" + " " + name + " ORDER BY [EventDateTime] DESC OFFSET " + num + " ROWS FETCH NEXT 1000 ROWS ONLY";
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
        int num;
        private async void uiButton2_Click(object sender, EventArgs e)
        {
            var data = uiComboBox1.SelectedItem.ToString();
            num += 1000;
            await Commsqls(data, num);
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

        private async void uiButton3_Click(object sender, EventArgs e)
        {

            for (int i = 9; i <= 15; i++)
            {
                SqlConnection MyConnection = new SqlConnection(strCon);
                string name = "";
                switch (i)
                {
                    //    case 9: name = "無磁鐵GP"; break;
                    //    case 10: name = "磁鐵GP"; break;
                    //    case 11: name = "未按按鍵GP"; break;
                    //    case 12: name = "按鍵GP"; break;
                    //    case 13: name = "按鍵恢復GP"; break;
                    //    case 14: name = "L-輸出電壓"; break;
                    //    case 15: name = "R-輸出電壓"; break;
                    case 9: name = "No magnet GP"; break;
                    case 10: name = "magnet GP"; break;
                    case 11: name = "No buttons GP"; break;
                    case 12: name = "buttons GP"; break;
                    case 13: name = "Button to restore GP"; break;
                    case 14: name = "L-output voltage"; break;
                    case 15: name = "R-input voltage"; break;

                }
                string MyUpdate = "Update dbo.BCP002_T1_2 set TestName='" + name + "'  where TestOrderNumber='" + i + "'";
                SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
                try
                {
                    MyConnection.Open();
                    MyCommand.ExecuteNonQuery();
                    MyConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            SqlConnection con = new SqlConnection(strCon1);
            await con.OpenAsync();
            string sql = "SELECT 	BCP002_T1_2.TestOrderNumber,  	BCP002_T1_2.TestName FROM 	dbo.BCP002_T1_2 WHERE 	BCP002_T1_2.TestOrderNumber = 9 OR 	BCP002_T1_2.TestOrderNumber = 10 AND 	BCP002_T1_2.TestOrderNumber = 11 OR 	BCP002_T1_2.TestOrderNumber = 12 OR 	BCP002_T1_2.TestOrderNumber = 13 OR 	BCP002_T1_2.TestOrderNumber = 14 OR 	BCP002_T1_2.TestOrderNumber = 15";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader sdr = await cmd.ExecuteReaderAsync();
            BindingSource bs = new BindingSource();
            bs.DataSource = sdr;
            dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = bs;
            con.Close();
        }
        private async void uiButton4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 16; i++)
            {
                SqlConnection MyConnection = new SqlConnection(strCon);
                string name = "";
                switch (i)
                {
                    case 2:
                        name = "colour"; Upsql(i, MyConnection, name);
                        Upsql2(i, MyConnection, "black");
                        break;
                    case 4: name = "no magnet GP"; Upsql(i, MyConnection, name); break;
                    case 5: name = "magnet GP"; Upsql(i, MyConnection, name); break;
                    case 6: name = "no magnet recover GP"; Upsql(i, MyConnection, name); break;
                    case 7: name = "No buttons GP"; Upsql(i, MyConnection, name); break;
                    case 8: name = "buttons GP"; Upsql(i, MyConnection, name); break;
                    case 9: name = "buttons recover GP"; Upsql(i, MyConnection, name); break;
                    case 16: name = "magnet GP"; Upsql(i, MyConnection, name); break;
                }
            }
            SqlConnection con = new SqlConnection(strCon1);
            await con.OpenAsync();
            string sql = "SELECT 	BCP002_T3_1.TestOrderNumber,  	BCP002_T3_1.TestName,  	BCP002_T3_1.TestResponse,  	BCP002_T3_1.MaxSpecLimit FROM 	dbo.BCP002_T3_1";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader sdr = await cmd.ExecuteReaderAsync();
            BindingSource bs = new BindingSource();
            bs.DataSource = sdr;
            dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = bs;
            con.Close();
        }

        private static void Upsql(int i, SqlConnection MyConnection, string name)
        {
            string MyUpdate = "Update dbo.BCP002_T3_1 set TestName='" + name + "'  where TestOrderNumber='" + i + "'";
            SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void Upsql2(int i, SqlConnection MyConnection, string name)
        {
            string MyUpdate = "Update dbo.BCP002_T3_1 set TestResponse='" + name + "', MaxSpecLimit='" + name + "'  where TestOrderNumber='" + i + "'";
            SqlCommand MyCommand = new SqlCommand(MyUpdate, MyConnection);
            try
            {
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
