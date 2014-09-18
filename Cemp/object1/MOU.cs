using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class MOU:Persistent
    {
        public String Id = "", MOUNumber = "", CompId = "", CompName = "", Active = "", Remark = "", CompAddress1 = "", CompAddress2 = "", CompTaxId = "";
        public String QuoId = "", QuoNumber = "", CustName = "", Line1 = "", ContactName = "", CustAddress = "", CustTel = "", CustFax = "", CustEmail = "", CustMobile = "";
        public String DatePeriod = "", StaffQuoId = "", StaffQuoName = "", StaffMOUTel = "", StaffMOUEmail = "", StaffMOUName = "", CustMou = "", MOUNumberCnt="";
        public String statusMOU = "", CustId="", StaffMOUMobile="", StaffMOUId="", CustMOUId="", StaffPlaceRecordId="", StaffPlaceRecordName="", StaffAnalysisId="", StaffAnalysisName="";
        public String dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "", DatePlaceRecord = "", StaffPlaceRecordPosition="", StatusReceiveSample="";
        public override string ToString()
        {
            return MOUNumber;
        }
    }
}
