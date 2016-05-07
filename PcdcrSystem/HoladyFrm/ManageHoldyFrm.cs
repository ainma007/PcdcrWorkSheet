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
    public partial class ManageHoldyFrm : DevExpress.XtraEditors.XtraForm
    {
        public ManageHoldyFrm()
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
        private void ManageHoldyFrm_Load(object sender, EventArgs e)
        {
            fillcombo();
            HoldyGridView.DataSource = HoldyCmd.GetAll();
            FromDateTimePicker.Value = DateTime.Now.Date;
            ToDateTimePicker.Value = DateTime.Now.Date;
        }

        private void HoldyGridView_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var col = HoldyGridView.CurrentColumn.Index;
            if (col == 4)
            {

                EditHoldyFrm frm = new EditHoldyFrm();
                HoldyTable tb = (HoldyTable)HoldyGridView.CurrentRow.DataBoundItem;
                frm.Htb = tb;
                frm.ShowDialog();




            }

            if (col == 5)
            {
                if (RadMessageBox.Show(this, "هل تريد حذف السجل", "حذف السجلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {

                    if (HoldyCmd.DeleteHoldy(((HoldyTable)this.HoldyGridView.CurrentRow.DataBoundItem).Id))
                    {

                       






                    }

                    else
                    {

                        RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);


                    }
                }

            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked == true && checkBox2.Checked == false)
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

                this.Cursor = Cursors.WaitCursor;
                HoldyGridView.DataSource = HoldyCmd.GetByEmpID(int.Parse(EmpComboBox.SelectedValue.ToString()));

                GC.SuppressFinalize(HoldyCmd.GetByEmpID(int.Parse(EmpComboBox.SelectedValue.ToString())));

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Cursor = Cursors.Default;

                
            }


            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
               

                this.Cursor = Cursors.WaitCursor;
                HoldyGridView.DataSource = HoldyCmd.GetByDate(FromDateTimePicker.Value.Date,ToDateTimePicker.Value.Date);

                GC.SuppressFinalize(HoldyCmd.GetByDate(FromDateTimePicker.Value.Date, ToDateTimePicker.Value.Date));

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Cursor = Cursors.Default;


            }

            if (checkBox1.Checked == true && checkBox2.Checked == true)
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

                this.Cursor = Cursors.WaitCursor;
                HoldyGridView.DataSource = HoldyCmd.GetByIDAndDate(int.Parse(EmpComboBox.SelectedValue.ToString()),FromDateTimePicker.Value.Date,ToDateTimePicker.Value.Date);

                GC.SuppressFinalize(HoldyCmd.GetByIDAndDate(int.Parse(EmpComboBox.SelectedValue.ToString()), FromDateTimePicker.Value.Date, ToDateTimePicker.Value.Date));

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Cursor = Cursors.Default;


            }


        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddHoldyFrm frm = new AddHoldyFrm();
            frm.ShowDialog();
        }
    }
}