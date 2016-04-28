using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Telerik.WinControls.Data;
using PcdcrData.CmdClass;

namespace PcdcrSystem.Report
{
    public partial class ReportEmployeeFrm : DevExpress.XtraEditors.XtraForm
    {
        public ReportEmployeeFrm()
        {
            InitializeComponent();
        }
        private void fillcombo()
        {
            this.EmpComboBox.MultiColumnComboBoxElement.DropDownWidth = 500;
            this.EmpComboBox.ValueMember = "Id";
            this.EmpComboBox.DisplayMember = "EmpName";
            EmpComboBox.DataSource = EmpCmd.GetAll();
            this.EmpComboBox.AutoFilter = true;
            CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
            FilterDescriptor empname = new FilterDescriptor("EmpName", FilterOperator.Contains, "");
            FilterDescriptor empNumber = new FilterDescriptor("EmpNo", FilterOperator.Contains, "");
            compositeFilter.FilterDescriptors.Add(empname);
            compositeFilter.FilterDescriptors.Add(empNumber);
            compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

            this.EmpComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);
        }
        private void ReportEmployeeFrm_Load(object sender, EventArgs e)
        {
            fillcombo();
            FromTimePicker.Value = DateTime.Now.Date;
            ToTimePicker.Value = DateTime.Now.Date;
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            EmpWorkReportCmd cmd = new EmpWorkReportCmd();
            cmd.GetRptCollectionByDateAndID(int.Parse(EmpComboBox.SelectedValue.ToString()), FromTimePicker.Value.Date, ToTimePicker.Value.Date);
        }
    }
}