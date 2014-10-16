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
        public FrmExcelInit(CheckControl c)
        {
            InitializeComponent();
            cc = c;
        }

        private void FrmExcelInit_Load(object sender, EventArgs e)
        {

        }
    }
}
