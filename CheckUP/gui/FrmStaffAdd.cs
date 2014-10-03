﻿using CheckUP.Control;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cemp.gui
{
    public partial class FrmStaffAdd : Form
    {
        CheckControl cc;
        Staff s;

        public FrmStaffAdd(String sfId, CheckControl c)
        {
            InitializeComponent();
            initConfig(sfId,c);
        }
        private void initConfig(String sfId, CheckControl c)
        {
            cc = new CheckControl();
            s = new Staff();
            cboPosition = cc.sfdb.getCboPosition(cboPosition);
            label9.Text = "";
            setControl(sfId);
        }
        public void setControl(String sfId)
        {
            s = cc.sfdb.selectByPk(sfId);
            txtStaffId.Text = s.Id;
            txtStaffCode.Text = s.Code;
            txtStaffName.Text = s.NameT;
            txtStaffRemark.Text = s.Remark;
            txtTel.Text = s.Tele;
            txtFax.Text = s.Fax;
            txtEmail.Text = s.Email;
            cboPosition.Text = s.PositionName;
            txtMobile.Text = s.Mobile;


            if (s.Active.Equals("1") || sfId.Equals(""))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
            else
            {
                chkActive.Checked = false;
                ChkUnActive.Checked = true;
            }
            if (s.Priority.Equals("1"))
            {
                chkInput.Checked=true;
            }
            else if (s.Priority.Equals("2"))
            {
                chkApprove.Checked = true;
            }
            else if (s.Priority.Equals("3"))
            {
                chkAdmin.Checked = true;
            }
        }
        private Staff getControl()
        {
            s.Id = txtStaffId.Text;
            s.Code = txtStaffCode.Text;
            s.NameT = txtStaffName.Text;
            s.Remark = txtStaffRemark.Text;
            s.Tele = txtTel.Text;
            s.Fax = txtFax.Text;
            s.Email = txtEmail.Text;
            s.PositionName = cboPosition.Text;
            s.PositionId = cc.getValueCboItem(cboPosition);
            s.Mobile = txtMobile.Text;
            
            if (chkInput.Checked)
            {
                s.Priority = "1";
            }
            else if (chkApprove.Checked)
            {
                s.Priority = "2";
            }
            else if (chkAdmin.Checked)
            {
                s.Priority = "3";
            }
            //if (chkActive.Checked)
            //{
                s.Active = "1";
            //}
            return s;
        }
        private void txtStaffCodeFocus()
        {
            txtStaffCode.SelectAll();
            txtStaffCode.Focus();
        }
        private void txtStaffNameFocus()
        {
            txtStaffName.SelectAll();
            txtStaffName.Focus();
        }
        private void txtStaffRemarkFocus()
        {
            txtStaffRemark.SelectAll();
            txtStaffRemark.Focus();
        }
        private void FrmStaffAdd_Load(object sender, EventArgs e)
        {
            txtStaffCodeFocus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนชื่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtStaffCode.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนรหัส", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtStaffId.Text.Equals(""))
            {
                s = cc.sfdb.selectByCode(txtStaffCode.Text);
                if (!s.Code.Equals(""))
                {
                    MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + s.Code + " ชื่อ " + s.NameT, "รหัสซ้ำ");
                    return;
                }
                if (!s.NameT.Equals(""))
                {
                    MessageBox.Show("ป้อนชื่อซ้ำ\nรหัส "+s.Code+" ชื่อ "+ s.NameT, "ชื่อซ้ำ");
                    return;
                }
            }
            s = getControl();
            if (cc.sfdb.insertStaff(s).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
            //setControl(s.Id);
        }

        private void txtStaffCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStaffNameFocus();
            }            
        }

        private void txtStaffName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStaffRemarkFocus();
            }            
        }

        private void txtStaffRemark_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkActive.Focus();
            }
        }

        private void txtStaffCode_Enter(object sender, EventArgs e)
        {
            txtStaffCode.BackColor = Color.LightYellow;
        }

        private void txtStaffCode_Leave(object sender, EventArgs e)
        {
            txtStaffCode.BackColor = Color.White;
            s = cc.sfdb.selectByCode(txtStaffCode.Text);
            if (!s.Code.Equals(""))
            {
                MessageBox.Show("ป้อนรหัสซ้ำ\nรหัส " + s.Code + " ชื่อ " + s.NameT, "รหัสซ้ำ");
                label9.Text = "รหัสซ้ำ";
                txtStaffCode.BackColor = Color.Red;
                return;
            }
            else
            {
                label9.Text = "OK";
            }
        }

        private void txtStaffName_Enter(object sender, EventArgs e)
        {
            txtStaffName.BackColor = Color.LightYellow;
        }

        private void txtStaffName_Leave(object sender, EventArgs e)
        {
            txtStaffName.BackColor = Color.White;
        }

        private void txtStaffRemark_Enter(object sender, EventArgs e)
        {
            txtStaffRemark.BackColor = Color.LightYellow;
        }

        private void txtStaffRemark_Leave(object sender, EventArgs e)
        {
            txtStaffRemark.BackColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.sfdb.VoidStaff(txtStaffId.Text);
                this.Dispose();
            }
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            if (ChkUnActive.Checked)
            {
                btnUnActive.Visible = true;

                txtStaffCode.Enabled = false;
                txtStaffName.Enabled = false;
                txtStaffRemark.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;

                txtStaffCode.Enabled = true;
                txtStaffName.Enabled = true;
                txtStaffRemark.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                groupBox2.Enabled = true;
            }
        }
    }
}
