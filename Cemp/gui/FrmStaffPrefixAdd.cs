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
    public partial class FrmStaffPrefixAdd : Form
    {
        CnviControl cc;
        Prefix pre;
        public FrmStaffPrefixAdd(String preId, CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig(preId);
            label9.Visible = false;
        }
        private void initConfig(String preId)
        {
            pre = new Prefix();
            setControl(preId);
        }
        private void setControl(String preId)
        {
            pre = cc.predb.selectByPk(preId);
            //txtCode.Text = itg.Code;
            txtId.Text = pre.Id;
            txtNameE.Text = pre.NameE;
            txtNameT.Text = pre.NameT;
            //txtRemark.Text = pre.Remark;
            //txtSort1.Text = pre.Sort1;
            if (txtSort1.Text.Equals(""))
            {
                txtSort1.Text = cc.itgdb.selectSortMax();
            }
            if (pre.Active.Equals("1"))
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
            if (pre.Active.Equals(""))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
        }
        private void getPrerfix()
        {
            //itg.Code = txtCode.Text;
            pre.Id = txtId.Text;
            pre.NameE = txtNameE.Text;
            pre.NameT = txtNameT.Text;
            pre.Active = "1";
            //pre.Remark = txtRemark.Text;
            //pre.Sort1 = txtSort1.Text;
            //pre.userCreate = cc.sf.Id;
            //pre.userModi = cc.sf.Id;
        }
        private void FrmStaffPrefixAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameE.Text.Trim().Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อน Name", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtNameT.Text.Trim().Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนชื่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtId.Text.Equals(""))
            {
                //me = cc.medb.selectByCode(txtCode.Text);
                //if (!me.Code.Equals(""))
                //{
                //    MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + me.Code + " ชื่อ " + me.NameT, "รหัสซ้ำ");
                //    return;
                //}
                //if (!cu.Code.Equals(""))
                //{
                //    MessageBox.Show("ป้อนชื่อซ้ำ\nรหัส " + cu.Code + " ชื่อ " + cu.NameT, "ชื่อซ้ำ");
                //    return;
                //}
            }
            getPrerfix();
            //if (itg.Code.Equals(""))
            //{
            //    itg.Code = cc.medb.getMethodCode();
            //}
            if (cc.predb.insertBank(pre).Length >= 1)
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
                //txtCode.Enabled = true;
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
                //txtCode.Enabled = false;
                txtNameE.Enabled = false;
                txtNameT.Enabled = false;
                txtRemark.Enabled = false;
            }
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก" + txtNameT.Text, "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.medb.VoidMethod(txtId.Text);
                this.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Analysis itg = cc.anadb.selectByNameT(txtNameT.Text);
            if (!itg.NameT.Equals(""))
            {
                if (!txtId.Text.Equals(itg.Id))
                {
                    label8.Text = "ชื่อซ้ำ" + itg.NameT + " ชื่อ " + itg.NameE;
                    MessageBox.Show("ป้อนชื่อซ้ำ\nชื่อ " + itg.NameT + " Name " + itg.NameE, "ชื่อซ้ำ");
                    return;
                }
            }
            else
            {
                label8.Text = "ok";
            }
        }
    }
}
