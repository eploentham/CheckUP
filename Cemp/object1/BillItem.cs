using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class BillItem:Persistent
    {
        public String Id = "", BillId = "", MOUId = "", MOUNumber = "", QuoId = "", QuoNumber = "", Active = "", Remark = "", Amount = "";
        public override string ToString()
        {
            return Id;
        }
    }
}
