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
    public partial class FrmResultView : Form
    {
        CnviControl cc;
        int colRow = 0, colCustName = 1, colDate=2, colId=3;
        int colCnt = 4;
        public FrmResultView(String sfId, CnviControl c)
        {
            InitializeComponent();
            initConfig(sfId, c);
        }
        private void initConfig(String sfId, CnviControl c)
        {
            cc = c;
            dgvView.ReadOnly = true;
            setGrd();
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80 - btnAdd.Width;
            dgvView.Height = this.Height - 150;
            btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {
            DataTable dt = cc.rsdb.selectAll();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colCustName].Width = 300;
            dgvView.Columns[colDate].Width = 120;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colCustName].HeaderText = "code";
            dgvView.Columns[colDate].HeaderText = "วันที่ออกผล";


            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colCustName, i].Value = dt.Rows[i][cc.rsdb.rs.CustNameT].ToString();
                    dgvView[colDate, i].Value = dt.Rows[i][cc.rsdb.rs.MeasureDate].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][cc.rsdb.rs.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }

        private void FrmResultView_Load(object sender, EventArgs e)
        {

        }

        private void FrmResultView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmResultAdd frm = new FrmResultAdd("",cc);
            this.Hide();
            frm.ShowDialog(this);
            setGrd();
            this.Show();
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvView[colId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmResultAdd frm = new FrmResultAdd(dgvView[colId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            this.Hide();
            frm.ShowDialog(this);
            setGrd();
            this.Show();
        }
    }
}
