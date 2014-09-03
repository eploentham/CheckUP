using Cemp.Control;
using Cemp.object1;
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
    public partial class FrmMethodAdd : Form
    {
        CnviControl cc;
        Method me;
        public FrmMethodAdd(String meId,CnviControl c)
        {
            InitializeComponent();
            initConfig(meId,c);
        }
        private void initConfig(String meId, CnviControl c)
        {
            me = new Method();
            setControl();
        }
        private void setControl()
        {

            txtCode = "";

        }
        private void FrmMethodAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
