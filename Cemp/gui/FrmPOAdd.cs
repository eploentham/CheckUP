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
    public partial class FrmPOAdd : Form
    {
        CnviControl cc;
        PO po;
        Company cp;
        Boolean pageLoad = false;
        int colRow = 0, colItemCode = 1, colItemId = 2, colDesc = 3, colPrice = 4, colQty = 5, colAmt = 6, colRemark = 7, colId = 8, colDel = 9;
        int colCnt = 10;
        int row = 0;
        public FrmPOAdd(String poId,CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig(poId);
        }
        private void initConfig(String poId)
        {
            po = new PO();
            cp = cc.cpdb.selectByPk();
            txtVatRate.Text = cp.vat;
            txtVatRate.ReadOnly = true;
            txtVat.ReadOnly = true;
            txtAmount.ReadOnly = true;
            txtNetTotal.ReadOnly = true;
            txtDueDate.ReadOnly = true;
            dtpDatePO.Format = DateTimePickerFormat.Short;
            cboComp = cc.cpdb.getCboCompany(cboComp);
            cboCust = cc.cudb.getCboVendor(cboCust);
            cboStaff = cc.sfdb.getCboStaff(cboStaff);
            cboStaffApprove = cc.sfdb.getCboStaff(cboStaffApprove);
            cboRemark1 = cc.podb.getCboRemark1(cboRemark1);
            cboRemark2 = cc.podb.getCboRemark2(cboRemark2);
            cboRemark3 = cc.podb.getCboRemark3(cboRemark3);
            cboRemark4 = cc.podb.getCboRemark4(cboRemark4);
            cboRemark5 = cc.podb.getCboRemark5(cboRemark5);
            setGrd();
            setControl(poId);
            
            btnUnActive.Visible = false;
        }
        private void setControl(String poId)
        {
            po = cc.podb.selectByPk(poId);

            if (po.Id.Equals(""))
            {
                if (cboComp.Items.Count == 1)
                {
                    cboComp.Text = cp.NameT;
                    //txtCompId.Text = cp.Id;
                    txtCpAddress1.Text = cp.AddressT;
                    txtCpAddress2.Text = "TEL. " + cp.Tele + " FAX. " + cp.Fax + " Email : " + cp.Email;
                    txtCpTaxId.Text = cp.Spec1 + " เลขประจำตัวผู้เสียภาษีอากร" + cp.TaxId;
                    txtVatRate.Text = cp.vat;
                }
                //txtLine1.Text = cc.initC.quoLine1;
                //txtLine2.Text = cc.cp.quLine2;
                //txtLine3.Text = cc.initC.quoLine3;
                //txtLine4.Text = cc.cp.quLine4;
                //txtLine5.Text = cc.cp.quLine5;
                //txtLine6.Text = cc.cp.quLine6;

                nuDDuePeriod.Value = 30;
                btnPrintT.Visible = false;
            }
            else
            {
                txtPOId.Text = po.Id;
                txtPONumber.Text = po.PONumber + "-" + po.PONumberCnt;
                cboComp.Text = po.CpNameT;
                txtCpAddress1.Text = po.CpAddress1;
                txtCpAddress2.Text = po.CpAddress2;
                txtCpTaxId.Text = po.CpTaxId;
                txtCpTaxId.Text = po.CpTaxId;

                cboCust.Text = po.CuNameT;
                txtCustAddress.Text = po.CuAddressT;
                txtCustEmail.Text = po.CuEmail;
                txtCustFax.Text = po.CuFax;
                txtCustTel.Text = po.CuTel;

                txtAmount.Text = String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(po.Amt)));
                txtVat.Text = String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(po.Vat)));
                txtVatRate.Text = String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(po.VatRate)));
                txtNetTotal.Text = String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(po.NetTotal)));
                cboStaffApprove.Text = po.SfApproveName;
                cboStaff.Text = po.SfName;
                txtStaffTel.Text = po.SfTel;

                cboRemark1.Text = po.Remark1;
                cboRemark2.Text = po.Remark2;
                cboRemark3.Text = po.Remark3;
                cboRemark4.Text = po.Remark4;
                cboRemark5.Text = po.Remark5;

                txtDueDate.Text = cc.cf.dateDBtoShow(po.PODueDate);
                nuDDuePeriod.Value = int.Parse(po.PODuePeriod);

                setGrd(poId);
                btnPrintT.Visible = true;
            }
            try
            {
                if (!po.PODate.Equals(""))
                {
                    dtpDatePO.Value = DateTime.Parse(cc.cf.dateDBtoShow1(po.PODate));
                }
                else
                {
                    dtpDatePO.Value = DateTime.Now;
                }

            }
            catch (Exception ex)
            {
                dtpDatePO.Value = DateTime.Parse(cc.cf.dateDBtoShow(po.PODate));
            }
            chkActive.Checked = true;
        }
        private Boolean getPO()
        {
            Boolean chk = true; ;
            po.Active = "1";
            po.ContactName = "";
            po.CpId = cc.getValueCboItem(cboComp);
            po.CpNameT = cboComp.Text;
            po.CpAddress1 = txtCpAddress1.Text;
            po.CpAddress2 = txtCpAddress2.Text;
            po.CpTaxId = txtCpTaxId.Text;

            po.CuFax = txtCustFax.Text;
            po.CuId = cc.getValueCboItem(cboCust);
            po.CuNameT = cboCust.Text;
            po.CuEmail = txtCustEmail.Text;
            po.CuTel = txtCustTel.Text;
            po.CuAddressT = txtCustAddress.Text;
            po.Id = txtPOId.Text;
            po.PODate = "";
            po.PODate = cc.cf.datetoDB(dtpDatePO.Value);
            po.PODuePeriod = "";
            po.PONumber = txtPONumber.Text;
            po.PONumberCnt = "";
            po.QuId = "";
            po.QuNumber = "";

            String[] doc1 = txtPONumber.Text.Split('-');
            if (doc1.Length > 1)
            {
                po.PONumber = doc1[0];
                po.PONumberCnt = doc1[1];
            }
            else
            {
                chk = false;
            }            

            po.SfEmail = "";
            po.SfId = cc.getValueCboItem(cboStaff);
            po.SfName = cboStaff.Text;
            po.SfTel = txtStaffTel.Text;
            po.SfApproveId = cc.getValueCboItem(cboStaffApprove);
            po.SfApproveName = cboStaffApprove.Text;

            po.Remark1 = cboRemark1.Text;
            po.Remark2 = cboRemark2.Text;
            po.Remark3 = cboRemark3.Text;
            po.Remark4 = cboRemark4.Text;
            po.Remark5 = cboRemark5.Text;

            po.Amt = txtAmount.Text.Replace(",","");
            po.VatRate = txtVatRate.Text.Replace(",", "");
            po.Vat = txtVat.Text.Replace(",", "");
            po.NetTotal = txtNetTotal.Text.Replace(",", "");

            po.PODuePeriod = nuDDuePeriod.Value.ToString();
            po.PODueDate = cc.cf.datetoDBChk25(txtDueDate.Text);
            return chk;
        }
        private void setGrd()
        {
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colItemCode].Width = 80;
            dgvAdd.Columns[colDesc].Width = 300;
            dgvAdd.Columns[colPrice].Width = 80;
            dgvAdd.Columns[colQty].Width = 80;
            dgvAdd.Columns[colRemark].Width = 150;
            dgvAdd.Columns[colId].Width = 120;
            dgvAdd.Columns[colAmt].Width = 100;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItemCode].HeaderText = "รหัส";
            dgvAdd.Columns[colDesc].HeaderText = "รายการ";
            dgvAdd.Columns[colPrice].HeaderText = "ราคา";
            dgvAdd.Columns[colQty].HeaderText = "จำนวน";
            dgvAdd.Columns[colRemark].HeaderText = "หมายเหตุ";
            dgvAdd.Columns[colAmt].HeaderText = "รวม";
            //dgvAdd.Columns[colMOUNumber].HeaderText = "เลขที่";
            dgvAdd.Columns[colId].HeaderText = "  ";

            dgvAdd.Columns[colPrice].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAdd.Columns[colQty].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvAdd.Columns[colPlace].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAdd.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvAdd.Font = font;
            dgvAdd.Columns[colId].Visible = false;
            dgvAdd.Columns[colDel].Visible = false;
            dgvAdd.Columns[colItemId].Visible = false;
            //dgvAdd.Columns[colSample].ReadOnly = true;
            //dgvAdd.Columns[colMethod].ReadOnly = true;
            //dgvAdd.Columns[colItem].ReadOnly = true;
            dgvAdd.Columns[colRow].ReadOnly = true;
            //dgvAdd.EditMode = DataGridViewEditMode.EditOnF2;
            dgvAdd.AllowUserToAddRows = false;
            DgvAddRow();
            dgvAdd.Rows[row].Cells[colItemCode].Selected = true;
            dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItemCode];
        }
        private void setGrd(String poId)
        {
            setGrd();
            DataTable dt = cc.poidb.selectByPoId(poId);

            //DataTable dt = new DataTable();
            //dt = cc.sfdb.selectAll();
            dgvAdd.RowCount = dt.Rows.Count + 1;
            //dgvAdd.Columns.Add(newColumn);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dgvAdd.Rows[0].Cells = newColumn;
                    //DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(dgvAdd.Rows[i].Cells[colItem]);
                    //cell.DataSource = newColumn;
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colItemCode, i].Value = dt.Rows[i][cc.poidb.poi.ItemCode].ToString();
                    dgvAdd[colItemId, i].Value = dt.Rows[i][cc.poidb.poi.ItemId].ToString();
                    dgvAdd[colDesc, i].Value = dt.Rows[i][cc.poidb.poi.ItemNameT].ToString();
                    dgvAdd[colPrice, i].Value = dt.Rows[i][cc.poidb.poi.ItemPrice].ToString();
                    dgvAdd[colQty, i].Value = dt.Rows[i][cc.poidb.poi.ItemQty].ToString();
                    dgvAdd[colRemark, i].Value = dt.Rows[i][cc.poidb.poi.Remark].ToString();
                    dgvAdd[colAmt, i].Value = dt.Rows[i][cc.poidb.poi.ItemAmount].ToString();
                    //dgvAdd[colMethodId, i].Value = dt.Rows[i][cc.moidb.moi.MethodId].ToString();
                    dgvAdd[colId, i].Value = dt.Rows[i][cc.poidb.poi.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.F1:

                    FrmPOItemSearch frm = new FrmPOItemSearch(cc);

                    return true; // signal that we've processed this key
                //case Keys.Insert:
                //    //txtInputFocus();
                //    return true;
            }
            // run base implementation
            return base.ProcessCmdKey(ref message, keys);
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 80;
            //groupBox3.Left = dgvAdd.Width - groupBox3.Width - 50;
            //btnSave.Left = dgvAdd.Width - 80;
            //btnPrintMou.Left = btnSave.Left;
            //btnReceive.Left = btnSave.Left;
            //groupBox2.Left = this.Width - groupBox2.Width - btnSave.Width - 150;

            //panel1.Top = this.Height - panel1.Height - 50;
            //dgvAdd.Height = this.Height - groupBox2.Top - groupBox2.Height - panel1.Height - 50 - 5;
            //groupBox3.Left = groupBox2.Left;
            //groupBox1.Height = this.Height = 150;
        }
        private void calAmount(int row)
        {
            dgvAdd[colAmt, row].Value = String.Format("{0:#,###,###.00}", (Double.Parse(dgvAdd[colPrice, row].Value.ToString()) * Double.Parse(dgvAdd[colQty, row].Value.ToString())));
            //txtItemAmount.Text = String.Concat(Double.Parse(cc.cf.NumberNull1(txtItemQty.Text)) * Double.Parse(cc.cf.NumberNull1(txtItemPrice.Text)));
        }
        private void calNetTotal()
        {
            Double amt = 0, amtDis = 0, total = 0, netTotal = 0, vat = 0, plus = 0;
            amt = Double.Parse(cc.cf.NumberNull1(txtAmount.Text.Replace(",", "")));
            //amtDis = amt - Double.Parse(cc.cf.NumberNull1(txtDiscount.Text.Replace(",", "")));
            //total = amtDis + Double.Parse(cc.cf.NumberNull1(txtPlus1.Text.Replace(",", "")));
            vat = (amt * Double.Parse(cc.cf.NumberNull1(txtVatRate.Text.Replace(",", ""))) / 100);
            netTotal = amt + vat;
            //txtPlus1.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull1(txtPlus1.Text)));
            //txtAmountDiscount.Text = String.Format("{0:#,###,###.00}", amtDis);
            //txtTotal.Text = String.Format("{0:#,###,###.00}", total);
            txtVat.Text = String.Format("{0:#,###,###.00}", vat);
            txtNetTotal.Text = String.Format("{0:#,###,###.00}", netTotal);
        }
        private void calAmount()
        {
            Double amt = 0, amtCost = 0;
            String amt1 = "";
            for (int i = 0; i < dgvAdd.Rows.Count; i++)
            {
                if (dgvAdd[colAmt, i].Value == null)
                {
                    continue;
                }
                if (dgvAdd[colAmt, i].Value.ToString().Equals(""))
                {
                    continue;
                }
                if (dgvAdd[colDel, i].Value == null)
                {
                    dgvAdd[colDel, i].Value = "";
                }
                if (!dgvAdd[colDel, i].Value.ToString().Equals("1"))
                {
                    amt += Double.Parse(cc.cf.NumberNull1(dgvAdd[colAmt, i].Value.ToString().Replace(",", "")));
                    //amtCost += (Double.Parse(cc.cf.NumberNull1(dgvAdd[colPrice, i].Value.ToString().Replace(",", ""))) *
                    //    Double.Parse(cc.cf.NumberNull1(dgvAdd[colQty, i].Value.ToString().Replace(",", ""))));
                }
            }
            txtAmount.Text = String.Format("{0:#,###,###.00}", amt);
            //txtAmountCost.Text = String.Format("{0:#,###,###.00}", amtCost);
        }
        private void DgvAddRow()
        {
            row = dgvAdd.Rows.Add();
            dgvAdd[colDel, row].Value = "";
            dgvAdd[colId, row].Value = "";
            dgvAdd[colItemCode, row].Value = "";
            dgvAdd[colItemId, row].Value = "";
            dgvAdd[colDesc, row].Value = "";
            dgvAdd[colRemark, row].Value = "";
            dgvAdd[colQty, row].Value = "";
            dgvAdd[colPrice, row].Value = "";
            dgvAdd[colAmt, row].Value = "";
            dgvAdd[colRow, row].Value = (row + 1);
            if ((row % 2) != 0)
            {
                dgvAdd.Rows[row].DefaultCellStyle.BackColor = Color.LightSalmon;
            }
        }
        private void setDueDate()
        {
            DateTimePicker dp = new DateTimePicker();
            dp.Format = DateTimePickerFormat.Short;
            dp.Value = dtpDatePO.Value;
            dp.Value = dp.Value.AddDays(int.Parse(nuDDuePeriod.Value.ToString()));
            //txtDueDate.Text = cc.cf.dateDBtoShow(dp.Value.Day.ToString("00") + "-" + dp.Value.Month.ToString("00") + "-" + dp.Value.Year);
            txtDueDate.Text = cc.cf.dateDBtoShow25(cc.cf.datetoDBChk25(dp.Value));
        }
        private void FrmPOAdd_Load(object sender, EventArgs e)
        {

        }

        private void cboCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Customer cu = new Customer();
                cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
                //txtCustId.Text = cu.Id;
                txtCustAddress.Text = cu.AddressT;
                txtCustEmail.Text = cu.Email;
                txtCustFax.Text = cu.Fax;
                txtCustTel.Text = cu.Tele;
                nuDDuePeriod.Value = int.Parse(cc.cf.NumberNull1(cu.PODuePeriod));
                //setDueDate();
                //cboContact.Text = cu.ContactName1;
            }
        }

        private void dgvAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colItemCode)
            {

            }
            //if (e.ColumnIndex == colRemark)
            //{
                
            //    row = dgvAdd.Rows.Add();
            //    dgvAdd.Rows[row].Cells[colItem].Selected = true;
            //    dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItem];
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chkdel = false;
            String poId = "";
            //if (txtQuNumber.Text.Equals(""))
            //{
            //    MessageBox.Show("ไม่มีเลขที่ Quotation", "ป้อนข้อมูลไม่ครบ");
            //    return;
            //}
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
            //if (cboContact.Text.Equals(""))
            //{
            //    MessageBox.Show("ไม่มี ชื่อผู้ติดต่อ", "ป้อนข้อมูลไม่ครบ");
            //    return;
            //}
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
            if (!getPO())
            {
                MessageBox.Show("get Object PO ไม่ได้", "Error");
                return;
            }
            if (po.Id.Equals(""))
            {
                po.PONumber = cc.podb.getPONumber();
                //String[] doc1 = qu.QuoNumber.Split('-');
                //qu.QuoNumber = doc1[0];
                po.PONumberCnt = "1";
            }
            else
            {
                //String[] doc1 = po.PONumber.Split('-');
                //qu.QuoNumber = doc1[0];
                //if (qu.NetTotal.Equals(oldNetTotal))
                //{
                //    qu.QuoNumberCnt = doc1[1];
                //}
                //else
                //{
                po.PONumberCnt = String.Concat(int.Parse(po.PONumberCnt) + 1);
                //}
            }
            poId = cc.podb.insertPO(po);
            if (poId.Length >= 1)
            {
                for (int i = 0; i < dgvAdd.RowCount; i++)
                {
                    if (dgvAdd[colAmt, i].Value == null)
                    {
                        continue;
                    }
                    if (dgvAdd[colAmt, i].Value.ToString().Equals(""))
                    {
                        continue;
                    }
                    if (dgvAdd[colDesc, i].Value.ToString().Equals(""))
                    {
                        continue;
                    }
                    POItem poi = new POItem();
                    poi.RowNumber = dgvAdd[colRow, i].Value.ToString();
                    poi.Active = "1";
                    poi.Id = dgvAdd[colId, i].Value.ToString();
                    poi.ItemAmount = dgvAdd[colAmt, i].Value.ToString().Replace(",", "");
                    poi.ItemId = dgvAdd[colItemId, i].Value.ToString();
                    poi.ItemNameT=dgvAdd[colDesc, i].Value.ToString();
                    poi.ItemPrice = dgvAdd[colPrice, i].Value.ToString().Replace(",", "");
                    poi.ItemQty = dgvAdd[colQty, i].Value.ToString().Replace(",","");
                    poi.Remark = dgvAdd[colRemark, i].Value.ToString();
                    poi.ItemCode = dgvAdd[colItemCode, i].Value.ToString();
                    poi.POId = poId;
                    cc.poidb.insertPOItem(poi);
                }
                PO po1 = cc.podb.selectByPk(poId);
                txtPONumber.Text = po1.PONumber + "-" + po1.PONumberCnt;
                txtPOId.Text = poId;
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            }
            Cursor.Current = cursor;
        }

        private void dgvAdd_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == colItemCode)
                {
                    dgvAdd.Rows[e.RowIndex].Cells[colDesc].Selected = true;
                    dgvAdd.CurrentCell = dgvAdd[colDesc, e.RowIndex];
                    //dgvAdd.BeginEdit(true);
                }
                else if (e.ColumnIndex == colDesc)
                {
                    dgvAdd.Rows[e.RowIndex].Cells[colPrice].Selected = true;
                    dgvAdd.CurrentCell = dgvAdd.Rows[e.RowIndex].Cells[colPrice];
                }
                else if (e.ColumnIndex == colPrice)
                {
                    dgvAdd.Rows[e.RowIndex].Cells[colQty].Selected = true;
                    dgvAdd.CurrentCell = dgvAdd.Rows[e.RowIndex].Cells[colQty];
                }
                else if (e.ColumnIndex == colQty)
                {
                    //dgvAdd.Rows[e.RowIndex].Cells[colRemark].Selected = true;
                    //dgvAdd.CurrentCell = dgvAdd.Rows[e.RowIndex].Cells[colRemark];
                    calAmount(e.RowIndex);
                    calAmount();
                    calNetTotal();
                    DgvAddRow();
                    dgvAdd.Rows[row].Cells[colItemCode].Selected = true;
                    dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItemCode];
                }
                else if (e.ColumnIndex == colRemark)
                {
                    //row = dgvAdd.Rows.Add();
                    //dgvAdd.Rows[row].Cells[colItem].Selected = true;
                    //dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItem];
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void FrmPOAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void dgvAdd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == colRemark)
            //{
            //    row = dgvAdd.Rows.Add();
            //    dgvAdd.Rows[row].Cells[colItem].Selected = true;
            //    dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItem];
            //}
        }

        private void dgvAdd_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == colPrice) // 1 should be your column index
            {
                Double i;

                if (!Double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    //dgvAdd[colPrice, e.RowIndex].Value = "";
                    e.Cancel = true;
                    //label1.Text = "please enter numeric";
                    MessageBox.Show("Please enter Numeric", "Error");
                    //dgvAdd[colPrice, e.RowIndex].s
                }
                else
                {
                    // the input is numeric 
                }
            }
            else if (e.ColumnIndex == colQty) // 1 should be your column index
            {
                Double i;

                if (!Double.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    //dgvAdd[colPrice, e.RowIndex].Value = "";
                    e.Cancel = true;
                    //label1.Text = "please enter numeric";
                    MessageBox.Show("Please enter Numeric", "Error");
                    //dgvAdd[colPrice, e.RowIndex].s
                }
                else
                {
                    // the input is numeric 
                }
            }
        }

        private void btnPrintT_Click(object sender, EventArgs e)
        {
            String sql = "";
            //OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = cc.poidb.selectByPoId(txtPOId.Text);
            PO po = cc.podb.selectByPk(txtPOId.Text);
            //po.ContactName = "เรียน : " + po.ContactName;
            po.CuAddressT = "ที่อยู่ : " + po.CuAddressT;
            po.CuTel = "เบอร์โทร : " + po.CuTel + " Email : " + po.CuEmail;
            po.Line1 = cc.cp.poLine1;
            po.PONumber = "เลขที่ : " + po.PONumber + "-" + po.PONumberCnt;
            //po.QuoDate = "วันที่ :" + po.QuoDate;
            //po.SfNameT = "ผู้เสนอราคา :" + po.StaffName;
            //po.StaffTel = "เบอร์โทร : " + po.StaffTel;
            //po.StaffEmail = "Email : " + po.StaffEmail;
            po.Remark1 = "1. " + po.Remark1;
            po.Remark2 = "2. " + po.Remark2;
            po.Remark3 = "3. " + po.Remark3;
            po.Remark4 = "4. " + po.Remark4;
            po.Remark5 = "5. " + po.Remark5;
            //po.Remark6 = "6. " + po.Remark6;
            //po.Remark7 = "7. " + po.Remark7;
            //po.ThaiBaht = cc.ThaiBaht(po.NetTotal);
            ////qu.Amount = "รวมราคา " + qu.Amount;
            ////qu.Discount = "ส่วนลด " + qu.Amount;
            ////DataTable dtqu = cc.qudb.selectPrintById(txtQuId.Text);
            ////DataTable dtqui = cc.quidb.selectByQuId(txtQuId.Text);
            ////DataSet ds = new DataSet();
            ////ds.Tables.Add(dtqu);
            ////ds.Tables.Add(dtqui);
            ////cc.conn.f
            ////dat
            FrmReport frm = new FrmReport(cc);
            frm.setReportPO(po, dt);
            frm.ShowDialog(this);
        }

        private void nuDDuePeriod_ValueChanged(object sender, EventArgs e)
        {
            setDueDate();
        }

        private void dtpDatePO_ValueChanged(object sender, EventArgs e)
        {
            setDueDate();
        }
    }
}
