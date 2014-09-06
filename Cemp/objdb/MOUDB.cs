using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class MOUDB
    {
        ConnectDB conn;
        public MOU mo;
        public MOUDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            mo = new MOU();
            mo.Active = "mou_active";
            mo.CompAddress1 = "comp_address1";
            mo.CompAddress2 = "comp_address2";
            mo.CompId = "comp_id";
            mo.CompName = "comp_name";
            mo.CompTaxId = "comp_tax_id";
            mo.ContactName = "contact_name";
            mo.CustAddress = "cust_address";
            mo.CustEmail = "cust_email";
            mo.CustFax = "cust_fax";
            mo.CustMobile = "cust_mobile";
            mo.CustMou = "cust_mou";
            mo.CustName = "cust_name";
            mo.CustTel = "cust_tel";
            mo.Id = "mou_id";
            mo.Line1 = "line1";
            mo.MOUNumber = "mou_number";
            mo.QuoId = "quo_id";
            mo.QuoNumber = "quo_number";
            mo.Remark = "remark";
            mo.StaffEmail = "staff_email";
            mo.StaffId = "staff_id";
            mo.StaffMOU = "staff_mou";
            mo.StaffName = "staff_name";
            mo.StaffTel = "staff_tel";
            mo.MOUNumberCnt = "mou_number_cnt";
            mo.statusMOU = "status_mou";
            mo.DatePeriod = "date_period";
            mo.CustId = "cust_id";
            mo.StaffMobile = "staff_mobile";

            mo.pkField = "mou_id";
            mo.table = "t_mou";
        }
        private MOU setData(MOU item, DataTable dt)
        {
            item.Active = dt.Rows[0][mo.Active].ToString();
            item.CompAddress1 = dt.Rows[0][mo.CompAddress1].ToString();
            item.CompAddress2 = dt.Rows[0][mo.CompAddress2].ToString();
            item.CompId = dt.Rows[0][mo.CompId].ToString();
            item.CompName = dt.Rows[0][mo.CompName].ToString();
            item.CompTaxId = dt.Rows[0][mo.CompTaxId].ToString();
            item.ContactName = dt.Rows[0][mo.ContactName].ToString();
            item.CustAddress = dt.Rows[0][mo.CustAddress].ToString();
            item.CustEmail = dt.Rows[0][mo.CustEmail].ToString();
            item.CustFax = dt.Rows[0][mo.CustFax].ToString();
            item.CustMobile = dt.Rows[0][mo.CustMobile].ToString();
            item.CustMou = dt.Rows[0][mo.CustMou].ToString();
            item.CustName = dt.Rows[0][mo.CustName].ToString();
            item.CustTel = dt.Rows[0][mo.CustTel].ToString();
            item.Id = dt.Rows[0][mo.Id].ToString();
            item.Line1 = dt.Rows[0][mo.Line1].ToString();
            item.MOUNumber = dt.Rows[0][mo.MOUNumber].ToString();
            item.QuoId = dt.Rows[0][mo.QuoId].ToString();
            item.QuoNumber = dt.Rows[0][mo.QuoNumber].ToString();
            item.Remark = dt.Rows[0][mo.Remark].ToString();
            item.StaffEmail = dt.Rows[0][mo.StaffEmail].ToString();
            item.StaffId = dt.Rows[0][mo.StaffId].ToString();
            item.StaffMOU = dt.Rows[0][mo.StaffMOU].ToString();
            item.StaffName = dt.Rows[0][mo.StaffName].ToString();
            item.StaffTel = dt.Rows[0][mo.StaffTel].ToString();
            item.MOUNumberCnt = dt.Rows[0][mo.MOUNumberCnt].ToString();
            item.statusMOU = dt.Rows[0][mo.statusMOU].ToString();
            item.DatePeriod = dt.Rows[0][mo.DatePeriod].ToString();
            item.CustId = dt.Rows[0][mo.CustId].ToString();
            item.StaffMobile = dt.Rows[0][mo.StaffMobile].ToString();
            
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + mo.table + " Where " + mo.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        //public DataTable selectDistinctRemark1()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select Distinct " + mo.Remark1 + " From " + mo.table + " Where " + mo.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        //public DataTable selectDistinctRemark2()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select Distinct " + mo.Remark2 + " From " + mo.table + " Where " + mo.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        //public DataTable selectDistinctRemark3()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select Distinct " + mo.Remark3 + " From " + mo.table + " Where " + mo.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        public MOU selectByPk(String saleId)
        {
            MOU item = new MOU();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + mo.table + " Where " + mo.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public MOU selectByNumber(String moId)
        {
            MOU item = new MOU();
            String sql = "";

            sql = "Select * From " + mo.table + " Where " + mo.MOUNumber + "='" + moId + "'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, conn.dt);
            }
            return item;
        }
        private String insert(MOU p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "mo" + p.getGenID();
            }

            p.CompAddress1 = p.CompAddress1.Replace("''", "'");
            p.CompAddress2 = p.CompAddress2.Replace("''", "'");
            p.CompName = p.CompName.Replace("''", "'");
            p.ContactName = p.ContactName.Replace("''", "'");
            p.CustAddress = p.CustAddress.Replace("''", "'");
            p.CustName = p.CustName.Replace("''", "'");
            p.StaffMOU = p.StaffMOU.Replace("''", "'");
            p.StaffName = p.StaffName.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            sql = "Insert Into " + mo.table + " (" + mo.pkField + "," + mo.Active + "," + mo.CompAddress1 + "," +
                mo.CompAddress2 + "," + mo.CompId + "," + mo.CompName + "," +
                mo.CompTaxId + "," + mo.ContactName + "," + mo.CustAddress + "," +
                mo.CustEmail + "," + mo.CustFax + "," + mo.CustMobile + "," +
                mo.CustMou + "," + mo.CustName + "," + mo.CustTel + "," +
                mo.Line1 + "," + mo.MOUNumber + "," + mo.QuoId + "," +
                mo.QuoNumber + "," + mo.Remark + "," + mo.StaffEmail + "," +
                mo.StaffId + "," + mo.StaffMOU + "," + mo.StaffName + "," +
                mo.StaffTel + "," + mo.MOUNumberCnt + "," + mo.Remark + "," +
                mo.statusMOU + "," + mo.DatePeriod + "," + mo.CustId + "," + mo.StaffMobile + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.CompAddress1 + "','" +
                p.CompAddress2 + "','" + p.CompId + "','" + p.CompName + "','" +
                p.CompTaxId + "','" + p.ContactName + "','" + p.CustAddress + "','" +
                p.CustEmail + "','" + p.CustFax + "','" + p.CustMobile + "','" +
                p.CustMou + "','" + p.CustName + "','" + p.CustTel + "','" +
                p.Line1 + "','" + p.MOUNumber + "','" + p.QuoId + ",'" +
                p.QuoNumber + "','" + p.Remark + "','" + p.StaffEmail + "','" +
                p.StaffId + "','" + p.StaffMOU + "','" + p.StaffName + "','" +
                p.StaffTel + "','" + p.MOUNumberCnt + "','" + p.Remark + "','" +
                p.statusMOU + "','" + p.DatePeriod + "','" + p.CustId + "','" + p.StaffMobile + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert MOU");
            }
            finally
            {
            }
            return chk;
        }
        private String update(MOU p)
        {
            String sql = "", chk = "";

            p.CompAddress1 = p.CompAddress1.Replace("''", "'");
            p.CompAddress2 = p.CompAddress2.Replace("''", "'");
            p.CompName = p.CompName.Replace("''", "'");
            p.ContactName = p.ContactName.Replace("''", "'");
            p.CustAddress = p.CustAddress.Replace("''", "'");
            p.CustName = p.CustName.Replace("''", "'");
            p.StaffMOU = p.StaffMOU.Replace("''", "'");
            p.StaffName = p.StaffName.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");

            sql = "Update " + mo.table + " Set " + mo.CompAddress1 + "=" + p.CompAddress1 + ", " +
                mo.CompAddress2 + "=" + p.CompAddress2 + ", " +
                mo.CompId + "='" + p.CompId + "', " +
                mo.CompName + "='" + p.CompName + "', " +
                mo.CompTaxId + "='" + p.CompTaxId + "', " +
                mo.ContactName + "='" + p.ContactName + "', " +
                mo.CustAddress + "=" + p.CustAddress + ", " +
                mo.CustEmail + "=" + p.CustEmail + ", " +
                mo.CustFax + "='" + p.CustFax + "', " +
                mo.CustMobile + "='" + p.CustMobile + "', " +
                mo.CustMou + "='" + p.CustMou + "', " +
                mo.CustName + "='" + p.CustName + "', " +
                mo.CustTel + "='" + p.CustTel + "', " +
                mo.Line1 + "='" + p.Line1 + "', " +
                mo.MOUNumber + "='" + p.MOUNumber + "', " +
                mo.QuoId + "='" + p.QuoId + "', " +
                mo.QuoNumber + "='" + p.QuoNumber + "', " +
                mo.Remark + "='" + p.Remark + "', " +
                mo.StaffEmail + "='" + p.StaffEmail + "', " +
                mo.StaffId + "='" + p.StaffId + "', " +
                mo.StaffMOU + "='" + p.StaffMOU + "', " +
                mo.StaffName + "='" + p.StaffName + "', " +
                mo.StaffTel + "='" + p.StaffTel + "', " +
                mo.MOUNumberCnt + "='" + p.MOUNumberCnt + "', " +
                mo.DatePeriod + "='" + p.DatePeriod + "', " +
                mo.Remark + "='" + p.Remark + "', " +
                mo.CustId + "='" + p.CustId + "', " +
                mo.StaffMobile + "='" + p.StaffMobile + "' " +
                "Where " + mo.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update MOU");
            }
            finally
            {
            }
            return chk;
        }
        public String insertMOU(MOU p)
        {
            MOU item = new MOU();
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
            sql = "Delete From " + mo.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String VoidMOU(String mod)
        {
            String sql = "", chk = "";

            sql = "Update " + mo.table + " Set " + mo.Active + "='3' " +
                "Where " + mo.pkField + "='" + mod + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        //public ComboBox getCboItemDescription(ComboBox c)
        //{
        //    ComboBoxItem item = new ComboBoxItem();
        //    DataTable dt = selectDistinctItemDescription();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        item = new ComboBoxItem();
        //        item.Value = dt.Rows[i][mo.ItemDescription].ToString();
        //        item.Text = dt.Rows[i][mo.ItemDescription].ToString();
        //        c.Items.Add(item);
        //        //c.Items.Add(new );
        //    }
        //    //c.SelectedItem = item;
        //    return c;
        //}
    }
}
