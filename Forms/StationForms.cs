using System;
using System.Windows.Forms;
using After.Generic;
using After_Test.Generic;
using CCWin;

namespace After_Test.Forms
{
    public partial class StationForms : Skin_Mac
    {
        public static StationForms Stationgorms;
        private static string Staiongs;
        private StationFor sta = new StationFor();

        public StationForms(string station)
        {
            InitializeComponent();
            Staiongs = station;
            Stationgorms = this;
        }

         private ClassControl ctl = new ClassControl();
        private void StationForms_Load(object sender, EventArgs e)
        {
    

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //对齐

            
            sta.QueryStaion(Staiongs);
            sta.QueryCobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staiongs = StaionBox.Text;
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

        private void StationForms_Resize(object sender, EventArgs e)
        {
            
        }
    }
}