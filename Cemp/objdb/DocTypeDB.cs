using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class DocTypeDB
    {
        ConnectDB conn;
        public DocType doc;
        public DocTypeDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            doc = new DocType();
            doc.Active = "doc_active";
            doc.docModule = "doc_module";
            doc.docType = "doc_type";
            doc.docValue = "doc_value";
            doc.PreFix = "doc_prefix";
            doc.Remark = "remark";
            doc.Id = "doc_id";

            doc.pkField = "doc_id";
            doc.table = "b_doc_prefix";
        }
        private DocType setData(DocType item, DataTable dt)
        {
            item.Active = dt.Rows[0][doc.Active].ToString();
            item.docModule = dt.Rows[0][doc.docModule].ToString();
            item.docType = dt.Rows[0][doc.docType].ToString();
            item.docValue = dt.Rows[0][doc.docValue].ToString();
            item.PreFix = dt.Rows[0][doc.PreFix].ToString();
            item.Remark = dt.Rows[0][doc.Remark].ToString();
            item.Id = dt.Rows[0][doc.Id].ToString();
            //item.PositionName = dt.Rows[0][dt.PositionName].ToString();


            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + doc.table + " Where " + doc.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public DocType selectByPk(String saleId)
        {
            DocType item = new DocType();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + doc.table + " Where " + doc.pkField + "='" + saleId + "'";
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

            sql = "Select * From " + doc.table + " Where " + doc.docModule + "='" + dtId + "' and " + doc.Active + "='1' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public String selectPrefixByModule(String docModule, String docType)
        {
            //DocType item = new DocType();
            String sql = "";

            sql = "Select "+doc.PreFix+" From " + doc.table + " Where " + doc.docModule + "='" + docModule + "' and " + doc.docType + "='" + docType + "' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt.Rows[0][doc.PreFix].ToString();
        }
        private String insert(DocType p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "sf" + p.getGenID();
            }
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Insert Into " + doc.table + " (" + doc.pkField + "," + doc.Active + "," + doc.docModule + "," +
                doc.docType + "," + doc.docValue + "," + doc.PreFix + "," +
                doc.Remark + ") " +
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

            sql = "Update " + doc.table + " Set " + doc.docModule + "='" + p.docModule + "', " +
                doc.docType + "='" + p.docType + "', " +
                doc.PreFix + "='" + p.PreFix + "', " +
                doc.Remark + "='" + p.Remark + "' " +

                "Where " + doc.pkField + "='" + p.Id + "'";
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
            sql = "Delete From " + doc.table;
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
                item.Value = dt.Rows[i][doc.PreFix].ToString();
                item.Text = dt.Rows[i][doc.docType].ToString();
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
