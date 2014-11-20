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
    public partial class FrmValueNormal : Form
    {
        CheckControl cc;
        int tabCBC = 0, tabFBS = 1, tabUA = 2, tabTri = 3, tabCho = 4, tabSgot = 5, tabBun = 6, tabUric = 7, tabOther1 = 8, tabLung = 9, tabAudio = 10, tabEye = 11, tabToxi = 12, tabStoolExam = 13;
        int tabCnt = 14;
        CustCheckUpPatientValueNormal ccpvn;
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
            setControl();
        }
        private void setControl()
        {
            DataTable dt = cc.ccpvndb.selectByPk();
            txtCBCBact.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcBasophil].ToString();
            txtCBCEos.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcEosinophil].ToString();
            txtCBCHb.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcHb].ToString();
            txtCBCHct.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcHct].ToString();
            txtCBCLy.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcLymphocyte].ToString();
            txtCBCMch.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMch].ToString();
            txtCBCMchc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMchc].ToString();
            txtCBCMcv.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMcv].ToString();
            txtCBCMono.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMonocyte].ToString();
            txtCBCNeu.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcNeutrophil].ToString();
            txtCBCPltC.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletCount].ToString();
            txtCBCPltS.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletSmear].ToString();
            txtCBCRbc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcRbc].ToString();
            txtCBCRbcMono.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMorpholog].ToString();
            txtCBCWbc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcWbc].ToString();

            txtFBSValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString();

            txtUAAppe.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineAppearance].ToString();
            txtUABact.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineBacteria].ToString();
            txtUABlood.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineBlood].ToString();
            txtUAColor.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineColor].ToString();
            txtUAEpi.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineEpithelium].ToString();
            txtUAKetone.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineKetone].ToString();
            txtUALeu.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineLeu].ToString();
            txtUApH.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urinePh].ToString();
            txtUAProtein.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineProtein].ToString();
            txtUARbc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineRbc].ToString();
            txtUASpgr.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineSpGr].ToString();
            txtUASugar.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineSugar].ToString();
            txtUAWBC.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineWbc].ToString();

            txtTriValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString();

            txtChoHDL.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hdl].ToString();
            txtChoLDL.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ldl].ToString();
            txtChoValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString();

            txtSgotALT.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverAlp].ToString();
            txtSgotSgptValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverSgpt].ToString();
            txtSgotValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString();

            txtBunValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyBun].ToString();
            txtBunCreatinineValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinine].ToString();

            txtUricValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.uricAcid].ToString();

            txtHBsAb.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hbsab].ToString();
            txtHBsAg.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hbsag].ToString();
            txtAntiHIV.Text = dt.Rows[0][cc.ccpvndb.ccpvn.antiHiv].ToString();
            txtVDRL.Text = dt.Rows[0][cc.ccpvndb.ccpvn.vdrl].ToString();
            txtCalcium.Text = dt.Rows[0][cc.ccpvndb.ccpvn.calcium].ToString();

            //txtUAAppe.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ua].ToString();

            txtFvcPredic.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungFvcPredic].ToString();
            txtFvcMeas.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungFvcMeas].ToString();
            txtFvcPer.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungFvcPer].ToString();
            txtFev1Predic.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungFev1Predic].ToString();
            txtFev1Meas.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungFev1Meas].ToString();
            txtFev1Per.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungFev1Per].ToString();
            txtPerFev1.Text = dt.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();

            txtToxiAcetone.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiAcetone].ToString();
            txtToxiAluminium.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiAluminium].ToString();
            txtToxiAmmonia.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiAmmonia].ToString();
            txtToxiAntimony.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiAntimony].ToString();
            txtToxiArsenic.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiArsenic].ToString();
            txtToxiBenzene.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiBenzene].ToString();
            txtToxiCadmium.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiCadmium].ToString();
            txtToxiChromium.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiChromium].ToString();
            txtToxiCopper.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiCopper].ToString();
            txtToxiEthanol.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiEthanol].ToString();
            txtToxiFluoride.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiFluoride].ToString();
            txtToxiFomaldehyde.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiFomaldehyde].ToString();
            txtToxiHexane.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiHexane].ToString();
            txtToxiHippuric.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiHippuric].ToString();
            txtToxiIPA.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiIPA].ToString();
            txtToxiKetone.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiKetone].ToString();
            txtToxiLead.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiLead].ToString();
            txtToxiMandelic.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiMandelic].ToString();
            txtToxiManganese.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiManganese].ToString();
            txtToxiMercury.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiMercury].ToString();
            txtToxiMethanol.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiMethanol].ToString();
            txtToxiMethyl.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiMethyl].ToString();
            txtToxiNickel.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiNickel].ToString();
            txtToxiPhenol.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiPhenol].ToString();
            txtToxiTin.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiTin].ToString();
            txtToxiTrichloroethylene.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiTrichloroethylene].ToString();
            txtToxiZinc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ToxiZinc].ToString();

            txtStoolExamAppearance.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamAppearance].ToString();
            txtStoolExamColor.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamColor].ToString();
            txtStoolExamParasite.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamParasite].ToString();
            txtStoolExamRbc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamRbc].ToString();
            txtStoolExamWbc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamWbc].ToString();
            
        }
        private void FrmValueNormal_Load(object sender, EventArgs e)
        {

        }

        private void btnStoolExamSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.updateStoolExam(txtStoolExamAppearance.Text,txtStoolExamColor.Text,txtStoolExamWbc.Text,txtStoolExamRbc.Text,txtStoolExamParasite.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล StoolExam เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnSgotSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateUA(txtUAColor.Text,txtUAAppe.Text,txtUASugar.Text,txtUASpgr.Text,txtUApH.Text,txtUAProtein.Text,txtUAWBC.Text,txtUARbc.Text,txtUAEpi.Text,txtUABact.Text, txtUAKetone.Text, txtUALeu.Text,txtUABlood.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
                }
            }   
        }

        private void btnTriSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
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
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateLung(txtFvcPredic.Text,txtFvcMeas.Text,txtFvcPer.Text,txtFev1Predic.Text,txtFev1Meas.Text,txtFev1Per.Text,txtPerFev1.Text);
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Lung เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnToxiSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.updateToxi1(txtToxiLead.Text,txtToxiAluminium.Text,txtToxiCadmium.Text,txtToxiMercury.Text,txtToxiTin.Text,txtToxiCopper.Text,txtToxiManganese.Text,txtToxiZinc.Text,txtToxiAmmonia.Text);
                if (chk.Equals("1"))
                {
                    chk = cc.ccpvndb.updateToxi2(txtToxiHippuric.Text,txtToxiMethyl.Text,txtToxiAcetone.Text,txtToxiNickel.Text,txtToxiChromium.Text,txtToxiPhenol.Text,txtToxiKetone.Text,
                        txtToxiBenzene.Text,txtToxiMandelic.Text,txtToxiMethanol.Text,txtToxiEthanol.Text,txtToxiIPA.Text,txtToxiArsenic.Text,txtToxiHexane.Text,
                        txtToxiFomaldehyde.Text,txtToxiTrichloroethylene.Text,txtToxiAntimony.Text,txtToxiFluoride.Text);
                    if (chk.Equals("1"))
                    {

                        MessageBox.Show("บันทึกข้อมูล Toxi เรียบร้อย", "บันทึกข้อมูล");
                    }
                    //MessageBox.Show("บันทึกข้อมูล Lung เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }
    }
}
