using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Bill:Persistent
    {
        public String Id = "", BillNumber = "", Active = "", Remark = "", BillDate = "", CustId = "", CustName = "", CustAddress = "", CustTel = "", CustFax = "", CustEmail = "";
        public String Amount = "", DiscountPer = "", Discount = "", AmountDiscount = "", Total = "", VatRate = "", Vat = "", Nettotal = "", dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "";
        public String StatusBill = "";
        public override string ToString()
        {
            return BillNumber;
        }
    }
}
