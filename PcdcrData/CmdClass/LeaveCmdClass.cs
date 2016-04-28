using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrData.CmdClass
{
   public class LeaveCmdClass
    {

        static DbDataContext db = new DbDataContext();
        public static bool addLeave(LeaveTable tb)
        {

            db = new DbDataContext();

            db.LeaveTables.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;


        }

        public static bool EditLeave(LeaveTable tb)
        {

            db = new DbDataContext();

            var q = db.LeaveTables.Where(p => p.Id == tb.Id).SingleOrDefault();
            q.EmpId = tb.EmpId;
            q.LeaveDate = tb.LeaveDate;
            q.LeaveTime = tb.LeaveTime;
            q.BackTime = tb.BackTime;
            q.LeaveType = tb.LeaveType;
          


            db.SubmitChanges();
            return true;



        }

        public static bool DeleteLeave(int ID)
        {
            try
            {
                db = new DbDataContext();
                var q = db.LeaveTables.Where(p => p.Id == ID).SingleOrDefault();
                db.LeaveTables.DeleteOnSubmit(q);
                db.SubmitChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public static List<LeaveTable> GetAll()
        {
            db = new DbDataContext();

            return db.LeaveTables.ToList();
        }

       //أرشيف البحث 
        public static List<LeaveTable> GetByEmpID(int ID)
        {
            db = new DbDataContext();
            var q = (from i in db.LeaveTables
                     where i.EmpId == ID
                     select i).ToList();

            return q;

        }
        public static List<LeaveTable> GetByIDAndDate(int ID, DateTime dat1, DateTime date2)
        {
            db = new DbDataContext();
            var q = (from i in db.LeaveTables
                     where i.LeaveDate >= dat1 && i.LeaveDate <= date2 && i.EmpId == ID
                     select i).ToList();

            return q;

        }

        public static List<LeaveTable> GetByDate(DateTime dat1, DateTime date2)
        {
            db = new DbDataContext();
            var q = (from i in db.LeaveTables
                     where i.LeaveDate >= dat1 && i.LeaveDate <= date2
                     select i).ToList();

            return q;

        }



    }
}
