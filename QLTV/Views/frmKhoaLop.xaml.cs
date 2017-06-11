using DevExpress.Xpf.Core;
using QLTV.Controllers;
using QLTV.View_Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QLTV.Views
{
    /// <summary>
    /// Interaction logic for frmKhoaLop.xaml
    /// </summary>
    public partial class frmKhoaLop : UserControl
    {
        KhoaController khoaControll;
        LopController lopControll;
        public frmKhoaLop()
        {
            InitializeComponent();
            khoaControll = new KhoaController();
            lopControll = new LopController();
            
            LoadKTable();
            LoadLTable();
            if (App.Role.AddAll == true)
            {
                _btnaddK.IsEnabled = true;
                _btnaddL.IsEnabled = true;
                _btnaddK_cancel.IsEnabled = true;
                _btnaddL_cancel.IsEnabled = true;
            }
            else
            {
                if (App.Role.AddDocGia != true)
                {
                    _btnaddK.IsEnabled = false;
                    _btnaddL.IsEnabled = false;
                    _btnaddK_cancel.IsEnabled = false;
                    _btnaddL_cancel.IsEnabled = false;
                }
            }
            if (App.Role.EditAll == true)
            {
                _btnsaveK.IsEnabled = true;
                _btnsaveL.IsEnabled = true;
            }
            else
            {
                if (App.Role.EditDocGia != true)
                {
                    _btnsaveK.IsEnabled = false;
                    _btnsaveL.IsEnabled = false;
                }
            }

            if (App.Role.DeleteAll == true)
            {
                _btndeleteK.IsEnabled = true;
                _btndeleteL.IsEnabled = true;
            }
            else
            {
                if (App.Role.DeleteDocGia != true)
                {
                    _btndeleteK.IsEnabled = false;
                    _btndeleteL.IsEnabled = false;
                }
            }
        }

        public void LoadKTable()
        {
            gridkhoa.ItemsSource = khoaControll.ListKhoa;
            gridkhoa.RefreshData();
           
        }
        private void _txtaddK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_btnaddK.Content.Equals("Add new"))
                {
                    _btnaddK.Content = "Hoàn tất";
                    _btnaddK_cancel.IsEnabled = true;
                    _btnaddK_cancel.Visibility = Visibility.Visible;
                    _btnsaveK.IsEnabled = false;
                    _btndeleteK.IsEnabled = false;
                    _btndeleteK.IsEnabled = false;
                    _btnloadK.IsEnabled = false;
                    gridkhoa.IsEnabled = false;
                    _txtmakhoa.Clear();
                    _txttenkhoa.Clear();
                    return;
                }
                Khoa khoa = new Khoa();
                khoa.MaKhoa = _txtmakhoa.Text.ToUpper();
                khoa.TenKhoa = _txttenkhoa.Text;
                string warning = "";

                if (String.IsNullOrWhiteSpace(_txtmakhoa.Text))
                {
                    warning += "Vui lòng nhập Mã khoa." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txttenkhoa.Text))
                {
                    warning += "Vui lòng nhập tên khoa." + '\n';
                }

                if (!warning.Equals(""))
                {
                    MessageBox.Show(
                        warning,
                        "Thêm mới khoa",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }

                if (khoaControll.Add(khoa))
                {
                    MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới tac giả",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(
                          "Thêm mới thất bại",
                          "Thêm mới lớp",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
                }
                _btnaddK.Content = "Add new";
                _btnaddK_cancel.IsEnabled = false;
                _btnaddK_cancel.Visibility = Visibility.Hidden;
                _btnsaveK.IsEnabled = true;
                _btndeleteK.IsEnabled = true;
                _btndeleteK.IsEnabled = true;
                _btnloadK.IsEnabled = true;
                gridkhoa.IsEnabled = true;
                LoadKTable();
            }
            catch
            {

            }
        }

        private void _btnaddK_cancel_Click(object sender, RoutedEventArgs e)
        {
            _btnaddK.Content = "Add new";
            _btnaddK_cancel.IsEnabled = false;
            _btnaddK_cancel.Visibility = Visibility.Hidden;
            _btnsaveK.IsEnabled = true;
            _btndeleteK.IsEnabled = true;
            _btndeleteK.IsEnabled = true;
            _btnloadK.IsEnabled = true;
            gridkhoa.IsEnabled = true;
            LoadKTable();
        }

        private void _btnsaveK_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu L", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmakhoa.Text.Equals(""))
                    {
                        Khoa khoa = new Khoa();
                        khoa = khoaControll.GetById(_txtmakhoa.Text);
                        khoa.TenKhoa = _txttenkhoa.Text;
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmakhoa.Text))
                        {
                            warning += "Vui lòng nhập mã khoa." + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_txttenkhoa.Text))
                        {
                            warning += "Vui lòng nhập tên tên khoa." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới khoa",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (khoaControll.Edit(khoa))
                        {
                            MessageBox.Show(
                               "Cập nhật thành công",
                               "Cập Nhật khoa",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Cập nhật thất bại",
                               "Cập Nhật khoa",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadKTable();
                    }
                }
                catch { }
            }
        }

        private void _btndeleteK_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xoA không", "Lưu khoa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmakhoa.Text.Equals(""))
                    {
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmakhoa.Text))
                        {
                            warning += "Vui lòng nhập Chọn Cần xóa." + '\n';
                        }


                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới lớp",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (khoaControll.Delete(_txtmakhoa.Text))
                        {
                            MessageBox.Show(
                               "Xóa thành công",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Xóa thất bại",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        LoadKTable();
                    }
                }
                catch { }
            }
        }

        private void _btnloadK_Click(object sender, RoutedEventArgs e)
        {
            LoadKTable();
        }

        private void gridkhoa_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                KhoaModel select = gridkhoa.SelectedItem as KhoaModel;
                Khoa khoa = khoaControll.GetById(select.MaKhoa);
                _txtmakhoa.Text = khoa.MaKhoa;
                _txttenkhoa.Text = khoa.TenKhoa;

            }
            catch { }
        }

        public void LoadLTable()
        {
            gridlop.ItemsSource = lopControll.ListLop;
            gridlop.RefreshData();
        }
        private void _btnaddL_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_btnaddL.Content.Equals("Add new"))
                {
                    _btnaddL.Content = "Hoàn tất";
                    _btnaddL_cancel.IsEnabled = true;
                    _btnaddL_cancel.Visibility = Visibility.Visible;
                    _btnsaveL.IsEnabled = false;
                    _btndeleteL.IsEnabled = false;
                    _btndeleteL.IsEnabled = false;
                    _btnloadL.IsEnabled = false;
                    gridlop.IsEnabled = false;
                    _txttenlop.Clear();
                    _txtmalop.Clear();
                    return;
                }
                Lop lop = new  Lop();
                lop.MaLop = _txtmalop.Text.ToUpper();
                lop.TenLop = _txttenlop.Text;
                string warning = "";

                if (String.IsNullOrWhiteSpace(_txtmalop.Text))
                {
                    warning += "Vui lòng nhập Mã lớp." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txttenlop.Text))
                {
                    warning += "Vui lòng nhập tên lớp." + '\n';
                }

                if (!warning.Equals(""))
                {
                    MessageBox.Show(
                        warning,
                        "Thêm mới lớp",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }

                if (lopControll.Add(lop))
                {
                    MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới lớp",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(
                          "Thêm mới thất bại",
                          "Thêm mới lớp",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
                }
                _btnaddL.Content = "Add new";
                _btnaddL_cancel.IsEnabled = false;
                _btnaddL_cancel.Visibility = Visibility.Hidden;
                _btnsaveL.IsEnabled = true;
                _btndeleteL.IsEnabled = true;
                _btndeleteL.IsEnabled = true;
                _btnloadL.IsEnabled = true;
                gridlop.IsEnabled = true;
                LoadLTable();
            }
            catch
            {

            }
        }

        private void _btnaddL_cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _btnsaveL_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu TG", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmalop.Text.Equals(""))
                    {
                        Lop lop = new Lop();
                        lop = lopControll.GetById(_txtmalop.Text);
                        lop.TenLop = _txttenlop.Text;
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmalop.Text))
                        {
                            warning += "Vui lòng nhập lớp." + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_txttenlop.Text))
                        {
                            warning += "Vui lòng nhập tên lớp." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới lớp",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (lopControll.Edit(lop))
                        {
                            MessageBox.Show(
                               "Cập nhật thành công",
                               "Cập Nhật lớp",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Cập nhật thất bại",
                               "Cập Nhật  lớp",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadLTable();
                    }
                }
                catch { }
            }
        }

        private void _btndeleteL_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xoA không", "Lưu lop", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmalop.Text.Equals(""))
                    {
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmalop.Text))
                        {
                            warning += "Vui lòng nhập Chọn Cần xóa." + '\n';
                        }


                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới lớp",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (lopControll.Delete(_txtmalop.Text))
                        {
                            MessageBox.Show(
                               "Xóa thành công",
                               "Xóa Lớp",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Xóa thất bại",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        LoadLTable();
                    }
                }
                catch { }
            }
        }

        private void _btnloadL_Click(object sender, RoutedEventArgs e)
        {
            LoadLTable();
        }

        private void gridlop_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                LopModel select = gridlop.SelectedItem as LopModel;
                Lop lop = lopControll.GetById(select.MaLop);
                _txtmalop.Text = lop.MaLop;
                _txttenlop.Text = lop.TenLop;

            }
            catch { }
        }
    }
}
