using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.objdb
{
    public class BillDB
    {
        ConnectDB conn;
        public Bill bi;
        public BillDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            bi = new Bill();
            bi.Active = "bill_active";
            bi.Amount = "amount";
            bi.AmountDiscount = "amount_discount";
            bi.BillDate = "bill_date";
            bi.BillNumber = "bill_number";
            bi.CustAddress = "cust_address";
            bi.CustEmail = "cust_email";
            bi.CustFax = "cust_fax";
            bi.CustId = "cust_id";
            bi.CustName = "cust_name";
            bi.CustTel = "cust_tel";
            bi.DateCancel = "date_cancel";
            bi.DateCreate = "date_create";
            bi.DateModi = "date_modi";
            bi.Discount = "discount";
            bi.DiscountPer = "discount_per";
            bi.Id = "bill_id";
            bi.Nettotal = "nettotal";
            bi.Remark = "remark";
            bi.Total = "total";
            bi.UserCancel = "user_cancel";
            bi.UserCreate = "user_create";
            bi.UserModi = "user_modi";
            bi.Vat = "vat";
            bi.VatRate = "vat_rate";

            bi.pkField = "bill_id";
            bi.table = "t_bill";
        }
    }
}
