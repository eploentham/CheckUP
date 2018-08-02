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
        public CompanyDB cpdb;
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
        public Company cp;
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
                cpdb = new CompanyDB(conn);
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

                cp = cpdb.selectByPk();
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
    }
}
