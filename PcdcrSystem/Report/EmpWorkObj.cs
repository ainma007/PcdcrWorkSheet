using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrSystem.Report
{
    public   class EmpWorkObj
    {
        public  int Id { get; set; }
        public  string empname { get; set; }
        public  string empNo { get; set; }
        public  DateTime WorkDat { get; set; }
        public  DateTime start { get; set; }
        public  DateTime end { get; set; }
        public double RealWork { get; set; }
        public double worktime { get; set; }
        public  double defernce { get; set; }

        public Double TotalDefernce { get; set; }
        public int TotalDays { get; set; }
        public int HoldyDays { get; set; }
        public double TotalWorkHouer { get; set; }
        public double TotalRealWorkHour { get; set; }
        ///

       






    }
}
