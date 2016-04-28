using Microsoft.Reporting.WinForms;
using PcdcrData.CmdClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrSystem.Report
{
  public  class MonthWorkCmd
    {
      public void GetRptCollectionByDateAndID( DateTime date1,DateTime date2)
      {
          var q = EmpCmd.GetAll();
          ReportDataSource rs = new ReportDataSource();
          List<MonthyObj> ls = new List<MonthyObj>();
          foreach (var item in q)
          {

              ls.Add(new MonthyObj()
              {
                  id = item.Id,
                  EmpName = item.EmpName,
                  empNo = item.EmpNo,
                  TotalDays = WorkCmd.GetTotalCountDayWork(date1, date2, item.Id),
                  HoldyDays = WorkCmd.GetTotalCountDayHolady(date1, date2,item.Id),
                  WorkHouer = WorkCmd.GetTotalWorkTime(date1, date2,item.Id),
                  RealWorkHour = WorkCmd.GetTotalRealWork(date1, date2,item.Id),
                  Defernce = WorkCmd.GetTotalDefrncMonth(date1, date2,item.Id),
                 

              });

          }
        
          rs.Name = "DataSet1";
          rs.Value = ls;
          ReportFrm frm = new ReportFrm();
          frm.reportViewer1.LocalReport.DataSources.Clear();
          frm.reportViewer1.LocalReport.DataSources.Add(rs);
          frm.reportViewer1.LocalReport.ReportEmbeddedResource = "PcdcrSystem.Report.MonthlyReport.rdlc";

          frm.ShowDialog();
      }
    }
}
