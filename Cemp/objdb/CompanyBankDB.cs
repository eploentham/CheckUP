using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class CompanyBankDB
    {
        ConnectDB conn;
        public CompanyBank cob;
        public CompanyBankDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            cob = new CompanyBank();
            cob.AccNumber = "acc_number";
            cob.Active = "comp_bank_active";
            cob.Branch = "comp_bank_branch";
            cob.Id = "comp_bank_id";
            cob.NameT = "comp_bank_name_t";
            cob.Remark = "remark";

            cob.pkField = "comp_bank_id";
            cob.table = "b_company_bank";
        }
        private CompanyBank setData(CompanyBank item, DataTable dt)
        {
            item.AccNumber = dt.Rows[0][cob.AccNumber].ToString();
            item.Active = dt.Rows[0][cob.Active].ToString();
            item.Branch = dt.Rows[0][cob.Branch].ToString();
            item.Id = dt.Rows[0][cob.Id].ToString();
            item.NameT = dt.Rows[0][cob.NameT].ToString();
            item.Remark = dt.Rows[0][cob.Remark].ToString();
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cob.table + " Where " + cob.Active + "='1' ";
            dt = conn.selectData(sql);

            return dt;
        }
        public CompanyBank selectByPk(String cuId)
        {
            CompanyBank item = new CompanyBank();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cob.table + " Where " + cob.pkField + "='" + cuId + "'";
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
            sql = "Select count(1) as cnt  From " + cob.table;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = "000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt;
        }

        public CompanyBank selectByNameT(String cuId)
        {
            CompanyBank item = new CompanyBank();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cob.table + " Where " + cob.NameT + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(CompanyBank p)
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
            p.Branch = p.Branch.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Insert Into " + cob.table + " (" + cob.pkField + "," + cob.AccNumber + "," + cob.Active + "," +
                cob.Branch + "," + cob.NameT + "," + cob.Remark + ") " +
                "Values('" + p.Id + "','" + p.AccNumber + "','" + p.Active + "','" +
                p.Branch + p.NameT + "','" + p.Remark + "','" + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert CompanyBank");
            }
            finally
            {
            }
            return chk;
        }
        private String update(CompanyBank p)
        {
            String sql = "", chk = "";

            p.Branch = p.Branch.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            //if (p.Sort1.Equals(""))
            //{
            //    p.Sort1 = "999";
            //}
            sql = "Update " + cob.table + " Set " + cob.AccNumber + "='" + p.AccNumber + "', " +
                cob.Branch + "='" + p.Branch + "', " +
                cob.NameT + "='" + p.NameT + "', " +
                cob.Remark + "='" + p.Remark + "' " +

                "Where " + cob.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update CompanyBank");
            }
            finally
            {
            }
            return chk;
        }
        public String insertCompanyBany(CompanyBank p)
        {
            CompanyBank item = new CompanyBank();
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
            sql = "Delete From " + cob.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboCompanyBany(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            c.Items.Clear();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][cob.Id].ToString();
                item.Text = dt.Rows[i][cob.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidCompanyBany(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + cob.table + " Set " + cob.Active + "='3' " +
                "Where " + cob.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
