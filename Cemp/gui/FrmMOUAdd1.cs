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
    public partial class FrmMOUAdd1 : Form
    {
        CnviControl cc;
        MOU mo;
        Quotation qu;
        Staff sf;
        int colRow = 0, colItem = 1, colMethod = 2, colSample = 3, colPlace = 4, colDatePlaceRecord=5, colId = 6, colDel =7, colItemId = 8, colMethodId = 9, colEdit = 10;
        int colCnt = 11;
        Boolean pageLoad = false, mouNew = false, MOUSplit = false;
        DateTimePicker cellDateTimePicker = new DateTimePicker();
        
        public FrmMOUAdd1(String moNumber, CnviControl c)
        {
            InitializeComponent();
            initConfig(moNumber,c);
        }
        private void initConfig(String moNumber, CnviControl c)
        {
            pageLoad = true;
            cellDateTimePicker.ValueChanged += new EventHandler(cellDateTimePickerValueChanged);
            cellDateTimePicker.Visible = false;
            cellDateTimePicker.CustomFormat = "dd/MM/yyyy";
            cellDateTimePicker.Format = DateTimePickerFormat.Custom;
            dgvAdd.Controls.Add(cellDateTimePicker);

            cc = c;
            mo = new MOU();
            qu = new Quotation();
            sf = new Staff();
            cboMOU = cc.modb.getCboMOUNumber(cboMOU, moNumber);
            cboQuo = cc.qudb.getCboQuotation(cboQuo);
            cboStaffPlaceRecord = cc.sfdb.getCboStaff(cboStaffPlaceRecord);
            cboStaffMOU = cc.sfdb.getCboStaff(cboStaffMOU);
            cboItem = cc.itdb.getCboItemQuotation(cboItem);
            txtStaffPlaceRecordPosition.Text = "เจ้าหน้าที่ผู้ทำการเก็บตัวอย่าง";
            setControl("");
            if (!moNumber.Equals(""))
            {
                //MOU mo1 = new MOU();
                String quNumber = cc.modb.selectQuoNumberByNumber(moNumber);
                cboQuo.Text = quNumber;
            }
            pageLoad = false;
        }
        void cellDateTimePickerValueChanged(object sender, EventArgs e)
        {
            dgvAdd.CurrentCell.Value = cellDateTimePicker.Value.ToString("dd/MM/yyyy");
            cellDateTimePicker.Visible = false;
        }
        private void setControl(String moId)
        {
            pageLoad = true;
            mo = cc.modb.selectByPk(moId);

            //cboMOU = cc.modb.getCboMOUNumber(cboMOU, mo.MOUNumber);

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
            txtStaffMOUEmail.Text = mo.StaffMOUEmail;
            txtStaffMOUMobile.Text = mo.StaffMOUMobile;
            txtStaffMOUTel.Text = mo.StaffMOUTel;
            txtDatePeriod.Text = mo.DatePeriod;
            if (!mo.StaffPlaceRecordPosition.Equals(""))
            {
                txtStaffPlaceRecordPosition.Text = mo.StaffPlaceRecordPosition;
            }
            
            cboStaffMOU.Text = mo.StaffQuoName;
            cboStaffPlaceRecord.Text = mo.StaffPlaceRecordName;
            CustMou.Text = mo.CustMou;

            setGrd(mo.Id);
            pageLoad = false;
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
            //mo.DatePeriod = 
            //it.ItemGroupId = cc.getValueCboItem(cboGroup);

            mo.Id = txtMOUId.Text;
            mo.MOUNumber = txtMouNumber.Text;
            mo.DatePeriod = txtDatePeriod.Text;
            mo.StaffMOUName = cboStaffMOU.Text;
            mo.StaffMOUId = cc.getValueCboItem(cboStaffPlaceRecord);
            mo.StaffMOUEmail = txtStaffMOUEmail.Text;
            mo.StaffMOUTel = txtStaffMOUTel.Text;
            mo.StaffQuoId = cc.getValueCboItem(cboStaffMOU);
            mo.StaffQuoName = cboStaffMOU.Text;
            mo.StaffMOUMobile = txtStaffMOUMobile.Text;
            mo.StaffPlaceRecordId = cc.getValueCboItem(cboStaffPlaceRecord);
            mo.StaffPlaceRecordName = cboStaffPlaceRecord.Text;
            mo.StaffPlaceRecordPosition = txtStaffPlaceRecordPosition.Text;

            mo.CustMou = CustMou.Text;
            mo.Active = "1";

            qu = cc.qudb.selectByPk(mo.QuoId);
            mo.CompAddress1 = qu.CompAddress1;
            mo.CompAddress2 = qu.CompAddress2;
            mo.CompId = qu.CompId;
            mo.CompName = qu.CompName;
            mo.CompTaxId = qu.CompTaxId;
            //mo.DatePeriod = txtDatePeriod.Text;
            mo.userCreate = cc.sf.Id;
            mo.userModi = cc.sf.Id;
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
            dgvAdd.Columns[colItem].Width = 350;
            dgvAdd.Columns[colMethod].Width = 350;
            dgvAdd.Columns[colSample].Width = 80;
            dgvAdd.Columns[colDatePlaceRecord].Width = 150;
            dgvAdd.Columns[colPlace].Width = 350;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItem].HeaderText = "Parameter";
            dgvAdd.Columns[colMethod].HeaderText = "Method";
            dgvAdd.Columns[colSample].HeaderText = "Sample";
            //dgvAdd.Columns[colPrice].HeaderText = "Price";
            dgvAdd.Columns[colPlace].HeaderText = "สถายที่เก็บตัวอย่าง";
            dgvAdd.Columns[colDatePlaceRecord].HeaderText = "วันที่เก็บตัวอย่าง";
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
                    dgvAdd[colDatePlaceRecord, i].Value = dt.Rows[i][cc.moidb.moi.DatePlaceRecord].ToString();
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
        private void LockSplit()
        {
            MOUSplit = true;
            txtCustName.ReadOnly = true;
            txtMouNumber.ReadOnly = true;
            cboMOU.Enabled = false;
            cboQuo.Enabled = false;

        }
        private void UnLockSplit()
        {
            MOUSplit = false;
            txtCustName.ReadOnly = false;
            txtMouNumber.ReadOnly = false;
            cboMOU.Enabled = true;
            cboQuo.Enabled = true;
        }
        private void setQuotation()
        {
            qu = cc.qudb.selectByPk(cc.getValueCboItem(cboQuo));
            txtCustName.Text = qu.CustName;
            txtCustId.Text = qu.CustId;
            txtCustAddress.Text = qu.CustAddress;
            txtCustEmail.Text = qu.CustEmail;
            txtCustMobile.Text = "";
            txtCustTel.Text = qu.CustTel;
            txtContactName.Text = qu.ContactName;
            cboStaffMOU.Text = qu.StaffName;
            CustMou.Text = qu.ContactName;
            sf = cc.sfdb.selectByPk(qu.StaffId);
            //cboStaffMOU.Text = sf.NameT;
            txtStaffMOUEmail.Text = sf.Email;
            txtStaffMOUMobile.Text = sf.Mobile;
            txtStaffMOUTel.Text = sf.Tele;
        }

        private void FrmMOUAdd1_Load(object sender, EventArgs e)
        {

        }

        private void cboQuo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Cursor cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                setQuotation();
                Cursor.Current = cursor;
            }
        }

        private void FrmMOUAdd1_Resize(object sender, EventArgs e)
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
            if (cboStaffMOU.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี ผู้รับผิดชอบข้อตกลง", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboStaffPlaceRecord.Text.Equals(""))
            {
                MessageBox.Show("ไม่มี เจ้าหน้าที่ผู้ทำการเก็บตัวอย่าง ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            getMOU();
            if (mo.Id.Equals("") && (!MOUSplit))
            {
                mo.MOUNumber = cc.modb.getMOUNumber("");
                String[] doc1 = mo.MOUNumber.Split('-');
                mo.MOUNumber = doc1[0];
                mo.MOUNumberCnt = doc1[1];
            }
            else if (MOUSplit)
            {
                String[] doc1 = mo.MOUNumber.Split('-');
                mo.MOUNumber = doc1[0];
                mo.MOUNumberCnt = cc.modb.selectMaxByNumber(mo.MOUNumber);
                mo.Id = "";
            }
            else
            {
                String[] doc1 = mo.MOUNumber.Split('-');
                mo.MOUNumber = doc1[0];
                mo.MOUNumberCnt = doc1[1];
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
                    if (MOUSplit)
                    {
                        moi.Id = "";
                    }
                    else
                    {
                        moi.Id = dgvAdd[colId, i].Value.ToString();
                    }
                    //moi.RowNumber = dgvAdd[colRow, i].Value.ToString();
                    Item it = cc.itdb.selectByPk(dgvAdd[colItemId, i].Value.ToString());
                    ItemGroup itg = cc.itgdb.selectByPk(it.ItemGroupId);

                    moi.Active = "1";
                    moi.ItemDescription = dgvAdd[colItem, i].Value.ToString();
                    moi.ItemId = dgvAdd[colItemId, i].Value.ToString();
                    moi.MethodDescription = dgvAdd[colMethod, i].Value.ToString();
                    moi.MethodId = dgvAdd[colMethodId, i].Value.ToString();
                    moi.MOUId = moId;
                    moi.PlaceRecord = dgvAdd[colPlace, i].Value.ToString();
                    moi.Sample = dgvAdd[colSample, i].Value.ToString();
                    moi.DatePlaceRecord = dgvAdd[colDatePlaceRecord, i].Value.ToString();
                    moi.ItemGroupId = itg.Id;
                    moi.ItemGroupNameT = itg.NameT;
                    moi.ItemGroupNameE = itg.NameE;
                    moi.ItemGroupSort = itg.Sort1;
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
                UnLockSplit();
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
                mouNew=false;
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
            if ((row % 2) != 0)
            {
                dgvAdd.Rows[row].DefaultCellStyle.BackColor = Color.LightSalmon;
            }
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
            LockSplit();
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

        private void btnPrintMou_Click(object sender, EventArgs e)
        {
            String sql = "";
            //OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = cc.moidb.selectByMoId(txtMOUId.Text);
            MOU mo = cc.modb.selectByPk(txtMOUId.Text);
            mo.ContactName = "เรียน :  " + mo.ContactName;
            mo.CustAddress = "ที่อยู่ :   " + mo.CustAddress;
            mo.CustTel = "เบอร์โทร : " + mo.CustTel + " Mobile : " + mo.CustMobile;
            mo.CustEmail = " Email : " + mo.CustEmail;
            mo.Line1 = cc.cp.mouLine1;
            mo.QuoNumber = "เลขที่ : " + mo.MOUNumber + "-" + mo.MOUNumberCnt;
            mo.DatePeriod = "วันที่ :  " + mo.DatePeriod;
            mo.StaffQuoName = "ผู้เสนอราคา :  " + mo.StaffQuoName;
            mo.StaffMOUTel = "เบอร์โทร : " + mo.StaffMOUTel + " Mobile : " + mo.StaffMOUMobile;
            mo.StaffMOUEmail = "Email : " + mo.StaffMOUEmail;
            mo.MOUNumber = "เลขที่ : " + mo.MOUNumber + "-" + mo.MOUNumberCnt;

            FrmReport frm = new FrmReport(cc);
            frm.setReportMOU(mo, dt);
            frm.ShowDialog(this);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            FrmMOUPlaceRecord frm = new FrmMOUPlaceRecord(txtMOUId.Text,cc);
            frm.ShowDialog(this);

        }

        private void dgvAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //int index = dgvAdd.CurrentCell.ColumnIndex;
            if (dgvAdd.CurrentCell.ColumnIndex==colDatePlaceRecord)
            {
                Rectangle tempRect = this.dgvAdd.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                cellDateTimePicker.Location = tempRect.Location;
                cellDateTimePicker.Width = tempRect.Width;
                try
                {
                    cellDateTimePicker.Value = DateTime.Parse(dgvAdd.CurrentCell.Value.ToString());
                }
                catch
                {
                    cellDateTimePicker.Value = DateTime.Now;
                }
                cellDateTimePicker.Visible = true;
            }
        }
    }
}
