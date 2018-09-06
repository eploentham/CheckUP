using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using CheckUP.Control;
using CheckUP.objdb;
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
    public partial class FrmgetCEM : Form
    {
        CheckControl cc;
        Staff sf;
        Font fEdit, fEditB;
        Font font = new Font("Microsoft Sans Serif", 12);
        //C1ThemeController theme1;
        Color color;
        C1FlexGrid grfView, grfSample;

        int colVName1 = 1, colVpatientid1=2, colVsampleid=3;
        int colStime=1, colSsampleid=2, colSitemid=3, colSfullname=4, colSresult = 5, colSresult1=6, colSref = 7;

        enum flagTestType { retrtiveNo, retriveYes};
        public FrmgetCEM(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            //MessageBox.Show("00000" , "Error");
            initConfig();
        }
        private void initConfig()
        {
            //MessageBox.Show("00000 "+ cc.initC.grdViewFontName, "Error");
            //MessageBox.Show("00000 " + cc.grdViewFontSize, "Error");
            //MessageBox.Show("grfRowColor " + cc.initC.grfRowColor, "Error");
            try
            {
                fEdit = new Font(cc.initC.grdViewFontName, cc.grdViewFontSize, FontStyle.Regular);
                fEditB = new Font(cc.initC.grdViewFontName, cc.grdViewFontSize, FontStyle.Bold);
                
                cc.initC.grfRowColor = string.IsNullOrEmpty(cc.initC.grfRowColor) ? "#EADBC4" : cc.initC.grfRowColor;
                cc.initC.grdViewFontSize = string.IsNullOrEmpty(cc.initC.grdViewFontSize) ? "10" : cc.initC.grdViewFontSize;
                //MessageBox.Show("grfRowColor1111 " + cc.initC.grfRowColor, "Error");
                color = ColorTranslator.FromHtml(cc.initC.grfRowColor);
                //theme1 = new C1ThemeController();
                //MessageBox.Show("00000", "Error");
                txtPath.Value = cc.initC.pathaccessCEM;

                this.FormClosing += FrmgetCEM_FormClosing;
                btnPath.Click += BtnPath_Click;
                btnRetrive.Click += BtnRetrive_Click;
                btnGen.Click += BtnGen_Click;
            }
            catch(Exception ex)
            {
                MessageBox.Show("zzzz "+ex.Message, "Error");
            }
            
            //MessageBox.Show("111111", "Error");
            initGrfView();
            initGrfSample();
        }

        private void BtnGen_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            CemDB cemDB;
            if (chk64Bit.Checked)
            {
                cemDB = new CemDB(txtPath.Text, CemDB.flagAccess.bit64);
            }
            else
            {
                cemDB = new CemDB(txtPath.Text, CemDB.flagAccess.bit32);
            }
            String dateStart = "", dateEnd = "";
            DateTime dateStart1, dateEnd1;
            dateStart1 = DateTime.Parse(txtDateStart.Text);
            dateEnd1 = DateTime.Parse(txtDateEnd.Text);
            dateStart = setDate(dateStart1);
            dateEnd = setDate(dateEnd1);
            if (chkTestType.Checked)
            {
                cemDB.getTextCEM(dateStart, dateEnd, txtNoStart.Text, txtNoEnd.Text, CemDB.flagTestType.retriveNo);
            }
            else
            {
                cemDB.getTextCEM(dateStart, dateEnd, txtNoStart.Text, txtNoEnd.Text, CemDB.flagTestType.retriveYes);
            }
        }
        private String setDate(DateTime date)
        {
            String re = "";
            if ((date.Year - 543) <= 1500)
            {
                re = (date.Year) + "-" + date.Month.ToString("00") + "-" + date.Day.ToString("00");
            }
            else
            {
                re = (date.Year - 543) + "-" + date.Month.ToString("00") + "-" + date.Day.ToString("00");
            }
            return re;
        }
        private void BtnRetrive_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            String dateStart = "", dateEnd = "";
            DateTime dateStart1, dateEnd1;
            dateStart1 = DateTime.Parse(txtDateStart.Text);
            dateEnd1 = DateTime.Parse(txtDateEnd.Text);
            dateStart = setDate(dateStart1);
            dateEnd = setDate(dateEnd1);

            //MessageBox.Show("dateStart " + dateStart);
            //MessageBox.Show("dateEnd " + dateEnd);

            setGrfView(dateStart, dateEnd, txtNoStart.Text, txtNoEnd.Text);
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "mdb";

            ofd.Filter = "Access files (*.mdb)|*.mdb|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
                cc.SetPathAccessCEM(txtPath.Text);
            }
        }
        private void initGrfView()
        {
            grfView = new C1FlexGrid();
            grfView.Font = fEdit;
            grfView.Dock = System.Windows.Forms.DockStyle.Fill;
            grfView.Location = new System.Drawing.Point(0, 0);

            //FilterRow fr = new FilterRow(grfView);

            //grfJob.AfterRowColChange += GrfJob_AfterRowColChange;
            //ContextMenu menuGw = new ContextMenu();
            //menuGw.MenuItems.Add("&แก้ไข", new EventHandler(ContextMenu_Gw_Edit));
            //grfView.ContextMenu = menuGw;
            grfView.DoubleClick += GrfView_DoubleClick;
            //grfExpnC.CellButtonClick += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellButtonClick);
            //grfExpnC.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellChanged);
            //grfJob.CellChanged += GrfExpnD_CellChanged;
            panel1.Controls.Add(grfView);
            grfView.Clear();
            grfView.Rows.Count = 2;
            grfView.Cols.Count = 5;
            grfView.Cols[colVName1].Width = 150;            

            grfView.Cols[colVName1].Caption = "NO";
            
            //grfView.Cols[colVNo].Visible = false;
            grfView.AllowEditing = false;
            //theme1.SetTheme(grfJob, "Office2013Red");
        }
        private void setGrfView(String dateStart, String dateEnd, String noStart, String noEnd)
        {
            grfView.DataSource = null;

            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("patient name", typeof(string)));
            dt1.Columns.Add(new DataColumn("ref id", typeof(string)));
            dt1.Columns.Add(new DataColumn("sample id", typeof(string)));
            grfView.Rows.Count = 2;
            grfView.Clear();
            //if (cucid.Equals("")) return;
            DataTable dt = new DataTable();
            CemDB cemDB;
            if (chk64Bit.Checked)
            {
                cemDB = new CemDB(txtPath.Text, CemDB.flagAccess.bit64);
            }
            else
            {
                cemDB = new CemDB(txtPath.Text, CemDB.flagAccess.bit32);
            }
            dt = cemDB.getDataHeader(dateStart, dateEnd, noStart, noEnd);
            grfView.Rows.Count = 2;
            grfView.Cols.Count = 3;
            TextBox txt = new TextBox();

            grfView.Cols[colVName1].Editor = txt;
            grfView.Cols[colVName1].Width = 80;                  

            //grfView.Cols[colVNo].Visible = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt1.NewRow();
                dr.ItemArray = new object[] { dt.Rows[i]["name"].ToString(), dt.Rows[i]["id"].ToString(), dt.Rows[i]["sampleid"].ToString() };
                //dr.ItemArray = new object[] { dt.Rows[i]["name"].ToString() };
                dt1.Rows.Add(dr);
                
            }
            grfView.DataSource = dt1;
            //grfView.Cols[0].Width = 70;
            grfView.Cols[colVName1].Width = 90;     //name
            grfView.Cols[colVpatientid1].Width = 70;     // patient id
            grfView.Cols[colVsampleid].Width = 70;     // sample id
            //grfView.Cols[colVId].Visible = false;
            //grfView.Cols[colVNo].Visible = false;
            grfView.AllowEditing = false;

            //FilterRow fr = new FilterRow(grfView);
            //setGrfColor();
            int j = 1;
            foreach (Row row1 in grfView.Rows)
            {
                if (row1[colVName1] == null) continue;
                if (row1[colVName1].ToString().Equals("")) continue;
                if (row1[colVName1].ToString().Equals("patient name")) continue;
                row1[0] = j;
                if (j % 2 == 0)
                    row1.StyleNew.BackColor = color;
                j++;
            }
            grfView.Cols[colVName1].AllowEditing = false;
            txtNoEnd.Value = dt.Rows.Count;
        }
        private void GrfView_DoubleClick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (grfView.Row < 1) return;
            if (grfView[grfView.Row, colVName1] == null) return;
            String dateStart = "", dateEnd = "";
            DateTime dateStart1, dateEnd1;
            dateStart1 = DateTime.Parse(cc.datetoDB(txtDateStart.Text));
            dateEnd1 = DateTime.Parse(txtDateEnd.Text);
            dateStart = setDate(dateStart1);
            dateEnd = setDate(dateEnd1);

            if (chkTestType.Checked)
            {
                setGrfSample(dateStart, dateEnd, grfView[grfView.Row, colVpatientid1].ToString(), flagTestType.retrtiveNo);
            }
            else
            {
                setGrfSample(dateStart, dateEnd, grfView[grfView.Row, colVpatientid1].ToString(), flagTestType.retriveYes);
            }
        }
        private void initGrfSample()
        {
            grfSample = new C1FlexGrid();
            grfSample.Font = fEdit;
            grfSample.Dock = System.Windows.Forms.DockStyle.Fill;
            grfSample.Location = new System.Drawing.Point(0, 0);

            //FilterRow fr = new FilterRow(grfView);

            //grfJob.AfterRowColChange += GrfJob_AfterRowColChange;
            //ContextMenu menuGw = new ContextMenu();
            //menuGw.MenuItems.Add("&แก้ไข", new EventHandler(ContextMenu_Gw_Edit));
            //grfView.ContextMenu = menuGw;
            //grfView.DoubleClick += GrfView_DoubleClick;
            //grfExpnC.CellButtonClick += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellButtonClick);
            //grfExpnC.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellChanged);
            //grfJob.CellChanged += GrfExpnD_CellChanged;
            panel2.Controls.Add(grfSample);
            grfSample.Clear();
            grfSample.Rows.Count = 2;
            grfSample.Cols.Count = 8;
            grfSample.Cols[colSresult].Width = 150;
            grfSample.Cols[colSref].Width = 150;

            grfSample.Cols[colSresult].Caption = "result";
            grfSample.Cols[colSref].Caption = "REF";

            //grfView.Cols[colVNo].Visible = false;
            grfSample.AllowEditing = false;
            //theme1.SetTheme(grfJob, "Office2013Red");
        }
        private void setGrfSample(String dateStart, String dateEnd, String noStart, flagTestType flagtesttype)
        {
            grfSample.DataSource = null;
            grfSample.Clear();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add(new DataColumn("date time", typeof(string)));
            dt1.Columns.Add(new DataColumn("ref id", typeof(string)));
            dt1.Columns.Add(new DataColumn("LAB id", typeof(string)));
            dt1.Columns.Add(new DataColumn("LAB name", typeof(string)));
            dt1.Columns.Add(new DataColumn("result", typeof(string)));
            dt1.Columns.Add(new DataColumn("result1", typeof(string)));
            dt1.Columns.Add(new DataColumn("value normal", typeof(string)));
            grfSample.Rows.Count = 2;
            grfSample.Clear();
            //if (cucid.Equals("")) return;
            DataTable dt = new DataTable();
            CemDB cemDB;
            if (chk64Bit.Checked)
            {
                cemDB = new CemDB(txtPath.Text, CemDB.flagAccess.bit64);
            }
            else
            {
                cemDB = new CemDB(txtPath.Text, CemDB.flagAccess.bit32);
            }
            dt = cemDB.getDataSample(dateStart, dateEnd, noStart, noStart, CemDB.flagTestType.retriveNo);
            grfSample.Rows.Count = 2;
            grfSample.Cols.Count = 7;
            TextBox txt = new TextBox();

            //grfView.Cols[colVNo].Visible = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt1.NewRow();
                String result = "";
                try
                {
                    result = cc.formatTextCEM(dt.Rows[i][4].ToString(), dt.Rows[i][2].ToString());
                    dr.ItemArray = new object[] { dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), result, dt.Rows[i][5].ToString() };
                    dt1.Rows.Add(dr);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(""+ex.Message, "error");
                }

            }
            grfSample.DataSource = dt1;
            grfSample.Cols[colVName1].Editor = txt;
            grfSample.Cols[colStime].Width = 180;
            grfSample.Cols[colSsampleid].Width = 70;
            grfSample.Cols[colSitemid].Width = 70;
            grfSample.Cols[colSfullname].Width = 180;
            grfSample.Cols[colSresult].Width = 120;
            grfSample.Cols[colSresult1].Width = 80;
            grfSample.Cols[colSref].Width = 100;

            grfSample.Cols[colStime].Caption = "date time";
            grfSample.Cols[colSitemid].Caption = "LAB id";
            grfSample.Cols[colSsampleid].Caption = "sample id";
            grfSample.Cols[colSfullname].Caption = "LAB name";
            grfSample.Cols[colSresult].Caption = "result";
            grfSample.Cols[colSresult1].Caption = "result1";
            grfSample.Cols[colSref].Caption = "value normal";
            //grfView.Cols[colVId].Visible = false;
            //grfView.Cols[colVNo].Visible = false;
            grfSample.AllowEditing = false;

            //FilterRow fr = new FilterRow(grfView);
            //setGrfColor();
            int j = 1;
            foreach (Row row1 in grfSample.Rows)
            {
                if (row1[colStime] == null) continue;
                if (row1[colStime].ToString().Equals("")) continue;
                if (row1[colStime].ToString().Equals("date time")) continue;
                row1[0] = j;
                if (j % 2 == 0)
                    row1.StyleNew.BackColor = color;
                j++;
            }
            grfSample.Cols[colStime].AllowEditing = false;
            grfSample.Cols[colSitemid].AllowEditing = false;
            grfSample.Cols[colSfullname].AllowEditing = false;
            grfSample.Cols[colSresult].AllowEditing = false;
            grfSample.Cols[colSref].AllowEditing = false;
        }
        private void FrmgetCEM_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            Application.Exit();
        }

        private void FrmgetCEM_Load(object sender, EventArgs e)
        {
            txtDateStart.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
            txtDateEnd.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
            txtNoStart.Value = 1;
            txtNoEnd.Value = 20;
        }
    }
}
