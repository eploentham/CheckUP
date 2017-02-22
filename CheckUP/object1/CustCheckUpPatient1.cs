using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    /**
     * เป็น Class ที่ต้องทำเพิ่ม เพราะจำนวน Column ของ Table มีมากเกินไป
     **/
    public class CustCheckUpPatient1:Persistent
    {
        public String Id = "", CAAFP = "", CAAFPResult = "", CAAFPSummary = "", CACEA = "", CACEAResult = "", CACEASummary = "", CAPSA = "", CAPSAResult = "", CAPSASummary = "", CAHCG = "", CAHCGResult = "", CAHCGSummary = "";
        public String CA153 = "", CA153Result = "", CA153Summary = "", CA125 = "", CA125Result = "", CA125Summary = "", CA199 = "", CA199Result = "", CA199Summary = "";

        public String AmphetamineSummary = "";

        public String vdrl = "", antiHiv = "", hbsag = "", hbsab = "", antiHbc = "", hbtyping = "", AntiHav = "", hbsagResult = "", hbsagSummary = "", hbsabResult = "", hbsabSummary = "", amphetamine = "",calcium="";
        public String CustCheckUpId = "", rowNumber = "", Active = "", patientFullname = "", AntiHavSummary="";
    }
}
