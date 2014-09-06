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
    public partial class FrmItemAdd : Form
    {
        CnviControl cc;
        Item it;
        public FrmItemAdd(String itId,CnviControl c)
        {
            InitializeComponent();
        }
        private void initConfig(String itId, CnviControl c)
        {
            cc = c;
            it = new Item();
            setControl(itId);
            if (itId.Equals(""))
            {
                label9.Text = cc.itdb.getMaxCode();
            }
            else
            {
                label9.Visible = false;
            }
            
            btnUnActive.Visible = false;
            //setGrd();
        }
        private void setControl(String itId)
        {
            it = cc.itdb.selectByPk(itId);
            txtCode.Text = it.Code;
            txtId.Text = it.Id;
            txtNameE.Text = it.NameE;
            txtNameT.Text = it.NameT;
            txtRemark.Text = it.Remark;
            txtPriceCost.Text = it.PriceCost;
            txtPriceSale.Text = it.PriceSale;
            if (it.Active.Equals("1"))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
            else
            {
                chkActive.Checked = false;
                ChkUnActive.Checked = true;
                btnUnActive.Visible = true;
            }
            if (it.Active.Equals(""))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
        }
        private void getItem()
        {
            it.Code = txtCode.Text;
            it.Id = txtId.Text;
            it.NameE = txtNameE.Text;
            it.NameT = txtNameT.Text;
            it.Remark = txtRemark.Text;
            it.PriceSale = txtPriceSale.Text;
            it.PriceCost = txtPriceCost.Text;
        }
        private void FrmItemAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameE.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนชื่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtId.Text.Equals(""))
            {
                it = cc.itdb.selectByCode(txtCode.Text);
                if (!it.Code.Equals(""))
                {
                    MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + it.Code + " ชื่อ " + it.NameT, "รหัสซ้ำ");
                    return;
                }
                //if (!cu.Code.Equals(""))
                //{
                //    MessageBox.Show("ป้อนชื่อซ้ำ\nรหัส " + cu.Code + " ชื่อ " + cu.NameT, "ชื่อซ้ำ");
                //    return;
                //}
            }
            getItem();
            if (it.Code.Equals(""))
            {
                it.Code = cc.itdb.getItemCode();
            }
            if (cc.itdb.insertItem(it).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Item it = cc.itdb.selectByCode(txtCode.Text);
            label8.Text = "รหัสซ้ำ" + it.Code + " ชื่อ " + it.NameT;
            if (!it.Code.Equals(""))
            {
                MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + it.Code + " ชื่อ " + it.NameT, "รหัสซ้ำ");
                return;
            }
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            FrmItemGroupAdd frm = new FrmItemGroupAdd();
            frm.ShowDialog(this);

        }
    }
}
