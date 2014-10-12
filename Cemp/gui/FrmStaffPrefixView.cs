using Cemp.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cemp.gui
{
    public partial class FrmStaffPrefixView : Form
    {
        CnviControl cc;
        int colRow = 0, colCode = 1, colNameT = 2, colNameE = 3, colRemark = 4, colId = 5;
        int colCnt = 6;
        DataTable dt = new DataTable();
        public FrmStaffPrefixView(CnviControl c)
        {
            InitializeComponent();
            initConfig(c);
        }
        private void initConfig(CnviControl c)
        {
            cc = c;
            setGrd();
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80 - btnAdd.Width;
            dgvView.Height = this.Height - 150;
            btnAdd.Left = dgvView.Width + 20;
            btnPrint.Left = btnAdd.Left;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {
            dt = cc.predb.selectAll();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colCode].Width = 80;
            dgvView.Columns[colNameT].Width = 200;
            dgvView.Columns[colNameE].Width = 200;
            dgvView.Columns[colRemark].Width = 200;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            //dgvView.Columns[colCode].HeaderText = "code";
            dgvView.Columns[colNameT].HeaderText = "ชื่อ";
            dgvView.Columns[colNameE].HeaderText = "Name";
            //dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";

            //dgvView.Columns[colPassword].HeaderText = "  ";

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
            dgvView.Columns[colCode].Visible = false;
            dgvView.Columns[colRemark].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    //dgvView[colCode, i].Value = dt.Rows[i][cc.itgdb.itg.Code].ToString();
                    dgvView[colNameT, i].Value = dt.Rows[i][cc.predb.pre.NameT].ToString();
                    dgvView[colNameE, i].Value = dt.Rows[i][cc.predb.pre.NameE].ToString();

                    //dgvView[colRemark, i].Value = dt.Rows[i][cc.andb.an.Remark].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][cc.predb.pre.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            dgvView.ReadOnly = true;
        }
        private void FrmStaffPrefixView_Load(object sender, EventArgs e)
        {

        }

        private void FrmStaffPrefixView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvView[colId, e.RowIndex].Value == null)
            {
                return;
            }
            FrmStaffPrefixAdd frm = new FrmStaffPrefixAdd(dgvView[colId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmStaffPrefixAdd frm = new FrmStaffPrefixAdd("", cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrd();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String sql = "";
            //DataTable dt = cc.itgdb.selectAll();
            FrmReport frm = new FrmReport(cc);
            frm.setReport("ItemGroupList", "รายงานรายละเอียด Parameter Group", "เงื่อนไข ทั้งหมด", dt);
            frm.ShowDialog(this);
        }
    }
}
