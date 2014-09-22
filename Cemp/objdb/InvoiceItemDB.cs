using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class InvoiceItemDB
    {
        ConnectDB conn;
        public InvoiceItem invi;
        public InvoiceItemDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            invi = new InvoiceItem();
            invi.Active = "inv_item_active";
            invi.Amount = "amount";
            invi.InvId = "inv_id";
            invi.Id = "inv_item_id";
            invi.MOUId = "mou_id";
            invi.MOUNumber = "mou_number";
            invi.QuoId = "quo_id";
            invi.QuoNumber = "quo_number";
            invi.Remark = "remark";
            invi.MOUName = "mou_name";
            invi.RowNumber = "row_number";

            invi.pkField = "inv_item_id";
            invi.table = "t_invoice_item";
        }
        private InvoiceItem setData(InvoiceItem item, DataTable dt)
        {
            item.Id = dt.Rows[0][invi.Id].ToString();
            item.Active = dt.Rows[0][invi.Active].ToString();
            item.Amount = dt.Rows[0][invi.Amount].ToString();
            item.InvId = dt.Rows[0][invi.InvId].ToString();
            item.MOUId = dt.Rows[0][invi.MOUId].ToString();
            item.MOUNumber = dt.Rows[0][invi.MOUNumber].ToString();
            item.QuoId = dt.Rows[0][invi.QuoId].ToString();

            item.QuoNumber = dt.Rows[0][invi.QuoNumber].ToString();
            item.Remark = dt.Rows[0][invi.Remark].ToString();
            item.MOUName = dt.Rows[0][invi.MOUName].ToString();
            item.RowNumber = dt.Rows[0][invi.RowNumber].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + invi.table + " Where " + invi.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByInvId(String biId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + invi.table + " Where " + invi.InvId + "='" + biId + "' and "+invi.Active+"='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public InvoiceItem selectByPk(String biId)
        {
            InvoiceItem item = new InvoiceItem();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + invi.table + " Where " + invi.pkField + "='" + biId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(InvoiceItem p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "bii" + p.getGenID();
            }

            //p.CustAddress = p.CustAddress.Replace("'", "''");
            p.MOUName = p.MOUName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Insert Into " + invi.table + " (" + invi.pkField + "," + invi.Active + "," + invi.Amount + "," +
                invi.InvId + "," + invi.MOUId + "," + invi.MOUNumber + "," +
                invi.QuoId + "," + invi.QuoNumber + "," + invi.Remark + "," + invi.MOUName + "," + invi.RowNumber + ") " +
                "Values('" + p.Id + "','" + p.Active + "'," + NumberNull1(p.Amount.Replace(",", "")) + ",'" +
                p.InvId + "','" + p.MOUId + "','" + p.MOUNumber + "','" +
                p.QuoId + "','" + p.QuoNumber + "','" + p.Remark + "','" + p.MOUName + "'," + NumberNull1(p.RowNumber) + ")";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert BillItem");
            }
            finally
            {
            }
            return chk;
        }
        private String update(InvoiceItem p)
        {
            String sql = "", chk = "";

            //p.CustAddress = p.CustAddress.Replace("'", "''");
            //p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + invi.table + " Set " + invi.Amount + "=" + p.Amount + ", " +
                invi.InvId + "='" + p.InvId + "', " +
                invi.MOUId + "='" + p.MOUId + "', " +
                invi.MOUNumber + "='" + p.MOUNumber + "', " +
                invi.QuoId + "='" + p.QuoId + "', " +
                invi.QuoNumber + "='" + p.QuoNumber + "', " +
                invi.Remark + "='" + p.Remark + "', " +
                invi.MOUName + "='" + p.MOUName + "', " +
                invi.RowNumber + "=" + p.RowNumber + " " +
                "Where " + invi.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update BillItem");
            }
            finally
            {
            }
            return chk;
        }
        public String insertBillItem(InvoiceItem p)
        {
            InvoiceItem item = new InvoiceItem();
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
            sql = "Delete From " + invi.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        //public ComboBox getCboBill(ComboBox c)
        //{
        //    ComboBoxItem item = new ComboBoxItem();
        //    DataTable dt = selectAll();
        //    //String aaa = "";
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        item = new ComboBoxItem();

        //        item.Text = dt.Rows[0][bi.BillNumber].ToString() + " " + dt.Rows[0][bi.CustName].ToString();

        //        item.Value = dt.Rows[i][bi.Id].ToString();
        //        //item.Text = dt.Rows[i][bi.NameT].ToString();
        //        c.Items.Add(item);
        //        //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
        //        //c.Items.Add(new );
        //    }
        //    return c;
        //}
        public String VoidInvoiceItem(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + invi.table + " Set " + invi.Active + "='3' " +
                "Where " + invi.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        //public String selectCodeMax()
        //{
        //    //Customer item = new Customer();
        //    String sql = "", year = "";
        //    if (System.DateTime.Now.Year > 2550)
        //    {
        //        year = System.DateTime.Now.Year.ToString().Substring(2);
        //    }
        //    else
        //    {
        //        year = String.Concat(System.DateTime.Now.Year + 543);
        //    }
        //    year = year.Substring(2);
        //    sql = "Select count(1) as cnt From " + bi.table;
        //    //dt = conn.selectData(sql);
        //    DataTable dt = conn.selectData(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        sql = "00000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
        //        sql = sql.Substring(sql.Length - 5);
        //    }
        //    else
        //    {
        //        sql = "00001";
        //    }
        //    return "CU" + year + sql;
        //}
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
