﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CheckUP.object1
{
    public class Staff : Persistent
    {
        public String Id = "", NameT = "", NameE="", Password = "", Active = "", Remark = "", Code = "", Priority="", Email="", Tele="", Fax="", PositionName="";
        public String dateCreate = "", dateModi = "", dateCancel = "", userCreate = "", userModi = "", userCancel = "", Mobile="", PositionId="";
        public override string ToString()
        {
            return NameT;
        }
    }
}
