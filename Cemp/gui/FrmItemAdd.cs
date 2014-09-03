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
    public partial class FrmItemAdd : Form
    {
        CnviControl cc;
        public FrmItemAdd(CnviControl c)
        {
            InitializeComponent();
        }
        private void initConfig(CnviControl c)
        {
            cc = c;
            //setGrd();
        }
        private void FrmItemAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
