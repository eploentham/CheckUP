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
        public FrmReport(String rptName, String sql,CnviControl c)
        {
            InitializeComponent();
            cc = c;
            conn = cc.conn;
            initConfig(rptName, sql, null);
        }
        public FrmReport(String rptName, DataTable dt, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            conn = cc.conn;
            initConfig(rptName, "", dt);
        }
        private void initConfig(String rptName, String sql, DataTable dt)
        {
            ReportDocument rpt = new ReportDocument();
            DataTable dt1;
            if (!sql.Equals(""))
            {
                dt1 = conn.selectData(sql);
            }
            else
            {
                dt1 = dt;
            }
            
            //string directory = My.Application.Info.DirectoryPath;
            //rpt.Load(directory & "\myCrystalReport1.rpt")
            rpt.Load(Environment.CurrentDirectory + "\\report\\" + rptName + ".rpt");
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
            //rpt.SetDataSource(dt1);
            //rpt.SetParameterValue("CustomerID", this.txtCustomerID.Text);
            this.crystalReportViewer1.ReportSource = rpt;
            this.crystalReportViewer1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
