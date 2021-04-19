using CCWin;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using After.Generic.Generic;

namespace After_Test.Forms
{
    public partial class DataRestore : Skin_Mac
    {
        public DataRestore()
        {
            InitializeComponent();
        }

        private void DataRestore_Load(object sender, EventArgs e)
        {
              textBox1.Enabled=false;
                还原.Enabled=false;
        }

        private void 还原_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show(@"确定还原吗？", @"还原", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
              
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = Util.conn;
                            Util. conn.Open();
                            mb.ImportFromFile(textBox1.Text);
                            Util. conn.Close();
                            MessageBox.Show(@"已还原");
                             
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text==@"merry-te")
            {
                textBox1.Enabled=true;
                还原.Enabled=true;
            }
        }
    }
}
