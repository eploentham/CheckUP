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
            initConfig(itId, c);
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
            cboMethod = cc.medb.getCboMethod(cboMethod);
            cboGroup = cc.itgdb.getCboItemGroup(cboGroup);
            cboMethod.Text = it.MethodNameT;
            cboGroup.Text = it.ItemGroupNameT;
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
            it.ItemGroupId = cc.getValueCboItem(cboGroup);
            it.MethodId = cc.getValueCboItem(cboMethod);
            it.ItemGroupNameT = cboGroup.Text;
            it.MethodNameT = cboMethod.Text;
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
            if (cboMethod.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้เลือก Method", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (cboGroup.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้เลือก Group", "ป้อนข้อมูลไม่ครบ");
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

            if (!it.Code.Equals(""))
            {
                label8.Text = "รหัสซ้ำ" + it.Code + " ชื่อ " + it.NameT;
                MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + it.Code + " ชื่อ " + it.NameT, "รหัสซ้ำ");
                return;
            }
            else
            {
                label8.Text = "ok";
            }
        }

        private void btnGroupAdd_Click(object sender, EventArgs e)
        {
            FrmItemGroupAdd frm = new FrmItemGroupAdd("",cc);
            frm.ShowDialog(this);
            //cboMethod = cc.medb.getCboMethod(cboMethod);
            cboGroup = cc.itgdb.getCboItemGroup(cboGroup);
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.LightYellow;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
            btnSearch_Click(null,null);
        }

        private void txtNameT_Enter(object sender, EventArgs e)
        {
            txtNameT.BackColor = Color.LightYellow;
        }

        private void txtNameT_Leave(object sender, EventArgs e)
        {
            txtNameT.BackColor = Color.White;
        }

        private void txtNameE_Enter(object sender, EventArgs e)
        {
            txtNameE.BackColor = Color.LightYellow;
        }

        private void txtNameE_Leave(object sender, EventArgs e)
        {
            txtNameE.BackColor = Color.White;
        }

        private void cboGroup_Enter(object sender, EventArgs e)
        {
            cboGroup.BackColor = Color.LightYellow;
        }

        private void cboGroup_Leave(object sender, EventArgs e)
        {
            cboGroup.BackColor = Color.White;
        }

        private void cboMethod_Enter(object sender, EventArgs e)
        {
            cboMethod.BackColor = Color.LightYellow;
        }

        private void cboMethod_Leave(object sender, EventArgs e)
        {
            cboMethod.BackColor = Color.White;
        }

        private void txtPriceSale_Enter(object sender, EventArgs e)
        {
            txtPriceSale.BackColor = Color.LightYellow;
        }

        private void txtPriceSale_Leave(object sender, EventArgs e)
        {
            txtPriceSale.BackColor = Color.White;
        }

        private void txtPriceCost_Enter(object sender, EventArgs e)
        {
            txtPriceCost.BackColor = Color.LightYellow;
        }

        private void txtPriceCost_Leave(object sender, EventArgs e)
        {
            txtPriceCost.BackColor = Color.White;
        }

        private void txtRemark_Enter(object sender, EventArgs e)
        {
            txtRemark.BackColor = Color.LightYellow;
        }

        private void txtRemark_Leave(object sender, EventArgs e)
        {
            txtRemark.BackColor = Color.White;
        }

        private void btnMethodAdd_Click(object sender, EventArgs e)
        {
            FrmMethodAdd frm = new FrmMethodAdd("", cc);
            frm.ShowDialog(this);
            cboMethod = cc.medb.getCboMethod(cboMethod);
            //cboGroup = cc.itgdb.getCboItemGroup(cboGroup);
        }

        private void txtPriceSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPriceCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
