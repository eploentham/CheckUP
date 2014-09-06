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
        public String DatePeriod = "", StaffId = "", StaffName = "", StaffTel = "", StaffEmail = "", StaffMOU = "", CustMou = "", MOUNumberCnt="";
        public String statusMOU = "", CustId="", StaffMobile="";
        public override string ToString()
        {
            return MOUNumber;
        }
    }
}
