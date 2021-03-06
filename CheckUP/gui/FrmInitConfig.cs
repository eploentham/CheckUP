﻿using CheckUP.Control;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.gui
{
    public partial class FrmInitConfig : Form
    {
        CheckControl cc;
        Staff sf;
        public FrmInitConfig(String sfCode, CheckControl l)
        {
            InitializeComponent();
            initConfig(sfCode, l);
        }
        private void initConfig(String sfCode, CheckControl l)
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
            btnPathMini.Click += BtnPathMini_Click;

            txtHostDBonsite.Text = cc.initC.hostDBonsite;
            txtNameDBonsite.Text = cc.initC.nameDBonsite;
            txtUserDBonsite.Text = cc.initC.userDBonsite;
            txtPassDBonsite.Text = cc.initC.passDBonsite;
            txtPortDBonsite.Text = cc.initC.portDBonsite;

            ChkServer.Checked = cc.initC.StatusServer.Equals("yes") ? true : false;
            ChkClient.Checked = cc.initC.StatusServer.Equals("yes") ? false : true;

            //{
            //    ChkServer.Checked = true;
            //    gBServer.Visible = true;
            //    ChkClient.Checked = false;
            //    gBClient.Visible = false;

            //    chkConnectServer.Checked = true;
            txtHost.Text = cc.initC.ServerIP;
            txtUser.Text = cc.initC.User;
            txtPwd.Text = cc.initC.Password;
            txtDatabase.Text = cc.initC.Database;
            txtPort.Text = cc.initC.Port;
                //txtDatabase.Visible = true;
                //txtHost.Visible = true;
                //txtPwd.Visible = true;
                //txtUser.Visible = true;
                
            //}
            //else
            //{
            //    ChkServer.Checked = false;
            //    gBServer.Visible = false;
            //    ChkClient.Checked = true;
            //    gBClient.Visible = true;

            //    chkConnectServer.Checked = false;
            //    txtDatabase.Visible = false;
            //    txtHost.Visible = true;
            //    txtPwd.Visible = false;
            //    txtUser.Visible = false;
            //}
            
            txtPathReport.Text = cc.initC.PathReport;
            
            txtQuoLine1.Text = cc.initC.quoLine1;
            txtQuoLine2.Text = cc.initC.quoLine2;
            txtQuoLine3.Text = cc.initC.quoLine3;
            txtQuoLine4.Text = cc.initC.quoLine4;
            txtQuoLine5.Text = cc.initC.quoLine5;
            txtQuoLine6.Text = cc.initC.quoLine6;
            txtHost.Text = cc.initC.IPServer;
            txtPathMini.Text = cc.initC.pathMini;
            
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

        private void BtnPathMini_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathMini.Text = fbd.SelectedPath;
            cc.SetPathMini(txtPathMini.Text.Trim());
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

            cc.SetHostDBinsite(txtHostDBonsite.Text);
            cc.SetNameDBinsite(txtNameDBonsite.Text);
            cc.SetUserDBinsite(txtUserDBonsite.Text);
            cc.SetPassDBinsite(txtPassDBonsite.Text);
            cc.SetPortDBinsite(txtPortDBonsite.Text);



            cc.SetHideCostQuotation(chkHideCostQuotation.Checked);
            if (ChkServer.Checked)
            {
                cc.SetSetatusServer(true);                              

            }
            else
            {
                cc.SetSetatusServer(false);
                //cc.SetConnectServer(chkConnectServer.Checked, txtHost.Text, txtUser.Text, txtPwd.Text);
                //lc.SetPathImage(txtPathImage.Text);
                //cc.SetIPServer(txtHost.Text);
                

            }
            cc.GetConfig();
        }

        private void chkConnectServer_Click(object sender, EventArgs e)
        {
            //if (chkConnectServer.Checked)
            //{
            //    label1.Visible = true;
            //    label2.Visible = true;
            //    label3.Visible = true;
            //    label4.Visible = true;
            //    btnTest.Visible = true;
            //    lV1.Visible = true;

            //    txtHost.Visible = true;
                

            //    txtDatabase.Visible = true;
            //    txtUser.Visible = true;
            //    txtPwd.Visible = true;
            //}
            //else
            //{
            //    label1.Visible = false;
            //    label2.Visible = false;
            //    label3.Visible = false;
            //    label4.Visible = false;
            //    btnTest.Visible = false;
            //    lV1.Visible = false;

            //    txtHost.Visible = false;
                

            //    txtDatabase.Visible = false;
            //    txtUser.Visible = false;
            //    txtPwd.Visible = false;
            //}
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
            
            
        }        

        private void ChkServer_Click(object sender, EventArgs e)
        {
            //gBServer.Visible = true;
            //gBClient.Visible = false;
        }

        private void ChkClient_Click(object sender, EventArgs e)
        {
            //gBServer.Visible = false;
            //gBClient.Visible = true;
        }

        private void btnPathReport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathReport.Text = fbd.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pB1.Visible = true;
            //String sql = "";
            //sql = "Select Distinct method1 From data_convert570915";
            //DataTable dt = cc.conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    pB1.Minimum = 0;
            //    pB1.Maximum = dt.Rows.Count;
            //    for (int i = 0; i < dt.Rows.Count; i++)
            //    {
            //        Method me = new Method();
            //        String[] doc = dt.Rows[i]["method1"].ToString().Split();
            //        me.Id = "";
            //        me.Active = "1";
            //        if (doc[0].ToString().Equals("-"))
            //        {
            //            me.Code = cc.medb.selectMax();
            //        }
            //        else
            //        {
            //            //if (doc.Length > 1)
            //            //{
            //            //    if (doc[1] != null)
            //            //    {
            //            //        me.Code = doc[0].sub + doc[1] + cc.medb.selectMax();
            //            //    }
            //            //    else
            //            //    {
            //            //        me.Code = doc[0] + cc.medb.selectMax();
            //            //    }
            //            //}
            //            //else
            //            //{
            //            //    me.Code = doc[0] + cc.medb.selectMax();
            //            //}
            //            me.Code =cc.medb.selectMax();
                        
            //        }
                    
            //        me.dateCreate = me.dateGenDB;
            //        me.NameE = dt.Rows[i]["method1"].ToString();
            //        me.NameT = dt.Rows[i]["method1"].ToString();
            //        me.Remark = "";
            //        me.userCreate = cc.sf.Id;
            //        me.Sort1 = cc.medb.selectSortMax();
            //        cc.medb.insertMethod(me);
            //        pB1.Value = i;
            //    }
            //}
            //pB1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    pB1.Visible = true;
        //    String sql = "";
        //    sql = "Select * From data_convert570915";
        //    DataTable dt = cc.conn.selectData(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        pB1.Minimum = 0;
        //        pB1.Maximum = dt.Rows.Count;
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            Item it = new Item();
        //            //String[] doc = dt.Rows[i]["method1"].ToString().Split();
        //            it.Id = "";
        //            it.Code = dt.Rows[i]["code"].ToString();
        //            it.dateCreate = it.dateGenDB;
        //            it.ItemGroupId = cc.itgdb.selectByNameT1(dt.Rows[i]["type1"].ToString());
        //            it.ItemGroupNameT=dt.Rows[i]["type1"].ToString();
        //            it.MeasuringPoint="";
        //            it.MethodId=cc.medb.selectByNameT1(dt.Rows[i]["method1"].ToString());
        //            it.MethodNameT = dt.Rows[i]["method1"].ToString();
        //            it.NameE = dt.Rows[i]["name1"].ToString();
        //            it.NameT = dt.Rows[i]["name1"].ToString();
        //            it.PriceCost = dt.Rows[i]["price_cost"].ToString();
        //            it.PriceSale = dt.Rows[i]["price_sale"].ToString();
        //            it.Remark = "convert 57-09-15";
        //            it.Sort1 = "";
        //            it.userCreate = cc.sf.Code;
        //            cc.itdb.insertItem(it);
        //            pB1.Value = i;
        //        }
        //    }
        //    pB1.Visible = false;
        }

    }
}
