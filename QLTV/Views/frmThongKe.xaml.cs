using DevExpress.Xpf.Printing;
using QLTV.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QLTV.Views
{
    /// <summary>
    /// Interaction logic for frmThongKe.xaml
    /// </summary>
    public partial class frmThongKe : Window
    {
        public frmThongKe()
        {
            InitializeComponent();
            Controllers.DocGiaController controll = new Controllers.DocGiaController();
            _cbbtendocgia.ItemsSource = controll.GetAllDocGia;
            _cbbtendocgia.DisplayMemberPath = "TenDocGia";
            if (_rdsachmember.IsChecked == true)
            {
                _gridall.IsEnabled = false;
                _gridall.Visibility = Visibility.Hidden;
                _gridmember.IsEnabled = true;
                _gridmember.Visibility = Visibility.Visible;
            }
            if (_rdall.IsChecked == true)
            {
                _gridmember.IsEnabled = false;
                _gridmember.Visibility = Visibility.Hidden;
                _gridall.IsEnabled = true;
                _gridall.Visibility = Visibility.Visible;
            }

        }

        private void _rccahaitc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _reportprint_Click(object sender, RoutedEventArgs e)
        {
            if (_rdall.IsChecked == true)
            {
                if (_rccahaitc.IsChecked == true)
                {
                    BooksLoanAll report = new BooksLoanAll();
                    //report.FilterString = "[DaTra] = false";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();
                }
                if (_rddatratc.IsChecked == true)
                {
                    BooksLoanAll report = new BooksLoanAll();
                    report.FilterString = "[DaTra] = true";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();
                }
                if (_rdchuatratc.IsChecked == true)
                {
                    BooksLoanAll report = new BooksLoanAll();
                    report.FilterString = "[DaTra] = false";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();
                }
            }
            if (_rdsachmember.IsChecked == true)
            {
                if (_cbbtendocgia.SelectedItem == null)
                {
                    MessageBox.Show("Chon Doi Tuong", "Thong Bao", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                if (_ckcahai.IsChecked == true)
                {
                  
                    BookLoanByMemBer report = new BookLoanByMemBer((_cbbtendocgia.SelectedItem as View_Models.DocGia).MaDocGia);
                    //report.FilterString = "[DaTra] = false";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();

                }
                if (_ckchuatra.IsChecked == true)
                {
                    BookLoanByMemBer report = new BookLoanByMemBer((_cbbtendocgia.SelectedItem as View_Models.DocGia).MaDocGia);
                    report.FilterString = "[DaTra] = false";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();
                }
                if (_ckdatra.IsChecked == true)
                {
                    BookLoanByMemBer report = new BookLoanByMemBer((_cbbtendocgia.SelectedItem as View_Models.DocGia).MaDocGia);
                    report.FilterString = "[DaTra] = true";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();
                }
            }
        }


        private void _rdall_Click(object sender, RoutedEventArgs e)
        {
            if (_rdall.IsChecked == true)
            {
                _gridmember.IsEnabled = false;
                _gridmember.Visibility = Visibility.Hidden;
                _gridall.IsEnabled = true;
                _gridall.Visibility = Visibility.Visible;
            }
        }

        private void _rdsachmember_Click(object sender, RoutedEventArgs e)
        {
            if (_rdsachmember.IsChecked == true)
            {
                _gridall.IsEnabled = false;
                _gridall.Visibility = Visibility.Hidden;
                _gridmember.IsEnabled = true;
                _gridmember.Visibility = Visibility.Visible;
            }
        }
    }
}
