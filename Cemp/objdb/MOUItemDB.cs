using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 * 
 * 57.12.09.02  ให้สามารถ รวมsample
 * 57.12.11.01 เปาแจ้งว่า  ใบข้อตกลง ควรเรียงตาม สถานที่เก็บ
 * */
namespace Cemp.objdb
{
    public class MOUItemDB
    {
        ConnectDB conn;
        public MOUItem moi;
        public MOUItemDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            moi = new MOUItem();
            moi.Active = "mou_item_active";
            moi.Id = "mou_item_id";
            moi.ItemDescription = "item_description";
            moi.ItemId = "item_id";
            moi.MethodDescription = "method_description";
            moi.MethodId = "method_id";
            moi.MOUId = "mou_id";
            moi.PlaceRecord = "place_record";
            moi.RowNumber = "row_number";
            moi.Sample = "sample";
            moi.dateCancel = "date_cancel";
            moi.dateCreate = "date_create";
            moi.dateModi = "date_modi";
            
            moi.userCancel = "user_cancel";
            moi.userCreate = "user_create";
            moi.userModi = "user_modi";

            moi.ItemGroupId = "item_group_id";
            moi.ItemGroupNameE = "item_group_name_e";
            moi.ItemGroupNameT = "item_group_name_t";
            moi.ItemGroupSort = "item_group_sort";
            moi.DatePlaceRecord = "date_place_record";

            moi.MOUNumber = "mou_number";
            moi.MOUNumberCnt = "mou_number_cnt";
            moi.PriceSale = "price_sale";
            moi.PriceCost = "price_cost";
            moi.Amount = "amount1";
            moi.Discount = "discount";

            moi.MOUNumberMain = "mou_number_main";
            moi.ItemType = "item_type";

            moi.TempSave = "temp_save";

            moi.SampleOld = "sample_old";
            moi.StatusMerge = "status_merge";
            moi.MergeId = "mou_item_id_merge";
            moi.StatusBill = "status_bill";
            moi.StatusResult = "status_result";

