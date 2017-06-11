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
    /// Interaction logic for frmDocGia.xaml
    /// </summary>
    public partial class frmDocGia : UserControl
    {
        private DocGiaController docGiaControll;
        private SachMuonController sachMuonControll;
       
        public frmDocGia()
        {
            InitializeComponent();
            docGiaControll = new DocGiaController();
            sachMuonControll = new SachMuonController();
            LoadCBB();
            LoadDocGiaTable();

            if (App.Role.AddAll == true)
            {
                _btnadd.IsEnabled = true;
                _btnadd_cancel.IsEnabled = true;
            }
            else
            {
                if (App.Role.AddDocGia != true)
                {
                    _btnadd.IsEnabled = false;
                    _btnadd_cancel.IsEnabled = false;
                }
            }
            if (App.Role.EditAll == true)
            {
                _btnsave.IsEnabled = true;
            }
            else
            {
                if (App.Role.EditDocGia != true)
                {
                    _btnsave.IsEnabled = false;
                }
            }
           
            if (App.Role.DeleteAll == true)
            {
                _btndelete.IsEnabled = true;
            }
            else
            {
                if (App.Role.DeleteDocGia != true)
                {
                    _btndelete.IsEnabled = false;
                }
            }
        }

        public void LoadDocGiaTable()
        {

            gridDoGia.ItemsSource = docGiaControll.Listdocgia;
            gridDoGia.RefreshData();
        }
        public void LoadCBB()
        {
            KhoaController khoaControll = new KhoaController();
            _cbbkhoa.ItemsSource = khoaControll.GetAllKhoa;
            _cbbkhoa.DisplayMemberPath = "TenKhoa";
            LopController lopControll = new LopController();
            _cbblop.ItemsSource = lopControll.GetAllLop;
            _cbblop.DisplayMemberPath = "TenLop";
        }
        private void _btnadd_Click(object sender, RoutedEventArgs e)
        {
          if (App.Role.AddDocGia == true)
            { 
            if (_btnadd.Content.Equals("Add new"))
            {
                _btnadd.Content = "Save";
                _btnadd_cancel.IsEnabled = true;
                _btnadd_cancel.Visibility = Visibility.Visible;
                _btnsave.IsEnabled = false;
                _btndelete.IsEnabled = false;
                _btndelete.IsEnabled = false;
                _btnload.IsEnabled = false;
                gridDoGia.IsEnabled = false;
                gridSachMuon.IsEnabled = false;
                _txtdiachi.Clear();
                _txtmadocgia.Clear();
                _txttendocgia.Clear();
                _txttienkigui.Clear();
                _datengaysinh.Clear();
                _rdnam.IsChecked = true;
                _cbbkhoa.SelectedItem = null;
                _cbblop.SelectedItem = null;


                return;
            }


            DocGia docgia = new DocGia();

            try
            {
                docgia.TenDocGia = _txttendocgia.Text;
             
                docgia.DiaChi = _txtdiachi.Text;
                string socmt = "";
                Random rd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    
                    socmt += rd.Next(0, 10);
                }
                docgia.SoCMT = socmt;
                if (_rdnam.IsChecked == true)
                {
                    docgia.GioiTinh = "Nam";
                }
                else docgia.GioiTinh = "Nữ";

                if (_datengaysinh.Text.Equals("") == false)
                {
                    try
                    {
                        docgia.NgaySinh = Convert.ToDateTime(_datengaysinh.Text);
                 
                    }
                    catch { }
                }
                else
                {
                    docgia.NgaySinh = DateTime.Today;

                }

            }
            catch
            {
            }
                try { docgia.ImageDocGia = App.ConvertFileToByte(_imagedocgia.Source); } catch { docgia.ImageDocGia = null; }
                if (_cbbkhoa.SelectedItem != null)
            {
                docgia.MaKhoa = (_cbbkhoa.SelectedItem as Khoa).MaKhoa;
            }
            if (_cbblop.SelectedItem != null)
            {
                docgia.MaLop = (_cbblop.SelectedItem as Lop).MaLop;
            }
         
            string warning = "";

            if (String.IsNullOrWhiteSpace(_txttendocgia.Text))
            {
                warning += "Nhập Tên Độc Giả." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_txtdiachi.Text))
            {
                warning += "Nhập Địa Chỉ." + '\n';
            }
          
            if (String.IsNullOrWhiteSpace(_cbbkhoa.Text))
            {
                warning += "Vui lòng Chọn Lớp." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_cbbkhoa.Text))
            {
                warning += "Vui lòng Chọn Khoa." + '\n';
            }
            
            if (!warning.Equals(""))
            {
                MessageBox.Show(
                    warning,
                    "Thêm mới Độc Giả",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            if (docGiaControll.Add(docgia))
            {

               
                MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới Độc Giả",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(
                    "Thêm mới thất bại",
                    "Thêm mới  Độc Giả",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

            _btnadd.Content = "Add new";
            _btnadd_cancel.IsEnabled = false;
            _btnadd_cancel.Visibility = Visibility.Hidden;
            _btnsave.IsEnabled = true;
            _btndelete.IsEnabled = true;
            _btnload.IsEnabled = true;
            gridDoGia.IsEnabled = true;
            gridSachMuon.IsEnabled = true;
            LoadDocGiaTable();
            }
          else {
                MessageBox.Show(
                   "Không Có Quyền Hạn",
                   "Thêm mới  Độc Giả",
                   MessageBoxButton.OK,
                   MessageBoxImage.Stop);
            }
        }

        private void gridDoGia_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {

            try
            {
                DocGiaModel select = gridDoGia.SelectedItem as DocGiaModel;

                DocGia docgia = docGiaControll.GetById(select.MaDocGia);
                _txtmadocgia.Text = docgia.MaDocGia.ToString();
                _txttendocgia.Text = docgia.TenDocGia.ToString();
                _txtdiachi.Text = docgia.DiaChi.ToString();
                _datengaysinh.Text = docgia.NgaySinh.ToString("MM/dd/yyyy");
                if (docgia.GioiTinh == "Nam")
                {
                    _rdnam.IsChecked = true;
                    _rdnu.IsChecked = false;
                }
               else
                {
                    _rdnam.IsChecked = false;
                    _rdnu.IsChecked = true;
                }
                _imagedocgia.Source = App.ConvertByteArrayToBitmapImage(docgia.ImageDocGia) != null ? App.ConvertByteArrayToBitmapImage(docgia.ImageDocGia) : null;
                if (docgia.MaLop != null)
                {
                    try
                    {
                        Lop selected = _cbblop.SelectedItem as Lop;
                        List<Lop> cboxList = _cbblop.ItemsSource as List<Lop>;
                        selected = cboxList.SingleOrDefault(m => m.MaLop == docgia.MaLop);
                        _cbblop.SelectedItem = selected;
                    }
                    catch (Exception)
                    {
                        _cbblop.SelectedItem = null;
                    }
                }
                else
                {
                    _cbblop.SelectedItem = null;
                }
                if (docgia.MaKhoa != null)
                {
                    try
                    {
                        Khoa selected = _cbbkhoa.SelectedItem as Khoa;
                        List<Khoa> cboxList = _cbbkhoa.ItemsSource as List<Khoa>;
                        selected = cboxList.SingleOrDefault(m => m.MaKhoa == docgia.MaKhoa);
                        _cbbkhoa.SelectedItem = selected;
                    }
                    catch (Exception)
                    {
                        _cbbkhoa.SelectedItem = null;
                    }
                }
                else
                {
                    _cbbkhoa.SelectedItem = null;
                }
                gridSachMuon.ItemsSource = sachMuonControll.GetSachMuonTableByDocGia(docgia);
                gridSachMuon.RefreshData();
            }
            catch
            { }
        }

        private void _btnsave_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu Sách", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {

                    if (_txtmadocgia.Text.Equals("") == false)
                    {
                        DocGia docgia = new DocGia();
                        docgia = docGiaControll.GetById((_txtmadocgia.Text));


                        try
                        {
                            docgia.DiaChi = (_txtdiachi.Text);
                            docgia.TenDocGia = _txttendocgia.Text;
                          
                            try
                            {
                                if (_datengaysinh.Text.Equals("") == false)
                                {
                                    try { docgia.NgaySinh = Convert.ToDateTime(_datengaysinh.Text); }
                                    catch { }
                                }
                                else { docgia.NgaySinh = DateTime.Today; }

                                if (_rdnam.IsChecked == true)
                                {
                                    docgia.GioiTinh = "Nam";
                                }
                                else docgia.GioiTinh = "Nữ";

                            }
                            catch { }
                            try { docgia.ImageDocGia = App.ConvertFileToByte(_imagedocgia.Source); } catch { docgia.ImageDocGia = null; }
                            if (_cbbkhoa.SelectedItem != null)
                            {
                                docgia.MaKhoa = (_cbbkhoa.SelectedItem as Khoa).MaKhoa;
                            }
                            if (_cbblop.SelectedItem != null)
                            {
                                docgia.MaLop = (_cbblop.SelectedItem as Lop).MaLop;
                            }

                        }
                        catch { }

                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_cbblop.Text))
                        {
                            warning += "Chọn Tên Lớp" + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_cbbkhoa.Text))
                        {
                            warning += "Chọn Tên Khoa." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Lưu Sách",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (docGiaControll.Edit(docgia)) {
                            MessageBox.Show(
                          "Cập nhật thành công",
                          "Cập Nhật Sách",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Cập Nhật thất bại",
                                "Cập Nhật Sách",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                        }

                        LoadDocGiaTable();
                    }
                }
                catch { }    
            }
        }

        private void _btndelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xóa không", "Xóa Người Mượn", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {

                    if (_txtmadocgia.Text.Equals("") == false)
                    {
                        if (docGiaControll.Delete((_txtmadocgia.Text)))
                        {
                            MessageBox.Show(
                          "Xóa thành công",
                          "Xóa Lượt Mượn",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);

                        }
                        else
                        {
                            MessageBox.Show(
                        "Xóa thất bại",
                        "Xóa Lượt Mượn",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                        }
                        LoadDocGiaTable();
                    }
                    else
                    {
                        MessageBox.Show(
                          "Vui lòng chọn sách cần xóa",
                          "Xóa Lượt Mượn",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
                    }
                }
                catch { }
            }
        }

        private void _btnload_Click(object sender, RoutedEventArgs e)
        {
            LoadDocGiaTable();
        }

        private void _btnadd_cancel_Click(object sender, RoutedEventArgs e)
        {
            _btnadd.Content = "Add new";
            _btnadd_cancel.IsEnabled = false;
            _btnadd_cancel.Visibility = Visibility.Hidden;
            _btnsave.IsEnabled = true;
            _btndelete.IsEnabled = true;
            _btnload.IsEnabled = true;
            gridDoGia.IsEnabled = true;
            gridSachMuon.IsEnabled = true;
            LoadDocGiaTable();
        }

        private void _btnchuatrasach_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DocGiaModel select = gridDoGia.SelectedItem as DocGiaModel;

                DocGia docgia = docGiaControll.GetById(select.MaDocGia);

                gridSachMuon.ItemsSource = sachMuonControll.GetSachMuonTableByDocGiaMuon(docgia, false);
                gridDoGia.RefreshData();
            }catch { }
        }

        private void _btntatcasachmuon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DocGiaModel select = gridDoGia.SelectedItem as DocGiaModel;

                DocGia docgia = docGiaControll.GetById(select.MaDocGia);

                gridSachMuon.ItemsSource = sachMuonControll.GetSachMuonTableByDocGia(docgia);
                gridDoGia.RefreshData();
            }
            catch { }
        }

      
    }
}
