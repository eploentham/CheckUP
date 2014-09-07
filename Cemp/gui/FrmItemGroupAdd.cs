﻿using Cemp.Control;
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
    public partial class FrmItemGroupAdd : Form
    {
        CnviControl cc;
        ItemGroup itg;
        public FrmItemGroupAdd(String itgId, CnviControl c)
        {
            InitializeComponent();
            initConfig(itgId, c);
            label9.Visible = false;
        }
        private void initConfig(String itgId, CnviControl c)
        {
            cc = c;
            itg = new ItemGroup();
            setControl(itgId);
            //if (itgId.Equals(""))
            //{
            //    label9.Text = cc.medb.getMaxCode();
            //}
            //else
            //{
            //    label9.Visible = false;
            //}
            btnUnActive.Visible = false;
            //txtCode.ReadOnly = true;
        }
        private void setControl(String itgId)
        {
            itg = cc.itgdb.selectByPk(itgId);
            //txtCode.Text = itg.Code;
            txtId.Text = itg.Id;
            txtNameE.Text = itg.NameE;
            txtNameT.Text = itg.NameT;
            txtRemark.Text = itg.Remark;
            if (itg.Active.Equals("1"))
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
            if (itg.Active.Equals(""))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
        }
        private void getMethod()
        {
            //itg.Code = txtCode.Text;
            itg.Id = txtId.Text;
            itg.NameE = txtNameE.Text;
            itg.NameT = txtNameT.Text;
            itg.Remark = txtRemark.Text;
        }
        private void FrmItemGroupAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameE.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อน Name", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtNameT.Text.Equals(""))
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
            getMethod();
            //if (itg.Code.Equals(""))
            //{
            //    itg.Code = cc.medb.getMethodCode();
            //}
            if (cc.itgdb.insertItemGroup(itg).Length >= 1)
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
            if (MessageBox.Show("ต้องการยกเลิก"  + txtNameT.Text, "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.medb.VoidMethod(txtId.Text);
                this.Dispose();
            }
        }
    }
}
