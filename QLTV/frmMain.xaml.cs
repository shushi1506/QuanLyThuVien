using DevExpress.Xpf.Docking;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;

using System.Windows.Input;

using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Core;


using System.Windows.Threading;

using QLTV.Reports;


namespace QLTV
{
    /// <summary>
    /// Interaction logic for frmMain.xaml
    /// </summary>
    public partial class frmMain : Window
    {

        public frmMain()
        {
            ApplicationThemeHelper.ApplicationThemeName = "Office2010Blue";
            InitializeComponent();
            startClock();
            DocumentPanel panelSach
         = new DocumentPanel()
         {
             Content = new Uri(@"Views\frmSach.xaml", UriKind.Relative),
             Caption = "Quản lý Sách"
         };
            documentGr.Items.Add(panelSach);

            docklayout.DockController.Activate(panelSach);
            LoadRoleView();
        }

        public void LoadRoleView()
        {
            try
            {
                if (App.Role.ViewAll == true)
                {
                    _navngoidunggroup.IsEnabled = true;
                    _navsachgroup.IsEnabled = true;
                    _navusergroup.IsEnabled = true;
                    _rpgmuontra.IsEnabled = true;
                    _rpgnguoimuon.IsEnabled = true;
                    _rpgsach.IsEnabled = true;
                    _rpgthongke.IsEnabled = true;
                    _rpguser.IsEnabled = true;
                }
                else
                {
                    if (App.Role.ViewDocGia == true)
                    {
                        _navngoidunggroup.IsEnabled = true;
                        _rpgnguoimuon.IsEnabled = true;
                    }
                    else
                    {
                        _navngoidunggroup.IsEnabled = false;
                        _rpgnguoimuon.IsEnabled = false;
                    }
                    if (App.Role.ViewSach == true)
                    {
                        _navsachgroup.IsEnabled = true;
                        _rpgsach.IsEnabled = true;
                    }
                    else
                    {
                        _navsachgroup.IsEnabled = true;
                        _rpgsach.IsEnabled = true;
                    }
                    if (App.Role.ViewSachMuon == true)
                    {
                        _navsachmuongroup.IsEnabled = true;
                    }
                    else
                    { _navsachmuongroup.IsEnabled = false; }
                    if (App.Role.ViewThongKe == true)
                    {
                        _rpgthongke.IsEnabled = true;
                    }
                    else _rpgthongke.IsEnabled = false;
                    if (App.Role.ViewUser == true)
                    {
                        _rpguser.IsEnabled = true;
                    }
                    else _rpguser.IsEnabled = false;
                }
            }
            catch { _bbiadduser.IsEnabled = false; }
        }
        private void _btnkhosach_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            try
            {
                DocumentPanel dcpanelSach = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Sách")) as DocumentPanel;
                if (dcpanelSach == null)
                {
                    DocumentPanel panelSach
                 = new DocumentPanel()
                 {
                     Content = new Uri(@"Views\frmSach.xaml", UriKind.Relative),
                     Caption = "Quản lý Sách"
                 };
                    documentGr.Items.Add(panelSach);
                    docklayout.DockController.Activate(panelSach);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelSach);
                }
            }
            catch 
            {

            }
        }

        private void _bbisachdamuon_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            try
            {
                DocumentPanel dcpanelMuon = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Mượn Sách")) as DocumentPanel;
                if (dcpanelMuon == null)
                {
                    DocumentPanel panelMuon
            = new DocumentPanel()
            {
                Content = new Uri(@"Views\frmSachMuon.xaml", UriKind.Relative),
                Caption = "Quản lý Mượn Sách"
            };
                    documentGr.Items.Add(panelMuon);
                    docklayout.DockController.Activate(panelMuon);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelMuon);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _bbidocgia_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            try
            {
                DocumentPanel dcpanelDocGia = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Đọc Giả")) as DocumentPanel;
                if (dcpanelDocGia == null)
                {
                    DocumentPanel panelDocgia
           = new DocumentPanel()
           {
               Content = new Uri(@"Views\frmDocGia.xaml", UriKind.Relative),
               Caption = "Quản lý Đọc Giả"
           };
                    documentGr.Items.Add(panelDocgia);
                    docklayout.DockController.Activate(panelDocgia);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelDocGia);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _btntheloai_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            try
            {
                DocumentPanel dcpanelTl = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý thông tin bên ngoài")) as DocumentPanel;
                if (dcpanelTl == null)
                {

                    DocumentPanel panelTL
          = new DocumentPanel()
          {
              Content = new Uri(@"Views\frmTheLoai.xaml", UriKind.Relative),
              Caption = "Quản lý thông tin bên ngoài"
          };
                    documentGr.Items.Add(panelTL);
                    docklayout.DockController.Activate(panelTL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelTl);
                }
            }
            catch (Exception)
            {

            }
        }


        private void _bbisachmuon_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            Views.frmThongKe fr = new Views.frmThongKe();
            fr.ShowDialog();
        }

        private void _bbikhoalop_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            try
            {
                DocumentPanel dcpanelKL = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý khoa lop")) as DocumentPanel;
                if (dcpanelKL == null)
                {

                    DocumentPanel panelKL
        = new DocumentPanel()
        {
            Content = new Uri(@"Views\frmKhoaLop.xaml", UriKind.Relative),
            Caption = "Quản lý khoa lop"
        };
                    documentGr.Items.Add(panelKL);
                    docklayout.DockController.Activate(panelKL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelKL);
                }
            }
            catch (Exception)
            {

            }
        }

       
        private string _UserName;

        public string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

        private void _bbidocgiareport_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            MemBerAll report = new MemBerAll();
            DocumentPreviewWindow window = new DocumentPreviewWindow();
            window.PreviewControl.DocumentSource = report;
            report.CreateDocument(true);
            window.ShowDialog();
        }

        private void _bbiadduser_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            try
            {
                DocumentPanel dcpanelKL = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Người Dùng")) as DocumentPanel;
                if (dcpanelKL == null)
                {

                    DocumentPanel panelKL
        = new DocumentPanel()
        {
            Content = new Uri(@"Views\frmUser.xaml", UriKind.Relative),
            Caption = "Quản lý Người Dùng"
        };
                    documentGr.Items.Add(panelKL);
                    docklayout.DockController.Activate(panelKL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelKL);
                }
            }
            catch (Exception)
            {

            }
        }
        private void startClock()
        {
            DispatcherTimer time = new DispatcherTimer();
            time.Interval = TimeSpan.FromSeconds(1);
            time.Tick += tichEvent;
            time.Start();

        }

        private void tichEvent(object sender, EventArgs e)
        {
            label.Content = DateTime.Now.ToString(@"hh\:mm\:ss:tt");
            DateTime dt = new DateTime();

        }

        private void datenavi_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            foreach (DateTime dt in datenavi.SelectedDates)
            {
                MessageBox.Show(Convert.ToString(dt));
            }
        }

        private void _navtheloai_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelTl = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý thông tin bên ngoài")) as DocumentPanel;
                if (dcpanelTl == null)
                {

                    DocumentPanel panelTL
          = new DocumentPanel()
          {
              Content = new Uri(@"Views\frmTheLoai.xaml", UriKind.Relative),
              Caption = "Quản lý thông tin bên ngoài"
          };
                    documentGr.Items.Add(panelTL);
                    docklayout.DockController.Activate(panelTL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelTl);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navtacgia_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelTl = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý thông tin bên ngoài")) as DocumentPanel;
                if (dcpanelTl == null)
                {

                    DocumentPanel panelTL
          = new DocumentPanel()
          {
              Content = new Uri(@"Views\frmTheLoai.xaml", UriKind.Relative),
              Caption = "Quản lý thông tin bên ngoài"
          };
                    documentGr.Items.Add(panelTL);
                    docklayout.DockController.Activate(panelTL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelTl);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navnxb_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelTl = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý thông tin bên ngoài")) as DocumentPanel;
                if (dcpanelTl == null)
                {

                    DocumentPanel panelTL
          = new DocumentPanel()
          {
              Content = new Uri(@"Views\frmTheLoai.xaml", UriKind.Relative),
              Caption = "Quản lý thông tin bên ngoài"
          };
                    documentGr.Items.Add(panelTL);
                    docklayout.DockController.Activate(panelTL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelTl);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navsachmuon_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelMuon = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Mượn Sách")) as DocumentPanel;
                if (dcpanelMuon == null)
                {
                    DocumentPanel panelMuon
            = new DocumentPanel()
            {
                Content = new Uri(@"Views\frmSachMuon.xaml", UriKind.Relative),
                Caption = "Quản lý Mượn Sách"
            };
                    documentGr.Items.Add(panelMuon);
                    docklayout.DockController.Activate(panelMuon);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelMuon);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navdocgia_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelDocGia = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Đọc Giả")) as DocumentPanel;
                if (dcpanelDocGia == null)
                {
                    DocumentPanel panelDocgia
           = new DocumentPanel()
           {
               Content = new Uri(@"Views\frmDocGia.xaml", UriKind.Relative),
               Caption = "Quản lý Đọc Giả"
           };
                    documentGr.Items.Add(panelDocgia);
                    docklayout.DockController.Activate(panelDocgia);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelDocGia);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navlop_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelKL = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý khoa lop")) as DocumentPanel;
                if (dcpanelKL == null)
                {

                    DocumentPanel panelKL
        = new DocumentPanel()
        {
            Content = new Uri(@"Views\frmKhoaLop.xaml", UriKind.Relative),
            Caption = "Quản lý khoa lop"
        };
                    documentGr.Items.Add(panelKL);
                    docklayout.DockController.Activate(panelKL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelKL);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navkhoa_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelKL = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý khoa lop")) as DocumentPanel;
                if (dcpanelKL == null)
                {

                    DocumentPanel panelKL = new DocumentPanel()
                    {
                        Content = new Uri(@"Views\frmKhoaLop.xaml", UriKind.Relative),
                        Caption = "Quản lý khoa lop"
                    };

                    documentGr.Items.Add(panelKL);
                    docklayout.DockController.Activate(panelKL);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelKL);
                }
            }
            catch (Exception)
            {

            }
        }

        private void _navnguoidung_Click(object sender, EventArgs e)
        {

        }

        private void _navsach_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentPanel dcpanelSach = documentGr.Items.SingleOrDefault(m => m.Caption.Equals("Quản lý Sách")) as DocumentPanel;
                if (dcpanelSach == null)
                {
                    DocumentPanel panelSach
                 = new DocumentPanel()
                 {
                     Content = new Uri(@"Views\frmSach.xaml", UriKind.Relative),
                     Caption = "Quản lý Sách"
                 };
                    documentGr.Items.Add(panelSach);
                    docklayout.DockController.Activate(panelSach);
                }
                else
                {
                    docklayout.DockController.Activate(dcpanelSach);
                }
            }
            catch (Exception)
            {

            }

        }


        private void _btnchangepass_Click(object sender, RoutedEventArgs e)
        {
            //if (_btnchangepass.Content.Equals("Change Pass"))
            //{
            //    _btnchangepass.Content = "Save";
            //    passwordBox1.IsEnabled = true;
            //    passwordBox.Clear();
            //    passwordBox1.ToolTip = "Nhập Lại Pass";
            //    _btncancelsavepass.Visibility = Visibility.Visible;
            //    _btncancelsavepass.IsEnabled = true;
            //    passwordBox.Focus();
            //    return;
            //}
            //string warning = "";
            //if (String.IsNullOrWhiteSpace(passwordBox.Password))
            //{
            //    warning += "Nhập password." + '\n';
            //}
            //if (String.IsNullOrWhiteSpace(passwordBox1.Password))
            //{
            //    warning += "Pass nhập lại không đúng." + '\n';
            //}
            //if (!warning.Equals(""))
            //{
            //    MessageBox.Show(warning,
            //        "Cập Nhật Pass",
            //        MessageBoxButton.OK,
            //        MessageBoxImage.Warning);
            //    return;
            //}
            //try
            //{
            //    if (passwordBox.Password == passwordBox1.Password)
            //    {
            //        UserController us = new UserController();
            //        View_Models.User user = us.GetById(Id);
            //        user.PASSWORD = passwordBox.Password.Trim();
            //        if (us.Edit(user))
            //        {
            //            MessageBox.Show("Cập Nhật thành công", "Cập Nhật Password", MessageBoxButton.OK, MessageBoxImage.Information);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Cập Nhật thất bại", "Cập Nhật Password", MessageBoxButton.OK, MessageBoxImage.Information);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Pass word nhập lại không trùng khớp", "Cập Nhật Password", MessageBoxButton.OK, MessageBoxImage.Information); return;
            //    }
            //    _btnchangepass.Content = "Change Pass";
            //    passwordBox1.IsEnabled = false;
            //    passwordBox1.Clear();
            //}
            //catch { }
            BookLoanByMemBer report = new BookLoanByMemBer("DG003");
            report.FilterString = "[DaTra] = false";
            DocumentPreviewWindow window = new DocumentPreviewWindow();
            window.PreviewControl.DocumentSource = report;
            report.CreateDocument(true);
            window.ShowDialog();

        }

        private void _btncancelsavepass_Click(object sender, RoutedEventArgs e)
        {
            //_btnchangepass.Content = "Change Pass";
            //passwordBox1.IsEnabled = false;
            //passwordBox1.Clear();
            //passwordBox.Password = role.PASSWORD.Trim();
            //_btncancelsavepass.Visibility = Visibility.Hidden;
            //_btncancelsavepass.IsEnabled = false;
        }

        private void _bbirestart_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            System.Windows.Forms.Application.Restart();

            System.Windows.Application.Current.Shutdown();
        }
    }
}
