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
    public partial class FrmItemSearch : Form
    {
        CnviControl cc;
        Item it;
        int colRow = 0, colCode=1, colNameT = 2, colNameE = 3, colPrice=4, colMethod = 5, colGroup = 6, colRemark = 7, colId = 8;
        int colCnt = 9;
        Boolean pageLoad = false;
        DataTable dt = new DataTable();
        public FrmItemSearch(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            //cc = c;
            pageLoad = true;
            it = new Item();
            cboItemGroup = cc.itgdb.getCboItemGroup(cboItemGroup);
            cboMethod = cc.medb.getCboMethod(cboMethod);
            setControl();
            setGrd();
            pageLoad = false;
        }
        private void setControl()
        {
            dgvView.ColumnCount = colCnt;

            
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colNameT].Width = 200;
            dgvView.Columns[colNameE].Width = 200;
            dgvView.Columns[colMethod].Width = 200;
            dgvView.Columns[colGroup].Width = 200;
            dgvView.Columns[colRemark].Width = 200;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colCode].HeaderText = "รหัส";
            dgvView.Columns[colNameT].HeaderText = "ชื่อ";
            dgvView.Columns[colPrice].HeaderText = "Price";
            dgvView.Columns[colMethod].HeaderText = "วิธีการตรวจ";
            dgvView.Columns[colGroup].HeaderText = "กลุ่ม";
            dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";
            //dgvView.Columns[colPassword].HeaderText = "  ";

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvView.Columns[colId].Visible = false;
            dgvView.Columns[colNameE].Visible = false;
            dgvView.Font = font;
            dgvView.ReadOnly = true;
        }
        private void setGrd()
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            int row = 0;
            try
            {
                dgvView.Rows.Clear();
                if (txtSearch.Text.Equals("") && cboItemGroup.Text.Equals("") && cboMethod.Text.Equals(""))
                {
                    return;
                }
                dt = cc.itdb.selectByItGroupMethod(txtSearch.Text, cboItemGroup.Text, cboMethod.Text);
                if (dt.Rows.Count <= 0)
                {
                    return;
                }
                dgvView.RowCount = dt.Rows.Count + 1;
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (!dt.Rows[i][cc.itdb.it.Active].ToString().Equals("1"))
                        {
                            continue;
                        }
                        row++;
                        dgvView[colRow, i].Value = (row);
                        dgvView[colCode, i].Value = dt.Rows[i][cc.itdb.it.Code].ToString();
                        dgvView[colNameT, i].Value = dt.Rows[i][cc.itdb.it.NameT].ToString();
                        dgvView[colPrice, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.itdb.it.PriceSale]);
                        dgvView[colMethod, i].Value = dt.Rows[i][cc.itdb.it.MethodNameT].ToString();
                        dgvView[colGroup, i].Value = dt.Rows[i][cc.itdb.it.ItemGroupNameT].ToString();
                        dgvView[colRemark, i].Value = dt.Rows[i][cc.itdb.it.Remark].ToString();
                        dgvView[colId, i].Value = dt.Rows[i][cc.itdb.it.Id].ToString();

                        if ((row % 2) != 0)
                        {
                            dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                cc.lw.WriteLog("FrmItemSearch.setGrd Error "+ex.Message);
            }
            Cursor.Current = cursor;
        }
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.MButton:

                    dgvView.Focus();
                    return true; // signal that we've processed this key
                //case Keys.Insert:
                //    //txtInputFocus();
                //    return true;
            }
            // run base implementation
            return base.ProcessCmdKey(ref message, keys);
        }
        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Item it = cc.itdb.selectByPk(dgvView[colId, e.RowIndex].Value.ToString());
            if (!it.Id.Equals(""))
            {
                cc.itSearch = it;
                this.Dispose();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text.Length > 2)
            {
                setGrd();
            }
        }

        private void FrmItemSearch_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setGrd();
        }

        private void cboItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            setGrd();
        }

        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            setGrd();
        }

    }
}
