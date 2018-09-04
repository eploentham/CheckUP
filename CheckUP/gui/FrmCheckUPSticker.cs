using C1.Win.C1FlexGrid;
using CheckUP.Control;
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
    public partial class FrmCheckUPSticker : Form
    {
        CheckControl cc;
        CustCheckUp cuc;
        Font fEdit, fEditB;
        Font font = new Font("Microsoft Sans Serif", 12);

        C1FlexGrid grfView;
        Color color;
        String cucId = "";

        int colId = 1, colCode = 2, colName = 3, colPrn=4;
        public FrmCheckUPSticker(String cucId, CheckControl c)
        {
            InitializeComponent();
            cc = c;            
            iniConfig(cucId);
        }
        private void iniConfig(String cucId)
        {
            cuc = new CustCheckUp();
            this.cucId = cucId;
            color = ColorTranslator.FromHtml(cc.initC.grfRowColor);

            btnSave.Click += BtnSave_Click;
            btnLabelSticker.Click += BtnLabelSticker_Click;
            initGrfView();
            setGrfView();
        }

        private void BtnLabelSticker_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            FrmLabelSticker frm = new FrmLabelSticker(cc);
            frm.ShowDialog(this);
            setGrfView();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            for(int i = 1; i < grfView.Rows.Count; i++)
            {
                Row row = grfView.Rows[i];
                cc.cucdb.UpdateSticker(cucId, row[colCode].ToString(), row[colPrn] != null ? (bool)row[colPrn] == true ? "1" : "0": "0");
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
            //grfView.DoubleClick += GrfView_DoubleClick;
            //grfExpnC.CellButtonClick += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellButtonClick);
            //grfExpnC.CellChanged += new C1.Win.C1FlexGrid.RowColEventHandler(this.grfDept_CellChanged);
            grfView.CellChecked += GrfView_CellChecked;
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
            if (cucId.Equals("")) return;
            DataTable dt = new DataTable();
            cuc = cc.cucdb.selectByPk(cucId);
            dt = cc.stkdb.selectAll();
            grfView.Rows.Count = 1;
            grfView.Cols.Count = 5;
            TextBox txt = new TextBox();
            CellStyle cs = grfView.Styles.Add("bool");
            cs.DataType = typeof(bool);
            cs.TextAlign = TextAlignEnum.LeftCenter;
            
            //if ((bool)row[colPdChk] == true)
            grfView.Cols[colCode].Editor = txt;
            grfView.Cols[colName].Editor = txt;
            grfView.Cols[colPrn].Style = cs;

            grfView.Cols[colCode].Width = 80;
            grfView.Cols[colName].Width = 200;
            grfView.Cols[colPrn].Width = 40;

            grfView.Cols[colCode].Caption = "รหัส";
            grfView.Cols[colName].Caption = "ชื่อ";
            grfView.Cols[colPrn].Caption = "พิมพ์";

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
                //row[colPrn] = "33333";
                if (i == 0)
                {
                    row[colPrn] = cuc.sticker01 != null ? cuc.sticker01.Equals("1") ? true : false : false;
                    if((cuc.sticker01 != null) && (cuc.sticker01.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 1)
                {
                    row[colPrn] = cuc.sticker02 != null ? cuc.sticker02.Equals("1") ? true : false : false;
                    if ((cuc.sticker02 != null) && (cuc.sticker02.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 2)
                {
                    row[colPrn] = cuc.sticker03 != null ? cuc.sticker03.Equals("1") ? true : false : false;
                    if ((cuc.sticker03 != null) && (cuc.sticker03.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 3)
                {
                    row[colPrn] = cuc.sticker04 != null ? cuc.sticker04.Equals("1") ? true : false : false;
                    if ((cuc.sticker04 != null) && (cuc.sticker04.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 4)
                {
                    row[colPrn] = cuc.sticker05 != null ? cuc.sticker05.Equals("1") ? true : false : false;
                    if ((cuc.sticker05 != null) && (cuc.sticker05.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 5)
                {
                    row[colPrn] = cuc.sticker06 != null ? cuc.sticker06.Equals("1") ? true : false : false;
                    if ((cuc.sticker06 != null) && (cuc.sticker06.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 6)
                {
                    row[colPrn] = cuc.sticker07 != null ? cuc.sticker07.Equals("1") ? true : false : false;
                    if ((cuc.sticker07 != null) && (cuc.sticker07.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 7)
                {
                    row[colPrn] = cuc.sticker08 != null ? cuc.sticker08.Equals("1") ? true : false : false;
                    if ((cuc.sticker08 != null) && (cuc.sticker08.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 8)
                {
                    row[colPrn] = cuc.sticker09 != null ? cuc.sticker09.Equals("1") ? true : false : false;
                    if ((cuc.sticker09 != null) && (cuc.sticker09.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 9)
                {
                    row[colPrn] = cuc.sticker10 != null ? cuc.sticker10.Equals("1") ? true : false : false;
                    if ((cuc.sticker10 != null) && (cuc.sticker10.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 10)
                {
                    row[colPrn] = cuc.sticker11 != null ? cuc.sticker11.Equals("1") ? true : false : false;
                    if ((cuc.sticker11 != null) && (cuc.sticker11.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 11)
                {
                    row[colPrn] = cuc.sticker12 != null ? cuc.sticker12.Equals("1") ? true : false : false;
                    if ((cuc.sticker12 != null) && (cuc.sticker12.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 12)
                {
                    row[colPrn] = cuc.sticker13 != null ? cuc.sticker13.Equals("1") ? true : false : false;
                    if ((cuc.sticker13 != null) && (cuc.sticker13.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 13)
                {
                    row[colPrn] = cuc.sticker14 != null ? cuc.sticker14.Equals("1") ? true : false : false;
                    if ((cuc.sticker14 != null) && (cuc.sticker14.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 14)
                {
                    row[colPrn] = cuc.sticker15 != null ? cuc.sticker15.Equals("1") ? true : false : false;
                    if ((cuc.sticker15 != null) && (cuc.sticker15.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 15)
                {
                    row[colPrn] = cuc.sticker16 != null ? cuc.sticker16.Equals("1") ? true : false : false;
                    if ((cuc.sticker16 != null) && (cuc.sticker16.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 16)
                {
                    row[colPrn] = cuc.sticker17 != null ? cuc.sticker17.Equals("1") ? true : false : false;
                    if ((cuc.sticker17 != null) && (cuc.sticker17.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 17)
                {
                    row[colPrn] = cuc.sticker18 != null ? cuc.sticker18.Equals("1") ? true : false : false;
                    if ((cuc.sticker18 != null) && (cuc.sticker18.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 18)
                {
                    row[colPrn] = cuc.sticker19 != null ? cuc.sticker19.Equals("1") ? true : false : false;
                    if ((cuc.sticker19 != null) && (cuc.sticker19.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                else if (i == 19)
                {
                    row[colPrn] = cuc.sticker20 != null ? cuc.sticker20.Equals("1") ? true : false : false;
                    if ((cuc.sticker20 != null) && (cuc.sticker20.Equals("1")))
                    {
                        row[colPrn] = true;
                        row.StyleNew.BackColor = Color.Fuchsia;
                    }
                    else
                    {
                        row[colPrn] = false;
                    }
                }
                
            }
            grfView.Cols[colId].Visible = false;
            grfView.Cols[colCode].AllowEditing = false;
            grfView.Cols[colName].AllowEditing = false;
            grfView.Cols[colPrn].AllowEditing = true;
        }
        private void GrfView_CellChecked(object sender, RowColEventArgs e)
        {
            //throw new NotImplementedException();
            if (grfView[e.Row, e.Col] == null) return;
            Row row = grfView.Rows[grfView.Row];
            
            if ((Boolean)row[colPrn] == true)
            {
                row.StyleNew.BackColor = Color.Fuchsia;
            }
            else
            {
                if (e.Row % 2 != 0)
                {
                    row.StyleNew.BackColor = color;
                }
                else
                {
                    row.StyleNew.BackColor = Color.White;
                }
            }
        }
        private void FrmCheckUPSticker_Load(object sender, EventArgs e)
        {

        }
    }
}
