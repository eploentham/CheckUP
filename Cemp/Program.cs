using Cemp.Control;
using Cemp.gui;
//using Cemp.;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cemp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new FrmLogin());
            //CnviControl cc = new CnviControl();
            //Application.Run(new FrmMethodView(new CnviControl()));
        }
    }
}
