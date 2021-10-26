using System;
using CCWin;


namespace After_Test.Forms.Interface
{
    public partial class SwSendData : Skin_Mac
    {
        public SwSendData()
        {
            InitializeComponent();
        }

        private void SwSendData_Load(object sender, EventArgs e)
        {
            uiList.Items.Add("登录");
            uiList.Items.Add("检查序号");
            uiList.Items.Add("查PCBA码");
            uiList.Items.Add("查镭雕码");
            uiList.Items.Add("PCBA绑定镭雕");
            uiList.Items.Add("PCBA绑定电池芯");
            uiList.Items.Add("过站");
            uiList.SelectedIndex = 0;
            uiComboGh.Items.Add("001");
            uiComboZb.Items.Add("CorePack-11");



        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void uiList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        VTChroma.SwATE _sw = new VTChroma.SwATE();
        private void uiButton1_Click(object sender, EventArgs e)
        {
            var result = uiList.SelectedItem.ToString();
            switch (result)
            {
                case "登录":
                    var data = _sw.SwSendData(1, uiComboGh.Text + ";" + uiComboZb.Text);
                    MsgBox.Items.Add("登录：" + data);
                    break;
                case "检查序号":
                    var data1 = _sw.SwSendData(2, uiTextPcba.Text + ";" + uiComboZb.Text);
                    MsgBox.Items.Add("检查序号：" + data1);
                    break;
                case "查PCBA码":
                    string res12 = _sw.getSNByLinkData("081300V11090613AE"); //传镭雕码 
                    string pcba = _sw.getSNByLinkData(uiTextLd.Text.Trim()); //传镭雕码 
                    MsgBox.Items.Add("PCBA码：" + pcba);
                    break;
                case "查镭雕码":
                    string ld = _sw.getLinkDataBySN(uiTextPcba.Text); // 传PCBA码
                    MsgBox.Items.Add("查镭雕码：" + ld);
                    break;
                case "PCBA绑定镭雕":
                    string bd = _sw.insertSNLinkSSNRec(uiTextPcba.Text, uiTextLd.Text);
                    MsgBox.Items.Add("PCBA绑定镭雕：" + bd);
                    break;
                case "PCBA绑定电池芯":
                    string dcx = _sw.SwSendData(7, uiTextPcba.Text + ";" + uiTextDcx.Text);
                    MsgBox.Items.Add("PCBA绑定电池芯：" + dcx);
                    break;
                case "过站":
                    string gz = _sw.SwSendData(3, uiComboGh.Text + ";" + uiTextPcba.Text + ";" + uiComboZb.Text + ";OK;");
                    MsgBox.Items.Add("过站：" + gz);
                    break;
            }
        }
    }
}
