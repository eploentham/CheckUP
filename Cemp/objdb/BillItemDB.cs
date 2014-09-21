using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            bii.table = "t_bill_item";
        }
        private BillItem setData(BillItem item, DataTable dt)
        {
            item.Id = dt.Rows[0][bii.Id].ToString();
            item.Active = dt.Rows[0][bii.Active].ToString();
            item.Amount = dt.Rows[0][bii.Amount].ToString();
            item.BillId = dt.Rows[0][bii.BillId].ToString();
            item.MOUId = dt.Rows[0][bii.MOUId].ToString();
            item.MOUNumber = dt.Rows[0][bii.MOUNumber].ToString();
            item.QuoId = dt.Rows[0][bii.QuoId].ToString();

            item.QuoNumber = dt.Rows[0][bii.QuoNumber].ToString();
            item.Remark = dt.Rows[0][bii.Remark].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + bii.table + " Where " + bii.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByBillId(String biId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + bii.table + " Where " + bii.BillId + "='" + biId + "' Where "+bii.Active+"='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public BillItem selectByPk(String biId)
        {
            BillItem item = new BillItem();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + bii.table + " Where " + bii.pkField + "='" + biId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(BillItem p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "bii" + p.getGenID();
            }

            //p.CustAddress = p.CustAddress.Replace("'", "''");
            //p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Insert Into " + bii.table + " (" + bii.pkField + "," + bii.Active + "," + bii.Amount + "," +
                bii.BillId + "," + bii.MOUId + "," + bii.MOUNumber + "," +
                bii.QuoId + "," + bii.QuoNumber + "," + bii.Remark + ") " +
                "Values('" + p.Id + "','" + p.Active + "'," + NumberNull1(p.Amount.Replace(",", "")) + ",'" +
                p.BillId + "','" + p.MOUId + "','" + p.MOUNumber + "','" +
                p.QuoId + "','" + p.QuoNumber + "','" + p.Remark  + "')";
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
        private String update(BillItem p)
        {
            String sql = "", chk = "";

            //p.CustAddress = p.CustAddress.Replace("'", "''");
            //p.CustName = p.CustName.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + bii.table + " Set " + bii.Amount + "=" + p.Amount + ", " +
                bii.BillId + "='" + p.BillId + "', " +
                bii.MOUId + "='" + p.MOUId + "', " +
                bii.MOUNumber + "='" + p.MOUNumber + "', " +
                bii.QuoId + "='" + p.QuoId + "', " +
                bii.QuoNumber + "='" + p.QuoNumber + "', " +
                bii.Remark + "='" + p.Remark + "', " +
                
                "Where " + bii.pkField + "='" + p.Id + "'";
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
        public String insertBillItem(BillItem p)
        {
            BillItem item = new BillItem();
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
            sql = "Delete From " + bii.table;
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
        public String VoidBillItem(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + bii.table + " Set " + bii.Active + "='3' " +
                "Where " + bii.pkField + "='" + saleId + "'";
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
