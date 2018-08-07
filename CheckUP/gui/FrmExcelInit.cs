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
    public partial class FrmExcelInit : Form
    {
        CheckControl cc;
        int tabSum = 0, tabPE = 1, tabXRay = 2, tabCBC = 3, tabFBS = 4, tabUA = 5, tabTri = 6, tabCho = 7, tabSgot = 8, tabBun = 9, tabUric = 10, tabOther1=11, tabLung=12, tabAudio=13, tabEye=14, tabToxi=15, tabStoolExam=16;
        int tabCnt = 17;
        OpenFileDialog ofd = new OpenFileDialog();
        ExcelInit ei;
        public FrmExcelInit(CheckControl c, String tab)
        {
            InitializeComponent();
            cc = c;
            initConfig();

            setTabShow(tab);

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
                    TabPage t = tC.TabPages[tabPE];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("cbc"))
                {
                    TabPage t = tC.TabPages[tabCBC];
                    tC.SelectedTab = t;
                }
                else if (tab.Equals("xray"))
                {
                    TabPage t = tC.TabPages[tabXRay];
                    tC.SelectedTab = t;
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
        private void initConfig()
        {
            int chk = 0;
            ei = cc.eidb.selectByPk();
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
            tC.TabPages[tabUric].Text = "Uric Acid";
            tC.TabPages[tabOther1].Text = "Other1";
            tC.TabPages[tabLung].Text = "Lung";
            tC.TabPages[tabAudio].Text = "Audio";
            tC.TabPages[tabEye].Text = "Eye";
            tC.TabPages[tabToxi].Text = "Toxicology";
            tC.TabPages[tabStoolExam].Text = "Stool Exam";

            if (ei.SfStatusName.Equals("A"))
            {
                chkA.Checked = true;
            }
            else if (ei.SfStatusName.Equals("B"))
            {
                chkB.Checked = true;
            }
            else if (ei.SfStatusName.Equals("C"))
            {
                chkC.Checked = true;
            }

            nmDDepartment.Value = int.Parse(cc.cf.NumberNull11(ei.DepartmentName));

            nmDPERow.Value = int.Parse(cc.cf.NumberNull11(ei.PERow));
            nmDPENo.Value = int.Parse(cc.cf.NumberNull11(ei.PENo));
            nmDPEAge.Value = int.Parse(cc.cf.NumberNull11(ei.PEAge));
            nmDPEBMI.Value = int.Parse(cc.cf.NumberNull11(ei.PEBMI));
            nmDPEHeight.Value = int.Parse(cc.cf.NumberNull11(ei.PEHeight));
            nmDPEPulse.Value = int.Parse(cc.cf.NumberNull11(ei.PEPulse));
            nmDPEResult.Value = int.Parse(cc.cf.NumberNull11(ei.PEResult));
            nmDPESummary.Value = int.Parse(cc.cf.NumberNull11(ei.PESummary));
            nmDPEVi.Value = int.Parse(cc.cf.NumberNull11(ei.PEVitalSign));
            nmDPEWeight.Value = int.Parse(cc.cf.NumberNull11(ei.PEWeight));
            nmDPEBloodGroup.Value = int.Parse(cc.cf.NumberNull11(ei.PEBloodGroup));

            nmDXRayRow.Value = int.Parse(cc.cf.NumberNull11(ei.XrayRow));
            nmDXRayNo.Value = int.Parse(cc.cf.NumberNull11(ei.XrayNo));
            nmDXRaySummary.Value = int.Parse(cc.cf.NumberNull11(ei.XraySummary));
            nmDXRayValue.Value = int.Parse(cc.cf.NumberNull11(ei.Xray));

            nmDCBCRow.Value = int.Parse(cc.cf.NumberNull11(ei.CBCRow));
            nmDCBCNo.Value = int.Parse(cc.cf.NumberNull11(ei.CBCNo));
            nmDCBCBact.Value = int.Parse(cc.cf.NumberNull11(ei.CBCBact));
            nmDCBCEos.Value = int.Parse(cc.cf.NumberNull11(ei.CBCEos));
            nmDCBCHb.Value = int.Parse(cc.cf.NumberNull11(ei.CBCHb));
            nmDCBCHct.Value = int.Parse(cc.cf.NumberNull11(ei.CBCHct));
            nmDCBCLy.Value = int.Parse(cc.cf.NumberNull11(ei.CBCLy));
            nmDCBCMono.Value = int.Parse(cc.cf.NumberNull11(ei.CBCMono));
            nmDCBCNeu.Value = int.Parse(cc.cf.NumberNull11(ei.CBCNeu));
            nmDCBCPltC.Value = int.Parse(cc.cf.NumberNull11(ei.CBCPltC));
            nmDCBCPltS.Value = int.Parse(cc.cf.NumberNull11(ei.CBCPltS));
            nmDCBCRBC.Value = int.Parse(cc.cf.NumberNull11(ei.CBCRBC));
            nmDCBCRBCmono.Value = int.Parse(cc.cf.NumberNull11(ei.CBCRBCmono));
            nmDCBCSummary.Value = int.Parse(cc.cf.NumberNull11(ei.CBCSummary));
            nmDCBCWBC.Value= int.Parse(cc.cf.NumberNull11(ei.CBCWBC));
            nmDCBCPmn.Value = int.Parse(cc.cf.NumberNull11(ei.cbcPmn));
            nmDCBCMCH.Value = int.TryParse(cc.cf.NumberNull11(ei.CBCMCH), out chk) ? chk : 0;
            nmDCBCMCHC.Value = int.TryParse(cc.cf.NumberNull11(ei.CBCMCHC), out chk) ? chk : 0;
            nmDCBCMCV.Value = int.TryParse(cc.cf.NumberNull11(ei.CBCMCV), out chk) ? chk : 0;
            nmDCBCBaso.Value = int.TryParse(cc.cf.NumberNull11(ei.CBCBASO), out chk) ? chk : 0;

            nmDFBSRow.Value = int.Parse(cc.cf.NumberNull11(ei.FBSRow));
            nmDFBSNo.Value = int.Parse(cc.cf.NumberNull11(ei.FBSNo));
            nmDFBSResult.Value = int.Parse(cc.cf.NumberNull11(ei.FBSResult));
            nmDFBSSummary.Value = int.Parse(cc.cf.NumberNull11(ei.FBSSummary));
            nmDFBSValue.Value = int.Parse(cc.cf.NumberNull11(ei.FBS));

            nmDUARow.Value = int.Parse(cc.cf.NumberNull11(ei.UARow));
            nmDUANo.Value = int.Parse(cc.cf.NumberNull11(ei.UANo));
            nmDUAAppe.Value = int.Parse(cc.cf.NumberNull11(ei.UAAppe));
            nmDUABact.Value = int.Parse(cc.cf.NumberNull11(ei.UABact));
            nmDUAColor.Value = int.Parse(cc.cf.NumberNull11(ei.UAColor));
            nmDUAEpi.Value = int.Parse(cc.cf.NumberNull11(ei.UAEpi));
            nmDUApH.Value = int.Parse(cc.cf.NumberNull11(ei.UApH));
            nmDUAProtein.Value = int.Parse(cc.cf.NumberNull11(ei.UAProtein));
            nmDUARBC.Value = int.Parse(cc.cf.NumberNull11(ei.UARBC));
            nmDUAResult.Value = int.Parse(cc.cf.NumberNull11(ei.UAResult));
            nmDUASpgr.Value = int.Parse(cc.cf.NumberNull11(ei.UASpgr));
            nmDUASugar.Value = int.Parse(cc.cf.NumberNull11(ei.UASugar));
            nmDUASummary.Value = int.Parse(cc.cf.NumberNull11(ei.UASummary));
            nmDUAWBC.Value = int.Parse(cc.cf.NumberNull11(ei.UAWBC));
            nmDUAGlu.Value = int.Parse(cc.cf.NumberNull11(ei.UAGlu));
            nmDUAKetone.Value = int.Parse(cc.cf.NumberNull11(ei.UAKetone));
            nmDUABlood.Value = int.Parse(cc.cf.NumberNull11(ei.UABlood));

            nmDUALeu.Value = int.Parse(cc.cf.NumberNull11(ei.UALeu));
            nmDUANit.Value = int.Parse(cc.cf.NumberNull11(ei.UANit));
            nmDUAUro.Value = int.Parse(cc.cf.NumberNull11(ei.UAUro));
            nmDUABili.Value = int.Parse(cc.cf.NumberNull11(ei.UABil));

            nmDTriRow.Value = int.Parse(cc.cf.NumberNull11(ei.TriRow));
            nmDTriNo.Value = int.Parse(cc.cf.NumberNull11(ei.TriNo));
            nmDTriResult.Value = int.Parse(cc.cf.NumberNull11(ei.TriResult));
            nmDTriSummary.Value = int.Parse(cc.cf.NumberNull11(ei.TriSummary));
            nmDTriValue.Value = int.Parse(cc.cf.NumberNull11(ei.Triglyceride));

            nmDChoNo.Value = int.Parse(cc.cf.NumberNull11(ei.ChoNo));
            nmDChoResult.Value = int.Parse(cc.cf.NumberNull11(ei.ChoResult));
            nmDChoRow.Value = int.Parse(cc.cf.NumberNull11(ei.ChoRow));
            nmDChoSummary.Value = int.Parse(cc.cf.NumberNull11(ei.Chosummary));
            nmDChoValue.Value = int.Parse(cc.cf.NumberNull11(ei.Cholesteral));
            nmDChoLDL.Value = int.Parse(cc.cf.NumberNull11(ei.ChoLDL));
            nmDChoHDL.Value = int.Parse(cc.cf.NumberNull11(ei.ChoHDL));
            nmDLDLResult.Value = int.Parse(cc.cf.NumberNull11(ei.ChoLDLResult));
            nmDLDLSummary.Value = int.Parse(cc.cf.NumberNull11(ei.ChoLDLsummary));
            nmDHDLResult.Value = int.Parse(cc.cf.NumberNull11(ei.ChoHDLResult));
            nmDHDLSummary.Value = int.Parse(cc.cf.NumberNull11(ei.ChoHDLsummary));

            nmDSgotRow.Value = int.Parse(cc.cf.NumberNull11(ei.SgotRow));
            nmDSgotNo.Value = int.Parse(cc.cf.NumberNull11(ei.SgotNo));
            nmDSgotResult.Value = int.Parse(cc.cf.NumberNull11(ei.SgotResult));
            nmDSgotSgptValue.Value = int.Parse(cc.cf.NumberNull11(ei.Sgpt));
            nmDSgotSummary.Value = int.Parse(cc.cf.NumberNull11(ei.SgptSummary));
            nmDSgotvalue.Value = int.Parse(cc.cf.NumberNull11(ei.Sgot));
            nmDSgotALPValue.Value = int.Parse(cc.cf.NumberNull11(ei.SgotALP));
            nmDSgotAakalineValue.Value = int.Parse(cc.cf.NumberNull11(ei.SgotAlkaline));

            nmDBunRow.Value = int.Parse(cc.cf.NumberNull11(ei.BunRow));
            nmDBunNo.Value = int.Parse(cc.cf.NumberNull11(ei.BunNo));
            nmDBunCreatinine.Value = int.Parse(cc.cf.NumberNull11(ei.BunCreatinine));
            nmDBunResult.Value = int.Parse(cc.cf.NumberNull11(ei.BunResult));
            nmDBunSummary.Value = int.Parse(cc.cf.NumberNull11(ei.BunSummary));
            nmDBunValue.Value = int.Parse(cc.cf.NumberNull11(ei.Bun));
            
            nmDUricRow.Value = int.Parse(cc.cf.NumberNull11(ei.UricRow));
            nmDUricNo.Value = int.Parse(cc.cf.NumberNull11(ei.UricNo));
            nmDUricResult.Value = int.Parse(cc.cf.NumberNull11(ei.UricResult));
            nmDUricSummary.Value = int.Parse(cc.cf.NumberNull11(ei.UricSummary));
            nmDUricValue.Value = int.Parse(cc.cf.NumberNull11(ei.UricAcid));

            nmDOther1No.Value = int.Parse(cc.cf.NumberNull11(ei.Other1No));
            nmDOther1Row.Value = int.Parse(cc.cf.NumberNull11(ei.Other1Row));
            nmDOther1HBsAb.Value = int.Parse(cc.cf.NumberNull11(ei.Other1HBsAb));
            nmDOther1HBsAg.Value = int.Parse(cc.cf.NumberNull11(ei.Other1HBsAg));
            nmDOther1Amphetamine.Value = int.Parse(cc.cf.NumberNull11(ei.Other1Amphetamine));
            nmDOther1Calcium.Value = int.Parse(cc.cf.NumberNull11(ei.Other1Calcium));
            nmDOther1VDRL.Value = int.Parse(cc.cf.NumberNull11(ei.Other1VDRL));
            nmDOther1AntiHIV.Value = int.Parse(cc.cf.NumberNull11(ei.Other1AntiHIV));
            nmDOther1AntiHav.Value = int.Parse(cc.cf.NumberNull11(ei.Other1AntiHav));
            nmDOther1CAAFP.Value = int.Parse(cc.cf.NumberNull13(ei.CAAFP));
            nmDOther1CACEA.Value = int.Parse(cc.cf.NumberNull13(ei.CACEA));
            nmDOther1CAPSA.Value = int.Parse(cc.cf.NumberNull13(ei.CAPSA));
            nmDOther1CAHCG.Value = int.Parse(cc.cf.NumberNull13(ei.CAHCG));
            nmDOther1CA153.Value = int.Parse(cc.cf.NumberNull13(ei.CA153));
            nmDOther1CA125.Value = int.Parse(cc.cf.NumberNull13(ei.CA125));
            nmDOther1CA199.Value = int.Parse(cc.cf.NumberNull13(ei.CA199));

            nmDOther1HBsAbResult.Value = int.Parse(cc.cf.NumberNull11(ei.Other1HBsAbResult));
            nmDOther1HBsAgResult.Value = int.Parse(cc.cf.NumberNull11(ei.Other1HBsAgResult));
            nmDOther1HBsAbSummary.Value = int.Parse(cc.cf.NumberNull11(ei.Other1HBsAbSummary));
            nmDOther1AntiHavSummary.Value = int.Parse(cc.cf.NumberNull11(ei.Other1AntiHavSummary));

            nmDOtherAmphetamineSummary.Value = int.Parse(cc.cf.NumberNull11(ei.AmphetamineSummary));

            nmDLungRow.Value = int.Parse(cc.cf.NumberNull11(ei.LungRow));
            nmDLungNo.Value = int.Parse(cc.cf.NumberNull11(ei.LungNo));
            nmDLungFvcPredic.Value = int.Parse(cc.cf.NumberNull11(ei.LungFvcPredic));
            nmDLungFvcMeas.Value = int.Parse(cc.cf.NumberNull11(ei.LungFvcMeas));
            nmDLungFvcPer.Value = int.Parse(cc.cf.NumberNull11(ei.LungFvcPer));
            nmDLungFev1Predic.Value = int.Parse(cc.cf.NumberNull11(ei.LungFev1Predic));
            nmDLungFev1Meas.Value = int.Parse(cc.cf.NumberNull11(ei.LungFev1Meas));
            nmDLungFev1Per.Value = int.Parse(cc.cf.NumberNull11(ei.LungFev1Per));
            nmDLungPerFev1.Value = int.Parse(cc.cf.NumberNull11(ei.LungPerFev1));
            nmDLungSummary.Value = int.Parse(cc.cf.NumberNull11(ei.LungSummary));

            nmDAudioNo.Value = int.Parse(cc.cf.NumberNull11(ei.AudiogramNo));
            nmDAudioRow.Value = int.Parse(cc.cf.NumberNull11(ei.AudiogramRow));
            nmDAudiogram500L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram500L));
            nmDAudiogram500R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram500R));
            nmDAudiogram1000L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram1000L));
            nmDAudiogram1000R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram1000R));
            nmDAudiogram2000L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram2000L));
            nmDAudiogram2000R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram2000R));
            nmDAudiogram3000L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram3000L));
            nmDAudiogram3000R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram3000R));
            nmDAudiogram4000L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram4000L));
            nmDAudiogram4000R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram4000R));
            nmDAudiogram6000L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram6000L));
            nmDAudiogram6000R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram6000R));
            nmDAudiogram8000L.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram8000L));
            nmDAudiogram8000R.Value = int.Parse(cc.cf.NumberNull11(ei.Audiogram8000R));
            nmDAudiogramSummaryL.Value = int.Parse(cc.cf.NumberNull11(ei.AudiogramSummaryL));
            nmDAudiogramSummaryR.Value = int.Parse(cc.cf.NumberNull11(ei.AudiogramSummaryR));
            nmDAudiogramExam.Value = int.Parse(cc.cf.NumberNull11(ei.AudiogramExam));

            nmDEyeNo.Value = int.Parse(cc.cf.NumberNull11(ei.EyeNo));
            nmDEyeRow.Value = int.Parse(cc.cf.NumberNull11(ei.EyeRow));
            nmDEyeShortLongLeft.Value = int.Parse(cc.cf.NumberNull11(ei.EyeShortLongLeft));
            nmDEyeShortLongRight.Value = int.Parse(cc.cf.NumberNull11(ei.EyeShortLongRight));
            nmDEyeSquintLeft.Value = int.Parse(cc.cf.NumberNull11(ei.EyeSquintLeft));
            nmDEyeSquintRight.Value = int.Parse(cc.cf.NumberNull11(ei.EyeSquintRight));
            nmDEyeDegreeLeft.Value = int.Parse(cc.cf.NumberNull11(ei.EyeDegreeLeft));
            nmDEyeDegreeRight.Value = int.Parse(cc.cf.NumberNull11(ei.EyeDegreeRight));
            nmDEyeOldLeft.Value = int.Parse(cc.cf.NumberNull11(ei.EyeOldLeft));
            nmDEyeOldRight.Value = int.Parse(cc.cf.NumberNull11(ei.EyeOldRight));
            nmDEyeBlindness.Value = int.Parse(cc.cf.NumberNull11(ei.EyeBlindness));
            nmDEyeResult.Value = int.Parse(cc.cf.NumberNull11(ei.EyeResult));
            nmDEyeSummary.Value = int.Parse(cc.cf.NumberNull11(ei.EyeSummary));
            nmDEyeExam.Value = int.Parse(cc.cf.NumberNull11(ei.EyeExam));

            nmDStoolExamAppearance.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamAppearance));
            nmDStoolExamColor.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamColor));
            nmDStoolExamNo.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamNo));
            nmDStoolExamParasite.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamParasite));
            nmDStoolExamRBC.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamRbc));
            nmDStoolExamRow.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamRow));
            nmDStoolExamSummary.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamSummary));
            nmDStoolExamWBC.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamWbc));
            nmDStoolExamCulture.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamCulture));
            nmDStoolExamTyHoidH.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamTyphoidH));
            nmDStoolExamTyHoidO.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamTyphoidO));
            nmDStoolExamCultureSummary.Value = int.Parse(cc.cf.NumberNull11(ei.StoolExamCultureSummary));

            nmDToxiLead.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiLead));
            nmDToxiAluminium.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiAluminium));
            nmDToxiCadmium.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiCadmium));
            nmDToxiMercury.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiMercury));
            nmDToxiTin.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiTin));
            nmDToxiCopper.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiCopper));
            nmDToxiManganese.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiManganese));
            nmDToxiZinc.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiZinc));
            nmDToxiAmmonia.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiAmmonia));

            nmDToxiHippuric.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiHippuric));
            nmDToxiMethyl.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiMethyl));
            nmDToxiAcetone.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiAcetone));
            nmDToxiNickel.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiNickel));
            nmDToxiChromium.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiChromium));
            nmDToxiPhenol.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiPhenol));
            nmDToxiKetone.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiKetone));
            nmDToxiBenzene.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiBenzene));
            nmDToxiMandelic.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiMandelic));
            nmDToxiMethanol.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiMethanol));
            nmDToxiEthanol.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiEthanol));
            nmDToxiIPA.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiIPA));
            nmDToxiArsenic.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiArsenic));
            nmDToxiHexane.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiHexane));
            nmDToxiFomaldehyde.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiFomaldehyde));
            nmDToxiTrichloroethylene.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiTrichloroethylene));
            nmDToxiAntimony.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiAntimony));
            nmDToxiFluoride.Value = int.Parse(cc.cf.NumberNull11(ei.ToxiFluoride));

            txtPESheetName.Text = ei.PESheetname;
            txtXRaySheetName.Text = ei.XraySheetname;
            txtCBCSheetName.Text = ei.CBCSheetname;
            txtFBSSheetName.Text = ei.FBSSheetname;
            txtUASheetName.Text = ei.UASheetname;
            txtTriSheetName.Text = ei.TriSheetname;
            txtChoSheetName.Text = ei.ChoSheetname;
            txtSgotSheetName.Text = ei.SgotSheetname;
            txtBunSheetName.Text = ei.BunSheetname;
            txtUricSheetName.Text = ei.UricSheetname;
            txtStoolExamSheetName.Text = ei.StoolExamSheetname;
            txtToxiSheetName.Text = ei.ToxiSheetname;
            txtEyeSheetName.Text = ei.EyeSheetname;
            txtAudioSheetName.Text = ei.AudiogramSheetname;
            txtLungSheetName.Text = ei.LungSheetname;
            txtOther1SheetName.Text = ei.Other1Sheetname;

            lbPE.Left = label3.Left;
            lbXRay.Left = label3.Left;
            lbCBC.Left = label3.Left;
            lbFBS.Left = label3.Left;
            lbUA.Left = label3.Left;
            lbTri.Left = label3.Left;
            lbCho.Left = label3.Left;
            lbSgot.Left = label3.Left;
            lbBun.Left = label3.Left;
            lbUric.Left = label3.Left;

            lbPE.Top = label3.Top;
            lbXRay.Top = label3.Top;
            lbCBC.Top = label3.Top;
            lbFBS.Top = label3.Top;
            lbUA.Top = label3.Top;
            lbTri.Top = label3.Top;
            lbCho.Top = label3.Top;
            lbSgot.Top = label3.Top;
            lbBun.Top = label3.Top;
            lbUric.Top = label3.Top;

            nmDPERow.Left = nmDRow.Left;
            nmDXRayRow.Left = nmDRow.Left;
            nmDCBCRow.Left = nmDRow.Left;
            nmDFBSRow.Left = nmDRow.Left;
            nmDUARow.Left = nmDRow.Left;
            nmDTriRow.Left = nmDRow.Left;
            nmDChoRow.Left = nmDRow.Left;
            nmDSgotRow.Left = nmDRow.Left;
            nmDBunRow.Left = nmDRow.Left;
            nmDUricRow.Left = nmDRow.Left;

            nmDPERow.Top = nmDRow.Top;
            nmDXRayRow.Top = nmDRow.Top;
            nmDCBCRow.Top = nmDRow.Top;
            nmDFBSRow.Top = nmDRow.Top;
            nmDUARow.Top = nmDRow.Top;
            nmDTriRow.Top = nmDRow.Top;
            nmDChoRow.Top = nmDRow.Top;
            nmDSgotRow.Top = nmDRow.Top;
            nmDBunRow.Top = nmDRow.Top;
            nmDUricRow.Top = nmDRow.Top;

            lbXRayNo.Top = lbPENo.Top;
            lbCBCNo.Top = lbPENo.Top;
            lbUANo.Top = lbPENo.Top;
            lbFBSNo.Top = lbPENo.Top;
            lbTriNo.Top = lbPENo.Top;
            lbChoNo.Top = lbPENo.Top;
            lbBunNo.Top = lbPENo.Top;
            lbSgotNo.Top = lbPENo.Top;
            lbUricNo.Top = lbPENo.Top;
            //lbXRayNo.Top = lbPENo.Top;
            lbXRayNo.Left = lbPENo.Left;
            lbCBCNo.Left = lbPENo.Left;
            lbUANo.Left = lbPENo.Left;
            lbFBSNo.Left = lbPENo.Left;
            lbTriNo.Left = lbPENo.Left;
            lbChoNo.Left = lbPENo.Left;
            lbBunNo.Left = lbPENo.Left;
            lbSgotNo.Left = lbPENo.Left;
            lbUricNo.Left = lbPENo.Left;

            nmDXRayNo.Top = nmDPENo.Top;
            nmDCBCNo.Top = nmDPENo.Top;
            nmDUANo.Top = nmDPENo.Top;
            nmDFBSNo.Top = nmDPENo.Top;
            nmDTriNo.Top = nmDPENo.Top;
            nmDChoNo.Top = nmDPENo.Top;
            nmDBunNo.Top = nmDPENo.Top;
            nmDSgotNo.Top = nmDPENo.Top;
            nmDUricNo.Top = nmDPENo.Top;

            nmDXRayNo.Left = nmDPENo.Left;
            nmDCBCNo.Left = nmDPENo.Left;
            nmDUANo.Left = nmDPENo.Left;
            nmDFBSNo.Left = nmDPENo.Left;
            nmDTriNo.Left = nmDPENo.Left;
            nmDChoNo.Left = nmDPENo.Left;
            nmDBunNo.Left = nmDPENo.Left;
            nmDSgotNo.Left = nmDPENo.Left;
            nmDUricNo.Left = nmDPENo.Left;
            Decimal chk1 = 0;
            if (Decimal.TryParse(ei.SfRow, out chk1))
            {
                nmDRow.Value = chk1;
            }
            else
            {
                MessageBox.Show("ลำดับ row ไม่ได้ set", "error");
            }
        }
        private void SaveSgot()
        {
            String No = "", sgot = "", sgpt = "", result = "", summary = "", alkaline="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtSgotSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDSgotRow.Value, nmDSgotNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotvalue.Value].Value2 != null)
            {
                sgot = xlRange.Cells[nmDSgotRow.Value, nmDSgotvalue.Value].Value2.ToString();
            }
            else
            {
                sgot = "";
            }
            sgot = sgot.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotSgptValue.Value].Value2 != null)
            {
                sgpt = xlRange.Cells[nmDSgotRow.Value, nmDSgotSgptValue.Value].Value2.ToString();
            }
            else
            {
                sgpt = "";
            }
            sgpt = sgpt.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDSgotRow.Value, nmDSgotResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDSgotRow.Value, nmDSgotSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            if (xlRange.Cells[nmDSgotRow.Value, nmDSgotAakalineValue.Value].Value2 != null)
            {
                alkaline = xlRange.Cells[nmDSgotRow.Value, nmDSgotAakalineValue.Value].Value2.ToString();
            }
            else
            {
                alkaline = "";
            }
            alkaline = alkaline.Trim();
            txtSgotTest.Text = "ลำดับ " + No + " sgot " + sgot + " sgpt " + sgpt + " result " + result + " summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateSgot(nmDSgotvalue.Value.ToString(), nmDSgotNo.Value.ToString(), nmDSgotResult.Value.ToString(), nmDSgotRow.Value.ToString(), nmDSgotSgptValue.Value.ToString(),
                nmDSgotSummary.Value.ToString(), txtSgotSheetName.Text, nmDSgotAakalineValue.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Sgot เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveBun()
        {
            String No = "", bun = "", creatinine = "", result = "", summary = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtBunSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDBunRow.Value, nmDBunNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDBunRow.Value, nmDBunNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunValue.Value].Value2 != null)
            {
                bun = xlRange.Cells[nmDBunRow.Value, nmDBunValue.Value].Value2.ToString();
            }
            else
            {
                bun = "";
            }
            bun = bun.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunCreatinine.Value].Value2 != null)
            {
                creatinine = xlRange.Cells[nmDBunRow.Value, nmDBunCreatinine.Value].Value2.ToString();
            }
            else
            {
                creatinine = "";
            }
            creatinine = creatinine.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDBunRow.Value, nmDBunResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDBunRow.Value, nmDBunSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDBunRow.Value, nmDBunSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtBunTest.Text = "ลำดับ " + No + " bun " + bun + " sgpt " + creatinine + " result " + result + " summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateBun(nmDBunRow.Value.ToString(), nmDBunNo.Value.ToString(),nmDBunValue.Value.ToString(),  nmDBunCreatinine.Value.ToString(), nmDBunResult.Value.ToString(), 
                nmDBunSummary.Value.ToString(),txtBunSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล BUN เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveUric()
        {
            String No = "", uricMale = "", uricFeMale = "", result = "", summary = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtUricSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDUricRow.Value, nmDUricNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDUricRow.Value, nmDUricNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDUricRow.Value, nmDUricValue.Value].Value2 != null)
            {
                uricMale = xlRange.Cells[nmDUricRow.Value, nmDUricValue.Value].Value2.ToString();
            }
            else
            {
                uricMale = "";
            }
            uricMale = uricMale.Trim();

            //if (xlRange.Cells[nmDUricRow.Value, nmDUricFeMaleValue.Value].Value2 != null)
            //{
            //    uricFeMale = xlRange.Cells[nmDUricRow.Value, nmDUricFeMaleValue.Value].Value2.ToString();
            //}
            //else
            //{
            //    uricFeMale = "";
            //}
            //uricMale = uricMale.Trim();

            if (xlRange.Cells[nmDUricRow.Value, nmDUricResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDUricRow.Value, nmDUricResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDUricRow.Value, nmDUricSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDUricRow.Value, nmDUricSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtUricTest.Text = "ลำดับ " + No + " Uric male " + uricMale + " Uric Female " + uricFeMale + " result " + result + " summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateUric(nmDUricRow.Value.ToString().Trim(), nmDUricNo.Value.ToString().Trim(), nmDUricValue.Value.ToString().Trim(), nmDUricResult.Value.ToString().Trim(),
                nmDUricSummary.Value.ToString().Trim(), txtUricSheetName.Text.Trim()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Uric Acid เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveCholes()
        {
            String No = "", cho = "", result = "", summary = "", ldl="", hdl="", ldlresult="", ldlsummary="", hdlresult="", hdlsummary="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtChoSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDChoRow.Value, nmDChoNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDChoRow.Value, nmDChoNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDChoValue.Value].Value2 != null)
            {
                cho = xlRange.Cells[nmDChoRow.Value, nmDChoValue.Value].Value2.ToString();
            }
            else
            {
                cho = "";
            }
            cho = cho.Trim();

            if (xlRange.Cells[nmDChoRow.Value, nmDChoLDL.Value].Value2 != null)
            {
                ldl = xlRange.Cells[nmDChoRow.Value, nmDChoLDL.Value].Value2.ToString();
            }
            else
            {
                ldl = "";
            }
            ldl = ldl.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDChoHDL.Value].Value2 != null)
            {
                hdl = xlRange.Cells[nmDChoRow.Value, nmDChoHDL.Value].Value2.ToString();
            }
            else
            {
                hdl = "";
            }
            hdl = hdl.Trim();

            if (xlRange.Cells[nmDChoRow.Value, nmDChoResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDChoRow.Value, nmDChoResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDChoSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDChoRow.Value, nmDChoSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDLDLResult.Value].Value2 != null)
            {
                ldlresult = xlRange.Cells[nmDChoRow.Value, nmDLDLResult.Value].Value2.ToString();
            }
            else
            {
                ldlresult = "";
            }
            ldlresult = ldlresult.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDLDLSummary.Value].Value2 != null)
            {
                ldlsummary = xlRange.Cells[nmDChoRow.Value, nmDLDLSummary.Value].Value2.ToString();
            }
            else
            {
                ldlsummary = "";
            }
            ldlsummary = ldlsummary.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDHDLResult.Value].Value2 != null)
            {
                hdlresult = xlRange.Cells[nmDChoRow.Value, nmDHDLResult.Value].Value2.ToString();
            }
            else
            {
                hdlresult = "";
            }
            hdlresult = hdlresult.Trim();
            if (xlRange.Cells[nmDChoRow.Value, nmDHDLSummary.Value].Value2 != null)
            {
                hdlsummary = xlRange.Cells[nmDChoRow.Value, nmDHDLSummary.Value].Value2.ToString();
            }
            else
            {
                hdlsummary = "";
            }
            hdlsummary = hdlsummary.Trim();

            Cursor.Current = cursor;
            txtChoTest.Text = "ลำดับ " + No + " choles " + cho + " result " + result + " summary " + summary + " LDL " + ldl + " result " + ldlresult + " summary " + ldlsummary + " HDL " + hdl + " result " + hdlresult + " summary " + hdlsummary;
            if (cc.eidb.updateCholes(nmDChoRow.Value.ToString(), nmDChoNo.Value.ToString(),nmDChoValue.Value.ToString(), nmDChoResult.Value.ToString(),
                nmDChoSummary.Value.ToString(), nmDChoLDL.Value.ToString(), nmDChoHDL.Value.ToString(), txtChoSheetName.Text, nmDLDLResult.Value.ToString(), 
                nmDLDLSummary.Value.ToString(), nmDHDLResult.Value.ToString(), nmDHDLSummary.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Choles เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveTrig()
        {
            String No = "", tri = "", result = "", summary = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtTriSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDTriRow.Value, nmDTriNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDTriRow.Value, nmDTriNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDTriRow.Value, nmDTriValue.Value].Value2 != null)
            {
                tri = xlRange.Cells[nmDTriRow.Value, nmDTriValue.Value].Value2.ToString();
            }
            else
            {
                tri = "";
            }
            tri = tri.Trim();
            if (xlRange.Cells[nmDTriRow.Value, nmDTriResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDTriRow.Value, nmDTriResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDTriRow.Value, nmDTriSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDTriRow.Value, nmDTriSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtTriTest.Text = "ลำดับ " + No + " Trig " + tri + " result " + result + " summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateTrig(nmDTriValue.Value.ToString(), nmDTriNo.Value.ToString(), nmDTriResult.Value.ToString(), nmDTriRow.Value.ToString(), nmDTriSummary.Value.ToString(),txtTriSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Trig เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveUA()
        {
            String No = "", color = "", appe = "", sugar = "", spgr = "", pH = "", protein = "", wbc = "", rbc = "", epi = "", bact = "", result = "", rbcmono = "", summary = "", glu = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtUASheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDUARow.Value, nmDUANo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDUARow.Value, nmDUANo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAColor.Value].Value2 != null)
            {
                color = xlRange.Cells[nmDUARow.Value, nmDUAColor.Value].Value2.ToString();
            }
            else
            {
                color = "";
            }
            color = color.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAAppe.Value].Value2 != null)
            {
                appe = xlRange.Cells[nmDUARow.Value, nmDUAAppe.Value].Value2.ToString();
            }
            else
            {
                appe = "";
            }
            appe = appe.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUASugar.Value].Value2 != null)
            {
                sugar = xlRange.Cells[nmDUARow.Value, nmDUASugar.Value].Value2.ToString();
            }
            else
            {
                sugar = "";
            }
            sugar = sugar.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUASpgr.Value].Value2 != null)
            {
                spgr = xlRange.Cells[nmDUARow.Value, nmDUASpgr.Value].Value2.ToString();
            }
            else
            {
                spgr = "";
            }
            spgr = spgr.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUApH.Value].Value2 != null)
            {
                pH = xlRange.Cells[nmDUARow.Value, nmDUApH.Value].Value2.ToString();
            }
            else
            {
                pH = "";
            }
            pH = pH.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAProtein.Value].Value2 != null)
            {
                protein = xlRange.Cells[nmDUARow.Value, nmDUAProtein.Value].Value2.ToString();
            }
            else
            {
                protein = "";
            }
            protein = protein.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAWBC.Value].Value2 != null)
            {
                wbc = xlRange.Cells[nmDUARow.Value, nmDUAWBC.Value].Value2.ToString();
            }
            else
            {
                wbc = "";
            }
            wbc = wbc.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUARBC.Value].Value2 != null)
            {
                rbc = xlRange.Cells[nmDUARow.Value, nmDUARBC.Value].Value2.ToString();
            }
            else
            {
                rbc = "";
            }
            rbc = rbc.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAEpi.Value].Value2 != null)
            {
                epi = xlRange.Cells[nmDUARow.Value, nmDUAEpi.Value].Value2.ToString();
            }
            else
            {
                epi = "";
            }
            epi = epi.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUABact.Value].Value2 != null)
            {
                bact = xlRange.Cells[nmDUARow.Value, nmDUABact.Value].Value2.ToString();
            }
            else
            {
                bact = "";
            }
            bact = bact.Trim();
            if (xlRange.Cells[nmDUARow.Value, nmDUAResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDUARow.Value, nmDUAResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();

            if (xlRange.Cells[nmDUARow.Value, nmDUASummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDUARow.Value, nmDUASummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();

            if (xlRange.Cells[nmDUARow.Value, nmDUAGlu.Value].Value2 != null)
            {
                glu = xlRange.Cells[nmDUARow.Value, nmDUAGlu.Value].Value2.ToString();
            }
            else
            {
                glu = "";
            }
            glu = glu.Trim();
            txtUATest.Text = "ลำดับ " + No + " color " + color + " spgr " + spgr + " sugar " + sugar + " appe " + appe + " protein " + protein + " pH " + pH + " wbc " + wbc +
                " rbc " + rbc + " epi " + epi + " bact " + bact + " result " + result + " rbcmono " + rbcmono + " Glu " + glu + " Summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateUA(nmDUAAppe.Value.ToString(), nmDUABact.Value.ToString(), nmDUAColor.Value.ToString(), nmDUAEpi.Value.ToString(),
                nmDUANo.Value.ToString(), nmDUApH.Value.ToString(), nmDUAProtein.Value.ToString(), nmDUARBC.Value.ToString(), nmDUAResult.Value.ToString(), nmDUARow.Value.ToString(),
                nmDUASpgr.Value.ToString(), nmDUASugar.Value.ToString(), nmDUASummary.Value.ToString(), nmDUAWBC.Value.ToString(), nmDUAGlu.Value.ToString(), nmDUAKetone.Value.ToString(), 
                nmDUABlood.Value.ToString(),txtUASheetName.Text, nmDUALeu.Value.ToString(), nmDUANit.Value.ToString(), nmDUAUro.Value.ToString(), nmDUABili.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveOther1()
        {
            String No = "", HBsAg = "", HbsAb = "", AntiHIV = "", VDRL = "", Amphetamine = "", Calcium = "", AntiHav = "", HBsAgResult = "", HbsAbResult = "", HBsAgSummary = "", HbsAbSummary = "";
            String CAAFP = "", CACEA = "", CAPSA = "", CAHCG = "", CA153 = "", CA125 = "", CA199 = "", AmphetamineSummary = "", AntiHavSummary="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtOther1SheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1No.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDOther1Row.Value, nmDOther1No.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAg.Value].Value2 != null)
            {
                HBsAg = xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAg.Value].Value2.ToString();
            }
            else
            {
                HBsAg = "";
            }
            HBsAg = HBsAg.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAb.Value].Value2 != null)
            {
                HbsAb = xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAb.Value].Value2.ToString();
            }
            else
            {
                HbsAb = "";
            }
            HbsAb = HbsAb.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1AntiHIV.Value].Value2 != null)
            {
                AntiHIV = xlRange.Cells[nmDOther1Row.Value, nmDOther1AntiHIV.Value].Value2.ToString();
            }
            else
            {
                AntiHIV = "";
            }
            AntiHIV = AntiHIV.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1VDRL.Value].Value2 != null)
            {
                VDRL = xlRange.Cells[nmDOther1Row.Value, nmDOther1VDRL.Value].Value2.ToString();
            }
            else
            {
                VDRL = "";
            }
            VDRL = VDRL.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1Amphetamine.Value].Value2 != null)
            {
                Amphetamine = xlRange.Cells[nmDOther1Row.Value, nmDOther1Amphetamine.Value].Value2.ToString();
            }
            else
            {
                Amphetamine = "";
            }
            Amphetamine = Amphetamine.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1Calcium.Value].Value2 != null)
            {
                Calcium = xlRange.Cells[nmDOther1Row.Value, nmDOther1Calcium.Value].Value2.ToString();
            }
            else
            {
                Calcium = "";
            }
            Calcium = Calcium.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1AntiHav.Value].Value2 != null)
            {
                AntiHav = xlRange.Cells[nmDOther1Row.Value, nmDOther1AntiHav.Value].Value2.ToString();
            }
            else
            {
                AntiHav = "";
            }
            AntiHav = AntiHav.Trim();

            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CAAFP.Value].Value2 != null)
            {
                CAAFP = xlRange.Cells[nmDOther1Row.Value, nmDOther1CAAFP.Value].Value2.ToString();
            }
            else
            {
                CAAFP = "";
            }
            CAAFP = CAAFP.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CACEA.Value].Value2 != null)
            {
                CACEA = xlRange.Cells[nmDOther1Row.Value, nmDOther1CACEA.Value].Value2.ToString();
            }
            else
            {
                CACEA = "";
            }
            CACEA = CACEA.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CAPSA.Value].Value2 != null)
            {
                CAPSA = xlRange.Cells[nmDOther1Row.Value, nmDOther1CAPSA.Value].Value2.ToString();
            }
            else
            {
                CAPSA = "";
            }
            CAPSA = CAPSA.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CAHCG.Value].Value2 != null)
            {
                CAHCG = xlRange.Cells[nmDOther1Row.Value, nmDOther1CAHCG.Value].Value2.ToString();
            }
            else
            {
                CAHCG = "";
            }
            CAHCG = CAHCG.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CA153.Value].Value2 != null)
            {
                CA153 = xlRange.Cells[nmDOther1Row.Value, nmDOther1CA153.Value].Value2.ToString();
            }
            else
            {
                CA153 = "";
            }
            CA153 = CA153.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CA125.Value].Value2 != null)
            {
                CA125 = xlRange.Cells[nmDOther1Row.Value, nmDOther1CA125.Value].Value2.ToString();
            }
            else
            {
                CA125 = "";
            }
            CA125 = CA125.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1CA199.Value].Value2 != null)
            {
                CA199 = xlRange.Cells[nmDOther1Row.Value, nmDOther1CA199.Value].Value2.ToString();
            }
            else
            {
                CA199 = "";
            }
            CA199 = CA199.Trim();

            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAgResult.Value].Value2 != null)
            {
                HBsAgResult = xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAgResult.Value].Value2.ToString();
            }
            else
            {
                HBsAgResult = "";
            }
            HBsAgResult = HBsAgResult.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAbResult.Value].Value2 != null)
            {
                HbsAbResult = xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAbResult.Value].Value2.ToString();
            }
            else
            {
                HbsAbResult = "";
            }
            HbsAbResult = HbsAbResult.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAgResult.Value].Value2 != null)
            {
                HBsAgSummary = xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAgResult.Value].Value2.ToString();
            }
            else
            {
                HBsAgSummary = "";
            }
            HBsAgSummary = HBsAgSummary.Trim();
            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAgSummary.Value].Value2 != null)
            {
                HbsAbSummary = xlRange.Cells[nmDOther1Row.Value, nmDOther1HBsAgSummary.Value].Value2.ToString();
            }
            else
            {
                HbsAbSummary = "";
            }
            HbsAbSummary = HbsAbSummary.Trim();

            if (xlRange.Cells[nmDOther1Row.Value, nmDOtherAmphetamineSummary.Value].Value2 != null)
            {
                AmphetamineSummary = xlRange.Cells[nmDOther1Row.Value, nmDOtherAmphetamineSummary.Value].Value2.ToString();
            }
            else
            {
                AmphetamineSummary = "";
            }
            AmphetamineSummary = AmphetamineSummary.Trim();

            if (xlRange.Cells[nmDOther1Row.Value, nmDOther1AntiHavSummary.Value].Value2 != null)
            {
                AntiHavSummary = xlRange.Cells[nmDOther1Row.Value, nmDOther1AntiHavSummary.Value].Value2.ToString();
            }
            else
            {
                AntiHavSummary = "";
            }
            AntiHavSummary = AntiHavSummary.Trim();

            txtOther1Test.Text = "ลำดับ " + No + " HBsAg " + HBsAg + " HbsAb " + HbsAb + " AntiHIV " + AntiHIV + " VDRL " + VDRL + " Amphetamine " + Amphetamine + " Calcium " + Calcium + " AntiHav " + AntiHav+
                " CAAFP " + CAAFP+" CACEA " + CACEA+" CAPSA " + CAPSA+" CAHCG " + CAHCG+" CA153 " + CA153+" CA125 " + CA125+" CA199 " + CA199;

            Cursor.Current = cursor;
            if (cc.eidb.UpdateOther1(nmDOther1Amphetamine.Value.ToString(), nmDOther1AntiHIV.Value.ToString(), nmDOther1Calcium.Value.ToString(), nmDOther1HBsAb.Value.ToString(),
                nmDOther1HBsAg.Value.ToString(), nmDOther1No.Value.ToString(), nmDOther1Row.Value.ToString(), nmDOther1VDRL.Value.ToString(),txtOther1SheetName.Text, nmDOther1AntiHav.Value.ToString(),
                nmDOther1CAAFP.Value.ToString(), nmDOther1CAAFPResult.Value.ToString(), nmDOther1CAAFPSummary.Value.ToString(), nmDOther1CACEA.Value.ToString(), nmDOther1CACEAResult.Value.ToString(),
                nmDOther1CACEASummary.Value.ToString(), nmDOther1CAPSA.Value.ToString(), nmDOther1CAPSAResult.Value.ToString(), nmDOther1CAPSASummary.Value.ToString(), nmDOther1CAHCG.Value.ToString(),
                nmDOther1CAHCGResult.Value.ToString(), nmDOther1CAHCGSummary.Value.ToString(), nmDOther1CA153.Value.ToString(), nmDOther1CA153Result.Value.ToString(), 
                nmDOther1CA153Summary.Value.ToString(), nmDOther1CA125.Value.ToString(), nmDOther1CA125Result.Value.ToString(), nmDOther1CA125Summary.Value.ToString(),
                nmDOther1CA199.Value.ToString(), nmDOther1CA199Result.Value.ToString(), nmDOther1CA199Summary.Value.ToString(), nmDOther1HBsAbResult.Value.ToString(),
                nmDOther1HBsAgResult.Value.ToString(), nmDOther1HBsAbSummary.Value.ToString(), nmDOther1HBsAgSummary.Value.ToString(), nmDOtherAmphetamineSummary.Value.ToString(), nmDOther1AntiHavSummary.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Other เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveLung()
        {
            String LungRow = "", LungNo = "", LungFvcPredic = "", LungFvcMeas = "", LungFvcPer = "", LungFev1Predic = "", LungFev1Meas = "", LungFev1Per = "", LungPerFev1 = "", LungSummary = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtLungSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDLungRow.Value, nmDLungNo.Value].Value2 != null)
            {
                LungNo = xlRange.Cells[nmDLungRow.Value, nmDLungNo.Value].Value2.ToString();
            }
            else
            {
                LungNo = "";
            }
            LungNo = LungNo.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungFvcPredic.Value].Value2 != null)
            {
                LungFvcPredic = xlRange.Cells[nmDLungRow.Value, nmDLungFvcPredic.Value].Value2.ToString();
            }
            else
            {
                LungFvcPredic = "";
            }
            LungFvcPredic = LungFvcPredic.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungFvcMeas.Value].Value2 != null)
            {
                LungFvcMeas = xlRange.Cells[nmDLungRow.Value, nmDLungFvcMeas.Value].Value2.ToString();
            }
            else
            {
                LungFvcMeas = "";
            }
            LungFvcMeas = LungFvcMeas.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungFvcPer.Value].Value2 != null)
            {
                LungFvcPer = xlRange.Cells[nmDLungRow.Value, nmDLungFvcPer.Value].Value2.ToString();
            }
            else
            {
                LungFvcPer = "";
            }
            LungFvcPer = LungFvcPer.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungFev1Predic.Value].Value2 != null)
            {
                LungFev1Predic = xlRange.Cells[nmDLungRow.Value, nmDLungFev1Predic.Value].Value2.ToString();
            }
            else
            {
                LungFev1Predic = "";
            }
            LungFev1Predic = LungFev1Predic.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungFev1Meas.Value].Value2 != null)
            {
                LungFev1Meas = xlRange.Cells[nmDLungRow.Value, nmDLungFev1Meas.Value].Value2.ToString();
            }
            else
            {
                LungFev1Meas = "";
            }
            LungFev1Meas = LungFev1Meas.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungFev1Per.Value].Value2 != null)
            {
                LungFev1Per = xlRange.Cells[nmDLungRow.Value, nmDLungFev1Per.Value].Value2.ToString();
            }
            else
            {
                LungFev1Per = "";
            }
            LungFev1Per = LungFev1Per.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungPerFev1.Value].Value2 != null)
            {
                LungPerFev1 = xlRange.Cells[nmDLungRow.Value, nmDLungPerFev1.Value].Value2.ToString();
            }
            else
            {
                LungPerFev1 = "";
            }
            LungPerFev1 = LungPerFev1.Trim();
            if (xlRange.Cells[nmDLungRow.Value, nmDLungSummary.Value].Value2 != null)
            {
                LungSummary = xlRange.Cells[nmDLungRow.Value, nmDLungSummary.Value].Value2.ToString();
            }
            else
            {
                LungSummary = "";
            }
            LungSummary = LungSummary.Trim();
            txtLungTest.Text = "ลำดับ " + LungNo + " FvcPredic " + LungFvcPredic + " FvcMeas " + LungFvcMeas + " FvcPer " + LungFvcPer +
                " Fev1Predic " + LungFev1Predic + " Fev1Meas " + LungFev1Meas + " Fev1Per " + LungFev1Per + " PerFev1 " + LungPerFev1 + " Summary " + LungSummary;

            Cursor.Current = cursor;
            if (cc.eidb.updateLung(nmDLungRow.Value.ToString(), nmDLungNo.Value.ToString(), nmDLungFvcPredic.Value.ToString(), nmDLungFvcMeas.Value.ToString(),
                nmDLungFvcPer.Value.ToString(), nmDLungFev1Predic.Value.ToString(), nmDLungFev1Meas.Value.ToString(), nmDLungFev1Per.Value.ToString(), 
                nmDLungPerFev1.Value.ToString(), nmDLungSummary.Value.ToString(),txtLungSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Lung เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveAudio()
        {
            String No = "", Audiogram500L = "", Audiogram1000L = "", Audiogram2000L = "", Audiogram3000L = "", Audiogram4000L="",Audiogram6000L="", Audiogram8000L="", AudiogramSummaryL="";
            String Audiogram500R = "", Audiogram1000R = "", Audiogram2000R = "", Audiogram3000R="", Audiogram4000R="", Audiogram6000R="", Audiogram8000R="", AudiogramSummaryR="", AudiogramExam="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtAudioSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDAudioRow.Value, nmDAudioNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDAudioRow.Value, nmDAudioNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram500L.Value].Value2 != null)
            {
                Audiogram500L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram500L.Value].Value2.ToString();
            }
            else
            {
                Audiogram500L = "";
            }
            Audiogram500L = Audiogram500L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram1000L.Value].Value2 != null)
            {
                Audiogram1000L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram1000L.Value].Value2.ToString();
            }
            else
            {
                Audiogram1000L = "";
            }
            Audiogram1000L = Audiogram1000L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram2000L.Value].Value2 != null)
            {
                Audiogram2000L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram2000L.Value].Value2.ToString();
            }
            else
            {
                Audiogram2000L = "";
            }
            Audiogram2000L = Audiogram2000L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram3000L.Value].Value2 != null)
            {
                Audiogram3000L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram3000L.Value].Value2.ToString();
            }
            else
            {
                Audiogram3000L = "";
            }
            Audiogram3000L = Audiogram3000L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram4000L.Value].Value2 != null)
            {
                Audiogram4000L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram4000L.Value].Value2.ToString();
            }
            else
            {
                Audiogram4000L = "";
            }
            Audiogram4000L = Audiogram4000L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram6000L.Value].Value2 != null)
            {
                Audiogram6000L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram6000L.Value].Value2.ToString();
            }
            else
            {
                Audiogram6000L = "";
            }
            Audiogram6000L = Audiogram6000L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram8000L.Value].Value2 != null)
            {
                Audiogram8000L = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram8000L.Value].Value2.ToString();
            }
            else
            {
                Audiogram8000L = "";
            }
            Audiogram8000L = Audiogram8000L.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogramSummaryL.Value].Value2 != null)
            {
                AudiogramSummaryL = xlRange.Cells[nmDAudioRow.Value, nmDAudiogramSummaryL.Value].Value2.ToString();
            }
            else
            {
                AudiogramSummaryL = "";
            }
            AudiogramSummaryL = AudiogramSummaryL.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram500R.Value].Value2 != null)
            {
                Audiogram500R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram500R.Value].Value2.ToString();
            }
            else
            {
                Audiogram500R = "";
            }
            Audiogram500R = Audiogram500R.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram1000R.Value].Value2 != null)
            {
                Audiogram1000R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram1000R.Value].Value2.ToString();
            }
            else
            {
                Audiogram1000R = "";
            }
            Audiogram1000R = Audiogram1000R.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram2000R.Value].Value2 != null)
            {
                Audiogram2000R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram2000R.Value].Value2.ToString();
            }
            else
            {
                Audiogram2000R = "";
            }
            Audiogram2000R = Audiogram2000R.Trim();

            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram3000R.Value].Value2 != null)
            {
                Audiogram3000R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram3000R.Value].Value2.ToString();
            }
            else
            {
                Audiogram3000R = "";
            }
            Audiogram3000R = Audiogram3000R.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram4000R.Value].Value2 != null)
            {
                Audiogram4000R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram4000R.Value].Value2.ToString();
            }
            else
            {
                Audiogram4000R = "";
            }
            Audiogram4000R = Audiogram4000R.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram6000R.Value].Value2 != null)
            {
                Audiogram6000R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram6000R.Value].Value2.ToString();
            }
            else
            {
                Audiogram6000R = "";
            }
            Audiogram6000R = Audiogram6000R.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogram8000R.Value].Value2 != null)
            {
                Audiogram8000R = xlRange.Cells[nmDAudioRow.Value, nmDAudiogram8000R.Value].Value2.ToString();
            }
            else
            {
                Audiogram8000R = "";
            }
            Audiogram8000R = Audiogram8000R.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogramSummaryR.Value].Value2 != null)
            {
                AudiogramSummaryR = xlRange.Cells[nmDAudioRow.Value, nmDAudiogramSummaryR.Value].Value2.ToString();
            }
            else
            {
                AudiogramSummaryR = "";
            }
            AudiogramSummaryR = AudiogramSummaryR.Trim();
            if (xlRange.Cells[nmDAudioRow.Value, nmDAudiogramExam.Value].Value2 != null)
            {
                AudiogramExam = xlRange.Cells[nmDAudioRow.Value, nmDAudiogramExam.Value].Value2.ToString();
            }
            else
            {
                AudiogramExam = "";
            }
            AudiogramExam = AudiogramExam.Trim();
            txtAudioTest.Text = "ลำดับ " + No + " Audiogram500L " + Audiogram500L + " Audiogram1000L " + Audiogram1000L + " Audiogram2000L " + Audiogram2000L + " Audiogram3000L " + Audiogram3000L + " Audiogram4000L " + Audiogram4000L + " Audiogram6000L " + Audiogram6000L + " Audiogram8000L " + Audiogram8000L +
                " AudiogramSummaryL " + AudiogramSummaryL + " Audiogram500R " + Audiogram500R + " Audiogram1000R " + Audiogram1000R + " Audiogram2000R " + Audiogram2000R + " Audiogram3000R " + Audiogram3000R + " Audiogram4000R " + Audiogram4000R + " Audiogram6000R " + Audiogram6000R + " Audiogram8000R " + Audiogram8000R + " AudiogramSummaryR " + AudiogramSummaryR + " AudiogramSummary " + AudiogramExam;

            Cursor.Current = cursor;
            if (cc.eidb.updateAudioGram(nmDAudioRow.Value.ToString(), nmDAudioNo.Value.ToString(),nmDAudiogram500L.Value.ToString(), nmDAudiogram500R.Value.ToString(), nmDAudiogram1000L.Value.ToString(), nmDAudiogram1000R.Value.ToString(),
                nmDAudiogram2000L.Value.ToString(), nmDAudiogram2000R.Value.ToString(), nmDAudiogram3000L.Value.ToString(), nmDAudiogram3000R.Value.ToString(), nmDAudiogram4000L.Value.ToString(), nmDAudiogram4000R.Value.ToString(),
                nmDAudiogram6000L.Value.ToString(), nmDAudiogram6000R.Value.ToString(), nmDAudiogram8000L.Value.ToString(), nmDAudiogram8000R.Value.ToString(), nmDAudiogramSummaryL.Value.ToString(), nmDAudiogramSummaryR.Value.ToString(), 
                nmDAudiogramExam.Value.ToString(),txtAudioSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล AudioGram เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveEye()
        {
            String No = "", EyeShortLongLeft = "", EyeShortLongRight = "", EyeSquintLeft = "", EyeSquintRight = "", EyedegreeLeft = "", EyeDegreeRight = "", EyeOldLeft = "", EyeOldRight = "", EyeBlindness = "", EyeResult = "", EyeSummary = "", EyeExam="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtEyeSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDEyeRow.Value, nmDEyeNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeShortLongLeft.Value].Value2 != null)
            {
                EyeShortLongLeft = xlRange.Cells[nmDEyeRow.Value, nmDEyeShortLongLeft.Value].Value2.ToString();
            }
            else
            {
                EyeShortLongLeft = "";
            }
            EyeShortLongLeft = EyeShortLongLeft.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeShortLongRight.Value].Value2 != null)
            {
                EyeShortLongRight = xlRange.Cells[nmDEyeRow.Value, nmDEyeShortLongRight.Value].Value2.ToString();
            }
            else
            {
                EyeShortLongRight = "";
            }
            EyeShortLongRight = EyeShortLongRight.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeSquintLeft.Value].Value2 != null)
            {
                EyeSquintLeft = xlRange.Cells[nmDEyeRow.Value, nmDEyeSquintLeft.Value].Value2.ToString();
            }
            else
            {
                EyeSquintLeft = "";
            }
            EyeSquintLeft = EyeSquintLeft.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeSquintRight.Value].Value2 != null)
            {
                EyeSquintRight = xlRange.Cells[nmDEyeRow.Value, nmDEyeSquintRight.Value].Value2.ToString();
            }
            else
            {
                EyeSquintRight = "";
            }
            EyeSquintRight = EyeSquintRight.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeDegreeLeft.Value].Value2 != null)
            {
                EyedegreeLeft = xlRange.Cells[nmDEyeRow.Value, nmDEyeDegreeLeft.Value].Value2.ToString();
            }
            else
            {
                EyedegreeLeft = "";
            }
            EyedegreeLeft = EyedegreeLeft.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeDegreeRight.Value].Value2 != null)
            {
                EyeDegreeRight = xlRange.Cells[nmDEyeRow.Value, nmDEyeDegreeRight.Value].Value2.ToString();
            }
            else
            {
                EyeDegreeRight = "";
            }
            EyeDegreeRight = EyeDegreeRight.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeOldLeft.Value].Value2 != null)
            {
                EyeOldLeft = xlRange.Cells[nmDEyeRow.Value, nmDEyeOldLeft.Value].Value2.ToString();
            }
            else
            {
                EyeOldLeft = "";
            }
            EyeOldLeft = EyeOldLeft.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeOldRight.Value].Value2 != null)
            {
                EyeOldRight = xlRange.Cells[nmDEyeRow.Value, nmDEyeOldRight.Value].Value2.ToString();
            }
            else
            {
                EyeOldRight = "";
            }
            EyeOldRight = EyeOldRight.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeBlindness.Value].Value2 != null)
            {
                EyeBlindness = xlRange.Cells[nmDEyeRow.Value, nmDEyeBlindness.Value].Value2.ToString();
            }
            else
            {
                EyeBlindness = "";
            }
            EyeBlindness = EyeBlindness.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeResult.Value].Value2 != null)
            {
                EyeResult = xlRange.Cells[nmDEyeRow.Value, nmDEyeResult.Value].Value2.ToString();
            }
            else
            {
                EyeResult = "";
            }
            EyeResult = EyeResult.Trim();
            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeSummary.Value].Value2 != null)
            {
                EyeSummary = xlRange.Cells[nmDEyeRow.Value, nmDEyeSummary.Value].Value2.ToString();
            }
            else
            {
                EyeSummary = "";
            }
            EyeSummary = EyeSummary.Trim();

            if (xlRange.Cells[nmDEyeRow.Value, nmDEyeExam.Value].Value2 != null)
            {
                EyeExam = xlRange.Cells[nmDEyeRow.Value, nmDEyeExam.Value].Value2.ToString();
            }
            else
            {
                EyeExam = "";
            }
            EyeExam = EyeExam.Trim();


            txtEyeTest.Text = "ลำดับ " + No + " EyeShortLongLeft " + EyeShortLongLeft + " EyeShortLongRight " + EyeShortLongRight + " EyeSquintLeft " + EyeSquintLeft + " EyeSquintRight " + EyeSquintRight + " EyedegreeLeft " + EyedegreeLeft + " EyeDegreeRight " + EyeDegreeRight + " EyeOldLeft " + EyeOldLeft +
                " EyeOldRight " + EyeOldRight + " EyeBlindness " + EyeBlindness + " EyeResult " + EyeResult + " EyeSummary " + EyeSummary + " EyeExam " + EyeExam;

            Cursor.Current = cursor;
            if (cc.eidb.updateEye(nmDEyeRow.Value.ToString(), nmDEyeNo.Value.ToString(), nmDEyeShortLongLeft.Value.ToString(), nmDEyeShortLongRight.Value.ToString(), nmDEyeSquintLeft.Value.ToString(), 
                nmDEyeSquintRight.Value.ToString(),
                nmDEyeDegreeLeft.Value.ToString(), nmDEyeDegreeRight.Value.ToString(), nmDEyeOldLeft.Value.ToString(), nmDEyeOldRight.Value.ToString(), nmDEyeResult.Value.ToString(),
                nmDEyeSummary.Value.ToString(), nmDEyeBlindness.Value.ToString(), nmDEyeExam.Value.ToString(),txtEyeSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Eye เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveToxi1()
        {
            String toxiRow = "", toxiNo = "";//, LungFvcPredic = "", LungFvcMeas = "", LungFvcPer = "", LungFev1Predic = "", LungFev1Meas = "", LungFev1Per = "", LungPerFev1 = "", LungSummary = "";
            
            String ToxiLead = "", ToxiAluminium = "", ToxiCadmium = "", ToxiMercury = "", ToxiTin = "", ToxiCopper = "", ToxiManganese = "", ToxiZinc = "", ToxiAmmonia = "";
            //String ToxiHippuric = "", ToxiMethyl = "", ToxiAcetone = "", ToxiNickel = "", ToxiChromium = "", ToxiPhenol = "", ToxiKetone = "", ToxiBenzene = "", ToxiMandelic = "", ToxiMethanol = "";
            //String ToxiEthanol = "", ToxiIPA = "", ToxiArsenic = "", ToxiHexane = "", ToxiFomaldehyde = "", ToxiTrichloroethylene = "", ToxiAntimony = "", ToxiFluoride = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtToxiSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiNo.Value].Value2 != null)
            {
                toxiNo = xlRange.Cells[nmDToxiRow.Value, nmDToxiNo.Value].Value2.ToString();
            }
            else
            {
                toxiNo = "";
            }
            toxiNo = toxiNo.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiLead.Value].Value2 != null)
            {
                ToxiLead = xlRange.Cells[nmDToxiRow.Value, nmDToxiLead.Value].Value2.ToString();
            }
            else
            {
                ToxiLead = "";
            }
            ToxiLead = ToxiLead.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAluminium.Value].Value2 != null)
            {
                ToxiAluminium = xlRange.Cells[nmDToxiRow.Value, nmDToxiAluminium.Value].Value2.ToString();
            }
            else
            {
                ToxiAluminium = "";
            }
            ToxiAluminium = ToxiAluminium.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiCadmium.Value].Value2 != null)
            {
                ToxiCadmium = xlRange.Cells[nmDToxiRow.Value, nmDToxiCadmium.Value].Value2.ToString();
            }
            else
            {
                ToxiCadmium = "";
            }
            ToxiCadmium = ToxiCadmium.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMercury.Value].Value2 != null)
            {
                ToxiMercury = xlRange.Cells[nmDToxiRow.Value, nmDToxiMercury.Value].Value2.ToString();
            }
            else
            {
                ToxiMercury = "";
            }
            ToxiMercury = ToxiMercury.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiTin.Value].Value2 != null)
            {
                ToxiTin = xlRange.Cells[nmDToxiRow.Value, nmDToxiTin.Value].Value2.ToString();
            }
            else
            {
                ToxiTin = "";
            }
            ToxiTin = ToxiTin.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiCopper.Value].Value2 != null)
            {
                ToxiCopper = xlRange.Cells[nmDToxiRow.Value, nmDToxiCopper.Value].Value2.ToString();
            }
            else
            {
                ToxiCopper = "";
            }
            ToxiCopper = ToxiCopper.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiManganese.Value].Value2 != null)
            {
                ToxiManganese = xlRange.Cells[nmDToxiRow.Value, nmDToxiManganese.Value].Value2.ToString();
            }
            else
            {
                ToxiManganese = "";
            }
            ToxiManganese = ToxiManganese.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiZinc.Value].Value2 != null)
            {
                ToxiZinc = xlRange.Cells[nmDToxiRow.Value, nmDToxiZinc.Value].Value2.ToString();
            }
            else
            {
                ToxiZinc = "";
            }
            ToxiZinc = ToxiZinc.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAmmonia.Value].Value2 != null)
            {
                ToxiAmmonia = xlRange.Cells[nmDToxiRow.Value, nmDToxiAmmonia.Value].Value2.ToString();
            }
            else
            {
                ToxiAmmonia = "";
            }
            ToxiAmmonia = ToxiAmmonia.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiHippuric.Value].Value2 != null)
            //{
            //    ToxiHippuric = xlRange.Cells[nmDToxiRow.Value, nmDToxiHippuric.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiHippuric = "";
            //}
            //ToxiHippuric = ToxiHippuric.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMethyl.Value].Value2 != null)
            //{
            //    ToxiMethyl = xlRange.Cells[nmDToxiRow.Value, nmDToxiMethyl.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiMethyl = "";
            //}
            //ToxiMethyl = ToxiMethyl.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAcetone.Value].Value2 != null)
            //{
            //    ToxiAcetone = xlRange.Cells[nmDToxiRow.Value, nmDToxiAcetone.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiAcetone = "";
            //}
            //ToxiAcetone = ToxiAcetone.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiNickel.Value].Value2 != null)
            //{
            //    ToxiNickel = xlRange.Cells[nmDToxiRow.Value, nmDToxiNickel.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiNickel = "";
            //}
            //ToxiNickel = ToxiNickel.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiChromium.Value].Value2 != null)
            //{
            //    ToxiChromium = xlRange.Cells[nmDToxiRow.Value, nmDToxiChromium.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiChromium = "";
            //}
            //ToxiChromium = ToxiChromium.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiPhenol.Value].Value2 != null)
            //{
            //    ToxiPhenol = xlRange.Cells[nmDToxiRow.Value, nmDToxiPhenol.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiPhenol = "";
            //}
            //ToxiPhenol = ToxiPhenol.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiKetone.Value].Value2 != null)
            //{
            //    ToxiKetone = xlRange.Cells[nmDToxiRow.Value, nmDToxiKetone.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiKetone = "";
            //}
            //ToxiKetone = ToxiKetone.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiBenzene.Value].Value2 != null)
            //{
            //    ToxiBenzene = xlRange.Cells[nmDToxiRow.Value, nmDToxiBenzene.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiBenzene = "";
            //}
            //ToxiBenzene = ToxiBenzene.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMandelic.Value].Value2 != null)
            //{
            //    ToxiMandelic = xlRange.Cells[nmDToxiRow.Value, nmDToxiMandelic.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiMandelic = "";
            //}
            //ToxiMandelic = ToxiMandelic.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMethanol.Value].Value2 != null)
            //{
            //    ToxiMethanol = xlRange.Cells[nmDToxiRow.Value, nmDToxiMethanol.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiMethanol = "";
            //}
            //ToxiMethanol = ToxiMethanol.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiEthanol.Value].Value2 != null)
            //{
            //    ToxiEthanol = xlRange.Cells[nmDToxiRow.Value, nmDToxiEthanol.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiEthanol = "";
            //}
            //ToxiEthanol = ToxiEthanol.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiIPA.Value].Value2 != null)
            //{
            //    ToxiIPA = xlRange.Cells[nmDToxiRow.Value, nmDToxiIPA.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiIPA = "";
            //}
            //ToxiIPA = ToxiIPA.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiArsenic.Value].Value2 != null)
            //{
            //    ToxiArsenic = xlRange.Cells[nmDToxiRow.Value, nmDToxiArsenic.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiArsenic = "";
            //}
            //ToxiArsenic = ToxiArsenic.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiHexane.Value].Value2 != null)
            //{
            //    ToxiHexane = xlRange.Cells[nmDToxiRow.Value, nmDToxiHexane.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiHexane = "";
            //}
            //ToxiHexane = ToxiHexane.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiFomaldehyde.Value].Value2 != null)
            //{
            //    ToxiFomaldehyde = xlRange.Cells[nmDToxiRow.Value, nmDToxiFomaldehyde.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiFomaldehyde = "";
            //}
            //ToxiFomaldehyde = ToxiFomaldehyde.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiTrichloroethylene.Value].Value2 != null)
            //{
            //    ToxiTrichloroethylene = xlRange.Cells[nmDToxiRow.Value, nmDToxiTrichloroethylene.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiTrichloroethylene = "";
            //}
            //ToxiTrichloroethylene = ToxiTrichloroethylene.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAntimony.Value].Value2 != null)
            //{
            //    ToxiAntimony = xlRange.Cells[nmDToxiRow.Value, nmDToxiAntimony.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiAntimony = "";
            //}
            //ToxiAntimony = ToxiAntimony.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiFluoride.Value].Value2 != null)
            //{
            //    ToxiFluoride = xlRange.Cells[nmDToxiRow.Value, nmDToxiFluoride.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiFluoride = "";
            //}
            //ToxiFluoride = ToxiFluoride.Trim();
            txtToxi1Test.Text = "ลำดับ " + toxiNo + " ToxiLead " + ToxiLead + " ToxiAluminium " + ToxiAluminium + " ToxiCadmium " + ToxiCadmium +
                " ToxiMercury " + ToxiMercury + " ToxiTin " + ToxiTin + " ToxiCopper " + ToxiCopper + " ToxiManganese " + ToxiManganese + " ToxiZinc " + ToxiZinc +
                " ToxiAmmonia " + ToxiAmmonia;

            Cursor.Current = cursor;
            if (cc.eidb.updateToxi1(nmDToxiRow.Value.ToString(), nmDToxiNo.Value.ToString(), nmDToxiLead.Value.ToString(), nmDToxiAluminium.Value.ToString(),
                nmDToxiCadmium.Value.ToString(), nmDToxiMercury.Value.ToString(), nmDToxiTin.Value.ToString(), nmDToxiCopper.Value.ToString(),
                nmDToxiManganese.Value.ToString(), nmDToxiZinc.Value.ToString(), nmDToxiAmmonia.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Toxi1 เรียบร้อย", "บันทึกข้อมูล");
            }
            //if (cc.eidb.updateToxi2(nmDToxiHippuric.Value.ToString(), nmDToxiMethyl.Value.ToString(), nmDToxiAcetone.Value.ToString(), nmDToxiNickel.Value.ToString(),
            //    nmDToxiChromium.Value.ToString(), nmDToxiPhenol.Value.ToString(), nmDToxiKetone.Value.ToString(), nmDToxiBenzene.Value.ToString(),
            //    nmDToxiMandelic.Value.ToString(), nmDToxiMethanol.Value.ToString(), nmDToxiEthanol.Value.ToString(), nmDToxiIPA.Value.ToString(), nmDToxiArsenic.Value.ToString(),
            //    nmDToxiHexane.Value.ToString(), nmDToxiFomaldehyde.Value.ToString(), nmDToxiTrichloroethylene.Value.ToString(), nmDToxiAntimony.Value.ToString(), nmDToxiFluoride.Value.ToString()).Length >= 1)
            //{
            //    MessageBox.Show("บันทึกข้อมูล Toxi เรียบร้อย", "บันทึกข้อมูล");
            //}
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveToxi2()
        {
            String toxiRow = "", toxiNo = "";//, LungFvcPredic = "", LungFvcMeas = "", LungFvcPer = "", LungFev1Predic = "", LungFev1Meas = "", LungFev1Per = "", LungPerFev1 = "", LungSummary = "";

            //String ToxiLead = "", ToxiAluminium = "", ToxiCadmium = "", ToxiMercury = "", ToxiTin = "", ToxiCopper = "", ToxiManganese = "", ToxiZinc = "", ToxiAmmonia = "";
            String ToxiHippuric = "", ToxiMethyl = "", ToxiAcetone = "", ToxiNickel = "", ToxiChromium = "", ToxiPhenol = "", ToxiKetone = "", ToxiBenzene = "", ToxiMandelic = "", ToxiMethanol = "";
            String ToxiEthanol = "", ToxiIPA = "", ToxiArsenic = "", ToxiHexane = "", ToxiFomaldehyde = "", ToxiTrichloroethylene = "", ToxiAntimony = "", ToxiFluoride = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtToxiSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiNo.Value].Value2 != null)
            {
                toxiNo = xlRange.Cells[nmDToxiRow.Value, nmDToxiNo.Value].Value2.ToString();
            }
            else
            {
                toxiNo = "";
            }
            toxiNo = toxiNo.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiLead.Value].Value2 != null)
            //{
            //    ToxiLead = xlRange.Cells[nmDToxiRow.Value, nmDToxiLead.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiLead = "";
            //}
            //ToxiLead = ToxiLead.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAluminium.Value].Value2 != null)
            //{
            //    ToxiAluminium = xlRange.Cells[nmDToxiRow.Value, nmDToxiAluminium.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiAluminium = "";
            //}
            //ToxiAluminium = ToxiAluminium.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiCadmium.Value].Value2 != null)
            //{
            //    ToxiCadmium = xlRange.Cells[nmDToxiRow.Value, nmDToxiCadmium.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiCadmium = "";
            //}
            //ToxiCadmium = ToxiCadmium.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMercury.Value].Value2 != null)
            //{
            //    ToxiMercury = xlRange.Cells[nmDToxiRow.Value, nmDToxiMercury.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiMercury = "";
            //}
            //ToxiMercury = ToxiMercury.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiTin.Value].Value2 != null)
            //{
            //    ToxiTin = xlRange.Cells[nmDToxiRow.Value, nmDToxiTin.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiTin = "";
            //}
            //ToxiTin = ToxiTin.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiCopper.Value].Value2 != null)
            //{
            //    ToxiCopper = xlRange.Cells[nmDToxiRow.Value, nmDToxiCopper.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiCopper = "";
            //}
            //ToxiCopper = ToxiCopper.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiManganese.Value].Value2 != null)
            //{
            //    ToxiManganese = xlRange.Cells[nmDToxiRow.Value, nmDToxiManganese.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiManganese = "";
            //}
            //ToxiManganese = ToxiManganese.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiZinc.Value].Value2 != null)
            //{
            //    ToxiZinc = xlRange.Cells[nmDToxiRow.Value, nmDToxiZinc.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiZinc = "";
            //}
            //ToxiZinc = ToxiZinc.Trim();
            //if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAmmonia.Value].Value2 != null)
            //{
            //    ToxiAmmonia = xlRange.Cells[nmDToxiRow.Value, nmDToxiAmmonia.Value].Value2.ToString();
            //}
            //else
            //{
            //    ToxiAmmonia = "";
            //}
            //ToxiAmmonia = ToxiAmmonia.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiHippuric.Value].Value2 != null)
            {
                ToxiHippuric = xlRange.Cells[nmDToxiRow.Value, nmDToxiHippuric.Value].Value2.ToString();
            }
            else
            {
                ToxiHippuric = "";
            }
            ToxiHippuric = ToxiHippuric.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMethyl.Value].Value2 != null)
            {
                ToxiMethyl = xlRange.Cells[nmDToxiRow.Value, nmDToxiMethyl.Value].Value2.ToString();
            }
            else
            {
                ToxiMethyl = "";
            }
            ToxiMethyl = ToxiMethyl.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAcetone.Value].Value2 != null)
            {
                ToxiAcetone = xlRange.Cells[nmDToxiRow.Value, nmDToxiAcetone.Value].Value2.ToString();
            }
            else
            {
                ToxiAcetone = "";
            }
            ToxiAcetone = ToxiAcetone.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiNickel.Value].Value2 != null)
            {
                ToxiNickel = xlRange.Cells[nmDToxiRow.Value, nmDToxiNickel.Value].Value2.ToString();
            }
            else
            {
                ToxiNickel = "";
            }
            ToxiNickel = ToxiNickel.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiChromium.Value].Value2 != null)
            {
                ToxiChromium = xlRange.Cells[nmDToxiRow.Value, nmDToxiChromium.Value].Value2.ToString();
            }
            else
            {
                ToxiChromium = "";
            }
            ToxiChromium = ToxiChromium.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiPhenol.Value].Value2 != null)
            {
                ToxiPhenol = xlRange.Cells[nmDToxiRow.Value, nmDToxiPhenol.Value].Value2.ToString();
            }
            else
            {
                ToxiPhenol = "";
            }
            ToxiPhenol = ToxiPhenol.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiKetone.Value].Value2 != null)
            {
                ToxiKetone = xlRange.Cells[nmDToxiRow.Value, nmDToxiKetone.Value].Value2.ToString();
            }
            else
            {
                ToxiKetone = "";
            }
            ToxiKetone = ToxiKetone.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiBenzene.Value].Value2 != null)
            {
                ToxiBenzene = xlRange.Cells[nmDToxiRow.Value, nmDToxiBenzene.Value].Value2.ToString();
            }
            else
            {
                ToxiBenzene = "";
            }
            ToxiBenzene = ToxiBenzene.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMandelic.Value].Value2 != null)
            {
                ToxiMandelic = xlRange.Cells[nmDToxiRow.Value, nmDToxiMandelic.Value].Value2.ToString();
            }
            else
            {
                ToxiMandelic = "";
            }
            ToxiMandelic = ToxiMandelic.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiMethanol.Value].Value2 != null)
            {
                ToxiMethanol = xlRange.Cells[nmDToxiRow.Value, nmDToxiMethanol.Value].Value2.ToString();
            }
            else
            {
                ToxiMethanol = "";
            }
            ToxiMethanol = ToxiMethanol.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiEthanol.Value].Value2 != null)
            {
                ToxiEthanol = xlRange.Cells[nmDToxiRow.Value, nmDToxiEthanol.Value].Value2.ToString();
            }
            else
            {
                ToxiEthanol = "";
            }
            ToxiEthanol = ToxiEthanol.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiIPA.Value].Value2 != null)
            {
                ToxiIPA = xlRange.Cells[nmDToxiRow.Value, nmDToxiIPA.Value].Value2.ToString();
            }
            else
            {
                ToxiIPA = "";
            }
            ToxiIPA = ToxiIPA.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiArsenic.Value].Value2 != null)
            {
                ToxiArsenic = xlRange.Cells[nmDToxiRow.Value, nmDToxiArsenic.Value].Value2.ToString();
            }
            else
            {
                ToxiArsenic = "";
            }
            ToxiArsenic = ToxiArsenic.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiHexane.Value].Value2 != null)
            {
                ToxiHexane = xlRange.Cells[nmDToxiRow.Value, nmDToxiHexane.Value].Value2.ToString();
            }
            else
            {
                ToxiHexane = "";
            }
            ToxiHexane = ToxiHexane.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiFomaldehyde.Value].Value2 != null)
            {
                ToxiFomaldehyde = xlRange.Cells[nmDToxiRow.Value, nmDToxiFomaldehyde.Value].Value2.ToString();
            }
            else
            {
                ToxiFomaldehyde = "";
            }
            ToxiFomaldehyde = ToxiFomaldehyde.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiTrichloroethylene.Value].Value2 != null)
            {
                ToxiTrichloroethylene = xlRange.Cells[nmDToxiRow.Value, nmDToxiTrichloroethylene.Value].Value2.ToString();
            }
            else
            {
                ToxiTrichloroethylene = "";
            }
            ToxiTrichloroethylene = ToxiTrichloroethylene.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiAntimony.Value].Value2 != null)
            {
                ToxiAntimony = xlRange.Cells[nmDToxiRow.Value, nmDToxiAntimony.Value].Value2.ToString();
            }
            else
            {
                ToxiAntimony = "";
            }
            ToxiAntimony = ToxiAntimony.Trim();
            if (xlRange.Cells[nmDToxiRow.Value, nmDToxiFluoride.Value].Value2 != null)
            {
                ToxiFluoride = xlRange.Cells[nmDToxiRow.Value, nmDToxiFluoride.Value].Value2.ToString();
            }
            else
            {
                ToxiFluoride = "";
            }
            ToxiFluoride = ToxiFluoride.Trim();
            txtToxi2Test.Text = " ToxiHippuric " + ToxiHippuric + " ToxiMethyl " + ToxiMethyl + " ToxiAcetone " + ToxiAcetone + " ToxiNickel " + ToxiNickel +
                " ToxiChromium " + ToxiChromium + " ToxiPhenol " + ToxiPhenol + " ToxiKetone " + ToxiKetone + " ToxiBenzene " + ToxiBenzene + " ToxiMandelic " + ToxiMandelic +
                " ToxiMethanol " + ToxiMethanol + " ToxiEthanol " + ToxiEthanol + " ToxiIPA " + ToxiIPA + " ToxiArsenic " + ToxiArsenic + " ToxiHexane " + ToxiHexane +
                " ToxiFomaldehyde " + ToxiFomaldehyde + " ToxiTrichloroethylene " + ToxiTrichloroethylene + " ToxiAntimony " + ToxiAntimony + " ToxiFluoride " + ToxiFluoride;

            Cursor.Current = cursor;
            //if (cc.eidb.updateToxi1(nmDToxiRow.Value.ToString(), nmDToxiNo.Value.ToString(), nmDToxiLead.Value.ToString(), nmDToxiAluminium.Value.ToString(),
            //    nmDToxiCadmium.Value.ToString(), nmDToxiMercury.Value.ToString(), nmDToxiTin.Value.ToString(), nmDToxiCopper.Value.ToString(),
            //    nmDToxiManganese.Value.ToString(), nmDToxiZinc.Value.ToString(), nmDToxiAmmonia.Value.ToString()).Length >= 1)
            //{
            //    MessageBox.Show("บันทึกข้อมูล Toxi เรียบร้อย", "บันทึกข้อมูล");
            //}
            if (cc.eidb.updateToxi2(nmDToxiHippuric.Value.ToString(), nmDToxiMethyl.Value.ToString(), nmDToxiAcetone.Value.ToString(), nmDToxiNickel.Value.ToString(),
                nmDToxiChromium.Value.ToString(), nmDToxiPhenol.Value.ToString(), nmDToxiKetone.Value.ToString(), nmDToxiBenzene.Value.ToString(),
                nmDToxiMandelic.Value.ToString(), nmDToxiMethanol.Value.ToString(), nmDToxiEthanol.Value.ToString(), nmDToxiIPA.Value.ToString(), nmDToxiArsenic.Value.ToString(),
                nmDToxiHexane.Value.ToString(), nmDToxiFomaldehyde.Value.ToString(), nmDToxiTrichloroethylene.Value.ToString(), nmDToxiAntimony.Value.ToString(), 
                nmDToxiFluoride.Value.ToString(),txtToxiSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล Toxi2 เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void FrmExcelInit_Load(object sender, EventArgs e)
        {

        }

        private void btnSfExcel_Click(object sender, EventArgs e)
        {
            String prefix = "", No="", FirstName="", LastName="", Age="", FullName="", AllName="", StatusSf="",department="", patientNumber="";
            if ((!chkA.Checked) &&(!chkB.Checked)&&(!chkC.Checked))
            {
                MessageBox.Show("เลือกประเภทคำนำหน้าชื่อ ", "เลือกข้อมูล");
                return;
            }
            //if (txtStaffCode.Text.Equals(""))
            //{
            //    MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
            //    return;
            //}
            //if (txtStaffId.Text.Equals(""))
            //{

            //}
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[ei.PESheetname];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDRow.Value, nmDDepartment.Value].Value2 != null)
            {
                department = xlRange.Cells[nmDRow.Value, nmDDepartment.Value].Value2.ToString();
            }
            else
            {
                department = "";
            }
            if (xlRange.Cells[nmDRow.Value, nmDPatientNumber.Value].Value2 != null)
            {
                patientNumber = xlRange.Cells[nmDRow.Value, nmDPatientNumber.Value].Value2.ToString();
            }
            else
            {
                patientNumber = "";
            }

            if (chkA.Checked)
            {
                StatusSf = "A";
                if (xlRange.Cells[nmDRow.Value, nmDARow.Value].Value2 != null)
                {
                    No = xlRange.Cells[nmDRow.Value, nmDARow.Value].Value2.ToString();
                }
                else
                {
                    No = "";
                }
                if (xlRange.Cells[nmDRow.Value, nmDAPrefix.Value].Value2 != null)
                {
                    prefix = xlRange.Cells[nmDRow.Value, nmDAPrefix.Value].Value2.ToString();
                }
                else
                {
                    prefix = "";
                }
                prefix = prefix.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDAFirstName.Value].Value2 != null)
                {
                    FirstName = xlRange.Cells[nmDRow.Value, nmDAFirstName.Value].Value2.ToString();
                }
                else
                {
                    FirstName = "";
                }
                FirstName = FirstName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2 != null)
                {
                    LastName = xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2.ToString();
                }
                else
                {
                    LastName = "";
                }
                LastName = LastName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDAAge.Value].Value2 != null)
                {
                    Age = xlRange.Cells[nmDRow.Value, nmDAAge.Value].Value2.ToString();
                }
                else
                {
                    Age = "";
                }
                LastName = LastName.Trim();
                txtPrefixTest.Text = "ลำดับ " + No + " ชื่อ นามสกุล " + prefix + " " + FirstName + " " + LastName + " อายุ " + Age + " " + " แผนก " + department + " รหัสพนักงาน " + patientNumber;
                Cursor.Current = cursor;
                if (cc.eidb.updateSfA(nmDAAge.Value.ToString(), nmDAPrefix.Value.ToString(), nmDAFirstName.Value.ToString(), nmDALastName.Value.ToString(),
                    nmDARow.Value.ToString(), nmDRow.Value.ToString(), nmDDepartment.Value.ToString(), nmDPatientNumber.Value.ToString()).Length >= 1)
                {
                    ei = cc.eidb.selectByPk();
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                }
            }
            else if (chkB.Checked)
            {
                StatusSf = "B";
                if (xlRange.Cells[nmDRow.Value, nmDBRow.Value].Value2 != null)
                {
                    No = xlRange.Cells[nmDRow.Value, nmDBRow.Value].Value2.ToString();
                }
                else
                {
                    No = "";
                }
                if (xlRange.Cells[nmDRow.Value, nmDBPrefix.Value].Value2 != null)
                {
                    prefix = xlRange.Cells[nmDRow.Value, nmDBPrefix.Value].Value2.ToString();
                }
                else
                {
                    prefix = "";
                }
                prefix = prefix.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDBFullName.Value].Value2 != null)
                {
                    FullName = xlRange.Cells[nmDRow.Value, nmDBFullName.Value].Value2.ToString();
                }
                else
                {
                    FullName = "";
                }
                FullName = FullName.Trim();
                //if (xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2 != null)
                //{
                //    LastName = xlRange.Cells[nmDRow.Value, nmDALastName.Value].Value2.ToString();
                //}
                //else
                //{
                //    LastName = "";
                //}
                //LastName = LastName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDBAge.Value].Value2 != null)
                {
                    Age = xlRange.Cells[nmDRow.Value, nmDBAge.Value].Value2.ToString();
                }
                else
                {
                    Age = "";
                }
                LastName = LastName.Trim();
                txtPrefixTest.Text = "ลำดับ " + No + " ชื่อ นามสกุล " + prefix + " " + FullName + " อายุ " + Age + " " + " แผนก " + department;
                Cursor.Current = cursor;
                if (cc.eidb.updateSfB(nmDBAge.Value.ToString(), nmDBPrefix.Value.ToString(), nmDBFullName.Value.ToString(), nmDBRow.Value.ToString(), nmDRow.Value.ToString(), nmDDepartment.Value.ToString(), nmDPatientNumber.Value.ToString()).Length >= 1)
                {
                    ei = cc.eidb.selectByPk();
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                }
            }
            else if (chkC.Checked)
            {
                StatusSf = "C";
                if (xlRange.Cells[nmDRow.Value, nmDCRow.Value].Value2 != null)
                {
                    No = xlRange.Cells[nmDRow.Value, nmDCRow.Value].Value2.ToString();
                }
                else
                {
                    No = "";
                }
                if (xlRange.Cells[nmDRow.Value, nmDCPrefix.Value].Value2 != null)
                {
                    AllName = xlRange.Cells[nmDRow.Value, nmDCPrefix.Value].Value2.ToString();
                }
                else
                {
                    AllName = "";
                }
                AllName = AllName.Trim();
                if (xlRange.Cells[nmDRow.Value, nmDCAge.Value].Value2 != null)
                {
                    Age = xlRange.Cells[nmDRow.Value, nmDCAge.Value].Value2.ToString();
                }
                else
                {
                    Age = "";
                }
                
                LastName = LastName.Trim();
                txtPrefixTest.Text = "ลำดับ " + No + " ชื่อ นามสกุล " + AllName + " อายุ " + Age + " " + " แผนก " + department;

                Cursor.Current = cursor;
                if (cc.eidb.updateSfC(nmDCAge.Value.ToString(), nmDCPrefix.Value.ToString(), nmDCRow.Value.ToString(), nmDRow.Value.ToString(), nmDDepartment.Value.ToString(), nmDPatientNumber.Value.ToString()).Length >= 1)
                {
                    ei = cc.eidb.selectByPk();
                    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                }
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
            //if (cc.sfdb.insertStaff(s).Length >= 1)
            //{
            //    MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            //    this.Dispose();
            //    this.Hide();
            //}
        }

        private void btnPEExcel_Click(object sender, EventArgs e)
        {
            String No = "", age="", bmi="", height="", weight="", pulse="", vi="", result="", summary="", bloodGroup="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtPESheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDPERow.Value, nmDPENo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDPERow.Value, nmDPENo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEAge.Value].Value2 != null)
            {
                age = xlRange.Cells[nmDPERow.Value, nmDPEAge.Value].Value2.ToString();
            }
            else
            {
                age = "";
            }
            age = age.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEBMI.Value].Value2 != null)
            {
                bmi = xlRange.Cells[nmDPERow.Value, nmDPEBMI.Value].Value2.ToString();
            }
            else
            {
                bmi = "";
            }
            bmi = bmi.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEHeight.Value].Value2 != null)
            {
                height = xlRange.Cells[nmDPERow.Value, nmDPEHeight.Value].Value2.ToString();
            }
            else
            {
                height = "";
            }
            height = height.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEWeight.Value].Value2 != null)
            {
                weight = xlRange.Cells[nmDPERow.Value, nmDPEWeight.Value].Value2.ToString();
            }
            else
            {
                weight = "";
            }
            weight = weight.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEPulse.Value].Value2 != null)
            {
                pulse = xlRange.Cells[nmDPERow.Value, nmDPEPulse.Value].Value2.ToString();
            }
            else
            {
                pulse = "";
            }
            pulse = pulse.Trim();

            if (xlRange.Cells[nmDPERow.Value, nmDPEBloodGroup.Value].Value2 != null)
            {
                bloodGroup = xlRange.Cells[nmDPERow.Value, nmDPEBloodGroup.Value].Value2.ToString();
            }
            else
            {
                bloodGroup = "";
            }
            bloodGroup = bloodGroup.Trim();

            if (xlRange.Cells[nmDPERow.Value, nmDPEVi.Value].Value2 != null)
            {
                vi = xlRange.Cells[nmDPERow.Value, nmDPEVi.Value].Value2.ToString();
            }
            else
            {
                vi = "";
            }
            vi = vi.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPEResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDPERow.Value, nmDPEResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDPESummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDPERow.Value, nmDPESummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtPETest.Text = "ลำดับ " + No + " อายุ " + age + " น้ำหนัก " + weight + " ส่วนสูง " + height + " BMI " + bmi + " VitalSign " + vi + " Pulse " + pulse +
                " Blood Group " + bloodGroup + " Result " + result + " Summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updatePE(nmDPENo.Value.ToString(), nmDPERow.Value.ToString(), nmDPEAge.Value.ToString(), nmDPEBMI.Value.ToString(),
                nmDPEHeight.Value.ToString(), nmDPEWeight.Value.ToString(), nmDPEPulse.Value.ToString(), nmDPEVi.Value.ToString(), nmDPEResult.Value.ToString(),
                nmDPESummary.Value.ToString(), nmDPEBloodGroup.Value.ToString(),txtPESheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล PE เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }
        private void SaveStoolExam()
        {
            String StoolExamRow = "", StoolExamNo = "", StoolExamColor = "", StoolExamAppearance = "", StoolExamWBC = "", StoolExamRBC = "", Parasite = "", StoolExamSummary = "", Culture="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDLungRow.Value, nmDStoolExamNo.Value].Value2 != null)
            {
                StoolExamNo = xlRange.Cells[nmDLungRow.Value, nmDStoolExamNo.Value].Value2.ToString();
            }
            else
            {
                StoolExamNo = "";
            }
            StoolExamNo = StoolExamNo.Trim();
            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamColor.Value].Value2 != null)
            {
                StoolExamColor = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamColor.Value].Value2.ToString();
            }
            else
            {
                StoolExamColor = "";
            }
            StoolExamColor = StoolExamColor.Trim();
            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamAppearance.Value].Value2 != null)
            {
                StoolExamAppearance = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamAppearance.Value].Value2.ToString();
            }
            else
            {
                StoolExamAppearance = "";
            }
            StoolExamAppearance = StoolExamAppearance.Trim();
            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamWBC.Value].Value2 != null)
            {
                StoolExamWBC = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamWBC.Value].Value2.ToString();
            }
            else
            {
                StoolExamWBC = "";
            }
            StoolExamWBC = StoolExamWBC.Trim();
            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamRBC.Value].Value2 != null)
            {
                StoolExamRBC = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamRBC.Value].Value2.ToString();
            }
            else
            {
                StoolExamRBC = "";
            }
            StoolExamRBC = StoolExamRBC.Trim();
            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamParasite.Value].Value2 != null)
            {
                Parasite = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamParasite.Value].Value2.ToString();
            }
            else
            {
                Parasite = "";
            }
            Parasite = Parasite.Trim();

            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamSummary.Value].Value2 != null)
            {
                StoolExamSummary = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamSummary.Value].Value2.ToString();
            }
            else
            {
                StoolExamSummary = "";
            }
            StoolExamSummary = StoolExamSummary.Trim();

            if (xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamCulture.Value].Value2 != null)
            {
                Culture = xlRange.Cells[nmDStoolExamRow.Value, nmDStoolExamCulture.Value].Value2.ToString();
            }
            else
            {
                Culture = "";
            }
            Parasite = Parasite.Trim();

            txtStoolExamTest.Text = "ลำดับ " + StoolExamNo + " Color " + StoolExamColor + " Appearance " + StoolExamAppearance + " WBC " + StoolExamWBC +
                " RBC " + StoolExamRBC + " Parasite " + Parasite + " Culture " + Culture + " Summary " + StoolExamSummary;

            Cursor.Current = cursor;
            if (cc.eidb.updateStoolExam(nmDStoolExamRow.Value.ToString(), nmDStoolExamNo.Value.ToString(), nmDStoolExamAppearance.Value.ToString(), nmDStoolExamColor.Value.ToString(),
                nmDStoolExamWBC.Value.ToString(), nmDStoolExamRBC.Value.ToString(), nmDStoolExamParasite.Value.ToString(), nmDStoolExamSummary.Value.ToString(), 
                nmDStoolExamCulture.Value.ToString(), nmDStoolExamTyHoidH.Value.ToString(), nmDStoolExamTyHoidO.Value.ToString(),txtStoolExamSheetName.Text, nmDStoolExamCultureSummary.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล StoolExam เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }

        private void btnXRayExcel_Click(object sender, EventArgs e)
        {
            String No = "", xray = "", summary = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtXRaySheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDPERow.Value, nmDXRayNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDPERow.Value, nmDXRayNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDXRayValue.Value].Value2 != null)
            {
                xray = xlRange.Cells[nmDPERow.Value, nmDXRayValue.Value].Value2.ToString();
            }
            else
            {
                xray = "";
            }
            xray = xray.Trim();
            if (xlRange.Cells[nmDPERow.Value, nmDXRaySummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDPERow.Value, nmDXRaySummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtXRayTest.Text = "ลำดับ " + No + " XRay " + xray + " summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateXray(nmDXRayValue.Value.ToString(), nmDXRayNo.Value.ToString(), nmDXRayRow.Value.ToString(), nmDXRaySummary.Value.ToString(),txtXRaySheetName.Text).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล XRay เรียบร้อย", "บันทึกข้อมูล");
                ei = cc.eidb.selectByPk();
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }

        private void btnCBCExcel_Click(object sender, EventArgs e)
        {
            String No = "", wbc = "", rbc = "", Hb = "", Hct = "", neu = "", ly = "", mono = "", eos="", bact="", pltc="", plts="", rbcmono="", summary = "",result="";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtCBCSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDCBCRow.Value, nmDCBCNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCWBC.Value].Value2 != null)
            {
                wbc = xlRange.Cells[nmDCBCRow.Value, nmDCBCWBC.Value].Value2.ToString();
            }
            else
            {
                wbc = "";
            }
            wbc = wbc.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCRBC.Value].Value2 != null)
            {
                rbc = xlRange.Cells[nmDCBCRow.Value, nmDCBCRBC.Value].Value2.ToString();
            }
            else
            {
                rbc = "";
            }
            rbc = rbc.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCHb.Value].Value2 != null)
            {
                Hb = xlRange.Cells[nmDCBCRow.Value, nmDCBCHb.Value].Value2.ToString();
            }
            else
            {
                Hb = "";
            }
            Hb = Hb.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCHct.Value].Value2 != null)
            {
                Hct = xlRange.Cells[nmDCBCRow.Value, nmDCBCHct.Value].Value2.ToString();
            }
            else
            {
                Hct = "";
            }
            Hct = Hct.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCNeu.Value].Value2 != null)
            {
                neu = xlRange.Cells[nmDCBCRow.Value, nmDCBCNeu.Value].Value2.ToString();
            }
            else
            {
                neu = "";
            }
            neu = neu.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCLy.Value].Value2 != null)
            {
                ly = xlRange.Cells[nmDCBCRow.Value, nmDCBCLy.Value].Value2.ToString();
            }
            else
            {
                ly = "";
            }
            ly = ly.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCMono.Value].Value2 != null)
            {
                mono = xlRange.Cells[nmDCBCRow.Value, nmDCBCMono.Value].Value2.ToString();
            }
            else
            {
                mono = "";
            }
            mono = mono.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCEos.Value].Value2 != null)
            {
                eos = xlRange.Cells[nmDCBCRow.Value, nmDCBCEos.Value].Value2.ToString();
            }
            else
            {
                eos = "";
            }
            eos = eos.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCBact.Value].Value2 != null)
            {
                bact = xlRange.Cells[nmDCBCRow.Value, nmDCBCBact.Value].Value2.ToString();
            }
            else
            {
                bact = "";
            }
            bact = bact.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCPltC.Value].Value2 != null)
            {
                pltc = xlRange.Cells[nmDCBCRow.Value, nmDCBCPltC.Value].Value2.ToString();
            }
            else
            {
                pltc = "";
            }
            pltc = pltc.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCPltS.Value].Value2 != null)
            {
                plts = xlRange.Cells[nmDCBCRow.Value, nmDCBCPltS.Value].Value2.ToString();
            }
            else
            {
                plts = "";
            }
            plts = plts.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCRBCmono.Value].Value2 != null)
            {
                rbcmono = xlRange.Cells[nmDCBCRow.Value, nmDCBCRBCmono.Value].Value2.ToString();
            }
            else
            {
                rbcmono = "";
            }
            rbcmono = rbcmono.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDCBCRow.Value, nmDCBCSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            if (xlRange.Cells[nmDCBCRow.Value, nmDCBCResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDCBCRow.Value, nmDCBCResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();

            txtCBCTest.Text = "ลำดับ " + No + " WBC " + wbc + " Hct " + Hct + " Hb " + Hb + " RBC " + rbc + " Ly " + ly + " Neu " + neu + " mono " + mono +
                " Eos " + eos + " bact " + bact + " pltc " + pltc + " plts " + plts + " rbcmono " + rbcmono + " Summary " + summary + " Result " + result;

            Cursor.Current = cursor;
            if (cc.eidb.updateCBC(nmDCBCBact.Value.ToString(), nmDCBCEos.Value.ToString(), nmDCBCHb.Value.ToString(), nmDCBCHct.Value.ToString(),
                nmDCBCLy.Value.ToString(), nmDCBCMono.Value.ToString(), nmDCBCNeu.Value.ToString(), nmDCBCNo.Value.ToString(), nmDCBCPltC.Value.ToString(), nmDCBCPltS.Value.ToString(),
                nmDCBCRBC.Value.ToString(), nmDCBCRBCmono.Value.ToString(), nmDCBCRow.Value.ToString(), nmDCBCSummary.Value.ToString(), nmDCBCWBC.Value.ToString(), 
                nmDCBCPmn.Value.ToString(),txtCBCSheetName.Text, nmDCBCMCV.Value.ToString(), nmDCBCMCH.Value.ToString(), nmDCBCMCHC.Value.ToString(), nmDCBCBaso.Value.ToString(), nmDCBCResult.Value.ToString()).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }

        private void btnFBSExcel_Click(object sender, EventArgs e)
        {
            String No = "", fbs = "", result="", summary = "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals("")) return;

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[txtFBSSheetName.Text.Trim()];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            if (xlRange.Cells[nmDFBSRow.Value, nmDXRayNo.Value].Value2 != null)
            {
                No = xlRange.Cells[nmDFBSRow.Value, nmDXRayNo.Value].Value2.ToString();
            }
            else
            {
                No = "";
            }
            No = No.Trim();
            if (xlRange.Cells[nmDFBSRow.Value, nmDFBSValue.Value].Value2 != null)
            {
                fbs = xlRange.Cells[nmDFBSRow.Value, nmDFBSValue.Value].Value2.ToString();
            }
            else
            {
                fbs = "";
            }
            fbs = fbs.Trim();
            if (xlRange.Cells[nmDFBSRow.Value, nmDFBSResult.Value].Value2 != null)
            {
                result = xlRange.Cells[nmDFBSRow.Value, nmDFBSResult.Value].Value2.ToString();
            }
            else
            {
                result = "";
            }
            result = result.Trim();
            if (xlRange.Cells[nmDFBSRow.Value, nmDFBSSummary.Value].Value2 != null)
            {
                summary = xlRange.Cells[nmDFBSRow.Value, nmDFBSSummary.Value].Value2.ToString();
            }
            else
            {
                summary = "";
            }
            summary = summary.Trim();
            txtFBSTest.Text = "ลำดับ " + No + " fbs " + fbs + " result " + result + " summary " + summary;

            Cursor.Current = cursor;
            if (cc.eidb.updateFBS(nmDFBSValue.Value.ToString(), nmDFBSNo.Value.ToString(), nmDFBSResult.Value.ToString(), nmDFBSRow.Value.ToString(), nmDFBSSummary.Value.ToString(),txtFBSSheetName.Text).Length >= 1)
            {
                ei = cc.eidb.selectByPk();
                MessageBox.Show("บันทึกข้อมูล FBS เรียบร้อย", "บันทึกข้อมูล");
            }
            xlWorkbook.Close(true, null, null);
            xlApp.Quit();
        }

        private void btnUAExcel_Click(object sender, EventArgs e)
        {
            SaveUA();
        }

        private void btnTriExcel_Click(object sender, EventArgs e)
        {
            SaveTrig();
        }

        private void btnChoExcel_Click(object sender, EventArgs e)
        {
            SaveCholes();
        }

        private void btnSgotExcel_Click(object sender, EventArgs e)
        {
            SaveSgot();
        }

        private void btnBunExcel_Click(object sender, EventArgs e)
        {
            SaveBun();
        }

        private void btnUricExcel_Click(object sender, EventArgs e)
        {
            SaveUric();
        }

        private void btnOther1Excel_Click(object sender, EventArgs e)
        {
            SaveOther1();
        }

        private void btnLungExcel_Click(object sender, EventArgs e)
        {
            SaveLung();
        }

        private void btnAudioExcel_Click(object sender, EventArgs e)
        {
            SaveAudio();
        }

        private void btnEyeExcel_Click(object sender, EventArgs e)
        {
            SaveEye();
        }

        private void btnStoolExamExcel_Click(object sender, EventArgs e)
        {
            SaveStoolExam();
        }

        private void btnToxi2Excel_Click(object sender, EventArgs e)
        {
            SaveToxi2();
        }

        private void btnToxi1Excel_Click(object sender, EventArgs e)
        {
            SaveToxi1();
        }
    }
}
