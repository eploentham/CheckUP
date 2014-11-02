using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class CustCheckUp:Persistent
    {
        public String Id = "", CheckUpDate = "", Description = "", Remark = "", Active = "", YearId = "", CustId = "", CustNameT = "", RegisDate = "", CheckUpStartDate = "", CheckUpEndDate = "", CommitCheckUpDate = "", CntEmployee = "";
        public String PECnt = "", PENormal = "", PEAbNormal = "", XrayCnt = "", XrayNormal = "", XrayAbNormal = "", CBCCnt = "", CBCNormal = "", CBCAbNormal = "", FBSCnt = "", FBSNormal = "", FBSAbNormal = "";
        public String UACnt = "", UANormal = "", UAAbNormal = "", TriCnt = "", TriNormal = "", TriAbNormal = "", ChoCnt = "", ChoNormal = "", ChoAbNormal = "", SgotCnt = "", SgotNormal = "", SgotAbNormal = "";
        public String BunCnt = "", BunNormal = "", BunAbNormal = "", UricCnt = "", UricNormal = "", UricAbNormal = "", Other1Cnt = "", Other1Normal = "", Other1AbNormal = "", AudioCnt = "", AudioNormal = "", AudioAbNormal = "";
        public String EyeCnt = "", EyeNormal = "", EyeAbNormal = "", LungCnt="", LungNormal="", LungAbNormal="";
        
        public override String ToString()
        {
            return Description;
        }
    }
}
