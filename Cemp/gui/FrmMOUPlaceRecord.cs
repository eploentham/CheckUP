using Cemp.Control;
using Cemp.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.gui
{
    public partial class FrmMOUPlaceRecord : Form
    {
        CnviControl cc;
        MOU mo;
        Boolean pageLoad = false;
        public FrmMOUPlaceRecord(String moId, CnviControl c)
        {
            cc = c;
            InitializeComponent();
            initConfig(moId, cc);
        }
        private void initConfig(String moId, CnviControl c)
        {
            pageLoad = true;
            cc = c;
            mo = new MOU();
            mo = cc.modb.selectByPk(moId);
            txtMouNumber.Text = mo.MOUNumber+"-"+mo.MOUNumberCnt;
            //qu = new Quotation();
            //cboMOU = cc.modb.getCboMOUNumber(cboMOU, moNumber);
            //cboQuo = cc.qudb.getCboQuotation(cboQuo);
            cboStaffPlaceRecord = cc.sfdb.getCboStaff(cboStaffPlaceRecord);
            cboStaffAnalysis = cc.sfdb.getCboStaff(cboStaffAnalysis);
            setControl(moId);
            //cboItem = cc.itdb.getCboItemQuotation(cboItem);
            //setGrd("");
            pageLoad = false;
        }
        private void setControl(String moId)
        {
            mo = cc.modb.selectByPk(moId);
            cboStaffAnalysis.Text = mo.StaffAnalysisName;
            cboStaffPlaceRecord.Text = mo.StaffPlaceRecordName;
        }
        private void FrmMOUPlaceRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String datePlaceRecord = "";
            //datePlaceRecord = dtpPlaceRecord.Value.Year.ToString() + "-" + dtpPlaceRecord.Value.Month.ToString("00") + "-" + dtpPlaceRecord.Value.Day.ToString("00");
            datePlaceRecord = cc.cf.datetoDB(dtpPlaceRecord.Value);
            String chk = cc.modb.updateMOUPlaceRecord(mo.Id, cc.getValueCboItem(cboStaffPlaceRecord), cboStaffPlaceRecord.Text, cc.getValueCboItem(cboStaffAnalysis), cboStaffAnalysis.Text, datePlaceRecord);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            mo = cc.modb.selectByPk(mo.Id);
            DataTable dt = cc.moidb.selectByMoId(mo.Id);
            //MOU mo = cc.modb.selectByPk(mo.Id);
            mo.ContactName = "เรียน :  " + mo.ContactName;
            mo.CustAddress = "ที่อยู่ :   " + mo.CustAddress;
            mo.CustTel = "เบอร์โทร : " + mo.CustTel + " Mobile : " + mo.CustMobile;
            mo.CustEmail = " Email : " + mo.CustEmail;
            mo.Line1 = cc.cp.mouLine1;
            mo.QuoNumber = "เลขที่ : " + mo.MOUNumber + "-" + mo.MOUNumberCnt;
            mo.DatePeriod = "วันที่ :  " + mo.DatePeriod;
            mo.StaffQuoName = "ผู้เสนอราคา :  " + mo.StaffQuoName;
            mo.StaffMOUTel = "เบอร์โทร : " + mo.StaffMOUTel + " Mobile : " + mo.StaffMOUMobile;
            mo.StaffMOUEmail = "Email : " + mo.StaffMOUEmail;
            mo.MOUNumber = "เลขที่ : " + mo.MOUNumber + "-" + mo.MOUNumberCnt;
            mo.StaffMOUName = "ผู้รับผิดชอบข้อตกลง : "+mo.StaffMOUName;

            FrmReport frm = new FrmReport(cc);
            frm.setReportMOUSamplePrint(mo, dt);
            frm.ShowDialog(this);
        }
    }
}
