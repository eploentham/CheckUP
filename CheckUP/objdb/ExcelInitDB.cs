using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class ExcelInitDB
    {
        ConnectDB conn;
        public ExcelInit ei;
        public ExcelInitDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            ei = new ExcelInit();
            ei.Id = "id";

            ei.DepartmentName = "department_name";

            ei.Bun = "bun_value";
            ei.BunCreatinine = "bun_creatinine";
            ei.BunNo = "bun_no";
            ei.BunResult = "bun_result";
            ei.BunRow = "bun_row";
            ei.BunSummary = "bun_summary";

            ei.CBCBact = "cbc_bact";
            ei.CBCEos = "cbc_eos";
            ei.CBCHb = "cbc_hb";
            ei.CBCHct = "cbc_hct";
            ei.CBCLy = "cbc_ly";
            ei.CBCMono = "cbc_mono";
            ei.CBCNeu = "cbc_neu";
            ei.CBCNo = "cbc_no";
            ei.CBCPltC = "cbc_plt_c";
            ei.CBCPltS = "cbc_plt_s";
            ei.CBCRBC = "cbc_rbc";
            ei.CBCRBCmono = "cbc_rbc_mono";
            ei.CBCRow = "cbc_row";
            ei.CBCSummary = "cbc_summary";
            ei.CBCWBC = "cbc_wbc";
            ei.cbcPmn = "cbc_pmn";

            ei.Cholesteral = "cho_value";
            ei.ChoNo = "cho_no";
            ei.ChoResult = "cho_result";
            ei.ChoRow = "cho_row";
            ei.Chosummary = "cho_summary";
            ei.ChoHDL = "hdl";
            ei.ChoLDL = "ldl";

            ei.FBS = "fbs_value";
            ei.FBSNo = "fbs_no";
            ei.FBSResult = "fbs_result";
            ei.FBSRow = "fbs_row";
            ei.FBSSummary = "fbs_summary";

            ei.PEAge = "pe_age";
            ei.PEBMI = "pe_bmi";
            ei.PEHeight = "pe_height";
            ei.PENo = "pe_no";
            ei.PEPulse = "pe_pulse";
            ei.PEResult = "pe_result";
            ei.PERow = "pe_row";
            ei.PESummary = "pe_summary";
            ei.PEVitalSign = "pe_vitalsign";
            ei.PEWeight = "pe_weight";
            ei.PEBloodGroup = "pe_bloodgroup";

            ei.SfAAge = "sf_a_age";
            ei.SfAFirstName = "sf_a_first_name";
            ei.SfALastName = "sf_a_last_name";
            ei.SfANo = "sf_a_no";
            ei.SfAPrefix = "sf_a_prefix";
            ei.SfBAge = "sf_b_age";
            ei.SfBFullName = "sf_b_fullname";
            ei.SfBNo = "sf_b_no";
            ei.SfBPrefix = "sf_b_prefix";
            ei.SfCAge = "sf_c_age";
            ei.SfCFullName = "sf_c_fullname";
            ei.SfCNo = "sf_c_no";
            ei.SfRow = "sf_row";
            ei.SfStatusName = "sf_status_name";

            ei.Sgot = "sgot_value";
            ei.SgotNo = "sgot_no";
            ei.SgotResult = "sgot_result";
            ei.SgotRow = "sgot_row";
            ei.Sgpt = "sgot_sgpt_value";
            ei.SgptSummary = "sgot_summary";
            ei.SgotALP = "sgot_alt_vaule";

            ei.Triglyceride = "tri_value";
            ei.TriNo = "tri_no";
            ei.TriResult = "tri_result";
            ei.TriRow = "tri_row";
            ei.TriSummary = "tri_summary";

            ei.UAAppe = "ua_appe";
            ei.UABact = "ua_bact";
            ei.UAColor = "ua_color";
            ei.UAEpi = "ua_epi";
            ei.UANo = "ua_no";
            ei.UApH = "ua_ph";
            ei.UAProtein = "ua_protein";
            ei.UARBC = "ua_rbc";
            ei.UAResult = "ua_rasult";
            ei.UARow = "ua_row";
            ei.UASpgr = "ua_spgr";
            ei.UASugar = "ua_sugar";
            ei.UASummary = "ua_summary";
            ei.UAWBC = "ua_wbc";

            ei.UricAcid = "uric_acid_value";
            ei.UricNo = "uric_no";
            ei.UricResult = "uric_result";
            ei.UricRow = "uric_row";
            ei.UricSummary = "uric_summary";

            ei.Xray = "xray_value";
            ei.XrayNo = "xray_no";
            ei.XrayRow = "xray_row";
            ei.XraySummary = "xray_summary";
            ei.Active = "active";

            ei.Other1Amphetamine = "other1_amphetamine";
            ei.Other1AntiHIV = "other1_antihiv";
            ei.Other1Calcium = "other1_calcium";
            ei.Other1HBsAb = "other1_hbsab";
            ei.Other1HBsAg = "other1_hbsag";
            ei.Other1No = "other1_no";
            ei.Other1Row = "other1_row";
            ei.Other1VDRL = "other1_vdrl";

            ei.LungFev1Meas = "lung_fev1_meas";
            ei.LungFev1Per = "lung_fev1_per";
            ei.LungFev1Predic = "lung_fev1_predic";
            ei.LungFvcMeas = "lung_fvc_meas";
            ei.LungFvcPer = "lung_fvc_per";
            ei.LungFvcPredic = "lung_fvc_predic";
            ei.LungNo = "lung_no";
            ei.LungPerFev1 = "lung_per_fev1";
            ei.LungRow = "lung_row";
            ei.LungSummary = "lung_summary";

            ei.Audiogram1000L = "audiogram_1000_left";
            ei.Audiogram1000R = "audiogram_1000_right";
            ei.Audiogram2000L = "audiogram_2000_left";
            ei.Audiogram2000R = "audiogram_2000_right";
            ei.Audiogram3000L = "audiogram_3000_left";
            ei.Audiogram3000R = "audiogram_3000_right";
            ei.Audiogram4000L = "audiogram_4000_left";
            ei.Audiogram4000R = "audiogram_4000_rightt";
            ei.Audiogram500L = "audiogram_500_left";
            ei.Audiogram500R = "audiogram_500_right";
            ei.Audiogram6000L = "audiogram_6000_left";
            ei.Audiogram6000R = "audiogram_6000_right";
            ei.Audiogram8000L = "audiogram_8000_left";
            ei.Audiogram8000R = "audiogram_8000_right";
            ei.AudiogramExam = "audiogram_exam";
            ei.AudiogramSummaryL = "audiogram_summary_left";
            ei.AudiogramSummaryR = "audiogram_summary_right";
            ei.AudiogramNo = "audiogram_no";
            ei.AudiogramRow = "audiogram_row";

            ei.EyeNo = "eye_no";
            ei.EyeRow = "eye_row";
            //ei.EyeShortLongLeft = "eye_short_long_left";
            //ei.EyeShortLongRight = "eye_short_long_right";
            ei.EyeDegreeLeft = "eye_degree_left";
            ei.EyeDegreeRight = "eye_degree_right";
            ei.EyeShortLongLeft = "eye_short_long_left";
            ei.EyeShortLongRight = "eye_short_long_right";
            ei.EyeSquintLeft = "eye_squint_left";
            ei.EyeSquintRight = "eye_squint_short";
            ei.EyeOldLeft = "eye_old_left";
            ei.EyeOldRight = "eye_old_right";
            ei.EyeSummary = "eye_summary";
            ei.EyeResult = "eye_result";
            ei.EyeBlindness = "eye_blindness";
            ei.EyeExam = "eyes_exam";


            ei.StoolExamAppearance = "stool_exam_appearance";
            ei.StoolExamColor = "stool_exam_color";
            ei.StoolExamNo = "stool_exam_no";
            ei.StoolExamParasite = "stool_exam_parasite";
            ei.StoolExamRbc = "stool_exam_rbc";
            ei.StoolExamRow = "stool_exam_row";
            ei.StoolExamSummary = "stool_exam_summary";
            ei.StoolExamWbc = "stool_exam_wbc";

            ei.ToxiAcetone = "toxicology_acetone";
            ei.ToxiAluminium = "toxicology_aluminium";
            ei.ToxiAmmonia = "toxicology_ammonia";
            ei.ToxiAntimony = "toxicology_antimony";
            ei.ToxiArsenic = "toxicology_arsenic";
            ei.ToxiBenzene = "toxicology_benzene";
            ei.ToxiCadmium = "toxicology_cadmium";
            ei.ToxiChromium = "toxicology_chromium";
            ei.ToxiCopper = "toxicology_copper";
            ei.ToxiEthanol = "toxicology_ethanol";
            ei.ToxiFluoride = "toxicology_fluoride";
            ei.ToxiFomaldehyde = "toxicology_fomaldehyde";
            ei.ToxiHexane = "toxicology_hexane";
            ei.ToxiHippuric = "toxicology_hippuric";
            ei.ToxiIPA = "toxicology_ipa";
            ei.ToxiKetone = "toxicology_ketone";
            ei.ToxiLead = "toxicology_lead";
            ei.ToxiMandelic = "toxicology_mandelic";
            ei.ToxiManganese = "toxicology_manganese";
            ei.ToxiMercury = "toxicology_mercury";
            ei.ToxiMethanol = "toxicology_methanol";
            ei.ToxiMethyl = "toxicology_methyl";
            ei.ToxiNickel = "toxicology_nickel";
            ei.ToxiPhenol = "toxicology_phenol";
            ei.ToxiTin = "toxicology_tin";
            ei.ToxiTrichloroethylene = "toxicology_trichloroethylenel";
            ei.ToxiZinc = "toxicology_zinc";
            ei.ToxiRow = "toxicology_row";
            ei.ToxiNo = "toxicology_no";

            ei.pkField = "id";
            ei.table = "b_excel_init";
        }
        private ExcelInit setData(ExcelInit item, DataTable dt)
        {
            item.Id = dt.Rows[0][ei.Id].ToString();
            item.Bun = NumberNull10(dt.Rows[0][ei.Bun].ToString());
            item.BunCreatinine = NumberNull10(dt.Rows[0][ei.BunCreatinine].ToString());
            item.BunNo = NumberNull10(dt.Rows[0][ei.BunNo].ToString());
            item.BunResult = NumberNull10(dt.Rows[0][ei.BunResult].ToString());
            item.BunRow = NumberNull10(dt.Rows[0][ei.BunRow].ToString());
            item.BunSummary = NumberNull10(dt.Rows[0][ei.BunSummary].ToString());

            item.CBCBact = NumberNull10(dt.Rows[0][ei.CBCBact].ToString());
            item.CBCEos = NumberNull10(dt.Rows[0][ei.CBCEos].ToString());
            item.CBCHb = NumberNull10(dt.Rows[0][ei.CBCHb].ToString());
            item.CBCHct = NumberNull10(dt.Rows[0][ei.CBCHct].ToString());
            item.CBCLy = NumberNull10(dt.Rows[0][ei.CBCLy].ToString());
            item.CBCMono = NumberNull10(dt.Rows[0][ei.CBCMono].ToString());
            item.CBCNeu = NumberNull10(dt.Rows[0][ei.CBCNeu].ToString());
            item.CBCNo = NumberNull10(dt.Rows[0][ei.CBCNo].ToString());
            item.CBCPltC = NumberNull10(dt.Rows[0][ei.CBCPltC].ToString());
            item.CBCPltS = NumberNull10(dt.Rows[0][ei.CBCPltS].ToString());
            item.CBCRBC = NumberNull10(dt.Rows[0][ei.CBCRBC].ToString());
            item.CBCRBCmono = NumberNull10(dt.Rows[0][ei.CBCRBCmono].ToString());
            item.CBCRow = NumberNull10(dt.Rows[0][ei.CBCRow].ToString());
            item.CBCSummary = NumberNull10(dt.Rows[0][ei.CBCSummary].ToString());
            item.CBCWBC = NumberNull10(dt.Rows[0][ei.CBCWBC].ToString());
            item.cbcPmn = NumberNull10(dt.Rows[0][ei.cbcPmn].ToString());

            item.Cholesteral = NumberNull10(dt.Rows[0][ei.Cholesteral].ToString());
            item.ChoNo = NumberNull10(dt.Rows[0][ei.ChoNo].ToString());
            item.ChoResult = NumberNull10(dt.Rows[0][ei.ChoResult].ToString());
            item.ChoRow = NumberNull10(dt.Rows[0][ei.ChoRow].ToString());
            item.Chosummary = NumberNull10(dt.Rows[0][ei.Chosummary].ToString());
            item.ChoHDL = NumberNull10(dt.Rows[0][ei.ChoHDL].ToString());
            item.ChoLDL = NumberNull10(dt.Rows[0][ei.ChoLDL].ToString());

            item.FBS = NumberNull10(dt.Rows[0][ei.FBS].ToString());
            item.FBSNo = NumberNull10(dt.Rows[0][ei.FBSNo].ToString());
            item.FBSResult = NumberNull10(dt.Rows[0][ei.FBSResult].ToString());
            item.FBSRow = NumberNull10(dt.Rows[0][ei.FBSRow].ToString());
            item.FBSSummary = NumberNull10(dt.Rows[0][ei.FBSSummary].ToString());

            item.PEAge = NumberNull10(dt.Rows[0][ei.PEAge].ToString());
            item.PEBMI = NumberNull10(dt.Rows[0][ei.PEBMI].ToString());
            item.PEHeight = NumberNull10(dt.Rows[0][ei.PEHeight].ToString());
            item.PENo = NumberNull10(dt.Rows[0][ei.PENo].ToString());
            item.PEPulse = NumberNull10(dt.Rows[0][ei.PEPulse].ToString());
            item.PEResult = NumberNull10(dt.Rows[0][ei.PEResult].ToString());
            item.PERow = NumberNull10(dt.Rows[0][ei.PERow].ToString());
            item.PESummary = NumberNull10(dt.Rows[0][ei.PESummary].ToString());
            item.PEVitalSign = NumberNull10(dt.Rows[0][ei.PEVitalSign].ToString());
            item.PEWeight = NumberNull10(dt.Rows[0][ei.PEWeight].ToString());
            item.PEBloodGroup = NumberNull10(dt.Rows[0][ei.PEBloodGroup].ToString());

            item.DepartmentName = NumberNull10(dt.Rows[0][ei.DepartmentName].ToString());

            item.SfAAge = NumberNull10(dt.Rows[0][ei.SfAAge].ToString());
            item.SfAFirstName = NumberNull10(dt.Rows[0][ei.SfAFirstName].ToString());
            item.SfALastName = NumberNull10(dt.Rows[0][ei.SfALastName].ToString());
            item.SfANo = NumberNull10(dt.Rows[0][ei.SfANo].ToString());
            item.SfAPrefix = NumberNull10(dt.Rows[0][ei.SfAPrefix].ToString());
            item.SfBAge = NumberNull10(dt.Rows[0][ei.SfBAge].ToString());
            item.SfBFullName = NumberNull10(dt.Rows[0][ei.SfBFullName].ToString());
            item.SfBNo = NumberNull10(dt.Rows[0][ei.SfBNo].ToString());
            item.SfBPrefix = NumberNull10(dt.Rows[0][ei.SfBPrefix].ToString());
            item.SfCAge = NumberNull10(dt.Rows[0][ei.SfCAge].ToString());
            item.SfCFullName = NumberNull10(dt.Rows[0][ei.SfCFullName].ToString());
            item.SfCNo = NumberNull10(dt.Rows[0][ei.SfCNo].ToString());
            item.SfRow = NumberNull10(dt.Rows[0][ei.SfRow].ToString());
            item.SfStatusName = NumberNull10(dt.Rows[0][ei.SfStatusName].ToString());

            item.Sgot = NumberNull10(dt.Rows[0][ei.Sgot].ToString());
            item.SgotNo = NumberNull10(dt.Rows[0][ei.SgotNo].ToString());
            item.SgotResult = NumberNull10(dt.Rows[0][ei.SgotResult].ToString());
            item.SgotRow = NumberNull10(dt.Rows[0][ei.SgotRow].ToString());
            item.Sgpt = NumberNull10(dt.Rows[0][ei.Sgpt].ToString());
            item.SgptSummary = NumberNull10(dt.Rows[0][ei.SgptSummary].ToString());
            item.SgotALP = NumberNull10(dt.Rows[0][ei.SgotALP].ToString());

            item.Triglyceride = NumberNull10(dt.Rows[0][ei.Triglyceride].ToString());
            item.TriNo = NumberNull10(dt.Rows[0][ei.TriNo].ToString());
            item.TriResult = NumberNull10(dt.Rows[0][ei.TriResult].ToString());
            item.TriRow = NumberNull10(dt.Rows[0][ei.TriRow].ToString());
            item.TriSummary = NumberNull10(dt.Rows[0][ei.TriSummary].ToString());

            item.UAAppe = NumberNull10(dt.Rows[0][ei.UAAppe].ToString());
            item.UABact = NumberNull10(dt.Rows[0][ei.UABact].ToString());
            item.UAColor = NumberNull10(dt.Rows[0][ei.UAColor].ToString());
            item.UAEpi = NumberNull10(dt.Rows[0][ei.UAEpi].ToString());
            item.UANo = NumberNull10(dt.Rows[0][ei.UANo].ToString());
            item.UApH = NumberNull10(dt.Rows[0][ei.UApH].ToString());
            item.UAProtein = NumberNull10(dt.Rows[0][ei.UAProtein].ToString());
            item.UARBC = NumberNull10(dt.Rows[0][ei.UARBC].ToString());
            item.UAResult = NumberNull10(dt.Rows[0][ei.UAResult].ToString());
            item.UARow = NumberNull10(dt.Rows[0][ei.UARow].ToString());
            item.UASpgr = NumberNull10(dt.Rows[0][ei.UASpgr].ToString());
            item.UASugar = NumberNull10(dt.Rows[0][ei.UASugar].ToString());
            item.UASummary = NumberNull10(dt.Rows[0][ei.UASummary].ToString());
            item.UAWBC = NumberNull10(dt.Rows[0][ei.UAWBC].ToString());

            item.UricAcid = NumberNull10(dt.Rows[0][ei.UricAcid].ToString());
            item.UricNo = NumberNull10(dt.Rows[0][ei.UricNo].ToString());
            item.UricResult = NumberNull10(dt.Rows[0][ei.UricResult].ToString());
            item.UricRow = NumberNull10(dt.Rows[0][ei.UricRow].ToString());
            item.UricSummary = NumberNull10(dt.Rows[0][ei.UricSummary].ToString());

            item.Xray = NumberNull10(dt.Rows[0][ei.Xray].ToString());
            item.XrayNo = NumberNull10(dt.Rows[0][ei.XrayNo].ToString());
            item.XrayRow = NumberNull10(dt.Rows[0][ei.XrayRow].ToString());
            item.XraySummary = NumberNull10(dt.Rows[0][ei.XraySummary].ToString());

            item.Other1Amphetamine = NumberNull10(dt.Rows[0][ei.Other1Amphetamine].ToString());
            item.Other1AntiHIV = NumberNull10(dt.Rows[0][ei.Other1AntiHIV].ToString());
            item.Other1Calcium = NumberNull10(dt.Rows[0][ei.Other1Calcium].ToString());
            item.Other1HBsAb = NumberNull10(dt.Rows[0][ei.Other1HBsAb].ToString());
            item.Other1HBsAg = NumberNull10(dt.Rows[0][ei.Other1HBsAg].ToString());
            item.Other1No = NumberNull10(dt.Rows[0][ei.Other1No].ToString());
            item.Other1Row = NumberNull10(dt.Rows[0][ei.Other1Row].ToString());
            item.Other1VDRL = NumberNull10(dt.Rows[0][ei.Other1VDRL].ToString());

            item.LungFev1Meas = NumberNull10(dt.Rows[0][ei.LungFev1Meas].ToString());
            item.LungFev1Per = NumberNull10(dt.Rows[0][ei.LungFev1Per].ToString());
            item.LungFev1Predic = NumberNull10(dt.Rows[0][ei.LungFev1Predic].ToString());
            item.LungFvcMeas = NumberNull10(dt.Rows[0][ei.LungFvcMeas].ToString());
            item.LungFvcPer = NumberNull10(dt.Rows[0][ei.LungFvcPer].ToString());
            item.LungFvcPredic = NumberNull10(dt.Rows[0][ei.LungFvcPredic].ToString());
            item.LungNo = NumberNull10(dt.Rows[0][ei.LungNo].ToString());
            item.LungPerFev1 = NumberNull10(dt.Rows[0][ei.LungPerFev1].ToString());
            item.LungRow = NumberNull10(dt.Rows[0][ei.LungRow].ToString());
            item.LungSummary = NumberNull10(dt.Rows[0][ei.LungSummary].ToString());

            item.Audiogram1000L = NumberNull10(dt.Rows[0][ei.Audiogram1000L].ToString());
            item.Audiogram1000R = NumberNull10(dt.Rows[0][ei.Audiogram1000R].ToString());
            item.Audiogram2000L = NumberNull10(dt.Rows[0][ei.Audiogram2000L].ToString());
            item.Audiogram2000R = NumberNull10(dt.Rows[0][ei.Audiogram2000R].ToString());
            item.Audiogram3000L = NumberNull10(dt.Rows[0][ei.Audiogram3000L].ToString());
            item.Audiogram3000R = NumberNull10(dt.Rows[0][ei.Audiogram3000R].ToString());
            item.Audiogram4000L = NumberNull10(dt.Rows[0][ei.Audiogram4000L].ToString());
            item.Audiogram4000R = NumberNull10(dt.Rows[0][ei.Audiogram4000R].ToString());
            item.Audiogram500L = NumberNull10(dt.Rows[0][ei.Audiogram500L].ToString());
            item.Audiogram500R = NumberNull10(dt.Rows[0][ei.Audiogram500R].ToString());
            item.Audiogram6000L = NumberNull10(dt.Rows[0][ei.Audiogram6000L].ToString());
            item.Audiogram6000R = NumberNull10(dt.Rows[0][ei.Audiogram6000R].ToString());
            item.Audiogram8000L = NumberNull10(dt.Rows[0][ei.Audiogram8000L].ToString());
            item.Audiogram8000R = NumberNull10(dt.Rows[0][ei.Audiogram8000R].ToString());
            item.AudiogramExam = NumberNull10(dt.Rows[0][ei.AudiogramExam].ToString());
            item.AudiogramSummaryL = NumberNull10(dt.Rows[0][ei.AudiogramSummaryL].ToString());
            item.AudiogramSummaryR = NumberNull10(dt.Rows[0][ei.AudiogramSummaryR].ToString());
            item.AudiogramNo = NumberNull10(dt.Rows[0][ei.AudiogramNo].ToString());
            item.AudiogramRow = NumberNull10(dt.Rows[0][ei.AudiogramRow].ToString());

            item.EyeNo = NumberNull10(dt.Rows[0][ei.EyeNo].ToString());
            item.EyeRow = NumberNull10(dt.Rows[0][ei.EyeRow].ToString());
            item.EyeShortLongLeft = NumberNull10(dt.Rows[0][ei.EyeShortLongLeft].ToString());
            item.EyeShortLongRight = NumberNull10(dt.Rows[0][ei.EyeShortLongRight].ToString());
            item.EyeExam = NumberNull10(dt.Rows[0][ei.EyeExam].ToString());
            item.EyeDegreeLeft = NumberNull10(dt.Rows[0][ei.EyeDegreeLeft].ToString());
            item.EyeDegreeRight = NumberNull10(dt.Rows[0][ei.EyeDegreeRight].ToString());
            item.EyeSquintLeft = NumberNull10(dt.Rows[0][ei.EyeSquintLeft].ToString());
            item.EyeSquintRight = NumberNull10(dt.Rows[0][ei.EyeSquintRight].ToString());
            item.EyeOldLeft = NumberNull10(dt.Rows[0][ei.EyeOldLeft].ToString());
            item.EyeOldRight = NumberNull10(dt.Rows[0][ei.EyeOldRight].ToString());
            item.EyeSummary = NumberNull10(dt.Rows[0][ei.EyeSummary].ToString());
            item.EyeResult = NumberNull10(dt.Rows[0][ei.EyeResult].ToString());
            item.EyeBlindness = NumberNull10(dt.Rows[0][ei.EyeBlindness].ToString());

            item.StoolExamAppearance = NumberNull10(dt.Rows[0][ei.StoolExamAppearance].ToString());
            item.StoolExamColor = NumberNull10(dt.Rows[0][ei.StoolExamColor].ToString());
            item.StoolExamNo = NumberNull10(dt.Rows[0][ei.StoolExamNo].ToString());
            item.StoolExamParasite = NumberNull10(dt.Rows[0][ei.StoolExamParasite].ToString());
            item.StoolExamRbc = NumberNull10(dt.Rows[0][ei.StoolExamRbc].ToString());
            item.StoolExamRow = NumberNull10(dt.Rows[0][ei.StoolExamRow].ToString());
            item.StoolExamSummary = NumberNull10(dt.Rows[0][ei.StoolExamSummary].ToString());
            item.StoolExamWbc = NumberNull10(dt.Rows[0][ei.StoolExamWbc].ToString());

            item.ToxiLead = NumberNull10(dt.Rows[0][ei.ToxiLead].ToString());
            item.ToxiAluminium = NumberNull10(dt.Rows[0][ei.ToxiAluminium].ToString());
            item.ToxiCadmium = NumberNull10(dt.Rows[0][ei.ToxiCadmium].ToString());
            item.ToxiMercury = NumberNull10(dt.Rows[0][ei.ToxiMercury].ToString());
            item.ToxiTin = NumberNull10(dt.Rows[0][ei.ToxiTin].ToString());
            item.ToxiCopper = NumberNull10(dt.Rows[0][ei.ToxiCopper].ToString());
            item.ToxiManganese = NumberNull10(dt.Rows[0][ei.ToxiManganese].ToString());
            item.ToxiZinc = NumberNull10(dt.Rows[0][ei.ToxiZinc].ToString());
            item.ToxiAmmonia = NumberNull10(dt.Rows[0][ei.ToxiAmmonia].ToString());

            item.ToxiHippuric = NumberNull10(dt.Rows[0][ei.ToxiHippuric].ToString());
            item.ToxiMethyl = NumberNull10(dt.Rows[0][ei.ToxiMethyl].ToString());
            item.ToxiAcetone = NumberNull10(dt.Rows[0][ei.ToxiAcetone].ToString());
            item.ToxiNickel = NumberNull10(dt.Rows[0][ei.ToxiNickel].ToString());
            item.ToxiChromium = NumberNull10(dt.Rows[0][ei.ToxiChromium].ToString());
            item.ToxiPhenol = NumberNull10(dt.Rows[0][ei.ToxiPhenol].ToString());
            item.ToxiKetone = NumberNull10(dt.Rows[0][ei.ToxiKetone].ToString());
            item.ToxiBenzene = NumberNull10(dt.Rows[0][ei.ToxiBenzene].ToString());
            item.ToxiMandelic = NumberNull10(dt.Rows[0][ei.ToxiMandelic].ToString());

            item.ToxiMethanol = NumberNull10(dt.Rows[0][ei.ToxiMethanol].ToString());
            item.ToxiEthanol = NumberNull10(dt.Rows[0][ei.ToxiEthanol].ToString());
            item.ToxiIPA = NumberNull10(dt.Rows[0][ei.ToxiIPA].ToString());
            item.ToxiArsenic = NumberNull10(dt.Rows[0][ei.ToxiArsenic].ToString());
            item.ToxiHexane = NumberNull10(dt.Rows[0][ei.ToxiHexane].ToString());
            item.ToxiFomaldehyde = NumberNull10(dt.Rows[0][ei.ToxiFomaldehyde].ToString());
            item.ToxiTrichloroethylene = NumberNull10(dt.Rows[0][ei.ToxiTrichloroethylene].ToString());
            item.ToxiAntimony = NumberNull10(dt.Rows[0][ei.ToxiAntimony].ToString());
            item.ToxiFluoride = NumberNull10(dt.Rows[0][ei.ToxiFluoride].ToString());

            item.ToxiRow = NumberNull10(dt.Rows[0][ei.ToxiRow].ToString());
            item.ToxiNo = NumberNull10(dt.Rows[0][ei.ToxiNo].ToString());

            item.Active = dt.Rows[0][ei.Active].ToString();

            //foreach (PropertyInfo item1 in item.get)
            //{

            //}

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ei.table + " Where " + ei.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public ExcelInit selectByPk()
        {
            ExcelInit item = new ExcelInit();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ei.table + " Where " + ei.pkField + "='10000'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String updateBun(String bunRow, String bunNo,String bunValue, String bunCreatinine, String bunResult,  String bunSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + ei.table + " Set " + ei.Bun + "='" + bunValue + "', " +
                ei.BunCreatinine + "='" + bunCreatinine + "', " +
                ei.BunNo + "='" + bunNo + "', " +
                ei.BunResult + "='" + bunResult + "', " +
                ei.BunRow + "='" + bunRow + "', " +
                ei.BunSummary + "='" + bunSummary + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateBun");
            }
            finally
            {
            }
            return chk;
        }
        public String updateCBC(String CBCBact, String CBCEos, String CBCHb, String CBCHct, String CBCLy, String CBCMono,
            String CBCNeu, String CBCNo, String CBCPltC, String CBCPltS, String CBCRBC, String CBCRBCmono, String CBCRow, String CBCSummary, String CBCWBC, String Pmn)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.CBCBact + "='" + CBCBact + "', " +
                ei.CBCEos + "='" + CBCEos + "', " +
                ei.CBCHb + "='" + CBCHb + "', " +
                ei.CBCHct + "='" + CBCHct + "', " +
                ei.CBCLy + "='" + CBCLy + "', " +
                ei.CBCMono + "='" + CBCMono + "', " +
                ei.CBCNeu + "='" + CBCNeu + "', " +
                ei.CBCNo + "='" + CBCNo + "', " +
                ei.CBCPltC + "='" + CBCPltC + "', " +
                ei.CBCPltS + "='" + CBCPltS + "', " +
                ei.CBCRBC + "='" + CBCRBC + "', " +
                ei.CBCRBCmono + "='" + CBCRBCmono + "', " +
                ei.CBCRow + "='" + CBCRow + "', " +
                ei.CBCSummary + "='" + CBCSummary + "', " +
                ei.CBCWBC + "='" + CBCWBC + "', "+
                ei.cbcPmn + "='" + Pmn + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateCBC");
            }
            finally
            {
            }
            return chk;
        }
        public String updateCholes(String ChoRow, String ChoNo,String Cholesteral, String ChoResult,  String Chosummary, String ChoLDL, String ChoHDL)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.Cholesteral + "='" + Cholesteral + "', " +
                ei.ChoNo + "='" + ChoNo + "', " +
                ei.ChoResult + "='" + ChoResult + "', " +
                ei.ChoRow + "='" + ChoRow + "', " +
                ei.Chosummary + "='" + Chosummary + "', "+
                ei.ChoHDL + "='" + ChoLDL + "', " +
                ei.ChoLDL + "='" + ChoHDL + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateCholes");
            }
            finally
            {
            }
            return chk;
        }
        public String updateFBS(String FBS, String FBSNo, String FBSResult, String FBSRow, String FBSSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + ei.table + " Set " + ei.FBS + "='" + FBS + "', " +
                ei.FBSNo + "='" + FBSNo + "', " +
                ei.FBSResult + "='" + FBSResult + "', " +
                ei.FBSRow + "='" + FBSRow + "', " +
                ei.FBSSummary + "='" + FBSSummary + "' " ;
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateFBS");
            }
            finally
            {
            }
            return chk;
        }
        public String updatePE( String PENo, String PERow, String PEAge, String PEBMI, String PEHeight, String PEWeight,  String PEPulse, 
            String PEVitalSign, String PEResult, String PESummary, String PEBloodGroup)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.PEAge + "='" + PEAge + "', " +
                ei.PEBMI + "='" + PEBMI + "', " +
                ei.PEHeight + "='" + PEHeight + "', " +
                ei.PENo + "='" + PENo + "', " +
                ei.PEPulse + "='" + PEPulse + "', " +
                ei.PEResult + "='" + PEResult + "', " +
                ei.PERow + "='" + PERow + "', " +
                ei.PESummary + "='" + PESummary + "', " +
                ei.PEVitalSign + "='" + PEVitalSign + "', " +
                ei.PEWeight + "='" + PEWeight + "', " +
                ei.PEBloodGroup + "='" + PEBloodGroup + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updatePE");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSf(String id, String SfAAge, String SfAFirstName, String SfALastName, String SfANo, String SfAPrefix, String SfBAge,
            String SfBFullName, String SfBNo, String SfBPrefix, String SfCAge, String SfCFullName, String SfCNo, String SfRow, String SfStatusName)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.SfAAge + "='" + SfAAge + "', " +
                ei.SfAFirstName + "='" + SfAFirstName + "', " +
                ei.SfALastName + "='" + SfALastName + "', " +
                ei.SfANo + "='" + SfANo + "', " +
                ei.SfAPrefix + "='" + SfAPrefix + "', " +
                ei.SfBAge + "='" + SfBAge + "', " +
                ei.SfBNo + "='" + SfBNo + "', " +
                ei.SfBFullName + "='" + SfBFullName + "', " +
                ei.SfBPrefix + "='" + SfBPrefix + "', " +
                ei.SfCAge + "='" + SfCAge + "', " +
                ei.SfCFullName + "='" + SfCFullName + "', " +
                ei.SfCNo + "='" + SfCNo + "', " +
                ei.SfRow + "='" + SfRow + "', " +
                ei.SfStatusName + "='" + SfStatusName + "' " +                

                "Where " + ei.pkField + "='" + id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateSf");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSfA(String SfAAge, String SfAPrefix, String SfAFirstName, String SfALastName, String SfANo, String SfRow, String department)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.SfAAge + "='" + SfAAge + "', " +
                ei.SfAFirstName + "='" + SfAFirstName + "', " +
                ei.SfALastName + "='" + SfALastName + "', " +
                ei.SfANo + "='" + SfANo + "', " +
                ei.SfAPrefix + "='" + SfAPrefix + "', " +
                ei.DepartmentName + "='" + department + "', " +
                //ei.SfBNo + "='" + SfBNo + "', " +
                //ei.SfBFullName + "='" + SfBFullName + "', " +
                //ei.SfBPrefix + "='" + SfBPrefix + "', " +
                //ei.SfCAge + "='" + SfCAge + "', " +
                //ei.SfCFullName + "='" + SfCFullName + "', " +
                //ei.SfCNo + "='" + SfCNo + "', " +
                ei.SfRow + "='" + SfRow + "', " +
                ei.SfStatusName + "='A' ";

                //"Where " + ei.pkField + "='" + id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateSfA");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSfB(String SfBAge, String SfBPrefix, String SfBFullName, String SfBNo, String SfRow, String department)
        {
            String sql = "", chk = "";
            
            sql = "Update " + ei.table + " Set " + ei.SfBAge + "='" + SfBAge + "', " +
                ei.SfBFullName + "='" + SfBFullName + "', " +
                ei.SfBNo + "='" + SfBNo + "', " +
                ei.SfBPrefix + "='" + SfBPrefix + "', " +
                ei.SfRow + "='" + SfRow + "', " +
                ei.DepartmentName + "='" + department + "', " +
                ei.SfStatusName + "='B' ";

            //"Where " + ei.pkField + "='" + id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateSfB");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSfC(String SfCAge, String SfCAllName, String SfCNo, String SfRow, String department)
        {
            String sql = "", chk = "";
            
            sql = "Update " + ei.table + " Set " + ei.SfCAge + "='" + SfCAge + "', " +
                ei.SfCFullName + "='" + SfCAllName + "', " +
                ei.SfCNo + "='" + SfCNo + "', " +
                ei.DepartmentName + "='" + department + "', " +
                ei.SfRow + "='" + SfRow + "', " +
                ei.SfStatusName + "='C' ";

            //"Where " + ei.pkField + "='" + id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateSfC");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSgot(String Sgot, String SgotNo, String SgotResult, String SgotRow, String Sgpt, String SgptSummary)
        {
            String sql = "", chk = "";
            sql = "Update " + ei.table + " Set " + ei.Sgot + "='" + Sgot + "', " +
                ei.SgotNo + "='" + SgotNo + "', " +
                ei.SgotResult + "='" + SgotResult + "', " +
                ei.SgotRow + "='" + SgotRow + "', " +
                ei.Sgpt + "='" + Sgpt + "', " +
                ei.SgptSummary + "='" + SgptSummary + "' " ;
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateSgot");
            }
            finally
            {
            }
            return chk;
        }
        public String updateTrig(String Triglyceride, String TriNo, String TriResult, String TriRow, String TriSummary)
        {
            String sql = "", chk = "";            

            sql = "Update " + ei.table + " Set " + ei.Triglyceride + "='" + Triglyceride + "', " +
                ei.TriNo + "='" + TriNo + "', " +
                ei.TriResult + "='" + TriResult + "', " +
                ei.TriRow + "='" + TriRow + "', " +
                ei.TriSummary + "='" + TriSummary + "' " ;
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateTrig");
            }
            finally
            {
            }
            return chk;
        }
        public String updateUA(String UAAppe, String UABact, String UAColor, String UAEpi, String UANo, String UApH,
            String UAProtein, String UARBC, String UAResult, String UARow, String UASpgr, String UASugar, String UASummary, String UAWBC)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.UAAppe + "='" + UAAppe + "', " +
                ei.UABact + "='" + UABact + "', " +
                ei.UAColor + "='" + UAColor + "', " +
                ei.UAEpi + "='" + UAEpi + "', " +
                ei.UANo + "='" + UANo + "', " +
                ei.UApH + "='" + UApH + "', " +
                ei.UAProtein + "='" + UAProtein + "', " +
                ei.UARBC + "='" + UARBC + "', " +
                ei.UAResult + "='" + UAResult + "', " +
                ei.UARow + "='" + UARow + "', " +
                ei.UASpgr + "='" + UASpgr + "', " +
                ei.UASugar + "='" + UASugar + "', " +
                ei.UASummary + "='" + UASummary + "', " +
                ei.UAWBC + "='" + UAWBC + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateUA");
            }
            finally
            {
            }
            return chk;
        }
        public String updateUric(String UricRow, String UricNo,String UricAcid, String UricResult,  String UricSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.UricAcid + "='" + UricAcid + "', " +
                ei.UricNo + "='" + UricNo + "', " +
                ei.UricResult + "='" + UricResult + "', " +
                ei.UricRow + "='" + UricRow + "', " +
                ei.UricSummary + "='" + UricSummary + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateUric");
            }
            finally
            {
            }
            return chk;
        }
        public String updateXray(String Xray, String XrayNo, String XrayRow, String XraySummary)
        {
            String sql = "", chk = "";
            sql = "Update " + ei.table + " Set " + ei.Xray + "='" + Xray + "', " +
                ei.XrayNo + "='" + XrayNo + "', " +
                ei.XrayRow + "='" + XrayRow + "', " +
                ei.XraySummary + "='" + XraySummary + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateXray");
            }
            finally
            {
            }
            return chk;
        }
        public String updateOther1(String Amphetamine, String AntiHIV, String Calcium, String HBsAb, String HBsAg, String No, String Row, String VDRL)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.Other1Amphetamine + "='" + Amphetamine + "', " +
                ei.Other1AntiHIV + "='" + AntiHIV + "', " +
                ei.Other1Calcium + "='" + Calcium + "', " +
                ei.Other1HBsAb + "='" + HBsAb + "', " +
                ei.Other1HBsAg + "='" + HBsAg + "', " +
                ei.Other1No + "='" + No + "', " +
                ei.Other1Row + "='" + Row + "', " +
                ei.Other1VDRL + "='" + VDRL + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateOther1");
            }
            finally
            {
            }
            return chk;
        }
        public String updateLung(String LungRow, String LungNo, String LungFvcPredic, String LungFvcMeas, String LungFvcPer, String LungFev1Predic, String LungFev1Meas, 
            String LungFev1Per, String LungPerFev1, String LungSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.LungRow + "='" + LungRow + "', " +
                ei.LungNo + "='" + LungNo + "', " +
                ei.LungFvcPredic + "='" + LungFvcPredic + "', " +
                ei.LungFvcMeas + "='" + LungFvcMeas + "', " +
                ei.LungFvcPer + "='" + LungFvcPer + "', " +
                ei.LungFev1Predic + "='" + LungFev1Predic + "', " +
                ei.LungFev1Meas + "='" + LungFev1Meas + "', " +
                ei.LungFev1Per + "='" + LungFev1Per + "', " +
                ei.LungPerFev1 + "='" + LungPerFev1 + "', " +
                ei.LungSummary + "='" + LungSummary + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateLung");
            }
            finally
            {
            }
            return chk;
        }
        public String updateAudioGram(String AudiogramRow, String AudiogramNo, String Audiogram500L, String Audiogram500R, String Audiogram1000L, String Audiogram1000R, String Audiogram2000L, String Audiogram2000R,
            String Audiogram3000L, String Audiogram3000R, String Audiogram4000L, String Audiogram4000R, String Audiogram6000L, String Audiogram6000R, String Audiogram8000L, String Audiogram8000R,
            String AudiogramSummaryL, String AudiogramSummaryR, String AudiogramExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.AudiogramRow + "='" + AudiogramRow + "', " +
                ei.AudiogramNo + "='" + AudiogramNo + "', " +
                ei.Audiogram500L + "='" + Audiogram500L + "', " +
                ei.Audiogram500R + "='" + Audiogram500R + "', " +
                ei.Audiogram1000L + "='" + Audiogram1000L + "', " +
                ei.Audiogram1000R + "='" + Audiogram1000R + "', " +
                ei.Audiogram2000L + "='" + Audiogram2000L + "', " +
                ei.Audiogram2000R + "='" + Audiogram2000R + "', " +
                ei.Audiogram3000L + "='" + Audiogram3000L + "', " +
                ei.Audiogram3000R + "='" + Audiogram3000R + "', " +
                ei.Audiogram4000L + "='" + Audiogram4000L + "', " +
                ei.Audiogram4000R + "='" + Audiogram4000R + "', " +
                ei.Audiogram6000L + "='" + Audiogram6000L + "', " +
                ei.Audiogram6000R + "='" + Audiogram6000R + "', " +
                ei.Audiogram8000L + "='" + Audiogram8000L + "', " +
                ei.Audiogram8000R + "='" + Audiogram8000R + "', " +
                ei.AudiogramSummaryL + "='" + AudiogramSummaryL + "', " +
                ei.AudiogramSummaryR + "='" + AudiogramSummaryR + "', " +
                ei.AudiogramExam + "='" + AudiogramExam + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateAudioGram");
            }
            finally
            {
            }
            return chk;
        }
        public String updateEye(String EyeRow, String EyeNo, String EyeShortLongLeft, String EyeShortLongRight, String EyeSquintLeft, String EyeSquintRight,
            String EyedegreeLeft, String EyeDegreeRight, String EyeOldLeft, String EyeOldRight, String EyeResult, String EyeSummary, String EyeBlindness, String EyeExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.EyeRow + "='" + EyeRow + "', " +
                ei.EyeNo + "='" + EyeNo + "', " +
                ei.EyeShortLongLeft + "='" + EyeShortLongLeft + "', " +
                ei.EyeShortLongRight + "='" + EyeShortLongRight + "', " +
                ei.EyeSquintLeft + "='" + EyeSquintLeft + "', " +
                ei.EyeSquintRight + "='" + EyeSquintRight + "', " +
                ei.EyeDegreeLeft + "='" + EyedegreeLeft + "', " +
                ei.EyeDegreeRight + "='" + EyeDegreeRight + "', " +
                ei.EyeOldLeft + "='" + EyeOldLeft + "', " +
                ei.EyeOldRight + "='" + EyeOldRight + "', " +
                ei.EyeResult + "='" + EyeResult + "', " +
                ei.EyeSummary + "='" + EyeSummary + "', " +
                ei.EyeExam + "='" + EyeExam + "', " +
                ei.EyeBlindness + "='" + EyeBlindness + "' " ;
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateEye");
            }
            finally
            {
            }
            return chk;
        }
        public String updateStoolExam(String StoolExamRow, String StoolExamNo, String StoolExamAppearance, String StoolExamColor, String StoolExamWbc, String StoolExamRbc, String StoolExamParasite, String StoolExamSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + ei.table + " Set " + ei.StoolExamRow + "='" + StoolExamRow + "', " +
                ei.StoolExamNo + "='" + StoolExamNo + "', " +
                ei.StoolExamAppearance + "='" + StoolExamAppearance + "', " +
                ei.StoolExamColor + "='" + StoolExamColor + "', " +
                ei.StoolExamWbc + "='" + StoolExamWbc + "', " +
                ei.StoolExamRbc + "='" + StoolExamRbc + "', " +
                ei.StoolExamParasite + "='" + StoolExamParasite + "', " +
                ei.StoolExamSummary + "='" + StoolExamSummary + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateStoolExam");
            }
            finally
            {
            }
            return chk;
        }
        public String updateToxi1(String ToxiRow, String ToxiNo, String ToxiLead, String ToxiAluminium, String ToxiCadmium, String ToxiMercury, String ToxiTin, String ToxiCopper,
            String ToxiManganese, String ToxiZinc, String ToxiAmmonia)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.ToxiRow + "='" + ToxiRow + "', " +
                ei.ToxiNo + "='" + ToxiNo + "', " +
                ei.ToxiLead + "='" + ToxiLead + "', " +
                ei.ToxiAluminium + "='" + ToxiAluminium + "', " +
                ei.ToxiCadmium + "='" + ToxiCadmium + "', " +
                ei.ToxiMercury + "='" + ToxiMercury + "', " +
                ei.ToxiTin + "='" + ToxiTin + "', " +
                ei.ToxiCopper + "='" + ToxiCopper + "', " +
                ei.ToxiManganese + "='" + ToxiManganese + "', " +
                ei.ToxiZinc + "='" + ToxiZinc + "', " +
                ei.ToxiAmmonia + "='" + ToxiAmmonia + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateToxi1");
            }
            finally
            {
            }
            return chk;
        }
        public String updateToxi2(String ToxiHippuric, String ToxiMethyl, String ToxiAcetone, String ToxiNickel, String ToxiChromium,
            String ToxiPhenol, String ToxiKetone, String ToxiBenzene, String ToxiMandelic, String ToxiMethanol, String ToxiEthanol, String ToxiIPA,
            String ToxiArsenic, String ToxiHexane, String ToxiFomaldehyde, String ToxiTrichloroethylene, String ToxiAntimony, String ToxiFluoride)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.ToxiHippuric + "='" + ToxiHippuric + "', " +
                ei.ToxiMethyl + "='" + ToxiMethyl + "', " +
                ei.ToxiAcetone + "='" + ToxiAcetone + "', " +
                ei.ToxiNickel + "='" + ToxiNickel + "', " +
                ei.ToxiChromium + "='" + ToxiChromium + "', " +
                ei.ToxiPhenol + "='" + ToxiPhenol + "', " +
                ei.ToxiKetone + "='" + ToxiKetone + "', " +
                ei.ToxiBenzene + "='" + ToxiBenzene + "', " +
                ei.ToxiMandelic + "='" + ToxiMandelic + "', " +
                ei.ToxiMethanol + "='" + ToxiMethanol + "', " +
                ei.ToxiEthanol + "='" + ToxiEthanol + "', " +
                ei.ToxiIPA + "='" + ToxiIPA + "', " +
                ei.ToxiArsenic + "='" + ToxiArsenic + "', " +
                ei.ToxiHexane + "='" + ToxiHexane + "', " +
                ei.ToxiFomaldehyde + "='" + ToxiFomaldehyde + "', " +
                ei.ToxiTrichloroethylene + "='" + ToxiTrichloroethylene + "', " +
                ei.ToxiAntimony + "='" + ToxiAntimony + "', " +
                ei.ToxiFluoride + "='" + ToxiFluoride + "' ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateToxi2");
            }
            finally
            {
            }
            return chk;
        }
        public String NumberNull10(String o)
        {
            if (o.Equals(""))
            {
                return "10";
            }
            else
            {
                return o;
            }
        }
    }
}
