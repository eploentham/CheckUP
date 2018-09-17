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
        public enum flagTestType { retriveNo, retriveYes };
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
        public DataTable getDataSample(String dateStart, String dateEnd, String noStart, String noEnd, flagTestType flagtesttype)
        {
            DataTable dt = new DataTable();
            String sql = "";
            //sql = "SELECT testtime,sampleid, itemid, fullname, testresult, printref  " +
            //    "FROM testdetail " +
            //    "left join testdefine on testdefine.id = testdetail.itemid " +
            //    "WHERE  TestTime >= #" + dateStart + " 00:00:00# and testtime <= #" + dateEnd + " 23:59:00# " +
            //    "and sampleid >="+ noStart+ " and  sampleid <=" + noEnd + " " +
            //    "ORDER BY sampleid, itemid,testdetail.testtime; ";
            if(flagtesttype == flagTestType.retriveNo)
            {
                sql = "SELECT testtime,sampleid, itemid, fullname, testresult, printref  " +
                "FROM testdetail " +
                "left join testdefine on testdefine.id = testdetail.itemid " +
                "WHERE  TestTime >= #" + dateStart + " 00:00:00# and testtime <= #" + dateEnd + " 23:59:00# " +
                "and testdetail.sampleid >=" + noStart + " and  testdetail.sampleid <=" + noEnd + " " +
                " and testdetail.testtype = 0 " +
                "ORDER BY sampleid, itemid,testdetail.testtime; ";
            }
            else
            {
                sql = "SELECT testtime,sampleid, itemid, fullname, testresult, printref  " +
                "FROM testdetail " +
                "left join testdefine on testdefine.id = testdetail.itemid " +
                "WHERE  TestTime >= #" + dateStart + " 00:00:00# and testtime <= #" + dateEnd + " 23:59:00# " +
                "and testdetail.sampleid >=" + noStart + " and  testdetail.sampleid <=" + noEnd + " " +
                "ORDER BY sampleid, itemid,testdetail.testtime; ";
            }
            
            dt = conn.selectDataAccecss(sql);
            return dt;
        }
        public void getTextCEM(String dateStart, String dateEnd, String noStart, String noEnd, flagTestType flagtesttype)
        {
            DataTable dt = new DataTable();
            String sql = "";

            //dt = getDataSample(dateStart, dateEnd, noStart, noEnd, flagtesttype);
            dt = getDataHeader(dateStart, dateEnd, noStart, noEnd);
            if (dt.Rows.Count > 0)
            {
                String col01 = "", col02 = "", col03 = "", col04 = "", col05 = "", col06 = "", colpatid="";
                String filename = "";
                try
                {
                    filename = Path.Combine(Environment.CurrentDirectory, "TextCEM.txt");
                    using (var tw = new StreamWriter(filename, false, Encoding.UTF8))
                    {
                        for (int row = 0; row < dt.Rows.Count; row++)
                        {
                            colpatid = dt.Rows[row][0] != null ? dt.Rows[row][0].ToString() : "";
                            DataTable dtS = new DataTable();
                            String start = "", end = "";
                            start = dt.Rows[row][1] != null ? dt.Rows[row][1].ToString() : "";
                            dtS = getDataSample(dateStart, dateEnd, start, start, flagtesttype);
                            for (int i = 0; i < dtS.Rows.Count; i++)
                            {
                                col01 = dtS.Rows[i][0] != null ? dtS.Rows[i][0].ToString() : "";      //date
                                col02 = dtS.Rows[i][1] != null ? dtS.Rows[i][1].ToString() : "";      //sample id
                                col03 = dtS.Rows[i][2] != null ? dtS.Rows[i][2].ToString() : "";      // item id
                                col04 = dtS.Rows[i][3] != null ? dtS.Rows[i][3].ToString() : "";      //fullname
                                col05 = dtS.Rows[i][4] != null ? formatTextCEM(dtS.Rows[i][4].ToString(), dtS.Rows[i][2].ToString()) : "";      //test
                                col06 = dtS.Rows[i][5] != null ? dtS.Rows[i][5].ToString() : "";      // ref
                                tw.WriteLine(col01 + "|" + colpatid+ "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                            }
                        }
                    }
                    MessageBox.Show("gen Text เรียบร้อย", "");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error "+ex.Message, "");
                }
                finally
                {

                }
                
            }
            else
            {
                MessageBox.Show("ไม่พบข้อมูล", "");
            }

        }
        public String formatTextCEM(String value, String labid)
        {
            String re = "";
            //1=FBS     Glucose                                     integer
            //2=BUN     Blood urea nitrogen                         integer
            //3=Creatinine     Creatinine                           round 2
            //4=Chol     Cholesterol                                integer
            //5=Trig     Triglyceride                               integer
            //6=Total Protein     Total Protein                     round 1
            //7=Albumin     Albumin                                 round 1
            //8=Alkalinephosphatase     Alkalinephosphatase         integer
            //9=HDL     HDL Cholesterol                             integer
            //10=SGOT        SGOT(AST)                              integer
            //11=SGPT        SGPT(ALT)                              integer
            //12=Uric Acid        Uric Acid                         round 1
            //13=Bilirubin        Total Bilirubin                   round 1
            //14=Direct Bilirubin        Direct Bilirubin           round 1
            //15=LDL        LDL Cholesterol                         integer
            if (labid.Equals("1"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("2"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("3"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 2);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("4"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("5"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("6"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("7"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("8"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("9"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("10"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("11"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("12"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("13"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("14"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("15"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            return re;
        }
    }
}
