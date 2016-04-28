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
using Telerik.WinControls;

namespace PcdcrSystem.UserFom
{
    public partial class Loginfrm : DevExpress.XtraEditors.XtraForm
    {
        public Loginfrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 

        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
             var q = EmpCmd.Login(empNoTextEdit.Text.ToString());
             if (q != null)
             {
                 UserClass.XEmpId = q.Id;
                 UserClass.XEmpName = q.EmpName;
                 UserClass.XWorkTime = float.Parse(q.WorkTimeNo.ToString());
                 UserWorkFrm frm = new UserWorkFrm();
                 this.Hide();

                 frm.ShowDialog();
                 Loginfrm_Load(null, null);
                 
             }

             else
             {
                 RadMessageBox.Show("تأكد من الرقم الوظيفي", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                 return;


             }
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            empNoTextEdit.ResetText();
            empNoTextEdit.Focus();
        }

        private void دخولالمسؤولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLogin frm = new AdminLogin();
            this.Hide();
            frm.ShowDialog();
         
        }

        private void Loginfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void empNoTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                EnterBtn_Click(sender, e);
                e.Handled = true;


            }
        }
    }
}