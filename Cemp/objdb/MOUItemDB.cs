using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public DataTable selectByMoNumber(String moNumber)
        {
            //MOUItem item = new MOUItem();
            String sql = "", cnt="", number="";
            if (moNumber.IndexOf("-") <= 0)
            {
                cnt = "";
            }
            else
            {
                number = moNumber.Substring(0, moNumber.IndexOf("-"));
                cnt = moNumber.Substring(moNumber.IndexOf("-"));
                cnt = cnt.Replace("-","");
            }
            sql = "Select * From " + moi.table + " Where " + moi.MOUNumber + "='" + number +"' and "+ moi.MOUNumberCnt + "=" + cnt + " Order By " + moi.RowNumber;
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

            sql = "Insert Into " + moi.table + " (" + moi.pkField + "," + moi.Active + "," + moi.ItemDescription + "," +
                moi.ItemId + "," + moi.MethodDescription + "," + moi.MethodId + "," +
                moi.MOUId + "," + moi.PlaceRecord + "," + moi.RowNumber + "," +
                moi.Sample + "," + moi.ItemGroupNameE + "," + moi.ItemGroupNameT + "," +
                moi.ItemGroupSort + "," + moi.ItemGroupId + "," + moi.DatePlaceRecord + "," +
                moi.MOUNumber + "," + moi.MOUNumberCnt + "," + moi.PriceCost + "," + 
                moi.PriceSale + "," + moi.Amount + "," + moi.Discount + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.ItemDescription + "','" +
                p.ItemId + "','" + p.MethodDescription + "','" + p.MethodId + "','" +
                p.MOUId + "','" + p.PlaceRecord + "','" + p.RowNumber + "','" +
                p.Sample + "','" + p.ItemGroupNameE + "','" + p.ItemGroupNameT + "','" +
                p.ItemGroupSort + "','" + p.ItemGroupId + "','" + p.DatePlaceRecord + "','" +
                p.MOUNumber + "'," + p.MOUNumberCnt + "," + NumberNull1(p.PriceCost) + "," + 
                NumberNull1(p.PriceSale) + "," + NumberNull1(p.Amount) + "," + NumberNull1(p.Discount) + ")";
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
                moi.MOUNumber + "='" + p.MOUNumber + "', " +
                moi.MOUNumberCnt + "=" + p.MOUNumberCnt + " " +
                //moi.PriceCost + "=" + p.PriceCost + ", " +
                //moi.PriceSale + "=" + p.PriceSale + ", " +
                //moi.Amount + "=" + p.Amount + ", " +
                //moi.Discount + "=" + p.Discount + " " +
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
