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
    public partial class FrmQuotationEx : Form
    {
        CnviControl cc;
        QuotationEx quex;
        String quId;
        public FrmQuotationEx(CnviControl c, String quoId, String quexId)
        {
            InitializeComponent();
            cc = c;
            quId = quoId;
            initConfig(quexId);
        }
        private void initConfig(String quexId)
        {
            quex = new QuotationEx();
            txtGoSiteA.Enabled = false;
            txtDistanceDailyA.Enabled = false;
            txtRentCarA.Enabled = false;
            txtEx1A.Enabled = false;
            txtEx2A.Enabled = false;
            txtRentRoomA.Enabled = false;
            txtAmount.Enabled = false;
            setVisibleGoSite(false);
            setVisibleDistanceDaily(false);
            setVisibleRentCar(false);
            setVisibleRentRoom(false);
            setControl(quexId);
        }
        private void getQuotationEx()
        {
            quex.Active = "1";
            quex.Amount = txtAmount.Text;
            quex.DistanceDailyA = txtDistanceDailyA.Text;
            quex.DistanceDailyD = txtDistanceDailyD.Text;
            quex.DistanceDailyN = txtDistanceDailyN.Text;
            quex.DistanceDailyP = txtDistanceDailyP.Text;
            quex.Ex1A = txtEx1A.Text;
            quex.Ex2A = txtEx2A.Text;
            quex.GoSiteA = txtGoSiteA.Text;
            quex.GositeD = txtGoSiteD.Text;
            quex.GoSiteN = txtGoSiteN.Text;
            quex.GoSiteP = txtGoSiteP.Text;
            quex.Id = txtId.Text;
            quex.Remark = "";
            quex.RentCarA = txtRentCarA.Text;
            quex.RentCarD = txtRentCarD.Text;
            quex.RentCarN = txtRentCarN.Text;
            quex.RentCarP = txtRentCarP.Text;
            quex.RentRoomA = txtRentRoomA.Text;
            quex.RentRoomD = txtRentRoomD.Text;
            quex.RentRoomN = txtRentRoomN.Text;
            quex.RentRoomP = txtRentRoomP.Text;
            if (chkDistanceDaily.Checked)
            {
                quex.StatusDistanceDaily = "1";
            }
            else
            {
                quex.StatusDistanceDaily = "3";
            }
            if (chkEx1.Checked)
            {
                quex.StatusEx1 = "1";
            }
            else
            {
                quex.StatusEx1 = "3";
            }
            if (chkEx2.Checked)
            {
                quex.StatusEx2 = "1";
            }
            else
            {
                quex.StatusEx2 = "3";
            }
            if (chkGoSite.Checked)
            {
                quex.StatusGoSite = "1";
            }
            else
            {
                quex.StatusGoSite = "3";
            }
            if (chkRentCar.Checked)
            {
                quex.StatusRentCar = "1";
            }
            else
            {
                quex.StatusRentCar = "3";
            }
            if (chkRentRoom.Checked)
            {
                quex.StatusRentRoom = "1";
            }
            else
            {
                quex.StatusRentRoom = "3";
            }
        }
        private void setControl(String quexId)
        {
            quex = cc.quexdb.selectByPk(quexId);
            quex.Amount = txtAmount.Text;
            txtDistanceDailyA.Text = quex.DistanceDailyA;
            txtDistanceDailyD.Text = quex.DistanceDailyD;
            txtDistanceDailyN.Text = quex.DistanceDailyN;
            txtDistanceDailyP.Text = quex.DistanceDailyP;
            txtEx1A.Text = quex.Ex1A;
            txtEx2A.Text = quex.Ex2A;
            txtGoSiteA.Text = quex.GoSiteA;
            txtGoSiteD.Text = quex.GositeD;
            txtGoSiteN.Text = quex.GoSiteN;
            txtGoSiteP.Text = quex.GoSiteP;
            txtId.Text = quex.Id;
            //quex.Remark = "";
            txtRentCarA.Text = quex.RentCarA;
            txtRentCarD.Text = quex.RentCarD;
            txtRentCarN.Text = quex.RentCarN;
            txtRentCarP.Text = quex.RentCarP;
            txtRentRoomA.Text = quex.RentRoomA;
            txtRentRoomD.Text = quex.RentRoomD;
            txtRentRoomN.Text = quex.RentRoomN;
            txtRentRoomP.Text = quex.RentRoomP;
            if (quex.StatusDistanceDaily.Equals("1"))
            {
                chkDistanceDaily.Checked = true;
                setVisibleDistanceDaily(true);
            }
            else
            {
                chkDistanceDaily.Checked = false;
                setVisibleDistanceDaily(false);
            }
            if (quex.StatusGoSite.Equals("1"))
            {
                chkGoSite.Checked = true;
                setVisibleGoSite(true);
            }
            else
            {
                chkGoSite.Checked = false;
                setVisibleGoSite(false);
            }
            if (quex.StatusRentCar.Equals("1"))
            {
                chkRentCar.Checked = true;
                setVisibleRentCar(true);
            }
            else
            {
                chkRentCar.Checked = false;
                setVisibleRentCar(false);
            }
            if (quex.StatusRentRoom.Equals("1"))
            {
                chkRentRoom.Checked = true;
                setVisibleRentRoom(true);
            }
            else
            {
                chkRentRoom.Checked = false;
                setVisibleRentRoom(false);
            }
            if (quex.StatusEx1.Equals("1"))
            {
                chkEx1.Checked = true;
            }
            else
            {
                chkEx1.Checked = false;
            }
            if (quex.StatusEx2.Equals("1"))
            {
                chkEx2.Checked = true;
            }
            else
            {
                chkEx2.Checked = false;
            }
        }
        private void calGoSite()
        {
            txtGoSiteA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull11(txtGoSiteN.Text)) * Double.Parse(cc.cf.NumberNull11(txtGoSiteD.Text)) * Double.Parse(cc.cf.NumberNull11(txtGoSiteP.Text))); 
        }
        private void calDistanceDaily()
        {
            txtDistanceDailyA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull11(txtDistanceDailyN.Text)) * Double.Parse(cc.cf.NumberNull11(txtDistanceDailyD.Text)) * Double.Parse(cc.cf.NumberNull11(txtDistanceDailyP.Text)));
        }
        private void calRentCar()//txtRentCarN
        {
            txtRentCarA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull11(txtRentCarP.Text)) * Double.Parse(cc.cf.NumberNull11(txtRentCarD.Text)) * Double.Parse(cc.cf.NumberNull11(txtRentCarN.Text)));
        }
        private void calRentRoom()
        {
            txtRentRoomA.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull11(txtRentRoomP.Text)) * Double.Parse(cc.cf.NumberNull11(txtRentRoomD.Text)) * Double.Parse(cc.cf.NumberNull11(txtRentRoomN.Text)));
        }
        private void calAmount()
        {
            //Double aaa = 0;
            //aaa = Double.Parse(cc.cf.NumberNull11(txtGoSiteA.Text.Replace(",", ""))) * Double.Parse(cc.cf.NumberNull11(txtDistanceDailyA.Text.Replace(",", ""))) *
            //    Double.Parse(cc.cf.NumberNull11(txtRentCarA.Text.Replace(",", ""))) * Double.Parse(cc.cf.NumberNull11(txtEx1A.Text.Replace(",", ""))) * Double.Parse(cc.cf.NumberNull11(txtEx2A.Text.Replace(",", "")));
            txtAmount.Text = String.Format("{0:#,###,###.00}", Double.Parse(cc.cf.NumberNull1(txtGoSiteA.Text.Replace(",", ""))) + Double.Parse(cc.cf.NumberNull1(txtDistanceDailyA.Text.Replace(",", ""))) +
                Double.Parse(cc.cf.NumberNull1(txtRentCarA.Text.Replace(",", ""))) + Double.Parse(cc.cf.NumberNull1(txtEx1A.Text.Replace(",", ""))) + Double.Parse(cc.cf.NumberNull1(txtEx2A.Text.Replace(",", "")))+
                +Double.Parse(cc.cf.NumberNull1(txtRentRoomA.Text.Replace(",", ""))));
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
            txtRentCarP.Visible = s;
            txtRentCarD.Visible = s;
            txtRentCarN.Visible = s;
            txtRentCarA.Visible = s;
            label8.Visible = s;
            label9.Visible = s;
            label12.Visible = s;
            label7.Visible = s;

        }
        private void setVisibleRentRoom(Boolean s)
        {
            txtRentRoomP.Visible = s;
            txtRentRoomD.Visible = s;
            txtRentRoomN.Visible = s;
            txtRentRoomA.Visible = s;
            label18.Visible = s;
            label15.Visible = s;
            label16.Visible = s;
            label17.Visible = s;

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

        private void chkRentRoom_Click(object sender, EventArgs e)
        {
            if (chkRentRoom.Checked)
            {
                setVisibleRentRoom(true);
            }
            else
            {
                setVisibleRentRoom(false);
            }
        }

        private void txtRentRoomN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRentRoomD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRentRoomP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtRentRoomN_KeyUp(object sender, KeyEventArgs e)
        {
            calRentRoom();
        }

        private void txtRentRoomD_KeyUp(object sender, KeyEventArgs e)
        {
            calRentRoom();
        }

        private void txtRentRoomP_KeyUp(object sender, KeyEventArgs e)
        {
            calRentRoom();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String quexId = "";
            getQuotationEx();
            quexId = cc.quexdb.insertQuotationEx(quex);
            if (quexId.Length >= 1)
            {
                cc.qudb.updateQuExId(quId,quexId);
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
            //cc.quexdb.insertQuotationEx(quex);
            //this.Dispose();
        }

        private void chkEx1_Click(object sender, EventArgs e)
        {
            if (chkEx1.Checked)
            {
                txtEx1A.Enabled = true;
            }
            else
            {
                txtEx1A.Enabled = false;
                txtEx1A.Text = "0";
            }
        }

        private void chkEx2_Click(object sender, EventArgs e)
        {
            if (chkEx2.Checked)
            {
                txtEx2A.Enabled = true;
            }
            else
            {
                txtEx2A.Enabled = false;
                txtEx2A.Text = "0";
            }
        }
    }
}
