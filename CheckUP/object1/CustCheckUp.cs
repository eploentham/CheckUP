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
        public String EyeCnt = "", EyeNormal = "", EyeAbNormal = "";
        public String LungCnt="", LungNormal="", LungAbNormal="", CntSuccess="";

        public String PESuccess = "", CBCSuccess = "", FBSSuccess = "", UASuccess = "", XraySuccess = "", TriSuccess = "", ChoSuccess = "", SgotSuccess = "", BunSuccess = "", UricSuccess = "", Other1Success = "", LungSuccess = "",AudioSuccess="",EyeSuccess="";

        public String ToxiCnt = "", ToxiSuccess = "", ToxiNormal = "", ToxiAbNormal = "";
        
        public String StoolExamCnt = "", StoolExamSuccess = "", StoolExamNormal = "", StoolExamAbNormal = "";

        public String dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "";
        public String pe_checkup = "", xray_checkup = "", cbc_checkup = "", ua_checkup = "", tri_checkup = "", cho_checkup = "", sgot_checkup = "", bun_checkup = "", uric_checkup = "";
        public String other1_checkup = "", lung_checkup = "", audio_checkup = "", eye_checkup = "", stoolexam_checkup = "", toxi_checkup = "", fbs_checkup="";
        public String pe_test = "", xray_test = "", cbc_test = "", ua_test = "", tri_test = "", cho_test = "", sgot_test = "", bun_test = "", uric_test = "";
        public String other1_test = "", lung_test = "", audio_test = "", eye_test = "", stoolexam_test = "", toxi_test = "", fbs_test = "";
        public String sticker = "";

        public override String ToString()
        {
            return Description;
        }
    }
}
