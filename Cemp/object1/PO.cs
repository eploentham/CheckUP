using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class PO:Persistent
    {
        public String Id = "", PONumber = "", CpId = "", CpNameT = "", PODate = "", PODurPeriod = "", Active = "", ContactName = "", CuId = "", CuNametT = "", CuTel = "";
        public String CuFax = "", CustEmail = "", SfId = "", SfEmail = "", SfName = "", SfTel = "", QuId = "", QuNumber = "", UserCreate = "", UserModi = "", UserCancel = "", DateCreate = "", DateModi = "", DateCancel = "";
        public String StatusPO = "", StatusApprove = "", PONumberCnt = "", Remark1 = "", Remark2 = "", Remark3 = "", Remark4 = "", Remark5 = "", CuAddressT = "", CpAddress1 = "", CpAddress2 = "", CpTaxId="";
        public String Amt = "", Vat = "", VatRate = "", NetTotal = "", SfApproveId = "", SfApproveName = "", line1="";
        public override string ToString()
        {
            return PONumber;
        }
    }
}
