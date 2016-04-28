using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrData.CmdClass
{
  public  class EmpCmd
    {
        static DbDataContext db = new DbDataContext();
        public static bool addEmp(EmpTable tb)
        {

            db = new DbDataContext();

            db.EmpTables.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;


        }

        public static bool EditDepartment(EmpTable tb)
        {

            db = new DbDataContext();

            var q = db.EmpTables.Where(p => p.Id == tb.Id).SingleOrDefault();
            q.EmpName = tb.EmpName;
            q.EmpNo = tb.EmpNo;
            q.WorkTimeNo = tb.WorkTimeNo;
            q.StartTime = tb.StartTime;
            q.EndTime = tb.EndTime;
            q.Pssword = tb.Pssword;

            db.SubmitChanges();
            return true;



        }

        public static bool DeleteDepartment(int ID)
        {
            try
            {
                db = new DbDataContext();
                var q = db.EmpTables.Where(p => p.Id == ID).SingleOrDefault();
                db.EmpTables.DeleteOnSubmit(q);
                db.SubmitChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public static List<EmpTable> GetAll()
        {
            db = new DbDataContext();

            return db.EmpTables.ToList();
        }

        public static EmpTable Login(string usr)
        {
            db = new DbDataContext();
            try
            {
                EmpTable q = db.EmpTables.Where(p => p.EmpNo == usr).Single();
                if (q.EmpNo==usr)
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

        public static UserTable Login(string usr, string pwd)
        {

            try
            {
                UserTable q = db.UserTables.Where(p => p.UserName == usr && p.Password == pwd).Single();
                if (q.UserName.StartsWith(usr) && q.Password.StartsWith(pwd))
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
