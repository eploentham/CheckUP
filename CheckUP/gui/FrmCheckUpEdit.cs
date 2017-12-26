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
    public partial class FrmCheckUpEdit : Form
    {
        CheckControl cc;
        CustCheckUp cuc;
        CustCheckUpPatient ccp;
        DataTable dtccp;
        int tabSum = 0, tabPE = 1, tabXRay = 2, tabCBC = 3, tabFBS = 4, tabUA = 5, tabTri = 6, tabCho = 7, tabSgot = 8, tabBun = 9, tabUric = 10, tabOther1 = 11, tabLung = 12, tabAudio = 13, tabEye = 14, tabToxi = 15, tabStoolExam = 16;
        int tabCnt = 17;

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
            cc.dtccpvn = cc.ccpvndb.selectByPk();

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
            tC.TabPages[tabOther1].Text = "Other1";
            tC.TabPages[tabLung].Text = "Lung";
            tC.TabPages[tabAudio].Text = "Audio";
            tC.TabPages[tabEye].Text = "Eye";
            tC.TabPages[tabToxi].Text = "Toxicology";
            tC.TabPages[tabStoolExam].Text = "Stool Exam";
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
            txtCBCPmn.Text = dtccp.Rows[0][cc.ccpdb.ccp.cbcPmn].ToString();

            txtPEBMI.Text = dtccp.Rows[0][cc.ccpdb.ccp.bmi].ToString();
            txtPEHeight.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientHeight].ToString();
            txtPEPulse.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientPulse].ToString();
            txtPEResult.Text = "";
            txtPESummary.Text = "";
            txtPEVitalSign.Text = dtccp.Rows[0][cc.ccpdb.ccp.vitalsign].ToString();
            txtPEWeight.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientWeight].ToString();
            txtPEAge.Text = dtccp.Rows[0][cc.ccpdb.ccp.patientAge].ToString();
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
            txtChoLDL.Text = dtccp.Rows[0][cc.ccpdb.ccp.ldl].ToString();
            txtChoHDL.Text = dtccp.Rows[0][cc.ccpdb.ccp.hdl].ToString();
            txtChoResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.cholesterolSuggess].ToString();
            txtChoSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.cholesterolSummary].ToString();
            txtLDLResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.ChoLDLResult].ToString();
            txtLDLSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.ChoLDLsummary].ToString();
            txtHDLResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.ChoHDLResult].ToString();
            txtHDLSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.ChoHDLsummary].ToString();

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



            txtCBCBactNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcBasophil].ToString();
            txtCBCEosNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcEosinophil].ToString();
            txtCBCHbNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHbMale].ToString();
            txtCBCHctNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHctMale].ToString();
            txtCBCLyNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcLymphocyte].ToString();
            txtCBCMonoNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMonocyte].ToString();
            txtCBCNeuNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcNeutrophil].ToString();
            txtCBCPltCNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletCount].ToString();
            txtCBCRbcNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMale].ToString();
            txtCBCRbcMonoNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMorpholog].ToString();
            txtCBCMchNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMch].ToString();
            txtCBCMchcNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMchc].ToString();
            txtCBCMcvNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcvMale].ToString();
            txtCBCWbcNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcWbc].ToString();
            txtCBCPltSNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletSmear].ToString();
            txtCBCPmnNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPmn].ToString();

            txtBunCreatinineNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString();
            //txtBunResultNormal.Text = dtccp.Rows[0][cc.ccpdb.ccp.kidneyResult].ToString();
            //txtBunSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.kidneySummary].ToString();
            txtBunNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString();

            txtFBSNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString();

            txtUAAppeNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineAppearance].ToString();
            txtUABactNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineBacteria].ToString();
            txtUAColorNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineColor].ToString();
            txtUAEpiNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineEpithelium].ToString();
            txtUApHNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urinePh].ToString();
            txtUAProteinNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineProtein].ToString();
            txtUARbcNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineRbc].ToString();
            txtUAKetoneNormal.Text = dtccp.Rows[0][cc.ccpvndb.ccpvn.urineKetone].ToString();
            txtUASpgrNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSpGr].ToString();
            txtUASugarNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSugar].ToString();
            txtUALeuNormal.Text = dtccp.Rows[0][cc.ccpvndb.ccpvn.urineLeu].ToString();
            txtUAWBCNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineWbc].ToString();
            txtUALeuNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineLeu].ToString();
            txtUAKetoneNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineKetone].ToString();
            txtUABloodNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineBlood].ToString();
            //txtUABactNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineBlood].ToString();

            txtTriNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString();

            txtChoNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString();
            txtChoLDLNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ldl].ToString();
            txtChoHDLNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.hdlMale].ToString();

            txtSgotNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgotMale].ToString();
            txtSgotSgptNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgptMale].ToString();
            //txtSgotResult.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverResult].ToString();
            //txtSgotSummary.Text = dtccp.Rows[0][cc.ccpdb.ccp.liverSummary].ToString();
            txtSgotALTNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverAlpMale].ToString();

            txtUricNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.uricAcidMale].ToString();

            txtHBsAgNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.hbsag].ToString();
            txtHBsAbNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.hbsab].ToString();
            txtAntiHIVNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.antiHiv].ToString();
            txtVDRLNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.vdrl].ToString();
            txtAmphetamineNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.amphetamine].ToString();
            txtCalciumNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.calcium].ToString();

            txtFvcPredicNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungFvcPredic].ToString();
            txtFvcMeasNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungFvcMeas].ToString();
            txtFvcPerNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungFvcPer].ToString();
            txtFev1PredicNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungFev1Predic].ToString();
            txtFev1MeasNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungFev1Meas].ToString();
            txtFev1PerNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungFev1Per].ToString();
            txtPerFev1Normal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();

            txtToxiLeadNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiAluminiumNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiCadmiumNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiMercuryNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiTinNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiCopperNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiManganeseNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiZincNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();
            txtToxiAmmoniaNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.lungPerFev1].ToString();

            txtToxiHippuricNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiHippuric].ToString();
            txtToxiMethylNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiMethyl].ToString();
            txtToxiAcetoneNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiAcetone].ToString();
            txtToxiNickelNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiNickel].ToString();
            txtToxiChromiumNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiChromium].ToString();
            txtToxiPhenolNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiPhenol].ToString();
            txtToxiKetoneNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiKetone].ToString();
            txtToxiBenzeneNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiBenzene].ToString();
            txtToxiMandelicNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiMandelic].ToString();
            txtToxiMethanolNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiMethanol].ToString();
            txtToxiEthanolNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiEthanol].ToString();
            txtToxiIPANormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiIPA].ToString();
            txtToxiArsenicNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiArsenic].ToString();
            txtToxiHexaneNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiHexane].ToString();
            txtToxiFomaldehydeNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiFomaldehyde].ToString();
            txtToxiTrichloroethyleneNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiTrichloroethylene].ToString();
            txtToxiAntimonyNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiAntimony].ToString();
            txtToxiFluorideNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.ToxiFluoride].ToString();

            txtStoolExamColorNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.StoolExamColor].ToString();
            txtStoolExamAppearanceNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.StoolExamAppearance].ToString();
            txtStoolExamWbcNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.StoolExamWbc].ToString();
            txtStoolExamRbcNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.StoolExamRbc].ToString();
            txtStoolExamParasiteNormal.Text = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.StoolExamParasite].ToString();

            if (dtccp.Rows[0][cc.ccpvndb.ccpvn.fSexId].ToString().Equals("3"))
            {
                chkOther.Checked = true;
                chkMale.Checked = false;
                chkFemale.Checked = false;
            }
            else if (dtccp.Rows[0][cc.ccpvndb.ccpvn.fSexId].ToString().Equals("2"))
            {
                chkOther.Checked = false;
                chkMale.Checked = false;
                chkFemale.Checked = true;
            }
            else if (dtccp.Rows[0][cc.ccpvndb.ccpvn.fSexId].ToString().Equals("1"))
            {
                chkOther.Checked = false;
                chkMale.Checked = true;
                chkFemale.Checked = false;
            }
        }

        private void FrmCheckUpEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCBCExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePE_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdatePE(txtRowNumber.Text, cuc.Id, txtPEAge.Text, txtPEVitalSign.Text, txtPEHeight.Text, txtPEWeight.Text, 
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
            String chk = cc.ccpdb.UpdateCBC(txtRowNumber.Text, cuc.Id, txtCBCBaso.Text, txtCBCEos.Text, txtCBCHb.Text, txtCBCHct.Text, 
                txtCBCLy.Text, txtCBCMch.Text, txtCBCMchc.Text, txtCBCMcv.Text, txtCBCMono.Text, txtCBCNeu.Text, txtCBCPltC.Text, txtCBCRbc.Text, 
                txtCBCRbcMono.Text, txtCBCSummary.Text, txtCBCWbc.Text, txtCBCPltS.Text, txtCBCPmn.Text, txtCBCBact.Text);
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
                MessageBox.Show("บันทึกข้อมูล FBS เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnUASave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateUA(txtRowNumber.Text, cuc.Id, txtUAColor.Text, txtUAAppe.Text, txtUASugar.Text, 
                txtUASpgr.Text, txtUApH.Text, txtUAProtein.Text, txtUAWBC.Text, txtUARbc.Text, txtUAEpi.Text, txtUABact.Text, 
                txtUAResult.Text, txtUASpgr.Text, txtUAGlu.Text,txtUAKetone.Text, txtUABlood.Text, txtUALeu.Text, txtUANit.Text,txtUAUro.Text, txtUABil.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnTriSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateTrigly(txtRowNumber.Text, cuc.Id, txtTriValue.Text, txtTriResult.Text, txtTriSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล Trigly เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnChoSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateCholes(txtRowNumber.Text, cuc.Id, txtChoValue.Text, txtChoResult.Text, txtChoSummary.Text, txtChoLDL.Text, txtChoHDL.Text, txtLDLResult.Text, txtLDLSummary.Text, txtHDLResult.Text, txtHDLSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล Choles เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnSgotSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateSgot(txtRowNumber.Text, cuc.Id, txtSgotValue.Text.Trim(), txtSgotSgptValue.Text.Trim(), "", txtSgotResult.Text.Trim(), txtSgotSummary.Text.Trim(), txtSgotAlkaline.Text.Trim());
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล SGOT เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnBunSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateBun(txtRowNumber.Text, cuc.Id, txtBunValue.Text, txtBunCreatinineValue.Text, txtBunResult.Text, txtBunSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล Bun เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnUricSave_Click(object sender, EventArgs e)
        {
            String chk = cc.ccpdb.UpdateUric(txtRowNumber.Text, cuc.Id, txtUricValue.Text, txtUricResult.Text, txtUricSummary.Text);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล Uric เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            String sex = "";
            if (chkMale.Checked)
            {
                sex = "1";
            }
            else if (chkFemale.Checked)
            {
                sex = "2";
            }
            else if (chkOther.Checked)
            {
                sex = "3";
            }
            String chk = cc.ccpdb.UpdateName(txtRowNumber.Text, cuc.Id, txtFullName.Text, txtAge.Text, sex);
            if (chk.Equals("1"))
            {
                MessageBox.Show("บันทึกข้อมูล PE เรียบร้อย", "บันทึกข้อมูล");
            }
        }

        private void btnStoolExamSave_Click(object sender, EventArgs e)
        {

        }

        private void btnOther1Save_Click(object sender, EventArgs e)
        {
            //String chk = cc.ccpdb.UpdateOther1(txt ,cuc.Id, txtUricValue.Text, txtUricResult.Text, txtUricSummary.Text);
            //if (chk.Equals("1"))
            //{
            //    MessageBox.Show("บันทึกข้อมูล Uric เรียบร้อย", "บันทึกข้อมูล");
            //}
        }
    }
}
