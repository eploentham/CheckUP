using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.objdb
{
    public class BillItemDB
    {
        ConnectDB conn;
        public BillItem bii;
        public BillItemDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            bii = new BillItem();
            bii.Active = "bill_item_active";
            bii.Amount = "amount";
            bii.BillId = "bill_id";
            bii.Id = "bill_item_id";
            bii.MOUId = "mou_id";
            bii.MOUNumber = "mou_number";
            bii.QuoId = "quo_id";
            bii.QuoNumber = "quo_number";
            bii.Remark = "remark";

            bii.pkField = "bill_item_id";
            bii.table = "";
        }
    }
}
