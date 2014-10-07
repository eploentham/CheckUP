using Cemp.Control;
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
    public partial class FrmPOItemSearch : Form
    {
        CnviControl cc;
        Boolean pageLoad = false;
        DataTable dt = new DataTable();
        int colRow = 0, colCode = 1, colNameT = 2, colPrice = 3, colQty = 4, colRemark = 5, colId =6;
        int colCnt = 7;
        public FrmPOItemSearch(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            pageLoad = true;

            setControl();
            setGrd();
            pageLoad = false;
        }
        private void setControl()
        {
            dgvView.ColumnCount = colCnt;


            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colCode].Width = 200;
            dgvView.Columns[colNameT].Width = 200;
            dgvView.Columns[colPrice].Width = 200;
            dgvView.Columns[colQty].Width = 200;
            dgvView.Columns[colRemark].Width = 200;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colCode].HeaderText = "รหัส";
            dgvView.Columns[colNameT].HeaderText = "ชื่อ";
            dgvView.Columns[colPrice].HeaderText = "Price";
            dgvView.Columns[colQty].HeaderText = "จำนวน";
            //dgvView.Columns[colRemark].HeaderText = "กลุ่ม";
            dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";
            //dgvView.Columns[colPassword].HeaderText = "  ";

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvView.Columns[colId].Visible = false;
            //dgvView.Columns[colNameE].Visible = false;
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
                //if (txtSearch.Text.Equals("") && cboItemGroup.Text.Equals("") && cboMethod.Text.Equals(""))
                //{
                //    return;
                //}
                dt = cc.poidb.selectByName(txtSearch.Text);
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
                        //dgvView[colMethod, i].Value = dt.Rows[i][cc.itdb.it.MethodNameT].ToString();
                        //dgvView[colGroup, i].Value = dt.Rows[i][cc.itdb.it.ItemGroupNameT].ToString();
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
                cc.lw.WriteLog("FrmItemSearch.setGrd Error " + ex.Message);
            }
            Cursor.Current = cursor;
        }
        private void FrmPOItemSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
