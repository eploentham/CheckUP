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
        public FrmValueNormal(CheckControl c, String tab)
        {
            InitializeComponent();
            cc = c;
            initConfig();
            setTabShow(tab);
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
        private void setTabShow(String tab)
        {
            if (tab.Equals(""))
            {
                return;
            }
            for (int i = 0; i < tabCnt; i++)
            {
                //tC.TabPages[i]
                if (tab.Equals("pe"))
                {
                    //TabPage t = tC.TabPages[tabPE];
                    //tC.SelectedTab = t;
                }
                else if (tab.Equals("cbc"))
                {
                    TabPage t = tC.TabPages[tabCBC];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("xray"))
                {
                    //TabPage t = tC.TabPages[tabXRay];
                    //tC.SelectedTab = t;
                }
                else if (tab.Equals("fbs"))
                {
                    TabPage t = tC.TabPages[tabFBS];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("ua"))
                {
                    TabPage t = tC.TabPages[tabUA];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("tri"))
                {
                    TabPage t = tC.TabPages[tabTri];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("cho"))
                {
                    TabPage t = tC.TabPages[tabCho];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("sgot"))
                {
                    TabPage t = tC.TabPages[tabSgot];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("bun"))
                {
                    TabPage t = tC.TabPages[tabBun];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("uric"))
                {
                    TabPage t = tC.TabPages[tabUric];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("other1"))
                {
                    TabPage t = tC.TabPages[tabOther1];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("lung"))
                {
                    TabPage t = tC.TabPages[tabLung];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("audio"))
                {
                    TabPage t = tC.TabPages[tabAudio];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("eye"))
                {
                    TabPage t = tC.TabPages[tabEye];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("toxi"))
                {
                    TabPage t = tC.TabPages[tabToxi];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("stoolexam"))
                {
                    TabPage t = tC.TabPages[tabStoolExam];
                    tC.SelectedTab = t;
                }
            }
        }
        private void setControl()
        {
            chkCBCNotsplitMaleFemale.Text = "ไม่แยก ชาย-หญิง";
            chkCBCsplitMaleFemale.Text = "แยก ชาย-หญิง";
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
            txtCBCPmn.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cbcPmn].ToString();

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
            txtUAGlu.Text = dt.Rows[0][cc.ccpvndb.ccpvn.urineGlu].ToString();

            txtTriValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString();

            txtChoHDLMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hdlMale].ToString();
            txtChoHDLFeMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hdlFemale].ToString();
            txtChoLDL.Text = dt.Rows[0][cc.ccpvndb.ccpvn.ldl].ToString();
            txtChoValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString();

            txtSgotALTMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverAlpMale].ToString();
            txtSgotSgptMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverSgptMale].ToString();
            txtSgotMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverSgotMale].ToString();
            txtSgotAlkalineMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverAlkalineMale].ToString();
            txtSgotALTFeMale.Text =  dt.Rows[0][cc.ccpvndb.ccpvn.liverAlpFeMale] == null ? "" : dt.Rows[0][cc.ccpvndb.ccpvn.liverAlpFeMale].ToString();
            txtSgotSgptFeMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverSgptFeMale] == null ? "" : dt.Rows[0][cc.ccpvndb.ccpvn.liverSgptFeMale].ToString();
            txtSgotFeMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverSgotFeMale] == null ? "" : dt.Rows[0][cc.ccpvndb.ccpvn.liverSgotFeMale].ToString();
            txtSgotAlkalineFeMale.Text = dt.Rows[0][cc.ccpvndb.ccpvn.liverAlkalineFeMale] == null ? "" : dt.Rows[0][cc.ccpvndb.ccpvn.liverAlkalineFeMale].ToString();

            txtBunMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString();
            txtBunCreatinineMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString();
            txtBunFemaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyBunFemale].ToString();
            txtBunCreatinineFemaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineFemale].ToString();

            txtUricMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.uricAcidMale].ToString();
            txtUricFeMaleValue.Text = dt.Rows[0][cc.ccpvndb.ccpvn.uricAcidFemale].ToString();

            txtHBsAb.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hbsab].ToString();
            txtHBsAg.Text = dt.Rows[0][cc.ccpvndb.ccpvn.hbsag].ToString();
            txtAntiHIV.Text = dt.Rows[0][cc.ccpvndb.ccpvn.antiHiv].ToString();
            txtVDRL.Text = dt.Rows[0][cc.ccpvndb.ccpvn.vdrl].ToString();
            txtCalcium.Text = dt.Rows[0][cc.ccpvndb.ccpvn.calcium].ToString();
            txtAntiHav.Text = dt.Rows[0][cc.ccpvndb.ccpvn.AntiHav].ToString();
            txtCAAFP.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CAAFP].ToString();
            txtCACEA.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CACEA].ToString();
            txtCAHCF.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CAHCG].ToString();
            txtCAPSA.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CAPSA].ToString();
            txtCA153.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CA153].ToString();
            txtCA125.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CA125].ToString();
            txtCA199.Text = dt.Rows[0][cc.ccpvndb.ccpvn.CA199].ToString();

            txtAmphetamine.Text = dt.Rows[0][cc.ccpvndb.ccpvn.amphetamine].ToString();

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
            txtStoolExamCulture.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamCulture].ToString();
            txtStoolExamTyhoidH.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamTyphoidH].ToString();
            txtStoolExamTyhoidO.Text = dt.Rows[0][cc.ccpvndb.ccpvn.StoolExamTyphoidO].ToString();
            if ((dt.Rows[0][cc.ccpvndb.ccpvn.StatusCBCNotsplitMaleFemale] == null) || (dt.Rows[0][cc.ccpvndb.ccpvn.StatusCBCNotsplitMaleFemale].ToString().Equals(""))
                || (dt.Rows[0][cc.ccpvndb.ccpvn.StatusCBCNotsplitMaleFemale].ToString().Equals("1")))//ไม่แยก ชายหญิง=1 แยกชายหญิง=2
            {
                setCBCsplitMale();
                chkCBCsplitMaleFemale.Checked = false;
                chkCBCNotsplitMaleFemale.Checked = true;
            }
            else
            {
                setCBCsplitMaleFemale();
                chkCBCsplitMaleFemale.Checked = true;
                chkCBCNotsplitMaleFemale.Checked = false;
            }
            if ((dt.Rows[0][cc.ccpvndb.ccpvn.StatusSgotNotsplitMaleFemale] == null) || (dt.Rows[0][cc.ccpvndb.ccpvn.StatusSgotNotsplitMaleFemale].ToString().Equals(""))
                || (dt.Rows[0][cc.ccpvndb.ccpvn.StatusSgotNotsplitMaleFemale].ToString().Equals("1")))//ไม่แยก ชายหญิง=1 แยกชายหญิง=2
            {
                setSgotsplitMale();
                chkSgotsplitMaleFemale.Checked = false;
                chkSgotNotsplitMaleFemale.Checked = true;
            }
            else
            {
                setSgotsplitFemale();
                chkSgotsplitMaleFemale.Checked = true;
                chkSgotNotsplitMaleFemale.Checked = false;
            }
            if ((dt.Rows[0][cc.ccpvndb.ccpvn.StatusBunNotsplitMaleFemale] == null) || (dt.Rows[0][cc.ccpvndb.ccpvn.StatusBunNotsplitMaleFemale].ToString().Equals(""))
                || (dt.Rows[0][cc.ccpvndb.ccpvn.StatusBunNotsplitMaleFemale].ToString().Equals("1")))//ไม่แยก ชายหญิง=1 แยกชายหญิง=2
            {
                setBunsplitMale();
                chkBunsplitMaleFemale.Checked = false;
                chkBunNotsplitMaleFemale.Checked = true;
            }
            else
            {
                setBunsplitFemale();
                chkBunsplitMaleFemale.Checked = true;
                chkBunNotsplitMaleFemale.Checked = false;
            }
        }
        private void FrmValueNormal_Load(object sender, EventArgs e)
        {

        }

        private void btnStoolExamSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                String chk = cc.ccpvndb.updateStoolExam(txtStoolExamAppearance.Text.Trim(), txtStoolExamColor.Text.Trim(), txtStoolExamWbc.Text.Trim(), txtStoolExamRbc.Text.Trim(), txtStoolExamParasite.Text.Trim(),
                    txtStoolExamCulture.Text.Trim(), txtStoolExamTyhoidH.Text.Trim(), txtStoolExamTyhoidO.Text.Trim());
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล StoolExam เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }
        private void setCBCsplitMale()
        {
            label42.Text = "RBC  :";
            label28.Hide();
            txtCBCRbcFemale.Hide();

            label41.Text = "Hb  :";
            label25.Hide();
            txtCBCHbFemale.Hide();

            label11.Text = "Mcv Male :";
            label27.Hide();
            txtCBCMcvFemale.Hide();

            label40.Text = "Hct :";
            label26.Hide();
            txtCBCHctFemale.Hide();
        }
        private void setCBCsplitFemale()
        {
            label42.Text = "RBC  Male :";
            label28.Show();
            txtCBCRbcFemale.Show();

            label41.Text = "Hb Male :";
            label25.Show();
            txtCBCHbFemale.Show();


            label11.Text = "Mcv Male :";
            label27.Show();
            txtCBCMcvFemale.Show();

            label40.Text = "Hct  Male :";
            label26.Show();
            txtCBCHctFemale.Show();
        }
        private void setSgotsplitMale()
        {
            label77.Text = "SGOT :";
            label103.Hide();
            txtSgotFeMaleValue.Hide();
            label101.Hide();

            label76.Text = "SGPT :";
            label117.Hide();
            txtSgotSgptFeMaleValue.Hide();
            label104.Hide();

            label7.Text = "ALT :";
            label118.Hide();
            txtSgotALTFeMale.Hide();

            label45.Text = "Alkaline ";
            label124.Hide();
            txtSgotAlkalineFeMale.Hide();
            label123.Hide();
        }
        private void setSgotsplitFemale()
        {
            label77.Text = "SGOT Male :";
            label103.Show();
            txtSgotFeMaleValue.Show();
            label101.Show();

            label76.Text = "SGPT Male :";
            label117.Show();
            txtSgotSgptFeMaleValue.Show();
            label104.Show();

            label7.Text = "ALT Male :";
            label118.Show();
            txtSgotALTFeMale.Show();

            label45.Text = "Alkaline Male:";
            label124.Show();
            txtSgotAlkalineFeMale.Show();
            label123.Show();
        }
        private void setBunsplitMale()
        {
            label78.Text = "BUN :";
            label24.Hide();
            txtBunFemaleValue.Hide();
            label18.Hide();

        }
        private void setBunsplitFemale()
        {
            label78.Text = "BUN Male :";
            label24.Show();
            txtBunFemaleValue.Show();
            label18.Show();

        }
        private void setCBCsplitMaleFemale()
        {
            
        }
        private void chkCBCNotsplitMaleFemale_Click(object sender, EventArgs e)
        {
            setCBCsplitMale();
        }

        private void chkCBCsplitMaleFemale_Click(object sender, EventArgs e)
        {
            setCBCsplitFemale();
        }

        private void chkSgotNotsplitMaleFemale_Click(object sender, EventArgs e)
        {
            setSgotsplitMale();
        }

        private void chkSgotsplitMaleFemale_Click(object sender, EventArgs e)
        {
            setSgotsplitFemale();
        }

        private void chkBunNotsplitMaleFemale_Click(object sender, EventArgs e)
        {
            setBunsplitMale();
        }

        private void chkBunsplitMaleFemale_Click(object sender, EventArgs e)
        {
            setBunsplitFemale();
        }

        private void chkCBCNotsplitMaleFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSgotSave_Click(object sender, EventArgs e)
        {
            try
            {
                String[] sgot = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgotMale].ToString().Split('@');
                int sgotMin = 0, sgotMax = 0;
                String sgotUnit = "";
                if (sgot.Length == 2)
                {
                    String[] aa = sgot[0].ToString().Split('-');
                    sgotMin = int.Parse(aa[0]);
                    sgotMax = int.Parse(aa[1]);
                    sgotUnit = sgot[1];
                }
                String[] sgpt = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgotMale].ToString().Split('@');
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
                    String chk = cc.ccpvndb.UpdateSgot(txtSgotMaleValue.Text.Trim(), txtSgotSgptMaleValue.Text.Trim(), txtSgotALTMale.Text.Trim(), txtSgotAlkalineMale.Text.Trim(),
                        txtSgotFeMaleValue.Text.Trim(), txtSgotSgptFeMaleValue.Text.Trim(), txtSgotALTFeMale.Text.Trim(), txtSgotAlkalineFeMale.Text.Trim(), chkSgotNotsplitMaleFemale.Checked ? "1" : "2");
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
                String chk = cc.ccpvndb.UpdateCBC(txtCBCBact.Text.Trim(), txtCBCEos.Text.Trim(), txtCBCHbMale.Text.Trim(), txtCBCHbFemale.Text.Trim(), txtCBCHctMale.Text.Trim(), txtCBCHctFemale.Text.Trim(),
                txtCBCLy.Text, txtCBCMch.Text.Trim(), txtCBCMchc.Text.Trim(), txtCBCMcvMale.Text.Trim(), txtCBCMcvFemale.Text.Trim(), txtCBCMono.Text.Trim(), txtCBCNeu.Text.Trim(), txtCBCPltC.Text.Trim(),
                txtCBCRbcMale.Text.Trim(), txtCBCRbcFemale.Text.Trim(), txtCBCRbcMono.Text.Trim(), txtCBCWbc.Text.Trim(), txtCBCPltS.Text.Trim(), txtCBCPmn.Text.Trim(), chkCBCNotsplitMaleFemale.Checked ? "1":"2");
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
                    String chk = cc.ccpvndb.UpdateFBS(txtFBSValue.Text.Trim());
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
                String chk = cc.ccpvndb.UpdateUA(txtUAColor.Text.Trim(), txtUAAppe.Text.Trim(), txtUASugar.Text.Trim(), txtUASpgr.Text.Trim(), txtUApH.Text.Trim(), txtUAProtein.Text.Trim(),
                    txtUAWBC.Text.Trim(), txtUARbc.Text.Trim(), txtUAEpi.Text.Trim(), txtUABact.Text.Trim(), txtUAKetone.Text.Trim(), txtUALeu.Text.Trim(), txtUABlood.Text.Trim(), txtUAGlu.Text.Trim());
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
                    String chk = cc.ccpvndb.UpdateTrigly(txtTriValue.Text.Trim());
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
                    //String[] aa = choles[0].ToString().Split('<');
                    //cholesMax = int.Parse(aa[0]);
                    //fbsMax = int.Parse(aa[1]);
                    cholesUnit = choles[1];
                }
                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateCholes(txtChoValue.Text.Trim(), txtChoLDL.Text.Trim(), txtChoHDLMale.Text.Trim(), txtChoHDLFeMale.Text.Trim());
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
                Double bunMaleMin = 0,bunMaleMax = 0;
                String bunMaleUnit = "";
                if (bunMale.Length == 2)
                {
                    String[] aa = bunMale[0].ToString().Split('-');
                    bunMaleMin = Double.Parse(aa[0]);
                    bunMaleMax = Double.Parse(aa[1]);
                    bunMaleUnit = bunMale[1];
                }
                String[] bunFemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunFemale].ToString().Split('@');
                Double bunFemaleMin = 0, bunFemaleMax = 0;
                String bunFemaleUnit = "";
                if (bunFemale.Length == 2)
                {
                    String[] aa = bunFemale[0].ToString().Split('-');
                    bunFemaleMin = Double.Parse(aa[0]);
                    bunFemaleMax = Double.Parse(aa[1]);
                    bunFemaleUnit = bunFemale[1];
                }
                String[] CreatinineMale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString().Split('@');
                Double CreatinineMaleMin = 0, CreatinineMaleMax = 0;
                String CreatinineMaleUnit = "";
                if (CreatinineMale.Length == 2)
                {
                    String[] aa = CreatinineMale[0].ToString().Split('-');
                    CreatinineMaleMin = Double.Parse(aa[0]);
                    CreatinineMaleMax = Double.Parse(aa[1]);
                    CreatinineMaleUnit = CreatinineMale[1];
                }
                String[] CreatinineFemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineFemale].ToString().Split('@');
                Double CreatinineFemaleMin = 0, CreatinineFemaleMax = 0;
                String CreatinineFemaleUnit = "";
                if (CreatinineFemale.Length == 2)
                {
                    String[] aa = CreatinineFemale[0].ToString().Split('-');
                    CreatinineFemaleMin = Double.Parse(aa[0]);
                    CreatinineFemaleMax = Double.Parse(aa[1]);
                    CreatinineFemaleUnit = CreatinineFemale[1];
                }

                if (MessageBox.Show("ต้องการแก้ไข", "บันทึก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    String chk = cc.ccpvndb.UpdateBun(txtBunMaleValue.Text, txtBunCreatinineMaleValue.Text.Trim(), txtBunFemaleValue.Text.Trim()
                        , txtBunCreatinineFemaleValue.Text.Trim(), chkBunNotsplitMaleFemale.Checked ? "1" : "2");//1= ไม่แยก 2= แยก
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
                String chk = cc.ccpvndb.UpdateUric(txtUricMaleValue.Text.Trim(), txtUricFeMaleValue.Text.Trim());
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
                String chk = cc.ccpvndb.UpdateOther1(txtHBsAg.Text.Trim(), txtHBsAb.Text.Trim(), txtAntiHIV.Text.Trim(), txtVDRL.Text.Trim(), txtAmphetamine.Text.Trim(), txtCalcium.Text.Trim(),
                    txtAntiHav.Text.Trim(), txtCAAFP.Text.Trim(), txtCACEA.Text.Trim(), txtCAPSA.Text.Trim(), txtCAHCF.Text.Trim(), txtCA153.Text.Trim(), txtCA125.Text.Trim(), txtCA199.Text.Trim());
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
                String chk = cc.ccpvndb.UpdateLung(txtFvcPredic.Text.Trim(), txtFvcMeas.Text.Trim(), txtFvcPer.Text.Trim(), txtFev1Predic.Text.Trim(), txtFev1Meas.Text.Trim(), txtFev1Per.Text.Trim(), txtPerFev1.Text.Trim());
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
                String chk = cc.ccpvndb.updateToxi1(txtToxiLead.Text.Trim(), txtToxiAluminium.Text.Trim(), txtToxiCadmium.Text.Trim(), txtToxiMercury.Text.Trim(), txtToxiTin.Text.Trim(),
                    txtToxiCopper.Text.Trim(), txtToxiManganese.Text.Trim(), txtToxiZinc.Text.Trim(), txtToxiAmmonia.Text.Trim());
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    chk = cc.ccpvndb.updateToxi2(txtToxiHippuric.Text.Trim(), txtToxiMethyl.Text.Trim(), txtToxiAcetone.Text.Trim(), txtToxiNickel.Text.Trim(), txtToxiChromium.Text.Trim(),
                        txtToxiPhenol.Text.Trim(), txtToxiKetone.Text.Trim(), txtToxiBenzene.Text.Trim(), txtToxiMandelic.Text.Trim(), txtToxiMethanol.Text.Trim(), txtToxiEthanol.Text.Trim(),
                        txtToxiIPA.Text.Trim(), txtToxiArsenic.Text.Trim(), txtToxiHexane.Text.Trim(), txtToxiFomaldehyde.Text.Trim(), txtToxiTrichloroethylene.Text.Trim(), txtToxiAntimony.Text.Trim(),
                        txtToxiFluoride.Text.Trim());
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
                String chk = cc.ccpvndb.updateEye(txtEyeShortLongLeft.Text.Trim(), txtEyeShortLongRight.Text.Trim(), txtEyeSquintLeft.Text.Trim(), txtEyeSquintRight.Text.Trim(), txtEyeDegreeLeft.Text.Trim(),
                    txtEyeDegreeRight.Text.Trim(), txtEyeOldLeft.Text.Trim(), txtEyeOldRight.Text.Trim(), txtEyeBlindness.Text.Trim(), txtEyeExam.Text.Trim());
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
                String chk = cc.ccpvndb.UpdateAudioGram(txtAudiogram500L.Text.Trim(), txtAudiogram500R.Text.Trim(), txtAudiogram1000L.Text.Trim(), txtAudiogram1000R.Text.Trim(), txtAudiogram2000L.Text.Trim(),
                    txtAudiogram2000R.Text.Trim(), txtAudiogram3000L.Text.Trim(), txtAudiogram3000R.Text.Trim(), txtAudiogram4000L.Text.Trim(), txtAudiogram4000R.Text.Trim(), txtAudiogram6000L.Text.Trim(),
                    txtAudiogram6000R.Text.Trim(), txtAudiogram8000L.Text.Trim(), txtAudiogram8000R.Text.Trim());
                cc.dtccpvn = cc.ccpvndb.selectByPk();
                if (chk.Equals("1"))
                {
                    MessageBox.Show("บันทึกข้อมูล AudioGram เรียบร้อย", "บันทึกข้อมูล");
                }
            }
        }
    }
}
