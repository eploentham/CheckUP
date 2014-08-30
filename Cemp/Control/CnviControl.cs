using Cemp.objdb;
using Cemp.object1;
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

namespace Cemp.Control
{
    public class CnviControl
    {
        public Config1 cf;
        public ConnectDB conn;//

        public StaffDB sfdb;
        public DistrictDB didb;
        public CompanyDB cpdb;

        public Staff sf;

        private IniFile iniFile;
        public InitConfig initC;

        public CnviControl()
        {
            initConfig();
        }        
        private void initConfig()
        {
            iniFile = new IniFile(Environment.CurrentDirectory + "\\" + Application.ProductName + ".ini");
            initC = new InitConfig();
            GetConfig();
            cf = new Config1();

            sf = new Staff();
            
            conn = new ConnectDB(initC);

            sfdb = new StaffDB(conn);
            didb = new DistrictDB(conn);
            cpdb = new CompanyDB(conn);

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

            initC.pathImage = iniFile.Read("pathimage");
            initC.pathImageBefore = iniFile.Read("pathimagebefore");
            initC.delImage = iniFile.Read("delimage");
            initC.StatusServer = iniFile.Read("statusserver");
            initC.pathShareData = iniFile.Read("pathsharedata");
            initC.pathShareImage = iniFile.Read("pathshareimage");
            //initC.Password = regE.getPassword();
        }
        public void SetPathImage(String path)
        {
            iniFile.Write("pathimage", path);
        }
        public void SetPathImageBefore(String path)
        {
            iniFile.Write("pathimagebefore", path);
        }
        public void SetPathShareImage(String path)
        {
            iniFile.Write("pathshareimage", path);
        }
        public void SetPathShareData(String path)
        {
            iniFile.Write("pathsharedata", path);
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
            return addr[addr.Length - 1].ToString();
            //return localIP;
        }
    }
}
