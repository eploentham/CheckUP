using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class MOUDB
    {
        ConnectDB conn;
        public MOU mo;
        public MOUDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            mo = new MOU();
            mo.Active = "mou_active";
            mo.CompAddress1 = "comp_address1";
            mo.CompAddress2 = "comp_address2";
            mo.CompId = "comp_id";
            mo.CompName = "comp_name";
            mo.CompTaxId = "comp_tax_id";
            mo.ContactName = "contact_name";
            mo.CustAddress = "cust_address";
            mo.CustEmail = "cust_email";
            mo.CustFax = "cust_fax";
            mo.CustMobile = "cust_mobile";
            mo.CustMou = "cust_mou_name";
            mo.CustName = "cust_name";
            mo.CustTel = "cust_tel";
            mo.Id = "mou_id";
            mo.Line1 = "line1";
            mo.MOUNumberMain = "mou_number_main";
            mo.QuoId = "quo_id";
            mo.QuoNumber = "quo_number";
            mo.Remark = "remark";
            mo.StaffMOUEmail = "staff_mou_email";
            mo.StaffQuoId = "staff_quo_id";
            mo.StaffMOUName = "staff_mou_name";
            mo.StaffQuoName = "staff_quo_name";
            mo.StaffMOUTel = "staff_mou_tel";
            mo.MOUNumberCnt = "mou_number_cnt";
            mo.statusMOU = "status_mou";
            mo.DatePeriod = "date_period";
            mo.CustId = "cust_id";
            mo.StaffMOUMobile = "staff_mou_mobile";
            mo.StaffMOUId = "staff_mou_id";
            mo.CustMOUId = "cust_mou_id";
            mo.StaffAnalysisId = "staff_analysis_id";
            mo.StaffAnalysisName = "staff_analysis_name";
            mo.StaffPlaceRecordId = "staff_place_record_id";
            mo.StaffPlaceRecordName = "staff_place_record_name";
            mo.dateCancel = "date_cancel";
            mo.dateCreate = "date_create";
            mo.dateModi = "date_modi";
            mo.DatePlaceRecord = "date_place_record";
            mo.userCancel = "user_cancel";
            mo.userCreate = "user_create";
            mo.userModi = "user_modi";
            mo.StaffPlaceRecordPosition = "staff_place_record_position";
            mo.StatusReceiveSample = "status_receive_sample";
            mo.StatusBill = "status_bill";
            mo.MOUDate = "mou_date";
            mo.MOUName = "mou_name";
            mo.docType = "doc_type";

            mo.pkField = "mou_id";
            mo.table = "t_mou";
        }
        private MOU setData(MOU item, DataTable dt)
        {
            item.Active = dt.Rows[0][mo.Active].ToString();
            item.CompAddress1 = dt.Rows[0][mo.CompAddress1].ToString();
            item.CompAddress2 = dt.Rows[0][mo.CompAddress2].ToString();
            item.CompId = dt.Rows[0][mo.CompId].ToString();
            item.CompName = dt.Rows[0][mo.CompName].ToString();
            item.CompTaxId = dt.Rows[0][mo.CompTaxId].ToString();
            item.ContactName = dt.Rows[0][mo.ContactName].ToString();
            item.CustAddress = dt.Rows[0][mo.CustAddress].ToString();
            item.CustEmail = dt.Rows[0][mo.CustEmail].ToString();
            item.CustFax = dt.Rows[0][mo.CustFax].ToString();
            item.CustMobile = dt.Rows[0][mo.CustMobile].ToString();
            item.CustMou = dt.Rows[0][mo.CustMou].ToString();
            item.CustName = dt.Rows[0][mo.CustName].ToString();
            item.CustTel = dt.Rows[0][mo.CustTel].ToString();
            item.Id = dt.Rows[0][mo.Id].ToString();
            item.Line1 = dt.Rows[0][mo.Line1].ToString();
            item.MOUNumberMain = dt.Rows[0][mo.MOUNumberMain].ToString();
            item.QuoId = dt.Rows[0][mo.QuoId].ToString();
            item.QuoNumber = dt.Rows[0][mo.QuoNumber].ToString();
            item.Remark = dt.Rows[0][mo.Remark].ToString();
            item.StaffMOUEmail = dt.Rows[0][mo.StaffMOUEmail].ToString();
            item.StaffQuoId = dt.Rows[0][mo.StaffQuoId].ToString();
            item.StaffMOUName = dt.Rows[0][mo.StaffMOUName].ToString();
            item.StaffQuoName = dt.Rows[0][mo.StaffQuoName].ToString();
            item.StaffMOUTel = dt.Rows[0][mo.StaffMOUTel].ToString();
            item.MOUNumberCnt = dt.Rows[0][mo.MOUNumberCnt].ToString();
            item.statusMOU = dt.Rows[0][mo.statusMOU].ToString();
            item.DatePeriod = dt.Rows[0][mo.DatePeriod].ToString();
            item.CustId = dt.Rows[0][mo.CustId].ToString();
            item.StaffMOUMobile = dt.Rows[0][mo.StaffMOUMobile].ToString();
            item.StaffMOUId = dt.Rows[0][mo.StaffMOUId].ToString();
            item.CustMOUId = dt.Rows[0][mo.CustMOUId].ToString();
            item.StaffAnalysisId = dt.Rows[0][mo.StaffAnalysisId].ToString();
            item.StaffAnalysisName = dt.Rows[0][mo.StaffAnalysisName].ToString();
            item.StaffPlaceRecordId = dt.Rows[0][mo.StaffPlaceRecordId].ToString();
            item.StaffPlaceRecordName = dt.Rows[0][mo.StaffPlaceRecordName].ToString();
            item.dateCancel = dt.Rows[0][mo.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][mo.dateCreate].ToString();
            item.dateModi = dt.Rows[0][mo.dateModi].ToString();
            item.DatePlaceRecord = dt.Rows[0][mo.DatePlaceRecord].ToString();
            item.userCancel = dt.Rows[0][mo.userCancel].ToString();
            item.userCreate = dt.Rows[0][mo.userCreate].ToString();
            item.userModi = dt.Rows[0][mo.userModi].ToString();
            item.StaffPlaceRecordPosition = dt.Rows[0][mo.StaffPlaceRecordPosition].ToString();
            item.StatusReceiveSample = dt.Rows[0][mo.StatusReceiveSample].ToString();
            item.StatusBill = dt.Rows[0][mo.StatusBill].ToString();
            item.MOUDate = dt.Rows[0][mo.MOUDate].ToString();
            item.MOUName = dt.Rows[0][mo.MOUName].ToString();
            item.docType = dt.Rows[0][mo.docType].ToString();
            
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + mo.table + " Where " + mo.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectMOUView()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select Distinct "+mo.MOUNumberMain+","+mo.CustName+","+mo.ContactName+","+mo.StaffQuoName+" From " + mo.table + " Where " + mo.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        //public DataTable selectDistinctRemark1()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select Distinct " + mo.Remark1 + " From " + mo.table + " Where " + mo.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        //public DataTable selectDistinctRemark2()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select Distinct " + mo.Remark2 + " From " + mo.table + " Where " + mo.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        //public DataTable selectDistinctRemark3()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select Distinct " + mo.Remark3 + " From " + mo.table + " Where " + mo.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        public MOU selectByPk(String moId)
        {
            MOU item = new MOU();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + mo.table + " Where " + mo.pkField + "='" + moId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public MOU selectByNumber1(String moNumber)
        {
            MOU item = new MOU();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + mo.table + " Where " + mo.MOUNumberMain + "='" + moNumber + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public DataTable selectByNumber(String moNumber)
        {
            String sql = "";

            sql = "Select "+mo.MOUNumberMain+","+mo.Id+","+mo.MOUNumberCnt+" From " + mo.table + " Where " + mo.MOUNumberMain + "='" + moNumber + "' and "+mo.Active+"='1'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    item = setData(item, conn.dt);
            //}
            return dt;
        }
        
        public String selectQuoNumberByNumber(String moNumber)
        {
            String sql = "";

            sql = "Select " + mo.QuoNumber + " From " + mo.table + " Where " + mo.MOUNumberMain + "='" + moNumber + "' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            sql = dt.Rows[0][mo.QuoNumber].ToString();
            return sql;
        }
        public DataTable selectByNoBilling()
        {
            String sql = "";

            sql = "Select * From " + mo.table + " Where " + mo.Active + "='1' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //sql = dt.Rows[0][mo.QuoNumber].ToString();
            return dt;
        }
        public DataTable selectByNoBilling(String cuId)
        {
            String sql = "";
            if (cuId.Equals(""))
            {
                sql = "Select mo." + mo.MOUNumberMain + "," + mo.MOUDate + "," + mo.CustName + ",mo." + mo.Remark + ",mo." + mo.Id + ", sum(moi.amount1) as amount1, count(1) as cnt " +
                    " From " + mo.table + " as mo inner join t_mou_item as moi on mo." + mo.Id + "=moi.mou_id "+
                    "Where mo." + mo.Active + "='1' and mo." + mo.StatusBill + "= '1' and moi.mou_item_active='1' "+
                    "Group By mo." + mo.MOUNumberMain + "," + mo.MOUDate + ",mo." + mo.Remark + "," + mo.CustName+ ",mo." + mo.Id+
                    " Order By mo."+mo.MOUNumberMain;
            }
            else
            {
                sql = "Select mo." + mo.MOUNumberMain + "," + mo.MOUDate + "," + mo.CustName + ",mo." + mo.Remark + ",mo." + mo.Id + ", sum(moi.amount1) as amount1, count(1) as cnt " +
                    " From " + mo.table + " as mo inner join t_mou_item as moi on mo." + mo.Id + "=moi.mou_id " +
                    "Where mo." + mo.Active + "='1' and mo." + mo.CustId + "='" + cuId + "' and mo." + mo.StatusBill + "= '1' and moi.mou_item_active='1' "+
                    "Group By mo." + mo.MOUNumberMain + "," + mo.MOUDate + ",mo." + mo.Remark + "," + mo.CustName+ ",mo." + mo.Id+
                    " Order By mo." + mo.MOUNumberMain;
            }
            //sql = "Select " + mo.MOUNumber + " From " + mo.table + " Where " + mo.Active + "='1' and "+mo.CustId+"='"+cuId+"'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //sql = dt.Rows[0][mo.QuoNumber].ToString();
            return dt;
        }
        public String selectMaxByNumber(String moNumber)
        {
            String sql = "";

            sql = "Select count(1) as cnt From " + mo.table + " Where " + mo.MOUNumberMain + "='" + moNumber + "' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            sql = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
            return sql;
        }
        private String insert(MOU p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "mo" + p.getGenID();
            }

            p.CompAddress1 = p.CompAddress1.Replace("''", "'");
            p.CompAddress2 = p.CompAddress2.Replace("''", "'");
            p.CompName = p.CompName.Replace("''", "'");
            p.ContactName = p.ContactName.Replace("''", "'");
            p.CustAddress = p.CustAddress.Replace("''", "'");
            p.CustName = p.CustName.Replace("''", "'");
            p.StaffMOUName = p.StaffMOUName.Replace("''", "'");
            p.StaffQuoName = p.StaffQuoName.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            p.StaffAnalysisName = p.StaffAnalysisName.Replace("''", "'");
            p.StaffPlaceRecordName = p.StaffPlaceRecordName.Replace("''", "'");
            p.StaffPlaceRecordPosition = p.StaffPlaceRecordPosition.Replace("''", "'");
            p.MOUName = p.MOUName.Replace("''", "'");

            p.userCreate = p.StaffQuoId;
            p.dateCreate = p.dateGenDB;
            p.StatusReceiveSample = "0";
            p.StatusBill = "1";
            sql = "Insert Into " + mo.table + " (" + mo.pkField + "," + mo.Active + "," + mo.CompAddress1 + "," +
                mo.CompAddress2 + "," + mo.CompId + "," + mo.CompName + "," +
                mo.CompTaxId + "," + mo.ContactName + "," + mo.CustAddress + "," +
                mo.CustEmail + "," + mo.CustFax + "," + mo.CustMobile + "," +
                mo.CustMou + "," + mo.CustName + "," + mo.CustTel + "," +
                mo.Line1 + "," + mo.MOUNumberMain + "," + mo.QuoId + "," +
                mo.QuoNumber + "," + mo.Remark + "," + mo.StaffMOUEmail + "," +
                mo.StaffQuoId + "," + mo.StaffMOUName + "," + mo.StaffQuoName + "," +
                mo.StaffMOUTel + "," + mo.MOUNumberCnt + "," + mo.StaffMOUMobile + "," +
                mo.statusMOU + "," + mo.DatePeriod + "," + mo.CustId + "," +
                mo.CustMOUId + "," + mo.StaffMOUId + "," + mo.dateCancel + "," +
                mo.dateCreate + "," + mo.dateModi + "," + mo.userCancel + "," +
                mo.userCreate + "," + mo.userModi + "," + mo.StaffPlaceRecordId + "," +
                mo.StaffPlaceRecordName + "," + mo.StaffAnalysisId + "," + mo.StaffAnalysisName + "," +
                mo.StaffPlaceRecordPosition + "," + mo.StatusReceiveSample + "," + mo.StatusBill + "," + mo.MOUName + "," + mo.docType + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.CompAddress1 + "','" +
                p.CompAddress2 + "','" + p.CompId + "','" + p.CompName + "','" +
                p.CompTaxId + "','" + p.ContactName + "','" + p.CustAddress + "','" +
                p.CustEmail + "','" + p.CustFax + "','" + p.CustMobile + "','" +
                p.CustMou + "','" + p.CustName + "','" + p.CustTel + "','" +
                p.Line1 + "','" + p.MOUNumberMain + "','" + p.QuoId + "','" +
                p.QuoNumber + "','" + p.Remark + "','" + p.StaffMOUEmail + "','" +
                p.StaffQuoId + "','" + p.StaffMOUName + "','" + p.StaffQuoName + "','" +
                p.StaffMOUTel + "'," + p.MOUNumberCnt + ",'" + p.StaffMOUMobile + "','" +
                p.statusMOU + "','" + p.DatePeriod + "','" + p.CustId + "','" +
                p.CustMOUId + "','" + p.StaffMOUId + "','" + p.dateCancel + "'," +
                p.dateCreate + ",'" + p.dateModi + "','" + p.userCancel + "','" +
                p.userCreate + "','" + p.userModi + "','" + p.StaffPlaceRecordId + "','" +
                p.StaffPlaceRecordName + "','" + p.StaffAnalysisId + "','" + p.StaffAnalysisName + "','" +
                p.StaffPlaceRecordPosition + "','" + p.StatusReceiveSample + "','" + p.StatusBill + "','" + p.MOUName + "','" + p.docType + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert MOU");
            }
            finally
            {
            }
            return chk;
        }
        private String update(MOU p)
        {
            String sql = "", chk = "";

            p.CompAddress1 = p.CompAddress1.Replace("''", "'");
            p.CompAddress2 = p.CompAddress2.Replace("''", "'");
            p.CompName = p.CompName.Replace("''", "'");
            p.ContactName = p.ContactName.Replace("''", "'");
            p.CustAddress = p.CustAddress.Replace("''", "'");
            p.CustName = p.CustName.Replace("''", "'");
            p.StaffMOUName = p.StaffMOUName.Replace("''", "'");
            p.StaffQuoName = p.StaffQuoName.Replace("''", "'");
            p.Remark = p.Remark.Replace("''", "'");
            p.StaffPlaceRecordPosition = p.StaffPlaceRecordPosition.Replace("''", "'");
            p.StaffPlaceRecordName = p.StaffPlaceRecordName.Replace("''", "'");
            p.MOUName = p.MOUName.Replace("''", "'");

            //p.dateModi = p.dateGenDB;
            sql = "Update " + mo.table + " Set " + mo.CompAddress1 + "='" + p.CompAddress1 + "', " +
                mo.CompAddress2 + "='" + p.CompAddress2 + "', " +
                mo.CompId + "='" + p.CompId + "', " +
                mo.CompName + "='" + p.CompName + "', " +
                mo.CompTaxId + "='" + p.CompTaxId + "', " +
                mo.ContactName + "='" + p.ContactName + "', " +
                mo.CustAddress + "='" + p.CustAddress + "', " +
                mo.CustEmail + "='" + p.CustEmail + "', " +
                mo.CustFax + "='" + p.CustFax + "', " +
                mo.CustMobile + "='" + p.CustMobile + "', " +
                mo.CustMou + "='" + p.CustMou + "', " +
                mo.CustName + "='" + p.CustName + "', " +
                mo.CustTel + "='" + p.CustTel + "', " +
                mo.Line1 + "='" + p.Line1 + "', " +
                mo.MOUNumberMain + "='" + p.MOUNumberMain + "', " +
                mo.QuoId + "='" + p.QuoId + "', " +
                mo.QuoNumber + "='" + p.QuoNumber + "', " +
                mo.Remark + "='" + p.Remark + "', " +
                mo.StaffMOUEmail + "='" + p.StaffMOUEmail + "', " +
                mo.StaffQuoId + "='" + p.StaffQuoId + "', " +
                mo.StaffMOUName + "='" + p.StaffMOUName + "', " +
                mo.StaffMOUId + "='" + p.StaffMOUId + "', " +
                mo.StaffQuoName + "='" + p.StaffQuoName + "', " +
                mo.StaffMOUTel + "='" + p.StaffMOUTel + "', " +
                mo.MOUNumberCnt + "=" + p.MOUNumberCnt + ", " +
                mo.DatePeriod + "='" + p.DatePeriod + "', " +
                //mo.Remark + "='" + p.Remark + "', " +
                mo.CustId + "='" + p.CustId + "', " +
                mo.StaffMOUMobile + "='" + p.StaffMOUMobile + "', " +
                mo.userModi + "='" + p.userModi + "', " +
                mo.dateModi + "=" + p.dateGenDB + ", " +
                mo.StaffPlaceRecordPosition + "='" + p.StaffPlaceRecordPosition + "', " +
                mo.StaffPlaceRecordName + "='" + p.StaffPlaceRecordName + "', " +
                mo.StaffPlaceRecordId + "='" + p.StaffPlaceRecordId + "', " +
                mo.MOUName + "='" + p.MOUName + "' " +
                "Where " + mo.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update MOU");
            }
            finally
            {
            }
            return chk;
        }
        public String insertMOU(MOU p)
        {
            MOU item = new MOU();
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
            sql = "Delete From " + mo.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String VoidMOU(String moId)
        {
            String sql = "", chk = "";

            sql = "Update " + mo.table + " Set " + mo.Active + "='3' " +
                "Where " + mo.pkField + "='" + moId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateStatusBill(String moId)
        {
            String sql = "", chk = "";

            sql = "Update " + mo.table + " Set " + mo.StatusBill + "='2' " +
                "Where " + mo.pkField + "='" + moId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateMOUPlaceRecord(String moId, String sfPlaceRecordId, String sfPlaceRecordName, String sfAnalysisId, String sfAnalysisName, String datePlaceRecord)
        {
            String sql = "", chk = "";

            sql = "Update " + mo.table + " Set " + mo.StaffPlaceRecordId + "='" + sfPlaceRecordId + "', " +
                mo.StaffPlaceRecordName + "='" + sfPlaceRecordName.Replace("'","''") + "', " +
                mo.StaffAnalysisId + "='" + sfAnalysisId + "', " +
                mo.StaffAnalysisName + "='" + sfAnalysisName.Replace("'", "''") + "', " +
                mo.StatusReceiveSample+"='1', "+
                mo.DatePlaceRecord + "='" + datePlaceRecord + "' " +
                "Where " + mo.pkField + "='" + moId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public ComboBox getCboMOUNumber(ComboBox c, String mouNumber)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectByNumber(mouNumber);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = dt.Rows[i][mo.Id].ToString();
                item.Text = dt.Rows[i][mo.MOUNumberMain].ToString() + "-" + dt.Rows[i][mo.MOUNumberCnt].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public String getMOUNumber(String mouNumber)
        {
            String sql = "", doc = "", cnt = "", year = "";
            String[] doc1 = mouNumber.Split('-');
            if (!mouNumber.Equals(""))
            {
                if (doc[0].ToString().Length > 5)
                {
                    year = doc[0].ToString().Substring(2, 2);
                }
            }
            else
            {
                year = getYear();
            }
            sql = "Select count(" + mo.QuoNumber + ") as cnt From " + mo.table + " Where +" + mo.MOUNumberMain + "='" + doc1[0] + "'";
            DataTable dt = conn.selectData(sql);
            if ((dt.Rows.Count > 0) && (!doc1[0].Equals("")))
            {
                cnt = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                doc = doc1[0];
            }
            else
            {
                //if (!System.DateTime.Now.Year.ToString().Equals(year))
                //{
                //year = getYear();
                //    year = year.Substring(2);
                //}
                sql = "Select count(" + mo.QuoNumber + ") as cnt From " + mo.table;
                dt = conn.selectData(sql);
                doc = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
                doc = "00000" + doc;
                doc = doc.Substring(doc.Length - 5);
                cnt = "1";
                //doc = "00001";
            }
            return "MOU" + year + doc + "-" + cnt;
        }
        public String getMOUMaxNumber(String prefix,String mouNumber)
        {
            String sql = "", doc = "", year = "";
            String[] doc1 = mouNumber.Split('-');
            if (!mouNumber.Equals(""))
            {
                if (doc[0].ToString().Length > 5)
                {
                    year = doc[0].ToString().Substring(2, 2);
                }
            }
            else
            {
                year = getYear();
            }

            sql = "Select count(" + mo.QuoNumber + ") as cnt From " + mo.table;
            DataTable dt = conn.selectData(sql);
            doc = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
            doc = "00000" + doc;
            doc = doc.Substring(doc.Length - 5);
            //cnt = "1";
            //doc = "00001";

            return prefix + year + doc;
        }
        public String getMOUMaxNumber(String mouNumber)
        {
            String sql = "", doc = "", year = "";
            String[] doc1 = mouNumber.Split('-');
            if (!mouNumber.Equals(""))
            {
                if (doc[0].ToString().Length > 5)
                {
                    year = doc[0].ToString().Substring(2, 2);
                }
            }
            else
            {
                year = getYear();
            }

            sql = "Select count(" + mo.QuoNumber + ") as cnt From " + mo.table;
            DataTable dt = conn.selectData(sql);
            doc = String.Concat(int.Parse(dt.Rows[0]["cnt"].ToString()) + 1);
            doc = "00000" + doc;
            doc = doc.Substring(doc.Length - 5);
            //cnt = "1";
            //doc = "00001";

            return "MOU" + year + doc;
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
