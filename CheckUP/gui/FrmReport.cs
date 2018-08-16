using CheckUP.Control;
using CheckUP.objdb;
using CheckUP.object1;
using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP
{
    public partial class FrmReport : Form
    {
        CheckControl cc;
        ConnectDB conn;
        //Quotation qu;
        public FrmReport(CheckControl c)
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
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
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
                cc.lw.WriteLog("FrmReport setReport " + cc.initC.PathReport + rptName + ".rpt");
                rpt.Load(cc.initC.PathReport+ rptName + ".rpt");
                cc.lw.WriteLog("rpt.Load OK.");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.SetDataSource OK.");
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", cc.cop.NameT);
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
                rpt.Load(cc.initC.PathReport + rptName + ".rpt");
                rpt.SetDataSource(ds);
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", cc.cop.NameT);
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
        public void setReportCheckUpMini1(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUp OK ");
                rpt.Load(cc.initC.PathReport + "CheckUp_mini_1.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUp OK Load" + cc.initC.PathReport + "CheckUp_mini_1.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportCheckUp OK SetDataSource");
                //        //rpt.SetDataSource(dt2);
                //        //ParameterField myParam = new ParameterField();
                //        //myParam.Name = "header1";
                //        //myParam.

                rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี " + cuc.YearId);
                rpt.SetParameterValue("compName", "โรงพยาบาล อรวรรณ");
                rpt.SetParameterValue("compAddress", "8/8 หมู่ 6 ต.แพรกษา อ.เมือง จ.สมุทรปราการ 10280 โทร : 02-3342555  Fax.02-3342684");


                rpt.SetParameterValue("custName", cuc.CustNameT);
                //rpt.SetParameterValue("year_id",cuc.YearId);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUp Error " + chk);
            }
        }
        public void setReportCheckUpMini2(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUp OK ");
                rpt.Load(cc.initC.PathReport + "CheckUp_mini_2.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUp OK Load" + cc.initC.PathReport + "CheckUp_mini_2.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportCheckUp OK SetDataSource");
                //        //rpt.SetDataSource(dt2);
                //        //ParameterField myParam = new ParameterField();
                //        //myParam.Name = "header1";
                //        //myParam.

                //rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี " + cuc.YearId);
                //rpt.SetParameterValue("compName", "โรงพยาบาล อรวรรณ");
                //rpt.SetParameterValue("compAddress", "8/8 หมู่ 6 ต.แพรกษา อ.เมือง จ.สมุทรปราการ 10280 โทร : 02-3342555  Fax.02-3342684");


                rpt.SetParameterValue("custName", cuc.CustNameT);
                //rpt.SetParameterValue("year_id",cuc.YearId);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUp Error " + chk);
            }
        }
        public void setReportCheckUpMini3(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUp OK ");
                rpt.Load(cc.initC.PathReport + "CheckUp_mini_3.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUp OK Load" + cc.initC.PathReport + "CheckUp_mini_3.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportCheckUp OK SetDataSource");
                //        //rpt.SetDataSource(dt2);
                //        //ParameterField myParam = new ParameterField();
                //        //myParam.Name = "header1";
                //        //myParam.

                //rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี " + cuc.YearId);
                //rpt.SetParameterValue("compName", "โรงพยาบาล อรวรรณ");
                //rpt.SetParameterValue("compAddress", "8/8 หมู่ 6 ต.แพรกษา อ.เมือง จ.สมุทรปราการ 10280 โทร : 02-3342555  Fax.02-3342684");


                rpt.SetParameterValue("custName", cuc.CustNameT);
                //rpt.SetParameterValue("year_id",cuc.YearId);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUp Error " + chk);
            }
        }
        public void setReportCheckUpMini4(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUp OK ");
                rpt.Load(cc.initC.PathReport + "CheckUp_mini_4.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUp OK Load" + cc.initC.PathReport + "CheckUp_mini_4.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportCheckUp OK SetDataSource");
                //        //rpt.SetDataSource(dt2);
                //        //ParameterField myParam = new ParameterField();
                //        //myParam.Name = "header1";
                //        //myParam.

                //rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี " + cuc.YearId);
                //rpt.SetParameterValue("compName", "โรงพยาบาล อรวรรณ");
                //rpt.SetParameterValue("compAddress", "8/8 หมู่ 6 ต.แพรกษา อ.เมือง จ.สมุทรปราการ 10280 โทร : 02-3342555  Fax.02-3342684");


                rpt.SetParameterValue("custName", cuc.CustNameT);
                //rpt.SetParameterValue("year_id",cuc.YearId);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUp Error " + chk);
            }
        }
        public void setReportCheckUp(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUp OK ");
                rpt.Load(cc.initC.PathReport + "CheckUpPrint3.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUp OK Load" + cc.initC.PathReport + "CheckUpPrint3.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportCheckUp OK SetDataSource");
        //        //rpt.SetDataSource(dt2);
        //        //ParameterField myParam = new ParameterField();
        //        //myParam.Name = "header1";
        //        //myParam.
        
                rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี "+ cuc.YearId);
                //rpt.SetParameterValue("compName", "โรงพยาบาล อรวรรณ");
                //rpt.SetParameterValue("compAddress", "8/8 หมู่ 6 ต.แพรกษา อ.เมือง จ.สมุทรปราการ 10280 โทร : 02-3342555  Fax.02-3342684");
                rpt.SetParameterValue("compName", "โรงพยาบาล บางนา5 "+ cc.cop.NameT);
                rpt.SetParameterValue("compAddress", "55 หมู่4 ถนนเทพารักษ์ ตำบลบางพลีใหญ่ อำเภอบางพลี จังหวัดสมุทรปราการ 10540");

                rpt.SetParameterValue("custName", cuc.CustNameT);
                //rpt.SetParameterValue("year_id",cuc.YearId);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUp Error " + chk);
            }
        }
        public void setReportCheckUpSticker(DataTable dt)
        {
            //MessageBox.Show(" 1111 ", "");
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            //MessageBox.Show(" 22222 ", "");
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUpSticker OK dt="+dt.Rows.Count+ " path " + cc.initC.PathReport + "CheckUpSticker.rpt");
                if(!File.Exists(cc.initC.PathReport + "CheckUpSticker.rpt"))
                {
                    MessageBox.Show(" File not found " + cc.initC.PathReport + "CheckUpSticker.rpt", "");
                    return;
                }
                else
                {
                    //MessageBox.Show(" OK " , "");
                }
                //MessageBox.Show(" OK 1", "");
                rpt.Load(cc.initC.PathReport + "CheckUpSticker.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUpSticker OK Load" + cc.initC.PathReport + "CheckUpSticker.rpt");
                rpt.SetDataSource(dt);
                cc.lw.WriteLog("rpt.setReportCheckUpSticker OK SetDataSource");

                //rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี 2557");
                //rpt.SetParameterValue("compName", "โรงพบาบาล บางนา5");
                //rpt.SetParameterValue("compAddress", "55 หมู่4 ");

                //rpt.SetParameterValue("custName", "Test Company");
                

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUpSticker Error " + chk);
            }
        }
        public void setReportCheckUpPE(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUpPE OK ");
                //rpt.Load(cc.initC.PathReport + "\\PEDetailPrint.rpt");
                rpt.Load(cc.initC.PathReport + "SumPE.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUpXRays OK Load" + cc.initC.PathReport + "SumPE.rpt");
                rpt.SetDataSource(dt);
                rpt.SetParameterValue("line1", cuc.CustNameT);
                rpt.SetParameterValue("line2", "โรงพยาบาล บางนา5");
                rpt.SetParameterValue("line3", "55 หมู่4 ถนนเทพารักษ์ ตำบลบางพลีใหญ่ อำเภอบางพลี จังหวัดสมุทรปราการ 10540");
                //rpt.SetParameterValue("custName", cuc.CustNameT);
                cc.lw.WriteLog("rpt.setReportCheckUpPE OK SetDataSource");

                //rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี 2557");
                //rpt.SetParameterValue("compName", "โรงพบาบาล บางนา5");
                //rpt.SetParameterValue("compAddress", "55 หมู่4 ");

                //rpt.SetParameterValue("custName", "Test Company");


                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUpSticker Error " + chk);
            }
        }
        public void setReportCheckUpXRay(CustCheckUp cuc, DataTable dt)
        {
            String chk = "";
            ReportDocument rpt = new ReportDocument();
            try
            {
                cc.lw.WriteLog("rpt.setReportCheckUpXRay OK ");
                rpt.Load(cc.initC.PathReport + "XrayDetailPrint.rpt");
                cc.lw.WriteLog("rpt.setReportCheckUpXRays OK Load" + cc.initC.PathReport + "XrayDetailPrint.rpt");
                rpt.SetDataSource(dt);
                rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี 2557");
                //rpt.SetParameterValue("compName", "โรงพยาบาล บางนา5");
                //rpt.SetParameterValue("compAddress", "55 หมู่4 ถนนเทพารักษ์ ตำบลบางพลีใหญ่ อำเภอบางพลี จังหวัดสมุทรปราการ 10540");
                rpt.SetParameterValue("compName", "โรงพยาบาล บางนา5");
                rpt.SetParameterValue("compAddress", "55 หมู่4 ถนนเทพารักษ์ ตำบลบางพลีใหญ่ อำเภอบางพลี จังหวัดสมุทรปราการ 10540");

                rpt.SetParameterValue("custName", cuc.CustNameT);
                cc.lw.WriteLog("rpt.setReportCheckUpXRays OK SetDataSource");

                //rpt.SetParameterValue("line1", "ผลตรวจสุขภาพประจำปี 2557");
                //rpt.SetParameterValue("compName", "โรงพบาบาล บางนา5");
                //rpt.SetParameterValue("compAddress", "55 หมู่4 ");

                //rpt.SetParameterValue("custName", "Test Company");


                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
                cc.lw.WriteLog("rpt.setReportCheckUpSticker Error " + chk);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
