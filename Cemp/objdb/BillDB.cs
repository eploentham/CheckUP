using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            bi.dateCancel = "date_cancel";
            bi.dateCreate = "date_create";
            bi.dateModi = "date_modi";
            bi.Discount = "discount";
            bi.DiscountPer = "discount_per";
            bi.Id = "bill_id";
            bi.Nettotal = "nettotal";
            bi.Remark = "remark";
            bi.Total = "total";
            bi.userCancel = "user_cancel";
            bi.userCreate = "user_create";
            bi.userModi = "user_modi";
            bi.Vat = "vat";
            bi.VatRate = "vat_rate";
            bi.StatusBill = "status_bill";

            bi.pkField = "bill_id";
            bi.table = "t_bill";
        }
        private Bill setData(Bill item, DataTable dt)
        {
            item.Id = dt.Rows[0][bi.Id].ToString();
            item.Active = dt.Rows[0][bi.Active].ToString();
            item.Amount = dt.Rows[0][bi.Amount].ToString();
            item.AmountDiscount = dt.Rows[0][bi.AmountDiscount].ToString();
            item.BillDate = dt.Rows[0][bi.BillDate].ToString();
            item.BillNumber = dt.Rows[0][bi.BillNumber].ToString();
            item.CustAddress = dt.Rows[0][bi.CustAddress].ToString();

            item.CustEmail = dt.Rows[0][bi.CustEmail].ToString();
            item.CustFax = dt.Rows[0][bi.CustFax].ToString();
            item.CustId = dt.Rows[0][bi.CustId].ToString();
            item.CustName = dt.Rows[0][bi.CustName].ToString();
            item.CustTel = dt.Rows[0][bi.CustTel].ToString();
            item.dateCancel = dt.Rows[0][bi.dateCancel].ToString();
            item.dateModi = dt.Rows[0][bi.dateModi].ToString();
            item.Discount = dt.Rows[0][bi.Discount].ToString();
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

            item.DiscountPer = dt.Rows[0][bi.DiscountPer].ToString();
            item.Nettotal = dt.Rows[0][bi.Nettotal].ToString();
            item.Remark = dt.Rows[0][bi.Remark].ToString();
            item.Total = dt.Rows[0][bi.Total].ToString();
            item.userCancel = dt.Rows[0][bi.userCancel].ToString();
            item.userCreate = dt.Rows[0][bi.userCreate].ToString();
            item.userModi = dt.Rows[0][bi.userModi].ToString();
            item.Vat = dt.Rows[0][bi.Vat].ToString();
            item.VatRate = dt.Rows[0][bi.VatRate].ToString();
            item.StatusBill = dt.Rows[0][bi.StatusBill].ToString();
            item.dateCreate = dt.Rows[0][bi.dateCreate].ToString();
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + bi.table + " Where " + bi.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectBillList()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select " + bi.BillNumber + "," + bi.CustName + "," + bi.BillDate + " From " + bi.table + " Where " + bi.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public Bill selectByPk(String biId)
        {
            Bill item = new Bill();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + bi.table + " Where " + bi.pkField + "='" + biId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public Bill selectByNumber(String biId)
        {
            Bill item = new Bill();
            String sql = "";

            sql = "Select * From " + bi.table + " Where " + bi.BillNumber + "='" + biId + "'  ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, conn.dt);
            }
            return item;
        }
        private String insert(Bill p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "bi" + p.getGenID();
            }

            p.CustAddress = p.CustAddress.Replace("'", "''");
            p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            p.StatusBill = "1";
            sql = "Insert Into " + bi.table + " (" + bi.pkField + "," + bi.Active + "," + bi.Amount + "," +
                bi.AmountDiscount + "," + bi.BillDate + "," + bi.BillNumber + "," +
                bi.CustAddress + "," + bi.CustEmail + "," + bi.CustFax + "," +
                bi.CustId + "," + bi.CustName + "," + bi.CustTel + "," +
                bi.dateCancel + "," + bi.dateModi + "," + bi.Discount + "," +
                bi.DiscountPer + "," + bi.Nettotal + "," + bi.Remark + "," +
                bi.Total + "," + bi.userCancel + "," + bi.userCreate + "," +
                bi.userModi + "," + bi.Vat + "," + bi.VatRate + "," + 
                bi.dateCreate + "," + bi.StatusBill + ") " +
                "Values('" + p.Id + "','" + p.Active + "'," + NumberNull1(p.Amount.Replace(",", "")) + "," +
                NumberNull1(p.AmountDiscount.Replace(",", "")) + ",'" + p.BillDate + "','" + p.BillNumber + "','" +
                p.CustAddress + "','" + p.CustEmail + "','" + p.CustFax + "','" +
                p.CustId + "','" + p.CustName + "','" + p.CustTel + "','" +
                p.dateCancel + "','" + p.dateModi + "'," + NumberNull1(p.Discount.Replace(",","")) + "," +
                NumberNull1(p.DiscountPer.Replace(",", "")) + "," + NumberNull1(p.Nettotal.Replace(",", "")) + ",'" + p.Remark + "'," +
                NumberNull1(p.Total.Replace(",", "")) + ",'" + p.userCancel + "','" + p.userCreate + "','" +
                p.userModi + "'," + NumberNull1(p.Vat.Replace(",", "")) + "," + NumberNull1(p.VatRate.Replace(",", "")) + "," + 
                p.dateGenDB + ",'" + p.StatusBill + "')";
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
        private String update(Bill p)
        {
            String sql = "", chk = "";

            p.CustAddress = p.CustAddress.Replace("'", "''");
            p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + bi.table + " Set " + bi.Amount + "=" + p.Amount + ", " +
                bi.AmountDiscount + "=" + p.AmountDiscount + ", " +
                bi.BillDate + "='" + p.BillDate + "', " +
                bi.BillNumber + "='" + p.BillNumber + "', " +
                bi.CustAddress + "='" + p.CustAddress + "', " +
                bi.CustEmail + "='" + p.CustEmail + "', " +
                bi.CustFax + "='" + p.CustFax + "', " +
                bi.CustId + "='" + p.CustId + "', " +
                bi.CustName + "='" + p.CustName + "', " +
                bi.CustTel + "='" + p.CustTel + "', " +
                bi.dateModi + "=" + p.dateGenDB + ", " +
                bi.Discount + "=" + p.Discount + ", " +
                bi.DiscountPer + "=" + p.DiscountPer + ", " +
                bi.Nettotal + "=" + p.Nettotal + ", " +
                bi.Remark + "='" + p.Remark + "', " +
                bi.Total + "=" + p.Total + ", " +
                bi.userModi + "='" + p.userModi + "', " +
                bi.Vat + "=" + p.Vat + ", " +
                bi.VatRate + "=" + p.VatRate + " " +
                

                "Where " + bi.pkField + "='" + p.Id + "'";
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
        public String insertBill(Bill p)
        {
            Bill item = new Bill();
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
            sql = "Delete From " + bi.table;
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

                item.Text = dt.Rows[0][bi.BillNumber].ToString() + " " + dt.Rows[0][bi.CustName].ToString();

                item.Value = dt.Rows[i][bi.Id].ToString();
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
            sql = "Update " + bi.table + " Set " + bi.Active + "='3' " +
                "Where " + bi.pkField + "='" + saleId + "'";
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
            sql = "Select count(1) as cnt From " + bi.table;
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
    }
}
