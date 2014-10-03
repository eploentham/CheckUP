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
    public partial class FrmMOUView : Form
    {
        CnviControl cc;
        int colCnt = 7;
        int colRow = 0, colMOUNumber = 1, colCustName = 2, colContactName = 3, colId = 4, colStaffName = 5, colStatusMOU = 6;
        public FrmMOUView(CnviControl c)
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
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {
            DataTable dt = new DataTable();
            dt = cc.modb.selectMOUView();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colMOUNumber].Width = 150;
            dgvView.Columns[colCustName].Width = 350;
            dgvView.Columns[colContactName].Width = 350;
            dgvView.Columns[colId].Width = 80;
            dgvView.Columns[colStatusMOU].Width = 80;
            dgvView.Columns[colStaffName].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colMOUNumber].HeaderText = "เลขที่";
            dgvView.Columns[colCustName].HeaderText = "ชื่อลูกค้า";
            dgvView.Columns[colContactName].HeaderText = "ชื่อผู้ติดต่อ";
            dgvView.Columns[colId].HeaderText = "id";
            dgvView.Columns[colStaffName].HeaderText = "ผู้รับผิดชอบข้อตกลง";
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
                    dgvView[colMOUNumber, i].Value = dt.Rows[i][cc.modb.mo.MOUNumberMain].ToString();
                    dgvView[colCustName, i].Value = dt.Rows[i][cc.modb.mo.CustName].ToString();
                    dgvView[colContactName, i].Value = dt.Rows[i][cc.modb.mo.ContactName].ToString();
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
        private void FrmMOUView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmMOUAdd frm = new FrmMOUAdd("",true,cc);
            frm.ShowDialog(this);
            setGrd();
        }

        private void FrmMOUView_Resize(object sender, EventArgs e)
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

            FrmMOUAdd frm = new FrmMOUAdd(dgvView[colMOUNumber, e.RowIndex].Value.ToString(),false, cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrd();
        }
    }
}
