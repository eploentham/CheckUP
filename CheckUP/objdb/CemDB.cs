using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

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
        public DataTable getDataSample(String dateStart, String dateEnd, String noStart)
        {
            DataTable dt = new DataTable();
            String sql = "";
            sql = "SELECT testtime, itemid, fullname, testresult, printref  " +
                "FROM testdetail " +
                "left join testdefine on testdefine.id = testdetail.itemid " +
                "WHERE  TestTime >= #" + dateStart + " 00:00:00# and testtime <= #" + dateEnd + " 23:59:00# and sampleid ="+ noStart+" " +
                "ORDER BY testdetail.testtime, itemid; ";
            dt = conn.selectDataAccecss(sql);
            return dt;
        }
    }
}
