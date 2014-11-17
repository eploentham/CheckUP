using Cemp.Control;
using Cemp.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        Staff sf;
        int colRow = 0, colItem = 1, colMethod = 2, colSample = 3, colPlace = 5, colDatePlaceRecord=4, colMOUNumber=6, colId = 7, colDel =8, colItemId = 9, colMethodId = 10;
        int colEdit = 11, colMOUNumberCnt=12, colDatePlaceRecord1=13, colItemType=14;
        //int colPriceSale = 14, colPriceCost = 15, colAmount = 16, colDiscount = 17;
        int colCnt = 15;
        int row = 0;
        Boolean pageLoad = false, mouNew = false, MOUSplit = false;
        //DateTimePicker cellDateTimePicker = new DateTimePicker();
        ComboBox cbo = new ComboBox();
        DateTimeFormatInfo df;
        List<String> ldate;
        List<String> lplace;
        List<String> ltype;
        //DataGridView dgv;
        String editItemTypeOld = "", editPlaceOld="", editDateOld="";
        public FrmMOUAdd(String moNumber, Boolean flagNew, CnviControl c)
        {
            mouNew = flagNew;
            InitializeComponent();
            initConfig(moNumber,c);
        }
        private void initConfig(String moNumber, CnviControl c)
        {
            pageLoad = true;
            //df = new CultureInfo("en-US").DateTimeFormat;
            //cellDateTimePicker.ValueChanged += new EventHandler(cellDateTimePickerValueChanged);
            //cellDateTimePicker.Visible = false;
            //cellDateTimePicker.CustomFormat = "dd/MM/yyyy";
            //cellDateTimePicker.Format = DateTimePickerFormat.Custom;
            //cellDateTimePicker.Value.GetDateTimeFormats(df);
            dgvAdd.Controls.Add(cbo);
            //dgv = new DataGridView();
            cbo.SelectedValueChanged += new EventHandler(cboValueChanged);
            ldate = new List<string>();
            lplace = new List<string>();
            ltype = new List<string>();
            cc = c;
            mo = new MOU();
            qu = new Quotation();
            sf = new Staff();
            txtMOUNumber.Text = moNumber;
            cboMOU = cc.moidb.getCboMOUNumberMain(cboMOU, moNumber);
            cboQuo = cc.qudb.getCboQuoConfirmNoMOU(cboQuo);
            cboStaffPlaceRecord = cc.sfdb.getCboStaff(cboStaffPlaceRecord);
            cboStaffMOU = cc.sfdb.getCboStaff(cboStaffMOU);
            cboDocType = cc.itydb.getCboDocType(cboDocType,"mou");
            txtStaffPlaceRecordPosition.Text = "เจ้าหน้าที่ผู้ทำการเก็บตัวอย่าง";
            cbo = cc.itydb.getCboDocType(cbo, "mou");
            cbo.Visible = false;
            setControl("");
            if (!moNumber.Equals(""))
            {
                //MOU mo1 = new MOU();
                String quNumber = cc.modb.selectQuoNumberByNumber(moNumber);
                cboQuo.Text = quNumber;
            }
            setLDate1(moNumber);
            setLPlace1(moNumber);
            pageLoad = false;
        }
        private void HideMOU()
        {
            label16.Enabled = false;
            //label9.Enabled = false;
            btnMOUAdd.Enabled = false;
            cboMOU.Enabled = false;
            //txtMouNumber.Enabled = false;
            //label5.Enabled = false;
            //txtDatePeriod.Enabled = false;
        }
        private void ShowMOU()
        {
            label16.Enabled = true;
            //label9.Enabled = true;
            btnMOUAdd.Enabled = true;
            cboMOU.Enabled = true;
            //label5.Enabled = true;
            //txtDatePeriod.Enabled = true;

            //txtMouNumber.Enabled = true;
            label1.Enabled = false;
            cboQuo.Enabled = false;
            label2.Enabled = false;
            txtCustName.Enabled = false;
        }
        //void cellDateTimePickerValueChanged(object sender, EventArgs e)
        //{
        //    dgvAdd.CurrentCell.Value = cellDateTimePicker.Value.ToString("dd/MM/yyyy");cboValueChanged
        //    cellDateTimePicker.Visible = false;
        //}
        void cboValueChanged(object sender, EventArgs e)
        {
            dgvAdd.CurrentCell.Value = cbo.Text;
            cbo.Visible = false;
        }
        private void setControl(String moNumberMain)
        {
            pageLoad = true;
            if (mouNew)
            {
                HideMOU();
            }
            else
            {
                ShowMOU();
            }
            if (moNumberMain.Equals(""))
            {
                pageLoad = false;
                //txtMouNumber.Text = "-";
                return;
            }
            //if (moNumberMain.IndexOf("-")<=0)
            //{
            //    pageLoad = false;
            //    return;
            //}
            mo = cc.modb.selectByNumber1(moNumberMain);

            //cboMOU = cc.moidb.getCboMOUNumberMain(cboMOU, mo.MOUNumberMain);

            //cboContact = cc.cudb.getCboCustomer(cboContact);
            dtpDateMOU.Format = DateTimePickerFormat.Short;
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
            cboDocType.Text = cc.getTextCboItem(cboDocType, mo.docType);

            txtMOUId.Text = mo.Id;
            //txtMouNumber.Text = mo.MOUNumber+"-"+mo.MOUNumberCnt;
            txtStaffMOUEmail.Text = mo.StaffMOUEmail;
            txtStaffMOUMobile.Text = mo.StaffMOUMobile;
            txtStaffMOUTel.Text = mo.StaffMOUTel;
            //txtDatePeriod.Text = mo.DatePeriod;
            if (!mo.StaffPlaceRecordPosition.Equals(""))
            {
                txtStaffPlaceRecordPosition.Text = mo.StaffPlaceRecordPosition;
            }
            try
            {
                if (!mo.MOUDate.Equals(""))
                {
                    dtpDateMOU.Value = DateTime.Parse(cc.cf.dateDBtoShow1(mo.MOUDate));
                }
                else
                {
                    dtpDateMOU.Value = DateTime.Now;
                }
                
            }
            catch (Exception ex)
            {
                dtpDateMOU.Value = DateTime.Parse(cc.cf.dateDBtoShow(mo.MOUDate));
            }
            cboStaffMOU.Text = mo.StaffQuoName;
            cboStaffPlaceRecord.Text = mo.StaffPlaceRecordName;
            CustMou.Text = mo.CustMou;
            txtMOUName.Text = mo.MOUName;
            chkActive.Checked =true;
            btnUnActive.Visible = false;
            setGrd(cc.getValueCboItem(cboMOU));
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
            mo.MOUNumberMain = txtMOUNumber.Text;
            //mo.DatePeriod = txtDatePeriod.Text;
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
            mo.MOUDate = cc.cf.datetoDB(dtpDateMOU.Value);
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
            mo.MOUName = txtMOUName.Text;
            mo.docType = cc.getValueCboItem(cboDocType);
        }
        private void setGrd()
        {
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colItem].Width = 350;
            dgvAdd.Columns[colMethod].Width = 350;
            dgvAdd.Columns[colSample].Width = 80;
            dgvAdd.Columns[colDatePlaceRecord].Width = 150;
            dgvAdd.Columns[colPlace].Width = 350;
            dgvAdd.Columns[colMOUNumber].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colItem].HeaderText = "Parameter";
            dgvAdd.Columns[colMethod].HeaderText = "Method";
            dgvAdd.Columns[colSample].HeaderText = "Sample";
            dgvAdd.Columns[colItemType].HeaderText = "Type";
            dgvAdd.Columns[colPlace].HeaderText = "สถานที่เก็บตัวอย่าง";
            dgvAdd.Columns[colDatePlaceRecord].HeaderText = "วันที่เก็บตัวอย่าง";
            dgvAdd.Columns[colMOUNumber].HeaderText = "เลขที่";
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
            dgvAdd.Columns[colMOUNumber].Visible = false;
            dgvAdd.Columns[colMOUNumberCnt].Visible = false;
            dgvAdd.Columns[colDatePlaceRecord1].Visible = false;
            //dgvAdd.Columns[colPriceCost].Visible = false;
            //dgvAdd.Columns[colPriceSale].Visible = false;
            //dgvAdd.Columns[colAmount].Visible = false;
            //dgvAdd.Columns[colDiscount].Visible = false;

            dgvAdd.Columns[colSample].ReadOnly = true;
            dgvAdd.Columns[colMethod].ReadOnly = true;
            dgvAdd.Columns[colItem].ReadOnly = true;
            dgvAdd.Columns[colRow].ReadOnly = true;
        }
        private void setGrd(String moNumber)
        {
            setGrd();
            DataTable dt = cc.moidb.selectByMoNumber(moNumber);
            //DataGridViewComboBoxColumn newColumn = new DataGridViewComboBoxColumn();
            //newColumn.Name = "abc";
            //newColumn.DataSource = new string[] { "a", "b", "c" };
            //newColumn.ReadOnly = false;

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
                    dgvAdd[colItem, i].Value = dt.Rows[i][cc.moidb.moi.ItemDescription].ToString();
                    dgvAdd[colMethod, i].Value = dt.Rows[i][cc.moidb.moi.MethodDescription].ToString();
                    dgvAdd[colSample, i].Value = dt.Rows[i][cc.moidb.moi.Sample].ToString();
                    dgvAdd[colItemType, i].Value = dt.Rows[i][cc.moidb.moi.ItemType].ToString();
                    dgvAdd[colPlace, i].Value = dt.Rows[i][cc.moidb.moi.PlaceRecord].ToString();
                    dgvAdd[colItemId, i].Value = dt.Rows[i][cc.moidb.moi.ItemId].ToString();
                    dgvAdd[colMethodId, i].Value = dt.Rows[i][cc.moidb.moi.MethodId].ToString();
                    dgvAdd[colId, i].Value = dt.Rows[i][cc.moidb.moi.Id].ToString();
                    //dgvAdd[colDatePlaceRecord, i].Value = cc.cf.dateDBtoShow1(dt.Rows[i][cc.moidb.moi.DatePlaceRecord].ToString());
                    //dgvAdd[colDatePlaceRecord1, i].Value = cc.cf.dateDBtoShow1(dt.Rows[i][cc.moidb.moi.DatePlaceRecord].ToString());
                    dgvAdd[colDatePlaceRecord, i].Value = cc.cf.dateShowMOU(dt.Rows[i][cc.moidb.moi.DatePlaceRecord].ToString());
                    dgvAdd[colDatePlaceRecord1, i].Value = cc.cf.dateShowMOU(dt.Rows[i][cc.moidb.moi.DatePlaceRecord].ToString());
                    dgvAdd[colMOUNumber, i].Value = dt.Rows[i][cc.moidb.moi.MOUNumber].ToString();
                    dgvAdd[colMOUNumberCnt, i].Value = dt.Rows[i][cc.moidb.moi.MOUNumberCnt].ToString();
                    dgvAdd[colDel, i].Value = "";
                    dgvAdd[colEdit, i].Value = "";
                    //setLPace(dgvAdd[colPlace, i].Value.ToString());
                    //setLDate(dgvAdd[colDatePlaceRecord, i].Value.ToString());
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void setLDate1(String moNumber)
        {
            ldate.Clear();
            DataTable dt = cc.moidb.selectDatePlaceByNumber(moNumber);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ldate.Add(cc.cf.dateShowMOU(dt.Rows[i][cc.moidb.moi.DatePlaceRecord].ToString()));
            }
        }
        private void setLPlace1(String moNumber)
        {
            lplace.Clear();
            DataTable dt = cc.moidb.selectPlaceByNumber(moNumber);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lplace.Add(dt.Rows[i][cc.moidb.moi.PlaceRecord].ToString());
            }
        }
        private void setLType1(String moNumber)
        {
            ltype.Clear();
            DataTable dt = cc.moidb.selectPlaceByNumber(moNumber);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltype.Add(dt.Rows[i][cc.moidb.moi.ItemType].ToString());
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
            
            panel1.Top = this.Height - panel1.Height -50;
            dgvAdd.Height = this.Height - groupBox2.Top - groupBox2.Height-panel1.Height-50-5;
            //groupBox3.Left = groupBox2.Left;
            //groupBox1.Height = this.Height = 150;
        }
        //private void clearItem()
        //{
        //    txtRow.Text = "";
        //    txtSample.Text = "";
        //    txtPlaceRecord.Text = "";
        //    cboItem.Text = "";
        //    //txtItemAmount.Text = "";
        //}
        private void LockSplit()
        {
            MOUSplit = true;
            txtCustName.ReadOnly = true;
            //txtMouNumber.ReadOnly = true;
            cboMOU.Enabled = false;
            cboQuo.Enabled = false;

        }
        private void UnLockSplit()
        {
            MOUSplit = false;
            txtCustName.ReadOnly = false;
            //txtMouNumber.ReadOnly = false;
            cboMOU.Enabled = true;
            cboQuo.Enabled = true;
        }
        private void setQuotation()
        {
            //mouNew = true;
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
            chkActive.Checked = true;
        }
        private void setGrdRow(String itId, String itDescription,String meId, String meDescription, String ity)
        {
            int row = dgvAdd.Rows.Add();
            dgvAdd[colRow, row].Value = (row + 1);
            dgvAdd[colItem, row].Value = itDescription;
            dgvAdd[colMethod, row].Value = meDescription;
            dgvAdd[colItemId, row].Value = itId;
            dgvAdd[colMethodId, row].Value = meId;
            dgvAdd[colSample, row].Value = "1";
            dgvAdd[colPlace, row].Value = "";
            dgvAdd[colId, row].Value = "";
            dgvAdd[colDatePlaceRecord, row].Value = "";
            dgvAdd[colMOUNumber, row].Value = "";
            dgvAdd[colDel, row].Value = "";
            dgvAdd[colEdit, row].Value = "";
            dgvAdd[colItemType, row].Value = ity;
            //dgvAdd[colPriceCost, row].Value = priceCost;
            //dgvAdd[colAmount, row].Value = amount;
            //dgvAdd[colDiscount, row].Value = discount;
        }
        private void setMOUNew(String quId)
        {
            setGrd();
            DataTable dt = cc.quidb.selectByQuId(quId);
            //dgvAdd.RowCount = dt.Rows.Count + 1;
            //dgvAdd.Columns.Add(newColumn);
            try
            {
                if (dt.Rows.Count > 0)
                {
                    dgvAdd.Rows.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Double sample = 0;
                        sample = Double.Parse(dt.Rows[i][cc.quidb.qui.Qty].ToString());
                        if (sample == 0)
                        {
                            sample = 1;
                        }
                        for (int j = 0; j < sample; j++)
                        {
                            setGrdRow(dt.Rows[i][cc.quidb.qui.ItemId].ToString(), dt.Rows[i][cc.quidb.qui.ItemDescription].ToString(),
                            dt.Rows[i][cc.quidb.qui.MethodId].ToString(), dt.Rows[i][cc.quidb.qui.MethodDescription].ToString(), dt.Rows[i][cc.quidb.qui.ItemType].ToString());
                        }
                    }
                    setGrdColor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message, "Error");
            }
        }
        private void setGrdColor()
        {
            for (int i = 0; i < dgvAdd.Rows.Count; i++)
            {
                if ((i % 2) != 0)
                {
                    dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
            }
        }
        private void FrmMOUAdd_Load(object sender, EventArgs e)
        {

        }

        private void cboQuo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad && mouNew)
            {
                Cursor cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                setQuotation();
                setMOUNew(qu.Id);
                Cursor.Current = cursor;
            }
        }

        private void FrmMOUAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }
        private void SortGrdDatePlaceRecord()
        {
            String moId = "", datePlaceRecordTemp = "",tmp="";
            //dgv = dgvAdd;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                if (dgvAdd[colSample, i].Value == null)
                {
                    continue;
                }
                for (int j = 0; j < dgvAdd.RowCount - 1; j++)
                {
                    if (dgvAdd[colDatePlaceRecord, (j + 1)].Value == null)
                    {
                        continue;
                    }
                    String sRow = "", sItem = "", sMethod = "", sSample = "", sPlace = "", sDatePlaceRecord = "", sMOUNumber = "", sId = "", sDel = "", sItemId = "", sMethodId = "", sEdit = "";
                    String sRow1 = "", sItem1 = "", sMethod1 = "", sSample1 = "", sPlace1 = "", sDatePlaceRecord1 = "", sMOUNumber1 = "", sId1 = "", sDel1 = "", sItemId1 = "", sMethodId1 = "", sEdit1= "";
                    String pricesale = "", pricecost = "", amount = "", discount = "";
                    datePlaceRecordTemp = cc.cf.dateInputMOU(dgvAdd[colDatePlaceRecord, (j + 1)].Value.ToString());
                    //if (int.Parse(cc.cf.datetoDB(dgvAdd[colDatePlaceRecord, j].Value).Replace("-", "")) > int.Parse(datePlaceRecordTemp.Replace("-", "")))
                    datePlaceRecordTemp = cc.cf.NumberNull1(datePlaceRecordTemp);
                    if (dgvAdd[colDatePlaceRecord, j].Value.ToString().Equals("") || (int.Parse(cc.cf.dateInputMOU(dgvAdd[colDatePlaceRecord, j].Value.ToString())) > int.Parse(datePlaceRecordTemp.Replace("-", ""))))
                    {
                        sRow1 = dgvAdd[colRow, (j + 1)].Value.ToString();
                        sItem1 = dgvAdd[colItem, (j + 1)].Value.ToString();
                        sMethod1 = dgvAdd[colMethod, (j + 1)].Value.ToString();
                        sSample1 = dgvAdd[colSample, (j + 1)].Value.ToString();
                        sPlace1 = dgvAdd[colPlace, (j + 1)].Value.ToString();
                        sDatePlaceRecord1 = dgvAdd[colDatePlaceRecord, (j + 1)].Value.ToString();
                        sMOUNumber1 = dgvAdd[colMOUNumber, (j + 1)].Value.ToString();
                        sId1 = dgvAdd[colId, (j + 1)].Value.ToString();
                        sDel1 = dgvAdd[colDel, (j + 1)].Value.ToString();
                        sItemId1 = dgvAdd[colItemId, (j + 1)].Value.ToString();
                        sMethodId1 = dgvAdd[colMethodId, (j + 1)].Value.ToString();
                        sEdit1 = dgvAdd[colEdit, (j + 1)].Value.ToString();
                        //pricesale = dgvAdd[colPriceSale, (j + 1)].Value.ToString();
                        //pricecost = dgvAdd[colPriceCost, (j + 1)].Value.ToString();
                        //amount = dgvAdd[colAmount, (j + 1)].Value.ToString();
                        //discount = dgvAdd[colDiscount, (j + 1)].Value.ToString();

                        dgvAdd[colRow, (j + 1)].Value = dgvAdd[colRow, j].Value.ToString();
                        dgvAdd[colItem, (j + 1)].Value = dgvAdd[colItem, j].Value.ToString();
                        dgvAdd[colMethod, (j + 1)].Value = dgvAdd[colMethod, j].Value.ToString();
                        dgvAdd[colSample, (j + 1)].Value = dgvAdd[colSample, j].Value.ToString();
                        dgvAdd[colPlace, (j + 1)].Value = dgvAdd[colPlace, j].Value.ToString();
                        dgvAdd[colDatePlaceRecord, (j + 1)].Value = dgvAdd[colDatePlaceRecord, j].Value.ToString();
                        dgvAdd[colMOUNumber, (j + 1)].Value = dgvAdd[colMOUNumber, j].Value.ToString();
                        dgvAdd[colId, (j + 1)].Value = dgvAdd[colId, j].Value.ToString();
                        dgvAdd[colDel, (j + 1)].Value = dgvAdd[colDel, j].Value.ToString();
                        dgvAdd[colItemId, (j + 1)].Value = dgvAdd[colItemId, j].Value.ToString();
                        dgvAdd[colMethodId, (j + 1)].Value = dgvAdd[colMethodId, j].Value.ToString();
                        dgvAdd[colEdit, (j + 1)].Value = dgvAdd[colEdit, j].Value.ToString();
                        //dgvAdd[colPriceCost, (j + 1)].Value = dgvAdd[colPriceCost, j].Value.ToString();
                        //dgvAdd[colPriceSale, (j + 1)].Value = dgvAdd[colPriceSale, j].Value.ToString();
                        //dgvAdd[colAmount, (j + 1)].Value = dgvAdd[colAmount, j].Value.ToString();
                        //dgvAdd[colDiscount, (j + 1)].Value = dgvAdd[colDiscount, j].Value.ToString();

                        dgvAdd[colRow, (j)].Value = sRow1;
                        dgvAdd[colItem, (j)].Value = sItem1;
                        dgvAdd[colMethod, (j)].Value = sMethod1;
                        dgvAdd[colSample, (j)].Value = sSample1;
                        dgvAdd[colPlace, (j)].Value = sPlace1;
                        dgvAdd[colDatePlaceRecord, (j)].Value = sDatePlaceRecord1;
                        dgvAdd[colMOUNumber, (j)].Value = sMOUNumber1;
                        dgvAdd[colId, (j)].Value = sId1;
                        dgvAdd[colDel, (j)].Value = sDel1;
                        dgvAdd[colItemId, (j)].Value = sItemId1;
                        dgvAdd[colMethodId, (j)].Value = sMethodId1;
                        dgvAdd[colEdit, (j)].Value = sEdit1;
                        //dgvAdd[colPriceCost, (j)].Value = pricecost;
                        //dgvAdd[colPriceSale, (j)].Value = pricesale;
                        //dgvAdd[colAmount, (j)].Value = amount;
                        //dgvAdd[colDiscount, (j)].Value = discount;

                        //dgvAdd[colDatePlaceRecord, (j + 1)].Value = dgvAdd[colDatePlaceRecord, j].Value.ToString();
                    }

                    //datePlaceRecordTemp = cc.cf.datetoDB(dgvAdd[colDatePlaceRecord, (j + 1)].Value);
                    //if (int.Parse(cc.cf.datetoDB(dgvAdd[colDatePlaceRecord, j].Value).Replace("-", "")) > int.Parse(datePlaceRecordTemp.Replace("-", "")))
                    //{
                    //    tmp = dgvAdd[colDatePlaceRecord, (j + 1)].Value.ToString();
                    //    dgvAdd[colDatePlaceRecord, (j + 1)].Value = dgvAdd[colDatePlaceRecord, j].Value.ToString();
                    //    dgvAdd[colDatePlaceRecord, j].Value = tmp;
                    //}
                }
            }
        }
        private void setMOUNumberCnt()
        {
            int cnt = 1;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                dgvAdd[colMOUNumberCnt, i].Value = cnt;
            }
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                String datePlaceRecordOld="";
                if (i ==0)
                {
                    continue;
                }
                if (dgvAdd[colDatePlaceRecord, i].Value==null)
                {
                    continue;
                }
                datePlaceRecordOld = dgvAdd[colDatePlaceRecord, (i - 1)].Value.ToString();
                if (!dgvAdd[colDatePlaceRecord, i].Value.ToString().Equals(datePlaceRecordOld))
                {
                    cnt++;                    
                }
                dgvAdd[colMOUNumberCnt, i].Value = cnt;
            }
        }
        private Boolean ChkGrd1()
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                if (dgvAdd[colItem, i].Value == null)
                {
                    continue;
                }
                if ((dgvAdd[colDatePlaceRecord, i].Value==null) ||(dgvAdd[colDatePlaceRecord, i].Value.ToString().Equals("")))
                {
                    //DataGridViewRow row = dgvAdd.Rows[i];
                    //row.Cells[colDatePlaceRecord].Style.BackColor = Color.Red;
                    dgvAdd.Rows[i].Cells[colDatePlaceRecord].Style.BackColor = Color.Red;
                    chk = true;
                }
                if ((dgvAdd[colItemType, i].Value == null) || (dgvAdd[colItemType, i].Value.ToString().Equals("")))
                {
                    //DataGridViewRow row = dgvAdd.Rows[i];
                    //row.Cells[colDatePlaceRecord].Style.BackColor = Color.Red;
                    dgvAdd.Rows[i].Cells[colItemType].Style.BackColor = Color.Red;
                    chk = true;
                }
            }
            return chk;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String moId = "", datePlaceRecordTemp="", ity="";
            int rowOld = 0, row = 0;
            Boolean chkEdit = false;
            if (cboMOU.Text.Equals("") && !mouNew)
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
            //if (cboDocType.Text.Equals(""))
            //{
            //    MessageBox.Show("ไม่มี Doc Type ", "ป้อนข้อมูลไม่ครบ");
            //    return;
            //}
            if (ChkGrd1())
            {
                return;
            }
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (mouNew)
            {
                SortGrdDatePlaceRecord();
                setMOUNumberCnt();
            }            
            getMOU();
            //if (mo.Id.Equals("") && (!MOUSplit))
            if (mouNew)
            {

                //mo.MOUNumber = cc.modb.getMOUMaxNumber(cc.getValueCboItem(cboDocType),"");
                mo.MOUNumberMain = cc.modb.getMOUMaxNumber("");
                //String[] doc1 = mo.MOUNumber.Split('-');
                //mo.MOUNumber = doc1[0];
                mo.MOUNumberCnt = "1";
            }
            //else if (MOUSplit)
            //{
            //    String[] doc1 = mo.MOUNumberMain.Split('-');
            //    mo.MOUNumberMain = doc1[0];
            //    mo.MOUNumberCnt = cc.modb.selectMaxByNumber(mo.MOUNumberMain);
            //    mo.Id = "";
            //}
            //else
            //{
            //    String[] doc1 = mo.MOUNumberMain.Split('-');
            //    mo.MOUNumberMain = doc1[0];
            //    mo.MOUNumberCnt = doc1[1];
            //}
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
                    //moi.RowNumber = dgvAdd[colRow, i].Value.ToString();
                    //row = int.Parse(moi.RowNumber);
                    row = i;
                    moi.RowNumber = String.Concat(i+1);
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
                    moi.DatePlaceRecord = cc.cf.datetoDB1(moi.DatePlaceRecord);
                    moi.ItemGroupId = itg.Id;
                    moi.ItemGroupNameT = itg.NameT;
                    moi.ItemGroupNameE = itg.NameE;
                    moi.ItemGroupSort = itg.Sort1;
                    moi.MOUNumberCnt = dgvAdd[colMOUNumberCnt, i].Value.ToString();
                    moi.MOUNumberMain = mo.MOUNumberMain;
                    moi.PriceCost = cc.cf.NumberNull1(it.PriceCost);
                    moi.PriceSale = cc.cf.NumberNull1(it.PriceSale);
                    moi.Discount = "0";
                    moi.Amount = String.Concat(Double.Parse(moi.PriceSale) * int.Parse(moi.Sample));
                    moi.ItemType = dgvAdd[colItemType, i].Value.ToString();
                    //if (cboMOU.Text.IndexOf("-"))
                    //{
                    //    moi.MOUNumber = cboMOU.Text;
                    //}
                    
                    if (dgvAdd[colEdit, i].Value.Equals("1"))
                    {
                        chkEdit = true;
                        ity = moi.ItemType;
                    }
                    //if ((!mouNew)&&(!dgvAdd[colDatePlaceRecord, i].Value.ToString().Equals(dgvAdd[colDatePlaceRecord1, i].Value.ToString())))
                    //{
                    //    moi.MOUNumberCnt = cc.moidb.selectCntByMoNumber(moi.MOUNumber, cc.cf.datetoDB1( dgvAdd[colDatePlaceRecord, i].Value.ToString()));
                    //}
                    //for (int j = 0; j<dgvAdd.RowCount - 1; j++)
                    //{
                    //    datePlaceRecordTemp = dgvAdd[colDatePlaceRecord, (j+1)].Value.ToString();
                    //    if (int.Parse(dgvAdd[colDatePlaceRecord, j].Value.ToString().Replace("-", "")) > int.Parse(datePlaceRecordTemp.Replace("-", "")))
                    //    {
                    //        dgvAdd[colRow, (j + 1)].Value = dgvAdd[colRow, j].Value.ToString();
                    //        dgvAdd[colRow, j].Value = dgvAdd[colRow, (j + 1)].Value;
                    //    }
                    //}
                    if (dgvAdd[colDel, i].Value.ToString().Equals("1"))
                    {
                        cc.moidb.VoidMOUItem(dgvAdd[colId, i].Value.ToString());
                    }
                    else
                    {
                        cc.moidb.insertMOUItem(moi);
                    }
                }
                if (mouNew)
                {
                    cc.moidb.UpdateMOUNumber(moId, cc.cboIty);
                }
                else if(chkEdit)
                {
                    cc.moidb.UpdateMaxMOUNumber(moId, cboMOU.Text, ity);
                }
                
                MOU mo1 = cc.modb.selectByPk(moId);
                txtMOUNumber.Text = mo1.MOUNumberMain;
                cboMOU = cc.moidb.getCboMOUNumberMain(cboMOU, mo1.MOUNumberMain);
                //cboMOU.Text = mo1.MOUNumberMain + "-" + mo1.MOUNumberCnt;
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
                //setControl(cc.getValueCboItem(cboMOU));
                setControl(txtMOUNumber.Text);
                //cellDateTimePicker.Visible = false;
                mouNew=false;
                Cursor.Current = cursor;
            }
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    int row = 0;
        //    Item it = new Item();
        //    if (txtRow.Text.Equals(""))
        //    {
        //        row = dgvAdd.Rows.Add(1);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            row = int.Parse(txtRow.Text) - 1;
        //            dgvAdd.Rows[row].DefaultCellStyle.BackColor = Color.DeepPink;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("ไม่พบข้อมูล ลำดับ", "Error");
        //            return;
        //        }
        //    }
        //    it = cc.itdb.selectByPk(cc.getValueCboItem(cboItem));
        //    if (it.Id.Equals(""))
        //    {
        //        return;
        //    }
        //    dgvAdd[colRow, row].Value = (row + 1);
        //    dgvAdd[colItemId, row].Value = it.Id;
        //    dgvAdd[colMethodId, row].Value = it.MethodId;
        //    dgvAdd[colItem, row].Value = it.NameT;
        //    dgvAdd[colMethod, row].Value = it.MethodNameT;
        //    dgvAdd[colSample, row].Value = txtSample.Text;
        //    dgvAdd[colPlace, row].Value = txtPlaceRecord.Text;
        //    //dgvAdd[colAmount, row].Value = String.Format("{0:#,###,###.00}", txtItemAmount.Text);
        //    dgvAdd[colId, row].Value = "";
        //    dgvAdd[colDel, row].Value = "";
        //    dgvAdd[colEdit, row].Value = "";
        //    if ((row % 2) != 0)
        //    {
        //        dgvAdd.Rows[row].DefaultCellStyle.BackColor = Color.LightSalmon;
        //    }
        //    //calAmount();
        //    //calNetTotal();

        //    clearItem();
        //}

        //private void btnDel_Click(object sender, EventArgs e)
        //{
        //    if (txtRow.Text.Equals(""))
        //    {
        //        return;
        //    }
        //    dgvAdd[colDel, (int.Parse(txtRow.Text) - 1)].Value = "1";
        //    dgvAdd.Rows[(int.Parse(txtRow.Text) - 1)].DefaultCellStyle.BackColor = Color.DarkGray;
        //}

        //private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!pageLoad)
        //    {
        //        Item it = cc.itdb.selectByPk(cc.getValueCboItem(cboItem));
        //        //txtItemPrice.Text = it.PriceSale;
        //        txtSample.Text = "1";
        //        txtPlaceRecord.Focus();
        //        //calItemAmount();
        //    }
        //}

        private void btnMOUAdd_Click(object sender, EventArgs e)
        {
            LockSplit();
        }

        private void dgvAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pageLoad = true;
            if (dgvAdd[colRow, e.RowIndex].Value == null)
            {
                return;
            }
            //txtRow.Text = dgvAdd[colRow, e.RowIndex].Value.ToString();
            //txtPlaceRecord.Text = dgvAdd[colPlace, e.RowIndex].Value.ToString();
            //txtSample.Text = dgvAdd[colSample, e.RowIndex].Value.ToString();
            ////txtItemAmount.Text = dgvAdd[colAmount, e.RowIndex].Value.ToString();
            //cboItem.SelectedItem = cc.setCboItem(cboItem, dgvAdd[colItemId, e.RowIndex].Value.ToString());
            ////cboMethod.Text = dgvAdd[colMethod, e.RowIndex].Value.ToString();
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
            mo.QuoNumber = "เลขที่ : " + mo.MOUNumberMain + "-" + mo.MOUNumberCnt;
            mo.DatePeriod = "วันที่ :  " + mo.DatePeriod;
            mo.StaffQuoName = "ผู้เสนอราคา :  " + mo.StaffQuoName;
            mo.StaffMOUTel = "เบอร์โทร : " + mo.StaffMOUTel + " Mobile : " + mo.StaffMOUMobile;
            mo.StaffMOUEmail = "Email : " + mo.StaffMOUEmail;
            mo.MOUNumberMain = "เลขที่ : " + mo.MOUNumberMain + "-" + mo.MOUNumberCnt;

            FrmReport frm = new FrmReport(cc);
            frm.setReportMOU(mo, dt);
            frm.ShowDialog(this);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            FrmMOUPlaceRecord frm = new FrmMOUPlaceRecord(txtMOUId.Text,cc);
            frm.ShowDialog(this);

        }
        private void dgvAdd_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDatePlaceRecord)
            {
                if ((dgvAdd.CurrentCell.Value.ToString().Equals("")))
                {
                    return;
                }
                row = dgvAdd.CurrentCell.RowIndex;
                dgvAdd.CurrentCell.Value = dgvAdd.CurrentCell.Value.ToString().Replace("/", "-");
                String[] tmp=dgvAdd.CurrentCell.Value.ToString().Split('-');
                if (tmp.Length != 3)
                {
                    String[] tmp1 = dgvAdd.CurrentCell.Value.ToString().Split('/');
                    MessageBox.Show("วันที่ไม่ถูกต้อง", "Error");
                    //dgvAdd.CurrentCell.f
                }
                setLDate(dgvAdd.CurrentCell.Value.ToString());
                if ((e.RowIndex % 2) != 0)
                {
                    dgvAdd[colDatePlaceRecord, e.RowIndex].Style.BackColor = Color.LightSalmon;
                }
                else
                {
                    dgvAdd[colDatePlaceRecord, e.RowIndex].Style.BackColor = Color.White;
                }
                if (!mouNew)
                {
                    if ((dgvAdd[colDatePlaceRecord, e.RowIndex].Value != null) && (!editDateOld.Equals(dgvAdd[colDatePlaceRecord, e.RowIndex].Value.ToString())))
                    {
                        dgvAdd[colEdit, e.RowIndex].Value = "1";
                        dgvAdd[colRow, e.RowIndex].Style.BackColor = Color.Olive;
                    }
                }
            }
            else if (e.ColumnIndex == colPlace)
            {
                if (dgvAdd.CurrentCell.Value == null)
                {
                    return;
                }
                if (dgvAdd.CurrentCell.Value.ToString().Equals(""))
                {
                    return;
                }
                setLPace(dgvAdd.CurrentCell.Value.ToString());
                if (!mouNew)
                {
                    if ((dgvAdd[colPlace, e.RowIndex].Value != null) && (!editPlaceOld.Equals(dgvAdd[colPlace, e.RowIndex].Value.ToString())))
                    {
                        dgvAdd[colEdit, e.RowIndex].Value = "1";
                        dgvAdd[colRow, e.RowIndex].Style.BackColor = Color.Olive;
                    }
                }
            }
            else if (e.ColumnIndex == colItemType)
            {
                if (dgvAdd.CurrentCell.Value==null)
                {
                    return;
                }
                if (dgvAdd.CurrentCell.Value.ToString().Equals(""))
                {
                    return;
                }
                row = dgvAdd.CurrentCell.RowIndex;
                if ((e.RowIndex % 2) != 0)
                {
                    dgvAdd[colItemType, e.RowIndex].Style.BackColor = Color.LightSalmon;
                }
                else
                {
                    dgvAdd[colItemType, e.RowIndex].Style.BackColor = Color.White;
                }
                setLType(dgvAdd.CurrentCell.Value.ToString());
                if ((dgvAdd[colItemType, e.RowIndex].Value!=null) && (!editItemTypeOld.Equals(dgvAdd[colItemType, e.RowIndex].Value.ToString())))
                {
                    if (!mouNew)
                    {
                        dgvAdd[colEdit, e.RowIndex].Value = "1";
                        dgvAdd[colRow, e.RowIndex].Style.BackColor = Color.Olive;
                    }
                }
            }
        }
        private void setLDate(String input1)
        {
            Boolean chk = false;
            for (int i = 0; i < ldate.Count; i++)
            {
                if (ldate[i].Equals(input1))
                {
                    chk = true;
                }
            }
            if (!chk && (!input1.Equals("")))
            {
                ldate.Add(input1);
            }
        }
        private void setLPace(String input1)
        {
            Boolean chk = false;
            for (int i = 0; i < lplace.Count; i++)
            {
                if (lplace[i].Equals(input1))
                {
                    chk = true;
                }
            }
            if (!chk && (!input1.Equals("")))
            {
                lplace.Add(input1);
            }
        }
        private void setLType(String input1)
        {
            Boolean chk = false;
            for (int i = 0; i < ltype.Count; i++)
            {
                if (ltype[i].Equals(input1))
                {
                    chk = true;
                }
            }
            if (!chk && (!input1.Equals("")))
            {
                ltype.Add(input1);
            }
        }
        private void mnuCost_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvView.SelectedRows[0].Index.ToString(), "aaa");
            if (dgvAdd.CurrentCell.RowIndex == -1)
            {
                return;
            }
            //if (dgvAdd[colId, dgvAdd.SelectedRows[0].Index].Value == null)
            //{
            //    return;
            //}
            MenuItem m = (MenuItem)(sender);
            dgvAdd.CurrentCell.Value = m.Text;
            if ((dgvAdd.CurrentCell.RowIndex % 2) != 0)
            {
                dgvAdd[colDatePlaceRecord, dgvAdd.CurrentCell.RowIndex].Style.BackColor = Color.LightSalmon;
            }
            else
            {
                dgvAdd[colDatePlaceRecord, dgvAdd.CurrentCell.RowIndex].Style.BackColor = Color.White;
            }
            //FrmQuotationAdd frm = new FrmQuotationAdd(dgvAdd[dgvAdd, dgvView.SelectedRows[0].Index].Value.ToString(), true, cc);
            ////frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            //frm.ShowDialog(this);
            //setGrd();
        }
        private void dgvAdd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.ColumnIndex == colDatePlaceRecord)
                {
                    ContextMenu m = new ContextMenu();
                    //m.MenuItems.Add(new MenuItem(" ดูข้อมูลต้นทุน"));
                    for (int i = 0; i < ldate.Count; i++)
                    {
                        m.MenuItems.Add(ldate[i], new EventHandler(mnuCost_Click));
                    }
                    int xOffset = Cursor.Position.X - this.Location.X;
                    int yOffset = Cursor.Position.Y - this.Location.Y;
                    int currentMouseOverRow = dgvAdd.HitTest(Cursor.Position.X, Cursor.Position.Y).RowIndex;

                    m.Show(dgvAdd, new Point(Cursor.Position.X - 80, Cursor.Position.Y - 250));
                }
                else if (e.ColumnIndex == colPlace)
                {
                    ContextMenu m = new ContextMenu();
                    //m.MenuItems.Add(new MenuItem(" ดูข้อมูลต้นทุน"));
                    for (int i = 0; i < lplace.Count; i++)
                    {
                        m.MenuItems.Add(lplace[i], new EventHandler(mnuCost_Click));
                    }
                    int xOffset = Cursor.Position.X - this.Location.X;
                    int yOffset = Cursor.Position.Y - this.Location.Y;
                    int currentMouseOverRow = dgvAdd.HitTest(Cursor.Position.X, Cursor.Position.Y).RowIndex;

                    m.Show(dgvAdd, new Point(Cursor.Position.X - 80, Cursor.Position.Y - 250));
                }
                else if (e.ColumnIndex == colItemType)
                {
                    ContextMenu m = new ContextMenu();
                    //m.MenuItems.Add(new MenuItem(" ดูข้อมูลต้นทุน"));
                    for (int i = 0; i < ltype.Count; i++)
                    {
                        m.MenuItems.Add(ltype[i], new EventHandler(mnuCost_Click));
                    }
                    int xOffset = Cursor.Position.X - this.Location.X;
                    int yOffset = Cursor.Position.Y - this.Location.Y;
                    int currentMouseOverRow = dgvAdd.HitTest(Cursor.Position.X, Cursor.Position.Y).RowIndex;

                    m.Show(dgvAdd, new Point(Cursor.Position.X - 80, Cursor.Position.Y - 250));
                }
                //m.Show(dgvAdd, new Point(xOffset, yOffset));
            }
        }
        private void setEnable(Boolean enable1)
        {
            dtpDateMOU.Enabled = enable1;
            txtContactName.Enabled = enable1;
            txtCustAddress.Enabled = enable1;
            txtCustEmail.Enabled = enable1;
            txtCustId.Enabled = enable1;
            txtCustMobile.Enabled = enable1;
            txtCustName.Enabled = enable1;
            txtCustTel.Enabled = enable1;
            txtCustMobile.Enabled = enable1;
            cboQuo.Enabled = enable1;
            CustMou.Enabled = enable1;
            cboDocType.Enabled = enable1;

            //txtMOUId.Text = mo.Id;
            //txtMouNumber.Text = mo.MOUNumber+"-"+mo.MOUNumberCnt;
            txtStaffMOUEmail.Enabled = enable1;
            txtStaffMOUMobile.Enabled = enable1;
            txtStaffMOUTel.Enabled = enable1;

            txtStaffPlaceRecordPosition.Enabled = enable1;

            dtpDateMOU.Enabled = enable1;

            cboStaffMOU.Enabled = enable1;
            cboStaffPlaceRecord.Enabled = enable1;
            CustMou.Enabled = enable1;
            txtMOUName.Enabled = enable1;
            cboMOU.Enabled = enable1;
            btnSave.Enabled = enable1;
            btnPrintMou.Enabled = enable1;
            btnReceive.Enabled = enable1;
        }
        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;
                setEnable(true);
            }
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            if (ChkUnActive.Checked)
            {
                btnUnActive.Visible = true;
                setEnable(false);

            }
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.modb.VoidMOU(txtMOUId.Text);
                this.Dispose();
            }
        }

        private void dgvAdd_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //int index = dgvAdd.CurrentCell.ColumnIndex;
            editItemTypeOld = "";
            editPlaceOld = "";
            editDateOld = "";
            if (dgvAdd.CurrentCell.ColumnIndex == colItemType)
            {
                if (dgvAdd[colItemType, e.RowIndex].Value != null)
                {
                    editItemTypeOld = dgvAdd[colItemType, e.RowIndex].Value.ToString();
                }
                else
                {
                    editItemTypeOld = "";
                }
                
                Rectangle tempRect = this.dgvAdd.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                cbo.Location = tempRect.Location;
                cbo.Width = tempRect.Width;
                try
                {
                    //cbo.Text = "11";
                }
                catch
                {
                    cbo.Text = "22";
                }
                cbo.Visible = true;
            }
            else if ((dgvAdd.CurrentCell.ColumnIndex == colPlace) && (dgvAdd[colPlace, e.RowIndex].Value != null))
            {
                editPlaceOld = dgvAdd[colPlace, e.RowIndex].Value.ToString();
            }
            else if ((dgvAdd.CurrentCell.ColumnIndex == colDatePlaceRecord) && (dgvAdd[colDatePlaceRecord, e.RowIndex].Value != null))
            {
                editDateOld = dgvAdd[colDatePlaceRecord, e.RowIndex].Value.ToString();
            }
        }

        private void dgvAdd_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            cbo.Visible = false;
        }
    }
}
