using After_Test.Generic;
using System;
using System.Windows.Forms;

namespace After_Test.Forms
{
    public partial class StationForms : Form
    {
        public static StationForms stationgorms;
        public StationForms(string station)
        {
            InitializeComponent();
            Staiongs = station;
            stationgorms = this;
        }
        StationFor sta = new StationFor();
        public static string Staiongs;
        private void StationForms_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//对齐

            sta.QueryStaion(Staiongs);
            sta.QueryCobox();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staiongs = comboBox1.Text;
            sta.QueryStaion(Staiongs);
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
         sta.IntStaion(Staiongs);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sta.DelectStaion(Staiongs);
        }
    }
}
