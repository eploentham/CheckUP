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
    public partial class FrmInvoiceAdd : Form
    {
        CnviControl cc;
        Invoice bi;
        Boolean pageLoad, biNew = false;
        int colRow = 0, colRow1=1, colMOUDate = 2,colCustName=3, colMOUNumber = 4, colSample=5, colNetTotal = 6, colRemark=7,colMOUId=8, colAdd=9;
        int colCnt = 10;
        int colAddRow = 0, colAddMOUNumber = 1, colAddAmount = 3, colAddMOUName = 2;
        public FrmInvoiceAdd(String biId, Boolean flagNew,CnviControl c)
        {
            InitializeComponent();
            cc = c;
            biNew = flagNew;
            initConfig(biId);
        }
        private void initConfig(String biId)
        {
            pageLoad = true;
            bi = new Invoice();
            dtpDateInv.Format = DateTimePickerFormat.Short;
            setControl(biId);
            
            //setGrdAdd();
            if (!biNew)
            {
                
                dgvView.Visible = false;
                groupBox1.Visible = true;
            }
            else
            {
                setGrdView("");
                setGrdAdd();
                groupBox1.Visible =true;
                chkActive.Checked = true;
                btnUnActive.Visible = false;
                dtpDateInv.Value = DateTime.Now;
            }
            pageLoad = false;
        }
        private void setControl(String biId)
        {
            cboCust = cc.cudb.getCboCustomer(cboCust);
            txtVatRate.Text = cc.cp.vat;
            txtInvDuePeriod.Text = cc.cp.InvDuePeriod;
            dgvView.ReadOnly = true;
            dgvAdd.ReadOnly = true;

            bi = cc.invdb.selectByPk(biId);
            cboCust.Text = bi.CustName;
            txtCustAddress.Text = bi.CustAddress;
            txtCustTel.Text = bi.CustTel;
            txtCustFax.Text = bi.CustFax;
            txtCustEmail.Text = bi.CustEmail;

            txtAmount.Text = bi.Amount;
            txtDiscount.Text = bi.Discount;
            txtDiscountPer.Text = bi.DiscountPer;
            txtTotal.Text = bi.Total;
            txtVat.Text = bi.Vat;
            txtVatRate.Text = bi.VatRate;
            txtNetTotal.Text = bi.Nettotal;
            txtInvDuePeriod.Text = bi.InvDuePeriod;
            txtInvId.Text = bi.Id;
            txtInvNumber.Text = bi.InvNumber;
            
            txtInvRemark.Text = bi.Remark;
            if (!biNew)
            {
                chkActive.Checked = true;
                groupBox1.Visible = true;
                dtpDateInv.Value = DateTime.Parse(bi.InvDate);
                setGrdAddInvItem(biId);
            }
            //cboContact.Text = bi.c
        }
        private void setGrdAddInvItem(String biId)
        {
            int colMOUnumber = 1, colAmount = 2;
            groupBox1.Visible = true;
            dgvAdd.Rows.Clear();
            dgvAdd.ColumnCount = 0;
            DataTable dt = cc.invidb.selectByInvId(biId);
            dgvAdd.ColumnCount = 4;
            dgvAdd.Columns[colAddRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colAddMOUNumber].HeaderText = "เลขที่ข้อตกลง";
            dgvAdd.Columns[colAddAmount].HeaderText = "มูลค่าทั้งหมด";
            dgvAdd.Columns[colAddMOUName].HeaderText = "รายการ";
            dgvAdd.RowCount = 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colAddRow].Width = 50;
            dgvAdd.Columns[colAddMOUNumber].Width = 120;
            dgvAdd.Columns[colAddAmount].Width = 120;
            dgvAdd.Columns[colAddMOUName].Width = 200;
            dgvAdd.RowCount = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvAdd[colAddRow, i].Value = (i + 1);
                dgvAdd[colAddMOUName, i].Value = dt.Rows[i][cc.invidb.invi.MOUName].ToString();
                dgvAdd[colAddMOUNumber, i].Value = dt.Rows[i][cc.invidb.invi.MOUNumber].ToString();
                dgvAdd[colAddAmount, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.invidb.invi.Amount]);

            }
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvAdd.Font = font;
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

            dt = cc.modb.selectByNoBilling(cuId);
            
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
            btnPrintInv.Left = btnSave.Left;
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
            groupBox1.Top = groupBox3.Top;
            groupBox1.Left = groupBox3.Left - groupBox1.Width - 20;
        }
        private void getBill()
        {
            Customer cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
            bi.Active = "1";
            bi.Amount = txtAmount.Text;
            bi.AmountDiscount = txtDiscount.Text;
            bi.InvDate = "";
            bi.InvNumber = "";
            bi.CustAddress = txtCustAddress.Text;
            bi.CustEmail = txtCustEmail.Text;
            bi.CustFax = txtCustFax.Text;
            bi.CustId = cc.getValueCboItem(cboCust);
            bi.CustName = cboCust.Text;
            bi.CustTel = txtCustTel.Text;
            bi.Discount = txtDiscount.Text;
            bi.DiscountPer = txtDiscountPer.Text;
            bi.Id = "";
            bi.Nettotal = txtNetTotal.Text;
            bi.Remark = txtInvRemark.Text;
            bi.StatusInv = "1";
            bi.Total = txtTotal.Text;
            bi.Vat = txtVat.Text;
            bi.VatRate = txtVatRate.Text;
            bi.InvDate = cc.cf.datetoDB(dtpDateInv.Value);
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
            txtTotal.Text = String.Format("{0:#,###,###.00}", total);
            txtVat.Text = String.Format("{0:#,###,###.00}",(total * double.Parse(cc.cf.NumberNull1(txtVatRate.Text))/100));
            txtNetTotal.Text = String.Format("{0:#,###,###.00}",(total+double.Parse(cc.cf.NumberNull1(txtVat.Text))));
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
                //cboContact.Text = cu.ContactName1;
                setGrdView(cu.Id);
                dgvAdd.Rows.Clear();
            }
        }

        private void FrmInvoiceAdd_Resize(object sender, EventArgs e)
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
            if (dgvView[colAdd, e.RowIndex].Value==null)
            {
                return;
            }
            if (dgvView[colMOUNumber, e.RowIndex].Value.ToString().Equals("1"))
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
                cc.lw.WriteLog("Error FrmInvoiceAdd dgvView_CellDoubleClick " + ex.Message);
                MessageBox.Show(" " + ex.Message, "Error FrmInvoiceAdd dgvView_CellDoubleClick");
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            getBill();
            bi.InvNumber = cc.invdb.getInvMaxNumber();
            biId = cc.invdb.insertBill(bi);
            if (biId.Length >= 1)
            {
                try
                {
                    for (int i = 0; i < dgvAdd.RowCount; i++)
                    {
                        if (dgvAdd[colMOUNumber, i].Value == null)
                        {
                            continue;
                        }
                        InvoiceItem bii = new InvoiceItem();
                        MOU mo = new MOU();
                        mo = cc.modb.selectByNumber1(dgvAdd[colMOUNumber, i].Value.ToString());
                        bii.Active = "1";
                        bii.Amount = dgvAdd[colNetTotal, i].Value.ToString();
                        bii.InvId = biId;
                        bii.Id = "";
                        bii.MOUId = mo.Id;
                        bii.MOUNumber = dgvAdd[colMOUNumber, i].Value.ToString();
                        bii.QuoId = mo.QuoId;
                        bii.QuoNumber = mo.QuoNumber;
                        bii.Remark = "";

                        cc.invidb.insertBillItem(bii);

                    }
                }
                catch (Exception ex)
                {
                    cc.lw.WriteLog("Error FrmInvoiceAdd btnSave_Click " + ex.Message);
                    MessageBox.Show("" + ex.Message, "Error FrmInvoiceAdd btnSave_Click");
                    return;
                }
                
                Invoice inv1 = cc.invdb.selectByPk(biId);
                txtInvId.Text = biId;
                txtInvNumber.Text = inv1.InvNumber;
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            }
            Cursor.Current = cursor;
        }

        private void FrmInvoiceAdd_Load(object sender, EventArgs e)
        {

        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;

                cboCust.Enabled = true;
                txtCustAddress.Enabled = true;
                txtCustTel.Enabled = true;
                txtCustFax.Enabled = true;
                txtCustEmail.Enabled = true;
                dgvView.Enabled = true;
                dgvAdd.Enabled = true;
                txtAmount.Enabled = true;
                txtDiscount.Enabled = true;
                txtDiscountPer.Enabled = true;
                txtTotal.Enabled = true;
                //chkActive.Checked = true;
                //ChkUnActive.Checked = true;
                txtVatRate.Enabled = true;
                txtDiscountPer.Enabled = true;
            }
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            btnUnActive.Visible = true;
            //chkActive.Checked = true;
            //ChkUnActive.Checked = true;

            //groupBox3.Enabled = false;
            //groupBox2.Enabled = false;
            //groupBox1.Enabled = false;
            dgvView.Enabled = false;
            dgvAdd.Enabled = false;
            //chkActive.Enabled = true;
            cboCust.Enabled = false;
            txtCustAddress.Enabled = false;
            txtCustTel.Enabled = false;
            txtCustFax.Enabled = false;
            txtCustEmail.Enabled = false;

            txtAmount.Enabled = false;
            txtDiscount.Enabled = false;
            txtDiscountPer.Enabled = false;
            txtTotal.Enabled = false;
            txtVatRate.Enabled = false;
            txtDiscountPer.Enabled = false;
        }

        private void btnPrintInv_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            String sql = "";
            //OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = cc.moidb.selectByMoId(txtInvId.Text);
            Invoice inv = cc.invdb.selectByPk(txtInvId.Text);
            //inv.CustName = inv.ContactName;
            //inv.CustAddress = "ที่อยู่ :   " + inv.CustAddress;
            //inv.CustTel = "เบอร์โทร : " + inv.CustTel + " Mobile : " + inv.CustMobile;
            //inv.CustEmail = " Email : " + inv.CustEmail;
            //inv.Line1 = cc.cp.mouLine1;
            //inv.QuoNumber = "เลขที่ : " + inv.MOUNumber + "-" + inv.MOUNumberCnt;
            //inv.DatePeriod = "วันที่ :  " + inv.DatePeriod;
            //inv.StaffQuoName = "ผู้เสนอราคา :  " + inv.StaffQuoName;
            //inv.StaffMOUTel = "เบอร์โทร : " + inv.StaffMOUTel + " Mobile : " + inv.StaffMOUMobile;
            //inv.StaffMOUEmail = "Email : " + inv.StaffMOUEmail;
            //inv.MOUNumber = "เลขที่ : " + inv.MOUNumber + "-" + inv.MOUNumberCnt;

            FrmReport frm = new FrmReport(cc);
            frm.setReportInvoice(inv, dt);
            frm.ShowDialog(this);
            Cursor.Current = cursor;
        }
    }
}
