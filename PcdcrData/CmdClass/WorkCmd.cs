using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrData.CmdClass
{
   public class WorkCmd
    {

        static DbDataContext db = new DbDataContext();
        public static bool addWork(WorkTable tb)
        {

            db = new DbDataContext();

            db.WorkTables.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;


        }

        public static bool EditWork(WorkTable tb)
        {

            db = new DbDataContext();

            var q = db.WorkTables.Where(p => p.Id == tb.Id).SingleOrDefault();
            q.EmpId = tb.EmpId;
            q.WorkDate = tb.WorkDate;
            q.startTime = tb.startTime;
            q.endtime = tb.endtime;
            q.RealWorkTimeNo = tb.RealWorkTimeNo;
            q.WorkTime = tb.WorkTime;
            q.DefernceTime = tb.DefernceTime;
            q.WorkFinsh = tb.WorkFinsh;


            db.SubmitChanges();
            return true;



        }

        public static bool DeleteWork(int ID)
        {
            try
            {
                db = new DbDataContext();
                var q = db.WorkTables.Where(p => p.Id == ID).SingleOrDefault();
                db.WorkTables.DeleteOnSubmit(q);
                db.SubmitChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public static List<WorkTable> GetAll()
        {
            db = new DbDataContext();

            return db.WorkTables.ToList();
        }
        public static List<EmpTable> GetEMpInfo(int PID)
        {
            db = new DbDataContext();
            var LST = (from p in db.EmpTables where p.Id == PID select p).ToList();
            return LST;
        }
        public static WorkTable CheckWork(int usr,DateTime date1)
        {
            db = new DbDataContext();
            try
            {
                WorkTable q = db.WorkTables.Where(p => p.EmpId==usr && p.WorkDate == date1).Single();
                if (q.EmpId == usr && q.WorkDate==date1)
                {

                    return q;
                }

                return null;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public static List<WorkTable> GetWorkInfo(int empid,DateTime date1)
        {
            db = new DbDataContext();
            var LST = (from p in db.WorkTables where p.EmpId == empid && p.WorkDate==date1.Date select p).ToList();
            return LST;
        }

        public static bool EditWorkUser(WorkTable tb)
        {

            db = new DbDataContext();

            var q = db.WorkTables.Where(p => p.EmpId == tb.EmpId && p.WorkDate==tb.WorkDate).SingleOrDefault();
            q.EmpId = tb.EmpId;
            q.WorkDate = tb.WorkDate;
            q.startTime = tb.startTime;
            q.endtime = tb.endtime;
            q.RealWorkTimeNo = tb.RealWorkTimeNo;
            q.WorkTime = tb.WorkTime;
            q.DefernceTime = tb.DefernceTime;
            q.WorkFinsh = tb.WorkFinsh;


            db.SubmitChanges();
            return true;



        }

        public static List<WorkTable> GetByEmpID(int ID)
        {
            db = new DbDataContext();
            var q = (from i in db.WorkTables
                     where i.EmpId == ID
                     select i).ToList();

            return q;

        }
        public static List<WorkTable> GetByIDAndDate(int ID, DateTime dat1, DateTime date2)
        {
            db = new DbDataContext();
            var q = (from i in db.WorkTables
                     where i.WorkDate >= dat1 && i.WorkDate <= date2 && i.EmpId == ID
                     select i).ToList();

            return q;

        }

        public static List<WorkTable> GetByDate(DateTime dat1, DateTime date2)
        {
            db = new DbDataContext();
            var q = (from i in db.WorkTables
                     where i.WorkDate >= dat1 && i.WorkDate <= date2
                     select i).ToList();

            return q;

        }

       /// مجموع الفروقات والايام
       /// 
        public static double GetTotalDefrnc(DateTime date1, DateTime date2, int ID)
        {
            db = new DbDataContext();

            var LST = (from p in db.WorkTables

                       where p.WorkDate >= date1 && p.WorkDate <= date2 && p.EmpId == ID && p.DefernceTime < (-.25)
                       select p.DefernceTime).ToList();

            double total = 0;
            foreach (var Sm in LST) { total += Convert.ToDouble(Sm); }

            return total;

        }

        public static double GetTotalDefrncMonth(DateTime date1, DateTime date2, int ID)
        {
            db = new DbDataContext();

            var LST = (from p in db.WorkTables

                       where p.WorkDate >= date1 && p.WorkDate <= date2 && p.EmpId == ID && p.DefernceTime < (-.25)
                       select p.DefernceTime).ToList();

            double total = 0;
            foreach (var Sm in LST) { total += Convert.ToDouble(Sm); }

            return total;

        }

        public static int GetTotalCountDayWork(DateTime date1, DateTime date2, int ID)
        {
            db = new DbDataContext();

            var LST = (from p in db.WorkTables

                       where p.WorkDate >= date1 && p.WorkDate <= date2 && p.EmpId == ID
                       select p.Id).Count();

            //int total = 0;
            //foreach (var Sm in LST) { total += Convert.ToInt32(Sm); }

            return LST;

        }

        public static int GetTotalCountDayHolady(DateTime date1, DateTime date2, int ID)
        {
            db = new DbDataContext();

            var LST = (from p in db.HoldyTables

                       where p.HoldyDate >= date1 && p.HoldyDate <= date2 && p.EmpID == ID
                       select p.Id).Count();

            

            return LST;

        }

        public static double GetTotalRealWork(DateTime date1, DateTime date2, int ID)
        {
            db = new DbDataContext();

            var LST = (from p in db.WorkTables

                       where p.WorkDate >= date1 && p.WorkDate <= date2 && p.EmpId == ID
                       select p.RealWorkTimeNo).ToList();

            double total = 0;
            foreach (var Sm in LST) { total += Convert.ToDouble(Sm); }

            return total;

        }

        public static double GetTotalWorkTime(DateTime date1,DateTime date2, int ID)
        {
            db = new DbDataContext();

            var LST = (from p in db.WorkTables

                       where p.WorkDate >= date1 && p.WorkDate <= date2 && p.EmpId == ID
                       select p.WorkTime).ToList();

            double total = 0;
            foreach (var Sm in LST) { total += Convert.ToDouble(Sm); }

            return total;

        }
  
    }
}
