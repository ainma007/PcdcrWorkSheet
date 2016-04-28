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

namespace PcdcrSystem.Report
{
    public partial class ReportFrm : DevExpress.XtraEditors.XtraForm
    {
        public ReportFrm()
        {
            InitializeComponent();
        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}