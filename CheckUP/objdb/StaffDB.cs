using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class StaffDB
    {
        ConnectDB conn;
        public Staff sf;
        public StaffDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sf = new Staff();
            sf.Id = "staff_id";
            sf.Code = "staff_code";
            sf.NameT = "staff_name_t";
            sf.Remark = "staff_remark";
            sf.Password = "staff_password";
            sf.Active = "staff_active";
            sf.Priority = "priority";
            sf.PositionName = "position_name";
            sf.dateCancel = "date_cancel";
            sf.dateCreate = "date_create";
            sf.dateModi = "date_modi";
            sf.userCancel = "user_cancel";
            sf.userCreate = "user_create";
            sf.userModi = "user_modi";
            sf.Mobile = "mobile";
            sf.Tele = "tele";
            sf.Email = "email";
            sf.Fax = "fax";
            sf.PositionId = "position_id";

            sf.sited = "";
            sf.table = "b_staff";
            sf.pkField = "staff_id";
        }
        private Staff setData(Staff item,DataTable dt)
        {
            item.Id = dt.Rows[0][sf.Id].ToString();
            item.Code = dt.Rows[0][sf.Code].ToString();
            item.NameT = dt.Rows[0][sf.NameT].ToString();
            item.Remark = dt.Rows[0][sf.Remark].ToString();
            item.Password = dt.Rows[0][sf.Password].ToString();
            item.Active = dt.Rows[0][sf.Active].ToString();
            item.Priority = dt.Rows[0][sf.Priority].ToString();
            item.PositionName = dt.Rows[0][sf.PositionName].ToString();
            item.dateCancel = dt.Rows[0][sf.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][sf.dateCreate].ToString();
            item.dateModi = dt.Rows[0][sf.dateModi].ToString();
            item.userCancel = dt.Rows[0][sf.userCancel].ToString();
            item.userCreate = dt.Rows[0][sf.userCreate].ToString();
            item.userModi = dt.Rows[0][sf.userModi].ToString();
            item.Tele = dt.Rows[0][sf.Tele].ToString();
            item.Fax = dt.Rows[0][sf.Fax].ToString();
            item.Email = dt.Rows[0][sf.Email].ToString();
            item.Mobile = dt.Rows[0][sf.Mobile].ToString();
            item.PositionId = dt.Rows[0][sf.PositionId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sf.table + " Where " + sf.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectPositionAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From f_position Where position_active='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public Staff selectByPk(String saleId)
        {
            Staff item = new Staff();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sf.table + " Where " + sf.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public Staff selectByCode(String sfId)
        {            
            Staff item = new Staff();
            String sql = "";
            //DataTable dt = new DataTable();
            if (sfId.Equals("pop"))
            {
                item.Code = "pop";
                item.NameT = "Administrator";
                item.Password = "pop";
                item.Priority = "3";
                return item;
            }
            sql = "Select * From " + sf.table + " Where " + sf.Code + "='" + sfId + "' and "+sf.Active+"='1' ";
            //dt = conn.selectData(sql);
            conn.selectDataN(sql);
            if (conn.dt.Rows.Count > 0)
            {
                item = setData(item, conn.dt);
            }
            return item;
        }
        private String insert(Staff p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "sf"+p.getGenID();
            }
            p.NameT = p.NameT.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Insert Into " + sf.table + " (" + sf.pkField + "," + sf.NameT + "," + sf.Remark + "," +
                sf.Active + "," + sf.Code + "," + sf.Priority + "," + 
                sf.PositionName + "," + sf.Tele + "," + sf.Fax + "," +
                sf.Email + "," + sf.Mobile + "," + sf.PositionId + ") " +
                "Values('" + p.Id + "','" + p.NameT + "','" + p.Remark + "','" +
                p.Active + "','" + p.Code + "','" + p.Priority + "','" + 
                p.PositionName + "','" + p.Tele + "','" + p.Fax + "','" +
                p.Email + "','" + p.Mobile + "','" + p.PositionId + "')";
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
        private String update(Staff p)
        {
            String sql = "", chk = "";

            p.NameT = p.NameT.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");
            p.PositionName = p.PositionName.Replace("'", "''");

            sql = "Update " + sf.table + " Set " + sf.NameT + "='" + p.NameT + "', " +
                sf.Remark + "='" + p.Remark + "', " +
                sf.Code + "='" + p.Code + "', " +
                sf.Priority + "='" + p.Priority + "', " +
                sf.PositionName + "='" + p.PositionName + "', " +
                sf.Tele + "='" + p.Tele + "', " +
                sf.Fax + "='" + p.Fax + "', " +
                sf.Email + "='" + p.Email + "', " +
                sf.Mobile + "='" + p.Mobile + "', " +
                sf.PositionId + "='" + p.PositionId + "'  " +
                "Where " + sf.pkField + "='" + p.Id + "'";
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
        public String insertStaff(Staff p)
        {
            Staff item = new Staff();
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
            sql = "Delete From " + sf.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboStaff(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][sf.Id].ToString();
                item.Text = dt.Rows[i][sf.NameT].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public ComboBox getCboStaff(ComboBox c, String selectedId)
        {
            ComboBoxItem item = new ComboBoxItem();
            ComboBoxItem se = new ComboBoxItem();
            DataTable dt = selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][sf.Id].ToString();
                item.Text = dt.Rows[i][sf.NameT].ToString();
                c.Items.Add(item);
                if (item.Value.Equals(selectedId))
                {
                    se = item;
                }
                //c.Items.Add(new );
            }

            c.SelectedItem = se;
            return c;
        }
        public ComboBox getCboPosition(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectPositionAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i]["position_id"].ToString();
                item.Text = dt.Rows[i]["position_name_t"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public String VoidStaff(String sfId)
        {
            String sql = "", chk = "";

            sql = "Update " + sf.table + " Set " + sf.Active + "='3' " +
                "Where " + sf.pkField + "='" + sfId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updatePassword(String sfId, String password)
        {
            String sql = "", chk = "";

            sql = "Update " + sf.table + " Set " + sf.Password + "='" + password + "' " +
                "Where " + sf.pkField + "='" + sfId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
