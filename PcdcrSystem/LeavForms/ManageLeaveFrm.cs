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

namespace PcdcrSystem.LeavForms
{
    public partial class ManageLeaveFrm : DevExpress.XtraEditors.XtraForm
    {
        public ManageLeaveFrm()
        {
            InitializeComponent();
        }

        private void ManageLeaveFrm_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = LeaveCmdClass.GetAll();
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
                radGridView1.DataSource = WorkCmd.GetByEmpID(int.Parse(EmpComboBox.SelectedValue.ToString()));

                GC.SuppressFinalize(HoldyCmd.GetByEmpID(int.Parse(EmpComboBox.SelectedValue.ToString())));

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Cursor = Cursors.Default;


            }


            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {


                this.Cursor = Cursors.WaitCursor;
                radGridView1.DataSource = WorkCmd.GetByDate(FromDateTimePicker.Value.Date, ToDateTimePicker.Value.Date);

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
                radGridView1.DataSource = WorkCmd.GetByIDAndDate(int.Parse(EmpComboBox.SelectedValue.ToString()), FromDateTimePicker.Value.Date, ToDateTimePicker.Value.Date);

                GC.SuppressFinalize(HoldyCmd.GetByIDAndDate(int.Parse(EmpComboBox.SelectedValue.ToString()), FromDateTimePicker.Value.Date, ToDateTimePicker.Value.Date));

                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Cursor = Cursors.Default;


            }

        }

        private void radGridView1_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;
            if (col == 7)
            {

                EditLeaveFrm frm = new EditLeaveFrm();
                LeaveTable tb = (LeaveTable)radGridView1.CurrentRow.DataBoundItem;
                frm.LvTb = tb;
                frm.ShowDialog();




            }

            if (col == 8)
            {
                if (RadMessageBox.Show(this, "هل تريد حذف السجل", "حذف السجلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {

                    if (LeaveCmdClass.DeleteLeave(((LeaveTable)this.radGridView1.CurrentRow.DataBoundItem).Id))
                    {








                    }

                    else
                    {

                        RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);


                    }
                }

            }
        }
    }
}