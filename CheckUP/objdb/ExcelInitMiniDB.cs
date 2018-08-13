using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class ExcelInitMiniDB
    {
        ConnectDB conn;
        public ExcelInitMini eimini;
        public ExcelInitMiniDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            eimini = new ExcelInitMini();
            eimini.Id = "id";

            eimini.DepartmentName = "department_name";

            eimini.Bun = "bun_value";
            eimini.BunCreatinine = "bun_creatinine";
            eimini.BunNo = "bun_no";
            eimini.BunResult = "bun_result";
            eimini.BunRow = "bun_row";
            eimini.BunSummary = "bun_summary";
            eimini.BunSheetname = "bun_sheetname";

            eimini.CBCBact = "cbc_bact";
            eimini.CBCEos = "cbc_eos";
            eimini.CBCHb = "cbc_hb";
            eimini.CBCHct = "cbc_hct";
            eimini.CBCLy = "cbc_ly";
            eimini.CBCMono = "cbc_mono";
            eimini.CBCNeu = "cbc_neu";
            eimini.CBCNo = "cbc_no";
            eimini.CBCPltC = "cbc_plt_c";
            eimini.CBCPltS = "cbc_plt_s";
            eimini.CBCRBC = "cbc_rbc";
            eimini.CBCRBCmono = "cbc_rbc_mono";
            eimini.CBCRow = "cbc_row";
            eimini.CBCSummary = "cbc_summary";
            eimini.CBCWBC = "cbc_wbc";
            eimini.cbcPmn = "cbc_pmn";
            eimini.CBCSheetname = "cbc_sheetname";
            eimini.CBCMCH = "cbc_mch";
            eimini.CBCMCHC = "cbc_mchc";
            eimini.CBCMCV = "cbc_mcv";
            eimini.CBCBASO = "cbc_baso";
            eimini.CBCResult = "cbc_result";

            eimini.Cholesteral = "cho_value";
            eimini.ChoNo = "cho_no";
            eimini.ChoResult = "cho_result";
            eimini.ChoRow = "cho_row";
            eimini.Chosummary = "cho_summary";
            eimini.ChoHDL = "hdl";
            eimini.ChoLDL = "ldl";
            eimini.ChoSheetname = "cho_sheetname";
            eimini.ChoLDLResult = "ldl_result";
            eimini.ChoLDLsummary = "ldl_summary";
            eimini.ChoHDLResult = "hdl_result";
            eimini.ChoHDLsummary = "hdl_summary";

            eimini.FBS = "fbs_value";
            eimini.FBSNo = "fbs_no";
            eimini.FBSResult = "fbs_result";
            eimini.FBSRow = "fbs_row";
            eimini.FBSSummary = "fbs_summary";
            eimini.FBSSheetname = "fbs_sheetname";

            eimini.PEAge = "pe_age";
            eimini.PEBMI = "pe_bmi";
            eimini.PEHeight = "pe_height";
            eimini.PENo = "pe_no";
            eimini.PEPulse = "pe_pulse";
            eimini.PEResult = "pe_result";
            eimini.PERow = "pe_row";
            eimini.PESummary = "pe_summary";
            eimini.PEVitalSign = "pe_vitalsign";
            eimini.PEWeight = "pe_weight";
            eimini.PEBloodGroup = "pe_bloodgroup";
            eimini.PESheetname = "pe_sheetname";

            eimini.SfAAge = "sf_a_age";
            eimini.SfAFirstName = "sf_a_first_name";
            eimini.SfALastName = "sf_a_last_name";
            eimini.SfANo = "sf_a_no";
            eimini.SfAPrefix = "sf_a_prefix";
            eimini.SfBAge = "sf_b_age";
            eimini.SfBFullName = "sf_b_fullname";
            eimini.SfBNo = "sf_b_no";
            eimini.SfBPrefix = "sf_b_prefix";
            eimini.SfCAge = "sf_c_age";
            eimini.SfCFullName = "sf_c_fullname";
            eimini.SfCNo = "sf_c_no";
            eimini.SfRow = "sf_row";
            eimini.SfStatusName = "sf_status_name";

            eimini.Sgot = "sgot_value";
            eimini.SgotNo = "sgot_no";
            eimini.SgotResult = "sgot_result";
            eimini.SgotRow = "sgot_row";
            eimini.Sgpt = "sgot_sgpt_value";
            eimini.SgptSummary = "sgot_summary";
            eimini.SgotALP = "sgot_alt_vaule";
            eimini.SgotSheetname = "sgot_sheetname";
            eimini.SgotAlkaline = "sgot_alkaline_value";

            eimini.Triglyceride = "tri_value";
            eimini.TriNo = "tri_no";
            eimini.TriResult = "tri_result";
            eimini.TriRow = "tri_row";
            eimini.TriSummary = "tri_summary";
            eimini.TriSheetname = "tri_sheetname";

            eimini.UAAppe = "ua_appe";
            eimini.UABact = "ua_bact";
            eimini.UAColor = "ua_color";
            eimini.UAEpi = "ua_epi";
            eimini.UANo = "ua_no";
            eimini.UApH = "ua_ph";
            eimini.UAProtein = "ua_protein";
            eimini.UARBC = "ua_rbc";
            eimini.UAResult = "ua_result";
            eimini.UARow = "ua_row";
            eimini.UASpgr = "ua_spgr";
            eimini.UASugar = "ua_sugar";
            eimini.UASummary = "ua_summary";
            eimini.UAWBC = "ua_wbc";
            eimini.UAGlu = "ua_glu";
            eimini.UABlood = "ua_blood";
            eimini.UAKetone = "ua_ketone";
            eimini.UASheetname = "ua_sheetname";
            eimini.UALeu = "ua_leu";
            eimini.UANit = "ua_nit";
            eimini.UAUro = "ua_uro";
            eimini.UABil = "ua_bili";

            eimini.UricAcid = "uric_acid_value";
            //ei.UricAcidFeMale = "uric_acid_female_value";

            eimini.UricNo = "uric_no";
            eimini.UricResult = "uric_result";
            eimini.UricRow = "uric_row";
            eimini.UricSummary = "uric_summary";
            eimini.UricSheetname = "uric_sheetname";

            eimini.Xray = "xray_value";
            eimini.XrayNo = "xray_no";
            eimini.XrayRow = "xray_row";
            eimini.XraySummary = "xray_summary";
            eimini.Active = "active";
            eimini.XraySheetname = "xray_sheetname";

            eimini.Other1Amphetamine = "other1_amphetamine";
            eimini.Other1AntiHIV = "other1_antihiv";
            eimini.Other1Calcium = "other1_calcium";
            eimini.Other1HBsAb = "other1_hbsab";
            eimini.Other1HBsAg = "other1_hbsag";
            eimini.Other1No = "other1_no";
            eimini.Other1Row = "other1_row";
            eimini.Other1VDRL = "other1_vdrl";
            eimini.Other1Sheetname = "other1_sheetname";
            eimini.Other1AntiHav = "other1_antihav";
            eimini.Other1AntiHavSummary = "other1_antihav_summary";

            eimini.Other1HBsAbResult = "other1_hbsab_result";
            eimini.Other1HBsAgResult = "other1_hbsag_result";
            eimini.Other1HBsAbSummary = "other1_hbsab_summary";
            eimini.Other1HBsAgSummary = "other1_hbsag_summary";

            eimini.AmphetamineSummary = "other1_amphetamine_summary";

            eimini.LungFev1Meas = "lung_fev1_meas";
            eimini.LungFev1Per = "lung_fev1_per";
            eimini.LungFev1Predic = "lung_fev1_predic";
            eimini.LungFvcMeas = "lung_fvc_meas";
            eimini.LungFvcPer = "lung_fvc_per";
            eimini.LungFvcPredic = "lung_fvc_predic";
            eimini.LungNo = "lung_no";
            eimini.LungPerFev1 = "lung_per_fev1";
            eimini.LungRow = "lung_row";
            eimini.LungSummary = "lung_summary";
            eimini.LungSheetname = "lung_sheetname";

            eimini.Audiogram1000L = "audiogram_1000_left";
            eimini.Audiogram1000R = "audiogram_1000_right";
            eimini.Audiogram2000L = "audiogram_2000_left";
            eimini.Audiogram2000R = "audiogram_2000_right";
            eimini.Audiogram3000L = "audiogram_3000_left";
            eimini.Audiogram3000R = "audiogram_3000_right";
            eimini.Audiogram4000L = "audiogram_4000_left";
            eimini.Audiogram4000R = "audiogram_4000_rightt";
            eimini.Audiogram500L = "audiogram_500_left";
            eimini.Audiogram500R = "audiogram_500_right";
            eimini.Audiogram6000L = "audiogram_6000_left";
            eimini.Audiogram6000R = "audiogram_6000_right";
            eimini.Audiogram8000L = "audiogram_8000_left";
            eimini.Audiogram8000R = "audiogram_8000_right";
            eimini.AudiogramExam = "audiogram_exam";
            eimini.AudiogramSummaryL = "audiogram_summary_left";
            eimini.AudiogramSummaryR = "audiogram_summary_right";
            eimini.AudiogramNo = "audiogram_no";
            eimini.AudiogramRow = "audiogram_row";
            eimini.AudiogramSheetname = "audiogram_sheetname";

            eimini.EyeNo = "eye_no";
            eimini.EyeRow = "eye_row";
            //ei.EyeShortLongLeft = "eye_short_long_left";
            //ei.EyeShortLongRight = "eye_short_long_right";
            eimini.EyeDegreeLeft = "eye_degree_left";
            eimini.EyeDegreeRight = "eye_degree_right";
            eimini.EyeShortLongLeft = "eye_short_long_left";
            eimini.EyeShortLongRight = "eye_short_long_right";
            eimini.EyeSquintLeft = "eye_squint_left";
            eimini.EyeSquintRight = "eye_squint_short";
            eimini.EyeOldLeft = "eye_old_left";
            eimini.EyeOldRight = "eye_old_right";
            eimini.EyeSummary = "eye_summary";
            eimini.EyeResult = "eye_result";
            eimini.EyeBlindness = "eye_blindness";
            eimini.EyeExam = "eyes_exam";
            eimini.EyeSheetname = "eye_sheetname";


            eimini.StoolExamAppearance = "stool_exam_appearance";
            eimini.StoolExamColor = "stool_exam_color";
            eimini.StoolExamNo = "stool_exam_no";
            eimini.StoolExamParasite = "stool_exam_parasite";
            eimini.StoolExamRbc = "stool_exam_rbc";
            eimini.StoolExamRow = "stool_exam_row";
            eimini.StoolExamSummary = "stool_exam_summary";
            eimini.StoolExamWbc = "stool_exam_wbc";
            eimini.StoolExamCulture = "stool_exam_culture";
            eimini.StoolExamTyphoidH = "stool_exam_typhoidh";
            eimini.StoolExamTyphoidO = "stool_exam_typhoido";
            eimini.StoolExamSheetname = "stool_exam_sheetname";
            eimini.StoolExamCultureSummary = "stool_exam_culture_summary";

            eimini.ToxiAcetone = "toxicology_acetone";
            eimini.ToxiAluminium = "toxicology_aluminium";
            eimini.ToxiAmmonia = "toxicology_ammonia";
            eimini.ToxiAntimony = "toxicology_antimony";
            eimini.ToxiArsenic = "toxicology_arsenic";
            eimini.ToxiBenzene = "toxicology_benzene";
            eimini.ToxiCadmium = "toxicology_cadmium";
            eimini.ToxiChromium = "toxicology_chromium";
            eimini.ToxiCopper = "toxicology_copper";
            eimini.ToxiEthanol = "toxicology_ethanol";
            eimini.ToxiFluoride = "toxicology_fluoride";
            eimini.ToxiFomaldehyde = "toxicology_fomaldehyde";
            eimini.ToxiHexane = "toxicology_hexane";
            eimini.ToxiHippuric = "toxicology_hippuric";
            eimini.ToxiIPA = "toxicology_ipa";
            eimini.ToxiKetone = "toxicology_ketone";
            eimini.ToxiLead = "toxicology_lead";
            eimini.ToxiMandelic = "toxicology_mandelic";
            eimini.ToxiManganese = "toxicology_manganese";
            eimini.ToxiMercury = "toxicology_mercury";
            eimini.ToxiMethanol = "toxicology_methanol";
            eimini.ToxiMethyl = "toxicology_methyl";
            eimini.ToxiNickel = "toxicology_nickel";
            eimini.ToxiPhenol = "toxicology_phenol";
            eimini.ToxiTin = "toxicology_tin";
            eimini.ToxiTrichloroethylene = "toxicology_trichloroethylenel";
            eimini.ToxiZinc = "toxicology_zinc";
            eimini.ToxiRow = "toxicology_row";
            eimini.ToxiNo = "toxicology_no";
            eimini.ToxiSheetname = "toxicology_sheetname";

            eimini.CAAFP = "ca_afp";
            eimini.CAAFPResult = "ca_afp_result";
            eimini.CAAFPSummary = "ca_afp_summary";
            eimini.CACEA = "ca_cea";
            eimini.CACEAResult = "ca_cea_result";
            eimini.CACEASummary = "ca_cea_summary";
            eimini.CAPSA = "ca_psa";
            eimini.CAPSAResult = "ca_psa_result";
            eimini.CAPSASummary = "ca_psa_summary";
            eimini.CAHCG = "ca_hcg";
            eimini.CAHCGResult = "ca_hcg_result";
            eimini.CAHCGSummary = "ca_hcg_summary";
            eimini.CA153 = "ca_153";
            eimini.CA153Result = "ca_153_result";
            eimini.CA153Summary = "ca_153_summary";
            eimini.CA125 = "ca_125";
            eimini.CA125Result = "ca_125_result";
            eimini.CA125Summary = "ca_125_summary";
            eimini.CA199 = "ca_19_9";
            eimini.CA199Result = "ca_19_9_result";
            eimini.CA199Summary = "ca_19_9_summary";
            eimini.patient_number = "patient_number";
            eimini.visit_hn = "visit_hn";
            eimini.position_name = "position_name";
            eimini.sticker01 = "sticker01";
            eimini.sticker02 = "sticker02";
            eimini.sticker03 = "sticker03";
            eimini.sticker04 = "sticker04";
            eimini.sticker05 = "sticker05";
            eimini.sticker06 = "sticker06";
            eimini.sticker07 = "sticker07";
            eimini.sticker08 = "sticker08";
            eimini.sticker09 = "sticker09";
            eimini.sticker10 = "sticker10";
            eimini.sticker11 = "sticker11";
            eimini.sticker12 = "sticker12";
            eimini.sticker13 = "sticker13";
            eimini.sticker14 = "sticker14";
            eimini.sticker15 = "sticker15";
            eimini.sticker16 = "sticker16";
            eimini.sticker17 = "sticker17";
            eimini.sticker18 = "sticker18";
            eimini.sticker19 = "sticker19";
            eimini.sticker20 = "sticker20";
            eimini.ekg = "ekg";
            eimini.ekg_result = "ekg_result";
            eimini.ekg_summary = "ekg_summary";

            eimini.pkField = "id";
            eimini.table = "b_excel_init_mini";
        }
        private ExcelInitMini setData(ExcelInitMini item, DataTable dt)
        {
            item.Id = dt.Rows[0][eimini.Id].ToString();
            item.Bun = NumberNull10(dt.Rows[0][eimini.Bun].ToString());
            item.BunCreatinine = NumberNull10(dt.Rows[0][eimini.BunCreatinine].ToString());
            item.BunNo = NumberNull10(dt.Rows[0][eimini.BunNo].ToString());
            item.BunResult = NumberNull10(dt.Rows[0][eimini.BunResult].ToString());
            item.BunRow = NumberNull10(dt.Rows[0][eimini.BunRow].ToString());
            item.BunSummary = NumberNull10(dt.Rows[0][eimini.BunSummary].ToString());
            item.BunSheetname = NumberNull10(dt.Rows[0][eimini.BunSheetname].ToString());

            item.CBCBact = NumberNull10(dt.Rows[0][eimini.CBCBact].ToString());
            item.CBCEos = NumberNull10(dt.Rows[0][eimini.CBCEos].ToString());
            item.CBCHb = NumberNull10(dt.Rows[0][eimini.CBCHb].ToString());
            item.CBCHct = NumberNull10(dt.Rows[0][eimini.CBCHct].ToString());
            item.CBCLy = NumberNull10(dt.Rows[0][eimini.CBCLy].ToString());
            item.CBCMono = NumberNull10(dt.Rows[0][eimini.CBCMono].ToString());
            item.CBCNeu = NumberNull10(dt.Rows[0][eimini.CBCNeu].ToString());
            item.CBCNo = NumberNull10(dt.Rows[0][eimini.CBCNo].ToString());
            item.CBCPltC = NumberNull10(dt.Rows[0][eimini.CBCPltC].ToString());
            item.CBCPltS = NumberNull10(dt.Rows[0][eimini.CBCPltS].ToString());
            item.CBCRBC = NumberNull10(dt.Rows[0][eimini.CBCRBC].ToString());
            item.CBCRBCmono = NumberNull10(dt.Rows[0][eimini.CBCRBCmono].ToString());
            item.CBCRow = NumberNull10(dt.Rows[0][eimini.CBCRow].ToString());
            item.CBCSummary = NumberNull10(dt.Rows[0][eimini.CBCSummary].ToString());
            item.CBCWBC = NumberNull10(dt.Rows[0][eimini.CBCWBC].ToString());
            item.cbcPmn = NumberNull10(dt.Rows[0][eimini.cbcPmn].ToString());

            item.CBCMCH = NumberNull10(dt.Rows[0][eimini.CBCMCH].ToString());
            item.CBCMCHC = NumberNull10(dt.Rows[0][eimini.CBCMCHC].ToString());
            item.CBCMCV = NumberNull10(dt.Rows[0][eimini.CBCMCV].ToString());
            item.CBCBASO = NumberNull10(dt.Rows[0][eimini.CBCBASO].ToString());
            item.CBCResult = NumberNull10(dt.Rows[0][eimini.CBCResult].ToString());

            item.CBCSheetname = NumberNull10(dt.Rows[0][eimini.CBCSheetname].ToString());

            item.Cholesteral = NumberNull10(dt.Rows[0][eimini.Cholesteral].ToString());
            item.ChoNo = NumberNull10(dt.Rows[0][eimini.ChoNo].ToString());
            item.ChoResult = NumberNull10(dt.Rows[0][eimini.ChoResult].ToString());
            item.ChoRow = NumberNull10(dt.Rows[0][eimini.ChoRow].ToString());
            item.Chosummary = NumberNull10(dt.Rows[0][eimini.Chosummary].ToString());
            item.ChoHDL = NumberNull10(dt.Rows[0][eimini.ChoHDL].ToString());
            item.ChoLDL = NumberNull10(dt.Rows[0][eimini.ChoLDL].ToString());
            item.ChoSheetname = NumberNull10(dt.Rows[0][eimini.ChoSheetname].ToString());
            item.ChoHDLResult = NumberNull10(dt.Rows[0][eimini.ChoHDLResult].ToString());
            item.ChoHDLsummary = NumberNull10(dt.Rows[0][eimini.ChoHDLsummary].ToString());
            item.ChoLDLResult = NumberNull10(dt.Rows[0][eimini.ChoLDLResult].ToString());
            item.ChoLDLsummary = NumberNull10(dt.Rows[0][eimini.ChoLDLsummary].ToString());

            item.FBS = NumberNull10(dt.Rows[0][eimini.FBS].ToString());
            item.FBSNo = NumberNull10(dt.Rows[0][eimini.FBSNo].ToString());
            item.FBSResult = NumberNull10(dt.Rows[0][eimini.FBSResult].ToString());
            item.FBSRow = NumberNull10(dt.Rows[0][eimini.FBSRow].ToString());
            item.FBSSummary = NumberNull10(dt.Rows[0][eimini.FBSSummary].ToString());
            item.FBSSheetname = NumberNull10(dt.Rows[0][eimini.FBSSheetname].ToString());

            item.PEAge = NumberNull10(dt.Rows[0][eimini.PEAge].ToString());
            item.PEBMI = NumberNull10(dt.Rows[0][eimini.PEBMI].ToString());
            item.PEHeight = NumberNull10(dt.Rows[0][eimini.PEHeight].ToString());
            item.PENo = NumberNull10(dt.Rows[0][eimini.PENo].ToString());
            item.PEPulse = NumberNull10(dt.Rows[0][eimini.PEPulse].ToString());
            item.PEResult = NumberNull10(dt.Rows[0][eimini.PEResult].ToString());
            item.PERow = NumberNull10(dt.Rows[0][eimini.PERow].ToString());
            item.PESummary = NumberNull10(dt.Rows[0][eimini.PESummary].ToString());
            item.PEVitalSign = NumberNull10(dt.Rows[0][eimini.PEVitalSign].ToString());
            item.PEWeight = NumberNull10(dt.Rows[0][eimini.PEWeight].ToString());
            item.PEBloodGroup = NumberNull10(dt.Rows[0][eimini.PEBloodGroup].ToString());
            item.PESheetname = NumberNull10(dt.Rows[0][eimini.PESheetname].ToString());

            item.DepartmentName = NumberNull10(dt.Rows[0][eimini.DepartmentName].ToString());

            item.SfAAge = NumberNull10(dt.Rows[0][eimini.SfAAge].ToString());
            item.SfAFirstName = NumberNull10(dt.Rows[0][eimini.SfAFirstName].ToString());
            item.SfALastName = NumberNull10(dt.Rows[0][eimini.SfALastName].ToString());
            item.SfANo = NumberNull10(dt.Rows[0][eimini.SfANo].ToString());
            item.SfAPrefix = NumberNull10(dt.Rows[0][eimini.SfAPrefix].ToString());
            item.SfBAge = NumberNull10(dt.Rows[0][eimini.SfBAge].ToString());
            item.SfBFullName = NumberNull10(dt.Rows[0][eimini.SfBFullName].ToString());
            item.SfBNo = NumberNull10(dt.Rows[0][eimini.SfBNo].ToString());
            item.SfBPrefix = NumberNull10(dt.Rows[0][eimini.SfBPrefix].ToString());
            item.SfCAge = NumberNull10(dt.Rows[0][eimini.SfCAge].ToString());
            item.SfCFullName = NumberNull10(dt.Rows[0][eimini.SfCFullName].ToString());
            item.SfCNo = NumberNull10(dt.Rows[0][eimini.SfCNo].ToString());
            item.SfRow = NumberNull10(dt.Rows[0][eimini.SfRow].ToString());
            item.SfStatusName = NumberNull10(dt.Rows[0][eimini.SfStatusName].ToString());

            item.Sgot = NumberNull10(dt.Rows[0][eimini.Sgot].ToString());
            item.SgotNo = NumberNull10(dt.Rows[0][eimini.SgotNo].ToString());
            item.SgotResult = NumberNull10(dt.Rows[0][eimini.SgotResult].ToString());
            item.SgotRow = NumberNull10(dt.Rows[0][eimini.SgotRow].ToString());
            item.Sgpt = NumberNull10(dt.Rows[0][eimini.Sgpt].ToString());
            item.SgptSummary = NumberNull10(dt.Rows[0][eimini.SgptSummary].ToString());
            item.SgotALP = NumberNull10(dt.Rows[0][eimini.SgotALP].ToString());
            item.SgotSheetname = NumberNull10(dt.Rows[0][eimini.SgotSheetname].ToString());
            item.SgotAlkaline = NumberNull10(dt.Rows[0][eimini.SgotAlkaline].ToString());

            item.Triglyceride = NumberNull10(dt.Rows[0][eimini.Triglyceride].ToString());
            item.TriNo = NumberNull10(dt.Rows[0][eimini.TriNo].ToString());
            item.TriResult = NumberNull10(dt.Rows[0][eimini.TriResult].ToString());
            item.TriRow = NumberNull10(dt.Rows[0][eimini.TriRow].ToString());
            item.TriSummary = NumberNull10(dt.Rows[0][eimini.TriSummary].ToString());
            item.TriSheetname = NumberNull10(dt.Rows[0][eimini.TriSheetname].ToString());

            item.UAAppe = NumberNull10(dt.Rows[0][eimini.UAAppe].ToString());
            item.UABact = NumberNull10(dt.Rows[0][eimini.UABact].ToString());
            item.UAColor = NumberNull10(dt.Rows[0][eimini.UAColor].ToString());
            item.UAEpi = NumberNull10(dt.Rows[0][eimini.UAEpi].ToString());
            item.UANo = NumberNull10(dt.Rows[0][eimini.UANo].ToString());
            item.UApH = NumberNull10(dt.Rows[0][eimini.UApH].ToString());
            item.UAProtein = NumberNull10(dt.Rows[0][eimini.UAProtein].ToString());
            item.UARBC = NumberNull10(dt.Rows[0][eimini.UARBC].ToString());
            item.UAResult = NumberNull10(dt.Rows[0][eimini.UAResult].ToString());
            item.UARow = NumberNull10(dt.Rows[0][eimini.UARow].ToString());
            item.UASpgr = NumberNull10(dt.Rows[0][eimini.UASpgr].ToString());
            item.UASugar = NumberNull10(dt.Rows[0][eimini.UASugar].ToString());
            item.UASummary = NumberNull10(dt.Rows[0][eimini.UASummary].ToString());
            item.UAWBC = NumberNull10(dt.Rows[0][eimini.UAWBC].ToString());
            item.UAGlu = NumberNull10(dt.Rows[0][eimini.UAGlu].ToString());
            item.UAKetone = NumberNull10(dt.Rows[0][eimini.UAKetone].ToString());
            item.UABlood = NumberNull10(dt.Rows[0][eimini.UABlood].ToString());
            item.UASheetname = NumberNull10(dt.Rows[0][eimini.UASheetname].ToString());

            item.UALeu = NumberNull10(dt.Rows[0][eimini.UALeu].ToString());
            item.UANit = NumberNull10(dt.Rows[0][eimini.UANit].ToString());
            item.UAUro = NumberNull10(dt.Rows[0][eimini.UAUro].ToString());
            item.UABil = NumberNull10(dt.Rows[0][eimini.UABil].ToString());

            item.UricAcid = NumberNull10(dt.Rows[0][eimini.UricAcid].ToString());
            //item.UricAcidFeMale = NumberNull10(dt.Rows[0][ei.UricAcidFeMale].ToString());
            item.UricNo = NumberNull10(dt.Rows[0][eimini.UricNo].ToString());
            item.UricResult = NumberNull10(dt.Rows[0][eimini.UricResult].ToString());
            item.UricRow = NumberNull10(dt.Rows[0][eimini.UricRow].ToString());
            item.UricSummary = NumberNull10(dt.Rows[0][eimini.UricSummary].ToString());
            item.UricSheetname = NumberNull10(dt.Rows[0][eimini.UricSheetname].ToString());

            item.Xray = NumberNull10(dt.Rows[0][eimini.Xray].ToString());
            item.XrayNo = NumberNull10(dt.Rows[0][eimini.XrayNo].ToString());
            item.XrayRow = NumberNull10(dt.Rows[0][eimini.XrayRow].ToString());
            item.XraySummary = NumberNull10(dt.Rows[0][eimini.XraySummary].ToString());
            item.XraySheetname = NumberNull10(dt.Rows[0][eimini.XraySheetname].ToString());

            item.Other1Amphetamine = NumberNull10(dt.Rows[0][eimini.Other1Amphetamine].ToString());
            item.Other1AntiHIV = NumberNull10(dt.Rows[0][eimini.Other1AntiHIV].ToString());
            item.Other1AntiHav = NumberNull10(dt.Rows[0][eimini.Other1AntiHav].ToString());
            item.Other1Calcium = NumberNull10(dt.Rows[0][eimini.Other1Calcium].ToString());
            item.Other1HBsAb = NumberNull10(dt.Rows[0][eimini.Other1HBsAb].ToString());
            item.Other1HBsAg = NumberNull10(dt.Rows[0][eimini.Other1HBsAg].ToString());
            item.Other1No = NumberNull10(dt.Rows[0][eimini.Other1No].ToString());
            item.Other1Row = NumberNull10(dt.Rows[0][eimini.Other1Row].ToString());
            item.Other1VDRL = NumberNull10(dt.Rows[0][eimini.Other1VDRL].ToString());
            item.Other1Sheetname = NumberNull10(dt.Rows[0][eimini.Other1Sheetname].ToString());

            item.Other1HBsAbResult = NumberNull10(dt.Rows[0][eimini.Other1HBsAbResult].ToString());
            item.Other1HBsAgResult = NumberNull10(dt.Rows[0][eimini.Other1HBsAgResult].ToString());
            item.Other1HBsAbSummary = NumberNull10(dt.Rows[0][eimini.Other1HBsAbSummary].ToString());
            item.Other1HBsAgSummary = NumberNull10(dt.Rows[0][eimini.Other1HBsAgSummary].ToString());
            item.Other1AntiHavSummary = NumberNull10(dt.Rows[0][eimini.Other1AntiHavSummary].ToString());

            item.AmphetamineSummary = NumberNull10(dt.Rows[0][eimini.AmphetamineSummary].ToString());

            item.CA125 = NumberNull10(dt.Rows[0][eimini.CA125].ToString());
            item.CA125Result = NumberNull10(dt.Rows[0][eimini.CA125Result].ToString());
            item.CA125Summary = NumberNull10(dt.Rows[0][eimini.CA125Summary].ToString());
            item.CA153 = NumberNull10(dt.Rows[0][eimini.CA153].ToString());
            item.CA153Result = NumberNull10(dt.Rows[0][eimini.CA153Result].ToString());
            item.CA153Summary = NumberNull10(dt.Rows[0][eimini.CA153Summary].ToString());
            item.CA199 = NumberNull10(dt.Rows[0][eimini.CA199].ToString());
            item.CA199Result = NumberNull10(dt.Rows[0][eimini.CA199Result].ToString());
            item.CA199Summary = NumberNull10(dt.Rows[0][eimini.CA199Summary].ToString());
            item.CAAFP = NumberNull10(dt.Rows[0][eimini.CAAFP].ToString());
            item.CAAFPResult = NumberNull10(dt.Rows[0][eimini.CAAFPResult].ToString());
            item.CAAFPSummary = NumberNull10(dt.Rows[0][eimini.CAAFPSummary].ToString());
            item.CACEA = NumberNull10(dt.Rows[0][eimini.CACEA].ToString());
            item.CACEAResult = NumberNull10(dt.Rows[0][eimini.CACEAResult].ToString());
            item.CACEASummary = NumberNull10(dt.Rows[0][eimini.CACEASummary].ToString());
            item.CAHCG = NumberNull10(dt.Rows[0][eimini.CAHCG].ToString());
            item.CAHCGResult = NumberNull10(dt.Rows[0][eimini.CAHCGResult].ToString());
            item.CAHCGSummary = NumberNull10(dt.Rows[0][eimini.CAHCGSummary].ToString());
            item.CAPSA = NumberNull10(dt.Rows[0][eimini.CAPSA].ToString());
            item.CAPSAResult = NumberNull10(dt.Rows[0][eimini.CAPSAResult].ToString());
            item.CAPSASummary = NumberNull10(dt.Rows[0][eimini.CAPSASummary].ToString());


            item.LungFev1Meas = NumberNull10(dt.Rows[0][eimini.LungFev1Meas].ToString());
            item.LungFev1Per = NumberNull10(dt.Rows[0][eimini.LungFev1Per].ToString());
            item.LungFev1Predic = NumberNull10(dt.Rows[0][eimini.LungFev1Predic].ToString());
            item.LungFvcMeas = NumberNull10(dt.Rows[0][eimini.LungFvcMeas].ToString());
            item.LungFvcPer = NumberNull10(dt.Rows[0][eimini.LungFvcPer].ToString());
            item.LungFvcPredic = NumberNull10(dt.Rows[0][eimini.LungFvcPredic].ToString());
            item.LungNo = NumberNull10(dt.Rows[0][eimini.LungNo].ToString());
            item.LungPerFev1 = NumberNull10(dt.Rows[0][eimini.LungPerFev1].ToString());
            item.LungRow = NumberNull10(dt.Rows[0][eimini.LungRow].ToString());
            item.LungSummary = NumberNull10(dt.Rows[0][eimini.LungSummary].ToString());
            item.LungSheetname = NumberNull10(dt.Rows[0][eimini.LungSheetname].ToString());

            item.Audiogram1000L = NumberNull10(dt.Rows[0][eimini.Audiogram1000L].ToString());
            item.Audiogram1000R = NumberNull10(dt.Rows[0][eimini.Audiogram1000R].ToString());
            item.Audiogram2000L = NumberNull10(dt.Rows[0][eimini.Audiogram2000L].ToString());
            item.Audiogram2000R = NumberNull10(dt.Rows[0][eimini.Audiogram2000R].ToString());
            item.Audiogram3000L = NumberNull10(dt.Rows[0][eimini.Audiogram3000L].ToString());
            item.Audiogram3000R = NumberNull10(dt.Rows[0][eimini.Audiogram3000R].ToString());
            item.Audiogram4000L = NumberNull10(dt.Rows[0][eimini.Audiogram4000L].ToString());
            item.Audiogram4000R = NumberNull10(dt.Rows[0][eimini.Audiogram4000R].ToString());
            item.Audiogram500L = NumberNull10(dt.Rows[0][eimini.Audiogram500L].ToString());
            item.Audiogram500R = NumberNull10(dt.Rows[0][eimini.Audiogram500R].ToString());
            item.Audiogram6000L = NumberNull10(dt.Rows[0][eimini.Audiogram6000L].ToString());
            item.Audiogram6000R = NumberNull10(dt.Rows[0][eimini.Audiogram6000R].ToString());
            item.Audiogram8000L = NumberNull10(dt.Rows[0][eimini.Audiogram8000L].ToString());
            item.Audiogram8000R = NumberNull10(dt.Rows[0][eimini.Audiogram8000R].ToString());
            item.AudiogramExam = NumberNull10(dt.Rows[0][eimini.AudiogramExam].ToString());
            item.AudiogramSummaryL = NumberNull10(dt.Rows[0][eimini.AudiogramSummaryL].ToString());
            item.AudiogramSummaryR = NumberNull10(dt.Rows[0][eimini.AudiogramSummaryR].ToString());
            item.AudiogramNo = NumberNull10(dt.Rows[0][eimini.AudiogramNo].ToString());
            item.AudiogramRow = NumberNull10(dt.Rows[0][eimini.AudiogramRow].ToString());
            item.AudiogramSheetname = NumberNull10(dt.Rows[0][eimini.AudiogramSheetname].ToString());

            item.EyeNo = NumberNull10(dt.Rows[0][eimini.EyeNo].ToString());
            item.EyeRow = NumberNull10(dt.Rows[0][eimini.EyeRow].ToString());
            item.EyeShortLongLeft = NumberNull10(dt.Rows[0][eimini.EyeShortLongLeft].ToString());
            item.EyeShortLongRight = NumberNull10(dt.Rows[0][eimini.EyeShortLongRight].ToString());
            item.EyeExam = NumberNull10(dt.Rows[0][eimini.EyeExam].ToString());
            item.EyeDegreeLeft = NumberNull10(dt.Rows[0][eimini.EyeDegreeLeft].ToString());
            item.EyeDegreeRight = NumberNull10(dt.Rows[0][eimini.EyeDegreeRight].ToString());
            item.EyeSquintLeft = NumberNull10(dt.Rows[0][eimini.EyeSquintLeft].ToString());
            item.EyeSquintRight = NumberNull10(dt.Rows[0][eimini.EyeSquintRight].ToString());
            item.EyeOldLeft = NumberNull10(dt.Rows[0][eimini.EyeOldLeft].ToString());
            item.EyeOldRight = NumberNull10(dt.Rows[0][eimini.EyeOldRight].ToString());
            item.EyeSummary = NumberNull10(dt.Rows[0][eimini.EyeSummary].ToString());
            item.EyeResult = NumberNull10(dt.Rows[0][eimini.EyeResult].ToString());
            item.EyeBlindness = NumberNull10(dt.Rows[0][eimini.EyeBlindness].ToString());
            item.EyeSheetname = NumberNull10(dt.Rows[0][eimini.EyeSheetname].ToString());

            item.StoolExamAppearance = NumberNull10(dt.Rows[0][eimini.StoolExamAppearance].ToString());
            item.StoolExamColor = NumberNull10(dt.Rows[0][eimini.StoolExamColor].ToString());
            item.StoolExamNo = NumberNull10(dt.Rows[0][eimini.StoolExamNo].ToString());
            item.StoolExamParasite = NumberNull10(dt.Rows[0][eimini.StoolExamParasite].ToString());
            item.StoolExamRbc = NumberNull10(dt.Rows[0][eimini.StoolExamRbc].ToString());
            item.StoolExamRow = NumberNull10(dt.Rows[0][eimini.StoolExamRow].ToString());
            item.StoolExamSummary = NumberNull10(dt.Rows[0][eimini.StoolExamSummary].ToString());
            item.StoolExamWbc = NumberNull10(dt.Rows[0][eimini.StoolExamWbc].ToString());
            item.StoolExamCulture = NumberNull10(dt.Rows[0][eimini.StoolExamCulture].ToString());
            item.StoolExamTyphoidH = NumberNull10(dt.Rows[0][eimini.StoolExamTyphoidH].ToString());
            item.StoolExamTyphoidO = NumberNull10(dt.Rows[0][eimini.StoolExamTyphoidO].ToString());
            item.StoolExamSheetname = NumberNull10(dt.Rows[0][eimini.StoolExamSheetname].ToString());

            item.StoolExamCultureSummary = NumberNull10(dt.Rows[0][eimini.StoolExamCultureSummary].ToString());

            item.ToxiLead = NumberNull10(dt.Rows[0][eimini.ToxiLead].ToString());
            item.ToxiAluminium = NumberNull10(dt.Rows[0][eimini.ToxiAluminium].ToString());
            item.ToxiCadmium = NumberNull10(dt.Rows[0][eimini.ToxiCadmium].ToString());
            item.ToxiMercury = NumberNull10(dt.Rows[0][eimini.ToxiMercury].ToString());
            item.ToxiTin = NumberNull10(dt.Rows[0][eimini.ToxiTin].ToString());
            item.ToxiCopper = NumberNull10(dt.Rows[0][eimini.ToxiCopper].ToString());
            item.ToxiManganese = NumberNull10(dt.Rows[0][eimini.ToxiManganese].ToString());
            item.ToxiZinc = NumberNull10(dt.Rows[0][eimini.ToxiZinc].ToString());
            item.ToxiAmmonia = NumberNull10(dt.Rows[0][eimini.ToxiAmmonia].ToString());
            item.ToxiSheetname = NumberNull10(dt.Rows[0][eimini.ToxiSheetname].ToString());

            item.ToxiHippuric = NumberNull10(dt.Rows[0][eimini.ToxiHippuric].ToString());
            item.ToxiMethyl = NumberNull10(dt.Rows[0][eimini.ToxiMethyl].ToString());
            item.ToxiAcetone = NumberNull10(dt.Rows[0][eimini.ToxiAcetone].ToString());
            item.ToxiNickel = NumberNull10(dt.Rows[0][eimini.ToxiNickel].ToString());
            item.ToxiChromium = NumberNull10(dt.Rows[0][eimini.ToxiChromium].ToString());
            item.ToxiPhenol = NumberNull10(dt.Rows[0][eimini.ToxiPhenol].ToString());
            item.ToxiKetone = NumberNull10(dt.Rows[0][eimini.ToxiKetone].ToString());
            item.ToxiBenzene = NumberNull10(dt.Rows[0][eimini.ToxiBenzene].ToString());
            item.ToxiMandelic = NumberNull10(dt.Rows[0][eimini.ToxiMandelic].ToString());

            item.ToxiMethanol = NumberNull10(dt.Rows[0][eimini.ToxiMethanol].ToString());
            item.ToxiEthanol = NumberNull10(dt.Rows[0][eimini.ToxiEthanol].ToString());
            item.ToxiIPA = NumberNull10(dt.Rows[0][eimini.ToxiIPA].ToString());
            item.ToxiArsenic = NumberNull10(dt.Rows[0][eimini.ToxiArsenic].ToString());
            item.ToxiHexane = NumberNull10(dt.Rows[0][eimini.ToxiHexane].ToString());
            item.ToxiFomaldehyde = NumberNull10(dt.Rows[0][eimini.ToxiFomaldehyde].ToString());
            item.ToxiTrichloroethylene = NumberNull10(dt.Rows[0][eimini.ToxiTrichloroethylene].ToString());
            item.ToxiAntimony = NumberNull10(dt.Rows[0][eimini.ToxiAntimony].ToString());
            item.ToxiFluoride = NumberNull10(dt.Rows[0][eimini.ToxiFluoride].ToString());

            item.ToxiRow = NumberNull10(dt.Rows[0][eimini.ToxiRow].ToString());
            item.ToxiNo = NumberNull10(dt.Rows[0][eimini.ToxiNo].ToString());
            item.patient_number = dt.Rows[0][eimini.patient_number].ToString();
            item.Active = dt.Rows[0][eimini.Active].ToString();

            item.ekg = NumberNull10(dt.Rows[0][eimini.ekg].ToString());
            item.ekg_result = NumberNull10(dt.Rows[0][eimini.ekg_result].ToString());
            item.ekg_summary = NumberNull10(dt.Rows[0][eimini.ekg_summary].ToString());

            item.visit_hn = dt.Rows[0][eimini.visit_hn].ToString();
            item.position_name = dt.Rows[0][eimini.position_name].ToString();
            //item.Active = dt.Rows[0][ei.Active].ToString();
            //foreach (PropertyInfo item1 in item.get)
            //{

            //}

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + eimini.table + " Where " + eimini.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public ExcelInitMini selectByPk()
        {
            ExcelInitMini item = new ExcelInitMini();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + eimini.table + " Where " + eimini.pkField + "='10000'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String updateBun( String bunValue, String bunCreatinine, String bunResult, String bunSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + eimini.table + " Set " + eimini.Bun + "='" + bunValue + "', " +
                eimini.BunCreatinine + "='" + bunCreatinine + "', " +
                eimini.BunResult + "='" + bunResult + "', " +
                eimini.BunSummary + "='" + bunSummary + "' " ;
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
            String CBCNeu, String CBCPltC, String CBCPltS, String CBCRBC, String CBCRBCmono,
            String CBCSummary, String CBCWBC, String Pmn, String CBCMCV, String CBCMCH, String CBCMCHC, String CBCBASO, String result)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.CBCBact + "='" + CBCBact + "' " +
                "," + eimini.CBCEos + "='" + CBCEos + "' " +
                "," + eimini.CBCHb + "='" + CBCHb + "' " +
                "," + eimini.CBCHct + "='" + CBCHct + "' " +
                "," + eimini.CBCLy + "='" + CBCLy + "' " +
                "," + eimini.CBCMono + "='" + CBCMono + "' " +
                "," + eimini.CBCNeu + "='" + CBCNeu + "' " +
                
                "," + eimini.CBCPltC + "='" + CBCPltC + "' " +
                "," + eimini.CBCPltS + "='" + CBCPltS + "' " +
                "," + eimini.CBCRBC + "='" + CBCRBC + "' " +
                "," + eimini.CBCRBCmono + "='" + CBCRBCmono + "' " +
                
                "," + eimini.CBCSummary + "='" + CBCSummary + "' " +
                "," + eimini.CBCWBC + "='" + CBCWBC + "' " +
                "," + eimini.cbcPmn + "='" + Pmn + "' " +
                "," + eimini.CBCMCH + "='" + CBCMCH + "' " +
                "," + eimini.CBCMCHC + "='" + CBCMCHC + "' " +
                "," + eimini.CBCMCV + "='" + CBCMCV + "' " +
                "," + eimini.CBCBASO + "='" + CBCBASO + "' " +
                "," + eimini.CBCResult + "='" + result + "' " ;
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
        public String updateCholes(String Cholesteral, String ChoResult, String Chosummary, String ChoLDL, String ChoHDL,
            String ChoLDLResult, String ChoLDlSummary, String ChoHDLResult, String ChoHDLSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.Cholesteral + "='" + Cholesteral + "', " +
                
                eimini.ChoResult + "='" + ChoResult + "', " +
                
                eimini.Chosummary + "='" + Chosummary + "', " +
                eimini.ChoLDL + "='" + ChoLDL + "', " +
                eimini.ChoHDL + "='" + ChoHDL + "', " +
                eimini.ChoLDLResult + "='" + ChoLDLResult + "', " +
                eimini.ChoLDLsummary + "='" + ChoLDlSummary + "', " +
                eimini.ChoHDLResult + "='" + ChoHDLResult + "', " +
                eimini.ChoHDLsummary + "='" + ChoHDLSummary + "' " ;
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
        public String updateFBS(String FBS, String FBSResult, String FBSSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + eimini.table + " Set " + eimini.FBS + "='" + FBS + "', " +                
                eimini.FBSResult + "='" + FBSResult + "', " +                
                eimini.FBSSummary + "='" + FBSSummary + "' " ;
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
        public String updatePE(String PEAge, String PEBMI, String PEHeight, String PEWeight, String PEPulse,
            String PEVitalSign, String PEResult, String PESummary, String PEBloodGroup, String ekg, String ekgResult, String ekgSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.PEAge + "='" + PEAge + "', " +
                eimini.PEBMI + "='" + PEBMI + "', " +
                eimini.PEHeight + "='" + PEHeight + "', " +
                eimini.PEPulse + "='" + PEPulse + "', " +
                eimini.PEResult + "='" + PEResult + "', " +
                eimini.PESummary + "='" + PESummary + "', " +
                eimini.PEVitalSign + "='" + PEVitalSign + "', " +
                eimini.PEWeight + "='" + PEWeight + "', " +
                eimini.PEBloodGroup + "='" + PEBloodGroup + "', " +
                eimini.ekg + "='" + ekg.Replace("'", "''") + "', " +
                eimini.ekg_result + "='" + ekgResult.Replace("'", "''") + "', " +
                eimini.ekg_summary + "='" + ekgSummary.Replace("'", "''") + "' " ;
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
        public String updateSfC(String SfCAge, String SfCAllName, String department, String patient_number, String visi_hn, String position)
        {
            String sql = "", chk = "";

            sql = "Update " + eimini.table + " Set " + eimini.SfCAge + "='" + SfCAge + "', " +
                eimini.SfCFullName + "='" + SfCAllName + "', " +                
                eimini.DepartmentName + "='" + department + "' " +                
                "," + eimini.patient_number + "='" + patient_number + "' " +
                "," + eimini.visit_hn + "='" + visi_hn + "' " +
                "," + eimini.position_name + "='" + position + "' " +
                "," + eimini.SfStatusName + "='C' ";

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
        public String updateSgot(String Sgot, String SgotResult, String Sgpt, String SgptSummary, String alkaline)
        {
            String sql = "", chk = "";
            sql = "Update " + eimini.table + " Set " + eimini.Sgot + "='" + NumberNull10(Sgot) + "', " +                
                eimini.SgotResult + "='" + NumberNull10(SgotResult) + "', " +                
                eimini.Sgpt + "='" + NumberNull10(Sgpt) + "', " +
                eimini.SgptSummary + "='" + NumberNull10(SgptSummary) + "', " +                
                eimini.SgotAlkaline + "='" + NumberNull10(alkaline) + "' ";
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
        public String updateTrig(String Triglyceride, String TriResult, String TriSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + eimini.table + " Set " + eimini.Triglyceride + "='" + NumberNull10(Triglyceride) + "', " +
                eimini.TriResult + "='" + NumberNull10(TriResult) + "', " +
                eimini.TriSummary + "='" + NumberNull10(TriSummary) + "' ";
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
        public String updateUA(String UAAppe, String UABact, String UAColor, String UAEpi, String UApH,
            String UAProtein, String UARBC, String UAResult, String UASpgr, String UASugar, String UASummary, String UAWBC,
            String UAGlu, String UAKetone, String UABlood, String UALeu, String UANit, String UAUro, String UABil)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.UAAppe + "='" + NumberNull10(UAAppe) + "', " +
                eimini.UABact + "='" + NumberNull10(UABact) + "', " +
                eimini.UAColor + "='" + NumberNull10(UAColor) + "', " +
                eimini.UAEpi + "='" + NumberNull10(UAEpi) + "', " +
                eimini.UApH + "='" + NumberNull10(UApH) + "', " +
                eimini.UAProtein + "='" + NumberNull10(UAProtein) + "', " +
                eimini.UARBC + "='" + NumberNull10(UARBC) + "', " +
                eimini.UAResult + "='" + NumberNull10(UAResult) + "', " +
                eimini.UASpgr + "='" + NumberNull10(UASpgr) + "', " +
                eimini.UASugar + "='" + NumberNull10(UASugar) + "', " +
                eimini.UASummary + "='" + NumberNull10(UASummary) + "', " +
                eimini.UAWBC + "='" + NumberNull10(UAWBC) + "', " +
                eimini.UAGlu + "='" + NumberNull10(UAGlu) + "', " +
                eimini.UAKetone + "='" + NumberNull10(UAKetone) + "', " +
                eimini.UABlood + "='" + NumberNull10(UABlood) + "', " +
                eimini.UALeu + "='" + NumberNull10(UALeu) + "', " +
                eimini.UANit + "='" + NumberNull10(UANit) + "', " +
                eimini.UAUro + "='" + NumberNull10(UAUro) + "', " +
                eimini.UABil + "='" + NumberNull10(UABil) + "' " ;
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
        public String updateUric(String UricAcid, String UricResult, String UricSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.UricAcid + "='" + NumberNull10(UricAcid) + "', " +
                eimini.UricResult + "='" + NumberNull10(UricResult) + "', " +
                eimini.UricSummary + "='" + NumberNull10(UricSummary) + "' ";
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
        public String updateXray(String Xray, String XraySummary)
        {
            String sql = "", chk = "";
            sql = "Update " + eimini.table + " Set " + eimini.Xray + "='" + NumberNull10(Xray) + "', " +                
                eimini.XraySummary + "='" + NumberNull10(XraySummary) + "' " ;
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
        public String UpdateOther1(String Amphetamine, String AntiHIV, String Calcium, String HBsAb, String HBsAg, String VDRL, String AntiHav,
            String CAAFP, String CAAFPResult, String CAAFPSummary, String CACEA, String CACEAResult, String CACEASummary, String CAPSA, String CAPSAResult, String CAPSASummary,
            String CAHCG, String CAHCGResult, String CAHCGSummary, String CA153, String CA153Result, String CA153Summary, String CA125, String CA125Result, String CA125Summary,
            String CA199, String CA199Result, String CA199Summary, String HBsAbResult, String HBsAgResult, String HBsAbSummary, String HBsAgSummary, String AmphetamineSummary,
            String AntiHavSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.Other1Amphetamine + "='" + NumberNull10(Amphetamine) + "', " +
                eimini.Other1AntiHIV + "='" + NumberNull10(AntiHIV) + "', " +
                eimini.Other1Calcium + "='" + NumberNull10(Calcium) + "', " +
                eimini.Other1HBsAb + "='" + NumberNull10(HBsAb) + "', " +
                eimini.Other1HBsAg + "='" + NumberNull10(HBsAg) + "', " +
                eimini.Other1VDRL + "='" + NumberNull10(VDRL) + "', " +
                eimini.Other1AntiHav + "='" + AntiHav + "', " +
                eimini.CAAFP + "='" + CAAFP + "', " +
                eimini.CAAFPResult + "='" + CAAFPResult + "', " +
                eimini.CAAFPSummary + "='" + CAAFPSummary + "', " +
                eimini.CACEA + "='" + CACEA + "', " +
                eimini.CACEAResult + "='" + CACEAResult + "', " +
                eimini.CACEASummary + "='" + CACEASummary + "', " +
                eimini.CAPSA + "='" + CAPSA + "', " +
                eimini.CAPSAResult + "='" + CAPSAResult + "', " +
                eimini.CAPSASummary + "='" + CAPSASummary + "', " +
                eimini.CAHCG + "='" + CAHCG + "', " +
                eimini.CAHCGResult + "='" + CAHCGResult + "', " +
                eimini.CAHCGSummary + "='" + CAHCGSummary + "', " +
                eimini.CA153 + "='" + CA153 + "', " +
                eimini.CA153Result + "='" + CA153Result + "', " +
                eimini.CA153Summary + "='" + CA153Summary + "', " +
                eimini.CA125 + "='" + CA125 + "', " +
                eimini.CA125Result + "='" + CA125Result + "', " +
                eimini.CA125Summary + "='" + CA125Summary + "', " +
                eimini.CA199 + "='" + CA199 + "', " +
                eimini.CA199Result + "='" + CA199Result + "', " +
                eimini.CA199Summary + "='" + CA199Summary + "', " +
                eimini.Other1HBsAbResult + "='" + HBsAbResult + "', " +
                eimini.Other1HBsAgResult + "='" + HBsAgResult + "', " +
                eimini.Other1HBsAbSummary + "='" + HBsAbSummary + "', " +
                eimini.Other1HBsAgSummary + "='" + HBsAgSummary + "', " +
                eimini.AmphetamineSummary + "='" + AmphetamineSummary + "', " +
                eimini.Other1AntiHavSummary + "='" + AntiHavSummary + "' ";
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
        public String updateLung(String LungFvcPredic, String LungFvcMeas, String LungFvcPer, String LungFev1Predic, String LungFev1Meas,
            String LungFev1Per, String LungPerFev1, String LungSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.LungFvcPredic + "='" + NumberNull10(LungFvcPredic) + "', " +
                eimini.LungFvcMeas + "='" + NumberNull10(LungFvcMeas) + "', " +
                eimini.LungFvcPer + "='" + NumberNull10(LungFvcPer) + "', " +
                eimini.LungFev1Predic + "='" + NumberNull10(LungFev1Predic) + "', " +
                eimini.LungFev1Meas + "='" + NumberNull10(LungFev1Meas) + "', " +
                eimini.LungFev1Per + "='" + NumberNull10(LungFev1Per) + "', " +
                eimini.LungPerFev1 + "='" + NumberNull10(LungPerFev1) + "', " +
                eimini.LungSummary + "='" + NumberNull10(LungSummary) + "' ";
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
        public String updateAudioGram(String Audiogram500L, String Audiogram500R, String Audiogram1000L, String Audiogram1000R, String Audiogram2000L, String Audiogram2000R,
            String Audiogram3000L, String Audiogram3000R, String Audiogram4000L, String Audiogram4000R, String Audiogram6000L, String Audiogram6000R, String Audiogram8000L, String Audiogram8000R,
            String AudiogramSummaryL, String AudiogramSummaryR, String AudiogramExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.Audiogram500L + "='" + NumberNull10(Audiogram500L) + "', " +
                eimini.Audiogram500R + "='" + NumberNull10(Audiogram500R) + "', " +
                eimini.Audiogram1000L + "='" + NumberNull10(Audiogram1000L) + "', " +
                eimini.Audiogram1000R + "='" + NumberNull10(Audiogram1000R) + "', " +
                eimini.Audiogram2000L + "='" + NumberNull10(Audiogram2000L) + "', " +
                eimini.Audiogram2000R + "='" + NumberNull10(Audiogram2000R) + "', " +
                eimini.Audiogram3000L + "='" + NumberNull10(Audiogram3000L) + "', " +
                eimini.Audiogram3000R + "='" + NumberNull10(Audiogram3000R) + "', " +
                eimini.Audiogram4000L + "='" + NumberNull10(Audiogram4000L) + "', " +
                eimini.Audiogram4000R + "='" + NumberNull10(Audiogram4000R) + "', " +
                eimini.Audiogram6000L + "='" + NumberNull10(Audiogram6000L) + "', " +
                eimini.Audiogram6000R + "='" + NumberNull10(Audiogram6000R) + "', " +
                eimini.Audiogram8000L + "='" + NumberNull10(Audiogram8000L) + "', " +
                eimini.Audiogram8000R + "='" + NumberNull10(Audiogram8000R) + "', " +
                eimini.AudiogramSummaryL + "='" + NumberNull10(AudiogramSummaryL) + "', " +
                eimini.AudiogramSummaryR + "='" + NumberNull10(AudiogramSummaryR) + "', " +
                eimini.AudiogramExam + "='" + NumberNull10(AudiogramExam) + "' " ;
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
        public String updateEye(String EyeShortLongLeft, String EyeShortLongRight, String EyeSquintLeft, String EyeSquintRight,
            String EyedegreeLeft, String EyeDegreeRight, String EyeOldLeft, String EyeOldRight, String EyeResult, String EyeSummary, String EyeBlindness, String EyeExam)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.EyeShortLongLeft + "='" + NumberNull10(EyeShortLongLeft) + "', " +
                eimini.EyeShortLongRight + "='" + NumberNull10(EyeShortLongRight) + "', " +
                eimini.EyeSquintLeft + "='" + NumberNull10(EyeSquintLeft) + "', " +
                eimini.EyeSquintRight + "='" + NumberNull10(EyeSquintRight) + "', " +
                eimini.EyeDegreeLeft + "='" + NumberNull10(EyedegreeLeft) + "', " +
                eimini.EyeDegreeRight + "='" + NumberNull10(EyeDegreeRight) + "', " +
                eimini.EyeOldLeft + "='" + NumberNull10(EyeOldLeft) + "', " +
                eimini.EyeOldRight + "='" + NumberNull10(EyeOldRight) + "', " +
                eimini.EyeResult + "='" + NumberNull10(EyeResult) + "', " +
                eimini.EyeSummary + "='" + NumberNull10(EyeSummary) + "', " +
                eimini.EyeExam + "='" + NumberNull10(EyeExam) + "', " +
                eimini.EyeBlindness + "='" + NumberNull10(EyeBlindness) + "' " ;
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
        public String updateStoolExam(String StoolExamAppearance, String StoolExamColor, String StoolExamWbc, String StoolExamRbc,
            String StoolExamParasite, String StoolExamSummary, String StoolExamCulture, String StoolExamTyhoidH, String StoolExamTyhoidO, String StoolExamCultureSummary)
        {
            String sql = "", chk = "";

            sql = "Update " + eimini.table + " Set " +eimini.StoolExamAppearance + "='" + NumberNull10(StoolExamAppearance) + "', " +
                eimini.StoolExamColor + "='" + NumberNull10(StoolExamColor) + "', " +
                eimini.StoolExamWbc + "='" + NumberNull10(StoolExamWbc) + "', " +
                eimini.StoolExamRbc + "='" + NumberNull10(StoolExamRbc) + "', " +
                eimini.StoolExamParasite + "='" + NumberNull10(StoolExamParasite) + "', " +
                eimini.StoolExamSummary + "='" + NumberNull10(StoolExamSummary) + "', " +
                eimini.StoolExamCulture + "='" + NumberNull10(StoolExamCulture) + "', " +
                eimini.StoolExamTyphoidH + "='" + StoolExamTyhoidH + "', " +
                eimini.StoolExamTyphoidO + "='" + StoolExamTyhoidO + "', " +
                eimini.StoolExamCultureSummary + "='" + StoolExamCultureSummary + "' ";
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
        public String updateToxi1(String ToxiLead, String ToxiAluminium, String ToxiCadmium, String ToxiMercury, String ToxiTin, String ToxiCopper,
            String ToxiManganese, String ToxiZinc, String ToxiAmmonia)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + eimini.table + " Set " + eimini.ToxiLead + "='" + NumberNull10(ToxiLead) + "', " +
                eimini.ToxiAluminium + "='" + NumberNull10(ToxiAluminium) + "', " +
                eimini.ToxiCadmium + "='" + NumberNull10(ToxiCadmium) + "', " +
                eimini.ToxiMercury + "='" + NumberNull10(ToxiMercury) + "', " +
                eimini.ToxiTin + "='" + NumberNull10(ToxiTin) + "', " +
                eimini.ToxiCopper + "='" + NumberNull10(ToxiCopper) + "', " +
                eimini.ToxiManganese + "='" + NumberNull10(ToxiManganese) + "', " +
                eimini.ToxiZinc + "='" + NumberNull10(ToxiZinc) + "', " +
                eimini.ToxiAmmonia + "='" + NumberNull10(ToxiAmmonia) + "' ";
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

            sql = "Update " + eimini.table + " Set " + eimini.ToxiHippuric + "='" + NumberNull10(ToxiHippuric) + "', " +
                eimini.ToxiMethyl + "='" + NumberNull10(ToxiMethyl) + "', " +
                eimini.ToxiAcetone + "='" + NumberNull10(ToxiAcetone) + "', " +
                eimini.ToxiNickel + "='" + NumberNull10(ToxiNickel) + "', " +
                eimini.ToxiChromium + "='" + NumberNull10(ToxiChromium) + "', " +
                eimini.ToxiPhenol + "='" + NumberNull10(ToxiPhenol) + "', " +
                eimini.ToxiKetone + "='" + NumberNull10(ToxiKetone) + "', " +
                eimini.ToxiBenzene + "='" + NumberNull10(ToxiBenzene) + "', " +
                eimini.ToxiMandelic + "='" + NumberNull10(ToxiMandelic) + "', " +
                eimini.ToxiMethanol + "='" + NumberNull10(ToxiMethanol) + "', " +
                eimini.ToxiEthanol + "='" + NumberNull10(ToxiEthanol) + "', " +
                eimini.ToxiIPA + "='" + NumberNull10(ToxiIPA) + "', " +
                eimini.ToxiArsenic + "='" + NumberNull10(ToxiArsenic) + "', " +
                eimini.ToxiHexane + "='" + NumberNull10(ToxiHexane) + "', " +
                eimini.ToxiFomaldehyde + "='" + NumberNull10(ToxiFomaldehyde) + "', " +
                eimini.ToxiTrichloroethylene + "='" + NumberNull10(ToxiTrichloroethylene) + "', " +
                eimini.ToxiAntimony + "='" + NumberNull10(ToxiAntimony) + "', " +
                eimini.ToxiFluoride + "='" + NumberNull10(ToxiFluoride) + "' " ;
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
