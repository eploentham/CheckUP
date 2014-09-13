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
    public partial class FrmMOUAdd : Form
    {
        CnviControl cc;
        MOU mo;
        public FrmMOUAdd(String moId, CnviControl c)
        {
            InitializeComponent();
            initConfig(moId,c);
        }
        private void initConfig(String moId, CnviControl c)
        {
            cc = c;
            mo = new MOU();
            setControl(moId);
        }
        private void setControl(String moId)
        {
            txtContactName.Text = mo.ContactName;
            txtCustAddress.Text = mo.CustAddress;
            txtCustEmail.Text = mo.CustEmail;
            txtCustId.Text = mo.CustName;
            txtCustMobile.Text = mo.CustMobile;
            txtCustName.Text = mo.CustName;
            txtCustTel.Text = mo.CustTel;
            txtCustMobile.Text = mo.CustMobile;
            cboQuo.Text = "";
            cboCustMou.Text = "";

            txtMOUId.Text = mo.Id;
            txtMouNumber.Text = mo.MOUNumber+"-"+mo.MOUNumberCnt;
            txtStaffEmail.Text = mo.StaffEmail;
            txtStaffMobile.Text = mo.StaffMobile;
            txtStaffTel.Text = mo.StaffTel;
            
            cboStaff.Text = mo.StaffName;
            cboStaffMOU.Text = mo.StaffMOU;

            setGrd(moId);
        }
        private void getMOU()
        {

        }
        private void setGrd(String moId)
        {

        }

        private void FrmMOUAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
