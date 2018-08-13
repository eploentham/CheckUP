using CheckUP.objdb;
using CheckUP.object1;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data;
using System.Reflection;
using System.Drawing;

namespace CheckUP.Control
{
    public class CheckControl
    {
        public Config1 cf;
        public ConnectDB conn;//

        public StaffDB sfdb;
        public DistrictDB didb;
        public AmphurDB amdb;
        public ProvinceDB prdb;
        public CompanyDB copdb;
        public CustomerDB cudb;
        public CustCheckUpPatientDB ccpdb;

        public CustCheckUpPatient1DB ccp1db;

        public CustCheckUpDB cucdb;
        public ExcelInitDB eidb;
        public RCheckUpDB rcdb;
        public CustCheckUpPatientValueNormalDB ccpvndb;
        public StickerDB stkdb;
        public ExcelInitMiniDB eiminidb;
        //public InvoiceDB invdb;
        //public InvoiceItemDB invidb;
        //public ResultDB rsdb;
        //public ResultItemDB rsidb;
        //public DocTypeDB docdb;

        public Staff sf;
        public Company cop;
        //public Item itSearch;

        private IniFile iniFile;
        public InitConfig initC;
        public String PathLogo;

        public ValueNormalCholes vCholes;
        public ValueNormalLDL vLDL;
        public ValueNormalSugar vSugar;
        public ValueNormalTrigly vTrig;

        public LogWriter lw;
        public DataTable dtccpvn;
        public int grdViewFontSize = 0;

