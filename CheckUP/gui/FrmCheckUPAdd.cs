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
    public partial class FrmCheckUPAdd : Form
    {
        CheckControl cc;
        CustCheckUp cuc;

        int tabSum = 0, tabPE=1, tabXRay=2, tabCBC=3, tabFBS=4, tabUA=5,tabTri=6, tabCho=7, tabSgot=8, tabBun=9, tabUric=10;
        int tabCnt = 11;

        int colPERow = 0, colPEId = 1, colPEName = 2, colPESex=3, colPEAge = 4, colPEWeight = 5, colPEHeight = 6, colPEBMI = 7, colPEvitalsign = 8, colPEx = 9, colPEResult = 10, colPESummary = 11;
        int colPECnt = 12;

        int colSumRow = 0, colSumDesc = 1, colSumSfCnt = 2, colSumSfNormal = 3, colSumAbNormal = 4, colSumPerNormal = 5, colSumPerAbNormal = 6;
        int colSumCnt = 7;

        int colXrayRow = 0, colXrayId = 1, colXrayName = 2, colXrayResult = 3, coLXraySummary = 4;
        int colXrayCnt = 5;

        int colCBCRow = 0, colCBCId = 1, colCBCName = 2, colCBCWBC = 3, colCBCRBC = 4, colCBCHb = 5, colCBCHct = 6, colCBCNew = 7, colCBCLy = 8, colCBCMono = 9, colCBCEo = 10;
        int colCBCBa = 11, colCBCPlt_c = 12, colCBCPlt_s = 13, colCBCRBC_mo = 14, colCBCSummary = 15;
        int colCBCCnt = 16;

        int colFBSRow = 0, colFBSId = 1, colFBSName = 2, colFBSValue=3, colFBSResult = 4, coLFBSSummary = 5;
        int colFBSCnt = 6;

        int colUARow = 0, colUAId = 1, colUAName = 2, colUColor = 3, colUAAppe = 4, colUASugar = 5, colUASpgr = 6, colUAPh = 7, colUAProtein = 8, colUAWBC = 9, colUARBC = 10;
        int colUAEpi = 11, colUABact = 12, colUAResult = 13, colUASummary = 14;
        int colUACnt = 15;

        int colTriRow = 0, colTriId = 1, colTriName = 2, colTriValue = 3, colTriResult = 4, coLTriSummary = 5;
        int colTriCnt = 6;

        int colChoRow = 0, colChoId = 1, colChoName = 2, colChoValue = 3, colChoResult = 4, coLChoSummary = 5;
        int colChoCnt = 6;

        int colSgotRow = 0, colSgotId = 1, colSgotName = 2, colSgotValue = 3, colSgotSgptValue = 4, colSgotResult=5, coLSgotSummary = 6;
        int colSgotCnt = 7;

        Font font = new Font("Microsoft Sans Serif", 12);
        Boolean flagNew=false;
        String fileName = "";
        public FrmCheckUPAdd(Boolean flagnew,CheckControl c)
        {
            InitializeComponent();
            cc = c;
            flagNew = flagnew;
            iniConfig();
        }
        private void iniConfig()
        {
            cuc = new CustCheckUp();
            tC.TabPages[tabSum].Text = "Summary";
            tC.TabPages[tabPE].Text = "PE";
            tC.TabPages[tabXRay].Text = "X-Ray";
            tC.TabPages[tabCBC].Text = "CBC";
            tC.TabPages[tabFBS].Text = "FBS";
            tC.TabPages[tabUA].Text = "UA";
            tC.TabPages[tabTri].Text = "Triglyceride";
            tC.TabPages[tabSgot].Text = "SGOT/SGPT";
            tC.TabPages[tabBun].Text = "BUN Creatine";
            tC.TabPages[tabUric].Text = "Uric acid";
            //tC.TabPages[tabCho].Text = "Cholesterol";
            pB1.Visible = false;
            if (flagNew)
            {
                btnImport.Text = "นำเข้ารายชื่อ";
                btnExcel.Enabled = true;
                btnImport.Enabled = false;
            }
            else
            {
                btnImport.Text = "บันทึก";
                btnExcel.Enabled = false;
            }

            tC.Font = font;
            cboCust = cc.cudb.getCboCustomer(cboCust);
            //tC.TabPages[tabCho].Text = "Cholesterol";
            
            setGrdSum();
            setGrdPE();
            setGrdXray();
            setGrdCBC();
            setGrdFBS();
            setGrdUA();
            setGrdTri();
            setGrdCho();
        }

        private void setResize()
        {
            tC.Width = this.Width - 50;
            tC.Height = this.Height - 150;
            tC.TabPages[tabSum].Width = tC.Width - 10;
            tC.TabPages[tabSum].Height = tC.Height - 10;
            dgvSum.Width = tC.TabPages[tabSum].Width - 10;
            dgvSum.Height = tC.TabPages[tabSum].Height - 10;


            tC.TabPages[tabPE].Width = tC.Width - 10;
            tC.TabPages[tabPE].Height = tC.Height - 10;
            dgvPE.Width = tC.TabPages[tabPE].Width - 10;
            dgvPE.Height = tC.TabPages[tabPE].Height - 10;
            dgvPE.Left = dgvSum.Left;
            dgvPE.Top = dgvSum.Left;

            tC.TabPages[tabXRay].Width = tC.Width - 10;
            tC.TabPages[tabXRay].Height = tC.Height - 10;
            dgvXRay.Width = tC.TabPages[tabXRay].Width - 10;
            dgvXRay.Height = tC.TabPages[tabXRay].Height - 10;
            dgvXRay.Left = dgvSum.Left;
            dgvXRay.Top = dgvSum.Left;

            tC.TabPages[tabCBC].Width = tC.Width - 10;
            tC.TabPages[tabCBC].Height = tC.Height - 10;
            dgvCBC.Width = tC.TabPages[tabCBC].Width - 10;
            dgvCBC.Height = tC.TabPages[tabCBC].Height - 10;
            dgvCBC.Left = dgvSum.Left;
            dgvCBC.Top = dgvSum.Left;

            tC.TabPages[tabFBS].Width = tC.Width - 10;
            tC.TabPages[tabFBS].Height = tC.Height - 10;
            dgvFBS.Width = tC.TabPages[tabFBS].Width - 10;
            dgvFBS.Height = tC.TabPages[tabFBS].Height - 10;
            dgvFBS.Left = dgvSum.Left;
            dgvFBS.Top = dgvSum.Left;

            tC.TabPages[tabUA].Width = tC.Width - 10;
            tC.TabPages[tabUA].Height = tC.Height - 10;
            dgvUA.Width = tC.TabPages[tabUA].Width - 10;
            dgvUA.Height = tC.TabPages[tabUA].Height - 10;
            dgvUA.Left = dgvSum.Left;
            dgvUA.Top = dgvSum.Left;

            tC.TabPages[tabTri].Width = tC.Width - 10;
            tC.TabPages[tabTri].Height = tC.Height - 10;
            dgvTri.Width = tC.TabPages[tabTri].Width - 10;
            dgvTri.Height = tC.TabPages[tabTri].Height - 10;
            dgvTri.Left = dgvSum.Left;
            dgvTri.Top = dgvSum.Left;

            tC.TabPages[tabCho].Width = tC.Width - 10;
            tC.TabPages[tabCho].Height = tC.Height - 10;
            dgvCho.Width = tC.TabPages[tabCho].Width - 10;
            dgvCho.Height = tC.TabPages[tabCho].Height - 10;
            dgvCho.Left = dgvSum.Left;
            dgvCho.Top = dgvSum.Left;

            //groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        private void setGrdPE()
        {
            dgvPE.ColumnCount = colPECnt;
            dgvPE.Rows.Clear();
            dgvPE.RowCount = 1;
            dgvPE.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPE.Columns[colPERow].Width = 50;
            dgvPE.Columns[colPEName].Width = 150;
            dgvPE.Columns[colPESex].Width = 120;
            dgvPE.Columns[colPEAge].Width = 80;
            dgvPE.Columns[colPEWeight].Width = 80;
            dgvPE.Columns[colPEHeight].Width = 180;
            dgvPE.Columns[colPEBMI].Width = 180;
            dgvPE.Columns[colPEvitalsign].Width = 180;
            dgvPE.Columns[colPEx].Width = 180;
            dgvPE.Columns[colPEResult].Width = 180;
            dgvPE.Columns[colPESummary].Width = 180;

            dgvPE.Columns[colPERow].HeaderText = "ลำดับ";
            dgvPE.Columns[colPEName].HeaderText = "code";
            dgvPE.Columns[colPESex].HeaderText = "ชื่อ";
            dgvPE.Columns[colPEAge].HeaderText = "หมายเหตุ";
            dgvPE.Columns[colPEWeight].HeaderText = "id";
            dgvPE.Columns[colPEHeight].HeaderText = "สิทธิใช้งาน";
            dgvPE.Columns[colPEBMI].HeaderText = "  ";
            dgvPE.Columns[colPEvitalsign].HeaderText = "  ";
            dgvPE.Columns[colPEx].HeaderText = "  ";
            dgvPE.Columns[colPEResult].HeaderText = "  ";
            dgvPE.Columns[colPESummary].HeaderText = "  ";

            dgvPE.Columns[colPEId].HeaderText = "id";
            

            dgvPE.Font = font;
            dgvPE.Columns[colPEId].Visible = false;
        }
        private void setGrdSum()
        {
            dgvSum.ColumnCount = colSumCnt;
            dgvSum.Rows.Clear();
            dgvSum.RowCount = 1;
            dgvSum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSum.Columns[colSumRow].Width = 50;
            dgvSum.Columns[colSumDesc].Width = 150;
            dgvSum.Columns[colSumSfCnt].Width = 120;
            dgvSum.Columns[colSumSfNormal].Width = 80;
            dgvSum.Columns[colSumAbNormal].Width = 80;
            dgvSum.Columns[colSumPerNormal].Width = 180;
            dgvSum.Columns[colSumPerAbNormal].Width = 180;            

            dgvSum.Columns[colSumRow].HeaderText = "ลำดับ";
            dgvSum.Columns[colSumDesc].HeaderText = "code";
            dgvSum.Columns[colSumSfCnt].HeaderText = "ชื่อ";
            dgvSum.Columns[colSumSfNormal].HeaderText = "หมายเหตุ";
            dgvSum.Columns[colSumAbNormal].HeaderText = "id";
            dgvSum.Columns[colSumPerNormal].HeaderText = "สิทธิใช้งาน";
            dgvSum.Columns[colSumPerAbNormal].HeaderText = "  ";            

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvSum.Font = font;
            //dgvSum.Columns[colPEId].Visible = false;
        }
        private void setGrdXray()
        {
            dgvXRay.ColumnCount = colXrayCnt;
            dgvXRay.Rows.Clear();
            dgvXRay.RowCount = 1;
            dgvXRay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXRay.Columns[colXrayRow].Width = 50;
            dgvXRay.Columns[colXrayId].Width = 150;
            dgvXRay.Columns[colXrayName].Width = 120;
            dgvXRay.Columns[colXrayResult].Width = 80;
            dgvXRay.Columns[coLXraySummary].Width = 80;            

            dgvXRay.Columns[colSumRow].HeaderText = "ลำดับ";
            dgvXRay.Columns[colXrayId].HeaderText = "code";
            dgvXRay.Columns[colXrayName].HeaderText = "ชื่อ";
            dgvXRay.Columns[colXrayResult].HeaderText = "หมายเหตุ";
            dgvXRay.Columns[coLXraySummary].HeaderText = "id";            

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvXRay.Font = font;
            //dgvSum.Columns[colPEId].Visible = false;
        }
        private void setGrdFBS()
        {
            dgvFBS.ColumnCount = colFBSCnt;
            dgvFBS.Rows.Clear();
            dgvFBS.RowCount = 1;
            dgvFBS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFBS.Columns[colFBSRow].Width = 50;
            dgvFBS.Columns[colFBSId].Width = 150;
            dgvFBS.Columns[colFBSName].Width = 120;
            dgvFBS.Columns[colFBSValue].Width = 80;
            dgvFBS.Columns[colFBSResult].Width = 80;
            dgvFBS.Columns[coLFBSSummary].Width = 80;

            dgvFBS.Columns[colFBSRow].HeaderText = "ลำดับ";
            dgvFBS.Columns[colFBSId].HeaderText = "code";
            dgvFBS.Columns[colFBSName].HeaderText = "ชื่อ";
            dgvFBS.Columns[colFBSValue].HeaderText = "หมายเหตุ";
            dgvFBS.Columns[colFBSResult].HeaderText = "id";
            dgvFBS.Columns[coLFBSSummary].HeaderText = "id";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvFBS.Font = font;
            //dgvSum.Columns[colPEId].Visible = false;
        }
        private void setGrdCBC()
        {
            dgvCBC.ColumnCount = colCBCCnt;
            dgvCBC.Rows.Clear();
            dgvCBC.RowCount = 1;
            dgvCBC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCBC.Columns[colCBCRow].Width = 50;
            dgvCBC.Columns[colCBCId].Width = 150;
            dgvCBC.Columns[colCBCName].Width = 120;
            dgvCBC.Columns[colCBCWBC].Width = 80;
            dgvCBC.Columns[colCBCRBC].Width = 80;
            dgvCBC.Columns[colCBCHb].Width = 180;
            dgvCBC.Columns[colCBCHct].Width = 180;
            dgvCBC.Columns[colCBCNew].Width = 180;
            dgvCBC.Columns[colCBCLy].Width = 180;
            dgvCBC.Columns[colCBCMono].Width = 180;
            dgvCBC.Columns[colCBCEo].Width = 180;
            dgvCBC.Columns[colCBCBa].Width = 180;
            dgvCBC.Columns[colCBCPlt_c].Width = 180;
            dgvCBC.Columns[colCBCPlt_s].Width = 180;
            dgvCBC.Columns[colCBCRBC_mo].Width = 180;
            dgvCBC.Columns[colCBCSummary].Width = 180;

            dgvCBC.Columns[colCBCRow].HeaderText = "ลำดับ";
            dgvCBC.Columns[colCBCId].HeaderText = "code";
            dgvCBC.Columns[colCBCName].HeaderText = "ชื่อ";
            dgvCBC.Columns[colCBCWBC].HeaderText = "หมายเหตุ";
            dgvCBC.Columns[colCBCRBC].HeaderText = "id";
            dgvCBC.Columns[colCBCHb].HeaderText = "สิทธิใช้งาน";
            dgvCBC.Columns[colCBCHct].HeaderText = "  ";
            dgvCBC.Columns[colCBCNew].HeaderText = "  ";
            dgvCBC.Columns[colCBCLy].HeaderText = "  ";
            dgvCBC.Columns[colCBCMono].HeaderText = "  ";
            dgvCBC.Columns[colCBCEo].HeaderText = "  ";
            dgvCBC.Columns[colCBCBa].HeaderText = "  ";
            dgvCBC.Columns[colCBCPlt_c].HeaderText = "  ";
            dgvCBC.Columns[colCBCPlt_s].HeaderText = "  ";
            dgvCBC.Columns[colCBCRBC_mo].HeaderText = "  ";
            dgvCBC.Columns[colCBCSummary].HeaderText = "  ";

            dgvCBC.Columns[colUAId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvCBC.Font = font;
            dgvCBC.Columns[colUAId].Visible = false;
        }
        private void setGrdUA()
        {
            dgvUA.ColumnCount = colUACnt;
            dgvUA.Rows.Clear();
            dgvUA.RowCount = 1;
            dgvUA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUA.Columns[colUARow].Width = 50;
            dgvUA.Columns[colUAName].Width = 150;
            dgvUA.Columns[colUColor].Width = 120;
            dgvUA.Columns[colUAAppe].Width = 80;
            dgvUA.Columns[colUASugar].Width = 80;
            dgvUA.Columns[colUASpgr].Width = 180;
            dgvUA.Columns[colUAPh].Width = 180;
            dgvUA.Columns[colUAProtein].Width = 180;
            dgvUA.Columns[colUAWBC].Width = 180;
            dgvUA.Columns[colUARBC].Width = 180;
            dgvUA.Columns[colUAEpi].Width = 180;
            dgvUA.Columns[colUABact].Width = 180;
            dgvUA.Columns[colUAResult].Width = 180;
            dgvUA.Columns[colUASummary].Width = 180;
            //dgvUA.Columns[colUASummary].Width = 180;

            dgvUA.Columns[colUARow].HeaderText = "ลำดับ";
            dgvUA.Columns[colUAName].HeaderText = "code";
            dgvUA.Columns[colUColor].HeaderText = "ชื่อ";
            dgvUA.Columns[colUAAppe].HeaderText = "หมายเหตุ";
            dgvUA.Columns[colUASugar].HeaderText = "id";
            dgvUA.Columns[colUASpgr].HeaderText = "สิทธิใช้งาน";
            dgvUA.Columns[colUAPh].HeaderText = "  ";
            dgvUA.Columns[colUAProtein].HeaderText = "  ";
            dgvUA.Columns[colUAWBC].HeaderText = "  ";
            dgvUA.Columns[colUARBC].HeaderText = "  ";
            dgvUA.Columns[colUAEpi].HeaderText = "  ";
            dgvUA.Columns[colUABact].HeaderText = "  ";
            dgvUA.Columns[colUAResult].HeaderText = "  ";
            dgvUA.Columns[colUASummary].HeaderText = "  ";
            //dgvUA.Columns[colUASummary].HeaderText = "  ";

            dgvUA.Columns[colUAId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvUA.Font = font;
            dgvUA.Columns[colUAId].Visible = false;
        }
        private void setGrdTri()
        {
            dgvTri.ColumnCount = colTriCnt;
            dgvTri.Rows.Clear();
            dgvTri.RowCount = 1;
            dgvTri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTri.Columns[colTriRow].Width = 50;
            dgvTri.Columns[colTriId].Width = 150;
            dgvTri.Columns[colTriName].Width = 120;
            dgvTri.Columns[colTriValue].Width = 80;
            dgvTri.Columns[colTriResult].Width = 80;
            dgvTri.Columns[coLTriSummary].Width = 80;

            dgvTri.Columns[colTriRow].HeaderText = "ลำดับ";
            dgvTri.Columns[colTriId].HeaderText = "code";
            dgvTri.Columns[colTriName].HeaderText = "ชื่อ";
            dgvTri.Columns[colTriValue].HeaderText = "หมายเหตุ";
            dgvTri.Columns[colTriResult].HeaderText = "id";
            dgvTri.Columns[coLTriSummary].HeaderText = "id";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvTri.Font = font;
            //dgvSum.Columns[colPEId].Visible = false;
        }
        private void setGrdCho()
        {
            dgvCho.ColumnCount = colChoCnt;
            dgvCho.Rows.Clear();
            dgvCho.RowCount = 1;
            dgvCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCho.Columns[colChoRow].Width = 50;
            dgvCho.Columns[colChoId].Width = 150;
            dgvCho.Columns[colChoName].Width = 120;
            dgvCho.Columns[colChoValue].Width = 80;
            dgvCho.Columns[colChoResult].Width = 80;
            dgvCho.Columns[coLChoSummary].Width = 80;

            dgvCho.Columns[colChoRow].HeaderText = "ลำดับ";
            dgvCho.Columns[colChoId].HeaderText = "code";
            dgvCho.Columns[colChoName].HeaderText = "ชื่อ";
            dgvCho.Columns[colChoValue].HeaderText = "หมายเหตุ";
            dgvCho.Columns[colChoResult].HeaderText = "id";
            dgvCho.Columns[coLChoSummary].HeaderText = "id";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvCho.Font = font;
            //dgvSum.Columns[colPEId].Visible = false;
        }
        private void setGrdSgot()
        {
            dgvCho.ColumnCount = colChoCnt;
            dgvCho.Rows.Clear();
            dgvCho.RowCount = 1;
            dgvCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCho.Columns[colChoRow].Width = 50;
            dgvCho.Columns[colChoId].Width = 150;
            dgvCho.Columns[colChoName].Width = 120;
            dgvCho.Columns[colChoValue].Width = 80;
            dgvCho.Columns[colChoResult].Width = 80;
            dgvCho.Columns[coLChoSummary].Width = 80;

            dgvCho.Columns[colChoRow].HeaderText = "ลำดับ";
            dgvCho.Columns[colChoId].HeaderText = "code";
            dgvCho.Columns[colChoName].HeaderText = "ชื่อ";
            dgvCho.Columns[colChoValue].HeaderText = "หมายเหตุ";
            dgvCho.Columns[colChoResult].HeaderText = "id";
            dgvCho.Columns[coLChoSummary].HeaderText = "id";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvCho.Font = font;
            //dgvSum.Columns[colPEId].Visible = false;
        }
        private void setControl(String cucId)
        {
            cuc = cc.cucdb.selectByPk(cucId);
            txtDescription.Text = cuc.Description;
            cboCust.Text = cuc.CustNameT;
            txtId.Text = cuc.Id;
        }
        private void getCustCheckUp()
        {
            cuc.Active = "1";
            cuc.CheckUpDate = "";
            cuc.CntEmployee = "";
            cuc.Description = txtDescription.Text;
            cuc.YearId = "";
        }
        private void ImportExcel()
        {
            pB1.Visible = true;
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //object misval = System.Reflection.Missing.Value;
            if (!System.IO.File.Exists(fileName))
            {
                pB1.Visible = false;
                return;
            }
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            String prefix = "", firstName = "", lastName = "";
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;


            if (cboCust.Text.Equals(""))
            {
                pB1.Visible = false;
                MessageBox.Show("ไม่ได้ป้อนชื่อ", "ป้อนข้อมูลไม่ครบ");
                return;
            }

            getCustCheckUp();
            if (cc.cucdb.insertCustCheckUp(cuc).Length < 1)
            {
                pB1.Visible = false;
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ ", "Error ");
                return;
            }

            pB1.Maximum = rowCount;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                CustCheckUpPatient ccp = new CustCheckUpPatient();
                ccp.Active = "1";
                ccp.Id = "";
                prefix = "";
                firstName = "";
                lastName = "";
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    prefix = xlRange.Cells[i, 2].Value2.ToString();
                }
                else
                {
                    prefix = "";
                }
                if (xlRange.Cells[i, 2].Value2 != null)
                {
                    firstName = xlRange.Cells[i, 3].Value2.ToString();
                }
                else
                {
                    firstName = "";
                    continue;
                }
                if (xlRange.Cells[i, 3].Value2 != null)
                {
                    lastName = xlRange.Cells[i, 4].Value2.ToString();
                }
                else
                {
                    lastName = "";
                }
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    ccp.rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    ccp.rowNumber = "";
                }
                if (xlRange.Cells[i, 4].Value2 != null)
                {
                    ccp.patientAge = xlRange.Cells[i, 4].Value2.ToString();
                }
                else
                {

                }
                ccp.patientFullname = prefix + " " + firstName + " " + lastName;


                cc.ccpdb.InsertCustCheckUpPatient(ccp);
                pB1.Value = i;
                //for (int j = 1; j <= colCount; j++)
                //{
                //    MessageBox.Show(xlRange.Cells[i, j].Value2.ToString());
                //}

            }
            pB1.Visible = false;
        }
        private void FrmCheckUPAdd_Load(object sender, EventArgs e)
        {

        }

        private void FrmCheckUPAdd_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            FrmCustAdd frm = new FrmCustAdd("",cc);
            frm.ShowDialog(this);
            cboCust = cc.cudb.getCboCustomer(cboCust);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (flagNew)
            {
                ImportExcel();
            }
            else
            {

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            //Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //object misval = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            fileName = ofd.FileName;
            btnImport.Enabled = true;
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;

                //txtId.Enabled = true;
                //txtCode.Enabled = true;
                //txtAddr.Enabled = true;
                //txtAddressE.Enabled = true;
                //txtAddressT.Enabled = true;
                //txtEmail.Enabled = true;
                //TxtFax.Enabled = true;
                //txtNameE.Enabled = true;
                //txtNameT.Enabled = true;
                //txtTaxID.Enabled = true;
                //txtTele.Enabled = true;
                //txtZipcode.Enabled = true;
                //cboAmphur.Enabled = true;
                //cboDistrict.Enabled = true;
                //cboProvince.Enabled = true;
                //txtContactName1.Enabled = true;
                //txtContactName1Tel.Enabled = true;
                //txtContactName2.Enabled = true;
                //txtContactName2Tel.Enabled = true;
            }
        }

        private void chkActive_Click(object sender, EventArgs e)
        {

        }

    }
}
