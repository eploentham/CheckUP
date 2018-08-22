using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class StickerDB
    {
        public Sticker stk;
        ConnectDB conn, connOnSite;

        public StickerDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            stk = new Sticker();
            stk.sticker_code = "sticker_code";
            stk.sticker_id = "sticker_id";
            stk.sticker_name = "sticker_name";

            stk.table = "b_sticker";
            stk.pkField = "sticker_id";
        }
        public String deleteOnSiteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + stk.table;
            connOnSite = new ConnectDB(conn.initc, ConnectDB.flagOnSite.OnSite);
            chk = connOnSite.ExecuteNonQuery(sql);
            
            return chk;
        }
        public String insertToOnSite()
        {
            String sql = "", chk = "";
            DataTable dt = new DataTable();
            dt = selectAll();
            sql = "Delete From " + stk.table;
            connOnSite = new ConnectDB(conn.initc, ConnectDB.flagOnSite.OnSite);
            chk = connOnSite.ExecuteNonQuery(sql);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                sql = "Insert Into "+stk.table+"("+stk.sticker_id+"," + stk.sticker_code+ "," + stk.sticker_name + ") " +
                    "Values ('"+dt.Rows[i][stk.sticker_id].ToString()+"','"+ dt.Rows[i][stk.sticker_code].ToString()+"','"+ dt.Rows[i][stk.sticker_name].ToString().Replace("'","''") + "')";
                chk = connOnSite.ExecuteNonQuery(sql);
            }
            //sql = "insert into " + conn.initc.nameRemoteClient + "." + conn.initc.nameDBonsite + ".dbo." + "onsite_" + stk.table + " " +
            //    "select * from " + stk.table + " " ;
            ////MessageBox.Show("SQL " + sql, "message ");
            //chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + stk.table + "  Order By " + stk.sticker_code + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public Sticker selectByPk(String cuId)
        {
            Sticker item = new Sticker();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + stk.table + " Where " + stk.pkField + "='" + cuId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(dt);
            }
            return item;
        }
        private Sticker setData(DataTable dt)
        {
            Sticker stk1 = new Sticker();
            stk1.sticker_code = dt.Rows[0][stk.sticker_code].ToString();
            stk1.sticker_id = dt.Rows[0][stk.sticker_id].ToString();
            stk1.sticker_name = dt.Rows[0][stk.sticker_name].ToString();

            return stk1;
        }
        public String update(String id, String name)
        {
            String sql = "", chk = "";            

            sql = "Update " + stk.table + " Set " + stk.sticker_name + "='" + name.Replace("'","''") + "' " +
                "Where " + stk.pkField + "='" + id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update ");
            }
            finally
            {
            }
            return chk;
        }
        public ComboBox getCboSticker(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            c.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                
                item.Text = dt.Rows[i][stk.sticker_code].ToString()+" "+dt.Rows[i][stk.sticker_name].ToString();                
                item.Value = dt.Rows[i][stk.sticker_code].ToString();
                //item.Text = dt.Rows[i][cu.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
