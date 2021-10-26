using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace After_Test.Forms.Interface
{
    public partial class BatteryUnbundle : Skin_Mac
    {
        public BatteryUnbundle()
        {
            InitializeComponent();
        }

        private void BatteryUnbundle_Load(object sender, EventArgs e)
        {

        }
        String strCon = "Data Source=10.175.12.91;Initial Catalog=battery;User ID=battery;Password=batterysql";
        String strCon1 = "Data Source=127.0.0.1;Initial Catalog=battery;User ID=sa;Password=woshishui";
        private async void uiButton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strCon);
            await con.OpenAsync();
            string sql = "SELECT  Cell_BarCode  FROM BCP002001_00A  WHERE  PCM_BarCode =" + uiTextPcba.Text;
            SqlCommand cmd = new SqlCommand(sql, con);
            uiTextDcx.Text = (string)await cmd.ExecuteScalarAsync();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string MyUpdate = "Update BCP002001_00A set Cell_BarCode=''  where PCM_BarCode=" + uiTextPcba.Text ;
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand MyCommand = new SqlCommand(MyUpdate, con);
            try
            {
                con.Open();
                var result =   MyCommand.ExecuteNonQuery();
                if (result==1)
                {
                    MessageBox.Show("解绑成功");
                }
                else
                {
                    MessageBox.Show("失败");
                }
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
