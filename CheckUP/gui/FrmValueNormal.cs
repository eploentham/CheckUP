using CheckUP.Control;
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
    public partial class FrmValueNormal : Form
    {
        CheckControl cc;
        int tabCBC = 0, tabFBS = 1, tabUA = 2, tabTri = 3, tabCho = 4, tabSgot = 5, tabBun = 6, tabUric = 7, tabOther1 = 8, tabLung = 9, tabAudio = 10, tabEye = 11, tabToxi = 12, tabStoolExam = 13;
        int tabCnt = 14;
        public FrmValueNormal(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {

            tC.TabPages[tabCBC].Text = "CBC";
            tC.TabPages[tabFBS].Text = "FBS";
            tC.TabPages[tabUA].Text = "UA";
            tC.TabPages[tabTri].Text = "Triglyceride";
            tC.TabPages[tabCho].Text = "Choles";
            tC.TabPages[tabSgot].Text = "SGOT/SGPT";
            tC.TabPages[tabBun].Text = "BUN Creatine";
            tC.TabPages[tabUric].Text = "Uric Acid";
            tC.TabPages[tabOther1].Text = "Other1";
            tC.TabPages[tabLung].Text = "Lung";
            tC.TabPages[tabAudio].Text = "Audio";
            tC.TabPages[tabEye].Text = "Eye";
            tC.TabPages[tabToxi].Text = "Toxicology";
            tC.TabPages[tabStoolExam].Text = "Stool Exam";
        }
        private void FrmValueNormal_Load(object sender, EventArgs e)
        {

        }

        private void btnStoolExamSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSgotSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateSgot(txtSgotValue.Text, txtSgotSgptValue.Text, txtSgotALT.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล SGOT เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnCBCSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateCBC(txtCBCBact.Text, txtCBCEos.Text, txtCBCHb.Text, txtCBCHct.Text,
                txtCBCLy.Text, txtCBCMch.Text, txtCBCMchc.Text, txtCBCMcv.Text, txtCBCMono.Text, txtCBCNeu.Text, txtCBCPltC.Text, txtCBCRbc.Text, txtCBCRbcMono.Text, txtCBCWbc.Text, txtCBCPltS.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
                }
            }            
        }

        private void btnFBSSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateFBS(txtFBSValue.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล FBS เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnUASave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateUA(txtUAColor.Text,txtUAAppe.Text,txtUASugar.Text,txtUASpgr.Text,txtUApH.Text,txtUAProtein.Text,txtUAWBC.Text,txtUARbc.Text,txtUAEpi.Text,txtUABact.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
                }
            }   
        }

        private void btnTriSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateTrigly(txtTriValue.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Trigly เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnChoSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateCholes(txtChoValue.Text, txtChoLDL.Text,txtChoHDL.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Choles เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnBunSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateBun(txtBunValue.Text,txtBunCreatinineValue.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Bun เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnUricSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateUric(txtUricValue.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Uric เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnOther1Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateOther1(txtHBsAg.Text, txtHBsAb.Text,txtAntiHIV.Text,txtVDRL.Text,txtAmphetamine.Text,txtCalcium.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Other1 เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnLungSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateLung(txtFvcPredic.Text,txtFvcMeas.Text,txtFvcPer.Text,txtFev1Predic.Text,txtFev1Meas.Text,txtFev1Per.Text,txtPerFev1.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Lung เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }
    }
}
