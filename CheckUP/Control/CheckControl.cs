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
using System.Threading;
using System.Globalization;

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
                //MessageBox.Show("33333 "+ Path.Combine(Environment.CurrentDirectory, Application.ProductName+".ini"), "Error");
                iniFile = new IniFile(Path.Combine(Environment.CurrentDirectory, Application.ProductName+".ini"));
                //MessageBox.Show("4444  " + iniFile.Path, "Error");
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
            //initC.statusonsite = iniFile.Read("nameDBonsite");

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
            initC.nameRemoteClient  = iniFile.Read("nameRemoteClient");     //ไม่ได้ใช้แล้ว
            initC.statusconnectCEM = iniFile.Read("statusconnectCEM");
            initC.pathaccessCEM = iniFile.Read("pathaccessCEM");
            initC.pathdataCEM = iniFile.Read("pathdataCEM");

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
        public void SetPathImage(String path)
        {
            iniFile.Write("pathimage", path);
        }
        public void SetPathMini(String path)
        {
            iniFile.Write("pathMini", path);
        }
        public void SetPathAccessCEM(String path)
        {
            iniFile.Write("pathaccessCEM", path);
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
                if (sf.Password.Equals(""))
                {
                    chk = false;
                }
                else if (sf.Password.Equals(password))
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
        public String datetoDB(String dt)
        {
            DateTime dt1 = new DateTime();
            String re = "";
            if (dt != null)
            {
                if (!dt.Equals(""))
                {
                    // Thread แบบนี้ ทำให้ โปรแกรม ที่ไปลงที Xtrim ไม่เอา date ผิด
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us")
                    {
                        DateTimeFormat =
                        {
                            DateSeparator = "-"
                        }
                    };
                    dt1 = DateTime.Parse(dt.ToString());
                    re = dt1.Year.ToString() + "-" + dt1.ToString("MM-dd");
                }
            }
            return re;
        }
        public String datetoDB1(String dt)
        {
            DateTime dt1 = new DateTime();
            String re = "";
            if (dt != null)
            {
                if (!dt.Equals(""))
                {
                    dt1 = DateTime.Parse(dt.ToString());
                    re = dt1.Year.ToString() + "-" + dt1.ToString("MM-dd");
                }
            }
            return re;
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
            //MessageBox.Show("111 " + sql, "message ");
            //stkdb.deleteOnSiteAll();
            //cucdb.deleteOnSiteAll();
            //ccpdb.deleteOnSiteAll();
            //ccp1db.deleteOnSiteAll();

            stkdb.insertToOnSite();
            cucdb.insertToOnSite(cucId);
            //ccp1db.insertToOnSite(cucId);

            ccpdb.insertToOnSite(cucId);
            
            //MessageBox.Show("222 " + sql, "message ");
            
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
            String filename = "", pathfile="";
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
            object misValue = System.Reflection.Missing.Value;
            pathfile = initC.pathMini+"\\" + cuc.YearId + "\\" + cuc.CustNameT + "\\";
            System.IO.Directory.CreateDirectory(pathfile);
            filename = pathfile + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            try
            {
                dt = ccpdb.selectAllByCucId(cucId);
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = (xlApp.Workbooks.Add(Missing.Value));
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
                xlWorksheet.Name = "sheet1";
                xlWorksheet.Cells[1,1] = "ลำดับที่";
                xlWorksheet.Cells[1,2] = "hn";
                xlWorksheet.Cells[1,3] = "รหัสพนักงาน";
                xlWorksheet.Cells[1,4] = "ชื่อ_นามสกุล";
                xlWorksheet.Cells[1,5] = "แผนก";
                xlWorksheet.Cells[1,6] = "บริษัท";
                xlWorksheet.Cells[1,7] = "วันที่ตรวจ";
                xlWorksheet.Cells[1,8] = "หมายเหตุ";
                xlWorksheet.Cells[1,9] = "Gender";
                xlWorksheet.Cells[1,10] = "Regis";
                xlWorksheet.Cells[1,11] = "PE";
                xlWorksheet.Cells[1,12] = "BG";
                xlWorksheet.Cells[1,13] = "อายุ";
                xlWorksheet.Cells[1,14] = "นน.";
                xlWorksheet.Cells[1,15] = "สูง";
                xlWorksheet.Cells[1,16] = "BP";
                xlWorksheet.Cells[1,17] = "Pulse";
                xlWorksheet.Cells[1,18] = "BMI";
                xlWorksheet.Cells[1,19] = "ผลBMI";
                xlWorksheet.Cells[1,20] = "ผลBP";
                xlWorksheet.Cells[1,21] = "ผลpulse";
                xlWorksheet.Cells[1,22] = "สรุปPE";
                xlWorksheet.Cells[1,23] = "คำแนะนำPE";
                xlWorksheet.Cells[1,24] = "xray/digital";
                xlWorksheet.Cells[1,25] = "ผลxray";
                xlWorksheet.Cells[1,26] = "สรุปxray";
                xlWorksheet.Cells[1,27] = "แนะนำxray";
                xlWorksheet.Cells[1,28] = "CBC";
                xlWorksheet.Cells[1,29] = "WBC";
                xlWorksheet.Cells[1,30] = "HB";
                xlWorksheet.Cells[1,31] = "RBC";
                xlWorksheet.Cells[1,32] = "HCT";
                xlWorksheet.Cells[1,33] = "MCV";
                xlWorksheet.Cells[1,34] = "MCH";
                xlWorksheet.Cells[1,35] = "MCHC";
                xlWorksheet.Cells[1,36] = "plt C";
                xlWorksheet.Cells[1,37] = "plt smr";
                xlWorksheet.Cells[1,38] = "R.M";
                xlWorksheet.Cells[1,39] = "ผลcbc";
                xlWorksheet.Cells[1,40] = "สรุป CBC";
                xlWorksheet.Cells[1,41] = "UA";
                xlWorksheet.Cells[1,42] = "สี";
                xlWorksheet.Cells[1,43] = "กรด";
                xlWorksheet.Cells[1,44] = "sp.gr";
                xlWorksheet.Cells[1,45] = "น้ำตาล";
                xlWorksheet.Cells[1,46] = "โปรตีน";
                xlWorksheet.Cells[1,47] = "คีโตน";
                xlWorksheet.Cells[1,48] = "wbc1";
                xlWorksheet.Cells[1,49] = "rbc1";
                xlWorksheet.Cells[1,50] = "epi";
                xlWorksheet.Cells[1,51] = "bac";
                xlWorksheet.Cells[1,52] = "สรุปUA";
                xlWorksheet.Cells[1,53] = "FBS";
                xlWorksheet.Cells[1,54] = "ผลFBS";
                xlWorksheet.Cells[1,55] = "ผลChol";
                xlWorksheet.Cells[1,56] = "ผลTri";
                xlWorksheet.Cells[1,57] = "ผลBUN";
                xlWorksheet.Cells[1,58] = "ผลCreatinine";
                xlWorksheet.Cells[1,59] = "ผลSgot";
                xlWorksheet.Cells[1,60] = "ผลSgpt";
                xlWorksheet.Cells[1,61] = "ผลHDL";
                xlWorksheet.Cells[1,62] = "ผลLDL";
                xlWorksheet.Cells[1,63] = "สรุปFBS";
                xlWorksheet.Cells[1,64] = "แนะนำFBS";
                xlWorksheet.Cells[1,65] = "Chol";
                xlWorksheet.Cells[1,66] = "Tri";
                xlWorksheet.Cells[1,67] = "สรุปChol_Tri";
                xlWorksheet.Cells[1,68] = "แนะนำChol_Tri";
                xlWorksheet.Cells[1,69] = "HDL_LDL";
                xlWorksheet.Cells[1,70] = "สรุปHDL_LDL";
                xlWorksheet.Cells[1,71] = "แนะนำHDL_LDL";
                xlWorksheet.Cells[1,72] = "BUN,Crea";
                xlWorksheet.Cells[1,73] = "สรุปBUN_Crea";
                xlWorksheet.Cells[1,74] = "แนะนำBUN_Crea";
                xlWorksheet.Cells[1,75] = "SS";
                xlWorksheet.Cells[1,76] = "สรุปSS";
                xlWorksheet.Cells[1,77] = "แนะนำSS";
                xlWorksheet.Cells[1,78] = "Uric";
                xlWorksheet.Cells[1,79] = "ผลUric";
                xlWorksheet.Cells[1,80] = "สรุปUric";
                xlWorksheet.Cells[1,81] = "แนะนำUric";
                xlWorksheet.Cells[1,82] = "ALP";
                xlWorksheet.Cells[1,83] = "สรุปALP";
                xlWorksheet.Cells[1,84] = "แนะนำALP";
                xlWorksheet.Cells[1,85] = "Bilirubin";
                xlWorksheet.Cells[1,86] = "ผลBilirubin";
                xlWorksheet.Cells[1,87] = "สรุปBilirubin";
                xlWorksheet.Cells[1,88] = "แนะนำBilirubin";
                xlWorksheet.Cells[1,89] = "HBs Ag";
                xlWorksheet.Cells[1,90] = "ผลHBs Ag";
                xlWorksheet.Cells[1,91] = "สรุปHBs Ag";
                xlWorksheet.Cells[1,92] = "แนะนำHBs Ag";
                xlWorksheet.Cells[1,93] = "HBs Ab";
                xlWorksheet.Cells[1,94] = "ผลHBs Ab";
                xlWorksheet.Cells[1,95] = "สรุปHBs Ab";
                xlWorksheet.Cells[1,96] = "แนะนำHBs Ab";
                xlWorksheet.Cells[1,97] = "HAV";
                xlWorksheet.Cells[1,98] = "ผลHAV";
                xlWorksheet.Cells[1,99] = "สรุปHAV";
                xlWorksheet.Cells[1,100] = "แนะนำHAV";
                xlWorksheet.Cells[1,101] = "Methamphetamine";
                xlWorksheet.Cells[1,102] = "ผลMethamphetamine";
                xlWorksheet.Cells[1,103] = "สรุปMethamphetamine";
                xlWorksheet.Cells[1,104] = "แนะนำMethamphetamine";
                xlWorksheet.Cells[1,105] = "AFP";
                xlWorksheet.Cells[1,106] = "ผลAFP";
                xlWorksheet.Cells[1,107] = "สรุปAFP";
                xlWorksheet.Cells[1,108] = "แนะนำAFP";
                xlWorksheet.Cells[1,109] = "CEA";
                xlWorksheet.Cells[1,110] = "ผลCEA";
                xlWorksheet.Cells[1,111] = "สรุปCEA";
                xlWorksheet.Cells[1,112] = "แนะนำCEA";
                xlWorksheet.Cells[1,113] = "PSA";
                xlWorksheet.Cells[1,114] = "ผลPSA";
                xlWorksheet.Cells[1,115] = "สรุปPSA";
                xlWorksheet.Cells[1,116] = "แนะนำPSA";
                xlWorksheet.Cells[1,117] = "Cholinesterase";
                xlWorksheet.Cells[1,118] = "ผลCholinesterase";
                xlWorksheet.Cells[1,119] = "สรุปCholinesterase";
                xlWorksheet.Cells[1,120] = "แนะนำCholinesterase";
                xlWorksheet.Cells[1,121] = "Stool Culture";
                xlWorksheet.Cells[1,122] = "ผลS/C";
                xlWorksheet.Cells[1,123] = "สรุปS/C";
                xlWorksheet.Cells[1,124] = "แนะนำS/C";
                xlWorksheet.Cells[1,125] = "Stool Exam";
                xlWorksheet.Cells[1,126] = "สี/ลักษณะ";
                xlWorksheet.Cells[1,127] = "ไข่/พยาธิ";
                xlWorksheet.Cells[1,128] = "เม็ดเลือดขาว";
                xlWorksheet.Cells[1,129] = "เม็ดเลือดแดง";
                xlWorksheet.Cells[1,130] = "ผลS/E";
                xlWorksheet.Cells[1,131] = "แนะนำS/E";
                xlWorksheet.Cells[1,132] = "Occupation";
                xlWorksheet.Cells[1,133] = "การมองระยะไกลโดยรวม";
                xlWorksheet.Cells[1,134] = "การมองระยะไกลทั้งสองตา";
                xlWorksheet.Cells[1,135] = "การมองระยะไกลตาขวา";
                xlWorksheet.Cells[1,136] = "การมองระยะไกลตาซ้าย";
                xlWorksheet.Cells[1,137] = "การมองภาพสามมิติระยะไกล";
                xlWorksheet.Cells[1,138] = "การทดสอบตาบอดสี";
                xlWorksheet.Cells[1,139] = "การมองพร้อมกันแนวดิ่ง";
                xlWorksheet.Cells[1,140] = "การมองพร้อมกันแนวนอน";
                xlWorksheet.Cells[1,141] = "การมองระยะใกล้ทั้งสองตา";
                xlWorksheet.Cells[1,142] = "การมองระยะใกล้ตาขวา";
                xlWorksheet.Cells[1,143] = "การมองระยะใกล้ตาซ้าย";
                xlWorksheet.Cells[1,144] = "การปรับตัวของกล้ามเนื้อตาในแนวนอน";
                xlWorksheet.Cells[1,145] = "สรุปผลการตรวจสายตาอาชีวอนามัย";
                xlWorksheet.Cells[1,146] = "Audiogram";
                xlWorksheet.Cells[1,147] = "500_R";
                xlWorksheet.Cells[1,148] = "1k_R";
                xlWorksheet.Cells[1,149] = "2k_R";
                xlWorksheet.Cells[1,150] = "3k_R";
                xlWorksheet.Cells[1,151] = "4k_R";
                xlWorksheet.Cells[1,152] = "6k_R";
                xlWorksheet.Cells[1,153] = "8k_R";
                xlWorksheet.Cells[1,154] = "สรุปหูขวา1";
                xlWorksheet.Cells[1,155] = "สรุปหูขวา2";
                xlWorksheet.Cells[1,156] = "สรุปรวมหูขวา";
                xlWorksheet.Cells[1,157] = "500_L";
                xlWorksheet.Cells[1,158] = "1k_L";
                xlWorksheet.Cells[1,159] = "2k_L";
                xlWorksheet.Cells[1,160] = "3k_L";
                xlWorksheet.Cells[1,161] = "4k_L";
                xlWorksheet.Cells[1,162] = "6k_L";
                xlWorksheet.Cells[1,163] = "8k_L";
                xlWorksheet.Cells[1,164] = "สรุปหูซ้าย1";
                xlWorksheet.Cells[1,165] = "สรุปหูซ้าย2";
                xlWorksheet.Cells[1,166] = "สรุปรวมหูซ้าย";
                xlWorksheet.Cells[1,167] = "สรุปหูสองข้าง";
                xlWorksheet.Cells[1,168] = "หมายเหตุ";
                xlWorksheet.Cells[1,169] = "Lung";
                xlWorksheet.Cells[1,170] = "FVC%Pred";
                xlWorksheet.Cells[1,171] = "FEV 1/FVC%Meas";
                xlWorksheet.Cells[1,172] = "FEV 1/FVC%Pred";
                xlWorksheet.Cells[1,173] = "FEV 1/FVC%/%Pred";
                xlWorksheet.Cells[1,174] = "ผลตรวจLFT";
                xlWorksheet.Cells[1,175] = "สรุปLFT";
                xlWorksheet.Cells[1,176] = "แนะนำLFT";
                xlWorksheet.Cells[1,177] = "EKG";
                xlWorksheet.Cells[1,178] = "ผลEKG";
                xlWorksheet.Cells[1,179] = "สรุปEKG";
                xlWorksheet.Cells[1,180] = "แนะนำEKG";
                xlWorksheet.Cells[1,181] = "กล้ามเนื้อแขนขา";
                xlWorksheet.Cells[1,182] = "ผลแขน";
                xlWorksheet.Cells[1,183] = "ผลขา";
                xlWorksheet.Cells[1,184] = "สรุปแขนขา";
                xlWorksheet.Cells[1,185] = "Inner Scan";
                xlWorksheet.Cells[1,186] = "%ไขมัน";
                xlWorksheet.Cells[1,187] = "ผลไขมันสะสมในร่างกาย";
                xlWorksheet.Cells[1,188] = "% น้ำ";
                xlWorksheet.Cells[1,189] = "ระดับไขมันในท้อง";
                xlWorksheet.Cells[1,190] = "ผลไขมันในช่องท้อง";
                xlWorksheet.Cells[1,191] = "กล้าม เนื้อ";
                xlWorksheet.Cells[1,192] = "ระดับ";
                xlWorksheet.Cells[1,193] = "ผลกล้ามเนื้อ";
                xlWorksheet.Cells[1,194] = "น.น.กระดูก";
                xlWorksheet.Cells[1,195] = "ผลกระดูก";
                xlWorksheet.Cells[1,196] = "ค่าปกติกระดูก ชาย";
                xlWorksheet.Cells[1,197] = "ค่าปกติกระดูก หญิง";
                xlWorksheet.Cells[1,198] = "BMR";
                xlWorksheet.Cells[1,199] = "อายุจริง";
                xlWorksheet.Cells[1,200] = "Age";
                xlWorksheet.Cells[1,201] = "ผล BMR";

                xlWorksheet.Cells[1, 202] = "ลักษณะ";
                xlWorksheet.Cells[1, 203] = "ผลAluminium";
                xlWorksheet.Cells[1, 204] = "ผลCadmium";
                xlWorksheet.Cells[1, 205] = "ผลLead";
                xlWorksheet.Cells[1, 206] = "ผลMercury";
                xlWorksheet.Cells[1, 207] = "สรุปAluminium";
                xlWorksheet.Cells[1, 208] = "แนะนำAluminium";
                xlWorksheet.Cells[1, 209] = "สรุปCadmium";
                xlWorksheet.Cells[1, 210] = "แนะนำCadmium";
                xlWorksheet.Cells[1, 211] = "สรุปLead";
                xlWorksheet.Cells[1, 212] = "แนะนำLead";
                xlWorksheet.Cells[1, 213] = "สรุปMercury";
                xlWorksheet.Cells[1, 214] = "แนะนำMercury";
                xlWorksheet.Cells[1, 214] = "เม็ดเลือดแดง_เม็ดเลือดแดง_";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    xlWorksheet.Cells[(i + 2), 1] = dt.Rows[i][ccpdb.ccp.rowNumber].ToString();
                    xlWorksheet.Cells[(i + 2), 2] = dt.Rows[i][ccpdb.ccp.visitHn].ToString();
                    xlWorksheet.Cells[(i + 2), 3] = dt.Rows[i][ccpdb.ccp.patientNumber].ToString();
                    xlWorksheet.Cells[(i + 2), 4] = dt.Rows[i][ccpdb.ccp.patientFullname].ToString();
                    xlWorksheet.Cells[(i + 2), 6] = cuc.CustNameT;
                    xlWorksheet.Cells[(i + 2), 9] = dt.Rows[i][ccpdb.ccp.SexName].ToString();
                    xlWorksheet.Cells[(i + 2), 13] = dt.Rows[i][ccpdb.ccp.patientAge].ToString();
                    xlWorksheet.Cells[(i + 2), 14] = dt.Rows[i][ccpdb.ccp.patientWeight].ToString();
                    xlWorksheet.Cells[(i + 2), 15] = dt.Rows[i][ccpdb.ccp.patientHeight].ToString();
                    xlWorksheet.Cells[(i + 2), 16] = dt.Rows[i][ccpdb.ccp.vitalsign].ToString();

                    
                }

                //xlWorksheet.SaveAs(@filename, SpreadsheetGear.FileFormat.XLS97);
                xlApp.Visible = true;
                //xlWorksheet.Close(true, misValue, misValue);
                //xlWorksheet.Dispose();
                

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
            using (var tw = new StreamWriter(Path.Combine(System.IO.Directory.GetCurrentDirectory(),"CheckList.txt"), false))
            {
                int row = 0;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    row = i + 1;
                    //col01 = row.ToString("0000");
                    col01 = dt.Rows[i][ccpdb.ccp.rowNumber].ToString();
                    col02 = " ";
                    col03 = dt.Rows[i][ccpdb.ccp.patientFullname].ToString();
                    //col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString();
                    //col05 = dt.Rows[i][ccpdb.ccp.patientFullname].ToString();
                    col06 = dt.Rows[i][ccpdb.ccp.departmentName].ToString();
                    if (dt.Rows[i][ccpdb.ccp.sticker01].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString()+"-01";
                        col05 = dtStk.Rows[0][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker02].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-02";
                        col05 = dtStk.Rows[1][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker03].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-03";
                        col05 = dtStk.Rows[2][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker04].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-04";
                        col05 = dtStk.Rows[3][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker05].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-05";
                        col05 = dtStk.Rows[4][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker06].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-06";
                        col05 = dtStk.Rows[5][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker07].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-07";
                        col05 = dtStk.Rows[6][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker08].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-08";
                        col05 = dtStk.Rows[7][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" );
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker09].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-09";
                        col05 = dtStk.Rows[8][stkdb.stk.sticker_name].ToString();
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" );
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker10].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-10";
                        col05 = dtStk.Rows[9][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker11].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-11";
                        col05 = dtStk.Rows[10][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker12].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-12";
                        col05 = dtStk.Rows[11][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker13].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-13";
                        col05 = dtStk.Rows[12][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker14].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-14";
                        col05 = dtStk.Rows[13][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker15].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-15";
                        col05 = dtStk.Rows[14][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker16].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-16";
                        col05 = dtStk.Rows[15][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker17].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-17";
                        col05 = dtStk.Rows[16][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" );
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker18].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-18";
                        col05 = dtStk.Rows[17][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker19].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-19";
                        col05 = dtStk.Rows[18][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" );
                    }
                    if (dt.Rows[i][ccpdb.ccp.sticker20].ToString().Equals("1"))
                    {
                        col04 = dt.Rows[i][ccpdb.ccp.visitHn].ToString() + "-20";
                        col05 = dtStk.Rows[19][stkdb.stk.sticker_name].ToString();
                        //tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|" + col06);
                        tw.WriteLine(col01 + "|" + col02 + "|" + col03 + "|" + col04 + "|" + col05 + "|");
                    }
                }
            }
        }
        public void importSticker(String cucId, String filename, String rowStart, String nmdVisitHn, ProgressBar pB1)
        {
            String visitHn = "", txt1="", txt2 = "", txt3 = "", txt4 = "", txt5 = "", txt6 = "", txt7 = "", txt8 = "", txt9 = "", txt10 = "";
            String txt11 = "", txt12 = "", txt13 = "", txt14 = "", txt15 = "", txt16 = "", txt17 = "", txt18 = "", txt19 = "", txt20 = "";
            int rowstart=0, colvisithn=0, chk=0;
            if (!fileExit(filename))
            {
                MessageBox.Show("ไม่พบ file Excel", "");
                return;
            }
            Cursor cursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            CustCheckUpPatient ccp = new CustCheckUpPatient();
            if(!int.TryParse(rowStart, out rowstart))
            {
                MessageBox.Show("Error rowStart", "");
                return;
            }
            if (!int.TryParse(nmdVisitHn, out colvisithn))
            {
                MessageBox.Show("Error visithn", "");
                return;
            }
            pB1.Visible = true;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filename);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.ActiveSheet;
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            int rowCount = xlRange.Rows.Count;
            pB1.Maximum = rowCount;

            txt1 = xlRange.Cells[1, colvisithn + 3].Value2 != null ? xlRange.Cells[1, colvisithn + 3].Value2.ToString() : "";   //PE                
            txt2 = xlRange.Cells[1, colvisithn + 4].Value2 != null ? xlRange.Cells[1, colvisithn + 4].Value2.ToString() : "";   //PE                
            txt3 = xlRange.Cells[1, colvisithn + 5].Value2 != null ? xlRange.Cells[1, colvisithn + 5].Value2.ToString() : "";   //PE                
            txt4 = xlRange.Cells[1, colvisithn + 6].Value2 != null ? xlRange.Cells[1, colvisithn + 6].Value2.ToString() : "";   //PE                
            txt5 = xlRange.Cells[1, colvisithn + 7].Value2 != null ? xlRange.Cells[1, colvisithn + 7].Value2.ToString() : "";   //PE                
            txt6 = xlRange.Cells[1, colvisithn + 8].Value2 != null ? xlRange.Cells[1, colvisithn + 8].Value2.ToString() : "";   //PE                
            txt7 = xlRange.Cells[1, colvisithn + 9].Value2 != null ? xlRange.Cells[1, colvisithn + 9].Value2.ToString() : "";   //PE                
            txt8 = xlRange.Cells[1, colvisithn + 10].Value2 != null ? xlRange.Cells[1, colvisithn + 10].Value2.ToString() : "";   //PE                
            txt9 = xlRange.Cells[1, colvisithn + 11].Value2 != null ? xlRange.Cells[1, colvisithn + 11].Value2.ToString() : "";   //PE                
            txt10 = xlRange.Cells[1, colvisithn + 12].Value2 != null ? xlRange.Cells[1, colvisithn + 12].Value2.ToString() : "";   //PE                
            txt11 = xlRange.Cells[1, colvisithn + 13].Value2 != null ? xlRange.Cells[1, colvisithn + 13].Value2.ToString() : "";   //PE                
            txt12 = xlRange.Cells[1, colvisithn + 14].Value2 != null ? xlRange.Cells[1, colvisithn + 14].Value2.ToString() : "";   //PE                
            txt13 = xlRange.Cells[1, colvisithn + 15].Value2 != null ? xlRange.Cells[1, colvisithn + 15].Value2.ToString() : "";   //PE                
            txt14 = xlRange.Cells[1, colvisithn + 16].Value2 != null ? xlRange.Cells[1, colvisithn + 16].Value2.ToString() : "";   //PE                
            txt15 = xlRange.Cells[1, colvisithn + 17].Value2 != null ? xlRange.Cells[1, colvisithn + 17].Value2.ToString() : "";   //PE                
            txt16 = xlRange.Cells[1, colvisithn + 18].Value2 != null ? xlRange.Cells[1, colvisithn + 18].Value2.ToString() : "";   //PE                
            txt17 = xlRange.Cells[1, colvisithn + 19].Value2 != null ? xlRange.Cells[1, colvisithn + 19].Value2.ToString() : "";   //PE                
            txt18 = xlRange.Cells[1, colvisithn + 20].Value2 != null ? xlRange.Cells[1, colvisithn + 20].Value2.ToString() : "";   //PE                
            txt19 = xlRange.Cells[1, colvisithn + 21].Value2 != null ? xlRange.Cells[1, colvisithn + 21].Value2.ToString() : "";   //PE                
            txt20 = xlRange.Cells[1, colvisithn + 22].Value2 != null ? xlRange.Cells[1, colvisithn + 22].Value2.ToString() : "";   //PE

            cucdb.updateStickerName(cucId, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20);

            for (int i = rowstart; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, colvisithn].Value2 != null)
                {
                    visitHn = xlRange.Cells[i, colvisithn].Value2.ToString();
                }
                else
                {
                    visitHn = "";
                }
                //txt = xlRange.Cells[i, visithn+2].Value2.ToString();                    
                txt1 = xlRange.Cells[i, colvisithn + 3].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 3].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt2 = xlRange.Cells[i, colvisithn + 4].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 4].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt3 = xlRange.Cells[i, colvisithn + 5].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 5].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt4 = xlRange.Cells[i, colvisithn + 6].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 6].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt5 = xlRange.Cells[i, colvisithn + 7].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 7].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt6 = xlRange.Cells[i, colvisithn + 8].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 8].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt7 = xlRange.Cells[i, colvisithn + 9].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 9].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt8 = xlRange.Cells[i, colvisithn + 10].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 10].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt9 = xlRange.Cells[i, colvisithn + 11].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 11].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt10 = xlRange.Cells[i, colvisithn + 12].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 12].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt11 = xlRange.Cells[i, colvisithn + 13].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 13].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt12 = xlRange.Cells[i, colvisithn + 14].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 14].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt13 = xlRange.Cells[i, colvisithn + 15].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 15].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt14 = xlRange.Cells[i, colvisithn + 16].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 16].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt15 = xlRange.Cells[i, colvisithn + 17].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 17].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt16 = xlRange.Cells[i, colvisithn + 18].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 18].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt17 = xlRange.Cells[i, colvisithn + 19].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 19].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt18 = xlRange.Cells[i, colvisithn + 20].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 20].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt19 = xlRange.Cells[i, colvisithn + 21].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 21].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE                
                txt20 = xlRange.Cells[i, colvisithn + 22].Value2 != null ? int.TryParse(xlRange.Cells[i, colvisithn + 22].Value2.ToString(), out chk) ? chk.ToString() : "0" : "0";   //PE
                ccpdb.UpdateSticker(visitHn.ToString(), cucId, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20);
                pB1.Value = i;
            }
            pB1.Visible = false;
        }
        public ComboBox getCboSticker(String cucId, ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            //stkdb.getCboSticker(c);
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
            DataTable dt = stkdb.selectAll();
            c.Items.Clear();
            if (cuc.sticker01.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[0][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[0][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[0][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker02.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[1][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[1][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[1][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker03.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[2][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[2][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[2][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker04.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[3][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[3][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[3][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker05.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[4][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[4][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[4][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker06.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[5][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[5][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[5][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker07.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[6][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[6][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[6][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker08.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[7][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[7][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[7][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker09.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker10.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker11.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker12.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker13.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker14.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker15.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker16.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker17.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker18.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker19.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            if (cuc.sticker20.Equals("1"))
            {
                item = new ComboBoxItem();
                item.Text = dt.Rows[8][stkdb.stk.sticker_code].ToString() + " " + dt.Rows[8][stkdb.stk.sticker_name].ToString();
                item.Value = dt.Rows[8][stkdb.stk.sticker_code].ToString();
                c.Items.Add(item);
            }
            return c;
        }
        public void readTextCEMUpdate(String cudId, String filename)
        {
            if (filename.Equals(""))
            {
                return;
            }
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(filename))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    String[] line1 = line.Split('|');
                    if (line1.Length > 0)
                    {
                        String rowid = "", labid="", value1 = "", normal1 = "", labname="";
                        rowid = line1[1];       //patient id เครื่อง CEM ไม่ได้ป้อน patient
                        labid = line1[2];       
                        value1 = line1[4];
                        normal1 = line1[5];
                        labname = line1[3];
                        
                    }
                }
            }
        }
        public String formatTextCEM(String value, String labid)
        {
            String re = "";
            //1=FBS     Glucose                                     integer
            //2=BUN     Blood urea nitrogen                         integer
            //3=Creatinine     Creatinine                           round 2
            //4=Chol     Cholesterol                                integer
            //5=Trig     Triglyceride                               integer
            //6=Total Protein     Total Protein                     round 1
            //7=Albumin     Albumin                                 round 1
            //8=Alkalinephosphatase     Alkalinephosphatase         integer
            //9=HDL     HDL Cholesterol                             integer
            //10=SGOT        SGOT(AST)                              integer
            //11=SGPT        SGPT(ALT)                              integer
            //12=Uric Acid        Uric Acid                         round 1
            //13=Bilirubin        Total Bilirubin                   round 1
            //14=Direct Bilirubin        Direct Bilirubin           round 1
            //15=LDL        LDL Cholesterol                         integer
            if (labid.Equals("1"))
            {
                Double chk1 = 0;
                int chk = 0;
                if(double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("2"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("3"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 2);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("4"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("5"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("6"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("7"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("8"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("9"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("10"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("11"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("12"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("13"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("14"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk1 = Math.Round(chk1, 1);
                    re = chk1.ToString();
                }
                else
                {
                    re = value;
                }
            }
            else if (labid.Equals("15"))
            {
                Double chk1 = 0;
                int chk = 0;
                if (double.TryParse(value, out chk1))
                {
                    chk = Convert.ToInt32(chk1);
                    re = chk.ToString();
                }
                else
                {
                    re = value;
                }
            }
            return re;
        }
    }
}
