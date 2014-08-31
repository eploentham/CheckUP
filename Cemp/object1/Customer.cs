using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Customer:Persistent
    {
        public String Id = "", Code = "", NameT = "", NameE = "", amphurId = "", districtId = "", provinceId="", AddressT="", AddressE="", saleId = "", thoId = "", Active = "", saleName = "";
        public String Fax = "", Tele="", Email="", TaxId="";
        public override string ToString()
        {
            return saleName+"."+NameT;
        }
    }
}
