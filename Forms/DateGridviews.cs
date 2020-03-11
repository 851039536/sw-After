using After.Generic;
using After.Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using After.Model;

namespace After_Test.Forms
{
    public partial class DateGridviews : Form
    {
        public DateGridviews()
        {
            InitializeComponent();
        }

        ClassControl ctl = new ClassControl();
        float X = 0;
        float Y = 0;
        float x1 = 0;
        float y1 = 0;

        private void DateGridviews_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //对齐
            panel1.Visible = false; //隐藏面板
            Test();
            dataGridView1.ReadOnly = true;
            X = Width;
            Y = Height;
            x1 = X;
            y1 = Y;

            ctl.setTag(this);
            WindowState = FormWindowState.Normal;
        }

        public void Test()
        {
            switch (Type2.Miscellaneous)
            {
                case 1:
                    CoboxMis();
                    //  QueryMis();
                    break;
                case 2:
                    Cobox();
                    QueryConfig();
                    break;
            }
        }

        MiscellaneousManager miscellaneous = new MiscellaneousManager();
        configManager config = new configManager();

        /// <summary>
        /// 查询所有
        /// </summary>
        public void QueryConfig()
        {
            try
            {
                var data = config.configDb.GetList();
                dataGridView1.DoubleBuffered(true);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Config机型
        /// </summary>
        public void Cobox()
        {
            var types = config.QueryConfig();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < types.Count; i++)
            {

                comboBox1.Items.Add(types[i]);
                comboBox2.Items.Add(types[i]);

            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        public void CoboxMis()
        {
            List<string> types = miscellaneous.QueryType();
            comboBox1.Items.Clear();

            for (int i = 0; i < types.Count; i++)
            {
                comboBox1.Items.Add(types[i]);
            }

            comboBox1.SelectedIndex = 0;

        }

        private void DateGridviews_Resize(object sender, EventArgs e)
        {
            float newX = Width;
            float newY = Height;
            ctl.setControls(newX / X, newY / Y, this);
            foreach (DataGridViewTextBoxColumn item in dataGridView1.Columns)
            {
                item.Width = Convert.ToInt16((item.Width * newX) / x1);
            }

            x1 = newX;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type2.Miscellaneous == 1)
            {
                try
                {
                    //mysql.conn.Open();
                    //MySqlDataAdapter sda = new MySqlDataAdapter("select * from miscellaneous where 型号='" + comboBox1.Text + "'", mysql.conn);//
                    //DataTable table = new DataTable();
                    //sda.Fill(table);//填充数据库
                    //dataGridView1.DoubleBuffered(true);
                    //dataGridView1.DataSource = table;
                    //mysql.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Type2.Miscellaneous == 2)
            {
                try
                {
                    var data = config.configDb.GetList(c => c.ConfigText == comboBox1.Text);
                    // MySqlDataAdapter sda = new MySqlDataAdapter("select * from config where ConfigText='" + comboBox1.Text + "'", mysql.conn);//
                    dataGridView1.DoubleBuffered(true);
                    dataGridView1.DataSource = data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //if (Type2.Miscellaneous == 1) QueryMis();
            if (Type2.Miscellaneous == 2) QueryConfig();
        }

        bool _databaseflag;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Cobox();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Type2.Miscellaneous == 2)
            {
                try
                {
                    string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText; //获取列标题
                    string assetsId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(); //获取焦点触发行的第一个值
                    string value = dataGridView1.CurrentCell.Value.ToString(); //获取当前点击的活动单元格的值
                    string strcomm = "update config set " + strcolumn + "='" + value + "'where ConfigText = '" +
                                     assetsId + "'";
                    // 只更新Name列和CreateTime列，其它列不更新，条件id=1
                    //    config.configDb.Update(it => new config() { strcolumn = "a"}, it => it.id == Convert.ToInt32(assetsId));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<config> data = config.configDb.GetList(c => c.ConfigText == comboBox2.Text);

            foreach (var data1 in data)
            {
              id.Text =  data1.id.ToString();
              ConfigText.Text = data1.ConfigText;
              HPID.Text = data1.HPID;
              HVID.Text = data1.HVID;
              Music.Text = data1.Music;
              NAME.Text = data1.NAME;
              Player.Text = data1.Player;
              DPID.Text = data1.DPID;
              DVID.Text = data1.DVID;
              Delay.Text = data1.Delay.ToString();
              barcode.Text = data1.barcode.ToString();
              count.Text = data1.count.ToString();
              testflag.Text = data1.testflag.ToString();

            }
           

        }
    }
};
