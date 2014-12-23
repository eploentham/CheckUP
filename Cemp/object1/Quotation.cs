using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Quotation:Persistent
    {
        public String Id = "", QuoDate = "", QuoNumber = "", CompId = "", CompName = "", CompAddress1 = "", CompAddress2 = "", CompTaxId = "", CustId = "";
        public String CustName = "", Line1 = "", ContactName = "", CustAddress = "", CustTel = "", CustFax = "", CustEmail = "", StaffId = "", StaffName = "", StaffTel = "";
        public String StaffEmail = "", Line2 = "", Remark1 = "", Remark2 = "", Remark3 = "", Amount = "", DiscountPer = "", AmountDiscount = "", Plus1 = "", Plus1Name = "";
        public String Total = "", VatRate = "", Vat = "", NetTotal = "", Line3 = "", Line4 = "", Line5 = "", Line6 = "", Active = "", StatusQuo = "", Discount="";
        public String StaffApproveId = "", StaffApproveName = "", QuoNumberCnt = "", StatusMOU = "", Remark4 = "", Remark5 = "", Remark6 = "", Remark7 = "";
        public String dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "", ThaiBaht = "", PathPicConfirm="", YearId="";
        public String QuExId = "";
        public override string ToString()
        {
            return QuoNumber;
        }
    }
}
