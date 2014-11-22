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
            po.CuNameT = "cust_name_t";
            po.CuEmail = "cust_email";
            po.CuTel = "cust_tel";
            po.DateCancel = "date_cancel";
            po.DateCreate = "date_create";
            po.DateModi = "date_modi";
            po.PODate = "po_date";
            po.PODuePeriod = "po_due_period";
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
            po.Remark1 = "remark1";
            po.Remark2 = "remark2";
            po.Remark3 = "remark3";
            po.Remark4 = "remark4";
            po.Remark5 = "remark5";
            po.CuAddressT = "cust_address";
            po.CpAddress1 = "comp_address1";
            po.CpAddress2 = "comp_address2";
            po.CpTaxId = "comp_tax_id";
            po.Amt = "amount";
            po.Vat = "vat";
            po.VatRate = "vat_rate";
            po.NetTotal = "nettotal";
            po.SfApproveId = "staff_approve_id";
            po.SfApproveName = "staff_approve_name";
            po.Line1 = "line1";
            po.PODueDate = "po_due_date";
            po.Ref1 = "ref1";

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
            item.CuNameT = dt.Rows[0][po.CuNameT].ToString();
            item.CuEmail = dt.Rows[0][po.CuEmail].ToString();
            item.CuTel = dt.Rows[0][po.CuTel].ToString();
            item.DateCancel = dt.Rows[0][po.DateCancel].ToString();
            item.DateCreate = dt.Rows[0][po.DateCreate].ToString();
            item.DateModi = dt.Rows[0][po.DateModi].ToString();
            item.PODate = dt.Rows[0][po.PODate].ToString();
            item.PODuePeriod = dt.Rows[0][po.PODuePeriod].ToString();
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

            item.Remark1 = dt.Rows[0][po.Remark1].ToString();
            item.Remark2 = dt.Rows[0][po.Remark2].ToString();
            item.Remark3 = dt.Rows[0][po.Remark3].ToString();
            item.Remark4 = dt.Rows[0][po.Remark4].ToString();
            item.Remark5 = dt.Rows[0][po.Remark5].ToString();

            item.CuAddressT = dt.Rows[0][po.CuAddressT].ToString();
            item.CpAddress1 = dt.Rows[0][po.CpAddress1].ToString();
            item.CpAddress2 = dt.Rows[0][po.CpAddress2].ToString();
            item.CpTaxId = dt.Rows[0][po.CpTaxId].ToString();
            item.Amt = dt.Rows[0][po.Amt].ToString();
            item.Vat = dt.Rows[0][po.Vat].ToString();
            item.VatRate = dt.Rows[0][po.VatRate].ToString();
            item.NetTotal = dt.Rows[0][po.NetTotal].ToString();
            item.SfApproveId = dt.Rows[0][po.SfApproveId].ToString();
            item.SfApproveName = dt.Rows[0][po.SfApproveName].ToString();
            item.Line1 = dt.Rows[0][po.Line1].ToString();

            item.PODueDate = dt.Rows[0][po.PODueDate].ToString();
            item.Ref1 = dt.Rows[0][po.Ref1].ToString();

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
            p.CuNameT = p.CuNameT.Replace("'", "'");
            p.SfName = p.SfName.Replace("'", "''");
            p.Remark1 = p.Remark1.Replace("'", "''");
            p.Remark2 = p.Remark2.Replace("'", "''");
            p.Remark3 = p.Remark3.Replace("'", "''");
            p.Remark4 = p.Remark4.Replace("'", "''");
            p.Remark5 = p.Remark5.Replace("'", "''");
            p.CuAddressT = p.CuAddressT.Replace("'", "''");
            p.CpAddress1 = p.CpAddress1.Replace("'", "''");
            p.CpAddress2 = p.CpAddress2.Replace("'", "''");
            p.Ref1 = p.Ref1.Replace("'", "''");
            p.PONumberCnt = "1";
            sql = "Insert Into " + po.table + " (" + po.pkField + "," + po.Active + "," + po.ContactName + "," +
                po.CpId + "," + po.CpNameT + "," + po.CuFax + "," +
                po.CuId + "," + po.CuNameT + "," + po.CuEmail + "," +
                po.CuTel + "," + po.DateCancel + "," + po.DateCreate + "," +
                po.DateModi + "," + po.PODate + "," + po.PODuePeriod + "," +
                po.PONumber + "," + po.QuId + "," + po.QuNumber + "," + 
                po.SfEmail + "," + po.SfId + "," + po.SfName + "," +
                po.SfTel + "," + po.StatusApprove + "," + po.StatusPO + "," +
                po.UserCancel + "," + po.UserCreate + "," + po.UserModi + "," +
                po.PONumberCnt + "," + po.Remark1 + "," + po.Remark2 + "," +
                po.Remark3 + "," + po.Remark4 + "," + po.Remark5 + "," + 
                po.CuAddressT + "," + po.CpAddress1 + "," + po.CpAddress2 + "," +
                po.CpTaxId + "," + po.Amt + "," + po.VatRate + "," + 
                po.Vat + "," + po.NetTotal + "," + po.SfApproveId + "," +
                po.SfApproveName + "," + po.Line1 + "," + po.PODueDate + "," + po.Ref1 + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.ContactName + "','" +
                p.CpId + "','" + p.CpNameT + "','" + p.CuFax + "','" +
                p.CuId + "','" + p.CuNameT + "','" + p.CuEmail + "','" +
                p.CuTel + "','" + p.DateCancel + "'," + p.dateGenDB + ",'" +
                p.DateModi + "','" + p.PODate + "','" + NumberNull1(p.PODuePeriod) + "','" +
                p.PONumber + "','" + p.QuId + "','" + p.QuNumber + "','" + 
                p.SfEmail + "','" + p.SfId + "','" + p.SfName + "','" +
                p.SfTel + "','" + p.StatusApprove + "','" + p.StatusPO + "','" +
                p.UserCancel + "','" + p.UserCreate + "','" + p.UserModi + "'," +
                NumberNull1(p.PONumberCnt) + ",'" + p.Remark1 + "','" + p.Remark2 + "','" +
                p.Remark3 + "','" + p.Remark4 + "','" + p.Remark5 + "','" +
                p.CuAddressT + "','" + p.CpAddress1 + "','" + p.CpAddress2 + "','" +
                p.CpTaxId + "'," + NumberNull1(p.Amt) + "," + NumberNull1(p.VatRate) + "," +
                NumberNull1(p.Vat) + "," + NumberNull1(p.NetTotal) + ",'" + p.SfApproveId + "','" +
                p.SfApproveName + "','" + p.Line1 + "','" + p.PODueDate + "','" + p.Ref1 + "')";
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
            p.CuNameT = p.CuNameT.Replace("'", "'");
            p.SfName = p.SfName.Replace("'", "''");
            p.Remark1 = p.Remark1.Replace("'", "''");
            p.Remark2 = p.Remark2.Replace("'", "''");
            p.Remark3 = p.Remark3.Replace("'", "''");
            p.Remark4 = p.Remark4.Replace("'", "''");
            p.Remark5 = p.Remark5.Replace("'", "''");
            p.CuAddressT = p.CuAddressT.Replace("'", "''");
            p.CpAddress1 = p.CpAddress1.Replace("'", "''");
            p.CpAddress2 = p.CpAddress2.Replace("'", "''");
            p.Ref1 = p.Ref1.Replace("'", "''");
            sql = "Update " + po.table + " Set " + po.ContactName + "='" + p.ContactName + "', " +
                po.CpId + "='" + p.CpId + "', " +
                po.CpNameT + "='" + p.CpNameT + "', " +
                po.CuFax + "='" + p.CuFax + "', " +
                po.CuId + "='" + p.CuId + "', " +
                po.CuNameT + "='" + p.CuNameT + "', " +
                po.CuEmail + "='" + p.CuEmail + "', " +
                po.CuTel + "='" + p.CuTel + "', " +
                po.DateModi + "=" + p.dateGenDB + ", " +
                po.PODate + "='" + p.PODate + "', " +
                po.PODuePeriod + "=" + NumberNull1(p.PODuePeriod) + ", " +
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
                //po.UserModi + "=" + p.dateGenDB + ", " +
                po.Remark1 + "='" + p.Remark1 + "', " +
                po.Remark2 + "='" + p.Remark2 + "', " +
                po.Remark3 + "='" + p.Remark3 + "', " +
                po.Remark4 + "='" + p.Remark4 + "', " +
                po.Remark5 + "='" + p.Remark5 + "', " +
                po.CuAddressT + "='" + p.CuAddressT + "', " +
                po.CpAddress1 + "='" + p.CpAddress1 + "', " +
                po.CpAddress2 + "='" + p.CpAddress2 + "', " +
                po.CpTaxId + "='" + p.CpTaxId + "', " +
                po.Amt + "=" + NumberNull1(p.Amt) + ", " +
                po.VatRate + "=" + NumberNull1(p.VatRate) + ", " +
                po.Vat + "=" + NumberNull1(p.Vat) + ", " +
                po.NetTotal + "=" + NumberNull1(p.NetTotal) + ", " +
                po.SfApproveId + "='" + p.SfApproveId + "', " +
                po.SfApproveName + "='" + p.SfApproveName + "', " +
                po.Line1 + "='" + p.Line1 + "', " +
                po.PODueDate + "='" + p.PODueDate + "', " +
                po.Ref1 + "='" + p.Ref1 + "' " +
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
            doc = doc.Substring(doc.Length - 5);
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
        private String NumberNull1(String o)
        {
            if (o.Equals(""))
            {
                return "0";
            }
            else
            {
                return o;
            }
        }
        public DataTable selectDistinctRemark1()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + po.Remark1 + " From " + po.table + " Where " + po.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboRemark1(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctRemark1();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][po.Remark1].ToString();
                item.Text = dt.Rows[i][po.Remark1].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public DataTable selectDistinctRemark2()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + po.Remark2 + " From " + po.table + " Where " + po.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboRemark2(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctRemark2();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][po.Remark2].ToString();
                item.Text = dt.Rows[i][po.Remark2].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public DataTable selectDistinctRemark3()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + po.Remark3 + " From " + po.table + " Where " + po.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboRemark3(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctRemark3();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][po.Remark3].ToString();
                item.Text = dt.Rows[i][po.Remark3].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public DataTable selectDistinctRemark4()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + po.Remark4 + " From " + po.table + " Where " + po.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboRemark4(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctRemark4();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][po.Remark4].ToString();
                item.Text = dt.Rows[i][po.Remark4].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public DataTable selectDistinctRemark5()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct " + po.Remark5 + " From " + po.table + " Where " + po.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboRemark5(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectDistinctRemark5();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][po.Remark5].ToString();
                item.Text = dt.Rows[i][po.Remark5].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
    }
}
