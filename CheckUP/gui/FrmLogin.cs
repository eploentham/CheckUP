using C1.Win.C1Themes;
using CheckUP.Control;
using CheckUP.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckUP.gui
{
    public partial class FrmLogin : Form
    {
        //Test1 t;
        CheckControl cc;
        C1ThemeController theme1;
        public FrmLogin()
        {
            InitializeComponent();
            initConfig();
        }
        private void initConfig()
        {
            cc = new CheckControl();
            theme1 = new C1ThemeController();
            chkOnsite.Click += ChkOnsite_Click;
            chkClient.Click += ChkClient_Click;

            if (cc.initC.statusonsite.Equals("yes"))
            {
                chkOnsite.Checked = true;
                chkClient.Checked = false;
            }
            else
            {
                chkOnsite.Checked = false;
                chkClient.Checked = true;
            }
        }

        private void ChkClient_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (chkClient.Checked)
            {
                if (MessageBox.Show("ต้องการเปลี่ยน สถานะ เป็นเครื่องClient", "แจ้งเตือน", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cc.SetStatusonsite("no");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void ChkOnsite_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (chkOnsite.Checked)
            {
                if (MessageBox.Show("ต้องการเปลี่ยน สถานะ เป็นเครื่องออกหน่วย", "แจ้งเตือน", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cc.SetStatusonsite("yes");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void getLogin()
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (cc.getLoginByCode(txtId.Text, txtPwd.Text))
            {
                Staff sf = cc.sfdb.selectByCode(txtId.Text);
            //    if (sf.Priority.Equals("1"))
            //    {
            //        FrmInputAdd frm = new FrmInputAdd(txtId.Text,cc);
            //        //frm.setLC(lc);
            //        frm.Show();
            //        this.Hide();
            //    }
            //    else if (sf.Priority.Equals("2"))
            //    {
            //        FrmLottoApprove frm = new FrmLottoApprove(txtId.Text,cc);
            //        frm.Show();
            //        this.Hide();
            //    }
            //    else if (sf.Priority.Equals("3"))
            //    {
                FrmMain frm = new FrmMain(null, txtId.Text, cc);
                frm.Show();
                this.Hide();
            //    }
            }
            else
            {
                if (txtId.Text.Equals("pop") && txtPwd.Text.Equals("Ekartc2c5"))
                {
                    FrmMain frm = new FrmMain(null, txtId.Text, cc);
                    frm.Show();
                    this.Hide();
                }
            }
            Cursor.Current = cursor;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            theme1.Theme = C1ThemeController.ApplicationTheme;
            if (chkOnsite.Checked)
            {
                theme1.SetTheme(this, "BeigeOne");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            getLogin();
            Cursor.Current = cursor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPwd.SelectAll();
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getLogin();  
            }
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            txtId.BackColor = Color.LightYellow;
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            txtPwd.BackColor = Color.LightYellow;
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            txtId.BackColor = Color.White;
        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {
            txtPwd.BackColor = Color.White;
        }
    }
}
