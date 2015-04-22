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
            ccpvn.kidneyBunMale = "kidney_bun_male";
            ccpvn.kidneyCreatinineMale = "kidney_creatinine_male";
            ccpvn.kidneyBunFemale = "kidney_bun_female";
            ccpvn.kidneyCreatinineFemale = "kidney_creatinine_female";

            ccpvn.kidneyResult = "kidney_result";
            ccpvn.kidneySummary = "kidney_summary";
            ccpvn.liverSgot = "liver_sgot";
            ccpvn.liverSgpt = "liver_sgpt";
            ccpvn.liverAlp = "liver_alp";
            ccpvn.liverResult = "liver_result";
            ccpvn.liverSummary = "liver_summary";
            ccpvn.liverAlkaline = "liver_alkaline";

            ccpvn.uricAcidMale = "uric_acid_male";
            ccpvn.uricAcidFemale = "uric_acid_female";
            ccpvn.cholesterol = "cholesterol";
            ccpvn.triglyceride = "triglyceride";
            ccpvn.triglycerideResult = "triglyceride_result";
            ccpvn.triglycerideSummary = "triglyceride_summary";
            ccpvn.hdlMale = "hdl_male";
            ccpvn.hdlFemale = "hdl_female";
            ccpvn.ldl = "ldl";
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
            ccpvn.urineLeu = "urine_leu";
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
        public String UpdateCBC(String Basophil, String Eosinophil, String HbMale, String HbFemale, String HctMale, String HctFemale, String Lymphocyte,
            String Mch, String Mchc, String McvMale, String McvFemale, String Monocyte, String Neutrophil, String PlateletCount, String RbcMale, String RbcFemale, String RbcMorpholog,
            String Wbc, String PlateletSmear, String Pmn)
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
                ccpvn.cbcWbc + "='" + Wbc + "' " ;
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUA(String Color, String Appe, String Sugar, String spgr, String pH,
            String Protein, String Wbc, String Rbc, String Epi, String Bact, String ketone, String leu, String blood, String glu)
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
                ccpvn.urineGlu + "='" + glu + "' ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateTrigly(String value)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.triglyceride + "='" + value + "' ";
                //ccp.triglycerideResult + "='" + result + "', " +
                //ccp.triglycerideSummary + "='" + summary + "' " +
                //    //ccp.sugarSuggess + "='" + suggess + "' " +
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCholes(String value, String ldl, String hdlMale, String hdlFemale)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.cholesterol + "='" + value + "'," +
                    //ccp.cholesterolSuggess + "='" + result + "', " +
                ccpvn.hdlFemale + "='" + hdlFemale + "', " +
                ccpvn.ldl + "='" + ldl + "', " +
                ccpvn.hdlMale + "='" + hdlMale + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateSgot(String sgot, String sgpt, String alt, String alkaline)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.liverSgot + "='" + sgot + "'," +
                    //ccp.liverResult + "='" + result + "', " +
                    //ccp.liverSummary + "='" + summary + "', " +
                ccpvn.liverAlp + "='" + alt + "', " +
                ccpvn.liverSgpt + "='" + sgpt + "', "+
                ccpvn.liverAlkaline + "='" + alkaline + "' ";
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateBun(String bunMale, String creatinineMale, String bunFemale, String creatinineFemale)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccpvn.table + " Set " + ccpvn.kidneyBunMale + "='" + bunMale + "'," +
                    ccpvn.kidneyBunFemale + "='" + bunFemale + "', " +
                    ccpvn.kidneyCreatinineFemale + "='" + creatinineFemale + "', " +
                ccpvn.kidneyCreatinineMale + "='" + creatinineMale + "' ";
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
    }
}
