using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class QuotationItemDB
    {
        ConnectDB conn;
        public QuotationItem qui;
        public QuotationItemDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            qui = new QuotationItem();
            qui.Active = "quo_item_active";
            qui.Amount = "amount1";
            qui.Discount = "discount";
            qui.Id = "quo_item_id";
            qui.ItemDescription = "item_description";
            qui.ItemId = "item_id";
            qui.MethodDescription = "item_method_description";
            qui.MethodId = "item_method_id";
            qui.PriceSale = "price_sale";
            qui.Qty = "qty";
            qui.QuoId = "quo_id";
            qui.RowNumber = "row_number";
            qui.Remark = "remark";
            qui.ItemGroupId = "item_group_id";
            qui.ItemGroupNameE = "item_group_name_e";
            qui.ItemGroupNameT = "item_group_name_t";
            qui.ItemGroupSort = "item_group_sort";
            qui.dateCancel = "date_cancel";
            qui.dateCreate = "date_create";
            qui.dateModi = "date_modi";

            qui.userCancel = "user_cancel";
            qui.userCreate = "user_create";
            qui.userModi = "user_modi";
            qui.PriceCost = "price_cost";

            qui.ItemCode = "item_code";
            qui.ItemType = "item_type";

            qui.table = "t_quotation_item";
            qui.pkField = "quo_item_id";
        }
        private QuotationItem setData(QuotationItem item, DataTable dt)
        {
            item.Active = dt.Rows[0][qui.Active].ToString();
            item.Amount = dt.Rows[0][qui.Amount].ToString();
            item.Discount = dt.Rows[0][qui.Discount].ToString();
            item.Id = dt.Rows[0][qui.Id].ToString();
            item.ItemDescription = dt.Rows[0][qui.ItemDescription].ToString();
            item.ItemId = dt.Rows[0][qui.ItemId].ToString();
            item.MethodDescription = dt.Rows[0][qui.MethodDescription].ToString();
            item.MethodId = dt.Rows[0][qui.MethodId].ToString();
            item.PriceSale = dt.Rows[0][qui.PriceSale].ToString();
            item.Qty = dt.Rows[0][qui.Qty].ToString();
            item.QuoId = dt.Rows[0][qui.QuoId].ToString();
            item.RowNumber = dt.Rows[0][qui.RowNumber].ToString();
            item.Remark = dt.Rows[0][qui.Remark].ToString();
            item.ItemGroupId = dt.Rows[0][qui.ItemGroupId].ToString();
            item.ItemGroupNameE = dt.Rows[0][qui.ItemGroupNameE].ToString();
            item.ItemGroupNameT = dt.Rows[0][qui.ItemGroupNameT].ToString();
            item.ItemGroupSort = dt.Rows[0][qui.ItemGroupSort].ToString();
            item.dateCancel = dt.Rows[0][qui.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][qui.dateCreate].ToString();
            item.dateModi = dt.Rows[0][qui.dateModi].ToString();

            item.userCancel = dt.Rows[0][qui.userCancel].ToString();
            item.userCreate = dt.Rows[0][qui.userCreate].ToString();
            item.userModi = dt.Rows[0][qui.userModi].ToString();

            item.PriceCost = dt.Rows[0][qui.PriceCost].ToString();

            item.ItemCode = dt.Rows[0][qui.ItemCode].ToString();
            item.ItemType = dt.Rows[0][qui.ItemType].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + qui.table + " Where " + qui.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public QuotationItem selectByPk(String quiId)
        {
            QuotationItem item = new QuotationItem();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + qui.table + " Where " + qui.pkField + "='" + quiId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public DataTable selectMOUByQuId(String quId)
        {
            //QuotationItem item = new QuotationItem();
            String sql = "";
            DataTable dt=new DataTable();
            sql = "Select qui.* From " + qui.table + " as qui inner join b_item bi on bi.item_id = qui." + qui.ItemId +
                " Where qui." + qui.QuoId + "='" + quId + "' and qui." + qui.Active + "='1' and bi.status_real = '1' " +
                "Order By qui." + qui.RowNumber;
            //dt = conn.selectData(sql);
            try
            {
                dt = conn.selectData(sql);
            }
            catch (Exception ex)
            {

            }
            

            return dt;
        }
        public DataTable selectByQuId(String quId)
        {
            //QuotationItem item = new QuotationItem();
            String sql = "";

            sql = "Select qui.* From " + qui.table + " Where qui." + qui.QuoId + "='" + quId + "' and qui." + qui.Active + "='1' "+
                "Order By qui." + qui.RowNumber;
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectDistinctItemDescription()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + qui.ItemDescription + " From " + qui.table + " Where " + qui.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectDistinctMethodDescription()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + qui.MethodDescription + " From " + qui.table + " Where " + qui.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        private String insert(QuotationItem p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "qui"+p.getGenID();
            }

            //p.Discount = NumberNull1(p.Discount);
            //p.Qty = NumberNull1(p.Qty);
            //p.PriceSale = NumberNull1(p.PriceSale);
            //p.PriceCost = NumberNull1(p.PriceCost);
            //p.Amount = NumberNull1(p.Amount);
            //p.RowNumber = NumberNull1(p.RowNumber);
            //p.Discount = NumberNull1(p.Discount);
            //p.Discount = NumberNull1(p.Discount);

            p.ItemDescription = p.ItemDescription.Replace("'", "''");
            p.MethodDescription = p.MethodDescription.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            p.ItemGroupNameE = p.ItemGroupNameE.Replace("'", "''");
            p.ItemGroupNameT = p.ItemGroupNameT.Replace("'", "''");
            
            //p. = p.ItemGroupNameT.Replace("''", "'");
            //p.PriceSale = p.PriceSale.Replace(",", "");
            //p.PriceCost = p.PriceCost.Replace(",", "");
            //p.Qty = p.Qty.Replace(",", "");
            //p.Amount = p.Amount.Replace(",", "");
            //p.Discount = p.Discount.Replace(",", "");
            //p.ItemGroupNameT = p.ItemGroupNameT.Replace("''", "'");

            if (p.ItemGroupSort.Equals(""))
            {
                p.ItemGroupSort = "999";
            }
            sql = "Insert Into " + qui.table + " (" + qui.pkField + "," + qui.Active + "," + qui.Amount + "," +
                qui.Discount + "," + qui.ItemDescription + "," + qui.ItemId + "," +
                qui.MethodDescription + "," + qui.MethodId + "," + qui.PriceSale + "," +
                qui.Qty + "," + qui.QuoId + "," + qui.RowNumber + "," +
                qui.Remark + "," + qui.ItemGroupNameE + "," + qui.ItemGroupNameT + "," +
                qui.ItemGroupSort + "," + qui.ItemGroupId + "," + qui.PriceCost + "," + qui.ItemCode + "," + qui.ItemType + ") " +
                "Values('" + p.Id + "','" + p.Active + "'," + NumberNull1(p.Amount.Replace(",", "")) + "," +
                NumberNull1(p.Discount.Replace(",", "")) + ",'" + p.ItemDescription + "','" + p.ItemId + "','" +
                p.MethodDescription + "','" + p.MethodId + "'," + NumberNull1(p.PriceSale.Replace(",", "")) + "," +
                NumberNull1(p.Qty.Replace(",", "")) + ",'" + p.QuoId + "'," + NumberNull1(p.RowNumber) + ",'" +
                p.Remark + "','" + p.ItemGroupNameE + "','" + p.ItemGroupNameT + "','" +
                p.ItemGroupSort + "','" + p.ItemGroupId + "'," + NumberNull1(p.PriceCost.Replace(",", "")) + ",'" + p.ItemCode + "','" + p.ItemType + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Staff");
            }
            finally
            {
            }
            return chk;
        }
        private String update(QuotationItem p)
        {
            String sql = "", chk = "";

            p.ItemDescription = p.ItemDescription.Replace("'", "'");
            p.MethodDescription = p.MethodDescription.Replace("'", "'");
            p.Remark = p.Remark.Replace("'", "'");
            p.ItemGroupNameE = p.ItemGroupNameE.Replace("'", "'");
            p.ItemGroupNameT = p.ItemGroupNameT.Replace("'", "'");

            //p.PriceSale = p.PriceSale.Replace(",", "");
            //p.PriceCost = p.PriceCost.Replace(",", "");
            //p.Qty = p.Qty.Replace(",", "");
            //p.Amount = p.Amount.Replace(",", "");
            //p.Discount = p.Discount.Replace(",", "");
            if (p.ItemGroupSort.Equals(""))
            {
                p.ItemGroupSort = "999";
            }
            sql = "Update " + qui.table + " Set " + qui.Amount + "=" + NumberNull1(p.Amount.Replace(",","")) + ", " +
                qui.Discount + "=" + NumberNull1(p.Discount.Replace(",", "")) + ", " +
                qui.ItemDescription + "='" + p.ItemDescription + "', " +
                qui.ItemId + "='" + p.ItemId + "', " +
                qui.MethodDescription + "='" + p.MethodDescription + "', " +
                qui.MethodId + "='" + p.MethodId + "', " +
                qui.PriceSale + "=" + NumberNull1(p.PriceSale.Replace(",","")) + ", " +
                qui.Qty + "=" + NumberNull1(p.Qty.Replace(",","")) + ", " +
                qui.QuoId + "='" + p.QuoId + "', " +
                qui.RowNumber + "='" + NumberNull1(p.RowNumber) + "', " +
                qui.Remark + "='" + p.Remark + "', " +
                qui.ItemGroupNameE + "='" + p.ItemGroupNameE + "', " +
                qui.ItemGroupNameT + "='" + p.ItemGroupNameT + "', " +
                qui.ItemGroupSort + "='" + p.ItemGroupSort + "', " +
                qui.ItemGroupId + "='" + p.ItemGroupId + "', " +
                qui.PriceCost + "=" + NumberNull1(p.PriceCost.Replace(",", "")) + ", " +
                qui.ItemCode + "='" + p.ItemCode + "', " +
                //qui.ItemGroupId + "='" + p.ItemGroupId + "', " +
                qui.ItemType + "='" + p.ItemType + "' " +
                "Where " + qui.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Staff");
            }
            finally
            {
            }
            return chk;
        }
        public String insertQuotationItem(QuotationItem p)
        {
            QuotationItem item = new QuotationItem();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
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
            sql = "Delete From " + qui.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String VoidQuotationItem(String quId)
        {
            String sql = "", chk = "";

            sql = "Update " + qui.table + " Set " + qui.Active + "='3' " +
                "Where " + qui.pkField + "='" + quId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboItemDescription(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctItemDescription();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][qui.ItemDescription].ToString();
                item.Text = dt.Rows[i][qui.ItemDescription].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public ComboBox getCboMethodDescription(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctMethodDescription();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][qui.MethodDescription].ToString();
                item.Text = dt.Rows[i][qui.MethodDescription].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
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
        public String UpdateGroupNameT(String itId, String itgId, String itgNameT, String sort1)
        {
            String sql = "", chk = "";
            sql = "Update " + qui.table + " Set " + qui.ItemGroupNameT + "='" + itgNameT + "', " +
                qui.ItemGroupId + "='" + itgId + "', " +
                qui.ItemGroupSort + "='" + sort1 + "' " +
                "Where " + qui.ItemId + "='" + itId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
