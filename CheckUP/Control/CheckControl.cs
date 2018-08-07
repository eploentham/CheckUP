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
        //public ItemDB itdb;
        //public ItemGroupDB itgdb;
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

                vCholes = new ValueNormalCholes();
                vLDL = new ValueNormalLDL();
                vSugar = new ValueNormalSugar();
                vTrig = new ValueNormalTrigly();

                sf = new Staff();
                //itSearch = new Item();

                conn = new ConnectDB(initC);

                sfdb = new StaffDB(conn);
                didb = new DistrictDB(conn);
                amdb = new AmphurDB(conn);
                prdb = new ProvinceDB(conn);
                copdb = new CompanyDB(conn);
                cudb = new CustomerDB(conn);
                ccpdb = new CustCheckUpPatientDB(conn);

                ccp1db = new CustCheckUpPatient1DB(conn);

                cucdb = new CustCheckUpDB(conn);
                eidb = new ExcelInitDB(conn);
                rcdb = new RCheckUpDB(conn);
                ccpvndb = new CustCheckUpPatientValueNormalDB(conn);
                //itdb = new ItemDB(conn);
                //itgdb = new ItemGroupDB(conn);
                //invdb = new InvoiceDB(conn);
                //invidb = new InvoiceItemDB(conn);
                //rsdb = new ResultDB(conn);
                //rsidb = new ResultItemDB(conn);
                //docdb = new DocTypeDB(conn);

                lw = new LogWriter();
                //Console.WriteLine("111");
                //Debug.WriteLine("111");
                //MessageBox.Show("111 ", "111 ");
                cop = copdb.selectByPk();
                //MessageBox.Show("222 ", "222 ");
                //Console.WriteLine("222");
                //Debug.WriteLine("222");
                PathLogo = Environment.CurrentDirectory;
                dtccpvn = ccpvndb.selectByPk();
                setValueNormal();
            }
            catch (Exception ex)
            {
                //lw.WriteLog("CnviControl.initConfig Error " + ex.Message);
                MessageBox.Show(""+ex.Message, "Error");
            }
        }
        public void setValueNormal()
        {
            DataTable dt = new DataTable();
            dt = ccpvndb.selectByPk();

            vCholes.cholesterolValueNormal = dt.Rows[0][ccpvndb.ccpvn.cholesterolValueNormal].ToString();
            vCholes.cholesterolValueUpper = dt.Rows[0][ccpvndb.ccpvn.cholesterolValueUpper].ToString();
            vCholes.cholesterolValueUpperSuggess = dt.Rows[0][ccpvndb.ccpvn.cholesterolValueUpperSuggess].ToString();

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
            initC.ServerIP = iniFile.Read("host");
            initC.User = iniFile.Read("username");
            initC.Password = iniFile.Read("password");
            initC.Port = iniFile.Read("port");
            initC.Database = iniFile.Read("database");
            initC.Host = initC.ServerIP;

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
            initC.reportSumNameCBC = iniFile.Read("reportSumNameCBC");
            initC.reportSumNameFBS = iniFile.Read("reportSumNameFBS");
            initC.reportSumNamePE = iniFile.Read("reportSumNamePE");
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
            }
            else
            {
                iniFile.Write("statusserver", "no");
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
        public void excelSum(String cucId)
        {
            CustCheckUp cuc = new CustCheckUp();
            cuc = cucdb.selectByPk(cucId);
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
                    range.Cells[1, 1] = initC.reportSumNamePE+" ประจำปี " + cuc.YearId;
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
                    range.Cells[1, 1] = "วันที่ตรวจ " + cuc.CheckUpDate+" แผ่นที่  "+i+" จำนวนผู้เข้าตรวจทั้งหมด "+cuc.pe_checkup +" มาตรวจ "+cuc.pe_test + " ปกติ "+cuc.PENormal +" ผิดปกติ "+cuc.PEAbNormal;
                    //range.Value2 = " วันที่  " + cuc.CheckUpDate;
                    range.Merge();
                    range.HorizontalAlignment = HorizontalAlignment.Center;
                    range.Font.Size = 20;
                    range.Font.Name = "Angsana New";

                    //row = 5 + pageCnt;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row+3, 1];
                    rg.ColumnWidth = 10;
                    rg.Value2 = "ลำดับ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 2];
                    rg.ColumnWidth = 40;
                    rg.Value2 = "รหัส";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "ชื่อ-นามสกุล";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 3];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "หมู่โลหิต";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 4];
                    rg.ColumnWidth = 20;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "อายุ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 5];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 6];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "น้ำหนัก";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 7];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ส่วนสูง";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 8];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 8];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "BMI";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 9];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 9];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ความดันโลหิต";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 10];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 10];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "ชีพจร";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 3, 11];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;
                    rg = (Microsoft.Office.Interop.Excel.Range)xlWorksheet.Cells[row + 4, 11];
                    rg.ColumnWidth = 23;
                    rg.Value2 = "สรุปผลการตรวจ";
                    rg.HorizontalAlignment = HorizontalAlignment.Center;

                    //range.Merge();
                    range = xlWorksheet.Range[xlWorksheet.Cells[row + 3, 1], xlWorksheet.Cells[row + 4, colCnt]];
                    range.Font.Size = 14;
                    range.Font.Name = "Angsana New";
                    range.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);


                    Microsoft.Office.Interop.Excel.Range rgPage;
                    rgPage = xlWorksheet.Range[xlWorksheet.Cells[row + 5, 1], xlWorksheet.Cells[row + pageRow+3, colCnt]];
                    rgPage.BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin);
                    rgPage.Font.Size = 14;
                    rgPage.Font.Name = "Angsana New";
                    for (int j = 1; j < pageRow; j++)
                    {
                        xlWorksheet.Cells[row + j + 1+3, 1] = (k+1);
                        xlWorksheet.Cells[row + j + 1 + 3, 2] = dt.Rows[k][ccpdb.ccp.patientNumber].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 3] = dt.Rows[k][ccpdb.ccp.patientFullname].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 4] = dt.Rows[k][ccpdb.ccp.BloodGroup].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 5] = dt.Rows[k][ccpdb.ccp.patientAge].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 6] = dt.Rows[k][ccpdb.ccp.patientWeight].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 7] = dt.Rows[k][ccpdb.ccp.patientHeight].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 8] = dt.Rows[k][ccpdb.ccp.bmi].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 9] = dt.Rows[k][ccpdb.ccp.vitalsign].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 10] = dt.Rows[k][ccpdb.ccp.patientPulse].ToString();
                        xlWorksheet.Cells[row + j + 1 + 3, 11] = dt.Rows[k][ccpdb.ccp.summaryPhysicalExam].ToString();
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
    }
}
