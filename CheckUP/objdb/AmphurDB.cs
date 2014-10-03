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
    public class AmphurDB
    {
        private ConnectDB conn;
        public Amphur amph;
        public AmphurDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            amph = new Amphur();
            amph.amphurCode = "amphur_code";
            amph.amphurId = "amphur_id";
            amph.amphurName = "amphur_name";
            amph.geoId = "geo_id";
            amph.provinceId = "province_id";
            amph.pkField = "amphur_id";
            amph.sited = "";
            amph.table = "f_amphures";
        }
        public DataTable selectAmphurAll()
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + amph.table + "  Order By " + amph.amphurName;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByPk(String code)
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + amph.table + "  Where " + amph.amphurCode + "='" + code + "'";
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboAmphur1(ComboBox c, String id)
        {
            //ComboBox c = new ComboBox();
            ComboBoxItem item = new ComboBoxItem();
            c.Items.Clear();
            //c.Items.Add(id);

            DataTable dt = selectByPk(id);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][amph.amphurCode].ToString();
                item.Text = dt.Rows[i][amph.amphurName].ToString();
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
