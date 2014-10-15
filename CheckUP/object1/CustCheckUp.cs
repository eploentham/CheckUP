using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class CustCheckUp:Persistent
    {
        public String Id = "", CheckUpDate = "", Description = "", Remark = "", Active = "", YearId = "", CustId = "", CustNameT = "", RegisDate = "", CheckUpStartDate = "", CheckUpEndDate = "", CommitCheckUpDate = "", CntEmployee = "";
        public override String ToString()
        {
            return Description;
        }
    }
}
