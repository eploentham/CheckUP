using CheckUP.Control;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.gui
{
    public partial class FrmExcelInit : Form
    {
        CheckControl cc;
        int tabSum = 0, tabPE = 1, tabXRay = 2, tabCBC = 3, tabFBS = 4, tabUA = 5, tabTri = 6, tabCho = 7, tabSgot = 8, tabBun = 9, tabUric = 10;
        int tabCnt = 11;
        OpenFileDialog ofd = new OpenFileDialog();
        ExcelInit ei;
        public FrmExcelInit(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            ei = cc.eidb.selectByPk();
            tC.TabPages[tabSum].Text = "Summary";
            tC.TabPages[tabPE].Text = "PE";
            tC.TabPages[tabXRay].Text = "X-Ray";
            tC.TabPages[tabCBC].Text = "CBC";
            tC.TabPages[tabFBS].Text = "FBS";
            tC.TabPages[tabUA].Text = "UA";
            tC.TabPages[tabTri].Text = "Triglyceride";
            tC.TabPages[tabCho].Text = "Choles";
            tC.TabPages[tabSgot].Text = "SGOT/SGPT";
            tC.TabPages[tabBun].Text = "BUN Creatine";
            tC.TabPages[tabUric].Text = "Uric acid";

            nmDPERow.Value = int.Parse(cc.cf.NumberNull1(ei.PERow));
            nmDPENo.Value = int.Parse(cc.cf.NumberNull1(ei.PENo));
            nmDPEAge.Value = int.Parse(cc.cf.NumberNull1(ei.PEAge));
            nmDPEBMI.Value = int.Parse(cc.cf.NumberNull1(ei.PEBMI));
            nmDPEHeight.Value = int.Parse(cc.cf.NumberNull1(ei.PEHeight));
            nmDPEPulse.Value = int.Parse(cc.cf.NumberNull1(ei.PEPulse));
            nmDPEResult.Value = int.Parse(cc.cf.NumberNull1(ei.PEResult));
            nmDPESummary.Value = int.Parse(cc.cf.NumberNull1(ei.PESummary));
            nmDPEVi.Value = int.Parse(cc.cf.NumberNull1(ei.PEVitalSign));
            nmDPEWeight.Value = int.Parse(cc.cf.NumberNull1(ei.PEWeight));

            nmDXRayRow.Value = int.Parse(cc.cf.NumberNull1(ei.XrayRow));
            nmDXRayNo.Value = int.Parse(cc.cf.NumberNull1(ei.XrayNo));
            nmDXRaySummary.Value = int.Parse(cc.cf.NumberNull1(ei.XraySummary));
            nmDXRayValue.Value = int.Parse(cc.cf.NumberNull1(ei.Xray));

            nmDCBCRow.Value = int.Parse(cc.cf.NumberNull1(ei.CBCRow));
            nmDCBCNo.Value = int.Parse(cc.cf.NumberNull1(ei.CBCNo));
            nmDCBCBact.Value = int.Parse(cc.cf.NumberNull1(ei.CBCBact));
            nmDCBCEos.Value = int.Parse(cc.cf.NumberNull1(ei.CBCEos));
            nmDCBCHb.Value = int.Parse(cc.cf.NumberNull1(ei.CBCHb));
            nmDCBCHct.Value = int.Parse(cc.cf.NumberNull1(ei.CBCHct));
            nmDCBCLy.Value = int.Parse(cc.cf.NumberNull1(ei.CBCLy));
            nmDCBCMono.Value = int.Parse(cc.cf.NumberNull1(ei.CBCMono));
            nmDCBCNeu.Value = int.Parse(cc.cf.NumberNull1(ei.CBCNeu));
            nmDCBCPltC.Value = int.Parse(cc.cf.NumberNull1(ei.CBCPltC));
            nmDCBCPltS.Value = int.Parse(cc.cf.NumberNull1(ei.CBCPltS));
            nmDCBCRBC.Value = int.Parse(cc.cf.NumberNull1(ei.CBCRBC));
            nmDCBCRBCmono.Value = int.Parse(cc.cf.NumberNull1(ei.CBCRBCmono));
            nmDCBCSummary.Value = int.Parse(cc.cf.NumberNull1(ei.CBCSummary));
            nmDCBCWBC.Value= int.Parse(cc.cf.NumberNull1(ei.CBCWBC));

            nmDFBSRow.Value = int.Parse(cc.cf.NumberNull1(ei.FBSRow));
            nmDFBSNo.Value = int.Parse(cc.cf.NumberNull1(ei.FBSNo));
            nmDFBSResult.Value = int.Parse(cc.cf.NumberNull1(ei.FBSResult));
            nmDFBSSummary.Value = int.Parse(cc.cf.NumberNull1(ei.FBSSummary));
            nmDFBSValue.Value = int.Parse(cc.cf.NumberNull1(ei.FBS));

            nmDUARow.Value = int.Parse(cc.cf.NumberNull1(ei.UARow));
            nmDUANo.Value = int.Parse(cc.cf.NumberNull1(ei.UANo));
            nmDUAAppe.Value = int.Parse(cc.cf.NumberNull1(ei.UAAppe));

            nmDTriRow.Value = int.Parse(cc.cf.NumberNull1(ei.TriRow));
            nmDTriNo.Value = int.Parse(cc.cf.NumberNull1(ei.TriNo));

            nmDChoRow.Value = int.Parse(cc.cf.NumberNull1(ei.ChoRow));
            nmDChoNo.Value = int.Parse(cc.cf.NumberNull1(ei.ChoNo));

            nmDSgotRow.Value = int.Parse(cc.cf.NumberNull1(ei.SgotRow));
            nmDSgotNo.Value = int.Parse(cc.cf.NumberNull1(ei.SgotNo));

            nmDBunRow.Value = int.Parse(cc.cf.NumberNull1(ei.BunRow));
            nmDBunNo.Value = int.Parse(cc.cf.NumberNull1(ei.BunNo));

            nmDUricRow.Value = int.Parse(cc.cf.NumberNull1(ei.UricRow));
            nmDUricNo.Value = int.Parse(cc.cf.NumberNull1(ei.UricNo));
            
            
            
            
            
            
            
            

            lbPE.Left = label3.Left;
            lbXRay.Left = label3.Left;
            lbCBC.Left = label3.Left;
            lbFBS.Left = label3.Left;
            lbUA.Left = label3.Left;
            lbTri.Left = label3.Left;
            lbCho.Left = label3.Left;
            lbSgot.Left = label3.Left;
            lbBun.Left = label3.Left;
            lbUric.Left = label3.Left;

            lbPE.Top = label3.Top;
            lbXRay.Top = label3.Top;
            lbCBC.Top = label3.Top;
            lbFBS.Top = label3.Top;
            lbUA.Top = label3.Top;
            lbTri.Top = label3.Top;
            lbCho.Top = label3.Top;
            lbSgot.Top = label3.Top;
            lbBun.Top = label3.Top;
            lbUric.Top = label3.Top;

            nmDPERow.Left = nmDRow.Left;
            nmDXRayRow.Left = nmDRow.Left;
            nmDCBCRow.Left = nmDRow.Left;
            nmDFBSRow.Left = nmDRow.Left;
            nmDUARow.Left = nmDRow.Left;
            nmDTriRow.Left = nmDRow.Left;
            nmDChoRow.Left = nmDRow.Left;
            nmDSgotRow.Left = nmDRow.Left;
            nmDBunRow.Left = nmDRow.Left;
            nmDUricRow.Left = nmDRow.Left;

            nmDPERow.Top = nmDRow.Top;
            nmDXRayRow.Top = nmDRow.Top;
            nmDCBCRow.Top = nmDRow.Top;
            nmDFBSRow.Top = nmDRow.Top;
            nmDUARow.Top = nmDRow.Top;
            nmDTriRow.Top = nmDRow.Top;
            nmDChoRow.Top = nmDRow.Top;
            nmDSgotRow.Top = nmDRow.Top;
            nmDBunRow.Top = nmDRow.Top;
            nmDUricRow.Top = nmDRow.Top;

            lbXRayNo.Top = lbPENo.Top;
            lbCBCNo.Top = lbPENo.Top;
            lbUANo.Top = lbPENo.Top;
            lbFBSNo.Top = lbPENo.Top;
            lbTriNo.Top = lbPENo.Top;
            lbChoNo.Top = lbPENo.Top;
            lbBunNo.Top = lbPENo.Top;
            lbSgotNo.Top = lbPENo.Top;
            lbUricNo.Top = lbPENo.Top;
            //lbXRayNo.Top = lbPENo.Top;
            lbXRayNo.Left = lbPENo.Left;
            lbCBCNo.Left = lbPENo.Left;
            lbUANo.Left = lbPENo.Left;
            lbFBSNo.Left = lbPENo.Left;
            lbTriNo.Left = lbPENo.Left;
            lbChoNo.Left = lbPENo.Left;
            lbBunNo.Left = lbPENo.Left;
            lbSgotNo.Left = lbPENo.Left;
            lbUricNo.Left = lbPENo.Left;

            nmDXRayNo.Top = nmDPENo.Top;
            nmDCBCNo.Top = nmDPENo.Top;
            nmDUANo.Top = nmDPENo.Top;
            nmDFBSNo.Top = nmDPENo.Top;
            nmDTriNo.Top = nmDPENo.Top;
            nmDChoNo.Top = nmDPENo.Top;
            nmDBunNo.Top = nmDPENo.Top;
            nmDSgotNo.Top = nmDPENo.Top;
            nmDUricNo.Top = nmDPENo.Top;
            nmDXRayNo.Left = nmDPENo.Left;
            nmDCBCNo.Left = nmDPENo.Left;
            nmDUANo.Left = nmDPENo.Left;
            nmDFBSNo.Left = nmDPENo.Left;
            nmDTriNo.Left = nmDPENo.Left;
            nmDChoNo.Left = nmDPENo.Left;
            nmDBunNo.Left = nmDPENo.Left;
            nmDSgotNo.Left = nmDPENo.Left;
            nmDUricNo.Left = nmDPENo.Left;

        }

        private void FrmExcelInit_Load(object sender, EventArgs e)
        {

        }

        private void btnSfExcel_Click(object sender, EventArgs e)
        {
            String prefix = "", No="", FirstName="", LastName="", Age="", FullName="", AllName="";
            if ((!chkA.Checked) &&(!chkB.Checked)&&(!chkC.Checked))
            {
                MessageBox.Show("เลือกประเภทคำนำหน้าชื่อ ", "เลือกข้อมูล");
                return;
            }
            //if (txtStaffCode.Text.Equals(""))
            //{
            //    MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
            //    return;
            //}
            //if (txtStaffId.Text.Equals(""))
            //{

            //}
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (chkA.Checked)
            {
                if (xlRange.Cells[nmDRow.Value, nmDARow.Value].Value2 != null)
                {
                    No = xlRange.Cells[nmDRow.Value, nmDARow.Value].Value2.ToString();
                }
                else
                {
                    No = "";
                }
                if (xlRange.Cells[nmDRow.Value, nmDAPrefix.Value].Value2 != null)
                {
                    prefix = xlRange.Cells[nmDRow.Value, nmDAPrefix.Value].Value2.ToString();
                }
                else
                {
                    prefix = "";
                }
                prefix = prefix.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDAFirstName.Value].Value2 != null)
                {
                    FirstName = xlRange.Cells[nmDRow.Value, nmDAFirstName.Value].Value2.ToString();
                }
                else
                {
                    FirstName = "";
                }
                FirstName = FirstName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2 != null)
                {
                    LastName = xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2.ToString();
                }
                else
                {
                    LastName = "";
                }
                LastName = LastName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDAAge.Value].Value2 != null)
                {
                    Age = xlRange.Cells[nmDRow.Value, nmDAAge.Value].Value2.ToString();
                }
                else
                {
                    Age = "";
                }
                LastName = LastName.Trim();
                txtPrefixTest.Text = "ลำดับ " + No + " ชื่อ นามสกุล " + prefix + " " + FirstName + " " + LastName + " อายุ " + Age + " ";

                if (cc.eidb.updateSfA(nmDAAge.Value.ToString(), nmDAPrefix.Value.ToString(), nmDAFirstName.Value.ToString(), nmDALastName.Value.ToString(), 
                    nmDARow.Value.ToString(), nmDRow.Value.ToString()).Length >= 1)
                {
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                }
            }
            else if (chkB.Checked)
            {
                if (xlRange.Cells[nmDRow.Value, nmDBRow.Value].Value2 != null)
                {
                    No = xlRange.Cells[nmDRow.Value, nmDBRow.Value].Value2.ToString();
                }
                else
                {
                    No = "";
                }
                if (xlRange.Cells[nmDRow.Value, nmDBPrefix.Value].Value2 != null)
                {
                    prefix = xlRange.Cells[nmDRow.Value, nmDBPrefix.Value].Value2.ToString();
                }
                else
                {
                    prefix = "";
                }
                prefix = prefix.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDBFullName.Value].Value2 != null)
                {
                    FullName = xlRange.Cells[nmDRow.Value, nmDBFullName.Value].Value2.ToString();
                }
                else
                {
                    FullName = "";
                }
                FullName = FullName.Trim();
                //if (xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2 != null)
                //{
                //    LastName = xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2.ToString();
                //}
                //else
                //{
                //    LastName = "";
                //}
                //LastName = LastName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDBAge.Value].Value2 != null)
                {
                    Age = xlRange.Cells[nmDRow.Value, nmDBAge.Value].Value2.ToString();
                }
                else
                {
                    Age = "";
                }
                LastName = LastName.Trim();
                txtPrefixTest.Text = "ลำดับ " + No + " ชื่อ นามสกุล " + prefix + " " + FullName + " อายุ " + Age + " ";

                if (cc.eidb.updateSfB(nmDBAge.Value.ToString(), nmDBPrefix.Value.ToString(), nmDBFullName.Value.ToString(), nmDBRow.Value.ToString(), nmDRow.Value.ToString()).Length >= 1)
                {
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                }
            }
            else if (chkC.Checked)
            {
                if (xlRange.Cells[nmDRow.Value, nmDCRow.Value].Value2 != null)
                {
                    No = xlRange.Cells[nmDRow.Value, nmDCRow.Value].Value2.ToString();
                }
                else
                {
                    No = "";
                }
                if (xlRange.Cells[nmDRow.Value, nmDCPrefix.Value].Value2 != null)
                {
                    AllName = xlRange.Cells[nmDRow.Value, nmDCPrefix.Value].Value2.ToString();
                }
                else
                {
                    AllName = "";
                }
                AllName = AllName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDBAge.Value].Value2 != null)
                {
                    Age = xlRange.Cells[nmDRow.Value, nmDBAge.Value].Value2.ToString();
                }
                else
                {
                    Age = "";
                }
                LastName = LastName.Trim();
                txtPrefixTest.Text = "ลำดับ " + No + " ชื่อ นามสกุล " + prefix + " " + FirstName + " อายุ " + LastName + " ";

                if (cc.eidb.updateSfC(nmDCAge.Value.ToString(), nmDCPrefix.Value.ToString(), nmDBRow.Value.ToString(), nmDRow.Value.ToString()).Length >= 1)
                {
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                }
            }
            //if (cc.sfdb.insertStaff(s).Length >= 1)
            //{
            //    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            //    this.Dispose();
            //    this.Hide();
            //}
        }

        private void btnPEExcel_Click(object sender, EventArgs e)
        {
            String No = "", age="", bmi="", height="", weight="", pulse="", vi="", result="", summary="";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDPERow.Value, nmDPENo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDPERow.Value, nmDPENo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEAge.Value].Value2 != null)
            {
                age = xlRange.Cells[nmDPERow.Value, nmDPEAge.Value].Value2.ToString();
            }
            else
            {
                age = "";
            }
            age = age.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEBMI.Value].Value2 != null)
            {
                bmi = xlRange.Cells[nmDPERow.Value, nmDPEBMI.Value].Value2.ToString();
            }
            else
            {
                bmi = "";
            }
            bmi = bmi.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEHeight.Value].Value2 != null)
            {
                height = xlRange.Cells[nmDPERow.Value, nmDPEHeight.Value].Value2.ToString();
            }
            else
            {
                height = "";
            }
            height = height.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEWeight.Value].Value2 != null)
            {
                weight = xlRange.Cells[nmDPERow.Value, nmDPEWeight.Value].Value2.ToString();
            }
            else
            {
                weight = "";
            }
            weight = weight.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEPulse.Value].Value2 != null)
            {
                pulse = xlRange.Cells[nmDPERow.Value, nmDPEPulse.Value].Value2.ToString();
            }
            else
            {
                pulse = "";
            }
            pulse = pulse.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEVi.Value].Value2 != null)
            {
                vi = xlRange.Cells[nmDPERow.Value, nmDPEVi.Value].Value2.ToString();
            }
            else
            {
                vi = "";
            }
            vi = vi.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDPERow.Value, nmDPEResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPESummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDPERow.Value, nmDPESummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtPETest.Text = "ลำดับ " + No + " อายุ " + age + " น้ำหนัก " + weight + " ส่วนสูง " + height + " BMI " + bmi + " VitalSign " + vi + " Pulse " + pulse + " Result " + result + " Summary " + summary;
            if (cc.eidb.updatePE(nmDPENo.Value.ToString(), nmDPERow.Value.ToString(), nmDPEAge.Value.ToString(), nmDPEBMI.Value.ToString(),
                nmDPEHeight.Value.ToString(), nmDPEWeight.Value.ToString(), nmDPEPulse.Value.ToString(), nmDPEVi.Value.ToString(), nmDPEResult.Value.ToString(), 
                nmDPESummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล PE เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnXRayExcel_Click(object sender, EventArgs e)
        {
            String No = "", xray = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDPERow.Value, nmDXRayNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDPERow.Value, nmDXRayNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDXRayValue.Value].Value2 != null)
            {
                xray = xlRange.Cells[nmDPERow.Value, nmDXRayValue.Value].Value2.ToString();
            }
            else
            {
                xray = "";
            }
            xray = xray.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDXRaySummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDPERow.Value, nmDXRaySummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtXRayTest.Text = "ลำดับ " + No + " XRay " + xray + " summary " + summary;
            if (cc.eidb.updateXray(nmDXRayValue.Value.ToString(), nmDXRayNo.Value.ToString(), nmDXRayRow.Value.ToString(), nmDXRaySummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล XRay เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnCBCExcel_Click(object sender, EventArgs e)
        {
            String No = "", wbc = "", rbc = "", Hb = "", Hct = "", neu = "", ly = "", mono = "", eos="", bact="", pltc="", plts="", rbcmono="", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDCBCRow.Value, nmDCBCNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCWBC.Value].Value2 != null)
            {
                wbc = xlRange.Cells[nmDCBCRow.Value, nmDCBCWBC.Value].Value2.ToString();
            }
            else
            {
                wbc = "";
            }
            wbc = wbc.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCRBC.Value].Value2 != null)
            {
                rbc = xlRange.Cells[nmDCBCRow.Value, nmDCBCRBC.Value].Value2.ToString();
            }
            else
            {
                rbc = "";
            }
            rbc = rbc.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCHb.Value].Value2 != null)
            {
                Hb = xlRange.Cells[nmDCBCRow.Value, nmDCBCHb.Value].Value2.ToString();
            }
            else
            {
                Hb = "";
            }
            Hb = Hb.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCHct.Value].Value2 != null)
            {
                Hct = xlRange.Cells[nmDCBCRow.Value, nmDCBCHct.Value].Value2.ToString();
            }
            else
            {
                Hct = "";
            }
            Hct = Hct.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCNeu.Value].Value2 != null)
            {
                neu = xlRange.Cells[nmDCBCRow.Value, nmDCBCNeu.Value].Value2.ToString();
            }
            else
            {
                neu = "";
            }
            neu = neu.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCLy.Value].Value2 != null)
            {
                ly = xlRange.Cells[nmDCBCRow.Value, nmDCBCLy.Value].Value2.ToString();
            }
            else
            {
                ly = "";
            }
            ly = ly.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCMono.Value].Value2 != null)
            {
                mono = xlRange.Cells[nmDCBCRow.Value, nmDCBCMono.Value].Value2.ToString();
            }
            else
            {
                mono = "";
            }
            mono = mono.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCEos.Value].Value2 != null)
            {
                eos = xlRange.Cells[nmDCBCRow.Value, nmDCBCEos.Value].Value2.ToString();
            }
            else
            {
                eos = "";
            }
            eos = eos.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCBact.Value].Value2 != null)
            {
                bact = xlRange.Cells[nmDCBCRow.Value, nmDCBCBact.Value].Value2.ToString();
            }
            else
            {
                bact = "";
            }
            bact = bact.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCPltC.Value].Value2 != null)
            {
                pltc = xlRange.Cells[nmDCBCRow.Value, nmDCBCPltC.Value].Value2.ToString();
            }
            else
            {
                pltc = "";
            }
            pltc = pltc.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCPltS.Value].Value2 != null)
            {
                plts = xlRange.Cells[nmDCBCRow.Value, nmDCBCPltS.Value].Value2.ToString();
            }
            else
            {
                plts = "";
            }
            plts = plts.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCRBCmono.Value].Value2 != null)
            {
                rbcmono = xlRange.Cells[nmDCBCRow.Value, nmDCBCRBCmono.Value].Value2.ToString();
            }
            else
            {
                rbcmono = "";
            }
            rbcmono = rbcmono.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDCBCRow.Value, nmDCBCSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtCBCTest.Text = "ลำดับ " + No + " WBC " + wbc + " Hct " + Hct + " Hb " + Hb + " RBC " + rbc + " Ly " + ly + " Neu " + neu + " mono " + mono +
                " Eos " + eos + " bact " + bact + " pltc " + pltc + " plts " + plts + " rbcmono " + rbcmono + " Summary " + summary;
            if (cc.eidb.updateCBC(nmDCBCBact.Value.ToString(), nmDCBCEos.Value.ToString(), nmDCBCHb.Value.ToString(), nmDCBCHct.Value.ToString(),
                nmDCBCLy.Value.ToString(), nmDCBCMono.Value.ToString(), nmDCBCNeu.Value.ToString(), nmDCBCNo.Value.ToString(), nmDCBCPltC.Value.ToString(), nmDCBCPltS.Value.ToString(),
                nmDCBCRBC.Value.ToString(), nmDCBCRBCmono.Value.ToString(), nmDCBCRow.Value.ToString(), nmDPESummary.Value.ToString(), nmDCBCWBC.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล PE เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnFBSExcel_Click(object sender, EventArgs e)
        {
            String No = "", fbs = "", result="", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDFBSRow.Value, nmDXRayNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDFBSRow.Value, nmDXRayNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDFBSRow.Value, nmDFBSValue.Value].Value2 != null)
            {
                fbs = xlRange.Cells[nmDFBSRow.Value, nmDFBSValue.Value].Value2.ToString();
            }
            else
            {
                fbs = "";
            }
            fbs = fbs.Trim();
            if (xlRange.Cells[nmDFBSRow.Value, nmDFBSResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDFBSRow.Value, nmDFBSResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDFBSRow.Value, nmDFBSSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDFBSRow.Value, nmDFBSSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtFBSTest.Text = "ลำดับ " + No + " fbs " + fbs + " result " + result + " summary " + summary;
            if (cc.eidb.updateFBS(nmDFBSValue.Value.ToString(), nmDFBSNo.Value.ToString(), nmDFBSResult.Value.ToString(), nmDFBSRow.Value.ToString(), nmDFBSSummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล FBS เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnUAExcel_Click(object sender, EventArgs e)
        {
            String No = "", color = "", appe = "", sugar = "", spgr = "", pH = "", protein = "", wbc = "", rbc = "", epi = "", bact = "", result = "", rbcmono = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDUARow.Value, nmDUANo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDUARow.Value, nmDUANo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAColor.Value].Value2 != null)
            {
                color = xlRange.Cells[nmDUARow.Value, nmDUAColor.Value].Value2.ToString();
            }
            else
            {
                color = "";
            }
            color = color.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAAppe.Value].Value2 != null)
            {
                appe = xlRange.Cells[nmDUARow.Value, nmDUAAppe.Value].Value2.ToString();
            }
            else
            {
                appe = "";
            }
            appe = appe.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUASugar.Value].Value2 != null)
            {
                sugar = xlRange.Cells[nmDUARow.Value, nmDUASugar.Value].Value2.ToString();
            }
            else
            {
                sugar = "";
            }
            sugar = sugar.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUASpgr.Value].Value2 != null)
            {
                spgr = xlRange.Cells[nmDUARow.Value, nmDUASpgr.Value].Value2.ToString();
            }
            else
            {
                spgr = "";
            }
            spgr = spgr.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUApH.Value].Value2 != null)
            {
                pH = xlRange.Cells[nmDUARow.Value, nmDUApH.Value].Value2.ToString();
            }
            else
            {
                pH = "";
            }
            pH = pH.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAProtein.Value].Value2 != null)
            {
                protein = xlRange.Cells[nmDUARow.Value, nmDUAProtein.Value].Value2.ToString();
            }
            else
            {
                protein = "";
            }
            protein = protein.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAWBC.Value].Value2 != null)
            {
                wbc = xlRange.Cells[nmDUARow.Value, nmDUAWBC.Value].Value2.ToString();
            }
            else
            {
                wbc = "";
            }
            wbc = wbc.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUARBC.Value].Value2 != null)
            {
                rbc = xlRange.Cells[nmDUARow.Value, nmDUARBC.Value].Value2.ToString();
            }
            else
            {
                rbc = "";
            }
            rbc = rbc.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAEpi.Value].Value2 != null)
            {
                epi = xlRange.Cells[nmDUARow.Value, nmDUAEpi.Value].Value2.ToString();
            }
            else
            {
                epi = "";
            }
            epi = epi.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUABact.Value].Value2 != null)
            {
                bact = xlRange.Cells[nmDUARow.Value, nmDUABact.Value].Value2.ToString();
            }
            else
            {
                bact = "";
            }
            bact = bact.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDUARow.Value, nmDUAResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();

            if (xlRange.Cells[nmDUARow.Value, nmDUASummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDUARow.Value, nmDUASummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtUATest.Text = "ลำดับ " + No + " color " + color + " spgr " + spgr + " sugar " + sugar + " appe " + appe + " protein " + protein + " pH " + pH + " wbc " + wbc +
                " rbc " + rbc + " epi " + epi + " bact " + bact + " result " + result + " rbcmono " + rbcmono + " Summary " + summary;
            if (cc.eidb.updateUA(nmDUAAppe.Value.ToString(), nmDUABact.Value.ToString(), nmDUAColor.Value.ToString(), nmDUAEpi.Value.ToString(),
                nmDUANo.Value.ToString(), nmDUApH.Value.ToString(), nmDUAProtein.Value.ToString(), nmDUARBC.Value.ToString(), nmDUAResult.Value.ToString(), nmDUARow.Value.ToString(),
                nmDUASpgr.Value.ToString(), nmDUASugar.Value.ToString(), nmDUASummary.Value.ToString(), nmDUAWBC.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnTriExcel_Click(object sender, EventArgs e)
        {
            String No = "", tri = "", result = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDTriRow.Value, nmDTriNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDTriRow.Value, nmDTriNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDTriRow.Value, nmDTriValue.Value].Value2 != null)
            {
                tri = xlRange.Cells[nmDTriRow.Value, nmDTriValue.Value].Value2.ToString();
            }
            else
            {
                tri = "";
            }
            tri = tri.Trim();
            if (xlRange.Cells[nmDTriRow.Value, nmDTriResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDTriRow.Value, nmDTriResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDTriRow.Value, nmDTriSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDTriRow.Value, nmDTriSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtTriTest.Text = "ลำดับ " + No + " Trig " + tri + " result " + result + " summary " + summary;
            if (cc.eidb.updateTrig(nmDTriValue.Value.ToString(), nmDTriNo.Value.ToString(), nmDTriResult.Value.ToString(), nmDTriRow.Value.ToString(), nmDTriSummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล Trig เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnChoExcel_Click(object sender, EventArgs e)
        {
            String No = "", cho = "", result = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDChoRow.Value, nmDChoNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDChoRow.Value, nmDChoNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDChoValue.Value].Value2 != null)
            {
                cho = xlRange.Cells[nmDChoRow.Value, nmDChoValue.Value].Value2.ToString();
            }
            else
            {
                cho = "";
            }
            cho = cho.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDChoResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDChoRow.Value, nmDChoResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDChoSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDChoRow.Value, nmDChoSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtChoTest.Text = "ลำดับ " + No + " choles " + cho + " result " + result + " summary " + summary;
            if (cc.eidb.updateTrig(nmDChoValue.Value.ToString(), nmDChoNo.Value.ToString(), nmDChoResult.Value.ToString(), nmDChoRow.Value.ToString(), nmDChoSummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล Choles เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnSgotExcel_Click(object sender, EventArgs e)
        {
            String No = "", sgot = "", sgpt="", result = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDSgotRow.Value, nmDSgotNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotvalue.Value].Value2 != null)
            {
                sgot = xlRange.Cells[nmDSgotRow.Value, nmDSgotvalue.Value].Value2.ToString();
            }
            else
            {
                sgot = "";
            }
            sgot = sgot.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotSgptValue.Value].Value2 != null)
            {
                sgpt = xlRange.Cells[nmDSgotRow.Value, nmDSgotSgptValue.Value].Value2.ToString();
            }
            else
            {
                sgpt = "";
            }
            sgpt = sgpt.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDSgotRow.Value, nmDSgotResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDSgotRow.Value, nmDSgotSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtSgotTest.Text = "ลำดับ " + No + " sgot " + sgot + " sgpt " + sgpt + " result " + result + " summary " + summary;
            if (cc.eidb.updateSgot(nmDSgotvalue.Value.ToString(), nmDSgotNo.Value.ToString(), nmDSgotResult.Value.ToString(), nmDSgotRow.Value.ToString(), nmDSgotSgptValue.Value.ToString(), nmDSgotSummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล Sgot เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnBunExcel_Click(object sender, EventArgs e)
        {
            String No = "", bun = "", creatinine = "", result = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDBunRow.Value, nmDBunNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDBunRow.Value, nmDBunNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunValue.Value].Value2 != null)
            {
                bun = xlRange.Cells[nmDBunRow.Value, nmDBunValue.Value].Value2.ToString();
            }
            else
            {
                bun = "";
            }
            bun = bun.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunCreatinine.Value].Value2 != null)
            {
                creatinine = xlRange.Cells[nmDBunRow.Value, nmDBunCreatinine.Value].Value2.ToString();
            }
            else
            {
                creatinine = "";
            }
            creatinine = creatinine.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDBunRow.Value, nmDBunResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDBunRow.Value, nmDBunSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtSgotTest.Text = "ลำดับ " + No + " bun " + bun + " sgpt " + creatinine + " result " + result + " summary " + summary;
            if (cc.eidb.updateBun(nmDBunValue.Value.ToString(), nmDBunNo.Value.ToString(), nmDBunResult.Value.ToString(), nmDBunRow.Value.ToString(), nmDBunCreatinine.Value.ToString(), nmDBunSummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล BUN เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnUricExcel_Click(object sender, EventArgs e)
        {
            String No = "", uric = "", result = "", summary = "";
            ofd.ShowDialog();
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDUricRow.Value, nmDUricNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDUricRow.Value, nmDUricNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDUricRow.Value, nmDUricValue.Value].Value2 != null)
            {
                uric = xlRange.Cells[nmDUricRow.Value, nmDUricValue.Value].Value2.ToString();
            }
            else
            {
                uric = "";
            }
            uric = uric.Trim();
            if (xlRange.Cells[nmDUricRow.Value, nmDUricResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDUricRow.Value, nmDUricResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDUricRow.Value, nmDUricSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDUricRow.Value, nmDUricSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtTriTest.Text = "ลำดับ " + No + " Uric " + uric + " result " + result + " summary " + summary;
            if (cc.eidb.updateTrig(nmDUricValue.Value.ToString(), nmDUricNo.Value.ToString(), nmDUricResult.Value.ToString(), nmDUricRow.Value.ToString(), nmDUricSummary.Value.ToString()).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล Uric Acid เรียบร้อย", "บันทึกข้อมูล");
            }
        }
    }
}
