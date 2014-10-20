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

            ei.Cholesteral = "cho_value";
            ei.ChoNo = "cho_no";
            ei.ChoResult = "cho_result";
            ei.ChoRow = "cho_row";
            ei.Chosummary = "cho_summary";

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

            ei.pkField = "id";
            ei.table = "b_excel_init";
        }
        private ExcelInit setData(ExcelInit item, DataTable dt)
        {
            item.Id = dt.Rows[0][ei.Id].ToString();
            item.Bun = dt.Rows[0][ei.Bun].ToString();
            item.BunCreatinine = dt.Rows[0][ei.BunCreatinine].ToString();
            item.BunNo = dt.Rows[0][ei.BunNo].ToString();
            item.BunResult = dt.Rows[0][ei.BunResult].ToString();
            item.BunRow = dt.Rows[0][ei.BunRow].ToString();
            item.BunSummary = dt.Rows[0][ei.BunSummary].ToString();

            item.CBCBact = dt.Rows[0][ei.CBCBact].ToString();
            item.CBCEos = dt.Rows[0][ei.CBCEos].ToString();
            item.CBCHb = dt.Rows[0][ei.CBCHb].ToString();
            item.CBCHct = dt.Rows[0][ei.CBCHct].ToString();
            item.CBCLy = dt.Rows[0][ei.CBCLy].ToString();
            item.CBCMono = dt.Rows[0][ei.CBCMono].ToString();
            item.CBCNeu = dt.Rows[0][ei.CBCNeu].ToString();
            item.CBCNo = dt.Rows[0][ei.CBCNo].ToString();
            item.CBCPltC = dt.Rows[0][ei.CBCPltC].ToString();
            item.CBCPltS = dt.Rows[0][ei.CBCPltS].ToString();
            item.CBCRBC = dt.Rows[0][ei.CBCRBC].ToString();
            item.CBCRBCmono = dt.Rows[0][ei.CBCRBCmono].ToString();
            item.CBCRow = dt.Rows[0][ei.CBCRow].ToString();
            item.CBCSummary = dt.Rows[0][ei.CBCSummary].ToString();
            item.CBCWBC = dt.Rows[0][ei.CBCWBC].ToString();

            item.Cholesteral = dt.Rows[0][ei.Cholesteral].ToString();
            item.ChoNo = dt.Rows[0][ei.ChoNo].ToString();
            item.ChoResult = dt.Rows[0][ei.ChoResult].ToString();
            item.ChoRow = dt.Rows[0][ei.ChoRow].ToString();
            item.Chosummary = dt.Rows[0][ei.Chosummary].ToString();

            item.FBS = dt.Rows[0][ei.FBS].ToString();
            item.FBSNo = dt.Rows[0][ei.FBSNo].ToString();
            item.FBSResult = dt.Rows[0][ei.FBSResult].ToString();
            item.FBSRow = dt.Rows[0][ei.FBSRow].ToString();
            item.FBSSummary = dt.Rows[0][ei.FBSSummary].ToString();

            item.PEAge = dt.Rows[0][ei.PEAge].ToString();
            item.PEBMI = dt.Rows[0][ei.PEBMI].ToString();
            item.PEHeight = dt.Rows[0][ei.PEHeight].ToString();
            item.PENo = dt.Rows[0][ei.PENo].ToString();
            item.PEPulse = dt.Rows[0][ei.PEPulse].ToString();
            item.PEResult = dt.Rows[0][ei.PEResult].ToString();
            item.PERow = dt.Rows[0][ei.PERow].ToString();
            item.PESummary = dt.Rows[0][ei.PESummary].ToString();
            item.PEVitalSign = dt.Rows[0][ei.PEVitalSign].ToString();
            item.PEWeight = dt.Rows[0][ei.PEWeight].ToString();

            item.SfAAge = dt.Rows[0][ei.SfAAge].ToString();
            item.SfAFirstName = dt.Rows[0][ei.SfAFirstName].ToString();
            item.SfALastName = dt.Rows[0][ei.SfALastName].ToString();
            item.SfANo = dt.Rows[0][ei.SfANo].ToString();
            item.SfAPrefix = dt.Rows[0][ei.SfAPrefix].ToString();
            item.SfBAge = dt.Rows[0][ei.SfBAge].ToString();
            item.SfBFullName = dt.Rows[0][ei.SfBFullName].ToString();
            item.SfBNo = dt.Rows[0][ei.SfBNo].ToString();
            item.SfBPrefix = dt.Rows[0][ei.SfBPrefix].ToString();
            item.SfCAge = dt.Rows[0][ei.SfCAge].ToString();
            item.SfCFullName = dt.Rows[0][ei.SfCFullName].ToString();
            item.SfCNo = dt.Rows[0][ei.SfCNo].ToString();
            item.SfRow = dt.Rows[0][ei.SfRow].ToString();
            item.SfStatusName = dt.Rows[0][ei.SfStatusName].ToString();

            item.Sgot = dt.Rows[0][ei.Sgot].ToString();
            item.SgotNo = dt.Rows[0][ei.SgotNo].ToString();
            item.SgotResult = dt.Rows[0][ei.SgotResult].ToString();
            item.SgotRow = dt.Rows[0][ei.SgotRow].ToString();
            item.Sgpt = dt.Rows[0][ei.Sgpt].ToString();
            item.SgptSummary = dt.Rows[0][ei.SgptSummary].ToString();

            item.Triglyceride = dt.Rows[0][ei.Triglyceride].ToString();
            item.TriNo = dt.Rows[0][ei.TriNo].ToString();
            item.TriResult = dt.Rows[0][ei.TriResult].ToString();
            item.TriRow = dt.Rows[0][ei.TriRow].ToString();
            item.TriSummary = dt.Rows[0][ei.TriSummary].ToString();

            item.UAAppe = dt.Rows[0][ei.UAAppe].ToString();
            item.UABact = dt.Rows[0][ei.UABact].ToString();
            item.UAColor = dt.Rows[0][ei.UAColor].ToString();
            item.UAEpi = dt.Rows[0][ei.UAEpi].ToString();
            item.UANo = dt.Rows[0][ei.UANo].ToString();
            item.UApH = dt.Rows[0][ei.UApH].ToString();
            item.UAProtein = dt.Rows[0][ei.UAProtein].ToString();
            item.UARBC = dt.Rows[0][ei.UARBC].ToString();
            item.UAResult = dt.Rows[0][ei.UAResult].ToString();
            item.UARow = dt.Rows[0][ei.UARow].ToString();
            item.UASpgr = dt.Rows[0][ei.UASpgr].ToString();
            item.UASugar = dt.Rows[0][ei.UASugar].ToString();
            item.UASummary = dt.Rows[0][ei.UASummary].ToString();
            item.UAWBC = dt.Rows[0][ei.UAWBC].ToString();

            item.UricAcid = dt.Rows[0][ei.UricAcid].ToString();
            item.UricNo = dt.Rows[0][ei.UricNo].ToString();
            item.UricResult = dt.Rows[0][ei.UricResult].ToString();
            item.UricRow = dt.Rows[0][ei.UricRow].ToString();
            item.UricSummary = dt.Rows[0][ei.UricSummary].ToString();

            item.Xray = dt.Rows[0][ei.Xray].ToString();
            item.XrayNo = dt.Rows[0][ei.XrayNo].ToString();
            item.XrayRow = dt.Rows[0][ei.XrayRow].ToString();
            item.XraySummary = dt.Rows[0][ei.XraySummary].ToString();

            item.Active = dt.Rows[0][ei.Active].ToString();
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
        public String updateBun(String bunValue, String bunCreatinine, String bunNo, String bunResult, String bunRow, String bunSummary)
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
            String CBCNeu, String CBCNo, String CBCPltC, String CBCPltS, String CBCRBC, String CBCRBCmono, String CBCRow, String CBCSummary, String CBCWBC)
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
                ei.CBCWBC + "='" + CBCWBC + "' " ;
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
        public String updateCholes(String id, String Cholesteral, String ChoNo, String ChoResult, String ChoRow, String Chosummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.Cholesteral + "='" + Cholesteral + "', " +
                ei.ChoNo + "='" + ChoNo + "', " +
                ei.ChoResult + "='" + ChoResult + "', " +
                ei.ChoRow + "='" + ChoRow + "', " +
                ei.Chosummary + "='" + Chosummary + "' " +
                //ei.BunSummary + "='" + bunSummary + "' " +
                "Where " + ei.pkField + "='" + id + "'";
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
        public String updatePE( String PENo, String PERow, String PEAge, String PEBMI, String PEHeight, String PEWeight,  String PEPulse, String PEVitalSign, String PEResult,
             String PESummary)
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
                ei.PEWeight + "='" + PEWeight + "' " ;
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
        public String updateSfA(String SfAAge, String SfAPrefix, String SfAFirstName, String SfALastName, String SfANo, String SfRow)
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
                //ei.SfBAge + "='" + SfBAge + "', " +
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
        public String updateSfB(String SfBAge, String SfBPrefix, String SfBFullName, String SfBNo, String SfRow)
        {
            String sql = "", chk = "";
            
            sql = "Update " + ei.table + " Set " + ei.SfBAge + "='" + SfBAge + "', " +
                ei.SfBFullName + "='" + SfBFullName + "', " +
                ei.SfBNo + "='" + SfBNo + "', " +
                ei.SfBPrefix + "='" + SfBPrefix + "', " +
                ei.SfRow + "='" + SfRow + "', " +
                ei.SfStatusName + "='B' ";

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
        public String updateSfC(String SfCAge, String SfCAllName, String SfCNo, String SfRow)
        {
            String sql = "", chk = "";
            
            sql = "Update " + ei.table + " Set " + ei.SfCAge + "='" + SfCAge + "', " +
                ei.SfCFullName + "='" + SfCAllName + "', " +
                ei.SfCNo + "='" + SfCNo + "', " +
                ////ei.SfAPrefix + "='" + SfBPrefix + "', " +
                ei.SfRow + "='" + SfRow + "', " +
                ei.SfStatusName + "='C' ";

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
        public String updateUric(String id, String UricAcid, String UricNo, String UricResult, String UricRow, String UricSummary)
        {
            String sql = "", chk = "";

            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + ei.table + " Set " + ei.UricAcid + "='" + UricAcid + "', " +
                ei.UricNo + "='" + UricNo + "', " +
                ei.UricResult + "='" + UricResult + "', " +
                ei.UricRow + "='" + UricRow + "', " +
                ei.UricSummary + "='" + UricSummary + "' " +
                //ei.SgptSummary + "='" + SgptSummary + "' " +
                "Where " + ei.pkField + "='" + id + "'";
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
    }
}
