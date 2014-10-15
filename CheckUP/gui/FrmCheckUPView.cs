using CheckUP.Control;
using CheckUP.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUP
{
    public partial class FrmCheckUPView : Form
    {
        CheckControl cc;
        int colCnt = 7;
        int colRow = 0, colName = 2, colRemark = 3, colId = 4, colCode = 1, colPassword = 6, colPriority = 5;
        public FrmCheckUPView(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            //dt = lc.selectStaffAll();
            setGrd();
            dgvView.ReadOnly = true;
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 150;

            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        public void setGrd()
        {
            DataTable dt = new DataTable();
            dt = cc.sfdb.selectAll();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colName].Width = 150;
            dgvView.Columns[colRemark].Width = 120;
            dgvView.Columns[colId].Width = 80;
            dgvView.Columns[colPassword].Width = 80;
            dgvView.Columns[colPriority].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colCode].HeaderText = "code";
            dgvView.Columns[colName].HeaderText = "ชื่อ";
            dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";
            dgvView.Columns[colId].HeaderText = "id";
            dgvView.Columns[colPriority].HeaderText = "สิทธิใช้งาน";
            dgvView.Columns[colPassword].HeaderText = "  ";

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colCode, i].Value = dt.Rows[i][cc.sfdb.sf.Code].ToString();
                    dgvView[colName, i].Value = dt.Rows[i][cc.sfdb.sf.NameT].ToString();
                    dgvView[colRemark, i].Value = dt.Rows[i][cc.sfdb.sf.Remark].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][cc.sfdb.sf.Id].ToString();
                    if (dt.Rows[i][cc.sfdb.sf.Priority].ToString().Equals("1"))
                    {
                        dgvView[colPriority, i].Value = "ป้อนข้อมูลอย่างเดียว";
                    }
                    else if (dt.Rows[i][cc.sfdb.sf.Priority].ToString().Equals("2"))
                    {
                        dgvView[colPriority, i].Value = "ตรวจสอบข้อมูลอย่างเดียว";
                    }
                    else if (dt.Rows[i][cc.sfdb.sf.Priority].ToString().Equals("3"))
                    {
                        dgvView[colPriority, i].Value = "ทุกหน้าจอ";
                    }
                    dgvView[colPassword, i].Value = "รหัสผ่าน";
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void FrmCheckUPView_Load(object sender, EventArgs e)
        {

        }

        private void btnSfAdd_Click(object sender, EventArgs e)
        {
            FrmCheckUPAdd frm = new FrmCheckUPAdd(true,cc);
            //frm.setControl("");
            frm.ShowDialog(this);
            setGrd();
        }
    }
}
