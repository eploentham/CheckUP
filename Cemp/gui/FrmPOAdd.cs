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
        int colRow = 0, colItem = 1, colDesc = 2, colPrice = 3, colQty = 4, colAmt=5, colRemark = 6, colId=7, colDel=8;
        int colCnt = 9;
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
            cboComp = cc.cpdb.getCboCompany(cboComp);
            cboCust = cc.cudb.getCboVendor(cboCust);
            cboStaff = cc.sfdb.getCboStaff(cboStaff);
            cboStaffApprove = cc.sfdb.getCboStaff(cboStaffApprove);
            
            setControl(poId);
            setGrd();
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
                    txtCompAddress1.Text = cp.AddressT;
                    txtCompAddress2.Text = "TEL. " + cp.Tele + " FAX. " + cp.Fax + " Email : " + cp.Email;
                    txtCompTaxId.Text = cp.Spec1 + " เลขประจำตัวผู้เสียภาษีอากร" + cp.TaxId;
                    txtVatRate.Text = cp.vat;
                }
                //txtLine1.Text = cc.initC.quoLine1;
                //txtLine2.Text = cc.cp.quLine2;
                //txtLine3.Text = cc.initC.quoLine3;
                //txtLine4.Text = cc.cp.quLine4;
                //txtLine5.Text = cc.cp.quLine5;
                //txtLine6.Text = cc.cp.quLine6;

                btnPrintT.Visible = false;
            }
            else
            {
                btnPrintT.Visible = true;
            }
        }
        private void setGrd()
        {
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colItem].Width = 350;
            dgvAdd.Columns[colDesc].Width = 350;
            dgvAdd.Columns[colPrice].Width = 80;
            dgvAdd.Columns[colQty].Width = 80;
            dgvAdd.Columns[colRemark].Width = 350;
            dgvAdd.Columns[colId].Width = 120;
            dgvAdd.Columns[colAmt].Width = 100;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItem].HeaderText = "รหัส";
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
            //dgvAdd.Columns[colDel].Visible = false;

            //dgvAdd.Columns[colSample].ReadOnly = true;
            //dgvAdd.Columns[colMethod].ReadOnly = true;
            //dgvAdd.Columns[colItem].ReadOnly = true;
            dgvAdd.Columns[colRow].ReadOnly = true;
            //dgvAdd.EditMode = DataGridViewEditMode.EditOnF2;
            dgvAdd.AllowUserToAddRows = false;
            DgvAddRow();
            dgvAdd.Rows[row].Cells[colItem].Selected = true;
            dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItem];
        }
        private void setGrd(String moNumber)
        {
            setGrd();
            DataTable dt = cc.moidb.selectByMoNumber(moNumber);

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
                    //dgvAdd[colItem, i].Value = dt.Rows[i][cc.moidb.moi.ItemDescription].ToString();
                    //dgvAdd[colMethod, i].Value = dt.Rows[i][cc.moidb.moi.MethodDescription].ToString();
                    //dgvAdd[colSample, i].Value = dt.Rows[i][cc.moidb.moi.Sample].ToString();
                    //dgvAdd[colItemType, i].Value = dt.Rows[i][cc.moidb.moi.ItemType].ToString();
                    //dgvAdd[colPlace, i].Value = dt.Rows[i][cc.moidb.moi.PlaceRecord].ToString();
                    //dgvAdd[colItemId, i].Value = dt.Rows[i][cc.moidb.moi.ItemId].ToString();
                    //dgvAdd[colMethodId, i].Value = dt.Rows[i][cc.moidb.moi.MethodId].ToString();
                    //dgvAdd[colId, i].Value = dt.Rows[i][cc.moidb.moi.Id].ToString();

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
            dgvAdd[colRow, row].Value = (row + 1);
            if ((row % 2) != 0)
            {
                dgvAdd.Rows[row].DefaultCellStyle.BackColor = Color.LightSalmon;
            }
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
                //cboContact.Text = cu.ContactName1;
            }
        }

        private void dgvAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == colItem)
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

        }

        private void dgvAdd_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colItem)
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
                DgvAddRow();
                dgvAdd.Rows[row].Cells[colItem].Selected = true;
                dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItem];
            }
            else if (e.ColumnIndex == colRemark)
            {
                //row = dgvAdd.Rows.Add();
                //dgvAdd.Rows[row].Cells[colItem].Selected = true;
                //dgvAdd.CurrentCell = dgvAdd.Rows[row].Cells[colItem];
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
    }
}
