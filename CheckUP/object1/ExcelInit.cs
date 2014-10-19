using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class ExcelInit:Persistent
    {
        public String SfRow = "", SfStatusName = "", SfANo = "", SfAPrefix = "", SfAFirstName = "", SfALastName = "", SfAAge = "", SfBNo = "", SfBPrefix = "", SfBFullName = "", SfBAge = "";
        public String SfCNo = "", SfCFullName = "", SfCAge = "";
        
        public String PERow = "", PENo="", PEAge="", PEWeght="", PEHeight="", PEBMI="", PEVitalSign="", PEPulse="", PEResult="", PESummary="";

        public String XrayRow = "", XrayNo = "", Xray = "", XraySummary = "";

        public String CBCRow = "", CBCNo = "", CBCWBC = "", CBCRBC = "", CBCHb = "", CBCHct = "", CBCNeu = "", CBCLy = "", CBCMono = "", CBCEos = "", CBCBact = "", CBCPltC = "", CBCPltS = "", CBCRBCmono = "", CBCSummary = "";

        public String FBSRow = "", FBSNo = "", FBS = "", FBSResult="", FBSSummary = "";

        public String UARow = "", UANo = "", UAColor = "", UAAppe = "", UASugar = "", UASpgr = "", UApH = "", UAProtein = "", UAWBC = "", UARBC = "", UAEpi = "", UABact = "", UAResult = "", UASummary = "";

        public String TriRow = "", TriNo = "", Triglyceride = "", TriResult = "", TriSummary = "";

        public String ChoRow = "", ChoNo = "", Cholesteral = "", ChoResult = "", Chosummary = "";

        public String SgotRow = "", SgotNo = "", Sgot = "", Sgpt = "", SgotResult = "", SgptSummary = "";

        public String BunRow = "", BunNo = "", Bun = "", BunCreatinine = "", BunResult = "", BunSummary = "";

        public String UricRow = "", UricNo = "", UricAcid = "", UricResult = "", UricSummary = "";
    }
}
