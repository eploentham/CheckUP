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
    public partial class FrmQuoConfirmView : Form
    {
        CnviControl cc;
        public FrmQuoConfirmView(String sfId, CnviControl c)
        {
            InitializeComponent();
            initConfig(sfId, c);
        }
        private void initConfig(String sfId, CnviControl c)
        {
            cc = c;
            setGrd();
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 80 - btnAdd.Width;
            dgvView.Height = this.Height - 150;
            btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {

        }

        private void FrmQuoConfirmView_Load(object sender, EventArgs e)
        {

        }

        private void FrmQuoConfirmView_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmQuoConfirmAdd frm = new FrmQuoConfirmAdd();
            frm.ShowDialog(this);
            setGrd();
        }
    }
}
