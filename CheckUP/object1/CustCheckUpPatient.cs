﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUP.object1
{
    public class CustCheckUpPatient:Persistent
    {
        public String Id="";
        public String CustCheckUpId="";    
        public String ChecklistId="";    
        public String visitHn="";    
        public String patientFullname="";    
        public String patientAge="";    
        public String departmentName="";    
        public String pid="";    
        public String patientNumber="";    
        public String sectionName="";    
        public String vitalsign="";    
        public String patientHeight="";    
        public String patientPulse="";    
        public String patientWeight="";
        public String EyeShortLongLeft = "", EyeShortLongRight = "", EyeSquintLeft = "", EyeSquintRight = "", EyeDegreeLeft = "", EyeDegreeRight = "", EyeOldLeft="", EyeOldRight="", EyeResult = "", EyeSummary = "", EyeBlindness="", EyeExam="";
        
        public String fSexId="", SexName="";    
        public String summaryPhysicalExam="", PeResult="";

        public String StoolExamColor = "", StoolExamAppearance = "", StoolExamWbc = "", StoolExamRbc = "", StoolExamParasite = "", StoolExamSummary = "", StoolExamCulture = "", StoolExamTyphoidO = "", StoolExamTyphoidH = "", StoolExamCultureSummary = "";

        public String ToxiLead = "", ToxiLeadRemark = "", ToxiLeadLabName = "", ToxiLeadLabNormal = "";
        public String ToxiAluminium = "", ToxiAluminiumRemark = "", ToxiAluminiumLabName = "", ToxiAluminiumLabNormal = "";
        public String ToxiCadmium = "", ToxiCadmiumRemark = "", ToxiCadmiumLabName = "", ToxiCadmiumLabNormal = "";
        public String ToxiMercury = "", ToxiMercuryRemark = "", ToxiMercuryLabName = "", ToxiMercuryLabNormal = "";
        public String ToxiTin = "", ToxiTinRemark = "", ToxiTinLabName = "", ToxiTinLabNormal = "";
        public String ToxiCopper = "", ToxiCopperRemark = "", ToxiCopperLabName = "", ToxiCopperLabNormal = "";
        public String ToxiManganese = "", ToxiManganeseRemark = "", ToxiManganeseLabName = "", ToxiManganeseLabNormal = "";
        public String ToxiZinc = "", ToxiZincRemark = "", ToxiZincLabName = "", ToxiZincLabNormal = "";
        public String ToxiAmmonia = "", ToxiAmmoniaRemark = "", ToxiAmmoniaLabName = "", ToxiAmmoniaLabNormal = "";
        public String ToxiHippuric = "", ToxiHippuricRemark = "", ToxiHippuricLabName = "", ToxiHippuricLabNormal = "";
        public String ToxiMethyl = "", ToxiMethylRemark = "", ToxiMethylLabName = "", ToxiMethylLabNormal = "";
        public String ToxiAcetone = "", ToxiAcetoneRemark = "", ToxiAcetoneLabName = "", ToxiAcetoneLabNormal = "";
        public String ToxiNickel = "", ToxiNickelRemark = "", ToxiNickelLabName = "", ToxiNickelLabNormal = "";
        public String ToxiChromium = "", ToxiChromiumRemark = "", ToxiChromiumLabName = "", ToxiChromiumLabNormal = "";
        public String ToxiPhenol = "", ToxiPhenolRemark = "", ToxiPhenolLabName = "", ToxiPhenolLabNormal = "";
        public String ToxiKetone = "", ToxiKetoneRemark = "", ToxiKetoneLabName = "", ToxiKetoneLabNormal = "";
        public String ToxiBenzene = "", ToxiBenzeneRemark = "", ToxiBenzeneLabName = "", ToxiBenzeneLabNormal = "";
        public String ToxiMandelic = "", ToxiMandelicRemark = "", ToxiMandelicLabName = "", ToxiMandelicLabNormal = "";
        public String ToxiMethanol = "", ToxiMethanolRemark = "", ToxiMethanolLabName = "", ToxiMethanolLabNormal = "";
        public String ToxiEthanol = "", ToxiEthanolRemark = "", ToxiEthanolLabName = "", ToxiEthanolLabNormal = "";
        public String ToxiIPA = "", ToxiIPARemark = "", ToxiIPALabName = "", ToxiIPALabNormal = "";
        public String ToxiArsenic = "", ToxiArsenicRemark = "", ToxiArsenicLabName = "", ToxiArsenicLabNormal = "";
        public String ToxiHexane = "", ToxiHexaneRemark = "", ToxiHexaneLabName = "", ToxiHexaneLabNormal = "";
        public String ToxiFomaldehyde = "", ToxiFomaldehydeRemark = "", ToxiFomaldehydeLabName = "", ToxiFomaldehydeLabNormal = "";
        public String ToxiTrichloroethylene = "", ToxiTrichloroethyleneRemark = "", ToxiTrichloroethyleneLabName = "", ToxiTrichloroethyleneLabNormal = "";
        public String ToxiAntimony = "", ToxiAntimonyRemark = "", ToxiAntimonyLabName = "", ToxiAntimonyLabNormal = "";
        public String ToxiFluoride = "", ToxiFluorideRemark = "", ToxiFluorideLabName = "", ToxiFluorideLabNormal = "";
                
        //public String toxicologyLead="",toxicologyMercury="",toxicologyBenzene="",toxicologyXylene="";

        //public String toxicologyToluene = "", toxicologyThinner = "", toxicologyAlcohol = "", toxicologyHexane = "", toxicologyMethanol = "", toxicologyMek = "", toxicologyAcetone = "";

        public String Audiogram500L="";
        public String Audiogram1000L="";
        public String Audiogram2000L="";
        public String Audiogram3000L="";
        public String Audiogram4000L="";
        public String Audiogram6000L="";
        public String Audiogram8000L="";
        public String AudiogramSummaryL="";
        public String Audiogram500R="";
        public String Audiogram1000R="";
        public String Audiogram2000R="";
        public String Audiogram3000R="";
        public String Audiogram4000R="";
        public String Audiogram6000R="";
        public String Audiogram8000R="";
        public String AudiogramSummaryR="";
        public String AudiogramExam="";
        public String xrayChestExam="";
        public String xrayChestSummary="";
        public String eyesExam="";
        public String ekgExam="";
        
        public String CAAFP="", CACEA="",CAPSA="", CAHCG="",CA153="", CA125="", CA199="";

        public String thyroidT3="";
        public String thyroidT4="";
        public String thyroidTsh="";
        public String BloodGroup="";

        public String vdrl = "", antiHiv = "", hbsag = "", hbsab = "", antiHbc = "", hbtyping = "", AntiHav = "", hbsagResult = "", hbsagSummary = "", hbsabResult = "", hbsabSummary = "";

        public String amphetamine="";
        public String disscusExam="";
        public String suggestExam="";
        public String sugar="";
        public String sugarDiagnosis="";
        public String sugarSummary="";
        public String sugarSuggess="";
        public String kidneyBun="";
        public String kidneyCreatinine="";
        public String kidneyResult = "";
        public String kidneySummary = "";

        public String liverSgot="";
        public String liverSgpt="";
        public String liverAlp="", liverAlkaline="";
        public String liverResult = "";
        public String liverSummary = "";
        public String uricAcid="";
        public String cholesterol="";
        public String triglyceride="";
        public String triglycerideResult = "";
        public String triglycerideSummary = "";
        public String hdl="", ldl = "", ChoLDLResult = "", ChoLDLsummary = "", ChoHDL = "", ChoHDLResult = "", ChoHDLsummary = "";

        public String calcium="";
        public String cbcHb="", cbcHbRemark="", cbcHbLabName="", cbcHbLabNormal="";
        public String cbcHct="", cbcHctRemark = "", cbcHctLabName = "", cbcHctLabNormal = "";
        public String cbcWbc="", cbcWbcRemark = "", cbcWbcLabName = "", cbcWbcLabNormal = "";
        public String cbcNeutrophil="", cbcNeutrophilRemark = "", cbcNeutrophilLabName = "", cbcNeutrophilLabNormal = "";
        public String cbcLymphocyte="", cbcLymphocyteRemark = "", cbcLymphocyteLabName = "", cbcLymphocyteLabNormal = "";
        public String cbcEosinophil="", cbcEosinophilRemark = "", cbcEosinophilLabName = "", cbcEosinophilLabNormal = "";
        public String cbcMonocyte="", cbcMonocyteRemark = "", cbcMonocyteLabName = "", cbcMonocyteLabNormal = "";
        public String cbcBasophil = "", cbcBasophilRemark = "", cbcBasophilLabName = "", cbcBasophilLabNormal = "";
        public String cbcBact="", cbcBactRemark = "", cbcBactLabName = "", cbcBactLabNormal = "";
        public String cbcPlateletCount="", cbcPlateletCountRemark = "", cbcPlateletCountLabName = "", cbcPlateletCountLabNormal = "";
        public String cbcRbcMorpholog="", cbcRbcMorphologRemark = "", cbcRbcMorphologLabName = "", cbcRbcMorphologLabNormal = "";
        public String cbcSummary="";
        public String cbcMch = "", cbcMchRemark = "", cbcMchLabName = "", cbcMchLabNormal = "";
        public String cbcMchc = "", cbcMchcRemark = "", cbcMchcLabName = "", cbcMchcLabNormal = "";
        public String cbcPlateletSmear = "", cbcPlateletSmearRemark = "", cbcPlateletSmearLabName = "", cbcPlateletSmearLabNormal = "";
        public String cbcPmn="", cbcPmnRemark = "", cbcPmnLabName = "", cbcPmnLabNormal = "";
        public String cbcMcv = "", cbcMcvRemark = "", cbcMcvLabName = "", cbcMcvLabNormal = "";
        public String cbcRbc = "", cbcRbcRemark = "", cbcRbcLabName = "", cbcRbcLabNormal = "";

        public String urineColor="";
        public String urineAppearance="";
        public String urinePh="";
        public String urineSpGr="";
        public String urineSugar="";
        public String urineProtein="";
        public String urineBlood="";
        public String urineKetone="";
        public String urineBacteria="";
        public String urineWbc="";
        public String urineRbc="";
        public String urineEpithelium="";
        public String urineGlu = "";
        public String urineSummary="";
        public String urineResult = "";
        public String urineLeu = "";
        public String urineNit = "";
        public String urineBil = "";
        public String urineUro = "";

        public String lungFvcPredic="";
        public String lungFvcMeas="";
        public String lungFvcPer="";
        public String lungFev1Predic="";
        public String lungFev1Meas="";
        public String lungFev1Per="";
        public String lungPerFev1="";
        public String lungSummary="";
        public String lungSuggess="";
        public String statusName="";
        public String rowNumber = "";
        
        
        public String thyroidRubellaLgg="";
        public String billirubin="";
        
        public String stickerQty="";
        public String statusCbc="";
        public String statusUa="";
        public String statusFbs="";
        public String statusPe="";
        public String statusXray="";
        public String statusStool="";
        //public String stoolExamSummary="";
        public String cholesterolSummary="";
        public String cholesterolSuggess="";
        public String statusCholes="";
        public String StatusHbsag="";
        
        
    
        public String Active="";
        public String eyeBio="";
        public String amphetamineSummary="";
        public String amphetamineSuggess="";
        public String statusAmphetamine="";
        public String antiHivSummary="", antiHavSummary="";
        public String antiHivSuggess="";
        public String statusAntiHiv="";
        public String statusUricAcid="";
        public String uricAcidSuggess="";
        public String uricAcidSummary="";
        public String statusVisit="";
        public String visitComment="";
        public String bmi="";
        public String caFt3="";                

        
        public String eyeLeft = "";
        public String eyeRight = "";
        public String opticalLeftAngle="";
        public String opticalRightAngle="";
        public String cbcMcvOld="";
        public String cbcHbOld="";
        public String cbcHctOld="";
        public String cbcWbcOld="";
        public String cbcNeutrophilOld="";
        public String cbcLymphocyteOld="";
        public String cbcEosinophilOld="";
        public String cbcMonocyteOld="";
        public String cbcBasophilOld="";
        public String cbcPlateletCountOld="";
        public String cbcRbcMorphologOld="";
        public String cbcSummaryOld="";
        public String cbcRbcOld="";
        public String cbcMchcOld="";
        public String cbcMchOld="";
        public String sugarOld="";
        public String kidneyBunOld="";
        public String kidneyCreatinineOld="";
        public String liverSgotOld="";
        public String liverSgptOld="";
        public String liverAlpOld="";
        public String uricAcidOld="";
        public String cholesterolOld="";
        public String triglycerideOld="";
        public String hdlOld="";
        public String ldlOld="";
        //public String toxicologyLeadOld="";
        //public String toxicologyMercuryOld="";
        //public String toxicologyBenzeneOld="";
        //public String toxicologyXyleneOld="";
        //public String toxicologyThinnerOld="";
        //public String toxicologyAlcoholOld="";
        //public String toxicologyHexaneOld="";
        //public String toxicologyMethanolOld="";
        //public String toxicologyMekOld="";
        //public String toxicologyAcetoneOld="";
        //public String toxicologyTolueneOld="";
        
        public String urineOther="";
        public String cultureStool="";
        public String cultureUrine="";
        public String cultureBacteria="";
        public String cultureSputum="";
        public String marketingCheckupPatientOldId="";
        public String thyroidFt3="";
        public String thyroidFt4="";
        public String amylase="";
        public String totalProtein="";
        public String albumin="";
        public String globulin="";
        public String albuminGlobulin="";
        public String directBillirubin="";
        public String colorBlindness="";
        public override String ToString()
        {
            return patientFullname;
        }
    }
}
