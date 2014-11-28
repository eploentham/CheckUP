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
            txtCBCHbMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcHbMale].ToString();
            txtCBCHbFemale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcHbFemale].ToString();
            txtCBCHctMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcHctMale].ToString();
            txtCBCHctFemale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcHctFemale].ToString();
            txtCBCLy.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcLymphocyte].ToString();
            txtCBCMch.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMch].ToString();
            txtCBCMchc.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMchc].ToString();
            txtCBCMcvMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMcvMale].ToString();
            txtCBCMcvFemale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMcvFemale].ToString();
            txtCBCMono.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcMonocyte].ToString();
            txtCBCNeu.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcNeutrophil].ToString();
            txtCBCPltC.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletCount].ToString();
            txtCBCPltS.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletSmear].ToString();
            txtCBCRbcMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMale].ToString();
            txtCBCRbcFemale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcRbcFemale].ToString();
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

            txtBunMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString();
            txtBunCreatinineMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString();
            txtBunFemaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyBunFemale].ToString();
            txtBunCreatinineFemaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineFemale].ToString();

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
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล StoolExam เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnSgotSave_Click(object sender, EventArgs e)
        {
            try
            {
                String[] sgot = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString().Split('@');
                int sgotMin = 0, sgotMax = 0;
                String sgotUnit = "";
                if (sgot.Length == 2)
                {
                    String[] aa = sgot[0].ToString().Split('-');
                    sgotMin = int.Parse(aa[0]);
                    sgotMax = int.Parse(aa[1]);
                    sgotUnit = sgot[1];
                }
                String[] sgpt = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString().Split('@');
                int sgptMin = 0, sgptMax = 0;
                String sgptUnit = "";
                if (sgot.Length == 2)
                {
                    String[] aa = sgpt[0].ToString().Split('-');
                    sgptMin = int.Parse(aa[0]);
                    sgptMax = int.Parse(aa[1]);
                    sgptUnit = sgot[1];
                }
                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateSgot(txtSgotValue.Text, txtSgotSgptValue.Text, txtSgotALT.Text);
                    cc.dtccpvn = cc.ccpvndb.selectByPk();
                    if (chk.Equals("1"))
                    {
                        MessageBox.Show("บันทึกข้อมูล SGOT เรียบร้อย", "บันทึกข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูล FBS ไม่ถูกต้อง - @ ", "Error");
                return;
            }
            
        }

        private void btnCBCSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateCBC(txtCBCBact.Text, txtCBCEos.Text, txtCBCHbMale.Text, txtCBCHbFemale.Text, txtCBCHctMale.Text, txtCBCHctFemale.Text,
                txtCBCLy.Text, txtCBCMch.Text, txtCBCMchc.Text, txtCBCMcvMale.Text, txtCBCMcvFemale.Text, txtCBCMono.Text, txtCBCNeu.Text, txtCBCPltC.Text, 
                txtCBCRbcMale.Text, txtCBCRbcFemale.Text, txtCBCRbcMono.Text, txtCBCWbc.Text, txtCBCPltS.Text);
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
                }
            }            
        }

        private void btnFBSSave_Click(object sender, EventArgs e)
        {
            try
            {
                String[] fbs = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString().Split('@');
                int fbsMin = 0, fbsMax = 0;
                String fbsUnit = "";
                if (fbs.Length == 2)
                {
                    String[] aa = fbs[0].ToString().Split('-');
                    fbsMin = int.Parse(aa[0]);
                    fbsMax = int.Parse(aa[1]);
                    fbsUnit = fbs[1];
                }
                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateFBS(txtFBSValue.Text);
                    cc.dtccpvn = cc.ccpvndb.selectByPk();
                    if (chk.Equals("1"))
                    {
                        MessageBox.Show("บันทึกข้อมูล FBS เรียบร้อย", "บันทึกข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูล FBS ไม่ถูกต้อง - @ ", "Error");
                return;
            }
        }

        private void btnUASave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateUA(txtUAColor.Text,txtUAAppe.Text,txtUASugar.Text,txtUASpgr.Text,txtUApH.Text,txtUAProtein.Text,txtUAWBC.Text,txtUARbc.Text,txtUAEpi.Text,txtUABact.Text, txtUAKetone.Text, txtUALeu.Text,txtUABlood.Text);
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
                }
            }   
        }

        private void btnTriSave_Click(object sender, EventArgs e)
        {
            try
            {
                String[] tri = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString().Split('@');
                int triMax = 0;
                String triUnit = "";
                if (tri.Length == 2)
                {
                    String[] aa = tri[0].ToString().Split('<');
                    triMax = int.Parse(aa[0]);
                    //fbsMax = int.Parse(aa[1]);
                    triUnit = tri[1];
                }
                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateTrigly(txtTriValue.Text);
                    cc.dtccpvn = cc.ccpvndb.selectByPk();
                    if (chk.Equals("1"))
                    {
                        MessageBox.Show("บันทึกข้อมูล Trigly เรียบร้อย", "บันทึกข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูล Trigly ไม่ถูกต้อง < @ ", "Error");
                return;
            }                        
        }

        private void btnChoSave_Click(object sender, EventArgs e)
        {
            try
            {
                String[] choles = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString().Split('@');
                int cholesMax = 0;
                String cholesUnit = "";
                if (choles.Length == 2)
                {
                    String[] aa = choles[0].ToString().Split('<');
                    cholesMax = int.Parse(aa[0]);
                    //fbsMax = int.Parse(aa[1]);
                    cholesUnit = choles[1];
                }
                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateCholes(txtChoValue.Text, txtChoLDL.Text, txtChoHDL.Text);
                    cc.dtccpvn = cc.ccpvndb.selectByPk();
                    if (chk.Equals("1"))
                    {
                        MessageBox.Show("บันทึกข้อมูล Choles เรียบร้อย", "บันทึกข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูล Choles ไม่ถูกต้อง < @ ", "Error");
                return;
            }
            
        }

        private void btnBunSave_Click(object sender, EventArgs e)
        {
            try
            {
                String[] bunMale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString().Split('@');
                int bunMaleMin = 0,bunMaleMax = 0;
                String bunMaleUnit = "";
                if (bunMale.Length == 2)
                {
                    String[] aa = bunMale[0].ToString().Split('<');
                    bunMaleMin = int.Parse(aa[0]);
                    bunMaleMax = int.Parse(aa[1]);
                    bunMaleUnit = bunMale[1];
                }
                String[] bunFemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunFemale].ToString().Split('@');
                int bunFemaleMin = 0, bunFemaleMax = 0;
                String bunFemaleUnit = "";
                if (bunFemale.Length == 2)
                {
                    String[] aa = bunFemale[0].ToString().Split('<');
                    bunFemaleMin = int.Parse(aa[0]);
                    bunFemaleMax = int.Parse(aa[1]);
                    bunFemaleUnit = bunFemale[1];
                }
                String[] CreatinineMale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString().Split('@');
                int CreatinineMaleMin = 0, CreatinineMaleMax = 0;
                String CreatinineMaleUnit = "";
                if (CreatinineMale.Length == 2)
                {
                    String[] aa = CreatinineMale[0].ToString().Split('<');
                    CreatinineMaleMin = int.Parse(aa[0]);
                    CreatinineMaleMax = int.Parse(aa[1]);
                    CreatinineMaleUnit = CreatinineMale[1];
                }
                String[] CreatinineFemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineFemale].ToString().Split('@');
                int CreatinineFemaleMin = 0, CreatinineFemaleMax = 0;
                String CreatinineFemaleUnit = "";
                if (CreatinineFemale.Length == 2)
                {
                    String[] aa = CreatinineFemale[0].ToString().Split('<');
                    CreatinineFemaleMin = int.Parse(aa[0]);
                    CreatinineFemaleMax = int.Parse(aa[1]);
                    CreatinineFemaleUnit = CreatinineFemale[1];
                }

                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateBun(txtBunMaleValue.Text, txtBunCreatinineMaleValue.Text, txtBunFemaleValue.Text, txtBunCreatinineFemaleValue.Text);
                    cc.dtccpvn = cc.ccpvndb.selectByPk();
                    if (chk.Equals("1"))
                    {
                        MessageBox.Show("บันทึกข้อมูล Bun เรียบร้อย", "บันทึกข้อมูล");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูล Bun ไม่ถูกต้อง < @ ", "Error");
                return;
            }
        }

        private void btnUricSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateUric(txtUricValue.Text);
                cc.dtccpvn = cc.ccpvndb.selectByPk();
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
                cc.dtccpvn = cc.ccpvndb.selectByPk();
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
                cc.dtccpvn = cc.ccpvndb.selectByPk();
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
                cc.dtccpvn = cc.ccpvndb.selectByPk();
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

        private void btnEyeSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.updateEye(txtEyeShortLongLeft.Text, txtEyeShortLongRight.Text,txtEyeSquintLeft.Text, txtEyeSquintRight.Text,txtEyeDegreeLeft.Text, 
                    txtEyeDegreeRight.Text,txtEyeOldLeft.Text, txtEyeOldRight.Text, txtEyeBlindness.Text, txtEyeExam.Text);
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล Eye เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }

        private void btnAudiogramSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.UpdateAudioGram(txtAudiogram500L.Text, txtAudiogram500R.Text, txtAudiogram1000L.Text, txtAudiogram1000R.Text, txtAudiogram2000L.Text,
                    txtAudiogram2000R.Text, txtAudiogram3000L.Text, txtAudiogram3000R.Text, txtAudiogram4000L.Text, txtAudiogram4000R.Text, txtAudiogram6000L.Text,
                    txtAudiogram6000R.Text, txtAudiogram8000L.Text, txtAudiogram8000R.Text);
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล AudioGram เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }
    }
}
