using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Bill:Persistent
    {
        public String Id = "", BillNumber = "", Active = "", Remark = "", BillDate = "", CustId = "", CustName = "", CustAddress = "", CustTel = "", CustFax = "", CustEmail = "";
        public String Amount = "", DiscountPer = "", Discount = "", AmountDiscount = "", Total = "", VatRate = "", Vat = "", Nettotal = "", DateCreate = "", DateModi = "", DateCancel = "", UserCreate = "", UserModi = "", UserCancel = "";
        public override string ToString()
        {
            return BillNumber;
        }
    }
}
