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

        int tabSum = 0, tabPrint=1, tabPE=2, tabXRay=3, tabCBC=4, tabFBS=5, tabUA=6,tabTri=7, tabCho=8, tabSgot=9, tabBun=10, tabUric=11, tabOther1=12, tabLung=13, tabAudio=14, tabEye=15;
        int tabCnt = 16;

        int colPERow = 0, colPEId = 1, colPEName = 2, colPESex=3, colPEAge = 4, colPEWeight = 5, colPEHeight = 6, colPEBMI = 7, colPEvitalsign = 8, colPEPulse = 9, colPEBloodGroup=10, colPEResult = 11, colPESummary = 12;
        int colPECnt = 13;

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

        int colChoRow = 0, colChoId = 1, colChoName = 2, colChoValue = 3, colChoLDL=4, colChoHDL=5, colChoResult = 6, coLChoSummary = 7;
        int colChoCnt = 8;

        int colSgotRow = 0, colSgotId = 1, colSgotName = 2, colSgotValue = 3, colSgotSgptValue = 4, colSgotResult=5, coLSgotSummary = 6;
        int colSgotCnt = 7;

        int colBunRow = 0, colBunId = 1, colBunName = 2, colBunValue = 3, colBunCreatinineValue = 4, colBunResult = 5, coLBunSummary = 6;
        int colBunCnt = 7;

        int colUricRow = 0, colUricId = 1, colUricName = 2, colUricValue = 3, colUricResult = 4, coLUricSummary = 5;
        int colUricCnt = 6;

        int colOther1Row = 0, colOther1Id = 1, colOther1Name = 2, colOther1HBsAg = 3, colOther1HBsAb = 4, colOther1AntiHIV = 5, colOther1VDRL = 6, colOther1Amphetamine = 7, colOther1Calcium = 8;
        int colOther1Cnt = 9;

        int colLungRow = 0, colLungId = 1, colLungName = 2, colLungFvcPredic = 3, colLungFvcMeas = 4, colLungFvcPer = 5, colLungFev1Predic = 6, colLungFev1Meas = 7, colLungFev1Per = 8, colLungPerFev1 = 9, colLungSummary = 10;
        int colLungCnt = 11;

        int colAudiogramRow = 0, colAudiogramId = 1, colAudiogramName = 2, colAudiogram500L = 3, colAudiogram1000L = 4, colAudiogram2000L = 5, colAudiogram3000L = 6, colAudiogram4000L = 7;
        int colAudiogram6000L = 8, colAudiogram8000L = 9, colAudiogramSummaryL = 10;
        int colAudiogram500R = 11, colAudiogram1000R = 12, colAudiogram2000R = 13, colAudiogram3000R = 14, colAudiogram4000R = 15;
        int colAudiogram6000R = 16, colAudiogram8000R = 17, colAudiogramSummaryR = 18, colAudiogramSummary = 19;
        int colAudiogramCnt = 20;

        int colEyeRow = 0, colEyeId = 1, colEyeName = 2, colEyeShortLongLeft = 3, colEyeShortLongRight = 4, colEyeSquintLeft = 5, colEyeSquintRight = 6, colEyeDegreeLeft = 7, colEyeDegreeRight = 8, colEyeOldLeft = 9, colEyeOldRight = 10, colEyeBlindness = 10, colEyeResult = 11, colEyeSummary = 12;
        int colEyeCnt = 13;

        Font font = new Font("Microsoft Sans Serif", 12);
        Boolean flagNew=false;
        String fileName = "", fileNamePE = "", fileNameFBS = "", fileNameXray = "", fileNameCBC = "", fileNameUA = "", fileNameTri = "", fileNameCho = "", fileNameLung="";
        String fileNameSgot = "", fileNameBun = "", fileNameUric = "", fileNameOther1 = "", fileNameAudio="", fileNameEye="";
        //String cucId = "";
        DataTable dtAll;
        OpenFileDialog ofd = new OpenFileDialog();
        object misValue = System.Reflection.Missing.Value;
        ExcelInit ei;
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
            ei = cc.eidb.selectByPk();
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
            tC.TabPages[tabPrint].Text = "Print";
            tC.TabPages[tabOther1].Text = "Other1";
            tC.TabPages[tabLung].Text = "Lung";
            tC.TabPages[tabAudio].Text = "Audio";
            tC.TabPages[tabEye].Text = "Eye";

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
            btnOtherImport.Enabled = false;
            btnLungImport.Enabled = false;
            btnAudioImport.Enabled = false;
            btnEyeImport.Enabled = false;

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
            nmDPrintEnd.Maximum = dtAll.Rows.Count;
            nmDPrintEnd.Minimum = 1;
            nmDPrintFirst.Maximum = dtAll.Rows.Count;
            nmDPrintFirst.Minimum = 1;

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
            setGrdOther1();
            setGrdLung();
            setGrdAudio();

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
            setGrdOther1(cucId);
            setGrdLung(cucId);
            setGrdAudoigram(cucId);
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

            tC.TabPages[tabSgot].Width = tC.Width - 10;
            tC.TabPages[tabSgot].Height = tC.Height - 10;
            dgvSgot.Width = tC.TabPages[tabSgot].Width - 10;
            dgvSgot.Height = tC.TabPages[tabSgot].Height - 10;
            dgvSgot.Left = dgvPE.Left;
            dgvSgot.Top = dgvPE.Left;

            tC.TabPages[tabBun].Width = tC.Width - 10;
            tC.TabPages[tabBun].Height = tC.Height - 10;
            dgvBun.Width = tC.TabPages[tabBun].Width - 10;
            dgvBun.Height = tC.TabPages[tabBun].Height - 10;
            dgvBun.Left = dgvPE.Left;
            dgvBun.Top = dgvPE.Left;

            tC.TabPages[tabUric].Width = tC.Width - 10;
            tC.TabPages[tabUric].Height = tC.Height - 10;
            dgvUric.Width = tC.TabPages[tabUric].Width - 10;
            dgvUric.Height = tC.TabPages[tabUric].Height - 10;
            dgvUric.Left = dgvPE.Left;
            dgvUric.Top = dgvPE.Left;

            tC.TabPages[tabOther1].Width = tC.Width - 10;
            tC.TabPages[tabOther1].Height = tC.Height - 10;
            dgvOther1.Width = tC.TabPages[tabOther1].Width - 10;
            dgvOther1.Height = tC.TabPages[tabOther1].Height - 10;
            dgvOther1.Left = dgvPE.Left;
            dgvOther1.Top = dgvPE.Left;

            tC.TabPages[tabLung].Width = tC.Width - 10;
            tC.TabPages[tabLung].Height = tC.Height - 10;
            dgvLung.Width = tC.TabPages[tabLung].Width - 10;
            dgvLung.Height = tC.TabPages[tabLung].Height - 10;
            dgvLung.Left = dgvPE.Left;
            dgvLung.Top = dgvPE.Left;

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
            dgvPE.Columns[colPEBloodGroup].HeaderText = "กรุ๊ปมเลือด";
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

            dgvXRay.Columns[colXrayRow].HeaderText = "ลำดับ";
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
            dgvCho.Columns[colChoHDL].Width = 80;
            dgvCho.Columns[colChoLDL].Width = 80;
            dgvCho.Columns[colChoResult].Width = 180;
            dgvCho.Columns[coLChoSummary].Width = 180;

            dgvCho.Columns[colChoRow].HeaderText = "ลำดับ";
            dgvCho.Columns[colChoId].HeaderText = "code";
            dgvCho.Columns[colChoName].HeaderText = "ชื่อ นามสกุล";
            dgvCho.Columns[colChoValue].HeaderText = "ค่า";
            dgvCho.Columns[colChoLDL].HeaderText = "LDL";
            dgvCho.Columns[colChoHDL].HeaderText = "HDL";
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
        private void setGrdOther1()
        {
            dgvOther1.ColumnCount = colOther1Cnt;
            dgvOther1.Rows.Clear();
            dgvOther1.RowCount = 1;
            dgvOther1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOther1.Columns[colOther1Row].Width = 50;
            dgvOther1.Columns[colOther1Name].Width = 250;
            dgvOther1.Columns[colOther1HBsAg].Width = 100;
            dgvOther1.Columns[colOther1HBsAb].Width = 100;
            dgvOther1.Columns[colOther1AntiHIV].Width = 100;
            dgvOther1.Columns[colOther1VDRL].Width = 100;
            dgvOther1.Columns[colOther1Amphetamine].Width = 100;
            dgvOther1.Columns[colOther1Calcium].Width = 100;

            dgvOther1.Columns[colOther1Row].HeaderText = "ลำดับ";
            dgvOther1.Columns[colOther1Id].HeaderText = "id";
            dgvOther1.Columns[colOther1Name].HeaderText = "ชื่อ นามสกุล";
            dgvOther1.Columns[colOther1HBsAg].HeaderText = "HBsAg";
            dgvOther1.Columns[colOther1HBsAb].HeaderText = "HbsAb";
            dgvOther1.Columns[colOther1AntiHIV].HeaderText = "AntiHIV";
            dgvOther1.Columns[colOther1VDRL].HeaderText = "VDRL";
            dgvOther1.Columns[colOther1Amphetamine].HeaderText = "Amphetamine";
            dgvOther1.Columns[colOther1Calcium].HeaderText = "Calcium";
            //dgvOther1.Columns[colOther1AntiHIV].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvOther1.Font = font;
            dgvOther1.Columns[colOther1Id].Visible = false;
        }
        private void setGrdLung()
        {
            dgvLung.ColumnCount = colLungCnt;
            dgvLung.Rows.Clear();
            dgvLung.RowCount = 1;
            dgvLung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLung.Columns[colLungRow].Width = 50;
            dgvLung.Columns[colLungName].Width = 250;
            dgvLung.Columns[colLungFvcPredic].Width = 100;
            dgvLung.Columns[colLungFvcMeas].Width = 100;
            dgvLung.Columns[colLungFvcPer].Width = 100;
            dgvLung.Columns[colLungFev1Predic].Width = 100;
            dgvLung.Columns[colLungFev1Meas].Width = 100;
            dgvLung.Columns[colLungFev1Per].Width = 100;
            dgvLung.Columns[colLungPerFev1].Width = 100;
            dgvLung.Columns[colLungSummary].Width = 100;

            dgvLung.Columns[colLungRow].HeaderText = "ลำดับ";
            dgvLung.Columns[colLungId].HeaderText = "id";
            dgvLung.Columns[colLungName].HeaderText = "ชื่อ นามสกุล";
            dgvLung.Columns[colLungFvcPredic].HeaderText = "Fvc Predic";
            dgvLung.Columns[colLungFvcMeas].HeaderText = "Fvc Meas";
            dgvLung.Columns[colLungFvcPer].HeaderText = "Fvc Per";
            dgvLung.Columns[colLungFev1Predic].HeaderText = "Fev1 Predic";
            dgvLung.Columns[colLungFev1Meas].HeaderText = "Fev1 Meas";
            dgvLung.Columns[colLungPerFev1].HeaderText = "Per Fev1";
            dgvLung.Columns[colLungFev1Per].HeaderText = "สรุปผลตรวจ";
            dgvLung.Columns[colLungSummary].HeaderText = "สรุปผลตรวจ";

            //dgvSum.Columns[colPEId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvLung.Font = font;
            dgvLung.Columns[colLungId].Visible = false;
        }
        private void setGrdAudio()
        {
            dgvAudio.ColumnCount = colAudiogramCnt;
            dgvAudio.Rows.Clear();
            dgvAudio.RowCount = 1;
            dgvAudio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAudio.Columns[colAudiogramRow].Width = 50;
            dgvAudio.Columns[colAudiogramName].Width = 250;
            dgvAudio.Columns[colAudiogram500L].Width = 80;
            dgvAudio.Columns[colAudiogram1000L].Width = 80;
            dgvAudio.Columns[colAudiogram2000L].Width = 80;
            dgvAudio.Columns[colAudiogram3000L].Width = 80;
            dgvAudio.Columns[colAudiogram4000L].Width = 80;
            dgvAudio.Columns[colAudiogram6000L].Width = 80;
            dgvAudio.Columns[colAudiogram8000L].Width = 80;
            dgvAudio.Columns[colAudiogramSummaryL].Width = 80;
            dgvAudio.Columns[colAudiogram500R].Width = 80;
            dgvAudio.Columns[colAudiogram1000R].Width = 80;
            dgvAudio.Columns[colAudiogram2000R].Width = 80;
            dgvAudio.Columns[colAudiogram3000R].Width = 80;
            dgvAudio.Columns[colAudiogram4000R].Width = 80;
            dgvAudio.Columns[colAudiogram6000R].Width = 80;
            dgvAudio.Columns[colAudiogram8000R].Width = 80;
            dgvAudio.Columns[colAudiogramSummaryR].Width = 80;
            dgvAudio.Columns[colAudiogramSummary].Width = 80;

            dgvAudio.Columns[colAudiogramRow].HeaderText = "ลำดับ";
            dgvAudio.Columns[colAudiogramName].HeaderText = "ชื่อ นามสกุล";
            dgvAudio.Columns[colAudiogram500L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram1000L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram2000L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram3000L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram4000L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram6000L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram8000L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogramSummaryL].HeaderText = "Left ";

            dgvAudio.Columns[colAudiogram500R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram1000R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram2000R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram3000R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram4000R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram6000R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram8000R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogramSummaryR].HeaderText = "Right";

            dgvAudio.Columns[colAudiogramSummary].HeaderText = "Summary";
            dgvAudio.Columns[colAudiogramId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvAudio.Font = font;
            dgvAudio.Columns[colAudiogramId].Visible = false;
        }
        private void setGrdEye()
        {
            dgvEye.ColumnCount = colAudiogramCnt;
            dgvEye.Rows.Clear();
            dgvEye.RowCount = 1;
            dgvEye.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEye.Columns[colEyeRow].Width = 50;
            dgvEye.Columns[colEyeName].Width = 250;
            dgvEye.Columns[colEyeShortLongLeft].Width = 80;
            dgvEye.Columns[colEyeShortLongRight].Width = 80;
            dgvEye.Columns[colEyeSquintLeft].Width = 80;
            dgvEye.Columns[colEyeSquintRight].Width = 80;
            dgvEye.Columns[colEyeDegreeLeft].Width = 80;
            dgvEye.Columns[colEyeDegreeRight].Width = 80;
            dgvEye.Columns[colEyeOldLeft].Width = 80;
            dgvEye.Columns[colEyeOldRight].Width = 80;
            dgvEye.Columns[colEyeBlindness].Width = 80;
            dgvEye.Columns[colEyeResult].Width = 80;
            dgvEye.Columns[colEyeSummary].Width = 80;
            //dgvEye.Columns[colAudiogram3000R].Width = 80;
            //dgvEye.Columns[colAudiogram4000R].Width = 80;
            //dgvEye.Columns[colAudiogram6000R].Width = 80;
            //dgvEye.Columns[colAudiogram8000R].Width = 80;
            //dgvEye.Columns[colAudiogramSummaryR].Width = 80;
            //dgvEye.Columns[colAudiogramSummary].Width = 80;

            dgvEye.Columns[colEyeRow].HeaderText = "ลำดับ";
            dgvEye.Columns[colEyeName].HeaderText = "ชื่อ นามสกุล";
            dgvEye.Columns[colEyeShortLongLeft].HeaderText = "สายตาสั้น / ยาว";
            dgvEye.Columns[colEyeShortLongRight].HeaderText = "สายตาสั้น / ยาว";
            dgvEye.Columns[colEyeSquintLeft].HeaderText = "สายตาเอียง";
            dgvEye.Columns[colEyeSquintRight].HeaderText = "สายตาเอียง";
            dgvEye.Columns[colEyeDegreeLeft].HeaderText = "องศา";
            dgvEye.Columns[colEyeDegreeRight].HeaderText = "องศา";
            dgvEye.Columns[colEyeOldLeft].HeaderText = "สายตายาว(มีอายุ)";
            dgvEye.Columns[colEyeOldRight].HeaderText = "สายตายาว(มีอายุ) ";

            dgvEye.Columns[colEyeBlindness].HeaderText = "Right 500";
            dgvEye.Columns[colEyeResult].HeaderText = "Right 500";
            dgvEye.Columns[colEyeSummary].HeaderText = "Summary";

            dgvEye.Columns[colEyeId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvEye.Font = font;
            dgvEye.Columns[colEyeId].Visible = false;
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
                    dgvPE[colPEBloodGroup, i].Value = dt.Rows[i][cc.ccpdb.ccp.BloodGroup].ToString();
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
                    dgvCho[colChoLDL, i].Value = dt.Rows[i][cc.ccpdb.ccp.ldl].ToString();
                    dgvCho[colChoHDL, i].Value = dt.Rows[i][cc.ccpdb.ccp.hdl].ToString();
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
        private void setGrdOther1(String cucId)
        {
            DataTable dt;
            dgvOther1.Rows.Clear();
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
                dgvOther1.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvOther1[colOther1Row, i].Value = (i + 1);
                    dgvOther1[colOther1Name, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvOther1[colOther1Amphetamine, i].Value = dt.Rows[i][cc.ccpdb.ccp.amphetamine].ToString();
                    dgvOther1[colOther1AntiHIV, i].Value = dt.Rows[i][cc.ccpdb.ccp.antiHiv].ToString();
                    dgvOther1[colOther1Calcium, i].Value = dt.Rows[i][cc.ccpdb.ccp.antiHiv].ToString();
                    dgvOther1[colOther1HBsAb, i].Value = dt.Rows[i][cc.ccpdb.ccp.hbsag].ToString();
                    dgvOther1[colOther1HBsAg, i].Value = dt.Rows[i][cc.ccpdb.ccp.hbsab].ToString();
                    dgvOther1[colOther1VDRL, i].Value = dt.Rows[i][cc.ccpdb.ccp.vdrl].ToString();
                    dgvOther1[colOther1Id, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvOther1.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdLung(String cucId)
        {
            DataTable dt;
            dgvLung.Rows.Clear();
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
                dgvLung.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvLung[colLungRow, i].Value = (i + 1);
                    dgvLung[colLungName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvLung[colLungFvcPredic, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungFvcPredic].ToString();
                    dgvLung[colLungFvcMeas, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungFvcMeas].ToString();
                    dgvLung[colLungFvcPer, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungFvcPer].ToString();
                    dgvLung[colLungFev1Predic, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungFev1Predic].ToString();
                    dgvLung[colLungFev1Meas, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungFev1Meas].ToString();
                    dgvLung[colLungPerFev1, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungPerFev1].ToString();
                    dgvLung[colLungFev1Per, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungFev1Per].ToString();
                    dgvLung[colLungSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.lungSummary].ToString();
                    dgvLung[colLungId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvLung.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdAudoigram(String cucId)
        {
            DataTable dt;
            dgvAudio.Rows.Clear();
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
                dgvAudio.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAudio[colAudiogramRow, i].Value = (i + 1);
                    dgvAudio[colAudiogramName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvAudio[colAudiogram500L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram500L].ToString();
                    dgvAudio[colAudiogram1000L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram1000L].ToString();
                    dgvAudio[colAudiogram2000L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram2000L].ToString();
                    dgvAudio[colAudiogram3000L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram3000L].ToString();
                    dgvAudio[colAudiogram4000L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram4000L].ToString();
                    dgvAudio[colAudiogram6000L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram6000L].ToString();
                    dgvAudio[colAudiogram8000L, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram8000L].ToString();
                    dgvAudio[colAudiogramSummaryL, i].Value = dt.Rows[i][cc.ccpdb.ccp.AudiogramSummaryL].ToString();
                    dgvAudio[colAudiogram500R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram500R].ToString();
                    dgvAudio[colAudiogram1000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram1000R].ToString();
                    dgvAudio[colAudiogram2000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram2000R].ToString();
                    dgvAudio[colAudiogram3000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram3000R].ToString();
                    dgvAudio[colAudiogram4000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram4000R].ToString();
                    dgvAudio[colAudiogram6000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram6000R].ToString();
                    dgvAudio[colAudiogram8000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram8000R].ToString();
                    dgvAudio[colAudiogramSummaryR, i].Value = dt.Rows[i][cc.ccpdb.ccp.AudiogramSummaryR].ToString();
                    dgvAudio[colAudiogramSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvAudio.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdEye(String cucId)
        {
            DataTable dt;
            dgvAudio.Rows.Clear();
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
                dgvEye.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvEye[colEyeRow, i].Value = (i + 1);
                    dgvEye[colEyeName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvEye[colEyeShortLongLeft, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeShortLongLeft].ToString();
                    dgvEye[colEyeShortLongRight, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeShortLongRight].ToString();
                    dgvEye[colEyeSquintLeft, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeSquintLeft].ToString();
                    dgvEye[colEyeSquintRight, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeSquintRight].ToString();
                    dgvEye[colEyeDegreeLeft, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeDegreeLeft].ToString();
                    dgvEye[colEyeDegreeRight, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeDegreeRight].ToString();
                    dgvEye[colEyeOldLeft, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeOldLeft].ToString();
                    dgvEye[colEyeOldRight, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeOldRight].ToString();
                    dgvEye[colEyeBlindness, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeBlindness].ToString();
                    dgvEye[colEyeResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeResult].ToString();
                    dgvEye[colEyeSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeSummary].ToString();
                    //dgvEye[colAudiogram3000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram3000R].ToString();
                    //dgvEye[colAudiogram4000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram4000R].ToString();
                    //dgvEye[colAudiogram6000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram6000R].ToString();
                    //dgvEye[colAudiogram8000R, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram8000R].ToString();
                    //dgvEye[colAudiogramSummaryR, i].Value = dt.Rows[i][cc.ccpdb.ccp.AudiogramSummaryR].ToString();
                    //dgvEye[colAudiogramSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvEye.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
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
            String rowNumber = "", chk="",vitalSign="", height="", weight="", bmi="", pulse="", result="", summary="", bloodgroup="";

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
                if (xlRange.Cells[i, ei.PENo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.PENo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.PEWeight].Value2 != null)
                {
                    weight = xlRange.Cells[i, ei.PEWeight].Value2.ToString();
                }
                else
                {
                    weight = "";
                }
                if (xlRange.Cells[i, ei.PEHeight].Value2 != null)
                {
                    height = xlRange.Cells[i, ei.PEHeight].Value2.ToString();
                }
                else
                {
                    height = "";
                }
                if (xlRange.Cells[i, ei.PEBMI].Value2 != null)
                {
                    bmi = xlRange.Cells[i, ei.PEBMI].Value2.ToString();
                }
                else
                {
                    bmi = "";
                }
                if (xlRange.Cells[i, ei.PEVitalSign].Value2 != null)
                {
                    vitalSign = xlRange.Cells[i, ei.PEVitalSign].Value2.ToString();
                }
                else
                {
                    vitalSign = "";
                }
                if (xlRange.Cells[i, ei.PEPulse].Value2 != null)
                {
                    pulse = xlRange.Cells[i, ei.PEPulse].Value2.ToString();
                }
                else
                {
                    pulse = "";
                }
                if (xlRange.Cells[i, ei.PEBloodGroup].Value2 != null)
                {
                    bloodgroup = xlRange.Cells[i, cc.eidb.ei.PEBloodGroup].Value2.ToString();
                }
                else
                {
                    bloodgroup = "";
                }
                chk = cc.ccpdb.UpdatePE(rowNumber, txtId.Text, vitalSign, height, weight, bmi, pulse, result, summary, bloodgroup);
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
                if (xlRange.Cells[i, ei.XrayNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.XrayNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.Xray].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.Xray].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.XraySummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.XraySummary].Value2.ToString();
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
                if (xlRange.Cells[i, ei.FBSNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.FBSNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.FBS].Value2 != null)
                {
                    value = xlRange.Cells[i, ei.FBS].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, ei.FBSResult].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.FBSResult].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.FBSSummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.FBSSummary].Value2.ToString();
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
                if (xlRange.Cells[i, ei.CBCNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.CBCNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.CBCHb].Value2 != null)
                {
                    hb = xlRange.Cells[i, ei.CBCHb].Value2.ToString();
                }
                else
                {
                    hb = "";
                }
                if (xlRange.Cells[i, ei.CBCWBC].Value2 != null)
                {
                    wbc = xlRange.Cells[i, ei.CBCWBC].Value2.ToString();
                }
                else
                {
                    wbc = "";
                }
                if (xlRange.Cells[i, ei.CBCRBC].Value2 != null)
                {
                    rbc = xlRange.Cells[i, ei.CBCRBC].Value2.ToString();
                }
                else
                {
                    rbc = "";
                }
                if (xlRange.Cells[i, ei.CBCHct].Value2 != null)
                {
                    hct = xlRange.Cells[i, ei.CBCHct].Value2.ToString();
                }
                else
                {
                    hct = "";
                }
                if (xlRange.Cells[i, ei.CBCNeu].Value2 != null)
                {
                    neu = xlRange.Cells[i, ei.CBCNeu].Value2.ToString();
                }
                else
                {
                    neu = "";
                }
                if (xlRange.Cells[i, ei.CBCLy].Value2 != null)
                {
                    lym = xlRange.Cells[i, ei.CBCLy].Value2.ToString();
                }
                else
                {
                    lym = "";
                }
                if (xlRange.Cells[i, ei.CBCMono].Value2 != null)
                {
                    mono = xlRange.Cells[i, ei.CBCMono].Value2.ToString();
                }
                else
                {
                    mono = "";
                }
                if (xlRange.Cells[i, ei.CBCEos].Value2 != null)
                {
                    eos = xlRange.Cells[i, ei.CBCEos].Value2.ToString();
                }
                else
                {
                    eos = "";
                }
                if (xlRange.Cells[i, ei.CBCBact].Value2 != null)
                {
                    bas = xlRange.Cells[i, ei.CBCBact].Value2.ToString();
                }
                else
                {
                    bas = "";
                }
                if (xlRange.Cells[i, ei.CBCPltC].Value2 != null)
                {
                    plaC = xlRange.Cells[i, ei.CBCPltC].Value2.ToString();
                }
                else
                {
                    plaC = "";
                }
                if (xlRange.Cells[i, ei.CBCPltS].Value2 != null)
                {
                    plaS = xlRange.Cells[i, ei.CBCPltS].Value2.ToString();
                }
                else
                {
                    plaS = "";
                }
                if (xlRange.Cells[i, ei.CBCRBCmono].Value2 != null)
                {
                    rbcmono = xlRange.Cells[i, ei.CBCRBCmono].Value2.ToString();
                }
                else
                {
                    rbcmono = "";
                }
                if (xlRange.Cells[i, ei.CBCSummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.CBCSummary].Value2.ToString();
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
                if (xlRange.Cells[i, ei.UANo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.UANo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.UASugar].Value2 != null)
                {
                    Sugar = xlRange.Cells[i, ei.UASugar].Value2.ToString();
                }
                else
                {
                    Sugar = "";
                }
                if (xlRange.Cells[i, ei.UAColor].Value2 != null)
                {
                    Color = xlRange.Cells[i, ei.UAColor].Value2.ToString();
                }
                else
                {
                    Color = "";
                }
                if (xlRange.Cells[i, ei.UAAppe].Value2 != null)
                {
                    Appe = xlRange.Cells[i, ei.UAAppe].Value2.ToString();
                }
                else
                {
                    Appe = "";
                }
                if (xlRange.Cells[i, ei.UASpgr].Value2 != null)
                {
                    spgr = xlRange.Cells[i, ei.UASpgr].Value2.ToString();
                }
                else
                {
                    spgr = "";
                }
                if (xlRange.Cells[i, ei.UApH].Value2 != null)
                {
                    pH = xlRange.Cells[i, ei.UApH].Value2.ToString();
                }
                else
                {
                    pH = "";
                }
                if (xlRange.Cells[i, ei.UAProtein].Value2 != null)
                {
                    Protein = xlRange.Cells[i, ei.UAProtein].Value2.ToString();
                }
                else
                {
                    Protein = "";
                }
                if (xlRange.Cells[i, ei.UAWBC].Value2 != null)
                {
                    Wbc = xlRange.Cells[i, ei.UAWBC].Value2.ToString();
                }
                else
                {
                    Wbc = "";
                }
                if (xlRange.Cells[i, ei.UARBC].Value2 != null)
                {
                    Rbc = xlRange.Cells[i, ei.UARBC].Value2.ToString();
                }
                else
                {
                    Rbc = "";
                }
                if (xlRange.Cells[i, ei.UAEpi].Value2 != null)
                {
                    Epi = xlRange.Cells[i, ei.UAEpi].Value2.ToString();
                }
                else
                {
                    Epi = "";
                }
                if (xlRange.Cells[i, ei.UABact].Value2 != null)
                {
                    Bact = xlRange.Cells[i, ei.UABact].Value2.ToString();
                }
                else
                {
                    Bact = "";
                }
                if (xlRange.Cells[i, ei.UAResult].Value2 != null)
                {
                    Result = xlRange.Cells[i, ei.UAResult].Value2.ToString();
                }
                else
                {
                    Result = "";
                }
                if (xlRange.Cells[i, ei.UASummary].Value2 != null)
                {
                    Summary = xlRange.Cells[i, ei.UASummary].Value2.ToString();
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
                if (xlRange.Cells[i, ei.TriNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.TriNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.Triglyceride].Value2 != null)
                {
                    value = xlRange.Cells[i, ei.Triglyceride].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, ei.TriResult].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.TriResult].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.TriSummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.TriSummary].Value2.ToString();
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
            String rowNumber = "", chk = "", result = "", summary = "", value = "", ldl="", hdl="";

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
                if (xlRange.Cells[i, ei.ChoNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.ChoNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.Cholesteral].Value2 != null)
                {
                    value = xlRange.Cells[i, ei.Cholesteral].Value2.ToString();
                }
                else
                {
                    value = "";
                }

                if (xlRange.Cells[i, ei.ChoLDL].Value2 != null)
                {
                    ldl = xlRange.Cells[i, ei.ChoLDL].Value2.ToString();
                }
                else
                {
                    ldl = "";
                } if (xlRange.Cells[i, ei.ChoHDL].Value2 != null)
                {
                    hdl = xlRange.Cells[i, ei.ChoHDL].Value2.ToString();
                }
                else
                {
                    hdl = "";
                }

                if (xlRange.Cells[i, ei.ChoResult].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.ChoResult].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.Chosummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.Chosummary].Value2.ToString();
                }
                else
                {
                    summary = "";
                }


                chk = cc.ccpdb.UpdateCholes(rowNumber, txtId.Text, value, result, summary, ldl,hdl);
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
            String rowNumber = "", chk = "", result = "", summary = "", sgot = "", sgpt="", alt="";

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
                if (xlRange.Cells[i, ei.SgotNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.SgotNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.Sgot].Value2 != null)
                {
                    sgot = xlRange.Cells[i, ei.Sgot].Value2.ToString();
                }
                else
                {
                    sgot = "";
                }
                if (xlRange.Cells[i, ei.Sgpt].Value2 != null)
                {
                    sgpt = xlRange.Cells[i, ei.Sgpt].Value2.ToString();
                }
                else
                {
                    sgpt = "";
                }
                if (xlRange.Cells[i, ei.Sgpt].Value2 != null)
                {
                    alt = xlRange.Cells[i, ei.Sgpt].Value2.ToString();
                }
                else
                {
                    alt = "";
                }
                if (xlRange.Cells[i, ei.SgotResult].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.SgotResult].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.SgptSummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.SgptSummary].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateSgot(rowNumber, txtId.Text, sgot, sgpt, alt, result, summary);
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
                if (xlRange.Cells[i,ei.BunNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.BunNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.Bun].Value2 != null)
                {
                    bun = xlRange.Cells[i, ei.Bun].Value2.ToString();
                }
                else
                {
                    bun = "";
                }
                if (xlRange.Cells[i, ei.BunCreatinine].Value2 != null)
                {
                    creatinine = xlRange.Cells[i, ei.BunCreatinine].Value2.ToString();
                }
                else
                {
                    creatinine = "";
                }
                if (xlRange.Cells[i, ei.BunResult].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.BunResult].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.BunSummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.BunSummary].Value2.ToString();
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
                if (xlRange.Cells[i, ei.UricNo].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, ei.UricNo].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, ei.UricAcid].Value2 != null)
                {
                    value = xlRange.Cells[i, ei.UricAcid].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, ei.UricResult].Value2 != null)
                {
                    result = xlRange.Cells[i, ei.UricResult].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, ei.UricSummary].Value2 != null)
                {
                    summary = xlRange.Cells[i, ei.UricSummary].Value2.ToString();
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
            Random r = new Random();
            RCheckUp rc = new RCheckUp();
            int row = 0;
            label85.Text = System.DateTime.Now.ToShortTimeString();
            pB1.Visible = true;
            pB1.Minimum = 0;
            cc.lw.WriteLog("FrmCheckUPAdd.btnPrint_Click 01 ");
            cc.rcdb.deleteAll();
            dtAll = cc.ccpdb.selectAllByCucId(cuc.Id);
            cc.lw.WriteLog("FrmCheckUPAdd.btnPrint_Click 02 ");
            //pB1.Maximum = dtAll.Rows.Count;
            pB1.Maximum = int.Parse(nmDPrintEnd.Value.ToString());
            cc.rcdb.conn.OpenConnection();
            row = int.Parse(nmDPrintFirst.Value.ToString()) - 1;
            //for (int i = 0; i < dtAll.Rows.Count; i++)
            if (nmDPrintFirst.Value > nmDPrintEnd.Value)
            {
                MessageBox.Show("ลำกับ พิมพ์ ไม่ถูกต้อง", "Error");
                return;
            }
            //DataTable dtN = new DataTable();
            //dtN = cc.ccpvndb.selectByPk();
            cc.lw.WriteLog("FrmCheckUPAdd.btnPrint_Click 03 ");
            for (int i = row; i < int.Parse(nmDPrintEnd.Value.ToString()); i++)
            {
                rc.Id = r.Next().ToString();
                rc.FullName = dtAll.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                rc.Age = dtAll.Rows[i][cc.ccpdb.ccp.patientAge].ToString();
                rc.BMI = dtAll.Rows[i][cc.ccpdb.ccp.bmi].ToString();
                rc.Height = dtAll.Rows[i][cc.ccpdb.ccp.patientHeight].ToString();
                rc.Weight = dtAll.Rows[i][cc.ccpdb.ccp.patientWeight].ToString();
                rc.RowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();

                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Hb";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHb].ToString();
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
                rc.Sort2 = "10";
                //rc.LabNormal = dtN.Rows[0][cc.ccpvndb.ccpvn.cbcHb].ToString();
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Hct";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHct].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcHct].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "11";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "WBC";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcWbc].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcWbc].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "13";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Neutrophils";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcNeutrophil].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcNeutrophil].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "14";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Eosinophils ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcEosinophil].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcEosinophil].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "15";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Basophils ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcBasophil].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcBasophil].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "16";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Lymphocyte ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcLymphocyte].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcLymphocyte].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "17";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Monocyte ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMonocyte].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMonocyte].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "18";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "RBC ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbc].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcRbc].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "19";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "MCV ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcv].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMcv].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "20";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "MCH ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMch].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMch].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "21";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "MCHC ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMchc].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMchc].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "22";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Platelet Count ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletCount].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcPlateletCount].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "23";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "Platelet smear ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletSmear].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcPlateletSmear].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "24";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                rc.LabName = "RBC morphology ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMorpholog].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcRbcMorpholog].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                rc.Remark = "";
                rc.StatusLab = "cbc";
                rc.Sort1 = "1010";
                rc.Sort2 = "25";
                cc.rcdb.insertRCheckUp(rc);

                //FBS
                rc.Id = r.Next().ToString();
                rc.LabGroup = "ระดับน้ำตาลในเลือด (Fasting Blood Sugar)";
                rc.LabName = "FBS ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.sugar].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจน้ำตาล";
                rc.Remark = "";
                rc.StatusLab = "fbs";
                rc.Sort1 = "1011";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                //UA
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Color ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineColor].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineColor].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Appearance ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineAppearance].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineAppearance].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "11";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "pH. ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urinePh].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urinePh].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "12";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Sugar ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSugar].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineSugar].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "13";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Protein ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineProtein].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineProtein].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "14";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "SpGr ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSpGr].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineSpGr].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "15";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Uric Acid ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.uricAcid].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.uricAcid].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "16";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Bacteria ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineBacteria].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineBacteria].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "17";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Blood ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineBlood].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineBlood].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "18";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Epithelium ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineEpithelium].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineEpithelium].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "19";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "RBC ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineRbc].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineRbc].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "20";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "WBC ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineWbc].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineWbc].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "21";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Ketone ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineKetone].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineKetone].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "22";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                rc.LabName = "Leu ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineLeu].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineLeu].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                rc.Remark = "";
                rc.StatusLab = "ua";
                rc.Sort1 = "1012";
                rc.Sort2 = "23";
                cc.rcdb.insertRCheckUp(rc);

                //Bun
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (Bun)";
                rc.LabName = "Bun ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBun].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.kidneyBun].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ BUN";
                rc.Remark = "";
                rc.StatusLab = "bun";
                rc.Sort1 = "1013";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (Bun)";
                rc.LabName = "Creatinine ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.kidneyCreatinine].ToString(); ;
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.kidneyCreatinine].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ BUN";
                rc.Remark = "";
                rc.StatusLab = "bun";
                rc.Sort1 = "1013";
                rc.Sort2 = "11";
                cc.rcdb.insertRCheckUp(rc);

                //Uric
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (Uric)";
                rc.LabName = "Bacteria ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.uricAcid].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.uricAcid].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ Uric";
                rc.Remark = "";
                rc.StatusLab = "uric";
                rc.Sort1 = "1014";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                //Trig
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (Triglyceride)";
                rc.LabName = "Triglyceride ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.triglyceride].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.triglyceride].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ Triglyceride";
                rc.Remark = "";
                rc.StatusLab = "tri";
                rc.Sort1 = "1015";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                //Sgot
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (SGOT/SGPT)";
                rc.LabName = "SGOT ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.liverSgot].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.liverSgot].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ SGOT";
                rc.Remark = "";
                rc.StatusLab = "sgot";
                rc.Sort1 = "1016";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                //Sgot
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (SGOT/SGPT)";
                rc.LabName = "SGPT ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.liverSgpt].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ SGOT";
                rc.Remark = "";
                rc.StatusLab = "sgot";
                rc.Sort1 = "1016";
                rc.Sort2 = "11";
                cc.rcdb.insertRCheckUp(rc);

                //Choles
                rc.Id = r.Next().ToString();
                rc.LabGroup = "การตรวจ (Choles)";
                rc.LabName = "Choles ";
                rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.cholesterol].ToString();
                rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cholesterol].ToString();
                rc.LInter = "การแปรผล";
                rc.LInterAbnormal = "ปกติ";
                rc.LInterNormal = "ผิดปกติ";
                rc.LNormal = "ค่าปกติ";
                rc.lResult = "ผลการตรวจ";
                rc.LTypeLab = "ประเภทการตรวจ Choles";
                rc.Remark = "";
                rc.StatusLab = "cho";
                rc.Sort1 = "1017";
                rc.Sort2 = "10";
                cc.rcdb.insertRCheckUp(rc);

                pB1.Value = i;
            }
            pB1.Visible = false;
            cc.rcdb.conn.CloseConnection();
            label86.Text = System.DateTime.Now.ToShortTimeString();
            

            DataTable dt = new DataTable();
            dt = cc.rcdb.selectAll();
            FrmReport frm = new FrmReport(cc);
            frm.setReportCheckUp(cuc, dt);
            frm.ShowDialog(this);

        }

        private void dgvPE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colPEId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colPEId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdPE(cuc.Id);

        }

        private void dgvXRay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colXrayId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colXrayId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdXray(cuc.Id);
        }

        private void dgvCBC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colCBCId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colCBCId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdCBC(cuc.Id);
        }

        private void dgvFBS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colFBSId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colFBSId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdFBS(cuc.Id);
        }

        private void dgvUA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colUAId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colUAId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdUA(cuc.Id);
        }

        private void dgvTri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colTriId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colTriId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdTri(cuc.Id);
        }

        private void dgvCho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colChoId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colChoId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdCholes(cuc.Id);
        }

        private void dgvSgot_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colSgotId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colSgotId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdSgot(cuc.Id);
        }

        private void dgvBun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colBunId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colBunId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdBun(cuc.Id);
        }

        private void dgvUric_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colUricId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colUricId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdUric(cuc.Id);
        }

        private void btnOther1Excel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameOther1 = ofd.FileName;
            btnOtherImport.Enabled = true;
        }

        private void btnOtherImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", HBsAg = "", HbsAb="", AntiHIV="", VDRL="", Amphetamine="", Calcium="";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameOther1);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.Other1Row); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.Other1No)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.Other1No)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Other1HBsAg)].Value2 != null)
                {
                    HBsAg = xlRange.Cells[i, int.Parse(ei.Other1HBsAg)].Value2.ToString();
                }
                else
                {
                    HBsAg = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Other1HBsAb)].Value2 != null)
                {
                    HbsAb = xlRange.Cells[i, int.Parse(ei.Other1HBsAb)].Value2.ToString();
                }
                else
                {
                    HbsAb = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Other1AntiHIV)].Value2 != null)
                {
                    AntiHIV = xlRange.Cells[i, int.Parse(ei.Other1AntiHIV)].Value2.ToString();
                }
                else
                {
                    AntiHIV = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Other1VDRL)].Value2 != null)
                {
                    VDRL = xlRange.Cells[i, int.Parse(ei.Other1VDRL)].Value2.ToString();
                }
                else
                {
                    VDRL = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Other1Amphetamine)].Value2 != null)
                {
                    Amphetamine = xlRange.Cells[i, int.Parse(ei.Other1Amphetamine)].Value2.ToString();
                }
                else
                {
                    Amphetamine = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Other1Calcium)].Value2 != null)
                {
                    Calcium = xlRange.Cells[i, int.Parse(ei.Other1Calcium)].Value2.ToString();
                }
                else
                {
                    Calcium = "";
                }
                //if (xlRange.Cells[i, ei.UricResult].Value2 != null)
                //{
                //    result = xlRange.Cells[i, ei.UricResult].Value2.ToString();
                //}
                //else
                //{
                //    result = "";
                //}
                //if (xlRange.Cells[i, ei.UricSummary].Value2 != null)
                //{
                //    summary = xlRange.Cells[i, ei.UricSummary].Value2.ToString();
                //}
                //else
                //{
                //    summary = "";
                //}

                chk = cc.ccpdb.UpdateOther1(rowNumber, txtId.Text, HBsAg, HbsAb, AntiHIV, VDRL, Amphetamine, Calcium);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdOther1(txtId.Text);
        }

        private void btnLungExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameLung = ofd.FileName;
            btnLungImport.Enabled = true;
        }

        private void btnLungImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", LungFvcPredic = "", LungFvcMeas = "", LungFvcPer = "", LungFev1Predic = "", LungFev1Meas = "", LungFev1Per = "", LungPerFev1 = "";

            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameLung);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.LungRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.LungNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.LungNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungFvcPredic)].Value2 != null)
                {
                    LungFvcPredic = xlRange.Cells[i, int.Parse(ei.LungFvcPredic)].Value2.ToString();
                }
                else
                {
                    LungFvcPredic = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungFvcMeas)].Value2 != null)
                {
                    LungFvcMeas = xlRange.Cells[i, int.Parse(ei.LungFvcMeas)].Value2.ToString();
                }
                else
                {
                    LungFvcMeas = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungFvcPer)].Value2 != null)
                {
                    LungFvcPer = xlRange.Cells[i, int.Parse(ei.LungFvcPer)].Value2.ToString();
                }
                else
                {
                    LungFvcPer = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungFev1Predic)].Value2 != null)
                {
                    LungFev1Predic = xlRange.Cells[i, int.Parse(ei.LungFev1Predic)].Value2.ToString();
                }
                else
                {
                    LungFev1Predic = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungFev1Meas)].Value2 != null)
                {
                    LungFev1Meas = xlRange.Cells[i, int.Parse(ei.LungFev1Meas)].Value2.ToString();
                }
                else
                {
                    LungFev1Meas = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungFev1Per)].Value2 != null)
                {
                    LungFev1Per = xlRange.Cells[i, int.Parse(ei.LungFev1Per)].Value2.ToString();
                }
                else
                {
                    LungFev1Per = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungPerFev1)].Value2 != null)
                {
                    LungPerFev1 = xlRange.Cells[i, int.Parse(ei.LungPerFev1)].Value2.ToString();
                }
                else
                {
                    LungPerFev1 = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.LungSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.LungSummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateLung(rowNumber, txtId.Text, LungFvcPredic, LungFvcMeas, LungFvcPer, LungFev1Predic, LungFev1Meas, LungFev1Per, LungPerFev1, summary);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdLung(txtId.Text);
        }

        private void btnAudioExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameAudio = ofd.FileName;
            btnAudioImport.Enabled = true;
        }

        private void btnAudioImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "";
            
            String Audiogram500L = "", Audiogram1000L = "", Audiogram2000L = "", Audiogram3000L = "", Audiogram4000L="",Audiogram6000L="", Audiogram8000L="", AudiogramSummaryL="";
            String Audiogram500R = "", Audiogram1000R = "", Audiogram2000R = "", Audiogram3000R="", Audiogram4000R="", Audiogram6000R="", Audiogram8000R="", AudiogramSummaryR="", AudiogramExam="";
            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameAudio);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.AudoigramRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.AudiogramNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.AudiogramNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram500L)].Value2 != null)
                {
                    Audiogram500L = xlRange.Cells[i, int.Parse(ei.Audiogram500L)].Value2.ToString();
                }
                else
                {
                    Audiogram500L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram1000L)].Value2 != null)
                {
                    Audiogram1000L = xlRange.Cells[i, int.Parse(ei.Audiogram1000L)].Value2.ToString();
                }
                else
                {
                    Audiogram1000L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram2000L)].Value2 != null)
                {
                    Audiogram2000L = xlRange.Cells[i, int.Parse(ei.Audiogram2000L)].Value2.ToString();
                }
                else
                {
                    Audiogram2000L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram3000L)].Value2 != null)
                {
                    Audiogram3000L = xlRange.Cells[i, int.Parse(ei.Audiogram3000L)].Value2.ToString();
                }
                else
                {
                    Audiogram3000L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram4000L)].Value2 != null)
                {
                    Audiogram4000L = xlRange.Cells[i, int.Parse(ei.Audiogram4000L)].Value2.ToString();
                }
                else
                {
                    Audiogram4000L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram6000L)].Value2 != null)
                {
                    Audiogram6000L = xlRange.Cells[i, int.Parse(ei.Audiogram6000L)].Value2.ToString();
                }
                else
                {
                    Audiogram6000L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram8000L)].Value2 != null)
                {
                    Audiogram8000L = xlRange.Cells[i, int.Parse(ei.Audiogram8000L)].Value2.ToString();
                }
                else
                {
                    Audiogram8000L = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.AudiogramSummaryL)].Value2 != null)
                {
                    AudiogramSummaryL = xlRange.Cells[i, int.Parse(ei.AudiogramSummaryL)].Value2.ToString();
                }
                else
                {
                    AudiogramSummaryL = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram500R)].Value2 != null)
                {
                    Audiogram500R = xlRange.Cells[i, int.Parse(ei.Audiogram500R)].Value2.ToString();
                }
                else
                {
                    Audiogram500R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram1000R)].Value2 != null)
                {
                    Audiogram1000R = xlRange.Cells[i, int.Parse(ei.Audiogram1000R)].Value2.ToString();
                }
                else
                {
                    Audiogram1000R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram2000R)].Value2 != null)
                {
                    Audiogram2000R = xlRange.Cells[i, int.Parse(ei.Audiogram2000R)].Value2.ToString();
                }
                else
                {
                    Audiogram2000R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram3000R)].Value2 != null)
                {
                    Audiogram3000R = xlRange.Cells[i, int.Parse(ei.Audiogram3000R)].Value2.ToString();
                }
                else
                {
                    Audiogram3000R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram4000R)].Value2 != null)
                {
                    Audiogram4000R = xlRange.Cells[i, int.Parse(ei.Audiogram4000R)].Value2.ToString();
                }
                else
                {
                    Audiogram4000R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram6000R)].Value2 != null)
                {
                    Audiogram6000R = xlRange.Cells[i, int.Parse(ei.Audiogram6000R)].Value2.ToString();
                }
                else
                {
                    Audiogram6000R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Audiogram8000R)].Value2 != null)
                {
                    Audiogram8000R = xlRange.Cells[i, int.Parse(ei.Audiogram8000R)].Value2.ToString();
                }
                else
                {
                    Audiogram8000R = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.AudiogramSummaryR)].Value2 != null)
                {
                    AudiogramSummaryR = xlRange.Cells[i, int.Parse(ei.AudiogramSummaryR)].Value2.ToString();
                }
                else
                {
                    AudiogramSummaryR = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.AudiogramExam)].Value2 != null)
                {
                    AudiogramExam = xlRange.Cells[i, int.Parse(ei.AudiogramExam)].Value2.ToString();
                }
                else
                {
                    AudiogramExam = "";
                }


                chk = cc.ccpdb.updateAudioGram(rowNumber, txtId.Text, Audiogram500L, Audiogram500R, Audiogram1000L, Audiogram1000R, Audiogram2000L, Audiogram2000R, Audiogram3000L, Audiogram3000R,
                    Audiogram4000L, Audiogram4000R, Audiogram6000L, Audiogram6000R, Audiogram8000L, Audiogram8000R, AudiogramSummaryL, AudiogramSummaryR, AudiogramExam);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdAudoigram(txtId.Text);
        }

        private void dgvOther1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colUricId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colOther1Id, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdOther1(cuc.Id);
        }

        private void dgvLung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colUricId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colLungId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);
            setGrdLung(cuc.Id);
        }

        private void dgvAudio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvPE[colUricId, e.RowIndex].Value == null)
            {
                return;
            }

            FrmCheckUpEdit frm = new FrmCheckUpEdit(dgvPE[colAudiogramId, e.RowIndex].Value.ToString(), cc);
            //frm.setControl(dgvView[colId, e.RowIndex].Value.ToString());
            frm.ShowDialog(this);            
            setGrdAudoigram(cuc.Id);
        }

        private void btnEyeExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameEye = ofd.FileName;
            btnEyeImport.Enabled = true;
        }

        private void btnEyeImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "";

            String EyeShortLongLeft = "", EyeShortLongRight = "", EyeSquintLeft = "", EyeSquintRight = "", EyedegreeLeft = "", EyeDegreeRight = "", EyeOldLeft = "", EyeOldRight = "", EyeBlindness = "", EyeResult = "", EyeSummary = "";
            pB1.Visible = true;
            pB1.Minimum = 0;

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameEye);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.AudoigramRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.EyeNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.EyeNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeShortLongLeft)].Value2 != null)
                {
                    EyeShortLongLeft = xlRange.Cells[i, int.Parse(ei.EyeShortLongLeft)].Value2.ToString();
                }
                else
                {
                    EyeShortLongLeft = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeShortLongRight)].Value2 != null)
                {
                    EyeShortLongRight = xlRange.Cells[i, int.Parse(ei.EyeShortLongRight)].Value2.ToString();
                }
                else
                {
                    EyeShortLongRight = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeSquintLeft)].Value2 != null)
                {
                    EyeSquintLeft = xlRange.Cells[i, int.Parse(ei.EyeSquintLeft)].Value2.ToString();
                }
                else
                {
                    EyeSquintLeft = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeSquintRight)].Value2 != null)
                {
                    EyeSquintRight = xlRange.Cells[i, int.Parse(ei.EyeSquintRight)].Value2.ToString();
                }
                else
                {
                    EyeSquintRight = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyedegreeLeft)].Value2 != null)
                {
                    EyedegreeLeft = xlRange.Cells[i, int.Parse(ei.EyedegreeLeft)].Value2.ToString();
                }
                else
                {
                    EyedegreeLeft = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeDegreeRight)].Value2 != null)
                {
                    EyeDegreeRight = xlRange.Cells[i, int.Parse(ei.EyeDegreeRight)].Value2.ToString();
                }
                else
                {
                    EyeDegreeRight = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeOldLeft)].Value2 != null)
                {
                    EyeOldLeft = xlRange.Cells[i, int.Parse(ei.EyeOldLeft)].Value2.ToString();
                }
                else
                {
                    EyeOldLeft = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeOldRight)].Value2 != null)
                {
                    EyeOldRight = xlRange.Cells[i, int.Parse(ei.EyeOldRight)].Value2.ToString();
                }
                else
                {
                    EyeOldRight = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeBlindness)].Value2 != null)
                {
                    EyeBlindness = xlRange.Cells[i, int.Parse(ei.EyeBlindness)].Value2.ToString();
                }
                else
                {
                    EyeBlindness = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeResult)].Value2 != null)
                {
                    EyeResult = xlRange.Cells[i, int.Parse(ei.EyeResult)].Value2.ToString();
                }
                else
                {
                    EyeResult = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.EyeSummary)].Value2 != null)
                {
                    EyeSummary = xlRange.Cells[i, int.Parse(ei.EyeSummary)].Value2.ToString();
                }
                else
                {
                    EyeSummary = "";
                }


                chk = cc.ccpdb.updateEye(rowNumber, txtId.Text, EyeShortLongLeft, EyeShortLongRight, EyeSquintLeft, EyeSquintRight, EyedegreeLeft, EyeDegreeRight, EyeOldLeft, EyeOldRight,
                    EyeResult, EyeSummary, EyeBlindness);
                pB1.Value = i;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdLung(txtId.Text);
        }
        
    }
}
