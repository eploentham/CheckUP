using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class ItemGroupDB
    {
        ConnectDB conn;
        public ItemGroup itg;
        public ItemGroupDB(ConnectDB c)
        {
            conn= c;
            initConfig();
        }
        private void initConfig()
        {
            itg = new ItemGroup();
            itg.Active = "item_group_active";
            itg.Id = "item_group_id";
            itg.NameE = "item_group_name_e";
            itg.NameT = "item_group_name_t";
            itg.Remark = "item_group_remark";
            itg.Sort1 = "sort1";

            itg.table = "b_item_group";
            itg.pkField = "item_group_id";
        }
        private ItemGroup setData(ItemGroup item, DataTable dt)
        {
            item.Active = dt.Rows[0][itg.Active].ToString();
            //item.Code = dt.Rows[0][itg.Code].ToString();
            item.Id = dt.Rows[0][itg.Id].ToString();
            item.NameE = dt.Rows[0][itg.NameE].ToString();
            item.NameT = dt.Rows[0][itg.NameT].ToString();
            item.Remark = dt.Rows[0][itg.Remark].ToString();
            item.Sort1 = dt.Rows[0][itg.Sort1].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + itg.table + " Where " + itg.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ItemGroup selectByPk(String cuId)
        {
            ItemGroup item = new ItemGroup();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + itg.table + " Where " + itg.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String selectMax()
        {
            //ItemGroup item = new ItemGroup();
            String sql = "", cnt="999";
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt  From " + itg.table ;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = "000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt;
        }
        public ItemGroup selectByNameT(String cuId)
        {
            ItemGroup item = new ItemGroup();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + itg.table + " Where " + itg.NameT + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        //public ItemGroup selectByCode(String cuId)
        //{
        //    ItemGroup item = new ItemGroup();
        //    String sql = "";

        //    sql = "Select * From " + itg.table + " Where " + itg.Code + "='" + cuId + "' and " + itg.Active + "='1' ";
        //    //dt = conn.selectData(sql);
        //    DataTable dt = conn.selectData(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        item = setData(item, dt);
        //    }
        //    return item;
        //}
        private String insert(ItemGroup p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "itg" + p.getGenID();
            }

            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "999";
            }
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");

            sql = "Insert Into " + itg.table + " (" + itg.pkField + "," + itg.Active + "," + itg.NameE + "," +
                itg.NameT + "," + itg.Remark + "," + itg.Sort1 + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.NameE + "','" +
                p.NameT + "','" + p.Remark + "','" + p.Sort1 + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert ItemGroup");
            }
            finally
            {
            }
            return chk;
        }
        private String update(ItemGroup p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "999";
            }
            sql = "Update " + itg.table + " Set " + itg.NameE + "='" + p.NameE + "', " +
                //itg.NameE + "='" + p.NameE + "', " +
                itg.NameT + "='" + p.NameT + "', " +
                itg.Remark + "='" + p.Remark + "', " +
                itg.Sort1 + "='" + p.Sort1 + "' " +

                "Where " + itg.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update ItemGroup");
            }
            finally
            {
            }
            return chk;
        }
        public String insertItemGroup(ItemGroup p)
        {
            ItemGroup item = new ItemGroup();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
                p.Active = "1";
                if (p.Sort1.Equals(""))
                {
                    p.Sort1 = selectMax();
                }
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
            sql = "Delete From " + itg.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboItemGroup(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            c.Items.Clear();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][itg.Id].ToString();
                item.Text = dt.Rows[i][itg.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidItemGroup(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + itg.table + " Set " + itg.Active + "='3' " +
                "Where " + itg.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
