using System;
using System.Windows.Forms;
using After.Generic.Generic;
using After.Service.Sevice;
using After_Test.Generic;
using CCWin;

namespace After_Test.Forms
{
    public partial class Alltestitem : Skin_Mac
    {
        public static Alltestitem Alltest;
        private AlltestitemFor alltestitemFor = new AlltestitemFor();
        ConfigService _configService = new ConfigService();
        private ClassControl ctl = new ClassControl();
        private float _x;
        private float _x1;
        private float _y;
        private float _y1;

        public Alltestitem()
        {
            InitializeComponent();
            Alltest = this;
        }

        private void Alltestitem_Load(object sender, EventArgs e)
        {
            Control();
            alltestitemFor.LoadJx();

        }


        /// <summary>
        /// 初始化
        /// </summary>
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

        private void Alltestitem_Resize(object sender, EventArgs e)
        {
            Resizes();
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            alltestitemFor.GetAll();
            GenericForm.DisplaylistboxMsg("已加载：" + comboBox1.Text + " 机型测试项");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            编号.Enabled = false;
            skinButton4.Visible = false;
            skinButton5.Visible = false;
            skinButton6.Visible = true;
            机型.Enabled = false;
            alltestitemFor.QueryListIfId(sender, e);


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            机型.Enabled = true;
            panel1.Visible = true;
            编号.Enabled = true;
            skinButton4.Visible = true;
            skinButton5.Visible = true;
            skinButton6.Visible = false;
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            alltestitemFor.DelectAlltestitem();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            机型.Enabled = true;
            // 机型.Text = "";
            单位.Text = "";
            数值上限.Text = "";
            数值下限.Text = "";
            测试项目.Text = "";
            耳机指令.Text = "";
            编号.Text = "";
        }

        private async void skinButton5_Click(object sender, EventArgs e)
        {
            if (单位.Text == "" || 数值上限.Text == "" || 数值上限.Text == "" || 数值下限.Text == "" || 测试项目.Text == "" || 耳机指令.Text == "" || 编号.Text == "")
            {
                MessageBox.Show(@"不能为空");
                return;
            }
            var result= await   _configService.GetTypeJxAsync(机型.Text);
            if (result==null)
            {
                MessageBox.Show(@"机型不存在");
                return ;
            }

            await alltestitemFor.InstAlltestitem();
        }

        private async void skinButton6_Click(object sender, EventArgs e)
        {
            await alltestitemFor.UpdateAlltestitem();

        }

        private void skinButton7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}