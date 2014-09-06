using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class MethodDB
    {
        public Method me;
        ConnectDB conn;
        public MethodDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            me = new Method();
            me.Active = "method_active";
            me.Code = "method_code";
            me.Id = "method_id";
            me.NameE = "method_name_e";
            me.NameT = "method_name_t";
            me.Remark = "remark";

            me.table = "b_method";
            me.pkField = "method_id";
        }
        private Method setData(Method item, DataTable dt)
        {
            item.Active = dt.Rows[0][me.Active].ToString();
            item.Code = dt.Rows[0][me.Code].ToString();
            item.Id = dt.Rows[0][me.Id].ToString();
            item.NameE = dt.Rows[0][me.NameE].ToString();
            item.NameT = dt.Rows[0][me.NameT].ToString();
            item.Remark = dt.Rows[0][me.Remark].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + me.table + " Where " + me.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public Method selectByPk(String cuId)
        {
            Method item = new Method();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + me.table + " Where " + me.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public Method selectByCode(String cuId)
        {
            Method item = new Method();
            String sql = "";

            sql = "Select * From " + me.table + " Where " + me.Code + "='" + cuId + "' and " + me.Active + "='1' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, conn.dt);
            }
            return item;
        }
        private String insert(Method p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "cu" + p.getGenID();
            }

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");

            sql = "Insert Into " + me.table + " (" + me.pkField + "," + me.Active + "," + me.Code + "," +
                me.NameE + "," + me.NameT + "," + me.Remark + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.Code + "','" +
                p.NameE + "','" + p.NameT + "','" + p.Remark + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Method");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Method p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");

            sql = "Update " + me.table + " Set " + me.Code + "='" + p.Code + "', " +
                me.NameE + "='" + p.NameE + "', " +
                me.NameT + "='" + p.NameT + "', " +
                me.Remark + "='" + p.Remark + "' " +

                "Where " + me.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Customer");
            }
            finally
            {
            }
            return chk;
        }
        public String insertMethod(Method p)
        {
            Method item = new Method();
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
            sql = "Delete From " + me.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboMethod(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][me.Id].ToString();
                item.Text = dt.Rows[i][me.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidMethod(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + me.table + " Set " + me.Active + "='3' " +
                "Where " + me.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
