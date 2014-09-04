using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class QuotationItem:Persistent
    {
        public String Id = "", QuoId = "", RowNumber = "", ItemId = "", ItemDescription = "", MethodId = "", MethodDescription = "", Qty = "", PriceSale = "", Discount = "", Amount = "", Active = "",Remark="";
        public override string ToString()
        {
            return ItemDescription;
        }
    }
}
