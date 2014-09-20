using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Customer:Persistent
    {
        public String Id = "", Code = "", NameT = "", NameE = "", amphurId = "", districtId = "", provinceId="", AddressT="", AddressE="", saleId = "", Active = "", saleName = "";
        public String Fax = "", Tele="", Email="", TaxId="", Remark="", Zipcode="", ContactName1="", ContactName2="", ContactName1Tel="", ContactName2Tel="";
        public String Addr = "", StatusCompany="", StatusVendor="",Remark2="";
        public String dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "";
        public override string ToString()
        {
            return saleName+"."+NameT;
        }
    }
}
