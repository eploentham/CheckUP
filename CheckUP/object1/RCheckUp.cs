using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckUP.object1
{
    public class RCheckUp:Persistent
    {
        public String Id = "", LTypeLab = "", LNormal = "", lResult = "", LInter = "", LInterNormal = "", LInterAbnormal = "";
        public String LabGroup = "", LabName = "", LabNormal = "", LabResult = "", StatusLab = "", Remark = "", Sort1 = "", Sort2 = "";
        public String FullName = "", RowNumber = "", CheckUpDate = "", Age = "", Height = "", Weight = "", BMI = "", Pulse = "", VitalSign = "", PESummary = "";
    }
}
