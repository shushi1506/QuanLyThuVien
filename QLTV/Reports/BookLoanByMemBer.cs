using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLTV.Reports
{
    public partial class BookLoanByMemBer : DevExpress.XtraReports.UI.XtraReport
    {
        public BookLoanByMemBer(string mdg)
        {
            InitializeComponent();
            lblngaytao.Text = DateTime.Today.ToString("dd/MM/yyyy");
            this.bookLoanByMemBerTableAdapter.Fill(this.bookManager1.BookLoanByMemBerTable, mdg);
        }

    }
}
