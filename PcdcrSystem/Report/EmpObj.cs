using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrSystem.Report
{
     public  class EmpObj
    {
        public int id { get; set; }
        public string empname  { get; set; }
        public string empNo { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public float worktime { get; set; }
        
    }
}
