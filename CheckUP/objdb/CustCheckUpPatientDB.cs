using CheckUP.objdb;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUP.objdb
{
    public class CustCheckUpPatientDB
    {
        ConnectDB conn;
        public CustCheckUpPatient ccp;
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
            ccp.CACEA = "ca_cea";
            ccp.CAPSA = "ca_psa";
            ccp.CAHCG = "ca_hcg";
            ccp.CA153 = "ca_153";
            ccp.CA125 = "ca_125";
            ccp.CA199 = "ca_19_9";

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

            ccp.disscusExam = "disscus_exam";
            ccp.suggestExam = "suggest_exam";
            ccp.sugar = "sugar";
            ccp.sugarDiagnosis = "sugar_diagnosis";
            ccp.sugarSummary = "sugar_summary";
            ccp.sugarSuggess = "sugar_suggess";
            ccp.kidneyBun = "kidney_bun";
            ccp.kidneyCreatinine = "kidney_creatinine";
            ccp.kidneyResult = "kidney_result";
            ccp.kidneySummary = "kidney_summary";
            ccp.liverSgot = "liver_sgot";
            ccp.liverSgpt = "liver_sgpt";
            ccp.liverAlp = "liver_alp";
            ccp.liverResult = "liver_result";
            ccp.liverSummary = "liver_summary";
            ccp.liverAlkaline = "liver_alkaline";

            ccp.uricAcid = "uric_acid";
            ccp.cholesterol = "cholesterol";
            ccp.triglyceride = "triglyceride";
            ccp.triglycerideResult = "triglyceride_result";
            ccp.triglycerideSummary = "triglyceride_summary";
            ccp.hdl = "hdl";
            ccp.ldl = "ldl";
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
            ccp.urineKetone = "urine_ketone";
            ccp.urineBlood = "urine_blood";

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

            ccp.hbsagSuggess = "hbsag_suggess";
            ccp.hbsagSummary = "hbsag_summary";
            ccp.cbcRbc = "cbc_rbc";
            ccp.cbcMch = "cbc_mch";
            ccp.cbcMchc = "cbc_mchc";
            ccp.Active = "cust_checkup_patient_active";
            ccp.eyeBio = "eye_bio";
            ccp.amphetamineSummary = "amphetamine_summary";
            ccp.amphetamineSuggess = "amphetamine_suggess";

            ccp.antiHivSummary = "anti_hiv_summary";
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
            ccp.cbcPlateletSmear = "cbc_platelet_smear";
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
            ccp.urineLeu = "urine_leu";
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

            ccp.ToxiAcetone = "toxicology_acetone";
            ccp.ToxiAluminium = "toxicology_aluminium";
            ccp.ToxiAmmonia = "toxicology_ammonia";
            ccp.ToxiAntimony = "toxicology_antimony";
            ccp.ToxiArsenic = "toxicology_arsenic";
            ccp.ToxiBenzene = "toxicology_benzene";
            ccp.ToxiCadmium = "toxicology_cadmium";
            ccp.ToxiChromium = "toxicology_chromium";
            ccp.ToxiCopper = "toxicology_copper";
            ccp.ToxiEthanol = "toxicology_ethanol";
            ccp.ToxiFluoride = "toxicology_fluoride";
            ccp.ToxiFomaldehyde = "toxicology_fomaldehyde";
            ccp.ToxiHexane = "toxicology_hexane";
            ccp.ToxiHippuric = "toxicology_hippuric";
            ccp.ToxiIPA = "toxicology_ipa";
            ccp.ToxiKetone = "toxicology_ketone";
            ccp.ToxiLead = "toxicology_lead";
            ccp.ToxiMandelic = "toxicology_mandelic";
            ccp.ToxiManganese = "toxicology_manganese";
            ccp.ToxiMercury = "toxicology_mercury";
            ccp.ToxiMethanol = "toxicology_methanol";
            ccp.ToxiMethyl = "toxicology_methyl";
            ccp.ToxiNickel = "toxicology_nickel";
            ccp.ToxiPhenol = "toxicology_phenol";
            ccp.ToxiTin = "toxicology_tin";
            ccp.ToxiTrichloroethylene = "toxicology_trichloroethylenel";
            ccp.ToxiZinc = "toxicology_zinc";

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
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccp.table + " Where " + ccp.Id + " = '" + ccpId + "'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectAllByCucId(String cucId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and "+ccp.CustCheckUpId+" = '"+cucId+"' Order By "+ccp.rowNumber;
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
        private String insert(CustCheckUpPatient p) {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "ccp" + p.getGenID();
            }
            try {
    //            Connection conn = config1.getConnectionBangna;
    //            Statement st = conn.createStatement;
                //ccp = getMarketingTCheckupPatientByPK(st,"", p.getMarketingCheckupPatientId,"");
                p.departmentName=p.departmentName.Replace("'", "''");
                p.patientFullname = p.patientFullname.Replace("'", "''");
                p.sectionName = p.sectionName.Replace("'", "''");
                p.summaryPhysicalExam = p.summaryPhysicalExam.Replace("'", "''");
                p.xrayChestExam = p.xrayChestExam.Replace("'", "''");
                //p.xrayChestExam = p.xrayChestExam.Replace("'", "''"));
                //p.xrayChestExam = p.xrayChestExam.Replace("'", "''"));

                    //max = getMaxRowMarketingTCheckupPatient(st);
            sql = "Insert Into " + ccp.table+ "(" 
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
                    + ccp.hbsagSuggess+","+ccp.hbsagSummary+","
                    + ccp.statusCholes+","+ccp.StatusHbsag+","
                    + ccp.cbcRbc+","+ccp.Active+","
                    + ccp.eyeBio+","+ccp.amphetamineSuggess+","
                    + ccp.amphetamineSummary+","+ccp.antiHivSuggess+","
                    + ccp.antiHivSummary+","+ccp.statusAmphetamine+","
                    + ccp.statusAntiHiv+","+ccp.statusVisit+","+
                    ccp.triglycerideResult + "," + ccp.triglycerideSummary +","+
                    ccp.liverResult + "," + ccp.liverSummary +","+
                    ccp.kidneyResult + "," + ccp.kidneySummary + "," + ccp.SexName + ") "
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
                    + p.hbsagSuggess + "','" + p.hbsagSummary + "','"
                    + p.statusCholes + "','" + p.StatusHbsag + "','"
                    + p.cbcRbc + "','" + p.Active + "','"
                    + p.eyeBio + "','" + p.amphetamineSuggess + "','"
                    + p.amphetamineSummary + "','" + p.antiHivSuggess + "','"
                    + p.antiHivSummary + "','" + p.statusAmphetamine + "','"
                    + p.statusAntiHiv + "','" + p.statusVisit + "','"+
                    p.triglycerideResult + "','" + p.triglycerideSummary + "','" +
                    p.liverResult + "','" + p.liverSummary + "','" +
                    p.kidneyResult + "','" + p.kidneySummary + "','" + p.SexName + "') ";
            chk = conn.ExecuteNonQuery(sql);
    //            conn.close;
            } catch (Exception ex) {
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
        public String UpdatePE(String rowNumber, String cucId, String vitalSign, String height, String weight, String bmi, String pulse, String result, String summary, String bloodgroup)
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
                ccp.PeResult + "='" + result + "', " +
                ccp.summaryPhysicalExam + "='" + summary + "' " +
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
        public String UpdatePE(String rowNumber, String cucId, String age, String vitalSign, String height, String weight, String bmi, String pulse, String result, String summary, String bloodgroup)
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
                sql = "Update "+ccp.table+" Set "+ccp.xrayChestExam+"='"+result+"',"+
                ccp.xrayChestSummary+"='"+summary+"' "+
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
                ccp.sugarSummary + "='" + summary + "', " +
                ccp.sugarSuggess + "='" + suggess + "' " +
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
            String Summary, String Wbc, String PlateletSmear, String Pmn)
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
                ccp.cbcSummary + "='" + Summary + "', " +
                ccp.cbcWbc + "='" + Wbc + "', " +
                ccp.cbcPmn + "='" + Pmn + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUA(String rowNumber, String cucId, String Color, String Appe, String Sugar, String spgr, String pH,
            String Protein, String Wbc, String Rbc, String Epi, String Bact, String Result, String Summary, String Glu, String Ketone, String Blood)
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
                ccp.urineSummary + "='" + Summary + "', " +
                ccp.urineResult + "='" + Result + "', " +
                ccp.urineBlood + "='" + Blood + "' " +
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
                ccp.triglycerideResult + "='" + result + "', " +
                ccp.triglycerideSummary + "='" + summary + "' " +
                //ccp.sugarSuggess + "='" + suggess + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateCholes(String rowNumber, String cucId, String value, String result, String summary, String ldl, String hdl)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cholesterol + "='" + value + "'," +
                ccp.cholesterolSuggess + "='" + result + "', " +
                ccp.cholesterolSummary + "='" + summary + "', " +
                ccp.ldl + "='" + ldl + "', " +
                ccp.hdl + "='" + hdl + "' " +
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
                ccp.liverResult + "='" + result + "', " +
                ccp.liverSummary + "='" + summary + "', " +
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
                ccp.kidneyResult + "='" + result + "', " +
                ccp.kidneySummary + "='" + summary + "', " +
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
                ccp.uricAcidSuggess + "='" + result + "', " +
                ccp.uricAcidSummary + "='" + summary + "' " +
                    //ccp.sugarSuggess + "='" + suggess + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateOther1(String rowNumber, String cucId, String HBsAg, String HbsAb, String AntiHIV, String VDRL, String Amphetamine, String Calcium, String AntiHav,
            String CAAFP = "", String CACEA = "", String CAPSA = "", String CAHCG = "", String CA153 = "", String CA125 = "", String CA199 = "")
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.hbsag + "='" + HBsAg + "'," +
                ccp.hbsab + "='" + HbsAb + "', " +
                ccp.antiHiv + "='" + AntiHIV + "', " +
                ccp.vdrl + "='" + VDRL + "', " +
                ccp.amphetamine + "='" + Amphetamine + "', " +
                ccp.calcium + "='" + Calcium + "', " +
                ccp.AntiHav + "='" + AntiHav + "', " +
                ccp.CAAFP + "='" + CAAFP + "', " +
                ccp.CACEA + "='" + CACEA + "', " +
                ccp.CAPSA + "='" + CAPSA + "', " +
                ccp.CAHCG + "='" + CAHCG + "', " +
                ccp.CA153 + "='" + CA153 + "', " +
                ccp.CA125 + "='" + CA125 + "', " +
                ccp.CA199 + "='" + CA199 + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
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
                ccp.lungSummary + "='" + LungSummary + "' " +
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
                ccp.AudiogramSummaryL + "='" + AudiogramSummaryL + "', " +
                ccp.AudiogramSummaryR + "='" + AudiogramSummaryR + "', " +
                ccp.AudiogramExam + "='" + AudiogramExam + "' " +
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
                ccp.EyeResult + "='" + EyeResult + "', " +
                ccp.EyeSummary + "='" + EyeSummary + "', " +
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
            String StoolExamParasite, String StoolExamSummary, String StoolExamCulture, String StoolExamTyhoidH, String StoolExamTyhoidO)
        {
            String sql = "", chk = "";

            sql = "Update " + ccp.table + " Set " + ccp.StoolExamAppearance + "='" + StoolExamAppearance + "', " +
                ccp.StoolExamColor + "='" + StoolExamColor + "', " +
                ccp.StoolExamWbc + "='" + StoolExamWbc + "', " +
                ccp.StoolExamRbc + "='" + StoolExamRbc + "', " +
                ccp.StoolExamParasite + "='" + StoolExamParasite + "', " +
                ccp.StoolExamSummary + "='" + StoolExamSummary + "', "+
                ccp.StoolExamCulture + "='" + StoolExamCulture + "', " +
                ccp.StoolExamTyphoidH + "='" + StoolExamTyhoidH + "', " +
                ccp.StoolExamTyphoidO + "='" + StoolExamTyhoidO + "' " +
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
