using Microsoft.Reporting.WinForms;
using PcdcrData.CmdClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrSystem.Report
{
   public  class EmpWorkReportCmd
    {
       public EmpWorkReportCmd() { }
       public DateTime Date1 { get; set; }
       public string empname { get; set; }
       public void GetRptCollectionByDateAndID(int ID, DateTime date1, DateTime date2)
       {
           var q = WorkCmd.GetByIDAndDate(ID, date1, date2);
           ReportDataSource rs = new ReportDataSource();
           List<EmpWorkObj> ls = new List<EmpWorkObj>();
           foreach (var item in q)
           {
              
               ls.Add(new EmpWorkObj()
               {
                   Id=item.Id,
                   empname = item.EmpTable.EmpName,
                   empNo = item.EmpTable.EmpNo,
                   WorkDat = item.WorkDate.Value,
                   start =DateTime.Parse(item.startTime.ToString()),
                   end =DateTime.Parse(item.endtime.ToString()),
                   RealWork = float.Parse(item.RealWorkTimeNo.ToString()),
                   worktime = float.Parse(item.WorkTime.ToString()),
                   defernce=float.Parse(item.DefernceTime.ToString()),
                   TotalDefernce= WorkCmd.GetTotalDefrnc(date1,date2,ID),
          
                 TotalDays = WorkCmd.GetTotalCountDayWork(date1, date2, item.Id),
                  HoldyDays = WorkCmd.GetTotalCountDayHolady(date1, date2,item.Id),
                  TotalWorkHouer = WorkCmd.GetTotalWorkTime(date1, date2,item.Id),
                  TotalRealWorkHour = WorkCmd.GetTotalRealWork(date1, date2,item.Id),
               });

           }

           var q1 = HoldyCmd.GetByIDAndDate(ID, date1, date2);
           ReportDataSource rs1 = new ReportDataSource();
           List<HoldyObj> ls1 = new List<HoldyObj>();
           foreach (var item in q1)
           {

               ls1.Add(new HoldyObj()
               {
                  
                   HoldyDate=item.HoldyDate.Value,
                   HoldyType=item.HoldType,


               });

           }


           rs.Name = "DataSet1";
           rs1.Name = "DataSet2";
           rs.Value = ls;
           rs1.Value = ls1;
           ReportFrm frm = new ReportFrm();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.DataSources.Add(rs1);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "PcdcrSystem.Report.EmpWorkReoprt.rdlc";

           frm.ShowDialog();
       }
    }
}
