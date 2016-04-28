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
using PcdcrData;
using PcdcrData.CmdClass;
using Telerik.WinControls.Data;
using Telerik.WinControls;

namespace PcdcrSystem.WorkFrm
{
    public partial class AddWorkFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddWorkFrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 
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
        public float WorkHour { get; set; }
        public float WorkTime { get; set; }
        public float Defernce { get; set; }
        private void AddWorkFrm_Load(object sender, EventArgs e)
        {
            radDateTimePicker1.Value = DateTime.Now.Date;
            fillcombo();
        }

        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmpComboBox.SelectedValue == null)
            {
                return;
            }
            var ListData = WorkCmd.GetEMpInfo(int.Parse(EmpComboBox.SelectedValue.ToString()));
            foreach (var item in ListData)
            {
                WorkHour = float.Parse(item.WorkTimeNo.ToString());
                startTimeTimeEdit.EditValue = item.StartTime;
                endtimeTimeEdit.EditValue = item.EndTime;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (EmpComboBox.Text == "")
            {
                EmpComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                EmpComboBox.Focus();

                return;
            }
            else
            {
                EmpComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }
            if (EmpComboBox.SelectedValue == null)
            {
                EmpComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;

                EmpComboBox.Focus();

                return;
            }
            else
            {
                EmpComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
            }




            #endregion

             var q = WorkCmd.CheckWork(int.Parse(EmpComboBox.SelectedValue.ToString()),radDateTimePicker1.Value.Date);
             if (q != null)
             {
                 RadMessageBox.Show("مسجل في هذا التاريخ مسبقاً", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                 return;

             }
            float compMonth = (endtimeTimeEdit.Time.Minute + endtimeTimeEdit.Time.Hour * 60) - (startTimeTimeEdit.Time.Minute + startTimeTimeEdit.Time.Hour * 60);
            float Totaltime = compMonth / 60;
            WorkTime = Totaltime;
            Defernce = WorkTime - WorkHour;

            WorkTable tb = new WorkTable()
            {
               EmpId=int.Parse(EmpComboBox.SelectedValue.ToString()),
               WorkDate=radDateTimePicker1.Value.Date,
               startTime=startTimeTimeEdit.Time.TimeOfDay,
               endtime=endtimeTimeEdit.Time.TimeOfDay,
               RealWorkTimeNo=WorkHour,
               WorkTime=WorkTime,
               DefernceTime=Defernce,
               WorkFinsh="true"


            };

            WorkCmd.addWork(tb);
            RadMessageBox.Show("تمت عملية الحفظ", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);
            EmpComboBox.Focus();

            
        }

        private void startTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}