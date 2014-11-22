using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class CompanyDB
    {
        Company cp;
        ConnectDB conn;
        public CompanyDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            cp = new Company();
            cp.AddressE = "comp_address_e";
            cp.AddressT = "comp_address_t";
            cp.amphurId = "amphur_id";
            //comp.Code = "";
            cp.districtId = "district_id";
            cp.Email = "email";
            cp.Fax = "fax";
            cp.Id = "comp_id";
            cp.NameE = "comp_name_e";
            cp.NameT = "comp_name_t";
            cp.provinceId = "province_id";
            cp.TaxId = "tax_id";
            cp.Tele = "tele";
            cp.vat = "vat";
            cp.Zipcode = "zipcode";
            //cp.website = "website";
            cp.logo = "logo";
            cp.Addr = "addr";
            cp.Code = "comp_code";
            cp.WebSite = "website";
            cp.Spec1 = "spec1";
            cp.dateCancel = "date_cancel";
            cp.dateCreate = "date_create";
            cp.dateModi = "date_modi";
            cp.userCancel = "user_cancel";
            cp.userCreate = "user_create";
            cp.userModi = "user_modi";

            cp.quLine1 = "qu_line1";
            cp.quLine2 = "qu_line2";
            cp.quLine3 = "qu_line3";
            cp.quLine4 = "qu_line4";
            cp.quLine5 = "qu_line5";
            cp.quLine6 = "qu_line6";

            cp.mouLine1 = "mou_line1";
            cp.mouLine2 = "mou_line2";
            cp.mouLine3 = "mou_line3";
            cp.mouLine4 = "mou_line4";
            cp.InvDuePeriod = "invoice_due_period";

            cp.rsLine1 = "rs_line1";
            cp.rsLine2 = "rs_line2";
            cp.rsLine3 = "rs_line3";
            cp.rsLine4 = "rs_line4";
            cp.rsLine5 = "rs_line5";
            cp.rsLine6 = "rs_line6";

            cp.poLine1 = "po_line1";
            cp.PODuePeriod = "po_due_period";

            cp.poLine2 = "po_line2";
            cp.poLine3 = "po_line3";
            cp.poLine4 = "po_line4";
            cp.poLine5 = "po_line5";
            cp.poLine6 = "po_line6";

            cp.pkField = "comp_id";
            cp.table = "b_company";
        }
        private Company setData(Company item, DataTable dt)
        {
            item.AddressE = dt.Rows[0][cp.AddressE].ToString();
            item.AddressT = dt.Rows[0][cp.AddressT].ToString();
            item.amphurId = dt.Rows[0][cp.amphurId].ToString();
            item.districtId = dt.Rows[0][cp.districtId].ToString();
            item.Email = dt.Rows[0][cp.Email].ToString();
            item.Fax = dt.Rows[0][cp.Fax].ToString();
            item.Id = dt.Rows[0][cp.Id].ToString();
            item.NameE = dt.Rows[0][cp.NameE].ToString();
            item.NameT = dt.Rows[0][cp.NameT].ToString();
            item.provinceId = dt.Rows[0][cp.provinceId].ToString();
            item.TaxId = dt.Rows[0][cp.TaxId].ToString();
            item.Tele = dt.Rows[0][cp.Tele].ToString();
            item.vat = dt.Rows[0][cp.vat].ToString();
            item.Zipcode = dt.Rows[0][cp.Zipcode].ToString();
            //item.website = dt.Rows[0][cp.website].ToString();
            item.logo = dt.Rows[0][cp.logo].ToString();
            item.Addr = dt.Rows[0][cp.Addr].ToString();
            item.Code = dt.Rows[0][cp.Code].ToString();
            item.WebSite = dt.Rows[0][cp.WebSite].ToString();
            item.Spec1 = dt.Rows[0][cp.Spec1].ToString();
            item.dateCancel = dt.Rows[0][cp.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][cp.dateCreate].ToString();
            item.dateModi = dt.Rows[0][cp.dateModi].ToString();
            item.userCancel = dt.Rows[0][cp.userCancel].ToString();
            item.userCreate = dt.Rows[0][cp.userCreate].ToString();
            item.userModi = dt.Rows[0][cp.userModi].ToString();

            item.quLine1 = dt.Rows[0][cp.quLine1].ToString();
            item.quLine2 = dt.Rows[0][cp.quLine2].ToString();
            item.quLine3 = dt.Rows[0][cp.quLine3].ToString();
            item.quLine4 = dt.Rows[0][cp.quLine4].ToString();
            item.quLine5 = dt.Rows[0][cp.quLine5].ToString();
            item.quLine6 = dt.Rows[0][cp.quLine6].ToString();

            item.mouLine1 = dt.Rows[0][cp.mouLine1].ToString();
            item.mouLine2 = dt.Rows[0][cp.mouLine2].ToString();
            item.mouLine3 = dt.Rows[0][cp.mouLine3].ToString();
            item.mouLine4 = dt.Rows[0][cp.mouLine4].ToString();
            item.InvDuePeriod = dt.Rows[0][cp.InvDuePeriod].ToString();

            item.rsLine1 = dt.Rows[0][cp.rsLine1].ToString();
            item.rsLine2 = dt.Rows[0][cp.rsLine2].ToString();
            item.rsLine3 = dt.Rows[0][cp.rsLine3].ToString();
            item.rsLine4 = dt.Rows[0][cp.rsLine4].ToString();
            item.rsLine5 = dt.Rows[0][cp.rsLine5].ToString();
            item.rsLine6 = dt.Rows[0][cp.rsLine6].ToString();

            item.poLine1 = dt.Rows[0][cp.poLine1].ToString();
            item.PODuePeriod = dt.Rows[0][cp.PODuePeriod].ToString();
            item.poLine2 = dt.Rows[0][cp.poLine2].ToString();
            item.poLine3 = dt.Rows[0][cp.poLine3].ToString();
            item.poLine4 = dt.Rows[0][cp.poLine4].ToString();
            item.poLine5 = dt.Rows[0][cp.poLine5].ToString();
            item.poLine6 = dt.Rows[0][cp.poLine6].ToString();
            
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cp.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public Company selectByPk()
        {
            Company item = new Company();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + cp.table + " ";
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
            p.AddressE = p.AddressE.Replace("'", "''");
            p.AddressT = p.AddressT.Replace("'", "''");
            p.NameE = p.NameE.Replace("'", "''");
            p.NameT = p.NameT.Replace("'", "''");
            p.Addr = p.Addr.Replace("'", "''");
            p.Spec1 = p.Spec1.Replace("'", "''");

            sql = "Insert Into " + cp.table + " (" + cp.pkField + "," + cp.AddressE + "," + cp.AddressT + "," +
                cp.amphurId + "," + cp.districtId + "," + cp.Email + "," +
                cp.Fax + "," + cp.NameE + "," + cp.NameT + "," +
                cp.provinceId + "," + cp.TaxId + "," + cp.Tele + "," +
                cp.vat + "," + cp.Zipcode + "," + cp.WebSite + "," +
                cp.logo + "," + cp.Addr + "," + cp.Code + "," + cp.Spec1 + "," + cp.InvDuePeriod + ") " +
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

            p.poLine1 = p.poLine1.Replace("'", "''");
            p.poLine2 = p.poLine2.Replace("'", "''");
            p.poLine3 = p.poLine3.Replace("'", "''");
            p.poLine4 = p.poLine4.Replace("'", "''");
            p.poLine5 = p.poLine5.Replace("'", "''");
            p.poLine6 = p.poLine6.Replace("'", "''");

            sql = "Update " + cp.table + " Set " + cp.AddressE + "='" + p.AddressE + "', " +
                cp.AddressT + "='" + p.AddressT + "', " +
                cp.amphurId + "='" + p.amphurId + "', " +
                cp.districtId + "='" + p.districtId + "', " +
                cp.Email + "='" + p.Email + "', " +
                cp.Fax + "='" + p.Fax + "', " +
                cp.NameE + "='" + p.NameE + "', " +
                cp.NameT + "='" + p.NameT + "', " +
                cp.provinceId + "='" + p.provinceId + "', " +
                cp.TaxId + "='" + p.TaxId + "', " +
                cp.Tele + "='" + p.Tele + "', " +
                cp.vat + "='" + p.vat + "', " +
                cp.Zipcode + "='" + p.Zipcode + "', " +
                cp.WebSite + "='" + p.WebSite + "', " +
                cp.Addr + "='" + p.Addr + "', " +
                cp.Code + "='" + p.Code + "', " +
                cp.quLine1 + "='" + p.quLine1 + "', " +
                cp.quLine2 + "='" + p.quLine2 + "', " +
                cp.quLine3 + "='" + p.quLine3 + "', " +
                cp.quLine4 + "='" + p.quLine4 + "', " +
                cp.quLine5 + "='" + p.quLine5 + "', " +
                cp.quLine6 + "='" + p.quLine6 + "', " +
                cp.mouLine1 + "='" + p.mouLine1 + "', " +
                cp.mouLine2 + "='" + p.mouLine2 + "', " +
                cp.mouLine3 + "='" + p.mouLine3 + "', " +
                cp.mouLine4 + "='" + p.mouLine4 + "', " +
                cp.InvDuePeriod + "='" + p.InvDuePeriod + "', " +
                cp.rsLine1 + "='" + p.rsLine1 + "', " +
                cp.rsLine2 + "='" + p.rsLine2 + "', " +
                cp.rsLine3 + "='" + p.rsLine3 + "', " +
                cp.rsLine4 + "='" + p.rsLine4 + "', " +
                cp.rsLine5 + "='" + p.rsLine5 + "', " +
                cp.rsLine6 + "='" + p.rsLine6 + "', " +
                cp.poLine1 + "='" + p.poLine1 + "', " +
                cp.Spec1 + "='" + p.Spec1 + "', " +
                cp.PODuePeriod + "=" + NumberNull1(p.PODuePeriod) + ", " +
                cp.poLine2 + "='" + p.poLine2 + "', " +
                cp.poLine3 + "='" + p.poLine3 + "', " +
                cp.poLine4 + "='" + p.poLine4 + "', " +
                cp.poLine5 + "='" + p.poLine5 + "', " +
                cp.poLine6 + "='" + p.poLine6 + "' " +
                
                "Where " + cp.pkField + "='" + p.Id + "'";
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
            sql = "Update " + cp.table + " Set " + cp.logo + "='" + logo + "' ";

            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboCompany(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectAll();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][cp.Id].ToString();
                item.Text = dt.Rows[i][cp.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
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
    }
}
