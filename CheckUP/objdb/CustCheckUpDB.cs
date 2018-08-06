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
        ConnectDB conn;
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

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cuc.table + " Where " + cuc.Active + "='1' Order By "+cuc.dateCreate+" desc";
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
            String sql = "";
            DataTable dt = new DataTable();
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
        private String insert(CustCheckUp p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "cuc" + p.getGenID();
            }

            p.Description = p.Description.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");


            sql = "Insert Into " + cuc.table + " (" + cuc.pkField + "," + cuc.Active + "," + cuc.CheckUpDate + "," +
                cuc.CheckUpEndDate + "," + cuc.CheckUpStartDate + "," + cuc.CntEmployee + "," +
                cuc.CommitCheckUpDate + "," + cuc.CustId + "," + cuc.CustNameT + "," +
                cuc.Description + "," + cuc.RegisDate + "," + cuc.Remark + "," +
                cuc.YearId + "," + cuc.dateCreate + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.CheckUpDate + "','" +
                p.CheckUpEndDate + "','" + p.CheckUpStartDate + "'," + NumberNull1(p.CntEmployee) + ",'" +
                p.CommitCheckUpDate + "','" + p.CustId + "','" + p.CustNameT + "','" +
                p.Description + "','" + p.RegisDate + "','" + p.Remark + "','" +
                p.YearId + "'," + p.dateGenDB + ")";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert CustCheckUp");
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
                cuc.YearId + "='" + p.YearId + "' " +
                

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
            item = selectByPk(p.Id);
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
        public String deleteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + cuc.table;
            chk = conn.ExecuteNonQuery(sql);
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
        public String UpdateCustCheckUp(String saleId, String date, String year)
        {
            String sql = "", chk = "";
            sql = "Update " + cuc.table + " Set " + cuc.CheckUpDate + "='" + date + "', "+cuc.YearId+"='"+year+"' " +
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

    }
}
