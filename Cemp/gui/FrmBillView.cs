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
    public partial class FrmBillView : Form
    {
        CnviControl cc;
        int colRow = 0, colBillNumber = 1, colCustName = 2, colBillDate = 3, colRemark = 4, colId = 5;
        int colCnt = 6;
        public FrmBillView(CnviControl c)
        {
            InitializeComponent();
            cc = c;
        }

        private void FrmBillView_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBillAdd frm = new FrmBillAdd(cc);
            frm.ShowDialog(this);

        }
    }
}
