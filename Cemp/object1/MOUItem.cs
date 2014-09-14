using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class MOUItem:Persistent
    {
        public String Id = "", MOUId = "", RowNumber = "", ItemId = "", ItemDescription = "", MethodId = "", MethodDescription = "", Sample = "", PlaceRecord = "", Active="";
        public String dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "";
    }
}
