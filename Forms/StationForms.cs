using System;
using System.Windows.Forms;
using After.Generic.Generic;
using After_Test.Generic;
using CCWin;

namespace After_Test.Forms
{
    public partial class StationForms : Skin_Mac
    {
        public static StationForms Stationgorms;
        private static string _staiongs;
        private StationFor sta = new StationFor();

        public StationForms(string station)
        {
            InitializeComponent();
            _staiongs = station;
            Stationgorms = this;
        }

         private ClassControl _ctl = new ClassControl();
        private void StationForms_Load(object sender, EventArgs e)
        {
    

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //对齐

            
            sta.QueryStaion(_staiongs);
            sta.QueryCobox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _staiongs = StaionBox.Text;
            sta.QueryStaion(_staiongs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sta.IntStaion(_staiongs);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sta.DelectStaion(_staiongs);
        }

        private void StationForms_Resize(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _staiongs = listBox1.SelectedItem.ToString();
            sta.QueryStaion(_staiongs);
        }
    }
}