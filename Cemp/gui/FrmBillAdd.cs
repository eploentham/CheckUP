using Cemp.Control;
using Cemp.object1;
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
    public partial class FrmBillAdd : Form
    {
        CnviControl cc;
        Bill bi;
        Boolean pageLoad, biNew = false;
        int colRow = 0, colRow1=1, colMOUDate = 2,colCustName=3, colMOUNumber = 4, colSample=5, colNetTotal = 6, colRemark=7,colMOUId=8, colAdd=9;
        int colCnt = 10;
        public FrmBillAdd(String biId, Boolean flagNew,CnviControl c)
        {
            InitializeComponent();
            cc = c;
            biNew = flagNew;
            initConfig();
        }
        private void initConfig()
        {
            pageLoad = true;
            bi = new Bill();
            setControl();
            setGrdView("");
            setGrdAdd();
            if (!biNew)
            {
                dgvView.Visible = false;
            }
            pageLoad = false;
        }
        private void setControl()
        {
            cboCust = cc.cudb.getCboCustomer(cboCust);
            txtVatRate.Text = cc.cp.vat;
            dgvView.ReadOnly = true;
            dgvAdd.ReadOnly = true;
        }
        private void setGrdAdd()
        {
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colRow1].Width = 50;
            dgvAdd.Columns[colMOUNumber].Width = 120;
            dgvAdd.Columns[colMOUDate].Width = 150;
            dgvAdd.Columns[colCustName].Width = 300;
            dgvAdd.Columns[colNetTotal].Width = 120;
            dgvAdd.Columns[colRemark].Width = 150;
            //dgvView.Columns[colAmount].Width = 180;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colMOUNumber].HeaderText = "เลขที่ข้อตกลง";
            dgvAdd.Columns[colCustName].HeaderText = "ลูกค้า บริษัท";
            dgvAdd.Columns[colMOUDate].HeaderText = "วันที่เริ่มข้อตกลง";
            dgvAdd.Columns[colSample].HeaderText = "จน.sample";
            dgvAdd.Columns[colNetTotal].HeaderText = "มูลค่าทั้งหมด";
            dgvAdd.Columns[colRemark].HeaderText = "หมายเหตุ";
            //dgvAdd.Columns[colRow1].Visible = false;
            dgvAdd.Columns[colMOUId].Visible = false;
            dgvAdd.Columns[colAdd].Visible = false;
            dgvAdd.Columns[colNetTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvAdd.Font = font;
        }
        private void setGrdView(String cuId)
        {
            DataTable dt;

            dt = cc.modb.selectByNoBilling("");
            
            dgvView.ColumnCount = colCnt;
            dgvView.Rows.Clear();
            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
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

            dgvView.Columns[colNetTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvView.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvView.Columns[colRow1].Visible = false;
            dgvView.Columns[colMOUId].Visible = false;
            dgvView.Columns[colAdd].Visible = false;
            //dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colMOUId, i].Value = dt.Rows[i][cc.modb.mo.Id].ToString();
                    dgvView[colMOUNumber, i].Value = dt.Rows[i][cc.modb.mo.MOUNumber].ToString();
                    dgvView[colMOUDate, i].Value = dt.Rows[i][cc.modb.mo.MOUDate].ToString();
                    dgvView[colCustName, i].Value = dt.Rows[i][cc.modb.mo.CustName].ToString();
                    dgvView[colNetTotal, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i]["amount1"]);
                    dgvView[colRemark, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.modb.mo.Remark]);
                    dgvView[colSample, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i]["cnt"]);
                    dgvView[colAdd, i].Value = "0";
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void setResize()
        {
            //dgvAdd.Left = this.Width - 80;
            dgvView.Height = this.Height - 150;
            dgvAdd.Height = this.Height - dgvAdd.Top - 150 + 12 - groupBox3.Height;
            
            groupBox2.Left = this.Width - groupBox2.Width - btnSave.Width - 150;
            
            btnSave.Left = groupBox2.Left + groupBox2.Width + 20;
            btnPrintMou.Left = btnSave.Left;
            if (biNew)
            {
                dgvAdd.Left = dgvView.Width + 20;
            }
            else
            {
                dgvAdd.Left = dgvView.Left;
            }
            
            dgvAdd.Width = (this.Width - dgvAdd.Left-50);
            groupBox3.Left = dgvAdd.Left + dgvAdd.Width - groupBox3.Width;
            groupBox3.Top = groupBox2.Height+dgvAdd.Height + 20;
            //groupBox1.Height = this.Height = 150;
        }
        private void getBill()
        {
            Customer cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
            bi.Active = "1";
            bi.Amount = txtAmount.Text;
            bi.AmountDiscount = txtDiscount.Text;
            bi.BillDate = "";
            bi.BillNumber = "";
            bi.CustAddress = txtCustAddress.Text;
            bi.CustEmail = txtCustEmail.Text;
            bi.CustFax = txtCustFax.Text;
            bi.CustId = cc.getValueCboItem(cboCust);
            bi.CustName = cboCust.Text;
            bi.CustTel = txtCustTel.Text;
            bi.Discount = txtDiscount.Text;
            bi.DiscountPer = "0";
            bi.Id = "";
            bi.Nettotal = txtNetTotal.Text;
            bi.Remark = "";
            bi.StatusBill = "1";
            bi.Total = txtTotal.Text;
            bi.Vat = txtVat.Text;
            bi.VatRate = txtVatRate.Text;

        }
        private void calAmount()
        {
            Double amt = 0;
            for (int i = 0; i < dgvAdd.Rows.Count; i++)
            {
                if (dgvAdd[colNetTotal, i].Value == null)
                {
                    continue;
                }
                amt += double.Parse(cc.cf.NumberNull1(dgvAdd[colNetTotal, i].Value.ToString()));

                if ((i % 2) != 0)
                {
                    dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
            }
            txtAmount.Text = String.Format("{0:#,###,###.00}",amt);
        }
        private void calNetTotal()
        {
            Double amt = 0, total=0, nettotal=0;
            amt = double.Parse(cc.cf.NumberNull1(txtAmount.Text));
            total = amt - double.Parse(cc.cf.NumberNull1(txtDiscount.Text));
            txtVat.Text = String.Format("{0:#,###,###.00}",(total * double.Parse(cc.cf.NumberNull1(txtVatRate.Text))));
            txtNetTotal.Text = String.Format("{0:#,###,###.00}",(total+double.Parse(cc.cf.NumberNull1(txtVat.Text))));
        }
        private void FrmBillAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void cboCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Customer cu;
                cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
                //txtCustId.Text = cu.Id;
                txtCustAddress.Text = cu.AddressT;
                txtCustEmail.Text = cu.Email;
                txtCustFax.Text = cu.Fax;
                txtCustTel.Text = cu.Tele;
                cboContact.Text = cu.ContactName1;
                setGrdView(cu.Id);
                dgvAdd.Rows.Clear();
            }
        }

        private void FrmBillAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow dr = dgvView.Rows[e.RowIndex];
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            //dgvView.Enabled = false;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvView[colAdd, e.RowIndex].Value.ToString().Equals("1"))
            {
                return;
            }
            int row=dgvAdd.Rows.Add(new DataGridViewRow());
            try
            {
                dgvAdd[colRow, row].Value = (row + 1);
                dgvAdd[colRow1, row].Value = dgvView[colRow, e.RowIndex].Value;
                dgvAdd[colMOUNumber, row].Value = dgvView[colMOUNumber, e.RowIndex].Value;
                dgvAdd[colMOUDate, row].Value = dgvView[colMOUDate, e.RowIndex].Value;
                dgvAdd[colCustName, row].Value = dgvView[colCustName, e.RowIndex].Value;
                dgvAdd[colNetTotal, row].Value = dgvView[colNetTotal, e.RowIndex].Value;
                dgvAdd[colRemark, row].Value = dgvView[colRemark, e.RowIndex].Value;
                dgvAdd[colSample, row].Value = dgvView[colSample, e.RowIndex].Value;
                dgvAdd[colSample, row].Value = dgvView[colSample, e.RowIndex].Value;

                dgvView[colAdd, e.RowIndex].Value = "1";
                calAmount();
                calNetTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dgvView_CellDoubleClick " + ex.Message, "Error");
            }
            

            Cursor.Current = cursor;
            //dgvView.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String biId = "";
            if (cboCust.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            getBill();
            biId = cc.bidb.insertBill(bi);
            if (biId.Length >= 1)
            {
                for (int i = 0; i < dgvAdd.RowCount; i++)
                {
                    BillItem bii = new BillItem();
                    MOU mo = new MOU();
                    mo = cc.modb.selectByNumber1(dgvAdd[colMOUNumber, i].Value.ToString());
                    bii.Active = "1";
                    bii.Amount = dgvAdd[colNetTotal, i].Value.ToString();
                    bii.BillId = biId;
                    bii.Id = "";
                    bii.MOUId = mo.Id;
                    bii.MOUNumber = dgvAdd[colMOUNumber, i].Value.ToString();
                    bii.QuoId = mo.QuoId;
                    bii.QuoNumber = mo.QuoNumber;
                    bii.Remark = "";

                    cc.biidb.insertBillItem(bii);

                }
            }
        }
    }
}
