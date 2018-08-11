using C1.Win.C1FlexGrid;
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
    public partial class FrmLabelSticker : Form
    {
        CheckControl cc;

        Font fEdit, fEditB;
        Font font = new Font("Microsoft Sans Serif", 12);

        C1FlexGrid grfView;
        Color color;
        String cucId = "";

        int colId = 1, colCode = 2, colName = 3, colPrn = 4;
        public FrmLabelSticker(CheckControl c)
        {
            InitializeComponent();
            cc = c;
            iniConfig();
        }
        private void iniConfig()
        {
            btnSave.Click += BtnSave_Click;
            initGrfView();
            setGrfView();
        }
        private void initGrfView()
        {
            grfView = new C1FlexGrid();
            grfView.Font = fEdit;
            grfView.Dock = System.Windows.Forms.DockStyle.Fill;
            grfView.Location = new System.Drawing.Point(0, 0);

            //FilterRow fr = new FilterRow(grfView);

            //grfJob.AfterRowColChange += GrfJob_AfterRowColChange;
            //grfView.DoubleClick += GrfView_DoubleClick;
            //grfExpnC.CellButtonClick += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellButtonClick);
            //grfExpnC.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellChanged);
            //grfJob.CellChanged += GrfExpnD_CellChanged;
            panel3.Controls.Add(grfView);
            grfView.Clear();
            grfView.Rows.Count = 2;
            grfView.Cols.Count = 5;
            grfView.Cols[colCode].Width = 80;
            grfView.Cols[colName].Width = 200;

            grfView.Cols[colCode].Caption = "รหัส";
            grfView.Cols[colName].Caption = "ชื่อ";

            grfView.Cols[colId].Visible = false;
            grfView.AllowEditing = true;
            //theme1.SetTheme(grfJob, "Office2013Red");
        }
        private void setGrfView()
        {
            grfView.DataSource = null;
            grfView.Rows.Count = 1;
            grfView.Clear();
            
            DataTable dt = new DataTable();
            
            dt = cc.stkdb.selectAll();
            grfView.Rows.Count = 1;
            grfView.Cols.Count = 5;
            TextBox txt = new TextBox();            

            //if ((bool)row[colPdChk] == true)
            grfView.Cols[colCode].Editor = txt;
            grfView.Cols[colName].Editor = txt;
            

            grfView.Cols[colCode].Width = 80;
            grfView.Cols[colName].Width = 200;
            

            grfView.Cols[colCode].Caption = "รหัส";
            grfView.Cols[colName].Caption = "ชื่อ";
            

            grfView.Cols[colId].Visible = false;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Row row = grfView.Rows.Add();
                row[0] = i + 1;
                if (i % 2 == 0)
                    row.StyleNew.BackColor = color;
                row[colId] = dt.Rows[i][cc.stkdb.stk.sticker_id].ToString();
                row[colCode] = dt.Rows[i][cc.stkdb.stk.sticker_code].ToString();
                row[colName] = dt.Rows[i][cc.stkdb.stk.sticker_name].ToString();

            }
            grfView.Cols[colId].Visible = false;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            for (int i = 1; i < grfView.Rows.Count; i++)
            {
                Row row = grfView.Rows[i];
                cc.stkdb.update(row[colId].ToString(), row[colName] != null ? row[colName].ToString() : "-");
            }
        }
        private void FrmLabelSticker_Load(object sender, EventArgs e)
        {

        }
    }
}
