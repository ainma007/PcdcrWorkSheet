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
    public partial class EditEmpFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditEmpFrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 

        }
        public EmpTable MyEMP { get; set; }
        private void EditEmpFrm_Load(object sender, EventArgs e)
        {
            empNameTextEdit.Text = MyEMP.EmpName;
            empNoTextEdit.Text = MyEMP.EmpNo;
            startTimeTimeEdit.EditValue = MyEMP.StartTime;
            endTimeTimeEdit.EditValue = MyEMP.EndTime;
            psswordTextEdit.Text = MyEMP.Pssword;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(this, "هل تريد حفظ التعديلات", "حفظ", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                MyEMP.EmpName = empNameTextEdit.Text;
                MyEMP.EmpNo = empNoTextEdit.Text;
                MyEMP.StartTime = startTimeTimeEdit.Time.TimeOfDay;
                MyEMP.EndTime = endTimeTimeEdit.Time.TimeOfDay;
                MyEMP.WorkTimeNo = float.Parse(workTimeNoSpinEdit.EditValue.ToString());
                MyEMP.Pssword = psswordTextEdit.Text;

                EmpCmd.EditDepartment(MyEMP);
                RadMessageBox.Show("تمت عملية الحفظ", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();


            }
        }

        private void startTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {
            int compMonth = (endTimeTimeEdit.Time.Minute + endTimeTimeEdit.Time.Hour * 60) - (startTimeTimeEdit.Time.Minute + startTimeTimeEdit.Time.Hour * 60);
            float Totaltime = compMonth / 60;
            workTimeNoSpinEdit.EditValue = Totaltime;
        }

        private void endTimeTimeEdit_EditValueChanged(object sender, EventArgs e)
        {
            int compMonth = (endTimeTimeEdit.Time.Minute + endTimeTimeEdit.Time.Hour * 60) - (startTimeTimeEdit.Time.Minute + startTimeTimeEdit.Time.Hour * 60);
            float Totaltime = compMonth / 60;
            workTimeNoSpinEdit.EditValue = Totaltime;
        }
    }
}