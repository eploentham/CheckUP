using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Company:Persistent
    {
        public String Id = "", NameT = "", NameE = "", amphurId = "", districtId = "", provinceId = "", AddressT = "", AddressE = "";
        public String Fax = "", Tele = "", Email = "", TaxId = "", Zipcode = "", vat="", logo="", Code="";
        public String Addr = "", WebSite="";
    }
}
