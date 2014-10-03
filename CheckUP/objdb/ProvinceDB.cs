using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class ProvinceDB
    {
        private ConnectDB conn;
        public Province prov;
        public ProvinceDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        public void initConfig()
        {
            prov = new Province();
            prov.geoId = "geo_id";
            prov.provinceCode = "province_code";
            prov.provinceId = "province_id";
            prov.provinceName = "province_name";
            prov.sited = "";
            prov.table = "f_provinces";
            prov.pkField = "province_id";
        }
        public DataTable selectProvince()
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + prov.table + "  Order By " + prov.provinceName;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByPk(String code)
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + prov.table + "  Where " + prov.provinceCode + "='" + code + "'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboProv1(ComboBox c, String id)
        {
            //ComboBox c = new ComboBox();
            ComboBoxItem item = new ComboBoxItem();
            c.Items.Clear();
            //c.Items.Add(id);

            DataTable dt = selectByPk(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][prov.provinceCode].ToString();
                item.Text = dt.Rows[i][prov.provinceName].ToString();
                //c.Items.Add(dt.Rows[i][dist.districtName].ToString() + "/" + dt.Rows[i][dist.amphurName].ToString() + "/" + dt.Rows[i][dist.provinceName].ToString());
                c.Items.Add(item);
            }
            c.SelectedItem = item;
            //c.SelectionStart = c.Text.Length;
            //c.DroppedDown = true;
            return c;
        }
    }
}
