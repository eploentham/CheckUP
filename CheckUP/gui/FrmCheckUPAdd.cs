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

        int colPERow = 0, colPEId = 1, colPEName = 2, colPESex=3, colPEAge = 4, colPEWeight = 5, colPEHeight = 6, colPEBMI = 7, colPEvitalsign = 8, colPEPulse = 9, colPEResult = 10, colPESummary = 11;
        int colPECnt = 12;

        int colSumRow = 0, colSumDesc = 1, colSumSfCnt = 2, colSumSfNormal = 3, colSumAbNormal = 4, colSumPerNormal = 5, colSumPerAbNormal = 6, colSumOpen=7, colSumImport=8;
        int colSumCnt = 9;

        int colXrayRow = 0, colXrayId = 1, colXrayName = 2, colXrayResult = 3, coLXraySummary = 4;
        int colXrayCnt = 5;

        int colCBCRow = 0, colCBCId = 1, colCBCName = 2, colCBCWBC = 3, colCBCRBC = 4, colCBCHb = 5, colCBCHct = 6, colCBCNeu = 7, colCBCLy = 8, colCBCMono = 9, colCBCEo = 10;
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

        int colBunRow = 0, colBunId = 1, colBunName = 2, colBunValue = 3, colBunCreatinineValue = 4, colBunResult = 5, coLBunSummary = 6;
        int colBunCnt = 7;

        int colUricRow = 0, colUricId = 1, colUricName = 2, colUricValue = 3, colUricResult = 4, coLUricSummary = 5;
        int colUricCnt = 6;

        Font font = new Font("Microsoft Sans Serif", 12);
        Boolean flagNew=false;
        String fileName = "", fileNamePE = "", fileNameFBS = "", fileNameXray = "", fileNameCBC = "", fileNameUA = "", fileNameTri = "", fileNameCho = "";
        String fileNameSgot = "", fileNameBun = "", fileNameUric = "";
        //String cucId = "";
        DataTable dtAll;
        OpenFileDialog ofd = new OpenFileDialog();
        object misValue = System.Reflection.Missing.Value;
        public FrmCheckUPAdd(String cucId,Boolean flagnew,CheckControl c)
        {
            InitializeComponent();
            cc = c;
            flagNew = flagnew;
            iniConfig(cucId);
        }
        private void iniConfig(String cucId)
        {
            cuc = new CustCheckUp();
            cuc.Id = cucId;
            dtAll = cc.ccpdb.selectAllByCucId(cucId);
            tC.TabPages[tabSum].Text = "Summary";
            tC.TabPages[tabPE].Text = "PE";
            tC.TabPages[tabXRay].Text = "X-Ray";
            tC.TabPages[tabCBC].Text = "CBC";
            tC.TabPages[tabFBS].Text = "FBS";
            tC.TabPages[tabUA].Text = "UA";
            tC.TabPages[tabTri].Text = "Triglyceride";
            tC.TabPages[tabCho].Text = "Choles";
            tC.TabPages[tabSgot].Text = "SGOT/SGPT";
            tC.TabPages[tabBun].Text = "BUN Creatine";
            tC.TabPages[tabUric].Text = "Uric acid";
            //tC.TabPages[tabCho].Text = "Cholesterol";
            pB1.Visible = false;
            btnPEImport.Enabled = false;
            btnXrayImport.Enabled = false;
            btnCBCImport.Enabled = false;
            btnUAImport.Enabled = false;
            btnTriImport.Enabled = false;
            btnChoImport.Enabled = false;
            btnFBSImport.Enabled = false;
            btnUricImport.Enabled = false;
            btnSgotImport.Enabled = false;
            btnBunImport.Enabled = false;
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
            setControl(cucId);
            //setGrdSum();
            setGrdPE();
            setGrdXray();
            setGrdCBC();
            setGrdFBS();
            setGrdUA();
            setGrdTri();
            setGrdCho();
            setGrdSgot();
            setGrdBun();
            setGrdUric();
            setGrdPE(cucId);
            setGrdXray(cucId);
            setGrdFBS(cucId);
            setGrdCBC(cucId);
            setGrdUA(cucId);
            setGrdTri(cucId);
            setGrdCholes(cucId);
            setGrdSgot(cucId);
            setGrdBun(cucId);
            setGrdUric(cucId);
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
            //dgvPE.Left = dgvSum.Left;
            //dgvPE.Top = dgvSum.Left;
            dgvSum.Width = tC.TabPages[tabPE].Width - 10;
            dgvSum.Height = tC.TabPages[tabPE].Height - 10;

            tC.TabPages[tabXRay].Width = tC.Width - 10;
            tC.TabPages[tabXRay].Height = tC.Height - 10;
            dgvXRay.Width = tC.TabPages[tabXRay].Width - 10;
            dgvXRay.Height = tC.TabPages[tabXRay].Height - 10;
            dgvXRay.Left = dgvPE.Left;
            dgvXRay.Top = dgvPE.Left;

            tC.TabPages[tabCBC].Width = tC.Width - 10;
            tC.TabPages[tabCBC].Height = tC.Height - 10;
            dgvCBC.Width = tC.TabPages[tabCBC].Width - 10;
            dgvCBC.Height = tC.TabPages[tabCBC].Height - 10;
            dgvCBC.Left = dgvPE.Left;
            dgvCBC.Top = dgvPE.Left;

            tC.TabPages[tabFBS].Width = tC.Width - 10;
            tC.TabPages[tabFBS].Height = tC.Height - 10;
            dgvFBS.Width = tC.TabPages[tabFBS].Width - 10;
            dgvFBS.Height = tC.TabPages[tabFBS].Height - 10;
            dgvFBS.Left = dgvPE.Left;
            dgvFBS.Top = dgvPE.Left;

            tC.TabPages[tabUA].Width = tC.Width - 10;
            tC.TabPages[tabUA].Height = tC.Height - 10;
            dgvUA.Width = tC.TabPages[tabUA].Width - 10;
            dgvUA.Height = tC.TabPages[tabUA].Height - 10;
            dgvUA.Left = dgvPE.Left;
            dgvUA.Top = dgvPE.Left;

            tC.TabPages[tabTri].Width = tC.Width - 10;
            tC.TabPages[tabTri].Height = tC.Height - 10;
            dgvTri.Width = tC.TabPages[tabTri].Width - 10;
            dgvTri.Height = tC.TabPages[tabTri].Height - 10;
            dgvTri.Left = dgvPE.Left;
            dgvTri.Top = dgvPE.Left;

            tC.TabPages[tabCho].Width = tC.Width - 10;
            tC.TabPages[tabCho].Height = tC.Height - 10;
            dgvCho.Width = tC.TabPages[tabCho].Width - 10;
            dgvCho.Height = tC.TabPages[tabCho].Height - 10;
            dgvCho.Left = dgvPE.Left;
            dgvCho.Top = dgvPE.Left;

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
            dgvPE.Columns[colPEName].Width = 250;
            dgvPE.Columns[colPESex].Width = 120;
            dgvPE.Columns[colPEAge].Width = 80;
            dgvPE.Columns[colPEWeight].Width = 80;
            dgvPE.Columns[colPEHeight].Width = 180;
            dgvPE.Columns[colPEBMI].Width = 180;
            dgvPE.Columns[colPEvitalsign].Width = 180;
            dgvPE.Columns[colPEPulse].Width = 180;
            dgvPE.Columns[colPEResult].Width = 180;
            dgvPE.Columns[colPESummary].Width = 180;

            dgvPE.Columns[colPERow].HeaderText = "ลำดับ";
            dgvPE.Columns[colPEName].HeaderText = "ชื่อ นามสกุล";
            dgvPE.Columns[colPESex].HeaderText = "เพศ";
            dgvPE.Columns[colPEAge].HeaderText = "อายุ";
            dgvPE.Columns[colPEWeight].HeaderText = "น้ำหนัก";
            dgvPE.Columns[colPEHeight].HeaderText = "ส่วนสูง";
            dgvPE.Columns[colPEBMI].HeaderText = "BMI";
            dgvPE.Columns[colPEvitalsign].HeaderText = "VitalSign";
            dgvPE.Columns[colPEPulse].HeaderText = "Pulse";
            dgvPE.Columns[colPEResult].HeaderText = "ผล";
            dgvPE.Columns[colPESummary].HeaderText = "สรุปผลตรวจ";

            dgvPE.Columns[colPEId].HeaderText = "id";
            

            dgvPE.Font = font;
            dgvPE.Columns[colPEId].Visible = false;
        }
        private void setGrdSum()
        {
            dgvSum.ColumnCount = colSumCnt;
            dgvSum.Rows.Clear();
            dgvSum.RowCount = 6;
            dgvSum.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSum.Columns[colSumRow].Width = 50;
            dgvSum.Columns[colSumDesc].Width = 150;
            dgvSum.Columns[colSumSfCnt].Width = 80;
            dgvSum.Columns[colSumSfNormal].Width = 80;
            dgvSum.Columns[colSumAbNormal].Width = 80;
            dgvSum.Columns[colSumPerNormal].Width = 80;
            dgvSum.Columns[colSumPerAbNormal].Width = 80;
            dgvSum.Columns[colSumOpen].Width = 60;
            dgvSum.Columns[colSumImport].Width = 60;

            dgvSum.Columns[colSumRow].HeaderText = "ลำดับ";
            dgvSum.Columns[colSumDesc].HeaderText = "รายการ";
            dgvSum.Columns[colSumSfCnt].HeaderText = "จน.พนักงาน";
            dgvSum.Columns[colSumSfNormal].HeaderText = "ผลปกติ";
            dgvSum.Columns[colSumAbNormal].HeaderText = "ผลผิดปกติ";
            dgvSum.Columns[colSumPerNormal].HeaderText = "%ผลปกติ";
            dgvSum.Columns[colSumPerAbNormal].HeaderText = "%ผลผิดปกติ";
            dgvSum.Columns[colSumOpen].HeaderText = "open";
            dgvSum.Columns[colSumImport].HeaderText = "import";

            dgvSum[colSumRow, 0].Value = 1;
            dgvSum[colSumDesc, 0].Value = "PE รายละเอียดพนักงาน ";
            dgvSum[colSumSfCnt, 0].Value = dtAll.Rows.Count;
            dgvSum[colSumOpen, 0].Value = "...";
            dgvSum[colSumSfCnt, 0].Value = "นำเข้า";
            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvSum.Font = font;
            dgvSum.ReadOnly = true;
        }
        private void setGrdXray()
        {
            dgvXRay.ColumnCount = colXrayCnt;
            dgvXRay.Rows.Clear();
            dgvXRay.RowCount = 1;
            dgvXRay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvXRay.Columns[colXrayRow].Width = 50;
            dgvXRay.Columns[colXrayId].Width = 250;
            dgvXRay.Columns[colXrayName].Width = 250;
            dgvXRay.Columns[colXrayResult].Width = 180;
            dgvXRay.Columns[coLXraySummary].Width = 180;            

            dgvXRay.Columns[colSumRow].HeaderText = "ลำดับ";
            dgvXRay.Columns[colXrayId].HeaderText = "id";
            dgvXRay.Columns[colXrayName].HeaderText = "ชื่อ นามสกุล";
            dgvXRay.Columns[colXrayResult].HeaderText = "ผล";
            dgvXRay.Columns[coLXraySummary].HeaderText = "สรุปผลตรวจ";            

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvXRay.Font = font;
            dgvXRay.Columns[colXrayId].Visible = false;
        }
        private void setGrdFBS()
        {
            dgvFBS.ColumnCount = colFBSCnt;
            dgvFBS.Rows.Clear();
            dgvFBS.RowCount = 1;
            dgvFBS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFBS.Columns[colFBSRow].Width = 50;
            dgvFBS.Columns[colFBSId].Width = 250;
            dgvFBS.Columns[colFBSName].Width = 250;
            dgvFBS.Columns[colFBSValue].Width = 80;
            dgvFBS.Columns[colFBSResult].Width = 180;
            dgvFBS.Columns[coLFBSSummary].Width = 180;

            dgvFBS.Columns[colFBSRow].HeaderText = "ลำดับ";
            dgvFBS.Columns[colFBSId].HeaderText = "code";
            dgvFBS.Columns[colFBSName].HeaderText = "ชื่อ นามสกุล";
            dgvFBS.Columns[colFBSValue].HeaderText = "ค่า";
            dgvFBS.Columns[colFBSResult].HeaderText = "ผล";
            dgvFBS.Columns[coLFBSSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvFBS.Font = font;
            dgvFBS.Columns[colFBSId].Visible = false;
        }
        private void setGrdCBC()
        {
            dgvCBC.ColumnCount = colCBCCnt;
            dgvCBC.Rows.Clear();
            dgvCBC.RowCount = 1;
            dgvCBC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCBC.Columns[colCBCRow].Width = 50;
            dgvCBC.Columns[colCBCId].Width = 150;
            dgvCBC.Columns[colCBCName].Width = 250;
            dgvCBC.Columns[colCBCWBC].Width = 80;
            dgvCBC.Columns[colCBCRBC].Width = 80;
            dgvCBC.Columns[colCBCHb].Width = 80;
            dgvCBC.Columns[colCBCHct].Width = 80;
            dgvCBC.Columns[colCBCNeu].Width = 80;
            dgvCBC.Columns[colCBCLy].Width = 80;
            dgvCBC.Columns[colCBCMono].Width = 80;
            dgvCBC.Columns[colCBCEo].Width = 80;
            dgvCBC.Columns[colCBCBa].Width = 80;
            dgvCBC.Columns[colCBCPlt_c].Width = 150;
            dgvCBC.Columns[colCBCPlt_s].Width = 150;
            dgvCBC.Columns[colCBCRBC_mo].Width = 150;
            dgvCBC.Columns[colCBCSummary].Width = 200;

            dgvCBC.Columns[colCBCRow].HeaderText = "ลำดับ";
            dgvCBC.Columns[colCBCId].HeaderText = "code";
            dgvCBC.Columns[colCBCName].HeaderText = "ชื่อ นามสกุล";
            dgvCBC.Columns[colCBCWBC].HeaderText = "WBC";
            dgvCBC.Columns[colCBCRBC].HeaderText = "RBC";
            dgvCBC.Columns[colCBCHb].HeaderText = "Hb";
            dgvCBC.Columns[colCBCHct].HeaderText = "Hct";
            dgvCBC.Columns[colCBCNeu].HeaderText = "Neutrophil";
            dgvCBC.Columns[colCBCLy].HeaderText = "Lymphocyte";
            dgvCBC.Columns[colCBCMono].HeaderText = "Mono";
            dgvCBC.Columns[colCBCEo].HeaderText = "Eosinophil";
            dgvCBC.Columns[colCBCBa].HeaderText = "Basophil";
            dgvCBC.Columns[colCBCPlt_c].HeaderText = "Plt.count";
            dgvCBC.Columns[colCBCPlt_s].HeaderText = "Plt.smear";
            dgvCBC.Columns[colCBCRBC_mo].HeaderText = "RBC mor";
            dgvCBC.Columns[colCBCSummary].HeaderText = "สรุปผลตรวจ";

            dgvCBC.Columns[colUAId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvCBC.Font = font;
            dgvCBC.Columns[colCBCId].Visible = false;
        }
        private void setGrdUA()
        {
            dgvUA.ColumnCount = colUACnt;
            dgvUA.Rows.Clear();
            dgvUA.RowCount = 1;
            dgvUA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUA.Columns[colUARow].Width = 50;
            dgvUA.Columns[colUAName].Width = 250;
            dgvUA.Columns[colUColor].Width = 80;
            dgvUA.Columns[colUAAppe].Width = 80;
            dgvUA.Columns[colUASugar].Width = 80;
            dgvUA.Columns[colUASpgr].Width = 80;
            dgvUA.Columns[colUAPh].Width = 80;
            dgvUA.Columns[colUAProtein].Width = 80;
            dgvUA.Columns[colUAWBC].Width = 80;
            dgvUA.Columns[colUARBC].Width = 80;
            dgvUA.Columns[colUAEpi].Width = 80;
            dgvUA.Columns[colUABact].Width = 80;
            dgvUA.Columns[colUAResult].Width = 80;
            dgvUA.Columns[colUASummary].Width = 80;
            //dgvUA.Columns[colUASummary].Width = 180;

            dgvUA.Columns[colUARow].HeaderText = "ลำดับ";
            dgvUA.Columns[colUAName].HeaderText = "ชื่อ นามสกุล";
            dgvUA.Columns[colUColor].HeaderText = "Color";
            dgvUA.Columns[colUAAppe].HeaderText = "Appe";
            dgvUA.Columns[colUASugar].HeaderText = "Sugar";
            dgvUA.Columns[colUASpgr].HeaderText = "SpGr";
            dgvUA.Columns[colUAPh].HeaderText = "pH";
            dgvUA.Columns[colUAProtein].HeaderText = "Protein";
            dgvUA.Columns[colUAWBC].HeaderText = "WBC";
            dgvUA.Columns[colUARBC].HeaderText = "RBC";
            dgvUA.Columns[colUAEpi].HeaderText = "Epi";
            dgvUA.Columns[colUABact].HeaderText = "Bact";
            dgvUA.Columns[colUAResult].HeaderText = "ผล";
            dgvUA.Columns[colUASummary].HeaderText = "สรุปผลตรวจ";
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
            dgvTri.Columns[colTriName].Width = 250;
            dgvTri.Columns[colTriValue].Width = 80;
            dgvTri.Columns[colTriResult].Width = 180;
            dgvTri.Columns[coLTriSummary].Width = 180;

            dgvTri.Columns[colTriRow].HeaderText = "ลำดับ";
            dgvTri.Columns[colTriId].HeaderText = "code";
            dgvTri.Columns[colTriName].HeaderText = "ชื่อ นามสกุล";
            dgvTri.Columns[colTriValue].HeaderText = "ค่า";
            dgvTri.Columns[colTriResult].HeaderText = "ผล";
            dgvTri.Columns[coLTriSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvTri.Font = font;
            dgvTri.Columns[colTriId].Visible = false;
        }
        private void setGrdCho()
        {
            dgvCho.ColumnCount = colChoCnt;
            dgvCho.Rows.Clear();
            dgvCho.RowCount = 1;
            dgvCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCho.Columns[colChoRow].Width = 50;
            dgvCho.Columns[colChoId].Width = 150;
            dgvCho.Columns[colChoName].Width =250;
            dgvCho.Columns[colChoValue].Width = 80;
            dgvCho.Columns[colChoResult].Width = 180;
            dgvCho.Columns[coLChoSummary].Width = 180;

            dgvCho.Columns[colChoRow].HeaderText = "ลำดับ";
            dgvCho.Columns[colChoId].HeaderText = "code";
            dgvCho.Columns[colChoName].HeaderText = "ชื่อ นามสกุล";
            dgvCho.Columns[colChoValue].HeaderText = "ค่า";
            dgvCho.Columns[colChoResult].HeaderText = "ผล";
            dgvCho.Columns[coLChoSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvCho.Font = font;
            dgvCho.Columns[colChoId].Visible = false;
        }
        private void setGrdSgot()
        {
            dgvSgot.ColumnCount = colSgotCnt;
            dgvSgot.Rows.Clear();
            dgvSgot.RowCount = 1;
            dgvSgot.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSgot.Columns[colSgotRow].Width = 50;
            dgvSgot.Columns[colSgotId].Width = 150;
            dgvSgot.Columns[colSgotName].Width = 250;
            dgvSgot.Columns[colSgotValue].Width = 80;
            dgvSgot.Columns[colSgotSgptValue].Width = 80;
            dgvSgot.Columns[colSgotResult].Width = 180;
            dgvSgot.Columns[coLSgotSummary].Width = 180;

            dgvSgot.Columns[colSgotRow].HeaderText = "ลำดับ";
            dgvSgot.Columns[colSgotId].HeaderText = "code";
            dgvSgot.Columns[colSgotName].HeaderText = "ชื่อ นามสกุล";
            dgvSgot.Columns[colSgotValue].HeaderText = "SGOT";
            dgvSgot.Columns[colSgotSgptValue].HeaderText = "SGPT";
            dgvSgot.Columns[colSgotResult].HeaderText = "ผล";
            dgvSgot.Columns[coLSgotSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvSgot.Font = font;
            dgvSgot.Columns[colSgotId].Visible = false;
        }
        private void setGrdBun()
        {
            dgvBun.ColumnCount = colBunCnt;
            dgvBun.Rows.Clear();
            dgvBun.RowCount = 1;
            dgvBun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBun.Columns[colBunRow].Width = 50;
            dgvBun.Columns[colBunId].Width = 150;
            dgvBun.Columns[colBunName].Width = 250;
            dgvBun.Columns[colBunValue].Width = 80;
            dgvBun.Columns[colBunCreatinineValue].Width = 80;
            dgvBun.Columns[colBunResult].Width = 180;
            dgvBun.Columns[coLBunSummary].Width = 180;

            dgvBun.Columns[colBunRow].HeaderText = "ลำดับ";
            dgvBun.Columns[colBunId].HeaderText = "code";
            dgvBun.Columns[colBunName].HeaderText = "ชื่อ นามสกุล";
            dgvBun.Columns[colBunValue].HeaderText = "BUN";
            dgvBun.Columns[colBunCreatinineValue].HeaderText = "Creatinine";
            dgvBun.Columns[colBunResult].HeaderText = "ผล";
            dgvBun.Columns[coLBunSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvBun.Font = font;
            dgvBun.Columns[colBunId].Visible = false;
        }
        private void setGrdUric()
        {
            dgvUric.ColumnCount = colUricCnt;
            dgvUric.Rows.Clear();
            dgvUric.RowCount = 1;
            dgvUric.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUric.Columns[colUricRow].Width = 50;
            dgvUric.Columns[colUricId].Width = 150;
            dgvUric.Columns[colUricName].Width = 250;
            dgvUric.Columns[colUricValue].Width = 80;
            dgvUric.Columns[colUricResult].Width = 180;
            dgvUric.Columns[coLUricSummary].Width = 180;

            dgvUric.Columns[colUricRow].HeaderText = "ลำดับ";
            dgvUric.Columns[colUricId].HeaderText = "code";
            dgvUric.Columns[colUricName].HeaderText = "ชื่อ นามสกุล";
            dgvUric.Columns[colUricValue].HeaderText = "ค่า";
            dgvUric.Columns[colUricResult].HeaderText = "ผล";
            dgvUric.Columns[coLUricSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvUric.Font = font;
            dgvUric.Columns[colUricId].Visible = false;
        }
        private void setControl(String cucId)
        {
            cuc = cc.cucdb.selectByPk(cucId);
            txtDescription.Text = cuc.Description;
            cboCust.Text = cuc.CustNameT;
            txtId.Text = cuc.Id;
        }
        private void setGrdPE(String cucId)
        {
            DataTable dt;
            dgvPE.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }
            
            if (dt.Rows.Count > 0)
            {
                dgvPE.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvPE[colPERow, i].Value = (i + 1);
                    dgvPE[colPEName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvPE[colPESex, i].Value = dt.Rows[i][cc.ccpdb.ccp.fSexId].ToString();
                    dgvPE[colPEAge, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientAge].ToString();
                    dgvPE[colPEWeight, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientWeight].ToString();
                    dgvPE[colPEHeight, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientHeight].ToString();
                    dgvPE[colPEBMI, i].Value = dt.Rows[i][cc.ccpdb.ccp.bmi].ToString();
                    dgvPE[colPEvitalsign, i].Value = dt.Rows[i][cc.ccpdb.ccp.vitalsign].ToString();
                    dgvPE[colPEPulse, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientPulse].ToString();
                    dgvPE[colPEResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungSuggess].ToString();
                    dgvPE[colPESummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungSuggess].ToString();
                    dgvPE[colPEId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvPE.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdXray(String cucId)
        {
            DataTable dt;
            dgvXRay.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvXRay.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvXRay[colXrayRow, i].Value = (i + 1);
                    dgvXRay[colXrayName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvXRay[colXrayResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.xrayChestExam].ToString();
                    dgvXRay[coLXraySummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.xrayChestSummary].ToString();
                    dgvXRay[colXrayId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvXRay.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdFBS(String cucId)
        {
            DataTable dt;
            dgvFBS.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvFBS.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvFBS[colFBSRow, i].Value = (i + 1);
                    dgvFBS[colFBSName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvFBS[colFBSValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.sugar].ToString();
                    dgvFBS[colFBSResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.sugarDiagnosis].ToString();
                    dgvFBS[coLFBSSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.sugarSummary].ToString();
                    dgvFBS[colFBSId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvFBS.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdCBC(String cucId)
        {
            DataTable dt;
            dgvCBC.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvCBC.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCBC[colCBCRow, i].Value = (i + 1);
                    dgvCBC[colCBCName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvCBC[colCBCWBC, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcWbc].ToString();
                    dgvCBC[colCBCRBC, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcRbc].ToString();
                    dgvCBC[colCBCHb, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcHb].ToString();
                    dgvCBC[colCBCHct, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcHct].ToString();
                    dgvCBC[colCBCNeu, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcNeutrophil].ToString();
                    dgvCBC[colCBCLy, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcLymphocyte].ToString();
                    dgvCBC[colCBCMono, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcMonocyte].ToString();
                    dgvCBC[colCBCEo, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcEosinophil].ToString();
                    dgvCBC[colCBCBa, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcBasophil].ToString();
                    dgvCBC[colCBCPlt_c, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcPlateletCount].ToString();
                    dgvCBC[colCBCPlt_s, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcPlateletSmear].ToString();
                    dgvCBC[colCBCRBC_mo, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcRbcMorpholog].ToString();
                    dgvCBC[colCBCSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcSummary].ToString();
                    dgvCBC[colCBCId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvCBC.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdUA(String cucId)
        {
            DataTable dt;
            dgvUA.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvUA.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvUA[colUARow, i].Value = (i + 1);
                    dgvUA[colUAName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvUA[colUColor, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineColor].ToString();
                    dgvUA[colUAAppe, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineAppearance].ToString();
                    dgvUA[colUASugar, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineSugar].ToString();
                    dgvUA[colUASpgr, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineSpGr].ToString();
                    dgvUA[colUAPh, i].Value = dt.Rows[i][cc.ccpdb.ccp.urinePh].ToString();
                    dgvUA[colUAProtein, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineProtein].ToString();
                    dgvUA[colUAWBC, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineWbc].ToString();
                    dgvUA[colUARBC, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineRbc].ToString();
                    dgvUA[colUAEpi, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineEpithelium].ToString();
                    dgvUA[colUABact, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineBacteria].ToString();
                    dgvUA[colUAResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineResult].ToString();
                    dgvUA[colUASummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.urineSummary].ToString();
                    //dgvUA[colCBCSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.cbcSummary].ToString();
                    dgvUA[colUAId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvUA.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdTri(String cucId)
        {
            DataTable dt;
            dgvTri.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvTri.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvTri[colTriRow, i].Value = (i + 1);
                    dgvTri[colTriName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvTri[colTriValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.triglyceride].ToString();
                    dgvTri[colTriResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.triglycerideResult].ToString();
                    dgvTri[coLTriSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.triglycerideSummary].ToString();
                    dgvTri[colTriId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvTri.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdCholes(String cucId)
        {
            DataTable dt;
            dgvCho.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvCho.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvCho[colChoRow, i].Value = (i + 1);
                    dgvCho[colChoName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvCho[colChoValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.cholesterol].ToString();
                    dgvCho[colChoResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.cholesterolSuggess].ToString();
                    dgvCho[coLChoSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.cholesterolSummary].ToString();
                    dgvCho[colChoId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvCho.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdSgot(String cucId)
        {
            DataTable dt;
            dgvSgot.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvSgot.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvSgot[colSgotRow, i].Value = (i + 1);
                    dgvSgot[colSgotName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvSgot[colSgotValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverSgot].ToString();
                    dgvSgot[colSgotSgptValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString();
                    dgvSgot[colSgotResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverResult].ToString();
                    dgvSgot[coLSgotSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverSummary].ToString();
                    dgvSgot[colSgotId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvSgot.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdBun(String cucId)
        {
            DataTable dt;
            dgvBun.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvBun.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvBun[colBunRow, i].Value = (i + 1);
                    dgvBun[colBunName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvBun[colBunValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.kidneyBun].ToString();
                    dgvBun[colBunCreatinineValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.kidneyCreatinine].ToString();
                    dgvBun[colBunResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.kidneyResult].ToString();
                    dgvBun[coLBunSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.kidneySummary].ToString();
                    dgvBun[colBunId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvBun.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdUric(String cucId)
        {
            DataTable dt;
            dgvUric.Rows.Clear();
            if (flagNew)
            {
                dt = cc.ccpdb.selectAllByCucId(cucId);
            }
            else
            {
                dt = dtAll;
            }

            if (dt.Rows.Count > 0)
            {
                dgvUric.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvUric[colUricRow, i].Value = (i + 1);
                    dgvUric[colUricName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvUric[colUricValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.uricAcid].ToString();
                    dgvUric[colUricResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.uricAcidSuggess].ToString();
                    dgvUric[coLUricSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.uricAcidSummary].ToString();
                    dgvUric[colUricId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvUric.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void getCustCheckUp()
        {
            cuc.Active = "1";
            cuc.CheckUpDate = cc.cf.datetoDB(dtpCheckUpDate.Value);
            cuc.CntEmployee = "";
            cuc.Description = txtDescription.Text;
            cuc.YearId = dtpCheckUpDate.Value.Year.ToString();
            cuc.CustId = cc.getValueCboItem(cboCust);
            cuc.CustNameT = cboCust.Text;
            cuc.Id = txtId.Text;
        }
        private String ImportExcel()
        {
            String cucId = "", sexId="";
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
                return "";
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
                return "";
            }

            getCustCheckUp();
            cucId = cc.cucdb.insertCustCheckUp(cuc);
            if (cucId.Length < 1)
            {
                pB1.Visible = false;
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ ", "Error ");
                return "";
            }

            pB1.Maximum = rowCount;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                try
                {
                    CustCheckUpPatient ccp = new CustCheckUpPatient();
                    ccp.CustCheckUpId = cucId;
                    ccp.Active = "1";
                    ccp.Id = "";
                    prefix = "";
                    firstName = "";
                    lastName = "";
                    if (xlRange.Cells[i, 2].Value2 != null)
                    {
                        prefix = xlRange.Cells[i, 2].Value2.ToString();
                    }
                    else
                    {
                        prefix = "";
                    }
                    prefix = prefix.Trim();
                    if (prefix.Equals("นาย"))
                    {
                        sexId = "1";
                    }
                    else if (prefix.Equals("นาย."))
                    {
                        sexId = "1";
                    }
                    else if (prefix.Equals("น.ส."))
                    {
                        sexId = "2";
                    }
                    else if (prefix.Equals("น.ส"))
                    {
                        sexId = "2";
                    }
                    else if (prefix.Equals("นส"))
                    {
                        sexId = "2";
                    }
                    else if (prefix.Equals("นส."))
                    {
                        sexId = "2";
                    }
                    else if (prefix.Equals("นาง"))
                    {
                        sexId = "2";
                    }
                    else
                    {
                        sexId = "3";
                    }
                    ccp.fSexId = sexId;
                    if (xlRange.Cells[i, 3].Value2 != null)
                    {
                        firstName = xlRange.Cells[i, 3].Value2.ToString();
                    }
                    else
                    {
                        firstName = "";
                        continue;
                    }
                    if (xlRange.Cells[i, 4].Value2 != null)
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
                    if (xlRange.Cells[i, 5].Value2 != null)
                    {
                        ccp.patientAge = xlRange.Cells[i, 5].Value2.ToString();
                    }
                    else
                    {

                    }
                    ccp.patientFullname = prefix + " " + firstName + " " + lastName;

                    cc.ccpdb.InsertCustCheckUpPatient1(ccp);
                }
                catch (Exception ex)
                {

                }
                
                pB1.Value = i;
                //for (int j = 1; j <= colCount; j++)
                //{
                //    MessageBox.Show(xlRange.Cells[i, j].Value2.ToString());
                //}

            }
            pB1.Visible = false;
            return cucId;
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
                String cucId = ImportExcel();
                setGrdPE(cucId);
            }
            else
            {

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {            
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

        private void btnPEExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNamePE = ofd.FileName;
            btnPEImport.Enabled = true;
        }

        private void btnXrayExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameXray = ofd.FileName;
            btnXrayImport.Enabled = true;
        }

        private void btnFBSExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameFBS = ofd.FileName;
            btnFBSImport.Enabled = true;
        }

        private void btnCBCExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameCBC = ofd.FileName;
            btnCBCImport.Enabled = true;
        }

        private void btnUAExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameUA = ofd.FileName;
            btnUAImport.Enabled = true;
        }

        private void btnTriExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameTri = ofd.FileName;
            btnTriImport.Enabled = true;
        }

        private void btnChoExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameCho = ofd.FileName;
            btnChoImport.Enabled = true;
        }

        private void btnPEImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk="",vitalSign="", height="", weight="", bmi="", pulse="", result="", summary="";

            pB1.Visible = true;
            pB1.Minimum = 0;
            
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNamePE);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    weight = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    weight = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    height = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    height = "";
                }
                if (xlRange.Cells[i, 8].Value2 != null)
                {
                    bmi = xlRange.Cells[i, 8].Value2.ToString();
                }
                else
                {
                    bmi = "";
                }
                if (xlRange.Cells[i, 9].Value2 != null)
                {
                    vitalSign = xlRange.Cells[i, 9].Value2.ToString();
                }
                else
                {
                    vitalSign = "";
                }
                if (xlRange.Cells[i, 10].Value2 != null)
                {
                    pulse = xlRange.Cells[i, 10].Value2.ToString();
                }
                else
                {
                    pulse = "";
                }
                chk = cc.ccpdb.UpdatePE(rowNumber, txtId.Text, vitalSign, height, weight, bmi, pulse, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdPE(txtId.Text);
        }

        private void btnXrayImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameXray);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    result = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    summary = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateXray(rowNumber, txtId.Text, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdXray(txtId.Text);
        }

        private void btnFBSImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value="";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameFBS);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    value = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    result = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    summary = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateFBS(rowNumber, txtId.Text, value, result, summary, "");
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdFBS(txtId.Text);
        }

        private void btnCBCImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", wbc = "", rbc = "", hb = "", hct="", neu="", lym="", mch="", mchc="", mvc="", mono="", plaC="", rbcmono="";
            String summary = "", eos="", bas="", plaS="";
            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameCBC);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    hb = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    hb = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    wbc = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    wbc = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    rbc = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    rbc = "";
                }
                if (xlRange.Cells[i, 8].Value2 != null)
                {
                    hct = xlRange.Cells[i, 8].Value2.ToString();
                }
                else
                {
                    hct = "";
                }
                if (xlRange.Cells[i, 9].Value2 != null)
                {
                    neu = xlRange.Cells[i, 9].Value2.ToString();
                }
                else
                {
                    neu = "";
                }
                if (xlRange.Cells[i, 10].Value2 != null)
                {
                    lym = xlRange.Cells[i, 10].Value2.ToString();
                }
                else
                {
                    lym = "";
                }
                if (xlRange.Cells[i, 11].Value2 != null)
                {
                    mono = xlRange.Cells[i, 11].Value2.ToString();
                }
                else
                {
                    mono = "";
                }
                if (xlRange.Cells[i, 12].Value2 != null)
                {
                    eos = xlRange.Cells[i, 12].Value2.ToString();
                }
                else
                {
                    eos = "";
                }
                if (xlRange.Cells[i, 13].Value2 != null)
                {
                    bas = xlRange.Cells[i, 13].Value2.ToString();
                }
                else
                {
                    bas = "";
                }
                if (xlRange.Cells[i, 14].Value2 != null)
                {
                    plaC = xlRange.Cells[i, 14].Value2.ToString();
                }
                else
                {
                    plaC = "";
                }
                if (xlRange.Cells[i, 15].Value2 != null)
                {
                    plaS = xlRange.Cells[i, 15].Value2.ToString();
                }
                else
                {
                    plaS = "";
                }
                if (xlRange.Cells[i, 16].Value2 != null)
                {
                    rbcmono = xlRange.Cells[i, 16].Value2.ToString();
                }
                else
                {
                    rbcmono = "";
                }
                if (xlRange.Cells[i, 17].Value2 != null)
                {
                    summary = xlRange.Cells[i, 17].Value2.ToString();
                }
                else
                {
                    summary = "";
                }
                //if (xlRange.Cells[i, 13].Value2 != null)
                //{
                //    bas = xlRange.Cells[i, 13].Value2.ToString();
                //}
                //else
                //{
                //    bas = "";
                //}

                chk = cc.ccpdb.UpdateCBC(rowNumber, txtId.Text, bas, eos, hb, hct, lym, mch, mchc, mvc, mono, neu, plaC, rbc, rbcmono, summary, wbc, plaS);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdCBC(txtId.Text);
        }

        private void btnUAImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", Color = "", Appe = "", Sugar = "", spgr = "", pH = "", Protein = "", Wbc = "", Rbc = "", Epi = "", Bact = "", Result = "", Summary = "";
            //String summary = "", eos = "", bas = "", plaS = "";
            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameUA);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            //xlWorkbook.
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    Sugar = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    Sugar = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    Color = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    Color = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    Appe = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    Appe = "";
                }
                if (xlRange.Cells[i, 8].Value2 != null)
                {
                    spgr = xlRange.Cells[i, 8].Value2.ToString();
                }
                else
                {
                    spgr = "";
                }
                if (xlRange.Cells[i, 9].Value2 != null)
                {
                    pH = xlRange.Cells[i, 9].Value2.ToString();
                }
                else
                {
                    pH = "";
                }
                if (xlRange.Cells[i, 10].Value2 != null)
                {
                    Protein = xlRange.Cells[i, 10].Value2.ToString();
                }
                else
                {
                    Protein = "";
                }
                if (xlRange.Cells[i, 11].Value2 != null)
                {
                    Wbc = xlRange.Cells[i, 11].Value2.ToString();
                }
                else
                {
                    Wbc = "";
                }
                if (xlRange.Cells[i, 12].Value2 != null)
                {
                    Rbc = xlRange.Cells[i, 12].Value2.ToString();
                }
                else
                {
                    Rbc = "";
                }
                if (xlRange.Cells[i, 13].Value2 != null)
                {
                    Epi = xlRange.Cells[i, 13].Value2.ToString();
                }
                else
                {
                    Epi = "";
                }
                if (xlRange.Cells[i, 14].Value2 != null)
                {
                    Bact = xlRange.Cells[i, 14].Value2.ToString();
                }
                else
                {
                    Bact = "";
                }
                if (xlRange.Cells[i, 15].Value2 != null)
                {
                    Result = xlRange.Cells[i, 15].Value2.ToString();
                }
                else
                {
                    Result = "";
                }
                if (xlRange.Cells[i, 16].Value2 != null)
                {
                    Summary = xlRange.Cells[i, 16].Value2.ToString();
                }
                else
                {
                    Summary = "";
                }
                //if (xlRange.Cells[i, 17].Value2 != null)
                //{
                //    summary = xlRange.Cells[i, 17].Value2.ToString();
                //}
                //else
                //{
                //    summary = "";
                //}
                //if (xlRange.Cells[i, 13].Value2 != null)
                //{
                //    bas = xlRange.Cells[i, 13].Value2.ToString();
                //}
                //else
                //{
                //    bas = "";
                //}

                chk = cc.ccpdb.UpdateUA(rowNumber, txtId.Text, Color, Appe, Sugar, spgr, pH, Protein, Wbc, Rbc, Epi, Bact, Result, Summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdUA(txtId.Text);
        }

        private void btnTriImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value = "";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameTri);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    value = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    result = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    summary = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateTrigly(rowNumber, txtId.Text, value, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdTri(txtId.Text);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnChoImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value = "";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameCho);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    value = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    result = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    summary = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateCholes(rowNumber, txtId.Text, value, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdCholes(txtId.Text);
        }

        private void btnSgotExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameSgot = ofd.FileName;
            btnSgotImport.Enabled = true;
        }

        private void btnBunExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameBun = ofd.FileName;
            btnBunImport.Enabled = true;
        }

        private void btnUricExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameUric = ofd.FileName;
            btnUricImport.Enabled = true;
        }

        private void btnSgotImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", sgot = "", sgpt="";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameSgot);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    sgot = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    sgot = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    sgpt = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    sgpt = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    result = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 8].Value2 != null)
                {
                    summary = xlRange.Cells[i, 8].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateSgot(rowNumber, txtId.Text, sgot, sgpt, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdSgot(txtId.Text);
        }

        private void btnBunImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", bun = "", creatinine = "";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameBun);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    bun = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    bun = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    creatinine = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    creatinine = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    result = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 8].Value2 != null)
                {
                    summary = xlRange.Cells[i, 8].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateBun(rowNumber, txtId.Text, bun, creatinine, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdBun(txtId.Text);
        }

        private void btnUricImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value = "";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameUric);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, 1].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, 1].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, 5].Value2 != null)
                {
                    value = xlRange.Cells[i, 5].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, 6].Value2 != null)
                {
                    result = xlRange.Cells[i, 6].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, 7].Value2 != null)
                {
                    summary = xlRange.Cells[i, 7].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateUric(rowNumber, txtId.Text, value, result, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdUric(txtId.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmExcelInit frm = new FrmExcelInit(cc);
            frm.ShowDialog(this);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            cc.rcdb.deleteAll();
            dtAll = cc.ccpdb.selectAllByCucId(cuc.Id);
            for (int i = 0; i < dtAll.Rows.Count; i++)
            {
                RCheckUp rc = new RCheckUp();
                rc.Id = "";
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Hb";
                rc.LabNormal = "12-16 gm%";
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcHb].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                cc.rcdb.insertRCheckUp(rc);

            }
        }
    }
}
