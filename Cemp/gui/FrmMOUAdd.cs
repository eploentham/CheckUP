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
    public partial class FrmMOUAdd : Form
    {
        CnviControl cc;
        public FrmMOUAdd(String moId, CnviControl c)
        {
            InitializeComponent();
            initConfig(moId,c);
        }
        private void initConfig(String moId, CnviControl c)
        {
            cc = c;
        }

        private void FrmMOUAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
