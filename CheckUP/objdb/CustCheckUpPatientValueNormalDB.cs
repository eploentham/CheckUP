using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CheckUP.objdb
{
    public class CustCheckUpPatientValueNormalDB
    {
        ConnectDB conn;
        public CustCheckUpPatientValueNormal ccpvn;
        public CustCheckUpPatientValueNormalDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            ccpvn = new CustCheckUpPatientValueNormal();
            ccpvn.Id = "patient_id";
            ccpvn.CustCheckUpId = "cust_checkup_id";
            ccpvn.ChecklistId = "t_checklist_id";
            ccpvn.visitHn = "visit_hn";
            ccpvn.patientFullname = "patient_fullname";
            ccpvn.patientAge = "patient_age";
            ccpvn.departmentName = "department_name";
            ccpvn.pid = "pid";
            ccpvn.patientNumber = "patient_number";
            ccpvn.sectionName = "section_name";
            ccpvn.vitalsign = "vitalsign";
            ccpvn.patientHeight = "patient_height";
            ccpvn.patientPulse = "patient_pulse";
            ccpvn.patientWeight = "patient_weight";
            //ccpvn.EyeShortLongLeft = "eye_short_long_left";
            ccpvn.EyeExam = "eyes_exam";
            ccpvn.EyeDegreeLeft = "eye_degree_left";
            ccpvn.EyeDegreeRight = "eye_degree_right";
            ccpvn.EyeShortLongLeft = "eye_short_long_left";
            ccpvn.EyeShortLongRight = "eye_short_long_right";
            ccpvn.EyeSquintLeft = "eye_squint_left";
            ccpvn.EyeSquintRight = "eye_squint_short";
            ccpvn.EyeOldLeft = "eye_old_left";
            ccpvn.EyeOldRight = "eye_old_right";
            ccpvn.EyeSummary = "eye_summary";
            ccpvn.EyeResult = "eye_result";
            ccpvn.EyeBlindness = "eye_blindness";

            ccpvn.fSexId = "f_sex_id";
            ccpvn.summaryPhysicalExam = "summary_physical_exam";

            ccpvn.StoolExamColor = "stool_exam_color";
            ccpvn.StoolExamAppearance = "stool_exam_appearance";
            ccpvn.StoolExamWbc = "stool_exam_wbc";
            ccpvn.StoolExamRbc = "stool_exam_rbc";
            ccpvn.StoolExamParasite = "stool_exam_parasite";
            ccpvn.StoolExamSummary = "stool_exam_summary";
            ccpvn.StoolExamCulture = "stool_exam_culture";
            ccpvn.StoolExamTyphoidH = "stool_exam_typhoidh";
            ccpvn.StoolExamTyphoidO = "stool_exam_typhoido";

            //ccpvn.toxicologyLead = "toxicology_lead";
            //ccpvn.toxicologyMercury = "toxicology_mercury";
            //ccpvn.toxicologyBenzene = "toxicology_benzene";
            //ccpvn.toxicologyXylene = "toxicology_xylene";
            ccpvn.Audiogram500L = "audiogram_500_left";
            ccpvn.Audiogram1000L = "audiogram_1000_left";
            ccpvn.Audiogram2000L = "audiogram_2000_left";
            ccpvn.Audiogram3000L = "audiogram_3000_left";
            ccpvn.Audiogram4000L = "audiogram_4000_left";
            ccpvn.Audiogram6000L = "audiogram_6000_left";
            ccpvn.Audiogram8000L = "audiogram_8000_left";
            ccpvn.AudiogramSummaryL = "audiogram_summary_left";
            ccpvn.Audiogram500R = "audiogram_500_right";
            ccpvn.Audiogram1000R = "audiogram_1000_right";
            ccpvn.Audiogram2000R = "audiogram_2000_right";
            ccpvn.Audiogram3000R = "audiogram_3000_right";
            ccpvn.Audiogram4000R = "audiogram_4000_rightt";
            ccpvn.Audiogram6000R = "audiogram_6000_right";
            ccpvn.Audiogram8000R = "audiogram_8000_right";
            ccpvn.AudiogramSummaryR = "audiogram_summary_right";
            ccpvn.AudiogramExam = "audiogram_exam";
            ccpvn.xrayChestExam = "xray_chest_exam";
            ccpvn.xrayChestSummary = "xray_chest_summary";
            ccpvn.eyesExam = "eyes_exam";
            ccpvn.ekgExam = "ekg_exam";

            ccpvn.CAAFP = "ca_afp";
            ccpvn.CACEA = "ca_cea";
            ccpvn.CAPSA = "ca_psa";
            ccpvn.CAHCG = "ca_hcg";
            ccpvn.CA153 = "ca_153";
            ccpvn.CA125 = "ca_125";
            ccpvn.CA199 = "ca_19_9";

            ccpvn.thyroidT3 = "thyroid_t3";
            ccpvn.thyroidT4 = "thyroid_t4";
            ccpvn.thyroidTsh = "thyroid_tsh";
            ccpvn.fPatientBloodGroupId = "f_patient_blood_group_id";
            
            ccpvn.vdrl = "vdrl";
            ccpvn.antiHiv = "anti_hiv";
            ccpvn.hbsag = "hbsag";
            ccpvn.hbsab = "hbsab";
            ccpvn.amphetamine = "amphetamine";
            ccpvn.AntiHav = "anti_hav";

            ccpvn.disscusExam = "disscus_exam";
            ccpvn.suggestExam = "suggest_exam";
            ccpvn.sugar = "sugar";
            ccpvn.sugarDiagnosis = "sugar_diagnosis";
            ccpvn.sugarSummary = "sugar_summary";
            ccpvn.sugarSuggess = "sugar_suggess";
            ccpvn.sugarValueNormal = "sugar_value_normal";
            ccpvn.sugarValueLower = "sugar_value_lower";
            ccpvn.sugarValueUpper = "sugar_value_upper";
            ccpvn.sugarValueLowerSuggess = "sugar_value_lower_suggess";
            ccpvn.sugarValueUpperSuggess = "sugar_value_upper_suggess";

            ccpvn.kidneyBunMale = "kidney_bun_male";
            ccpvn.kidneyCreatinineMale = "kidney_creatinine_male";
            ccpvn.kidneyBunFemale = "kidney_bun_female";
            ccpvn.kidneyCreatinineFemale = "kidney_creatinine_female";

            ccpvn.kidneyResult = "kidney_result";
            ccpvn.kidneySummary = "kidney_summary";
            ccpvn.liverSgotMale = "liver_sgot_male";
            ccpvn.liverSgotFeMale = "liver_sgot_female";
            ccpvn.liverSgptMale = "liver_sgpt_male";
            ccpvn.liverSgptFeMale = "liver_sgpt_female";
            ccpvn.liverAlpMale = "liver_alp_male";
            ccpvn.liverAlpFeMale = "liver_alp_female";
            ccpvn.liverResult = "liver_result";
            ccpvn.liverSummary = "liver_summary";
            ccpvn.liverAlkalineMale = "liver_alkaline_male";
            ccpvn.liverAlkalineFeMale = "liver_alkaline_female";

            ccpvn.uricAcidMale = "uric_acid_male";
            ccpvn.uricAcidFemale = "uric_acid_female";
            ccpvn.uric_acid_value_lower = "uric_acid_value_lower";
            ccpvn.uric_acid_value_lower_suggess = "uric_acid_value_lower_suggess";
            ccpvn.uric_acid_value_normal = "uric_acid_value_normal";
            ccpvn.uric_acid_value_upper = "uric_acid_value_upper";
            ccpvn.uric_acid_value_upper_suggess = "uric_acid_value_upper_suggess";

            ccpvn.cholesterol = "cholesterol";
            ccpvn.cholesterolValueNormal = "cholesterol_value_normal";
            ccpvn.cholesterolValueUpper = "cholesterol_value_upper";
            ccpvn.cholesterolValueUpperSuggess = "cholesterol_value_upper_suggess";

            ccpvn.triglyceride = "triglyceride";
            ccpvn.triglycerideValueNormal = "triglyceride_value_normal";
            ccpvn.triglycerideValueUpper = "triglyceride_value_upper";
            ccpvn.triglycerideValueUpperSuggess = "triglyceride_value_upper_suggess";

            ccpvn.triglycerideResult = "triglyceride_result";
            ccpvn.triglycerideSummary = "triglyceride_summary";
            ccpvn.hdlMale = "hdl_male";
            ccpvn.hdlFemale = "hdl_female";
            ccpvn.ldl = "ldl";
            ccpvn.ldlValueNormal = "ldl_value_normal";
            ccpvn.ldlValueUpper = "ldl_value_upper";
            ccpvn.ldlValueUpperSuggess = "ldl_value_upper_suggess";

            ccpvn.calcium = "calcium";

            ccpvn.cbcMcvMale = "cbc_mcv_male";
            ccpvn.cbcHbMale = "cbc_hb_male";
            ccpvn.cbcHctMale = "cbc_hct_male";
            ccpvn.cbcRbcMale = "cbc_rbc_male";
            ccpvn.cbcMcvFemale = "cbc_mcv_female";
            ccpvn.cbcHbFemale = "cbc_hb_female";
            ccpvn.cbcHctFemale = "cbc_hct_female";
            ccpvn.cbcRbcFemale = "cbc_rbc_female";
            ccpvn.cbcWbc = "cbc_wbc";
            ccpvn.cbcMch = "cbc_mch";
            ccpvn.cbcMchc = "cbc_mchc";
            ccpvn.cbcNeutrophil = "cbc_neutrophil";
            ccpvn.cbcLymphocyte = "cbc_lymphocyte";
            ccpvn.cbcEosinophil = "cbc_eosinophil";
            ccpvn.cbcMonocyte = "cbc_monocyte";
            ccpvn.cbcBasophil = "cbc_basophil";
            ccpvn.cbcPlateletCount = "cbc_platelet_count";
            ccpvn.cbcRbcMorpholog = "cbc_rbc_morpholog";
            ccpvn.cbcSummary = "cbc_summary";
            ccpvn.cbcPmn = "cbc_pmn";

            ccpvn.urineColor = "urine_color";
            ccpvn.urineAppearance = "urine_appearance";
            ccpvn.urinePh = "urine_ph";
            ccpvn.urineSpGr = "urine_sp_gr";
            ccpvn.urineSugar = "urine_sugar";
            ccpvn.urineProtein = "urine_protein";
            ccpvn.urineBlood = "urine_blood";
            ccpvn.urineKetone = "urine_ketone";
            ccpvn.urineBacteria = "urine_bacteria";
            ccpvn.urineWbc = "urine_wbc";
            ccpvn.urineRbc = "urine_rbc";
            ccpvn.urineEpithelium = "urine_epithelium";
            ccpvn.urineSummary = "urine_summary";
            ccpvn.urineResult = "urine_result";
            ccpvn.urineGlu = "urine_glu";
            ccpvn.urineNit = "urine_nit";
            ccpvn.urineBil = "urine_bil";
            ccpvn.urineUro = "urine_uro";
            ccpvn.urineLeu = "urine_leu";

            ccpvn.lungFvcPredic = "lung_fvc_predic";
            ccpvn.lungFvcMeas = "lung_fvc_meas";
            ccpvn.lungFvcPer = "lung_fvc_per";
            ccpvn.lungFev1Predic = "lung_fev1_predic";
            ccpvn.lungFev1Meas = "lung_fev1_meas";
            ccpvn.lungFev1Per = "lung_fev1_per";
            ccpvn.lungPerFev1 = "lung_per_fev1";
            ccpvn.lungSummary = "lung_summary";
            ccpvn.lungSuggess = "lung_suggess";
            ccpvn.statusName = "status_name";
            ccpvn.rowNumber = "row_number";

            //ccpvn.cbcMcv="";
            //ccpvn.toxicologyToluene = "toxicology_toluene";

            ccpvn.thyroidRubellaLgg = "thyroid_rubella_lgg";
            ccpvn.billirubin = "billirubin";
            //ccpvn.toxicologyThinner = "toxicology_thinner";
            //ccpvn.toxicologyAlcohol = "toxicology_alcohol";
            ccpvn.stickerQty = "sticker_qty";
            ccpvn.statusCbc = "status_cbc";
            ccpvn.statusUa = "status_ua";
            ccpvn.statusFbs = "status_fbs";
            ccpvn.statusPe = "status_pe";
            ccpvn.statusXray = "status_xray";
            ccpvn.statusStool = "status_stool";
            ccpvn.statusAntiHiv = "status_anti_hiv";
            ccpvn.statusUricAcid = "status_uric_acid";
            ccpvn.statusAmphetamine = "status_amphetamine";
            ccpvn.statusVisit = "status_visit";
            ccpvn.statusCholes = "status_choles";
            ccpvn.StatusHbsag = "status_hbsag";

            
            ccpvn.cholesterolSummary = "cholesterol_summary";
            ccpvn.cholesterolSuggess = "cholesterol_suggess";

            ccpvn.hbsagSuggess = "hbsag_suggess";
            ccpvn.hbsagSummary = "hbsag_summary";
            
            ccpvn.Active = "cust_checkup_patient_active";
            ccpvn.eyeBio = "eye_bio";
            ccpvn.amphetamineSummary = "amphetamine_summary";
            ccpvn.amphetamineSuggess = "amphetamine_suggess";

            ccpvn.antiHivSummary = "anti_hiv_summary";
            ccpvn.antiHivSuggess = "anti_hiv_suggess";
            //ccpvn.eyesExam = "";
            ccpvn.uricAcidSuggess = "uric_acid_suggess";
            ccpvn.uricAcidSummary = "uric_acid_summary";

            ccpvn.visitComment = "visit_comment";
            ccpvn.bmi = "bmi";
            ccpvn.antiHbc = "anti_hbc";
            ccpvn.caFt3 = "ca_ft3";
            ccpvn.hbtyping = "hbtyping";
            //ccpvn.toxicologyHexane = "toxicology_hexane";
            //ccpvn.toxicologyMethanol = "toxicology_methanol";
            //ccpvn.toxicologyMek = "toxicology_mek";
            //ccpvn.toxicologyAcetone = "toxicology_acetone";
            //ccpvn.antiHbc="";
            ccpvn.eyeLeft = "";
            ccpvn.eyeRight = "";
            ccpvn.opticalLeftAngle = "optical_left_angle";
            ccpvn.opticalRightAngle = "optical_right_angle";
            ccpvn.cbcMcvOld = "cbc_mcv_old";
            ccpvn.cbcHbOld = "cbc_hb_old";
            ccpvn.cbcHctOld = "cbc_hct_old";
            ccpvn.cbcWbcOld = "cbc_wbc_old";
            ccpvn.cbcNeutrophilOld = "cbc_neutrophil_old";
            ccpvn.cbcLymphocyteOld = "cbc_lymphocyte_old";
            ccpvn.cbcEosinophilOld = "cbc_eosinophil_old";
            ccpvn.cbcMonocyteOld = "cbc_monocyte_old";
            ccpvn.cbcBasophilOld = "cbc_basophil_old";
            ccpvn.cbcPlateletCountOld = "cbc_platelet_count_old";
            ccpvn.cbcRbcMorphologOld = "cbc_rbc_morpholog_old";
            ccpvn.cbcSummaryOld = "cbc_summary_old";
            ccpvn.cbcRbcOld = "cbc_rbc_old";
            ccpvn.cbcMchcOld = "cbc_mchc_old";
            ccpvn.cbcMchOld = "cbc_mch_old";
            ccpvn.cbcPlateletSmear = "cbc_platelet_smear";
            ccpvn.sugarOld = "sugar_old";
            ccpvn.kidneyBunOld = "kidney_bun_old";
            ccpvn.kidneyCreatinineOld = "kidney_creatinine_old";
            ccpvn.liverSgotOld = "liver_sgot_old";
            ccpvn.liverSgptOld = "liver_sgpt_old";
            ccpvn.liverAlpOld = "liver_alp_old";
            ccpvn.uricAcidOld = "uric_acid_old";
            ccpvn.cholesterolOld = "cholesterol_old";
            ccpvn.triglycerideOld = "triglyceride_old";
            ccpvn.hdlOld = "hdl_old";
            ccpvn.ldlOld = "ldl_old";
            //ccpvn.toxicologyLeadOld = "toxicology_lead_old";
            //ccpvn.toxicologyMercuryOld = "toxicology_mercury_old";
            //ccpvn.toxicologyBenzeneOld = "toxicology_benzene_old";
            //ccpvn.toxicologyXyleneOld = "toxicology_xylene_old";
            //ccpvn.toxicologyThinnerOld = "toxicology_thinner_old";
            //ccpvn.toxicologyAlcoholOld = "toxicology_alcohol_old";
            //ccpvn.toxicologyHexaneOld = "toxicology_hexane_old";
            //ccpvn.toxicologyMethanolOld = "toxicology_methanol_old";
            //ccpvn.toxicologyMekOld = "toxicology_mek_old";
            //ccpvn.toxicologyAcetoneOld = "toxicology_acetone_old";
            //ccpvn.toxicologyTolueneOld = "toxicology_toluene_old";
            
            ccpvn.urineOther = "urine_other";
            ccpvn.cultureStool = "culture_stool";
            ccpvn.cultureUrine = "culture_urine";
            ccpvn.cultureBacteria = "culture_bacteria";
            ccpvn.cultureSputum = "culture_sputum";
            ccpvn.marketingCheckupPatientOldId = "marketing_checkup_patient_old_id";
            ccpvn.thyroidFt3 = "thyroid_ft3";
            ccpvn.thyroidFt4 = "thyroid_ft4";
            ccpvn.amylase = "amylase";
            ccpvn.totalProtein = "total_protein";
            ccpvn.albumin = "albumin";
            ccpvn.globulin = "globulin";
            ccpvn.albuminGlobulin = "albumin_globulin";
            ccpvn.directBillirubin = "direct_billirubin";
            ccpvn.colorBlindness = "color_blindness";

            ccpvn.ToxiAcetone = "toxicology_acetone";
            ccpvn.ToxiAluminium = "toxicology_aluminium";
            ccpvn.ToxiAmmonia = "toxicology_ammonia";
            ccpvn.ToxiAntimony = "toxicology_antimony";
            ccpvn.ToxiArsenic = "toxicology_arsenic";
            ccpvn.ToxiBenzene = "toxicology_benzene";
            ccpvn.ToxiCadmium = "toxicology_cadmium";
            ccpvn.ToxiChromium = "toxicology_chromium";
            ccpvn.ToxiCopper = "toxicology_copper";
            ccpvn.ToxiEthanol = "toxicology_ethanol";
            ccpvn.ToxiFluoride = "toxicology_fluoride";
            ccpvn.ToxiFomaldehyde = "toxicology_fomaldehyde";
            ccpvn.ToxiHexane = "toxicology_hexane";
            ccpvn.ToxiHippuric = "toxicology_hippuric";
            ccpvn.ToxiIPA = "toxicology_ipa";
            ccpvn.ToxiKetone = "toxicology_ketone";
            ccpvn.ToxiLead = "toxicology_lead";
            ccpvn.ToxiMandelic = "toxicology_mandelic";
            ccpvn.ToxiManganese = "toxicology_manganese";
            ccpvn.ToxiMercury = "toxicology_mercury";
            ccpvn.ToxiMethanol = "toxicology_methanol";
            ccpvn.ToxiMethyl = "toxicology_methyl";
            ccpvn.ToxiNickel = "toxicology_nickel";
            ccpvn.ToxiPhenol = "toxicology_phenol";
            ccpvn.ToxiTin = "toxicology_tin";
            ccpvn.ToxiTrichloroethylene = "toxicology_trichloroethylenel";
            ccpvn.ToxiZinc = "toxicology_zinc";
            ccpvn.StatusCBCNotsplitMaleFemale = "status_cbcnotsplitmalefemale";
            ccpvn.StatusSgotNotsplitMaleFemale = "status_sgotnotsplitmalefemale";
            ccpvn.StatusBunNotsplitMaleFemale = "status_bunnotsplitmalefemale";

            ccpvn.pkField = "patient_id";
            ccpvn.table = "b_cust_checkup_patient_value_normal";
        }
        public DataTable selectByPk()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccpvn.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public CustCheckUpPatientValueNormal selectByPk1()
        {
            String sql = "";
            DataTable dt = new DataTable();
            CustCheckUpPatientValueNormal ccpvn1 = new CustCheckUpPatientValueNormal();
            sql = "Select * From " + ccpvn.table + " ";
            dt = conn.selectData(sql);
            ccpvn1 = setCustCheckUpPatientValueNormal(dt);
            return ccpvn1;
        }
        public String UpdateFBS(String value)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.sugar + "='" + value + "' ";
                //ccp.sugarDiagnosis + "='" + result + "', " +
                //ccp.sugarSummary + "='" + summary + "', " +
                //ccp.sugarSuggess + "='" + suggess + "' " +
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateFBS1(String value, String valueNormal, String valueLower, String valueUpper, String lowerSuggess, String upperSuggess)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.sugar + "='" + value + "', "+
                ccpvn.sugarValueNormal + "='" + valueNormal + "', " +
                ccpvn.sugarValueLower + "='" + valueLower + "', " +
                ccpvn.sugarValueUpper + "='" + valueUpper + "', " +
                ccpvn.sugarValueLowerSuggess + "='" + lowerSuggess + "', "+
                ccpvn.sugarValueUpperSuggess + "='" + upperSuggess + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBC(String Basophil, String Eosinophil, String HbMale, String HbFemale, String HctMale, String HctFemale, String Lymphocyte,
            String Mch, String Mchc, String McvMale, String McvFemale, String Monocyte, String Neutrophil, String PlateletCount, String RbcMale, String RbcFemale, String RbcMorpholog,
            String Wbc, String PlateletSmear, String Pmn, String statCBCsplitMaleFemale)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.cbcBasophil + "='" + Basophil + "'," +
                ccpvn.cbcEosinophil + "='" + Eosinophil + "', " +
                ccpvn.cbcHbMale + "='" + HbMale + "', " +
                ccpvn.cbcHbFemale + "='" + HbFemale + "', " +
                ccpvn.cbcHctMale + "='" + HctMale + "', " +
                ccpvn.cbcHctFemale + "='" + HctFemale + "', " +
                ccpvn.cbcLymphocyte + "='" + Lymphocyte + "', " +
                ccpvn.cbcMch + "='" + Mch + "', " +
                ccpvn.cbcMchc + "='" + Mchc + "', " +
                ccpvn.cbcMcvMale + "='" + McvMale + "', " +
                ccpvn.cbcMcvFemale + "='" + McvFemale + "', " +
                ccpvn.cbcMonocyte + "='" + Monocyte + "', " +
                ccpvn.cbcNeutrophil + "='" + Neutrophil + "', " +
                ccpvn.cbcPlateletCount + "='" + PlateletCount + "', " +
                ccpvn.cbcPlateletSmear + "='" + PlateletSmear + "', " +
                ccpvn.cbcRbcMale + "='" + RbcMale + "', " +
                ccpvn.cbcRbcFemale + "='" + RbcFemale + "', " +
                ccpvn.cbcRbcMorpholog + "='" + RbcMorpholog + "', " +
                ccpvn.cbcPmn + "='" + Pmn + "', " +
                ccpvn.cbcWbc + "='" + Wbc + "', " +
                ccpvn.StatusCBCNotsplitMaleFemale + "='"+ statCBCsplitMaleFemale+"'";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUA(String Color, String Appe, String Sugar, String spgr, String pH,
            String Protein, String Wbc, String Rbc, String Epi, String Bact, String ketone, String leu, String blood
            , String glu, String bil, String nit, String uro)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.urineColor + "='" + Color + "'," +
                ccpvn.urineAppearance + "='" + Appe + "', " +
                ccpvn.urineSugar + "='" + Sugar + "', " +
                ccpvn.urineSpGr + "='" + spgr + "', " +
                ccpvn.urinePh + "='" + pH + "', " +
                ccpvn.urineProtein + "='" + Protein + "', " +
                ccpvn.urineWbc + "='" + Wbc + "', " +
                ccpvn.urineRbc + "='" + Rbc + "', " +
                ccpvn.urineEpithelium + "='" + Epi + "', " +
                ccpvn.urineBacteria + "='" + Bact + "', " +
                ccpvn.urineLeu + "='" + leu + "', " +
                ccpvn.urineKetone + "='" + ketone + "', " +
                ccpvn.urineBlood + "='" + blood + "', "+
                ccpvn.urineGlu + "='" + glu + "' " +
                ", "+ccpvn.urineBil + "='" + bil + "' " +
                ", "+ccpvn.urineNit + "='" + nit + "' " +
                ", "+ccpvn.urineUro + "='" + uro + "' " ;
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateTrigly(String value, String valueNormal, String valueUpper, String upperSuggess)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.triglyceride + "='" + value + "', "+
                ccpvn.triglycerideValueNormal + "='" + valueNormal + "', " +
                ccpvn.triglycerideValueUpper + "='" + valueUpper + "', " +
                ccpvn.triglycerideValueUpperSuggess + "='" + upperSuggess + "' ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCholes(String value, String hdlMale, String hdlFemale, String cholesValueNormal
            , String cholesValueUpper, String cholesValueUpperSuggess)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.cholesterol + "='" + value + "'," +
                    //ccp.cholesterolSuggess + "='" + result + "', " +
                ccpvn.hdlFemale + "='" + hdlFemale + "', " +                
                ccpvn.cholesterolValueNormal + "='" + cholesValueNormal + "', "+
                ccpvn.cholesterolValueUpper + "='" + cholesValueUpper + "', "+
                ccpvn.cholesterolValueUpperSuggess + "='" + cholesValueUpperSuggess + "', "+
                ccpvn.hdlMale + "='" + hdlMale + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateLDL(String value, String valueNormal
            , String valueUpper, String valueUpperSuggess)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.ldl + "='" + value + "'," +
                ccpvn.ldlValueNormal + "='" + valueNormal + "', " +
                ccpvn.ldlValueUpper + "='" + valueUpper + "', " +
                ccpvn.ldlValueUpperSuggess + "='" + valueUpperSuggess + "' ";
                
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateSgot(String sgotmale, String sgptmale, String altmale, String alkalinemale
            , String sgotfemale, String sgptfemale, String altfemale, String alkalinefemale, String statSgotsplitMaleFemale)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.liverSgotMale + "='" + sgotmale + "'," +
                    //ccp.liverResult + "='" + result + "', " +
                    //ccp.liverSummary + "='" + summary + "', " +
                ccpvn.liverAlpMale + "='" + altmale + "', " +
                ccpvn.liverSgptMale + "='" + sgptmale + "', "+
                ccpvn.liverAlkalineMale + "='" + alkalinemale + "', "+
                ccpvn.liverSgotFeMale + "='" + sgotfemale + "', " +
                ccpvn.liverSgptFeMale + "='" + sgptfemale + "', " +
                ccpvn.liverAlkalineFeMale + "='" + alkalinefemale + "', "+
                ccpvn.liverAlpFeMale + "='" + altfemale + "', "+
                ccpvn.StatusSgotNotsplitMaleFemale + "='" + statSgotsplitMaleFemale + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateBun(String bunMale, String creatinineMale, String bunFemale, String creatinineFemale, String statBunsplitMaleFemale)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.kidneyBunMale + "='" + bunMale + "'," +
                    ccpvn.kidneyBunFemale + "='" + bunFemale + "', " +
                    ccpvn.kidneyCreatinineFemale + "='" + creatinineFemale + "', " +
                    ccpvn.kidneyCreatinineMale + "='" + creatinineMale + "', "+
                    ccpvn.StatusBunNotsplitMaleFemale + "='" + statBunsplitMaleFemale + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUric(String male, String Female)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.uricAcidMale + "='" + male + "', " +
                ccpvn.uricAcidFemale + "='" + Female + "' ";
                //ccp.uricAcidSummary + "='" + summary + "' " +
                    //ccp.sugarSuggess + "='" + suggess + "' " +
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateOther1(String HBsAg, String HbsAb, String AntiHIV, String VDRL, String Amphetamine, String Calcium, String AntiHav,
            String CAAFP = "", String CACEA = "", String CAPSA = "", String CAHCG = "", String CA153 = "", String CA125 = "", String CA199 = "")
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.hbsag + "='" + HBsAg + "'," +
                ccpvn.hbsab + "='" + HbsAb + "', " +
                ccpvn.antiHiv + "='" + AntiHIV + "', " +
                ccpvn.vdrl + "='" + VDRL + "', " +
                ccpvn.amphetamine + "='" + Amphetamine + "', " +
                ccpvn.calcium + "='" + Calcium + "', " +
                ccpvn.AntiHav + "='" + AntiHav + "', " +
                ccpvn.CAAFP + "='" + CAAFP + "', " +
                ccpvn.CACEA + "='" + CACEA + "', " +
                ccpvn.CAPSA + "='" + CAPSA + "', " +
                ccpvn.CAHCG + "='" + CAHCG + "', " +
                ccpvn.CA153 + "='" + CA153 + "', " +
                ccpvn.CA125 + "='" + CA125 + "', " +
                ccpvn.CA199 + "='" + CA199 + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateLung(String LungFvcPredic, String LungFvcMeas, String LungFvcPer, String LungFev1Predic, String LungFev1Meas,
            String LungFev1Per, String LungPerFev1)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.lungFvcPredic + "='" + LungFvcPredic + "'," +
                ccpvn.lungFvcMeas + "='" + LungFvcMeas + "', " +
                ccpvn.lungFvcPer + "='" + LungFvcPer + "', " +
                ccpvn.lungFev1Predic + "='" + LungFev1Predic + "', " +
                ccpvn.lungFev1Meas + "='" + LungFev1Meas + "', " +
                ccpvn.lungFev1Per + "='" + LungFev1Per + "', " +
                ccpvn.lungPerFev1 + "='" + LungPerFev1 + "' ";
                //ccpvn.lungSummary + "='" + LungSummary + "' " +
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateAudioGram(String Audiogram500L, String Audiogram500R, String Audiogram1000L, String Audiogram1000R, String Audiogram2000L, String Audiogram2000R,
            String Audiogram3000L, String Audiogram3000R, String Audiogram4000L, String Audiogram4000R, String Audiogram6000L, String Audiogram6000R, String Audiogram8000L, String Audiogram8000R)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccpvn.table + " Set " + ccpvn.Audiogram500L + "='" + Audiogram500L + "', " +
                ccpvn.Audiogram500R + "='" + Audiogram500R + "', " +
                ccpvn.Audiogram1000L + "='" + Audiogram1000L + "', " +
                ccpvn.Audiogram1000R + "='" + Audiogram1000R + "', " +
                ccpvn.Audiogram2000L + "='" + Audiogram2000L + "', " +
                ccpvn.Audiogram2000R + "='" + Audiogram2000R + "', " +
                ccpvn.Audiogram3000L + "='" + Audiogram3000L + "', " +
                ccpvn.Audiogram3000R + "='" + Audiogram3000R + "', " +
                ccpvn.Audiogram4000L + "='" + Audiogram4000L + "', " +
                ccpvn.Audiogram4000R + "='" + Audiogram4000R + "', " +
                ccpvn.Audiogram6000L + "='" + Audiogram6000L + "', " +
                ccpvn.Audiogram6000R + "='" + Audiogram6000R + "', " +
                ccpvn.Audiogram8000L + "='" + Audiogram8000L + "', " +
                ccpvn.Audiogram8000R + "='" + Audiogram8000R + "' ";
                //ccpvn.AudiogramSummaryL + "='" + AudiogramSummaryL + "', " +
                //ccpvn.AudiogramSummaryR + "='" + AudiogramSummaryR + "', " +
                //ccpvn.AudiogramExam + "='" + AudiogramExam + "' " +
                //"Where " + ccpvn.CustCheckUpId + "='" + cucId + "' and " + ccpvn.rowNumber + "=" + rowNumber + " ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update updateAudioGram");
            }
            finally
            {
            }
            return chk;
        }
        public String updateEye(String EyeShortLongLeft, String EyeShortLongRight, String EyeSquintLeft, String EyeSquintRight,
            String EyeDegreeLeft, String EyeDegreeRight, String EyeOldLeft, String EyeOldRight, String EyeBlindness, String EyeExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccpvn.table + " Set " + ccpvn.EyeShortLongLeft + "='" + EyeShortLongLeft + "', " +
                ccpvn.EyeShortLongRight + "='" + EyeShortLongRight + "', " +
                ccpvn.EyeSquintLeft + "='" + EyeSquintLeft + "', " +
                ccpvn.EyeSquintRight + "='" + EyeSquintRight + "', " +
                ccpvn.EyeDegreeLeft + "='" + EyeDegreeLeft + "', " +
                ccpvn.EyeDegreeRight + "='" + EyeDegreeRight + "', " +
                ccpvn.EyeOldLeft + "='" + EyeOldLeft + "', " +
                ccpvn.EyeOldRight + "='" + EyeOldRight + "', " +
                ccpvn.EyeExam + "='" + EyeExam + "', " +
                //ccp.EyeSummary + "='" + EyeSummary + "', " +
                ccpvn.EyeBlindness + "='" + EyeBlindness + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update updateEye");
            }
            finally
            {
            }
            return chk;
        }
        public String updateStoolExam(String StoolExamAppearance, String StoolExamColor, String StoolExamWbc, String StoolExamRbc, String StoolExamParasite,
            String StoolExamCulture, String StoolExamTyhoidH, String StoolExamTyhoidO)
        {
            String sql = "", chk = "";

            sql = "Update " + ccpvn.table + " Set " + ccpvn.StoolExamAppearance + "='" + StoolExamAppearance + "', " +
                ccpvn.StoolExamColor + "='" + StoolExamColor + "', " +
                ccpvn.StoolExamWbc + "='" + StoolExamWbc + "', " +
                ccpvn.StoolExamRbc + "='" + StoolExamRbc + "', " +
                ccpvn.StoolExamParasite + "='" + StoolExamParasite + "', "+
                ccpvn.StoolExamCulture + "='" + StoolExamCulture + "', "+
                ccpvn.StoolExamTyphoidH + "='" + StoolExamTyhoidH + "', " +
                ccpvn.StoolExamTyphoidO + "='" + StoolExamTyhoidO + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update updateStoolExam");
            }
            finally
            {
            }
            return chk;
        }
        public String updateToxi1(String ToxiLead, String ToxiAluminium, String ToxiCadmium, String ToxiMercury, String ToxiTin, String ToxiCopper,
            String ToxiManganese, String ToxiZinc, String ToxiAmmonia)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccpvn.table + " Set " + ccpvn.ToxiLead + "='" + ToxiLead + "', " +
                ccpvn.ToxiAluminium + "='" + ToxiAluminium + "', " +
                ccpvn.ToxiCadmium + "='" + ToxiCadmium + "', " +
                ccpvn.ToxiMercury + "='" + ToxiMercury + "', " +
                ccpvn.ToxiTin + "='" + ToxiTin + "', " +
                ccpvn.ToxiCopper + "='" + ToxiCopper + "', " +
                ccpvn.ToxiManganese + "='" + ToxiManganese + "', " +
                ccpvn.ToxiZinc + "='" + ToxiZinc + "', " +
                ccpvn.ToxiAmmonia + "='" + ToxiAmmonia + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update updateAudioGram");
            }
            finally
            {
            }
            return chk;
        }
        public String updateToxi2(String ToxiHippuric, String ToxiMethyl, String ToxiAcetone, String ToxiNickel, String ToxiChromium, String ToxiPhenol,
            String ToxiKetone, String ToxiBenzene, String ToxiMandelic, String ToxiMethanol, String ToxiEthanol, String ToxiIPA, String ToxiArsenic, String ToxiHexane,
            String ToxiFomaldehyde, String ToxiTrichloroethylene, String ToxiAntimony, String ToxiFluoride)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccpvn.table + " Set " + ccpvn.ToxiHippuric + "='" + ToxiHippuric + "', " +
                ccpvn.ToxiMethyl + "='" + ToxiMethyl + "', " +
                ccpvn.ToxiAcetone + "='" + ToxiAcetone + "', " +
                ccpvn.ToxiNickel + "='" + ToxiNickel + "', " +
                ccpvn.ToxiChromium + "='" + ToxiChromium + "', " +
                ccpvn.ToxiPhenol + "='" + ToxiPhenol + "', " +
                ccpvn.ToxiKetone + "='" + ToxiKetone + "', " +
                ccpvn.ToxiBenzene + "='" + ToxiBenzene + "', " +
                ccpvn.ToxiMandelic + "='" + ToxiMandelic + "', " +
                ccpvn.ToxiMethanol + "='" + ToxiMethanol + "', " +
                ccpvn.ToxiEthanol + "='" + ToxiEthanol + "', " +
                ccpvn.ToxiIPA + "='" + ToxiIPA + "', " +
                ccpvn.ToxiArsenic + "='" + ToxiArsenic + "', " +
                ccpvn.ToxiHexane + "='" + ToxiHexane + "', " +
                ccpvn.ToxiFomaldehyde + "='" + ToxiFomaldehyde + "', " +
                ccpvn.ToxiTrichloroethylene + "='" + ToxiTrichloroethylene + "', " +
                ccpvn.ToxiAntimony + "='" + ToxiAntimony + "', " +
                ccpvn.ToxiFluoride + "='" + ToxiFluoride + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error " + ex.ToString(), "update updateAudioGram");
            }
            finally
            {
            }
            return chk;
        }
        public CustCheckUpPatientValueNormal setCustCheckUpPatientValueNormal(DataTable dt)
        {
            CustCheckUpPatientValueNormal ccpvn1 = new CustCheckUpPatientValueNormal();
            if (dt.Rows.Count > 0)
            {
                ccpvn1.Id = "";
                ccpvn1.CustCheckUpId = "";
                ccpvn1.ChecklistId = "";
                ccpvn1.visitHn = "";
                ccpvn1.patientFullname = "";
                ccpvn1.patientAge = "";
                ccpvn1.departmentName = "";
                ccpvn1.pid = "";
                ccpvn1.patientNumber = "";
                ccpvn1.sectionName = "";
                ccpvn1.vitalsign = "";
                ccpvn1.patientHeight = "";
                ccpvn1.patientPulse = "";
                ccpvn1.patientWeight = "";
                //ccpvn1.EyeShortLongLeft = "eye_short_long_left";
                ccpvn1.EyeExam = "";
                ccpvn1.EyeDegreeLeft = "";
                ccpvn1.EyeDegreeRight = "";
                ccpvn1.EyeShortLongLeft = "";
                ccpvn1.EyeShortLongRight = "";
                ccpvn1.EyeSquintLeft = "";
                ccpvn1.EyeSquintRight = "";
                ccpvn1.EyeOldLeft = "";
                ccpvn1.EyeOldRight = "";
                ccpvn1.EyeSummary = "";
                ccpvn1.EyeResult = "";
                ccpvn1.EyeBlindness = "";

                ccpvn1.fSexId = "";
                ccpvn1.summaryPhysicalExam = "";

                ccpvn1.StoolExamColor = "";
                ccpvn1.StoolExamAppearance = "";
                ccpvn1.StoolExamWbc = "";
                ccpvn1.StoolExamRbc = "";
                ccpvn1.StoolExamParasite = "";
                ccpvn1.StoolExamSummary = "";
                ccpvn1.StoolExamCulture = "";
                ccpvn1.StoolExamTyphoidH = "";
                ccpvn1.StoolExamTyphoidO = "";

                //ccpvn1.toxicologyLead = "toxicology_lead";
                //ccpvn1.toxicologyMercury = "toxicology_mercury";
                //ccpvn1.toxicologyBenzene = "toxicology_benzene";
                //ccpvn1.toxicologyXylene = "toxicology_xylene";
                ccpvn1.Audiogram500L = "";
                ccpvn1.Audiogram1000L = "";
                ccpvn1.Audiogram2000L = "";
                ccpvn1.Audiogram3000L = "";
                ccpvn1.Audiogram4000L = "";
                ccpvn1.Audiogram6000L = "";
                ccpvn1.Audiogram8000L = "";
                ccpvn1.AudiogramSummaryL = "";
                ccpvn1.Audiogram500R = "";
                ccpvn1.Audiogram1000R = "";
                ccpvn1.Audiogram2000R = "";
                ccpvn1.Audiogram3000R = "";
                ccpvn1.Audiogram4000R = "";
                ccpvn1.Audiogram6000R = "";
                ccpvn1.Audiogram8000R = "";
                ccpvn1.AudiogramSummaryR = "";
                ccpvn1.AudiogramExam = "";
                ccpvn1.xrayChestExam = "";
                ccpvn1.xrayChestSummary = "";
                ccpvn1.eyesExam = "";
                ccpvn1.ekgExam = "";

                ccpvn1.CAAFP = "";
                ccpvn1.CACEA = "";
                ccpvn1.CAPSA = "";
                ccpvn1.CAHCG = "";
                ccpvn1.CA153 = "";
                ccpvn1.CA125 = "";
                ccpvn1.CA199 = "";

                ccpvn1.thyroidT3 = "";
                ccpvn1.thyroidT4 = "";
                ccpvn1.thyroidTsh = "";
                ccpvn1.fPatientBloodGroupId = "";

                ccpvn1.vdrl = "";
                ccpvn1.antiHiv = "";
                ccpvn1.hbsag = "";
                ccpvn1.hbsab = "";
                ccpvn1.amphetamine = "";
                ccpvn1.AntiHav = "";

                ccpvn1.disscusExam = "";
                ccpvn1.suggestExam = "";
                ccpvn1.sugar = "";
                ccpvn1.sugarDiagnosis = "";
                ccpvn1.sugarSummary = dt.Rows[0][ccpvn.sugarSummary].ToString();
                ccpvn1.sugarSuggess = "";
                ccpvn1.sugarValueNormal = dt.Rows[0][ccpvn.sugarValueNormal].ToString();
                ccpvn1.sugarValueLower = dt.Rows[0][ccpvn.sugarValueLower].ToString();
                ccpvn1.sugarValueUpper = dt.Rows[0][ccpvn.sugarValueUpper].ToString();
                ccpvn1.sugarValueLowerSuggess = dt.Rows[0][ccpvn.sugarValueLowerSuggess].ToString();
                ccpvn1.sugarValueUpperSuggess = dt.Rows[0][ccpvn.sugarValueUpperSuggess].ToString();

                ccpvn1.kidneyBunMale = "";
                ccpvn1.kidneyCreatinineMale = "";
                ccpvn1.kidneyBunFemale = "";
                ccpvn1.kidneyCreatinineFemale = "";

                ccpvn1.kidneyResult = "";
                ccpvn1.kidneySummary = "";
                ccpvn1.liverSgotMale = "";
                ccpvn1.liverSgotFeMale = "";
                ccpvn1.liverSgptMale = "";
                ccpvn1.liverSgptFeMale = "";
                ccpvn1.liverAlpMale = "";
                ccpvn1.liverAlpFeMale = "";
                ccpvn1.liverResult = "";
                ccpvn1.liverSummary = "";
                ccpvn1.liverAlkalineMale = "";
                ccpvn1.liverAlkalineFeMale = "";

                ccpvn1.uricAcidMale = "";
                ccpvn1.uricAcidFemale = "";
                ccpvn1.uric_acid_value_lower = "";
                ccpvn1.uric_acid_value_lower_suggess = "";
                ccpvn1.uric_acid_value_normal = "";
                ccpvn1.uric_acid_value_upper = "";
                ccpvn1.uric_acid_value_upper_suggess = "";

                ccpvn1.cholesterol = "";
                ccpvn1.cholesterolValueNormal = "";
                ccpvn1.cholesterolValueUpper = "";
                ccpvn1.cholesterolValueUpperSuggess = "";

                ccpvn1.triglyceride = "";
                ccpvn1.triglycerideValueNormal = "";
                ccpvn1.triglycerideValueUpper = "";
                ccpvn1.triglycerideValueUpperSuggess = "";

                ccpvn1.triglycerideResult = "";
                ccpvn1.triglycerideSummary = "";
                ccpvn1.hdlMale = "";
                ccpvn1.hdlFemale = "";
                ccpvn1.ldl = "";
                ccpvn1.ldlValueNormal = "";
                ccpvn1.ldlValueUpper = "";
                ccpvn1.ldlValueUpperSuggess = "";

                ccpvn1.calcium = "";

                ccpvn1.cbcMcvMale = "";
                ccpvn1.cbcHbMale = "";
                ccpvn1.cbcHctMale = "";
                ccpvn1.cbcRbcMale = "";
                ccpvn1.cbcMcvFemale = "";
                ccpvn1.cbcHbFemale = "";
                ccpvn1.cbcHctFemale = "";
                ccpvn1.cbcRbcFemale = "";
                ccpvn1.cbcWbc = "";
                ccpvn1.cbcMch = "";
                ccpvn1.cbcMchc = "";
                ccpvn1.cbcNeutrophil = "";
                ccpvn1.cbcLymphocyte = "";
                ccpvn1.cbcEosinophil = "";
                ccpvn1.cbcMonocyte = "";
                ccpvn1.cbcBasophil = "";
                ccpvn1.cbcPlateletCount = "";
                ccpvn1.cbcRbcMorpholog = "";
                ccpvn1.cbcSummary = "";
                ccpvn1.cbcPmn = "";

                ccpvn1.urineColor = "";
                ccpvn1.urineAppearance = "";
                ccpvn1.urinePh = "";
                ccpvn1.urineSpGr = "";
                ccpvn1.urineSugar = "";
                ccpvn1.urineProtein = "";
                ccpvn1.urineBlood = "";
                ccpvn1.urineKetone = "";
                ccpvn1.urineBacteria = "";
                ccpvn1.urineWbc = "";
                ccpvn1.urineRbc = "";
                ccpvn1.urineEpithelium = "";
                ccpvn1.urineSummary = "";
                ccpvn1.urineResult = "";
                ccpvn1.urineGlu = "";
                ccpvn1.urineNit = "";
                ccpvn1.urineBil = "";
                ccpvn1.urineUro = "";
                ccpvn1.urineLeu = "";

                ccpvn1.lungFvcPredic = "";
                ccpvn1.lungFvcMeas = "";
                ccpvn1.lungFvcPer = "";
                ccpvn1.lungFev1Predic = "";
                ccpvn1.lungFev1Meas = "";
                ccpvn1.lungFev1Per = "";
                ccpvn1.lungPerFev1 = "";
                ccpvn1.lungSummary = "";
                ccpvn1.lungSuggess = "";
                ccpvn1.statusName = "";
                ccpvn1.rowNumber = "";

                //ccpvn1.cbcMcv="";
                //ccpvn1.toxicologyToluene = "toxicology_toluene";

                ccpvn1.thyroidRubellaLgg = "";
                ccpvn1.billirubin = "";
                //ccpvn1.toxicologyThinner = "toxicology_thinner";
                //ccpvn1.toxicologyAlcohol = "toxicology_alcohol";
                ccpvn1.stickerQty = "";
                ccpvn1.statusCbc = "";
                ccpvn1.statusUa = "";
                ccpvn1.statusFbs = "";
                ccpvn1.statusPe = "";
                ccpvn1.statusXray = "";
                ccpvn1.statusStool = "";
                ccpvn1.statusAntiHiv = "";
                ccpvn1.statusUricAcid = "";
                ccpvn1.statusAmphetamine = "";
                ccpvn1.statusVisit = "";
                ccpvn1.statusCholes = "";
                ccpvn1.StatusHbsag = "";


                ccpvn1.cholesterolSummary = "";
                ccpvn1.cholesterolSuggess = "";

                ccpvn1.hbsagSuggess = "";
                ccpvn1.hbsagSummary = "";

                ccpvn1.Active = "";
                ccpvn1.eyeBio = "";
                ccpvn1.amphetamineSummary = "";
                ccpvn1.amphetamineSuggess = "";

                ccpvn1.antiHivSummary = "";
                ccpvn1.antiHivSuggess = "";
                //ccpvn1.eyesExam = "";
                ccpvn1.uricAcidSuggess = "";
                ccpvn1.uricAcidSummary = "";

                ccpvn1.visitComment = "";
                ccpvn1.bmi = "";
                ccpvn1.antiHbc = "";
                ccpvn1.caFt3 = "";
                ccpvn1.hbtyping = "";
                //ccpvn1.toxicologyHexane = "toxicology_hexane";
                //ccpvn1.toxicologyMethanol = "toxicology_methanol";
                //ccpvn1.toxicologyMek = "toxicology_mek";
                //ccpvn1.toxicologyAcetone = "toxicology_acetone";
                //ccpvn1.antiHbc="";
                ccpvn1.eyeLeft = "";
                ccpvn1.eyeRight = "";
                ccpvn1.opticalLeftAngle = "";
                ccpvn1.opticalRightAngle = "";
                ccpvn1.cbcMcvOld = "";
                ccpvn1.cbcHbOld = "";
                ccpvn1.cbcHctOld = "";
                ccpvn1.cbcWbcOld = "";
                ccpvn1.cbcNeutrophilOld = "";
                ccpvn1.cbcLymphocyteOld = "";
                ccpvn1.cbcEosinophilOld = "";
                ccpvn1.cbcMonocyteOld = "";
                ccpvn1.cbcBasophilOld = "";
                ccpvn1.cbcPlateletCountOld = "";
                ccpvn1.cbcRbcMorphologOld = "";
                ccpvn1.cbcSummaryOld = "";
                ccpvn1.cbcRbcOld = "";
                ccpvn1.cbcMchcOld = "";
                ccpvn1.cbcMchOld = "";
                ccpvn1.cbcPlateletSmear = "";
                ccpvn1.sugarOld = "";
                ccpvn1.kidneyBunOld = "";
                ccpvn1.kidneyCreatinineOld = "";
                ccpvn1.liverSgotOld = "";
                ccpvn1.liverSgptOld = "";
                ccpvn1.liverAlpOld = "";
                ccpvn1.uricAcidOld = "";
                ccpvn1.cholesterolOld = "";
                ccpvn1.triglycerideOld = "";
                ccpvn1.hdlOld = "";
                ccpvn1.ldlOld = "";
                //ccpvn1.toxicologyLeadOld = "toxicology_lead_old";
                //ccpvn1.toxicologyMercuryOld = "toxicology_mercury_old";
                //ccpvn1.toxicologyBenzeneOld = "toxicology_benzene_old";
                //ccpvn1.toxicologyXyleneOld = "toxicology_xylene_old";
                //ccpvn1.toxicologyThinnerOld = "toxicology_thinner_old";
                //ccpvn1.toxicologyAlcoholOld = "toxicology_alcohol_old";
                //ccpvn1.toxicologyHexaneOld = "toxicology_hexane_old";
                //ccpvn1.toxicologyMethanolOld = "toxicology_methanol_old";
                //ccpvn1.toxicologyMekOld = "toxicology_mek_old";
                //ccpvn1.toxicologyAcetoneOld = "toxicology_acetone_old";
                //ccpvn1.toxicologyTolueneOld = "toxicology_toluene_old";

                ccpvn1.urineOther = "";
                ccpvn1.cultureStool = "";
                ccpvn1.cultureUrine = "";
                ccpvn1.cultureBacteria = "";
                ccpvn1.cultureSputum = "";
                ccpvn1.marketingCheckupPatientOldId = "";
                ccpvn1.thyroidFt3 = "";
                ccpvn1.thyroidFt4 = "";
                ccpvn1.amylase = "";
                ccpvn1.totalProtein = "";
                ccpvn1.albumin = "";
                ccpvn1.globulin = "";
                ccpvn1.albuminGlobulin = "";
                ccpvn1.directBillirubin = "";
                ccpvn1.colorBlindness = "";

                ccpvn1.ToxiAcetone = "";
                ccpvn1.ToxiAluminium = "";
                ccpvn1.ToxiAmmonia = "";
                ccpvn1.ToxiAntimony = "";
                ccpvn1.ToxiArsenic = "";
                ccpvn1.ToxiBenzene = "";
                ccpvn1.ToxiCadmium = "";
                ccpvn1.ToxiChromium = "";
                ccpvn1.ToxiCopper = "";
                ccpvn1.ToxiEthanol = "";
                ccpvn1.ToxiFluoride = "";
                ccpvn1.ToxiFomaldehyde = "";
                ccpvn1.ToxiHexane = "";
                ccpvn1.ToxiHippuric = "";
                ccpvn1.ToxiIPA = "";
                ccpvn1.ToxiKetone = "";
                ccpvn1.ToxiLead = "";
                ccpvn1.ToxiMandelic = "";
                ccpvn1.ToxiManganese = "";
                ccpvn1.ToxiMercury = "";
                ccpvn1.ToxiMethanol = "";
                ccpvn1.ToxiMethyl = "";
                ccpvn1.ToxiNickel = "";
                ccpvn1.ToxiPhenol = "";
                ccpvn1.ToxiTin = "";
                ccpvn1.ToxiTrichloroethylene = "";
                ccpvn1.ToxiZinc = "";
                ccpvn1.StatusCBCNotsplitMaleFemale = "";
                ccpvn1.StatusSgotNotsplitMaleFemale = "";
                ccpvn1.StatusBunNotsplitMaleFemale = "";
            }
            return ccpvn1;
        }
    }
}
