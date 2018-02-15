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
        public ConnectDB conn;
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
            rcu.Sort1 = "sort1";
            rcu.Age = "age";
            rcu.BMI = "bmi";
            rcu.CheckUpDate = "checkup_date";
            rcu.FullName = "full_name";
            rcu.Height = "height";
            rcu.PESummary = "pe_summary";
            rcu.Pulse = "pulse";
            rcu.RowNumber = "row_number";
            rcu.VitalSign = "vitalsign";
            rcu.Weight = "weight";
            rcu.Sort2 = "sort2";
            rcu.BMISummary = "bmi_summary";
            rcu.PulseSummary = "pulse_summary";
            rcu.BloodName = "bloodname";

            rcu.pkField = "id";
            rcu.table = "r_checkup";
        }
        public DataTable selectAll()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + rcu.table + " Order By "+rcu.RowNumber+","+rcu.Sort1+","+rcu.Sort2;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectMini1()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + rcu.table + " Where sort1='1009' and sort2= '10' Order By " + rcu.RowNumber + "," + rcu.Sort1 + "," + rcu.Sort2;
            dt = conn.selectData(sql);

            return dt;
        }
        public DataTable selectMini2()
        {
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + rcu.table + " Where sort1='1010'  Order By " + rcu.RowNumber + "," + rcu.Sort1 + "," + rcu.Sort2;
            dt = conn.selectData(sql);

            return dt;
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
            StringBuilder sql1 = new StringBuilder();
            String sql = "", chk = "";
            if (p.Id.Equals(""))
            {
                p.Id = "rcu" + p.getGenID();
            }
            //p.LabGroup = p.LabGroup.Replace("'", "''");
            //p.LabName = p.LabName.Replace("'", "''");
            //p.LabNormal = p.LabNormal.Replace("'", "''");
            //p.LabResult = p.LabResult.Replace("'", "''");
            //p.LInter = p.LInter.Replace("'", "''");
            //p.LInterAbnormal = p.LInterAbnormal.Replace("'", "''");
            //p.LInterNormal = p.LInterNormal.Replace("'", "''");
            //p.LNormal = p.LNormal.Replace("'", "''");
            //p.lResult = p.lResult.Replace("'", "''");
            //p.LTypeLab = p.LTypeLab.Replace("'", "''");
            //p.Remark = p.Remark.Replace("'", "''");

            //sql = "Insert Into " + rcu.table + " (" + rcu.pkField + "," + rcu.LabGroup + "," + rcu.LabName + "," +
            //    rcu.LabNormal + "," + rcu.LabResult + "," + rcu.LInter + "," +
            //    rcu.LInterAbnormal + "," + rcu.LInterNormal + "," + rcu.LNormal + "," +
            //    rcu.lResult + "," + rcu.LTypeLab + "," + rcu.Remark + "," + rcu.StatusLab + "," + rcu.Sort1 + ") " +
            //    "Values('" + p.Id + "','" + p.LabGroup + "','" + p.LabName + "','" +
            //    p.LabNormal + "','" + p.LabResult + "','" + p.LInter + "','" +
            //    p.LInterAbnormal + "','" + p.LInterNormal + "','" + p.LNormal + "','" +
            //    p.lResult + "','" + p.LTypeLab + "','" + p.Remark + "','" + p.StatusLab + "','" + p.Sort1 + "')";
            sql1.Append("Insert Into ").Append(rcu.table).Append(" (").Append(rcu.pkField).Append(",").Append(rcu.LabGroup).Append(",").Append(rcu.LabName).Append(",").Append(
                rcu.LabNormal).Append("," ).Append(rcu.LabResult).Append(",").Append(rcu.LInter).Append(",").Append(
                rcu.LInterAbnormal).Append(",").Append(rcu.LInterNormal).Append("," ).Append(rcu.LNormal).Append(",").Append(
                rcu.lResult).Append(",").Append(rcu.LTypeLab).Append(",").Append(rcu.Remark).Append(",").Append(rcu.StatusLab).Append(",").Append(rcu.Sort1).Append(",").Append(
                rcu.FullName).Append(",").Append(rcu.RowNumber).Append(",").Append(rcu.Age).Append(",").Append(rcu.Height).Append(",").Append(
                rcu.Weight).Append(",").Append(rcu.BMI).Append(",").Append(rcu.Pulse).Append(",").Append(
                rcu.VitalSign).Append(",").Append(rcu.Sort2).Append(",").Append(rcu.CheckUpDate).Append(",").Append(rcu.BMISummary).Append(",").Append(rcu.PulseSummary).Append(",").Append(rcu.BloodName).Append(") ").Append(
                "Values('").Append(p.Id).Append("','" ).Append(p.LabGroup).Append("','").Append(p.LabName).Append("','").Append(
                p.LabNormal).Append("','").Append(p.LabResult).Append("','").Append(p.LInter).Append("','").Append(
                p.LInterAbnormal).Append("','").Append(p.LInterNormal).Append( "','").Append(p.LNormal).Append("','").Append(
                p.lResult).Append("','").Append(p.LTypeLab).Append("','").Append(p.Remark).Append("','").Append(p.StatusLab).Append("','").Append(p.Sort1).Append("','").Append(
                p.FullName).Append("',").Append(NumberNull1(p.RowNumber)).Append(",'").Append(p.Age).Append("','").Append(p.Height).Append("','").Append(
                p.Weight).Append("','").Append(p.BMI).Append("','").Append(p.Pulse).Append("','").Append(
                p.VitalSign).Append("','").Append(p.Sort2).Append("','").Append(p.CheckUpDate).Append("','").Append(p.BMISummary).Append("','").Append(p.PulseSummary).Append("','").Append(p.BloodName).Append("')");
            try
            {
                chk = conn.ExecuteNonQueryNoClose(sql1.ToString());
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
