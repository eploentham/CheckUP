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

            label15.Left = label3.Left;
            label16.Left = label3.Left;
            label17.Left = label3.Left;
            label18.Left = label3.Left;
            label19.Left = label3.Left;
            label20.Left = label3.Left;
            label21.Left = label3.Left;
            label22.Left = label3.Left;
            label23.Left = label3.Left;
            label24.Left = label3.Left;

            label15.Top = label3.Top;
            label16.Top = label3.Top;
            label17.Top = label3.Top;
            label18.Top = label3.Top;
            label19.Top = label3.Top;
            label20.Top = label3.Top;
            label21.Top = label3.Top;
            label22.Top = label3.Top;
            label23.Top = label3.Top;
            label24.Top = label3.Top;

            nmDRow15.Left = nmDRow.Left;
            nmDRow16.Left = nmDRow.Left;
            nmDRow17.Left = nmDRow.Left;
            nmDRow18.Left = nmDRow.Left;
            nmDRow19.Left = nmDRow.Left;
            nmDRow20.Left = nmDRow.Left;
            nmDRow21.Left = nmDRow.Left;
            nmDRow22.Left = nmDRow.Left;
            nmDRow23.Left = nmDRow.Left;
            nmDRow24.Left = nmDRow.Left;

            nmDRow15.Top = nmDRow.Top;
            nmDRow16.Top = nmDRow.Top;
            nmDRow17.Top = nmDRow.Top;
            nmDRow18.Top = nmDRow.Top;
            nmDRow19.Top = nmDRow.Top;
            nmDRow20.Top = nmDRow.Top;
            nmDRow21.Top = nmDRow.Top;
            nmDRow22.Top = nmDRow.Top;
            nmDRow23.Top = nmDRow.Top;
            nmDRow24.Top = nmDRow.Top;


        }

        private void FrmExcelInit_Load(object sender, EventArgs e)
        {

        }
    }
}
