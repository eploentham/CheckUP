using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class PO:Persistent
    {
        public String Id = "", PONumber = "", CpId = "", CpNameT = "", PODate = "", PODuePeriod = "", Active = "", ContactName = "", CuId = "", CuNameT = "", CuTel = "";
        public String CuFax = "", CuEmail = "", SfId = "", SfEmail = "", SfName = "", SfTel = "", QuId = "", QuNumber = "", UserCreate = "", UserModi = "", UserCancel = "", DateCreate = "", DateModi = "", DateCancel = "";
        public String StatusPO = "", StatusApprove = "", PONumberCnt = "", Remark1 = "", Remark2 = "", Remark3 = "", Remark4 = "", Remark5 = "", CuAddressT = "", CpAddress1 = "", CpAddress2 = "", CpTaxId="";
        public String Amt = "", Vat = "", VatRate = "", NetTotal = "", SfApproveId = "", SfApproveName = "", Line1="", PODueDate="";
        public override string ToString()
        {
            return PONumber;
        }
    }
}
