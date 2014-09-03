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
            p.AddressE = p.AddressE.Replace("''", "'");
            p.AddressT = p.AddressT.Replace("''", "'");
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Addr = p.Addr.Replace("''", "'");
            sql = "Insert Into " + cp.table + " (" + cp.pkField + "," + cp.AddressE + "," + cp.AddressT + "," +
                cp.amphurId + "," + cp.districtId + "," + cp.Email + "," +
                cp.Fax + "," + cp.NameE + "," + cp.NameT + "," +
                cp.provinceId + "," + cp.TaxId + "," + cp.Tele + "," +
                cp.vat + "," + cp.Zipcode + "," + cp.WebSite + "," +
                cp.logo + "," + cp.Addr + "," + cp.Code + ") " +
                "Values('" + p.Id + "','" + p.AddressE + "','" + p.AddressT + "','" +
                p.amphurId + "','" + p.districtId + "','" + p.Email + "','" +
                p.Fax + "','" + p.NameE + "','" + p.NameT + "','" +
                p.provinceId + "','" + p.TaxId + "','" + p.Tele + "','" +
                p.vat + "','" + p.Zipcode + "','" + p.WebSite + "','" +
                p.logo + "','" + p.Addr + "','" + p.Code + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Sale");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Company p)
        {
            String sql = "", chk = "";

            p.AddressE = p.AddressE.Replace("''", "'");
            p.AddressT = p.AddressT.Replace("''", "'");
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            p.Addr = p.Addr.Replace("''", "'");

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
                cp.Code + "='" + p.Code + "' " +
                "Where " + cp.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Sale");
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
    }
}
