using PcdcrData;
using PcdcrData.CmdClass;
using PcdcrSystem.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PcdcrSystem.EmpForms
{
    public partial class ManagEmpfrm : Form
    {
        public ManagEmpfrm()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Dark"); 

        }

        private void ManagEmpfrm_Load(object sender, EventArgs e)
        {
            EmpGridView.DataSource = EmpCmd.GetAll();
        }

        private void EmpGridView_CommandCellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

            var col = EmpGridView.CurrentColumn.Index;
            if (col == 6)
            {

                EditEmpFrm frm = new EditEmpFrm();
                EmpTable tb = (EmpTable)EmpGridView.CurrentRow.DataBoundItem;
                frm.MyEMP = tb;
                frm.ShowDialog();




            }

            if (col == 7)
            {
                if (RadMessageBox.Show(this, "هل تريد حذف السجل", "حذف السجلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {

                    if (EmpCmd.DeleteDepartment(((EmpTable)this.EmpGridView.CurrentRow.DataBoundItem).Id))
                    {

                        ManagEmpfrm_Load(null, null);






                    }

                    else
                    {

                        RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);


                    }
                }

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddEmp frm = new AddEmp();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmpReportCmd cmd = new EmpReportCmd();
            cmd.GetAllEmployee();
        }
    }
}