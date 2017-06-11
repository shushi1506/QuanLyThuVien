using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLTV.Reports
{
    public partial class MemBerAll : DevExpress.XtraReports.UI.XtraReport
    {
        public MemBerAll()
        {
            InitializeComponent();
            lblngaytao.Text = DateTime.Today.ToShortDateString();
            this.memBerAllTableAdapter1.Fill(this.bookManager1.MemBerAllTable);

        }

    }
}
