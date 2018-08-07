using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class CompanyDB
    {
        public Company cop;
        ConnectDB conn;
        public CompanyDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            cop = new Company();
            cop.AddressE = "comp_address_e";
            cop.AddressT = "comp_address_t";
            cop.amphurId = "amphur_id";
            //comp.Code = "";
            cop.districtId = "district_id";
            cop.Email = "email";
            cop.Fax = "fax";
            cop.Id = "comp_id";
            cop.NameE = "comp_name_e";
            cop.NameT = "comp_name_t";
            cop.provinceId = "province_id";
            cop.TaxId = "tax_id";
            cop.Tele = "tele";
            cop.vat = "vat";
            cop.Zipcode = "zipcode";
            //cp.website = "website";
            cop.logo = "logo";
            cop.Addr = "addr";
            cop.Code = "comp_code";
            cop.WebSite = "website";
            cop.Spec1 = "spec1";
            cop.dateCancel = "date_cancel";
            cop.dateCreate = "date_create";
            cop.dateModi = "date_modi";
            cop.userCancel = "user_cancel";
            cop.userCreate = "user_create";
            cop.userModi = "user_modi";

            cop.quLine1 = "qu_line1";
            cop.quLine2 = "qu_line2";
            cop.quLine3 = "qu_line3";
            cop.quLine4 = "qu_line4";
            cop.quLine5 = "qu_line5";
            cop.quLine6 = "qu_line6";

            cop.mouLine1 = "mou_line1";
            cop.mouLine2 = "mou_line2";
            cop.mouLine3 = "mou_line3";
            cop.mouLine4 = "mou_line4";
            cop.InvDuePeriod = "invoice_due_period";

            cop.rsLine1 = "rs_line1";
            cop.rsLine2 = "rs_line2";
            cop.rsLine3 = "rs_line3";
            cop.rsLine4 = "rs_line4";
            cop.rsLine5 = "rs_line5";
            cop.rsLine6 = "rs_line6";
            cop.report_sum_name_cbc = "report_sum_name_cbc";
            cop.report_sum_name_fbs = "report_sum_name_fbs";
            cop.report_sum_name_pe = "report_sum_name_pe";
            cop.report_sum_name_bun = "report_sum_name_bun";
            cop.report_sum_name_cho = "report_sum_name_cho";
            cop.report_sum_name_eye = "report_sum_name_eye";
            cop.report_sum_name_lung = "report_sum_name_lung";
            cop.report_sum_name_other1 = "report_sum_name_other1";
            cop.report_sum_name_sgot = "report_sum_name_sgot";
            cop.report_sum_name_stool_exam = "report_sum_name_stool_exam";
            cop.report_sum_name_sum = "report_sum_name_sum";
            cop.report_sum_name_toxi = "report_sum_name_toxi";
            cop.report_sum_name_tri = "report_sum_name_tri";
            cop.report_sum_name_ua = "report_sum_name_ua";
            cop.report_sum_name_uric = "report_sum_name_uric";
            cop.report_sum_name_xray = "report_sum_name_xray";

            cop.pkField = "comp_id";
            cop.table = "b_company";
        }
        private Company setData(Company item, DataTable dt)
        {
            item.AddressE = dt.Rows[0][cop.AddressE].ToString();
            item.AddressT = dt.Rows[0][cop.AddressT].ToString();
            item.amphurId = dt.Rows[0][cop.amphurId].ToString();
            item.districtId = dt.Rows[0][cop.districtId].ToString();
            item.Email = dt.Rows[0][cop.Email].ToString();
            item.Fax = dt.Rows[0][cop.Fax].ToString();
            item.Id = dt.Rows[0][cop.Id].ToString();
            item.NameE = dt.Rows[0][cop.NameE].ToString();
            item.NameT = dt.Rows[0][cop.NameT].ToString();
            item.provinceId = dt.Rows[0][cop.provinceId].ToString();
            item.TaxId = dt.Rows[0][cop.TaxId].ToString();
            item.Tele = dt.Rows[0][cop.Tele].ToString();
            item.vat = dt.Rows[0][cop.vat].ToString();
            item.Zipcode = dt.Rows[0][cop.Zipcode].ToString();
            //item.website = dt.Rows[0][cp.website].ToString();
            item.logo = dt.Rows[0][cop.logo].ToString();
            item.Addr = dt.Rows[0][cop.Addr].ToString();
            item.Code = dt.Rows[0][cop.Code].ToString();
            item.WebSite = dt.Rows[0][cop.WebSite].ToString();
            item.Spec1 = dt.Rows[0][cop.Spec1].ToString();
            item.dateCancel = dt.Rows[0][cop.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][cop.dateCreate].ToString();
            item.dateModi = dt.Rows[0][cop.dateModi].ToString();
            item.userCancel = dt.Rows[0][cop.userCancel].ToString();
            item.userCreate = dt.Rows[0][cop.userCreate].ToString();
            item.userModi = dt.Rows[0][cop.userModi].ToString();

            item.quLine1 = dt.Rows[0][cop.quLine1].ToString();
            item.quLine2 = dt.Rows[0][cop.quLine2].ToString();
            item.quLine3 = dt.Rows[0][cop.quLine3].ToString();
            item.quLine4 = dt.Rows[0][cop.quLine4].ToString();
            item.quLine5 = dt.Rows[0][cop.quLine5].ToString();
            item.quLine6 = dt.Rows[0][cop.quLine6].ToString();

            item.mouLine1 = dt.Rows[0][cop.mouLine1].ToString();
            item.mouLine2 = dt.Rows[0][cop.mouLine2].ToString();
            item.mouLine3 = dt.Rows[0][cop.mouLine3].ToString();
            item.mouLine4 = dt.Rows[0][cop.mouLine4].ToString();
            item.InvDuePeriod = dt.Rows[0][cop.InvDuePeriod].ToString();

            item.rsLine1 = dt.Rows[0][cop.rsLine1].ToString();
            item.rsLine2 = dt.Rows[0][cop.rsLine2].ToString();
            item.rsLine3 = dt.Rows[0][cop.rsLine3].ToString();
            item.rsLine4 = dt.Rows[0][cop.rsLine4].ToString();
            item.rsLine5 = dt.Rows[0][cop.rsLine5].ToString();
            item.rsLine6 = dt.Rows[0][cop.rsLine6].ToString();

            item.report_sum_name_cbc = dt.Rows[0][cop.report_sum_name_cbc].ToString();
            item.report_sum_name_fbs = dt.Rows[0][cop.report_sum_name_fbs].ToString();
            item.report_sum_name_pe = dt.Rows[0][cop.report_sum_name_pe].ToString();
            item.report_sum_name_bun = dt.Rows[0][cop.report_sum_name_bun].ToString();
            item.report_sum_name_cho = dt.Rows[0][cop.report_sum_name_cho].ToString();
            item.report_sum_name_eye = dt.Rows[0][cop.report_sum_name_eye].ToString();
            item.report_sum_name_lung = dt.Rows[0][cop.report_sum_name_lung].ToString();
            item.report_sum_name_other1 = dt.Rows[0][cop.report_sum_name_other1].ToString();
            item.report_sum_name_sgot = dt.Rows[0][cop.report_sum_name_sgot].ToString();
            item.report_sum_name_stool_exam = dt.Rows[0][cop.report_sum_name_stool_exam].ToString();
            item.report_sum_name_sum = dt.Rows[0][cop.report_sum_name_sum].ToString();
            item.report_sum_name_toxi = dt.Rows[0][cop.report_sum_name_toxi].ToString();
            item.report_sum_name_tri = dt.Rows[0][cop.report_sum_name_tri].ToString();
            item.report_sum_name_ua = dt.Rows[0][cop.report_sum_name_ua].ToString();
            item.report_sum_name_uric = dt.Rows[0][cop.report_sum_name_uric].ToString();
            item.report_sum_name_xray = dt.Rows[0][cop.report_sum_name_xray].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cop.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public Company selectByPk()
        {
            Company item = new Company();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cop.table + " ";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(Company p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "cp"+p.getGenID();
            }
            p.AddressE = p.AddressE.Replace("''", "'");
            p.AddressT = p.AddressT.Replace("''", "'");
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Addr = p.Addr.Replace("''", "'");
            p.Spec1 = p.Spec1.Replace("''", "'");

            sql = "Insert Into " + cop.table + " (" + cop.pkField + "," + cop.AddressE + "," + cop.AddressT + "," +
                cop.amphurId + "," + cop.districtId + "," + cop.Email + "," +
                cop.Fax + "," + cop.NameE + "," + cop.NameT + "," +
                cop.provinceId + "," + cop.TaxId + "," + cop.Tele + "," +
                cop.vat + "," + cop.Zipcode + "," + cop.WebSite + "," +
                cop.logo + "," + cop.Addr + "," + cop.Code + "," + cop.Spec1 + "," + cop.InvDuePeriod + ") " +
                "Values('" + p.Id + "','" + p.AddressE + "','" + p.AddressT + "','" +
                p.amphurId + "','" + p.districtId + "','" + p.Email + "','" +
                p.Fax + "','" + p.NameE + "','" + p.NameT + "','" +
                p.provinceId + "','" + p.TaxId + "','" + p.Tele + "','" +
                p.vat + "','" + p.Zipcode + "','" + p.WebSite + "','" +
                p.logo + "','" + p.Addr + "','" + p.Code + "','" + p.Spec1 + "','" + p.InvDuePeriod + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Company");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Company p)
        {
            String sql = "", chk = "";

            p.AddressE = p.AddressE.Replace("'", "''");
            p.AddressT = p.AddressT.Replace("'", "''");
            p.NameE = p.NameE.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");
            p.Addr = p.Addr.Replace("'", "''");
            p.quLine1 = p.quLine1.Replace("'", "''");
            p.quLine2 = p.quLine2.Replace("'", "''");
            p.quLine3 = p.quLine3.Replace("'", "''");
            p.quLine4 = p.quLine4.Replace("'", "''");
            p.quLine5 = p.quLine5.Replace("'", "''");
            p.quLine6 = p.quLine6.Replace("'", "''");

            p.mouLine1 = p.mouLine1.Replace("'", "''");
            p.mouLine2 = p.mouLine2.Replace("'", "''");
            p.mouLine3 = p.mouLine3.Replace("'", "''");
            p.mouLine4 = p.mouLine4.Replace("'", "''");

            p.rsLine1 = p.rsLine1.Replace("'", "''");
            p.rsLine2 = p.rsLine2.Replace("'", "''");
            p.rsLine3 = p.rsLine3.Replace("'", "''");
            p.rsLine4 = p.rsLine4.Replace("'", "''");
            p.rsLine5 = p.rsLine5.Replace("'", "''");
            p.rsLine6 = p.rsLine6.Replace("'", "''");

            sql = "Update " + cop.table + " Set " + cop.AddressE + "='" + p.AddressE + "', " +
                cop.AddressT + "='" + p.AddressT + "', " +
                cop.amphurId + "='" + p.amphurId + "', " +
                cop.districtId + "='" + p.districtId + "', " +
                cop.Email + "='" + p.Email + "', " +
                cop.Fax + "='" + p.Fax + "', " +
                cop.NameE + "='" + p.NameE + "', " +
                cop.NameT + "='" + p.NameT + "', " +
                cop.provinceId + "='" + p.provinceId + "', " +
                cop.TaxId + "='" + p.TaxId + "', " +
                cop.Tele + "='" + p.Tele + "', " +
                cop.vat + "='" + p.vat + "', " +
                cop.Zipcode + "='" + p.Zipcode + "', " +
                cop.WebSite + "='" + p.WebSite + "', " +
                cop.Addr + "='" + p.Addr + "', " +
                cop.Code + "='" + p.Code + "', " +
                cop.quLine1 + "='" + p.quLine1 + "', " +
                cop.quLine2 + "='" + p.quLine2 + "', " +
                cop.quLine3 + "='" + p.quLine3 + "', " +
                cop.quLine4 + "='" + p.quLine4 + "', " +
                cop.quLine5 + "='" + p.quLine5 + "', " +
                cop.quLine6 + "='" + p.quLine6 + "', " +
                cop.mouLine1 + "='" + p.mouLine1 + "', " +
                cop.mouLine2 + "='" + p.mouLine2 + "', " +
                cop.mouLine3 + "='" + p.mouLine3 + "', " +
                cop.mouLine4 + "='" + p.mouLine4 + "', " +
                cop.InvDuePeriod + "='" + p.InvDuePeriod + "', " +
                cop.rsLine1 + "='" + p.rsLine1 + "', " +
                cop.rsLine2 + "='" + p.rsLine2 + "', " +
                cop.rsLine3 + "='" + p.rsLine3 + "', " +
                cop.rsLine4 + "='" + p.rsLine4 + "', " +
                cop.rsLine5 + "='" + p.rsLine5 + "', " +
                cop.rsLine6 + "='" + p.rsLine6 + "' " +
                "Where " + cop.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Company");
            }
            finally
            {
            }
            return chk;
        }
        public String insertCompany(Company p)
        {
            Company item = new Company();
            String chk = "";
            item = selectByPk();
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
        public String UpdateLogo(String logo)
        {
            String sql = "", chk = "";
            sql = "Update " + cop.table + " Set " + cop.logo + "='" + logo + "' ";

            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboCustomer(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][cop.Id].ToString();
                item.Text = dt.Rows[i][cop.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
