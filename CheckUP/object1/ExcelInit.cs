using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class ExcelInit:Persistent
    {
        public String Id = "";
        public String SfRow = "", SfStatusName = "", SfANo = "", SfAPrefix = "", SfAFirstName = "", SfALastName = "", SfAAge = "", SfBNo = "", SfBPrefix = "", SfBFullName = "", SfBAge = "";
        public String SfCNo = "", SfCFullName = "", SfCAge = "", Active="";
        
        public String PERow = "", PENo="", PEAge="", PEWeight="", PEHeight="", PEBMI="", PEVitalSign="", PEPulse="", PEResult="", PESummary="", PEBloodGroup="";

        public String XrayRow = "", XrayNo = "", Xray = "", XraySummary = "";

        public String CBCRow = "", CBCNo = "", CBCWBC = "", CBCRBC = "", CBCHb = "", CBCHct = "", CBCNeu = "", CBCLy = "", CBCMono = "", CBCEos = "", CBCBact = "", CBCPltC = "", CBCPltS = "", CBCRBCmono = "", CBCSummary = "";

        public String FBSRow = "", FBSNo = "", FBS = "", FBSResult="", FBSSummary = "";

        public String UARow = "", UANo = "", UAColor = "", UAAppe = "", UASugar = "", UASpgr = "", UApH = "", UAProtein = "", UAWBC = "", UARBC = "", UAEpi = "", UABact = "", UAResult = "", UASummary = "";

        public String TriRow = "", TriNo = "", Triglyceride = "", TriResult = "", TriSummary = "";

        public String ChoRow = "", ChoNo = "", Cholesteral = "", ChoResult = "", Chosummary = "", ChoLDL="", ChoHDL="";

        public String SgotRow = "", SgotNo = "", Sgot = "", Sgpt = "", SgotResult = "", SgptSummary = "", SgotALP="";

        public String BunRow = "", BunNo = "", Bun = "", BunCreatinine = "", BunResult = "", BunSummary = "";

        public String UricRow = "", UricNo = "", UricAcid = "", UricResult = "", UricSummary = "";

        public String Other1Row = "", Other1No = "", Other1HBsAg = "", Other1HBsAb = "", Other1AntiHIV = "", Other1VDRL = "", Other1Calcium = "", Other1Amphetamine="";

        public String LungRow = "", LungNo = "", LungFvcPredic = "", LungFvcMeas = "", LungFvcPer = "", LungFev1Predic = "", LungFev1Meas = "", LungFev1Per = "", LungPerFev1 = "", LungSummary = "";
    }
}
