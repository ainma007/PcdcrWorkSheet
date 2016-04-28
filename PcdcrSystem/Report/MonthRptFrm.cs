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
    public partial class MonthRptFrm : DevExpress.XtraEditors.XtraForm
    {
        public MonthRptFrm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MonthWorkCmd cmd = new MonthWorkCmd();
            cmd.GetRptCollectionByDateAndID(RadDateTimePicker.Value.Date, radDateTimePicker1.Value.Date);
        }

        private void MonthRptFrm_Load(object sender, EventArgs e)
        {
            RadDateTimePicker.Value=DateTime.Now.Date;
            radDateTimePicker1.Value = DateTime.Now.Date;
        }
    }
}