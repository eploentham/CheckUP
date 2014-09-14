using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Cemp.object1
{
    public class Staff : Persistent
    {
        public String Id = "", NameT = "", NameE="", Password = "", Active = "", Remark = "", Code = "", Priority="", Email="", Tele="", Fax="", PositionName="";
        public override string ToString()
        {
            return NameT;
        }
    }
}
