using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cemp.object1
{
    public class Persistent
    {
        public String table { get; set; }
        public String pkField { get; set; }
        public String sited { get; set; }
        public String dateGenDB = "Format(Now(),'yyyy')+'-'+Format(Now(),'mm')+'-'+Format(Now(),'dd')+' '+Format(Now(),'hh:nn:ss')";
        Random r = new Random();
        public Persistent()
        {
            table = "";
            pkField = "";
            sited = "";
        }
        public String getGenID()
        {
            r = new Random();
            return r.Next().ToString();
        }
    }
}
