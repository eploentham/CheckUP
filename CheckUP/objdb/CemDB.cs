using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class CemDB
    {
        ConnectDB conn;
        public enum flagAccess { bit32, bit64 };
        flagAccess flagaccess;
        public CemDB(String path, flagAccess flag)
        {
            if(flag == flagAccess.bit32)
            {
                conn = new ConnectDB(path,"", ConnectDB.flagAccess.bit32);
            }
            else
            {
                conn = new ConnectDB(path, "", ConnectDB.flagAccess.bit64);
            }
            initConfig();
        }
        private void initConfig()
        {

        }
        public DataTable getDataHeader(String dateStart, String dateEnd, String noStart, String noEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "SELECT distinct sampleid " +
                "FROM testdetail " +
                "WHERE  TestTime >= #"+ dateStart + " 00:00:00# and testtime <= #"+ dateEnd + " 23:59:00# " +
                "ORDER BY sampleid; ";
            dt = conn.selectDataAccecss(sql);
            return dt;
        }
        public DataTable getDataSample(String dateStart, String dateEnd, String noStart, String noEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "SELECT testtime,sampleid, itemid, fullname, testresult, printref  " +
                "FROM testdetail " +
                "left join testdefine on testdefine.id = testdetail.itemid " +
                "WHERE  TestTime >= #" + dateStart + " 00:00:00# and testtime <= #" + dateEnd + " 23:59:00# and sampleid >="+ noStart+ " and  sampleid <=" + noEnd + " " +
                "ORDER BY testdetail.testtime, itemid; ";
            dt = conn.selectDataAccecss(sql);
            return dt;
        }
        public void getTextCEM(String dateStart, String dateEnd, String noStart, String noEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";

            dt = getDataSample(dateStart, dateEnd, noStart, noStart);
            if (dt.Rows.Count > 0)
            {
                String col01 = "", col02 = "", col03 = "", col04 = "", col05 = "", col06 = "";

                using (var tw = new StreamWriter("TextCEM.txt", false))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        col01 = dt.Rows[i][0] != null ? dt.Rows[i][0].ToString() : "";
                        col02 = dt.Rows[i][1] != null ? dt.Rows[i][1].ToString() : "";
                        col03 = dt.Rows[i][2] != null ? dt.Rows[i][2].ToString() : "";
                        col04 = dt.Rows[i][3] != null ? dt.Rows[i][3].ToString() : "";
                        col05 = dt.Rows[i][4] != null ? dt.Rows[i][4].ToString() : "";
                        col06 = dt.Rows[i][5] != null ? dt.Rows[i][5].ToString() : "";
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                }
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล", "");
            }

        }
    }
}
