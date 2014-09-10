using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Item:Persistent
    {
        public String Id = "", Code = "", NameT = "", NameE = "", PriceSale = "", PriceCost = "", Remark = "", Active = "";
        public String MeasuringPoint = "", MethodId = "", MethodNameT = "", ItemGroupId = "", ItemGroupNameT = "", Sort1 = "";
    }
}
