using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class BankDB
    {
        ConnectDB conn;
        public Bank ban;
        public BankDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            ban = new Bank();
            ban.Active = "bank_active";
            ban.Id = "bank_id";
            ban.NameE = "bank_name_e";
            ban.NameT = "bank_name_t";

            ban.pkField = "bank_id";
            ban.table = "b_bank";
        }

        private Bank setData(Bank item, DataTable dt)
        {
            item.Active = dt.Rows[0][ban.Active].ToString();
            //item.Code = dt.Rows[0][itg.Code].ToString();
            item.Id = dt.Rows[0][ban.Id].ToString();
            item.NameE = dt.Rows[0][ban.NameE].ToString();
            item.NameT = dt.Rows[0][ban.NameT].ToString();            

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ban.table + " Where " + ban.Active + "='1' ";
            dt = conn.selectData(sql);

            return dt;
        }
        public Bank selectByPk(String cuId)
        {
            Bank item = new Bank();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ban.table + " Where " + ban.pkField + "='" + cuId + "'";
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
            String sql = "", cnt = "999";
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt  From " + ban.table;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = "000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt;
        }

        public Bank selectByNameT(String cuId)
        {
            Bank item = new Bank();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ban.table + " Where " + ban.NameT + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(Bank p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "itg" + p.getGenID();
            }

            //if (p.Sort1.Equals(""))
            //{
            //    p.Sort1 = "999";
            //}
            p.NameE = p.NameE.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("''", "'");

            sql = "Insert Into " + ban.table + " (" + ban.pkField + "," + ban.Active + "," + ban.NameE + "," +
                ban.NameT + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.NameE + "','" +
                p.NameT + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Analysis");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Bank p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");
            //p.Remark = p.Remark.Replace("''", "'");
            //if (p.Sort1.Equals(""))
            //{
            //    p.Sort1 = "999";
            //}
            sql = "Update " + ban.table + " Set " + ban.NameE + "='" + p.NameE + "', " +
                //itg.NameE + "='" + p.NameE + "', " +
                ban.NameT + "='" + p.NameT + "' " +
                //ban.Remark + "='" + p.Remark + "' " +

                "Where " + ban.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Analysis");
            }
            finally
            {
            }
            return chk;
        }
        public String insertBank(Bank p)
        {
            Bank item = new Bank();
            String chk = "";
            item = selectByPk(p.Id);
            if (item.Id == "")
            {
                p.Active = "1";
                //if (p.Sort1.Equals(""))
                //{
                //    p.Sort1 = selectMax();
                //}
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
            sql = "Delete From " + ban.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCbobank(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            c.Items.Clear();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][ban.Id].ToString();
                item.Text = dt.Rows[i][ban.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidBank(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + ban.table + " Set " + ban.Active + "='3' " +
                "Where " + ban.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
