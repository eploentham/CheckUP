using CheckUP.Control;
using CheckUP.object1;
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
    public partial class FrmCheckUpEdit : Form
    {
        CheckControl cc;
        CustCheckUp cuc;
        int tabSum = 0, tabPrint = 1, tabPE = 2, tabXRay = 3, tabCBC = 4, tabFBS = 5, tabUA = 6, tabTri = 7, tabCho = 8, tabSgot = 9, tabBun = 10, tabUric = 11;
        int tabCnt = 12;

        public FrmCheckUpEdit(String ccpId,CheckControl c)
        {
            InitializeComponent();
            cc = c;
        }
        private void initConfig(String cucId)
        {
            cuc = new CustCheckUp();
            cuc = cc.cucdb.selectByPk(cucId);

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
            tC.TabPages[tabPrint].Text = "Print";

        }

        private void FrmCheckUpEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
