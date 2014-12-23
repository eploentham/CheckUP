using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class QuotationEx:Persistent
    {
        public String Id = "", StatusGoSite="", GoSiteA = "", GoSiteN = "", GositeD = "", GoSiteP = "";
        public String StatusDistanceDaily = "", DistanceDailyA = "", DistanceDailyN = "", DistanceDailyD = "", DistanceDailyP = "";
        public String StatusRentCar = "", RentCarA = "", RentCarN = "", RentCarD = "", RentCarP = "";
        public String StatusRentRoom = "", RentRoomA = "", RentRoomN = "", RentRoomD = "", RentRoomP = "";
        public String StatusEx1 = "", Ex1A = "";
        public String StatusEx2 = "", Ex2A = "", Amount="", Active="",Remark="";
    }
}
