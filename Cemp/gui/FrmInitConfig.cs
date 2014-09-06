using Cemp.Control;
using Cemp.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Cemp.gui
{
    public partial class FrmInitConfig : Form
    {
        CnviControl cc;
        Staff sf;
        public FrmInitConfig(String sfCode, CnviControl l)
        {
            InitializeComponent();
            initConfig(sfCode, l);
        }
        private void initConfig(String sfCode, CnviControl l)
        {
            cc = l;
            sf = cc.sfdb.selectByCode(sfCode);
            if (cc.initC.clearInput.Equals("yes"))
            {
                chkClearInput.Checked = true;
            }
            else
            {
                chkClearInput.Checked = false;
            }
            if (cc.initC.StatusServer.Equals("yes"))
            {
                ChkServer.Checked = true;
                gBServer.Visible = true;
                ChkClient.Checked = false;
                gBClient.Visible = false;

                chkConnectServer.Checked = true;
                txtHost.Text = cc.initC.ServerIP;
                txtUser.Text = cc.initC.User;
                txtPwd.Text = cc.initC.Password;
                txtDatabase.Text = cc.initC.Database;
                txtDatabase.Visible = true;
                txtHost.Visible = true;
                txtPwd.Visible = true;
                txtUser.Visible = true;
            }
            else
            {
                ChkServer.Checked = false;
                gBServer.Visible = false;
                ChkClient.Checked = true;
                gBClient.Visible = true;

                chkConnectServer.Checked = false;
                txtDatabase.Visible = false;
                txtHost.Visible = false;
                txtPwd.Visible = false;
                txtUser.Visible = false;
            }

            txtPathImage.Text = cc.initC.pathImage;
            txtPathBefore.Text = cc.initC.pathImageBefore;
            if (cc.initC.delImage.Equals("yes"))
            {
                chkDelImage.Checked = true;
            }
            else
            {
                chkDelImage.Checked = false;
            }
            if (cc.initC.use32Bit.Equals("yes"))
            {
                chkUse32bit.Checked = true;
            }
            else
            {
                chkUse32bit.Checked = false;
            }
        }
        private void FrmInitConfig_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cc.SetClearInput(chkClearInput.Checked);
            cc.SetUse32Bit(chkUse32bit.Checked);
            if (ChkServer.Checked)
            {
                cc.SetSetatusServer(true);
                cc.SetPathImage(txtPathImage.Text);
                cc.SetPathImageBefore(txtPathBefore.Text);
                cc.SetDelImage(chkDelImage.Checked);

                cc.SetPathShareImage(txtPathShareImage.Text);
                cc.SetPathShareData(txtPathShareData.Text);
            }
            else
            {
                cc.SetSetatusServer(false);
                cc.SetConnectServer(chkConnectServer.Checked, txtHost.Text, txtUser.Text, txtPwd.Text);
                //lc.SetPathImage(txtPathImage.Text);

                cc.SetPathShareImage(txtConnectShareData.Text);
                cc.SetPathShareData(txtConnectShareImage.Text);
            }

            cc.GetConfig();
        }

        private void chkConnectServer_Click(object sender, EventArgs e)
        {
            if (chkConnectServer.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                btnTest.Visible = true;
                lV1.Visible = true;

                txtHost.Visible = true;
                label8.Visible = true;
                label10.Visible = true;
                txtConnectShareData.Visible = true;
                txtConnectShareImage.Visible = true;

                txtDatabase.Visible = true;
                txtUser.Visible = true;
                txtPwd.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                btnTest.Visible = false;
                lV1.Visible = false;

                txtHost.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                txtConnectShareData.Visible = false;
                txtConnectShareImage.Visible = false;

                txtDatabase.Visible = false;
                txtUser.Visible = false;
                txtPwd.Visible = false;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //OpenFileDialog theDialog = new OpenFileDialog();
            //theDialog.Title = "Open Path File";
            ////theDialog.Filter = "TXT files|*.txt";
            //theDialog.InitialDirectory = @"C:\";
            //if (theDialog.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(theDialog.FileName.ToString());
            //}
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathImage.Text = fbd.SelectedPath;
        }

        private void btnPath1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPathBefore.Text = fbd.SelectedPath;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            cc.CreateSharedFolder(txtPathImage.Text, txtPathShareImage.Text, txtPathShareImage.Text);
            cc.CreateSharedFolder(Environment.CurrentDirectory + "\\Database\\", txtPathShareData.Text, txtPathShareData.Text);
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            txtIP.Text = cc.LocalIPAddress();
        }

        private void ChkServer_Click(object sender, EventArgs e)
        {
            gBServer.Visible = true;
            gBClient.Visible = false;
        }

        private void ChkClient_Click(object sender, EventArgs e)
        {
            gBServer.Visible = false;
            gBClient.Visible = true;
        }

    }
}
