using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrData.CmdClass
{
  public  class HoldyCmd
    {
        static DbDataContext db = new DbDataContext();
        public static bool addHoldy(HoldyTable tb)
        {

            db = new DbDataContext();

            db.HoldyTables.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;


        }

        public static bool EditHoldy(HoldyTable tb)
        {

            db = new DbDataContext();

            var q = db.HoldyTables.Where(p => p.Id == tb.Id).SingleOrDefault();
            q.EmpID = tb.EmpID;
            q.HoldType = tb.HoldType;
            q.HoldyDate = tb.HoldyDate;
           

            db.SubmitChanges();
            return true;



        }

        public static bool DeleteHoldy(int ID)
        {
            try
            {
                db = new DbDataContext();
                var q = db.HoldyTables.Where(p => p.Id == ID).SingleOrDefault();
                db.HoldyTables.DeleteOnSubmit(q);
                db.SubmitChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public static List<HoldyTable> GetAll()
        {
            db = new DbDataContext();

            return db.HoldyTables.ToList();
        }

      // أرشيف البحث 

        public static List<HoldyTable> GetByEmpID(int ID)
        {
            db = new DbDataContext();
            var q = (from i in db.HoldyTables
                     where i.EmpID == ID
                     select i).ToList();

            return q;

        }
        public static List<HoldyTable> GetByIDAndDate(int ID, DateTime dat1, DateTime date2)
        {
            db = new DbDataContext();
            var q = (from i in db.HoldyTables
                     where i.HoldyDate >= dat1 && i.HoldyDate <= date2 && i.EmpID == ID
                     select i).ToList();

            return q;

        }

        public static List<HoldyTable> GetByDate(DateTime dat1, DateTime date2)
        {
            db = new DbDataContext();
            var q = (from i in db.HoldyTables
                     where i.HoldyDate >= dat1 && i.HoldyDate <= date2
                     select i).ToList();

            return q;

        }

        public static HoldyTable CheckHoldy(int usr, DateTime date1)
        {
            db = new DbDataContext();
            try
            {
                HoldyTable q = db.HoldyTables.Where(p => p.EmpID == usr && p.HoldyDate == date1).Single();
                if (q.EmpID == usr && q.HoldyDate == date1)
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
    }
}
