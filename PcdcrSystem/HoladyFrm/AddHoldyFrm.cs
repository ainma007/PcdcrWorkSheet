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

namespace PcdcrSystem.HoladyFrm
{
    public partial class AddHoldyFrm : DevExpress.XtraEditors.XtraForm
    {
        public AddHoldyFrm()
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
        private void AddHoldyFrm_Load(object sender, EventArgs e)
        {
            holdyDateTimePicker.Value = DateTime.Now.Date;
            fillcombo();

            
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
            var q = HoldyCmd.CheckHoldy(int.Parse(EmpComboBox.SelectedValue.ToString()), holdyDateTimePicker.Value.Date);
            if (q != null)
            {
                RadMessageBox.Show("مسجل في هذا التاريخ مسبقاً", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;
            }
            
            HoldyTable tb = new HoldyTable()
            {
                EmpID = int.Parse(EmpComboBox.SelectedValue.ToString()),
                HoldyDate = holdyDateTimePicker.Value.Date,
                HoldType = HoldyTypeDropDownList.Text,
            };
            HoldyCmd.addHoldy(tb);
            RadMessageBox.Show("تمت عملية الحفظ", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);
            EmpComboBox.Focus();
            HoldyTypeDropDownList.ResetText();
        }
    }
}