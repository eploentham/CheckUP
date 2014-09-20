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
    public partial class FrmBillAdd : Form
    {
        CnviControl cc;
        Boolean pageLoad;
        int colRow = 0, colMOUNumber = 1, colMOUDate = 2, colNetTotal = 3, colRemark=4;
        int colCnt = 5;
        public FrmBillAdd(CnviControl c)
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
            cboCust = cc.cudb.getCboCustomer(cboCust);
        }
        private void setGrd()
        {
            DataTable dt = cc.modb.selectByNoBilling("");
            dgvAdd.ColumnCount = colCnt;

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colMOUNumber].Width = 250;
            dgvAdd.Columns[colMOUDate].Width = 200;
            dgvAdd.Columns[colNetTotal].Width = 120;
            dgvAdd.Columns[colRemark].Width = 150;
            //dgvAdd.Columns[colAmount].Width = 180;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colMOUNumber].HeaderText = "เลขที่ข้อตกลง";
            dgvAdd.Columns[colMOUDate].HeaderText = "วันที่เริ่มข้อตกลง";
            dgvAdd.Columns[colNetTotal].HeaderText = "มูลค่าทั้งหมด";
            dgvAdd.Columns[colRemark].HeaderText = "หมายเหตุ";

            dgvAdd.Columns[colNetTotal].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvAdd.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvAdd.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dgvAdd.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvAdd.Font = font;

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colMOUNumber, i].Value = dt.Rows[i][cc.modb.mo.MOUNumber].ToString();
                    dgvAdd[colMOUDate, i].Value = dt.Rows[i][cc.modb.mo.MOUNumberCnt].ToString();
                    //dgvAdd[colNetTotal, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.modb.mo.]);
                    dgvAdd[colRemark, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.modb.mo.Remark]);
                    
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void setResize()
        {
            //dgvAdd.Width = this.Width - 80;
            dgvView.Height = this.Height - 150;
            //btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void FrmBillAdd_Load(object sender, EventArgs e)
        {

        }

        private void cboCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                Customer cu;
                cu = cc.cudb.selectByPk(cc.getValueCboItem(cboCust));
                //txtCustId.Text = cu.Id;
                txtCustAddress.Text = cu.AddressT;
                txtCustEmail.Text = cu.Email;
                txtCustFax.Text = cu.Fax;
                txtCustTel.Text = cu.Tele;
                cboContact.Text = cu.ContactName1;
            }
        }

        private void FrmBillAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
