using CheckUP.Control;
using CheckUP.gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUP
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
            //MessageBox.Show("00000", "Error");
            CheckControl cc;
            cc = new CheckControl();
            if (cc.initC.statusconnectCEM.Equals("yes"))
            {
                Application.Run(new FrmgetCEM(cc));
            }
            else
            {
                Application.Run(new FrmLogin(cc));
            }
            
        }
    }
}
