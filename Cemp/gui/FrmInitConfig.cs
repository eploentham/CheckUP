using Cemp.Control;
using Cemp.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Cemp.gui
{
    public partial class FrmInitConfig : Form
    {
        CnviControl cc;
        Staff sf;
        public FrmInitConfig(String sfCode, CnviControl l)
        {
            InitializeComponent();
            initConfig(sfCode, l);
        }
        private void initConfig(String sfCode, CnviControl l)
        {
            cc = l;
            sf = cc.sfdb.selectByCode(sfCode);
            if (cc.initC.clearInput.Equals("yes"))
            {
                chkClearInput.Checked = true;
            }
            else
            {
                chkClearInput.Checked = false;
            }
            if (cc.initC.StatusServer.Equals("yes"))
            {
                ChkServer.Checked = true;
                gBServer.Visible = true;
                ChkClient.Checked = false;
                gBClient.Visible = false;

                chkConnectServer.Checked = true;
                txtHost.Text = cc.initC.ServerIP;
                txtUser.Text = cc.initC.User;
                txtPwd.Text = cc.initC.Password;
                txtDatabase.Text = cc.initC.Database;
                txtDatabase.Visible = true;
                txtHost.Visible = true;
                txtPwd.Visible = true;
                txtUser.Visible = true;
                
            }
            else
            {
                ChkServer.Checked = false;
                gBServer.Visible = false;
                ChkClient.Checked = true;
                gBClient.Visible = true;

                chkConnectServer.Checked = false;
                txtDatabase.Visible = false;
                txtHost.Visible = true;
                txtPwd.Visible = false;
                txtUser.Visible = false;
            }
            if (cc.initC.connectDatabaseServer.Equals("yes"))
            {
                ChkServer.Checked = true;
                gBServer.Visible = true;
                ChkClient.Checked = false;
                gBClient.Visible = false;

                chkConnectServer.Checked = true;
                txtHost.Text = cc.initC.ServerIP;
                txtUser.Text = cc.initC.User;
                txtPwd.Text = cc.initC.Password;
                txtDatabase.Text = cc.initC.Database;
                txtDatabase.Visible = true;
                txtHost.Visible = true;
                txtPwd.Visible = true;
                txtUser.Visible = true;

            }
            txtIP.Text = cc.initC.IPServer;
            txtPathData.Text = cc.initC.PathData;
            txtPathImage.Text = cc.initC.pathImageLogo;
            txtPathReport.Text = cc.initC.PathReport;
            txtNameShareData.Text = cc.initC.NameShareData;
            txtQuoLine1.Text = cc.initC.quoLine1;
            txtQuoLine2.Text = cc.initC.quoLine2;
            txtQuoLine3.Text = cc.initC.quoLine3;
            txtQuoLine4.Text = cc.initC.quoLine4;
            txtQuoLine5.Text = cc.initC.quoLine5;
            txtQuoLine6.Text = cc.initC.quoLine6;
            txtHost.Text = cc.initC.IPServer;
            txtConnectShareData.Text = cc.initC.ConnectShareData;
            if (cc.initC.delImage.Equals("yes"))
            {
                chkDelImage.Checked = true;
            }
            else
            {
                chkDelImage.Checked = false;
            }
            if (cc.initC.use32Bit.Equals("yes"))
            {
                chkUse32bit.Checked = true;
            }
            else
            {
                chkUse32bit.Checked = false;
            }
            if (cc.initC.HideCostQuotation.Equals("yes"))
            {
                chkHideCostQuotation.Checked = true;
            }
            else
            {
                chkHideCostQuotation.Checked = false;
            }
            pB1.Visible = false;
        }
        private void FrmInitConfig_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cc.SetClearInput(chkClearInput.Checked);
            cc.SetUse32Bit(chkUse32bit.Checked);
            cc.SetPathReport(txtPathReport.Text);
            cc.SetQuoLine1(txtQuoLine1.Text);
            cc.SetQuoLine2(txtQuoLine2.Text);
            cc.SetQuoLine3(txtQuoLine3.Text);
            cc.SetQuoLine4(txtQuoLine4.Text);
            cc.SetQuoLine5(txtQuoLine5.Text);
            cc.SetQuoLine6(txtQuoLine6.Text);
            cc.SetHideCostQuotation(chkHideCostQuotation.Checked);
            if (ChkServer.Checked)
            {
                cc.SetSetatusServer(true);
                cc.SetPathImage(txtPathData.Text);
                cc.SetPathImageLogo(txtPathImage.Text);
                cc.SetDelImage(chkDelImage.Checked);

                cc.SetPathShareImage(txtPathShareImage.Text);
                cc.SetNameShareData(txtNameShareData.Text);
                cc.SetIPServer(txtIP.Text);
                
            }
            else
            {
                cc.SetSetatusServer(false);
                cc.SetConnectServer(chkConnectServer.Checked, txtHost.Text, txtDatabase.Text, txtUser.Text, txtPwd.Text);
                //lc.SetPathImage(txtPathImage.Text);
                cc.SetIPServer(txtHost.Text);
                cc.SetPathShareImage(txtConnectShareData.Text);
                cc.SetConnectShareData(txtConnectShareData.Text);

            }
            cc.GetConfig();
        }

        private void chkConnectServer_Click(object sender, EventArgs e)
        {
            if (chkConnectServer.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btnTest.Visible = true;
                lV1.Visible = true;

                txtHost.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                txtConnectShareData.Visible = true;
                txtConnectShareImage.Visible = true;

                txtDatabase.Visible = true;
                txtUser.Visible = true;
                txtPwd.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                btnTest.Visible = false;
                lV1.Visible = false;

                txtHost.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                txtConnectShareData.Visible = false;
                txtConnectShareImage.Visible = false;

                txtDatabase.Visible = false;
                txtUser.Visible = false;
                txtPwd.Visible = false;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //OpenFileDialog theDialog = new OpenFileDialog();
            //theDialog.Title = "Open Path File";
            ////theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"C:\";
            //if (theDialog.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(theDialog.FileName.ToString());
            //}
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathData.Text = fbd.SelectedPath;
        }

        private void btnPath1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathImage.Text = fbd.SelectedPath;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            cc.CreateSharedFolder(txtPathData.Text, txtNameShareData.Text, txtNameShareData.Text);
            //cc.CreateSharedFolder(Environment.CurrentDirectory + "\\Database\\", txtPathShareData.Text, txtPathShareData.Text);
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            txtIP.Text = cc.LocalIPAddress();
        }

        private void ChkServer_Click(object sender, EventArgs e)
        {
            gBServer.Visible = true;
            gBClient.Visible = false;
        }

        private void ChkClient_Click(object sender, EventArgs e)
        {
            gBServer.Visible = false;
            gBClient.Visible = true;
        }

        private void btnPathReport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathReport.Text = fbd.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pB1.Visible = true;
            String sql = "";
            sql = "Select Distinct method1 From data_convert571025";
            DataTable dt = cc.conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                pB1.Minimum = 0;
                pB1.Maximum = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Method me = new Method();
                    String[] doc = dt.Rows[i]["method1"].ToString().Split();
                    me.Id = "";
                    me.Active = "1";
                    if (doc[0].ToString().Equals("-"))
                    {
                        me.Code = cc.medb.selectMax();
                    }
                    else
                    {
                        //if (doc.Length > 1)
                        //{
                        //    if (doc[1] != null)
                        //    {
                        //        me.Code = doc[0].sub + doc[1] + cc.medb.selectMax();
                        //    }
                        //    else
                        //    {
                        //        me.Code = doc[0] + cc.medb.selectMax();
                        //    }
                        //}
                        //else
                        //{
                        //    me.Code = doc[0] + cc.medb.selectMax();
                        //}
                        me.Code =cc.medb.selectMax();
                        
                    }
                    
                    me.dateCreate = me.dateGenDB;
                    me.NameE = dt.Rows[i]["method1"].ToString();
                    me.NameT = dt.Rows[i]["method1"].ToString();
                    me.Remark = "";
                    me.userCreate = cc.sf.Id;
                    me.Sort1 = cc.medb.selectSortMax();
                    cc.medb.insertMethod(me);
                    pB1.Value = i;
                }
            }
            pB1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pB1.Visible = true;
            String sql = "";
            sql = "Select * From data_convert571025";
            DataTable dt = cc.conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                pB1.Minimum = 0;
                pB1.Maximum = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Item it = new Item();
                    //String[] doc = dt.Rows[i]["method1"].ToString().Split();
                    it.Id = "";
                    it.Code = dt.Rows[i]["code"].ToString();
                    it.dateCreate = it.dateGenDB;
                    it.ItemGroupId = cc.itgdb.selectByNameT1(dt.Rows[i]["group1"].ToString());
                    it.ItemGroupNameT = dt.Rows[i]["group1"].ToString();
                    it.MeasuringPoint="";
                    it.MethodId=cc.medb.selectByNameT1(dt.Rows[i]["method1"].ToString());
                    it.MethodNameT = dt.Rows[i]["method1"].ToString();
                    it.NameE = dt.Rows[i]["name1"].ToString();
                    it.NameT = dt.Rows[i]["name1"].ToString();
                    it.PriceCost = dt.Rows[i]["sub_price"].ToString();
                    it.PriceSale = dt.Rows[i]["price_sale"].ToString();
                    it.Remark = "convert 57-10-08";
                    it.ItemType = dt.Rows[i]["type1"].ToString().ToUpper();
                    it.Sort1 = "";
                    it.AnalysisId = cc.anadb.selectByNameT1(dt.Rows[i]["analysis"].ToString());
                    it.AnalysisNameT = dt.Rows[i]["analysis"].ToString();
                    //it.CustId = cc.getValueCboVendor(dt.Rows[i]["sub_name"].ToString());
                    it.CustId = cc.cudb.selectIdByNameT(dt.Rows[i]["sub_name"].ToString());
                    it.CustNameT = dt.Rows[i]["sub_name"].ToString();
                    it.userCreate = cc.sf.Code;
                    cc.itdb.insertItem(it);
                    pB1.Value = i;
                }
            }
            pB1.Visible = false;
        }

    }
}
