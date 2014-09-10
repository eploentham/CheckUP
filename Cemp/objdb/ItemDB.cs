using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class ItemDB
    {
        ConnectDB conn;
        public Item it;
        public ItemDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            it = new Item();
            it.Active = "item_active";
            it.Code = "item_code";
            it.Id = "item_id";
            it.NameE = "item_name_e";
            it.NameT = "item_name_t";
            it.PriceCost = "price_cost";
            it.PriceSale = "price_sale";
            it.Remark = "item_remark";
            it.ItemGroupId = "item_group_id";
            it.ItemGroupNameT = "item_group_name_t";
            it.MeasuringPoint = "measuring_point";
            it.MethodId = "method_id";
            it.MethodNameT = "method_name_t";
            it.Sort1 = "sort1";

            it.table = "b_item";
            it.pkField = "item_id";
        }
        private Item setData(Item item, DataTable dt)
        {
            item.Active = dt.Rows[0][it.Active].ToString();
            item.Code = dt.Rows[0][it.Code].ToString();
            item.Id = dt.Rows[0][it.Id].ToString();
            item.NameE = dt.Rows[0][it.NameE].ToString();
            item.NameT = dt.Rows[0][it.NameT].ToString();
            item.PriceCost = dt.Rows[0][it.PriceCost].ToString();
            item.PriceSale = dt.Rows[0][it.PriceSale].ToString();
            item.Remark = dt.Rows[0][it.Remark].ToString();
            item.ItemGroupId = dt.Rows[0][it.ItemGroupId].ToString();
            item.ItemGroupNameT = dt.Rows[0][it.ItemGroupNameT].ToString();
            item.MethodNameT = dt.Rows[0][it.MethodNameT].ToString();
            item.MethodId = dt.Rows[0][it.MethodId].ToString();
            item.MeasuringPoint = dt.Rows[0][it.MeasuringPoint].ToString();
            item.Sort1 = dt.Rows[0][it.Sort1].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + it.table + " Where " + it.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public Item selectByPk(String cuId)
        {
            Item item = new Item();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + it.table + " Where " + it.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public Item selectByCode(String cuId)
        {
            Item item = new Item();
            String sql = "";

            sql = "Select * From " + it.table + " Where " + it.Code + "='" + cuId + "' and " + it.Active + "='1' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(Item p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "cu" + p.getGenID();
            }

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            p.ItemGroupNameT = p.ItemGroupNameT.Replace("''", "'");
            p.MethodNameT = p.MethodNameT.Replace("''", "'");
            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "9999";
            }
            sql = "Insert Into " + it.table + " (" + it.pkField + "," + it.Active + "," + it.Code + "," +
                it.NameE + "," + it.NameT + "," + it.Remark + "," +
                it.PriceCost + "," + it.PriceSale + "," + it.ItemGroupId + "," +
                it.ItemGroupNameT + "," + it.MethodNameT + "," + it.MethodId + "," + it.Sort1 + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.Code + "','" +
                p.NameE + "','" + p.NameT + "','" + p.Remark + "'," +
                NumberNull1(p.PriceCost) + "," + NumberNull1(p.PriceSale) + ",'" + p.ItemGroupId + "','" +
                p.ItemGroupNameT + "','" + p.MethodNameT + "','" + p.MethodId + "','" + p.Sort1 + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Item");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Item p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            p.ItemGroupNameT = p.ItemGroupNameT.Replace("''", "'");
            p.MethodNameT = p.MethodNameT.Replace("''", "'");
            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "9999";
            }
            sql = "Update " + it.table + " Set " + it.Code + "='" + p.Code + "', " +
                it.NameE + "='" + p.NameE + "', " +
                it.NameT + "='" + p.NameT + "', " +
                it.Remark + "='" + p.Remark + "', " +
                it.ItemGroupId + "='" + p.ItemGroupId + "', " +
                it.ItemGroupNameT + "='" + p.ItemGroupNameT + "', " +
                it.MethodNameT + "='" + p.MethodNameT + "', " +
                it.MethodId + "='" + p.MethodId + "', " +
                it.PriceCost + "=" + NumberNull1(p.PriceCost) + ", " +
                it.PriceSale + "=" + NumberNull1(p.PriceSale) + ", " +
                it.Sort1 + "='" + p.Sort1 + "', " +
                "Where " + it.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Item");
            }
            finally
            {
            }
            return chk;
        }
        public String insertItem(Item p)
        {
            Item item = new Item();
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
            sql = "Delete From " + it.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboItem(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][it.Id].ToString();
                item.Text = dt.Rows[i][it.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboItemQuotation(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][it.Id].ToString();
                item.Text = dt.Rows[i][it.Code].ToString() + " " + dt.Rows[i][it.NameT].ToString() + " " + dt.Rows[i][it.MethodNameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidItem(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + it.table + " Set " + it.Active + "='3' " +
                "Where " + it.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String getMaxCode()
        {
            String sql = "", cnt = "", year = "";
            sql = "Select count(1) as cnt From " + it.table;
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = "00000" + cnt;
                cnt = cnt.Substring(cnt.Length - 5);
                //year = getYear();
            }
            //return "me" + year + cnt;
            return cnt;
        }
        public String getItemCode()
        {
            String sql = "", cnt = "", year = "";
            sql = "Select count(1) as cnt From " + it.table;
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = "00000" + cnt;
                cnt = cnt.Substring(cnt.Length - 5);
                //year = getYear();
            }
            //return "me" + year + cnt;
            return cnt;
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
