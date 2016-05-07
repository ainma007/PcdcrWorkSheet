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
    public partial class AdminLogin : DevExpress.XtraEditors.XtraForm
    {
        public AdminLogin()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var q = EmpCmd.Login(UserTxt.Text.ToString(), PassText.Text.ToString());
            if (q != null)
            {
                MainForm frm = new MainForm();
                frm.ShowDialog();
            }
            else
            {
                RadMessageBox.Show("خطأ في كلمة المرور", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);
                return;


            }

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Loginfrm myForm = (Loginfrm)Application.OpenForms["Loginfrm"];
            //myForm.Show();
            //this.Close();
        }

        private void PassText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                LoginBtn_Click(sender, e);
                e.Handled = true;


            }
        }
    }
}