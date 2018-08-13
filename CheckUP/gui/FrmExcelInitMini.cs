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
    public partial class FrmExcelInitMini : Form
    {
        CheckControl cc;
        OpenFileDialog ofd = new OpenFileDialog();
        ExcelInitMini eimini;

        public FrmExcelInitMini(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            int chk = 0;
            btnSave.Click += BtnSave_Click;

            setControl();


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (cc.eiminidb.updateSgot(nmDSgotvalue.Value.ToString(), nmDSgotResult.Value.ToString(), nmDSgotSgptValue.Value.ToString(),
                nmDSgotSummary.Value.ToString(), nmDSgotAakalineValue.Value.ToString()).Length >= 1)
            {
                
                //MessageBox.Show("บันทึกข้อมูล Sgot เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateBun(nmDBunValue.Value.ToString(), nmDBunCreatinine.Value.ToString(), nmDBunResult.Value.ToString(),
                nmDBunSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล BUN เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateUric( nmDUricValue.Value.ToString().Trim(), nmDUricResult.Value.ToString().Trim(),
                nmDUricSummary.Value.ToString().Trim()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Uric Acid เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateCholes(nmDChoValue.Value.ToString(), nmDChoResult.Value.ToString(),
                nmDChoSummary.Value.ToString(), nmDChoLDL.Value.ToString(), nmDChoHDL.Value.ToString(), nmDLDLResult.Value.ToString(),
                nmDLDLSummary.Value.ToString(), nmDHDLResult.Value.ToString(), nmDHDLSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Choles เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateTrig(nmDTriValue.Value.ToString(), nmDTriResult.Value.ToString(), nmDTriSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Trig เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateUA(nmDUAAppe.Value.ToString(), nmDUABact.Value.ToString(), nmDUAColor.Value.ToString(), nmDUAEpi.Value.ToString(),
                nmDUApH.Value.ToString(), nmDUAProtein.Value.ToString(), nmDUARBC.Value.ToString(), nmDUAResult.Value.ToString(),
                nmDUASpgr.Value.ToString(), nmDUASugar.Value.ToString(), nmDUASummary.Value.ToString(), nmDUAWBC.Value.ToString(), nmDUAGlu.Value.ToString(), nmDUAKetone.Value.ToString(),
                nmDUABlood.Value.ToString(), nmDUALeu.Value.ToString(), nmDUANit.Value.ToString(), nmDUAUro.Value.ToString(), nmDUABili.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล UA เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.UpdateOther1(nmDOther1Amphetamine.Value.ToString(), nmDOther1AntiHIV.Value.ToString(), nmDOther1Calcium.Value.ToString(), nmDOther1HBsAb.Value.ToString(),
                nmDOther1HBsAg.Value.ToString(), nmDOther1VDRL.Value.ToString(), nmDOther1AntiHav.Value.ToString(),
                nmDOther1CAAFP.Value.ToString(), nmDOther1CAAFPResult.Value.ToString(), nmDOther1CAAFPSummary.Value.ToString(), nmDOther1CACEA.Value.ToString(), nmDOther1CACEAResult.Value.ToString(),
                nmDOther1CACEASummary.Value.ToString(), nmDOther1CAPSA.Value.ToString(), nmDOther1CAPSAResult.Value.ToString(), nmDOther1CAPSASummary.Value.ToString(), nmDOther1CAHCG.Value.ToString(),
                nmDOther1CAHCGResult.Value.ToString(), nmDOther1CAHCGSummary.Value.ToString(), nmDOther1CA153.Value.ToString(), nmDOther1CA153Result.Value.ToString(),
                nmDOther1CA153Summary.Value.ToString(), nmDOther1CA125.Value.ToString(), nmDOther1CA125Result.Value.ToString(), nmDOther1CA125Summary.Value.ToString(),
                nmDOther1CA199.Value.ToString(), nmDOther1CA199Result.Value.ToString(), nmDOther1CA199Summary.Value.ToString(), nmDOther1HBsAbResult.Value.ToString(),
                nmDOther1HBsAgResult.Value.ToString(), nmDOther1HBsAbSummary.Value.ToString(), nmDOther1HBsAgSummary.Value.ToString(), nmDOtherAmphetamineSummary.Value.ToString(), nmDOther1AntiHavSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Other เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateLung(nmDLungFvcPredic.Value.ToString(), nmDLungFvcMeas.Value.ToString(),
                nmDLungFvcPer.Value.ToString(), nmDLungFev1Predic.Value.ToString(), nmDLungFev1Meas.Value.ToString(), nmDLungFev1Per.Value.ToString(),
                nmDLungPerFev1.Value.ToString(), nmDLungSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Lung เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateAudioGram(nmDAudiogram500L.Value.ToString(), nmDAudiogram500R.Value.ToString(), nmDAudiogram1000L.Value.ToString(), nmDAudiogram1000R.Value.ToString(),
                nmDAudiogram2000L.Value.ToString(), nmDAudiogram2000R.Value.ToString(), nmDAudiogram3000L.Value.ToString(), nmDAudiogram3000R.Value.ToString(), nmDAudiogram4000L.Value.ToString(), nmDAudiogram4000R.Value.ToString(),
                nmDAudiogram6000L.Value.ToString(), nmDAudiogram6000R.Value.ToString(), nmDAudiogram8000L.Value.ToString(), nmDAudiogram8000R.Value.ToString(), nmDAudiogramSummaryL.Value.ToString(), nmDAudiogramSummaryR.Value.ToString(),
                nmDAudiogramExam.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล AudioGram เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateEye(nmDEyeShortLongLeft.Value.ToString(), nmDEyeShortLongRight.Value.ToString(), nmDEyeSquintLeft.Value.ToString(),
                nmDEyeSquintRight.Value.ToString(),
                nmDEyeDegreeLeft.Value.ToString(), nmDEyeDegreeRight.Value.ToString(), nmDEyeOldLeft.Value.ToString(), nmDEyeOldRight.Value.ToString(), nmDEyeResult.Value.ToString(),
                nmDEyeSummary.Value.ToString(), nmDEyeBlindness.Value.ToString(), nmDEyeExam.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Eye เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateToxi1(nmDToxiLead.Value.ToString(), nmDToxiAluminium.Value.ToString(),
                nmDToxiCadmium.Value.ToString(), nmDToxiMercury.Value.ToString(), nmDToxiTin.Value.ToString(), nmDToxiCopper.Value.ToString(),
                nmDToxiManganese.Value.ToString(), nmDToxiZinc.Value.ToString(), nmDToxiAmmonia.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Toxi1 เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateToxi2(nmDToxiHippuric.Value.ToString(), nmDToxiMethyl.Value.ToString(), nmDToxiAcetone.Value.ToString(), nmDToxiNickel.Value.ToString(),
                nmDToxiChromium.Value.ToString(), nmDToxiPhenol.Value.ToString(), nmDToxiKetone.Value.ToString(), nmDToxiBenzene.Value.ToString(),
                nmDToxiMandelic.Value.ToString(), nmDToxiMethanol.Value.ToString(), nmDToxiEthanol.Value.ToString(), nmDToxiIPA.Value.ToString(), nmDToxiArsenic.Value.ToString(),
                nmDToxiHexane.Value.ToString(), nmDToxiFomaldehyde.Value.ToString(), nmDToxiTrichloroethylene.Value.ToString(), nmDToxiAntimony.Value.ToString(),
                nmDToxiFluoride.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล Toxi2 เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateSfC(nmDCAge.Value.ToString(), nmDCPrefix.Value.ToString(), nmDDepartment.Value.ToString()
                    , nmDPatientNumber.Value.ToString(), nmDVisitHn.Value.ToString(), nmDPositionName.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updatePE(nmDCAge.Value.ToString(), nmDPEBMI.Value.ToString(),
                nmDPEHeight.Value.ToString(), nmDPEWeight.Value.ToString(), nmDPEPulse.Value.ToString(), nmDPEVi.Value.ToString(), nmDPEResult.Value.ToString(),
                nmDPESummary.Value.ToString(), nmDPEBloodGroup.Value.ToString(), nmdEKG.Value.ToString(), nmdEKGresult.Value.ToString(), nmdEKGsummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล PE เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateStoolExam(nmDStoolExamAppearance.Value.ToString(), nmDStoolExamColor.Value.ToString(),
                nmDStoolExamWBC.Value.ToString(), nmDStoolExamRBC.Value.ToString(), nmDStoolExamParasite.Value.ToString(), nmDStoolExamSummary.Value.ToString(),
                nmDStoolExamCulture.Value.ToString(), nmDStoolExamTyHoidH.Value.ToString(), nmDStoolExamTyHoidO.Value.ToString(), nmDStoolExamCultureSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล StoolExam เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateXray(nmDXRayValue.Value.ToString(), nmDXRaySummary.Value.ToString()).Length >= 1)
            {
                //MessageBox.Show("บันทึกข้อมูล XRay เรียบร้อย", "บันทึกข้อมูล");
                //ei = cc.eidb.selectByPk();
            }
            if (cc.eiminidb.updateCBC(nmDCBCBact.Value.ToString(), nmDCBCEos.Value.ToString(), nmDCBCHb.Value.ToString(), nmDCBCHct.Value.ToString(),
                nmDCBCLy.Value.ToString(), nmDCBCMono.Value.ToString(), nmDCBCNeu.Value.ToString(), nmDCBCPltC.Value.ToString(), nmDCBCPltS.Value.ToString(),
                nmDCBCRBC.Value.ToString(), nmDCBCRBCmono.Value.ToString(), nmDCBCSummary.Value.ToString(), nmDCBCWBC.Value.ToString(),
                nmDCBCPmn.Value.ToString(), nmDCBCMCV.Value.ToString(), nmDCBCMCH.Value.ToString(), nmDCBCMCHC.Value.ToString(), nmDCBCBaso.Value.ToString(), nmDCBCResult.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล CBC เรียบร้อย", "บันทึกข้อมูล");
            }
            if (cc.eiminidb.updateFBS(nmDFBSValue.Value.ToString(), nmDFBSResult.Value.ToString(), nmDFBSSummary.Value.ToString()).Length >= 1)
            {
                //ei = cc.eidb.selectByPk();
                //MessageBox.Show("บันทึกข้อมูล FBS เรียบร้อย", "บันทึกข้อมูล");
            }
            eimini = cc.eiminidb.selectByPk();
            MessageBox.Show("บันทึกข้อมูล  เรียบร้อย", "บันทึกข้อมูล");
            setControl();
        }

        private void setControl()
        {
            int chk = 0;
            eimini = cc.eiminidb.selectByPk();
            nmDDepartment.Value = int.Parse(cc.cf.NumberNull11(eimini.DepartmentName));

            nmDPEBMI.Value = int.Parse(cc.cf.NumberNull11(eimini.PEBMI));
            nmDPEHeight.Value = int.Parse(cc.cf.NumberNull11(eimini.PEHeight));
            nmDPEPulse.Value = int.Parse(cc.cf.NumberNull11(eimini.PEPulse));
            nmDPEResult.Value = int.Parse(cc.cf.NumberNull11(eimini.PEResult));
            nmDPESummary.Value = int.Parse(cc.cf.NumberNull11(eimini.PESummary));
            nmDPEVi.Value = int.Parse(cc.cf.NumberNull11(eimini.PEVitalSign));
            nmDPEWeight.Value = int.Parse(cc.cf.NumberNull11(eimini.PEWeight));
            nmDPEBloodGroup.Value = int.Parse(cc.cf.NumberNull11(eimini.PEBloodGroup));


            nmDXRaySummary.Value = int.Parse(cc.cf.NumberNull11(eimini.XraySummary));
            nmDXRayValue.Value = int.Parse(cc.cf.NumberNull11(eimini.Xray));


            nmDCBCBact.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCBact));
            nmDCBCEos.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCEos));
            nmDCBCHb.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCHb));
            nmDCBCHct.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCHct));
            nmDCBCLy.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCLy));
            nmDCBCMono.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCMono));
            nmDCBCNeu.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCNeu));
            nmDCBCPltC.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCPltC));
            nmDCBCPltS.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCPltS));
            nmDCBCRBC.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCRBC));
            nmDCBCRBCmono.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCRBCmono));
            nmDCBCSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCSummary));
            nmDCBCWBC.Value = int.Parse(cc.cf.NumberNull11(eimini.CBCWBC));
            nmDCBCPmn.Value = int.Parse(cc.cf.NumberNull11(eimini.cbcPmn));
            nmDCBCMCH.Value = int.TryParse(cc.cf.NumberNull11(eimini.CBCMCH), out chk) ? chk : 0;
            nmDCBCMCHC.Value = int.TryParse(cc.cf.NumberNull11(eimini.CBCMCHC), out chk) ? chk : 0;
            nmDCBCMCV.Value = int.TryParse(cc.cf.NumberNull11(eimini.CBCMCV), out chk) ? chk : 0;
            nmDCBCBaso.Value = int.TryParse(cc.cf.NumberNull11(eimini.CBCBASO), out chk) ? chk : 0;


            nmDFBSResult.Value = int.Parse(cc.cf.NumberNull11(eimini.FBSResult));
            nmDFBSSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.FBSSummary));
            nmDFBSValue.Value = int.Parse(cc.cf.NumberNull11(eimini.FBS));


            nmDUAAppe.Value = int.Parse(cc.cf.NumberNull11(eimini.UAAppe));
            nmDUABact.Value = int.Parse(cc.cf.NumberNull11(eimini.UABact));
            nmDUAColor.Value = int.Parse(cc.cf.NumberNull11(eimini.UAColor));
            nmDUAEpi.Value = int.Parse(cc.cf.NumberNull11(eimini.UAEpi));
            nmDUApH.Value = int.Parse(cc.cf.NumberNull11(eimini.UApH));
            nmDUAProtein.Value = int.Parse(cc.cf.NumberNull11(eimini.UAProtein));
            nmDUARBC.Value = int.Parse(cc.cf.NumberNull11(eimini.UARBC));
            nmDUAResult.Value = int.Parse(cc.cf.NumberNull11(eimini.UAResult));
            nmDUASpgr.Value = int.Parse(cc.cf.NumberNull11(eimini.UASpgr));
            nmDUASugar.Value = int.Parse(cc.cf.NumberNull11(eimini.UASugar));
            nmDUASummary.Value = int.Parse(cc.cf.NumberNull11(eimini.UASummary));
            nmDUAWBC.Value = int.Parse(cc.cf.NumberNull11(eimini.UAWBC));
            nmDUAGlu.Value = int.Parse(cc.cf.NumberNull11(eimini.UAGlu));
            nmDUAKetone.Value = int.Parse(cc.cf.NumberNull11(eimini.UAKetone));
            nmDUABlood.Value = int.Parse(cc.cf.NumberNull11(eimini.UABlood));

            nmDUALeu.Value = int.Parse(cc.cf.NumberNull11(eimini.UALeu));
            nmDUANit.Value = int.Parse(cc.cf.NumberNull11(eimini.UANit));
            nmDUAUro.Value = int.Parse(cc.cf.NumberNull11(eimini.UAUro));
            nmDUABili.Value = int.Parse(cc.cf.NumberNull11(eimini.UABil));

            nmDTriResult.Value = int.Parse(cc.cf.NumberNull11(eimini.TriResult));
            nmDTriSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.TriSummary));
            nmDTriValue.Value = int.Parse(cc.cf.NumberNull11(eimini.Triglyceride));
            nmDChoResult.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoResult));

            nmDChoSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.Chosummary));
            nmDChoValue.Value = int.Parse(cc.cf.NumberNull11(eimini.Cholesteral));
            nmDChoLDL.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoLDL));
            nmDChoHDL.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoHDL));
            nmDLDLResult.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoLDLResult));
            nmDLDLSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoLDLsummary));
            nmDHDLResult.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoHDLResult));
            nmDHDLSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.ChoHDLsummary));

            nmDSgotResult.Value = int.Parse(cc.cf.NumberNull11(eimini.SgotResult));
            nmDSgotSgptValue.Value = int.Parse(cc.cf.NumberNull11(eimini.Sgpt));
            nmDSgotSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.SgptSummary));
            nmDSgotvalue.Value = int.Parse(cc.cf.NumberNull11(eimini.Sgot));
            nmDSgotALPValue.Value = int.Parse(cc.cf.NumberNull11(eimini.SgotALP));
            nmDSgotAakalineValue.Value = int.Parse(cc.cf.NumberNull11(eimini.SgotAlkaline));

            nmDBunCreatinine.Value = int.Parse(cc.cf.NumberNull11(eimini.BunCreatinine));
            nmDBunResult.Value = int.Parse(cc.cf.NumberNull11(eimini.BunResult));
            nmDBunSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.BunSummary));
            nmDBunValue.Value = int.Parse(cc.cf.NumberNull11(eimini.Bun));

            nmDUricResult.Value = int.Parse(cc.cf.NumberNull11(eimini.UricResult));
            nmDUricSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.UricSummary));
            nmDUricValue.Value = int.Parse(cc.cf.NumberNull11(eimini.UricAcid));

            nmDOther1HBsAb.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1HBsAb));
            nmDOther1HBsAg.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1HBsAg));
            nmDOther1Amphetamine.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1Amphetamine));
            nmDOther1Calcium.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1Calcium));
            nmDOther1VDRL.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1VDRL));
            nmDOther1AntiHIV.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1AntiHIV));
            nmDOther1AntiHav.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1AntiHav));
            nmDOther1CAAFP.Value = int.Parse(cc.cf.NumberNull13(eimini.CAAFP));
            nmDOther1CACEA.Value = int.Parse(cc.cf.NumberNull13(eimini.CACEA));
            nmDOther1CAPSA.Value = int.Parse(cc.cf.NumberNull13(eimini.CAPSA));
            nmDOther1CAHCG.Value = int.Parse(cc.cf.NumberNull13(eimini.CAHCG));
            nmDOther1CA153.Value = int.Parse(cc.cf.NumberNull13(eimini.CA153));
            nmDOther1CA125.Value = int.Parse(cc.cf.NumberNull13(eimini.CA125));
            nmDOther1CA199.Value = int.Parse(cc.cf.NumberNull13(eimini.CA199));

            nmDOther1HBsAbResult.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1HBsAbResult));
            nmDOther1HBsAgResult.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1HBsAgResult));
            nmDOther1HBsAbSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1HBsAbSummary));
            nmDOther1AntiHavSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.Other1AntiHavSummary));

            nmDOtherAmphetamineSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.AmphetamineSummary));

            nmDLungFvcPredic.Value = int.Parse(cc.cf.NumberNull11(eimini.LungFvcPredic));
            nmDLungFvcMeas.Value = int.Parse(cc.cf.NumberNull11(eimini.LungFvcMeas));
            nmDLungFvcPer.Value = int.Parse(cc.cf.NumberNull11(eimini.LungFvcPer));
            nmDLungFev1Predic.Value = int.Parse(cc.cf.NumberNull11(eimini.LungFev1Predic));
            nmDLungFev1Meas.Value = int.Parse(cc.cf.NumberNull11(eimini.LungFev1Meas));
            nmDLungFev1Per.Value = int.Parse(cc.cf.NumberNull11(eimini.LungFev1Per));
            nmDLungPerFev1.Value = int.Parse(cc.cf.NumberNull11(eimini.LungPerFev1));
            nmDLungSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.LungSummary));

            nmDAudiogram500L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram500L));
            nmDAudiogram500R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram500R));
            nmDAudiogram1000L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram1000L));
            nmDAudiogram1000R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram1000R));
            nmDAudiogram2000L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram2000L));
            nmDAudiogram2000R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram2000R));
            nmDAudiogram3000L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram3000L));
            nmDAudiogram3000R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram3000R));
            nmDAudiogram4000L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram4000L));
            nmDAudiogram4000R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram4000R));
            nmDAudiogram6000L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram6000L));
            nmDAudiogram6000R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram6000R));
            nmDAudiogram8000L.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram8000L));
            nmDAudiogram8000R.Value = int.Parse(cc.cf.NumberNull11(eimini.Audiogram8000R));
            nmDAudiogramSummaryL.Value = int.Parse(cc.cf.NumberNull11(eimini.AudiogramSummaryL));
            nmDAudiogramSummaryR.Value = int.Parse(cc.cf.NumberNull11(eimini.AudiogramSummaryR));
            nmDAudiogramExam.Value = int.Parse(cc.cf.NumberNull11(eimini.AudiogramExam));

            nmDEyeShortLongLeft.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeShortLongLeft));
            nmDEyeShortLongRight.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeShortLongRight));
            nmDEyeSquintLeft.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeSquintLeft));
            nmDEyeSquintRight.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeSquintRight));
            nmDEyeDegreeLeft.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeDegreeLeft));
            nmDEyeDegreeRight.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeDegreeRight));
            nmDEyeOldLeft.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeOldLeft));
            nmDEyeOldRight.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeOldRight));
            nmDEyeBlindness.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeBlindness));
            nmDEyeResult.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeResult));
            nmDEyeSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeSummary));
            nmDEyeExam.Value = int.Parse(cc.cf.NumberNull11(eimini.EyeExam));

            nmDStoolExamAppearance.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamAppearance));
            nmDStoolExamColor.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamColor));

            nmDStoolExamParasite.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamParasite));
            nmDStoolExamRBC.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamRbc));

            nmDStoolExamSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamSummary));
            nmDStoolExamWBC.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamWbc));
            nmDStoolExamCulture.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamCulture));
            nmDStoolExamTyHoidH.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamTyphoidH));
            nmDStoolExamTyHoidO.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamTyphoidO));
            nmDStoolExamCultureSummary.Value = int.Parse(cc.cf.NumberNull11(eimini.StoolExamCultureSummary));

            nmDToxiLead.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiLead));
            nmDToxiAluminium.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiAluminium));
            nmDToxiCadmium.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiCadmium));
            nmDToxiMercury.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiMercury));
            nmDToxiTin.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiTin));
            nmDToxiCopper.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiCopper));
            nmDToxiManganese.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiManganese));
            nmDToxiZinc.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiZinc));
            nmDToxiAmmonia.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiAmmonia));

            nmDToxiHippuric.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiHippuric));
            nmDToxiMethyl.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiMethyl));
            nmDToxiAcetone.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiAcetone));
            nmDToxiNickel.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiNickel));
            nmDToxiChromium.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiChromium));
            nmDToxiPhenol.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiPhenol));
            nmDToxiKetone.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiKetone));
            nmDToxiBenzene.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiBenzene));
            nmDToxiMandelic.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiMandelic));
            nmDToxiMethanol.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiMethanol));
            nmDToxiEthanol.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiEthanol));
            nmDToxiIPA.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiIPA));
            nmDToxiArsenic.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiArsenic));
            nmDToxiHexane.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiHexane));
            nmDToxiFomaldehyde.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiFomaldehyde));
            nmDToxiTrichloroethylene.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiTrichloroethylene));
            nmDToxiAntimony.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiAntimony));
            nmDToxiFluoride.Value = int.Parse(cc.cf.NumberNull11(eimini.ToxiFluoride));

            nmDPatientNumber.Value = int.Parse(cc.cf.NumberNull11(eimini.patient_number));
            nmDPositionName.Value = int.Parse(cc.cf.NumberNull11(eimini.position_name));
            nmDVisitHn.Value = int.Parse(cc.cf.NumberNull11(eimini.visit_hn));
            nmDCPrefix.Value = int.Parse(cc.cf.NumberNull11(eimini.SfCFullName));
            nmDCAge.Value = int.Parse(cc.cf.NumberNull11(eimini.SfCAge));
        }

        private void FrmExcelInitMini_Load(object sender, EventArgs e)
        {

        }
    }
}
