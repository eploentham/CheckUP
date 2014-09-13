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
    public partial class FrmMOUAdd : Form
    {
        CnviControl cc;
        MOU mo;
        Quotation qu;
        int colRow = 0, colItem = 1, colMethod = 2, colSample = 3, colPlace = 4, colId = 5, colDel = 6, colItemId = 7, colMethodId = 8, colEdit = 9;
        int colCnt = 10;
        Boolean pageLoad = false;
        public FrmMOUAdd(String moNumber, CnviControl c)
        {
            InitializeComponent();
            initConfig(moNumber,c);
        }
        private void initConfig(String moNumber, CnviControl c)
        {
            pageLoad = true;
            cc = c;
            mo = new MOU();
            qu = new Quotation();
            cboMOU = cc.modb.getCboMOUNumber(cboMOU, moNumber);
            cboQuo = cc.qudb.getCboQuotation(cboQuo);
            pageLoad = false;
        }
        private void setControl(String moId)
        {

            mo = cc.modb.selectByPk(moId);

            cboMOU = cc.modb.getCboMOUNumber(cboMOU, mo.MOUNumber);
            
            cboStaff = cc.sfdb.getCboStaff(cboStaff);
            cboStaffMOU = cc.sfdb.getCboStaff(cboStaffMOU);
            cboItem = cc.itdb.getCboItemQuotation(cboItem);
            //cboContact = cc.cudb.getCboCustomer(cboContact);

            txtContactName.Text = mo.ContactName;
            txtCustAddress.Text = mo.CustAddress;
            txtCustEmail.Text = mo.CustEmail;
            txtCustId.Text = mo.CustName;
            txtCustMobile.Text = mo.CustMobile;
            txtCustName.Text = mo.CustName;
            txtCustTel.Text = mo.CustTel;
            txtCustMobile.Text = mo.CustMobile;
            cboQuo.Text = cc.getTextCboItem(cboQuo,mo.QuoId);
            CustMou.Text = "";

            txtMOUId.Text = mo.Id;
            txtMouNumber.Text = mo.MOUNumber+"-"+mo.MOUNumberCnt;
            txtStaffEmail.Text = mo.StaffEmail;
            txtStaffMobile.Text = mo.StaffMobile;
            txtStaffTel.Text = mo.StaffTel;
            txtDatePeriod.Text = mo.DatePeriod;
            
            cboStaff.Text = mo.StaffName;
            cboStaffMOU.Text = mo.StaffMOU;
            CustMou.Text = mo.CustMou;

            setGrd(mo.Id);
        }
        private void getMOU()
        {   
            mo.QuoNumber = cboQuo.Text;
            mo.QuoId = cc.getValueCboItem(cboQuo);
            mo.ContactName = txtContactName.Text;
            mo.CustAddress = txtCustAddress.Text;
            mo.CustEmail = txtCustEmail.Text;
            mo.CustMobile = txtCustMobile.Text;
            mo.CustTel = txtCustTel.Text;
            mo.CustName = txtCustName.Text;
            mo.CustId = txtCustId.Text;

            //it.ItemGroupId = cc.getValueCboItem(cboGroup);

            mo.Id = txtMOUId.Text;
            mo.MOUNumber = txtMouNumber.Text;
            mo.DatePeriod = txtDatePeriod.Text;
            mo.StaffMOU = cc.getValueCboItem(cboStaffMOU);
            mo.StaffEmail = txtStaffEmail.Text;
            mo.StaffTel = txtStaffTel.Text;
            mo.StaffId = cc.getValueCboItem(cboStaff);
            mo.StaffName = cboStaff.Text;
            mo.StaffMobile = txtStaffMobile.Text;

            mo.CustMou = CustMou.Text;
            mo.Active = "1";

            qu = cc.qudb.selectByPk(mo.QuoId);
            mo.CompAddress1 = qu.CompAddress1;
            mo.CompAddress2 = qu.CompAddress2;
            mo.CompId = qu.CompId;
            mo.CompName = qu.CompName;
            mo.CompTaxId = qu.CompTaxId;
            //mo.DatePeriod = txtDatePeriod.Text;
            
        }
        private void setGrd(String moId)
        {
            DataTable dt = cc.moidb.selectByMoId(moId);
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
            dgvAdd.Columns[colSample].Width = 120;
            //dgvAdd.Columns[colPrice].Width = 150;
            dgvAdd.Columns[colPlace].Width = 250;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItem].HeaderText = "Parameter";
            dgvAdd.Columns[colMethod].HeaderText = "Method";
            dgvAdd.Columns[colSample].HeaderText = "Sample";
            //dgvAdd.Columns[colPrice].HeaderText = "Price";
            dgvAdd.Columns[colPlace].HeaderText = "สถายที่เก็บตัวอย่าง";
            dgvAdd.Columns[colId].HeaderText = "  ";

            dgvAdd.Columns[colSample].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvAdd.Columns[colPrice].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvAdd.Columns[colPlace].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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
                    dgvAdd[colItem, i].Value = dt.Rows[i][cc.moidb.moi.ItemDescription].ToString();
                    dgvAdd[colMethod, i].Value = dt.Rows[i][cc.moidb.moi.MethodDescription].ToString();
                    dgvAdd[colSample, i].Value = dt.Rows[i][cc.moidb.moi.Sample].ToString();
                    //dgvAdd[colPrice, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.quidb.qui.PriceSale]);
                    dgvAdd[colPlace, i].Value = dt.Rows[i][cc.moidb.moi.PlaceRecord].ToString();
                    dgvAdd[colItemId, i].Value = dt.Rows[i][cc.moidb.moi.ItemId].ToString();
                    dgvAdd[colMethodId, i].Value = dt.Rows[i][cc.moidb.moi.MethodId].ToString();
                    dgvAdd[colId, i].Value = dt.Rows[i][cc.moidb.moi.Id].ToString();
                    dgvAdd[colDel, i].Value = "";
                    dgvAdd[colEdit, i].Value = "";
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 80;
            //groupBox3.Left = dgvAdd.Width - groupBox3.Width - 50;
            btnSave.Left = dgvAdd.Width - 80;
            btnPrintMou.Left = btnSave.Left;
            btnReceive.Left = btnSave.Left;
            groupBox2.Left = this.Width - groupBox2.Width - btnSave.Width - 150;
            //groupBox3.Left = groupBox2.Left;
            //groupBox1.Height = this.Height = 150;
        }
        private void clearItem()
        {
            txtRow.Text = "";
            txtSample.Text = "";
            txtPlaceRecord.Text = "";
            cboItem.Text = "";
            //txtItemAmount.Text = "";
        }

        private void FrmMOUAdd_Load(object sender, EventArgs e)
        {

        }

        private void cboQuo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Cursor cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                qu = cc.qudb.selectByPk(cc.getValueCboItem(cboQuo));
                txtCustName.Text = qu.CustName;
                txtCustId.Text = qu.CustId;
                txtCustAddress.Text = qu.CustAddress;
                txtCustEmail.Text = qu.CustEmail;
                txtCustMobile.Text = "";
                txtCustTel.Text = qu.CustTel;
                txtContactName.Text = qu.ContactName;
                cboStaff.Text = qu.StaffName;
                CustMou.Text = qu.ContactName;
                Cursor.Current = cursor;
            }
        }

        private void FrmMOUAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String moId = "";
            if (txtMouNumber.Text.Equals(""))
            {
                MessageBox.Show("ไม่มีเลขที่ MOU", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (CustMou.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ลูกค้า/ผู้ประสานงาน/ผู้รัลผิดชอบการตรวจ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboQuo.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี เลขที่ Quotation", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtCustName.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ชื่อผู้ติดต่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboStaff.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ผู้รับผิดชอบข้อตกลง", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboStaffMOU.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี เจ้าหน้าที่ผู้ทำการเก็บตัวอย่าง ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            getMOU();
            if (mo.Id.Equals(""))
            {
                mo.MOUNumber = cc.modb.getMOUNumber("");
                String[] doc1 = mo.MOUNumber.Split('-');
                mo.MOUNumber = doc1[0];
                mo.MOUNumberCnt = doc1[1];
            }
            else
            {
                String[] doc1 = mo.MOUNumber.Split('-');
                mo.MOUNumber = doc1[0];
                mo.MOUNumberCnt = cc.modb.selectMaxByNumber(mo.MOUNumber);
            }
            moId = cc.modb.insertMOU(mo);
            if (moId.Length >= 1)
            {
                for (int i = 0; i < dgvAdd.RowCount; i++)
                {
                    if (dgvAdd[colSample, i].Value == null)
                    {
                        continue;
                    }
                    if (dgvAdd[colItemId, i].Value.ToString().Equals(""))
                    {
                        continue;
                    }
                    MOUItem moi = new MOUItem();
                    moi.RowNumber = dgvAdd[colRow, i].Value.ToString();
                    moi.Id = dgvAdd[colId, i].Value.ToString();
                    moi.Active = "1";
                    moi.ItemDescription = dgvAdd[colItem, i].Value.ToString();
                    moi.ItemId = dgvAdd[colItemId, i].Value.ToString();
                    moi.MethodDescription = dgvAdd[colMethod, i].Value.ToString();
                    moi.MethodId = dgvAdd[colMethodId, i].Value.ToString();
                    moi.MOUId = moId;
                    moi.PlaceRecord = dgvAdd[colPlace, i].Value.ToString();
                    moi.Sample = dgvAdd[colSample, i].Value.ToString();
                    if (dgvAdd[colDel, i].Value.ToString().Equals("1"))
                    {
                        cc.moidb.VoidMOUItem(dgvAdd[colId, i].Value.ToString());
                    }
                    else
                    {
                        cc.moidb.insertMOUItem(moi);
                    }
                }
                MOU mo1 = cc.modb.selectByPk(moId);
                txtMouNumber.Text = mo1.MOUNumber + "-" + mo1.MOUNumberCnt;
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                btnPrintMou.Visible = true;
            }
            Cursor.Current = cursor;
        }

        private void cboMOU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Cursor cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                setControl(cc.getValueCboItem(cboMOU));
                Cursor.Current = cursor;
            }
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
                    row = int.Parse(txtRow.Text) - 1;
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
            dgvAdd[colSample, row].Value = txtSample.Text;
            dgvAdd[colPlace, row].Value = txtPlaceRecord.Text;
            //dgvAdd[colAmount, row].Value = String.Format("{0:#,###,###.00}", txtItemAmount.Text);
            dgvAdd[colId, row].Value = "";
            dgvAdd[colDel, row].Value = "";
            dgvAdd[colEdit, row].Value = "";
            //calAmount();
            //calNetTotal();

            clearItem();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtRow.Text.Equals(""))
            {
                return;
            }
            dgvAdd[colDel, (int.Parse(txtRow.Text) - 1)].Value = "1";
            dgvAdd.Rows[(int.Parse(txtRow.Text) - 1)].DefaultCellStyle.BackColor = Color.DarkGray;
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Item it = cc.itdb.selectByPk(cc.getValueCboItem(cboItem));
                //txtItemPrice.Text = it.PriceSale;
                txtSample.Text = "1";
                txtPlaceRecord.Focus();
                //calItemAmount();
            }
        }

        private void btnMOUAdd_Click(object sender, EventArgs e)
        {
            //txtMouNumber.Text = "-";
            txtMOUId.Text = "";
        }

        private void dgvAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pageLoad = true;
            txtRow.Text = dgvAdd[colRow, e.RowIndex].Value.ToString();
            txtPlaceRecord.Text = dgvAdd[colPlace, e.RowIndex].Value.ToString();
            txtSample.Text = dgvAdd[colSample, e.RowIndex].Value.ToString();
            //txtItemAmount.Text = dgvAdd[colAmount, e.RowIndex].Value.ToString();
            cboItem.SelectedItem = cc.setCboItem(cboItem, dgvAdd[colItemId, e.RowIndex].Value.ToString());
            //cboMethod.Text = dgvAdd[colMethod, e.RowIndex].Value.ToString();
            pageLoad = false;
        }
    }
}
