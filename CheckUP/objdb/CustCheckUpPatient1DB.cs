using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.objdb
{
    public class CustCheckUpPatient1DB
    {
        ConnectDB conn;
        public CustCheckUpPatient1 ccp1;
        LogWriter lw;
        public CustCheckUpPatient1DB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            lw = new LogWriter();
            ccp1 = new CustCheckUpPatient1();
            ccp1.CustCheckUpId = "cust_checkup_patient_id";
            ccp1.rowNumber = "row_number";
            ccp1.patientFullname = "patient_fullname";
            ccp1.CA125 = "ca_125";
            ccp1.CA125Result = "ca_125_result";
            ccp1.CA125Summary = "ca_125_summary";
            ccp1.CA153 = "ca_153";
            ccp1.CA153Result = "ca_153_result";
            ccp1.CA153Summary = "ca_153_summary";
            ccp1.CA199 = "ca_19_9";
            ccp1.CA199Result = "ca_19_9_result";
            ccp1.CA199Summary = "ca_19_9_summary";
            ccp1.CAAFP = "ca_afp";
            ccp1.CAAFPResult = "ca_afp_result";
            ccp1.CAAFPSummary = "ca_afp_summary";
            ccp1.CACEA = "ca_cea";
            ccp1.CACEAResult = "ca_cea_result";
            ccp1.CACEASummary = "ca_cea_summary";
            ccp1.CAHCG = "ca_hcg";
            ccp1.CAHCGResult = "ca_hcg_result";
            ccp1.CAHCGSummary = "ca_hcg_summary";
            ccp1.CAPSA = "ca_psa";
            ccp1.CAPSAResult = "ca_psa_result";
            ccp1.CAPSASummary = "ca_psa_summary";

            ccp1.AntiHav = "anti_hav";
            ccp1.antiHbc = "anti_hbc";
            ccp1.antiHiv = "anti_hiv";
            ccp1.hbsab = "hbsab";
            ccp1.hbsabResult = "hbsab_result";
            ccp1.hbsabSummary = "hbsab_summary";
            ccp1.hbsag = "hbsag";
            ccp1.hbsagResult = "hbsag_result";
            ccp1.hbsagSummary = "hbsag_summary";
            ccp1.hbtyping = "hbtyping";
            ccp1.vdrl = "vdrl";
            ccp1.amphetamine = "amphetamine";
            ccp1.calcium = "calcium";
            ccp1.Id = "patient_id";
            ccp1.Active = "cust_checkup_patient_active";

            ccp1.table = "t_cust_checkup_patient1";
            
        }
        public String UpdateOther1(String rowNumber, String cucId, String HBsAg, String HbsAb, String AntiHIV, String VDRL, String Amphetamine, String Calcium, String AntiHav,
            String CAAFP, String CAAFPResult, String CAAFPSummary, String CACEA, String CACEAResult, String CACEASummary, String CAPSA, String CAPSAResult, String CAPSASummary,
            String CAHCG, String CAHCGResult, String CAHCGSummary, String CA153, String CA153Result, String CA153Summary, String CA125, String CA125Result, String CA125Summary,
            String CA199, String CA199Result, String CA199Summary, String HBsAgResult,
            String HBsAgSummary, String HbsAbResult, String HbsAbSummary)
        {
            String chk = "", sql = "";
            try
            {
                sql = "Update " + ccp1.table + " Set " + ccp1.hbsag + "='" + HBsAg + "'," +
                ccp1.hbsab + "='" + HbsAb + "', " +
                ccp1.antiHiv + "='" + AntiHIV + "', " +
                ccp1.vdrl + "='" + VDRL + "', " +
                ccp1.amphetamine + "='" + Amphetamine + "', " +
                ccp1.calcium + "='" + Calcium + "', " +
                ccp1.AntiHav + "='" + AntiHav + "', " +
                ccp1.CAAFP + "='" + CAAFP + "', " +
                ccp1.CAAFPResult + "='" + CAAFPResult + "', " +
                ccp1.CAAFPSummary + "='" + CAAFPSummary + "', " +
                ccp1.CACEA + "='" + CACEA + "', " +
                ccp1.CACEAResult + "='" + CACEAResult + "', " +
                ccp1.CACEASummary + "='" + CACEASummary + "', " +
                ccp1.CAPSA + "='" + CAPSA + "', " +
                ccp1.CAPSAResult + "='" + CAPSAResult + "', " +
                ccp1.CAPSASummary + "='" + CAPSASummary + "', " +
                ccp1.CAHCG + "='" + CAHCG + "', " +
                ccp1.CAHCGResult + "='" + CAHCGResult + "', " +
                ccp1.CAHCGSummary + "='" + CAHCGSummary + "', " +
                ccp1.CA153 + "='" + CA153 + "', " +
                ccp1.CA153Result + "='" + CA153Result + "', " +
                ccp1.CA153Summary + "='" + CA153Summary + "', " +
                ccp1.CA125 + "='" + CA125 + "', " +
                ccp1.CA125Result + "='" + CA125Result + "', " +
                ccp1.CA125Summary + "='" + CA125Summary + "', " +
                ccp1.CA199 + "='" + CA199 + "', " +
                ccp1.CA199Result + "='" + CA199Result + "', " +
                ccp1.CA199Summary + "='" + CA199Summary + "', " +
                ccp1.hbsagResult + "='" + HBsAgResult + "', " +
                ccp1.hbsagSummary + "='" + HBsAgSummary + "', " +
                ccp1.hbsabResult + "='" + HbsAbResult + "', " +
                ccp1.hbsabSummary + "='" + HbsAbSummary + "' " +
                "Where " + ccp1.CustCheckUpId + "='" + cucId + "' and " + ccp1.rowNumber + "=" + rowNumber + " ";
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            return chk;
        }
    }
}
