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
    public partial class FrmQuotationAdd : Form
    {
        CnviControl cc;
        public FrmQuotationAdd(String sfId, CnviControl c)
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
            //dgvView.Width = this.Width - 80 - btnAdd.Width;
            //dgvView.Height = this.Height - 150;
            //btnAdd.Left = dgvView.Width + 20;
            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrd()
        {

        }
        private void FrmQuotationAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
