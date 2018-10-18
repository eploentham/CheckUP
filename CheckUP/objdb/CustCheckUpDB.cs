using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class CustCheckUpDB
    {
        ConnectDB conn, connOnSite;
        public CustCheckUp cuc;
        public CustCheckUpDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            cuc = new CustCheckUp();
            cuc.Active = "cust_checkup_active";
            cuc.CheckUpDate = "checkup_date";
            cuc.CheckUpEndDate = "checkup_end_date";
            cuc.CheckUpStartDate = "checkup_start_date";
            cuc.CntEmployee = "cnt_employee";
            cuc.CommitCheckUpDate = "commit_checkup_date";
            cuc.CustId = "cust_id";
            cuc.CustNameT = "cust_namet";
            cuc.Description = "description";
            cuc.Id = "cust_checkup_patient_id";
            cuc.RegisDate = "regis_date";
            cuc.Remark = "remark";
            cuc.YearId = "year_id";
            cuc.CntSuccess = "cnt_success";

            cuc.PEAbNormal = "pe_abnormal";
            cuc.PECnt = "pe_cnt";
            cuc.PENormal = "pe_normal";
            cuc.PESuccess = "pe_success";

            cuc.XrayAbNormal = "xray_abnormal";
            cuc.XrayCnt = "xray_cnt";
            cuc.XrayNormal = "xray_normal";
            cuc.XraySuccess = "xray_success";

            cuc.CBCAbNormal = "cbc_abnormal";
            cuc.CBCCnt = "cbc_cnt";
            cuc.CBCNormal = "cbc_normal";
            cuc.CBCSuccess = "cbc_success";

            cuc.FBSAbNormal = "fbs_abnormal";
            cuc.FBSCnt = "fbs_cnt";
            cuc.FBSNormal = "fbs_normal";
            cuc.FBSSuccess = "fbs_success";

            cuc.UAAbNormal = "ua_abnormal";
            cuc.UACnt = "ua_cnt";
            cuc.UANormal = "ua_normal";
            cuc.UASuccess = "ua_success";

            cuc.TriAbNormal = "tri_abnormal";
            cuc.TriCnt = "tri_cnt";
            cuc.TriNormal = "tri_normal";
            cuc.TriSuccess = "tri_success";

            cuc.BunAbNormal = "bun_abnormal";
            cuc.BunCnt = "bun_cnt";
            cuc.BunNormal = "bun_normal";
            cuc.BunSuccess = "bun_success";

            cuc.ChoAbNormal = "cho_abnormal";
            cuc.ChoCnt = "cho_cnt";
            cuc.ChoNormal = "cho_normal";
            cuc.ChoSuccess = "cho_success";

            cuc.SgotAbNormal = "sgot_abnormal";
            cuc.SgotCnt = "sgot_cnt";
            cuc.SgotNormal = "sgot_normal";
            cuc.SgotSuccess = "sgot_success";

            cuc.UricAbNormal = "uric_abnormal";
            cuc.UricCnt = "uric_cnt";
            cuc.UricNormal = "uric_normal";
            cuc.UricSuccess = "uric_success";

            cuc.Other1AbNormal = "other1_abnormal";
            cuc.Other1Cnt = "other1_cnt";
            cuc.Other1Normal = "other1_normal";
            cuc.Other1Success = "other1_success";

            cuc.AudioAbNormal = "audio_abnormal";
            cuc.AudioCnt = "audio_cnt";
            cuc.AudioNormal = "audio_normal";
            cuc.AudioSuccess = "audio_success";

            cuc.LungAbNormal = "lung_abnormal";
            cuc.LungCnt = "lung_cnt";
            cuc.LungNormal = "lung_normal";
            cuc.LungSuccess = "lung_success";

            cuc.EyeAbNormal = "eye_abnormal";
            cuc.EyeCnt = "eye_cnt";
            cuc.EyeNormal = "eye_normal";
            cuc.EyeSuccess = "eye_success";

            cuc.StoolExamAbNormal = "stoolexam_abnormal";
            cuc.StoolExamCnt = "stoolexam_cnt";
            cuc.StoolExamNormal = "stoolexam_normal";
            cuc.StoolExamSuccess = "stoolexam_success";

            cuc.ToxiAbNormal = "toxi_abnormal";
            cuc.ToxiCnt = "toxi_cnt";
            cuc.ToxiNormal = "toxi_normal";
            cuc.ToxiSuccess = "toxi_success";

            cuc.dateCancel = "date_cancel";
            cuc.dateCreate = "date_create";
            cuc.dateModi = "date_modi";

            cuc.userCancel = "user_cancel";
            cuc.userCreate = "user_create";
            cuc.userModi = "user_modi";

            cuc.pe_checkup = "pe_checkup";
            cuc.xray_checkup = "xray_checkup";
            cuc.fbs_checkup = "fbs_checkup";
            cuc.cbc_checkup = "cbc_checkup";
            cuc.ua_checkup = "ua_checkup";
            cuc.tri_checkup = "tri_checkup";
            cuc.cho_checkup = "cho_checkup";
            cuc.sgot_checkup = "sgot_checkup";
            cuc.bun_checkup = "bun_checkup";
            cuc.uric_checkup = "uric_checkup";
            cuc.other1_checkup = "other1_checkup";
            cuc.lung_checkup = "lung_checkup";
            cuc.audio_checkup = "audio_checkup";
            cuc.eye_checkup = "eye_checkup";
            cuc.stoolexam_checkup = "stoolexam_checkup";
            cuc.toxi_checkup = "toxi_checkup";
            cuc.pe_test = "pe_test";
            cuc.xray_test = "xray_test";
            cuc.fbs_test = "fbs_test";
            cuc.cbc_test  = "cbc_test";
            cuc.ua_test = "ua_test";
            cuc.tri_test = "tri_test";
            cuc.cho_test = "cho_test";
            cuc.sgot_test = "sgot_test";
            cuc.bun_test = "bun_test";
            cuc.uric_test = "uric_test";
            cuc.other1_test = "other1_test";
            cuc.lung_test = "lung_test";
            cuc.audio_test = "audio_test";
            cuc.eye_test = "eye_test";
            cuc.stoolexam_test = "stoolexam_test";
            cuc.toxi_test = "toxi_test";
            cuc.sticker = "sticker";

            cuc.sticker01 = "sticker01";
            cuc.sticker02 = "sticker02";
            cuc.sticker03 = "sticker03";
            cuc.sticker04 = "sticker04";
            cuc.sticker05 = "sticker05";
            cuc.sticker06 = "sticker06";
            cuc.sticker07 = "sticker07";
            cuc.sticker08 = "sticker08";
            cuc.sticker09 = "sticker09";
            cuc.sticker10 = "sticker10";
            cuc.sticker11 = "sticker11";
            cuc.sticker12 = "sticker12";
            cuc.sticker13 = "sticker13";
            cuc.sticker14 = "sticker14";
            cuc.sticker15 = "sticker15";
            cuc.sticker16 = "sticker16";
            cuc.sticker17 = "sticker17";
            cuc.sticker18 = "sticker18";
            cuc.sticker19 = "sticker19";
            cuc.sticker20 = "sticker20";

            cuc.sticker01_name = "sticker01_name";
            cuc.sticker02_name = "sticker02_name";
            cuc.sticker03_name = "sticker03_name";
            cuc.sticker04_name = "sticker04_name";
            cuc.sticker05_name = "sticker05_name";
            cuc.sticker06_name = "sticker06_name";
            cuc.sticker07_name = "sticker07_name";
            cuc.sticker08_name = "sticker08_name";
            cuc.sticker09_name = "sticker09_name";
            cuc.sticker10_name = "sticker10_name";
            cuc.sticker11_name = "sticker11_name";
            cuc.sticker12_name = "sticker12_name";
            cuc.sticker13_name = "sticker13_name";
            cuc.sticker14_name = "sticker14_name";
            cuc.sticker15_name = "sticker15_name";
            cuc.sticker16_name = "sticker16_name";
            cuc.sticker17_name = "sticker17_name";
            cuc.sticker18_name = "sticker18_name";
            cuc.sticker19_name = "sticker19_name";
            cuc.sticker20_name = "sticker20_name";

            cuc.pkField = "cust_checkup_patient_id";
            cuc.table = "t_cust_checkup";
        }
        private CustCheckUp setData(CustCheckUp item, DataTable dt)
        {
            item.Active = dt.Rows[0][cuc.Active].ToString();
            item.CheckUpDate = dt.Rows[0][cuc.CheckUpDate].ToString();
            item.CheckUpEndDate = dt.Rows[0][cuc.CheckUpEndDate].ToString();
            item.CheckUpStartDate = dt.Rows[0][cuc.CheckUpStartDate].ToString();
            item.CntEmployee = dt.Rows[0][cuc.CntEmployee].ToString();
            item.CommitCheckUpDate = dt.Rows[0][cuc.CommitCheckUpDate].ToString();
            item.CustId = dt.Rows[0][cuc.CustId].ToString();
            item.CntSuccess = dt.Rows[0][cuc.CntSuccess].ToString();

            item.CustNameT = dt.Rows[0][cuc.CustNameT].ToString();
            item.Description = dt.Rows[0][cuc.Description].ToString();
            item.Id = dt.Rows[0][cuc.Id].ToString();
            item.RegisDate = dt.Rows[0][cuc.RegisDate].ToString();
            item.Remark = dt.Rows[0][cuc.Remark].ToString();
            item.YearId = dt.Rows[0][cuc.YearId].ToString();

            item.PEAbNormal = dt.Rows[0][cuc.PEAbNormal].ToString();
            item.PECnt = dt.Rows[0][cuc.PECnt].ToString();
            item.PENormal = dt.Rows[0][cuc.PENormal].ToString();
            item.PESuccess = dt.Rows[0][cuc.PESuccess].ToString();

            item.XrayAbNormal = dt.Rows[0][cuc.XrayAbNormal].ToString();
            item.XrayCnt = dt.Rows[0][cuc.XrayCnt].ToString();
            item.XrayNormal = dt.Rows[0][cuc.XrayNormal].ToString();
            item.XraySuccess = dt.Rows[0][cuc.XraySuccess].ToString();

            item.CBCAbNormal = dt.Rows[0][cuc.CBCAbNormal].ToString();
            item.CBCCnt = dt.Rows[0][cuc.CBCCnt].ToString();
            item.CBCNormal = dt.Rows[0][cuc.CBCNormal].ToString();
            item.CBCSuccess = dt.Rows[0][cuc.CBCSuccess].ToString();

            item.FBSAbNormal = dt.Rows[0][cuc.FBSAbNormal].ToString();
            item.FBSCnt = dt.Rows[0][cuc.FBSCnt].ToString();
            item.FBSNormal = dt.Rows[0][cuc.FBSNormal].ToString();
            item.FBSSuccess = dt.Rows[0][cuc.FBSSuccess].ToString();

            item.UAAbNormal = dt.Rows[0][cuc.UAAbNormal].ToString();
            item.UACnt = dt.Rows[0][cuc.UACnt].ToString();
            item.UANormal = dt.Rows[0][cuc.UANormal].ToString();
            item.UASuccess = dt.Rows[0][cuc.UASuccess].ToString();

            item.TriAbNormal = dt.Rows[0][cuc.TriAbNormal].ToString();
            item.TriCnt = dt.Rows[0][cuc.TriCnt].ToString();
            item.TriNormal = dt.Rows[0][cuc.TriNormal].ToString();
            item.TriSuccess = dt.Rows[0][cuc.TriSuccess].ToString();

            item.BunAbNormal = dt.Rows[0][cuc.BunAbNormal].ToString();
            item.BunCnt = dt.Rows[0][cuc.BunCnt].ToString();
            item.BunNormal = dt.Rows[0][cuc.BunNormal].ToString();
            item.BunSuccess = dt.Rows[0][cuc.BunSuccess].ToString();

            item.ChoAbNormal = dt.Rows[0][cuc.ChoAbNormal].ToString();
            item.ChoCnt = dt.Rows[0][cuc.ChoCnt].ToString();
            item.ChoNormal = dt.Rows[0][cuc.ChoNormal].ToString();
            item.ChoSuccess = dt.Rows[0][cuc.ChoSuccess].ToString();

            item.SgotAbNormal = dt.Rows[0][cuc.SgotAbNormal].ToString();
            item.SgotCnt = dt.Rows[0][cuc.SgotCnt].ToString();
            item.SgotNormal = dt.Rows[0][cuc.SgotNormal].ToString();
            item.SgotSuccess = dt.Rows[0][cuc.SgotSuccess].ToString();

            item.UricAbNormal = dt.Rows[0][cuc.UricAbNormal].ToString();
            item.UricCnt = dt.Rows[0][cuc.UricCnt].ToString();
            item.UricNormal = dt.Rows[0][cuc.UricNormal].ToString();
            item.UricSuccess = dt.Rows[0][cuc.UricSuccess].ToString();

            item.Other1AbNormal = dt.Rows[0][cuc.Other1AbNormal].ToString();
            item.Other1Cnt = dt.Rows[0][cuc.Other1Cnt].ToString();
            item.Other1Normal = dt.Rows[0][cuc.Other1Normal].ToString();
            item.Other1Success = dt.Rows[0][cuc.Other1Success].ToString();

            item.AudioAbNormal = dt.Rows[0][cuc.AudioAbNormal].ToString();
            item.AudioCnt = dt.Rows[0][cuc.AudioCnt].ToString();
            item.AudioNormal = dt.Rows[0][cuc.AudioNormal].ToString();
            item.AudioSuccess = dt.Rows[0][cuc.AudioSuccess].ToString();

            item.LungAbNormal = dt.Rows[0][cuc.LungAbNormal].ToString();
            item.LungCnt = dt.Rows[0][cuc.LungCnt].ToString();
            item.LungNormal = dt.Rows[0][cuc.LungNormal].ToString();
            item.LungSuccess = dt.Rows[0][cuc.LungSuccess].ToString();

            item.EyeAbNormal = dt.Rows[0][cuc.EyeAbNormal].ToString();
            item.EyeCnt = dt.Rows[0][cuc.EyeCnt].ToString();
            item.EyeNormal = dt.Rows[0][cuc.EyeNormal].ToString();
            item.EyeSuccess = dt.Rows[0][cuc.EyeSuccess].ToString();

            item.StoolExamAbNormal = dt.Rows[0][cuc.StoolExamAbNormal].ToString();
            item.StoolExamCnt = dt.Rows[0][cuc.StoolExamCnt].ToString();
            item.StoolExamNormal = dt.Rows[0][cuc.StoolExamNormal].ToString();
            item.StoolExamSuccess = dt.Rows[0][cuc.StoolExamSuccess].ToString();

            item.ToxiAbNormal = dt.Rows[0][cuc.ToxiAbNormal].ToString();
            item.ToxiCnt = dt.Rows[0][cuc.ToxiCnt].ToString();
            item.ToxiNormal = dt.Rows[0][cuc.ToxiNormal].ToString();
            item.ToxiSuccess = dt.Rows[0][cuc.ToxiSuccess].ToString();

            item.dateCancel = dt.Rows[0][cuc.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][cuc.dateCreate].ToString();
            item.dateModi = dt.Rows[0][cuc.dateModi].ToString();

            item.userCancel = dt.Rows[0][cuc.userCancel].ToString();
            item.userCreate = dt.Rows[0][cuc.userCreate].ToString();
            item.userModi = dt.Rows[0][cuc.userModi].ToString();

            item.pe_checkup = dt.Rows[0][cuc.pe_checkup].ToString();
            item.xray_checkup = dt.Rows[0][cuc.xray_checkup].ToString();
            item.fbs_checkup = dt.Rows[0][cuc.fbs_checkup].ToString();
            item.cbc_checkup = dt.Rows[0][cuc.cbc_checkup].ToString();
            item.ua_checkup = dt.Rows[0][cuc.ua_checkup].ToString();
            item.tri_checkup = dt.Rows[0][cuc.tri_checkup].ToString();
            item.cho_checkup = dt.Rows[0][cuc.cho_checkup].ToString();
            item.sgot_checkup = dt.Rows[0][cuc.sgot_checkup].ToString();
            item.bun_checkup = dt.Rows[0][cuc.userModi].ToString();
            item.uric_checkup = dt.Rows[0][cuc.uric_checkup].ToString();
            item.other1_checkup = dt.Rows[0][cuc.other1_checkup].ToString();
            item.lung_checkup = dt.Rows[0][cuc.lung_checkup].ToString();
            item.audio_checkup = dt.Rows[0][cuc.audio_checkup].ToString();
            item.eye_checkup = dt.Rows[0][cuc.eye_checkup].ToString();
            item.stoolexam_checkup = dt.Rows[0][cuc.stoolexam_checkup].ToString();
            item.toxi_checkup = dt.Rows[0][cuc.toxi_checkup].ToString();
            item.pe_test = dt.Rows[0][cuc.pe_test].ToString();
            item.xray_test = dt.Rows[0][cuc.xray_test].ToString();
            item.fbs_test = dt.Rows[0][cuc.fbs_test].ToString();
            item.cbc_test = dt.Rows[0][cuc.cbc_test].ToString();
            item.ua_test = dt.Rows[0][cuc.ua_test].ToString();
            item.tri_test = dt.Rows[0][cuc.tri_test].ToString();
            item.cho_test = dt.Rows[0][cuc.cho_test].ToString();
            item.sgot_test = dt.Rows[0][cuc.sgot_test].ToString();
            item.bun_test = dt.Rows[0][cuc.userModi].ToString();
            item.uric_test = dt.Rows[0][cuc.uric_test].ToString();
            item.other1_test = dt.Rows[0][cuc.other1_test].ToString();
            item.lung_test = dt.Rows[0][cuc.lung_test].ToString();
            item.audio_test = dt.Rows[0][cuc.audio_test].ToString();
            item.eye_test = dt.Rows[0][cuc.eye_test].ToString();
            item.stoolexam_test = dt.Rows[0][cuc.stoolexam_test].ToString();
            item.toxi_test = dt.Rows[0][cuc.toxi_test].ToString();
            item.sticker = dt.Rows[0][cuc.sticker].ToString();

            item.sticker01 = dt.Rows[0][cuc.sticker01].ToString();
            item.sticker02 = dt.Rows[0][cuc.sticker02].ToString();
            item.sticker03 = dt.Rows[0][cuc.sticker03].ToString();
            item.sticker04 = dt.Rows[0][cuc.sticker04].ToString();
            item.sticker05= dt.Rows[0][cuc.sticker05].ToString();
            item.sticker06 = dt.Rows[0][cuc.sticker06].ToString();
            item.sticker07 = dt.Rows[0][cuc.sticker07].ToString();
            item.sticker08 = dt.Rows[0][cuc.sticker08].ToString();
            item.sticker09 = dt.Rows[0][cuc.sticker09].ToString();
            item.sticker10 = dt.Rows[0][cuc.sticker10].ToString();
            item.sticker11 = dt.Rows[0][cuc.sticker11].ToString();
            item.sticker12 = dt.Rows[0][cuc.sticker12].ToString();
            item.sticker13 = dt.Rows[0][cuc.sticker13].ToString();
            item.sticker14 = dt.Rows[0][cuc.sticker14].ToString();
            item.sticker15 = dt.Rows[0][cuc.sticker15].ToString();
            item.sticker16 = dt.Rows[0][cuc.sticker16].ToString();
            item.sticker17 = dt.Rows[0][cuc.sticker17].ToString();
            item.sticker18 = dt.Rows[0][cuc.sticker18].ToString();
            item.sticker19 = dt.Rows[0][cuc.sticker19].ToString();
            item.sticker20 = dt.Rows[0][cuc.sticker20].ToString();

            item.sticker01_name = dt.Rows[0][cuc.sticker01_name].ToString();
            item.sticker02_name = dt.Rows[0][cuc.sticker02_name].ToString();
            item.sticker03_name = dt.Rows[0][cuc.sticker03_name].ToString();
            item.sticker04_name = dt.Rows[0][cuc.sticker04_name].ToString();
            item.sticker05_name = dt.Rows[0][cuc.sticker05_name].ToString();
            item.sticker06_name = dt.Rows[0][cuc.sticker06_name].ToString();
            item.sticker07_name = dt.Rows[0][cuc.sticker07_name].ToString();
            item.sticker08_name = dt.Rows[0][cuc.sticker08_name].ToString();
            item.sticker09_name = dt.Rows[0][cuc.sticker09_name].ToString();
            item.sticker10_name = dt.Rows[0][cuc.sticker10_name].ToString();
            item.sticker11_name = dt.Rows[0][cuc.sticker11_name].ToString();
            item.sticker12_name = dt.Rows[0][cuc.sticker12_name].ToString();
            item.sticker13_name = dt.Rows[0][cuc.sticker13_name].ToString();
            item.sticker14_name = dt.Rows[0][cuc.sticker14_name].ToString();
            item.sticker15_name = dt.Rows[0][cuc.sticker15_name].ToString();
            item.sticker16_name = dt.Rows[0][cuc.sticker16_name].ToString();
            item.sticker17_name = dt.Rows[0][cuc.sticker17_name].ToString();
            item.sticker18_name = dt.Rows[0][cuc.sticker18_name].ToString();
            item.sticker19_name = dt.Rows[0][cuc.sticker19_name].ToString();
            item.sticker20_name = dt.Rows[0][cuc.sticker20_name].ToString();
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "", onsite="";
            DataTable dt = new DataTable();
            if (conn.initc.statusonsite.Equals("yes"))
            {
                onsite = " onsite_";
            }
            //MessageBox.Show("onsite " + onsite, "");
            //MessageBox.Show("onsite " + conn.initc.statusonsite, "");
            //MessageBox.Show("ConnectionString " + conn._mainConnection.ConnectionString, "");
            sql = "Select * From " + onsite+cuc.table + " Where " + cuc.Active + "='1' Order By "+cuc.dateCreate+" desc";
            dt = conn.selectData(sql);

            return dt;
        }
        //public DataTable selectCustomerList()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select " + cu.Code + "," + cu.NameT + "," + cu.NameE + " From " + cu.table + " Where " + cu.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        public CustCheckUp selectByPk(String cuId)
        {
            CustCheckUp item = new CustCheckUp();
            String sql = "", onsite="";
            DataTable dt = new DataTable();
            if (conn.initc.statusonsite.Equals("yes"))
            {
                onsite = " onsite_";
            }
            sql = "Select * From " + onsite+cuc.table + " Where " + cuc.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public CustCheckUp selectByPk1(String cuId)
        {
            CustCheckUp item = new CustCheckUp();
            String sql = "", onsite = "";
            DataTable dt = new DataTable();
            if (conn.initc.statusonsite.Equals("yes"))
            {
                onsite = " onsite_";
            }
            sql = "Select * From " + cuc.table + " Where " + cuc.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        //public CustCheckUp selectByCode(String cuId)
        //{
        //    CustCheckUp item = new CustCheckUp();
        //    String sql = "";

        //    sql = "Select * From " + cuc.table + " Where " + cuc.Code + "='" + cuId + "' and " + cuc.Active + "='1' ";
        //    //dt = conn.selectData(sql);
        //    DataTable dt = conn.selectData(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        item = setData(item, conn.dt);
        //    }
        //    return item;
        //}
        private void chkNull(CustCheckUp p)
        {
            p.CheckUpDate = p.CheckUpDate == null ? "" : p.CheckUpDate;
            p.CheckUpEndDate = p.CheckUpEndDate == null ? "" : p.CheckUpEndDate;
            p.CheckUpStartDate = p.CheckUpStartDate == null ? "" : p.CheckUpStartDate;
            p.CommitCheckUpDate = p.CommitCheckUpDate == null ? "" : p.CommitCheckUpDate;
            p.CustId = p.CustId == null ? "" : p.CustId;
            p.CustNameT = p.CustNameT == null ? "" : p.CustNameT;
            p.Description = p.Description == null ? "" : p.Description;
            p.RegisDate = p.RegisDate == null ? "" : p.RegisDate;
            p.Remark = p.Remark == null ? "" : p.Remark;
            p.YearId = p.YearId == null ? "" : p.YearId;

            p.sticker01 = p.sticker01 == null ? "" : p.sticker01;
            p.sticker02 = p.sticker02 == null ? "" : p.sticker02;
            p.sticker03 = p.sticker03 == null ? "" : p.sticker03;
            p.sticker04 = p.sticker04 == null ? "" : p.sticker04;
            p.sticker05 = p.sticker05 == null ? "" : p.sticker05;
            p.sticker06 = p.sticker06 == null ? "" : p.sticker06;
            p.sticker07 = p.sticker07 == null ? "" : p.sticker07;
            p.sticker08 = p.sticker08 == null ? "" : p.sticker08;
            p.sticker09 = p.sticker09 == null ? "" : p.sticker09;
            p.sticker10 = p.sticker10 == null ? "" : p.sticker10;
            p.sticker01_name = p.sticker01_name == null ? "" : p.sticker01_name;
            p.sticker02_name = p.sticker02_name == null ? "" : p.sticker02_name;
            p.sticker03_name = p.sticker03_name == null ? "" : p.sticker03_name;
            p.sticker04_name = p.sticker04_name == null ? "" : p.sticker04_name;
            p.sticker05_name = p.sticker05_name == null ? "" : p.sticker05_name;
            p.sticker06_name = p.sticker06_name == null ? "" : p.sticker06_name;
            p.sticker07_name = p.sticker07_name == null ? "" : p.sticker07_name;
            p.sticker08_name = p.sticker08_name == null ? "" : p.sticker08_name;
            p.sticker09_name = p.sticker09_name == null ? "" : p.sticker09_name;
            p.sticker10_name = p.sticker10_name == null ? "" : p.sticker10_name;
        }
        private String insert(CustCheckUp p)
        {
            String sql = "", chk = "";
            //MessageBox.Show("0000 ", "Error ");
            if (p.Id.Equals(""))
            {
                p.Id = "cuc" + p.getGenID();
            }
            //MessageBox.Show("1111 ", "Error ");
            p.Description = p.Description.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            int chk1 = 0;
            p.sticker = int.TryParse(p.sticker, out chk1) ? chk1.ToString() : "0";

            chkNull(p);
            p.Active = "1";
            sql = "Insert Into " + cuc.table + " (" + cuc.pkField + "," + cuc.Active + "," + cuc.CheckUpDate + "," +
                cuc.CheckUpEndDate + "," + cuc.CheckUpStartDate + "," + cuc.CntEmployee + "," +
                cuc.CommitCheckUpDate + "," + cuc.CustId + "," + cuc.CustNameT + "," +
                cuc.Description + "," + cuc.RegisDate + "," + cuc.Remark + "," +
                cuc.YearId + "," + cuc.dateCreate + "," + cuc.sticker +","+
                cuc.sticker01 + "," + cuc.sticker02 + "," + cuc.sticker03 + "," +
                cuc.sticker04 + "," + cuc.sticker05 + "," + cuc.sticker06 + "," +
                cuc.sticker07 + "," + cuc.sticker08 + "," + cuc.sticker09 + "," +
                cuc.sticker10 + "," + cuc.sticker11 + "," + cuc.sticker12 + "," +
                cuc.sticker13 + "," + cuc.sticker14 + "," + cuc.sticker15 + "," +
                cuc.sticker16 + "," + cuc.sticker17 + "," + cuc.sticker18 + "," +
                cuc.sticker19 + "," + cuc.sticker20 + "," +
                cuc.sticker01_name + "," + cuc.sticker02_name + "," + cuc.sticker03_name + "," +
                cuc.sticker04_name + "," + cuc.sticker05_name + "," + cuc.sticker06_name + "," +
                cuc.sticker07_name + "," + cuc.sticker08_name + "," + cuc.sticker09_name + "," +
                cuc.sticker10_name + "," + cuc.sticker11_name + "," + cuc.sticker12_name + "," +
                cuc.sticker13_name + "," + cuc.sticker14_name + "," + cuc.sticker15_name + "," +
                cuc.sticker16_name + "," + cuc.sticker17_name + "," + cuc.sticker18_name + "," +
                cuc.sticker19_name + "," + cuc.sticker20_name + " " +
                ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.CheckUpDate + "','" +
                p.CheckUpEndDate + "','" + p.CheckUpStartDate + "'," + NumberNull1(p.CntEmployee) + ",'" +
                p.CommitCheckUpDate + "','" + p.CustId + "','" + p.CustNameT + "','" +
                p.Description + "','" + p.RegisDate + "','" + p.Remark + "','" +
                p.YearId + "'," + p.dateGenDB + ",'" + p.sticker + "','" +
                p.sticker01 + "','" + p.sticker02 + "','" + p.sticker03 + "','" +
                p.sticker04 + "','" + p.sticker05 + "','" + p.sticker06 + "','" +
                p.sticker07 + "','" + p.sticker08 + "','" + p.sticker09 + "','" +
                p.sticker10 + "','" + p.sticker11 + "','" + p.sticker12 + "','" +
                p.sticker13 + "','" + p.sticker14 + "','" + p.sticker15 + "','" +
                p.sticker16 + "','" + p.sticker17 + "','" + p.sticker18 + "','" +
                p.sticker19 + "','" + p.sticker20 + "','" +
                p.sticker01_name.Replace("'", "''") + "','" + p.sticker02_name.Replace("'", "''") + "','" + p.sticker03_name.Replace("'", "''") + "','" +
                p.sticker04_name.Replace("'", "''") + "','" + p.sticker05_name.Replace("'", "''") + "','" + p.sticker06_name.Replace("'", "''") + "','" +
                p.sticker07_name.Replace("'", "''") + "','" + p.sticker08_name.Replace("'", "''") + "','" + p.sticker09_name.Replace("'", "''") + "','" +
                p.sticker10_name.Replace("'", "''") + "','" + p.sticker11_name.Replace("'", "''") + "','" + p.sticker12_name.Replace("'", "''") + "','" +
                p.sticker13_name.Replace("'", "''") + "','" + p.sticker14_name.Replace("'", "''") + "','" + p.sticker15_name.Replace("'", "''") + "','" +
                p.sticker16_name.Replace("'", "''") + "','" + p.sticker17_name.Replace("'", "''") + "','" + p.sticker18_name.Replace("'", "''") + "','" +
                p.sticker19_name.Replace("'", "''") + "','" + p.sticker20_name.Replace("'", "''") + "' " +
                " )";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString()+"\n"+sql, "insert CustCheckUp");
            }
            finally
            {
            }
            return chk;
        }
        private String update(CustCheckUp p)
        {
            String sql = "", chk = "";

            p.Description = p.Description.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            int chk1 = 0;
            p.sticker = int.TryParse(p.sticker, out chk1) ? chk1.ToString() : "0";

            sql = "Update " + cuc.table + " Set " + cuc.CheckUpDate + "='" + p.CheckUpDate + "', " +
                cuc.CheckUpEndDate + "='" + p.CheckUpEndDate + "', " +
                cuc.CheckUpStartDate + "='" + p.CheckUpStartDate + "', " +
                cuc.CntEmployee + "=" + NumberNull1(p.CntEmployee) + ", " +
                cuc.CommitCheckUpDate + "='" + p.CommitCheckUpDate + "', " +
                cuc.CustId + "='" + p.CustId + "', " +
                cuc.CustNameT + "='" + p.CustNameT + "', " +
                cuc.Description + "='" + p.Description + "', " +
                cuc.RegisDate + "='" + p.RegisDate + "', " +
                cuc.Remark + "='" + p.Remark + "', " +
                cuc.YearId + "='" + p.YearId + "', " +
                cuc.sticker + "='" + p.sticker + "' " +

                "Where " + cuc.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update CustCheckUp");
            }
            finally
            {
            }
            return chk;
        }
        public String insertCustCheckUp(CustCheckUp p)
        {
            CustCheckUp item = new CustCheckUp();
            String chk = "";
            //MessageBox.Show("1111 ", "Error ");
            item = selectByPk(p.Id);
            //MessageBox.Show("2222 ", "Error ");
            if (item.Id == "")
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
        private String insertOnSite(CustCheckUp p, ConnectDB connonsite)
        {
            String sql = "", chk = "";
            //MessageBox.Show("0000 ", "Error ");
            if (p.Id.Equals(""))
            {
                p.Id = "cuc" + p.getGenID();
            }
            //MessageBox.Show("1111 ", "Error ");
            p.Description = p.Description.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            int chk1 = 0;
            p.sticker = int.TryParse(p.sticker, out chk1) ? chk1.ToString() : "0";

            chkNull(p);
            p.Active = "1";
            sql = "Insert Into onsite_" + cuc.table + " (" + cuc.pkField + "," + cuc.Active + "," + cuc.CheckUpDate + "," +
                cuc.CheckUpEndDate + "," + cuc.CheckUpStartDate + "," + cuc.CntEmployee + "," +
                cuc.CommitCheckUpDate + "," + cuc.CustId + "," + cuc.CustNameT + "," +
                cuc.Description + "," + cuc.RegisDate + "," + cuc.Remark + "," +
                cuc.YearId + "," + cuc.dateCreate + "," + cuc.sticker + "," +
                cuc.sticker01 + "," + cuc.sticker02 + "," + cuc.sticker03 + "," +
                cuc.sticker04 + "," + cuc.sticker05 + "," + cuc.sticker06 + "," +
                cuc.sticker07 + "," + cuc.sticker08 + "," + cuc.sticker09 + "," +
                cuc.sticker10 + "," + cuc.sticker11 + "," + cuc.sticker12 + "," +
                cuc.sticker13 + "," + cuc.sticker14 + "," + cuc.sticker15 + "," +
                cuc.sticker16 + "," + cuc.sticker17 + "," + cuc.sticker18 + "," +
                cuc.sticker19 + "," + cuc.sticker20 + "," +
                cuc.sticker01_name + "," + cuc.sticker02_name + "," + cuc.sticker03_name + "," +
                cuc.sticker04_name + "," + cuc.sticker05_name + "," + cuc.sticker06_name + "," +
                cuc.sticker07_name + "," + cuc.sticker08_name + "," + cuc.sticker09_name + "," +
                cuc.sticker10_name + "," + cuc.sticker11_name + "," + cuc.sticker12_name + "," +
                cuc.sticker13_name + "," + cuc.sticker14_name + "," + cuc.sticker15_name + "," +
                cuc.sticker16_name + "," + cuc.sticker17_name + "," + cuc.sticker18_name + "," +
                cuc.sticker19_name + "," + cuc.sticker20_name + " " +
                ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.CheckUpDate + "','" +
                p.CheckUpEndDate + "','" + p.CheckUpStartDate + "'," + NumberNull1(p.CntEmployee) + ",'" +
                p.CommitCheckUpDate + "','" + p.CustId + "','" + p.CustNameT + "','" +
                p.Description + "','" + p.RegisDate + "','" + p.Remark + "','" +
                p.YearId + "'," + p.dateGenDB + ",'" + p.sticker + "','" +
                p.sticker01 + "','" + p.sticker02 + "','" + p.sticker03 + "','" +
                p.sticker04 + "','" + p.sticker05 + "','" + p.sticker06 + "','" +
                p.sticker07 + "','" + p.sticker08 + "','" + p.sticker09 + "','" +
                p.sticker10 + "','" + p.sticker11 + "','" + p.sticker12 + "','" +
                p.sticker13 + "','" + p.sticker14 + "','" + p.sticker15 + "','" +
                p.sticker16 + "','" + p.sticker17 + "','" + p.sticker18 + "','" +
                p.sticker19 + "','" + p.sticker20 + "','" +
                p.sticker01_name.Replace("'", "''") + "','" + p.sticker02_name.Replace("'", "''") + "','" + p.sticker03_name.Replace("'", "''") + "','" +
                p.sticker04_name.Replace("'", "''") + "','" + p.sticker05_name.Replace("'", "''") + "','" + p.sticker06_name.Replace("'", "''") + "','" +
                p.sticker07_name.Replace("'", "''") + "','" + p.sticker08_name.Replace("'", "''") + "','" + p.sticker09_name.Replace("'", "''") + "','" +
                p.sticker10_name.Replace("'", "''") + "','" + p.sticker11_name.Replace("'", "''") + "','" + p.sticker12_name.Replace("'", "''") + "','" +
                p.sticker13_name.Replace("'", "''") + "','" + p.sticker14_name.Replace("'", "''") + "','" + p.sticker15_name.Replace("'", "''") + "','" +
                p.sticker16_name.Replace("'", "''") + "','" + p.sticker17_name.Replace("'", "''") + "','" + p.sticker18_name.Replace("'", "''") + "','" +
                p.sticker19_name.Replace("'", "''") + "','" + p.sticker20_name.Replace("'", "''") + "' " +
                ")";
            try
            {
                chk = connonsite.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString() + "\n" + sql, "insert CustCheckUp");
            }
            finally
            {
            }
            return chk;
        }
        public String deleteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + cuc.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String deleteOnSiteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From onsite_" + cuc.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String insertToOnSite(String cucId)
        {
            String sql = "", chk = "";
            CustCheckUp cuc1 = new CustCheckUp();
            cuc1 = selectByPk1(cucId);
            sql = "Delete From onsite_" + cuc.table;
            connOnSite = new ConnectDB(conn.initc, ConnectDB.flagOnSite.OnSite);
            //MessageBox.Show("CustNameT " + cuc1.CustNameT, "");
            //MessageBox.Show("hostDBonsite " + conn.initc.hostDBonsite + "\n nameDBonsite " + conn.initc.nameDBonsite + "\n userDBonsite " + conn.initc.userDBonsite + "\n passDBonsite " + conn.initc.passDBonsite, "message ");
            chk = connOnSite.ExecuteNonQuery(sql);
            chk = insertOnSite(cuc1, connOnSite);
            //sql = "insert into "+conn.initc.nameRemoteClient + "." + conn.initc.nameDBonsite + ".dbo." + "onsite_" + cuc.table + " " +
            //    "select * from " + cuc.table +" "+
            //    "Where " + cuc.pkField + "='" + cucId + "'";
            ////MessageBox.Show("SQL " + sql, "message ");
            //chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboCustCheckUp(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();

                item.Text = dt.Rows[0][cuc.CustNameT].ToString() + " " + dt.Rows[0][cuc.YearId].ToString();

                item.Value = dt.Rows[i][cuc.Id].ToString();
                //item.Text = dt.Rows[i][cu.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String UpdateCustCheckUp(String saleId, String date, String year, String sticker)
        {
            String sql = "", chk = "";
            sql = "Update " + cuc.table + " Set " + cuc.CheckUpDate + "='" + date + "', "+cuc.YearId+"='"+year+"',"+cuc.sticker+"='"+sticker+"' " +
                "Where " + cuc.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String VoidCustCheckUp(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + cuc.table + " Set " + cuc.Active + "='3' " +
                "Where " + cuc.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String NumberNull1(String o)
        {
            if (o.Equals(""))
            {
                return "0";
            }
            else
            {
                return o;
            }
        }
        public String updateStickerName(String cucId, String name1, String name2, String name3, String name4, String name5, String name6, String name7, String name8, String name9, String name10
            , String name11, String name12, String name13, String name14, String name15, String name16, String name17, String name18, String name19, String name20)
        {
            String sql = "", chk = "";
            String col1 = "", col2 = "", col3 = "", col4 = "", col5 = "", col6 = "", col7 = "", col8 = "", col9 = "", col10="";
            String col11 = "", col12 = "", col13 = "", col14 = "", col15 = "", col16 = "", col17 = "", col18 = "", col19 = "", col20 = "";
            col1 = !name1.Equals("") ? "," + cuc.sticker01 + "='1' " : "," + cuc.sticker01 + "='0' ";
            col2 = !name2.Equals("") ? "," + cuc.sticker02 + "='1' " : "," + cuc.sticker02 + "='0' ";
            col3 = !name3.Equals("") ? "," + cuc.sticker03 + "='1' " : "," + cuc.sticker03 + "='0' ";
            col4 = !name4.Equals("") ? "," + cuc.sticker04 + "='1' " : "," + cuc.sticker04 + "='0' ";
            col5 = !name5.Equals("") ? "," + cuc.sticker05 + "='1' " : "," + cuc.sticker05 + "='0' ";
            col6 = !name6.Equals("") ? "," + cuc.sticker06 + "='1' " : "," + cuc.sticker06 + "='0' ";
            col7 = !name7.Equals("") ? "," + cuc.sticker07 + "='1' " : "," + cuc.sticker07 + "='0' ";
            col8 = !name8.Equals("") ? "," + cuc.sticker08 + "='1' " : "," + cuc.sticker08 + "='0' ";
            col9 = !name9.Equals("") ? "," + cuc.sticker09 + "='1' " : "," + cuc.sticker09 + "='0' ";
            col10 = !name10.Equals("") ? "," + cuc.sticker10 + "='1' " : "," + cuc.sticker10 + "='0' ";
            col11 = !name11.Equals("") ? "," + cuc.sticker11 + "='1' " : "," + cuc.sticker11 + "='0' ";
            col12 = !name12.Equals("") ? "," + cuc.sticker12 + "='1' " : "," + cuc.sticker12 + "='0' ";
            col13 = !name13.Equals("") ? "," + cuc.sticker13 + "='1' " : "," + cuc.sticker13 + "='0' ";
            col14 = !name14.Equals("") ? "," + cuc.sticker14 + "='1' " : "," + cuc.sticker14 + "='0' ";
            col15 = !name15.Equals("") ? "," + cuc.sticker15 + "='1' " : "," + cuc.sticker15 + "='0' ";
            col16 = !name16.Equals("") ? "," + cuc.sticker16 + "='1' " : "," + cuc.sticker16 + "='0' ";
            col17 = !name17.Equals("") ? "," + cuc.sticker17 + "='1' " : "," + cuc.sticker17 + "='0' ";
            col18 = !name18.Equals("") ? "," + cuc.sticker18 + "='1' " : "," + cuc.sticker18 + "='0' ";
            col19 = !name19.Equals("") ? "," + cuc.sticker19 + "='1' " : "," + cuc.sticker19 + "='0' ";
            col20 = !name20.Equals("") ? "," + cuc.sticker20 + "='1' " : "," + cuc.sticker20 + "='0' ";

            sql = "Update " + cuc.table + " Set " + cuc.sticker01_name + "='" + name1.Replace("'","''") + "' " + col1 +
                "," + cuc.sticker02_name + "='" + name2.Replace("'", "''") + "' " + col2 +
                "," + cuc.sticker03_name + "='" + name3.Replace("'", "''") + "' " + col3 +
                "," + cuc.sticker04_name + "='" + name4.Replace("'", "''") + "' " + col4 +
                "," + cuc.sticker05_name + "='" + name5.Replace("'", "''") + "' " + col5 +
                "," + cuc.sticker06_name + "='" + name6.Replace("'", "''") + "' " + col6 +
                "," + cuc.sticker07_name + "='" + name7.Replace("'", "''") + "' " + col7 +
                "," + cuc.sticker08_name + "='" + name8.Replace("'", "''") + "' " + col8 +
                "," + cuc.sticker09_name + "='" + name9.Replace("'", "''") + "' " + col9 +
                "," + cuc.sticker10_name + "='" + name10.Replace("'", "''") + "' " + col10 +
                "," + cuc.sticker11_name + "='" + name11.Replace("'", "''") + "' " + col11 +
                "," + cuc.sticker12_name + "='" + name12.Replace("'", "''") + "' " + col12 +
                "," + cuc.sticker13_name + "='" + name13.Replace("'", "''") + "' " + col13 +
                "," + cuc.sticker14_name + "='" + name14.Replace("'", "''") + "' " + col14 +
                "," + cuc.sticker15_name + "='" + name15.Replace("'", "''") + "' " + col15 +
                "," + cuc.sticker16_name + "='" + name16.Replace("'", "''") + "' " + col16 +
                "," + cuc.sticker17_name + "='" + name17.Replace("'", "''") + "' " + col17 +
                "," + cuc.sticker18_name + "='" + name18.Replace("'", "''") + "' " + col18 +
                "," + cuc.sticker19_name + "='" + name19.Replace("'", "''") + "' " + col19 +
                "," + cuc.sticker20_name + "='" + name20.Replace("'", "''") + "' " + col20 +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                //MessageBox.Show("chk " + chk+"\n sql"+sql, "");
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
        public String updatePE(String cucId, String PEAbNormal, String PECnt, String PENormal, String pecheckup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.PEAbNormal + "=" + PEAbNormal + ", " +
                cuc.PECnt + "=" + PECnt + ", " +
                cuc.PENormal + "=" + PENormal + " " +
                ","+cuc.pe_checkup + "='" + pecheckup + "' " +
                "," + cuc.pe_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateXray(String cucId, String XrayAbNormal, String XrayCnt, String XrayNormal, String xraycheckup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.XrayAbNormal + "=" + XrayAbNormal + ", " +
                cuc.XrayCnt + "=" + XrayCnt + ", " +
                cuc.XrayNormal + "=" + XrayNormal + " " +
                "," + cuc.xray_checkup + "='" + xraycheckup + "' " +
                "," + cuc.xray_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateFBS(String cucId, String FBSAbNormal, String FBSCnt, String FBSNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.FBSAbNormal + "=" + FBSAbNormal + ", " +
                cuc.FBSCnt + "=" + FBSCnt + ", " +
                cuc.FBSNormal + "=" + FBSNormal + " " +
                "," + cuc.fbs_checkup + "='" + checkup + "' " +
                "," + cuc.fbs_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateCBC(String cucId, String CBCAbNormal, String CBCSCnt, String CBCNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.CBCAbNormal + "=" + CBCAbNormal + ", " +
                cuc.CBCCnt + "=" + CBCSCnt + ", " +
                cuc.CBCNormal + "=" + CBCNormal + " " +
                "," + cuc.cbc_checkup + "='" + checkup + "' " +
                "," + cuc.cbc_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateUA(String cucId, String UAAbNormal, String UACnt, String UANormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.UAAbNormal + "=" + UAAbNormal + ", " +
                cuc.UACnt + "=" + UACnt + ", " +
                cuc.UANormal + "=" + UANormal + " " +
                "," + cuc.ua_checkup + "='" + checkup + "' " +
                "," + cuc.ua_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateTri(String cucId, String TriAbNormal, String TriCnt, String TriNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.TriAbNormal + "=" + TriAbNormal + ", " +
                cuc.TriCnt + "=" + TriCnt + ", " +
                cuc.TriNormal + "=" + TriNormal + " " +
                "," + cuc.tri_checkup + "='" + checkup + "' " +
                "," + cuc.tri_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateTri");
            }
            finally
            {
            }
            return chk;
        }
        public String updateCho(String cucId, String ChoAbNormal, String ChoCnt, String ChoNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.ChoAbNormal + "=" + ChoAbNormal + ", " +
                cuc.ChoCnt + "=" + ChoCnt + ", " +
                cuc.ChoNormal + "=" + ChoNormal + " " +
                "," + cuc.cho_checkup + "='" + checkup + "' " +
                "," + cuc.cho_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateCho");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSgot(String cucId, String SgotAbNormal, String SgotCnt, String SgotNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.SgotAbNormal + "=" + SgotAbNormal + ", " +
                cuc.SgotCnt + "=" + SgotCnt + ", " +
                cuc.SgotNormal + "=" + SgotNormal + " " +
                "," + cuc.sgot_checkup + "='" + checkup + "' " +
                "," + cuc.sgot_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateBun(String cucId, String BunAbNormal, String BunCnt, String BunNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.BunAbNormal + "=" + BunAbNormal + ", " +
                cuc.BunCnt + "=" + BunCnt + ", " +
                cuc.BunNormal + "=" + BunNormal + " " +
                "," + cuc.bun_checkup + "='" + checkup + "' " +
                "," + cuc.bun_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateUric(String cucId, String UricAbNormal, String UricCnt, String UricNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.UricAbNormal + "=" + UricAbNormal + ", " +
                cuc.UricCnt + "=" + UricCnt + ", " +
                cuc.UricNormal + "=" + UricNormal + " " +
                "," + cuc.uric_checkup + "='" + checkup + "' " +
                "," + cuc.uric_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateOther1(String cucId, String Other1AbNormal, String Other1Cnt, String Other1Normal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.Other1AbNormal + "=" + Other1AbNormal + ", " +
                cuc.Other1Cnt + "=" + Other1Cnt + ", " +
                cuc.Other1Normal + "=" + Other1Normal + " " +
                "," + cuc.other1_checkup + "='" + checkup + "' " +
                "," + cuc.other1_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateLung(String cucId, String LungAbNormal, String LungCnt, String LungNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.LungAbNormal + "=" + LungAbNormal + ", " +
                cuc.LungCnt + "=" + LungCnt + ", " +
                cuc.LungNormal + "=" + LungNormal + " " +
                "," + cuc.lung_checkup + "='" + checkup + "' " +
                "," + cuc.lung_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateAudio(String cucId, String AudioAbNormal, String AudioCnt, String AudioNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.AudioAbNormal + "=" + AudioAbNormal + ", " +
                cuc.AudioCnt + "=" + AudioCnt + ", " +
                cuc.AudioNormal + "=" + AudioNormal + " " +
                "," + cuc.audio_checkup + "='" + checkup + "' " +
                "," + cuc.audio_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateAudio");
            }
            finally
            {
            }
            return chk;
        }
        public String updateEye(String cucId, String EyeAbNormal, String EyeCnt, String EyeNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.EyeAbNormal + "=" + EyeAbNormal + ", " +
                cuc.EyeCnt + "=" + EyeCnt + ", " +
                cuc.EyeNormal + "=" + EyeNormal + " " +
                "," + cuc.eye_checkup + "='" + checkup + "' " +
                "," + cuc.eye_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateToxi(String cucId, String ToxiAbNormal, String ToxiCnt, String ToxiNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.ToxiAbNormal + "=" + ToxiAbNormal + ", " +
                cuc.ToxiCnt + "=" + ToxiCnt + ", " +
                cuc.ToxiNormal + "=" + ToxiNormal + " " +
                "," + cuc.toxi_checkup + "='" + checkup + "' " +
                "," + cuc.toxi_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateStoolExam(String cucId, String StoolExamAbNormal, String StoolExamCnt, String StoolExamNormal, String checkup, String test)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.StoolExamAbNormal + "=" + StoolExamAbNormal + ", " +
                cuc.StoolExamCnt + "=" + StoolExamCnt + ", " +
                cuc.StoolExamNormal + "=" + StoolExamNormal + " " +
                "," + cuc.stoolexam_checkup + "='" + checkup + "' " +
                "," + cuc.stoolexam_test + "='" + test + "' " +
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updateCntImport(String cucId, int cntEmp, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.CntEmployee + "=" + cntEmp + ", " +
                cuc.CntSuccess + "=" + row + " " +
                
                "Where " + cuc.pkField + "='" + cucId + "'";
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
        public String updatePEImport(String cucId, int cntEmp, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.PECnt + "=" + cntEmp + ", " +
                cuc.PESuccess + "=" + row + ", " +
                cuc.PENormal + "=" + normal + ", " +
                cuc.PEAbNormal + "=" + (row - normal) + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updatePEImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateXrayImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.XrayCnt + "=" + cnt + ", " +
                cuc.XraySuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateXrayImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateCBCImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.CBCCnt + "=" + cnt + ", " +
                cuc.CBCSuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateCBCImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateFBSImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.FBSCnt + "=" + cnt + ", " +
                cuc.FBSSuccess + "=" + row + ", " +
                cuc.FBSNormal + "=" + normal + ", " +
                cuc.FBSAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateFBSImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateUAImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.UACnt + "=" + cnt + ", " +
                cuc.UASuccess + "=" + row + ", " +
                cuc.UANormal + "=" + normal + ", " +
                cuc.UAAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateUAImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateTriImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.TriCnt + "=" + cnt + ", " +
                cuc.TriSuccess + "=" + row + ", " +
                cuc.TriNormal + "=" + normal + ", " +
                cuc.TriAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateTriImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateChoImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.ChoCnt + "=" + cnt + ", " +
                cuc.ChoSuccess + "=" + row + ", " +
                cuc.ChoNormal + "=" + normal + ", " +
                cuc.ChoAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateChoImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateSgotImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.SgotCnt + "=" + cnt + ", " +
                cuc.SgotSuccess + "=" + row + ", " +
                cuc.SgotNormal + "=" + normal + ", " +
                cuc.SgotAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateSgotImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateBunImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.BunCnt + "=" + cnt + ", " +
                cuc.BunSuccess + "=" + row + ", " +
                cuc.BunNormal + "=" + normal + ", " +
                cuc.BunAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateBunImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateUricImport(String cucId, int cnt, int row, int normal)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.UricCnt + "=" + cnt + ", " +
                cuc.UricSuccess + "=" + row + ", " +
                cuc.UricNormal + "=" + normal + ", " +
                cuc.UricAbNormal + "=" + (row - normal) + " " +
                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateUricImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateOther1Import(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.Other1Cnt + "=" + cnt + ", " +
                cuc.Other1Success + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateOther1Import");
            }
            finally
            {
            }
            return chk;
        }
        public String updateLungImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.LungCnt + "=" + cnt + ", " +
                cuc.LungSuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateLungImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateAudioImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.AudioCnt + "=" + cnt + ", " +
                cuc.AudioSuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateAudioImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateEyeImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.EyeCnt + "=" + cnt + ", " +
                cuc.EyeSuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateEyeImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateStoolExamImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.StoolExamCnt + "=" + cnt + ", " +
                cuc.StoolExamSuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateStoolExamImport");
            }
            finally
            {
            }
            return chk;
        }
        public String updateToxiImport(String cucId, int cnt, int row)
        {
            String sql = "", chk = "";

            //p.Description = p.Description.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + cuc.table + " Set " + cuc.ToxiCnt + "=" + cnt + ", " +
                cuc.ToxiSuccess + "=" + row + " " +

                "Where " + cuc.pkField + "='" + cucId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update updateToxiImport");
            }
            finally
            {
            }
            return chk;
        }
        public String UpdateCustNameT(String cuId, String name)
        {
            String sql = "", chk = "";
            sql = "Update " + cuc.table + " Set " + cuc.CustNameT + "='" + name + "' " +
                "Where " + cuc.CustId + "='" + cuId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String UpdateSticker(String cuId, String code, String prn)
        {
            String sql = "", chk = "";
            if (code.Equals("01"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker01 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("02"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker02 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("03"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker03 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("04"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker04 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("05"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker05 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("06"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker06 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("07"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker07 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("08"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker08 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("09"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker09 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("10"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker10 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("11"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker11 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("12"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker12 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("13"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker13 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("14"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker14 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("15"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker15 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("16"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker16 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("17"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker17 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("18"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker18 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("19"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker19 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            else if (code.Equals("20"))
            {
                sql = "Update " + cuc.table + " Set " + cuc.sticker20 + "='" + prn + "' " +
                "Where " + cuc.pkField + "='" + cuId + "'";
            }
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboStickerr(ComboBox c, String cucId)
        {
            ComboBoxItem item = new ComboBoxItem();
            CustCheckUp cuc = selectByPk(cucId);
            //String aaa = "";

            c.Items.Clear();
            if (!cuc.sticker01_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "01";
                item.Text = cuc.sticker01_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker02_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "02";
                item.Text = cuc.sticker02_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker01_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "01";
                item.Text = cuc.sticker01_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker03_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "03";
                item.Text = cuc.sticker03_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker04_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "04";
                item.Text = cuc.sticker04_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker05_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "05";
                item.Text = cuc.sticker05_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker06_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "06";
                item.Text = cuc.sticker06_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker07_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "07";
                item.Text = cuc.sticker07_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker08_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "08";
                item.Text = cuc.sticker08_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker09_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "09";
                item.Text = cuc.sticker09_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker10_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "10";
                item.Text = cuc.sticker10_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker11_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "11";
                item.Text = cuc.sticker11_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker12_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "12";
                item.Text = cuc.sticker12_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker13_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "13";
                item.Text = cuc.sticker13_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker14_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "14";
                item.Text = cuc.sticker14_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker15_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "15";
                item.Text = cuc.sticker15_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker16_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "16";
                item.Text = cuc.sticker16_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker17_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "17";
                item.Text = cuc.sticker17_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker18_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "18";
                item.Text = cuc.sticker18_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker19_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "19";
                item.Text = cuc.sticker19_name;
                c.Items.Add(item);
            }
            if (!cuc.sticker20_name.Equals(""))
            {
                item = new ComboBoxItem();
                item.Value = "20";
                item.Text = cuc.sticker20_name;
                c.Items.Add(item);
            }
            return c;
        }
    }
}
