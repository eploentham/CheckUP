using Cemp.Control;
using Cemp.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        Company cp;
        int colRow = 0, colItem = 1, colMethod = 2, colQty = 3, colPrice = 4, colAmount = 5, colId=6, colDel=7, colItemId=8, colMethodId=9, colEdit=10;
        int colCnt = 11;
        String oldNetTotal = "";
        Boolean pageLoad = false;
        //NumberFormat fmt = NumberFormat.getCurrencyInstance();
        public FrmQuotationAdd(String quId, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig(quId);
        }
        private void initConfig(String quId)
        {
            pageLoad = true;
            //cc = c;
            qu = new Quotation();
            cp = cc.cpdb.selectByPk();
            txtVatRate.Text = cp.vat;
            dtpDateQu.Format = DateTimePickerFormat.Short;
            setControl(quId);
            setGrd(quId);
            pageLoad = false;
            txtItemAmount.ReadOnly = true;
            txtRow.ReadOnly = true;
            dgvAdd.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtAmountDiscount.ReadOnly = true;
            txtVatRate.ReadOnly = true;
            txtVat.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtNetTotal.ReadOnly = true;
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 80;
            //groupBox3.Left = dgvAdd.Width - groupBox3.Width - 50;
            btnSave.Left = dgvAdd.Width - 80;
            btnPrint.Left = btnSave.Left;
            groupBox2.Left = this.Width - groupBox2.Width - btnSave.Width - 150;
            groupBox3.Left = groupBox2.Left;
            //groupBox1.Height = this.Height = 150;
        }
        private void setControl(String quId)
        {
            qu = cc.qudb.selectByPk(quId);
            cboComp = cc.cpdb.getCboCustomer(cboComp);
            cboCust = cc.cudb.getCboCustomer(cboCust);
            cboStaff = cc.sfdb.getCboStaff(cboStaff);
            cboStaffApprove = cc.sfdb.getCboStaff(cboStaffApprove);
            cboRemark1 = cc.qudb.getCboRemark1(cboRemark1);
            cboRemark2 = cc.qudb.getCboRemark2(cboRemark2);
            cboRemark3 = cc.qudb.getCboRemark3(cboRemark3);
            cboItem = cc.itdb.getCboItemQuotation(cboItem);
            //cboMethod = cc.medb.getCboMethod(cboMethod);

            cboContact.Text = qu.ContactName;
            txtAmount.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.Amount)));
            txtAmountDiscount.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.AmountDiscount)));
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
            txtDiscount.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.Discount)));
            txtNetTotal.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.NetTotal)));
            txtPlus1.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.Plus1)));
            txtQuId.Text = qu.Id;
            txtQuNumber.Text = qu.QuoNumber+"-"+qu.QuoNumberCnt;
            txtStaffEmail.Text = qu.StaffEmail;
            txtStaffTel.Text = qu.StaffTel;
            txtStaffId.Text = qu.StaffId;
            cboStaff.Text = qu.StaffName;
            txtTotal.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.Total)));
            txtVat.Text = String.Format("{0:#,###,###.00}",double.Parse(cc.cf.NumberNull1(qu.Vat)));
            txtVatRate.Text = qu.VatRate;
            cboStaffApprove.Text = qu.StaffApproveName;
            txtStaffApproveId.Text = qu.StaffApproveId;

            //txtLine1.Text = qu.Line1;
            //txtLine2.Text = qu.Line2;
            //txtLine3.Text = qu.Line3;
            txtLine4.Text = qu.Line4;
            txtLine5.Text = qu.Line5;
            txtLine6.Text = qu.Line6;

            //txtVatRate.Text = qu.VatRate;
            cboRemark1.Text = qu.Remark1;
            cboRemark2.Text = qu.Remark2;
            cboRemark3.Text = qu.Remark3;

            if (qu.Id.Equals(""))
            {
                if (cboComp.Items.Count == 1)
                {
                    cboComp.Text = cp.NameT;
                    txtCompId.Text = cp.Id;
                    txtCompAddress1.Text = cp.AddressT;
                    txtCompAddress2.Text = cp.AddressT;
                    txtCompTaxId.Text = cp.TaxId;
                    txtVatRate.Text = cp.vat;
                }
                //txtLine1.Text = cc.initC.quoLine1;
                //txtLine2.Text = cc.initC.quoLine2;
                //txtLine3.Text = cc.initC.quoLine3;
                txtLine4.Text = cc.initC.quoLine4;
                txtLine5.Text = cc.initC.quoLine5;
                txtLine6.Text = cc.initC.quoLine6;

                btnPrint.Visible = false;
            }
            else
            {
                btnPrint.Visible = true;
            }

            txtQuNumber.ReadOnly = true;
            oldNetTotal = qu.NetTotal;
        }
        private void getQuotation()
        {
            qu.Amount = txtAmount.Text.Replace(",", "");
            qu.AmountDiscount = txtAmountDiscount.Text.Replace(",", "");
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
            qu.Discount = txtDiscount.Text.Replace(",", "");
            qu.NetTotal = txtNetTotal.Text.Replace(",", "");
            qu.Plus1 = txtPlus1.Text.Replace(",", "");
            qu.Id = txtQuId.Text;
            qu.QuoNumber = txtQuNumber.Text;
            qu.StaffEmail = txtStaffEmail.Text;
            qu.StaffTel = txtStaffTel.Text;
            qu.StaffId = txtStaffId.Text;
            qu.StaffName = cboStaff.Text;
            qu.Total = txtTotal.Text.Replace(",","");
            qu.Vat = txtVat.Text.Replace(",", "");
            qu.VatRate = txtVatRate.Text;
            qu.StaffApproveName = cboStaffApprove.Text;
            qu.StaffApproveId = txtStaffApproveId.Text;
            qu.Active = "1";
            qu.Remark1 = cboRemark1.Text;
            qu.Remark2 = cboRemark2.Text;
            qu.Remark3 = cboRemark3.Text;
            qu.ContactName = cboContact.Text;

            //qu.Line1 = txtLine1.Text;
            //qu.Line2 = txtLine2.Text;
            //qu.Line3 = txtLine3.Text;
            qu.Line4 = txtLine4.Text;
            qu.Line5 = txtLine5.Text;
            qu.Line6 = txtLine6.Text;
            //qu.StatusQuo = "1";
        }
        private void setGrd(String quId)
        {
            DataTable dt = cc.quidb.selectByQuId(quId);
            //DataGridViewComboBoxColumn newColumn = new DataGridViewComboBoxColumn();
            //newColumn.Name = "abc";
            //newColumn.DataSource = new string[] { "a", "b", "c" };
            //newColumn.ReadOnly = false;

            //DataTable dt = new DataTable();
            //dt = cc.sfdb.selectAll();
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colItem].Width = 150;
            dgvAdd.Columns[colMethod].Width = 120;
            dgvAdd.Columns[colQty].Width = 120;
            dgvAdd.Columns[colPrice].Width = 150;
            dgvAdd.Columns[colAmount].Width = 180;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItem].HeaderText = "Parameter";
            dgvAdd.Columns[colMethod].HeaderText = "Method";
            dgvAdd.Columns[colQty].HeaderText = "QTY";
            dgvAdd.Columns[colPrice].HeaderText = "Price";
            dgvAdd.Columns[colAmount].HeaderText = "Amount";
            dgvAdd.Columns[colId].HeaderText = "  ";

            dgvAdd.Columns[colQty].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAdd.Columns[colPrice].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAdd.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAdd.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvAdd.Font = font;
            dgvAdd.Columns[colId].Visible = false;
            dgvAdd.Columns[colDel].Visible = false;
            dgvAdd.Columns[colItemId].Visible = false;
            dgvAdd.Columns[colMethodId].Visible = false;
            dgvAdd.Columns[colEdit].Visible = false;
            //dgvAdd.Columns.Add(newColumn);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dgvAdd.Rows[0].Cells = newColumn;
                    //DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(dgvAdd.Rows[i].Cells[colItem]);
                    //cell.DataSource = newColumn;

                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colItem, i].Value = dt.Rows[i][cc.quidb.qui.ItemDescription].ToString();
                    dgvAdd[colMethod, i].Value = dt.Rows[i][cc.quidb.qui.MethodDescription].ToString();
                    dgvAdd[colQty, i].Value = dt.Rows[i][cc.quidb.qui.Qty].ToString();
                    dgvAdd[colPrice, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.quidb.qui.PriceSale]);
                    dgvAdd[colAmount, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.quidb.qui.Amount]);
                    dgvAdd[colItemId, i].Value = dt.Rows[i][cc.quidb.qui.ItemId].ToString();
                    dgvAdd[colMethodId, i].Value = dt.Rows[i][cc.quidb.qui.MethodId].ToString();
                    dgvAdd[colId, i].Value = dt.Rows[i][cc.quidb.qui.Id].ToString();
                    dgvAdd[colDel, i].Value = "";
                    dgvAdd[colEdit, i].Value = "";
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void calAmount()
        {
            Double amt = 0;
            String amt1 = "";
            for (int i = 0; i < dgvAdd.Rows.Count; i++)
            {
                if (dgvAdd[colAmount, i].Value==null)
                {
                    continue;
                }
                if (dgvAdd[colAmount, i].Value.ToString().Equals(""))
                {
                    continue;
                }
                amt += Double.Parse(cc.cf.NumberNull1(dgvAdd[colAmount, i].Value.ToString().Replace(",","")));
            }
            txtAmount.Text = String.Format("{0:#,###,###.00}", amt);
        }
        private void calNetTotal()
        {
            Double amt = 0, amtDis=0,total=0,netTotal=0, vat=0;
            amt = Double.Parse(cc.cf.NumberNull1(txtAmount.Text.Replace(",", "")));
            amtDis = amt - Double.Parse(cc.cf.NumberNull1(txtDiscount.Text.Replace(",", "")));
            total = amtDis + Double.Parse(cc.cf.NumberNull1(txtPlus1.Text.Replace(",", "")));
            vat = (total * Double.Parse(cc.cf.NumberNull1(txtVatRate.Text.Replace(",", ""))) / 100);
            netTotal = total + vat;
            txtAmountDiscount.Text = String.Format("{0:#,###,###.00}", amtDis);
            txtTotal.Text = String.Format("{0:#,###,###.00}", total);
            txtVat.Text = String.Format("{0:#,###,###.00}", vat);
            txtNetTotal.Text = String.Format("{0:#,###,###.00}", netTotal);
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
            String quId = "";
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            getQuotation();
            if (qu.Id.Equals(""))
            {
                qu.QuoNumber = cc.qudb.getQuoNumber("");
                String[] doc1 = qu.QuoNumber.Split('-');
                qu.QuoNumber = doc1[0];
                qu.QuoNumberCnt = doc1[1];
            }
            else
            {
                String[] doc1 = qu.QuoNumber.Split('-');
                qu.QuoNumber = doc1[0];
                if (qu.NetTotal.Equals(oldNetTotal))
                {
                    qu.QuoNumberCnt = doc1[1];
                }
                else
                {
                    qu.QuoNumberCnt = String.Concat(int.Parse(doc1[1])+1);
                }
            }
            quId = cc.qudb.insertQuotation(qu);
            if (quId.Length >= 1)
            {
                for (int i = 0; i < dgvAdd.RowCount; i++)
                {
                    
                    if (dgvAdd[colAmount, i].Value == null)
                    {
                        continue;
                    }
                    if (dgvAdd[colAmount, i].Value.ToString().Equals(""))
                    {
                        continue;
                    }
                    if (dgvAdd[colItemId, i].Value.ToString().Equals(""))
                    {
                        continue;
                    }
                    QuotationItem qui = new QuotationItem();
                    Item it = cc.itdb.selectByPk(dgvAdd[colItemId, i].Value.ToString());
                    ItemGroup itg = cc.itgdb.selectByPk(it.ItemGroupId);
                    qui.RowNumber = dgvAdd[colRow, i].Value.ToString();
                    qui.PriceSale = cc.cf.NumberNull1(dgvAdd[colPrice, i].Value.ToString());
                    qui.Qty = cc.cf.NumberNull1(dgvAdd[colQty, i].Value.ToString());
                    qui.Amount = cc.cf.NumberNull1(dgvAdd[colAmount, i].Value.ToString());
                    qui.ItemDescription = dgvAdd[colItem, i].Value.ToString();
                    qui.MethodDescription = dgvAdd[colMethod, i].Value.ToString();
                    qui.ItemId = dgvAdd[colItemId, i].Value.ToString();
                    qui.MethodId = dgvAdd[colMethodId, i].Value.ToString();
                    qui.Id = dgvAdd[colId, i].Value.ToString();
                    qui.Active = "1";
                    qui.QuoId = quId;
                    qui.ItemGroupId = itg.Id;
                    qui.ItemGroupNameT = itg.NameT;
                    qui.ItemGroupNameE = itg.NameE;

                    if (dgvAdd[colDel, i].Value.ToString().Equals("1"))
                    {
                        cc.quidb.VoidQuotationItem(dgvAdd[colId, i].Value.ToString());
                    }
                    else
                    {
                        cc.quidb.insertQuotationItem(qui);
                    }
                    
                }
                Quotation qu1 = cc.qudb.selectByPk(quId);
                txtQuNumber.Text = qu1.QuoNumber+"-"+qu1.QuoNumberCnt;
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                btnPrint.Visible = true;
                //this.Dispose();
                //this.Hide();
            }
            Cursor.Current = cursor;
        }
        private void calItemAmount()
        {
            txtItemAmount.Text = String.Format("{0:#,###,###.00}", (Double.Parse(cc.cf.NumberNull1(txtItemQty.Text)) * Double.Parse(cc.cf.NumberNull1(txtItemPrice.Text))));
            //txtItemAmount.Text = String.Concat(Double.Parse(cc.cf.NumberNull1(txtItemQty.Text)) * Double.Parse(cc.cf.NumberNull1(txtItemPrice.Text)));
        }

        private void cboCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer cu = new Customer();
            if (!pageLoad)
            {
                cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
                txtCustId.Text = cu.Id;
                txtCustAddress.Text = cu.AddressT;
                txtCustEmail.Text = cu.Email;
                txtCustFax.Text = cu.Fax;
                txtCustTel.Text = cu.Tele;
                cboContact.Text = cu.ContactName1;
            }
        }
        private void clearItem()
        {
            txtRow.Text = "";
            txtItemQty.Text = "";
            txtItemPrice.Text = "";
            cboItem.Text = "";
            txtItemAmount.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int row = 0;
            Item it = new Item();
            if (txtRow.Text.Equals(""))
            {
                row = dgvAdd.Rows.Add(1);
            }
            else
            {
                try
                {
                    row = int.Parse(txtRow.Text)-1;
                    dgvAdd.Rows[row].DefaultCellStyle.BackColor = Color.DeepPink;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ไม่พบข้อมูล ลำดับ", "Error");
                    return;
                }
            }
            it = cc.itdb.selectByPk(cc.getValueCboItem(cboItem));
            if (it.Id.Equals(""))
            {
                return;
            }
            dgvAdd[colRow, row].Value = (row + 1);
            dgvAdd[colItemId, row].Value = it.Id;
            dgvAdd[colMethodId, row].Value = it.MethodId;
            dgvAdd[colItem, row].Value = it.NameT;
            dgvAdd[colMethod, row].Value = it.MethodNameT;
            dgvAdd[colQty, row].Value = String.Format("{0:#,###,###.00}",txtItemQty.Text);
            dgvAdd[colPrice, row].Value = String.Format("{0:#,###,###.00}",Double.Parse(txtItemPrice.Text));
            dgvAdd[colAmount, row].Value = String.Format("{0:#,###,###.00}",txtItemAmount.Text);
            dgvAdd[colId, row].Value = "";
            dgvAdd[colDel, row].Value = "";
            dgvAdd[colEdit, row].Value = "";
            calAmount();
            calNetTotal();

            clearItem();
        }

        private void dgvAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pageLoad = true;
            txtRow.Text = dgvAdd[colRow, e.RowIndex].Value.ToString();
            txtItemPrice.Text = dgvAdd[colPrice, e.RowIndex].Value.ToString();
            txtItemQty.Text = dgvAdd[colQty, e.RowIndex].Value.ToString();
            txtItemAmount.Text = dgvAdd[colAmount, e.RowIndex].Value.ToString();
            cboItem.SelectedItem = cc.setCboItem(cboItem, dgvAdd[colItemId, e.RowIndex].Value.ToString());
            //cboMethod.Text = dgvAdd[colMethod, e.RowIndex].Value.ToString();
            pageLoad = false;
        }

        private void txtItemPrice_Leave(object sender, EventArgs e)
        {
            calItemAmount();
            btnAdd.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtRow.Text.Equals(""))
            {
                return;
            }
            dgvAdd[colDel, (int.Parse(txtRow.Text)-1)].Value = "1";
            dgvAdd.Rows[(int.Parse(txtRow.Text)-1)].DefaultCellStyle.BackColor = Color.DarkGray;
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            calNetTotal();
        }

        private void txtPlus1_Leave(object sender, EventArgs e)
        {
            calNetTotal();
        }

        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            FrmItemAdd frm = new FrmItemAdd("", cc);
            frm.ShowDialog(this);
            cboItem = cc.itdb.getCboItemQuotation(cboItem);
        }

        private void cboComp_Enter(object sender, EventArgs e)
        {
            cboComp.BackColor = Color.LightYellow;
        }

        private void cboComp_Leave(object sender, EventArgs e)
        {
            cboComp.BackColor = Color.White;
        }

        private void txtCompAddress1_Enter(object sender, EventArgs e)
        {
            txtCompAddress1.BackColor = Color.LightYellow;
        }

        private void txtCompAddress1_Leave(object sender, EventArgs e)
        {
            txtCompAddress1.BackColor = Color.White;
        }

        private void txtCompAddress2_Enter(object sender, EventArgs e)
        {
            txtCompAddress2.BackColor = Color.LightYellow;
        }

        private void txtCompAddress2_Leave(object sender, EventArgs e)
        {
            txtCompAddress2.BackColor = Color.White;
        }

        private void txtCompTaxId_Enter(object sender, EventArgs e)
        {
            txtCompTaxId.BackColor = Color.LightYellow;
        }

        private void txtCompTaxId_Leave(object sender, EventArgs e)
        {
            txtCompTaxId.BackColor = Color.White;
        }

        private void cboCust_Enter(object sender, EventArgs e)
        {
            cboCust.BackColor = Color.LightYellow;
        }

        private void cboCust_Leave(object sender, EventArgs e)
        {
            cboCust.BackColor = Color.White;
        }

        private void cboContact_Enter(object sender, EventArgs e)
        {
            cboContact.BackColor = Color.LightYellow;
        }

        private void cboContact_Leave(object sender, EventArgs e)
        {
            cboContact.BackColor = Color.White;
        }

        private void txtCustAddress_Enter(object sender, EventArgs e)
        {
            txtCustAddress.BackColor = Color.LightYellow;
        }

        private void txtCustAddress_Leave(object sender, EventArgs e)
        {
            txtCustAddress.BackColor = Color.White;
        }

        private void txtCustTel_Enter(object sender, EventArgs e)
        {
            txtCustTel.BackColor = Color.LightYellow;
        }

        private void txtCustTel_Leave(object sender, EventArgs e)
        {
            txtCustTel.BackColor = Color.White;
        }

        private void txtCustFax_Enter(object sender, EventArgs e)
        {
            txtCustFax.BackColor = Color.LightYellow;
        }

        private void txtCustFax_Leave(object sender, EventArgs e)
        {
            txtCustFax.BackColor = Color.White;
        }

        private void txtCustEmail_Enter(object sender, EventArgs e)
        {
            txtCustEmail.BackColor = Color.LightYellow;
        }

        private void txtCustEmail_Leave(object sender, EventArgs e)
        {
            txtCustEmail.BackColor = Color.White;
        }

        private void cboItem_Enter(object sender, EventArgs e)
        {
            cboItem.BackColor = Color.LightYellow;
        }

        private void cboItem_Leave(object sender, EventArgs e)
        {
            cboItem.BackColor = Color.White;
        }

        private void txtItemQty_Enter(object sender, EventArgs e)
        {
            txtItemQty.BackColor = Color.LightYellow;
        }

        private void txtItemQty_Leave(object sender, EventArgs e)
        {
            txtItemQty.BackColor = Color.White;
            calItemAmount();
        }

        private void txtItemPrice_Enter(object sender, EventArgs e)
        {
            txtItemPrice.BackColor = Color.LightYellow;
        }

        private void cboRemark1_Enter(object sender, EventArgs e)
        {
            cboRemark1.BackColor = Color.LightYellow;
        }

        private void cboRemark1_Leave(object sender, EventArgs e)
        {
            cboRemark1.BackColor = Color.White;
        }

        private void cboRemark2_Enter(object sender, EventArgs e)
        {
            cboRemark2.BackColor = Color.LightYellow;
        }

        private void cboRemark2_Leave(object sender, EventArgs e)
        {
            cboRemark2.BackColor = Color.White;
        }

        private void cboRemark3_Enter(object sender, EventArgs e)
        {
            cboRemark3.BackColor = Color.LightYellow;
        }

        private void cboRemark3_Leave(object sender, EventArgs e)
        {
            cboRemark3.BackColor = Color.White;
        }

        private void cboStaff_Enter(object sender, EventArgs e)
        {
            cboStaff.BackColor = Color.LightYellow;
        }

        private void cboStaff_Leave(object sender, EventArgs e)
        {
            cboStaff.BackColor = Color.White;
        }

        private void txtStaffTel_Enter(object sender, EventArgs e)
        {
            txtStaffTel.BackColor = Color.LightYellow;
        }

        private void txtStaffTel_Leave(object sender, EventArgs e)
        {
            txtStaffTel.BackColor = Color.White;
        }

        private void cboStaffApprove_Enter(object sender, EventArgs e)
        {
            cboStaffApprove.BackColor = Color.LightYellow;
        }

        private void cboStaffApprove_Leave(object sender, EventArgs e)
        {
            cboStaffApprove.BackColor = Color.White;
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            txtDiscount.BackColor = Color.LightYellow;
        }

        private void txtPlus1_Enter(object sender, EventArgs e)
        {
            txtPlus1.BackColor = Color.LightYellow;
        }

        private void txtStaffEmail_Enter(object sender, EventArgs e)
        {
            txtStaffEmail.BackColor = Color.LightYellow;
        }

        private void txtStaffEmail_Leave(object sender, EventArgs e)
        {
            txtStaffEmail.BackColor = Color.White;
        }

        private void txtItemQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Item it = cc.itdb.selectByPk(cc.getValueCboItem(cboItem));
                txtItemPrice.Text = it.PriceSale;
                txtItemQty.Text = "1.00";
                calItemAmount();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            String sql = "";
            //OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = cc.qudb.selectPrintById1(txtQuId.Text);
            Quotation qu = cc.qudb.selectByPk(txtQuId.Text);
            //DataTable dtqu = cc.qudb.selectPrintById(txtQuId.Text);
            //DataTable dtqui = cc.quidb.selectByQuId(txtQuId.Text);
            //DataSet ds = new DataSet();
            //ds.Tables.Add(dtqu);
            //ds.Tables.Add(dtqui);
            //cc.conn.f
            //dat
            FrmReport frm = new FrmReport(cc);
            frm.setReportQuotation(qu,dt);
            frm.ShowDialog(this);
        }

    }
}
