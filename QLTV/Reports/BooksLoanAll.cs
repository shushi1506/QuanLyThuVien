using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLTV.Reports
{
    public partial class BooksLoanAll : DevExpress.XtraReports.UI.XtraReport
    {
        public BooksLoanAll()
        {
            InitializeComponent();
            lblngaytao.Text = DateTime.Today.ToString("dd/MM/yyyy");
            this.bookLoanAllTableAdapter1.Fill(this.bookManager1.BookLoanAllTable);
        }

    }
}
