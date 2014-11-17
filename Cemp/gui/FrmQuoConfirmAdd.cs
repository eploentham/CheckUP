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
    public partial class FrmQuoConfirmAdd : Form
    {
        CnviControl cc;
        Quotation qu;
        int colRow = 0, colItemCode = 1, colItem = 2, colMethod = 3, colQty = 4, colPriceCost = 5, colPriceSale = 6, colAmount = 7, colId = 8, colDel = 9, colItemId = 10, colMethodId = 11, colEdit = 12;
        int colCnt = 13;
        OpenFileDialog ofd;
        String pathConfirm = "";

        public FrmQuoConfirmAdd(String quId, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            ofd = new OpenFileDialog();
            initConfig(quId);
        }
        private void initConfig(String quId)
        {
            pathConfirm = Environment.CurrentDirectory + "\\pic\\qu_confirm\\";
            qu = new Quotation();
            btnPicCertify.Visible = false;
            setControl(quId);
            setGrd(quId);
        }
        private void setControl(String quId)
        {
            qu = cc.qudb.selectByPk(quId);
            txtQuId.Text = qu.Id;
            txtCust.Text = qu.CustName;
            txtNetTotal.Text = String.Format("{0:#,###,###.00}", double.Parse(cc.cf.NumberNull1(qu.NetTotal)));
            txtQuNumber.Text = qu.QuoNumber + "-" + qu.QuoNumberCnt;
            if (qu.StatusQuo.Equals("2"))
            {
                chkComfirm.Checked = true;
                chkNoComfirm.Checked = false;
                viewPicConfirm(qu.PathPicConfirm);
            }
            else
            {
                chkComfirm.Checked = false;
                chkNoComfirm.Checked = true;
            }
        }
        private void setGrd(String quId)
        {
            DataTable dt = cc.quidb.selectByQuId(quId);
            dgvView.Rows.Clear();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colItem].Width = 250;
            dgvView.Columns[colMethod].Width = 200;
            dgvView.Columns[colQty].Width = 120;
            dgvView.Columns[colPriceSale].Width = 150;
            dgvView.Columns[colAmount].Width = 180;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colItemCode].HeaderText = "CODE";
            dgvView.Columns[colItem].HeaderText = "Parameter";
            dgvView.Columns[colMethod].HeaderText = "Method";
            dgvView.Columns[colQty].HeaderText = "QTY";
            dgvView.Columns[colPriceCost].HeaderText = "Cost";
            dgvView.Columns[colPriceSale].HeaderText = "Price";
            dgvView.Columns[colAmount].HeaderText = "Amount";
            dgvView.Columns[colId].HeaderText = "  ";

            dgvView.Columns[colQty].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvView.Columns[colPriceSale].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvView.Columns[colAmount].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvView.Columns[colId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colId].Visible = false;
            dgvView.Columns[colDel].Visible = false;
            dgvView.Columns[colItemId].Visible = false;
            dgvView.Columns[colMethodId].Visible = false;
            dgvView.Columns[colEdit].Visible = false;

            dgvView.Columns[colPriceCost].Visible = false;
            dgvView.Columns[colItemCode].ReadOnly = true;
            dgvView.ReadOnly = true;

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dgvAdd.Rows[0].Cells = newColumn;
                    //DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(dgvAdd.Rows[i].Cells[colItem]);
                    //cell.DataSource = newColumn;

                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colItemCode, i].Value = dt.Rows[i][cc.quidb.qui.ItemCode].ToString();
                    dgvView[colItem, i].Value = dt.Rows[i][cc.quidb.qui.ItemDescription].ToString();
                    dgvView[colMethod, i].Value = dt.Rows[i][cc.quidb.qui.MethodDescription].ToString();
                    dgvView[colQty, i].Value = dt.Rows[i][cc.quidb.qui.Qty].ToString();
                    dgvView[colPriceCost, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.quidb.qui.PriceCost]);
                    dgvView[colPriceSale, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.quidb.qui.PriceSale]);
                    dgvView[colAmount, i].Value = String.Format("{0:#,###,###.00}", dt.Rows[i][cc.quidb.qui.Amount]);
                    dgvView[colItemId, i].Value = dt.Rows[i][cc.quidb.qui.ItemId].ToString();
                    dgvView[colMethodId, i].Value = dt.Rows[i][cc.quidb.qui.MethodId].ToString();
                    dgvView[colId, i].Value = dt.Rows[i][cc.quidb.qui.Id].ToString();
                    dgvView[colDel, i].Value = "";
                    dgvView[colEdit, i].Value = "";
                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private void savePicConfirm()
        {
            String fileName = "", fileName1 = "", ex = "";
            fileName = pathConfirm + txtQuId.Text + "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals(""))
            {
                return;
            }
            fileName1 = ofd.FileName;
            ex = fileName1.Substring(ofd.FileName.IndexOf("."));
            //fbd.SelectedPath = Environment.CurrentDirectory + "\\pic";
            //DirectoryInfo dir = new DirectoryInfo(ofd.FileName);
            try
            {
                if (System.IO.File.Exists(ofd.FileName))
                {
                    bool exists = System.IO.Directory.Exists(pathConfirm);
                    if (!exists) System.IO.Directory.CreateDirectory(pathConfirm);
                    Image image = Image.FromFile(ofd.FileName);
                    image.Save(fileName + ex);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(""+ex1.Message, "Error");
            }
            
            cc.qudb.updatePathPicConfirm(txtQuId.Text, fileName + ex);
            viewPicConfirm(fileName + ex);
        }
        private void viewPicConfirm(String filename)
        {
            if (System.IO.File.Exists(filename))
            {
                picCertify.Image = Image.FromFile(filename);
                picCertify.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void FrmQuoConfirmAdd_Load(object sender, EventArgs e)
        {

        }

        private void chkComfirm_Click(object sender, EventArgs e)
        {
            btnPicCertify.Visible = true;
        }

        private void chkNoComfirm_Click(object sender, EventArgs e)
        {
            btnPicCertify.Visible = false;
        }

        private void btnPicCertify_Click(object sender, EventArgs e)
        {
            savePicConfirm();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยืนยัน", "ยืนยัน", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.qudb.updateStatusConfirm(txtQuId.Text);
                this.Dispose();
            }
        }
    }
}
