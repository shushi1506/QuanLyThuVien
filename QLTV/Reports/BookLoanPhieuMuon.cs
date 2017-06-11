using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLTV.Reports
{
    public partial class BookLoanPhieuMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public BookLoanPhieuMuon(string tendocgia,DateTime dt)
        {
            InitializeComponent();
            lblngaytao.Text = DateTime.Today.ToShortDateString();
            this.phieuMuonDataTableTableAdapter1.Fill(this.bookManager1.PhieuMuonDataTable, tendocgia, dt.ToString("MM/dd/yyyy"));

        }

    }
}
