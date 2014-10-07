using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class AnalysisDB
    {
        ConnectDB conn;
        public Analysis an;
        public AnalysisDB(ConnectDB c)
        {
            conn= c;
            initConfig();
        }
        private void initConfig()
        {
            an = new Analysis();
            an.Active = "analysis_active";
            an.Id = "analysis_id";
            an.NameE = "analysis_name_e";
            an.NameT = "analysis_name_t";
            an.Remark = "analysis_remark";
            an.Sort1 = "sort1";
            an.dateCancel = "date_cancel";
            an.dateCreate = "date_create";
            an.dateModi = "date_modi";
            //itg.DatePlaceRecord = "date_place_record";
            an.userCancel = "user_cancel";
            an.userCreate = "user_create";
            an.userModi = "user_modi";

            an.table = "b_analysis";
            an.pkField = "analysis_id";
        }
        private Analysis setData(Analysis item, DataTable dt)
        {
            item.Active = dt.Rows[0][an.Active].ToString();
            //item.Code = dt.Rows[0][itg.Code].ToString();
            item.Id = dt.Rows[0][an.Id].ToString();
            item.NameE = dt.Rows[0][an.NameE].ToString();
            item.NameT = dt.Rows[0][an.NameT].ToString();
            item.Remark = dt.Rows[0][an.Remark].ToString();
            item.Sort1 = dt.Rows[0][an.Sort1].ToString();
            item.dateCancel = dt.Rows[0][an.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][an.dateCreate].ToString();
            item.dateModi = dt.Rows[0][an.dateModi].ToString();
            //item.DatePlaceRecord = dt.Rows[0][mo.DatePlaceRecord].ToString();
            item.userCancel = dt.Rows[0][an.userCancel].ToString();
            item.userCreate = dt.Rows[0][an.userCreate].ToString();
            item.userModi = dt.Rows[0][an.userModi].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + an.table + " Where " + an.Active + "='1' Order By "+an.Sort1;
            dt = conn.selectData(sql);

            return dt;
        }
        public Analysis selectByPk(String cuId)
        {
            Analysis item = new Analysis();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + an.table + " Where " + an.pkField + "='" + cuId + "'";
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
            sql = "Select count(1) as cnt  From " + an.table ;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = "000" + String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt;
        }

        public String selectSortMax()
        {
            String sql = "";
            int cnt = 0;
            DataTable dt = new DataTable();
            sql = "Select count(1) as cnt  From " + an.table;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                cnt = (100 + int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                //cnt = cnt.Substring(cnt.Length - 3); ;
            }
            return cnt.ToString();
        }
        public Analysis selectByNameT(String cuId)
        {
            Analysis item = new Analysis();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + an.table + " Where " + an.NameT + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String selectByNameT1(String cuId)
        {
            Analysis item = new Analysis();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select "+an.Id+" From " + an.table + " Where " + an.NameT + "='" + cuId.Replace("'","''") + "'";
            dt = conn.selectData(sql);
            sql = "";
            if (dt.Rows.Count > 0)
            {
                sql = dt.Rows[0][an.Id].ToString();
            }
            return sql;
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
        private String insert(Analysis p)
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

            sql = "Insert Into " + an.table + " (" + an.pkField + "," + an.Active + "," + an.NameE + "," +
                an.NameT + "," + an.Remark + "," + an.Sort1 + "," + 
                an.dateCancel + "," + an.dateCreate + "," + an.dateModi + "," + 
                an.userCancel + "," + an.userCreate + "," + an.userModi + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.NameE + "','" +
                p.NameT + "','" + p.Remark + "','" + p.Sort1 + "','" + 
                p.dateCancel + "'," +p.dateGenDB + ",'" + p.dateModi + "','" + 
                p.userCancel + "','" +p.userCreate + "','" + p.userModi + "')";
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
        private String update(Analysis p)
        {
            String sql = "", chk = "";

            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            if (p.Sort1.Equals(""))
            {
                p.Sort1 = "999";
            }
            sql = "Update " + an.table + " Set " + an.NameE + "='" + p.NameE + "', " +
                //itg.NameE + "='" + p.NameE + "', " +
                an.NameT + "='" + p.NameT + "', " +
                an.Remark + "='" + p.Remark + "', " +
                an.Sort1 + "='" + p.Sort1 + "', " +
                an.userModi + "='" + p.userModi + "'," +
                an.dateModi + "=" + p.dateGenDB + " " +

                "Where " + an.pkField + "='" + p.Id + "'";
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
        public String insertItemGroup(Analysis p)
        {
            Analysis item = new Analysis();
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
            sql = "Delete From " + an.table;
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
                item.Value = dt.Rows[i][an.Id].ToString();
                item.Text = dt.Rows[i][an.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public String VoidItemGroup(String saleId)
        {
            String sql = "", chk = "";
            sql = "Update " + an.table + " Set " + an.Active + "='3' " +
                "Where " + an.pkField + "='" + saleId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
