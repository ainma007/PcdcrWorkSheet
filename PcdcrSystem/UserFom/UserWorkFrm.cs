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
using PcdcrData.CmdClass;
using PcdcrData;
using Telerik.WinControls;

namespace PcdcrSystem.UserFom
{
    public partial class UserWorkFrm : DevExpress.XtraEditors.XtraForm
    {
        public UserWorkFrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark");
        }
        public DateTime Startime { get; set; }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            WorkTable tb = new WorkTable()
            {
                EmpId= UserClass.XEmpId,
                WorkDate=DateTime.Now.Date,
                startTime=DateTime.Parse(DateTime.Now.ToShortTimeString()).TimeOfDay,
                endtime=DateTime.Parse(DateTime.Now.ToShortTimeString()).TimeOfDay,
                RealWorkTimeNo=UserClass.XWorkTime,
                WorkTime=0,
                DefernceTime = (0-UserClass.XWorkTime)


                 
            };
            WorkCmd.addWork(tb);
            RadMessageBox.Show("تم تسجيل الحضور", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);

            Loginfrm myForm = (Loginfrm)Application.OpenForms["Loginfrm"];
            myForm.Show();
            this.Close();

        }

        private void UserWorkFrm_Load(object sender, EventArgs e)
        {
            var q = WorkCmd.CheckWork(UserClass.XEmpId,DateTime.Now.Date);
            if (q != null)
            {

                simpleButton1.Enabled = false;
                simpleButton2.Enabled = true;
                if (q.WorkFinsh == "true")
                {
                    simpleButton1.Enabled = false;
                    simpleButton2.Enabled = false;

                }

                               
            }
            else
            {
                simpleButton1.Enabled = true;
                simpleButton2.Enabled = false;
            }
            EmpNameTxt.Text = UserClass.XEmpName;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTxt.Text = DateTime.Now.Date.ToShortDateString();
            HourText.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (RadMessageBox.Show(this, "هل تريد حفظ التعديلات", "حفظ", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                var ListData = WorkCmd.GetWorkInfo(UserClass.XEmpId, DateTime.Now.Date);

                foreach (var item in ListData)
                {
                    Startime = DateTime.Parse(item.startTime.ToString());

                }

                float compMonth = (DateTime.Now.Minute + DateTime.Now.Hour * 60) - (Startime.Minute + Startime.Hour * 60);
                float Totaltime = compMonth / 60;


                WorkTable tb = new WorkTable()
                {
                    EmpId = UserClass.XEmpId,
                    WorkDate = DateTime.Now.Date,
                    startTime = Startime.TimeOfDay,
                    endtime = DateTime.Parse(DateTime.Now.ToShortTimeString()).TimeOfDay,
                    RealWorkTimeNo = UserClass.XWorkTime,
                    WorkTime = Totaltime,
                    DefernceTime = (Totaltime - UserClass.XWorkTime),
                    WorkFinsh = "true"

                };
                WorkCmd.EditWorkUser(tb);
                RadMessageBox.Show("تم تسجيل الانصراف", "تمت", MessageBoxButtons.OK, RadMessageIcon.Info);

                Loginfrm myForm = (Loginfrm)Application.OpenForms["Loginfrm"];
                myForm.Show();
                this.Close();
            }

          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            UserHoldyFrm frm = new UserHoldyFrm();
            frm.ShowDialog();
        }
    }
}