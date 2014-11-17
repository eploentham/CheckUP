using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class POItem:Persistent
    {
        public String Id = "", POId = "", ItemId = "", ItemNameT = "", ItemPrice = "", ItemQty = "", ItemAmount = "", Remark = "", Active = "", UserCreate = "", UserModi = "", UserCancel = "", DateCreate = "", DateModi = "", DateCancel = "";
        public String ItemType = "", RowNumber = "", ItemCode = "";
        public override string ToString()
        {
            return ItemNameT;
        }
    }
}
