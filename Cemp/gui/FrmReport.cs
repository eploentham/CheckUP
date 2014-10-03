using Cemp.Control;
using Cemp.objdb;
using Cemp.object1;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp
{
    public partial class FrmReport : Form
    {
        CnviControl cc;
        ConnectDB conn;
        //Quotation qu;
        public FrmReport(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            conn = cc.conn;
            //initConfig(rptName, reportName, condition, sql);
        }

        //public void setQuotation(Quotation p)
        //{
        //    qu = p;
        //}
        private void initConfig(String rptName, String reportName, String condition, String sql)
        {

        }
        public void setReport(String rptName, String reportName, String condition, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            //DataTable dt1;
            //DataSet ds = new DataSet();
            //if (!sql.Equals(""))
            //{
            //    dt1 = conn.selectData(sql);
            //}
            //else
            //{
            //    dt1 = dt;
            //}
            
            //string directory = My.Application.Info.DirectoryPath;
            //rpt.Load(directory & "\myCrystalReport1.rpt")
            //rpt.Load(Environment.CurrentDirectory + "\\report\\" + rptName + ".rpt");
            
            //ConnectionInfo crConnectionInfo = new ConnectionInfo();
            //crConnectionInfo.ServerName = "";
            //crConnectionInfo.DatabaseName = Environment.CurrentDirectory + "\\database\\cemp.mdb";
            //foreach (Table crTable in rpt.Database.Tables)
            //{
            //    TableLogOnInfo crLogOnInfo = crTable.LogOnInfo;
            //    crLogOnInfo.ConnectionInfo = crConnectionInfo;
            //    crTable.ApplyLogOnInfo(crLogOnInfo);
            //    //crTable.Location = crTable.Location;
            //}
            //rpt.DataSourceConnections.Clear();
            //rpt.DataSourceConnections[0].SetConnection("", Environment.CurrentDirectory + "\\database\\cemp.mdb", false);
            //rpt.Database.Tables[0].Location = Environment.CurrentDirectory + "\\database\\cemp.mdb";
            //rpt.Load(Environment.CurrentDirectory + "\\report\\test.rpt");
            try
            {
                cc.lw.WriteLog("FrmReport setReport " + cc.initC.PathReport + "\\" + rptName + ".rpt");
                rpt.Load(cc.initC.PathReport+"\\" + rptName + ".rpt");
                cc.lw.WriteLog("rpt.Load OK.");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.SetDataSource OK.");
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", cc.cp.NameT);
                rpt.SetParameterValue("header2", reportName);
                rpt.SetParameterValue("header3", condition);
                cc.lw.WriteLog("rpt.SetParameterValue OK.");
                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.SetParameterValue Error " + chk);
            }
            
            //rpt.SetParameterValue("CustomerID", this.txtCustomerID.Text);
            
        }
        private void initConfig(String rptName, String reportName, String condition, String sql, DataSet ds)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                rpt.Load(cc.initC.PathReport + "\\" + rptName + ".rpt");
                rpt.SetDataSource(ds);
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", cc.cp.NameT);
                rpt.SetParameterValue("header2", reportName);
                rpt.SetParameterValue("header3", condition);

                //if (rptName.Equals("QuotationPrint"))
                //{
                //    rpt.SetParameterValue("", cc.qu
                //}

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
            }
        }
        public void setReportResult(Result rs, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportResult OK ");
                rpt.Load(cc.initC.PathReport + "\\ResultPrint.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportResult OK SetDataSource");

                rpt.SetParameterValue("compName", cc.cp.NameT);
                rpt.SetParameterValue("compAddress1", cc.cp.AddressT);
                rpt.SetParameterValue("compAddress2", "Tel "+cc.cp.Tele+" FAX "+cc.cp.Fax+" Email "+cc.cp.Email);
                rpt.SetParameterValue("taxid", cc.cp.TaxId);

                rpt.SetParameterValue("custName", rs.CustNameT);
                rpt.SetParameterValue("custAddress", rs.CustAddressT);
                rpt.SetParameterValue("machinery", rs.Machinery);
                rpt.SetParameterValue("measurecompany", cc.cp.NameT);
                rpt.SetParameterValue("methodmeasure", rs.MethodMeasure);

                rpt.SetParameterValue("summary", rs.Summary);
                rpt.SetParameterValue("line1", cc.cp.quLine1);
                rpt.SetParameterValue("line2", cc.cp.quLine1);
                rpt.SetParameterValue("line3", cc.cp.quLine1);
                //rpt.SetParameterValue("datedueperiod", rs.InvDuePeriod);
                ////rpt.SetParameterValue("duedate", "");
                //rpt.SetParameterValue("amount", rs.Amount);
                //rpt.SetParameterValue("total", rs.Total);

                //rpt.SetParameterValue("vatrate", rs.VatRate);

                //rpt.SetParameterValue("nettotal", rs.Nettotal);
                //rpt.SetParameterValue("contactName", qu.ContactName);

                //rpt.SetParameterValue("line2", inv.StaffPlaceRecordPosition);
                //rpt.SetParameterValue("staffplacerecordname", inv.StaffPlaceRecordName);
                //rpt.SetParameterValue("line3", "ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ");

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportResult Error " + chk);
            }
        }
        public void setReportInvoice(Invoice inv, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportInvoice OK ");
                rpt.Load(cc.initC.PathReport + "\\InvoicePrint.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportInvoice OK SetDataSource");

                //rpt.SetParameterValue("compName", inv.CompName);
                //rpt.SetParameterValue("compAddress1", inv.CompAddress1);
                //rpt.SetParameterValue("compAddress2", inv.CompAddress2);
                rpt.SetParameterValue("taxid", cc.cp.TaxId);

                rpt.SetParameterValue("custname", inv.CustName);
                rpt.SetParameterValue("custaddress1", inv.CustAddress);
                rpt.SetParameterValue("custaddress2", inv.CustTel);
                rpt.SetParameterValue("invdate", cc.cf.dateDBtoShow1(inv.InvDate));
                rpt.SetParameterValue("discount", inv.Discount);

                rpt.SetParameterValue("invnumber", inv.InvNumber);
                rpt.SetParameterValue("dueperiod", inv.InvDuePeriod);
                rpt.SetParameterValue("datedueperiod", inv.InvDuePeriod);
                //rpt.SetParameterValue("duedate", "");
                rpt.SetParameterValue("amount", inv.Amount);
                rpt.SetParameterValue("total", inv.Total);

                rpt.SetParameterValue("vatrate", inv.VatRate);

                rpt.SetParameterValue("nettotal", inv.Nettotal);
                //rpt.SetParameterValue("contactName", qu.ContactName);

                //rpt.SetParameterValue("line2", inv.StaffPlaceRecordPosition);
                //rpt.SetParameterValue("staffplacerecordname", inv.StaffPlaceRecordName);
                //rpt.SetParameterValue("line3", "ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ");

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportInvoice Error " + chk);
            }
        }
        public void setReportMOUSamplePrint(MOU mo, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportMOUSamplePrint OK ");
                rpt.Load(cc.initC.PathReport + "\\MOUSamplePrint.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportMOUSamplePrint OK SetDataSource");

                rpt.SetParameterValue("compName", mo.CompName);
                rpt.SetParameterValue("compAddress1", mo.CompAddress1);
                rpt.SetParameterValue("compAddress2", mo.CompAddress2);
                rpt.SetParameterValue("compTaxId", mo.CompTaxId);

                rpt.SetParameterValue("custName", mo.CustName);
                rpt.SetParameterValue("custAddress", mo.CustAddress);
                rpt.SetParameterValue("custTel", mo.CustTel);
                //rpt.SetParameterValue("custFax", mo.CustFax);
                rpt.SetParameterValue("custEmail", mo.CustEmail);

                rpt.SetParameterValue("mouNumber", mo.MOUNumberMain);
                rpt.SetParameterValue("dateperiod", "เก็บตัวอย่างระหว่างวันที่ : " + mo.DatePeriod);
                rpt.SetParameterValue("staffmouname", mo.StaffMOUName);
                //rpt.SetParameterValue("staffName", mo.StaffName);
                rpt.SetParameterValue("staffTel", mo.StaffMOUTel);
                rpt.SetParameterValue("staffEmail", mo.StaffMOUEmail);

                rpt.SetParameterValue("contactName", mo.ContactName);

                rpt.SetParameterValue("line1", mo.Line1);
                //rpt.SetParameterValue("contactName", qu.ContactName);

                rpt.SetParameterValue("line2", mo.StaffPlaceRecordPosition);
                rpt.SetParameterValue("staffplacerecordname", mo.StaffPlaceRecordName);
                rpt.SetParameterValue("line3", "ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ");
                rpt.SetParameterValue("staffanalysis", "ผู้รับตัวอย่างเข้าวิเคราะห์ : "+mo.StaffAnalysisName);
                rpt.SetParameterValue("lstaffplacerecord", "ผู้เก็บตัวอย่าง : "+mo.StaffPlaceRecordName);
                rpt.SetParameterValue("dateplacerecord","วันที่ "+ mo.DatePlaceRecord);


                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportMOUSamplePrint Error " + chk);
            }
        }
        public void setReportMOU(MOU mo, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportMOU OK ");
                rpt.Load(cc.initC.PathReport + "\\MOUPrint.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportMOU OK SetDataSource");

                rpt.SetParameterValue("compName", mo.CompName);
                rpt.SetParameterValue("compAddress1", mo.CompAddress1);
                rpt.SetParameterValue("compAddress2", mo.CompAddress2);
                rpt.SetParameterValue("compTaxId", mo.CompTaxId);

                rpt.SetParameterValue("custName", mo.CustName);
                rpt.SetParameterValue("custAddress", mo.CustAddress);
                rpt.SetParameterValue("custTel", mo.CustTel);
                //rpt.SetParameterValue("custFax", mo.CustFax);
                rpt.SetParameterValue("custEmail", mo.CustEmail);

                rpt.SetParameterValue("mouNumber", mo.MOUNumberMain);
                rpt.SetParameterValue("dateperiod", "เก็บตัวอย่างระหว่างวันที่ : " + mo.DatePlaceRecord);
                rpt.SetParameterValue("staffmouname", mo.StaffMOUName);
                //rpt.SetParameterValue("staffName", mo.StaffName);
                rpt.SetParameterValue("staffTel", mo.StaffMOUTel);
                rpt.SetParameterValue("staffEmail", mo.StaffMOUEmail);

                rpt.SetParameterValue("contactName", mo.ContactName);
                
                rpt.SetParameterValue("line1", mo.Line1);
                //rpt.SetParameterValue("contactName", qu.ContactName);

                rpt.SetParameterValue("line2", mo.StaffPlaceRecordPosition);
                rpt.SetParameterValue("staffplacerecordname", mo.StaffPlaceRecordName);
                rpt.SetParameterValue("line3", "ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ");

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportMOU Error " + chk);
            }
        }
        public void setReportQuotation(Quotation qu, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportQuotation OK ");
                rpt.Load(cc.initC.PathReport + "\\QuotationPrint.rpt");
                cc.lw.WriteLog("rpt.setReportQuotation OK Load" + cc.initC.PathReport + "\\QuotationPrint.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportQuotation OK SetDataSource");
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                //rpt.SetParameterValue("header1", cc.cp.NameT);
                //rpt.SetParameterValue("header2", reportName);
                //rpt.SetParameterValue("header3", condition);

                rpt.SetParameterValue("quoNumber", qu.QuoNumber);
                rpt.SetParameterValue("quoDate", qu.QuoDate);
                rpt.SetParameterValue("contactName", qu.ContactName);
                rpt.SetParameterValue("compName", qu.CompName);
                rpt.SetParameterValue("compAddress1", qu.CompAddress1);
                rpt.SetParameterValue("compAddress2", qu.CompAddress2);
                rpt.SetParameterValue("compTaxId", qu.CompTaxId);
                rpt.SetParameterValue("line1", qu.Line1);
                //rpt.SetParameterValue("contactName", qu.ContactName);
                rpt.SetParameterValue("custName", qu.CustName);
                rpt.SetParameterValue("custAddress", qu.CustAddress);
                rpt.SetParameterValue("custTel", qu.CustTel);
                rpt.SetParameterValue("custFax", qu.CustFax);
                rpt.SetParameterValue("custEmail", qu.CustEmail);
                rpt.SetParameterValue("line2", qu.Line2);
                rpt.SetParameterValue("staffName", qu.StaffName);
                rpt.SetParameterValue("staffTel", qu.StaffTel);
                rpt.SetParameterValue("staffEmail", qu.StaffEmail);
                rpt.SetParameterValue("remark1", qu.Remark1);
                rpt.SetParameterValue("remark2", qu.Remark2);
                rpt.SetParameterValue("remark3", qu.Remark3);
                rpt.SetParameterValue("remark4", qu.Remark4);
                rpt.SetParameterValue("remark5", qu.Remark5);
                rpt.SetParameterValue("remark6", qu.Remark6);
                rpt.SetParameterValue("remark7", qu.Remark7);

                rpt.SetParameterValue("line1", qu.Line1);
                rpt.SetParameterValue("line2", qu.Line2);
                rpt.SetParameterValue("line3", qu.Line3);
                rpt.SetParameterValue("line4", qu.Line4);
                rpt.SetParameterValue("line5", qu.Line5);
                rpt.SetParameterValue("line6", qu.Line6);
                rpt.SetParameterValue("staffApproveName", qu.StaffApproveName);
                rpt.SetParameterValue("amount2", qu.Amount);
                rpt.SetParameterValue("discountPer", qu.DiscountPer);
                rpt.SetParameterValue("discount", qu.Discount);
                rpt.SetParameterValue("amountDiscount", qu.AmountDiscount);
                rpt.SetParameterValue("plus1Name", qu.Plus1Name);
                rpt.SetParameterValue("plus1", qu.Plus1);
                rpt.SetParameterValue("total", qu.Total);
                rpt.SetParameterValue("vatRate", qu.VatRate);
                rpt.SetParameterValue("vat", qu.Vat);
                rpt.SetParameterValue("netTotal", qu.NetTotal);
                rpt.SetParameterValue("lamount", "รวมราคา");
                rpt.SetParameterValue("ldiscount", "ส่วนลด");
                rpt.SetParameterValue("plus1name", "ค่าภาคสนาม(ค่าเดินทาง)");
                rpt.SetParameterValue("ltotal", "รวม");
                rpt.SetParameterValue("lvat", "ภาษีมูลค่าเพิ่ม");
                rpt.SetParameterValue("lnettotal", "รวมทั้งสิ้น");
                rpt.SetParameterValue("lcustapprove","อนุมัติสั่งซื้อตามราบการที่เสนอ");
                rpt.SetParameterValue("lstaffquotation", "ผู้เสนอราคา");
                rpt.SetParameterValue("lstaffapprove", "ขอแสดงความนับถือ");
                rpt.SetParameterValue("thaibaht", qu.ThaiBaht);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);
                //rpt.SetParameterValue("", qu.QuoDate);


                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportQuotation Error " + chk);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
