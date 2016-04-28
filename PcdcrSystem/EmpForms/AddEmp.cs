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
using Telerik.WinControls;
using PcdcrData.CmdClass;

namespace PcdcrSystem.EmpForms
{
    public partial class AddEmp : DevExpress.XtraEditors.XtraForm
    {
        public AddEmp()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 

        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
             startTimeTimeEdit.EditValue = DateTime.Parse("09:00:00");
            endTimeTimeEdit.EditValue = DateTime.Parse("15:00:00");
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
             #region "  CheckFillTextBox "
            if (empNameTextEdit.Text == "")
            {

                empNameTextEdit.BackColor = Color.OrangeRed;
                empNameTextEdit.Focus();

                return;
            }
            else
            {
                empNameTextEdit.BackColor = Color.White;
            }

            if (empNoTextEdit.Text == "")
            {

                empNoTextEdit.BackColor = Color.OrangeRed;
                empNoTextEdit.Focus();

                return;
            }
            else
            {
                empNoTextEdit.BackColor = Color.White;
            }
            
            #endregion

            EmpTable tb = new EmpTable()
            {

            EmpName = empNameTextEdit.Text,
            EmpNo=empNoTextEdit.Text,
            WorkTimeNo=float.Parse(workTimeNoSpinEdit.EditValue.ToString()),
            StartTime=startTimeTimeEdit.Time.TimeOfDay,
            EndTime=endTimeTimeEdit.Time.TimeOfDay,
            Pssword= psswordTextEdit.Text,
            };
            EmpCmd.addEmp(tb);

            RadMessageBox.Show("تمت عملية الحفظ", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);
            empNameTextEdit.ResetText();
            empNoTextEdit.ResetText();
            psswordTextEdit.ResetText();
            empNameTextEdit.Focus();


        }

        private void startTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {
            float compMonth = (endTimeTimeEdit.Time.Minute + endTimeTimeEdit.Time.Hour*60) - (startTimeTimeEdit.Time.Minute + startTimeTimeEdit.Time.Hour*60);
            float Totaltime = compMonth/60;
            workTimeNoSpinEdit.EditValue = Totaltime;
        }

        private void endTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {
            float compMonth = (endTimeTimeEdit.Time.Minute + endTimeTimeEdit.Time.Hour * 60) - (startTimeTimeEdit.Time.Minute + startTimeTimeEdit.Time.Hour * 60);
            float Totaltime = compMonth/60;
            workTimeNoSpinEdit.EditValue = Totaltime;
        }

        }
    }
