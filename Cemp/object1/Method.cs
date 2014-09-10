using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Method:Persistent
    {
        public String Id = "", Code = "", NameT = "", NameE = "", Active = "", Remark = "", Sort1 = "";
        public override string ToString()
        {
            return Code;
        }
    }
}
