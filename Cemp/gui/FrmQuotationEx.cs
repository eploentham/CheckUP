using Cemp.Control;
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
    public partial class FrmQuotationEx : Form
    {
        CnviControl cc;
        public FrmQuotationEx(CnviControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            txtGoSiteA.Enabled = false;
            txtDistanceDailyA.Enabled = false;
            txtRentCarA.Enabled = false;
            txtEx1A.Enabled = false;
            txtEx2A.Enabled = false;
            setVisibleGoSite(false);
            setVisibleDistanceDaily(false);
            setVisibleRentCar(false);
        }
        private void calGoSite()
        {
            txtGoSiteA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull1(txtGoSiteN.Text)) * Double.Parse(cc.cf.NumberNull1(txtGoSiteD.Text)) * Double.Parse(cc.cf.NumberNull1(txtGoSiteP.Text))); 
        }
        private void calDistanceDaily()
        {
            txtDistanceDailyA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull1(txtDistanceDailyN.Text)) * Double.Parse(cc.cf.NumberNull1(txtDistanceDailyD.Text)) * Double.Parse(cc.cf.NumberNull1(txtDistanceDailyP.Text)));
        }
        private void calRentCar()//txtRentCarN
        {
            txtRentCarA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull1(txtRentCarN.Text)) * Double.Parse(cc.cf.NumberNull1(txtRentCarD.Text)) * Double.Parse(cc.cf.NumberNull1(txtRentCarP.Text)));
        }
        private void calAmount()
        {
            //Double aaa = 0;
            //aaa = Double.Parse(cc.cf.NumberNull11(txtGoSiteA.Text.Replace(",", ""))) * Double.Parse(cc.cf.NumberNull11(txtDistanceDailyA.Text.Replace(",", ""))) *
            //    Double.Parse(cc.cf.NumberNull11(txtRentCarA.Text.Replace(",", ""))) * Double.Parse(cc.cf.NumberNull11(txtEx1A.Text.Replace(",", ""))) * Double.Parse(cc.cf.NumberNull11(txtEx2A.Text.Replace(",", "")));
            txtAmount.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull1(txtGoSiteA.Text.Replace(",", ""))) + Double.Parse(cc.cf.NumberNull1(txtDistanceDailyA.Text.Replace(",", ""))) +
                Double.Parse(cc.cf.NumberNull1(txtRentCarA.Text.Replace(",", ""))) + Double.Parse(cc.cf.NumberNull1(txtEx1A.Text.Replace(",", ""))) + Double.Parse(cc.cf.NumberNull1(txtEx2A.Text.Replace(",", ""))));
        }
        private void setVisibleGoSite(Boolean s)
        {
            txtGoSiteN.Visible = s;
            txtGoSiteD.Visible = s;
            txtGoSiteP.Visible = s;
            txtGoSiteA.Visible = s;
            label2.Visible = s;
            label1.Visible = s;
            label14.Visible = s;
            label3.Visible = s;

        }
        private void setVisibleDistanceDaily(Boolean s)
        {
            txtDistanceDailyN.Visible = s;
            txtDistanceDailyD.Visible = s;
            txtDistanceDailyP.Visible = s;
            txtDistanceDailyA.Visible = s;
            label13.Visible = s;
            label6.Visible = s;
            label5.Visible = s;
            label4.Visible = s;

        }
        private void setVisibleRentCar(Boolean s)
        {
            txtRentCarN.Visible = s;
            txtRentCarD.Visible = s;
            txtRentCarP.Visible = s;
            txtRentCarA.Visible = s;
            label8.Visible = s;
            label9.Visible = s;
            label12.Visible = s;
            label7.Visible = s;

        }

        private void FrmQuotationEx_Load(object sender, EventArgs e)
        {

        }

        private void txtGoSiteD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGoSiteP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDistanceDailyD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDistanceDailyP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRentCarD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRentCarP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGoSiteD_KeyUp(object sender, KeyEventArgs e)
        {
            calGoSite();
        }

        private void txtGoSiteP_KeyUp(object sender, KeyEventArgs e)
        {
            calGoSite();
        }

        private void txtDistanceDailyD_KeyUp(object sender, KeyEventArgs e)
        {
            calDistanceDaily();
        }

        private void txtDistanceDailyP_KeyUp(object sender, KeyEventArgs e)
        {
            calDistanceDaily();
        }

        private void txtRentCarD_KeyUp(object sender, KeyEventArgs e)
        {
            calRentCar();
        }

        private void txtRentCarP_KeyUp(object sender, KeyEventArgs e)
        {
            calRentCar();
        }

        private void txtGoSiteA_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtDistanceDailyA_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtRentCarA_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEx1A_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEx2A_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtGoSiteA_TextChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void txtDistanceDailyA_TextChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void txtRentCarA_TextChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void txtEx1A_TextChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void txtEx2A_TextChanged(object sender, EventArgs e)
        {
            calAmount();
        }

        private void chkGoSite_Click(object sender, EventArgs e)
        {
            if (chkGoSite.Checked)
            {
                setVisibleGoSite(true);
            }
            else
            {
                setVisibleGoSite(false);
            }
        }

        private void chkDistanceDaily_Click(object sender, EventArgs e)
        {
            if (chkDistanceDaily.Checked)
            {
                setVisibleDistanceDaily(true);
            }
            else
            {
                setVisibleDistanceDaily(false);
            }
        }

        private void chkRentCar_Click(object sender, EventArgs e)
        {
            if (chkRentCar.Checked)
            {
                setVisibleRentCar(true);
            }
            else
            {
                setVisibleRentCar(false);
            }
        }

        private void txtRentCarN_KeyUp(object sender, KeyEventArgs e)
        {
            calRentCar();
        }

        private void txtRentCarN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGoSiteN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDistanceDailyN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGoSiteN_KeyUp(object sender, KeyEventArgs e)
        {
            calGoSite();
            
        }

        private void txtDistanceDailyN_KeyUp(object sender, KeyEventArgs e)
        {
            calDistanceDaily();
        }
    }
}
