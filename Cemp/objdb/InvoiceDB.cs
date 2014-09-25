using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class InvoiceDB
    {
        ConnectDB conn;
        public Invoice inv;
        public InvoiceDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            inv = new Invoice();
            inv.Active = "inv_active";
            inv.Amount = "amount";
            inv.AmountDiscount = "amount_discount";
            inv.InvDate = "inv_date";
            inv.InvNumber = "inv_number";
            inv.CustAddress = "cust_address";
            inv.CustEmail = "cust_email";
            inv.CustFax = "cust_fax";
            inv.CustId = "cust_id";
            inv.CustName = "cust_name";
            inv.CustTel = "cust_tel";
            inv.dateCancel = "date_cancel";
            inv.dateCreate = "date_create";
            inv.dateModi = "date_modi";
            inv.Discount = "discount";
            inv.DiscountPer = "discount_per";
            inv.Id = "inv_id";
            inv.Nettotal = "nettotal";
            inv.Remark = "remark";
            inv.Total = "total";
            inv.userCancel = "user_cancel";
            inv.userCreate = "user_create";
            inv.userModi = "user_modi";
            inv.Vat = "vat";
            inv.VatRate = "vat_rate";
            inv.StatusInv = "status_inv";
            inv.InvDuePeriod = "invoice_due_period";
            inv.CustRemark2 = "cust_remark2";
            inv.Plus1 = "plus1";
            inv.Plus1Name = "plus1name";

            inv.pkField = "inv_id";
            inv.table = "t_invoice";
        }
        private Invoice setData(Invoice item, DataTable dt)
        {
            item.Id = dt.Rows[0][inv.Id].ToString();
            item.Active = dt.Rows[0][inv.Active].ToString();
            item.Amount = dt.Rows[0][inv.Amount].ToString();
            item.AmountDiscount = dt.Rows[0][inv.AmountDiscount].ToString();
            item.InvDate = dt.Rows[0][inv.InvDate].ToString();
            item.InvNumber = dt.Rows[0][inv.InvNumber].ToString();
            item.CustAddress = dt.Rows[0][inv.CustAddress].ToString();

            item.CustEmail = dt.Rows[0][inv.CustEmail].ToString();
            item.CustFax = dt.Rows[0][inv.CustFax].ToString();
            item.CustId = dt.Rows[0][inv.CustId].ToString();
            item.CustName = dt.Rows[0][inv.CustName].ToString();
            item.CustTel = dt.Rows[0][inv.CustTel].ToString();
            item.dateCancel = dt.Rows[0][inv.dateCancel].ToString();
            item.dateModi = dt.Rows[0][inv.dateModi].ToString();
            item.Discount = dt.Rows[0][inv.Discount].ToString();
            //if (dt.Rows[0][bi.StatusCompany].ToString().Equals("1"))
            //{
            //    item.NameT = "บริษัท " + dt.Rows[0][bi.NameT].ToString() + " จำกัด";
            //}
            //else if (dt.Rows[0][bi.StatusCompany].ToString().Equals("2"))
            //{
            //    item.NameT = dt.Rows[0][bi.NameT].ToString() + " Co., Ltd.";
            //}
            //else
            //{
            //    item.NameT = dt.Rows[0][bi.NameT].ToString();
            //}

            item.DiscountPer = dt.Rows[0][inv.DiscountPer].ToString();
            item.Nettotal = dt.Rows[0][inv.Nettotal].ToString();
            item.Remark = dt.Rows[0][inv.Remark].ToString();
            item.Total = dt.Rows[0][inv.Total].ToString();
            item.userCancel = dt.Rows[0][inv.userCancel].ToString();
            item.userCreate = dt.Rows[0][inv.userCreate].ToString();
            item.userModi = dt.Rows[0][inv.userModi].ToString();
            item.Vat = dt.Rows[0][inv.Vat].ToString();
            item.VatRate = dt.Rows[0][inv.VatRate].ToString();
            item.StatusInv = dt.Rows[0][inv.StatusInv].ToString();
            item.dateCreate = dt.Rows[0][inv.dateCreate].ToString();
            item.InvDuePeriod = dt.Rows[0][inv.InvDuePeriod].ToString();
            item.CustRemark2 = dt.Rows[0][inv.CustRemark2].ToString();
            item.Plus1 = dt.Rows[0][inv.Plus1].ToString();
            item.Plus1Name = dt.Rows[0][inv.Plus1Name].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + inv.table + " Where " + inv.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectBillList()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + inv.table + " Where " + inv.Active + "='1' and "+inv.StatusInv+"='1' Order By "+inv.InvNumber;
            dt = conn.selectData(sql);

            return dt;
        }
        public Invoice selectByPk(String biId)
        {
            Invoice item = new Invoice();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + inv.table + " Where " + inv.pkField + "='" + biId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public Invoice selectByNumber(String biId)
        {
            Invoice item = new Invoice();
            String sql = "";

            sql = "Select * From " + inv.table + " Where " + inv.InvNumber + "='" + biId + "'  ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, conn.dt);
            }
            return item;
        }
        public String getInvMaxNumber()
        {
            String sql = "", doc = "", year = "";
            //String[] doc1 = mouNumber.Split('-');

            year = getYear();

            sql = "Select count(1) as cnt From " + inv.table;
            DataTable dt = conn.selectData(sql);
            doc = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
            doc = "00000" + doc;
            doc = doc.Substring(doc.Length - 5);
            //cnt = "1";
            //doc = "00001";

            return "INV" + year + doc;
        }
        private String insert(Invoice p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "bi" + p.getGenID();
            }

            p.CustAddress = p.CustAddress.Replace("'", "''");
            p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            p.CustRemark2 = p.CustRemark2.Replace("'", "''");
            p.StatusInv = "1";
            p.Plus1Name = p.Plus1Name.Replace("'", "''");
            sql = "Insert Into " + inv.table + " (" + inv.pkField + "," + inv.Active + "," + inv.Amount + "," +
                inv.AmountDiscount + "," + inv.InvDate + "," + inv.InvNumber + "," +
                inv.CustAddress + "," + inv.CustEmail + "," + inv.CustFax + "," +
                inv.CustId + "," + inv.CustName + "," + inv.CustTel + "," +
                inv.dateCancel + "," + inv.dateModi + "," + inv.Discount + "," +
                inv.DiscountPer + "," + inv.Nettotal + "," + inv.Remark + "," +
                inv.Total + "," + inv.userCancel + "," + inv.userCreate + "," +
                inv.userModi + "," + inv.Vat + "," + inv.VatRate + "," +
                inv.dateCreate + "," + inv.StatusInv + "," + inv.InvDuePeriod + "," + 
                inv.CustRemark2 + "," + inv.Plus1Name + "," + inv.Plus1 + ") " +
                "Values('" + p.Id + "','" + p.Active + "'," + NumberNull1(p.Amount.Replace(",", "")) + "," +
                NumberNull1(p.AmountDiscount.Replace(",", "")) + ",'" + p.InvDate + "','" + p.InvNumber + "','" +
                p.CustAddress + "','" + p.CustEmail + "','" + p.CustFax + "','" +
                p.CustId + "','" + p.CustName + "','" + p.CustTel + "','" +
                p.dateCancel + "','" + p.dateModi + "'," + NumberNull1(p.Discount.Replace(",","")) + "," +
                NumberNull1(p.DiscountPer.Replace(",", "")) + "," + NumberNull1(p.Nettotal.Replace(",", "")) + ",'" + p.Remark + "'," +
                NumberNull1(p.Total.Replace(",", "")) + ",'" + p.userCancel + "','" + p.userCreate + "','" +
                p.userModi + "'," + NumberNull1(p.Vat.Replace(",", "")) + "," + NumberNull1(p.VatRate.Replace(",", "")) + "," +
                p.dateGenDB + ",'" + p.StatusInv + "','" + p.InvDuePeriod + "','" +
                p.CustRemark2 + "','" + p.Plus1Name + "'," + NumberNull1(p.Plus1.Replace(",", "")) + ")";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Bill");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Invoice p)
        {
            String sql = "", chk = "";

            p.CustAddress = p.CustAddress.Replace("'", "''");
            p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            p.CustRemark2 = p.CustRemark2.Replace("'", "''");
            p.Plus1Name = p.Plus1Name.Replace("'", "''");
            sql = "Update " + inv.table + " Set " + inv.Amount + "=" + NumberNull1(p.Amount.Replace(",", "")) + ", " +
                inv.AmountDiscount + "=" + NumberNull1(p.AmountDiscount.Replace(",", "")) + ", " +
                inv.InvDate + "='" + p.InvDate + "', " +
                inv.InvNumber + "='" + p.InvNumber + "', " +
                inv.CustAddress + "='" + p.CustAddress + "', " +
                inv.CustEmail + "='" + p.CustEmail + "', " +
                inv.CustFax + "='" + p.CustFax + "', " +
                inv.CustId + "='" + p.CustId + "', " +
                inv.CustName + "='" + p.CustName + "', " +
                inv.CustTel + "='" + p.CustTel + "', " +
                inv.dateModi + "=" + p.dateGenDB + ", " +
                inv.Discount + "=" + NumberNull1(p.Discount.Replace(",", "")) + ", " +
                inv.DiscountPer + "=" + NumberNull1(p.DiscountPer.Replace(",", "")) + ", " +
                inv.Nettotal + "=" + NumberNull1(p.Nettotal.Replace(",", "")) + ", " +
                inv.Remark + "='" + p.Remark + "', " +
                inv.Total + "=" + p.Total + ", " +
                inv.userModi + "='" + p.userModi + "', " +
                inv.Vat + "=" + NumberNull1(p.Vat.Replace(",", "")) + ", " +
                inv.VatRate + "=" + NumberNull1(p.VatRate.Replace(",", "")) + ", " +
                inv.InvDuePeriod + "='" + p.InvDuePeriod + "', " +
                inv.CustRemark2 + "='" + p.CustRemark2 + "' " +
                inv.Plus1Name + "='" + p.Plus1Name + "' " +
                inv.Plus1 + "='" + NumberNull1(p.Plus1.Replace(",", "")) + "' " +
                "Where " + inv.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Bill");
            }
            finally
            {
            }
            return chk;
        }
        public String insertBill(Invoice p)
        {
            Invoice item = new Invoice();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
                p.Active = "1";
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String deleteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + inv.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboBill(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();

                item.Text = dt.Rows[0][inv.InvNumber].ToString() + " " + dt.Rows[0][inv.CustName].ToString();

                item.Value = dt.Rows[i][inv.Id].ToString();
                //item.Text = dt.Rows[i][bi.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidBill(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + inv.table + " Set " + inv.Active + "='3' " +
                "Where " + inv.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String selectCodeMax()
        {
            //Customer item = new Customer();
            String sql = "", year = "";
            if (System.DateTime.Now.Year > 2550)
            {
                year = System.DateTime.Now.Year.ToString().Substring(2);
            }
            else
            {
                year = String.Concat(System.DateTime.Now.Year + 543);
            }
            year = year.Substring(2);
            sql = "Select count(1) as cnt From " + inv.table;
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                sql = "00000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                sql = sql.Substring(sql.Length - 5);
            }
            else
            {
                sql = "00001";
            }
            return "CU" + year + sql;
        }
        private String NumberNull1(String o)
        {
            if (o.Equals(""))
            {
                return "0";
            }
            else
            {
                return o;
            }
        }
        public String getYear()
        {
            String year = "";
            if (System.DateTime.Now.Year > 2550)
            {
                year = System.DateTime.Now.Year.ToString().Substring(2);
            }
            else
            {
                year = String.Concat(System.DateTime.Now.Year + 543);
            }
            year = year.Substring(2);
            return year;
        }
    }
}
