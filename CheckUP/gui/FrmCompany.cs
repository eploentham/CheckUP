using CheckUP.Control;
using CheckUP.object1;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Cemp.gui
{
    public partial class FrmCompany : Form
    {
        CheckControl cc;
        Company cp;
        OpenFileDialog ofd;
        Boolean pageLoad = false, keyDistrict = false;
        //Staff sf;
        public FrmCompany(CheckControl c)
        {
            InitializeComponent();
            initConfig(c);
        }
        private void initConfig(CheckControl c)
        {
            pageLoad = true;
            cc = c;
            //sf = cc.sfdb.selectByPk(sfId);
            cp = new Company();
            ofd = new OpenFileDialog();
            setControl();
            txtCode.ReadOnly = true;
            pageLoad = false;
            //txtNameT.Focus();
        }
        private void setResize()
        {
            //dgvView.Width = this.Width - 80 - btnAdd.Width;
            //dgvView.Height = this.Height - 150;
            //btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setControl()
        {
            cp = cc.cpdb.selectByPk();
            txtCode.Text = cp.Code;
            txtId.Text = cp.Id;
            txtNameE.Text = cp.NameE;
            txtNameT.Text = cp.NameT;
            txtAddr.Text = cp.Addr;
            txtAddressT.Text = cp.AddressT;
            //cboDistrict.SelectedItem = cp.districtId;
            //cboAmphur.SelectedItem = cp.amphurId;
            //cboProvince.SelectedItem = cp.provinceId;
            txtZipcode.Text = cp.Zipcode;
            txtAddressE.Text = cp.AddressE;
            txtTele.Text = cp.Tele;
            TxtFax.Text = cp.Fax;
            txtEmail.Text = cp.Email;
            txtTaxID.Text = cp.TaxId;
            txtVat.Text = cp.vat;
            txtWebSite.Text = cp.WebSite;
            viewImage(cc.PathLogo + "\\" + cp.logo);
            label18.Text = cp.districtId;
            txtSpec1.Text = cp.Spec1;

            txtQuoLine1.Text = cp.quLine1;
            txtQuoLine2.Text = cp.quLine2;
            txtQuoLine3.Text = cp.quLine3;
            txtQuoLine4.Text = cp.quLine4;
            txtQuoLine5.Text = cp.quLine5;
            txtQuoLine6.Text = cp.quLine6;

            txtMOULine1.Text = cp.mouLine1;
            txtMOULine2.Text = cp.mouLine2;
            txtMOULine3.Text = cp.mouLine3;
            txtMOULine4.Text = cp.mouLine4;

            txtRsLine1.Text = cp.rsLine1;
            txtRsLine2.Text = cp.rsLine2;
            txtRsLine3.Text = cp.rsLine3;
            txtRsLine4.Text = cp.rsLine4;
            txtRsLine5.Text = cp.rsLine5;
            txtRsLine6.Text = cp.rsLine6;

            txtInvDuePeriod.Text = cp.InvDuePeriod;

            if (label18.Text.Length > 4)
            {
                cboDistrict = cc.didb.getCboDist1(cboDistrict, label18.Text);
                cboAmphur = cc.amdb.getCboAmphur1(cboAmphur, label18.Text.Substring(0, 4));
                cboProvince = cc.prdb.getCboProv1(cboProvince, label18.Text.Substring(0, 2));
            }
            
        }
        private void getCompany()
        {
            cp.Id = txtId.Text;
            cp.Code = txtCode.Text;
            cp.Addr = txtAddr.Text;
            cp.AddressE = txtAddressE.Text;
            cp.AddressT = txtAddressT.Text;
            cp.amphurId = cc.cf.getValueCboItem(cboAmphur);
            cp.districtId = cc.cf.getValueCboItem(cboDistrict);
            cp.Email = txtEmail.Text;
            cp.Fax = TxtFax.Text;
            cp.logo = "";
            cp.NameE = txtNameE.Text;
            cp.NameT = txtNameT.Text;
            cp.provinceId = cc.cf.getValueCboItem(cboProvince);
            cp.TaxId = txtTaxID.Text;
            cp.Tele = txtTele.Text;
            cp.vat = txtVat.Text;
            cp.Zipcode = txtZipcode.Text;
            cp.WebSite = txtWebSite.Text;
            cp.Spec1 = txtSpec1.Text;

            cp.quLine1=txtQuoLine1.Text;
            cp.quLine2=txtQuoLine2.Text;
            cp.quLine3=txtQuoLine3.Text;
            cp.quLine4=txtQuoLine4.Text;
            cp.quLine5=txtQuoLine5.Text;
            cp.quLine6=txtQuoLine6.Text;

            cp.mouLine1 = txtMOULine1.Text;
            cp.mouLine2 = txtMOULine2.Text;
            cp.mouLine3 = txtMOULine3.Text;
            cp.mouLine4 = txtMOULine4.Text;

            cp.rsLine1 = txtRsLine1.Text;
            cp.rsLine2 = txtRsLine2.Text;
            cp.rsLine3 = txtRsLine3.Text;
            cp.rsLine4 = txtRsLine4.Text;
            cp.rsLine5 = txtRsLine5.Text;
            cp.rsLine6 = txtRsLine6.Text;

            cp.InvDuePeriod = txtInvDuePeriod.Text;
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            //txtNameT.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Document doc = new Document(PageSize.A4);
            //var output = new FileStream(Environment.CurrentDirectory + "\\MyFirstPDF.pdf", FileMode.Create);
            //var writer = PdfWriter.GetInstance(doc, output);

            //doc.Open();


            //var logo = iTextSharp.text.Image.GetInstance(Environment.CurrentDirectory + "\\logo.jpg");
            //logo.SetAbsolutePosition(430, 770);
            //logo.ScaleAbsoluteHeight(30);
            //logo.ScaleAbsoluteWidth(70);
            //doc.Add(logo);

            //PdfPTable table1 = new PdfPTable(2);
            //table1.DefaultCell.Border = 0;
            //table1.WidthPercentage = 80;

            //PdfPCell cell11 = new PdfPCell();
            //cell11.Colspan = 1;
            ////cell11.AddElement(new Paragraph("ABC Traders Receipt", titleFont));

            ////cell11.AddElement(new Paragraph("Thankyou for shoping at ABC traders,your order details are below", subTitleFont));


            //cell11.VerticalAlignment = Element.ALIGN_LEFT;

            //PdfPCell cell12 = new PdfPCell();


            //cell12.VerticalAlignment = Element.ALIGN_CENTER;


            //table1.AddCell(cell11);

            //table1.AddCell(cell12);

            //PdfPTable table2 = new PdfPTable(3);

            ////One row added

            //PdfPCell cell21 = new PdfPCell();

            //cell21.AddElement(new Paragraph("Photo Type"));

            //PdfPCell cell22 = new PdfPCell();

            //cell22.AddElement(new Paragraph("No. of Copies"));

            //PdfPCell cell23 = new PdfPCell();

            //cell23.AddElement(new Paragraph("Amount"));

            //table2.AddCell(cell21);

            //table2.AddCell(cell22);

            //table2.AddCell(cell23);

            ////New Row Added

            //PdfPCell cell31 = new PdfPCell();

            //cell31.AddElement(new Paragraph("Safe"));

            //cell31.FixedHeight = 300.0f;

            //PdfPCell cell32 = new PdfPCell();

            //cell32.AddElement(new Paragraph("2"));

            //cell32.FixedHeight = 300.0f;

            //PdfPCell cell33 = new PdfPCell();

            //cell33.AddElement(new Paragraph("20.00 * " + "2" + " = " + (20 * Convert.ToInt32("2")) + ".00"));

            //cell33.FixedHeight = 300.0f;

            //table2.AddCell(cell31);

            //table2.AddCell(cell32);

            //table2.AddCell(cell33);


            //PdfPCell cell2A = new PdfPCell(table2);

            //cell2A.Colspan = 2;

            //table1.AddCell(cell2A);

            //PdfPCell cell41 = new PdfPCell();

            //cell41.AddElement(new Paragraph("Name : " + "ABC"));

            //cell41.AddElement(new Paragraph("Advance : " + "advance"));

            //cell41.VerticalAlignment = Element.ALIGN_LEFT;

            //PdfPCell cell42 = new PdfPCell();

            //cell42.AddElement(new Paragraph("Customer ID : " + "011"));

            //cell42.AddElement(new Paragraph("Balance : " + "3993"));

            //cell42.VerticalAlignment = Element.ALIGN_RIGHT;


            //table1.AddCell(cell41);

            //table1.AddCell(cell42);

            //doc.Add(table1);

            //doc.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("eploentham@gmail.com");
            mail.To.Add("eploentham@gmail.com");
            mail.Subject = "Test Mail - 1";
            mail.Body = "mail with attachment";

            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(Environment.CurrentDirectory + "\\MyFirstPDF.pdf");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("eploentham@gmail.com", "Ekartc2c5");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            button2.Enabled = true;
        }

        private void cboDistrict_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (keyDistrict))
            {
                cboDistrict = cc.didb.getCboDist1(cboDistrict, label18.Text);
                cboAmphur = cc.amdb.getCboAmphur1(cboAmphur, label18.Text.Substring(0, 4));
                cboProvince = cc.prdb.getCboProv1(cboProvince, label18.Text.Substring(0, 2));
                txtZipcode.Text = cc.didb.selectZipCodeByPk(label18.Text);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyDistrict = true;
                //    aaa = cc.cf.getValueCboItem(cboDistrict);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (cboDistrict.Text.Length >= 3)
                {
                    cboDistrict = cc.didb.getCboDistrict1(cboDistrict, cboDistrict.Text);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNameE.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนชื่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }
            if (txtNameT.Text.Equals(""))
            {
                MessageBox.Show("ไม่ได้ป้อนName", "ป้อนข้อมูลไม่ครบ");
                return;
            }

            getCompany();
            if (cc.cpdb.insertCompany(cp).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                this.Dispose();
                //this.Hide();
            }
        }
        private void viewImage(String filename)
        {
            if (System.IO.File.Exists(filename))
            {
                pic1.Image = System.Drawing.Image.FromFile(filename);
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            String fileName = "", fileName1 = "", ex = "";
            //fileName = fileCertify + txtPaId.Text + "";
            ofd.ShowDialog();
            if (ofd.FileName.Equals(""))
            {
                return;
            }
            fileName1 = ofd.FileName;
            ex = fileName1.Substring(ofd.FileName.IndexOf("."));
            //fbd.SelectedPath = Environment.CurrentDirectory + "\\pic";
            //DirectoryInfo dir = new DirectoryInfo(ofd.FileName);

            if (System.IO.File.Exists(ofd.FileName))
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(ofd.FileName);
                if (System.IO.File.Exists(cc.PathLogo + "\\" + ofd.SafeFileName))
                {
                    System.IO.File.Delete(cc.PathLogo + "\\" + ofd.SafeFileName);
                }
                image.Save(cc.PathLogo + "\\" + ofd.SafeFileName);
            }
            //cc.padb.UpdatePathPicCertify(txtPaId.Text, fileName + ex);
            viewImage(cc.PathLogo + "\\" + ofd.SafeFileName);
            cc.cpdb.UpdateLogo(ofd.SafeFileName);
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!pageLoad)
            {
                String aaa = "";
                aaa = cc.cf.getValueCboItem(cboDistrict);
                label18.Text = aaa;
            }
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

        private void txtAddr_Enter(object sender, EventArgs e)
        {
            txtAddr.BackColor = Color.LightYellow;
        }

        private void txtAddr_Leave(object sender, EventArgs e)
        {
            txtAddr.BackColor = Color.White;
        }

        private void cboDistrict_Enter(object sender, EventArgs e)
        {
            cboDistrict.BackColor = Color.LightYellow;
        }

        private void cboDistrict_Leave(object sender, EventArgs e)
        {
            cboDistrict.BackColor = Color.White;
        }

        private void cboAmphur_Enter(object sender, EventArgs e)
        {
            cboAmphur.BackColor = Color.LightYellow;
        }

        private void cboAmphur_Leave(object sender, EventArgs e)
        {
            cboAmphur.BackColor = Color.White;
        }

        private void cboProvince_Enter(object sender, EventArgs e)
        {
            cboProvince.BackColor = Color.LightYellow;
        }

        private void cboProvince_Leave(object sender, EventArgs e)
        {
            cboProvince.BackColor = Color.White;
        }

        private void txtZipcode_Enter(object sender, EventArgs e)
        {
            txtZipcode.BackColor = Color.LightYellow;
        }

        private void txtZipcode_Leave(object sender, EventArgs e)
        {
            txtZipcode.BackColor = Color.White;
        }

        private void txtAddressT_Enter(object sender, EventArgs e)
        {
            txtAddressT.BackColor = Color.LightYellow;
        }

        private void txtAddressT_Leave(object sender, EventArgs e)
        {
            txtAddressT.BackColor = Color.White;
        }

        private void txtAddressE_Enter(object sender, EventArgs e)
        {
            txtAddressE.BackColor = Color.LightYellow;
        }

        private void txtAddressE_Leave(object sender, EventArgs e)
        {
            txtAddressE.BackColor = Color.White;
        }

        private void txtTele_Enter(object sender, EventArgs e)
        {
            txtTele.BackColor = Color.LightYellow;
        }

        private void txtTele_Leave(object sender, EventArgs e)
        {
            txtTele.BackColor = Color.White;
        }

        private void TxtFax_Enter(object sender, EventArgs e)
        {
            TxtFax.BackColor = Color.LightYellow;
        }

        private void TxtFax_Leave(object sender, EventArgs e)
        {
            TxtFax.BackColor = Color.White;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.LightYellow;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.White;
        }

        private void txtTaxID_Enter(object sender, EventArgs e)
        {
            txtTaxID.BackColor = Color.LightYellow;
        }

        private void txtTaxID_Leave(object sender, EventArgs e)
        {
            txtTaxID.BackColor = Color.White;
        }

        private void txtWebSite_Enter(object sender, EventArgs e)
        {
            txtWebSite.BackColor = Color.LightYellow;
        }

        private void txtWebSite_Leave(object sender, EventArgs e)
        {
            txtWebSite.BackColor = Color.White;
        }

        private void txtVat_Enter(object sender, EventArgs e)
        {
            txtVat.BackColor = Color.LightYellow;
        }

        private void txtVat_Leave(object sender, EventArgs e)
        {
            txtVat.BackColor = Color.White;
        }

        private void txtTaxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNameE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = Regex.IsMatch(txtNameE.Text, "^[a-zA-Z]*$");
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 122) || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = false; // OS will handle this event.
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNameT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 122) || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46)
            {
                e.Handled = true; // OS will handle this event.
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
