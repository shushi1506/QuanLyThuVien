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
    /// Interaction logic for frmTheLoai.xaml
    /// </summary>
    public partial class frmTheLoai : UserControl
    {
        private TheLoaiController theloaiControll;
        private NXBController nxbControll;
        private TacGiaController tacgiaControll;
        public frmTheLoai()
        {
            InitializeComponent();
            theloaiControll = new TheLoaiController();
            nxbControll = new NXBController();
            tacgiaControll = new TacGiaController();
            LoadTGTable();
            LoadTheLoaiTable();
            LoadNXBTable();
            _txtmanxb.IsReadOnly = true;
            _txtmatacgia.IsReadOnly = true;
            _txtmatheloai.IsReadOnly = true;
            if (App.Role.AddAll == true)
            {
                _btnaddNXB.IsEnabled = true;
                _btnaddTG.IsEnabled = true;
                _btnaddTL.IsEnabled = true;
                _btnaddTG_cancel.IsEnabled = true;
                _btnaddNXB_cancel.IsEnabled = true;
                _btnaddTL_cancel.IsEnabled = true;
            }
            else
            {
                if (App.Role.AddSach != true)
                {
                    _btnaddNXB.IsEnabled = false;
                    _btnaddTG.IsEnabled = false;
                    _btnaddTL.IsEnabled = false;
                    _btnaddTG_cancel.IsEnabled = false;
                    _btnaddNXB_cancel.IsEnabled = false;
                    _btnaddTL_cancel.IsEnabled = false;
                }
            }
            if (App.Role.EditAll == true)
            {
                _btnsaveNXB.IsEnabled = true;
                _btnsaveTG.IsEnabled = true;
                _btnsaveTL.IsEnabled = true;

            }
            else
            {
                if (App.Role.EditSach != true)
                {
                    _btnsaveNXB.IsEnabled = false;
                    _btnsaveTG.IsEnabled = false;
                    _btnsaveTL.IsEnabled = false;

                }
            }
            if (App.Role.DeleteAll == true)
            {
                _btndeleteNXB.IsEnabled = true;
                _btndeleteTG.IsEnabled = true;
                _btndeleteTL.IsEnabled = true;
            }else
            {
                if (App.Role.DeleteSach != true)
                {
                    _btndeleteNXB.IsEnabled = false;
                    _btndeleteTG.IsEnabled = false;
                    _btndeleteTL.IsEnabled = false;
                }
            }
        }
        //code bang the loai
        #region 
       
        public void LoadTheLoaiTable()
        {
            gridTheLoai.ItemsSource = theloaiControll.ListTheLoai;
            gridTheLoai.RefreshData();
        }
        private void _btnaddTL_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_btnaddTL.Content.Equals("Add new"))
                {
                    _btnaddTL.Content = "Hoàn tất";
                    _btnaddTL_cancel.IsEnabled = true;
                    _btnaddTL_cancel.Visibility = Visibility.Visible;
                    _btnsaveTL.IsEnabled = false;
                    _btndeleteTL.IsEnabled = false;
                    _btndeleteTL.IsEnabled = false;
                    _btnloadTL.IsEnabled = false;
                    gridTheLoai.IsEnabled = false;
                    _txtmatheloai.IsReadOnly = false;
                    _txtmatheloai.Clear();
                    _txttentheloai.Clear();
                    return;
                }
                TheLoai theloai = new TheLoai();
                theloai.MaTheLoai = _txtmatheloai.Text.ToUpper();
                theloai.TenTheLoai = _txttentheloai.Text;
                string warning = "";

                if (String.IsNullOrWhiteSpace(_txtmatheloai.Text))
                {
                    warning += "Vui lòng nhập Mã thể loại." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txttentheloai.Text))
                {
                    warning += "Vui lòng nhập tên thể loại." + '\n';
                }

                if (!warning.Equals(""))
                {
                    MessageBox.Show(
                        warning,
                        "Thêm mới thể loại",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }

                if (theloaiControll.Add(theloai))
                {
                    MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới thể loại",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(
                          "Thêm mới thất bại",
                          "Thêm mới thể loại",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
                }
                _btnaddTL.Content = "Add new";
                _btnaddTL_cancel.IsEnabled = false;
                _btnaddTL_cancel.Visibility = Visibility.Hidden;
                _btnsaveTL.IsEnabled = true;
                _btndeleteTL.IsEnabled = true;
                _btndeleteTL.IsEnabled = true;
                _btnloadTL.IsEnabled = true;
                gridTheLoai.IsEnabled = true;
              
                _txtmatheloai.IsReadOnly = true;
                LoadTheLoaiTable();
            }
            catch
            {

            }
        }
        private void _btndeleteTL_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xóa không", "Xóa Thể Loại", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmatheloai.Text.Equals(""))
                    {
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmatheloai.Text))
                        {
                            warning += "Vui lòng nhập Chọn Cần xóa." + '\n';
                        }


                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới thể loại",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (theloaiControll.Delete(_txtmatheloai.Text))
                        {
                            MessageBox.Show(
                               "Xóa thành công",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Xóa thất bại",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadTheLoaiTable();
                    }
                }
                catch { }
            }
        }

        private void _btnsaveTL_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu Thể loại", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmatheloai.Text.Equals(""))
                    {
                        TheLoai theloai = new TheLoai();
                        theloai = theloaiControll.GetById(_txtmatheloai.Text);
                        theloai.TenTheLoai = _txttentheloai.Text;
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmatheloai.Text))
                        {
                            warning += "Vui lòng nhập Mã Thể Loại." + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_txttentheloai.Text))
                        {
                            warning += "Vui lòng nhập tên thể loại." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới thể loại",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (theloaiControll.Edit(theloai))
                        {
                            MessageBox.Show(
                               "Cập nhật thành công",
                               "Cập Nhật Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Cập nhật thất bại",
                               "Cập Nhật Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadTheLoaiTable();
                    }
                }
                catch { }
            }

        }

        private void _btnloadTL_Click(object sender, RoutedEventArgs e)
        {
            LoadTheLoaiTable();
        }

        private void gridTheLoai_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                TheLoaiModel select = gridTheLoai.SelectedItem as TheLoaiModel;
                TheLoai theloai = theloaiControll.GetById(select.MaTheLoai);
                _txtmatheloai.Text = theloai.MaTheLoai;
                _txttentheloai.Text = theloai.TenTheLoai;

            }
            catch { }
        }

        private void _btnaddTL_cancel_Click(object sender, RoutedEventArgs e)
        {
            _btnaddTL.Content = "Add new";
            _btnaddTL_cancel.IsEnabled = false;
            _btnaddTL_cancel.Visibility = Visibility.Hidden;
            _btnsaveTL.IsEnabled = true;
            _btndeleteTL.IsEnabled = true;
            _btndeleteTL.IsEnabled = true;
            _btnloadTL.IsEnabled = true;
         
            _txtmatheloai.IsReadOnly = true;
            gridTheLoai.IsEnabled = true;
            LoadTheLoaiTable();
        }


        #endregion
        //code bang nxb
        #region

        public void LoadNXBTable()
        {
            gridNXB.ItemsSource = nxbControll.ListNXB;
            gridNXB.RefreshData();
        }
        private void _btnaddNXB_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_btnaddNXB.Content.Equals("Add new"))
                {
                    _btnaddNXB.Content = "Hoàn tất";
                    _btnaddNXB_cancel.IsEnabled = true;
                    _btnaddNXB_cancel.Visibility = Visibility.Visible;
                    _btnsaveNXB.IsEnabled = false;
                    _btndeleteNXB.IsEnabled = false;
                    _btndeleteNXB.IsEnabled = false;
                    _btnloadNXB.IsEnabled = false;
                    gridNXB.IsEnabled = false;
                    _txtmanxb.IsReadOnly = false;
         
                    _txttennxb.Clear();
                    _txtmanxb.Clear();
                    return;
                }
                NhaXB nxb = new NhaXB();
                nxb.MaNXB = _txtmanxb.Text.ToUpper();
                nxb.TenNhaXB = _txttennxb.Text;
                string warning = "";

                if (String.IsNullOrWhiteSpace(_txtmanxb.Text))
                {
                    warning += "Vui lòng nhập Mã NXB." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txttennxb.Text))
                {
                    warning += "Vui lòng nhập tên NXB." + '\n';
                }

                if (!warning.Equals(""))
                {
                    MessageBox.Show(
                        warning,
                        "Thêm mới NXB",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }

                if (nxbControll.Add(nxb))
                {
                    MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới NXB",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(
                          "Thêm mới thất bại",
                          "Thêm mới NXB",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
                }
                _btnaddNXB.Content = "Add new";
                _btnaddNXB_cancel.IsEnabled = false;
                _btnaddNXB_cancel.Visibility = Visibility.Hidden;
                _btnsaveNXB.IsEnabled = true;
                _btndeleteNXB.IsEnabled = true;
                _btndeleteNXB.IsEnabled = true;
                _btnloadNXB.IsEnabled = true;
                _txtmanxb.IsReadOnly = true;
              
                gridNXB.IsEnabled = true;
                LoadNXBTable();
            }
            catch
            {

            }
        }

        private void _btnsaveNXB_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu NXB", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmanxb.Text.Equals(""))
                    {
                        NhaXB nxb = new NhaXB();
                        nxb = nxbControll.GetById(_txtmanxb.Text);
                        nxb.TenNhaXB = _txttennxb.Text;
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmanxb.Text))
                        {
                            warning += "Vui lòng nhập NXB." + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_txttennxb.Text))
                        {
                            warning += "Vui lòng nhập tên NXB." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới thể loại",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (nxbControll.Edit(nxb))
                        {
                            MessageBox.Show(
                               "Cập nhật thành công",
                               "Cập Nhật Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Cập nhật thất bại",
                               "Cập Nhật Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        LoadNXBTable();
                    }
                }
                catch { }
            }
        }

        private void _btndeleteNXB_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xóa không", "Lưu NXB", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmanxb.Text.Equals(""))
                    {
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmanxb.Text))
                        {
                            warning += "Vui lòng nhập Chọn Cần xóa." + '\n';
                        }


                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới thể loại",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (nxbControll.Delete(_txtmanxb.Text))
                        {
                            MessageBox.Show(
                               "Xóa thành công",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Xóa thất bại",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadNXBTable();
                    }
                }
                catch { }
            }
        }

        private void _btnloadNXB_Click(object sender, RoutedEventArgs e)
        {
            LoadNXBTable();
        }

        private void _btnaddNXB_cancel_Click(object sender, RoutedEventArgs e)
        {
            _btnaddNXB.Content = "Add new";
            _btnaddNXB_cancel.IsEnabled = false;
            _btnaddNXB_cancel.Visibility = Visibility.Hidden;
            _btnsaveNXB.IsEnabled = true;
            _btndeleteNXB.IsEnabled = true;
            _btndeleteNXB.IsEnabled = true;
            _btnloadNXB.IsEnabled = true;
            _txtmanxb.IsReadOnly = true;
       
       
            gridNXB.IsEnabled = true;
            LoadNXBTable();
        }

        private void gridNXB_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                NhaXuatBanModel select = gridNXB.SelectedItem as NhaXuatBanModel;
                NhaXB nxb = nxbControll.GetById(select.MaNXB);
                _txtmanxb.Text = nxb.MaNXB;
                _txttennxb.Text = nxb.TenNhaXB;

            }
            catch { }
        }


        #endregion
        //code cho bang tac gia
        #region
        public void LoadTGTable()
        {
            gridTacGia.ItemsSource = tacgiaControll.ListTacGia;
            gridTacGia.RefreshData();
        }
        private void _btnaddTG_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_btnaddTG.Content.Equals("Add new"))
                {
                    _btnaddTG.Content = "Hoàn tất";
                    _btnaddTG_cancel.IsEnabled = true;
                    _btnaddTG_cancel.Visibility = Visibility.Visible;
                    _btnsaveTG.IsEnabled = false;
                    _btndeleteTG.IsEnabled = false;
                    _btndeleteTG.IsEnabled = false;
                    _btnloadTG.IsEnabled = false;
                    gridTacGia.IsEnabled = false;
                    _txtmatacgia.IsReadOnly = false;
                    _txttentacgia.Clear();
                    _txtmatacgia.Clear();
                    return;
                }
                TacGia tacgia = new TacGia();
                tacgia.MaTacGia = _txtmatacgia.Text.ToUpper();
                tacgia.TenTacGia = _txttentacgia.Text;
                string warning = "";

                if (String.IsNullOrWhiteSpace(_txtmatacgia.Text))
                {
                    warning += "Vui lòng nhập Mã tác giả." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txttentacgia.Text))
                {
                    warning += "Vui lòng nhập tên tác giả." + '\n';
                }

                if (!warning.Equals(""))
                {
                    MessageBox.Show(
                        warning,
                        "Thêm mới tác giả",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }

                if (tacgiaControll.Add(tacgia))
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
                          "Thêm mới tác giả",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
                }
                _btnaddTG.Content = "Add new";
                _btnaddTG_cancel.IsEnabled = false;
                _btnaddTG_cancel.Visibility = Visibility.Hidden;
                _btnsaveTG.IsEnabled = true;
                _btndeleteTG.IsEnabled = true;
                _btndeleteTG.IsEnabled = true;
                _btnloadTG.IsEnabled = true;
                _txtmatacgia.IsReadOnly = true;
                gridTacGia.IsEnabled = true;
                LoadTGTable();
            }
            catch
            {

            }
        }

        private void _btnsaveTG_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu TG", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmatacgia.Text.Equals(""))
                    {
                        TacGia tacgia = new TacGia();
                        tacgia = tacgiaControll.GetById(_txtmatacgia.Text);
                        tacgia.TenTacGia = _txttentacgia.Text;
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmatacgia.Text))
                        {
                            warning += "Vui lòng nhập tác giả." + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_txttentacgia.Text))
                        {
                            warning += "Vui lòng nhập tên tác giả." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới tác giả",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (tacgiaControll.Edit(tacgia))
                        {
                            MessageBox.Show(
                               "Cập nhật thành công",
                               "Cập Nhật Tác Giả",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Cập nhật thất bại",
                               "Cập Nhật  Tác giả",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadTGTable();
                    }
                }
                catch { }
            }
        }

        private void _btndeleteTG_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xoA không", "Lưu tacgia", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtmatacgia.Text.Equals(""))
                    {
                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_txtmatacgia.Text))
                        {
                            warning += "Vui lòng nhập Chọn Cần xóa." + '\n';
                        }


                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới tác giả",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (tacgiaControll.Delete(_txtmatacgia.Text))
                        {
                            MessageBox.Show(
                               "Xóa thành công",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Xóa thất bại",
                               "Xóa Thể Loại",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadTGTable();
                    }
                }
                catch { }
            }
        }

        private void _btnloadTG_Click(object sender, RoutedEventArgs e)
        {
            LoadTGTable();
        }

        private void _btnaddTG_cancel_Click(object sender, RoutedEventArgs e)
        {
            _btnaddTG.Content = "Add new";
            _btnaddTG_cancel.IsEnabled = false;
            _btnaddTG_cancel.Visibility = Visibility.Hidden;
            _btnsaveTG.IsEnabled = true;
            _btndeleteTG.IsEnabled = true;
            _btndeleteTG.IsEnabled = true;
            _btnloadTG.IsEnabled = true;
            _txtmatacgia.IsReadOnly = true;
            gridTacGia.IsEnabled = true;
            LoadTGTable();
        }

        private void gridTacGia_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                TacGiaModel select = gridTacGia.SelectedItem as TacGiaModel;
                TacGia tacgia = tacgiaControll.GetById(select.MaTacGia);
                _txtmatacgia.Text = tacgia.MaTacGia;
                _txttentacgia.Text = tacgia.TenTacGia;

            }
            catch { }
        }
        #endregion
    }
}
