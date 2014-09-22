using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Invoice:Persistent
    {
        public String Id = "", InvNumber = "", Active = "", Remark = "", InvDate = "", CustId = "", CustName = "", CustAddress = "", CustTel = "", CustFax = "", CustEmail = "";
        public String Amount = "", DiscountPer = "", Discount = "", AmountDiscount = "", Total = "", VatRate = "", Vat = "", Nettotal = "", dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "";
        public String StatusInv = "", InvDuePeriod = "", CustRemark2 = "";
        public override string ToString()
        {
            return InvNumber;
        }
    }
}
