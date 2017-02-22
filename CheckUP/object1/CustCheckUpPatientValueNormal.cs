using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class CustCheckUpPatientValueNormal:Persistent
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
        public String EyeShortLongLeft = "", EyeShortLongRight = "", EyeSquintLeft = "", EyeSquintRight = "", EyeDegreeLeft = "", EyeDegreeRight = "", EyeOldLeft = "", EyeOldRight = "", EyeResult = "", EyeSummary = "", EyeBlindness = "", EyeExam = "";
        public String fSexId="";
        public String summaryPhysicalExam="";
        public String StoolExamColor = "", StoolExamAppearance = "", StoolExamWbc = "", StoolExamRbc = "", StoolExamParasite = "", StoolExamSummary = "", StoolExamCulture = "", StoolExamTyphoidO = "", StoolExamTyphoidH = "";

        public String ToxiLead = "", ToxiAluminium = "", ToxiCadmium = "", ToxiMercury = "", ToxiTin = "", ToxiCopper = "", ToxiManganese = "", ToxiZinc = "", ToxiAmmonia = "";
        public String ToxiHippuric = "", ToxiMethyl = "", ToxiAcetone = "", ToxiNickel = "", ToxiChromium = "", ToxiPhenol = "", ToxiKetone = "", ToxiBenzene = "", ToxiMandelic = "", ToxiMethanol = "";
        public String ToxiEthanol = "", ToxiIPA = "", ToxiArsenic = "", ToxiHexane = "", ToxiFomaldehyde = "", ToxiTrichloroethylene = "", ToxiAntimony = "", ToxiFluoride = "";

        public String CAAFP = "", CACEA = "", CAPSA = "", CAHCG = "", CA153 = "", CA125 = "", CA199 = "";

        //public String toxicologyLead = "", toxicologyMercury = "", toxicologyBenzene = "", toxicologyXylene = "";
        //public String toxicologyLead="";
        //public String toxicologyMercury="";
        //public String toxicologyBenzene="";
        //public String toxicologyXylene="";
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
        //public String caAfp="";
        //public String caCea="";
        //public String caPsa="";
        //public String caHcg="";
        //public String ca153="";
        //public String ca125="";
        //public String ca199="";
        public String thyroidT3="";
        public String thyroidT4="";
        public String thyroidTsh="";
        public String fPatientBloodGroupId="";

        public String vdrl = "", antiHiv = "", hbsag = "", hbsab = "", amphetamine = "", hbtyping = "", AntiHav = "";

        public String disscusExam="";
        public String suggestExam="";
        public String sugar="";
        public String sugarDiagnosis="";
        public String sugarSummary="";
        public String sugarSuggess="";

        public String kidneyBunMale = "", kidneyBunFemale = "";
        public String kidneyCreatinineMale = "", kidneyCreatinineFemale = "";
        public String kidneyResult = "";
        public String kidneySummary = "";

        public String liverSgotMale="", liverSgotFeMale = "";
        public String liverSgptMale="", liverSgptFeMale = "";
        public String liverAlpMale = "", liverAlpFeMale = "", liverAlkalineMale = "", liverAlkalineFeMale = "";
        public String liverResult = "";
        public String liverSummary = "";
        public String uricAcidMale="", uricAcidFemale="";
        public String cholesterol="";
        public String triglyceride="";
        public String triglycerideResult = "";
        public String triglycerideSummary = "";
        public String hdlMale="", hdlFemale="";
        public String ldl="";

        public String calcium="";

        public String cbcHbMale = "", cbcHbFemale = "";
        public String cbcHctMale = "", cbcHctFemale = "";
        public String cbcMcvMale = "", cbcMcvFemale = "";
        public String cbcRbcMale = "", cbcRbcFemale = "";
        public String cbcWbc="";
        public String cbcNeutrophil="";
        public String cbcLymphocyte="";
        public String cbcEosinophil="";
        public String cbcMonocyte="";
        public String cbcBasophil="";
        public String cbcPlateletCount="";
        public String cbcRbcMorpholog="";
        public String cbcSummary="";
        public String cbcMch = "";
        public String cbcMchc = "";
        public String cbcPlateletSmear = "", cbcPmn = "";

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
        public String urineSummary="";
        public String urineResult = "";
        public String urineGlu = "";

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
        
        //public String toxicologyToluene="";
        public String thyroidRubellaLgg="";
        public String billirubin="";
        //public String toxicologyThinner="";
        //public String toxicologyAlcohol="";
        public String stickerQty="";
        public String statusCbc="";
        public String statusUa="";
        public String statusFbs="";
        public String statusPe="";
        public String statusXray="";
        public String statusStool="";
        
        public String cholesterolSummary="";
        public String cholesterolSuggess="";
        public String statusCholes="";
        public String StatusHbsag="";
        public String hbsagSuggess="";
        public String hbsagSummary="";        
    
        public String Active="";
        public String eyeBio="";
        public String amphetamineSummary="";
        public String amphetamineSuggess="";
        public String statusAmphetamine="";
        public String antiHivSummary="";
        public String antiHivSuggess="";
        public String statusAntiHiv="";
        public String statusUricAcid="";
        public String uricAcidSuggess="";
        public String uricAcidSummary="";
        public String statusVisit="";
        public String visitComment="";
        public String bmi="";
        public String caFt3="";
        
        //public String toxicologyHexane="";
        //public String toxicologyMethanol="";
        //public String toxicologyMek="";
        //public String toxicologyAcetone="";
        public String antiHbc="";
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
        public String urineLeu="";
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
        public String StatusCBCNotsplitMaleFemale = "";
        public String StatusSgotNotsplitMaleFemale = "";
        public String StatusBunNotsplitMaleFemale = "";
        public override String ToString()
        {
            return patientFullname;
        }
    }
}
