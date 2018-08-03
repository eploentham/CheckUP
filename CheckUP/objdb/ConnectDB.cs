﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CheckUP.object1;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace CheckUP.objdb
{
    public class ConnectDB
    {
        public String Unamelogin = "";
        public OleDbConnection cntemp = new OleDbConnection();
        public int portnumber = 0;
        public String UName = "", User1 = "", SS = "";
        //public OleDbConnection _mainConnection = new OleDbConnection();
        public SqlConnection _mainConnection = new SqlConnection();
        //public MySql.Data.MySqlClient.MySqlConnection cMysql;

        public int _rowsAffected = 0;
        public SqlInt32 _errorCode = 0;
        public Boolean _isDisposed = false;
        public SqlConnection connMainHIS;
        private String hostname = "";
        //private IniFile iniFile;
        public String databaseNameMainHIS = "";
        public String hostNameMainHIS = "";
        public String userNameMainHIS = "";
        public String passwordMainHIS = "";
        public String databaseNameBua = "";
        public String hostNameBua = "";
        public String userNameBua = "";
        public String passwordBua = "";
        public String server = "";
        public String isBranch = "";
        private InitConfig initc;
        public DataTable toReturn = new DataTable();
        public DataTable dt = new DataTable();

        public LogWriter lw;

        //OleDbCommand cmdToExecute = new OleDbCommand();
        public ConnectDB(InitConfig i)
        {
            initc = i;
            //if (initc.use32Bit.Equals("yes"))
            //{
            //    if (initc.StatusServer.ToLower().Equals("yes"))
            //    {
            //        _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "\\Database\\cemp.mdb;Persist Security Info=False";
            //    }
            //    else
            //    {
            //        _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\Database\\cemp.mdb;Persist Security Info=False";
            //    }
            //}
            //else
            //{
            //    if (initc.StatusServer.ToLower().Equals("yes"))
            //    {
            //        if (initc.connectDatabaseServer.ToLower().Equals("yes"))
            //        {
            //            cMysql = new MySql.Data.MySqlClient.MySqlConnection();
            //            cMysql.ConnectionString = "server=" + initc.ServerIP + ";uid=" + initc.User + ";pwd=" + initc.Password + ";database=test;";
            //        }
            //        else
            //        {
            //            if (Environment.Is64BitOperatingSystem)
            //            {
            //                _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\source\\lottory\\lottory\\DataBase\\lottory.mdb;Persist Security Info=False";
            //                _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\Database\\CheckUP.mdb;Persist Security Info=False";
            //            }
            //            else
            //            {
            //                _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\lottory\\lottory\\DataBase\\lottory.mdb;Persist Security Info=False";
            //                _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "\\Database\\CheckUP.mdb;Persist Security Info=False";
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (Environment.Is64BitOperatingSystem)
            //        {
            //            //_mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\source\\lottory\\lottory\\DataBase\\lottory.mdb;Persist Security Info=False";
            //            //_mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Environment.CurrentDirectory + "\\Database\\lottory.mdb;Persist Security Info=False";
            //            _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + "\\\\" +initc.IPServer+"\\" + initc.ConnectShareData + "\\Database\\checkup.accdb;Persist Security Info=False";
            //        }
            //        else
            //        {
            //            //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\lottory\\lottory\\DataBase\\lottory.mdb;Persist Security Info=False";
            //            //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Environment.CurrentDirectory + "\\Database\\lottory.mdb;Persist Security Info=False";
            //            _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + "\\\\" + initc.IPServer + "\\" + initc.ConnectShareData + "\\Database\\checkup.mdb;Persist Security Info=False";
            //        }
            //    }
            //}
            //SqlConnection connBIT = new SqlConnection();
            //connMainHIS.ConnectionString = GetConfig(hostName);
            _mainConnection.ConnectionString = "Server=" + initc.Host + ";Database=" + initc.Database + ";Uid=" + initc.User + ";Pwd=" + initc.Password + ";Connection Timeout=300;";

            //_mainConnection = new OleDbConnection();
            //_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");

            //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\lottory\\lottory\\DataBase\\lottory.mdb;Persist Security Info=False";
            _isDisposed = false;
        }
        public ConnectDB(String hostName)
        {
            lw = new LogWriter();
            if (hostName == "mainhis")
            {
                hostname = "mainhis";
                connMainHIS = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS.ConnectionString = "Server=" + hostNameMainHIS + ";Database=" + databaseNameMainHIS.ToString() + ";Uid=" + userNameMainHIS + ";Pwd=" + passwordMainHIS + ";";
            }
            else if (hostName == "bangna")
            {
                hostname = "bangna";
                connMainHIS = new SqlConnection();
                //connMainHIS.ConnectionString = GetConfig(hostName);
                connMainHIS.ConnectionString = "Server=" + hostNameBua + ";Database=" + databaseNameBua + ";Uid=" + userNameBua + ";Pwd=" + passwordBua + ";";
            }
            else
            {
                //_mainConnection = new OleDbConnection();
                ////_mainConnection.ConnectionString = GetConfig("Main.ConnectionString");
                //if (Environment.Is64BitOperatingSystem)
                //{
                //    _mainConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                //}
                //else
                //{
                //    _mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                //}
                //_mainConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\source\reportBangna\\reportBangna\\DataBase\\reportBangna.mdb;Persist Security Info=False";
                _mainConnection.ConnectionString = "Server=" + initc.Host + ";Database=" + initc.Database + ";Uid=" + initc.User + ";Pwd=" + initc.Password + ";Connection Timeout=300;";
                _isDisposed = false;
            }
        }
        public String GetConfig(String key)
        {

            AppSettingsReader _configReader = new AppSettingsReader();
            // Set connection string of the sqlconnection object
            return _configReader.GetValue(key, "".GetType()).ToString();
        }
        public DataTable selectData(String sql)
        {
            DataTable toReturn = new DataTable();
            //toReturn.Clear();
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql, _mainConnection);
            //cmdToExecute.Connection = _mainConnection;
            try
            {
                //MessageBox.Show("333 "+ sql, "333 " );
                //MessageBox.Show("444 " + _mainConnection.ConnectionString, "444 ");
                _mainConnection.Open();
                adapter.Fill(toReturn);
                //return toReturn;
            }
            catch (Exception ex)
            {
                //throw new Exception("", ex);
                //MessageBox.Show("ex "+ ex.InnerException, "error "+ex.Message);
                lw.WriteLog("selectData " + "ex " + ex.InnerException+ " error " + ex.Message);
            }
            finally
            {
                _mainConnection.Close();
                //cmdToExecute.Dispose();
                adapter.Dispose();
            }
            
            return toReturn;
        }
        public void selectDataN(String sql)
        {
            //OleDbDataAdapter adapter = new OleDbDataAdapter(sql, _mainConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, _mainConnection);
            try
            {
                _mainConnection.Open();
                adapter.Fill(dt);
                //return toReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
            finally
            {
                _mainConnection.Close();
                //cmdToExecute.Dispose();
                adapter.Dispose();
            }
            //return toReturn;
        }
        public String ExecuteNonQuery(String sql)
        {
            String toReturn = "";
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = sql;
            cmdToExecute.CommandType = CommandType.Text;
            cmdToExecute.Connection = _mainConnection;
            try
            {
                _mainConnection.Open();
                _rowsAffected = cmdToExecute.ExecuteNonQuery();
                toReturn = _rowsAffected.ToString();
            }
            catch (Exception ex)
            {
                //throw new Exception("ExecuteNonQuery::Error occured.", ex);
                //toReturn = ex.Message;
                //MessageBox.Show("ex " + ex.InnerException, "error " + ex.Message);
                lw.WriteLog("ExecuteNonQuery " + "ex " + ex.InnerException + " error " + ex.Message);
            }
            finally
            {
                _mainConnection.Close();
                cmdToExecute.Dispose();
            }
            
            return toReturn;
        }
        public String ExecuteNonQueryNoClose(String sql)
        {
            String toReturn = "";
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = sql;
            cmdToExecute.CommandType = CommandType.Text;
            cmdToExecute.Connection = _mainConnection;
            try
            {
                //_mainConnection.Open();
                _rowsAffected = cmdToExecute.ExecuteNonQuery();
                toReturn = _rowsAffected.ToString();
            }
            catch (Exception ex)
            {
                //throw new Exception("ExecuteNonQuery::Error occured.", ex);
                //toReturn = ex.Message;
                //MessageBox.Show("ex " + ex.InnerException, "error " + ex.Message);
                lw.WriteLog("ExecuteNonQueryNoClose " + "ex " + ex.InnerException + " error " + ex.Message);
            }
            finally
            {
                //_mainConnection.Close();
                //cmdToExecute.Dispose();
            }
            return toReturn;
        }
        public String OpenConnection()
        {
            String toReturn = "";            
            //cmdToExecute.Connection = _mainConnection;
            try
            {
                _mainConnection.Open();
                //_rowsAffected = cmdToExecute.ExecuteNonQuery();
                //toReturn = _rowsAffected.ToString();
            }
            catch (Exception ex)
            {
                lw.WriteLog("OpenConnection " + "ex " + ex.InnerException + " error " + ex.Message);
                throw new Exception("ExecuteNonQuery::Error occured.", ex);
                toReturn = ex.Message;
            }
            finally
            {
                //_mainConnection.Close();
                //cmdToExecute.Dispose();
            }
            return toReturn;
        }
        public void CloseConnection()
        {
            _mainConnection.Close();            
        }
    }
}
