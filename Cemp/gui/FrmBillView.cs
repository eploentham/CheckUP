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
    public partial class FrmBillView : Form
    {
        CnviControl cc;
        int colRow = 0, colRow1 = 1, colMOUDate = 2, colCustName = 3, colMOUNumber = 4, colSample = 5, colNetTotal = 6, colRemark = 7, colMOUId = 8, colId=9;
        int colCnt = 10;
        public FrmBillView(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
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
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colRow1].Width = 50;
            dgvView.Columns[colMOUNumber].Width = 120;
            dgvView.Columns[colMOUDate].Width = 150;
            dgvView.Columns[colCustName].Width = 300;
            dgvView.Columns[colNetTotal].Width = 120;
            dgvView.Columns[colRemark].Width = 150;
            //dgvView.Columns[colAmount].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colMOUNumber].HeaderText = "เลขที่ข้อตกลง";
            dgvView.Columns[colCustName].HeaderText = "ลูกค้า บริษัท";
            dgvView.Columns[colMOUDate].HeaderText = "วันที่เริ่มข้อตกลง";
            dgvView.Columns[colSample].HeaderText = "จน.sample";
            dgvView.Columns[colNetTotal].HeaderText = "มูลค่าทั้งหมด";
            dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";
            //dgvView.Columns[colRow1].Visible = false;
            dgvView.Columns[colMOUId].Visible = false;
            dgvView.Columns[colNetTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
        }
        private void FrmBillView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBillAdd frm = new FrmBillAdd("",true,cc);
            frm.ShowDialog(this);

        }

        private void FrmBillView_Resize(object sender, EventArgs e)
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
                //return;
            }

            //FrmBillAdd frm = new FrmBillAdd(dgvView[colId, e.RowIndex].Value.ToString(), false, cc);
            FrmBillAdd frm = new FrmBillAdd("", false, cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrd();
        }
    }
}
