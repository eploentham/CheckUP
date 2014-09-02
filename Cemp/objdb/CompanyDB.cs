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
        Company comp;
        ConnectDB conn;
        public CompanyDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            comp = new Company();
            comp.AddressE = "comp_address_e";
            comp.AddressT = "comp_address_t";
            comp.amphurId = "amphur_id";
            //comp.Code = "";
            comp.districtId = "district_id";
            comp.Email = "email";
            comp.Fax = "fax";
            comp.Id = "comp_id";
            comp.NameE = "comp_name_e";
            comp.NameT = "comp_name_t";
            comp.provinceId = "province_id";
            comp.TaxId = "tax_id";
            comp.Tele = "tele";
            comp.vat = "vat";
            comp.Zipcode = "zipcode";
            comp.website = "website";
            comp.logo = "logo";

            comp.pkField = "comp_id";
            comp.table = "b_company";
        }
        private Company setData(Company item, DataTable dt)
        {
            item.AddressE = dt.Rows[0][comp.AddressE].ToString();
            item.AddressT = dt.Rows[0][comp.AddressT].ToString();
            item.amphurId = dt.Rows[0][comp.amphurId].ToString();
            item.districtId = dt.Rows[0][comp.districtId].ToString();
            item.Email = dt.Rows[0][comp.Email].ToString();
            item.Fax = dt.Rows[0][comp.Fax].ToString();
            item.Id = dt.Rows[0][comp.Id].ToString();
            item.NameE = dt.Rows[0][comp.NameE].ToString();
            item.NameT = dt.Rows[0][comp.NameT].ToString();
            item.provinceId = dt.Rows[0][comp.provinceId].ToString();
            item.TaxId = dt.Rows[0][comp.TaxId].ToString();
            item.Tele = dt.Rows[0][comp.Tele].ToString();
            item.vat = dt.Rows[0][comp.vat].ToString();
            item.Zipcode = dt.Rows[0][comp.Zipcode].ToString();
            item.website = dt.Rows[0][comp.website].ToString();
            item.logo = dt.Rows[0][comp.logo].ToString();
            //item.Priority = dt.Rows[0][comp.Priority].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + comp.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public Company selectByPk()
        {
            Company item = new Company();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + comp.table + " ";
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
                p.Id = p.getGenID();
            }
            p.AddressE = p.AddressE.Replace("''", "'");
            p.AddressT = p.AddressT.Replace("''", "'");
            p.NameE = p.NameE.Replace("''", "'");
            p.NameT = p.NameT.Replace("''", "'");
            sql = "Insert Into " + comp.table + " (" + comp.pkField + "," + comp.AddressE + "," + comp.AddressT + "," +
                comp.amphurId + "," + comp.districtId + "," + comp.Email + "," +
                comp.Fax + "," + comp.NameE + "," + comp.NameT + "," +
                comp.provinceId + "," + comp.TaxId + "," + comp.Tele + "," +
                comp.vat + "," + comp.Zipcode + "," + comp.website + "," +
                comp.logo + ") " +
                "Values('" + p.Id + "','" + p.AddressE + "','" + p.AddressT + "','" +
                p.amphurId + "','" + p.districtId + "','" + p.Email + "','" +
                p.Fax + "','" + p.NameE + "','" + p.NameT + "','" +
                p.provinceId + "','" + p.TaxId + "','" + p.Tele + "','" +
                p.vat + "','" + p.Zipcode + "','" + p.website + "','" +
                p.logo + "')";
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

            p.NameT = p.NameT.Replace("''", "'");

            sql = "Update " + comp.table + " Set " + comp.AddressE + "='" + p.AddressE + "', " +
                comp.AddressT + "='" + p.AddressT + "', " +
                comp.amphurId + "='" + p.amphurId + "', " +
                comp.districtId + "='" + p.districtId + "', " +
                comp.Email + "='" + p.Email + "', " +
                comp.Fax + "='" + p.Fax + "', " +
                comp.NameE + "='" + p.NameE + "', " +
                comp.NameT + "='" + p.NameT + "', " +
                comp.provinceId + "='" + p.provinceId + "', " +
                comp.TaxId + "='" + p.TaxId + "', " +
                comp.Tele + "='" + p.Tele + "', " +
                comp.vat + "='" + p.vat + "', " +
                comp.Zipcode + "='" + p.Zipcode + "', " +
                comp.website + "='" + p.website + "' " +
                "Where " + comp.pkField + "='" + p.Id + "'";
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
    }
}
