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

        int tabSum = 0, tabSum2=1, tabPrint=2, tabPE=3, tabXRay=4, tabCBC=5, tabFBS=6, tabUA=7,tabTri=8, tabCho=9, tabSgot=10, tabBun=11, tabUric=12, tabOther1=13, tabLung=14, tabAudio=15, tabEye=16, tabToxi=17, tabStoolExam=18;
        int tabCnt = 20;

        int colPERow = 0, colPEId = 1, colPEName = 2, colPESex=3, colPEAge = 4, colPEDepartment=5, colPEWeight = 6, colPEHeight = 7, colPEBMI = 8, colPEvitalsign = 9, colPEPulse = 10, colPEBloodGroup=11, colPEResult = 12, colPESummary = 13;
        int colPECnt = 14;

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

        int colSgotRow = 0, colSgotId = 1, colSgotName = 2, colSgotValue = 3, colSgotSgptValue = 4, colSgotResult = 5, colSgptResult = 6, coLSgotSummary = 7;
        int colSgotCnt = 8;

        int colBunRow = 0, colBunId = 1, colBunName = 2, colBunValue = 3, colBunCreatinineValue = 4, colBunResult = 5, colCreatinineResult = 6, coLBunSummary = 7;
        int colBunCnt = 8;

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

        int colEyeRow = 0, colEyeId = 1, colEyeName = 2, colEyeShortLongLeft = 3, colEyeShortLongRight = 4, colEyeSquintLeft = 5, colEyeSquintRight = 6, colEyeDegreeLeft = 7, colEyeDegreeRight = 8, colEyeOldLeft = 9, colEyeOldRight = 10, colEyeBlindness = 10, colEyeResult = 11, colEyeSummary = 12, colEyeExam=13;
        int colEyeCnt = 14;

        int colStoolExamRow = 0, colStoolExamId = 1, colStoolExamName=2, colStoolExamColor = 3, colStoolExamAppearance = 4, colStoolExamWBC = 5, colStoolExamRBC = 6, colParasite = 7, colStoolExamSummary = 8;
        int colStoolExamCnt = 9;

        int colToxiRow = 0, colToxiId = 1, colToxiName = 2, colToxiLead = 3, colToxiAluminium = 4, colToxiCadmium = 5, colToxiMercury = 6, colToxiTin = 7, colToxiCopper = 8, colToxiManganese = 9, colToxiZinc = 10, colToxiAmmonia = 11;
        int colToxiHippuric = 12, colToxiMethyl = 13, colToxiAcetone = 14, colToxiNickel = 15, colToxiChromium = 16, colToxiPhenol = 17, colToxiKetone = 18, colToxiBenzene = 19, colToxiMandelic = 20, colToxiMethanol = 21;
        int colToxiEthanol = 22, colToxiIPA = 23, colToxiArsenic = 24, colToxiHexane = 25, colToxiFomaldehyde = 26, colToxiTrichloroethylene = 27, colToxiAntimony = 28, colToxiFluoride = 29;
        int colToxiCnt = 30;

        Font font = new Font("Microsoft Sans Serif", 12);
        Boolean flagNew=false;
        String fileName = "", fileNamePE = "", fileNameFBS = "", fileNameXray = "", fileNameCBC = "", fileNameUA = "", fileNameTri = "", fileNameCho = "", fileNameLung="";
        String fileNameSgot = "", fileNameBun = "", fileNameUric = "", fileNameOther1 = "", fileNameAudio="", fileNameEye="", fileNameStoolExam="", fileNameToxi="", fileNameChemU="";
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
            tC.TabPages[tabToxi].Text = "Toxicology";
            //tC.TabPages[tabChemU].Text = "Chem Uric";
            tC.TabPages[tabStoolExam].Text = "Stool Exam";

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
            btnStoolExamImport.Enabled = false;
            btnToxiImport.Enabled = false;
            //btnChemUImport.Enabled = false;

            btnUnActive.Visible = false;

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
            setGrdEye();
            setGrdStoolExam();
            setGrdToxi();

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
            setGrdEye(cucId);
            setGrdStoolExam(cucId);
            setGrdToxi(cucId);
        }

        private void setResize()
        {
            tC.Width = this.Width - 50;
            tC.Height = this.Height - 150;
            tC.TabPages[tabSum].Width = tC.Width - 10;
            tC.TabPages[tabSum].Height = tC.Height - 10;
            dgvSum.Width = tC.TabPages[tabSum].Width - 10;
            dgvSum.Height = tC.TabPages[tabSum].Height - 30;


            tC.TabPages[tabPE].Width = tC.Width - 10;
            tC.TabPages[tabPE].Height = tC.Height - 10;
            dgvPE.Width = tC.TabPages[tabPE].Width - 10;
            dgvPE.Height = tC.TabPages[tabPE].Height - 30;
            //dgvPE.Left = dgvSum.Left;
            //dgvPE.Top = dgvSum.Left;
            dgvSum.Width = tC.TabPages[tabPE].Width - 10;
            dgvSum.Height = tC.TabPages[tabPE].Height - 30;

            tC.TabPages[tabXRay].Width = tC.Width - 10;
            tC.TabPages[tabXRay].Height = tC.Height - 10;
            dgvXRay.Width = tC.TabPages[tabXRay].Width - 10;
            dgvXRay.Height = tC.TabPages[tabXRay].Height - 30;
            dgvXRay.Left = dgvPE.Left;
            dgvXRay.Top = dgvPE.Left;

            tC.TabPages[tabCBC].Width = tC.Width - 10;
            tC.TabPages[tabCBC].Height = tC.Height - 10;
            dgvCBC.Width = tC.TabPages[tabCBC].Width - 10;
            dgvCBC.Height = tC.TabPages[tabCBC].Height - 30;
            dgvCBC.Left = dgvPE.Left;
            dgvCBC.Top = dgvPE.Left;

            tC.TabPages[tabFBS].Width = tC.Width - 10;
            tC.TabPages[tabFBS].Height = tC.Height - 10;
            dgvFBS.Width = tC.TabPages[tabFBS].Width - 10;
            dgvFBS.Height = tC.TabPages[tabFBS].Height - 30;
            dgvFBS.Left = dgvPE.Left;
            dgvFBS.Top = dgvPE.Left;

            tC.TabPages[tabUA].Width = tC.Width - 10;
            tC.TabPages[tabUA].Height = tC.Height - 10;
            dgvUA.Width = tC.TabPages[tabUA].Width - 10;
            dgvUA.Height = tC.TabPages[tabUA].Height - 30;
            dgvUA.Left = dgvPE.Left;
            dgvUA.Top = dgvPE.Left;

            tC.TabPages[tabTri].Width = tC.Width - 10;
            tC.TabPages[tabTri].Height = tC.Height - 10;
            dgvTri.Width = tC.TabPages[tabTri].Width - 10;
            dgvTri.Height = tC.TabPages[tabTri].Height - 30;
            dgvTri.Left = dgvPE.Left;
            dgvTri.Top = dgvPE.Left;

            tC.TabPages[tabCho].Width = tC.Width - 10;
            tC.TabPages[tabCho].Height = tC.Height - 10;
            dgvCho.Width = tC.TabPages[tabCho].Width - 10;
            dgvCho.Height = tC.TabPages[tabCho].Height - 30;
            dgvCho.Left = dgvPE.Left;
            dgvCho.Top = dgvPE.Left;

            tC.TabPages[tabSgot].Width = tC.Width - 10;
            tC.TabPages[tabSgot].Height = tC.Height - 10;
            dgvSgot.Width = tC.TabPages[tabSgot].Width - 10;
            dgvSgot.Height = tC.TabPages[tabSgot].Height - 30;
            dgvSgot.Left = dgvPE.Left;
            dgvSgot.Top = dgvPE.Left;

            tC.TabPages[tabBun].Width = tC.Width - 10;
            tC.TabPages[tabBun].Height = tC.Height - 10;
            dgvBun.Width = tC.TabPages[tabBun].Width - 10;
            dgvBun.Height = tC.TabPages[tabBun].Height - 30;
            dgvBun.Left = dgvPE.Left;
            dgvBun.Top = dgvPE.Left;

            tC.TabPages[tabUric].Width = tC.Width - 10;
            tC.TabPages[tabUric].Height = tC.Height - 10;
            dgvUric.Width = tC.TabPages[tabUric].Width - 10;
            dgvUric.Height = tC.TabPages[tabUric].Height - 30;
            dgvUric.Left = dgvPE.Left;
            dgvUric.Top = dgvPE.Left;

            tC.TabPages[tabOther1].Width = tC.Width - 10;
            tC.TabPages[tabOther1].Height = tC.Height - 10;
            dgvOther1.Width = tC.TabPages[tabOther1].Width - 10;
            dgvOther1.Height = tC.TabPages[tabOther1].Height - 30;
            dgvOther1.Left = dgvPE.Left;
            dgvOther1.Top = dgvPE.Left;

            tC.TabPages[tabLung].Width = tC.Width - 10;
            tC.TabPages[tabLung].Height = tC.Height - 10;
            dgvLung.Width = tC.TabPages[tabLung].Width - 10;
            dgvLung.Height = tC.TabPages[tabLung].Height - 30;
            dgvLung.Left = dgvPE.Left;
            dgvLung.Top = dgvPE.Left;

            tC.TabPages[tabAudio].Width = tC.Width - 10;
            tC.TabPages[tabAudio].Height = tC.Height - 10;
            dgvAudio.Width = tC.TabPages[tabAudio].Width - 10;
            dgvAudio.Height = tC.TabPages[tabAudio].Height - 30;
            dgvAudio.Left = dgvPE.Left;
            dgvAudio.Top = dgvPE.Left;

            tC.TabPages[tabEye].Width = tC.Width - 10;
            tC.TabPages[tabEye].Height = tC.Height - 10;
            dgvEye.Width = tC.TabPages[tabEye].Width - 10;
            dgvEye.Height = tC.TabPages[tabEye].Height - 30;
            dgvEye.Left = dgvPE.Left;
            dgvEye.Top = dgvPE.Left;

            tC.TabPages[tabStoolExam].Width = tC.Width - 10;
            tC.TabPages[tabStoolExam].Height = tC.Height - 10;
            dgvStoolExam.Width = tC.TabPages[tabStoolExam].Width - 10;
            dgvStoolExam.Height = tC.TabPages[tabStoolExam].Height - 30;
            dgvStoolExam.Left = dgvPE.Left;
            dgvStoolExam.Top = dgvPE.Left;

            tC.TabPages[tabToxi].Width = tC.Width - 10;
            tC.TabPages[tabToxi].Height = tC.Height - 10;
            dgvToxi.Width = tC.TabPages[tabToxi].Width - 10;
            dgvToxi.Height = tC.TabPages[tabToxi].Height - 30;
            dgvToxi.Left = dgvPE.Left;
            dgvToxi.Top = dgvPE.Left;

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
            dgvPE.Columns[colPEDepartment].Width = 120;
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
            dgvPE.Columns[colPEDepartment].HeaderText = "department";
            dgvPE.Columns[colPEWeight].HeaderText = "น้ำหนัก";
            dgvPE.Columns[colPEHeight].HeaderText = "ส่วนสูง";
            dgvPE.Columns[colPEBMI].HeaderText = "BMI";
            dgvPE.Columns[colPEvitalsign].HeaderText = "VitalSign";
            dgvPE.Columns[colPEPulse].HeaderText = "Pulse";
            dgvPE.Columns[colPEBloodGroup].HeaderText = "กรุ๊ปเลือด";
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
            dgvFBS.Columns[colFBSResult].HeaderText = "ผล [" + cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString()+"]";
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
            dgvUA.Columns[colUASummary].Width = 180;
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
            dgvTri.Columns[colTriResult].HeaderText = "ผล ["+cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString()+"]";
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
            dgvCho.Columns[colChoResult].Width = 300;
            dgvCho.Columns[coLChoSummary].Width = 180;

            dgvCho.Columns[colChoRow].HeaderText = "ลำดับ";
            dgvCho.Columns[colChoId].HeaderText = "code";
            dgvCho.Columns[colChoName].HeaderText = "ชื่อ นามสกุล";
            dgvCho.Columns[colChoValue].HeaderText = "ค่า";
            dgvCho.Columns[colChoLDL].HeaderText = "LDL";
            dgvCho.Columns[colChoHDL].HeaderText = "HDL";
            dgvCho.Columns[colChoResult].HeaderText = "ผล Choles [" + cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString()+"]";
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
            dgvSgot.Columns[colSgotResult].Width = 300;
            dgvSgot.Columns[colSgptResult].Width = 300;
            dgvSgot.Columns[coLSgotSummary].Width = 180;

            dgvSgot.Columns[colSgotRow].HeaderText = "ลำดับ";
            dgvSgot.Columns[colSgotId].HeaderText = "code";
            dgvSgot.Columns[colSgotName].HeaderText = "ชื่อ นามสกุล";
            dgvSgot.Columns[colSgotValue].HeaderText = "SGOT";
            dgvSgot.Columns[colSgotSgptValue].HeaderText = "SGPT";
            dgvSgot.Columns[colSgotResult].HeaderText = "ผล SGOT [" + cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString()+"]";
            dgvSgot.Columns[colSgptResult].HeaderText = "ผล SGPT ["+cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgpt].ToString()+"]";
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
            dgvBun.Columns[colBunResult].HeaderText = "ผล BUN ";
            dgvBun.Columns[colCreatinineResult].HeaderText = "ผล Creatinine ";
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
            dgvLung.Columns[colLungFvcPredic].Width = 120;
            dgvLung.Columns[colLungFvcMeas].Width = 120;
            dgvLung.Columns[colLungFvcPer].Width = 120;
            dgvLung.Columns[colLungFev1Predic].Width = 120;
            dgvLung.Columns[colLungFev1Meas].Width = 120;
            dgvLung.Columns[colLungFev1Per].Width = 120;
            dgvLung.Columns[colLungPerFev1].Width = 120;
            dgvLung.Columns[colLungSummary].Width = 120;

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
            dgvAudio.Columns[colAudiogram500L].Width = 120;
            dgvAudio.Columns[colAudiogram1000L].Width = 120;
            dgvAudio.Columns[colAudiogram2000L].Width = 120;
            dgvAudio.Columns[colAudiogram3000L].Width = 120;
            dgvAudio.Columns[colAudiogram4000L].Width = 120;
            dgvAudio.Columns[colAudiogram6000L].Width = 120;
            dgvAudio.Columns[colAudiogram8000L].Width = 120;
            dgvAudio.Columns[colAudiogramSummaryL].Width = 120;
            dgvAudio.Columns[colAudiogram500R].Width = 120;
            dgvAudio.Columns[colAudiogram1000R].Width = 120;
            dgvAudio.Columns[colAudiogram2000R].Width = 120;
            dgvAudio.Columns[colAudiogram3000R].Width = 120;
            dgvAudio.Columns[colAudiogram4000R].Width = 120;
            dgvAudio.Columns[colAudiogram6000R].Width = 120;
            dgvAudio.Columns[colAudiogram8000R].Width = 120;
            dgvAudio.Columns[colAudiogramSummaryR].Width = 120;
            dgvAudio.Columns[colAudiogramSummary].Width = 120;

            dgvAudio.Columns[colAudiogramRow].HeaderText = "ลำดับ";
            dgvAudio.Columns[colAudiogramName].HeaderText = "ชื่อ นามสกุล";
            dgvAudio.Columns[colAudiogram500L].HeaderText = "Left 500";
            dgvAudio.Columns[colAudiogram1000L].HeaderText = "Left 1000";
            dgvAudio.Columns[colAudiogram2000L].HeaderText = "Left 2000";
            dgvAudio.Columns[colAudiogram3000L].HeaderText = "Left 3000";
            dgvAudio.Columns[colAudiogram4000L].HeaderText = "Left 4000";
            dgvAudio.Columns[colAudiogram6000L].HeaderText = "Left 6000";
            dgvAudio.Columns[colAudiogram8000L].HeaderText = "Left 8000";
            dgvAudio.Columns[colAudiogramSummaryL].HeaderText = "Left ";

            dgvAudio.Columns[colAudiogram500R].HeaderText = "Right 500";
            dgvAudio.Columns[colAudiogram1000R].HeaderText = "Right 1000";
            dgvAudio.Columns[colAudiogram2000R].HeaderText = "Right 2000";
            dgvAudio.Columns[colAudiogram3000R].HeaderText = "Right 3000";
            dgvAudio.Columns[colAudiogram4000R].HeaderText = "Right 4000";
            dgvAudio.Columns[colAudiogram6000R].HeaderText = "Right 6000";
            dgvAudio.Columns[colAudiogram8000R].HeaderText = "Right 8000";
            dgvAudio.Columns[colAudiogramSummaryR].HeaderText = "Right";

            dgvAudio.Columns[colAudiogramSummary].HeaderText = "Summary";
            dgvAudio.Columns[colAudiogramId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvAudio.Font = font;
            dgvAudio.Columns[colAudiogramId].Visible = false;
        }
        private void setGrdEye()
        {
            dgvEye.ColumnCount =colEyeCnt;
            dgvEye.Rows.Clear();
            dgvEye.RowCount = 1;
            dgvEye.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEye.Columns[colEyeRow].Width = 50;
            dgvEye.Columns[colEyeName].Width = 250;
            dgvEye.Columns[colEyeShortLongLeft].Width = 150;
            dgvEye.Columns[colEyeShortLongRight].Width = 150;
            dgvEye.Columns[colEyeSquintLeft].Width = 150;
            dgvEye.Columns[colEyeSquintRight].Width = 150;
            dgvEye.Columns[colEyeDegreeLeft].Width = 150;
            dgvEye.Columns[colEyeDegreeRight].Width = 150;
            dgvEye.Columns[colEyeOldLeft].Width = 150;
            dgvEye.Columns[colEyeOldRight].Width = 150;
            dgvEye.Columns[colEyeBlindness].Width = 150;
            dgvEye.Columns[colEyeResult].Width = 150;
            dgvEye.Columns[colEyeSummary].Width = 150;
            dgvEye.Columns[colEyeExam].Width = 150;
            //dgvEye.Columns[colAudiogram4000R].Width = 80;
            //dgvEye.Columns[colAudiogram6000R].Width = 80;
            //dgvEye.Columns[colAudiogram8000R].Width = 80;
            //dgvEye.Columns[colAudiogramSummaryR].Width = 80;
            //dgvEye.Columns[colAudiogramSummary].Width = 80;

            dgvEye.Columns[colEyeRow].HeaderText = "ลำดับ";
            dgvEye.Columns[colEyeName].HeaderText = "ชื่อ นามสกุล";
            dgvEye.Columns[colEyeShortLongLeft].HeaderText = "สายตาสั้น/ยาวL";
            dgvEye.Columns[colEyeShortLongRight].HeaderText = "สายตาสั้น/ยาวR";
            dgvEye.Columns[colEyeSquintLeft].HeaderText = "สายตาเอียงL";
            dgvEye.Columns[colEyeSquintRight].HeaderText = "สายตาเอียงR";
            dgvEye.Columns[colEyeDegreeLeft].HeaderText = "องศาL";
            dgvEye.Columns[colEyeDegreeRight].HeaderText = "องศาR";
            dgvEye.Columns[colEyeOldLeft].HeaderText = "สายตายาว(มีอายุ)L";
            dgvEye.Columns[colEyeOldRight].HeaderText = "สายตายาว(มีอายุ)R";

            dgvEye.Columns[colEyeBlindness].HeaderText = "ตาบอดสี";
            dgvEye.Columns[colEyeResult].HeaderText = "ผล";
            dgvEye.Columns[colEyeSummary].HeaderText = "Summary";
            dgvEye.Columns[colEyeExam].HeaderText = "ตาทั่วไป";

            dgvEye.Columns[colEyeId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvEye.Font = font;
            //dgvEye.AutoScrollOffset  
            dgvEye.Columns[colEyeId].Visible = false;
        }
        private void setGrdStoolExam()
        {
            dgvStoolExam.ColumnCount = colStoolExamCnt;
            dgvStoolExam.Rows.Clear();
            dgvStoolExam.RowCount = 1;
            dgvStoolExam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStoolExam.Columns[colStoolExamRow].Width = 50;
            dgvStoolExam.Columns[colStoolExamName].Width = 250;
            dgvStoolExam.Columns[colStoolExamColor].Width = 120;
            dgvStoolExam.Columns[colStoolExamAppearance].Width = 120;
            dgvStoolExam.Columns[colStoolExamWBC].Width = 120;
            dgvStoolExam.Columns[colStoolExamRBC].Width = 120;
            dgvStoolExam.Columns[colParasite].Width = 120;
            dgvStoolExam.Columns[colStoolExamSummary].Width = 120;

            dgvStoolExam.Columns[colStoolExamRow].HeaderText = "ลำดับ";
            dgvStoolExam.Columns[colStoolExamName].HeaderText = "ชื่อ นามสกุล";
            dgvStoolExam.Columns[colStoolExamColor].HeaderText = "Color";
            dgvStoolExam.Columns[colStoolExamAppearance].HeaderText = "Appearance";
            dgvStoolExam.Columns[colStoolExamWBC].HeaderText = "WBC";
            dgvStoolExam.Columns[colStoolExamRBC].HeaderText = "RBC";
            dgvStoolExam.Columns[colParasite].HeaderText = "Parasite";
            dgvStoolExam.Columns[colStoolExamSummary].HeaderText = "Summary";

            dgvStoolExam.Columns[colStoolExamId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvStoolExam.Font = font;
            dgvStoolExam.Columns[colStoolExamId].Visible = false;
        }
        private void setGrdToxi()
        {
            dgvToxi.ColumnCount = colToxiCnt;
            dgvToxi.Rows.Clear();
            dgvToxi.RowCount = 1;
            dgvToxi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToxi.Columns[colToxiRow].Width = 50;
            dgvToxi.Columns[colToxiName].Width = 250;
            dgvToxi.Columns[colToxiLead].Width = 120;
            dgvToxi.Columns[colToxiAluminium].Width = 120;
            dgvToxi.Columns[colToxiCadmium].Width = 120;
            dgvToxi.Columns[colToxiMercury].Width = 120;
            dgvToxi.Columns[colToxiTin].Width = 120;
            dgvToxi.Columns[colToxiCopper].Width = 120;
            dgvToxi.Columns[colToxiManganese].Width = 120;
            dgvToxi.Columns[colToxiZinc].Width = 120;
            dgvToxi.Columns[colToxiAmmonia].Width = 120;
            dgvToxi.Columns[colToxiHippuric].Width = 120;
            dgvToxi.Columns[colToxiMethyl].Width = 120;
            dgvToxi.Columns[colToxiAcetone].Width = 120;
            dgvToxi.Columns[colToxiNickel].Width = 120;
            dgvToxi.Columns[colToxiChromium].Width = 120;
            dgvToxi.Columns[colToxiPhenol].Width = 120;
            dgvToxi.Columns[colToxiKetone].Width = 120;
            dgvToxi.Columns[colToxiBenzene].Width = 120;
            dgvToxi.Columns[colToxiMandelic].Width = 120;
            dgvToxi.Columns[colToxiMethanol].Width = 120;
            dgvToxi.Columns[colToxiEthanol].Width = 120;
            dgvToxi.Columns[colToxiIPA].Width = 120;
            dgvToxi.Columns[colToxiArsenic].Width = 120;
            dgvToxi.Columns[colToxiHexane].Width = 120;
            dgvToxi.Columns[colToxiFomaldehyde].Width = 120;
            dgvToxi.Columns[colToxiTrichloroethylene].Width = 120;
            dgvToxi.Columns[colToxiAntimony].Width = 120;
            dgvToxi.Columns[colToxiFluoride].Width = 120;

            dgvToxi.Columns[colToxiRow].HeaderText = "ลำดับ";
            dgvToxi.Columns[colToxiName].HeaderText = "ชื่อ นามสกุล";
            dgvToxi.Columns[colToxiLead].HeaderText = "Lead";
            dgvToxi.Columns[colToxiAluminium].HeaderText = "Aluminium";
            dgvToxi.Columns[colToxiCadmium].HeaderText = "Cadmium";
            dgvToxi.Columns[colToxiMercury].HeaderText = "Mercury";
            dgvToxi.Columns[colToxiTin].HeaderText = "Tin";
            dgvToxi.Columns[colToxiCopper].HeaderText = "Copper";
            dgvToxi.Columns[colToxiManganese].HeaderText = "Manganese";
            dgvToxi.Columns[colToxiZinc].HeaderText = "Zinc";
            dgvToxi.Columns[colToxiAmmonia].HeaderText = "Ammonia";
            dgvToxi.Columns[colToxiHippuric].HeaderText = "Hippuric";
            dgvToxi.Columns[colToxiMethyl].HeaderText = "Methyl";
            dgvToxi.Columns[colToxiAcetone].HeaderText = "Acetone";
            dgvToxi.Columns[colToxiNickel].HeaderText = "Nickel";
            dgvToxi.Columns[colToxiChromium].HeaderText = "Chromium";
            dgvToxi.Columns[colToxiPhenol].HeaderText = "Phenol";
            dgvToxi.Columns[colToxiKetone].HeaderText = "Ketone";
            dgvToxi.Columns[colToxiBenzene].HeaderText = "Benzene";
            dgvToxi.Columns[colToxiMandelic].HeaderText = "Mandelic";
            dgvToxi.Columns[colToxiMethanol].HeaderText = "Methanol";
            dgvToxi.Columns[colToxiEthanol].HeaderText = "Ethanol";
            dgvToxi.Columns[colToxiIPA].HeaderText = "IPA";
            dgvToxi.Columns[colToxiArsenic].HeaderText = "Arsenic";
            dgvToxi.Columns[colToxiHexane].HeaderText = "Hexane";
            dgvToxi.Columns[colToxiFomaldehyde].HeaderText = "Fomaldehyde";
            dgvToxi.Columns[colToxiTrichloroethylene].HeaderText = "Trichloroethylene";
            dgvToxi.Columns[colToxiAntimony].HeaderText = "Antimony";
            dgvToxi.Columns[colToxiFluoride].HeaderText = "Fluoride";

            dgvToxi.Columns[colToxiId].HeaderText = "id";
            //Font font = new Font("Microsoft Sans Serif", 12);

            dgvToxi.Font = font;
            dgvToxi.Columns[colToxiId].Visible = false;
        }
        private void setControl(String cucId)
        {
            cuc = cc.cucdb.selectByPk(cucId);
            txtDescription.Text = cuc.Description;
            cboCust.Text = cuc.CustNameT;
            txtId.Text = cuc.Id;
            txtCntEmp.Text = cuc.CntEmployee;
            txtYear.Text = cuc.YearId;
            txtCntSuccess.Text = cuc.CntSuccess;

            txtPECntEmp.Text = cuc.PECnt;
            txtPESucess.Text = cuc.PESuccess;

            txtXrayCntEmp.Text = cuc.XrayCnt;
            txtXraySucess.Text = cuc.XraySuccess;

            txtFBSCntEmp.Text = cuc.FBSCnt;
            txtFBSSucess.Text = cuc.FBSSuccess;
            txtFBSNormal.Text = cuc.FBSNormal;

            txtCBCCntEmp.Text = cuc.CBCCnt;
            txtCBCSucess.Text = cuc.CBCSuccess;

            txtUACntEmp.Text = cuc.UACnt;
            txtUASucess.Text = cuc.UASuccess;
            txtUANormal.Text = cuc.UANormal;

            txtChoCntEmp.Text = cuc.ChoCnt;
            txtChoSucess.Text = cuc.ChoSuccess;
            txtchoNormal.Text = cuc.ChoNormal;

            txtTriCntEmp.Text = cuc.TriCnt;
            txtTriSucess.Text = cuc.TriSuccess;
            txtTriNormal.Text = cuc.TriAbNormal;

            txtSgotCntEmp.Text = cuc.SgotCnt;
            txtSgotSucess.Text = cuc.SgotSuccess;

            txtUricCntEmp.Text = cuc.UricCnt;
            txtUricSucess.Text = cuc.UricSuccess;

            txtBunCntEmp.Text = cuc.BunCnt;
            txtBunSucess.Text = cuc.BunSuccess;

            if (cuc.Active.Equals("1"))
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = false;
            }
            else 
            {
                chkActive.Checked = true;
                ChkUnActive.Checked = false;
                btnUnActive.Visible = true;
            }
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
                    //dgvPE[colPERow, i].Value = (i + 1);
                    dgvPE[colPERow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvPE[colPEName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    //if (dt.Rows[i][cc.ccpdb.ccp.fSexId].ToString().Equals("1"))
                    //{
                    dgvPE[colPESex, i].Value = dt.Rows[i][cc.ccpdb.ccp.SexName].ToString();
                    //}
                    //else if (dt.Rows[i][cc.ccpdb.ccp.fSexId].ToString().Equals("2"))
                    //{
                    //    dgvPE[colPESex, i].Value = "หญิง";
                    //}
                    //if (dt.Rows[i][cc.ccpdb.ccp.fSexId].ToString().Equals("3"))
                    //{
                    //    dgvPE[colPESex, i].Value = "ไม่ระบุ";
                    //}
                    //else
                    //{
                    //    dgvPE[colPESex, i].Value = "ไม่ระบุ";
                    //}
                    dgvPE[colPEDepartment, i].Value = dt.Rows[i][cc.ccpdb.ccp.departmentName].ToString();
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
                    //dgvXRay[colXrayRow, i].Value = (i + 1);
                    dgvXRay[colXrayRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
            //FBS
            String[] fbs = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString().Split('@');
            int fbsMin = 0, fbsMax = 0;
            String fbsUnit = "";
            if (fbs.Length == 2)
            {
                String[] aa = fbs[0].ToString().Split('-');
                fbsMin = int.Parse(aa[0]);
                fbsMax = int.Parse(aa[1]);
                fbsUnit = fbs[1];
            }
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
                    //dgvFBS[colFBSRow, i].Value = (i + 1);
                    dgvFBS[colFBSRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvFBS[colFBSName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvFBS[colFBSValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.sugar].ToString();
                    dgvFBS[colFBSResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.sugarDiagnosis].ToString();
                    dgvFBS[coLFBSSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.sugarSummary].ToString();

                    if (int.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.sugar].ToString())) > 0)
                    {
                        if ((int.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.sugar].ToString())) > fbsMin) && (int.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.sugar].ToString())) < fbsMax))
                        {
                            dgvFBS[colFBSResult, i].Value = "ปกติ";
                        }
                        else
                        {
                            if (int.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.sugar].ToString())) > fbsMax)
                            {
                                dgvFBS[colFBSResult, i].Value = "สูงกว่ามาตรฐาน";
                            }
                            else
                            {
                                dgvFBS[colFBSResult, i].Value = "ต่ำกว่ามาตรฐาน";
                            }
                        }
                    }
                    else
                    {
                        dgvFBS[colFBSResult, i].Value = "";
                    }

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
                    //dgvCBC[colCBCRow, i].Value = (i + 1);
                    dgvCBC[colCBCRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
                    //dgvUA[colUARow, i].Value = (i + 1);
                    dgvUA[colUARow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
            //Trigy
            String[] tri = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString().Split('@');
            Double triMax = 0;
            String triUnit = "";
            if (tri.Length == 2)
            {
                String[] aa = tri[0].ToString().Split('<');
                triMax = Double.Parse(aa[1]);
                //fbsMax = int.Parse(aa[1]);
                triUnit = tri[1];
            }
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
                    //dgvTri[colTriRow, i].Value = (i + 1);
                    dgvTri[colTriRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvTri[colTriName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvTri[colTriValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.triglyceride].ToString();
                    dgvTri[colTriResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.triglycerideResult].ToString();
                    dgvTri[coLTriSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.triglycerideSummary].ToString();
                    dgvTri[colTriId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();

                    if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.triglyceride].ToString())) > 0)
                    {
                        if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.triglyceride].ToString())) >= triMax)
                        {
                            dgvTri[colTriResult, i].Value = "สูงกว่าปกติ";
                        }
                        else if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.triglyceride].ToString())) < triMax)
                        {
                            dgvTri[colTriResult, i].Value = "ปกติ";
                        }
                    }
                    else
                    {
                        dgvTri[colTriResult, i].Value = "";
                    }

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
            //Choles
            String[] choles = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString().Split('@');
            Double cholesMax = 0;
            String cholesUnit = "";
            if (choles.Length == 2)
            {
                String[] aa = choles[0].ToString().Split('<');
                cholesMax = Double.Parse(aa[1]);
                //fbsMax = int.Parse(aa[1]);
                cholesUnit = choles[1];
            }
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
                    //dgvCho[colChoRow, i].Value = (i + 1);
                    dgvCho[colChoRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvCho[colChoName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvCho[colChoValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.cholesterol].ToString();
                    dgvCho[colChoLDL, i].Value = dt.Rows[i][cc.ccpdb.ccp.ldl].ToString();
                    dgvCho[colChoHDL, i].Value = dt.Rows[i][cc.ccpdb.ccp.hdl].ToString();
                    //dgvCho[colChoResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.cholesterolSuggess].ToString();
                    dgvCho[coLChoSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.cholesterolSummary].ToString();

                    if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.cholesterol].ToString())) > 0)
                    {
                        if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.cholesterol].ToString())) >= cholesMax)
                        {
                            dgvCho[colChoResult, i].Value = "สูงกว่าปกติ";
                        }
                        else if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.cholesterol].ToString())) < cholesMax)
                        {
                            dgvCho[colChoResult, i].Value = "ปกติ";
                        }
                    }
                    else
                    {
                        dgvCho[colChoResult, i].Value = "";
                    }

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
            //Sgot
            String[] sgot = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString().Split('@');
            Double sgotMin = 0, sgotMax = 0;
            String sgotUnit = "";
            if (sgot.Length == 2)
            {
                String[] aa = sgot[0].ToString().Split('-');
                sgotMin = Double.Parse(aa[0]);
                sgotMax = Double.Parse(aa[1]);
                sgotUnit = sgot[1];
            }
            String[] sgpt = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString().Split('@');
            Double sgptMin = 0, sgptMax = 0;
            String sgptUnit = "";
            if (sgpt.Length == 2)
            {
                String[] aa = sgpt[0].ToString().Split('-');
                sgptMin = Double.Parse(aa[0]);
                sgptMax = Double.Parse(aa[1]);
                sgptUnit = sgpt[1];
            }
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
                    //dgvSgot[colSgotRow, i].Value = (i + 1);
                    dgvSgot[colSgotRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvSgot[colSgotName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvSgot[colSgotValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverSgot].ToString();
                    dgvSgot[colSgotSgptValue, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString();
                    //dgvSgot[colSgotResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverResult].ToString();
                    //dgvSgot[colSgptResult, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverResult].ToString();
                    dgvSgot[coLSgotSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.liverSummary].ToString();

                    if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgot].ToString())) > 0)
                    {
                        if ((Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgot].ToString())) > sgptMin) &&
                            (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgot].ToString())) < sgptMax))
                        {
                            dgvSgot[colSgotResult, i].Value = "ปกติ";
                        }
                        else
                        {
                            if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgot].ToString())) > sgptMax)
                            {
                                dgvSgot[colSgotResult, i].Value = "สูงกว่ามาตรฐาน";
                            }
                            else
                            {
                                dgvSgot[colSgotResult, i].Value = "ต่ำกว่ามาตรฐาน";
                            }
                        }
                    }
                    else
                    {
                        dgvSgot[colSgotResult, i].Value = "";
                    }
                    if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString())) > 0)
                    {
                        if ((Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString())) > sgptMin) &&
                            (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString())) < sgptMax))
                        {
                            dgvSgot[colSgptResult, i].Value = "ปกติ";
                        }
                        else
                        {
                            if (Double.Parse(cc.cf.NumberNull1(dt.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString())) > sgptMax)
                            {
                                dgvSgot[colSgptResult, i].Value = "สูงกว่ามาตรฐาน";
                            }
                            else
                            {
                                dgvSgot[colSgptResult, i].Value = "ต่ำกว่ามาตรฐาน";
                            }
                        }
                    }
                    else
                    {
                        dgvSgot[colSgotResult, i].Value = "";
                    }

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
                    //dgvBun[colBunRow, i].Value = (i + 1);
                    dgvBun[colBunRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
                    //dgvUric[colUricRow, i].Value = (i + 1);
                    dgvUric[colUricRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
                    //dgvOther1[colOther1Row, i].Value = (i + 1);
                    dgvOther1[colOther1Row, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
                    //dgvLung[colLungRow, i].Value = (i + 1);
                    dgvLung[colLungRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
                    //dgvAudio[colAudiogramRow, i].Value = (i + 1);
                    dgvAudio[colAudiogramRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
            dgvEye.Rows.Clear();
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
                    //dgvEye[colEyeRow, i].Value = (i + 1);
                    dgvEye[colEyeRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
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
                    dgvEye[colEyeExam, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeExam].ToString();
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
        private void setGrdStoolExam(String cucId)
        {
            DataTable dt;
            dgvStoolExam.Rows.Clear();
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
                dgvStoolExam.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dgvStoolExam[colStoolExamRow, i].Value = (i + 1);
                    dgvStoolExam[colStoolExamRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvStoolExam[colStoolExamName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvStoolExam[colStoolExamColor, i].Value = dt.Rows[i][cc.ccpdb.ccp.StoolExamColor].ToString();
                    dgvStoolExam[colStoolExamAppearance, i].Value = dt.Rows[i][cc.ccpdb.ccp.StoolExamAppearance].ToString();
                    dgvStoolExam[colStoolExamWBC, i].Value = dt.Rows[i][cc.ccpdb.ccp.StoolExamWbc].ToString();
                    dgvStoolExam[colStoolExamRBC, i].Value = dt.Rows[i][cc.ccpdb.ccp.StoolExamRbc].ToString();
                    dgvStoolExam[colParasite, i].Value = dt.Rows[i][cc.ccpdb.ccp.StoolExamParasite].ToString();
                    dgvStoolExam[colStoolExamSummary, i].Value = dt.Rows[i][cc.ccpdb.ccp.StoolExamSummary].ToString();
                    dgvStoolExam[colStoolExamId, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvStoolExam.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
            //dgvView.ReadOnly = true;
        }
        private void setGrdToxi(String cucId)
        {
            DataTable dt;
            dgvToxi.Rows.Clear();
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
                dgvToxi.RowCount = dt.Rows.Count;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //dgvToxi[colToxiRow, i].Value = (i + 1);
                    dgvToxi[colToxiRow, i].Value = dt.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                    dgvToxi[colToxiName, i].Value = dt.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                    dgvToxi[colToxiLead, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeShortLongLeft].ToString();
                    dgvToxi[colToxiAluminium, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeShortLongRight].ToString();
                    dgvToxi[colToxiCadmium, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeSquintLeft].ToString();
                    dgvToxi[colToxiMercury, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeSquintRight].ToString();
                    dgvToxi[colToxiTin, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeDegreeLeft].ToString();
                    dgvToxi[colToxiCopper, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeDegreeRight].ToString();
                    dgvToxi[colToxiManganese, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeOldLeft].ToString();
                    dgvToxi[colToxiZinc, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeOldRight].ToString();
                    dgvToxi[colToxiAmmonia, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeBlindness].ToString();

                    dgvToxi[colToxiHippuric, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeResult].ToString();
                    dgvToxi[colToxiMethyl, i].Value = dt.Rows[i][cc.ccpdb.ccp.EyeSummary].ToString();
                    dgvToxi[colToxiAcetone, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram3000R].ToString();
                    dgvToxi[colToxiNickel, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram4000R].ToString();
                    dgvToxi[colToxiChromium, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram6000R].ToString();
                    dgvToxi[colToxiPhenol, i].Value = dt.Rows[i][cc.ccpdb.ccp.Audiogram8000R].ToString();
                    dgvToxi[colToxiKetone, i].Value = dt.Rows[i][cc.ccpdb.ccp.AudiogramSummaryR].ToString();
                    dgvToxi[colToxiBenzene, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiMandelic, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiMethanol, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiEthanol, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiIPA, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiArsenic, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiHexane, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiFomaldehyde, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiTrichloroethylene, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiAntimony, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    dgvToxi[colToxiFluoride, i].Value = dt.Rows[i][cc.ccpdb.ccp.Id].ToString();
                    
                    if ((i % 2) != 0)
                    {
                        dgvToxi.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
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
            //cuc.CommitCheckUpDate = cc.cf.datetoDB(dtpCheckUpDate.Value);
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            String prefix = "", firstName = "", lastName = "", department="";
            int rowCount = xlRange.Rows.Count, row = 0;
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
                    if (ei.SfStatusName.Equals("A"))
                    {
                        if (xlRange.Cells[i, int.Parse(ei.SfAPrefix)].Value2 != null)
                        {
                            prefix = xlRange.Cells[i, int.Parse(ei.SfAPrefix)].Value2.ToString();
                        }
                        else
                        {
                            prefix = "";
                        }
                        prefix = prefix.Trim();
                        if (prefix.Equals("นาย"))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("นาย."))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("น.ส."))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("น.ส"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("นส"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("นส."))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("นาง"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("Mr."))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("Mrs."))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("Mr"))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("Miss"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.IndexOf("หญิง")>=0)
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else
                        {
                            sexId = "3";
                            ccp.SexName = "ไม่ระบุ";
                        }
                        ccp.fSexId = sexId;
                        if (xlRange.Cells[i, int.Parse(ei.SfAFirstName)].Value2 != null)
                        {
                            firstName = xlRange.Cells[i, int.Parse(ei.SfAFirstName)].Value2.ToString();
                        }
                        else
                        {
                            firstName = "";
                            continue;
                        }
                        if (xlRange.Cells[i, int.Parse(ei.SfALastName)].Value2 != null)
                        {
                            lastName = xlRange.Cells[i, int.Parse(ei.SfALastName)].Value2.ToString();
                        }
                        else
                        {
                            lastName = "";
                        }
                        if (xlRange.Cells[i, int.Parse(ei.SfANo)].Value2 != null)
                        {
                            ccp.rowNumber = xlRange.Cells[i, int.Parse(ei.SfANo)].Value2.ToString();
                        }
                        else
                        {
                            ccp.rowNumber = "";
                        }
                        if (xlRange.Cells[i, int.Parse(ei.SfAAge)].Value2 != null)
                        {
                            ccp.patientAge = xlRange.Cells[i, int.Parse(ei.SfAAge)].Value2.ToString();
                        }
                        else
                        {

                        }
                        ccp.patientFullname = prefix + " " + firstName + " " + lastName;
                    }
                    else if (ei.SfStatusName.Equals("B"))
                    {
                        if (xlRange.Cells[i, int.Parse(ei.SfBPrefix)].Value2 != null)
                        {
                            prefix = xlRange.Cells[i, int.Parse(ei.SfBPrefix)].Value2.ToString();
                        }
                        else
                        {
                            prefix = "";
                        }
                        prefix = prefix.Trim();
                        if (prefix.Equals("นาย"))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("นาย."))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("น.ส."))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("น.ส"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("นส"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("นส."))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("นาง"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("Mr."))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("Mrs."))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else if (prefix.Equals("Mr"))
                        {
                            sexId = "1";
                            ccp.SexName = "ชาย";
                        }
                        else if (prefix.Equals("Miss"))
                        {
                            sexId = "2";
                            ccp.SexName = "หญิง";
                        }
                        else
                        {
                            sexId = "3";
                            ccp.SexName = "ไม่ระบุ";
                        }
                        ccp.fSexId = sexId;
                        if (xlRange.Cells[i, int.Parse(ei.SfBFullName)].Value2 != null)
                        {
                            firstName = xlRange.Cells[i, int.Parse(ei.SfBFullName)].Value2.ToString();
                        }
                        else
                        {
                            firstName = "";
                            continue;
                        }
                        //if (xlRange.Cells[i, int.Parse(ei.SfALastName)].Value2 != null)
                        //{
                        //    lastName = xlRange.Cells[i, int.Parse(ei.SfALastName)].Value2.ToString();
                        //}
                        //else
                        //{
                        //    lastName = "";
                        //}
                        if (xlRange.Cells[i, int.Parse(ei.SfBNo)].Value2 != null)
                        {
                            ccp.rowNumber = xlRange.Cells[i, int.Parse(ei.SfBNo)].Value2.ToString();
                        }
                        else
                        {
                            ccp.rowNumber = "";
                        }
                        if (xlRange.Cells[i, int.Parse(ei.SfBAge)].Value2 != null)
                        {
                            ccp.patientAge = xlRange.Cells[i, int.Parse(ei.SfBAge)].Value2.ToString();
                        }
                        else
                        {

                        }
                        ccp.patientFullname = prefix + " " + firstName ;
                    }
                    else if (ei.SfStatusName.Equals("C"))
                    {
                        //if (xlRange.Cells[i, int.Parse(ei.SfBPrefix)].Value2 != null)
                        //{
                        //    prefix = xlRange.Cells[i, int.Parse(ei.SfBPrefix)].Value2.ToString();
                        //}
                        //else
                        //{
                        //    prefix = "";
                        //}
                        //prefix = prefix.Trim();
                        
                        if (xlRange.Cells[i, int.Parse(ei.SfCFullName)].Value2 != null)
                        {
                            firstName = xlRange.Cells[i, int.Parse(ei.SfCFullName)].Value2.ToString();
                            if (firstName.IndexOf("นาย")>=0)
                            {
                                sexId = "1";
                                ccp.SexName = "ชาย";
                            }
                            else if (firstName.IndexOf("นาย.") >= 0)
                            {
                                sexId = "1";
                                ccp.SexName = "ชาย";
                            }
                            else if (firstName.IndexOf("น.ส.") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else if (firstName.IndexOf("น.ส") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else if (firstName.IndexOf("นส") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else if (firstName.IndexOf("นส.") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else if (firstName.IndexOf("นาง") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else if (firstName.IndexOf("Mr.") >= 0)
                            {
                                sexId = "1";
                                ccp.SexName = "ชาย";
                            }
                            else if (firstName.IndexOf("Mrs.") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else if (firstName.IndexOf("Mr") >= 0)
                            {
                                sexId = "1";
                                ccp.SexName = "ชาย";
                            }
                            else if (firstName.IndexOf("Miss") >= 0)
                            {
                                sexId = "2";
                                ccp.SexName = "หญิง";
                            }
                            else
                            {
                                sexId = "3";
                                ccp.SexName = "ไม่ระบุ";
                            }
                            ccp.fSexId = sexId;
                            
                        }
                        else
                        {
                            firstName = "";
                            continue;
                        }
                        //if (xlRange.Cells[i, int.Parse(ei.SfALastName)].Value2 != null)
                        //{
                        //    lastName = xlRange.Cells[i, int.Parse(ei.SfALastName)].Value2.ToString();
                        //}
                        //else
                        //{
                        //    lastName = "";
                        //}
                        if (xlRange.Cells[i, int.Parse(ei.SfCNo)].Value2 != null)
                        {
                            ccp.rowNumber = xlRange.Cells[i, int.Parse(ei.SfCNo)].Value2.ToString();
                        }
                        else
                        {
                            ccp.rowNumber = "";
                        }
                        if (xlRange.Cells[i, int.Parse(ei.SfCAge)].Value2 != null)
                        {
                            ccp.patientAge = xlRange.Cells[i, int.Parse(ei.SfCAge)].Value2.ToString();
                        }
                        else
                        {

                        }
                        ccp.patientFullname = firstName;
                    }

                    if (xlRange.Cells[i, int.Parse(ei.DepartmentName)].Value2 != null)
                    {
                        ccp.departmentName = xlRange.Cells[i, int.Parse(ei.DepartmentName)].Value2.ToString();
                    }
                    else
                    {
                        ccp.departmentName = "";
                    }
                    

                    cc.ccpdb.InsertCustCheckUpPatient1(ccp);
                    row++;
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
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            cc.cucdb.updateCntImport(cucId, rowCount, row);
            Cursor.Current = cursor;
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (flagNew)
            {
                String cucId = ImportExcel();
                txtId.Text = cucId;
                setGrdPE(cucId);
            }
            else
            {

            }
            Cursor.Current = cursor;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {            
            ofd.ShowDialog();
            //Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //object misval = System.Reflection.Missing.Value;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            fileName = ofd.FileName;
            Cursor.Current = cursor;
            btnImport.Enabled = true;
        }

        private void ChkUnActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;
            }
            else if (ChkUnActive.Checked)
            {
                btnUnActive.Visible = true;
            }

        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                btnUnActive.Visible = false;
            }
            else if (ChkUnActive.Checked)
            {
                btnUnActive.Visible = true;
            }
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNamePE);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row=0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.PENo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.PENo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEWeight)].Value2 != null)
                {
                    weight = xlRange.Cells[i, int.Parse(ei.PEWeight)].Value2.ToString();
                }
                else
                {
                    weight = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEHeight)].Value2 != null)
                {
                    height = xlRange.Cells[i, int.Parse(ei.PEHeight)].Value2.ToString();
                }
                else
                {
                    height = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEBMI)].Value2 != null)
                {
                    bmi = xlRange.Cells[i, int.Parse(ei.PEBMI)].Value2.ToString();
                }
                else
                {
                    bmi = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEVitalSign)].Value2 != null)
                {
                    vitalSign = xlRange.Cells[i, int.Parse(ei.PEVitalSign)].Value2.ToString();
                }
                else
                {
                    vitalSign = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEPulse)].Value2 != null)
                {
                    pulse = xlRange.Cells[i, int.Parse(ei.PEPulse)].Value2.ToString();
                }
                else
                {
                    pulse = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEBloodGroup)].Value2 != null)
                {
                    bloodgroup = xlRange.Cells[i, int.Parse(ei.PEBloodGroup)].Value2.ToString();
                }
                else
                {
                    bloodgroup = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PEResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.PEResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.PESummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.PESummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }
                chk = cc.ccpdb.UpdatePE(rowNumber, txtId.Text, vitalSign, height, weight, string.Format("{0:f2}", Double.Parse(cc.cf.NumberNull1(bmi))), pulse, result, summary, bloodgroup);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            pB1.Visible = false;
            cc.cucdb.updatePEImport(txtId.Text, rowCount- int.Parse(nmDRow.Value.ToString()), row , normal);
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdPE(txtId.Text);
            txtPESucess.Text = row.ToString();
            txtPECntEmp.Text = String.Concat(rowCount - int.Parse(nmDRow.Value.ToString()));
            txtPECntNormal.Text = normal.ToString();
            Cursor.Current = cursor;
        }

        private void btnXrayImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "";

            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameXray);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            //for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            for (int i = int.Parse(ei.XrayRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.XrayNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.XrayNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Xray)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.Xray)].Value2.ToString();
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.XraySummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.XraySummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateXray(rowNumber, txtId.Text, result, summary);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdXray(txtId.Text);
            cc.cucdb.updateXrayImport(txtId.Text, rowCount-int.Parse(nmDRow.Value.ToString()), row);
            txtXrayCntEmp.Text = rowCount.ToString();
            txtXraySucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void btnFBSImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value="";

            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameFBS);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            //for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            for (int i = int.Parse(ei.FBSRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.FBSNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.FBSNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.FBS)].Value2 != null)
                {
                    value = xlRange.Cells[i, int.Parse(ei.FBS)].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.FBSResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.FBSResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.FBSSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.FBSSummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateFBS(rowNumber, txtId.Text, value, result, summary, "");
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdFBS(txtId.Text);
            cc.cucdb.updateFBSImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row, normal);
            txtFBSCntEmp.Text = String.Concat(rowCount - int.Parse(nmDRow.Value.ToString()));
            txtFBSSucess.Text = row.ToString();
            txtFBSNormal.Text = normal.ToString();
            Cursor.Current = cursor;
        }

        private void btnCBCImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", wbc = "", rbc = "", hb = "", hct="", neu="", lym="", mch="", mchc="", mvc="", mono="", plaC="", rbcmono="";
            String summary = "", eos="", bas="", plaS="";
            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameCBC);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            //for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            for (int i = int.Parse(ei.CBCRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.CBCNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.CBCNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCHb)].Value2 != null)
                {
                    hb = xlRange.Cells[i, int.Parse(ei.CBCHb)].Value2.ToString();
                }
                else
                {
                    hb = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCWBC)].Value2 != null)
                {
                    wbc = xlRange.Cells[i, int.Parse(ei.CBCWBC)].Value2.ToString();
                }
                else
                {
                    wbc = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCRBC)].Value2 != null)
                {
                    rbc = xlRange.Cells[i, int.Parse(ei.CBCRBC)].Value2.ToString();
                }
                else
                {
                    rbc = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCHct)].Value2 != null)
                {
                    hct = xlRange.Cells[i, int.Parse(ei.CBCHct)].Value2.ToString();
                }
                else
                {
                    hct = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCNeu)].Value2 != null)
                {
                    neu = xlRange.Cells[i, int.Parse(ei.CBCNeu)].Value2.ToString();
                }
                else
                {
                    neu = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCLy)].Value2 != null)
                {
                    lym = xlRange.Cells[i, int.Parse(ei.CBCLy)].Value2.ToString();
                }
                else
                {
                    lym = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCMono)].Value2 != null)
                {
                    mono = xlRange.Cells[i, int.Parse(ei.CBCMono)].Value2.ToString();
                }
                else
                {
                    mono = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCEos)].Value2 != null)
                {
                    eos = xlRange.Cells[i, int.Parse(ei.CBCEos)].Value2.ToString();
                }
                else
                {
                    eos = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCBact)].Value2 != null)
                {
                    bas = xlRange.Cells[i, int.Parse(ei.CBCBact)].Value2.ToString();
                }
                else
                {
                    bas = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCPltC)].Value2 != null)
                {
                    plaC = xlRange.Cells[i, int.Parse(ei.CBCPltC)].Value2.ToString();
                }
                else
                {
                    plaC = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCPltS)].Value2 != null)
                {
                    plaS = xlRange.Cells[i, int.Parse(ei.CBCPltS)].Value2.ToString();
                }
                else
                {
                    plaS = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCRBCmono)].Value2 != null)
                {
                    rbcmono = xlRange.Cells[i, int.Parse(ei.CBCRBCmono)].Value2.ToString();
                }
                else
                {
                    rbcmono = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.CBCSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.CBCSummary)].Value2.ToString();
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
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdCBC(txtId.Text);
            cc.cucdb.updateCBCImport(txtId.Text, rowCount- int.Parse(nmDRow.Value.ToString()), row );
            txtCBCCntEmp.Text = rowCount.ToString();
            txtCBCSucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void btnUAImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", Color = "", Appe = "", Sugar = "", spgr = "", pH = "", Protein = "", Wbc = "", Rbc = "", Epi = "", Bact = "", Result = "", Summary = "";
            //String summary = "", eos = "", bas = "", plaS = "";
            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameUA);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            //xlWorkbook.
            //for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            for (int i = int.Parse(ei.UARow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.UANo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.UANo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UASugar)].Value2 != null)
                {
                    Sugar = xlRange.Cells[i, int.Parse(ei.UASugar)].Value2.ToString();
                }
                else
                {
                    Sugar = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UAColor)].Value2 != null)
                {
                    Color = xlRange.Cells[i, int.Parse(ei.UAColor)].Value2.ToString();
                }
                else
                {
                    Color = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UAAppe)].Value2 != null)
                {
                    Appe = xlRange.Cells[i, int.Parse(ei.UAAppe)].Value2.ToString();
                }
                else
                {
                    Appe = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UASpgr)].Value2 != null)
                {
                    spgr = xlRange.Cells[i, int.Parse(ei.UASpgr)].Value2.ToString();
                }
                else
                {
                    spgr = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UApH)].Value2 != null)
                {
                    pH = xlRange.Cells[i, int.Parse(ei.UApH)].Value2.ToString();
                }
                else
                {
                    pH = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UAProtein)].Value2 != null)
                {
                    Protein = xlRange.Cells[i, int.Parse(ei.UAProtein)].Value2.ToString();
                }
                else
                {
                    Protein = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UAWBC)].Value2 != null)
                {
                    Wbc = xlRange.Cells[i, int.Parse(ei.UAWBC)].Value2.ToString();
                }
                else
                {
                    Wbc = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UARBC)].Value2 != null)
                {
                    Rbc = xlRange.Cells[i, int.Parse(ei.UARBC)].Value2.ToString();
                }
                else
                {
                    Rbc = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UAEpi)].Value2 != null)
                {
                    Epi = xlRange.Cells[i, int.Parse(ei.UAEpi)].Value2.ToString();
                }
                else
                {
                    Epi = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UABact)].Value2 != null)
                {
                    Bact = xlRange.Cells[i, int.Parse(ei.UABact)].Value2.ToString();
                }
                else
                {
                    Bact = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UAResult)].Value2 != null)
                {
                    Result = xlRange.Cells[i, int.Parse(ei.UAResult)].Value2.ToString();
                    if (Result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    Result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UASummary)].Value2 != null)
                {
                    Summary = xlRange.Cells[i, int.Parse(ei.UASummary)].Value2.ToString();
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
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdUA(txtId.Text);
            cc.cucdb.updateUAImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row, normal);
            txtUACntEmp.Text = rowCount.ToString();
            txtUASucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void btnTriImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value = "";

            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameTri);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.TriNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.TriNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Triglyceride)].Value2 != null)
                {
                    value = xlRange.Cells[i, int.Parse(ei.Triglyceride)].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.TriResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.TriResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.TriSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.TriSummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateTrigly(rowNumber, txtId.Text, value, result, summary);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdTri(txtId.Text);
            cc.cucdb.updateTriImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row, normal);
            txtTriCntEmp.Text = rowCount.ToString();
            txtTriSucess.Text = row.ToString();
            Cursor.Current = cursor;
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameCho);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.ChoRow); i <= rowCount; i++)
            //for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.ChoNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.ChoNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Cholesteral)].Value2 != null)
                {
                    value = xlRange.Cells[i, int.Parse(ei.Cholesteral)].Value2.ToString();
                }
                else
                {
                    value = "";
                }

                if (xlRange.Cells[i, int.Parse(ei.ChoLDL)].Value2 != null)
                {
                    ldl = xlRange.Cells[i, int.Parse(ei.ChoLDL)].Value2.ToString();
                }
                else
                {
                    ldl = "";
                } if (xlRange.Cells[i, int.Parse(ei.ChoHDL)].Value2 != null)
                {
                    hdl = xlRange.Cells[i, int.Parse(ei.ChoHDL)].Value2.ToString();
                }
                else
                {
                    hdl = "";
                }

                if (xlRange.Cells[i, int.Parse(ei.ChoResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.ChoResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Chosummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.Chosummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }


                chk = cc.ccpdb.UpdateCholes(rowNumber, txtId.Text, value, result, summary, ldl,hdl);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdCholes(txtId.Text);
            cc.cucdb.updateChoImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row, normal);
            txtChoCntEmp.Text = rowCount.ToString();
            txtChoSucess.Text = row.ToString();
            Cursor.Current = cursor;
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameSgot);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            //for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            for (int i = int.Parse(ei.SgotRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.SgotNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.SgotNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Sgot)].Value2 != null)
                {
                    sgot = xlRange.Cells[i, int.Parse(ei.Sgot)].Value2.ToString();
                }
                else
                {
                    sgot = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Sgpt)].Value2 != null)
                {
                    sgpt = xlRange.Cells[i, int.Parse(ei.Sgpt)].Value2.ToString();
                }
                else
                {
                    sgpt = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Sgpt)].Value2 != null)
                {
                    alt = xlRange.Cells[i, int.Parse(ei.Sgpt)].Value2.ToString();
                }
                else
                {
                    alt = "";
                }
                if (xlRange.Cells[i,int.Parse(ei.SgotResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.SgotResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.SgptSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.SgptSummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateSgot(rowNumber, txtId.Text, sgot, sgpt, alt, result, summary);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdSgot(txtId.Text);
            cc.cucdb.updateSgotImport(txtId.Text, rowCount- int.Parse(nmDRow.Value.ToString()), row , normal);
            txtSgotCntEmp.Text = rowCount.ToString();
            txtSgotSucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void btnBunImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", bun = "", creatinine = "";

            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameBun);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i,int.Parse(ei.BunNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.BunNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.Bun)].Value2 != null)
                {
                    bun = xlRange.Cells[i, int.Parse(ei.Bun)].Value2.ToString();
                }
                else
                {
                    bun = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.BunCreatinine)].Value2 != null)
                {
                    creatinine = xlRange.Cells[i, int.Parse(ei.BunCreatinine)].Value2.ToString();
                }
                else
                {
                    creatinine = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.BunResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.BunResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.BunSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.BunSummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateBun(rowNumber, txtId.Text, bun, creatinine, result, summary);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdBun(txtId.Text);
            cc.cucdb.updateBunImport(txtId.Text, rowCount- int.Parse(nmDRow.Value.ToString()), row ,normal);
            txtBunCntEmp.Text = rowCount.ToString();
            txtBunSucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void btnUricImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "", result = "", summary = "", value = "";

            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameUric);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0, normal=0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(nmDRow.Value.ToString()); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.UricNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.UricNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UricAcid)].Value2 != null)
                {
                    value = xlRange.Cells[i, int.Parse(ei.UricAcid)].Value2.ToString();
                }
                else
                {
                    value = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UricResult)].Value2 != null)
                {
                    result = xlRange.Cells[i, int.Parse(ei.UricResult)].Value2.ToString();
                    if (result.Equals("ปกติ"))
                    {
                        normal++;
                    }
                }
                else
                {
                    result = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.UricSummary)].Value2 != null)
                {
                    summary = xlRange.Cells[i, int.Parse(ei.UricSummary)].Value2.ToString();
                }
                else
                {
                    summary = "";
                }

                chk = cc.ccpdb.UpdateUric(rowNumber, txtId.Text, value, result, summary);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdUric(txtId.Text);
            cc.cucdb.updateUricImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row, normal);
            txtUricCntEmp.Text = rowCount.ToString();
            txtUricSucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmExcelInit frm = new FrmExcelInit(cc,"");
            frm.ShowDialog(this);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            RCheckUp rc = new RCheckUp();

            //CBC wbc
            String[] cbcwbc = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcWbc].ToString().Split('@');
            int cbcwbcMin = 0, cbcwbcMax = 0;
            String cbcwbcUnit = "";
            if (cbcwbc.Length == 2)
            {
                String[] aa = cbcwbc[0].ToString().Split('-');
                cbcwbcMin = int.Parse(aa[0]);
                cbcwbcMax = int.Parse(aa[1]);
                cbcwbcUnit = cbcwbc[1];
            }
            //CBC Hb male
            String[] cbchbmale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHbMale].ToString().Split('@');
            int cbchbmaleMin = 0, cbchbmaleMax = 0;
            String cbchbmaleUnit = "";
            if (cbchbmale.Length == 2)
            {
                String[] aa = cbchbmale[0].ToString().Split('-');
                cbchbmaleMin = int.Parse(aa[0]);
                cbchbmaleMax = int.Parse(aa[1]);
                cbchbmaleUnit = cbchbmale[1];
            }
            //CBC Hb female
            String[] cbchbfemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHbFemale].ToString().Split('@');
            int cbchbfemaleMin = 0, cbchbfemaleMax = 0;
            String cbchbfemaleUnit = "";
            if (cbchbfemale.Length == 2)
            {
                String[] aa = cbchbfemale[0].ToString().Split('-');
                cbchbfemaleMin = int.Parse(aa[0]);
                cbchbfemaleMax = int.Parse(aa[1]);
                cbchbfemaleUnit = cbchbfemale[1];
            }
            //CBC Hct male
            String[] cbchctmale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHctMale].ToString().Split('@');
            int cbchctmaleMin = 0, cbchctmaleMax = 0;
            String cbchctmaleUnit = "";
            if (cbchctmale.Length == 2)
            {
                String[] aa = cbchctmale[0].ToString().Split('-');
                cbchctmaleMin = int.Parse(aa[0]);
                cbchctmaleMax = int.Parse(aa[1]);
                cbchctmaleUnit = cbchctmale[1];
            }
            //CBC Hct female
            String[] cbchctfemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHctFemale].ToString().Split('@');
            int cbchctfemaleMin = 0, cbchctfemaleMax = 0;
            String cbchctfemaleUnit = "";
            if (cbchctfemale.Length == 2)
            {
                String[] aa = cbchctfemale[0].ToString().Split('-');
                cbchctfemaleMin = int.Parse(aa[0]);
                cbchctfemaleMax = int.Parse(aa[1]);
                cbchctfemaleUnit = cbchctfemale[1];
            }
            //CBC mcv male
            String[] cbcmcvmale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcvMale].ToString().Split('@');
            Double cbcmcvmaleMin = 0, cbcmcvmaleMax = 0;
            String cbcmcvmaleUnit = "";
            if (cbcmcvmale.Length == 2)
            {
                String[] aa = cbcmcvmale[0].ToString().Split('-');
                cbcmcvmaleMin = Double.Parse(aa[0]);
                cbcmcvmaleMax = Double.Parse(aa[1]);
                cbcmcvmaleUnit = cbcmcvmale[1];
            }
            //CBC mcv female
            String[] cbcmcvfemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcvFemale].ToString().Split('@');
            Double cbcmcvfemaleMin = 0, cbcmcvfemaleMax = 0;
            String cbcmcvfemaleUnit = "";
            if (cbcmcvfemale.Length == 2)
            {
                String[] aa = cbcmcvfemale[0].ToString().Split('-');
                cbcmcvfemaleMin = Double.Parse(aa[0]);
                cbcmcvfemaleMax = Double.Parse(aa[1]);
                cbcmcvfemaleUnit = cbcmcvfemale[1];
            }
            //CBC mch
            String[] cbcmch = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMch].ToString().Split('@');
            Double cbcmchMin = 0, cbcmchMax = 0;
            String cbcmchUnit = "";
            if (cbcmch.Length == 2)
            {
                String[] aa = cbcmch[0].ToString().Split('-');
                cbcmchMin = Double.Parse(aa[0]);
                cbcmchMax = Double.Parse(aa[1]);
                cbcmchUnit = cbcmch[1];
            }
            //CBC mchc
            String[] cbcmchc = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMchc].ToString().Split('@');
            Double cbcmchcMin = 0, cbcmchcMax = 0;
            String cbcmchcUnit = "";
            if (cbcmchc.Length == 2)
            {
                String[] aa = cbcmchc[0].ToString().Split('-');
                cbcmchcMin = Double.Parse(aa[0]);
                cbcmchcMax = Double.Parse(aa[1]);
                cbcmchcUnit = cbcmchc[1];
            }
            //CBC rbc male
            String[] cbcrbcmale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMale].ToString().Split('@');
            Double cbcrbcmaleMin = 0, cbcrbcmaleMax = 0;
            String cbcrbcmaleUnit = "";
            if (cbcrbcmale.Length == 2)
            {
                String[] aa = cbcrbcmale[0].ToString().Split('-');
                cbcrbcmaleMin = Double.Parse(aa[0]);
                cbcrbcmaleMax = Double.Parse(aa[1]);
                cbcrbcmaleUnit = cbcrbcmale[1];
            }
            //CBC rbc female
            String[] cbcrbcfemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcFemale].ToString().Split('@');
            Double cbcrbcfemaleMin = 0, cbcrbcfemaleMax = 0;
            String cbcrbcfemaleUnit = "";
            if (cbcrbcfemale.Length == 2)
            {
                String[] aa = cbcrbcfemale[0].ToString().Split('-');
                cbcrbcfemaleMin = Double.Parse(aa[0]);
                cbcrbcfemaleMax = Double.Parse(aa[1]);
                cbcrbcfemaleUnit = cbcrbcfemale[1];
            }
            //CBC lym
            String[] cbclym = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcLymphocyte].ToString().Split('@');
            int cbclymMin = 0, cbclymMax = 0;
            String cbclymUnit = "";
            if (cbclym.Length == 2)
            {
                String[] aa = cbclym[0].ToString().Split('-');
                cbclymMin = int.Parse(aa[0]);
                cbclymMax = int.Parse(aa[1]);
                cbclymUnit = cbclym[1];
            }
            //CBC mono
            String[] cbcmono = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMonocyte].ToString().Split('@');
            int cbcmonoMin = 0, cbcmonoMax = 0;
            String cbcmonoUnit = "";
            if (cbcmono.Length == 2)
            {
                String[] aa = cbcmono[0].ToString().Split('-');
                cbcmonoMin = int.Parse(aa[0]);
                cbcmonoMax = int.Parse(aa[1]);
                cbcmonoUnit = cbcmono[1];
            }
            //CBC eos
            String[] cbceos = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcEosinophil].ToString().Split('@');
            int cbceosMin = 0, cbceosMax = 0;
            String cbceosUnit = "";
            if (cbceos.Length == 2)
            {
                String[] aa = cbceos[0].ToString().Split('-');
                cbceosMin = int.Parse(aa[0]);
                cbceosMax = int.Parse(aa[1]);
                cbceosUnit = cbceos[1];
            }
            //CBC bas
            String[] cbcbas = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcBasophil].ToString().Split('@');
            int cbcbasMin = 0, cbcbasMax = 0;
            String cbcbasUnit = "";
            if (cbcbas.Length == 2)
            {
                String[] aa = cbcbas[0].ToString().Split('-');
                cbcbasMin = int.Parse(aa[0]);
                cbcbasMax = int.Parse(aa[1]);
                cbcbasUnit = cbcbas[1];
            }
            //CBC pltc
            String[] cbcpltc = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletCount].ToString().Split('@');
            Double cbcpltcMin = 0, cbcpltcMax = 0;
            String cbcpltcUnit = "";
            if (cbcpltc.Length == 2)
            {
                String[] aa = cbcpltc[0].ToString().Split('-');
                cbcpltcMin = Double.Parse(aa[0]);
                cbcpltcMax = Double.Parse(aa[1]);
                cbcpltcUnit = cbcpltc[1];
            }
            //CBC neu
            String[] cbcneu = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcNeutrophil].ToString().Split('@');
            Double cbcneuMin = 0, cbcneuMax = 0;
            String cbcneuUnit = "";
            if (cbcneu.Length == 2)
            {
                String[] aa = cbcneu[0].ToString().Split('-');
                cbcneuMin = Double.Parse(aa[0]);
                cbcneuMax = Double.Parse(aa[1]);
                cbcneuUnit = cbcneu[1];
            }
            ////CBC plts
            String cbcplts = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletSmear].ToString();
            //CBC rbc mono
            String cbcrbcmono = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMorpholog].ToString();
            //String[] plts = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletSmear].ToString().Split('@');
            //int pltsMin = 0, pltsMax = 0;
            //String pltsUnit = "";
            //if (mchc.Length == 2)
            //{
            //    String[] aa = plts[0].ToString().Split('-');
            //    pltsMin = int.Parse(aa[0]);
            //    pltsMax = int.Parse(aa[1]);
            //    pltsUnit = plts[1];
            //}

            //FBS
            String[] fbs = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString().Split('@');
            int fbsMin = 0, fbsMax = 0;            
            String fbsUnit = "";
            if (fbs.Length == 2)
            {
                String[] aa = fbs[0].ToString().Split('-');
                fbsMin = int.Parse(aa[0]);
                fbsMax = int.Parse(aa[1]);
                fbsUnit = fbs[1];
            }
            //Trigy
            String[] tri = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.triglyceride].ToString().Split('@');
            int triMax = 0;
            String triUnit = "";
            if (tri.Length == 2)
            {
                String[] aa = tri[0].ToString().Split('<');
                triMax = int.Parse(aa[1]);
                //fbsMax = int.Parse(aa[1]);
                triUnit = tri[1];
            }
            //Choles
            String[] choles = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cholesterol].ToString().Split('@');
            int cholesMax = 0;
            String cholesUnit = "";
            if (choles.Length == 2)
            {
                String[] aa = choles[0].ToString().Split('<');
                cholesMax = int.Parse(aa[1]);
                //fbsMax = int.Parse(aa[1]);
                cholesUnit = choles[1];
            }
            //Sgot
            String[] sgot = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString().Split('@');
            int sgotMin = 0, sgotMax = 0;  
            String sgotUnit = "";
            if (sgot.Length == 2)
            {
                String[] aa = sgot[0].ToString().Split('-');
                sgotMin = int.Parse(aa[0]);
                sgotMax = int.Parse(aa[1]);
                sgotUnit = sgot[1];
            }
            String[] sgpt = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.liverSgot].ToString().Split('@');
            int sgptMin = 0, sgptMax = 0;
            String sgptUnit = "";
            if (sgpt.Length == 2)
            {
                String[] aa = sgpt[0].ToString().Split('-');
                sgptMin = int.Parse(aa[0]);
                sgptMax = int.Parse(aa[1]);
                sgptUnit = sgpt[1];
            }
            //Bun Male
            String[] bunMale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString().Split('@');
            Double bunMaleMin = 0, bunMaleMax = 0;
            String bunMaleUnit = "";
            if (bunMale.Length == 2)
            {
                String[] aa = bunMale[0].ToString().Split('-');
                bunMaleMin = Double.Parse(aa[0]);
                bunMaleMax = Double.Parse(aa[1]);
                bunMaleUnit = bunMale[1];
            }
            //Bun FeMale
            String[] bunFemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunFemale].ToString().Split('@');
            Double bunFemaleMin = 0, bunFemaleMax = 0;
            String bunFemaleUnit = "";
            if (bunFemale.Length == 2)
            {
                String[] aa = bunFemale[0].ToString().Split('-');
                bunFemaleMin = Double.Parse(aa[0]);
                bunFemaleMax = Double.Parse(aa[1]);
                bunFemaleUnit = bunFemale[1];
            }
            //Bun Creatinine Male
            String[] creatinineMale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString().Split('@');
            Double creatinineMaleMin = 0, creatinineMaleMax = 0;
            String creatininenMaleUnit = "";
            if (creatinineMale.Length == 2)
            {
                String[] aa = creatinineMale[0].ToString().Split('-');
                creatinineMaleMin = Double.Parse(aa[0]);
                creatinineMaleMax = Double.Parse(aa[1]);
                creatininenMaleUnit = creatinineMale[1];
            }
            //Bun Creatinine FeMale
            String[] creatinineFemale = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineFemale].ToString().Split('@');
            Double creatinineFemaleMin = 0, creatinineFemaleMax = 0;
            String creatinineFemaleUnit = "";
            if (creatinineFemale.Length == 2)
            {
                String[] aa = creatinineFemale[0].ToString().Split('-');
                creatinineFemaleMin = Double.Parse(aa[0]);
                creatinineFemaleMax = Double.Parse(aa[1]);
                creatinineFemaleUnit = creatinineFemale[1];
            }
            

            //UA Color
            String uacolor = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineColor].ToString();
            String uasugar = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSugar].ToString();
            String uaprotein = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineProtein].ToString();
            String uaappear = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineAppearance].ToString();
            //UA pH
            String[] uapH = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urinePh].ToString().Split('@');
            Double uapHMin = 0, uapHMax = 0;
            String uapHUnit = "";
            if (uapH.Length == 1)//ไม่มีหน่วย
            {
                String[] aa = uapH[0].ToString().Split('-');
                uapHMin = Double.Parse(aa[0]);
                uapHMax = Double.Parse(aa[1]);
                //uapHUnit = uapH[1];
            }
            String[] uaspgr = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSpGr].ToString().Split('@');
            Double uaspgrMin = 0, uaspgrMax = 0;
            String uaspgrUnit = "";
            if (uaspgr.Length == 1)//ไม่มีหน่วย
            {
                String[] aa = uaspgr[0].ToString().Split('-');
                uaspgrMin = Double.Parse(aa[0]);
                uaspgrMax = Double.Parse(aa[1]);
                //uaspgrUnit = uaspgr[1];
            }
            String[] uawbc = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSpGr].ToString().Split('@');
            Double uawbcMin = 0, uawbcMax = 0;
            String uawbcUnit = "";
            if (uawbc.Length == 1)//ไม่มีหน่วย
            {
                String[] aa = uaspgr[0].ToString().Split('-');
                uawbcMin = Double.Parse(aa[0]);
                uawbcMax = Double.Parse(aa[1]);
                //uaspgrUnit = uawbc[1];
            }
            String[] uaepi = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.urineSpGr].ToString().Split('@');
            Double uaepiMin = 0, uaepiMax = 0;
            String uaepiUnit = "";
            if (uaepi.Length == 1)//ไม่มีหน่วย
            {
                String[] aa = uaspgr[0].ToString().Split('-');
                uaepiMin = Double.Parse(aa[0]);
                uaepiMax = Double.Parse(aa[1]);
                //uaspgrUnit = uaepi[1];
            }
            //Double creatinineFemaleMin = 0, creatinineFemaleMax = 0;
            //String uacolorUnit = "";
            //if (uacolor.Length == 2)
            //{
            //    String[] aa = uacolor[0].ToString().Split('-');
            //    creatinineFemaleMin = Double.Parse(aa[0]);
            //    creatinineFemaleMax = Double.Parse(aa[1]);
            //    uacolorUnit = uacolor[1];
            //}

            int row = 0;
            label85.Text = System.DateTime.Now.ToShortTimeString();
            pB1.Visible = true;
            pB1.Minimum = 0;
            cc.lw.WriteLog("FrmCheckUPAdd.btnPrint_Click 01 ");
            cc.rcdb.deleteAll();
            dtAll = cc.ccpdb.selectAllByCucId(cuc.Id);
            cuc = cc.cucdb.selectByPk(cuc.Id);
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
                rc.Remark = "";
                rc.Id = r.Next().ToString();
                rc.FullName = dtAll.Rows[i][cc.ccpdb.ccp.patientFullname].ToString();
                rc.Sex = dtAll.Rows[i][cc.ccpdb.ccp.fSexId].ToString();
                if (dtAll.Rows[i][cc.ccpdb.ccp.patientAge].ToString().Equals("") || dtAll.Rows[i][cc.ccpdb.ccp.patientAge].ToString().Equals("0"))
                {
                    rc.Age = "-";
                }
                else
                {
                    rc.Age = dtAll.Rows[i][cc.ccpdb.ccp.patientAge].ToString();
                }

                rc.BMI = dtAll.Rows[i][cc.ccpdb.ccp.bmi].ToString();
                rc.Height = dtAll.Rows[i][cc.ccpdb.ccp.patientHeight].ToString();
                rc.Weight = dtAll.Rows[i][cc.ccpdb.ccp.patientWeight].ToString();
                rc.VitalSign = dtAll.Rows[i][cc.ccpdb.ccp.vitalsign].ToString();
                rc.Pulse = dtAll.Rows[i][cc.ccpdb.ccp.patientPulse].ToString();
                rc.RowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                rc.PESummary = dtAll.Rows[i][cc.ccpdb.ccp.summaryPhysicalExam].ToString();
                rc.CheckUpDate = cc.cf.dateDBtoShow(cuc.CheckUpDate);

                //Xray
                if (int.Parse(cuc.XraySuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "Xray";
                    rc.LabName = "Xray";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.xrayChestExam].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.xrayChestExam].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "Xray";
                    rc.Remark = "";
                    rc.StatusLab = "xray";
                    rc.Sort1 = "1009";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "Xray";
                    rc.LabName = "สรุป";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.xrayChestSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.xrayChestSummary].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "Xray";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1009";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);
                }
                //CBC
                if (int.Parse(cuc.CBCSuccess)>0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Hb";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHbMale].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcHb].ToString();
                    //rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbc].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (rc.Sex.Equals("1"))//male
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHbMale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbchbmaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbchbmaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (int.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbchbmaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        else
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHbFemale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbchbfemaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbchbfemaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbchbfemaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "10";
                    //rc.LabNormal = dtN.Rows[0][cc.ccpvndb.ccpvn.cbcHb].ToString();
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Hct";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHctMale].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcHct].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (rc.Sex.Equals("1"))//male
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHctMale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbchctmaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbchctmaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbchctmaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        else
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcHctFemale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbchctfemaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbchctfemaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbchctfemaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "WBC";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcWbc].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcWbc].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcwbcMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcwbcMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcwbcMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "13";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Neutrophils";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcNeutrophil].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcNeutrophil].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcneuMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcneuMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcneuMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "14";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Eosinophils ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcEosinophil].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcEosinophil].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbceosMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbceosMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbceosMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "15";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Basophils ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcBasophil].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcBasophil].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcbasMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcbasMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcbasMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "16";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Lymphocyte ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcLymphocyte].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcLymphocyte].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbclymMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbclymMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbclymMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "17";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Monocyte ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMonocyte].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMonocyte].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcmonoMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcmonoMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcmonoMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "18";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "RBC ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMale].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcRbc].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (rc.Sex.Equals("1"))//male
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcMale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcrbcmaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcrbcmaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcrbcmaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        else
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcRbcFemale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcrbcfemaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcrbcfemaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcrbcfemaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "19";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "MCV ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcvMale].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMcv].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (rc.Sex.Equals("1"))//male
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcvMale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcmcvmaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcmcvmaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcmcvmaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        else
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMcvFemale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcmcvfemaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcmcvfemaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcmcvfemaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "20";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "MCH ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMch].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMch].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcmchMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcmchMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcmchMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "21";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "MCHC ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcMchc].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcMchc].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcmchcMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcmchcMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcmchcMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }

                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "22";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "Platelet Count ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcPlateletCount].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcPlateletCount].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cbcpltcMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= cbcpltcMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > cbcpltcMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
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
                    if (rc.LabResult.ToLower().Equals(cbcplts.ToLower()))
                    {
                        rc.Remark = "ปกติ";
                    }
                    else
                    {
                        rc.Remark = "ผิดปกติ";
                    }
                    //rc.Remark = "";
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
                    if (rc.LabResult.ToLower().Equals(cbcrbcmono.ToLower()))
                    {
                        rc.Remark = "ปกติ";
                    }
                    else
                    {
                        rc.Remark = "ผิดปกติ";
                    }
                    //rc.Remark = "";
                    rc.StatusLab = "cbc";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "25";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ความสมบรูณ์ของเม็ดเลือด (C.B.C.)";
                    rc.LabName = "สรุป ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.cbcSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cbcSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจเลือดทั่วไป";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1010";
                    rc.Sort2 = "26";
                    cc.rcdb.insertRCheckUp(rc);
                }                

                //FBS
                if (int.Parse(cuc.FBSSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ระดับน้ำตาลในเลือด (Fasting Blood Sugar)";
                    rc.LabName = "FBS ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugar].ToString().Replace("@"," ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.sugar].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจน้ำตาล";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= fbsMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= fbsMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > fbsMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    
                    rc.StatusLab = "fbs";
                    rc.Sort1 = "1011";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "ระดับน้ำตาลในเลือด (Fasting Blood Sugar)";
                    rc.LabName = "สรุป ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.sugarSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจน้ำตาล";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1011";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);
                }                

                //UA
                if (int.Parse(cuc.UASuccess) > 0)
                {
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
                    if (rc.LabResult.ToLower().Equals(uacolor.ToLower()))
                    {
                        rc.Remark = "ปกติ";
                    }
                    else
                    {
                        rc.Remark = "ผิดปกติ";
                    }
                    //rc.Remark = "";
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
                    if (rc.LabResult.ToLower().Equals(uaappear.ToLower()))
                    {
                        rc.Remark = "ปกติ";
                    }
                    else
                    {
                        rc.Remark = "ผิดปกติ";
                    }
                    //rc.Remark = "";
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
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= uapHMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= uapHMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > uapHMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
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
                    if (rc.LabResult.ToLower().Equals(uasugar.ToLower()))
                    {
                        rc.Remark = "ปกติ";
                    }
                    else
                    {
                        rc.Remark = "ผิดปกติ";
                    }
                    //rc.Remark = "";
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
                    if (rc.LabResult.ToLower().Equals(uaprotein.ToLower()))
                    {
                        rc.Remark = "ปกติ";
                    }
                    else
                    {
                        rc.Remark = "ผิดปกติ";
                    }
                    //rc.Remark = "";
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
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= uaspgrMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= uaspgrMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > uaspgrMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
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
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= uaepiMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= uaepiMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > uaepiMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
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
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= uawbcMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= uawbcMax))
                            {
                                rc.Remark = "ปกติ";
                            }
                            else
                            {
                                if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > uawbcMax)
                                {
                                    rc.Remark = "สูงกว่ามาตรฐาน";
                                }
                                else
                                {
                                    rc.Remark = "ต่ำกว่ามาตรฐาน";
                                }
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    //rc.Remark = "";
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

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจความสมบรูณ์ของปัสสาวะ (UA)";
                    rc.LabName = "สรุป ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.urineSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจปัสสาวะ";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1012";
                    rc.Sort2 = "24";
                    cc.rcdb.insertRCheckUp(rc);
                }

                //Bun
                if (int.Parse(cuc.BunSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Bun)";
                    rc.LabName = "Bun ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.kidneyBun].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ BUN";
                    try
                    {
                        if (rc.Sex.Equals("1"))//male
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunMale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= bunMaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= bunMaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > bunMaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        else
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyBunFemale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= bunFemaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= bunFemaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > bunFemaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "ไม่ระบุเพศ";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "bun";
                    rc.Sort1 = "1013";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Bun)";
                    rc.LabName = "Creatinine ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.kidneyCreatinine].ToString(); ;
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.kidneyCreatinine].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ BUN";
                    try
                    {
                        if (rc.Sex.Equals("1"))//male
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineMale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= creatinineMaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= creatinineMaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > creatinineMaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        else
                        {
                            rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.kidneyCreatinineFemale].ToString().Replace("@", " ");
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= creatinineFemaleMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= creatinineFemaleMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > creatinineFemaleMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    //rc.Remark = "";
                    rc.StatusLab = "bun";
                    rc.Sort1 = "1013";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Bun)";
                    rc.LabName = "สรุป ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.kidneySummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ BUN";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1013";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);
                }

                //Uric
                if (int.Parse(cuc.UricSuccess) > 0)
                {
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

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Uric)";
                    rc.LabName = "สรุป ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.uricAcidSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Uric";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1012";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);
                }
                

                //Trig
                if (int.Parse(cuc.TriSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Triglyceride)";
                    rc.LabName = "Triglyceride ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.triglyceride].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.triglyceride].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Triglyceride";
                    try
                    {
                        if (int.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if (int.Parse(cc.cf.NumberNull1(rc.LabResult)) >= triMax)
                            {
                                rc.Remark = "สูงกว่าปกติ";
                            }
                            else if (int.Parse(cc.cf.NumberNull1(rc.LabResult)) < triMax)
                            {
                                rc.Remark = "ปกติ";
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }
                    
                    
                    rc.StatusLab = "tri";
                    rc.Sort1 = "1015";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Triglyceride)";
                    rc.LabName = "สรุป ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.triglycerideSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Triglyceride";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1015";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);
                }                

                //Sgot
                if (int.Parse(cuc.SgotSuccess) > 0)
                {
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
                    if (!rc.LabResult.Equals("") && !rc.LabResult.Equals("-"))
                    {
                        try
                        {
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= sgptMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= sgptMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > sgptMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                        }

                        //rc.Remark = "";
                        rc.StatusLab = "sgot";
                        rc.Sort1 = "1016";
                        rc.Sort2 = "10";
                        cc.rcdb.insertRCheckUp(rc);
                    }
                    

                    //Sgpt
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (SGOT/SGPT)";
                    rc.LabName = "SGPT ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.liverSgpt].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.liverSgpt].ToString();
                    //rc.Remark = dtAll.Rows[i][cc.ccpdb.ccp.liverSummary].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ SGPT";
                    if (!rc.LabResult.Equals("") && !rc.LabResult.Equals("-"))
                    {
                        try
                        {
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                            {
                                if ((Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= sgptMin) && (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) <= sgptMax))
                                {
                                    rc.Remark = "ปกติ";
                                }
                                else
                                {
                                    if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > sgptMax)
                                    {
                                        rc.Remark = "สูงกว่ามาตรฐาน";
                                    }
                                    else
                                    {
                                        rc.Remark = "ต่ำกว่ามาตรฐาน";
                                    }
                                }
                            }
                            else
                            {
                                rc.Remark = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                        }

                        //rc.Remark = "";
                        rc.StatusLab = "sgot";
                        rc.Sort1 = "1016";
                        rc.Sort2 = "11";
                        cc.rcdb.insertRCheckUp(rc);
                    }
                    

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (SGPT)";
                    rc.LabName = "สรุป ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.liverSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ SGPT";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1016";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);
                }
                

                //Choles
                if (int.Parse(cuc.ChoSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Cholesterol)";
                    rc.LabName = "Cholesterol ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.cholesterol].ToString().Replace("@", " ");
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cholesterol].ToString();
                    rc.Remark = dtAll.Rows[i][cc.ccpdb.ccp.cholesterolSummary].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Cholesterol";
                    try
                    {
                        if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) > 0)
                        {
                            if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) >= cholesMax)
                            {
                                rc.Remark = "สูงกว่าปกติ";
                            }
                            else if (Double.Parse(cc.cf.NumberNull1(rc.LabResult)) < cholesMax)
                            {
                                rc.Remark = "ปกติ";
                            }
                        }
                        else
                        {
                            rc.Remark = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        rc.Remark = "แปลผลไม่ได้ " + rc.LabResult;
                    }                    
                    
                    rc.StatusLab = "cho";
                    rc.Sort1 = "1017";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Cholesterol)";
                    rc.LabName = "สรุป ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.cholesterolSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Cholesterol";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1017";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);
                }

                //Other1
                if (int.Parse(cuc.Other1Success) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Other1)";
                    rc.LabName = "HBsAg ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.hbsag].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.hbsag].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ HBsAg";
                    rc.Remark = "";
                    rc.StatusLab = "other1";
                    rc.Sort1 = "1018";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Other1)";
                    rc.LabName = "HBsAb ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.hbsab].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.hbsab].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ HBsAb";
                    rc.Remark = "";
                    rc.StatusLab = "other1";
                    rc.Sort1 = "1018";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Other1)";
                    rc.LabName = "Anti HIV ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.antiHiv].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.antiHiv].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Anti HIV";
                    rc.Remark = "";
                    rc.StatusLab = "other1";
                    rc.Sort1 = "1018";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Other1)";
                    rc.LabName = "VDRL ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.vdrl].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.vdrl].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ VDRL";
                    rc.Remark = "";
                    rc.StatusLab = "other1";
                    rc.Sort1 = "1018";
                    rc.Sort2 = "13";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Other1)";
                    rc.LabName = "Amphetamine ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.amphetamine].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.amphetamine].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Amphetamine";
                    rc.Remark = "";
                    rc.StatusLab = "other1";
                    rc.Sort1 = "1018";
                    rc.Sort2 = "14";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Other1)";
                    rc.LabName = "Calcium ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.calcium].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.calcium].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Calcium";
                    rc.Remark = "";
                    rc.StatusLab = "other1";
                    rc.Sort1 = "1018";
                    rc.Sort2 = "15";
                    cc.rcdb.insertRCheckUp(rc);
                }

                //Lung
                if (int.Parse(cuc.LungSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "FvcPredic ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungFvcPredic].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungFvcPredic].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ FvcPredic";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "FvcMeas ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungFvcMeas].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungFvcMeas].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ FvcMeas";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "FvcPer ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungFvcPer].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungFvcMeas].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ FvcPer";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "Fev1Predic ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungFev1Predic].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungFvcMeas].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Fev1Predic";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "13";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "Fev1Meas ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungFev1Meas].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungFev1Meas].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Fev1Meas";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "14";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "Fev1Per ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungFev1Per].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungFev1Per].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Fev1Per";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "15";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "PerFev1 ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.lungPerFev1].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungPerFev1].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ PerFev1";
                    rc.Remark = "";
                    rc.StatusLab = "lung";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "16";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Lung)";
                    rc.LabName = "สรุป ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.lungSummary].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Lung";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1019";
                    rc.Sort2 = "17";
                    cc.rcdb.insertRCheckUp(rc);
                }

                //Audiogram
                if (int.Parse(cuc.AudioSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "500L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram500L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram500L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "500R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram500R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram500R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audoi";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "1000L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram1000L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram1000L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "1000R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram1000R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram1000R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "13";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "2000L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram2000L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram2000L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "14";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "2000R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram2000R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram2000R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "15";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "3000L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram3000L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram3000L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "16";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "3000R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram3000R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram3000R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "17";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "4000L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram4000L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram4000L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "18";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "4000R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram4000R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram4000R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "19";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "6000L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram6000L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram6000L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "20";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "6000R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram6000R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram6000R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "21";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "8000L ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram8000L].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram8000L].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "22";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "8000R ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.Audiogram8000R].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.Audiogram8000R].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "audio";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "สรุปหูซ้าย ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.AudiogramSummaryL].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "24";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (AudioGram)";
                    rc.LabName = "สรุปหูขวา ";
                    //rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.AudiogramSummaryR].ToString();
                    //rc.LabResult = "";
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ AudioGram";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1020";
                    rc.Sort2 = "25";
                    cc.rcdb.insertRCheckUp(rc);

                }
                //Eye
                if (int.Parse(cuc.EyeSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "ตา สั้น ยาว ซ้าย ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeShortLongLeft].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeShortLongLeft].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "ตา สั้น ยาว ขวา ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeShortLongRight].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeShortLongRight].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "ตา เอียง ซ้าย ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeSquintLeft].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeSquintLeft].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "ตา เอียงขวา ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeSquintRight].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeSquintRight].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "13";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "องศา ซ้าย ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeDegreeLeft].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeDegreeLeft].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "14";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "องศา ขวา ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeDegreeRight].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeDegreeRight].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "15";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "สายตาผู้สูงอายุ ซ้าย ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeOldLeft].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeOldLeft].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "16";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "สายตาผู้สูงอายุ ขวา ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeOldRight].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeOldRight].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "17";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "สายตาบอดสี ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeBlindness].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeBlindness].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "18";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "สายตาทั่วไป ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeExam].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeExam].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "eye";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "18";
                    cc.rcdb.insertRCheckUp(rc);
                    
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Eye)";
                    rc.LabName = "สรุป ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.EyeSummary].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeSummary].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Eye";
                    rc.Remark = "";
                    rc.StatusLab = "sum";
                    rc.Sort1 = "1021";
                    rc.Sort2 = "19";
                    cc.rcdb.insertRCheckUp(rc);

                    //rc.Id = r.Next().ToString();
                    //rc.LabGroup = "การตรวจ (Eye)";
                    //rc.LabName = "สรุป ";
                    ////rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpvndb.ccpvn.sugarSummary].ToString();
                    //rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.EyeSummary].ToString();
                    ////rc.LabResult = "";
                    //rc.LInter = "การแปรผล";
                    //rc.LInterAbnormal = "ปกติ";
                    //rc.LInterNormal = "ผิดปกติ";
                    //rc.LNormal = "ค่าปกติ";
                    //rc.lResult = "ผลการตรวจ";
                    //rc.LTypeLab = "ประเภทการตรวจ Eye";
                    //rc.Remark = "";
                    //rc.StatusLab = "sum";
                    //rc.Sort1 = "1021";
                    //rc.Sort2 = "20";
                    //cc.rcdb.insertRCheckUp(rc);
                }
                //Toxi
                if (int.Parse(cuc.ToxiSuccess) > 0)
                {
                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiAcetone ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiAcetone].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiAcetone].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "10";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiAluminium ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiAluminium].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiAluminium].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "11";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiAmmonia ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiAmmonia].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiAmmonia].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "12";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiAntimony ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiAntimony].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiAntimony].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "13";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiArsenic ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiArsenic].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiArsenic].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "14";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiBenzene ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiBenzene].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiBenzene].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "15";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiCadmium ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiCadmium].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiCadmium].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "16";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiChromium ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiChromium].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiChromium].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "17";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiCopper ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiCopper].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiCopper].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "18";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiEthanol ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiEthanol].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiEthanol].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "19";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiFluoride ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiFluoride].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiFluoride].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "20";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiFomaldehyde ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiFomaldehyde].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiFomaldehyde].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "21";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiHexane ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiHexane].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiHexane].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "22";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiHippuric ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiHippuric].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiHippuric].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiIPA ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiIPA].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiIPA].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiKetone ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiKetone].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiKetone].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiLead ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiLead].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiLead].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiMandelic ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiMandelic].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiMandelic].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiManganese ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiManganese].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiManganese].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiMercury ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiMercury].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiMercury].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiMethanol ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiMethanol].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiMethanol].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiMethyl ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiMethyl].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiMethyl].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiNickel ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiNickel].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiNickel].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiPhenol ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiPhenol].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiPhenol].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiTin ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiTin].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiTin].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiTrichloroethylene ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiTrichloroethylene].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiTrichloroethylene].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                    rc.Id = r.Next().ToString();
                    rc.LabGroup = "การตรวจ (Toxicology)";
                    rc.LabName = "ToxiZinc ";
                    rc.LabNormal = cc.dtccpvn.Rows[0][cc.ccpdb.ccp.ToxiZinc].ToString();
                    rc.LabResult = dtAll.Rows[i][cc.ccpdb.ccp.ToxiZinc].ToString();
                    rc.LInter = "การแปรผล";
                    rc.LInterAbnormal = "ปกติ";
                    rc.LInterNormal = "ผิดปกติ";
                    rc.LNormal = "ค่าปกติ";
                    rc.lResult = "ผลการตรวจ";
                    rc.LTypeLab = "ประเภทการตรวจ Toxicology";
                    rc.Remark = "";
                    rc.StatusLab = "toxi";
                    rc.Sort1 = "1022";
                    rc.Sort2 = "23";
                    cc.rcdb.insertRCheckUp(rc);

                }
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameOther1);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row=0;
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
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdOther1(txtId.Text);
            cc.cucdb.updateOther1Import(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row);
            txtOther1CntEmp.Text = rowCount.ToString();
            txtOther1Sucess.Text = row.ToString();
            Cursor.Current = cursor;
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameLung);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0;
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
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdLung(txtId.Text);
            cc.cucdb.updateLungImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row);
            txtLungCntEmp.Text = rowCount.ToString();
            txtLungSucess.Text = row.ToString();
            Cursor.Current = cursor;
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
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameAudio);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.AudiogramRow); i <= rowCount; i++)
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
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdAudoigram(txtId.Text);
            cc.cucdb.updateAudioImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row);
            txtAudioCntEmp.Text = rowCount.ToString();
            txtAudioSucess.Text = row.ToString();
            Cursor.Current = cursor;
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

            String EyeShortLongLeft = "", EyeShortLongRight = "", EyeSquintLeft = "", EyeSquintRight = "", EyedegreeLeft = "", EyeDegreeRight = "", EyeOldLeft = "", EyeOldRight = "", EyeBlindness = "", EyeResult = "", EyeSummary = "", EyeExam="";
            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameEye);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, row = 0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.EyeRow); i <= rowCount; i++)
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
                if (xlRange.Cells[i, int.Parse(ei.EyeDegreeLeft)].Value2 != null)
                {
                    EyedegreeLeft = xlRange.Cells[i, int.Parse(ei.EyeDegreeLeft)].Value2.ToString();
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
                if (xlRange.Cells[i, int.Parse(ei.EyeExam)].Value2 != null)
                {
                    EyeExam = xlRange.Cells[i, int.Parse(ei.EyeExam)].Value2.ToString();
                }
                else
                {
                    EyeExam = "";
                }

                chk = cc.ccpdb.updateEye(rowNumber, txtId.Text, EyeShortLongLeft, EyeShortLongRight, EyeSquintLeft, EyeSquintRight, EyedegreeLeft, EyeDegreeRight, EyeOldLeft, EyeOldRight,
                    EyeResult, EyeSummary, EyeBlindness, EyeExam);
                pB1.Value = i;
                row++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdEye(txtId.Text);
            cc.cucdb.updateEyeImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), row);
            txtEyeCntEmp.Text = rowCount.ToString();
            txtEyeSucess.Text = row.ToString();
            Cursor.Current = cursor;
        }

        private void btnPrintSticker_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cc.ccpdb.selectPEByCucId(txtId.Text);
            FrmReport frm = new FrmReport(cc);
            frm.setReportCheckUpSticker(dt);
            frm.ShowDialog(this);
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการยกเลิก", "ยกเลิก", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                cc.cucdb.VoidCustCheckUp(txtId.Text);
                this.Dispose();
            }
        }

        private void btnStoolExamImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "";

            String StoolExamRow = "", StoolExamNo = "", StoolExamColor = "", StoolExamAppearance = "", StoolExamWBC = "", StoolExamRBC = "", Parasite = "", StoolExamSummary = "";
            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameStoolExam);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, rowStoolExam = 0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.StoolExamRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.StoolExamNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.StoolExamNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.StoolExamColor)].Value2 != null)
                {
                    StoolExamColor = xlRange.Cells[i, int.Parse(ei.StoolExamColor)].Value2.ToString();
                }
                else
                {
                    StoolExamColor = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.StoolExamAppearance)].Value2 != null)
                {
                    StoolExamAppearance = xlRange.Cells[i, int.Parse(ei.StoolExamAppearance)].Value2.ToString();
                }
                else
                {
                    StoolExamAppearance = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.StoolExamWbc)].Value2 != null)
                {
                    StoolExamWBC = xlRange.Cells[i, int.Parse(ei.StoolExamWbc)].Value2.ToString();
                }
                else
                {
                    StoolExamWBC = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.StoolExamRbc)].Value2 != null)
                {
                    StoolExamRBC = xlRange.Cells[i, int.Parse(ei.StoolExamRbc)].Value2.ToString();
                }
                else
                {
                    StoolExamRBC = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.StoolExamParasite)].Value2 != null)
                {
                    Parasite = xlRange.Cells[i, int.Parse(ei.StoolExamParasite)].Value2.ToString();
                }
                else
                {
                    Parasite = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.StoolExamSummary)].Value2 != null)
                {
                    StoolExamSummary = xlRange.Cells[i, int.Parse(ei.StoolExamSummary)].Value2.ToString();
                }
                else
                {
                    StoolExamSummary = "";
                }

                chk = cc.ccpdb.updateStoolExam(rowNumber, txtId.Text, StoolExamAppearance, StoolExamColor, StoolExamWBC, StoolExamRBC, Parasite, StoolExamSummary);
                pB1.Value = i;
                rowStoolExam++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdStoolExam(txtId.Text);
            cc.cucdb.updateStoolExamImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), rowStoolExam);
            txtStoolExamCntEmp.Text = rowCount.ToString();
            txtStoolExamSucess.Text = rowStoolExam.ToString();
            Cursor.Current = cursor;
        }

        private void btnStoolExamExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameStoolExam = ofd.FileName;
            btnStoolExamImport.Enabled = true;
        }

        private void btnToxiImport_Click(object sender, EventArgs e)
        {
            String rowNumber = "", chk = "";

            String ToxiLead = "", ToxiAluminium = "", ToxiCadmium = "", ToxiMercury = "", ToxiTin = "", ToxiCopper = "", ToxiManganese = "", ToxiZinc = "", ToxiAmmonia = "";
            String ToxiHippuric = "", ToxiMethyl = "", ToxiAcetone="", ToxiNickel="", ToxiChromium="", ToxiPhenol="", ToxiKetone="", ToxiBenzene="", ToxiMandelic="", ToxiMethanol="";
            String ToxiEthanol="", ToxiIPA="", ToxiArsenic="", ToxiHexane="", ToxiFomaldehyde="", ToxiTrichloroethylene="", ToxiAntimony="", ToxiFluoride="";

            pB1.Visible = true;
            pB1.Minimum = 0;
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fileNameToxi);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count, rowToxi = 0;
            pB1.Maximum = rowCount;
            xlApp.Visible = false;
            for (int i = int.Parse(ei.StoolExamRow); i <= rowCount; i++)
            {
                //rowNumber = dtAll.Rows[i][cc.ccpdb.ccp.rowNumber].ToString();
                if (xlRange.Cells[i, int.Parse(ei.ToxiNo)].Value2 != null)
                {
                    rowNumber = xlRange.Cells[i, int.Parse(ei.ToxiNo)].Value2.ToString();
                }
                else
                {
                    rowNumber = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiLead)].Value2 != null)
                {
                    ToxiLead = xlRange.Cells[i, int.Parse(ei.ToxiLead)].Value2.ToString();
                }
                else
                {
                    ToxiLead = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiAluminium)].Value2 != null)
                {
                    ToxiAluminium = xlRange.Cells[i, int.Parse(ei.ToxiAluminium)].Value2.ToString();
                }
                else
                {
                    ToxiAluminium = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiCadmium)].Value2 != null)
                {
                    ToxiCadmium = xlRange.Cells[i, int.Parse(ei.ToxiCadmium)].Value2.ToString();
                }
                else
                {
                    ToxiCadmium = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiMercury)].Value2 != null)
                {
                    ToxiMercury = xlRange.Cells[i, int.Parse(ei.ToxiMercury)].Value2.ToString();
                }
                else
                {
                    ToxiMercury = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiTin)].Value2 != null)
                {
                    ToxiTin = xlRange.Cells[i, int.Parse(ei.ToxiTin)].Value2.ToString();
                }
                else
                {
                    ToxiTin = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiCopper)].Value2 != null)
                {
                    ToxiCopper = xlRange.Cells[i, int.Parse(ei.ToxiCopper)].Value2.ToString();
                }
                else
                {
                    ToxiCopper = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiManganese)].Value2 != null)
                {
                    ToxiManganese = xlRange.Cells[i, int.Parse(ei.ToxiManganese)].Value2.ToString();
                }
                else
                {
                    ToxiManganese = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiZinc)].Value2 != null)
                {
                    ToxiZinc = xlRange.Cells[i, int.Parse(ei.ToxiZinc)].Value2.ToString();
                }
                else
                {
                    ToxiZinc = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiAmmonia)].Value2 != null)
                {
                    ToxiAmmonia = xlRange.Cells[i, int.Parse(ei.ToxiAmmonia)].Value2.ToString();
                }
                else
                {
                    ToxiAmmonia = "";
                }

                if (xlRange.Cells[i, int.Parse(ei.ToxiHippuric)].Value2 != null)
                {
                    ToxiHippuric = xlRange.Cells[i, int.Parse(ei.ToxiHippuric)].Value2.ToString();
                }
                else
                {
                    ToxiHippuric = "";
                }

                if (xlRange.Cells[i, int.Parse(ei.ToxiMethyl)].Value2 != null)
                {
                    ToxiMethyl = xlRange.Cells[i, int.Parse(ei.ToxiMethyl)].Value2.ToString();
                }
                else
                {
                    ToxiMethyl = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiAcetone)].Value2 != null)
                {
                    ToxiAcetone = xlRange.Cells[i, int.Parse(ei.ToxiAcetone)].Value2.ToString();
                }
                else
                {
                    ToxiAcetone = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiNickel)].Value2 != null)
                {
                    ToxiNickel = xlRange.Cells[i, int.Parse(ei.ToxiNickel)].Value2.ToString();
                }
                else
                {
                    ToxiNickel = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiChromium)].Value2 != null)
                {
                    ToxiChromium = xlRange.Cells[i, int.Parse(ei.ToxiChromium)].Value2.ToString();
                }
                else
                {
                    ToxiChromium = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiPhenol)].Value2 != null)
                {
                    ToxiPhenol = xlRange.Cells[i, int.Parse(ei.ToxiPhenol)].Value2.ToString();
                }
                else
                {
                    ToxiPhenol = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiKetone)].Value2 != null)
                {
                    ToxiKetone = xlRange.Cells[i, int.Parse(ei.ToxiKetone)].Value2.ToString();
                }
                else
                {
                    ToxiKetone = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiBenzene)].Value2 != null)
                {
                    ToxiBenzene = xlRange.Cells[i, int.Parse(ei.ToxiBenzene)].Value2.ToString();
                }
                else
                {
                    ToxiBenzene = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiMandelic)].Value2 != null)
                {
                    ToxiMandelic = xlRange.Cells[i, int.Parse(ei.ToxiMandelic)].Value2.ToString();
                }
                else
                {
                    ToxiMandelic = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiMethanol)].Value2 != null)
                {
                    ToxiMethanol = xlRange.Cells[i, int.Parse(ei.ToxiMethanol)].Value2.ToString();
                }
                else
                {
                    ToxiMethanol = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiEthanol)].Value2 != null)
                {
                    ToxiEthanol = xlRange.Cells[i, int.Parse(ei.ToxiEthanol)].Value2.ToString();
                }
                else
                {
                    ToxiEthanol = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiIPA)].Value2 != null)
                {
                    ToxiIPA = xlRange.Cells[i, int.Parse(ei.ToxiIPA)].Value2.ToString();
                }
                else
                {
                    ToxiIPA = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiArsenic)].Value2 != null)
                {
                    ToxiArsenic = xlRange.Cells[i, int.Parse(ei.ToxiArsenic)].Value2.ToString();
                }
                else
                {
                    ToxiArsenic = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiHexane)].Value2 != null)
                {
                    ToxiHexane = xlRange.Cells[i, int.Parse(ei.ToxiHexane)].Value2.ToString();
                }
                else
                {
                    ToxiHexane = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiFomaldehyde)].Value2 != null)
                {
                    ToxiFomaldehyde = xlRange.Cells[i, int.Parse(ei.ToxiFomaldehyde)].Value2.ToString();
                }
                else
                {
                    ToxiFomaldehyde = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiTrichloroethylene)].Value2 != null)
                {
                    ToxiTrichloroethylene = xlRange.Cells[i, int.Parse(ei.ToxiTrichloroethylene)].Value2.ToString();
                }
                else
                {
                    ToxiTrichloroethylene = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiAntimony)].Value2 != null)
                {
                    ToxiAntimony = xlRange.Cells[i, int.Parse(ei.ToxiAntimony)].Value2.ToString();
                }
                else
                {
                    ToxiAntimony = "";
                }
                if (xlRange.Cells[i, int.Parse(ei.ToxiFluoride)].Value2 != null)
                {
                    ToxiFluoride = xlRange.Cells[i, int.Parse(ei.ToxiFluoride)].Value2.ToString();
                }
                else
                {
                    ToxiFluoride = "";
                }

                chk = cc.ccpdb.updateToxi1(rowNumber, txtId.Text, ToxiLead, ToxiAluminium, ToxiCadmium, ToxiMercury, ToxiTin, ToxiCopper, ToxiManganese, ToxiZinc, ToxiAmmonia);
                chk = cc.ccpdb.updateToxi2(rowNumber, txtId.Text, ToxiHippuric, ToxiMethyl, ToxiAcetone, ToxiNickel, ToxiChromium, ToxiPhenol, ToxiKetone, ToxiBenzene, ToxiMandelic, ToxiMethanol,
                    ToxiEthanol, ToxiIPA, ToxiArsenic, ToxiHexane, ToxiFomaldehyde, ToxiTrichloroethylene, ToxiAntimony, ToxiFluoride);
                pB1.Value = i;
                rowToxi++;
            }
            xlWorkbook.Close(true, misValue, misValue);
            xlApp.Quit();
            pB1.Visible = false;
            dtAll = cc.ccpdb.selectAllByCucId(txtId.Text);
            setGrdStoolExam(txtId.Text);
            cc.cucdb.updateToxiImport(txtId.Text, rowCount - int.Parse(nmDRow.Value.ToString()), rowToxi);
            txtToxiCntEmp.Text = rowCount.ToString();
            txtToxiSucess.Text = rowToxi.ToString();
            Cursor.Current = cursor;
        }

        private void btnToxiExcel_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fileNameToxi = ofd.FileName;
            btnToxiImport.Enabled = true;
        }

        private void btnExcel1_Click(object sender, EventArgs e)
        {
            FrmExcelInit frm = new FrmExcelInit(cc,"");
            frm.ShowDialog();
            ei = cc.eidb.selectByPk();
        }
        private void OpenExcelInit(String tab)
        {
            FrmExcelInit frm = new FrmExcelInit(cc,tab);
            frm.ShowDialog();
            ei = cc.eidb.selectByPk();
        }

        private void btnExelPE_Click(object sender, EventArgs e)
        {
            OpenExcelInit("pe");
        }
    }
}
