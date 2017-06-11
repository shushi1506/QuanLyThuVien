using DevExpress.Xpf.Printing;
using QLTV.Controllers;
using QLTV.Reports;
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
    /// Interaction logic for frmSachMuon.xaml
    /// </summary>
    public partial class frmSachMuon : UserControl
    {
        private SachMuonController sachMuonControll;
        private DocGiaController docGiaControll;
        private SachController sachControll;
        public frmSachMuon()
        {
            InitializeComponent();
            sachMuonControll = new SachMuonController();
            docGiaControll = new DocGiaController();
            sachControll = new SachController();
            LoadCBB();
            _txtmamuon.IsReadOnly = true;
            _txtdiachidg.IsReadOnly = true;
            _txtkhoadg.IsReadOnly = true;
            _txtlopdg.IsReadOnly = true;
            _txttendg.IsReadOnly = true;
            _txttienkiguidg.IsReadOnly = true;
            LoadSachMuonTable();
            if (App.Role.AddAll == true)
            {
                _btnadd.IsEnabled = true;
                _btnadd_cancel.IsEnabled = true;
            }
            else
            {
                if (App.Role.AddSachMuon != true)
                {
                    _btnadd.IsEnabled = false;
                    _btnadd_cancel.IsEnabled = false;
                }
            }
            if (App.Role.EditAll == true)
            {
                _btnsave.IsEnabled = true;
            }else
            {
                if (App.Role.EditSachMuon != true)
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
                if (App.Role.DeleteSachMuon != true)
                {
                    _btndelete.IsEnabled = false;
                }
            }
        }
        public void LoadSachMuonTable()
        {
            
            gridSachMuon.ItemsSource =sachMuonControll.ListSach;
            gridSachMuon.RefreshData();
        }

        public void LoadCBB()
        {
          
            _cbbtendocgia.ItemsSource = docGiaControll.GetAllDocGia;
            _cbbtendocgia.DisplayMemberPath = "TenDocGia";

            _cbbtensach.ItemsSource = sachControll.GetAllSach;
            _cbbtensach.DisplayMemberPath = "TenSach";
        }

        private void gridSachMuon_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                SachMuonModel select = gridSachMuon.SelectedItem as SachMuonModel;
               
                MuonSach sach = sachMuonControll.GetById(select.MaMuon);
                _txtmamuon.Text = sach.MaMuon.ToString();
                _txtsoluongmuon.Text = sach.SoLuongMuon.ToString();
                _txttiencoc.Text = sach.TienCoc.ToString();
                _datemuon.Text = sach.NgayMuon.ToString("MM/dd/yyyy");
                _datetra.Text = sach.NgayHen.ToString("MM/dd/yyyy");
                _checkdatra.IsChecked = sach.DaTra;
                if (sach.MaDocGia != null)
                {
                    try
                    {
                        DocGia selected = _cbbtendocgia.SelectedItem as DocGia;
                        List<DocGia> cboxList = _cbbtendocgia.ItemsSource as List<DocGia>;
                        selected = cboxList.SingleOrDefault(m => m.MaDocGia == sach.MaDocGia);
                        _cbbtendocgia.SelectedItem = selected;
                    }
                    catch (Exception)
                    {
                        _cbbtendocgia.SelectedItem = null;
                    }
                }
                else
                {
                    _cbbtendocgia.SelectedItem = null;
                }
                if (sach.Sach != null)
                {
                    try
                    {
                        Sach selected = _cbbtensach.SelectedItem as Sach;
                        List<Sach> cboxList = _cbbtensach.ItemsSource as List<Sach>;
                        selected = cboxList.SingleOrDefault(m => m.MaSach == sach.MaSach);
                        _cbbtensach.SelectedItem = selected;
                    }
                    catch (Exception)
                    {
                        _cbbtensach.SelectedItem = null;
                    }
                }
                else
                {
                    _cbbtensach.SelectedItem = null;
                }
                List<string> ma = new List<string>();
                ma = sachMuonControll.GetListMaDocGia(sach.MaSach);
                gridDocgia.ItemsSource = docGiaControll.GetDocGiaByListMa(ma);
                gridDocgia.RefreshData();
            }
            catch
            { }
        }

        private void _btnadd_Click(object sender, RoutedEventArgs e)
        {

            if (_btnadd.Content.Equals("Add new"))
            {
                _btnadd.Content = "Hoàn tất";
                _btnadd_cancel.IsEnabled = true;
                _btnadd_cancel.Visibility = Visibility.Visible;
                _btnsave.IsEnabled = false;
                _btndelete.IsEnabled = false;
                _btndelete.IsEnabled = false;
                _btnload.IsEnabled = false;
                gridSachMuon.IsEnabled = false;

                _txtmamuon.Clear();
                _txtsoluongmuon.Clear();
                _txttiencoc.Clear();
                _datemuon.Clear();
                _datetra.Clear();
                _checkdatra.IsChecked = false;
                _cbbtendocgia.SelectedItem = null;
                _cbbtensach.SelectedItem = null;


                return;
            }

            string warning = "";

            if (String.IsNullOrWhiteSpace(_txtsoluongmuon.Text))
            {
                warning += "Vui lòng nhập Số Lượng Sách Mượn." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_txttiencoc.Text))
            {
                warning += "Vui lòng nhập tiền cọc." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_cbbtendocgia.Text))
            {
                warning += "Vui lòng Chọn Độc Giả." + '\n';
            }
            if (String.IsNullOrWhiteSpace(_cbbtensach.Text))
            {
                warning += "Vui lòng Chọn Tên Sách." + '\n';
            }
          
            if (!warning.Equals(""))
            {
                MessageBox.Show(
                    warning,
                    "Thêm mới Sách Mượn",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }
            MuonSach sach = new MuonSach();

            try
            {
                sach.SoLuongMuon = Convert.ToInt16(_txtsoluongmuon.Text);
                sach.TienCoc = Convert.ToDecimal(_txttiencoc.Text);
                if (_checkdatra.IsChecked == true)
                {
                    sach.DaTra = true;
                } else sach.DaTra = false;

                if (_datemuon.Text.Equals("") == false && _datetra.Text.Equals("") == false)
                {
                    try
                    {
                        sach.NgayMuon = DateTime.Today;
                        sach.NgayHen = Convert.ToDateTime(_datetra.Text);
                    }
                    catch { }
                }
                else {
                    sach.NgayMuon = DateTime.Today;
                    sach.NgayHen = DateTime.Today;
                }

            }
            catch
            {
            }
            if (_cbbtendocgia.SelectedItem != null)
            {
                sach.MaDocGia = (_cbbtendocgia.SelectedItem as View_Models.DocGia).MaDocGia;
            }
            if (_cbbtensach.SelectedItem != null)
            {
                sach.MaSach = (_cbbtensach.SelectedItem as View_Models.Sach).MaSach;
            }
            Sach temp = _cbbtensach.SelectedItem as Sach;
            int slcm = sachControll.CheckChoMuon(temp);
            if (slcm == 0)
            {
                warning += "Sách trong kho đã hết" + '\n';
            }
            if (slcm < sach.SoLuongMuon)
            {
                warning += "Sách trong kho còn:" + slcm + '\n';
            }
            if (!warning.Equals(""))
            {
                MessageBox.Show(
                    warning,
                    "Thêm mới Sách Mượn",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            if (sachMuonControll.Add(sach))
                    {

                        Sach sachtemp = sachControll.GetById(sach.MaSach);
              
               sachtemp.LuongDaMuon =sachMuonControll.GetTongSachMuon(sachtemp)==null? 0: sachMuonControll.GetTongSachMuon(sachtemp).Value;
                 sachControll.Edit(sachtemp);
                 DocGia dgtemp = docGiaControll.GetById(sach.MaDocGia);
                  dgtemp.TienKiGui = sachMuonControll.GetTongTienCoc(dgtemp) == null ? 0 : sachMuonControll.GetTongTienCoc(dgtemp).Value;
                      docGiaControll.Edit(dgtemp);
                MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới Sách Muọn",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                MessageBoxResult re;
                re = MessageBox.Show("Bạn có muốn in phiếu không", "In Phiếu", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (re == MessageBoxResult.Yes)
                {
                    BookLoanPhieuMuon report = new BookLoanPhieuMuon(sach.MaDocGia,sach.NgayMuon);
                    report.FilterString = "[DaTra] = false";
                    DocumentPreviewWindow window = new DocumentPreviewWindow();
                    window.PreviewControl.DocumentSource = report;
                    report.CreateDocument(true);
                    window.ShowDialog();
                }
                }
                    else
                    {
                        MessageBox.Show(
                            "Thêm mới thất bại",
                            "Thêm mới Sách Mượn",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }
             
            _btnadd.Content = "Add new";
            _btnadd_cancel.IsEnabled = false;
            _btnadd_cancel.Visibility = Visibility.Hidden;
            _btnsave.IsEnabled = true;
            _btndelete.IsEnabled = true;
            _btnload.IsEnabled = true;
            gridSachMuon.IsEnabled = true;
            LoadSachMuonTable();
                

        }

        private void _btnsave_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu Sách", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {

                    if (_txtmamuon.Text.Equals("") == false)
                    {
                        MuonSach ms = new MuonSach();
                        ms = sachMuonControll.GetById(Convert.ToInt16(_txtmamuon.Text));
                        decimal datcoccu = ms.TienCoc;
                        MuonSach sach = new MuonSach();
                        try
                        {
                            sach.MaMuon =Convert.ToInt16( _txtmamuon.Text);
                            sach.SoLuongMuon =Convert.ToInt16( _txtsoluongmuon.Text);
                            sach.TienCoc = Convert.ToDecimal(_txttiencoc.Text);
                            try
                            {
                                if (_datetra.Text.Equals("") == false)
                                {
                                    try { sach.NgayHen = Convert.ToDateTime(_datetra.Text); }
                                    catch { }
                                }
                                else { sach.NgayHen = DateTime.Today; }
                                if (_datemuon.Text.Equals("") == false)
                                {
                                    try { sach.NgayMuon = Convert.ToDateTime(_datemuon.Text); }
                                    catch { }
                                }
                                else { sach.NgayMuon = DateTime.Today; }
                                if (_checkdatra.IsChecked == true)
                                {
                                    sach.DaTra = true;
                                }
                                else sach.DaTra = false;

                            }
                            catch
                            {

                            }
                            if (_cbbtendocgia.SelectedItem != null)
                            {
                                sach.MaDocGia = (_cbbtendocgia.SelectedItem as DocGia).MaDocGia;
                            }
                            if (_cbbtensach.SelectedItem != null)
                            {
                                sach.MaSach = (_cbbtensach.SelectedItem as Sach).MaSach;
                            }
                           
                        }
                        catch { }
                        Sach temp = _cbbtensach.SelectedItem as Sach;
                       
                        int slm = sachControll.CheckChoMuon(temp);
                        slm += Convert.ToInt16(sachMuonControll.GetById(Convert.ToInt16(_txtmamuon.Text)).SoLuongMuon);

                        string warning = "";

                        if (String.IsNullOrWhiteSpace(_cbbtensach.Text))
                        {
                            warning += "Vui lòng Chọn Tên Sách" + '\n';
                        }
                        if (String.IsNullOrWhiteSpace(_cbbtendocgia.Text))
                        {
                            warning += "Vui lòng Chọn Người Mượn." + '\n';
                        }
                        if (slm == 0)
                        {
                            warning += "Sách trong kho đã hết" + '\n';
                        }
                        if (slm < sach.SoLuongMuon)
                        {
                            warning += "Sách trong kho còn:" + slm + '\n';
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
                        if (sachMuonControll.Edit(sach))
                        {
                            try
                            {
                                Sach sachtemp = sachControll.GetById(sach.MaSach);
                                sachtemp.LuongDaMuon = sachMuonControll.GetTongSachMuon(sachtemp) == null ? 0 : sachMuonControll.GetTongSachMuon(sachtemp).Value;
                                sachControll.Edit(sachtemp);
                                DocGia dgtemp = docGiaControll.GetById(sach.MaDocGia);
                                dgtemp.TienKiGui = sachMuonControll.GetTongTienCoc(dgtemp) == null ? 0 : sachMuonControll.GetTongTienCoc(dgtemp).Value;
                                docGiaControll.Edit(dgtemp);
                            }

                            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
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

                        LoadSachMuonTable();
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

        private void _btndelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xóa không", "Xóa Người Mượn", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {

                    if (_txtmamuon.Text.Equals("") == false)
                    {
                        if (sachMuonControll.Delete(Convert.ToInt16(_txtmamuon.Text)))
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
                        MessageBoxImage.Error);
                        }
                        LoadSachMuonTable();
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
            LoadSachMuonTable();
        }

        private void _btnadd_cancel_Click(object sender, RoutedEventArgs e)
        {
            _btnadd.Content = "Add new";
            _btnadd_cancel.IsEnabled = false;
            _btnadd_cancel.Visibility = Visibility.Hidden;
            _btnsave.IsEnabled = true;
            _btndelete.IsEnabled = true;
            _btnload.IsEnabled = true;
            gridSachMuon.IsEnabled = true;
            LoadSachMuonTable();
        }

        private void gridDocgia_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                DocGiaModel select = gridDocgia.SelectedItem as DocGiaModel;

                DocGia docgia = docGiaControll.GetById(select.MaDocGia);
                _txtdiachidg.Text = docgia.DiaChi;
                _txtkhoadg.Text = docgia.Khoa.TenKhoa;
                _txtlopdg.Text = docgia.Lop.TenLop;
                _txttendg.Text = docgia.TenDocGia;
                _txttienkiguidg.Text = docgia.TienKiGui.ToString();
            }
            catch
            { }
        }
    }
}
