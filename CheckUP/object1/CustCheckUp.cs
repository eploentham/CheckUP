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
        public String sticker01 = "", sticker02 = "", sticker03 = "", sticker04 = "", sticker05 = "", sticker06 = "", sticker07 = "", sticker08 = "", sticker09 = "", sticker10 = "";
        public String sticker11 = "", sticker12 = "", sticker13 = "", sticker14 = "", sticker15 = "", sticker16 = "", sticker17 = "", sticker18 = "", sticker19 = "", sticker20 = "";
        public String sticker01_name = "", sticker02_name = "", sticker03_name = "", sticker04_name = "", sticker05_name = "", sticker06_name = "", sticker07_name = "", sticker08_name = "", sticker09_name = "", sticker10_name = "";
        public String sticker11_name = "", sticker12_name = "", sticker13_name = "", sticker14_name = "", sticker15_name = "", sticker16_name = "", sticker17_name = "", sticker18_name = "", sticker19_name = "", sticker20_name = "";

        public override String ToString()
        {
            return Description;
        }
    }
}
