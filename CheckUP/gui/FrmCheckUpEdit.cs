﻿using CheckUP.Control;
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
    public partial class FrmCheckUpEdit : Form
    {
        CheckControl cc;
        CustCheckUp cuc;
        CustCheckUpPatient ccp;
        DataTable dtccp, dtccpvn;
        int tabSum = 0, tabPE = 1, tabXRay = 2, tabCBC = 3, tabFBS = 4, tabUA = 5, tabTri = 6, tabCho = 7, tabSgot = 8, tabBun = 9, tabUric = 10;
        int tabCnt = 11;

        public FrmCheckUpEdit(String ccpId,CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig(ccpId);
        }
        private void initConfig(String ccpId)
        {
            cuc = new CustCheckUp();
            ccp = new CustCheckUpPatient();
            dtccpvn = cc.ccpvndb.selectByPk();

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
            tC.TabPages[tabPE].Focus();
            //tC.TabPages[tabPrint].Text = "Print";
            setControl(ccpId);
        }
        private void setControl(String ccpId)
        {
            dtccp = cc.ccpdb.selectByPk(ccpId);
            cuc.Id = dtccp.Rows[0][cc.ccpdb.ccp.CustCheckUpId].ToString();
            cuc = cc.cucdb.selectByPk(cuc.Id);
            txtCustName.Text = cuc.CustNameT;

            txtFullName.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientFullname].ToString();
            //txtCustName.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientFullname].ToString();
            txtRowNumber.Text = dtccp.Rows[0][cc.ccpdb.ccp.rowNumber].ToString();

            txtBunCreatinineValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.kidneyCreatinine].ToString();
            txtBunResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.kidneyResult].ToString();
            txtBunSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.kidneySummary].ToString();
            txtBunValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.kidneyBun].ToString();

            txtCBCBact.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcBasophil].ToString();
            txtCBCEos.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcEosinophil].ToString();
            txtCBCHb.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcHb].ToString();
            txtCBCHct.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcHct].ToString();
            txtCBCLy.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcLymphocyte].ToString();
            txtCBCMono.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcMonocyte].ToString();
            txtCBCNeu.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcNeutrophil].ToString();
            txtCBCPltC.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcPlateletCount].ToString();
            txtCBCRbc.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcRbc].ToString();
            txtCBCRbcMono.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcRbcMorpholog].ToString();
            txtCBCSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcSummary].ToString();
            txtCBCWbc.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcWbc].ToString();
            txtCBCPltS.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcPlateletSmear].ToString();

            txtPEBMI.Text = dtccp.Rows[0][cc.ccpdb.ccp.bmi].ToString();
            txtPEHeight.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientHeight].ToString();
            txtPEPulse.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientPulse].ToString();
            txtPEResult.Text = "";
            txtPESummary.Text = "";
            txtPEVitalSign.Text = dtccp.Rows[0][cc.ccpdb.ccp.vitalsign].ToString();
            txtPEWeight.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientWeight].ToString();
            nmDPEAge.Value = int.Parse(cc.cf.NumberNull1(dtccp.Rows[0][cc.ccpdb.ccp.patientAge].ToString()));
            txtAge.Text  = dtccp.Rows[0][cc.ccpdb.ccp.patientAge].ToString();

            txtXRayResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.xrayChestExam].ToString();
            txtXRaySummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.xrayChestSummary].ToString();

            txtFBSResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.sugarSuggess].ToString();
            txtFBSSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.sugarSummary].ToString();
            txtFBSValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.sugar].ToString();

            txtUAAppe.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineAppearance].ToString();
            txtUABact.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineBacteria].ToString();
            txtUAColor.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineColor].ToString();
            txtUAEpi.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineEpithelium].ToString();
            txtUApH.Text = dtccp.Rows[0][cc.ccpdb.ccp.urinePh].ToString();
            txtUAProtein.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineProtein].ToString();
            txtUARbc.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineRbc].ToString();
            txtUAResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineResult].ToString();
            txtUASpgr.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineSpGr].ToString();
            txtUASugar.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineSugar].ToString();
            txtUASummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineSummary].ToString();
            txtUAWBC.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineWbc].ToString();
            txtUALeu.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineLeu].ToString();
            txtUAKetone.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineKetone].ToString();
            txtUABlood.Text = dtccp.Rows[0][cc.ccpdb.ccp.urineBlood].ToString();

            txtTriValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.triglyceride].ToString();
            txtTriResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.triglycerideResult].ToString();
            txtTriSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.triglycerideSummary].ToString();

            txtChoValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.cholesterol].ToString();
            txtChoResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.cholesterolSuggess].ToString();
            txtChoSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.cholesterolSummary].ToString();

            txtSgotValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverSgot].ToString();
            txtSgotSgptValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverSgpt].ToString();
            txtSgotResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverResult].ToString();
            txtSgotSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverSummary].ToString();
            txtSgotALT.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverAlp].ToString();

            //txtCBCLy.Text = dtccp.Rows[0][cc.ccpdb.ccp.].ToString();
            //txtCBCLy.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcLymphocyte].ToString();
            //txtCBCLy.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcLymphocyte].ToString();
            //txtCBCLy.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcLymphocyte].ToString();

            txtUricValue.Text = dtccp.Rows[0][cc.ccpdb.ccp.uricAcid].ToString();
            txtUricResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.uricAcidSuggess].ToString();
            txtUricSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.uricAcidSummary].ToString();
        }

        private void FrmCheckUpEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCBCExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePE_Click(object sender, EventArgs e)
        {

            String chk = cc.ccpdb.UpdatePE(txtRowNumber.Text, cuc.Id,int.Parse(nmDPEAge.Value.ToString()).ToString(), txtPEVitalSign.Text, txtPEHeight.Text, txtPEWeight.Text, 
                txtPEBMI.Text, txtPEPulse.Text, txtPEResult.Text, txtPESummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล PE เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnXraySave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateXray(txtRowNumber.Text, cuc.Id, txtXRayResult.Text, txtXRaySummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล Xray เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnCBCSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateCBC(txtRowNumber.Text, cuc.Id, txtCBCBact.Text, txtCBCEos.Text, txtCBCHb.Text, txtCBCHct.Text, 
                txtCBCLy.Text, txtCBCMch.Text, txtCBCMchc.Text, txtCBCMcv.Text, txtCBCMono.Text, txtCBCNeu.Text, txtCBCPltC.Text, txtCBCRbc.Text, 
                txtCBCRbcMono.Text, txtCBCSummary.Text, txtCBCWbc.Text, txtCBCPltS.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnFBSSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateFBS(txtRowNumber.Text, cuc.Id, txtFBSValue.Text, txtFBSResult.Text, txtFBSSummary.Text, "");
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnUASave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateUA(txtRowNumber.Text, cuc.Id, txtUAColor.Text, txtUAAppe.Text, txtUASugar.Text, 
                txtUASpgr.Text, txtUApH.Text, txtUAProtein.Text, txtUAWBC.Text, txtUARbc.Text, txtUAEpi.Text, txtUABact.Text, 
                txtUAResult.Text, txtUASpgr.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnTriSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateTrigly(txtRowNumber.Text, cuc.Id, txtTriValue.Text, txtTriResult.Text, txtTriSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnChoSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateCholes(txtRowNumber.Text, cuc.Id, txtChoValue.Text, txtChoResult.Text, txtChoSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnSgotSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateSgot(txtRowNumber.Text, cuc.Id, txtSgotValue.Text, txtSgotSgptValue.Text,"", txtSgotResult.Text, txtSgotSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnBunSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateBun(txtRowNumber.Text, cuc.Id, txtBunValue.Text, txtBunCreatinineValue.Text, txtBunResult.Text, txtBunSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnUricSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateUric(txtRowNumber.Text, cuc.Id, txtUricValue.Text, txtUricResult.Text, txtUricSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
        }
    }
}
