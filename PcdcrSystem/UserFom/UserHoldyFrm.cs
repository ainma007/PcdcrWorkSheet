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

namespace PcdcrSystem.UserFom
{
    public partial class UserHoldyFrm : DevExpress.XtraEditors.XtraForm
    {
        public UserHoldyFrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            HoldyTable tb = new HoldyTable
            {
                EmpID=UserClass.XEmpId,
                HoldyDate=holdyDateTimePicker.Value.Date,
                HoldType=HoldyTypeDropDownList.Text,
            
            };
            HoldyCmd.addHoldy(tb);
            RadMessageBox.Show("تمت عملية الحفظ", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);
            Loginfrm myForm = (Loginfrm)Application.OpenForms["Loginfrm"];
            myForm.Show();
            this.Close();

        }

        private void UserHoldyFrm_Load(object sender, EventArgs e)
        {
            holdyDateTimePicker.Value = DateTime.Now.Date;
          
        }
    }
}