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
    public partial class FrmInvoiceView : Form
    {
        CnviControl cc;
        int colRow = 0, colRow1 = 1, colMOUDate = 2, colCustName = 3, colMOUNumber = 4, colSample = 5, colNetTotal = 6, colRemark = 7, colMOUId = 8, colId=9;
        int colCnt = 10;

        int colMOURow = 0, colMOUMOUDate = 1, colMOUCustName = 2, colMOUMOUNumber = 3, colMOUSample = 4, colMOUNetTotal = 5, colMOURemark = 6, colMOUMOUId = 7, colMOUAdd = 8;
        int colMOUCnt = 9;

        int colInvRow = 0, colInvInvNumber = 1, colInvInvDate = 2, colInvCustName = 3, colInvNettotal = 4, colInvRemark = 5, colInvInvId=6, colInvCustRemark=7;
        int colInvCnt = 8;
        public FrmInvoiceView(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            chkMOU.Checked = true;
            setGrdViewMOU();
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
            dgvView.Columns[colMOUNumber].Width = 140;
            dgvView.Columns[colMOUDate].Width = 150;
            dgvView.Columns[colCustName].Width = 300;
            dgvView.Columns[colNetTotal].Width = 120;
            dgvView.Columns[colRemark].Width = 150;
            //dgvView.Columns[colAmount].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colMOUNumber].HeaderText = "เลขที่ข้อตกลง";
            dgvView.Columns[colCustName].HeaderText = "ลูกค้า บริษัท";
            dgvView.Columns[colMOUDate].HeaderText = "วันที่เริ่มข้อตกลง";
            dgvView.Columns[colSample].HeaderText = "sample";
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
        private void setGrdViewMOU()
        {
            DataTable dt;

            dt = cc.modb.selectByNoBilling("");

            dgvView.ColumnCount = colMOUCnt;
            dgvView.Rows.Clear();
            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colMOURow].Width = 50;
            dgvView.Columns[colMOUMOUNumber].Width = 130;
            dgvView.Columns[colMOUMOUDate].Width = 150;
            dgvView.Columns[colMOUCustName].Width = 300;
            dgvView.Columns[colMOUNetTotal].Width = 120;
            dgvView.Columns[colMOURemark].Width = 150;
            //dgvView.Columns[colAmount].Width = 180;

            dgvView.Columns[colMOURow].HeaderText = "ลำดับ";
            dgvView.Columns[colMOUMOUNumber].HeaderText = "เลขที่ข้อตกลง";
            dgvView.Columns[colMOUCustName].HeaderText = "ลูกค้า บริษัท";
            dgvView.Columns[colMOUMOUDate].HeaderText = "วันที่เก็บตัวอย่าง...";
            dgvView.Columns[colMOUSample].HeaderText = "sample";
            dgvView.Columns[colMOUNetTotal].HeaderText = "มูลค่าทั้งหมด";
            dgvView.Columns[colMOURemark].HeaderText = "หมายเหตุ";

            dgvView.Columns[colNetTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colRow1].Visible = false;
            dgvView.Columns[colMOUMOUId].Visible = false;
            //dgvView.Columns[colAdd].Visible = false;
            //dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colMOURow, i].Value = (i + 1);
                    dgvView[colMOUMOUId, i].Value = dt.Rows[i][cc.modb.mo.Id].ToString();
                    dgvView[colMOUMOUNumber, i].Value = dt.Rows[i][cc.modb.mo.MOUNumberMain].ToString();
                    dgvView[colMOUMOUDate, i].Value = dt.Rows[i][cc.modb.mo.MOUDate].ToString();
                    dgvView[colMOUCustName, i].Value = dt.Rows[i][cc.modb.mo.CustName].ToString();
                    dgvView[colMOUNetTotal, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i]["amount1"]);
                    dgvView[colMOURemark, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.modb.mo.Remark]);
                    dgvView[colMOUSample, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i]["cnt"]);
                    //dgvView[colAdd, i].Value = "0";
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void setGrdViewInv()
        {
            DataTable dt;

            dt = cc.invdb.selectBillList();

            dgvView.ColumnCount = colInvCnt;
            dgvView.Rows.Clear();
            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colInvRow].Width = 50;
            dgvView.Columns[colInvInvNumber].Width = 140;
            dgvView.Columns[colInvInvDate].Width = 150;
            dgvView.Columns[colInvCustName].Width = 300;
            dgvView.Columns[colInvNettotal].Width = 120;
            dgvView.Columns[colInvRemark].Width = 150;
            dgvView.Columns[colInvCustRemark].Width = 180;

            dgvView.Columns[colInvRow].HeaderText = "ลำดับ";
            dgvView.Columns[colInvInvNumber].HeaderText = "เลขที่invoice";
            dgvView.Columns[colInvInvDate].HeaderText = "วันที่invoice";
            dgvView.Columns[colInvCustName].HeaderText = "ลูกค้า บริษัท";
            dgvView.Columns[colInvNettotal].HeaderText = "มูลค่าทั้งหมด";
            dgvView.Columns[colInvRemark].HeaderText = "หมายเหตุ";
            dgvView.Columns[colInvCustRemark].HeaderText = "เงื่อนไขการวางBill รับCheque";

            dgvView.Columns[colInvNettotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvView.Columns[colInvCustRemark].Visible = true;
            dgvView.Columns[colInvInvId].Visible = false;
            //dgvView.Columns[colAdd].Visible = false;
            //dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colInvRow, i].Value = (i + 1);
                    dgvView[colInvInvId, i].Value = dt.Rows[i][cc.invdb.inv.Id].ToString();
                    dgvView[colInvInvNumber, i].Value = dt.Rows[i][cc.invdb.inv.InvNumber].ToString();
                    dgvView[colInvInvDate, i].Value = dt.Rows[i][cc.invdb.inv.InvDate].ToString();
                    dgvView[colInvCustName, i].Value = dt.Rows[i][cc.invdb.inv.CustName].ToString();
                    dgvView[colInvNettotal, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.invdb.inv.Nettotal]);
                    dgvView[colInvRemark, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.invdb.inv.Remark]);
                    dgvView[colInvCustRemark, i].Value = dt.Rows[i][cc.invdb.inv.CustRemark2].ToString();
                    //dgvView[colAdd, i].Value = "0";
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmInvoiceAdd frm = new FrmInvoiceAdd("",true,cc);
            frm.ShowDialog(this);

        }

        private void FrmInvoiceView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //FrmBillAdd frm = new FrmBillAdd(dgvView[colId, e.RowIndex].Value.ToString(), false, cc);
            if (chkBillStatus2.Checked)
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                if (dgvView[colInvInvId, e.RowIndex].Value == null)
                {
                    //return;
                }
                FrmInvoiceAdd frm = new FrmInvoiceAdd(dgvView[colInvInvId, e.RowIndex].Value.ToString(), false, cc);
                //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
                frm.ShowDialog(this);
                setGrd();
            }

            
        }

        private void FrmInvoiceView_Load(object sender, EventArgs e)
        {

        }

        private void chkMOU_Click(object sender, EventArgs e)
        {
            setGrdViewMOU();
        }

        private void chkOverDue_Click(object sender, EventArgs e)
        {

        }

        private void chkBillStatus2_Click(object sender, EventArgs e)
        {
            setGrdViewInv();
        }
    }
}
