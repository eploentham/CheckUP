using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class PODB
    {
        public PO po;
        ConnectDB conn;
        public PODB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            po = new PO();
            po.Active = "po_active";
            po.ContactName = "contact_name";
            po.CpId = "comp_id";
            po.CpNameT = "comp_name_t";
            po.CuFax = "cust_fax";
            po.CuId = "cust_id";
            po.CuNametT = "cust_name_t";
            po.CustEmail = "cust_email";
            po.CuTel = "cust_tel";
            po.DateCancel = "date_cancel";
            po.DateCreate = "date_create";
            po.DateModi = "date_modi";
            po.PODate = "po_date";
            po.PODurPeriod = "po_due_period";
            po.Id = "po_id";
            po.PONumber = "po_number";
            po.QuId = "quo_id";
            po.QuNumber = "quo_number";
            po.SfEmail = "staff_email";
            po.SfId = "staff_id";
            po.SfName = "staff_name";
            po.SfTel = "staff_tel";
            po.StatusApprove = "status_approve";
            po.StatusPO = "status_po";
            po.UserCancel = "user_cancel";
            po.UserCreate = "user_create";
            po.UserModi = "user_modi";
            po.PONumberCnt = "po_number_cnt";

            po.pkField = "po_id";
            po.table = "t_po";
        }
        private PO setData(PO item, DataTable dt)
        {
            item.Active = dt.Rows[0][po.Active].ToString();
            item.ContactName = dt.Rows[0][po.ContactName].ToString();
            item.CpId = dt.Rows[0][po.CpId].ToString();
            item.CpNameT = dt.Rows[0][po.CpNameT].ToString();
            item.CuFax = dt.Rows[0][po.CuFax].ToString();
            item.CuId = dt.Rows[0][po.CuId].ToString();
            item.CuNametT = dt.Rows[0][po.CuNametT].ToString();
            item.CustEmail = dt.Rows[0][po.CustEmail].ToString();
            item.CuTel = dt.Rows[0][po.CuTel].ToString();
            item.DateCancel = dt.Rows[0][po.DateCancel].ToString();
            item.DateCreate = dt.Rows[0][po.DateCreate].ToString();
            item.DateModi = dt.Rows[0][po.DateModi].ToString();
            item.PODate = dt.Rows[0][po.PODate].ToString();
            item.PODurPeriod = dt.Rows[0][po.PODurPeriod].ToString();
            item.Id = dt.Rows[0][po.Id].ToString();
            item.PONumber = dt.Rows[0][po.PONumber].ToString();
            item.QuId = dt.Rows[0][po.QuId].ToString();
            item.QuNumber = dt.Rows[0][po.QuNumber].ToString();
            item.SfEmail = dt.Rows[0][po.SfEmail].ToString();
            item.SfId = dt.Rows[0][po.SfId].ToString();
            item.SfName = dt.Rows[0][po.SfName].ToString();
            item.SfTel = dt.Rows[0][po.SfTel].ToString();
            item.StatusApprove = dt.Rows[0][po.StatusApprove].ToString();
            item.StatusPO = dt.Rows[0][po.StatusPO].ToString();
            item.UserCancel = dt.Rows[0][po.UserCancel].ToString();
            item.UserCreate = dt.Rows[0][po.UserCreate].ToString();
            item.UserModi = dt.Rows[0][po.UserModi].ToString();
            item.PONumberCnt = dt.Rows[0][po.PONumberCnt].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + po.table + " Where " + po.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public PO selectByPk(String saleId)
        {
            PO item = new PO();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + po.table + " Where " + po.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(PO p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "po" + p.getGenID();
            }
            p.ContactName = p.ContactName.Replace("'", "''");
            p.CpNameT = p.CpNameT.Replace("'", "''");
            p.CuNametT = p.CuNametT.Replace("'", "'");
            p.SfName = p.SfName.Replace("'", "''");
            //p.MethodMeasure = p.MethodMeasure.Replace("'", "''");
            //p.Summary = p.Summary.Replace("'", "''");
            p.PONumberCnt = "1";
            sql = "Insert Into " + po.table + " (" + po.pkField + "," + po.Active + "," + po.ContactName + "," +
                po.CpId + "," + po.CpNameT + "," + po.CuFax + "," +
                po.CuId + "," + po.CuNametT + "," + po.CustEmail + "," +
                po.CuTel + "," + po.DateCancel + "," + po.DateCreate + "," +
                po.DateModi + "," + po.PODate + "," + po.PODurPeriod + "," +
                po.PONumber + "," + po.QuId + "," + po.QuNumber + "," + 
                po.SfEmail + "," + po.SfId + "," + po.SfName + "," +
                po.SfTel + "," + po.StatusApprove + "," + po.StatusPO + "," +
                po.UserCancel + "," + po.UserCreate + "," + po.UserModi + "," + po.PONumberCnt + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.ContactName + "','" +
                p.CpId + "','" + p.CpNameT + "','" + p.CuFax + "','" +
                p.CuId + "','" + p.CuNametT + "','" + p.CustEmail + "','" +
                p.CuTel + "','" + p.DateCancel + "'," + p.dateGenDB + ",'" +
                p.DateModi + "','" + p.PODate + "','" + p.PODurPeriod + "','" +
                p.PONumber + "','" + p.QuId + "','" + p.QuNumber + "','" + 
                p.SfEmail + "','" + p.SfId + "','" + p.SfName + "','" +
                p.SfTel + "','" + p.StatusApprove + "','" + p.StatusPO + "','" +
                p.UserCancel + "','" + p.UserCreate + "','" + p.UserModi + "'," + p.PONumberCnt + ")";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert PO");
            }
            finally
            {
            }
            return chk;
        }
        private String update(PO p)
        {
            String sql = "", chk = "";

            p.ContactName = p.ContactName.Replace("'", "''");
            p.CpNameT = p.CpNameT.Replace("'", "''");
            p.CuNametT = p.CuNametT.Replace("'", "'");
            p.SfName = p.SfName.Replace("'", "''");

            sql = "Update " + po.table + " Set " + po.ContactName + "='" + p.ContactName + "', " +
                po.CpId + "='" + p.CpId + "', " +
                po.CpNameT + "='" + p.CpNameT + "', " +
                po.CuFax + "='" + p.CuFax + "', " +
                po.CuId + "='" + p.CuId + "', " +
                po.CuNametT + "='" + p.CuNametT + "', " +
                po.CustEmail + "='" + p.CustEmail + "', " +
                po.CuTel + "='" + p.CuTel + "', " +
                po.DateModi + "=" + p.dateGenDB + ", " +
                po.PODate + "='" + p.PODate + "', " +
                po.PODurPeriod + "='" + p.PODurPeriod + "', " +
                po.PONumber + "='" + p.PONumber + "', " +
                po.QuId + "='" + p.QuId + "', " +
                po.QuNumber + "='" + p.QuNumber + "', " +
                po.SfEmail + "='" + p.SfEmail + "', " +
                po.SfId + "='" + p.SfId + "', " +
                po.SfName + "='" + p.SfName + "', " +
                po.SfTel + "='" + p.SfTel + "', " +
                po.StatusApprove + "='" + p.StatusApprove + "', " +
                po.StatusPO + "='" + p.StatusPO + "', " +
                po.PONumberCnt + "=" + p.PONumberCnt + ", " +
                po.UserModi + "='" + p.UserModi + "' " +
                //po.MethodMeasure + "='" + p.MethodMeasure + "', " +
                //po.Summary + "='" + p.Summary + "' " +

                "Where " + po.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update PO");
            }
            finally
            {
            }
            return chk;
        }
        public String insertPO(PO p)
        {
            PO item = new PO();
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
            sql = "Delete From " + po.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String getPONumber()
        {
            String sql = "", year = "", doc="";
            year = getYear();
            sql = "Select count(1) as cnt From " + po.table + " ";
            DataTable dt = conn.selectData(sql);
            doc = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
            doc = "00000" + doc;
            doc = doc.Substring(0, doc.Length - 5);
            return "PO"+year + doc;
        }
        public String getYear()
        {
            String year = "";
            if (System.DateTime.Now.Year > 2550)
            {
                year = System.DateTime.Now.Year.ToString().Substring(2);
            }
            else
            {
                year = String.Concat(System.DateTime.Now.Year + 543);
            }
            year = year.Substring(2);
            return year;
        }
    }
}
