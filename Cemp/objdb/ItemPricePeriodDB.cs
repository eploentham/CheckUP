using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class ItemPricePeriodDB
    {
        ConnectDB conn;
        public ItemPricePeriod ipp;
        public ItemPricePeriodDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            ipp = new ItemPricePeriod();
            ipp.Active = "item_price_period_acitve";
            ipp.Id = "item_price_period_id";
            ipp.ItemId = "item_id";
            ipp.PeriodEnd = "period_end";
            ipp.PeriodStart = "period_start";
            ipp.PriceSale = "price_sale";
            ipp.Remark = "remark";

            ipp.pkField = "item_price_period_id";
            ipp.table = "";
        }
        private ItemPricePeriod setData(ItemPricePeriod item, DataTable dt)
        {
            item.Active = dt.Rows[0][ipp.Active].ToString();
            item.Id = dt.Rows[0][ipp.Id].ToString();
            item.ItemId = dt.Rows[0][ipp.ItemId].ToString();
            item.PeriodEnd = dt.Rows[0][ipp.PeriodEnd].ToString();
            item.PeriodStart = dt.Rows[0][ipp.PeriodStart].ToString();
            item.PriceSale = dt.Rows[0][ipp.PriceSale].ToString();
            item.Remark = dt.Rows[0][ipp.Remark].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ipp.table + " Where " + ipp.Active + "='1' ";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByItemId(String itId)
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ipp.table + " Where " + ipp.Active + "='1' and "+ipp.ItemId+"='"+itId+"'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ItemPricePeriod selectByPk(String cuId)
        {
            ItemPricePeriod item = new ItemPricePeriod();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ipp.table + " Where " + ipp.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(ItemPricePeriod p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "it" + p.getGenID();
            }

            //p.NameE = p.NameE.Replace("'", "''");
            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.ItemGroupNameT = p.ItemGroupNameT.Replace("'", "''");
            //p.MethodNameT = p.MethodNameT.Replace("'", "''");
            //p.CustNameT = p.CustNameT.Replace("'", "''");
            //p.AnalysisNameT = p.AnalysisNameT.Replace("'", "''");
            //if (p.Sort1.Equals(""))
            //{
            //    p.Sort1 = "9999";
            //}
            //if (p.StatusReal.Equals(""))
            //{
            //    p.StatusReal = "1";
            //}
            //if (p.StatusStock.Equals(""))
            //{
            //    p.StatusStock = "1";
            //}
            sql = "Insert Into " + ipp.table + " (" + ipp.pkField + "," + ipp.Active + "," + ipp.ItemId + "," +
                ipp.PeriodEnd + "," + ipp.PeriodStart + "," + ipp.PriceSale + "," +
                ipp.Remark + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.ItemId + "'," +
                NumberNull1(p.PeriodEnd) + "," + NumberNull1(p.PeriodStart) + "," + NumberNull1(p.PriceSale) + "," +
                p.Remark + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert ItemPricePeriod");
            }
            finally
            {
            }
            return chk;
        }
        private String update(ItemPricePeriod p)
        {
            String sql = "", chk = "";

            //p.NameE = p.NameE.Replace("'", "''");
            //p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");
            //p.ItemGroupNameT = p.ItemGroupNameT.Replace("'", "''");
            //p.MethodNameT = p.MethodNameT.Replace("'", "''");
            //p.CustNameT = p.CustNameT.Replace("'", "''");
            //p.AnalysisNameT = p.AnalysisNameT.Replace("'", "''");
            //if (p.Sort1.Equals(""))
            //{
            //    p.Sort1 = "9999";
            //}
            sql = "Update " + ipp.table + " Set " + ipp.PeriodEnd + "=" + NumberNull1(p.PeriodEnd) + ", " +
                ipp.PeriodStart + "=" + NumberNull1(p.PeriodStart) + ", " +
                ipp.PriceSale + "=" + NumberNull1(p.PriceSale) + ", " +
                ipp.Remark + "='" + p.Remark + "', " +
                ipp.ItemId + "='" + p.ItemId + "' " +

                "Where " + ipp.pkField + "='" + p.Id + "'";
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
        public String insertItem(ItemPricePeriod p)
        {
            ItemPricePeriod item = new ItemPricePeriod();
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
            sql = "Delete From " + ipp.table;
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
                item.Value = dt.Rows[i][ipp.Id].ToString();
                item.Text = dt.Rows[i][ipp.PeriodStart].ToString() + " " + dt.Rows[i][ipp.PeriodEnd].ToString();
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
                item.Value = dt.Rows[i][ipp.Id].ToString();
                item.Text = dt.Rows[i][ipp.PeriodStart].ToString() + " " + dt.Rows[i][ipp.PeriodEnd].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidItem(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + ipp.table + " Set " + ipp.Active + "='3' " +
                "Where " + ipp.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
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
