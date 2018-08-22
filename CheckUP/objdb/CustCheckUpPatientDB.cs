using CheckUP.objdb;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class CustCheckUpPatientDB
    {
        ConnectDB conn, connOnSite;
        public CustCheckUpPatient ccp;
        public CustCheckUpPatient1 ccp1;
        public CustCheckUpPatient1DB ccp1db;
        LogWriter lw;
        public CustCheckUpPatientDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            lw = new LogWriter();
            ccp = new CustCheckUpPatient();
            ccp1 = new CustCheckUpPatient1();
            ccp1db = new CustCheckUpPatient1DB(conn);
            ccp.Id="patient_id";
            ccp.CustCheckUpId="cust_checkup_id";    
            ccp.ChecklistId="t_checklist_id";    
            ccp.visitHn="visit_hn";
            ccp.patientFullname = "patient_fullname";
            ccp.patientAge = "patient_age";
            ccp.departmentName = "department_name";
            ccp.pid = "pid";
            ccp.patientNumber = "patient_number";
            ccp.sectionName = "section_name";
            ccp.vitalsign = "vitalsign";
            ccp.patientHeight = "patient_height";
            ccp.patientPulse = "patient_pulse";
            ccp.patientWeight = "patient_weight";
            ccp.PeResult = "pe_result";

            //ccp.EyeShortLongLeft = "eye_short_long_left";
            //ccp.EyeShortLongRight = "eye_short_long_right";
            ccp.EyeDegreeLeft = "eye_degree_left";
            ccp.EyeDegreeRight = "eye_degree_right";
            ccp.EyeShortLongLeft = "eye_short_long_left";
            ccp.EyeShortLongRight = "eye_short_long_right";
            ccp.EyeSquintLeft = "eye_squint_left";
            ccp.EyeSquintRight = "eye_squint_short";
            ccp.EyeOldLeft = "eye_old_left";
            ccp.EyeOldRight = "eye_old_right";
            ccp.EyeSummary = "eye_summary";
            ccp.EyeResult = "eye_result";
            ccp.EyeBlindness = "eye_blindness";
            ccp.EyeExam = "eyes_exam";

            ccp.fSexId = "f_sex_id";
            ccp.SexName = "sex_name";
            ccp.summaryPhysicalExam = "summary_physical_exam";

            ccp.StoolExamColor = "stool_exam_color";
            ccp.StoolExamAppearance = "stool_exam_appearance";
            ccp.StoolExamWbc = "stool_exam_wbc";
            ccp.StoolExamRbc = "stool_exam_rbc";
            ccp.StoolExamParasite = "stool_exam_parasite";
            ccp.StoolExamSummary = "stool_exam_summary";
            ccp.StoolExamCulture = "stool_exam_culture";
            ccp.StoolExamTyphoidH = "stool_exam_typhoidh";
            ccp.StoolExamTyphoidO = "stool_exam_typhoido";
            ccp.StoolExamCultureSummary = "stool_exam_culture_summary";

            //ccp.toxicologyLead = "toxicology_lead";
            //ccp.toxicologyMercury = "toxicology_mercury";
            //ccp.toxicologyBenzene = "toxicology_benzene";
            //ccp.toxicologyXylene = "toxicology_xylene";

            ccp.Audiogram500L = "audiogram_500_left";
            ccp.Audiogram1000L = "audiogram_1000_left";
            ccp.Audiogram2000L = "audiogram_2000_left";
            ccp.Audiogram3000L = "audiogram_3000_left";
            ccp.Audiogram4000L = "audiogram_4000_left";
            ccp.Audiogram6000L = "audiogram_6000_left";
            ccp.Audiogram8000L = "audiogram_8000_left";
            ccp.AudiogramSummaryL = "audiogram_summary_left";
            ccp.Audiogram500R = "audiogram_500_right";
            ccp.Audiogram1000R = "audiogram_1000_right";
            ccp.Audiogram2000R = "audiogram_2000_right";
            ccp.Audiogram3000R = "audiogram_3000_right";
            ccp.Audiogram4000R = "audiogram_4000_rightt";
            ccp.Audiogram6000R = "audiogram_6000_right";
            ccp.Audiogram8000R = "audiogram_8000_right";
            ccp.AudiogramSummaryR = "audiogram_summary_right";
            ccp.AudiogramExam = "audiogram_exam";
            ccp.xrayChestExam = "xray_chest_exam";
            ccp.xrayChestSummary = "xray_chest_summary";
            ccp.eyesExam = "eyes_exam";
            ccp.ekgExam = "ekg_exam";

            ccp.CAAFP = "ca_afp";
            ccp.CAAFPLabName = "ca_afp_lab_name";
            ccp.CAAFPLabNormal = "ca_afp_lab_normal";
            ccp.CAAFPRemark = "ca_afp_remark";

            ccp.CACEA = "ca_cea";
            ccp.CACEALabName = "ca_cea_lab_name";
            ccp.CACEALabNormal = "ca_cea_lab_normal";
            ccp.CACEARemark = "ca_cea_remark";

            ccp.CAPSA = "ca_psa";
            ccp.CAPSALabName = "ca_psa_lab_name";
            ccp.CAPSALabNormal = "ca_psa_lab_normal";
            ccp.CAPSARemark = "ca_psa_remark";

            ccp.CAHCG = "ca_hcg";
            ccp.CAHCGLabName = "ca_hcg_lab_name";
            ccp.CAHCGLabNormal = "ca_hcg_lab_normal";
            ccp.CAHCGRemark = "ca_hcg_remark";

            ccp.CA153 = "ca_153";
            ccp.CA153LabName = "ca_153_lab_name";
            ccp.CA153LabNormal = "ca_153_lab_normal";
            ccp.CA153Remark = "ca_153_remark";

            ccp.CA125 = "ca_125";
            ccp.CA125LabName = "ca_125_lab_name";
            ccp.CA125LabNormal = "ca_125_lab_normal";
            ccp.CA125Remark = "ca_125_remark";

            ccp.CA199 = "ca_19_9";
            ccp.CA199LabName = "ca_19_9_lab_name";
            ccp.CA199LabNormal = "ca_19_9_lab_normal";
            ccp.CA199Remark = "ca_19_9_remark";

            ccp.thyroidT3 = "thyroid_t3";
            ccp.thyroidT4 = "thyroid_t4";
            ccp.thyroidTsh = "thyroid_tsh";
            ccp.BloodGroup = "blood_group";

            ccp.vdrl = "vdrl";
            ccp.antiHiv = "anti_hiv";
            ccp.hbsag = "hbsag";
            ccp.hbsab = "hbsab";
            ccp.amphetamine = "amphetamine";
            ccp.hbtyping = "hbtyping";
            ccp.AntiHav = "anti_hav";
            ccp.antiHbc = "anti_hbc";
            ccp.hbsagResult = "hbsag_result";
            ccp.hbsagSummary = "hbsag_summary";
            ccp.hbsabResult = "hbsab_result";
            ccp.hbsabSummary = "hbsab_summary";

            ccp.disscusExam = "disscus_exam";
            ccp.suggestExam = "suggest_exam";
            ccp.sugar = "sugar";
            ccp.sugarLabName = "sugar_lab_name";
            ccp.sugarLabNormal = "sugar_lab_normal";
            ccp.sugarRemark = "sugar_remark";

            ccp.sugarDiagnosis = "sugar_diagnosis";
            ccp.sugarSummary = "sugar_summary";
            ccp.sugarSuggess = "sugar_suggess";
            ccp.kidneyBun = "kidney_bun";
            ccp.kidneyBunLabName = "kidney_bun_lab_name";
            ccp.kidneyBunLabNormal = "kidney_bun_lab_normal";
            ccp.kidneyBunRemark = "kidney_bun_remark";

            ccp.kidneyCreatinine = "kidney_creatinine";
            ccp.kidneyCreatinineLabName = "kidney_creatinine_lab_name";
            ccp.kidneyCreatinineLabNormal = "kidney_creatinine_lab_normal";
            ccp.kidneyCreatinineRemark = "kidney_creatinine_remark";

            ccp.kidneyResult = "kidney_result";
            ccp.kidneySummary = "kidney_summary";
            ccp.liverSgot = "liver_sgot";
            ccp.liverSgotLabName = "liver_sgot_lab_name";
            ccp.liverSgotLabNormal = "liver_sgot_lab_normal";
            ccp.liverSgotRemark = "liver_sgot_remark";

            ccp.liverSgpt = "liver_sgpt";
            ccp.liverSgptLabName = "liver_sgpt_lab_name";
            ccp.liverSgptLabNormal = "liver_sgpt_lab_normal";
            ccp.liverSgptRemark = "liver_sgpt_remark";

            ccp.liverAlp = "liver_alp";
            ccp.liverAlpLabName = "liver_alp_lab_name";
            ccp.liverAlpLabNormal = "liver_alp_lab_normal";
            ccp.liverAlpRemark = "liver_alp_remark";

            ccp.liverResult = "liver_result";
            ccp.liverSummary = "liver_summary";
            ccp.liverAlkaline = "liver_alkaline";

            ccp.uricAcid = "uric_acid";
            ccp.uricAcidLabName = "uric_acid_lab_name";
            ccp.uricAcidLabNormal = "uric_acid_lab_normal";
            ccp.uricAcidRemark = "uric_acid_remark";

            //ccp.uricAcidFemale = "uric_acid_female";
            ccp.cholesterol = "cholesterol";
            ccp.cholesterolLabName = "cholesterol_lab_name";
            ccp.cholesterolLabNormal = "cholesterol_lab_normal";
            ccp.cholesterolRemark = "cholesterol_remark";

            ccp.triglyceride = "triglyceride";
            ccp.triglycerideLabName = "triglyceride_lab_name";
            ccp.triglycerideLabNormal = "triglyceride_lab_normal";
            ccp.triglycerideRemark = "triglyceride_remark";

            ccp.triglycerideResult = "triglyceride_result";
            ccp.triglycerideSummary = "triglyceride_summary";
            ccp.hdl = "hdl_male";
            ccp.hdlLabName = "hdl_lab_name";
            ccp.hdlLabNormal = "hdl_lab_normal";
            ccp.hdlRemark = "hdl_remark";

            ccp.ldl = "ldl";
            ccp.ldlLabName = "ldl_lab_name";
            ccp.ldlLabNormal = "ldl_lab_normal";
            ccp.ldlRemark = "ldl_remark";

            ccp.ChoLDLResult = "ldl_result";
            ccp.ChoLDLsummary = "ldl_summary";
            ccp.ChoHDLResult = "hdl_result";
            ccp.ChoHDLsummary = "hdl_summary";

            ccp.calcium = "calcium";
            ccp.cbcMcv = "cbc_mcv";
            ccp.cbcHb = "cbc_hb";
            ccp.cbcHct = "cbc_hct";
            ccp.cbcWbc = "cbc_wbc";
            ccp.cbcNeutrophil = "cbc_neutrophil";
            ccp.cbcLymphocyte = "cbc_lymphocyte";
            ccp.cbcEosinophil = "cbc_eosinophil";
            ccp.cbcMonocyte = "cbc_monocyte";
            ccp.cbcBasophil = "cbc_basophil";
            ccp.cbcPlateletCount = "cbc_platelet_count";
            ccp.cbcRbcMorpholog = "cbc_rbc_morpholog";
            ccp.cbcSummary = "cbc_summary";
            ccp.cbcPmn = "cbc_pmn";
            ccp.cbcBact = "cbc_bact";
            ccp.cbcMcvLabName = "cbc_mcv_lab_name";
            ccp.cbcMcvLabNormal = "cbc_mcv_lab_normal";
            ccp.cbcMcvRemark = "cbc_mcv_remark";
            ccp.cbcHbLabName = "cbc_hb_lab_name";
            ccp.cbcHbLabNormal = "cbc_hb_lab_normal";
            ccp.cbcHbRemark = "cbc_hb_remark";
            ccp.cbcHctLabName = "cbc_hct_lab_name";
            ccp.cbcHctLabNormal = "cbc_hct_lab_normal";
            ccp.cbcHctRemark = "cbc_hct_remark";
            ccp.cbcWbcLabName = "cbc_wbc_lab_name";
            ccp.cbcWbcLabNormal = "cbc_wbc_lab_normal";
            ccp.cbcWbcRemark = "cbc_wbc_remark";
            ccp.cbcNeutrophilLabName = "cbc_neutrophil_lab_name";
            ccp.cbcNeutrophilLabNormal = "cbc_neutrophil_lab_normal";
            ccp.cbcNeutrophilRemark = "cbc_neutrophil_remark";
            ccp.cbcLymphocyteLabName = "cbc_lymphocyte_lab_name";
            ccp.cbcLymphocyteLabNormal = "cbc_lymphocyte_lab_normal";
            ccp.cbcLymphocyteRemark = "cbc_lymphocyte_remark";
            ccp.cbcEosinophilLabName = "cbc_eosinophil_lab_name";
            ccp.cbcEosinophilLabNormal = "cbc_eosinophil_lab_normal";
            ccp.cbcEosinophilRemark = "cbc_eosinophil_remark";
            ccp.cbcMonocyteLabName = "cbc_monocyte_lab_name";
            ccp.cbcMonocyteLabNormal = "cbc_monocyte_lab_normal";
            ccp.cbcMonocyteRemark = "cbc_monocyte_remark";
            ccp.cbcBasophilLabName = "cbc_basophil_lab_name";
            ccp.cbcBasophilLabNormal = "cbc_basophil_lab_normal";
            ccp.cbcBasophilRemark = "cbc_basophil_remark";
            ccp.cbcPlateletCountLabName = "cbc_platelet_count_lab_name";
            ccp.cbcPlateletCountLabNormal = "cbc_platelet_count_lab_normal";
            ccp.cbcPlateletCountRemark = "cbc_platelet_count_remark";
            ccp.cbcRbcMorphologLabName = "cbc_rbc_morpholog_lab_name";
            ccp.cbcRbcMorphologLabNormal = "cbc_rbc_morpholog_lab_normal";
            ccp.cbcRbcMorphologRemark = "cbc_rbc_morpholog_remark";
            ccp.cbcPmnLabName = "cbc_pmn_lab_name";
            ccp.cbcPmnLabNormal = "cbc_pmn_lab_normal";
            ccp.cbcPmnRemark = "cbc_pmn_remark";
            ccp.cbcBactLabName = "cbc_bact_lab_name";
            ccp.cbcBactLabNormal = "cbc_bact_lab_normal";
            ccp.cbcBactRemark = "cbc_bact_remark";
            ccp.cbcRbcLabName = "cbc_rbc_lab_name";
            ccp.cbcRbcLabNormal = "cbc_rbc_lab_normal";
            ccp.cbcRbcRemark = "cbc_rbc_remark";
            ccp.cbcMchLabName = "cbc_mch_lab_name";
            ccp.cbcMchLabNormal = "cbc_mch_lab_normal";
            ccp.cbcMchRemark = "cbc_mch_remark";
            ccp.cbcMchcLabName = "cbc_mchc_lab_name";
            ccp.cbcMchcLabNormal = "cbc_mchc_lab_normal";
            ccp.cbcMchcRemark = "cbc_mchc_remark";
            ccp.cbcRbc = "cbc_rbc";
            ccp.cbcMch = "cbc_mch";
            ccp.cbcMchc = "cbc_mchc";
            ccp.cbcPlateletSmear = "cbc_platelet_smear";
            ccp.cbcPlateletSmearLabName = "cbc_platelet_smear_lab_name";
            ccp.cbcPlateletSmearLabNormal = "cbc_platelet_smear_lab_normal";
            ccp.cbcPlateletSmearRemark = "cbc_platelet_smear_remark";
            ccp.cbcResult = "cbc_result";

            ccp.urineColor = "urine_color";
            ccp.urineAppearance = "urine_appearance";
            ccp.urinePh = "urine_ph";
            ccp.urineSpGr = "urine_sp_gr";
            ccp.urineSugar = "urine_sugar";
            ccp.urineProtein = "urine_protein";
            ccp.urineBlood = "urine_blood";
            ccp.urineKetone = "urine_ketone";
            ccp.urineBacteria = "urine_bacteria";
            ccp.urineWbc = "urine_wbc";
            ccp.urineRbc = "urine_rbc";
            ccp.urineEpithelium = "urine_epithelium";
            ccp.urineSummary = "urine_summary";
            ccp.urineResult = "urine_result";
            ccp.urineGlu = "urine_glu";            
            ccp.urineNit = "urine_nit";
            ccp.urineLeu = "urine_leu";
            ccp.urineUro = "urine_uro";
            ccp.urineBil = "urine_bil";
            ccp.urineColorLabName = "urine_color_lab_name";
            ccp.urineColorLabNormal = "urine_color_lab_normal";
            ccp.urineColorRemark = "urine_color_remark";
            ccp.urineAppearanceLabName = "urine_appearance_lab_name";
            ccp.urineAppearanceLabNormal = "urine_appearance_lab_normal";
            ccp.urineAppearanceRemark = "urine_appearance_remark";
            ccp.urinePhLabName = "urine_ph_lab_name";
            ccp.urinePhLabNormal = "urine_ph_lab_normal";
            ccp.urinePhRemark = "urine_ph_remark";
            ccp.urineSpGrLabName = "urine_sp_gr_lab_name";
            ccp.urineSpGrLabNormal = "urine_sp_gr_lab_normal";
            ccp.urineSpGrRemark = "urine_sp_gr_remark";
            ccp.urineSugarLabName = "urine_sugar_lab_name";
            ccp.urineSugarLabNormal = "urine_sugar_lab_normal";
            ccp.urineSugarRemark = "urine_sugar_remark";
            ccp.urineProteinLabName = "urine_protein_lab_name";
            ccp.urineProteinLabNormal = "urine_protein_lab_normal";
            ccp.urineProteinRemark = "urine_protein_remark";
            ccp.urineBloodLabName = "urine_blood_lab_name";
            ccp.urineBloodLabNormal = "urine_blood_lab_normal";
            ccp.urineBloodRemark = "urine_blood_remark";
            ccp.urineKetoneLabName = "urine_ketone_lab_name";
            ccp.urineKetoneLabNormal = "urine_ketone_lab_normal";
            ccp.urineKetoneRemark = "urine_ketone_remark";
            ccp.urineBacteriaLabName = "urine_bacteria_lab_name";
            ccp.urineBacteriaLabNormal = "urine_bacteria_lab_normal";
            ccp.urineBacteriaRemark = "urine_bacteria_remark";
            ccp.urineWbcLabName = "urine_wbc_lab_name";
            ccp.urineWbcLabNormal = "urine_wbc_lab_normal";
            ccp.urineWbcRemark = "urine_wbc_remark";
            ccp.urineRbcLabName = "urine_rbc_lab_name";
            ccp.urineRbcLabNormal = "urine_rbc_lab_normal";
            ccp.urineRbcRemark = "urine_rbc_remark";
            ccp.urineEpitheliumLabName = "urine_epithelium_lab_name";
            ccp.urineEpitheliumLabNormal = "urine_epithelium_lab_normal";
            ccp.urineEpitheliumRemark = "urine_epithelium_remark";
            ccp.urineGluLabName = "urine_glu_lab_name";
            ccp.urineGluLabNormal = "urine_glu_lab_normal";
            ccp.urineGluRemark = "urine_glu_remark";
            ccp.urineNitLabName = "urine_nit_lab_name";
            ccp.urineNitLabNormal = "urine_nit_lab_normal";
            ccp.urineNitRemark = "urine_nit_remark";
            ccp.urineLeuLabName = "urine_leu_lab_name";
            ccp.urineLeuLabNormal = "urine_leu_lab_normal";
            ccp.urineLeuRemark = "urine_leu_remark";
            ccp.urineUroLabName = "urine_uro_lab_name";
            ccp.urineUroLabNormal = "urine_uro_lab_normal";
            ccp.urineUroRemark = "urine_uro_remark";
            ccp.urineBilLabName = "urine_bil_lab_name";
            ccp.urineBilLabNormal = "urine_bil_lab_normal";
            ccp.urineBilRemark = "urine_bil_remark";

            ccp.lungFvcPredic = "lung_fvc_predic";
            ccp.lungFvcMeas = "lung_fvc_meas";
            ccp.lungFvcPer = "lung_fvc_per";
            ccp.lungFev1Predic = "lung_fev1_predic";
            ccp.lungFev1Meas = "lung_fev1_meas";
            ccp.lungFev1Per = "lung_fev1_per";
            ccp.lungPerFev1 = "lung_per_fev1";
            ccp.lungSummary = "lung_summary";
            ccp.lungSuggess = "lung_suggess";
            ccp.statusName = "status_name";
            ccp.rowNumber="row_number";
            //ccp.cbcMcv="";
            //ccp.toxicologyToluene = "toxicology_toluene";
            ccp.thyroidRubellaLgg = "thyroid_rubella_lgg";
            ccp.billirubin = "billirubin";
            //ccp.toxicologyThinner = "toxicology_thinner";
            //ccp.toxicologyAlcohol = "toxicology_alcohol";
            ccp.stickerQty = "sticker_qty";
            ccp.statusCbc = "status_cbc";
            ccp.statusUa = "status_ua";
            ccp.statusFbs = "status_fbs";
            ccp.statusPe = "status_pe";
            ccp.statusXray = "status_xray";
            ccp.statusStool = "status_stool";
            ccp.statusAntiHiv = "status_anti_hiv";
            ccp.statusUricAcid = "status_uric_acid";
            ccp.statusAmphetamine = "status_amphetamine";
            ccp.statusVisit = "status_visit";
            ccp.statusCholes = "status_choles";
            ccp.StatusHbsag = "status_hbsag";
            
            ccp.cholesterolSummary = "cholesterol_summary";
            ccp.cholesterolSuggess = "cholesterol_suggess";

            
            
            ccp.Active = "cust_checkup_patient_active";
            ccp.eyeBio = "eye_bio";
            ccp.amphetamineSummary = "amphetamine_summary";
            ccp.amphetamineSuggess = "amphetamine_suggess";

            ccp.antiHivSummary = "anti_hiv_summary";
            ccp.antiHavSummary = "anti_hav_summary";
            ccp.antiHivSuggess = "anti_hiv_suggess";
            //ccp.eyesExam = "";
            ccp.uricAcidSuggess = "uric_acid_suggess";
            ccp.uricAcidSummary = "uric_acid_summary";

            ccp.visitComment = "visit_comment";
            ccp.bmi = "bmi";
            
            ccp.caFt3 = "ca_ft3";
            
            //ccp.toxicologyHexane = "toxicology_hexane";
            //ccp.toxicologyMethanol = "toxicology_methanol";
            //ccp.toxicologyMek = "toxicology_mek";
            //ccp.toxicologyAcetone = "toxicology_acetone";
            //ccp.antiHbc="";
            ccp.eyeLeft = "";
            ccp.eyeRight = "";
            ccp.opticalLeftAngle = "optical_left_angle";
            ccp.opticalRightAngle = "optical_right_angle";
            ccp.cbcMcvOld = "cbc_mcv_old";
            ccp.cbcHbOld = "cbc_hb_old";
            ccp.cbcHctOld = "cbc_hct_old";
            ccp.cbcWbcOld = "cbc_wbc_old";
            ccp.cbcNeutrophilOld = "cbc_neutrophil_old";
            ccp.cbcLymphocyteOld = "cbc_lymphocyte_old";
            ccp.cbcEosinophilOld = "cbc_eosinophil_old";
            ccp.cbcMonocyteOld = "cbc_monocyte_old";
            ccp.cbcBasophilOld = "cbc_basophil_old";
            ccp.cbcPlateletCountOld = "cbc_platelet_count_old";
            ccp.cbcRbcMorphologOld = "cbc_rbc_morpholog_old";
            ccp.cbcSummaryOld = "cbc_summary_old";
            ccp.cbcRbcOld = "cbc_rbc_old";
            ccp.cbcMchcOld = "cbc_mchc_old";
            ccp.cbcMchOld = "cbc_mch_old";
            
            

            ccp.sugarOld = "sugar_old";
            ccp.kidneyBunOld = "kidney_bun_old";
            ccp.kidneyCreatinineOld = "kidney_creatinine_old";
            ccp.liverSgotOld = "liver_sgot_old";
            ccp.liverSgptOld = "liver_sgpt_old";
            ccp.liverAlpOld = "liver_alp_old";
            ccp.uricAcidOld = "uric_acid_old";
            ccp.cholesterolOld = "cholesterol_old";
            ccp.triglycerideOld = "triglyceride_old";
            ccp.hdlOld = "hdl_old";
            ccp.ldlOld = "ldl_old";
            //ccp.toxicologyLeadOld = "toxicology_lead_old";
            //ccp.toxicologyMercuryOld = "toxicology_mercury_old";
            //ccp.toxicologyBenzeneOld = "toxicology_benzene_old";
            //ccp.toxicologyXyleneOld = "toxicology_xylene_old";
            //ccp.toxicologyThinnerOld = "toxicology_thinner_old";
            //ccp.toxicologyAlcoholOld = "toxicology_alcohol_old";
            //ccp.toxicologyHexaneOld = "toxicology_hexane_old";
            //ccp.toxicologyMethanolOld = "toxicology_methanol_old";
            //ccp.toxicologyMekOld = "toxicology_mek_old";
            //ccp.toxicologyAcetoneOld = "toxicology_acetone_old";
            //ccp.toxicologyTolueneOld = "toxicology_toluene_old";
            
            ccp.urineOther = "urine_other";
            ccp.cultureStool = "culture_stool";
            ccp.cultureUrine = "culture_urine";
            ccp.cultureBacteria = "culture_bacteria";
            ccp.cultureSputum = "culture_sputum";
            ccp.marketingCheckupPatientOldId = "marketing_checkup_patient_old_id";
            ccp.thyroidFt3 = "thyroid_ft3";
            ccp.thyroidFt4 = "thyroid_ft4";
            ccp.amylase = "amylase";
            ccp.totalProtein = "total_protein";
            ccp.albumin = "albumin";
            ccp.globulin = "globulin";
            ccp.albuminGlobulin = "albumin_globulin";
            ccp.directBillirubin = "direct_billirubin";
            ccp.colorBlindness = "color_blindness";

            ccp.ToxiAcetone = "toxi_acetone";
            ccp.ToxiAluminium = "toxi_aluminium";
            ccp.ToxiAmmonia = "toxi_ammonia";
            ccp.ToxiAntimony = "toxi_antimony";
            ccp.ToxiArsenic = "toxi_arsenic";
            ccp.ToxiBenzene = "toxi_benzene";
            ccp.ToxiCadmium = "toxi_cadmium";
            ccp.ToxiChromium = "toxi_chromium";
            ccp.ToxiCopper = "toxi_copper";
            ccp.ToxiEthanol = "toxi_ethanol";
            ccp.ToxiFluoride = "toxi_fluoride";
            ccp.ToxiFomaldehyde = "toxi_fomaldehyde";
            ccp.ToxiHexane = "toxi_hexane";
            ccp.ToxiHippuric = "toxi_hippuric";
            ccp.ToxiIPA = "toxi_ipa";
            ccp.ToxiKetone = "toxi_ketone";
            ccp.ToxiLead = "toxi_lead";
            ccp.ToxiMandelic = "toxi_mandelic";
            ccp.ToxiManganese = "toxi_manganese";
            ccp.ToxiMercury = "toxi_mercury";
            ccp.ToxiMethanol = "toxi_methanol";
            ccp.ToxiMethyl = "toxi_methyl";
            ccp.ToxiNickel = "toxi_nickel";
            ccp.ToxiPhenol = "toxi_phenol";
            ccp.ToxiTin = "toxi_tin";
            ccp.ToxiTrichloroethylene = "toxi_trichloroethylenel";
            ccp.ToxiZinc = "toxi_zinc";
            ccp.ToxiAcetoneLabName = "toxi_acetone_lab_name";
            ccp.ToxiAcetoneLabNormal = "toxi_acetone_lab_normal";
            ccp.ToxiAcetoneRemark = "toxi_acetone_remark";
            ccp.ToxiAluminiumLabName = "toxi_aluminium_lab_name";
            ccp.ToxiAluminiumLabNormal = "toxi_aluminium_lab_normal";
            ccp.ToxiAluminiumRemark = "toxi_aluminium_remark";
            ccp.ToxiAmmoniaLabName = "toxi_ammonia_lab_name";
            ccp.ToxiAmmoniaLabNormal = "toxi_ammonia_lab_normal";
            ccp.ToxiAmmoniaRemark = "toxi_ammonia_remark";
            ccp.ToxiAntimonyLabName = "toxi_antimony_lab_name";
            ccp.ToxiAntimonyLabNormal = "toxi_antimony_lab_normal";
            ccp.ToxiAntimonyRemark = "toxi_antimony_remark";
            ccp.ToxiArsenicLabName = "toxi_arsenic_lab_name";
            ccp.ToxiArsenicLabNormal = "toxi_arsenic_lab_normal";
            ccp.ToxiArsenicRemark = "toxi_arsenic_remark";
            ccp.ToxiBenzeneLabName = "toxi_benzene_lab_name";
            ccp.ToxiBenzeneLabNormal = "toxi_benzene_normal";
            ccp.ToxiBenzeneRemark = "toxi_benzene_remark";
            ccp.ToxiCadmiumLabName = "toxi_cadmium_lab_name";
            ccp.ToxiCadmiumLabNormal = "toxi_cadmium_lab_normal";
            ccp.ToxiCadmiumRemark = "toxi_cadmium_remark";
            ccp.ToxiChromiumLabName = "toxi_chromium_lab_name";
            ccp.ToxiChromiumLabNormal = "toxi_chromium_lab_normal";
            ccp.ToxiChromiumRemark = "toxi_chromium_remark";
            ccp.ToxiCopperLabName = "toxi_copper_lab_name";
            ccp.ToxiCopperLabNormal = "toxi_copper_lab_normal";
            ccp.ToxiCopperRemark = "toxi_copper_remark";
            ccp.ToxiEthanolLabName = "toxi_ethanol_lab_name";
            ccp.ToxiEthanolLabNormal = "toxi_ethanol_lab_normal";
            ccp.ToxiEthanolRemark = "toxi_ethanol_remark";
            ccp.ToxiFluorideLabName = "toxi_fluoride_lab_name";
            ccp.ToxiFluorideLabNormal = "toxi_fluoride_lab_normal";
            ccp.ToxiFluorideRemark = "toxi_fluoride_remark";
            ccp.ToxiFomaldehydeLabName = "toxi_fomaldehyde_lab_name";
            ccp.ToxiFomaldehydeLabNormal = "toxi_fomaldehyde_lab_normal";
            ccp.ToxiFomaldehydeRemark = "toxi_fomaldehyde_remark";
            ccp.ToxiHexaneLabName = "toxi_hexane_lab_name";
            ccp.ToxiHexaneLabNormal = "toxi_hexane_lab_normal";
            ccp.ToxiHexaneRemark = "toxi_hexane_remark";
            ccp.ToxiHippuricLabName = "toxi_hippuric_lab_name";
            ccp.ToxiHippuricLabNormal = "toxi_hippuric_lab_normal";
            ccp.ToxiHippuricRemark = "toxi_hippuric_remark";
            ccp.ToxiIPALabName = "toxi_ipa_lab_name";
            ccp.ToxiIPALabNormal = "toxi_ipa_lab_normal";
            ccp.ToxiIPARemark = "toxi_ipa_remark";
            ccp.ToxiKetoneLabName = "toxi_ketone_lab_name";
            ccp.ToxiKetoneLabNormal = "toxi_ketone_lab_normal";
            ccp.ToxiKetoneRemark = "toxi_ketone_remark";
            ccp.ToxiLeadLabName = "toxi_lead_lab_name";
            ccp.ToxiLeadLabNormal = "toxi_lead_lab_normal";
            ccp.ToxiLeadRemark = "toxi_lead_remark";
            ccp.ToxiMandelicLabName = "toxi_mandelic_lab_name";
            ccp.ToxiMandelicLabNormal = "toxi_mandelic_lab_normal";
            ccp.ToxiMandelicRemark = "toxi_mandelic_remark";
            ccp.ToxiManganeseLabName = "toxi_manganese_lab_name";
            ccp.ToxiManganeseLabNormal = "toxi_manganese_lab_normal";
            ccp.ToxiManganeseRemark = "toxi_manganese_remark";
            ccp.ToxiMercuryLabName = "toxi_mercury_lab_name";
            ccp.ToxiMercuryLabNormal = "toxi_mercury_lab_normal";
            ccp.ToxiMercuryRemark = "toxi_mercury_remark";
            ccp.ToxiMethanolLabName = "toxi_methanol_lab_name";
            ccp.ToxiMethanolLabNormal = "toxi_methanol_lab_normal";
            ccp.ToxiMethanolRemark = "toxi_methanol_remark";
            ccp.ToxiMethylLabName = "toxi_methyl_lab_name";
            ccp.ToxiMethylLabNormal = "toxi_methyl_lab_normal";
            ccp.ToxiMethylRemark = "toxi_methyl_remark";
            ccp.ToxiNickelLabName = "toxi_nickel_lab_name";
            ccp.ToxiNickelLabNormal = "toxi_nickel_lab_normal";
            ccp.ToxiNickelRemark = "toxi_nickel_remark";
            ccp.ToxiPhenolLabName = "toxi_phenol_lab_name";
            ccp.ToxiPhenolLabNormal = "toxi_phenol_lab_normal";
            ccp.ToxiPhenolRemark = "toxi_phenol_remark";
            ccp.ToxiTinLabName = "toxi_tin_lab_name";
            ccp.ToxiTinLabNormal = "toxi_tin_lab_normal";
            ccp.ToxiTinRemark = "toxi_tin_remark";
            ccp.ToxiTrichloroethyleneLabName = "toxi_trichloroethylenel_lab_name";
            ccp.ToxiTrichloroethyleneLabNormal = "toxi_trichloroethylenel_lab_normal";
            ccp.ToxiTrichloroethyleneRemark = "toxi_trichloroethylenel_remark";
            ccp.ToxiZincLabName = "toxi_zinc_lab_name";
            ccp.ToxiZincLabNormal = "toxi_zinc_lab_normal";
            ccp.ToxiZincRemark = "toxi_zinc_remark";
            ccp.position_name = "position_name";
            ccp.sticker01 = "sticker01";
            ccp.sticker02 = "sticker02";
            ccp.sticker03 = "sticker03";
            ccp.sticker04 = "sticker04";
            ccp.sticker05 = "sticker05";
            ccp.sticker06 = "sticker06";
            ccp.sticker07 = "sticker07";
            ccp.sticker08 = "sticker08";
            ccp.sticker09 = "sticker09";
            ccp.sticker10 = "sticker10";
            ccp.sticker11 = "sticker11";
            ccp.sticker12 = "sticker12";
            ccp.sticker13 = "sticker13";
            ccp.sticker14 = "sticker14";
            ccp.sticker15 = "sticker15";
            ccp.sticker16 = "sticker16";
            ccp.sticker17 = "sticker17";
            ccp.sticker18 = "sticker18";
            ccp.sticker19 = "sticker19";
            ccp.sticker20 = "sticker20";

            ccp.test01 = "test01";
            ccp.test02 = "test02";
            ccp.test03 = "test03";
            ccp.test04 = "test04";
            ccp.test05 = "test05";
            ccp.test06 = "test06";
            ccp.test07 = "test07";
            ccp.test08 = "test08";
            ccp.test09 = "test09";
            ccp.test10 = "test10";
            ccp.test11 = "test11";
            ccp.test12 = "test12";
            ccp.test13 = "test13";
            ccp.test14 = "test14";
            ccp.test15 = "test15";
            ccp.test16 = "test16";
            ccp.test17 = "test17";
            ccp.test18 = "test18";
            ccp.test19 = "test19";
            ccp.test20 = "test20";

            ccp.ekg = "ekg";
            ccp.ekg_result = "ekg_result";
            ccp.ekg_summary = "ekg_summary";

            ccp.pkField = "patient_id";
            ccp.table = "t_cust_checkup_patient";
        }
        public String selectByPk1(String cuId)
        {
            //CustCheckUpPatient item = new CustCheckUpPatient();
            String sql = "", chk="";
            DataTable dt = new DataTable();
            sql = "Select " + ccp .Id+ " From " + ccp.table + " Where " + ccp.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                chk = dt.Rows[0][ccp.Id].ToString();
            }
            return chk;
        }
        public DataTable selectByPk(String ccpId)
        {
            String sql = "", onsite="";
            DataTable dt = new DataTable();
            if (conn.initc.statusonsite.Equals("yes"))
            {
                onsite = " onsite_";
            }
            sql = "Select * From " + onsite+ccp.table + " Where " + ccp.Id + " = '" + ccpId + "'";
            dt = conn.selectData(sql);

            return dt;
        }

        public DataTable selectAllByCucId(String cucId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' Order By " + ccp.rowNumber;
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public String selectCntAllByCucId(String cucId)
        {
            String sql = "", re = "0";
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "'  " ;
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                re = dt.Rows[0][0].ToString();
            }
            return re;
        }
        public String calCntStickerByCucId(String cucId)
        {
            int cntAll = 0;
            String sql = "", re = "0";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "'  ";
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0, cnt5 = 0, cnt6 = 0, cnt7 = 0, cnt8 = 0, cnt9 = 0, cnt10 = 0;
                    int cnt11 = 0, cnt12 = 0, cnt13 = 0, cnt14 = 0, cnt15 = 0, cnt16 = 0, cnt17 = 0, cnt18 = 0, cnt19 = 0, cnt20 = 0;
                    int.TryParse(dt.Rows[i][ccp.sticker01].ToString(), out cnt1);
                    int.TryParse(dt.Rows[i][ccp.sticker02].ToString(), out cnt2);
                    int.TryParse(dt.Rows[i][ccp.sticker03].ToString(), out cnt3);
                    int.TryParse(dt.Rows[i][ccp.sticker04].ToString(), out cnt4);
                    int.TryParse(dt.Rows[i][ccp.sticker05].ToString(), out cnt5);
                    int.TryParse(dt.Rows[i][ccp.sticker06].ToString(), out cnt6);
                    int.TryParse(dt.Rows[i][ccp.sticker07].ToString(), out cnt7);
                    int.TryParse(dt.Rows[i][ccp.sticker08].ToString(), out cnt8);
                    int.TryParse(dt.Rows[i][ccp.sticker09].ToString(), out cnt9);
                    int.TryParse(dt.Rows[i][ccp.sticker10].ToString(), out cnt10);
                    int.TryParse(dt.Rows[i][ccp.sticker11].ToString(), out cnt11);
                    int.TryParse(dt.Rows[i][ccp.sticker12].ToString(), out cnt12);
                    int.TryParse(dt.Rows[i][ccp.sticker13].ToString(), out cnt13);
                    int.TryParse(dt.Rows[i][ccp.sticker14].ToString(), out cnt14);
                    int.TryParse(dt.Rows[i][ccp.sticker15].ToString(), out cnt15);
                    int.TryParse(dt.Rows[i][ccp.sticker16].ToString(), out cnt16);
                    int.TryParse(dt.Rows[i][ccp.sticker17].ToString(), out cnt17);
                    int.TryParse(dt.Rows[i][ccp.sticker18].ToString(), out cnt18);
                    int.TryParse(dt.Rows[i][ccp.sticker19].ToString(), out cnt19);
                    int.TryParse(dt.Rows[i][ccp.sticker20].ToString(), out cnt20);
                    cntAll += cnt1 + cnt2 + cnt3 + cnt4 + cnt5 + cnt6 + cnt7 + cnt8 + cnt9 + cnt10 + cnt11 + cnt12 + cnt13 + cnt14 + cnt15 + cnt16 + cnt17 + cnt18 + cnt19 + cnt20;
                }
            }
            return cntAll.ToString();
        }
        public String calCntTestByCucId(String cucId)
        {
            int cntAll = 0;
            String sql = "", re = "0";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "'  ";
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt4 = 0, cnt5 = 0, cnt6 = 0, cnt7 = 0, cnt8 = 0, cnt9 = 0, cnt10 = 0;
                    int cnt11 = 0, cnt12 = 0, cnt13 = 0, cnt14 = 0, cnt15 = 0, cnt16 = 0, cnt17 = 0, cnt18 = 0, cnt19 = 0, cnt20 = 0;
                    int.TryParse(dt.Rows[i][ccp.test01].ToString(), out cnt1);
                    int.TryParse(dt.Rows[i][ccp.test02].ToString(), out cnt2);
                    int.TryParse(dt.Rows[i][ccp.test03].ToString(), out cnt3);
                    int.TryParse(dt.Rows[i][ccp.test04].ToString(), out cnt4);
                    int.TryParse(dt.Rows[i][ccp.test05].ToString(), out cnt5);
                    int.TryParse(dt.Rows[i][ccp.test06].ToString(), out cnt6);
                    int.TryParse(dt.Rows[i][ccp.test07].ToString(), out cnt7);
                    int.TryParse(dt.Rows[i][ccp.test08].ToString(), out cnt8);
                    int.TryParse(dt.Rows[i][ccp.test09].ToString(), out cnt9);
                    int.TryParse(dt.Rows[i][ccp.test10].ToString(), out cnt10);
                    int.TryParse(dt.Rows[i][ccp.test11].ToString(), out cnt11);
                    int.TryParse(dt.Rows[i][ccp.test12].ToString(), out cnt12);
                    int.TryParse(dt.Rows[i][ccp.test13].ToString(), out cnt13);
                    int.TryParse(dt.Rows[i][ccp.test14].ToString(), out cnt14);
                    int.TryParse(dt.Rows[i][ccp.test15].ToString(), out cnt15);
                    int.TryParse(dt.Rows[i][ccp.test16].ToString(), out cnt16);
                    int.TryParse(dt.Rows[i][ccp.test17].ToString(), out cnt17);
                    int.TryParse(dt.Rows[i][ccp.test18].ToString(), out cnt18);
                    int.TryParse(dt.Rows[i][ccp.test19].ToString(), out cnt19);
                    int.TryParse(dt.Rows[i][ccp.test20].ToString(), out cnt20);
                    cntAll += cnt1 + cnt2 + cnt3 + cnt4 + cnt5 + cnt6 + cnt7 + cnt8 + cnt9 + cnt10 + cnt11 + cnt12 + cnt13 + cnt14 + cnt15 + cnt16 + cnt17 + cnt18 + cnt19 + cnt20;
                }
            }
            return cntAll.ToString();
        }
        public String selectCntStatusVisit1ByCucId(String cucId)
        {
            String sql = "", re="0";
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' and " + ccp.statusVisit + "='1' ";
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                re = dt.Rows[0][0].ToString();
            }
            return re;
        }
        public DataTable selectAllStatusVisit1ByCucId(String cucId)
        {
            String sql = "", onsite="";
            DataTable dt = new DataTable();
            if (conn.initc.statusonsite.Equals("yes"))
            {
                onsite = " onsite_";
            }
            sql = "Select * From " + onsite+ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' and " + ccp.statusVisit + "='1' Order By " + ccp.rowNumber;
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectAllStatusVisit0ByCucId(String cucId)
        {
            String sql = "", onsite="";
            DataTable dt = new DataTable();
            if (conn.initc.statusonsite.Equals("yes"))
            {
                onsite = " onsite_";
            }
            sql = "Select * From " + onsite+ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' and "+ccp.statusVisit+"='0' Order By " + ccp.rowNumber;
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public String selectCntByCucId(String cucId)
        {
            String sql = "", chk="0";
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' ";
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                chk = dt.Rows.Count.ToString();
            }
            return chk;
        }
        public DataTable selectPrintByCucId(String cucId, String rowNumber)
        {
            String sql = "", where="";
            DataTable dt = new DataTable();
            where = " and row_number in (" + rowNumber + ") ";
            sql = "Select * From " + ccp.table + " " +
                "Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' " + where + 
                " Order By " + ccp.rowNumber;
            //sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectOtherByCucId(String cucId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            //sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "' Order By " + ccp.rowNumber;
            sql = "Select * From " + ccp1db.ccp1.table + " Where " + ccp1db.ccp1.Active + "='1' and " + ccp1db.ccp1.CustCheckUpId + " = '" + cucId + "' Order By " + ccp1db.ccp1.rowNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectPEByCucId(String cucId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "'" + " Order By " + ccp.rowNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public String deleteOnSiteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From onsite_" + ccp.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String insertToOnSite(String cucId)
        {
            String sql = "", chk = "";
            DataTable dt = new DataTable();
            dt = selectAllByCucId(cucId);
            if (connOnSite == null)
                connOnSite = new ConnectDB(conn.initc, ConnectDB.flagOnSite.OnSite);

            sql = "Delete From onsite_" + ccp.table;
            chk = connOnSite.ExecuteNonQuery(sql);
            //MessageBox.Show("dt "+dt.Rows.Count, "");
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    CustCheckUpPatient ccp1 = new CustCheckUpPatient();
                    ccp1.Active = "1";
                    ccp1.Id = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.Id].ToString() : "";
                    ccp1.CustCheckUpId = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.CustCheckUpId].ToString() : "";
                    ccp1.rowNumber = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.rowNumber].ToString() : "";
                    ccp1.visitHn = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.visitHn].ToString() : "";
                    ccp1.patientFullname = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.patientFullname].ToString() : "";
                    ccp1.departmentName = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.departmentName].ToString() : "";
                    ccp1.patientNumber = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.patientNumber].ToString() : "";
                    ccp1.sectionName = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.patientNumber].ToString() : "";
                    ccp1.position_name = dt.Rows[i][ccp.Id] != null ? dt.Rows[i][ccp.position_name].ToString() : "";
                    ccp1.statusVisit = "0";
                    
                    insertOnSite(ccp1, connOnSite);
                    UpdateStickerOnSite(ccp1.Id, dt.Rows[i][ccp.sticker01].ToString(), dt.Rows[i][ccp.sticker02].ToString(), dt.Rows[i][ccp.sticker03].ToString(), dt.Rows[i][ccp.sticker04].ToString(), dt.Rows[i][ccp.sticker05].ToString()
                        , dt.Rows[i][ccp.sticker06].ToString(), dt.Rows[i][ccp.sticker07].ToString(), dt.Rows[i][ccp.sticker08].ToString(), dt.Rows[i][ccp.sticker09].ToString(), dt.Rows[i][ccp.sticker10].ToString()
                        , dt.Rows[i][ccp.sticker11].ToString(), dt.Rows[i][ccp.sticker12].ToString(), dt.Rows[i][ccp.sticker13].ToString(), dt.Rows[i][ccp.sticker14].ToString(), dt.Rows[i][ccp.sticker15].ToString()
                        , dt.Rows[i][ccp.sticker16].ToString(), dt.Rows[i][ccp.sticker17].ToString(), dt.Rows[i][ccp.sticker18].ToString(), dt.Rows[i][ccp.sticker19].ToString(), dt.Rows[i][ccp.sticker20].ToString());
                    UpdateTestOnSite(ccp1.Id, "0", "0", "0", "0", "0"
                        , "0", "0", "0", "0", "0"
                        , "0", "0", "0", "0", "0"
                        , "0", "0", "0", "0", "0");
                }
            }

            //sql = "insert into "+ conn.initc.nameRemoteClient + "." + conn.initc.nameDBonsite + ".dbo." + "onsite_" + ccp.table + " " +
            //    "select * from " + ccp.table +" "+
            //    "Where " + ccp.CustCheckUpId + "='" + cucId + "'";
            ////MessageBox.Show("SQL " + sql, "message ");
            //chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        private String insert(CustCheckUpPatient p) {
            String sql = "", chk = "", onsite="";
            if (p.Id.Equals(""))
            {
                p.Id = "ccp" + p.getGenID();
            }
            try {
                //if (conn.initc.statusonsite.Equals("yes"))
                //{
                //    onsite = " onsite_";
                //}
    //            Connection conn = config1.getConnectionBangna;
    //            Statement st = conn.createStatement;
                //ccp = getMarketingTCheckupPatientByPK(st,"", p.getMarketingCheckupPatientId,"");
                p.departmentName=p.departmentName.Replace("'", "''");
                p.patientFullname = p.patientFullname.Replace("'", "''");
                p.sectionName = p.sectionName.Replace("'", "''");
                p.summaryPhysicalExam = p.summaryPhysicalExam.Replace("'", "''");
                p.xrayChestExam = p.xrayChestExam.Replace("'", "''");
                p.position_name = p.position_name.Replace("'", "''");
                p.SexName = p.SexName.Replace("'", "''");

                //max = getMaxRowMarketingTCheckupPatient(st);
                p.statusAmphetamine = "0";
                p.statusAntiHiv = "0";
                p.statusCbc = "0";
                p.statusCholes = "0";
                p.statusFbs = "0";
                p.StatusHbsag = "0";
                p.statusPe = "0";
                p.statusName = "0";
                p.statusStool = "0";
                p.statusUa = "0";
                p.statusUricAcid = "0";
                p.statusVisit = "0";
                p.statusXray = "0";
                p.sticker01 = "0";
                p.sticker02 = "0";
                p.sticker03 = "0";
                p.sticker04 = "0";
                p.sticker05 = "0";
                p.sticker06 = "0";
                p.sticker07 = "0";
                p.sticker08 = "0";
                p.sticker09 = "0";
                p.sticker10 = "0";
                p.sticker11 = "0";
                p.sticker12 = "0";
                p.sticker13 = "0";
                p.sticker14 = "0";
                p.sticker15 = "0";
                p.sticker16 = "0";
                p.sticker17 = "0";
                p.sticker18 = "0";
                p.sticker19 = "0";
                p.sticker20 = "0";

                p.test01 = "0";
                p.test02 = "0";
                p.test03 = "0";
                p.test04 = "0";
                p.test05 = "0";
                p.test06 = "0";
                p.test07 = "0";
                p.test08 = "0";
                p.test09 = "0";
                p.test10 = "0";
                p.test11 = "0";
                p.test12 = "0";
                p.test13 = "0";
                p.test14 = "0";
                p.test15 = "0";
                p.test16 = "0";
                p.test17 = "0";
                p.test18 = "0";
                p.test19 = "0";
                p.test20 = "0";

                sql = "Insert Into " + onsite + ccp.table+ "(" 
                + ccp.Id + ", " + ccp.amphetamine + ", "
                + ccp.antiHiv + "," + ccp.AudiogramExam + ","
                + ccp.Audiogram1000L + "," + ccp.Audiogram1000R + ","
                + ccp.Audiogram2000L + "," + ccp.Audiogram2000R + ","
                + ccp.Audiogram3000L + "," + ccp.Audiogram3000R + ","

                + ccp.Audiogram4000L + "," + ccp.Audiogram4000R + ","
                + ccp.Audiogram6000L + "," + ccp.Audiogram6000R + ","
                + ccp.Audiogram8000L + "," + ccp.Audiogram8000R + ","
                + ccp.Audiogram500L + "," + ccp.Audiogram500R + ","
                + ccp.AudiogramSummaryL + "," + ccp.AudiogramSummaryR + ","

                + ccp.CA125 + "," + ccp.cbcPlateletSmear + ","
                + ccp.CA199 + "," + ccp.CAAFP + ","
                + ccp.CACEA + "," + ccp.CAHCG + ","
                + ccp.calcium + "," + ccp.CAPSA + ","
                + ccp.cbcBasophil + "," + ccp.cbcEosinophil + ","

                + ccp.cbcHb + "," + ccp.cbcHct + ","
                + ccp.cbcLymphocyte + "," + ccp.cbcMonocyte + ","
                + ccp.cbcNeutrophil + "," + ccp.cbcPlateletCount + ","
                + ccp.cbcRbcMorpholog + "," + ccp.cbcWbc + ","
                + ccp.cholesterol + "," + ccp.departmentName + ","

                + ccp.disscusExam + "," + ccp.ekgExam + ","
                + ccp.urineEpithelium + "," + ccp.eyesExam + ","
                + ccp.BloodGroup + "," + ccp.fSexId + ","
                + ccp.hbsab + "," + ccp.hbsag + ","
                + ccp.hdl + "," + ccp.kidneyBun + ","

                + ccp.kidneyCreatinine + "," + ccp.ldl + ","
                + ccp.liverAlp + "," + ccp.liverSgot + ","
                + ccp.liverSgpt + "," + ccp.CustCheckUpId + ","
                + ccp.xrayChestExam + "," + ccp.EyeShortLongLeft + ","
                + ccp.EyeShortLongRight + "," + ccp.patientAge + ","

                + ccp.patientFullname + "," + ccp.xrayChestSummary+","
                + ccp.patientHeight + "," + ccp.patientNumber + ","
                + ccp.patientPulse + "," + ccp.patientWeight + ","
                + ccp.pid + "," + ccp.sectionName + ","
                + ccp.StoolExamAppearance + "," + ccp.ChecklistId + ","

                + ccp.StoolExamColor + "," + ccp.StoolExamParasite + ","
                + ccp.StoolExamRbc + "," + ccp.StoolExamWbc + ","
                + ccp.sugar + "," + ccp.suggestExam + ","
                + ccp.sugarDiagnosis + "," + ccp.sugarSuggess + ","
                + ccp.sugarSummary + ","+ccp.urineResult+","

                + ccp.thyroidT3+ "," + ccp.thyroidT4 + ","
                + ccp.thyroidTsh + ","  + ccp.triglyceride + ","
                + ccp.uricAcid + "," + ccp.urineAppearance + ","

                + ccp.urineBacteria + "," + ccp.urineBlood + ","
                + ccp.urineKetone + "," + ccp.urineColor + ","
                + ccp.urinePh + "," + ccp.urineProtein + ","
                + ccp.urineRbc + "," + ccp.urineSpGr + ","
                + ccp.urineSugar + "," + ccp.urineWbc + ","

                + ccp.lungFev1Meas + "," + ccp.lungFev1Per + ","
                + ccp.lungFev1Predic + "," + ccp.lungFvcMeas + ","
                + ccp.lungFvcPer + "," + ccp.lungFvcPredic + ","
                + ccp.lungPerFev1 + "," + ccp.lungSuggess + ","
                + ccp.lungSummary + "," +ccp.urineSummary+","

                + ccp.cbcSummary + "," +ccp.summaryPhysicalExam+","
                + ccp.vdrl + "," + ccp.visitHn + ","
                + ccp.rowNumber+","+ccp.cbcMcv+","
                    + ccp.stickerQty+","+ccp.statusCbc+","
                    + ccp.statusFbs+","+ccp.statusUa+","
                    + ccp.statusPe+","+ccp.statusXray+","
                    + ccp.statusStool+","+ccp.StoolExamSummary+","
                    + ccp.cholesterolSuggess+","+ccp.cholesterolSummary+","
                    + ccp.cbcMch+","+ccp.cbcMchc+","
                    + ccp.hbsagResult+","+ccp.hbsagSummary+","
                    + ccp.statusCholes+","+ccp.StatusHbsag+","
                    + ccp.cbcRbc+","+ccp.Active+","
                    + ccp.eyeBio+","+ccp.amphetamineSuggess+","
                    + ccp.amphetamineSummary+","+ccp.antiHivSuggess+","
                    + ccp.antiHivSummary+","+ccp.statusAmphetamine+","
                    + ccp.statusAntiHiv+","+ccp.statusVisit+","+
                    ccp.triglycerideResult + "," + ccp.triglycerideSummary +","+
                    ccp.liverResult + "," + ccp.liverSummary +","+
                    ccp.kidneyResult + "," + ccp.kidneySummary + "," + ccp.SexName + " "+
                    "," + ccp.sticker01 + "," + ccp.sticker02 + "," + ccp.sticker03 + " " +
                    "," + ccp.sticker04 + "," + ccp.sticker05 + "," + ccp.sticker06 + " " +
                    "," + ccp.sticker07 + "," + ccp.sticker08 + "," + ccp.sticker09 + " " +
                    "," + ccp.sticker10 + "," + ccp.sticker11 + "," + ccp.sticker12 + " " +
                    "," + ccp.sticker13 + "," + ccp.sticker14 + "," + ccp.sticker15 + " " +
                    "," + ccp.sticker16 + "," + ccp.sticker17 + "," + ccp.sticker18 + " " +
                    "," + ccp.sticker19 + "," + ccp.sticker20 + "," + ccp.position_name + " " +
                    "," + ccp.test01 + "," + ccp.test02 + "," + ccp.test03 + " " +
                    "," + ccp.test04 + "," + ccp.test05 + "," + ccp.test06 + " " +
                    "," + ccp.test07 + "," + ccp.test08 + "," + ccp.test09 + " " +
                    "," + ccp.test10 + "," + ccp.test11 + "," + ccp.test12 + " " +
                    "," + ccp.test13 + "," + ccp.test14 + "," + ccp.test15 + " " +
                    "," + ccp.test16 + "," + ccp.test17 + "," + ccp.test18 + " " +
                    "," + ccp.test19 + "," + ccp.test20 + " " +
                    ") "

                + "Values('" + p.Id + "','" + p.amphetamine + "','"
                + p.antiHiv + "','" + p.AudiogramExam + "','"
                + p.Audiogram1000L + "','" + p.Audiogram1000R + "','"
                + p.Audiogram2000L + "','" + p.Audiogram2000R + "','"
                + p.Audiogram3000L + "','" + p.Audiogram3000R + "','"

                + p.Audiogram4000L + "','" + p.Audiogram4000R + "','"
                + p.Audiogram6000L + "','" + p.Audiogram6000R + "','"
                + p.Audiogram8000L + "','" + p.Audiogram8000R + "','"
                + p.Audiogram500L + "','" + p.Audiogram500R + "','"
                + p.AudiogramSummaryL + "','" + p.AudiogramSummaryR + "','"

                + p.CA125 + "','" + p.cbcPlateletSmear + "','"
                + p.CA199 + "','" + p.CAAFP + "','"
                + p.CACEA + "','" + p.CAHCG + "','"
                + p.calcium + "','" + p.CAPSA + "','"
                + p.cbcBasophil + "','" + p.cbcEosinophil + "','"

                + p.cbcHb + "','" + p.cbcHct + "','"
                + p.cbcLymphocyte + "','" + p.cbcMonocyte + "','"
                + p.cbcNeutrophil + "','" + p.cbcPlateletCount + "','"
                + p.cbcRbcMorpholog + "','" + p.cbcWbc + "','"
                + p.cholesterol + "','" + p.departmentName + "','"

                + p.disscusExam + "','" + p.ekgExam + "','"
                + p.urineEpithelium + "','" + p.eyesExam + "','"
                + p.BloodGroup + "','" + p.fSexId + "','"
                + p.hbsab + "','" + p.hbsag + "','"
                + p.hdl + "','" + p.kidneyBun + "','"

                + p.kidneyCreatinine + "','" + p.ldl + "','"
                + p.liverAlp + "','" + p.liverSgot + "','"
                + p.liverSgpt + "','" + p.CustCheckUpId + "','"
                + p.xrayChestExam + "','" + p.EyeShortLongLeft + "','"
                + p.EyeShortLongRight + "','" + p.patientAge + "','"

                + p.patientFullname + "','" + p.xrayChestSummary + "','"
                + p.patientHeight + "','" + p.patientNumber + "','"
                + p.patientPulse + "','" + p.patientWeight + "','"
                + p.pid + "','" + p.sectionName + "','"
                + p.StoolExamAppearance + "','" + p.ChecklistId + "','"

                + p.StoolExamColor + "','" + p.StoolExamParasite + "','"
                + p.StoolExamRbc + "','" + p.StoolExamWbc + "','"
                + p.sugar + "','" + p.suggestExam + "','"
                + p.sugarDiagnosis + "','" + p.sugarSuggess + "','"
                + p.sugarSummary + "','"+p.urineResult+"','"

                + p.thyroidT3 + "','" + p.thyroidT4 + "','"
                + p.thyroidTsh + "','"  + p.triglyceride + "','"
                + p.uricAcid + "','" + p.urineAppearance + "','"

                + p.urineBacteria + "','" + p.urineBlood + "','"
                + p.urineKetone + "','" + p.urineColor + "','"
                + p.urinePh + "','" + p.urineProtein + "','"
                + p.urineRbc + "','" + p.urineSpGr + "','"
                + p.urineSugar + "','" + p.urineWbc + "','"

                + p.lungFev1Meas + "','" + p.lungFev1Per + "','"
                + p.lungFev1Predic + "','" + p.lungFvcMeas + "','"
                + p.lungFvcPer + "','" + p.lungFvcPredic + "','"
                + p.lungPerFev1 + "','" + p.lungSuggess + "','"
                + p.lungSummary + "','" + p.urineSummary + "','"

                + p.cbcSummary + "','" + p.summaryPhysicalExam + "','"
                + p.vdrl + "','" + p.visitHn + "',"
                + p.rowNumber + ",'" + p.cbcMcv + "','"
                    + p.stickerQty + "','" + p.statusCbc + "','"
                    + p.statusFbs + "','" + p.statusUa + "','"
                    + p.statusPe + "','" + p.statusXray + "','"
                    + p.statusStool + "','" + p.StoolExamSummary + "','"
                    + p.cholesterolSuggess + "','" + p.cholesterolSummary + "','"
                    + p.cbcMch + "','" + p.cbcMchc + "','"
                    + p.hbsagResult + "','" + p.hbsagSummary + "','"
                    + p.statusCholes + "','" + p.StatusHbsag + "','"
                    + p.cbcRbc + "','" + p.Active + "','"
                    + p.eyeBio + "','" + p.amphetamineSuggess + "','"
                    + p.amphetamineSummary + "','" + p.antiHivSuggess + "','"
                    + p.antiHivSummary + "','" + p.statusAmphetamine + "','"
                    + p.statusAntiHiv + "','" + p.statusVisit + "','"+
                    p.triglycerideResult + "','" + p.triglycerideSummary + "','" +
                    p.liverResult + "','" + p.liverSummary + "','" +
                    p.kidneyResult + "','" + p.kidneySummary + "','" + p.SexName + "'"+
                    ",'" + p.sticker01 + "','" + p.sticker02 + "','" + p.sticker03 + "'" +
                    ",'" + p.sticker04 + "','" + p.sticker05 + "','" + p.sticker06 + "'" +
                    ",'" + p.sticker07 + "','" + p.sticker08 + "','" + p.sticker09 + "'" +
                    ",'" + p.sticker10 + "','" + p.sticker11 + "','" + p.sticker12 + "'" +
                    ",'" + p.sticker13 + "','" + p.sticker14 + "','" + p.sticker15 + "'" +
                    ",'" + p.sticker16 + "','" + p.sticker17 + "','" + p.sticker18 + "'" +
                    ",'" + p.sticker19 + "','" + p.sticker20 + "','" + p.position_name + "'" +
                    ",'" + p.test01 + "','" + p.test02 + "','" + p.test03 + "'" +
                    ",'" + p.test04 + "','" + p.test05 + "','" + p.test06 + "'" +
                    ",'" + p.test07 + "','" + p.test08 + "','" + p.test09 + "'" +
                    ",'" + p.test10 + "','" + p.test11 + "','" + p.test12 + "'" +
                    ",'" + p.test13 + "','" + p.test14 + "','" + p.test15 + "'" +
                    ",'" + p.test16 + "','" + p.test17 + "','" + p.test18 + "'" +
                    ",'" + p.test19 + "','" + p.test20 + "' " +
                    ") ";
                chk = conn.ExecuteNonQuery(sql);
                sql = "Insert Into " + ccp1db.ccp1.table + "(" + ccp1db.ccp1.Id + "," + ccp1db.ccp1.CustCheckUpId + "," + ccp1db.ccp1.rowNumber +","+ccp1db.ccp1.Active+","+ccp1db.ccp1.patientFullname+
                    ") Values ('" + p.Id + "','" + p.CustCheckUpId + "'," + p.rowNumber + ",'1','"+p.patientFullname+"')";
                chk = conn.ExecuteNonQuery(sql);
    //            conn.close;
            } catch (Exception ex) {
                //Logger.getLogger(MarketingTCheckupDB.class.getName).log(Level.SEVERE, null, ex);
                //max = ex.getMessage;
            }
            return p.Id;
        }
        private String insertOnSite(CustCheckUpPatient p, ConnectDB connonsite)
        {
            String sql = "", chk = "", onsite = "";
            if (p.Id.Equals(""))
            {
                p.Id = "ccp" + p.getGenID();
            }
            try
            {
                
                onsite = " onsite_";
                
                //            Connection conn = config1.getConnectionBangna;
                //            Statement st = conn.createStatement;
                //ccp = getMarketingTCheckupPatientByPK(st,"", p.getMarketingCheckupPatientId,"");
                p.departmentName = p.departmentName.Replace("'", "''");
                p.patientFullname = p.patientFullname.Replace("'", "''");
                p.sectionName = p.sectionName.Replace("'", "''");
                p.summaryPhysicalExam = p.summaryPhysicalExam.Replace("'", "''");
                p.xrayChestExam = p.xrayChestExam.Replace("'", "''");
                p.position_name = p.position_name.Replace("'", "''");
                p.SexName = p.SexName.Replace("'", "''");

                //max = getMaxRowMarketingTCheckupPatient(st);
                p.statusAmphetamine = "0";
                p.statusAntiHiv = "0";
                p.statusCbc = "0";
                p.statusCholes = "0";
                p.statusFbs = "0";
                p.StatusHbsag = "0";
                p.statusPe = "0";
                p.statusName = "0";
                p.statusStool = "0";
                p.statusUa = "0";
                p.statusUricAcid = "0";
                p.statusVisit = "0";
                p.statusXray = "0";
                p.sticker01 = "0";
                p.sticker02 = "0";
                p.sticker03 = "0";
                p.sticker04 = "0";
                p.sticker05 = "0";
                p.sticker06 = "0";
                p.sticker07 = "0";
                p.sticker08 = "0";
                p.sticker09 = "0";
                p.sticker10 = "0";
                p.sticker11 = "0";
                p.sticker12 = "0";
                p.sticker13 = "0";
                p.sticker14 = "0";
                p.sticker15 = "0";
                p.sticker16 = "0";
                p.sticker17 = "0";
                p.sticker18 = "0";
                p.sticker19 = "0";
                p.sticker20 = "0";

                p.test01 = "0";
                p.test02 = "0";
                p.test03 = "0";
                p.test04 = "0";
                p.test05 = "0";
                p.test06 = "0";
                p.test07 = "0";
                p.test08 = "0";
                p.test09 = "0";
                p.test10 = "0";
                p.test11 = "0";
                p.test12 = "0";
                p.test13 = "0";
                p.test14 = "0";
                p.test15 = "0";
                p.test16 = "0";
                p.test17 = "0";
                p.test18 = "0";
                p.test19 = "0";
                p.test20 = "0";

                sql = "Insert Into " + onsite + ccp.table + "("
                + ccp.Id + ", " + ccp.amphetamine + ", "
                + ccp.antiHiv + "," + ccp.AudiogramExam + ","
                + ccp.Audiogram1000L + "," + ccp.Audiogram1000R + ","
                + ccp.Audiogram2000L + "," + ccp.Audiogram2000R + ","
                + ccp.Audiogram3000L + "," + ccp.Audiogram3000R + ","

                + ccp.Audiogram4000L + "," + ccp.Audiogram4000R + ","
                + ccp.Audiogram6000L + "," + ccp.Audiogram6000R + ","
                + ccp.Audiogram8000L + "," + ccp.Audiogram8000R + ","
                + ccp.Audiogram500L + "," + ccp.Audiogram500R + ","
                + ccp.AudiogramSummaryL + "," + ccp.AudiogramSummaryR + ","

                + ccp.CA125 + "," + ccp.cbcPlateletSmear + ","
                + ccp.CA199 + "," + ccp.CAAFP + ","
                + ccp.CACEA + "," + ccp.CAHCG + ","
                + ccp.calcium + "," + ccp.CAPSA + ","
                + ccp.cbcBasophil + "," + ccp.cbcEosinophil + ","

                + ccp.cbcHb + "," + ccp.cbcHct + ","
                + ccp.cbcLymphocyte + "," + ccp.cbcMonocyte + ","
                + ccp.cbcNeutrophil + "," + ccp.cbcPlateletCount + ","
                + ccp.cbcRbcMorpholog + "," + ccp.cbcWbc + ","
                + ccp.cholesterol + "," + ccp.departmentName + ","

                + ccp.disscusExam + "," + ccp.ekgExam + ","
                + ccp.urineEpithelium + "," + ccp.eyesExam + ","
                + ccp.BloodGroup + "," + ccp.fSexId + ","
                + ccp.hbsab + "," + ccp.hbsag + ","
                + ccp.hdl + "," + ccp.kidneyBun + ","

                + ccp.kidneyCreatinine + "," + ccp.ldl + ","
                + ccp.liverAlp + "," + ccp.liverSgot + ","
                + ccp.liverSgpt + "," + ccp.CustCheckUpId + ","
                + ccp.xrayChestExam + "," + ccp.EyeShortLongLeft + ","
                + ccp.EyeShortLongRight + "," + ccp.patientAge + ","

                + ccp.patientFullname + "," + ccp.xrayChestSummary + ","
                + ccp.patientHeight + "," + ccp.patientNumber + ","
                + ccp.patientPulse + "," + ccp.patientWeight + ","
                + ccp.pid + "," + ccp.sectionName + ","
                + ccp.StoolExamAppearance + "," + ccp.ChecklistId + ","

                + ccp.StoolExamColor + "," + ccp.StoolExamParasite + ","
                + ccp.StoolExamRbc + "," + ccp.StoolExamWbc + ","
                + ccp.sugar + "," + ccp.suggestExam + ","
                + ccp.sugarDiagnosis + "," + ccp.sugarSuggess + ","
                + ccp.sugarSummary + "," + ccp.urineResult + ","

                + ccp.thyroidT3 + "," + ccp.thyroidT4 + ","
                + ccp.thyroidTsh + "," + ccp.triglyceride + ","
                + ccp.uricAcid + "," + ccp.urineAppearance + ","

                + ccp.urineBacteria + "," + ccp.urineBlood + ","
                + ccp.urineKetone + "," + ccp.urineColor + ","
                + ccp.urinePh + "," + ccp.urineProtein + ","
                + ccp.urineRbc + "," + ccp.urineSpGr + ","
                + ccp.urineSugar + "," + ccp.urineWbc + ","

                + ccp.lungFev1Meas + "," + ccp.lungFev1Per + ","
                + ccp.lungFev1Predic + "," + ccp.lungFvcMeas + ","
                + ccp.lungFvcPer + "," + ccp.lungFvcPredic + ","
                + ccp.lungPerFev1 + "," + ccp.lungSuggess + ","
                + ccp.lungSummary + "," + ccp.urineSummary + ","

                + ccp.cbcSummary + "," + ccp.summaryPhysicalExam + ","
                + ccp.vdrl + "," + ccp.visitHn + ","
                + ccp.rowNumber + "," + ccp.cbcMcv + ","
                    + ccp.stickerQty + "," + ccp.statusCbc + ","
                    + ccp.statusFbs + "," + ccp.statusUa + ","
                    + ccp.statusPe + "," + ccp.statusXray + ","
                    + ccp.statusStool + "," + ccp.StoolExamSummary + ","
                    + ccp.cholesterolSuggess + "," + ccp.cholesterolSummary + ","
                    + ccp.cbcMch + "," + ccp.cbcMchc + ","
                    + ccp.hbsagResult + "," + ccp.hbsagSummary + ","
                    + ccp.statusCholes + "," + ccp.StatusHbsag + ","
                    + ccp.cbcRbc + "," + ccp.Active + ","
                    + ccp.eyeBio + "," + ccp.amphetamineSuggess + ","
                    + ccp.amphetamineSummary + "," + ccp.antiHivSuggess + ","
                    + ccp.antiHivSummary + "," + ccp.statusAmphetamine + ","
                    + ccp.statusAntiHiv + "," + ccp.statusVisit + "," +
                    ccp.triglycerideResult + "," + ccp.triglycerideSummary + "," +
                    ccp.liverResult + "," + ccp.liverSummary + "," +
                    ccp.kidneyResult + "," + ccp.kidneySummary + "," + ccp.SexName + " " +
                    "," + ccp.sticker01 + "," + ccp.sticker02 + "," + ccp.sticker03 + " " +
                    "," + ccp.sticker04 + "," + ccp.sticker05 + "," + ccp.sticker06 + " " +
                    "," + ccp.sticker07 + "," + ccp.sticker08 + "," + ccp.sticker09 + " " +
                    "," + ccp.sticker10 + "," + ccp.sticker11 + "," + ccp.sticker12 + " " +
                    "," + ccp.sticker13 + "," + ccp.sticker14 + "," + ccp.sticker15 + " " +
                    "," + ccp.sticker16 + "," + ccp.sticker17 + "," + ccp.sticker18 + " " +
                    "," + ccp.sticker19 + "," + ccp.sticker20 + "," + ccp.position_name + " " +
                    "," + ccp.test01 + "," + ccp.test02 + "," + ccp.test03 + " " +
                    "," + ccp.test04 + "," + ccp.test05 + "," + ccp.test06 + " " +
                    "," + ccp.test07 + "," + ccp.test08 + "," + ccp.test09 + " " +
                    "," + ccp.test10 + "," + ccp.test11 + "," + ccp.test12 + " " +
                    "," + ccp.test13 + "," + ccp.test14 + "," + ccp.test15 + " " +
                    "," + ccp.test16 + "," + ccp.test17 + "," + ccp.test18 + " " +
                    "," + ccp.test19 + "," + ccp.test20 + " " +
                    ") "

                + "Values('" + p.Id + "','" + p.amphetamine + "','"
                + p.antiHiv + "','" + p.AudiogramExam + "','"
                + p.Audiogram1000L + "','" + p.Audiogram1000R + "','"
                + p.Audiogram2000L + "','" + p.Audiogram2000R + "','"
                + p.Audiogram3000L + "','" + p.Audiogram3000R + "','"

                + p.Audiogram4000L + "','" + p.Audiogram4000R + "','"
                + p.Audiogram6000L + "','" + p.Audiogram6000R + "','"
                + p.Audiogram8000L + "','" + p.Audiogram8000R + "','"
                + p.Audiogram500L + "','" + p.Audiogram500R + "','"
                + p.AudiogramSummaryL + "','" + p.AudiogramSummaryR + "','"

                + p.CA125 + "','" + p.cbcPlateletSmear + "','"
                + p.CA199 + "','" + p.CAAFP + "','"
                + p.CACEA + "','" + p.CAHCG + "','"
                + p.calcium + "','" + p.CAPSA + "','"
                + p.cbcBasophil + "','" + p.cbcEosinophil + "','"

                + p.cbcHb + "','" + p.cbcHct + "','"
                + p.cbcLymphocyte + "','" + p.cbcMonocyte + "','"
                + p.cbcNeutrophil + "','" + p.cbcPlateletCount + "','"
                + p.cbcRbcMorpholog + "','" + p.cbcWbc + "','"
                + p.cholesterol + "','" + p.departmentName + "','"

                + p.disscusExam + "','" + p.ekgExam + "','"
                + p.urineEpithelium + "','" + p.eyesExam + "','"
                + p.BloodGroup + "','" + p.fSexId + "','"
                + p.hbsab + "','" + p.hbsag + "','"
                + p.hdl + "','" + p.kidneyBun + "','"

                + p.kidneyCreatinine + "','" + p.ldl + "','"
                + p.liverAlp + "','" + p.liverSgot + "','"
                + p.liverSgpt + "','" + p.CustCheckUpId + "','"
                + p.xrayChestExam + "','" + p.EyeShortLongLeft + "','"
                + p.EyeShortLongRight + "','" + p.patientAge + "','"

                + p.patientFullname + "','" + p.xrayChestSummary + "','"
                + p.patientHeight + "','" + p.patientNumber + "','"
                + p.patientPulse + "','" + p.patientWeight + "','"
                + p.pid + "','" + p.sectionName + "','"
                + p.StoolExamAppearance + "','" + p.ChecklistId + "','"

                + p.StoolExamColor + "','" + p.StoolExamParasite + "','"
                + p.StoolExamRbc + "','" + p.StoolExamWbc + "','"
                + p.sugar + "','" + p.suggestExam + "','"
                + p.sugarDiagnosis + "','" + p.sugarSuggess + "','"
                + p.sugarSummary + "','" + p.urineResult + "','"

                + p.thyroidT3 + "','" + p.thyroidT4 + "','"
                + p.thyroidTsh + "','" + p.triglyceride + "','"
                + p.uricAcid + "','" + p.urineAppearance + "','"

                + p.urineBacteria + "','" + p.urineBlood + "','"
                + p.urineKetone + "','" + p.urineColor + "','"
                + p.urinePh + "','" + p.urineProtein + "','"
                + p.urineRbc + "','" + p.urineSpGr + "','"
                + p.urineSugar + "','" + p.urineWbc + "','"

                + p.lungFev1Meas + "','" + p.lungFev1Per + "','"
                + p.lungFev1Predic + "','" + p.lungFvcMeas + "','"
                + p.lungFvcPer + "','" + p.lungFvcPredic + "','"
                + p.lungPerFev1 + "','" + p.lungSuggess + "','"
                + p.lungSummary + "','" + p.urineSummary + "','"

                + p.cbcSummary + "','" + p.summaryPhysicalExam + "','"
                + p.vdrl + "','" + p.visitHn + "',"
                + p.rowNumber + ",'" + p.cbcMcv + "','"
                    + p.stickerQty + "','" + p.statusCbc + "','"
                    + p.statusFbs + "','" + p.statusUa + "','"
                    + p.statusPe + "','" + p.statusXray + "','"
                    + p.statusStool + "','" + p.StoolExamSummary + "','"
                    + p.cholesterolSuggess + "','" + p.cholesterolSummary + "','"
                    + p.cbcMch + "','" + p.cbcMchc + "','"
                    + p.hbsagResult + "','" + p.hbsagSummary + "','"
                    + p.statusCholes + "','" + p.StatusHbsag + "','"
                    + p.cbcRbc + "','" + p.Active + "','"
                    + p.eyeBio + "','" + p.amphetamineSuggess + "','"
                    + p.amphetamineSummary + "','" + p.antiHivSuggess + "','"
                    + p.antiHivSummary + "','" + p.statusAmphetamine + "','"
                    + p.statusAntiHiv + "','" + p.statusVisit + "','" +
                    p.triglycerideResult + "','" + p.triglycerideSummary + "','" +
                    p.liverResult + "','" + p.liverSummary + "','" +
                    p.kidneyResult + "','" + p.kidneySummary + "','" + p.SexName + "'" +
                    ",'" + p.sticker01 + "','" + p.sticker02 + "','" + p.sticker03 + "'" +
                    ",'" + p.sticker04 + "','" + p.sticker05 + "','" + p.sticker06 + "'" +
                    ",'" + p.sticker07 + "','" + p.sticker08 + "','" + p.sticker09 + "'" +
                    ",'" + p.sticker10 + "','" + p.sticker11 + "','" + p.sticker12 + "'" +
                    ",'" + p.sticker13 + "','" + p.sticker14 + "','" + p.sticker15 + "'" +
                    ",'" + p.sticker16 + "','" + p.sticker17 + "','" + p.sticker18 + "'" +
                    ",'" + p.sticker19 + "','" + p.sticker20 + "','" + p.position_name + "'" +
                    ",'" + p.test01 + "','" + p.test02 + "','" + p.test03 + "'" +
                    ",'" + p.test04 + "','" + p.test05 + "','" + p.test06 + "'" +
                    ",'" + p.test07 + "','" + p.test08 + "','" + p.test09 + "'" +
                    ",'" + p.test10 + "','" + p.test11 + "','" + p.test12 + "'" +
                    ",'" + p.test13 + "','" + p.test14 + "','" + p.test15 + "'" +
                    ",'" + p.test16 + "','" + p.test17 + "','" + p.test18 + "'" +
                    ",'" + p.test19 + "','" + p.test20 + "' " +
                    ") ";
                chk = connonsite.ExecuteNonQuery(sql);
                //sql = "Insert Into " + ccp1db.ccp1.table + "(" + ccp1db.ccp1.Id + "," + ccp1db.ccp1.CustCheckUpId + "," + ccp1db.ccp1.rowNumber + "," + ccp1db.ccp1.Active + "," + ccp1db.ccp1.patientFullname +
                //    ") Values ('" + p.Id + "','" + p.CustCheckUpId + "'," + p.rowNumber + ",'1','" + p.patientFullname + "')";
                //chk = conn.ExecuteNonQuery(sql);
                //            conn.close;
            }
            catch (Exception ex)
            {
                //Logger.getLogger(MarketingTCheckupDB.class.getName).log(Level.SEVERE, null, ex);
                //max = ex.getMessage;
            }
            return p.Id;
        }
        private String update(CustCheckUpPatient p)
        {
            String chk = "";
            return chk;
        }
        //ccp.InsertCustCheckUpPatient()
        //{

        //}
        public String InsertCustCheckUpPatient(CustCheckUpPatient p)
        {
            //CustCheckUpPatient item = new CustCheckUpPatient();
            String chk = "", id="";
            id = selectByPk1(p.Id);
            if (id == "")
            {
                p.Active = "1";
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String InsertCustCheckUpPatient1(CustCheckUpPatient p)
        {
            //CustCheckUpPatient item = new CustCheckUpPatient();
            String chk = "", id = "";
            chk = insert(p);
            return chk;
        }
        public String UpdateName(String rowNumber, String cucId, String name, String age)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.patientFullname + "='" + name + "', " +
                ccp.patientAge + "='" + age + "' " +
                //ccp.departmentName + "='" + department + "' " +
                
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }

            return chk;
        }
        public String UpdateStatusVisit0(String ccpId)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set " + ccp.statusVisit + "='0' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateSticker(String visitHn, String cucId, String col, String val)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set sticker" + col + "='"+ val + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.visitHn + "='" + visitHn + "' ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateSticker(String visitHn, String cucId, String val1, String val2, String val3, String val4, String val5, String val6, String val7, String val8, String val9, String val10
            , String val11, String val12, String val13, String val14, String val15, String val16, String val17, String val18, String val19, String val20)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " +
                    "sticker01 ='" + val1 + "' " +
                    ",sticker02 ='" + val2 + "' " +
                    ",sticker03 ='" + val3 + "' " +
                    ",sticker04 ='" + val4 + "' " +
                    ",sticker05 ='" + val5 + "' " +
                    ",sticker06 ='" + val6 + "' " +
                    ",sticker07 ='" + val7 + "' " +
                    ",sticker08 ='" + val8 + "' " +
                    ",sticker09 ='" + val9 + "' " +
                    ",sticker10 ='" + val10 + "' " +
                    ",sticker11 ='" + val11 + "' " +
                    ",sticker12 ='" + val12 + "' " +
                    ",sticker13 ='" + val13 + "' " +
                    ",sticker14 ='" + val14 + "' " +
                    ",sticker15 ='" + val15 + "' " +
                    ",sticker16 ='" + val16 + "' " +
                    ",sticker17 ='" + val17 + "' " +
                    ",sticker18 ='" + val18 + "' " +
                    ",sticker19 ='" + val19 + "' " +
                    ",sticker20 ='" + val20 + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.visitHn + "='" + visitHn + "' ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateSticker(String ccpId, String val1, String val2, String val3, String val4, String val5, String val6, String val7, String val8, String val9, String val10
            , String val11, String val12, String val13, String val14, String val15, String val16, String val17, String val18, String val19, String val20)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set " +
                    "sticker01 ='" + val1 + "' " +
                    ",sticker02 ='" + val2 + "' " +
                    ",sticker03 ='" + val3 + "' " +
                    ",sticker04 ='" + val4 + "' " +
                    ",sticker05 ='" + val5 + "' " +
                    ",sticker06 ='" + val6 + "' " +
                    ",sticker07 ='" + val7 + "' " +
                    ",sticker08 ='" + val8 + "' " +
                    ",sticker09 ='" + val9 + "' " +
                    ",sticker10 ='" + val10 + "' " +
                    ",sticker11 ='" + val11 + "' " +
                    ",sticker12 ='" + val12 + "' " +
                    ",sticker13 ='" + val13 + "' " +
                    ",sticker14 ='" + val14 + "' " +
                    ",sticker15 ='" + val15 + "' " +
                    ",sticker16 ='" + val16 + "' " +
                    ",sticker17 ='" + val17 + "' " +
                    ",sticker18 ='" + val18 + "' " +
                    ",sticker19 ='" + val19 + "' " +
                    ",sticker20 ='" + val20 + "' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateStickerOnSite(String ccpId, String val1, String val2, String val3, String val4, String val5, String val6, String val7, String val8, String val9, String val10
            , String val11, String val12, String val13, String val14, String val15, String val16, String val17, String val18, String val19, String val20)
        {
            String chk = "", sql = "", onsite = "";
            try
            {
                
                onsite = " onsite_";
                
                sql = "Update " + onsite + ccp.table + " Set " +
                    "sticker01 ='" + val1 + "' " +
                    ",sticker02 ='" + val2 + "' " +
                    ",sticker03 ='" + val3 + "' " +
                    ",sticker04 ='" + val4 + "' " +
                    ",sticker05 ='" + val5 + "' " +
                    ",sticker06 ='" + val6 + "' " +
                    ",sticker07 ='" + val7 + "' " +
                    ",sticker08 ='" + val8 + "' " +
                    ",sticker09 ='" + val9 + "' " +
                    ",sticker10 ='" + val10 + "' " +
                    ",sticker11 ='" + val11 + "' " +
                    ",sticker12 ='" + val12 + "' " +
                    ",sticker13 ='" + val13 + "' " +
                    ",sticker14 ='" + val14 + "' " +
                    ",sticker15 ='" + val15 + "' " +
                    ",sticker16 ='" + val16 + "' " +
                    ",sticker17 ='" + val17 + "' " +
                    ",sticker18 ='" + val18 + "' " +
                    ",sticker19 ='" + val19 + "' " +
                    ",sticker20 ='" + val20 + "' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateTest(String ccpId, String val1, String val2, String val3, String val4, String val5, String val6, String val7, String val8, String val9, String val10
            , String val11, String val12, String val13, String val14, String val15, String val16, String val17, String val18, String val19, String val20)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set " +
                    "test01 ='" + val1 + "' " +
                    ",test02 ='" + val2 + "' " +
                    ",test03 ='" + val3 + "' " +
                    ",test04 ='" + val4 + "' " +
                    ",test05 ='" + val5 + "' " +
                    ",test06 ='" + val6 + "' " +
                    ",test07 ='" + val7 + "' " +
                    ",test08 ='" + val8 + "' " +
                    ",test09 ='" + val9 + "' " +
                    ",test10 ='" + val10 + "' " +
                    ",test11 ='" + val11 + "' " +
                    ",test12 ='" + val12 + "' " +
                    ",test13 ='" + val13 + "' " +
                    ",test14 ='" + val14 + "' " +
                    ",test15 ='" + val15 + "' " +
                    ",test16 ='" + val16 + "' " +
                    ",test17 ='" + val17 + "' " +
                    ",test18 ='" + val18 + "' " +
                    ",test19 ='" + val19 + "' " +
                    ",test20 ='" + val20 + "' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateTestOnSite(String ccpId, String val1, String val2, String val3, String val4, String val5, String val6, String val7, String val8, String val9, String val10
            , String val11, String val12, String val13, String val14, String val15, String val16, String val17, String val18, String val19, String val20)
        {
            String chk = "", sql = "", onsite = "";
            try
            {
                
                onsite = " onsite_";
                
                sql = "Update " + onsite + ccp.table + " Set " +
                    "test01 ='" + val1 + "' " +
                    ",test02 ='" + val2 + "' " +
                    ",test03 ='" + val3 + "' " +
                    ",test04 ='" + val4 + "' " +
                    ",test05 ='" + val5 + "' " +
                    ",test06 ='" + val6 + "' " +
                    ",test07 ='" + val7 + "' " +
                    ",test08 ='" + val8 + "' " +
                    ",test09 ='" + val9 + "' " +
                    ",test10 ='" + val10 + "' " +
                    ",test11 ='" + val11 + "' " +
                    ",test12 ='" + val12 + "' " +
                    ",test13 ='" + val13 + "' " +
                    ",test14 ='" + val14 + "' " +
                    ",test15 ='" + val15 + "' " +
                    ",test16 ='" + val16 + "' " +
                    ",test17 ='" + val17 + "' " +
                    ",test18 ='" + val18 + "' " +
                    ",test19 ='" + val19 + "' " +
                    ",test20 ='" + val20 + "' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateSticker0(String ccpId, String col)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set sticker"+col+"='0' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateSticker1(String ccpId, String col)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set sticker" + col + "='1' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateTest0(String ccpId, String col)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set test" + col + "='0' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateTest1(String ccpId, String col)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set test" + col + "='1' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateStatusVisit1(String ccpId)
        {
            String chk = "", sql = "", onsite="";
            try
            {
                if (conn.initc.statusonsite.Equals("yes"))
                {
                    onsite = " onsite_";
                }
                sql = "Update " + onsite+ccp.table + " Set " + ccp.statusVisit + "='1' " +
                "Where " + ccp.pkField + "='" + ccpId + "'  ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateName(String rowNumber, String cucId, String name, String age, String sex)
        {
            String chk = "", sql = "", sexname="";
            try
            {
                if (sex.Equals("1"))
                {
                    sexname = "ชาย";
                }
                else if (sex.Equals("2"))
                {
                    sexname = "หญิง";
                }
                else if (sex.Equals("3"))
                {
                    sexname = "ไม่ระบุ";
                }
                sql = "Update " + ccp.table + " Set " + ccp.patientFullname + "='" + name + "', " +
                ccp.patientAge + "='" + age + "', " +
                ccp.fSexId + "='" + sex + "', " +
                ccp.SexName + "='" + sexname + "' " +

                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }

            return chk;
        }
        public String UpdatePE(String rowNumber, String cucId, String vitalSign, String height, String weight, String bmi, String pulse, String result
            , String summary, String bloodgroup, String patientnumber)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.vitalsign + "='" + vitalSign + "', " +
                ccp.patientHeight + "='" + height + "'," +
                ccp.patientWeight + "='" + weight + "'," +
                ccp.bmi + "='" + bmi + "'," +
                ccp.patientPulse + "='" + pulse + "', " +
                ccp.BloodGroup + "='" + bloodgroup + "', " +
                ccp.PeResult + "='" + result.Replace("'", "''") + "', " +
                ccp.summaryPhysicalExam + "='" + summary.Replace("'", "''") + "' " +
                ","+ccp.patientNumber + "='" + patientnumber.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                lw.WriteLog("ccp.UpdatePE Error " + ex.Message);
                //max = ex.getMessage;
            }

            return chk;
        }
        public String UpdatePE(String rowNumber, String cucId, String age, String vitalSign, String height, String weight, String bmi, String pulse, String result
            , String summary, String bloodgroup, String patientnumber, String ekg, String ekgresult, String ekgsummary)
        {
            String chk = "", sql="";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.vitalsign + "='" + vitalSign + "', " +
                ccp.patientHeight + "='" + height + "'," +
                ccp.patientWeight + "='" + weight + "'," +
                ccp.bmi + "='" + bmi + "'," +
                ccp.patientPulse + "='" + pulse + "', " +
                ccp.patientAge + "='" + age + "', " +
                ccp.BloodGroup + "='" + bloodgroup + "' " +
                ","+ccp.PeResult + "='" + result.Replace("'", "''") + "' " +
                "," + ccp.summaryPhysicalExam + "='" + summary.Replace("'", "''") + "' " +
                "," + ccp.patientNumber + "='" + patientnumber.Replace("'", "''") + "' " +
                "," + ccp.ekg + "='" + ekg.Replace("'", "''") + "' " +
                "," + ccp.ekg_result + "='" + ekgresult.Replace("'", "''") + "' " +
                "," + ccp.ekg_summary + "='" + ekgsummary.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            } catch (Exception ex) {
                //Logger.getLogger(MarketingTCheckupDB.class.getName).log(Level.SEVERE, null, ex);
                //max = ex.getMessage;
            }
            return chk;
        }
        public String UpdateXray(String rowNumber, String cucId, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update "+ccp.table+" Set "+ccp.xrayChestExam+"='"+result+"' "+
                ","+ccp.xrayChestSummary+"='"+summary.Replace("'", "''") + "' "+
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateFBS(String rowNumber, String cucId, String value, String result, String summary, String suggess)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.sugar + "='" + value + "'," +
                ccp.sugarDiagnosis + "='" + result + "', " +
                ccp.sugarSummary + "='" + summary.Replace("'", "''") + "', " +
                ccp.sugarSuggess + "='" + suggess.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBC(String rowNumber, String cucId, String Basophil, String Eosinophil, String Hb, String Hct, String Lymphocyte,
            String Mch, String Mchc, String Mcv, String Monocyte, String Neutrophil, String PlateletCount, String Rbc, String RbcMorpholog, 
            String Summary, String Wbc, String PlateletSmear, String Pmn, String bact, String result)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcBasophil + "='" + Basophil + "'," +
                ccp.cbcEosinophil + "='" + Eosinophil + "', " +
                ccp.cbcHb + "='" + Hb + "', " +
                ccp.cbcHct + "='" + Hct + "', " +
                ccp.cbcLymphocyte + "='" + Lymphocyte + "', " +
                ccp.cbcMch + "='" + Mch + "', " +
                ccp.cbcMchc + "='" + Mchc + "', " +
                ccp.cbcMcv + "='" + Mcv + "', " +
                ccp.cbcMonocyte + "='" + Monocyte + "', " +
                ccp.cbcNeutrophil + "='" + Neutrophil + "', " +
                ccp.cbcPlateletCount + "='" + PlateletCount + "', " +
                ccp.cbcPlateletSmear + "='" + PlateletSmear + "', " +
                ccp.cbcRbc + "='" + Rbc + "', " +
                ccp.cbcRbcMorpholog + "='" + RbcMorpholog + "', " +
                ccp.cbcSummary + "='" + Summary.Replace("'", "''") + "', " +
                ccp.cbcWbc + "='" + Wbc + "', " +
                ccp.cbcPmn + "='" + Pmn + "', " +
                ccp.cbcBact + "='" + bact + "', " +
                ccp.cbcResult + "='" + result.Replace("'","''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCHbRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcHbLabName + "='" + labName + "' " +
                ", "+ccp.cbcHbLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", "+ccp.cbcHbRemark + "='" + remark.Replace("'", "''") + "' " +                
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCHctRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcHctLabName + "='" + labName + "' " +
                ", " + ccp.cbcHctLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcHctRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCWbcRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcWbcLabName + "='" + labName + "' " +
                ", " + ccp.cbcWbcLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcWbcRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCNeutrophilRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcNeutrophilLabName + "='" + labName + "' " +
                ", " + ccp.cbcNeutrophilLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcNeutrophilRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCEosinophilRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcEosinophilLabName + "='" + labName + "' " +
                ", " + ccp.cbcEosinophilLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcEosinophilRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCBasophilRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcBasophilLabName + "='" + labName + "' " +
                ", " + ccp.cbcBasophilLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcBasophilRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCLymphocyteRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcLymphocyteLabName + "='" + labName + "' " +
                ", " + ccp.cbcLymphocyteLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcLymphocyteRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCMonocyteRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcMonocyteLabName + "='" + labName + "' " +
                ", " + ccp.cbcMonocyteLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcMonocyteRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCRbcRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcRbcLabName + "='" + labName + "' " +
                ", " + ccp.cbcRbcLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcRbcRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCMcvRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcMcvLabName + "='" + labName + "' " +
                ", " + ccp.cbcMcvLabNormal + "='" + labNormal.Replace("'", "''") + "' " +
                ", " + ccp.cbcMcvRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCMchRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcMchLabName + "='" + labName + "' " +
                ", " + ccp.cbcMchLabNormal + "='" + labNormal + "' " +
                ", " + ccp.cbcMchRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCMchcRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcMchcLabName + "='" + labName + "' " +
                ", " + ccp.cbcMchcLabNormal + "='" + labNormal + "' " +
                ", " + ccp.cbcMchcRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCPlateletCountRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcPlateletCountLabName + "='" + labName + "' " +
                ", " + ccp.cbcPlateletCountLabNormal + "='" + labNormal + "' " +
                ", " + ccp.cbcPlateletCountRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCBCRbcMorphologRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cbcRbcMorphologLabName + "='" + labName + "' " +
                ", " + ccp.cbcRbcMorphologLabNormal + "='" + labNormal + "' " +
                ", " + ccp.cbcRbcMorphologRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiAcetoneRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiAcetoneLabName + "='" + labName + "' " +
                ", " + ccp.ToxiAcetoneLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiAcetoneRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiAluminiumRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiAluminiumLabName + "='" + labName + "' " +
                ", " + ccp.ToxiAluminiumLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiAluminiumRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiAmmoniaRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiAmmoniaLabName + "='" + labName + "' " +
                ", " + ccp.ToxiAmmoniaLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiAmmoniaRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiAntimonyRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiAntimonyLabName + "='" + labName + "' " +
                ", " + ccp.ToxiAntimonyLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiAntimonyRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiArsenicRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiArsenicLabName + "='" + labName + "' " +
                ", " + ccp.ToxiArsenicLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiArsenicRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiBenzeneRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiBenzeneLabName + "='" + labName + "' " +
                ", " + ccp.ToxiBenzeneLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiBenzeneRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiCadmiumRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiCadmiumLabName + "='" + labName + "' " +
                ", " + ccp.ToxiCadmiumLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiCadmiumRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiChromiumRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiChromiumLabName + "='" + labName + "' " +
                ", " + ccp.ToxiChromiumLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiChromiumRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiCopperRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiCopperLabName + "='" + labName + "' " +
                ", " + ccp.ToxiCopperLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiCopperRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiEthanolRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiEthanolLabName + "='" + labName + "' " +
                ", " + ccp.ToxiEthanolLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiEthanolRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiFluorideRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiFluorideLabName + "='" + labName + "' " +
                ", " + ccp.ToxiFluorideLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiFluorideRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiFomaldehydeRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiFomaldehydeLabName + "='" + labName + "' " +
                ", " + ccp.ToxiFomaldehydeLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiFomaldehydeRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiHexaneRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiHexaneLabName + "='" + labName + "' " +
                ", " + ccp.ToxiHexaneLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiHexaneRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiHippuricRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiHippuricLabName + "='" + labName + "' " +
                ", " + ccp.ToxiHippuricLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiHippuricRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiIPARemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiIPALabName + "='" + labName + "' " +
                ", " + ccp.ToxiIPALabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiIPARemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiKetoneRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiKetoneLabName + "='" + labName + "' " +
                ", " + ccp.ToxiKetoneLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiKetoneRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiLeadRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiLeadLabName + "='" + labName + "' " +
                ", " + ccp.ToxiLeadLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiLeadRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiMandelicRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiMandelicLabName + "='" + labName + "' " +
                ", " + ccp.ToxiMandelicLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiMandelicRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiManganeseRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiManganeseLabName + "='" + labName + "' " +
                ", " + ccp.ToxiManganeseLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiManganeseRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiMercuryRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiMercuryLabName + "='" + labName + "' " +
                ", " + ccp.ToxiMercuryLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiMercuryRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiMethanolRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiMethanolLabName + "='" + labName + "' " +
                ", " + ccp.ToxiMethanolLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiMethanolRemark + "='" + remark + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiMethylRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiMethylLabName + "='" + labName + "' " +
                ", " + ccp.ToxiMethylLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiMethylRemark + "='" + remark + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiNickelRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiNickelLabName + "='" + labName + "' " +
                ", " + ccp.ToxiNickelLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiNickelRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiPhenolRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiPhenolLabName + "='" + labName + "' " +
                ", " + ccp.ToxiPhenolLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiPhenolRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiTinRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiTinLabName + "='" + labName + "' " +
                ", " + ccp.ToxiTinLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiTinRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiTrichloroethyleneRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiTrichloroethyleneLabName + "='" + labName + "' " +
                ", " + ccp.ToxiTrichloroethyleneLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiTrichloroethyleneRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateToxiZincRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ToxiZincLabName + "='" + labName + "' " +
                ", " + ccp.ToxiZincLabNormal + "='" + labNormal + "' " +
                ", " + ccp.ToxiZincRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateurineColorRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.urineColorLabName + "='" + labName + "' " +
                ", " + ccp.urineColorLabNormal + "='" + labNormal + "' " +
                ", " + ccp.urineColorRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateurineAppearanceRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.urineAppearanceLabName + "='" + labName + "' " +
                ", " + ccp.urineAppearanceLabNormal + "='" + labNormal + "' " +
                ", " + ccp.urineAppearanceRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateurinePhRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.urinePhLabName + "='" + labName + "' " +
                ", " + ccp.urinePhLabNormal + "='" + labNormal + "' " +
                ", " + ccp.urinePhRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateurineSugarRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.urineSugarLabName + "='" + labName + "' " +
                ", " + ccp.urineSugarLabNormal + "='" + labNormal + "' " +
                ", " + ccp.urineSugarRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateurineProteinRemark(String rowNumber, String cucId, String labName, String labNormal, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.urineProteinLabName + "='" + labName + "' " +
                ", " + ccp.urineProteinLabNormal + "='" + labNormal + "' " +
                ", " + ccp.urineProteinRemark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCheckupPatientRemark(String rowNumber, String cucId, String FlabName, String labName, String FlabNormal, String labNormal, String Fremark, String remark)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + FlabName + "='" + labName + "' " +
                ", " + FlabNormal + "='" + labNormal + "' " +
                ", " + Fremark + "='" + remark.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQueryNoClose(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUA(String rowNumber, String cucId, String Color, String Appe, String Sugar, String spgr, String pH,
            String Protein, String Wbc, String Rbc, String Epi, String Bact, String Result, String Summary, String Glu, String Ketone, 
            String Blood, String leu, String nit, String uro, String bil)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.urineColor + "='" + Color + "'," +
                ccp.urineAppearance + "='" + Appe + "', " +
                ccp.urineSugar + "='" + Sugar + "', " +
                ccp.urineSpGr + "='" + spgr + "', " +
                ccp.urinePh + "='" + pH + "', " +
                ccp.urineProtein + "='" + Protein + "', " +
                ccp.urineWbc + "='" + Wbc + "', " +
                ccp.urineRbc + "='" + Rbc + "', " +
                ccp.urineEpithelium + "='" + Epi + "', " +
                ccp.urineBacteria + "='" + Bact + "', " +
                ccp.urineGlu + "='" + Glu + "', " +
                ccp.urineKetone + "='" + Ketone + "', " +
                ccp.urineSummary + "='" + Summary.Replace("'", "''") + "', " +
                ccp.urineResult + "='" + Result.Replace("'", "''") + "', " +
                ccp.urineBlood + "='" + Blood + "', " +
                ccp.urineLeu + "='" + leu + "', " +
                ccp.urineNit + "='" + nit + "', " +
                ccp.urineUro + "='" + uro + "', " +
                ccp.urineBil + "='" + bil + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateTrigly(String rowNumber, String cucId, String value, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.triglyceride + "='" + value + "'," +
                ccp.triglycerideResult + "='" + result.Replace("'", "''") + "', " +
                ccp.triglycerideSummary + "='" + summary.Replace("'", "''") + "' " +
                //ccp.sugarSuggess + "='" + suggess + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCholes(String rowNumber, String cucId, String value, String result, String summary, String ldl, String hdl, String ldlresult, String ldlsummary, String hdlresult, String hdlsummary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cholesterol + "='" + value + "'," +
                ccp.cholesterolSuggess + "='" + result.Replace("'", "''") + "', " +
                ccp.cholesterolSummary + "='" + summary.Replace("'", "''") + "', " +
                ccp.ldl + "='" + ldl + "', " +
                ccp.hdl + "='" + hdl + "', " +
                ccp.ChoLDLResult + "='" + ldlresult.Replace("'", "''") + "', " +
                ccp.ChoLDLsummary + "='" + ldlsummary.Replace("'", "''") + "', " +
                ccp.ChoHDLResult + "='" + hdlresult.Replace("'", "''") + "', " +
                ccp.ChoHDLsummary + "='" + hdlsummary.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateSgot(String rowNumber, String cucId, String sgot, String sgpt, String alt, String result, String summary, String alkaline)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.liverSgot + "='" + sgot + "'," +
                ccp.liverResult + "='" + result.Replace("'", "''") + "', " +
                ccp.liverSummary + "='" + summary.Replace("'", "''") + "', " +
                ccp.liverAlp + "='" + sgpt + "', " +
                ccp.liverSgpt + "='" + alt + "', " +
                ccp.liverAlkaline + "='" + alkaline + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateBun(String rowNumber, String cucId, String bun, String creatinine, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.kidneyBun + "='" + bun + "'," +
                ccp.kidneyResult + "='" + result.Replace("'", "''") + "', " +
                ccp.kidneySummary + "='" + summary.Replace("'", "''") + "', " +
                ccp.kidneyCreatinine + "='" + creatinine + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUric(String rowNumber, String cucId, String value, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.uricAcid + "='" + value + "'," +
                ccp.uricAcidSuggess + "='" + result.Replace("'", "''") + "', " +
                ccp.uricAcidSummary + "='" + summary.Replace("'", "''") + "' " +
                    //ccp.sugarSuggess + "='" + suggess + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateEKG(String rowNumber, String cucId, String value, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.ekg + "='" + value + "'," +
                ccp.ekg_result + "='" + result.Replace("'", "''") + "', " +
                ccp.ekg_summary + "='" + summary.Replace("'", "''") + "' " +
                //ccp.sugarSuggess + "='" + suggess + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        //public String UpdateOther1(String rowNumber, String cucId, String HBsAg, String HbsAb, String AntiHIV, String VDRL, String Amphetamine, String Calcium, String AntiHav,
        //    String CAAFP, String CACEA, String CAPSA, String CAHCG, String CA153, String CA125, String CA199, String HBsAgResult, 
        //    String HBsAgSummary, String HbsAbResult, String HbsAbSummary)
        public String UpdateOther1(String rowNumber, String cucId, String HBsAg, String HbsAb, String AntiHIV, String VDRL, String Amphetamine, String Calcium, String AntiHav,
            String CAAFP, String CAAFPResult, String CAAFPSummary, String CACEA, String CACEAResult, String CACEASummary, String CAPSA, String CAPSAResult, String CAPSASummary,
            String CAHCG, String CAHCGResult, String CAHCGSummary, String CA153, String CA153Result, String CA153Summary, String CA125, String CA125Result, String CA125Summary,
            String CA199, String CA199Result, String CA199Summary, String HBsAgResult,
            String HBsAgSummary, String HbsAbResult, String HbsAbSummary, String AmphetamineSummary, String AntiHavSummary)
        {
            String chk = "", sql = "";
            try
            {
                //sql = "Update " + ccp.table + " Set " + ccp.hbsag + "='" + HBsAg + "'," +
                //ccp.hbsab + "='" + HbsAb + "', " +
                //ccp.antiHiv + "='" + AntiHIV + "', " +
                //ccp.vdrl + "='" + VDRL + "', " +
                //ccp.amphetamine + "='" + Amphetamine + "', " +
                //ccp.calcium + "='" + Calcium + "', " +
                //ccp.AntiHav + "='" + AntiHav + "', " +
                //ccp.CAAFP + "='" + CAAFP + "', " +
                //ccp.CACEA + "='" + CACEA + "', " +
                //ccp.CAPSA + "='" + CAPSA + "', " +
                //ccp.CAHCG + "='" + CAHCG + "', " +
                //ccp.CA153 + "='" + CA153 + "', " +
                //ccp.CA125 + "='" + CA125 + "', " +
                //ccp.CA199 + "='" + CA199 + "', " +
                //ccp.hbsagResult + "='" + HBsAgResult + "', " +
                //ccp.hbsagSummary + "='" + HBsAgSummary + "', " +
                //ccp.hbsabResult + "='" + HbsAbResult + "', " +
                //ccp.hbsabSummary + "='" + HbsAbSummary + "' " +
                //"Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";

                sql = "Update " + ccp1db.ccp1.table + " Set " + ccp1db.ccp1.hbsag + "='" + HBsAg + "'," +
                ccp1db.ccp1.hbsab + "='" + HbsAb + "', " +
                ccp1db.ccp1.antiHiv + "='" + AntiHIV + "', " +
                ccp1db.ccp1.vdrl + "='" + VDRL + "', " +
                ccp1db.ccp1.amphetamine + "='" + Amphetamine + "', " +
                ccp1db.ccp1.calcium + "='" + Calcium + "', " +
                ccp1db.ccp1.AntiHav + "='" + AntiHav + "', " +
                ccp1db.ccp1.CAAFP + "='" + CAAFP + "', " +
                ccp1db.ccp1.CAAFPResult + "='" + CAAFPResult.Replace("'", "''") + "', " +
                ccp1db.ccp1.CAAFPSummary + "='" + CAAFPSummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.CACEA + "='" + CACEA + "', " +
                ccp1db.ccp1.CACEAResult + "='" + CACEAResult.Replace("'", "''") + "', " +
                ccp1db.ccp1.CACEASummary + "='" + CACEASummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.CAPSA + "='" + CAPSA + "', " +
                ccp1db.ccp1.CAPSAResult + "='" + CAPSAResult.Replace("'", "''") + "', " +
                ccp1db.ccp1.CAPSASummary + "='" + CAPSASummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.CAHCG + "='" + CAHCG + "', " +
                ccp1db.ccp1.CAHCGResult + "='" + CAHCGResult.Replace("'", "''") + "', " +
                ccp1db.ccp1.CAHCGSummary + "='" + CAHCGSummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.CA153 + "='" + CA153 + "', " +
                ccp1db.ccp1.CA153Result + "='" + CA153Result.Replace("'", "''") + "', " +
                ccp1db.ccp1.CA153Summary + "='" + CA153Summary.Replace("'", "''") + "', " +
                ccp1db.ccp1.CA125 + "='" + CA125 + "', " +
                ccp1db.ccp1.CA125Result + "='" + CA125Result.Replace("'", "''") + "', " +
                ccp1db.ccp1.CA125Summary + "='" + CA125Summary.Replace("'", "''") + "', " +
                ccp1db.ccp1.CA199 + "='" + CA199 + "', " +
                ccp1db.ccp1.CA199Result + "='" + CA199Result.Replace("'", "''") + "', " +
                ccp1db.ccp1.CA199Summary + "='" + CA199Summary.Replace("'", "''") + "', " +
                ccp1db.ccp1.hbsagResult + "='" + HBsAgResult.Replace("'", "''") + "', " +
                ccp1db.ccp1.hbsagSummary + "='" + HBsAgSummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.hbsabResult + "='" + HbsAbResult.Replace("'", "''") + "', " +
                ccp1db.ccp1.hbsabSummary + "='" + HbsAbSummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.AmphetamineSummary + "='" + AmphetamineSummary.Replace("'", "''") + "', " +
                ccp1db.ccp1.AntiHavSummary + "='" + AntiHavSummary.Replace("'", "''") + "' " +
                "Where " + ccp1db.ccp1.CustCheckUpId + "='" + cucId + "' and " + ccp1db.ccp1.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateLung(String rowNumber, String cucId, String LungFvcPredic, String LungFvcMeas, String LungFvcPer, String LungFev1Predic, String LungFev1Meas,
            String LungFev1Per, String LungPerFev1, String LungSummary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.lungFvcPredic + "='" + LungFvcPredic + "'," +
                ccp.lungFvcMeas + "='" + LungFvcMeas + "', " +
                ccp.lungFvcPer + "='" + LungFvcPer + "', " +
                ccp.lungFev1Predic + "='" + LungFev1Predic + "', " +
                ccp.lungFev1Meas + "='" + LungFev1Meas + "', " +
                ccp.lungFev1Per + "='" + LungFev1Per + "', " +
                ccp.lungPerFev1 + "='" + LungPerFev1 + "', " +
                ccp.lungSummary + "='" + LungSummary.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String updateAudioGram(String rowNumber, String cucId, String Audiogram500L, String Audiogram500R, String Audiogram1000L, String Audiogram1000R, String Audiogram2000L, String Audiogram2000R,
            String Audiogram3000L, String Audiogram3000R, String Audiogram4000L, String Audiogram4000R, String Audiogram6000L, String Audiogram6000R, String Audiogram8000L, String Audiogram8000R,
            String AudiogramSummaryL, String AudiogramSummaryR, String AudiogramExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccp.table + " Set " + ccp.Audiogram500L + "='" + Audiogram500L + "', " +
                ccp.Audiogram500R + "='" + Audiogram500R + "', " +
                ccp.Audiogram1000L + "='" + Audiogram1000L + "', " +
                ccp.Audiogram1000R + "='" + Audiogram1000R + "', " +
                ccp.Audiogram2000L + "='" + Audiogram2000L + "', " +
                ccp.Audiogram2000R + "='" + Audiogram2000R + "', " +
                ccp.Audiogram3000L + "='" + Audiogram3000L + "', " +
                ccp.Audiogram3000R + "='" + Audiogram3000R + "', " +
                ccp.Audiogram4000L + "='" + Audiogram4000L + "', " +
                ccp.Audiogram4000R + "='" + Audiogram4000R + "', " +
                ccp.Audiogram6000L + "='" + Audiogram6000L + "', " +
                ccp.Audiogram6000R + "='" + Audiogram6000R + "', " +
                ccp.Audiogram8000L + "='" + Audiogram8000L + "', " +
                ccp.Audiogram8000R + "='" + Audiogram8000R + "', " +
                ccp.AudiogramSummaryL + "='" + AudiogramSummaryL.Replace("'", "''") + "', " +
                ccp.AudiogramSummaryR + "='" + AudiogramSummaryR.Replace("'", "''") + "', " +
                ccp.AudiogramExam + "='" + AudiogramExam.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
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
        public String updateEye(String rowNumber, String cucId, String EyeShortLongLeft, String EyeShortLongRight, String EyeSquintLeft, String EyeSquintRight,
            String EyeDegreeLeft, String EyeDegreeRight, String EyeOldLeft, String EyeOldRight, String EyeResult, String EyeSummary, String EyeBlindness, String EyeExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccp.table + " Set " + ccp.EyeShortLongLeft + "='" + EyeShortLongLeft + "', " +
                ccp.EyeShortLongRight + "='" + EyeShortLongRight + "', " +
                ccp.EyeSquintLeft + "='" + EyeSquintLeft + "', " +
                ccp.EyeSquintRight + "='" + EyeSquintRight + "', " +
                ccp.EyeDegreeLeft + "='" + EyeDegreeLeft + "', " +
                ccp.EyeDegreeRight + "='" + EyeDegreeRight + "', " +
                ccp.EyeOldLeft + "='" + EyeOldLeft + "', " +
                ccp.EyeOldRight + "='" + EyeOldRight + "', " +
                ccp.EyeResult + "='" + EyeResult.Replace("'", "''") + "', " +
                ccp.EyeSummary + "='" + EyeSummary.Replace("'", "''") + "', " +
                ccp.EyeBlindness + "='" + EyeBlindness + "', "+
                ccp.EyeExam + "='" + EyeExam + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
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
        public String updateStoolExam(String rowNumber, String cucId, String StoolExamAppearance, String StoolExamColor, String StoolExamWbc, String StoolExamRbc,
            String StoolExamParasite, String StoolExamSummary, String StoolExamCulture, String StoolExamTyhoidH, String StoolExamTyhoidO, String StoolExamCultureSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + ccp.table + " Set " + ccp.StoolExamAppearance + "='" + StoolExamAppearance + "', " +
                ccp.StoolExamColor + "='" + StoolExamColor + "', " +
                ccp.StoolExamWbc + "='" + StoolExamWbc + "', " +
                ccp.StoolExamRbc + "='" + StoolExamRbc + "', " +
                ccp.StoolExamParasite + "='" + StoolExamParasite + "', " +
                ccp.StoolExamSummary + "='" + StoolExamSummary.Replace("'", "''") + "', "+
                ccp.StoolExamCulture + "='" + StoolExamCulture + "', " +
                ccp.StoolExamTyphoidH + "='" + StoolExamTyhoidH + "', " +
                ccp.StoolExamTyphoidO + "='" + StoolExamTyhoidO + "', " +
                ccp.StoolExamCultureSummary + "='" + StoolExamCultureSummary.Replace("'", "''") + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
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
        public String updateToxi1(String rowNumber, String cucId, String ToxiLead, String ToxiAluminium, String ToxiCadmium, String ToxiMercury, String ToxiTin, String ToxiCopper,
            String ToxiManganese, String ToxiZinc, String ToxiAmmonia)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccp.table + " Set " + ccp.ToxiLead + "='" + ToxiLead + "', " +
                ccp.ToxiAluminium + "='" + ToxiAluminium + "', " +
                ccp.ToxiCadmium + "='" + ToxiCadmium + "', " +
                ccp.ToxiMercury + "='" + ToxiMercury + "', " +
                ccp.ToxiTin + "='" + ToxiTin + "', " +
                ccp.ToxiCopper + "='" + ToxiCopper + "', " +
                ccp.ToxiManganese + "='" + ToxiManganese + "', " +
                ccp.ToxiZinc + "='" + ToxiZinc + "', " +
                ccp.ToxiAmmonia + "='" + ToxiAmmonia + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
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
        public String updateToxi2(String rowNumber, String cucId, String ToxiHippuric, String ToxiMethyl, String ToxiAcetone, String ToxiNickel, String ToxiChromium, String ToxiPhenol,
            String ToxiKetone, String ToxiBenzene, String ToxiMandelic, String ToxiMethanol, String ToxiEthanol, String ToxiIPA, String ToxiArsenic, String ToxiHexane,
            String ToxiFomaldehyde, String ToxiTrichloroethylene, String ToxiAntimony, String ToxiFluoride)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ccp.table + " Set " + ccp.ToxiHippuric + "='" + ToxiHippuric + "', " +
                ccp.ToxiMethyl + "='" + ToxiMethyl + "', " +
                ccp.ToxiAcetone + "='" + ToxiAcetone + "', " +
                ccp.ToxiNickel + "='" + ToxiNickel + "', " +
                ccp.ToxiChromium + "='" + ToxiChromium + "', " +
                ccp.ToxiPhenol + "='" + ToxiPhenol + "', " +
                ccp.ToxiKetone + "='" + ToxiKetone + "', " +
                ccp.ToxiBenzene + "='" + ToxiBenzene + "', " +
                ccp.ToxiMandelic + "='" + ToxiMandelic + "', " +
                ccp.ToxiMethanol + "='" + ToxiMethanol + "', " +
                ccp.ToxiEthanol + "='" + ToxiEthanol + "', " +
                ccp.ToxiIPA + "='" + ToxiIPA + "', " +
                ccp.ToxiArsenic + "='" + ToxiArsenic + "', " +
                ccp.ToxiHexane + "='" + ToxiHexane + "', " +
                ccp.ToxiFomaldehyde + "='" + ToxiFomaldehyde + "', " +
                ccp.ToxiTrichloroethylene + "='" + ToxiTrichloroethylene + "', " +
                ccp.ToxiAntimony + "='" + ToxiAntimony + "', " +
                ccp.ToxiFluoride + "='" + ToxiFluoride + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
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
