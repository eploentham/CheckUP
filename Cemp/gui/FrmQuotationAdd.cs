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
    public partial class FrmQuotationAdd : Form
    {
        CnviControl cc;
        Quotation qu;
        int colRow = 0, colItem = 1, colMethod = 2, colQty = 3, colPrice = 4, colAmount = 5, colId=6;
        int colCnt = 7;
        public FrmQuotationAdd(String quId, CnviControl c)
        {
            InitializeComponent();
            initConfig(quId, c);
        }
        private void initConfig(String quId, CnviControl c)
        {
            cc = c;
            qu = new Quotation();
            setControl(quId);
            setGrd();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 80;
            //dgvAdd.Height = this.Height - 150;
            //btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setControl(String quId)
        {
            qu = cc.qudb.selectByPk(quId);
            txtAmount.Text = qu.Amount;
            txtAmountDiscount.Text = qu.AmountDiscount;
            txtCompAddress1.Text = qu.CompAddress1;
            txtCompAddress2.Text = qu.CompAddress2;
            txtCompTaxId.Text = qu.CompTaxId;
            txtCompId.Text = qu.CompId;
            cboComp.Text = qu.CompName;
            txtCustAddress.Text = qu.CustAddress;
            txtCustEmail.Text = qu.CustEmail;
            txtCustFax.Text = qu.CustFax;
            txtCustTel.Text = qu.CustTel;
            cboCust.Text = qu.CustName;
            txtCustId.Text = qu.CustId;
            txtDiscount.Text = qu.Discount;
            txtNetTotal.Text = qu.NetTotal;
            txtPlus1.Text = qu.Plus1;
            txtQuId.Text = qu.Id;
            txtQuNumber.Text = qu.QuoNumber;
            txtStaffEmail.Text = qu.StaffEmail;
            txtStaffTel.Text = qu.StaffTel;
            txtStaffId.Text = qu.StaffId;
            cboStaff.Text = qu.StaffName;
            txtTotal.Text = qu.Total;
            txtVat.Text = qu.Vat;
            txtVatRate.Text = qu.VatRate;
            cboStaffApprove.Text = qu.StaffApproveName;
            txtStaffApproveId.Text = qu.StaffApproveId;
        }
        private void getQuotation()
        {
            qu.Amount = txtAmount.Text;
            qu.AmountDiscount=txtAmountDiscount.Text;
            qu.CompAddress1 = txtCompAddress1.Text;
            qu.CompAddress2 = txtCompAddress2.Text;
            qu.CompTaxId = txtCompTaxId.Text;
            qu.CompId = txtCompId.Text;
            qu.CompName = cboComp.Text;
            qu.CustAddress = txtCustAddress.Text;
            qu.CustEmail = txtCustEmail.Text;
            qu.CustFax = txtCustFax.Text;
            qu.CustTel = txtCustTel.Text;
            qu.CustName = cboCust.Text;
            qu.CustId = txtCustId.Text;
            qu.Discount = txtDiscount.Text;
            qu.NetTotal = txtNetTotal.Text;
            qu.Plus1 = txtPlus1.Text;
            qu.Id = txtQuId.Text;
            qu.QuoNumber = txtQuNumber.Text;
            qu.StaffEmail = txtStaffEmail.Text;
            qu.StaffTel = txtStaffTel.Text;
            qu.StaffId = txtStaffId.Text;
            qu.StaffName = cboStaff.Text;
            qu.Total = txtTotal.Text;
            qu.Vat = txtVat.Text;
            qu.VatRate = txtVatRate.Text;
            qu.StaffApproveName = cboStaffApprove.Text;
            qu.StaffApproveId = txtStaffApproveId.Text;
            qu.Active = "1";
            //qu.StatusQuo = "1";
        }
        private void setGrd()
        {
            //DataGridViewComboBoxColumn newColumn = new DataGridViewComboBoxColumn();
            //newColumn.Name = "abc";
            //newColumn.DataSource = new string[] { "a", "b", "c" };
            //newColumn.ReadOnly = false;

            DataTable dt = new DataTable();
            dt = cc.sfdb.selectAll();
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colItem].Width = 150;
            dgvAdd.Columns[colMethod].Width = 120;
            dgvAdd.Columns[colQty].Width = 80;
            dgvAdd.Columns[colPrice].Width = 80;
            dgvAdd.Columns[colAmount].Width = 180;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItem].HeaderText = "Parameter";
            dgvAdd.Columns[colMethod].HeaderText = "Method";
            dgvAdd.Columns[colQty].HeaderText = "QTY";
            dgvAdd.Columns[colPrice].HeaderText = "Price";
            dgvAdd.Columns[colAmount].HeaderText = "Amount";
            dgvAdd.Columns[colId].HeaderText = "  ";

            dgvAdd.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvAdd.Font = font;
            dgvAdd.Columns[colId].Visible = false;
            //dgvAdd.Columns.Add(newColumn);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dgvAdd.Rows[0].Cells = newColumn;
                    //DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(dgvAdd.Rows[i].Cells[colItem]);
                    //cell.DataSource = newColumn;
                    
                    //dgvAdd[colRow, i].Value = (i + 1);
                    //dgvAdd[colItem, i].Value = dt.Rows[i][cc.sfdb.sf.Code].ToString();
                    //dgvAdd[colMethod, i].Value = dt.Rows[i][cc.sfdb.sf.NameT].ToString();
                    //dgvAdd[colQty, i].Value = dt.Rows[i][cc.sfdb.sf.Remark].ToString();
                    //dgvAdd[colPrice, i].Value = dt.Rows[i][cc.sfdb.sf.Remark].ToString();
                    //dgvAdd[colAmount, i].Value = dt.Rows[i][cc.sfdb.sf.Remark].ToString();
                    //dgvAdd[colId, i].Value = dt.Rows[i][cc.sfdb.sf.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void FrmQuotationAdd_Load(object sender, EventArgs e)
        {

        }

        private void FrmQuotationAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuNumber.Text.Equals(""))
            {
                MessageBox.Show("ไม่มีเลขที่ Quotation", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboComp.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ชื่อบริษัท", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboCust.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ชื่อลูกค้า", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboContact.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ชื่อผู้ติดต่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboStaff.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ชื่อผู้เสนอราคา", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboStaffApprove.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ชื่อผู้อนุมัติ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            //if (txtStaffCode.Text.Equals(""))
            //{
            //    MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
            //    return;
            //}
            //if (txtQuNumber.Text.Equals(""))
            //{
            //    qu = cc.qudb.selectByNumber(txtQuNumber.Text);
            //    if (!qu.Id.Equals(""))
            //    {
            //        MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + qu.QuoNumber + " ชื่อ " + s.NameT, "รหัสซ้ำ");
            //        return;
            //    }
            //    if (!s.Code.Equals(""))
            //    {
            //        MessageBox.Show("ป้อนชื่อซ้ำ\nรหัส " + s.Code + " ชื่อ " + s.NameT, "ชื่อซ้ำ");
            //        return;
            //    }
            //}
            getQuotation();
            if (cc.qudb.insertQuotation(qu).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }
    }
}
