using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.objdb
{
    public class RCheckUpDB
    {
        ConnectDB conn;
        public RCheckUp rcu;
        public RCheckUpDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            rcu = new RCheckUp();
            rcu.Id = "id";
            rcu.LabGroup = "lab_group";
            rcu.LabName = "lab_name";
            rcu.LabNormal = "lab_normal";
            rcu.LabResult = "lab_result";
            rcu.LInter = "l_inter";
            rcu.LInterAbnormal = "l_inter_abnormal";
            rcu.LInterNormal = "l_inter_normal";
            rcu.LNormal = "l_normal";
            rcu.lResult = "l_result";
            rcu.LTypeLab = "l_type_lab";
            rcu.Remark = "remark";
            rcu.StatusLab = "status_lab";

            rcu.pkField = "id";
            rcu.table = "r_checkup";
        }
        //private RCheckUp setData(RCheckUp item, DataTable dt)
        //{
        //    item.Id = dt.Rows[0][rcu.Id].ToString();
        //    item.Code = dt.Rows[0][rcu.Code].ToString();
        //    item.NameT = dt.Rows[0][rcu.NameT].ToString();
        //    item.Remark = dt.Rows[0][rcu.Remark].ToString();
        //    item.Password = dt.Rows[0][rcu.Password].ToString();
        //    item.Active = dt.Rows[0][rcu.Active].ToString();
        //    item.Priority = dt.Rows[0][rcu.Priority].ToString();
        //    item.PositionName = dt.Rows[0][rcu.PositionName].ToString();
        //    item.dateCancel = dt.Rows[0][rcu.dateCancel].ToString();
        //    item.dateCreate = dt.Rows[0][rcu.dateCreate].ToString();
        //    item.dateModi = dt.Rows[0][rcu.dateModi].ToString();
        //    item.userCancel = dt.Rows[0][rcu.userCancel].ToString();
        //    item.userCreate = dt.Rows[0][rcu.userCreate].ToString();
            
        //    return item;
        //}
        //public DataTable selectAll()
        //{
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select * From " + rcu.table + " Where " + rcu.Active + "='1'";
        //    dt = conn.selectData(sql);

        //    return dt;
        //}
        //public RCheckUp selectByPk(String saleId)
        //{
        //    RCheckUp item = new RCheckUp();
        //    String sql = "";
        //    DataTable dt = new DataTable();
        //    sql = "Select * From " + rcu.table + " Where " + rcu.pkField + "='" + saleId + "'";
        //    dt = conn.selectData(sql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        item = setData(item, dt);
        //    }
        //    return item;
        //}
        private String insert(RCheckUp p)
        {
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "rcu" + p.getGenID();
            }
            p.LabGroup = p.LabGroup.Replace("'", "''");
            p.LabName = p.LabName.Replace("'", "''");
            p.LabNormal = p.LabNormal.Replace("'", "''");
            p.LabResult = p.LabResult.Replace("'", "''");
            p.LInter = p.LInter.Replace("'", "''");
            p.LInterAbnormal = p.LInterAbnormal.Replace("'", "''");
            p.LInterNormal = p.LInterNormal.Replace("'", "''");
            p.LNormal = p.LNormal.Replace("'", "''");
            p.lResult = p.lResult.Replace("'", "''");
            p.LTypeLab = p.LTypeLab.Replace("'", "''");
            p.Remark = p.Remark.Replace("'", "''");

            sql = "Insert Into " + rcu.table + " (" + rcu.pkField + "," + rcu.LabGroup + "," + rcu.LabName + "," +
                rcu.LabNormal + "," + rcu.LabResult + "," + rcu.LInter + "," +
                rcu.LInterAbnormal + "," + rcu.LInterNormal + "," + rcu.LNormal + "," +
                rcu.lResult + "," + rcu.LTypeLab + "," + rcu.Remark + "," + rcu.StatusLab + ") " +
                "Values('" + p.Id + "','" + p.LabGroup + "','" + p.LabName + "','" +
                p.LabNormal + "','" + p.LabResult + "','" + p.LInter + "','" +
                p.LInterAbnormal + "','" + p.LInterNormal + "','" + p.LNormal + "','" +
                p.lResult + "','" + p.LTypeLab + "','" + p.Remark + "','" + p.StatusLab + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert RCheckUp");
            }
            finally
            {
            }
            return chk;
        }
        public String insertRCheckUp(RCheckUp p)
        {
            //RCheckUp item = new RCheckUp();
            String chk = "";
            //item = selectByPk(p.Id);
            //if (item.Id == "")
            //{
                chk = insert(p);
            //}
            //else
            //{
            //    //chk = update(p);
            //}
            return chk;
        }
        public String deleteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + rcu.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
