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
    public partial class FrmPOView : Form
    {
        CnviControl cc;
        int colCnt = 7;
        int colRow = 0, colPONumber = 1, colCustName = 2, colDuePeriod = 3, colId = 4, colStaffName = 5, colStatusMOU = 6;
        public FrmPOView(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            setGrd();
            dgvView.ReadOnly = true;
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80 - btnAdd.Width;
            dgvView.Height = this.Height - 150;
            btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {
            DataTable dt = new DataTable();
            dt = cc.podb.selectAll();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colPONumber].Width = 150;
            dgvView.Columns[colCustName].Width = 350;
            dgvView.Columns[colDuePeriod].Width = 350;
            dgvView.Columns[colId].Width = 80;
            dgvView.Columns[colStatusMOU].Width = 80;
            dgvView.Columns[colStaffName].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colPONumber].HeaderText = "เลขที่";
            dgvView.Columns[colCustName].HeaderText = "ชื่อลูกค้า";
            dgvView.Columns[colDuePeriod].HeaderText = "ระยะเวลา";
            dgvView.Columns[colId].HeaderText = "id";
            dgvView.Columns[colStaffName].HeaderText = "";
            dgvView.Columns[colStatusMOU].HeaderText = "สถานะ";

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colPONumber, i].Value = dt.Rows[i][cc.podb.po.PONumber].ToString();
                    dgvView[colCustName, i].Value = dt.Rows[i][cc.podb.po.CuNametT].ToString();
                    dgvView[colDuePeriod, i].Value = dt.Rows[i][cc.podb.po.PODurPeriod].ToString();
                    dgvView[colId, i].Value = "";
                    //if (dt.Rows[i][cc.modb.mo.statusMOU].ToString().Equals("1"))
                    //{
                    //    dgvView[colStaffName, i].Value = "รอเก็บผล";
                    //}
                    //else if (dt.Rows[i][cc.modb.mo.statusMOU].ToString().Equals("2"))
                    //{
                    //    dgvView[colStaffName, i].Value = "เก็บผลเรียบร้อยแล้ว";
                    //}

                    //dgvView[colStatusMOU, i].Value = dt.Rows[i][cc.modb.mo.statusMOU].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            dgvView.ReadOnly = true;
        }
        private void FrmPOView_Load(object sender, EventArgs e)
        {

        }

        private void FrmPOView_Resize(object sender, EventArgs e)
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

            FrmPOAdd frm = new FrmPOAdd(dgvView[colPONumber, e.RowIndex].Value.ToString(),  cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrd();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPOAdd frm = new FrmPOAdd("",  cc);
            frm.ShowDialog(this);
            setGrd();
        }
    }
}
