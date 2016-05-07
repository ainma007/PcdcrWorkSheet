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
using Telerik.WinControls;
using Telerik.WinControls.Data;

namespace PcdcrSystem.LeavForms
{
    public partial class AddLeaveFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddLeaveFrm()
        {
            InitializeComponent();
        }
        public DateTime Startime { get; set; }
        public float TotalHouer { get; set; }
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
        private void AddLeaveFrm_Load(object sender, EventArgs e)
        {
            fillcombo();
            LeaveDateTimePicker.Value = DateTime.Now.Date;
            leaveTimeTimeEdit.EditValue = DateTime.Now;
            backTimeTimeEdit.EditValue = DateTime.Now;
        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
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
            //

            if (radDropDownList1.Text == "")
            {
                radDropDownList1.BackColor = Color.OrangeRed;

                radDropDownList1.Focus();

                return;
            }
            else
            {
                radDropDownList1.BackColor = Color.White;
            }
            
           

            #endregion
            var q = WorkCmd.CheckWork(int.Parse(EmpComboBox.SelectedValue.ToString()), LeaveDateTimePicker.Value.Date);
             if (q != null)
             {
                 LeaveTable tb = new LeaveTable
                 {
                     EmpId = int.Parse(EmpComboBox.SelectedValue.ToString()),
                     LeaveDate = LeaveDateTimePicker.Value.Date,
                     LeaveTime = leaveTimeTimeEdit.Time.TimeOfDay,
                     BackTime = backTimeTimeEdit.Time.TimeOfDay,
                     LeaveType = radDropDownList1.Text,
                     TotalHouer=TotalHouer,
                 };

                 LeaveCmdClass.addLeave(tb);

                 if (RadMessageBox.Show(this, "هل يتم اعتماد ساعة العودة  ساعة الانصراف", "تنبيه", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                 {
                     var ListData = WorkCmd.GetWorkInfo(int.Parse(EmpComboBox.SelectedValue.ToString()), LeaveDateTimePicker.Value.Date);

                     foreach (var item in ListData)
                     {
                         Startime = DateTime.Parse(item.startTime.ToString());
                         UserClass.XWorkTime = float.Parse(item.RealWorkTimeNo.ToString());
                     }

                     float compMonth = (backTimeTimeEdit.Time.Minute + backTimeTimeEdit.Time.Hour * 60) - (Startime.Minute + Startime.Hour * 60);
                     float Totaltime = compMonth / 60;
                     WorkTable tb1 = new WorkTable()
                     {
                         EmpId = int.Parse(EmpComboBox.SelectedValue.ToString()),
                         WorkDate=LeaveDateTimePicker.Value.Date,
                         startTime = Startime.TimeOfDay,
                         endtime = backTimeTimeEdit.Time.TimeOfDay,
                         RealWorkTimeNo = UserClass.XWorkTime,
                         WorkTime = Totaltime,
                         DefernceTime = (Totaltime - UserClass.XWorkTime),
                         WorkFinsh = "true"

                     };
                     WorkCmd.EditWorkUser(tb1);
                     RadMessageBox.Show("تمت الاضافة واعتماد ساعة الخروج", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);

                 }
                 else
                 {
                     RadMessageBox.Show("تمت الاضافة بدون اعتماد ساعةالخروج", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);

                 }


             }
             else
             {
                 RadMessageBox.Show("يرجى اولا تسجيل الحضور", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                 return;
             }
       
        }

        private void leaveTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {
            float compMonth = (backTimeTimeEdit.Time.Minute + backTimeTimeEdit.Time.Hour * 60) - (leaveTimeTimeEdit.Time.Minute + leaveTimeTimeEdit.Time.Hour * 60);
            TotalHouer = compMonth / 60;
        }

        private void backTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {
            float compMonth = (backTimeTimeEdit.Time.Minute + backTimeTimeEdit.Time.Hour * 60) - (leaveTimeTimeEdit.Time.Minute + leaveTimeTimeEdit.Time.Hour * 60);
            TotalHouer = compMonth / 60;
        }
    }
}