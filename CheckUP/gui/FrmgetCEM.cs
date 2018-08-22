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
    public partial class FrmgetCEM : Form
    {
        CheckControl cc;
        Staff sf;
        public FrmgetCEM(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            initConfig();
        }
        private void initConfig()
        {
            txtPath.Value = cc.initC.pathaccessCEM;

            this.FormClosing += FrmgetCEM_FormClosing;
            btnPath.Click += BtnPath_Click;
            btnRetrive.Click += BtnRetrive_Click;
        }

        private void BtnRetrive_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "mdb";

            ofd.Filter = "Access files (*.mdb)|*.mdb|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                cc.SetPathAccessCEM(txtPath.Text);
            }
        }

        private void FrmgetCEM_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            Application.Exit();
        }

        private void FrmgetCEM_Load(object sender, EventArgs e)
        {

        }

    }
}
