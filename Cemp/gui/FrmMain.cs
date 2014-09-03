using Cemp.Control;
using Cemp.gui;
using Cemp.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp
{
    public partial class FrmMain : Form
    {
        CnviControl cc;
        Form frm;
        Staff sf;
        public FrmMain(Form f, String sfCode, CnviControl l)
        {
            InitializeComponent();
            initConfig(f, sfCode, l);
        }
        private void initConfig(Form f, String sfCode, CnviControl l)
        {
            //lc = new LottoryControl();
            cc = l;
            frm = f;
            sf = cc.sfdb.selectByCode(sfCode);
            cc.sf = sf;
            tvMain();
        }
        private void showFrame(Form f)
        {
            this.Hide();
            f.ShowDialog(this);
            this.Show();
        }
        private void tvMain()
        {
            tv1.Nodes.Clear();

            //if (sf.Priority.Equals("1") || sf.Priority.Equals("3"))
            //{
            tv1.Nodes.Add("nQuotationView", "พิมพ์ Quotation");
            tv1.Nodes.Add("nQuoConfirmView", "Confirm Quotation");
            tv1.Nodes.Add("nMOUView", "พิมพ์ ใบMOU และใบรับตัวอย่าง");
            tv1.Nodes.Add("nInputResult", "ป้อนผลตัวอย่าง");
            tv1.Nodes.Add("nBillNoteView", "พิมพ์ Bill Note");
            tv1.Nodes.Add("nRewardAdd", "ป้อนรางวัล");
            //}
            //if (sf.Priority.Equals("2") || sf.Priority.Equals("3"))
            //{
            //    tv1.Nodes.Add("nLottoImage", "นำรูปเข้าระบบ");
            //    tv1.Nodes.Add("nLottoApprove", "ยืนยันตัวเลข");
            //    tv1.Nodes.Add("nLottoResult", "ตรวจรางวัลประจำงวด");
            //    tv1.Nodes.Add("nLottoSummary", "สรุปข้อมูลประจำงวด");
            //}
            //if (sf.Priority.Equals("3"))
            //{
            tv1.Nodes.Add("nInitConfig", "กำหนดค่าโปรแกรม");
            tv1.Nodes["nInitConfig"].Nodes.Add("nItemView", "สร้างรายการ Parameter");
            tv1.Nodes["nInitConfig"].Nodes.Add("nCustomerView", "สร้าง ลูกค้า");
            tv1.Nodes["nInitConfig"].Nodes.Add("nStaffView", "สร้าง พนักงาน");

            tv1.Nodes["nInitConfig"].Nodes.Add("nCompany", "ข้อมูลบริษัท");
            //    tv1.Nodes["nInitConfig"].Nodes.Add("nRateView", "สร้างอัตรา");
            tv1.Nodes["nInitConfig"].Nodes.Add("nPassword", "เปลี่ยนรหัสผ่าน");
            //    tv1.Nodes["nInitConfig"].Nodes.Add("nThooDefault", "กำหนดเจ้ามือ (เจ้าของโปรแกรม)");
            //    tv1.Nodes["nInitConfig"].Nodes.Add("nInitConfig1", "กำหนดค่าโปรแกรม");
            //}

            tv1.ExpandAll();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Last Update " + System.IO.File.GetLastWriteTime(System.Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frm != null)
            {
                frm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void tv1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name.ToString() == "nQuotationView")
            {
                FrmQuotationView frm = new FrmQuotationView(sf.Id,cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nQuoConfirmView")
            {
                FrmQuoConfirmView frm = new FrmQuoConfirmView(sf.Id, cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nMOUView")
            {
                FrmMOUView frm = new FrmMOUView(sf.Id, cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nInputResult")
            {
                FrmResultView frm = new FrmResultView(sf.Id, cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nBillNoteView")
            {
                FrmPassword frm = new FrmPassword(sf.Id);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nCompany")
            {
                FrmCompany frm = new FrmCompany(cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nCustomerView")
            {
                FrmCustView frm = new FrmCustView(cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nStaffView")
            {
                FrmStaffView frm = new FrmStaffView(cc);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nItemView")
            {
                FrmItemView frm = new FrmItemView(cc);
                showFrame(frm);
            }
            //else if (e.Node.Name.ToString() == "nLottoApprove")
            //{
            //    FrmLottoApprove frm = new FrmLottoApprove(sf.Code, lc);
            //    showFrame(frm);
            //}
            //else if (e.Node.Name.ToString() == "nLottoSummary")
            //{
            //    FrmLottoSummary frm = new FrmLottoSummary(sf.Code, lc);
            //    showFrame(frm);
            //}
            //else if (e.Node.Name.ToString() == "nThooDefault")
            //{
            //    FrmThooDefault frm = new FrmThooDefault(sf.Code);
            //    showFrame(frm);
            //}
            //else if (e.Node.Name.ToString() == "nInitConfig1")
            //{
            //    FrmInitConfig frm = new FrmInitConfig(sf.Code, lc);
            //    showFrame(frm);
            //}
            //else if (e.Node.Name.ToString() == "nInputImage")
            //{
            //    FrmInputImage frm = new FrmInputImage(sf.Code, lc);
            //    showFrame(frm);
            //}
            //else if (e.Node.Name.ToString() == "nLottoImage")
            //{
            //    FrmLottoImage frm = new FrmLottoImage(sf.Code, lc);
            //    showFrame(frm);
            //}
        }
    }
}
