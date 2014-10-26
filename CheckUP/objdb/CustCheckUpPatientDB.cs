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
        public CustCheckUpPatientDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
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
            ccp.opticalExamLeft = "optical_exam_left";
            ccp.opticalExamRight = "optical_exam_right";
            ccp.fSexId = "f_sex_id";
            ccp.summaryPhysicalExam = "summary_physical_exam";
            ccp.stoolExamColor = "stool_exam_color";
            ccp.stoolExamAppearance = "stool_exam_appearance";
            ccp.stoolExamWbc = "stool_exam_wbc";
            ccp.stoolExamRbc = "stool_exam_rbc";
            ccp.stoolExamParasite = "stool_exam_parasite";
            ccp.toxicologyLead = "toxicology_lead";
            ccp.toxicologyMercury = "toxicology_mercury";
            ccp.toxicologyBenzene = "toxicology_benzene";
            ccp.toxicologyXylene = "toxicology_xylene";
            ccp.audiogram500Left = "audiogram_500_left";
            ccp.audiogram1000Left = "audiogram_1000_left";
            ccp.audiogram2000Left = "audiogram_2000_left";
            ccp.audiogram3000Left = "audiogram_3000_left";
            ccp.audiogram4000Left = "audiogram_4000_left";
            ccp.audiogram6000Left = "audiogram_6000_left";
            ccp.audiogram8000Left = "audiogram_8000_left";
            ccp.audiogramSummaryLeft = "audiogram_summary_left";
            ccp.audiogram500Right = "audiogram_500_right";
            ccp.audiogram1000Right = "audiogram_1000_right";
            ccp.audiogram2000Right = "audiogram_2000_right";
            ccp.audiogram3000Right = "audiogram_3000_right";
            ccp.audiogram4000Rightt = "audiogram_4000_rightt";
            ccp.audiogram6000Right = "audiogram_6000_right";
            ccp.audiogram8000Right = "audiogram_8000_right";
            ccp.audiogramSummaryRight = "audiogram_summary_right";
            ccp.audiogramExam = "audiogram_exam";
            ccp.xrayChestExam = "xray_chest_exam";
            ccp.xrayChestSummary = "xray_chest_summary";
            ccp.eyesExam = "eyes_exam";
            ccp.ekgExam = "ekg_exam";
            ccp.caAfp = "ca_afp";
            ccp.caCea = "ca_cea";
            ccp.caPsa = "ca_psa";
            ccp.caHcg = "ca_hcg";
            ccp.ca153 = "ca_153";
            ccp.ca125 = "ca_125";
            ccp.ca199 = "ca_19_9";
            ccp.thyroidT3 = "thyroid_t3";
            ccp.thyroidT4 = "thyroid_t4";
            ccp.thyroidTsh = "thyroid_tsh";
            ccp.fPatientBloodGroupId = "f_patient_blood_group_id";
            ccp.vdrl = "vdrl";
            ccp.antiHiv = "anti_hiv";
            ccp.hbsag = "hbsag";
            ccp.hbsab = "hbsab";
            ccp.amphetamine = "amphetamine";
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
            ccp.toxicologyToluene = "toxicology_toluene";
            ccp.thyroidRubellaLgg = "thyroid_rubella_lgg";
            ccp.billirubin = "billirubin";
            ccp.toxicologyThinner = "toxicology_thinner";
            ccp.toxicologyAlcohol = "toxicology_alcohol";
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

            ccp.stoolExamSummary = "stool_exam_summary";
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
            ccp.antiHbc = "anti_hbc";
            ccp.caFt3 = "ca_ft3";
            ccp.hbtyping = "hbtyping";
            ccp.toxicologyHexane = "toxicology_hexane";
            ccp.toxicologyMethanol = "toxicology_methanol";
            ccp.toxicologyMek = "toxicology_mek";
            ccp.toxicologyAcetone = "toxicology_acetone";
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
            ccp.toxicologyLeadOld = "toxicology_lead_old";
            ccp.toxicologyMercuryOld = "toxicology_mercury_old";
            ccp.toxicologyBenzeneOld = "toxicology_benzene_old";
            ccp.toxicologyXyleneOld = "toxicology_xylene_old";
            ccp.toxicologyThinnerOld = "toxicology_thinner_old";
            ccp.toxicologyAlcoholOld = "toxicology_alcohol_old";
            ccp.toxicologyHexaneOld = "toxicology_hexane_old";
            ccp.toxicologyMethanolOld = "toxicology_methanol_old";
            ccp.toxicologyMekOld = "toxicology_mek_old";
            ccp.toxicologyAcetoneOld = "toxicology_acetone_old";
            ccp.toxicologyTolueneOld = "toxicology_toluene_old";
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
            sql = "Select * From " + ccp.table + " Where " + ccp.Active + "='1' and " + ccp.CustCheckUpId + " = '" + cucId + "'";
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
                + ccp.antiHiv + "," + ccp.audiogramExam + ","
                + ccp.audiogram1000Left + "," + ccp.audiogram1000Right + ","
                + ccp.audiogram2000Left + "," + ccp.audiogram2000Right + ","
                + ccp.audiogram3000Left + "," + ccp.audiogram3000Right + ","

                + ccp.audiogram4000Left + "," + ccp.audiogram4000Rightt + ","
                + ccp.audiogram6000Left + "," + ccp.audiogram6000Right + ","
                + ccp.audiogram8000Left + "," + ccp.audiogram8000Right + ","
                + ccp.audiogram500Left + "," + ccp.audiogram500Right + ","
                + ccp.audiogramSummaryLeft + "," + ccp.audiogramSummaryRight + ","

                + ccp.ca125 + "," + ccp.cbcPlateletSmear + ","
                + ccp.ca199 + "," + ccp.caAfp + ","
                + ccp.caCea + "," + ccp.caHcg + ","
                + ccp.calcium + "," + ccp.caPsa + ","
                + ccp.cbcBasophil + "," + ccp.cbcEosinophil + ","

                + ccp.cbcHb + "," + ccp.cbcHct + ","
                + ccp.cbcLymphocyte + "," + ccp.cbcMonocyte + ","
                + ccp.cbcNeutrophil + "," + ccp.cbcPlateletCount + ","
                + ccp.cbcRbcMorpholog + "," + ccp.cbcWbc + ","
                + ccp.cholesterol + "," + ccp.departmentName + ","

                + ccp.disscusExam + "," + ccp.ekgExam + ","
                + ccp.urineEpithelium + "," + ccp.eyesExam + ","
                + ccp.fPatientBloodGroupId + "," + ccp.fSexId + ","
                + ccp.hbsab + "," + ccp.hbsag + ","
                + ccp.hdl + "," + ccp.kidneyBun + ","

                + ccp.kidneyCreatinine + "," + ccp.ldl + ","
                + ccp.liverAlp + "," + ccp.liverSgot + ","
                + ccp.liverSgpt + "," + ccp.CustCheckUpId + ","
                + ccp.xrayChestExam + "," + ccp.opticalExamLeft + ","
                + ccp.opticalExamRight + "," + ccp.patientAge + ","

                + ccp.patientFullname + "," + ccp.xrayChestSummary+","
                + ccp.patientHeight + "," + ccp.patientNumber + ","
                + ccp.patientPulse + "," + ccp.patientWeight + ","
                + ccp.pid + "," + ccp.sectionName + ","
                + ccp.stoolExamAppearance + "," + ccp.ChecklistId + ","

                + ccp.stoolExamColor + "," + ccp.stoolExamParasite + ","
                + ccp.stoolExamRbc + "," + ccp.stoolExamWbc + ","
                + ccp.sugar + "," + ccp.suggestExam + ","
                + ccp.sugarDiagnosis + "," + ccp.sugarSuggess + ","
                + ccp.sugarSummary + ","+ccp.urineResult+","

                + ccp.thyroidT3+ "," + ccp.thyroidT4 + ","
                + ccp.thyroidTsh + "," + ccp.toxicologyBenzene + ","
                + ccp.toxicologyLead + "," + ccp.toxicologyMercury + ","
                + ccp.toxicologyXylene + "," + ccp.triglyceride + ","
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
                    + ccp.statusStool+","+ccp.stoolExamSummary+","
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
                    ccp.kidneyResult + "," + ccp.kidneySummary + ") "
                + "Values('" + p.Id + "','" + p.amphetamine + "','"
                + p.antiHiv + "','" + p.audiogramExam + "','"
                + p.audiogram1000Left + "','" + p.audiogram1000Right + "','"
                + p.audiogram2000Left + "','" + p.audiogram2000Right + "','"
                + p.audiogram3000Left + "','" + p.audiogram3000Right + "','"

                + p.audiogram4000Left + "','" + p.audiogram4000Rightt + "','"
                + p.audiogram6000Left + "','" + p.audiogram6000Right + "','"
                + p.audiogram8000Left + "','" + p.audiogram8000Right + "','"
                + p.audiogram500Left + "','" + p.audiogram500Right + "','"
                + p.audiogramSummaryLeft + "','" + p.audiogramSummaryRight + "','"

                + p.ca125 + "','" + p.cbcPlateletSmear + "','"
                + p.ca199 + "','" + p.caAfp + "','"
                + p.caCea + "','" + p.caHcg + "','"
                + p.calcium + "','" + p.caPsa + "','"
                + p.cbcBasophil + "','" + p.cbcEosinophil + "','"

                + p.cbcHb + "','" + p.cbcHct + "','"
                + p.cbcLymphocyte + "','" + p.cbcMonocyte + "','"
                + p.cbcNeutrophil + "','" + p.cbcPlateletCount + "','"
                + p.cbcRbcMorpholog + "','" + p.cbcWbc + "','"
                + p.cholesterol + "','" + p.departmentName + "','"

                + p.disscusExam + "','" + p.ekgExam + "','"
                + p.urineEpithelium + "','" + p.eyesExam + "','"
                + p.fPatientBloodGroupId + "','" + p.fSexId + "','"
                + p.hbsab + "','" + p.hbsag + "','"
                + p.hdl + "','" + p.kidneyBun + "','"

                + p.kidneyCreatinine + "','" + p.ldl + "','"
                + p.liverAlp + "','" + p.liverSgot + "','"
                + p.liverSgpt + "','" + p.CustCheckUpId + "','"
                + p.xrayChestExam + "','" + p.opticalExamLeft + "','"
                + p.opticalExamRight + "','" + p.patientAge + "','"

                + p.patientFullname + "','" + p.xrayChestSummary + "','"
                + p.patientHeight + "','" + p.patientNumber + "','"
                + p.patientPulse + "','" + p.patientWeight + "','"
                + p.pid + "','" + p.sectionName + "','"
                + p.stoolExamAppearance + "','" + p.ChecklistId + "','"

                + p.stoolExamColor + "','" + p.stoolExamParasite + "','"
                + p.stoolExamRbc + "','" + p.stoolExamWbc + "','"
                + p.sugar + "','" + p.suggestExam + "','"
                + p.sugarDiagnosis + "','" + p.sugarSuggess + "','"
                + p.sugarSummary + "','"+p.urineResult+"','"

                + p.thyroidT3 + "','" + p.thyroidT4 + "','"
                + p.thyroidTsh + "','" + p.toxicologyBenzene + "','"
                + p.toxicologyLead + "','" + p.toxicologyMercury + "','"
                + p.toxicologyXylene + "','" + p.triglyceride + "','"
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
                    + p.statusStool + "','" + p.stoolExamSummary + "','"
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
                    p.kidneyResult + "','" + p.kidneySummary + "') ";
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
        public String UpdatePE(String rowNumber, String cucId, String vitalSign, String height, String weight, String bmi, String pulse, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.vitalsign + "='" + vitalSign + "', " +
                ccp.patientHeight + "='" + height + "'," +
                ccp.patientWeight + "='" + weight + "'," +
                ccp.bmi + "='" + bmi + "'," +
                ccp.patientPulse + "='" + pulse + "' " +
                //ccp.patientAge + "='" + age + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                //Logger.getLogger(MarketingTCheckupDB.class.getName).log(Level.SEVERE, null, ex);
                //max = ex.getMessage;
            }

            return chk;
        }
        public String UpdatePE(String rowNumber, String cucId, String age, String vitalSign, String height, String weight, String bmi, String pulse, String result, String summary)
        {
            String chk = "", sql="";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.vitalsign + "='" + vitalSign + "', " +
                ccp.patientHeight + "='" + height + "'," +
                ccp.patientWeight + "='" + weight + "'," +
                ccp.bmi + "='" + bmi + "'," +
                ccp.patientPulse + "='" + pulse + "', " +
                ccp.patientAge + "='" + age + "' " +
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
            String Summary, String Wbc, String PlateletSmear)
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
                ccp.cbcWbc + "='" + Wbc + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateUA(String rowNumber, String cucId, String Color, String Appe, String Sugar, String spgr, String pH,
            String Protein, String Wbc, String Rbc, String Epi, String Bact, String Result,String Summary)
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
                //ccp.urineSummary + "='" + Result + "', " +                
                //ccp.urineRbc + "='" + Rbc + "', " +
                ccp.urineSummary + "='" + Summary + "', " +
                ccp.urineResult + "='" + Result + "' " +
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
        public String UpdateCholes(String rowNumber, String cucId, String value, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.cholesterol + "='" + value + "'," +
                ccp.cholesterolSuggess + "='" + result + "', " +
                ccp.cholesterolSummary + "='" + summary + "' " +
                    //ccp.sugarSuggess + "='" + suggess + "' " +
                "Where " + ccp.CustCheckUpId + "='" + cucId + "' and " + ccp.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql); ;
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
        public String UpdateSgot(String rowNumber, String cucId, String sgot, String sgpt, String alt, String result, String summary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp.table + " Set " + ccp.liverSgot + "='" + sgot + "'," +
                ccp.liverResult + "='" + result + "', " +
                ccp.liverSummary + "='" + summary + "', " +
                ccp.liverAlp + "='" + sgpt + "', " +
                ccp.liverSgpt + "='" + alt + "' " +
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
    }
}
