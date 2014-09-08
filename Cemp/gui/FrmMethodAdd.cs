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
    public partial class FrmMethodAdd : Form
    {
        CnviControl cc;
        Method me;
        public FrmMethodAdd(String meId,CnviControl c)
        {
            InitializeComponent();
            initConfig(meId,c);
        }
        private void initConfig(String meId, CnviControl c)
        {
            cc = c;
            me = new Method();
            setControl(meId);
            if (meId.Equals(""))
            {
                label9.Text = cc.medb.getMaxCode();
            }
            else
            {
                label9.Visible = false;
            }
            btnUnActive.Visible = false;
            label8.Text = "";
            //txtCode.ReadOnly = true;
        }
        private void setControl(String meId)
        {
            me = cc.medb.selectByPk(meId);
            txtCode.Text = me.Code;
            txtId.Text = me.Id;
            txtNameE.Text = me.NameE;
            txtNameT.Text = me.NameT;
            txtRemark.Text = me.Remark;
            if (me.Active.Equals("1"))
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
            if (me.Active.Equals(""))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
        }
        private void getMethod()
        {
            me.Code = txtCode.Text;
            me.Id = txtId.Text;
            me.NameE = txtNameE.Text;
            me.NameT = txtNameT.Text;
            me.Remark = txtRemark.Text;
        }

        private void FrmMethodAdd_Load(object sender, EventArgs e)
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
                me = cc.medb.selectByCode(txtCode.Text);
                if (!me.Code.Equals(""))
                {
                    MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + me.Code + " ชื่อ " + me.NameT, "รหัสซ้ำ");
                    return;
                }
                //if (!cu.Code.Equals(""))
                //{
                //    MessageBox.Show("ป้อนชื่อซ้ำ\nรหัส " + cu.Code + " ชื่อ " + cu.NameT, "ชื่อซ้ำ");
                //    return;
                //}
            }
            getMethod();
            if (me.Code.Equals(""))
            {
                me.Code = cc.medb.getMethodCode();
            }
            if (cc.medb.insertMethod(me).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;

                txtId.Enabled = true;
                txtCode.Enabled = true;
                txtNameE.Enabled = true;
                txtNameT.Enabled = true;
                txtRemark.Enabled = true;
            }
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            if (ChkUnActive.Checked)
            {
                btnUnActive.Visible = true;

                txtId.Enabled = false;
                txtCode.Enabled = false;
                txtNameE.Enabled = false;
                txtNameT.Enabled = false;
                txtRemark.Enabled = false;
            }
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก"+txtCode.Text+"  "+txtNameT.Text, "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.medb.VoidMethod(txtId.Text);
                this.Dispose();
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.LightYellow;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
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

        private void txtRemark_Enter(object sender, EventArgs e)
        {
            txtRemark.BackColor = Color.LightYellow;
        }

        private void txtRemark_Leave(object sender, EventArgs e)
        {
            txtRemark.BackColor = Color.White;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Method me = cc.medb.selectByCode(txtCode.Text);
            //label8.Text = "รหัสซ้ำ" + me.Code + " ชื่อ " + me.NameT;
            if (!me.Code.Equals(""))
            {
                label8.Text = "รหัสซ้ำ" + me.Code + " ชื่อ " + me.NameT;
                MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + me.Code + " ชื่อ " + me.NameT, "รหัสซ้ำ");
                return;
            }
            else
            {
                label8.Text = "ok";
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