        public CheckControl()
        {
            initConfig();
        }
        private void initConfig()
        {
            try
            {
                iniFile = new IniFile(Environment.CurrentDirectory + "\\" + Application.ProductName + ".ini");
                initC = new InitConfig();
                GetConfig();
                cf = new Config1();
                //MessageBox.Show("5555", "Error");
                vCholes = new ValueNormalCholes();
                vLDL = new ValueNormalLDL();
                vSugar = new ValueNormalSugar();
                vTrig = new ValueNormalTrigly();

                sf = new Staff();
                //itSearch = new Item();

                conn = new ConnectDB(initC);
                //MessageBox.Show("66666", "Error");
                sfdb = new StaffDB(conn);
                didb = new DistrictDB(conn);
                amdb = new AmphurDB(conn);
                prdb = new ProvinceDB(conn);
                copdb = new CompanyDB(conn);
                cudb = new CustomerDB(conn);
                ccpdb = new CustCheckUpPatientDB(conn);

                ccp1db = new CustCheckUpPatient1DB(conn);
                //MessageBox.Show("66666", "Error");
                cucdb = new CustCheckUpDB(conn);
                eidb = new ExcelInitDB(conn);
                rcdb = new RCheckUpDB(conn);
                ccpvndb = new CustCheckUpPatientValueNormalDB(conn);
                stkdb = new StickerDB(conn);
                eiminidb = new ExcelInitMiniDB(conn);
                //invdb = new InvoiceDB(conn);
                //invidb = new InvoiceItemDB(conn);
                //rsdb = new ResultDB(conn);
                //rsidb = new ResultItemDB(conn);
                //docdb = new DocTypeDB(conn);
                //MessageBox.Show("66666", "Error");
                lw = new LogWriter();
                //Console.WriteLine("111");
                //Debug.WriteLine("111");
                //MessageBox.Show("111 ", "111 ");
                //cop = copdb.selectByPk();
                //MessageBox.Show("222 ", "222 ");
                //Console.WriteLine("222");
                //Debug.WriteLine("222");
                PathLogo = Environment.CurrentDirectory;
                //MessageBox.Show("111" , "Error");
                //dtccpvn = ccpvndb.selectByPk();
                //MessageBox.Show("222", "Error");
                //setValueNormal();
            }
            catch (Exception ex)
            {
                //lw.WriteLog("CnviControl.initConfig Error " + ex.Message);
                MessageBox.Show(""+ex.Message, "Error");
            }
        }
        public void setStartApp()
        {
            cop = copdb.selectByPk();
            dtccpvn = ccpvndb.selectByPk();
            setValueNormal();
        }
        public void setValueNormal()
        {
            DataTable dt = new DataTable();
            dt = ccpvndb.selectByPk();
            //MessageBox.Show("333", "Error");
            vCholes.cholesterolValueNormal = dt.Rows[0][ccpvndb.ccpvn.cholesterolValueNormal].ToString();
            vCholes.cholesterolValueUpper = dt.Rows[0][ccpvndb.ccpvn.cholesterolValueUpper].ToString();
            vCholes.cholesterolValueUpperSuggess = dt.Rows[0][ccpvndb.ccpvn.cholesterolValueUpperSuggess].ToString();
            //MessageBox.Show("444", "Error");
            vLDL.ldlValueNormal = dt.Rows[0][ccpvndb.ccpvn.ldlValueNormal].ToString();
            vLDL.ldlValueUpper = dt.Rows[0][ccpvndb.ccpvn.ldlValueUpper].ToString();
            vLDL.ldlValueUpperSuggess= dt.Rows[0][ccpvndb.ccpvn.ldlValueUpperSuggess].ToString();

            vSugar.sugarValueNormal = dt.Rows[0][ccpvndb.ccpvn.sugarValueNormal].ToString();
            vSugar.sugarValueLower = dt.Rows[0][ccpvndb.ccpvn.sugarValueLower].ToString();
            vSugar.sugarValueLowerSuggess = dt.Rows[0][ccpvndb.ccpvn.sugarValueLowerSuggess].ToString();
            vSugar.sugarValueUpper = dt.Rows[0][ccpvndb.ccpvn.sugarValueUpper].ToString();
            vSugar.sugarValueUpperSuggess = dt.Rows[0][ccpvndb.ccpvn.sugarValueUpperSuggess].ToString();

            vTrig.triglycerideValueNormal = dt.Rows[0][ccpvndb.ccpvn.triglycerideValueNormal].ToString();
            vTrig.triglycerideValueUpper = dt.Rows[0][ccpvndb.ccpvn.triglycerideValueUpper].ToString();
            vTrig.triglycerideValueUpperSuggess = dt.Rows[0][ccpvndb.ccpvn.triglycerideValueUpperSuggess].ToString();
        }
        public String getTextCboItem(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Value.Equals(valueId))
                {
                    r = cc;
                }
            }
            return r.Text;
        }
        public void GetConfig()
        {
            initC.clearInput = iniFile.Read("clearinput");
            initC.connectDatabaseServer = iniFile.Read("connectserver");
            initC.Host = iniFile.Read("host");
            initC.User = iniFile.Read("username");
            initC.Password = iniFile.Read("password");
            initC.Port = iniFile.Read("port");
            initC.Database = iniFile.Read("database");

            initC.hostDBonsite = iniFile.Read("hostDBonsite");
            initC.userDBonsite = iniFile.Read("userDBonsite");
            initC.passDBonsite = iniFile.Read("passDBonsite");
            initC.portDBonsite = iniFile.Read("portDBonsite");
            initC.nameDBonsite = iniFile.Read("nameDBonsite");
            initC.statusonsite = iniFile.Read("nameDBonsite");

            //initC.Host = initC.ServerIP;

            initC.PathData = iniFile.Read("pathimage");
            initC.pathImageLogo = iniFile.Read("pathimagelogo");
            initC.delImage = iniFile.Read("delimage");
            initC.StatusServer = iniFile.Read("statusserver");
            initC.NameShareData = iniFile.Read("namesharedata");
            initC.pathShareImage = iniFile.Read("pathshareimage");
            initC.use32Bit = iniFile.Read("use32bit");
            initC.PathReport = iniFile.Read("pathreport");
            initC.ConnectShareData = iniFile.Read("connectsharedata");
            initC.IPServer = iniFile.Read("ipserver");

            initC.quoLine1 = iniFile.Read("quotationline1");
            initC.quoLine2 = iniFile.Read("quotationline2");
            initC.quoLine3 = iniFile.Read("quotationline3");
            initC.quoLine4 = iniFile.Read("quotationline4");
            initC.quoLine5 = iniFile.Read("quotationline5");
            initC.quoLine6 = iniFile.Read("quotationline6");

            initC.HideCostQuotation = iniFile.Read("hidecostquotation");

            initC.grdViewFontSize = iniFile.Read("grdViewFontSize");
            initC.grdViewFontName = iniFile.Read("grdViewFontName");
            initC.themeApplication = iniFile.Read("themeApplication");
            initC.txtFocus = iniFile.Read("txtFocus");
            initC.grfRowColor = iniFile.Read("grfRowColor");
            initC.statusonsite = iniFile.Read("statusonsite");
            initC.pathMini = iniFile.Read("pathMini");

            initC.grdViewFontName = initC.grdViewFontName.Equals("") ? "Microsoft Sans Serif" : initC.grdViewFontName;
            int.TryParse(initC.grdViewFontSize, out grdViewFontSize);
            //initC.reportSumNameCBC = iniFile.Read("reportSumNameCBC");
            //initC.reportSumNameFBS = iniFile.Read("reportSumNameFBS");
            //initC.reportSumNamePE = iniFile.Read("reportSumNamePE");
            //initC.Password = regE.getPassword();
        }
        public Boolean fileExit(String path)
        {
            bool folderExists = File.Exists(path);
            return folderExists;
        }
        public void SetPathMini(String path)
        {
            iniFile.Write("pathMini", path);
        }
        public void SetPathImage(String path)
        {
            iniFile.Write("pathimage", path);
        }
        public void SetPathImageLogo(String path)
        {
            iniFile.Write("pathimagelogo", path);
        }
        public void SetConnectShareImage(String path)
        {
            iniFile.Write("connectshareimage", path);
        }
        public void SetConnectShareData(String path)
        {
            iniFile.Write("connectsharedata", path);
        }
        public void SetNameShareData(String path)
        {
            iniFile.Write("namesharedata", path);
        }
        public void SetPathShareImage(String path)
        {
            iniFile.Write("pathshareimage", path);
        }
        public void SetPathReport(String path)
        {
            iniFile.Write("pathreport", path);
        }
        public void SetIPServer(String path)
        {
            iniFile.Write("ipserver", path);
        }
        public void SetQuoLine1(String path)
        {
            //iniFile.Write("quotationline1", path);
            iniFile.WriteUniCode("quotationline1", Utf8ToUtf16(path));
        }
        public void SetQuoLine2(String path)
        {
            //iniFile.Write("quotationline2", path);
            iniFile.WriteUniCode("quotationline2", Utf8ToUtf16(path));
        }
        public void SetQuoLine3(String path)
        {
            //iniFile.Write("quotationline3", path);
            iniFile.WriteUniCode("quotationline3", path);
        }
        public void SetQuoLine4(String path)
        {
            //iniFile.Write("quotationline4", path);
            iniFile.WriteUniCode("quotationline4", path);
        }
        public void SetQuoLine5(String path)
        {
            //iniFile.Write("quotationline5", path);
            iniFile.WriteUniCode("quotationline5", path);
        }
        public void SetQuoLine6(String path)
        {
            //iniFile.Write("quotationline6", path);
            iniFile.WriteUniCode("quotationline6", path);
        }
        public void SetHostDBinsite(String val)
        {            
            iniFile.WriteUniCode("hostDBonsite", val);
        }
        public void SetNameDBinsite(String val)
        {
            iniFile.WriteUniCode("nameDBonsite", val);
        }
        public void SetUserDBinsite(String val)
        {
            iniFile.WriteUniCode("userDBonsite", val);
        }
        public void SetPassDBinsite(String val)
        {
            iniFile.WriteUniCode("passDBonsite", val);
        }
        public void SetPortDBinsite(String val)
        {
            iniFile.WriteUniCode("portDBonsite", val);
        }
        public void SetStatusonsite(String val)
        {
            iniFile.WriteUniCode("statusonsite", val);
        }
        public void SetHideCostQuotation(Boolean value)
        {
            if (value)
            {
                iniFile.Write("hidecostquotation", "yes");
            }
            else
            {
                iniFile.Write("hidecostquotation", "no");
            }
        }
        public void SetSetatusServer(Boolean value)
        {
            if (value)
            {
                iniFile.Write("statusserver", "yes");
                //iniFile.Write("statusonsite", "yes");
            }
            else
            {
                iniFile.Write("statusserver", "no");
                //iniFile.Write("statusonsite", "no");
            }
        }
        public void SetClearInput(Boolean value)
        {
            if (value)
            {
                iniFile.Write("clearinput", "yes");
            }
            else
            {
                iniFile.Write("clearinput", "no");
            }
        }
        public void SetDelImage(Boolean value)
        {
            if (value)
            {
                iniFile.Write("delimage", "yes");
            }
            else
            {
                iniFile.Write("delimage", "no");
            }
        }
        public void SetUse32Bit(Boolean value)
        {
            if (value)
            {
                iniFile.Write("use32bit", "yes");
            }
            else
            {
                iniFile.Write("use32bit", "no");
            }
        }
        public void SetConnectServer(Boolean value, String host, String username, String password)
        {
            if (value)
            {
                iniFile.Write("connectserver", "yes");
                iniFile.Write("host", host.Trim());
                iniFile.Write("username", username.Trim());
                iniFile.Write("password", password.Trim());
            }
            else
            {
                iniFile.Write("connectserver", "no");
            }
        }
        public void renameFileImage(String fileName)
        {
            String file1 = fileName.Replace("_0", "_1");
            System.IO.File.Move(fileName, file1);
        }
        public void DeleteFileImage(String fileName)
        {
            //String file1 = fileName.Replace("_0", "_1");
            System.IO.File.Delete(fileName);

        }
        public Boolean getLoginByCode(String code, String password)
        {
            Boolean chk = false;
            sf = sfdb.selectByCode(code);
            if (sf != null)
            {
                if (sf.Password.Equals(password))
                {
                    chk = true;
                }
            }
            return chk;
        }
        public void CreateSharedFolder(string FolderPath, string ShareName, string Description)
        {
            try
            {
                // Create a ManagementClass object
                ManagementClass mc = new ManagementClass("Win32_Share");

                // Create ManagementBaseObjects for in and out parameters
                ManagementBaseObject inParams = mc.GetMethodParameters("Create");

                ManagementBaseObject outParams;

                // Set the input parameters
                inParams["Description"] = Description;
                inParams["Name"] = ShareName;
                inParams["Path"] = FolderPath;
                inParams["Type"] = 0x0; // Disk Drive

                //Another Type:
                // DISK_DRIVE = 0x0
                // PRINT_QUEUE = 0x1
                // DEVICE = 0x2
                // IPC = 0x3
                // DISK_DRIVE_ADMIN = 0x80000000
                // PRINT_QUEUE_ADMIN = 0x80000001
                // DEVICE_ADMIN = 0x80000002
                // IPC_ADMIN = 0x8000003

                //inParams["MaximumAllowed"] = 2;
                inParams["Password"] = null;

                NTAccount everyoneAccount = new NTAccount(null, "EVERYONE");
                SecurityIdentifier sid = (SecurityIdentifier)everyoneAccount.Translate(typeof(SecurityIdentifier));
                byte[] sidArray = new byte[sid.BinaryLength];
                sid.GetBinaryForm(sidArray, 0);

                ManagementObject everyone = new ManagementClass("Win32_Trustee");
                everyone["Domain"] = null;
                everyone["Name"] = "EVERYONE";
                everyone["SID"] = sidArray;

                ManagementObject dacl = new ManagementClass("Win32_Ace");
                dacl["AccessMask"] = 2032127;
                dacl["AceFlags"] = 3;
                dacl["AceType"] = 0;
                dacl["Trustee"] = everyone;

                ManagementObject securityDescriptor = new ManagementClass("Win32_SecurityDescriptor");
                securityDescriptor["ControlFlags"] = 4; //SE_DACL_PRESENT 
                securityDescriptor["DACL"] = new object[] { dacl };

                inParams["Access"] = securityDescriptor;

                // Invoke the "create" method on the ManagementClass object
                outParams = mc.InvokeMethod("Create", inParams, null);

                // Check to see if the method invocation was successful
                var result = (uint)(outParams.Properties["ReturnValue"].Value);
                switch (result)
                {
                    case 0:
                        Console.WriteLine("Folder successfuly shared.");
                        break;
                    case 2:
                        Console.WriteLine("Access Denied");
                        break;
                    case 8:
                        Console.WriteLine("Unknown Failure");
                        break;
                    case 9:
                        Console.WriteLine("Invalid Name");
                        break;
                    case 10:
                        Console.WriteLine("Invalid Level");
                        break;
                    case 21:
                        Console.WriteLine("Invalid Parameter");
                        break;
                    case 22:
                        Console.WriteLine("Duplicate Share");
                        break;
                    case 23:
                        Console.WriteLine("Redirected Path");
                        break;
                    case 24:
                        Console.WriteLine("Unknown Device or Directory");
                        break;
                    case 25:
                        Console.WriteLine("Net Name Not Found");
                        break;
                    default:
                        Console.WriteLine("Folder cannot be shared.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
        public string LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = host.AddressList;
            for (int i = 0; i < addr.Length; i++)
            {
                if (addr[i].AddressFamily.ToString().ToLower().Equals("internetwork"))
                {
                    localIP = addr[i].ToString();
                }
            }
            return localIP;
            //return localIP;
        }
        public String getValueCboItem(ComboBox c)
        {
            ComboBoxItem iSale;
            iSale = (ComboBoxItem)c.SelectedItem;
            if (iSale == null)
            {
                return "";
            }
            else
            {
                return iSale.Value;
            }
        }
        public ComboBox setCboItem(ComboBox c, String valueId)
        {
            ComboBoxItem r = new ComboBoxItem();
            r.Text = "";
            r.Value = "";
            foreach (ComboBoxItem cc in c.Items)
            {
                if (cc.Value.Equals(valueId))
                {
                    c.Text = cc.Text;
                    return c;
                }
            }
            return c;
        }
        public String getYear()
        {
            String year = "";
            if (System.DateTime.Now.Year > 2550)
            {
                year = System.DateTime.Now.Year.ToString().Substring(2);
            }
            else
            {
                year = String.Concat(System.DateTime.Now.Year + 543);
            }
            year = year.Substring(2);
            return year;
        }
        public String ThaiBaht(string txt)
        {
            string bahtTxt, n, bahtTH = "";
            double amount;
            try { amount = Convert.ToDouble(txt); }
            catch { amount = 0; }
            bahtTxt = amount.ToString("####.00");
            string[] num = { "ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า", "สิบ" };
            string[] rank = { "", "สิบ", "ร้อย", "พัน", "หมื่น", "แสน", "ล้าน" };
            string[] temp = bahtTxt.Split('.');
            string intVal = temp[0];
            string decVal = temp[1];
            if (Convert.ToDouble(bahtTxt) == 0)
                bahtTH = "ศูนย์บาทถ้วน";
            else
            {
                for (int i = 0; i < intVal.Length; i++)
                {
                    n = intVal.Substring(i, 1);
                    if (n != "0")
                    {
                        if ((i == (intVal.Length - 1)) && (n == "1"))
                            bahtTH += "เอ็ด";
                        else if ((i == (intVal.Length - 2)) && (n == "2"))
                            bahtTH += "ยี่";
                        else if ((i == (intVal.Length - 2)) && (n == "1"))
                            bahtTH += "";
                        else
                            bahtTH += num[Convert.ToInt32(n)];
                        bahtTH += rank[(intVal.Length - i) - 1];
                    }
                }
                bahtTH += "บาท";
                if (decVal == "00")
                    bahtTH += "ถ้วน";
                else
                {
                    for (int i = 0; i < decVal.Length; i++)
                    {
                        n = decVal.Substring(i, 1);
                        if (n != "0")
                        {
                            if ((i == decVal.Length - 1) && (n == "1"))
                                bahtTH += "เอ็ด";
                            else if ((i == (decVal.Length - 2)) && (n == "2"))
                                bahtTH += "ยี่";
                            else if ((i == (decVal.Length - 2)) && (n == "1"))
                                bahtTH += "";
                            else
                                bahtTH += num[Convert.ToInt32(n)];
                            bahtTH += rank[(decVal.Length - i) - 1];
                        }
                    }
                    bahtTH += "สตางค์";
                }
            }
            return bahtTH;
        }
        public static string Utf8ToUtf16(string utf8String)
        {
            // Get UTF8 bytes by reading each byte with ANSI encoding
            byte[] utf8Bytes = Encoding.Default.GetBytes(utf8String);

            // Convert UTF8 bytes to UTF16 bytes
            byte[] utf16Bytes = Encoding.Convert(Encoding.UTF8, Encoding.Unicode, utf8Bytes);

            // Return UTF16 bytes as UTF16 string
            return Encoding.Unicode.GetString(utf16Bytes);
        }
        public void genDataOnsite(String cucId)
        {
            String sql = "";
            cucdb.deleteOnSiteAll();
            ccpdb.deleteOnSiteAll();
            ccp1db.deleteOnSiteAll();
            cucdb.insertToOnSite(cucId);
            ccpdb.insertToOnSite(cucId);
            ccp1db.insertToOnSite(cucId);
        }
        public void excelSum(String cucId)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;
            
            try
            {
                int pageCnt = 1, pagemod=0, pageRow=18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
                
                xlWorksheet.Name = "summary";
                
                //xlWorksheet.Cells.Font.Size = 15;
                xlWorksheet.Cells.HorizontalAlignment = HorizontalAlignment.Center;

                Microsoft.Office.Interop.Excel.Range range;
                Microsoft.Office.Interop.Excel.Range rg;
                range = xlWorksheet.Range[xlWorksheet.Cells[1, 1], xlWorksheet.Cells[1, 8]];
                //range = xlWorksheet.get_Range("A1", "H1");
                range.Cells[1, 1] = "ตารางรายงานสรุปจำนวนผู้ที่มีผลการตรวจเป็นปกติ และผิดปกติ ประจำปี "+cuc.YearId;
                range.Merge();
                range.HorizontalAlignment = HorizontalAlignment.Center;
                range.Font.Size = 20;
                range.Font.Name = "Angsana New";

                //Microsoft.Office.Interop.Excel.Range range1;
                //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                range = xlWorksheet.get_Range("A2", "H2");
                range.Cells[1, 1] = " " + cuc.CustNameT;
                range.Merge();
                range.HorizontalAlignment = HorizontalAlignment.Center;
                range.Font.Size = 20;
                range.Font.Name = "Angsana New";

                range = xlWorksheet.Range[xlWorksheet.Cells[3, 1], xlWorksheet.Cells[3, 8]];
                range.Cells[1, 1] = " วันที่  " + cuc.CheckUpDate;
                //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                range.Merge();
                range.HorizontalAlignment = HorizontalAlignment.Center;                
                range.Font.Size = 20;
                range.Font.Name = "Angsana New";

                //xlWorksheet.Cells[1, 1] = "Student Report Card";
                //xlWorksheet.Cells[1, 2] = "รายการตรวจสุขภาพ " ;
                //xlWorksheet.Cells[1, 3] = "จำนวนผู้รับการตรวจ ";
                //range.HorizontalAlignment = HorizontalAlignment.Center;
                

                int row = 4;
                for(int i = 1; i <= pageCnt; i++)
                {
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รายการตรวจสุขภาพ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "จำนวนผู้รับการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+1, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "(คน)";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "จำนวนผู้รับการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+1, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "(%)";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "จำนวนผู้ที่ผมีผลการตรวจปกติ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+1, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "(คน)";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "จำนวนผู้ที่ผมีผลการตรวจปกติ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+1, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "(%)";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "จำนวนผู้ที่ผมีผลการตรวจผิดปกติ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+1, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "(คน)";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row, 8];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "จำนวนผู้ที่ผมีผลการตรวจผิดปกติ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+1, 8];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "(%)";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row+1, 8]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);


                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row+2, 1], xlWorksheet.Cells[row + pageRow, 8]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for(int j = 1; j < pageRow; j++)
                    {
                        xlWorksheet.Cells[row + j+1, 1] = j;
                    }

                    //Microsoft.Office.Interop.Excel.Range rgPage1;
                    //rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row+1, 1], xlWorksheet.Cells[row + 22+1, 8]];
                    //rgPage1.Font.Size = 14;
                    //rgPage1.Font.Name = "Angsana New";

                    row += (pageRow+2);
                }
                //int.TryParse(dt.Rows.Count)

                //range. = "Student Report Card";


                //xlWorksheet.Cells[1, 1] = "Testing";

                //Microsoft.Office.Interop.Excel.Range range = xlWorksheet.get_Range(xlWorksheet.Cells[1, 1], xlWorksheet.Cells[1, 2]);

                //range.Merge(true);

                //range.Interior.ColorIndex = 36;

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelSum " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {
                //if (xlWorkbook != null)
                //    xlWorkbook.Close();
                //if (xlApp != null)
                //    xlApp.Quit();
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            }
            Cursor.Current = cursor;
        }
        public void excelPE(String cucId)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "pe";

                //xlWorksheet.Cells.Font.Size = 15;
                //xlWorksheet.Cells.HorizontalAlignment = HorizontalAlignment.Center;                

                //xlWorksheet.Cells[1, 1] = "Student Report Card";
                //xlWorksheet.Cells[1, 2] = "รายการตรวจสุขภาพ " ;
                //xlWorksheet.Cells[1, 3] = "จำนวนผู้รับการตรวจ ";
                //range.HorizontalAlignment = HorizontalAlignment.Center;

                int row = 1,k=0, colCnt=11;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_pe+ " ประจำปี " + cuc.YearId;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row+2, 1], xlWorksheet.Cells[row+2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate+" จำนวนผู้เข้าตรวจทั้งหมด "+cuc.pe_checkup + " หน้าที่  " + i;
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.pe_test;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.PENormal;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.PEAbNormal;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "หมู่โลหิต";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "อายุ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "น้ำหนัก";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ส่วนสูง";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 8];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 8];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "BMI";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 9];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 9];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ความดันโลหิต";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 10];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 10];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ชีพจร";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 11];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 11];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    
                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k+1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.BloodGroup].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.patientAge].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.patientWeight].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.patientHeight].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 8] = dt.Rows[k][ccpdb.ccp.bmi].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 9] = dt.Rows[k][ccpdb.ccp.vitalsign].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 10] = dt.Rows[k][ccpdb.ccp.patientPulse].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 11] = dt.Rows[k][ccpdb.ccp.summaryPhysicalExam].ToString();
                        k++;
                    }

                    //Microsoft.Office.Interop.Excel.Range rgPage1;
                    //rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row+1, 1], xlWorksheet.Cells[row + 22+1, 8]];
                    //rgPage1.Font.Size = 14;
                    //rgPage1.Font.Name = "Angsana New";

                    row = row + (pageRow + 5);
                }
                //int.TryParse(dt.Rows.Count)

                //range. = "Student Report Card";


                //xlWorksheet.Cells[1, 1] = "Testing";

                //Microsoft.Office.Interop.Excel.Range range = xlWorksheet.get_Range(xlWorksheet.Cells[1, 1], xlWorksheet.Cells[1, 2]);

                //range.Merge(true);

                //range.Interior.ColorIndex = 36;

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelSum " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {
                //if (xlWorkbook != null)
                //    xlWorkbook.Close();
                //if (xlApp != null)
                //    xlApp.Quit();
                //System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            }
            Cursor.Current = cursor;
        }
        public String calFBS(String result)
        {
            //FBS
            String remark = "@";
            String[] fbs = dtccpvn.Rows[0][ccpvndb.ccpvn.sugar].ToString().Split('@');
            Double fbsMin = 0, fbsMax = 0;
            String fbsUnit = "";
            if (fbs.Length == 2)
            {
                String[] aa = fbs[0].ToString().Split('-');
                fbsMin = Double.Parse(aa[0]);
                fbsMax = Double.Parse(aa[1]);
                fbsUnit = fbs[1];
            }
            try
            {
                if (Double.Parse(cf.NumberNull1(result)) > 0)
                {
                    if ((Double.Parse(cf.NumberNull1(result)) >= fbsMin) && (Double.Parse(cf.NumberNull1(result)) <= fbsMax))
                    {
                        //rc.Remark = "ปกติ";
                        remark = vSugar.sugarValueNormal+"@";
                    }
                    else
                    {
                        if (Double.Parse(cf.NumberNull1(result)) > fbsMax)
                        {
                            //rc.Remark = "สูงกว่ามาตรฐาน";
                            remark = vSugar.sugarValueUpper+"@"+ vSugar.sugarValueUpperSuggess;
                        }
                        else
                        {
                            //rc.Remark = "ต่ำกว่ามาตรฐาน";
                            remark = vSugar.sugarValueLower + "@" + vSugar.sugarValueLowerSuggess;
                        }
                    }
                }
                else
                {
                    remark = "@";
                }
            }
            catch (Exception ex)
            {
                remark = "แปลผลไม่ได้ " + result;
            }
            return remark;
        }
        public void excelFBS(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "fbs";

                int row = 1, k = 0, colCnt = 6;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_fbs + " ประจำปี " + cuc.YearId;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.fbs_checkup + " หน้าที่  " + i;
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.fbs_test;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.FBSNormal;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.FBSAbNormal;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "FBS ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.sugar].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.sugar].ToString();
                        if (chkResult)
                        {
                            String result = "";
                            result = calFBS(dt.Rows[k][ccpdb.ccp.sugar].ToString());
                            String[] result1 = result.Split('@');

                            xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            if (result1[1].Length > 0)
                            {
                                Microsoft.Office.Interop.Excel.Range rgPage1;
                                rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                                rgPage1.Font.Color = Color.Red;
                                rgPage1.Font.Bold = true;
                            }
                        }
                        else
                        {
                            xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.sugarSuggess].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.sugarSummary].ToString();
                        }                        
                        k++;
                    }                                        

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelFBS " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {
                
            }
            Cursor.Current = cursor;
        }
        public void excelCBC(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 17;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "cbc";

                int row = 1, k = 0, colCnt = 17;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_cbc + " ประจำปี " + cuc.YearId;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.cbc_checkup + " หน้าที่  " + i;
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.cbc_test;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.CBCNormal;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.CBCAbNormal;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "WBC ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcWbc].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Hb ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "M "+dtccpvn.Rows[0][ccpvndb.ccpvn.cbcHbMale].ToString()+" F "+ dtccpvn.Rows[0][ccpvndb.ccpvn.cbcHbFemale].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Hct ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "M "+dtccpvn.Rows[0][ccpvndb.ccpvn.cbcHctMale].ToString()+" F "+ dtccpvn.Rows[0][ccpvndb.ccpvn.cbcHctFemale].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 7];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "RBC ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 7];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "M "+dtccpvn.Rows[0][ccpvndb.ccpvn.cbcRbcMale].ToString() + " F " + dtccpvn.Rows[0][ccpvndb.ccpvn.cbcRbcFemale].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 8];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "PMN ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 8];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcPmn].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 9];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "LYM ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 9];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcLymphocyte].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 10];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Mono ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 10];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcMonocyte].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 11];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "EO ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 11];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcEosinophil].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 12];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "BAS ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 12];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcBasophil].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 13];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Plt.count ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 13];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcPlateletCount].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 14];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Plt.smear ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 14];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcPlateletSmear].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                                        

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 15];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "RBC morphology ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 15];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.cbcRbcMorpholog].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 16];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 16];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 17];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 17];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();

                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.cbcWbc].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.cbcHb].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.cbcHct].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.cbcRbc].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 8] = dt.Rows[k][ccpdb.ccp.cbcPmn].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 9] = dt.Rows[k][ccpdb.ccp.cbcLymphocyte].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 10] = dt.Rows[k][ccpdb.ccp.cbcMonocyte].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 11] = dt.Rows[k][ccpdb.ccp.cbcEosinophil].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 12] = dt.Rows[k][ccpdb.ccp.cbcBasophil].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 13] = dt.Rows[k][ccpdb.ccp.cbcPlateletCount].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 14] = dt.Rows[k][ccpdb.ccp.cbcPlateletSmear].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 15] = dt.Rows[k][ccpdb.ccp.cbcRbcMorpholog].ToString();
                        if (chkResult)
                        {
                            //String result = "";
                            //result = calFBS(dt.Rows[k][ccpdb.ccp.sugar].ToString());
                            //String[] result1 = result.Split('@');

                            //xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            //xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            //if (result1[1].Length > 0)
                            //{
                            //    Microsoft.Office.Interop.Excel.Range rgPage1;
                            //    rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                            //    rgPage1.Font.Color = Color.Red;
                            //    rgPage1.Font.Bold = true;
                            //}
                            //xlWorksheet.Cells[row + j + 1 + 4, 16] = dt.Rows[k][ccpdb.ccp.cbcResult].ToString();
                            //xlWorksheet.Cells[row + j + 1 + 4, 17] = dt.Rows[k][ccpdb.ccp.cbcSummary].ToString();
                        }
                        else
                        {
                            //xlWorksheet.Cells[row + j + 1 + 4, 16] = dt.Rows[k][ccpdb.ccp.cbcResult].ToString();
                            //xlWorksheet.Cells[row + j + 1 + 4, 17] = dt.Rows[k][ccpdb.ccp.cbcSummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelCBC " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public void excelUA(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 13;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "ua";

                int row = 1, k = 0, colCnt = 17;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_ua + " ประจำปี " + cuc.YearId;       //
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.ua_checkup + " หน้าที่  " + i;       //
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.uric_test;       //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.UricNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.UricAbNormal;       //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Glu ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineGlu].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Spgr ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineSpGr].ToString() ;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "PH ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urinePh].ToString() ;
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 7];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Protein ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 7];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineProtein].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 8];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Blood ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 8];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineBlood].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 9];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Ketone ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 9];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineKetone].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 10];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "WBC ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 10];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineWbc].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 11];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "RBC ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 11];
                    rg.ColumnWidth = 20;
                    rg.Value2 = dtccpvn.Rows[0][ccpvndb.ccpvn.urineRbc].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 12];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 12];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 13];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 13];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();

                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.urineGlu].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.urineSpGr].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.urinePh].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.urineProtein].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 8] = dt.Rows[k][ccpdb.ccp.urineBlood].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 9] = dt.Rows[k][ccpdb.ccp.urineKetone].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 10] = dt.Rows[k][ccpdb.ccp.urineWbc].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 11] = dt.Rows[k][ccpdb.ccp.urineRbc].ToString();
                        
                        if (chkResult)
                        {
                            //String result = "";
                            //result = calFBS(dt.Rows[k][ccpdb.ccp.sugar].ToString());
                            //String[] result1 = result.Split('@');

                            //xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            //xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            //if (result1[1].Length > 0)
                            //{
                            //    Microsoft.Office.Interop.Excel.Range rgPage1;
                            //    rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                            //    rgPage1.Font.Color = Color.Red;
                            //    rgPage1.Font.Bold = true;
                            //}
                            //xlWorksheet.Cells[row + j + 1 + 4, 12] = dt.Rows[k][ccpdb.ccp.urineResult].ToString();
                            //xlWorksheet.Cells[row + j + 1 + 4, 13] = dt.Rows[k][ccpdb.ccp.urineSummary].ToString();
                        }
                        else
                        {
                            //xlWorksheet.Cells[row + j + 1 + 4, 12] = dt.Rows[k][ccpdb.ccp.urineResult].ToString();
                            //xlWorksheet.Cells[row + j + 1 + 4, 13] = dt.Rows[k][ccpdb.ccp.urineSummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelUA " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public void excelUric(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 6;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "uric acid";

                int row = 1, k = 0, colCnt = 6;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_uric + " ประจำปี " + cuc.YearId;      //
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.uric_checkup + " หน้าที่  " + i;        //checkup
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.uric_test;      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.UricNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.UricAbNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Uric ACID";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "M "+dtccpvn.Rows[0][ccpvndb.ccpvn.uricAcidMale].ToString()+" F "+ dtccpvn.Rows[0][ccpvndb.ccpvn.uricAcidFemale].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.uricAcid].ToString();
                        if (chkResult)
                        {
                            //String result = "";
                            //result = calFBS(dt.Rows[k][ccpdb.ccp.sugar].ToString());
                            //String[] result1 = result.Split('@');

                            //xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            //xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            //if (result1[1].Length > 0)
                            //{
                            //    Microsoft.Office.Interop.Excel.Range rgPage1;
                            //    rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                            //    rgPage1.Font.Color = Color.Red;
                            //    rgPage1.Font.Bold = true;
                            //}
                            xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.uricAcidSuggess].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.uricAcidSummary].ToString();
                        }
                        else
                        {
                            xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.uricAcidSuggess].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.uricAcidSummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelUric " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public String calTri(String result)
        {
            //Trigy
            String remark = "@";
            String[] tri = dtccpvn.Rows[0][ccpvndb.ccpvn.triglyceride].ToString().Split('@');
            Double triMax = 0;
            String triUnit = "";
            if (tri.Length == 2)
            {
                //String[] aa = tri[0].ToString().Split('<');
                //triMax = Double.Parse(aa[1].Replace(".0", ""));
                triMax = Double.Parse(tri[0].Replace(".0", ""));
                //fbsMax = int.Parse(aa[1]);
                triUnit = tri[1];
            }
            try
            {
                if (int.Parse(cf.NumberNull1(result)) > 0)
                {
                    if (int.Parse(cf.NumberNull1(result)) >= triMax)
                    {
                        //rc.Remark = "สูงกว่าปกติ";
                        remark = vTrig.triglycerideValueUpper;
                    }
                    else if (int.Parse(cf.NumberNull1(result)) < triMax)
                    {
                        remark = vTrig.triglycerideValueNormal;
                    }
                }
                else
                {
                    remark = "@";
                }
            }
            catch (Exception ex)
            {
                remark = "แปลผลไม่ได้ " + result;
            }
            return remark;
        }
        public void excelTri(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "trig";

                int row = 1, k = 0, colCnt = 6;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_tri + " ประจำปี " + cuc.YearId;      //
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.tri_checkup + " หน้าที่  " + i;        //
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.tri_test;      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.TriNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.TriAbNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Triglyceride ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ค่าปกติ " + dtccpvn.Rows[0][ccpvndb.ccpvn.triglyceride].ToString();
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.triglyceride].ToString();
                        if (chkResult)
                        {
                            String result = "";
                            result = calTri(dt.Rows[k][ccpdb.ccp.triglyceride].ToString());
                            String[] result1 = result.Split('@');

                            xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            if (result1[1].Length > 0)
                            {
                                Microsoft.Office.Interop.Excel.Range rgPage1;
                                rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                                rgPage1.Font.Color = Color.Red;
                                rgPage1.Font.Bold = true;
                            }
                            xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.triglycerideResult].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.triglycerideRemark].ToString();
                        }
                        else
                        {
                            xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.triglycerideResult].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.triglycerideSummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelTri " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public String calCho(String result)
        {
            //Choles
            String remark = "@";
            //Choles
            String[] choles = dtccpvn.Rows[0][ccpvndb.ccpvn.cholesterol].ToString().Split('@');
            int cholesMax = 0;
            String cholesUnit = "";
            if (choles.Length == 2)
            {
                cholesMax = int.Parse(choles[0].Replace(".0", ""));
                cholesUnit = choles[1];
            }
            try
            {
                if (Double.Parse(cf.NumberNull1(result)) > 0)
                {
                    if (Double.Parse(cf.NumberNull1(result)) >= cholesMax)
                    {
                        //rc.Remark = "สูงกว่าปกติ";
                        remark = vCholes.cholesterolValueUpper;
                    }
                    else if (Double.Parse(cf.NumberNull1(result)) < cholesMax)
                    {
                        //rc.Remark = "ปกติ";
                        remark = vCholes.cholesterolValueNormal;
                    }
                }
                else
                {
                    remark = "@";
                }
            }
            catch (Exception ex)
            {
                remark = "แปลผลไม่ได้ " + result;
            }
            return remark;
        }
        public void excelCho(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "choles";

                int row = 1, k = 0, colCnt = 6;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_cho + " ประจำปี " + cuc.YearId;      //
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.cho_checkup + " หน้าที่  " + i;        //checkup
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.cho_test;      //test
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.ChoNormal;     //Normal
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.ChoAbNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Cholesterol  ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ค่าปกติ " + dtccpvn.Rows[0][ccpvndb.ccpvn.cholesterol].ToString();      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.cholesterol].ToString();
                        if (chkResult)
                        {
                            String result = "";
                            result = calCho(dt.Rows[k][ccpdb.ccp.cholesterol].ToString());
                            String[] result1 = result.Split('@');

                            xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            if (result1[1].Length > 0)
                            {
                                Microsoft.Office.Interop.Excel.Range rgPage1;
                                rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                                rgPage1.Font.Color = Color.Red;
                                rgPage1.Font.Bold = true;
                            }
                            //xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.cholesterolSuggess].ToString();
                            //xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.cholesterolSummary].ToString();
                        }
                        else
                        {
                            xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.cholesterolSuggess].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.cholesterolSummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelCho " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public void excelSgot(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "sgot";

                int row = 1, k = 0, colCnt = 7;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_sgot + " ประจำปี " + cuc.YearId;      //
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.sgot_checkup + " หน้าที่  " + i;        //checkup
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.sgot_test;      //test
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.SgotNormal;     //Normal
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.SgotAbNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "SGOT  ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ค่าปกติ M " + dtccpvn.Rows[0][ccpvndb.ccpvn.liverSgotMale].ToString()+" F "+ dtccpvn.Rows[0][ccpvndb.ccpvn.liverSgotFeMale].ToString();      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "SGPT  ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ค่าปกติ M " + dtccpvn.Rows[0][ccpvndb.ccpvn.liverSgptMale].ToString()+" F "+ dtccpvn.Rows[0][ccpvndb.ccpvn.liverSgptFeMale].ToString();      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.liverSgot].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.liverSgpt].ToString();
                        if (chkResult)
                        {
                            //String result = "";
                            //result = calCho(dt.Rows[k][ccpdb.ccp.cholesterol].ToString());
                            //String[] result1 = result.Split('@');

                            //xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            //xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            //if (result1[1].Length > 0)
                            //{
                            //    Microsoft.Office.Interop.Excel.Range rgPage1;
                            //    rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                            //    rgPage1.Font.Color = Color.Red;
                            //    rgPage1.Font.Bold = true;
                            //}
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.liverResult].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.liverSummary].ToString();
                        }
                        else
                        {
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.liverResult].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.liverSummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelSgot " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public void excelBUN(String cucId, Boolean chkResult)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;

            try
            {
                int pageCnt = 1, pagemod = 0, pageRow = 18;

                dt = ccpdb.selectAllByCucId(cucId);
                pageCnt = dt.Rows.Count / pageRow;
                pagemod = dt.Rows.Count % pageRow;
                if (pagemod > 0)
                {
                    pageCnt++;
                }

                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                xlWorksheet.Name = "bun";

                int row = 1, k = 0, colCnt = 7;
                for (int i = 1; i <= pageCnt; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range;
                    Microsoft.Office.Interop.Excel.Range rg;
                    range = xlWorksheet.Range[xlWorksheet.Cells[row, 1], xlWorksheet.Cells[row, colCnt]];
                    //range = xlWorksheet.get_Range("A1", "H1");
                    range.Cells[1, 1] = cop.report_sum_name_bun + " ประจำปี " + cuc.YearId;      //
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //Microsoft.Office.Interop.Excel.Range range1;
                    //range = xlWorksheet.Range[xlWorksheet.Cells[2, 1], xlWorksheet.Cells[2, 8]];
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 1, 1], xlWorksheet.Cells[row + 1, colCnt]];
                    range.Cells[1, 1] = " " + cuc.CustNameT;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 2, 1], xlWorksheet.Cells[row + 2, colCnt]];
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate + " จำนวนผู้เข้าตรวจทั้งหมด " + cuc.bun_checkup + " หน้าที่  " + i;        //checkup
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " มาตรวจ " + cuc.bun_test;      //test
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ปกติ " + cuc.BunNormal;     //Normal
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 10;
                    rg.Value2 = " ผิดปกติ " + cuc.BunAbNormal;     //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "BUN  ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ค่าปกติ M " + dtccpvn.Rows[0][ccpvndb.ccpvn.kidneyBunMale].ToString() + " F " + dtccpvn.Rows[0][ccpvndb.ccpvn.kidneyBunFemale].ToString();      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "Creatinie  ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 5];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ค่าปกติ M " + dtccpvn.Rows[0][ccpvndb.ccpvn.kidneyCreatinineMale].ToString() + " F " + dtccpvn.Rows[0][ccpvndb.ccpvn.kidneyCreatinineFemale].ToString();      //
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 5, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 4, 1], xlWorksheet.Cells[row + 5, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);

                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 6, 1], xlWorksheet.Cells[row + pageRow + 4, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        if (k >= dt.Rows.Count) continue;
                        xlWorksheet.Cells[row + j + 1 + 4, 1] = (k + 1);
                        xlWorksheet.Cells[row + j + 1 + 4, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 4] = dt.Rows[k][ccpdb.ccp.kidneyBun].ToString();
                        xlWorksheet.Cells[row + j + 1 + 4, 5] = dt.Rows[k][ccpdb.ccp.kidneyCreatinine].ToString();
                        if (chkResult)
                        {
                            //String result = "";
                            //result = calCho(dt.Rows[k][ccpdb.ccp.cholesterol].ToString());
                            //String[] result1 = result.Split('@');

                            //xlWorksheet.Cells[row + j + 1 + 4, 5] = result1[0];
                            //xlWorksheet.Cells[row + j + 1 + 4, 6] = result1[1];
                            //if (result1[1].Length > 0)
                            //{
                            //    Microsoft.Office.Interop.Excel.Range rgPage1;
                            //    rgPage1 = xlWorksheet.Range[xlWorksheet.Cells[row + j + 1 + 4, 5], xlWorksheet.Cells[row + j + 1 + 4, 6]];
                            //    rgPage1.Font.Color = Color.Red;
                            //    rgPage1.Font.Bold = true;
                            //}
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.kidneyResult].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.kidneySummary].ToString();
                        }
                        else
                        {
                            xlWorksheet.Cells[row + j + 1 + 4, 6] = dt.Rows[k][ccpdb.ccp.kidneyResult].ToString();
                            xlWorksheet.Cells[row + j + 1 + 4, 7] = dt.Rows[k][ccpdb.ccp.kidneySummary].ToString();
                        }
                        k++;
                    }

                    row = row + (pageRow + 5);
                }

                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelBUN " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
        }
        public void genExcelMini(String cucId)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            Company cop = new Company();
            cop = copdb.selectByPk();
            ExcelInitMini eim = new ExcelInitMini();
            eim = eiminidb.selectByPk();
            DataTable dt = new DataTable();

            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            dt = ccpdb.selectAllByCucId(cucId);
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = null;
            try
            {
                dt = ccpdb.selectAllByCucId(cucId);
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
                xlWorksheet.Name = "sheet1";
                xlWorksheet.Cells[1, 1] = "ลำดับที่";
                xlWorksheet.Cells[2, 1] = "hn";
                xlWorksheet.Cells[3, 1] = "รหัสพนักงาน";
                xlWorksheet.Cells[4, 1] = "ชื่อ_นามสกุล";
                xlWorksheet.Cells[5, 1] = "แผนก";
                xlWorksheet.Cells[6, 1] = "บริษัท";
                xlWorksheet.Cells[7, 1] = "วันที่ตรวจ";
                xlWorksheet.Cells[8, 1] = "หมายเหตุ";
                xlWorksheet.Cells[9, 1] = "Gender";
                xlWorksheet.Cells[10, 1] = "Regis";
                xlWorksheet.Cells[11, 1] = "PE";
                xlWorksheet.Cells[12, 1] = "BG";
                xlWorksheet.Cells[13, 1] = "อายุ";
                xlWorksheet.Cells[14, 1] = "นน.";
                xlWorksheet.Cells[15, 1] = "สูง";
                xlWorksheet.Cells[16, 1] = "BP";
                xlWorksheet.Cells[17, 1] = "Pulse";
                xlWorksheet.Cells[18, 1] = "BMI";
                xlWorksheet.Cells[19, 1] = "ผลBMI";
                xlWorksheet.Cells[20, 1] = "ผลBP";
                xlWorksheet.Cells[21, 1] = "ผลpulse";
                xlWorksheet.Cells[22, 1] = "สรุปPE";
                xlWorksheet.Cells[23, 1] = "คำแนะนำPE";
                xlWorksheet.Cells[24, 1] = "xray/digital";
                xlWorksheet.Cells[25, 1] = "ผลxray";
                xlWorksheet.Cells[26, 1] = "สรุปxray";
                xlWorksheet.Cells[27, 1] = "แนะนำxray";
                xlWorksheet.Cells[28, 1] = "CBC";
                xlWorksheet.Cells[29, 1] = "WBC";
                xlWorksheet.Cells[30, 1] = "HB";
                xlWorksheet.Cells[31, 1] = "RBC";
                xlWorksheet.Cells[32, 1] = "HCT";
                xlWorksheet.Cells[33, 1] = "MCV";
                xlWorksheet.Cells[34, 1] = "MCH";
                xlWorksheet.Cells[35, 1] = "MCHC";
                xlWorksheet.Cells[36, 1] = "plt C";
                xlWorksheet.Cells[37, 1] = "plt smr";
                xlWorksheet.Cells[38, 1] = "R.M";
                xlWorksheet.Cells[39, 1] = "ผลcbc";
                xlWorksheet.Cells[40, 1] = "สรุป CBC";
                xlWorksheet.Cells[41, 1] = "UA";
                xlWorksheet.Cells[42, 1] = "สี";
                xlWorksheet.Cells[43, 1] = "กรด";
                xlWorksheet.Cells[44, 1] = "sp.gr";
                xlWorksheet.Cells[45, 1] = "น้ำตาล";
                xlWorksheet.Cells[46, 1] = "โปรตีน";
                xlWorksheet.Cells[47, 1] = "คีโตน";
                xlWorksheet.Cells[48, 1] = "wbc1";
                xlWorksheet.Cells[49, 1] = "rbc1";
                xlWorksheet.Cells[50, 1] = "epi";
                xlWorksheet.Cells[51, 1] = "bac";
                xlWorksheet.Cells[52, 1] = "สรุปUA";
                xlWorksheet.Cells[53, 1] = "FBS";
                xlWorksheet.Cells[54, 1] = "ผลFBS";
                xlWorksheet.Cells[55, 1] = "ผลChol";
                xlWorksheet.Cells[56, 1] = "ผลTri";
                xlWorksheet.Cells[57, 1] = "ผลBUN";
                xlWorksheet.Cells[58, 1] = "ผลCreatinine";
                xlWorksheet.Cells[59, 1] = "ผลSgot";
                xlWorksheet.Cells[60, 1] = "ผลSgpt";
                xlWorksheet.Cells[61, 1] = "ผลHDL";
                xlWorksheet.Cells[62, 1] = "ผลLDL";
                xlWorksheet.Cells[63, 1] = "สรุปFBS";
                xlWorksheet.Cells[64, 1] = "แนะนำFBS";
                xlWorksheet.Cells[65, 1] = "Chol";
                xlWorksheet.Cells[66, 1] = "Tri";
                xlWorksheet.Cells[67, 1] = "สรุปChol_Tri";
                xlWorksheet.Cells[68, 1] = "แนะนำChol_Tri";
                xlWorksheet.Cells[69, 1] = "HDL_LDL";
                xlWorksheet.Cells[70, 1] = "สรุปHDL_LDL";
                xlWorksheet.Cells[71, 1] = "แนะนำHDL_LDL";
                xlWorksheet.Cells[72, 1] = "BUN,Crea";
                xlWorksheet.Cells[73, 1] = "สรุปBUN_Crea";
                xlWorksheet.Cells[74, 1] = "แนะนำBUN_Crea";
                xlWorksheet.Cells[75, 1] = "SS";
                xlWorksheet.Cells[76, 1] = "สรุปSS";
                xlWorksheet.Cells[77, 1] = "แนะนำSS";
                xlWorksheet.Cells[78, 1] = "Uric";
                xlWorksheet.Cells[79, 1] = "ผลUric";
                xlWorksheet.Cells[80, 1] = "สรุปUric";
                xlWorksheet.Cells[81, 1] = "แนะนำUric";
                xlWorksheet.Cells[82, 1] = "ALP";
                xlWorksheet.Cells[83, 1] = "สรุปALP";
                xlWorksheet.Cells[84, 1] = "แนะนำALP";
                xlWorksheet.Cells[85, 1] = "Bilirubin";
                xlWorksheet.Cells[86, 1] = "ผลBilirubin";
                xlWorksheet.Cells[87, 1] = "สรุปBilirubin";
                xlWorksheet.Cells[88, 1] = "แนะนำBilirubin";
                xlWorksheet.Cells[89, 1] = "HBs Ag";
                xlWorksheet.Cells[90, 1] = "ผลHBs Ag";
                xlWorksheet.Cells[91, 1] = "สรุปHBs Ag";
                xlWorksheet.Cells[92, 1] = "แนะนำHBs Ag";
                xlWorksheet.Cells[93, 1] = "HBs Ab";
                xlWorksheet.Cells[94, 1] = "ผลHBs Ab";
                xlWorksheet.Cells[95, 1] = "สรุปHBs Ab";
                xlWorksheet.Cells[96, 1] = "แนะนำHBs Ab";
                xlWorksheet.Cells[97, 1] = "HAV";
                xlWorksheet.Cells[98, 1] = "ผลHAV";
                xlWorksheet.Cells[99, 1] = "สรุปHAV";
                xlWorksheet.Cells[100, 1] = "แนะนำHAV";
                xlWorksheet.Cells[101, 1] = "Methamphetamine";
                xlWorksheet.Cells[102, 1] = "ผลMethamphetamine";
                xlWorksheet.Cells[103, 1] = "สรุปMethamphetamine";
                xlWorksheet.Cells[104, 1] = "แนะนำMethamphetamine";
                xlWorksheet.Cells[105, 1] = "AFP";
                xlWorksheet.Cells[106, 1] = "ผลAFP";
                xlWorksheet.Cells[107, 1] = "สรุปAFP";
                xlWorksheet.Cells[108, 1] = "แนะนำAFP";
                xlWorksheet.Cells[109, 1] = "CEA";
                xlWorksheet.Cells[110, 1] = "ผลCEA";
                xlWorksheet.Cells[111, 1] = "สรุปCEA";
                xlWorksheet.Cells[112, 1] = "แนะนำCEA";
                xlWorksheet.Cells[113, 1] = "PSA";
                xlWorksheet.Cells[114, 1] = "ผลPSA";
                xlWorksheet.Cells[115, 1] = "สรุปPSA";
                xlWorksheet.Cells[116, 1] = "แนะนำPSA";
                xlWorksheet.Cells[117, 1] = "Cholinesterase";
                xlWorksheet.Cells[118, 1] = "ผลCholinesterase";
                xlWorksheet.Cells[119, 1] = "สรุปCholinesterase";
                xlWorksheet.Cells[120, 1] = "แนะนำCholinesterase";
                xlWorksheet.Cells[121, 1] = "Stool Culture";
                xlWorksheet.Cells[122, 1] = "ผลS/C";
                xlWorksheet.Cells[123, 1] = "สรุปS/C";
                xlWorksheet.Cells[124, 1] = "แนะนำS/C";
                xlWorksheet.Cells[125, 1] = "Stool Exam";
                xlWorksheet.Cells[126, 1] = "สี/ลักษณะ";
                xlWorksheet.Cells[127, 1] = "ไข่/พยาธิ";
                xlWorksheet.Cells[128, 1] = "เม็ดเลือดขาว";
                xlWorksheet.Cells[129, 1] = "เม็ดเลือดแดง";
                xlWorksheet.Cells[130, 1] = "ผลS/E";
                xlWorksheet.Cells[131, 1] = "แนะนำS/E";
                xlWorksheet.Cells[132, 1] = "Occupation";
                xlWorksheet.Cells[133, 1] = "การมองระยะไกลโดยรวม";
                xlWorksheet.Cells[134, 1] = "การมองระยะไกลทั้งสองตา";
                xlWorksheet.Cells[135, 1] = "การมองระยะไกลตาขวา";
                xlWorksheet.Cells[136, 1] = "การมองระยะไกลตาซ้าย";
                xlWorksheet.Cells[137, 1] = "การมองภาพสามมิติระยะไกล";
                xlWorksheet.Cells[138, 1] = "การทดสอบตาบอดสี";
                xlWorksheet.Cells[139, 1] = "การมองพร้อมกันแนวดิ่ง";
                xlWorksheet.Cells[140, 1] = "การมองพร้อมกันแนวนอน";
                xlWorksheet.Cells[141, 1] = "การมองระยะใกล้ทั้งสองตา";
                xlWorksheet.Cells[142, 1] = "การมองระยะใกล้ตาขวา";
                xlWorksheet.Cells[143, 1] = "การมองระยะใกล้ตาซ้าย";
                xlWorksheet.Cells[144, 1] = "การปรับตัวของกล้ามเนื้อตาในแนวนอน";
                xlWorksheet.Cells[145, 1] = "สรุปผลการตรวจสายตาอาชีวอนามัย";
                xlWorksheet.Cells[146, 1] = "Audiogram";
                xlWorksheet.Cells[147, 1] = "500_R";
                xlWorksheet.Cells[148, 1] = "1k_R";
                xlWorksheet.Cells[149, 1] = "2k_R";
                xlWorksheet.Cells[150, 1] = "3k_R";
                xlWorksheet.Cells[151, 1] = "4k_R";
                xlWorksheet.Cells[152, 1] = "6k_R";
                xlWorksheet.Cells[153, 1] = "8k_R";
                xlWorksheet.Cells[154, 1] = "สรุปหูขวา1";
                xlWorksheet.Cells[155, 1] = "สรุปหูขวา2";
                xlWorksheet.Cells[156, 1] = "สรุปรวมหูขวา";
                xlWorksheet.Cells[157, 1] = "500_L";
                xlWorksheet.Cells[158, 1] = "1k_L";
                xlWorksheet.Cells[159, 1] = "2k_L";
                xlWorksheet.Cells[160, 1] = "3k_L";
                xlWorksheet.Cells[161, 1] = "4k_L";
                xlWorksheet.Cells[162, 1] = "6k_L";
                xlWorksheet.Cells[163, 1] = "8k_L";
                xlWorksheet.Cells[164, 1] = "สรุปหูซ้าย1";
                xlWorksheet.Cells[165, 1] = "สรุปหูซ้าย2";
                xlWorksheet.Cells[166, 1] = "สรุปรวมหูซ้าย";
                xlWorksheet.Cells[167, 1] = "สรุปหูสองข้าง";
                xlWorksheet.Cells[168, 1] = "หมายเหตุ";
                xlWorksheet.Cells[169, 1] = "Lung";
                xlWorksheet.Cells[170, 1] = "FVC%Pred";
                xlWorksheet.Cells[171, 1] = "FEV 1/FVC%Meas";
                xlWorksheet.Cells[172, 1] = "FEV 1/FVC%Pred";
                xlWorksheet.Cells[173, 1] = "FEV 1/FVC%/%Pred";
                xlWorksheet.Cells[174, 1] = "ผลตรวจLFT";
                xlWorksheet.Cells[175, 1] = "สรุปLFT";
                xlWorksheet.Cells[176, 1] = "แนะนำLFT";
                xlWorksheet.Cells[177, 1] = "EKG";
                xlWorksheet.Cells[178, 1] = "ผลEKG";
                xlWorksheet.Cells[179, 1] = "สรุปEKG";
                xlWorksheet.Cells[180, 1] = "แนะนำEKG";
                xlWorksheet.Cells[181, 1] = "กล้ามเนื้อแขนขา";
                xlWorksheet.Cells[182, 1] = "ผลแขน";
                xlWorksheet.Cells[183, 1] = "ผลขา";
                xlWorksheet.Cells[184, 1] = "สรุปแขนขา";
                xlWorksheet.Cells[185, 1] = "Inner Scan";
                xlWorksheet.Cells[186, 1] = "%ไขมัน";
                xlWorksheet.Cells[187, 1] = "ผลไขมันสะสมในร่างกาย";
                xlWorksheet.Cells[188, 1] = "% น้ำ";
                xlWorksheet.Cells[189, 1] = "ระดับไขมันในท้อง";
                xlWorksheet.Cells[190, 1] = "ผลไขมันในช่องท้อง";
                xlWorksheet.Cells[191, 1] = "กล้าม เนื้อ";
                xlWorksheet.Cells[192, 1] = "ระดับ";
                xlWorksheet.Cells[193, 1] = "ผลกล้ามเนื้อ";
                xlWorksheet.Cells[194, 1] = "น.น.กระดูก";
                xlWorksheet.Cells[195, 1] = "ผลกระดูก";
                xlWorksheet.Cells[196, 1] = "ค่าปกติกระดูก ชาย";
                xlWorksheet.Cells[197, 1] = "ค่าปกติกระดูก หญิง";
                xlWorksheet.Cells[198, 1] = "BMR";
                xlWorksheet.Cells[199, 1] = "อายุจริง";
                xlWorksheet.Cells[200, 1] = "Age";
                xlWorksheet.Cells[200, 1] = "ผล BMR";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    xlWorksheet.Cells[i, 1] = "";
                }
                //xlWorkbook.SaveAs(initC.pathMini+"")
                xlApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error excelBUN " + ex.InnerException, "message " + ex.Message);
            }
            finally
            {

            }
            Cursor.Current = cursor;
            
        }
        
        public void getTextSticker(String cucId)
        {
            String col01="", col02="", col03="", col04="", col05="", col06 = "";
            DataTable dt = new DataTable();
            DataTable dtStk = new DataTable();
            dt = ccpdb.selectAllByCucId(cucId);
            dtStk = stkdb.selectAll();
            using (var tw = new StreamWriter("CheckList.txt", false))
            {
                int row = 0;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    row = i + 1;
                    col01 = row.ToString("0000");
                    col02 = " ";
                    col03 = dt.Rows[i][ccpdb.ccp.patientFullname].ToString();
                    //col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString();
                    //col05 = dt.Rows[i][ccpdb.ccp.patientFullname].ToString();
                    col06 = dt.Rows[i][ccpdb.ccp.departmentName].ToString();
                    if (dt.Rows[i][ccpdb.ccp.sticker01].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString()+"-01";
                        col05 = dtStk.Rows[0][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker02].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-02";
                        col05 = dtStk.Rows[1][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker03].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-03";
                        col05 = dtStk.Rows[2][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker04].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-04";
                        col05 = dtStk.Rows[3][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker05].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-05";
                        col05 = dtStk.Rows[4][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker06].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-06";
                        col05 = dtStk.Rows[5][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker07].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-07";
                        col05 = dtStk.Rows[6][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker08].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-08";
                        col05 = dtStk.Rows[7][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker09].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-09";
                        col05 = dtStk.Rows[8][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker10].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-10";
                        col05 = dtStk.Rows[9][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker11].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-11";
                        col05 = dtStk.Rows[10][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker12].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-12";
                        col05 = dtStk.Rows[11][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker13].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-13";
                        col05 = dtStk.Rows[12][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker14].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-14";
                        col05 = dtStk.Rows[13][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker15].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-15";
                        col05 = dtStk.Rows[14][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker16].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-16";
                        col05 = dtStk.Rows[15][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker17].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-17";
                        col05 = dtStk.Rows[16][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker18].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-18";
                        col05 = dtStk.Rows[17][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker19].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-19";
                        col05 = dtStk.Rows[18][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker20].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-20";
                        col05 = dtStk.Rows[19][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                }
            }
        }
    }
}