            moi.pkField = "mou_item_id";
            moi.table = "t_mou_item";
        }
        private MOUItem setData(MOUItem item, DataTable dt)
        {
            item.Active = dt.Rows[0][moi.Active].ToString();
            item.Id = dt.Rows[0][moi.Id].ToString();
            item.ItemDescription = dt.Rows[0][moi.ItemDescription].ToString();
            item.ItemId = dt.Rows[0][moi.ItemId].ToString();
            item.MethodDescription = dt.Rows[0][moi.MethodDescription].ToString();
            item.MethodId = dt.Rows[0][moi.MethodId].ToString();
            item.MOUId = dt.Rows[0][moi.MOUId].ToString();
            item.PlaceRecord = dt.Rows[0][moi.PlaceRecord].ToString();
            item.RowNumber = dt.Rows[0][moi.RowNumber].ToString();
            item.Sample = dt.Rows[0][moi.Sample].ToString();
            item.dateCancel = dt.Rows[0][moi.dateCancel].ToString();
            item.dateCreate = dt.Rows[0][moi.dateCreate].ToString();
            item.dateModi = dt.Rows[0][moi.dateModi].ToString();

            item.userCancel = dt.Rows[0][moi.userCancel].ToString();
            item.userCreate = dt.Rows[0][moi.userCreate].ToString();
            item.userModi = dt.Rows[0][moi.userModi].ToString();

            item.ItemGroupId = dt.Rows[0][moi.ItemGroupId].ToString();
            item.ItemGroupNameE = dt.Rows[0][moi.ItemGroupNameE].ToString();
            item.ItemGroupNameT = dt.Rows[0][moi.ItemGroupNameT].ToString();
            item.ItemGroupSort = dt.Rows[0][moi.ItemGroupSort].ToString();

            item.DatePlaceRecord = dt.Rows[0][moi.DatePlaceRecord].ToString();
            item.MOUNumber = dt.Rows[0][moi.MOUNumber].ToString();
            item.MOUNumberCnt = dt.Rows[0][moi.MOUNumberCnt].ToString();

            item.PriceSale = dt.Rows[0][moi.PriceSale].ToString();
            item.PriceCost = dt.Rows[0][moi.PriceCost].ToString();
            item.Amount = dt.Rows[0][moi.Amount].ToString();
            item.Discount = dt.Rows[0][moi.Discount].ToString();

            item.MOUNumberMain = dt.Rows[0][moi.MOUNumberMain].ToString();
            item.ItemType = dt.Rows[0][moi.ItemType].ToString();

            item.TempSave = dt.Rows[0][moi.TempSave].ToString();
            item.StatusMerge = dt.Rows[0][moi.StatusMerge].ToString();
            item.MergeId = dt.Rows[0][moi.MergeId].ToString();
            item.SampleOld = dt.Rows[0][moi.SampleOld].ToString();

            item.StatusBill = dt.Rows[0][moi.StatusBill].ToString();
            item.StatusResult = dt.Rows[0][moi.StatusResult].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + moi.table + " Where " + moi.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public MOUItem selectByPk(String saleId)
        {
            MOUItem item = new MOUItem();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + moi.table + " Where " + moi.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public DataTable selectByMoId(String moId)
        {
            //MOUItem item = new MOUItem();
            String sql = "";

            sql = "Select * From " + moi.table + " Where " + moi.MOUId + "='" + moId + "' Order By "+moi.RowNumber;
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByMoNumberPrint(String moNumber)
        {
            //MOUItem item = new MOUItem();
            String sql = "";
            String[] tmp = moNumber.Split('-');
            //sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + tmp[0] + "' and " + moi.MOUNumberCnt + " =" + tmp[1] + " and " + moi.StatusMerge + " in ('0','2') Order By " + moi.RowNumber;     //57.12.11.01 -
            sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + tmp[0] + "' and " + moi.MOUNumberCnt + " =" + tmp[1] + " and " + moi.StatusMerge + " in ('0','2') Order By " + moi.PlaceRecord+","+moi.RowNumber;       //57.12.11.01 +
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectDatePlaceByNumber(String moNumber)
        {
            String sql = "";
            sql = "Select Distinct " + moi.DatePlaceRecord + "  From " + moi.table + " Where " + moi.MOUNumber + "='" + moNumber + "' and " + moi.Active + "='1'";
            DataTable dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectPlaceByNumber(String moNumber)
        {
            String sql = "";
            sql = "Select Distinct " + moi.PlaceRecord + "  From " + moi.table + " Where " + moi.MOUNumber + "='" + moNumber + "' and " + moi.Active + "='1'";
            DataTable dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectByMoiId1(String moId)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt="", number="";

            cnt = "";
            sql = "Select * From " + moi.table + " Where " + moi.MOUId + "='" + moId + "' and " + moi.DatePlaceRecord + "=''  Order By " + moi.RowNumber;

            //sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + number +"' and "+ moi.MOUNumberCnt + "=" + cnt + " Order By " + moi.RowNumber;
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByMoNumber1(String moNumber, String moId)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            if (moNumber.Equals("xxxxx"))
            {
                sql = "Select * From " + moi.table + " Where " + moi.MOUId + "='" + moId + "' and " + moi.MOUNumber + "='' Order By " + moi.RowNumber;
            }
            else
            {
                if (moNumber.IndexOf("-") <= 0)
                {
                    cnt = "";
                }
                else
                {
                    number = moNumber.Substring(0, moNumber.IndexOf("-"));
                    cnt = moNumber.Substring(moNumber.IndexOf("-"));
                    cnt = cnt.Replace("-", "");
                }
                //sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + number + "' and " + moi.MOUNumberCnt + "=" + cnt + " Order By " + moi.RowNumber;  // 57.12.09.02 -
                sql = "Select * From " + moi.table + 
                    " Where " + moi.MOUNumber + "='" + number + "' and " + moi.MOUNumberCnt + "=" + cnt + " and "+moi.StatusMerge+" in ('0','2') Order By " + moi.RowNumber;    //57.12.09.02 +
            }

            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectByMoNumber(String moNumber)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            if (moNumber.Equals("xxxxx"))
            {
                sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + number + "' and " + moi.MOUNumberCnt + "=" + cnt + " Order By " + moi.RowNumber;
            }
            else
            {
                if (moNumber.IndexOf("-") <= 0)
                {
                    cnt = "";
                }
                else
                {
                    number = moNumber.Substring(0, moNumber.IndexOf("-"));
                    cnt = moNumber.Substring(moNumber.IndexOf("-"));
                    cnt = cnt.Replace("-", "");
                }
                sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + number + "' and " + moi.MOUNumberCnt + "=" + cnt + " Order By " + moi.RowNumber;
            }
            
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        public String selectCntByMoNumber(String moNumber, String datePlaceRecord)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";

            sql = "Select " + moi.MOUNumberCnt + " From " + moi.table + " Where " + moi.MOUNumber + "='" + moNumber + "' and " + moi.DatePlaceRecord + "='" + datePlaceRecord + "'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                number = dt.Rows[0][moi.MOUNumberCnt].ToString();
            }
            else
            {
                sql = "Select max(" + moi.MOUNumberCnt + ") as cnt From " + moi.table + " Where " + moi.MOUNumber + "='" + moNumber + "' ";
                dt = conn.selectData(sql);
                number = String.Concat(int.Parse(NumberNull1(dt.Rows[0]["cnt"].ToString())) + 1);
            }
            return number;
        }
        public DataTable selectDistinctByMoId1(String moId)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            sql = "Select " + moi.ItemType + " From " + moi.table + " Where " + moi.MOUId + "='" + moId + "' and "+moi.ItemType+" <> '' and "+moi.TempSave+"='0' and "+moi.DatePlaceRecord+" <> '' Group By " + moi.ItemType;
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            return dt;
        }
        public DataTable selectDistinctByMoId(String moId)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            sql = "Select " + moi.ItemType + " From " + moi.table + " Where " + moi.MOUId + "='" + moId + "' Group By " + moi.ItemType;
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            return dt;
        }
        public String selectMaxByMoNumber(String ity)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            sql = "Select max("+moi.MOUNumber+") as cnt From " + moi.table + " Where " + moi.ItemType + "='" + ity + "' ";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt.Rows[0]["cnt"].ToString();
        }
        public String selectMaxCntByMoNumber(String mouNumber, String ity)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            sql = "Select max(" + moi.MOUNumberCnt + ") as cnt From " + moi.table + " Where " + moi.ItemType + "='" + ity + "' and "+moi.MOUId+"='"+mouNumber+"'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt.Rows[0]["cnt"].ToString();
        }
        public String selectMaxByMoNumber1(String moId,String ity)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            sql = "Select max(" + moi.MOUNumber + ") as cnt From " + moi.table + " Where " + moi.ItemType + "='" + ity + "' and "+moi.MOUId+"='"+moId+"'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt.Rows[0]["cnt"].ToString();
        }
        public DataTable selectNoBillByCust(String cuId)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", number = "";
            if (cuId.Equals(""))
            {
                sql = "Select moi." + moi.MOUNumber + ",moi." + moi.MOUNumberCnt + ", mo. cust_name, mo. cust_id, moi." + moi.DatePlaceRecord + ", count(1) as cnt, sum(" + moi.Amount + ") as amt " +
                "From " + moi.table + " as moi " +
                " Left Join t_mou mo On moi." + moi.MOUId + " = mo.mou_id " +
                " Where  moi." + moi.Active + "='1' and mo.mou_active = '1' and moi." + moi.StatusBill + "='0' and moi.temp_save= '1'";
            }
            else
            {
                sql = "Select moi." + moi.MOUNumber + ",moi." + moi.MOUNumberCnt + ", mo. cust_name, mo. cust_id, moi."+moi.DatePlaceRecord+", count(1) as cnt, sum(" + moi.Amount + ") as amt " +
                "From " + moi.table + " as moi " +
                " Left Join t_mou mo On moi." + moi.MOUId + " = mo.mou_id " +
                " Where mo.cust_id = '" + cuId + "' and moi." + moi.Active + "='1' and mo.mou_active = '1' and moi." + moi.StatusBill + "='0' and moi.temp_save= '1'";
            }
            
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);

            return dt;
        }
        private String insert(MOUItem p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "moi" + p.getGenID();
            }

            p.MethodDescription = p.MethodDescription.Replace("'", "''");
            p.ItemDescription = p.ItemDescription.Replace("'", "''");
            p.PlaceRecord = p.PlaceRecord.Replace("'", "''");
            p.ItemGroupNameE = p.ItemGroupNameE.Replace("'", "''");
            p.ItemGroupNameT = p.ItemGroupNameT.Replace("'", "''");

            p.dateCreate = p.dateGenDB;

            sql = "Insert Into " + moi.table + " (" + moi.pkField + "," + moi.Active + "," + moi.ItemDescription + "," +
                moi.ItemId + "," + moi.MethodDescription + "," + moi.MethodId + "," +
                moi.MOUId + "," + moi.PlaceRecord + "," + moi.RowNumber + "," +
                moi.Sample + "," + moi.ItemGroupNameE + "," + moi.ItemGroupNameT + "," +
                moi.ItemGroupSort + "," + moi.ItemGroupId + "," + moi.DatePlaceRecord + "," +
                moi.MOUNumber + "," + moi.MOUNumberCnt + "," + moi.PriceCost + "," +
                moi.PriceSale + "," + moi.Amount + "," + moi.Discount + "," +
                moi.MOUNumberMain + "," + moi.ItemType + "," + moi.TempSave + "," + 
                moi.StatusMerge + "," + moi.MergeId + "," + moi.SampleOld + "," +
                moi.StatusBill + "," + moi.StatusResult + "," + moi.dateCreate + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.ItemDescription + "','" +
                p.ItemId + "','" + p.MethodDescription + "','" + p.MethodId + "','" +
                p.MOUId + "','" + p.PlaceRecord + "','" + p.RowNumber + "','" +
                p.Sample + "','" + p.ItemGroupNameE + "','" + p.ItemGroupNameT + "','" +
                p.ItemGroupSort + "','" + p.ItemGroupId + "','" + p.DatePlaceRecord + "','" +
                p.MOUNumber + "'," + NumberNull1(p.MOUNumberCnt) + "," + NumberNull1(p.PriceCost) + "," +
                NumberNull1(p.PriceSale) + "," + NumberNull1(p.Amount) + "," + NumberNull1(p.Discount) + ",'" +
                p.MOUNumberMain + "','" + p.ItemType + "','0','" + 
                p.StatusMerge + "','" + p.MergeId + "','" + p.SampleOld + 
                "','0','0',"+p.dateCreate+")";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert MOUItem");
            }
            finally
            {
            }
            return chk;
        }
        private String update(MOUItem p)
        {
            String sql = "", chk = "";

            p.MethodDescription = p.MethodDescription.Replace("''", "'");
            p.ItemDescription = p.ItemDescription.Replace("''", "'");
            p.PlaceRecord = p.PlaceRecord.Replace("''", "'");
            p.ItemGroupNameE = p.ItemGroupNameE.Replace("'", "''");
            p.ItemGroupNameT = p.ItemGroupNameT.Replace("'", "''");

            p.dateModi = p.dateGenDB;

            sql = "Update " + moi.table + " Set " + moi.ItemDescription + "='" + p.ItemDescription + "', " +
                moi.ItemId + "='" + p.ItemId + "', " +
                moi.MethodDescription + "='" + p.MethodDescription + "', " +
                moi.MethodId + "='" + p.MethodId + "', " +
                moi.MOUId + "='" + p.MOUId + "', " +
                moi.PlaceRecord + "='" + p.PlaceRecord + "', " +
                moi.RowNumber + "=" + p.RowNumber + ", " +
                moi.Sample + "='" + p.Sample + "', " +
                moi.ItemGroupNameE + "='" + p.ItemGroupNameE + "', " +
                moi.ItemGroupNameT + "='" + p.ItemGroupNameT + "', " +
                moi.ItemGroupSort + "='" + p.ItemGroupSort + "', " +
                moi.ItemGroupId + "='" + p.ItemGroupId + "', " +
                moi.DatePlaceRecord + "='" + p.DatePlaceRecord + "', " +
                moi.StatusMerge + "='" + p.StatusMerge + "', " +
                moi.MergeId + "='" + p.MergeId + "', " +
                moi.MOUNumberMain + "='" + p.MOUNumberMain + "', " +
                moi.ItemType + "='" + p.ItemType + "', " +
                moi.SampleOld + "='" + p.SampleOld + "', " +
                moi.dateModi + "=" + p.dateModi + " " +
                "Where " + moi.pkField + "='" + p.Id + "'";
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
        public String insertMOUItem(MOUItem p)
        {
            MOUItem item = new MOUItem();
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
            sql = "Delete From " + moi.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String VoidMOUItem(String mod)
        {
            String sql = "", chk = "";

            sql = "Update " + moi.table + " Set " + moi.Active + "='3' " +
                "Where " + moi.pkField + "='" + mod + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public DataTable selectByNumber(String moNumber)
        {
            String sql = "";

            sql = "Select Distinct " + moi.MOUNumberCnt + " as cnt From " + moi.table + " Where " + moi.MOUNumber + "='" + moNumber + "' and " + moi.Active + "='1'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    item = setData(item, conn.dt);
            //}
            return dt;
        }
        public DataTable selectCustomerNoBill()
        {
            String sql = "";

            //sql = "Select moi." + moi.MOUNumber + ",moi." + moi.MOUNumberCnt + ", mo. cust_name, mo.mou_date" + ", count(1) as cnt, sum(" + moi.Amount + ") as amt " +
            //    "From " + moi.table + " as moi " +
            //    " Left Join t_mou mo On moi." + moi.MOUId + " = mo.mou_id " +
            //    " Where  moi." + moi.Active + "='1' and mo.mou_active = '1' ";

            //sql = "Select Distinct mo.cust_name as cust_name From t_mou as mo left Join " + moi.table + " as moi on mo.mou_id = moi."+moi.MOUId+
            //    " Where moi." + moi.StatusBill + "='0' and moi." + moi.StatusResult + " = '1' and moi." + moi.Active + "='1' and moi." + moi.TempSave + "= '1'";
            sql = "Select Distinct mo.cust_name as cust_name,mo.cust_id From t_mou as mo left Join " + moi.table + " as moi on mo.mou_id = moi." + moi.MOUId +
                " Where moi." + moi.StatusBill + "='0' and moi." + moi.Active + "='1' and moi." + moi.TempSave + "= '1' and mo.mou_active = '1'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    item = setData(item, conn.dt);
            //}
            return dt;
        }
        public DataTable selectCustomerNoResult()
        {
            String sql = "";

            sql = "Select Distinct mo.cust_name as cust_name, mo.cust_id From t_mou as mo left Join " + moi.table + " as moi on mo.mou_id = moi." + moi.MOUId +
                " Where moi." + moi.StatusResult + " = '0' and moi." + moi.Active + "='1' and moi."+moi.TempSave+"= '1'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    item = setData(item, conn.dt);
            //}
            return dt;
        }
        public ComboBox getCboMOUNumber(ComboBox c, String mouNumber)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectByNumber(mouNumber);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                item.Value = mouNumber + "-" + dt.Rows[i]["cnt"].ToString();
                item.Text = mouNumber + "-" + dt.Rows[i]["cnt"].ToString();
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public DataTable selectByNumberMain(String moNumber)
        {
            String sql = "";

            sql = "Select Distinct " + moi.MOUNumber + " as num, "+moi.MOUNumberCnt+" as cnt From " + moi.table + " Where " + moi.MOUNumberMain + "='" + moNumber + "' and " + moi.Active + "='1'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    item = setData(item, conn.dt);
            //}
            return dt;
        }
        public DataTable selectByCustName(String custId)
        {
            String sql = "";

            sql = "Select Distinct moi." + moi.MOUNumber + " as num, moi." + moi.MOUNumberCnt + " as cnt From t_mou as mo left Join " + moi.table + " as moi on mo.mou_id = moi." + moi.MOUId +" "+
                "Where mo.cust_id = '" + custId + "' and " + moi.Active + "='1'";
            //dt = conn.selectData(sql);
            DataTable dt = conn.selectData(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    item = setData(item, conn.dt);
            //}
            return dt;
        }
        public ComboBox getCboMOUNumbernoResult(ComboBox c, String custName)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectByCustName(custName);
            c.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                if (!dt.Rows[i]["num"].ToString().Equals(""))
                {
                    item.Value = dt.Rows[i]["num"].ToString() + "-" + dt.Rows[i]["cnt"].ToString();
                    item.Text = dt.Rows[i]["num"].ToString() + "-" + dt.Rows[i]["cnt"].ToString();
                }
                else
                {
                    item.Value = "xxxxx";
                    item.Text = "xxxxx";
                }
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public ComboBox getCboMOUNumber1(ComboBox c, String mouNumber)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectByNumberMain(mouNumber);
            c.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                if (!dt.Rows[i]["num"].ToString().Equals(""))
                {
                    item.Value = dt.Rows[i]["num"].ToString() + "-" + dt.Rows[i]["cnt"].ToString();
                    item.Text = dt.Rows[i]["num"].ToString() + "-" + dt.Rows[i]["cnt"].ToString();
                }
                else
                {
                    item.Value = "xxxxx";
                    item.Text = "xxxxx";
                }
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
            return c;
        }
        public ComboBox getCboMOUNumberMain(ComboBox c, String mouNumber)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectByNumberMain(mouNumber);
            c.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();
                if (!dt.Rows[i]["num"].ToString().Equals(""))
                {
                    item.Value = dt.Rows[i]["num"].ToString() + "-" + dt.Rows[i]["cnt"].ToString();
                    item.Text = dt.Rows[i]["num"].ToString() + "-" + dt.Rows[i]["cnt"].ToString();
                }
                else
                {
                    item.Value = "xxxxx";
                    item.Text = "xxxxx";
                }
                c.Items.Add(item);
                //c.Items.Add(new );
            }
            //c.SelectedItem = item;
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
        private String UpdateMOUNumber1(String moId, String ity, String doc1, int max)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", doc = "";
            doc = "00000"+max.ToString();
            doc = doc1 + doc.Substring(doc.Length - 5);
            //sql = "Update " + moi.table + " "+
            //    "Set " + moi.MOUNumber + "='" + doc + "', " +
            //    moi.MOUNumberCnt+"=1"+
            //    " Where " + moi.MOUId + "='" + moId + "' and "+moi.ItemType+"='"+ity+"'";
            sql = "Update " + moi.table + " " +
                "Set " + moi.MOUNumber + "='" + doc + "', " +
                moi.MOUNumberCnt + "=1, " +
                moi.TempSave + "='1' " +
                " Where " + moi.MOUId + "='" + moId + "' and " + moi.ItemType + "='" + ity + "' and "+ moi.DatePlaceRecord+" <> '' and "+moi.PlaceRecord+" <> '' and "+moi.TempSave+"='0'";
            //dt = conn.selectData(sql);
            cnt = conn.ExecuteNonQuery(sql);

            return "";
        }
        private String UpdateMOUNumberNext(String moId, String ity, String doc1, int max, int cnt1)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt = "", doc = "";
            doc = "00000" + max.ToString();
            doc = doc1 + doc.Substring(doc.Length - 5);
            //sql = "Update " + moi.table + " "+
            //    "Set " + moi.MOUNumber + "='" + doc + "', " +
            //    moi.MOUNumberCnt+"=1"+
            //    " Where " + moi.MOUId + "='" + moId + "' and "+moi.ItemType+"='"+ity+"'";
            sql = "Update " + moi.table + " " +
                "Set " + moi.MOUNumber + "='" + doc + "', " +
                moi.MOUNumberCnt + "="+cnt1+", " +
                moi.TempSave + "='1' " +
                " Where " + moi.MOUId + "='" + moId + "' and " + moi.ItemType + "='" + ity + "' and " + moi.DatePlaceRecord + " <> '' and " + moi.PlaceRecord + " <> '' and "+
                moi.MOUNumber+" = '' and "+moi.TempSave+"='0'";
            //dt = conn.selectData(sql);
            cnt = conn.ExecuteNonQuery(sql);

            return "";
        }
        public void UpdateMOUNumber(String MOUNumberMain, ComboBox cboity)
        {
            String ity = "", max="", doc="";
            DataTable dt = selectDistinctByMoId1(MOUNumberMain);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ity = dt.Rows[i][moi.ItemType].ToString();
                    doc = getValueCboItem(cboity, ity);
                    max = selectMaxByMoNumber(ity);
                    if (max.Equals(""))
                    {
                        max = "00";
                    }
                    else if(max.Length>2)
                    {
                        max = max.Substring(2);
                    }
                    
                    if (max.IndexOf("-")>0)
                    {
                        max = max.Substring(0,max.IndexOf("-"));
                    }

                    UpdateMOUNumber1(MOUNumberMain, ity, doc, (int.Parse(NumberNull1(max.Substring(2))) + 1));
                }
            }
        }
        public void UpdateMOUNumberNext(String MOUNumberMain, ComboBox cboity, String dateplace)
        {
            String ity = "", max = "", doc = "", cnt="";
            DataTable dt = selectDistinctByMoId1(MOUNumberMain);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ity = dt.Rows[i][moi.ItemType].ToString();
                    doc = getValueCboItem(cboity, ity);
                    max = selectMaxByMoNumber(ity);
                    cnt = selectMaxCntByMoNumber(MOUNumberMain,ity);
                    if (max.Equals(""))
                    {
                        max = "00";
                    }
                    else if (max.Length > 2)
                    {
                        max = max.Substring(2);
                    }

                    if (max.IndexOf("-") > 0)
                    {
                        max = max.Substring(0, max.IndexOf("-"));
                    }

                    UpdateMOUNumberNext(MOUNumberMain, ity, doc, int.Parse(NumberNull1(max.Substring(2))), (int.Parse(NumberNull1(cnt)) + 1));
                }
            }
        }
        public void UpdateMaxMOUNumber(String moId, String moNumber, String ity)
        {
            String max = "", sql="", mo1="";
            //max = selectMaxByMoNumber1(moId,ity);            
            if (moNumber.IndexOf("-") > 0)
            {
                mo1 = moNumber.Substring(0, moNumber.IndexOf("-"));
                max = moNumber.Substring(moNumber.IndexOf("-"));
                max = max.Replace("-", "");
            }
            else
            {
                mo1 = moNumber;
            }
            if (max.Equals(""))
            {
                max = "00";
            }
            max = String.Concat(int.Parse(max) + 1);
            sql = "Update " + moi.table + " " +
                "Set " + moi.MOUNumberCnt + "='" + max+"' " +
                " Where " + moi.MOUId + "='" + moId + "' and " + moi.ItemType + "='" + ity + "' and " + moi.MOUNumber + "='" + mo1 + "'";
            //dt = conn.selectData(sql);
            sql = conn.ExecuteNonQuery(sql);
            //UpdateMOUNumber1(MOUNumber, ity, doc, (int.Parse(NumberNull1(max.Substring(2))) + 1));

        }
        public String getValueCboItem(ComboBox c, String text)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Text.Equals(text))
                {
                    r = cc;
                }
            }
            return r.Value;
        }
        public String UpdateGroupNameT(String itId, String itgId, String itgNameT, String sort1)
        {
            String sql = "", chk = "";
            sql = "Update " + moi.table + " Set " + moi.ItemGroupNameT + "='" + itgNameT + "', " +
                moi.ItemGroupId + "='" + itgId + "', " +
                moi.ItemGroupSort + "='" + sort1 + "' " +
                "Where " + moi.ItemId + "='" + itId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String UpdateDocType(String itId, String docType)
        {
            String sql = "", chk = "";
            sql = "Update " + moi.table + " Set " + moi.ItemType + "='" + docType + "' " +
                //qui.ItemGroupId + "='" + itgId + "', " +
                //qui.ItemGroupSort + "='" + sort1 + "' " +
                "Where " + moi.ItemId + "='" + itId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        /**
         * 
         * **/
        public String VoidMOUReturn(String moNumber)
        {
            String sql = "", chk = "";
            String[] tmp = moNumber.Split('-');
            if (tmp.Length > 0)
            {
                sql = "Update " + moi.table + " Set " + moi.Active + "='1', " +moi.TempSave+"='0', "+moi.MOUNumber+"='', "+moi.MOUNumberCnt+"=0 " +
                "Where " + moi.MOUNumber + "='" + tmp[0] + "' and " + moi.MOUNumberCnt + " ='" + tmp[1] + "' ";
                chk = conn.ExecuteNonQuery(sql);

            }            
            return chk;
        }
        public String VoidMerge(String mergeNumber)
        {
            String sql = "", chk = "";
            //String[] tmp = moNumber.Split('-');

            sql = "Update " + moi.table + " Set " + moi.StatusMerge + "='0', " + moi.Sample + "=" + moi.SampleOld + ", " + moi.MergeId + "='', "+moi.SampleOld+"='' " +
                "Where " + moi.MergeId + "='" + mergeNumber + "' ";
                chk = conn.ExecuteNonQuery(sql);

            return chk;
        }
        /*
         * 
         **/
        public String UpdateStatusBill(String moNumber)
        {
            String sql = "", chk = "";
            String[] tmp = moNumber.Split('-');
            if (tmp.Length > 0)
            {
                sql = "Update " + moi.table + " Set " + moi.StatusBill + "='1' " +
                "Where " + moi.MOUNumber + "='" + tmp[0] + "' and " + moi.MOUNumberCnt + " ='" + tmp[1] + "' ";
                chk = conn.ExecuteNonQuery(sql);

            }
            return chk;
        }
        /*
         * 
         **/
        public String UpdateStatusResult(String moNumber)
        {
            String sql = "", chk = "";
            String[] tmp = moNumber.Split('-');
            if (tmp.Length > 0)
            {
                sql = "Update " + moi.table + " Set " + moi.StatusResult + "='1' " +
                "Where " + moi.MOUNumber + "='" + tmp[0] + "' and " + moi.MOUNumberCnt + " ='" + tmp[1] + "' ";
                chk = conn.ExecuteNonQuery(sql);

            }
            return chk;
        }
        public ComboBox getCboCustomerMOUnoBill(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectCustomerNoBill();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();

                item.Text = dt.Rows[i]["cust_name"].ToString();

                item.Value = dt.Rows[i]["cust_id"].ToString();
                //item.Text = dt.Rows[i][cu.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        /**
         * ต้องแก้ไข เพราะใช้ getCboCustomerMOUnoBill ทำให้ดึงข้อมูล ได้ไม่เท่ากัน น่าจาก Distinct
         * เลยต้องเปลี่ยน
         * */
        public ComboBox getCboCustomerMOUnoBill1(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectNoBillByCust("");//
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();

                item.Text = dt.Rows[i]["cust_name"].ToString();

                item.Value = dt.Rows[i]["cust_id"].ToString();
                //item.Text = dt.Rows[i][cu.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
        public ComboBox getCboCustomerMOUnoResult(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            DataTable dt = selectCustomerNoResult();
            //String aaa = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ComboBoxItem();

                item.Text = dt.Rows[i]["cust_name"].ToString();

                item.Value = dt.Rows[i]["cust_id"].ToString();
                //item.Text = dt.Rows[i][cu.NameT].ToString();
                c.Items.Add(item);
                //aaa += "new { Text = "+dt.Rows[i][sale.Name].ToString()+", Value = "+dt.Rows[i][sale.Id].ToString()+" },";
                //c.Items.Add(new );
            }
            return c;
        }
    }
}
