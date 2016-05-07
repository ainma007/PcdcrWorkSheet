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
using Telerik.WinControls;
using PcdcrData;
using PcdcrData.CmdClass;
using Telerik.WinControls.Data;

namespace PcdcrSystem.WorkFrm
{
    public partial class EditWorkFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditWorkFrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 
        }
        public WorkTable  Wtb { get; set; }
        public float WorkHour { get; set; }
        public float WorkTime { get; set; }
        public float Defernce { get; set; }
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
        private void EditWorkFrm_Load(object sender, EventArgs e)
        {
            fillcombo();
            var ListData = WorkCmd.GetEMpInfo(int.Parse(EmpComboBox.SelectedValue.ToString()));
            foreach (var item in ListData)
            {
                WorkHour = float.Parse(item.WorkTimeNo.ToString());
              
            }
            EmpComboBox.Text = Wtb.EmpTable.EmpName;
            startTimeTimeEdit.EditValue = Wtb.startTime;
            radDateTimePicker1.Value = Wtb.WorkDate.Value.Date;
            endtimeTimeEdit.EditValue = Wtb.endtime;

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

            float compMonth = (endtimeTimeEdit.Time.Minute + endtimeTimeEdit.Time.Hour * 60) - (startTimeTimeEdit.Time.Minute + startTimeTimeEdit.Time.Hour * 60);
            float Totaltime = compMonth / 60;
            WorkTime = Totaltime;
            Defernce = WorkTime - WorkHour;

            if (RadMessageBox.Show(this, "هل تريد حفظ التعديلات", "حفظ", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Wtb.EmpId = int.Parse(EmpComboBox.SelectedValue.ToString());
                Wtb.startTime = startTimeTimeEdit.Time.TimeOfDay;
                Wtb.endtime = endtimeTimeEdit.Time.TimeOfDay;
                Wtb.WorkTime = WorkTime;
                Wtb.RealWorkTimeNo = WorkHour;
                Wtb.DefernceTime = Defernce;
                Wtb.WorkFinsh = "true";
                WorkCmd.EditWork(Wtb);
            }

            this.Close();


        }
    }
}