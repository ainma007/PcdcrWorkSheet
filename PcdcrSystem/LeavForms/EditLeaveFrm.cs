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


namespace PcdcrSystem.LeavForms
{
    public partial class EditLeaveFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditLeaveFrm()
        {
            InitializeComponent();
        }
        public LeaveTable LvTb { get; set; }
        public float WorkHouer { get; set; }
        public DateTime Startime { get; set; }
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
        private void EditLeaveFrm_Load(object sender, EventArgs e)
        {
            fillcombo();
            EmpComboBox.Text = LvTb.EmpTable.EmpName;
            LeaveDateTimePicker.Value = LvTb.LeaveDate.Value;
            leaveTimeTimeEdit.EditValue = LvTb.LeaveTime;
            backTimeTimeEdit.EditValue = LvTb.BackTime;
            radDropDownList1.Text = LvTb.LeaveType;
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

            
           

            #endregion

       var q = WorkCmd.CheckWork(int.Parse(EmpComboBox.SelectedValue.ToString()), LeaveDateTimePicker.Value.Date);
       if (q != null)
       {

           if (RadMessageBox.Show(this, "هل تريد حفظ التغيرات", "تنبيه", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
           {
               LvTb.EmpId = int.Parse(EmpComboBox.SelectedValue.ToString());
               LvTb.LeaveDate = LeaveDateTimePicker.Value.Date;
               LvTb.LeaveTime = leaveTimeTimeEdit.Time.TimeOfDay;
               LvTb.BackTime = backTimeTimeEdit.Time.TimeOfDay;
               LvTb.LeaveType = radDropDownList1.Text;
               LeaveCmdClass.EditLeave(LvTb);


           }
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
                   WorkDate = LeaveDateTimePicker.Value.Date,
                   startTime = Startime.TimeOfDay,
                   endtime = leaveTimeTimeEdit.Time.TimeOfDay,
                   RealWorkTimeNo = UserClass.XWorkTime,
                   WorkTime = Totaltime,
                   DefernceTime = (Totaltime - UserClass.XWorkTime),
                   WorkFinsh = "true"

               };
               WorkCmd.EditWorkUser(tb1);
               RadMessageBox.Show("تمت الاضافة واعتماد ساعة الانتهاء من الدوام", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);

           }

           RadMessageBox.Show("تمت الاضافة بدون اعتماد ساعةالانتهاء من الدوام", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);

       }
       else
       {
           RadMessageBox.Show("يرجى اولا تسجيل الحضور", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
           return;
       }
        }
    }
}