using DBUtility;
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
    public partial class StationForms : Form
    {
        public StationForms(string station)
        {
            InitializeComponent();
            Staiongs = station;
        }
        TestitemManager testitem = new TestitemManager();
        public static string Staiongs;
        private void StationForms_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//对齐
            DataTable data = testitem.QueryStaion(Staiongs);
            //dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = data;
            List<string> data1 =testitem.QueryCobox();

            comboBox1.Items.Clear();
            for (int i = 0; i < data1.Count; i++)
            {
                comboBox1.Items.Add(data1[i]);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staiongs = comboBox1.Text;
            DataTable data = testitem.QueryStaion(Staiongs);
            //dataGridView1.DoubleBuffered(true);
            dataGridView1.DataSource = data;
        }
    }
}
