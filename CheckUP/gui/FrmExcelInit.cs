using CheckUP.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckUP.gui
{
    public partial class FrmExcelInit : Form
    {
        CheckControl cc;
        int tabSum = 0, tabPE = 1, tabXRay = 2, tabCBC = 3, tabFBS = 4, tabUA = 5, tabTri = 6, tabCho = 7, tabSgot = 8, tabBun = 9, tabUric = 10;
        int tabCnt = 11;
        public FrmExcelInit(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            tC.TabPages[tabSum].Text = "Summary";
            tC.TabPages[tabPE].Text = "PE";
            tC.TabPages[tabXRay].Text = "X-Ray";
            tC.TabPages[tabCBC].Text = "CBC";
            tC.TabPages[tabFBS].Text = "FBS";
            tC.TabPages[tabUA].Text = "UA";
            tC.TabPages[tabTri].Text = "Triglyceride";
            tC.TabPages[tabCho].Text = "Choles";
            tC.TabPages[tabSgot].Text = "SGOT/SGPT";
            tC.TabPages[tabBun].Text = "BUN Creatine";
            tC.TabPages[tabUric].Text = "Uric acid";

            lbPE.Left = label3.Left;
            lbXRay.Left = label3.Left;
            lbCBC.Left = label3.Left;
            lbFBS.Left = label3.Left;
            lbUA.Left = label3.Left;
            lbTri.Left = label3.Left;
            lbCho.Left = label3.Left;
            lbSgot.Left = label3.Left;
            lbBun.Left = label3.Left;
            lbUric.Left = label3.Left;

            lbPE.Top = label3.Top;
            lbXRay.Top = label3.Top;
            lbCBC.Top = label3.Top;
            lbFBS.Top = label3.Top;
            lbUA.Top = label3.Top;
            lbTri.Top = label3.Top;
            lbCho.Top = label3.Top;
            lbSgot.Top = label3.Top;
            lbBun.Top = label3.Top;
            lbUric.Top = label3.Top;

            nmDPERow.Left = nmDRow.Left;
            nmDXRayRow.Left = nmDRow.Left;
            nmDNoRow.Left = nmDRow.Left;
            nmDFBSRow.Left = nmDRow.Left;
            nmDUARow.Left = nmDRow.Left;
            nmDTriRow.Left = nmDRow.Left;
            nmDChoRow.Left = nmDRow.Left;
            nmDSgotRow.Left = nmDRow.Left;
            nmDBunRow.Left = nmDRow.Left;
            nmDUricRow.Left = nmDRow.Left;

            nmDPERow.Top = nmDRow.Top;
            nmDXRayRow.Top = nmDRow.Top;
            nmDNoRow.Top = nmDRow.Top;
            nmDFBSRow.Top = nmDRow.Top;
            nmDUARow.Top = nmDRow.Top;
            nmDTriRow.Top = nmDRow.Top;
            nmDChoRow.Top = nmDRow.Top;
            nmDSgotRow.Top = nmDRow.Top;
            nmDBunRow.Top = nmDRow.Top;
            nmDUricRow.Top = nmDRow.Top;

            lbXRayNo.Top = lbPENo.Top;
            lbCBCNo.Top = lbPENo.Top;
            lbUANo.Top = lbPENo.Top;
            lbFBSNo.Top = lbPENo.Top;
            lbTriNo.Top = lbPENo.Top;
            lbChoNo.Top = lbPENo.Top;
            lbBunNo.Top = lbPENo.Top;
            lbSgotNo.Top = lbPENo.Top;
            lbUricNo.Top = lbPENo.Top;
            //lbXRayNo.Top = lbPENo.Top;
            lbXRayNo.Left = lbPENo.Left;
            lbCBCNo.Left = lbPENo.Left;
            lbUANo.Left = lbPENo.Left;
            lbFBSNo.Left = lbPENo.Left;
            lbTriNo.Left = lbPENo.Left;
            lbChoNo.Left = lbPENo.Left;
            lbBunNo.Left = lbPENo.Left;
            lbSgotNo.Left = lbPENo.Left;
            lbUricNo.Left = lbPENo.Left;

            nmDXRayNo.Top = nmDPENo.Top;
            nmDCBCNo.Top = nmDPENo.Top;
            nmDUANo.Top = nmDPENo.Top;
            nmDFBSNo.Top = nmDPENo.Top;
            nmDTriNo.Top = nmDPENo.Top;
            nmDChoNo.Top = nmDPENo.Top;
            nmDBunNo.Top = nmDPENo.Top;
            nmDSgotNo.Top = nmDPENo.Top;
            nmDUricNo.Top = nmDPENo.Top;
            nmDXRayNo.Left = nmDPENo.Left;
            nmDCBCNo.Left = nmDPENo.Left;
            nmDUANo.Left = nmDPENo.Left;
            nmDFBSNo.Left = nmDPENo.Left;
            nmDTriNo.Left = nmDPENo.Left;
            nmDChoNo.Left = nmDPENo.Left;
            nmDBunNo.Left = nmDPENo.Left;
            nmDSgotNo.Left = nmDPENo.Left;
            nmDUricNo.Left = nmDPENo.Left;

        }

        private void FrmExcelInit_Load(object sender, EventArgs e)
        {

        }

        private void btnPrefixExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
