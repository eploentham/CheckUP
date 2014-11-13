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
    public partial class FrmValueNormal : Form
    {
        CheckControl cc;
        int tabCBC = 0, tabFBS = 1, tabUA = 2, tabTri = 3, tabCho = 4, tabSgot = 5, tabBun = 6, tabUric = 7, tabOther1 = 8, tabLung = 9, tabAudio = 10, tabEye = 11, tabToxi = 12, tabStoolExam = 13;
        int tabCnt = 14;
        public FrmValueNormal(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {

            tC.TabPages[tabCBC].Text = "CBC";
            tC.TabPages[tabFBS].Text = "FBS";
            tC.TabPages[tabUA].Text = "UA";
            tC.TabPages[tabTri].Text = "Triglyceride";
            tC.TabPages[tabCho].Text = "Choles";
            tC.TabPages[tabSgot].Text = "SGOT/SGPT";
            tC.TabPages[tabBun].Text = "BUN Creatine";
            tC.TabPages[tabUric].Text = "Uric Acid";
            tC.TabPages[tabOther1].Text = "Other1";
            tC.TabPages[tabLung].Text = "Lung";
            tC.TabPages[tabAudio].Text = "Audio";
            tC.TabPages[tabEye].Text = "Eye";
            tC.TabPages[tabToxi].Text = "Toxicology";
            tC.TabPages[tabStoolExam].Text = "Stool Exam";
        }
        private void FrmValueNormal_Load(object sender, EventArgs e)
        {

        }
    }
}
