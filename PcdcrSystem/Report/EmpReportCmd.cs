using Microsoft.Reporting.WinForms;
using PcdcrData.CmdClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcdcrSystem.Report
{
   public  class EmpReportCmd
    {
       public EmpReportCmd() { }

       public void GetAllEmployee()
       {
           var q = EmpCmd.GetAll();
           ReportDataSource rs = new ReportDataSource();
           List<EmpObj> ls = new List<EmpObj>();
           int counter = 0;
           foreach (var item in q)
           {
             
               counter++;
               ls.Add(new EmpObj()
               {
                   id = counter,
                   empname = item.EmpName ,
                   empNo = item.EmpNo,
                   start = DateTime.Parse(item.StartTime.ToString()),
                   end = DateTime.Parse(item.EndTime.ToString()),
                   worktime = float.Parse(item.WorkTimeNo.ToString()),
                   
               }); 
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           ReportFrm frm = new ReportFrm();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "PcdcrSystem.Report.EmpReport.rdlc";
           frm.ShowDialog();


       }
    }
}
