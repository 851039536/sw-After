using After.Generic;
using After.Manager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using After_Test.Generic;

namespace After_Test.Forms
{
    public partial class DateGridviews : Form
    {

        public static DateGridviews dategridviews;
        public DateGridviews()
        {
            InitializeComponent();
            dategridviews = this;
        }

        ClassControl ctl = new ClassControl();
        float X = 0;
        float Y = 0;
        float x1 = 0;
        float y1 = 0;

        DateGridviewsFor date = new DateGridviewsFor();

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
                   // CoboxMis();
                    //  QueryMis();
                    break;
                case 2:
                    date.Cobox();
                    date.QueryConfig();
                    break;
            }
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
            if (Type2.Miscellaneous == 2)
            {
                date.QueryIfJX();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //if (Type2.Miscellaneous == 1) QueryMis();
            if (Type2.Miscellaneous == 2) date.QueryConfig();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            date.Cobox();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            date.QueryListIfJX();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           date.UpdateConfig();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            date.InstConfig();
            date.Cobox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConfigText.Enabled = true;
            ConfigText.Text = "";
            HPID.Text = "";
            HVID.Text = "";
            Music.Text = "";
            NAME.Text = "";
            Player.Text = "";
            DPID.Text = "";
            DVID.Text = "";
            Delay.Text = "";
            barcode.Text = "";
            count.Text = "";
            testflag.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            date.DelectConfig();
        }

       
    }
};
