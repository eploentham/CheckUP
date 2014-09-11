using Cemp.Control;
using Cemp.objdb;
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
        public FrmReport(String rptName, String reportName, String condition, String sql, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            conn = cc.conn;
            initConfig(rptName, reportName, condition, sql);
        }
        public FrmReport(String rptName, String reportName, String condition, DataTable dt, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            conn = cc.conn;
            initConfig(rptName, reportName, condition, "", dt);
        }
        public FrmReport(String rptName, String reportName, String condition, DataSet ds, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            conn = cc.conn;
            initConfig(rptName, reportName, condition, "", ds);
        }
        private void initConfig(String rptName, String reportName, String condition, String sql)
        {

        }
        private void initConfig(String rptName, String reportName, String condition, String sql, DataTable dt)
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
                rpt.Load(cc.initC.PathReport+"\\" + rptName + ".rpt");
                rpt.SetDataSource(dt);
                //rpt.SetDataSource(dt2);
                //ParameterField myParam = new ParameterField();
                //myParam.Name = "header1";
                //myParam.
                rpt.SetParameterValue("header1", cc.cp.NameT);
                rpt.SetParameterValue("header2", reportName);
                rpt.SetParameterValue("header3", condition);

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
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

                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                chk = ex.Message.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
