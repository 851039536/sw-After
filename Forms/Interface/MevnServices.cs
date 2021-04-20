using System;
using CCWin;

namespace After_Test.Forms.Interface
{
    public partial class MevnServices : Skin_Mac
    {
        public MevnServices()
        {
            InitializeComponent();
        }

        private void MevnService_Load(object sender, EventArgs e)
        {
            uiList.Items.Add("ASSY_Data");
            uiList.Items.Add("Bluetooth_ID");
            uiList.Items.Add("GetBDAFailQty");
            uiList.Items.Add("GetBDNoBySn");
            uiList.Items.Add("GetEMESBDAWOInfo");
            uiList.Items.Add("GetEMESUseNextBDANoTest");
            uiList.Items.Add("GetEMESUseNextBDANoTest2");
            uiList.Items.Add("GetEMES_Check_SN_BDA_KEY");
            uiList.Items.Add("GetMESNextFailBDANo");
            uiList.Items.Add("GetMESQCUserNextBDANo");
            uiList.Items.Add("GetMESQCUserNextBDANo2");
            uiList.Items.Add("InsertDCSN");
            uiList.Items.Add("InsertSNInformation");
            uiList.Items.Add("InsertSSN");
            uiList.Items.Add("Insert_DC_Result");
            uiList.Items.Add("MESGetQCRecordBDACNT");
            uiList.Items.Add("MESGetQCRecordBDACNTByMO");
            uiList.Items.Add("MESWritBDAUpadeRecord");
            uiList.Items.Add("MESWriteBDALog");
            uiList.Items.Add("QUERY_WO_SNANDPANELNO");
            uiList.Items.Add("Query_Bluetooth_ID");
            uiList.Items.Add("Query_Link_SN");
            uiList.Items.Add("SN_Relation_BATTERY");
            uiList.Items.Add("Unbind_Bluetooth_ID");
            uiList.Items.Add("UpdatTETestResult");
            uiList.Items.Add("checkAssyData");
            uiList.Items.Add("checkEmpNo");
            uiList.Items.Add("checkSN_Route");
            uiList.Items.Add("checkSN_Station");
            uiList.Items.Add("getLinkDataBySN");
            uiList.Items.Add("getSNByLinkData");
            uiList.Items.Add("input_sn");
            uiList.Items.Add("insertSNLinkSSNRec");
            uiList.Items.Add("sendTestData");
            uiList.Items.Add("sendTestResult");

        }

        MevnService.Service1 _service = new MevnService.Service1();
        private void uiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = uiList.SelectedItem.ToString();
            switch (result)
            {
                case "ASSY_Data":
                    describe.Text = @"上传组装资料";
                    break;
                case "Bluetooth_ID":
                    describe.Text = @"SN与BD绑定";
                    break;
                case "GetBDAFailQty":
                    describe.Text = @"取得某張工單，燒錄失敗的總數量 1:燒錄成功，2:燒錄失敗，3:重新燒錄成功";
                    break;
                case "GetBDNoBySn":
                    describe.Text = @"BDA根據產品SN號查找綁定的DBA號";
                    break;
                case "GetEMESBDAWOInfo":
                    describe.Text = @"依據工單咨詢，取得BDA號段信息，與當前和下一個BDA號";
                    break;
                case "GetEMESUseNextBDANoTest":
                    describe.Text = @"輸入工單取得BDA号_正常燒錄";
                    break;
                case "GetEMESUseNextBDANoTest2":
                    describe.Text = @"輸入工單取得BDA号_正常燒錄";
                    break;
                case "GetEMES_Check_SN_BDA_KEY":
                    describe.Text = @"SN、 BD、 cvc綁定比較";
                    break;

                case "GetMESNextFailBDANo":
                    describe.Text = @"取某張工單燒錄失敗的BDA號，重複利用";
                    break;
                case "GetMESQCUserNextBDANo":
                    describe.Text = @"輸入工單取得BDA号_QC做首尾件";
                    break;
                case "GetMESQCUserNextBDANo2":
                    describe.Text = @"先check sn 是否在這個工作站台， 輸入工單取得BDA号_QC做首尾件";
                    break;
                case "InsertDCSN":
                    describe.Text = @"用於綁定電池序號";
                    break;
                case "InsertSNInformation":
                    describe.Text = @"（镭雕）成功后记录log";
                    break;
                case "InsertSSN":
                    describe.Text = @"SN绑定出货序号";
                    break;
                case "Insert_DC_Result":
                    describe.Text = @"上传电池测试结果";
                    break;
                case "MESGetQCRecordBDACNT":
                    describe.Text = @"根據工單號，取得當前工單所有號段，QC首尾件已經取了多少個號";
                    break;
                case "MESGetQCRecordBDACNTByMO":
                    describe.Text = @"根據工單號，取得指定號段，QC首尾件已經取了多少個號";
                    break;
                case "MESWritBDAUpadeRecord":
                    describe.Text = @"燒錄失敗的BDA號重複利用，再次燒錄成功時，更新DB數據";
                    break;
                case "MESWriteBDALog":
                    describe.Text = @"BDA號燒錄記錄寫入數據庫";
                    break;
                case "QUERY_WO_SNANDPANELNO":
                    describe.Text = @"（镭雕）根据工单号查询所有SN、PANEL号";
                    break;
                case "Query_Bluetooth_ID":
                    describe.Text = @"根据SN查询绑定的BD";
                    break;
                case "Query_Link_SN":
                    describe.Text = @"依据在制品SN查询绑定的序号";
                    break;
                case "SN_Relation_BATTERY":
                    describe.Text = @"SN绑定电池芯";
                    break;
                case "Unbind_Bluetooth_ID":
                    describe.Text = @"SN与BD解除绑定";
                    break;
                case "UpdatTETestResult":
                    describe.Text = @"更新燒錄結果";
                    break;
                case "checkAssyData":
                    describe.Text = @"檢查綁定KeyPart是否完成";
                    break;
                case "checkSN_Route":
                    describe.Text = @"检查序号和途程";
                    break;
                case "checkSN_Station":
                    describe.Text = @"检测序号有效性及是否允许在此工站测试";
                    break;
                case "getLinkDataBySN":
                    describe.Text = @"根據SN獲取綁定的SSN，無為空";
                    break;
                case "getSNByLinkData":
                    describe.Text = @"根據SSN獲取綁定的SN，無為空(sn 是PCBA板SN，SSN是镭雕二维码)";
                    break;
                case "input_sn":
                    describe.Text = @"Input SN";
                    break;
                case "insertSNLinkSSNRec":
                    describe.Text = @"SN(主)和SSN(成品)綁定,成功返回True，失敗返回False";
                    break;
                case "sendTestData":
                    describe.Text = @"上传测试项目数据";
                    break;
                case "sendTestResult":
                    describe.Text = @"上传测试结果和过站";
                    break;
                case "checkEmpNo":
                    describe.Text = @"檢查員工:001,688-T2.4-11";
                    break;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            var result = uiList.SelectedItem.ToString();
            switch (result)
            {
                case "checkEmpNo":
                    var checkEmpNo = parameter.Text.Split(',');
                    var data = _service.checkEmpNo(checkEmpNo[0], checkEmpNo[1]);
                    MsgBox.Text = data;
                    break;
            }


        }
    }
}
