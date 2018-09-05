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
            //sql = "SELECT distinct sampleid " +
            //    "FROM testdetail " +
            //    "WHERE  TestTime >= #"+ dateStart + " 00:00:00# and testtime <= #"+ dateEnd + " 23:59:00# " +
            //    "ORDER BY sampleid; ";
            sql = "SELECT  patientinfo.name, testdetail.sampleid, patientinfo.id " +
                "FROM testdetail " +
                "Left join patientinfo on testdetail.id = patientinfo.id " +
                "WHERE  TestTime >= #" + dateStart + " 00:00:00# and testtime <= #" + dateEnd + " 23:59:00# " +
                "and patientinfo.questdate >= #" + dateStart + " 00:00:00# and patientinfo.questdate <= #" + dateEnd + " 23:59:00# " +
                "ORDER BY patientinfo.name,sampleid; ";
            //MessageBox.Show("1111111", "getDataHeader");
            if (conn== null)
            {
                MessageBox.Show("2222222", "getDataHeader");
            }
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
                "ORDER BY sampleid, itemid,testdetail.testtime; ";
            dt = conn.selectDataAccecss(sql);
            return dt;
        }
        public void getTextCEM(String dateStart, String dateEnd, String noStart, String noEnd)
        {
            DataTable dt = new DataTable();
            String sql = "";

            dt = getDataSample(dateStart, dateEnd, noStart, noEnd);
            if (dt.Rows.Count > 0)
            {
                String col01 = "", col02 = "", col03 = "", col04 = "", col05 = "", col06 = "";
                String filename = "";
                filename = Path.Combine(Environment.CurrentDirectory, "TextCEM.txt");
                using (var tw = new StreamWriter(filename, false, Encoding.UTF8))
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        col01 = dt.Rows[i][0] != null ? dt.Rows[i][0].ToString() : "";      //date
                        col02 = dt.Rows[i][1] != null ? dt.Rows[i][1].ToString() : "";      //sample id
                        col03 = dt.Rows[i][2] != null ? dt.Rows[i][2].ToString() : "";      // item id
                        col04 = dt.Rows[i][3] != null ? dt.Rows[i][3].ToString() : "";      //fullname 
                        col05 = dt.Rows[i][4] != null ? dt.Rows[i][4].ToString() : "";      //test
                        col06 = dt.Rows[i][5] != null ? dt.Rows[i][5].ToString() : "";      // ref
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
