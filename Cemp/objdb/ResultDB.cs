using Cemp.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.objdb
{
    public class ResultDB
    {
        ConnectDB conn;
        public Result rs;
        public ResultDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            rs = new Result();
            rs.Active = "result_active";
            rs.CustAddressT = "cust_address1";
            rs.CustId = "cust_id";
            rs.CustNameT = "cust_name_t";
            rs.Id = "result_id";
            rs.Machinery = "machinery";
            rs.MeasureDate = "measure_date";
            rs.Measurement = "measurement";
            rs.MethodMeasure = "method_measure";
            rs.Summary = "summary";
            rs.MouNumber = "mou_number";
            rs.MouNumberCnt = "mou_number_cnt";

            rs.YearId = "year_id";            

            rs.pkField = "result_id";
            rs.table = "t_result";
        }
        private Result setData(Result item, DataTable dt)
        {
            item.Active = dt.Rows[0][rs.Active].ToString();
            item.CustAddressT = dt.Rows[0][rs.CustAddressT].ToString();
            item.CustId = dt.Rows[0][rs.CustId].ToString();
            item.CustNameT = dt.Rows[0][rs.CustNameT].ToString();
            item.Id = dt.Rows[0][rs.Id].ToString();
            item.Machinery = dt.Rows[0][rs.Machinery].ToString();
            item.MeasureDate = dt.Rows[0][rs.MeasureDate].ToString();
            item.Measurement = dt.Rows[0][rs.Measurement].ToString();
            item.MethodMeasure = dt.Rows[0][rs.MethodMeasure].ToString();
            item.Summary = dt.Rows[0][rs.Summary].ToString();
            item.MouNumber = dt.Rows[0][rs.MouNumber].ToString();
            item.MouNumberCnt = dt.Rows[0][rs.MouNumberCnt].ToString();
            item.YearId = dt.Rows[0][rs.YearId].ToString();
            
            return item;
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + rs.table + " Where " + rs.Active + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }

        public Result selectByPk(String saleId)
        {
            Result item = new Result();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + rs.table + " Where " + rs.pkField + "='" + saleId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(Result p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "rs" + p.getGenID();
            }
            p.CustAddressT = p.CustAddressT.Replace("'", "''");
            p.CustNameT = p.CustNameT.Replace("'", "''");
            p.Machinery = p.Machinery.Replace("'", "'");
            p.Measurement = p.Measurement.Replace("'", "''");
            p.MethodMeasure = p.MethodMeasure.Replace("'", "''");
            p.Summary = p.Summary.Replace("'", "''");

            sql = "Insert Into " + rs.table + " (" + rs.pkField + "," + rs.Active + "," + rs.CustAddressT + "," +
                rs.CustId + "," + rs.CustNameT + "," + rs.Machinery + "," +
                rs.MeasureDate + "," + rs.Measurement + "," + rs.MethodMeasure + "," +
                rs.Summary + "," + rs.MouNumber + "," + rs.MouNumberCnt + "," + rs.YearId + ") " +
                "Values('" + p.Id + "','" + p.Active + "','" + p.CustAddressT + "','" +
                p.CustId + "','" + p.CustNameT + "','" + p.Machinery + "','" +
                p.MeasureDate + "','" + p.Measurement + "','" + p.MethodMeasure + "','" +
                p.Summary + "','" + p.MouNumber + "'," + NumberNull1(p.MouNumberCnt) + ",'" + p.YearId + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert Result");
            }
            finally
            {
            }
            return chk;
        }
        private String update(Result p)
        {
            String sql = "", chk = "";

            p.CustAddressT = p.CustAddressT.Replace("'", "''");
            p.CustNameT = p.CustNameT.Replace("'", "''");
            p.Machinery = p.Machinery.Replace("'", "'");
            p.Measurement = p.Measurement.Replace("'", "''");
            p.MethodMeasure = p.MethodMeasure.Replace("'", "''");
            p.Summary = p.Summary.Replace("'", "''");

            sql = "Update " + rs.table + " Set " + rs.CustAddressT + "='" + p.CustAddressT + "', " +
                rs.CustId + "='" + p.CustId + "', " +
                rs.CustNameT + "='" + p.CustNameT + "', " +
                rs.Machinery + "='" + p.Machinery + "', " +
                rs.MeasureDate + "='" + p.MeasureDate + "', " +
                rs.Measurement + "='" + p.Measurement + "', " +
                rs.MethodMeasure + "='" + p.MethodMeasure + "', " +
                rs.Summary + "='" + p.Summary + "', " +
                rs.MouNumber + "='" + p.MouNumber + "', " +
                rs.MouNumberCnt + "=" + NumberNull1(p.MouNumberCnt) + " " +

                "Where " + rs.pkField + "='" + p.Id + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update Result");
            }
            finally
            {
            }
            return chk;
        }
        public String insertResult(Result p)
        {
            Result item = new Result();
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
            sql = "Delete From " + rs.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
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
        public String VoidResult(String rsId)
        {
            String sql = "", chk = "";
            sql = "Update " + rs.table + " Set " + rs.Active + "='3' " +
                "Where " + rs.pkField + "='" + rsId + "'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
