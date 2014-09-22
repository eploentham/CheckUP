using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class InvoiceItem:Persistent
    {
        public String Id = "", InvId = "", MOUId = "", MOUNumber = "", QuoId = "", QuoNumber = "", Active = "", Remark = "", Amount = "", MOUName="", RowNumber="";
        public override string ToString()
        {
            return Id;
        }
    }
}
