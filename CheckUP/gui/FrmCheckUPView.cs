using CheckUP.Control;
using CheckUP.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUP
{
    public partial class FrmCheckUPView : Form
    {
        CheckControl cc;
        int colCnt = 7;
        int colRow = 0, colDesc = 2, colRemark = 3, colId = 4, colCustNameT = 1, colCheckUpDate = 6, colPriority = 5;
        public FrmCheckUPView(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            //dt = lc.selectStaffAll();
            setGrd();
            dgvView.ReadOnly = true;
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80 - btnAdd.Width;
            dgvView.Height = this.Height - 150;
            btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        public void setGrd()
        {
            DataTable dt = new DataTable();
            dt = cc.cucdb.selectAll();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colCustNameT].Width = 450;
            dgvView.Columns[colDesc].Width = 150;
            dgvView.Columns[colRemark].Width = 120;
            dgvView.Columns[colId].Width = 80;
            dgvView.Columns[colCheckUpDate].Width = 120;
            dgvView.Columns[colPriority].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colCustNameT].HeaderText = "code";
            dgvView.Columns[colDesc].HeaderText = "ชื่อ";
            dgvView.Columns[colRemark].HeaderText = "หมายเหตุ";
            dgvView.Columns[colId].HeaderText = "id";
            dgvView.Columns[colPriority].HeaderText = "สิทธิใช้งาน";
            dgvView.Columns[colCheckUpDate].HeaderText = "  ";

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colCustNameT, i].Value = dt.Rows[i][cc.cucdb.cuc.CustNameT].ToString();
                    dgvView[colDesc, i].Value = dt.Rows[i][cc.cucdb.cuc.Description].ToString();
                    dgvView[colRemark, i].Value = dt.Rows[i][cc.cucdb.cuc.Remark].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][cc.cucdb.cuc.Id].ToString();

                    dgvView[colCheckUpDate, i].Value = dt.Rows[i][cc.cucdb.cuc.CheckUpDate].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void FrmCheckUPView_Load(object sender, EventArgs e)
        {

        }

        private void FrmCheckUPView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCheckUPAdd frm = new FrmCheckUPAdd("",true, cc);
            //frm.setControl("");
            this.Hide();
            frm.ShowDialog(this);
            this.Show();
            setGrd();
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
            //if (e.ColumnIndex == colId)
            //{
            FrmCheckUPAdd frm = new FrmCheckUPAdd(dgvView[colId, e.RowIndex].Value.ToString(), false, cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            this.Hide();
            frm.ShowDialog(this);
            this.Show();
            setGrd();
            //}            
        }
    }
}
