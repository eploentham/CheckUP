using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class ItemTypeDB
    {
        ConnectDB conn;
        public DocType ity;
        public ItemTypeDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            ity = new DocType();
            ity.Active = "doc_active";
            ity.docModule = "doc_module";
            ity.docType = "doc_type";
            ity.docValue = "doc_value";
            ity.PreFix = "doc_prefix";
            ity.Remark = "remark";
            ity.Id = "doc_id";
            

            ity.pkField = "doc_id";
            ity.table = "b_doc_prefix";
        }
        private DocType setData(DocType item, DataTable dt)
        {
            item.Active = dt.Rows[0][ity.Active].ToString();
            item.docModule = dt.Rows[0][ity.docModule].ToString();
            item.docType = dt.Rows[0][ity.docType].ToString();
            item.docValue = dt.Rows[0][ity.docValue].ToString();
            item.PreFix = dt.Rows[0][ity.PreFix].ToString();
            item.Remark = dt.Rows[0][ity.Remark].ToString();
            item.Id = dt.Rows[0][ity.Id].ToString();
            //item.ItemType = dt.Rows[0][ity.ItemType].ToString();
            //item.PositionName = dt.Rows[0][dt.PositionName].ToString();


            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ity.table + " Where " + ity.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public DocType selectByPk(String saleId)
        {
            DocType item = new DocType();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + ity.table + " Where " + ity.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public DataTable selectPrefixByModule(String dtId)
        {
            //DocType item = new DocType();
            String sql = "";

            sql = "Select * From " + ity.table + " Where " + ity.docModule + "='" + dtId + "' and " + ity.Active + "='1' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public String selectPrefixByModule(String docModule, String docType)
        {
            //DocType item = new DocType();
            String sql = "";

            sql = "Select "+ity.PreFix+" From " + ity.table + " Where " + ity.docModule + "='" + docModule + "' and " + ity.docType + "='" + docType + "' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt.Rows[0][ity.PreFix].ToString();
        }
        private String insert(DocType p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "sf" + p.getGenID();
            }
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Insert Into " + ity.table + " (" + ity.pkField + "," + ity.Active + "," + ity.docModule + "," +
                ity.docType + "," + ity.docValue + "," + ity.PreFix + "," +
                ity.Remark + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.docModule + "','" +
                p.docType + "','" + p.docValue + "','" + p.PreFix + "','" +
                p.Remark + "')";
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
        private String update(DocType p)
        {
            String sql = "", chk = "";

            p.Remark = p.Remark.Replace("'", "''");

            sql = "Update " + ity.table + " Set " + ity.docModule + "='" + p.docModule + "', " +
                ity.docType + "='" + p.docType + "', " +
                ity.PreFix + "='" + p.PreFix + "', " +
                ity.Remark + "='" + p.Remark + "' " +

                "Where " + ity.pkField + "='" + p.Id + "'";
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
        public String insertDocType(DocType p)
        {
            DocType item = new DocType();
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
            sql = "Delete From " + ity.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboDocType(ComboBox c, String docModule)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectPrefixByModule(docModule);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][ity.PreFix].ToString();
                item.Text = dt.Rows[i][ity.docType].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        //public ComboBox getCboStaff(ComboBox c, String selectedId)
        //{
        //    ComboBoxItem item = new ComboBoxItem();
        //    ComboBoxItem se = new ComboBoxItem();
        //    DataTable dt = selectAll();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        item = new ComboBoxItem();
        //        item.Value = dt.Rows[i][sf.Id].ToString();
        //        item.Text = dt.Rows[i][sf.NameT].ToString();
        //        c.Items.Add(item);
        //        if (item.Value.Equals(selectedId))
        //        {
        //            se = item;
        //        }
        //        //c.Items.Add(new );
        //    }

        //    c.SelectedItem = se;
        //    return c;
        //}

        //public String VoidStaff(String sfId)
        //{
        //    String sql = "", chk = "";

        //    sql = "Update " + sf.table + " Set " + sf.Active + "='3' " +
        //        "Where " + sf.pkField + "='" + sfId + "'";
        //    chk = conn.ExecuteNonQuery(sql);
        //    return chk;
        //}
    }
}
