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
    /// Interaction logic for frmSach.xaml
    /// </summary>
    public partial class frmSach : UserControl
    {
        public frmSach()
        {
            InitializeComponent();
            sachControll = new SachController();
            LoadCBB();
            LoadSachTable();
            if (App.Role.AddAll == true)
            {
                _btnadd.IsEnabled = true;
                _btncancel_add.IsEnabled = true;

            }else
            {
                if (App.Role.AddSach != true)
                {
                    _btnadd.IsEnabled = false;
                    _btncancel_add.IsEnabled = false;

                }
            }
            if (App.Role.EditAll == true)
            {
                _btnedit.IsEnabled = true;

            }else
            {
                if (App.Role.EditSach != true)
                {
                    _btnedit.IsEnabled = false;

                }
            }
            if (App.Role.DeleteAll == true)
            {
                _btndelete.IsEnabled = true;
            }
            else
            {
                if (App.Role.DeleteSach != true)
                {
                    _btndelete.IsEnabled = false;
                }
            }
        }
      public  SachController sachControll;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
         
    
     
        }
        public void LoadSachTable()
        {
          
             gridSach.ItemsSource = sachControll.ListSach;
            gridSach.RefreshData();
        }

        public void LoadCBB()
        {
            TheLoaiController theloaiControll = new TheLoaiController();
            _cbbtheloai.ItemsSource = theloaiControll.GetAllTheLoai;
            _cbbtheloai.DisplayMemberPath = "TenTheLoai";
            TacGiaController tacgiaControll = new TacGiaController();
            _cbbtacgia.ItemsSource = tacgiaControll.GetAllTacgia;
            _cbbtacgia.DisplayMemberPath = "TenTacGia";
            NXBController nxbcontroll = new NXBController();
            _cbbnxb.ItemsSource = nxbcontroll.GetAllNxb;
            _cbbnxb.DisplayMemberPath = "TenNhaXB";
        }

        private void gridSach_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try { 
            SachModel select = gridSach.SelectedItem as SachModel;
            SachController sc = new SachController();
            Sach sach = sc.GetById(select.MaSach);
            _txttensach.Text = sach.TenSach;
            _txtsotrang.Text = sach.SoTrang.ToString();
            _txtsoluog.Text = sach.TongSoSach.ToString();
            _txtnamxb.Text = sach.NamXuatBan.ToString("dd/MM/yyyy");
            _txtmasach.Text = sach.MaSach;
            _txtsachdamuon.Text = sach.LuongDaMuon.ToString();
            if (sach.TheLoai != null)
            {
                try
                {
                    View_Models.TheLoai selected = _cbbtheloai.SelectedItem as View_Models.TheLoai;
                    List<View_Models.TheLoai> cboxList = _cbbtheloai.ItemsSource as List<View_Models.TheLoai>;
                    selected = cboxList.SingleOrDefault(m => m.MaTheLoai == sach.MaTheLoai);
                    _cbbtheloai.SelectedItem = selected;
                }
                catch (Exception)
                {
                    _cbbtheloai.SelectedItem = null;
                }
            }
            else
            {
                _cbbtheloai.SelectedItem = null;
            }
                _imagebooks.Source = App.ConvertByteArrayToBitmapImage(sach.ImageSach) != null ? App.ConvertByteArrayToBitmapImage(sach.ImageSach) : null;

                if (sach.NhaXB != null)
            {
                try
                {
                        View_Models.NhaXB selected = _cbbnxb.SelectedItem as View_Models.NhaXB;
                    List<View_Models.NhaXB> cboxList = _cbbnxb.ItemsSource as List<View_Models.NhaXB>;
                    selected = cboxList.SingleOrDefault(m => m.MaNXB == sach.MaNXB);
                    _cbbnxb.SelectedItem = selected;
                }
                catch (Exception)
                {
                    _cbbnxb.SelectedItem = null;
                }
            }
            else
            {
                _cbbnxb.SelectedItem = null;
            }
            if (sach.TacGia != null)
            {
                try
                {
                        View_Models.TacGia selected = _cbbtacgia.SelectedItem as View_Models.TacGia;
                    List<View_Models.TacGia> cboxList = _cbbtacgia.ItemsSource as List<View_Models.TacGia>;
                    selected = cboxList.SingleOrDefault(m => m.MaTacGia == sach.MaTacGia);
                    _cbbtacgia.SelectedItem = selected;
                }
                catch (Exception)
                {
                    _cbbtacgia.SelectedItem = null;
                }
            }
            else
            {
                _cbbtacgia.SelectedItem = null;
            }
        }
        catch
            { }
        }

        private void gridSach_SelectionChanged(object sender, DevExpress.Xpf.Grid.GridSelectionChangedEventArgs e)
        {

        }

        private void _btnadd_Click_1(object sender, RoutedEventArgs e)
        {
            if (_btnadd.Content.Equals("Add new"))
            {
                _btnadd.Content = "Hoàn tất";
                _btncancel_add.IsEnabled = true;
                _btncancel_add.Visibility = Visibility.Visible;
                _btnedit.IsEnabled = false;
                _btnsearch.IsEnabled = false;
                _btndelete.IsEnabled = false;
                _btnrefresh.IsEnabled = false;
                gridSach.IsEnabled = false;

                _txtmasach.Clear();
                _txtnamxb.Clear();
                _txtsachdamuon.Clear();
                _txtsoluog.Clear();
                _txtsotrang.Clear();
                _txttensach.Clear();
                _cbbnxb.SelectedItem = null;
                _cbbtacgia.SelectedItem=null;
                _cbbtheloai.SelectedItem = null;

                return;
            }

            string warning = "";

            if (String.IsNullOrWhiteSpace(_txttensach.Text))
            {
                warning += "Vui lòng nhập Tên Sách." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_cbbnxb.Text))
            {
                warning += "Vui lòng Chọn Nhà Xuất Bản." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_cbbtacgia.Text))
            {
                warning += "Vui lòng Chọn Tác Giả." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_cbbtheloai.Text))
            {
                warning += "Vui lòng Chọn Thể Loại." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_txtsoluog.Text))
            {
                warning += "Vui lòng Nhap So Luong." + '\n';
            }
            if (!warning.Equals(""))
            {
                MessageBox.Show(
                    warning,
                    "Thêm mới Mặt hàng",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }
            Sach sach = new Sach();
            sach.TenSach = _txttensach.Text;
           
          
                if (_txtnamxb.Text.Equals("") == false)
                {
                    try { sach.NamXuatBan = Convert.ToDateTime(_txtnamxb.Text); }
                    catch { }
                }
                else { sach.NamXuatBan = DateTime.Today; }
                try
                {
                    sach.SoTrang = Convert.ToInt16(_txtsotrang.Text);
                }
                catch { sach.SoTrang = 0; }
                try { sach.TongSoSach = Convert.ToInt16(_txtsoluog.Text); } catch { sach.TongSoSach = 0; }
            try { sach.ImageSach = App.ConvertFileToByte(_imagebooks.Source); } catch { sach.ImageSach = null; }





            if (_cbbnxb.SelectedItem != null)
            {
                sach.MaNXB = (_cbbnxb.SelectedItem as View_Models.NhaXB).MaNXB;
            }
            if (_cbbtacgia.SelectedItem != null)
            {
                sach.MaTacGia = (_cbbtacgia.SelectedItem as View_Models.TacGia).MaTacGia;
            }
            if (_cbbtheloai.SelectedItem != null)
            {
                sach.MaTheLoai = (_cbbtheloai.SelectedItem as View_Models.TheLoai).MaTheLoai;
            }
          
            if (sachControll.Add(sach))
            {
                MessageBox.Show(
                    "Thêm mới thành công",
                    "Thêm mới Sách",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(
                    "Thêm mới thất bại",
                    "Thêm mới Sách",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }


            _btnadd.Content = "Add new";
            _btncancel_add.IsEnabled = false;
            _btncancel_add.Visibility = Visibility.Hidden;
            _btnedit.IsEnabled = true;
            _btndelete.IsEnabled = true;
            _btnrefresh.IsEnabled = true;
            _btnsearch.IsEnabled = true;
            gridSach.IsEnabled = true;
            LoadSachTable();
        }

        private void _btnedit_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
          re=  MessageBox.Show("Bạn có muốn sửa không", "Lưu Sách", MessageBoxButton.YesNo, MessageBoxImage.Question);
        if(re== MessageBoxResult.Yes)
            {
            try
            {
                
                if (_txtmasach.Text.Equals("")== false)
                {
                    Sach sach = new Sach();
                    try
                    {  
                        sach.MaSach = _txtmasach.Text;
                        sach.TenSach = _txttensach.Text;
                       
                            if (_txtnamxb.Text.Equals("") == false)
                            {
                                try { sach.NamXuatBan = Convert.ToDateTime(_txtnamxb.Text); }
                                catch { sach.NamXuatBan = DateTime.Today; }
                            }
                            else { sach.NamXuatBan = DateTime.Today; }
                             try { sach.SoTrang = Convert.ToInt16(_txtsotrang.Text); } catch { sach.SoTrang = 0; }
                             try { sach.TongSoSach = Convert.ToInt16(_txtsoluog.Text); } catch { sach.TongSoSach = 0; }
                             try { sach.LuongDaMuon = Convert.ToInt16(_txtsachdamuon.Text); } catch { sach.LuongDaMuon = 0; }
                            try { sach.ImageSach = App.ConvertFileToByte(_imagebooks.Source); } catch { sach.ImageSach = null; }
                            if (_cbbnxb.SelectedItem != null)
                        {
                            sach.MaNXB = (_cbbnxb.SelectedItem as View_Models.NhaXB).MaNXB;
                        }
                        if (_cbbtacgia.SelectedItem != null)
                        {
                            sach.MaTacGia = (_cbbtacgia.SelectedItem as View_Models.TacGia).MaTacGia;
                        }
                        if (_cbbtheloai.SelectedItem != null)
                        {
                            sach.MaTheLoai = (_cbbtheloai.SelectedItem as View_Models.TheLoai).MaTheLoai;
                        }
                    }
                    catch{ }
                    string warning = "";

                    if (String.IsNullOrWhiteSpace(_cbbnxb.Text))
                    {
                        warning += "Vui lòng Chọn Nhà Xuất Bản." + '\n';
                    }
                    if (String.IsNullOrWhiteSpace(_cbbtacgia.Text))
                    {
                        warning += "Vui lòng Chọn Tác Giả." + '\n';
                    }
                    if (String.IsNullOrWhiteSpace(_cbbtheloai.Text))
                    {
                        warning += "Vui lòng Chọn Thể Loại." + '\n';
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
                    if (sachControll.Edit(sach))
                    {
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

                    LoadSachTable();
                }
                else
                {
                    MessageBox.Show(
              "Mã sách không hợp lệ",
              "Cập nhật sách",
              MessageBoxButton.OK,
              MessageBoxImage.Warning);
                }
            }

            catch
            {
            }
            }

        }
        private void _btndelete_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xóa không", "Lưu Sách", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {

                    if (_txtmasach.Text.Equals("")==false)
                    {
                        if (sachControll.Delete(_txtmasach.Text))
                        {
                            MessageBox.Show(
                          "Xóa thành công",
                          "Xóa Sách",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);

                        }
                        else
                        {
                            MessageBox.Show(
                        "Xóa thất bại",
                        "Xóa Sách",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                        }
                      
                        LoadSachTable();
                    }
                    else
                    {
                        MessageBox.Show(
                          "Vui lòng chọn sách cần xóa",
                          "Xóa Sách",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
                    }
                }
                catch { }
           }
        }

        private void _btnrefresh_Click_1(object sender, RoutedEventArgs e)
        {
            LoadSachTable();
        }

        private void _btnsearch_Click_1(object sender, RoutedEventArgs e)
        {
            gridSach.ItemsSource = sachControll.GetListTableModelBySearch(_txtsearch.Text);
            gridSach.RefreshData();
        }

        private void _btncancel_add_Click(object sender, RoutedEventArgs e)
        {
            _btnadd.Content = "Add new";
            _btncancel_add.IsEnabled = false;
            _btncancel_add.Visibility = Visibility.Hidden;
            _btnedit.IsEnabled = true;
            _btndelete.IsEnabled = true;
            _btnrefresh.IsEnabled = true;
            _btnsearch.IsEnabled = true;
            gridSach.IsEnabled = true;
            LoadSachTable();
        }
    }
}
