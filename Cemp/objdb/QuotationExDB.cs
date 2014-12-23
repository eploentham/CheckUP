using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class QuotationExDB
    {
        ConnectDB conn;
        public QuotationEx quex;
        public QuotationExDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            quex = new QuotationEx();
            quex.Amount = "amount";
            quex.StatusDistanceDaily = "status_distance_daily";
            quex.DistanceDailyA = "distance_daily_a";
            quex.DistanceDailyD = "distance_daily_d";
            quex.DistanceDailyN = "distance_daily_n";
            quex.DistanceDailyP = "distance_daily_p";
            quex.Ex1A = "ex1_a";
            quex.Ex2A = "ex2_a";
            quex.StatusGoSite = "status_go_site";
            quex.GoSiteA = "go_site_a";
            quex.GositeD = "go_site_d";
            quex.GoSiteN = "go_site_n";
            quex.GoSiteP = "go_site_p";
            quex.Id = "quo_ex_id";
            quex.RentCarA = "rent_car_a";
            quex.RentCarD = "rent_car_d";
            quex.RentCarN = "rent_car_n";
            quex.RentCarP = "rent_car_p";
            quex.RentRoomA = "rent_room_a";
            quex.RentRoomD = "rent_room_d";
            quex.RentRoomN = "rent_room_n";
            quex.RentRoomP = "rent_room_p";
            //quex.StatusDistanceDaily = "";
            quex.StatusEx1 = "status_ex1";
            quex.StatusEx2 = "status_ex2";
            //quex.StatusGoSite = "";
            quex.StatusRentCar = "status_rent_car";
            quex.StatusRentRoom = "status_rent_room";
            quex.Active = "quo_ex_active";
            quex.Remark = "remark";

            quex.table = "t_quotation_ex";
            quex.pkField = "quo_ex_id";
        }
        private QuotationEx setData(QuotationEx item, DataTable dt)
        {
            item.Amount = dt.Rows[0][quex.Amount].ToString();
            item.StatusDistanceDaily = dt.Rows[0][quex.StatusDistanceDaily].ToString();
            item.DistanceDailyA = dt.Rows[0][quex.DistanceDailyA].ToString();
            item.DistanceDailyD = dt.Rows[0][quex.DistanceDailyD].ToString();
            item.DistanceDailyN = dt.Rows[0][quex.DistanceDailyN].ToString();
            item.DistanceDailyP = dt.Rows[0][quex.DistanceDailyP].ToString();
            item.Ex1A = dt.Rows[0][quex.Ex1A].ToString();
            item.Ex2A = dt.Rows[0][quex.Ex2A].ToString();
            item.StatusGoSite = dt.Rows[0][quex.StatusGoSite].ToString();
            item.GoSiteA = dt.Rows[0][quex.GoSiteA].ToString();
            item.GositeD = dt.Rows[0][quex.GositeD].ToString();
            item.GoSiteN = dt.Rows[0][quex.GoSiteN].ToString();
            item.GoSiteP = dt.Rows[0][quex.GoSiteP].ToString();
            item.Id = dt.Rows[0][quex.Id].ToString();
            item.RentCarA = dt.Rows[0][quex.RentCarA].ToString();
            item.RentCarD = dt.Rows[0][quex.RentCarD].ToString();
            item.RentCarN = dt.Rows[0][quex.RentCarN].ToString();
            item.RentCarP = dt.Rows[0][quex.RentCarP].ToString();
            item.RentRoomA = dt.Rows[0][quex.RentRoomA].ToString();
            item.RentRoomD = dt.Rows[0][quex.RentRoomD].ToString();
            item.RentRoomN = dt.Rows[0][quex.RentRoomN].ToString();
            item.RentRoomP = dt.Rows[0][quex.RentRoomP].ToString();
            item.StatusEx1 = dt.Rows[0][quex.StatusEx1].ToString();
            item.StatusEx2 = dt.Rows[0][quex.StatusEx2].ToString();
            item.StatusRentCar = dt.Rows[0][quex.StatusRentCar].ToString();
            item.StatusRentRoom = dt.Rows[0][quex.StatusRentRoom].ToString();
            item.Active = dt.Rows[0][quex.Active].ToString();
            item.Remark = dt.Rows[0][quex.Remark].ToString();
            //item.YearId = dt.Rows[0][quex.YearId].ToString();

            return item;
        }
        public QuotationEx selectByPk(String saleId)
        {
            QuotationEx item = new QuotationEx();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + quex.table + " Where " + quex.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(QuotationEx p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "quex" + p.getGenID();
            }
            p.Remark = p.Remark.Replace("'", "''");
            //p.CustNameT = p.CustNameT.Replace("'", "''");
            //p.Machinery = p.Machinery.Replace("'", "'");
            //p.Measurement = p.Measurement.Replace("'", "''");
            //p.MethodMeasure = p.MethodMeasure.Replace("'", "''");
            //p.Summary = p.Summary.Replace("'", "''");

            sql = "Insert Into " + quex.table + " (" + quex.pkField + "," + quex.Amount + "," + quex.StatusDistanceDaily + "," +
                quex.DistanceDailyA + "," + quex.DistanceDailyD + "," + quex.DistanceDailyN + "," +
                quex.DistanceDailyP + "," + quex.Ex1A + "," + quex.Ex2A + "," +
                quex.StatusGoSite + "," + quex.GoSiteA + "," + quex.GositeD + "," +
                quex.GoSiteN + "," + quex.GoSiteP + "," +//+ quex.Id + "," +
                quex.RentCarA + "," + quex.RentCarD + "," + quex.RentCarN + "," +
                quex.RentCarP + "," + quex.RentRoomA + "," + quex.RentRoomD + "," +
                quex.RentRoomN + "," + quex.RentRoomP + "," + quex.StatusEx1 + "," +
                quex.StatusEx2 + "," + quex.StatusRentCar + "," + quex.StatusRentRoom + "," +
                quex.Active + "," + quex.Remark  + ") " +
                "Values('" + p.Id + "','" + p.Amount + "','" + p.StatusDistanceDaily + "','" +
                p.DistanceDailyA + "','" + p.DistanceDailyD + "','" + p.DistanceDailyN + "','" +
                p.DistanceDailyP + "','" + p.Ex1A + "','" + p.Ex2A + "','" +
                p.StatusGoSite + "','" + p.GoSiteA + "','" + p.GositeD + "','" +
                p.GoSiteN + "','" + p.GoSiteP + "','" +//+ p.Id + "','" +
                p.RentCarA + "','" + p.RentCarD + "','" + p.RentCarN + "','" +
                p.RentCarP + "','" + p.RentRoomA + "','" + p.RentRoomD + "','" +
                p.RentRoomN + "','" + p.RentRoomP + "','" + p.StatusEx1 + "','" +
                p.StatusEx2 + "','" + p.StatusRentCar + "','" + p.StatusRentRoom + "','" +
                p.Active + "','" + p.Remark + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert QuotationEx");
            }
            finally
            {
            }
            return chk;
        }
        private String update(QuotationEx p)
        {
            String sql = "", chk = "";

            p.Remark = p.Remark.Replace("'", "''");
            //p.CustNameT = p.CustNameT.Replace("'", "''");
            //p.Machinery = p.Machinery.Replace("'", "'");
            //p.Measurement = p.Measurement.Replace("'", "''");
            //p.MethodMeasure = p.MethodMeasure.Replace("'", "''");
            //p.Summary = p.Summary.Replace("'", "''");

            sql = "Update " + quex.table + " Set " + quex.Amount + "='" + p.Amount + "', " +
                quex.StatusDistanceDaily + "='" + p.StatusDistanceDaily + "', " +
                quex.DistanceDailyA + "='" + p.DistanceDailyA + "', " +
                quex.DistanceDailyD + "='" + p.DistanceDailyD + "', " +
                quex.DistanceDailyN + "='" + p.DistanceDailyN + "', " +
                quex.DistanceDailyP + "='" + p.DistanceDailyP + "', " +
                quex.Ex1A + "='" + p.Ex1A + "', " +
                quex.Ex2A + "='" + p.Ex2A + "', " +
                quex.StatusGoSite + "='" + p.StatusGoSite + "', " +
                quex.GoSiteA + "='" + p.GoSiteA + "', " +
                quex.GositeD + "='" + p.GositeD + "', " +
                quex.GoSiteN + "='" + p.GoSiteN + "', " +
                quex.GoSiteP + "='" + p.GoSiteP + "', " +
                quex.RentCarA + "='" + p.RentCarA + "', " +
                quex.RentCarD + "='" + p.RentCarD + "', " +
                quex.RentCarN + "='" + p.RentCarN + "', " +
                quex.RentCarP + "='" + p.RentCarP + "', " +
                quex.RentRoomA + "='" + p.RentRoomA + "', " +
                quex.RentRoomD + "='" + p.RentRoomD + "', " +
                quex.RentRoomN + "='" + p.RentRoomN + "', " +
                quex.RentRoomP + "='" + p.RentRoomP + "', " +
                quex.StatusEx1 + "='" + p.StatusEx1 + "', " +
                quex.StatusEx2 + "='" + p.StatusEx2 + "', " +
                quex.StatusRentCar + "='" + p.StatusRentCar + "', " +
                quex.StatusRentRoom + "='" + p.StatusRentRoom + "', " +
                quex.Remark + "='" + p.Remark + "' " +
                //quex.StatusEx1 + "='" + p.StatusEx1 + "', " +

                "Where " + quex.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update QuotationEx");
            }
            finally
            {
            }
            return chk;
        }
        public String insertQuotationEx(QuotationEx p)
        {
            QuotationEx item = new QuotationEx();
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
    }
}
