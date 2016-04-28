using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrSystem.Report
{
   public class MonthyObj
    {
        public int id { get; set; }
        public string EmpName { get; set; }
        public DateTime Month { get; set; }
        public string empNo { get; set; }
        public int TotalDays { get; set; }
       public int HoldyDays { get; set; }
       public double WorkHouer { get; set; }
       public double RealWorkHour { get; set; }
       public double Defernce { get; set; }
    }
}
