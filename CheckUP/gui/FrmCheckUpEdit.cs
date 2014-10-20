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
        public FrmCheckUpEdit(String cucId,CheckControl c)
        {
            InitializeComponent();
            cc = c;
        }
        private void initConfig(String cucId)
        {
            cuc = new CustCheckUp();
            cuc = cc.cucdb.selectByPk(cucId);
        }

        private void FrmCheckUpEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
