using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class PrefixDB
    {
        private ConnectDB conn;
        public Prefix pre;
        public PrefixDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            pre = new Prefix();
            pre.Active = "prefix_active";
            pre.Id = "prefix_id";
            pre.NameE = "prefix_name_e";
            pre.NameT = "prefix_name_t";
            //pre.Active = "";

            pre.pkField = "prefix_id";
            pre.table = "b_prefix";
        }
        private Prefix setData(Prefix item, DataTable dt)
        {
            item.Active = dt.Rows[0][pre.Active].ToString();
            item.Id = dt.Rows[0][pre.Id].ToString();
            item.NameE = dt.Rows[0][pre.NameE].ToString();
            item.NameT = dt.Rows[0][pre.NameT].ToString();
            //item.Email = dt.Rows[0][cp.Email].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + pre.table + "  Order By " + pre.NameT;
            dt = conn.selectData(sql);

            return dt;
        }
        public Prefix selectByPk(String cuId)
        {
            Prefix item = new Prefix();
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + pre.table + "  Where " + pre.pkField + "='" + cuId + "'";
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }

            return item;
        }

        private String insert(Prefix p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "cp" + p.getGenID();
            }
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");

            sql = "Insert Into " + pre.table + " (" + pre.pkField + "," + pre.NameE + "," + pre.NameT + "," +
                pre.Active + ") " +
                "Values('" + p.Id + "','" + p.NameE + "','" + p.NameT + "','" +
                p.Active + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Prefix");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Prefix p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");

            sql = "Update " + pre.table + " Set " + pre.NameE + "='" + p.NameE + "', " +
                pre.NameT + "='" + p.NameT + "' " +
                //cp.rsLine2 + "='" + p.rsLine2 + "', " +

                "Where " + pre.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Prefix");
            }
            finally
            {
            }
            return chk;
        }
        public String insertBank(Prefix p)
        {
            Prefix item = new Prefix();
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
        public ComboBox getCboPrefix(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][pre.Id].ToString();
                item.Text = dt.Rows[i][pre.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
