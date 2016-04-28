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

namespace PcdcrSystem.HoladyFrm
{
    public partial class EditHoldyFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditHoldyFrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 
        }
        public HoldyTable Htb { get; set; }
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
        private void EditHoldyFrm_Load(object sender, EventArgs e)
        {
            fillcombo();
            EmpComboBox.Text = Htb.EmpTable.EmpName;
            holdyDateTimePicker.Value = Htb.HoldyDate.Value.Date;
            HoldyTypeDropDownList.Text = Htb.HoldType;


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(this, "هل تريد حفظ التعديلات", "حفظ", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Htb.EmpID = int.Parse(EmpComboBox.SelectedValue.ToString());
                Htb.HoldyDate = holdyDateTimePicker.Value.Date;
                Htb.HoldType = HoldyTypeDropDownList.Text;


                HoldyCmd.EditHoldy(Htb);
                RadMessageBox.Show("تمت عملية الحفظ", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();


            }
        }
    }
}