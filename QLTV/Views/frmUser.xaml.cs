using QLTV.Controllers;
using System;
using QLTV.View_Models;
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
    /// Interaction logic for frmUser.xaml
    /// </summary>
    public partial class frmUser : UserControl
    {
        public frmUser()
        {
            InitializeComponent();
            LoadCBB();

            LoadUserTable();
            LoadRoleTable();
            if (App.Role.AddAll == true)
            {
                _navadd.IsEnabled = true;
                _navadd_cancel.IsEnabled = true;
                _btnaddpermiss.IsEnabled = true;
                _btncanceladdpermiss.IsEnabled = true;
            }else
            {
                if (App.Role.AddUser != true)
                {
                    _navadd.IsEnabled = false;
                    _navadd_cancel.IsEnabled = false;
                    _btnaddpermiss.IsEnabled = false;
                    _btncanceladdpermiss.IsEnabled = false;
                }
            }
            if (App.Role.EditAll == true)
            {
                _navsave.IsEnabled = true;
                _btneditpermiss.IsEnabled = true;
            }
            else
            {
                if (App.Role.EditUser != true)
                {
                    _navsave.IsEnabled = false;
                    _btneditpermiss.IsEnabled = false;
                }
            }
            if (App.Role.DeleteAll == true)
            {
                _navdelete.IsEnabled = true;
                _btndeletepermiss.IsEnabled = true;
            }else
            {
                if (App.Role.DeleteUser != true)
                {
                    _navdelete.IsEnabled = false;
                    _btndeletepermiss.IsEnabled = false;
                }
            }
        }
        RoleController rolecontroll = new RoleController();
        UserController usercontroll = new UserController();
        public void LoadUserTable()
        {
            gridUser.ItemsSource = usercontroll.ListUser;
            gridUser.RefreshData();
        }
        public void LoadCBB()
        {
            
            _txtrole.ItemsSource = rolecontroll.GetAllRole;
            _txtrole.DisplayMemberPath = "RoleName";
        }
        private void _navadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_navadd.Content.Equals("Add new"))
                {
                    _navadd.Content = "OK";
                    _navadd_cancel.IsEnabled = true;

                    _navsave.IsEnabled = false;
                    _navdelete.IsEnabled = false;
                    _navdelete.IsEnabled = false;
                    _navload.IsEnabled = false;
                    gridUser.IsEnabled = false;
                    _txtiduser.Clear();
                    _txtusername.Clear();
                    _txtpassword.Clear();
                    _txtrole.SelectedItem=null;
                    return;
                }
                User User = new User();

                User.USERNAME = _txtusername.Text;
                User.PASSWORD = _txtpassword.Text;
                if (_txtrole.SelectedItem != null)
                {
                    User.IdRole = (_txtrole.SelectedItem as Role).IdRole;
                }
                string warning = "";

                if (String.IsNullOrWhiteSpace(_txtpassword.Text))
                {
                    warning += "Vui lòng nhập password User." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txtusername.Text))
                {
                    warning += "Vui lòng nhập tên User." + '\n';
                }
                if (String.IsNullOrWhiteSpace(_txtrole.Text))
                {
                    warning += "Vui lòng nhập role User." + '\n';
                }
                if (!warning.Equals(""))
                {
                    MessageBox.Show(warning,
                        "Thêm mới User",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }

                if (usercontroll.Add(User))
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
                _navadd.Content = "Add new";
                _navadd_cancel.IsEnabled = false;

                _navsave.IsEnabled = true;
                _navdelete.IsEnabled = true;
                _navdelete.IsEnabled = true;
                _navload.IsEnabled = true;
                gridUser.IsEnabled = true;
                LoadUserTable();
            }
            catch
            {

            }
        }

        private void _navedit_Click(object sender, EventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu User", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtiduser.Text.Equals(""))
                    {
                        User User = new User();
                        User = usercontroll.GetById(Convert.ToInt16(_txtiduser.Text.Trim()));
                        User.PASSWORD = _txtpassword.Text.Trim();

                        if (_txtrole.SelectedItem != null)
                        {
                            User.IdRole = (_txtrole.SelectedItem as Role).IdRole;
                        }
                        string warning = "";
                        if (String.IsNullOrWhiteSpace(_txtpassword.Text))
                        {
                            warning += "Vui lòng nhập password." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới User",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (usercontroll.Edit(User))
                        {
                            MessageBox.Show(
                               "Cập nhật thành công",
                               "Cập Nhật User",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Cập nhật thất bại",
                               "Cập Nhật User",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadUserTable();
                    }
                }
                catch { }
            }
        }

        private void _navdelete_Click(object sender, EventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xoa không", "Lưu User", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    if (!_txtiduser.Text.Equals(""))
                    {
                        string warning = "";
                        if (String.IsNullOrWhiteSpace(_txtiduser.Text))
                        {
                            warning += "Vui lòng chọn cần xóa." + '\n';
                        }

                        if (!warning.Equals(""))
                        {
                            MessageBox.Show(
                                warning,
                                "Thêm mới User",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
                            return;
                        }
                        if (usercontroll.Delete(Convert.ToInt16(_txtiduser.Text)))
                        {
                            MessageBox.Show(
                               "Xóa thành công",
                               "Xóa User",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                               "Xóa thất bại",
                               "Xóa User",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
                        }
                        LoadUserTable();
                    }
                }
                catch { }
            }
        }

        private void _navload_Click(object sender, EventArgs e)
        {
            LoadUserTable();
        }

        private void _navcancel_Click(object sender, EventArgs e)
        {
            _navadd.Content = "Add new";
            _navadd_cancel.IsEnabled = false;

            _navsave.IsEnabled = true;
            _navdelete.IsEnabled = true;
            _navdelete.IsEnabled = true;
            _navload.IsEnabled = true;
            gridUser.IsEnabled = true;
            LoadUserTable();
        }
        private void gridUser_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                UserModel select = gridUser.SelectedItem as UserModel;
                User User = usercontroll.GetById(select.IDUSER);
                _txtiduser.Text = User.IDUSER.ToString();
                _txtusername.Text = User.USERNAME;
                _txtpassword.Text = User.PASSWORD;
                _txtrole.Text = User.Role.RoleName;

            }
            catch { }
        }

        private void _btnaddpermiss_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_btnaddpermiss.Content.Equals("Add new"))
                {
                    _btnaddpermiss.Content = "Ok";
                    _btncanceladdpermiss.IsEnabled = true;

                    _btneditpermiss.IsEnabled = false;
                    _btndeletepermiss.IsEnabled = false;

                    _btnloadpermiss.IsEnabled = false;
                    gridPerMiss.IsEnabled = false;
                    _txtrolename.Clear();
                    _checkAddAll.IsChecked =
                    _checkAddDocGia.IsChecked =
                    _checkAddSach.IsChecked =
                    _checkAddSM.IsChecked =
                    _checkAdduser.IsChecked =
                    _checkViewAll.IsChecked =
                    _checkViewDocGia.IsChecked =
                    _checkViewSach.IsChecked =
                    _checkViewSM.IsChecked =
                    _checkViewuser.IsChecked =
                    _checkViewThongKe.IsChecked =
                    _checkEditAll.IsChecked =
                    _checkEditDocGia.IsChecked =
                    _checkEditSach.IsChecked =
                    _checkEditSM.IsChecked =
                    _checkEdituser.IsChecked =
                    _checkDeleteAll.IsChecked =
                    _checkDeleteDocGia.IsChecked =
                    _checkDeleteSach.IsChecked =
                    _checkDeleteSM.IsChecked =
                    _checkDeleteuser.IsChecked = null;
                    return;
                }
                if (String.IsNullOrWhiteSpace(_txtrolename.Text))
                {
                    MessageBox.Show("Role Name không được để trống.",
                        "Thêm mới Role",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    return;
                }
                Role _role = new Role();
                _role.RoleName = _txtrolename.Text;
                _role.AddAll = _checkAddAll.IsChecked;
                _role.AddDocGia = _checkAddDocGia.IsChecked;
                _role.AddSach = _checkAddSach.IsChecked;
                _role.AddSachMuon = _checkAddSM.IsChecked;
                _role.AddUser = _checkAdduser.IsChecked;
                _role.ViewAll = _checkViewAll.IsChecked;
                _role.ViewDocGia = _checkViewDocGia.IsChecked;
                _role.ViewSach = true;
                _role.ViewSachMuon = _checkViewSM.IsChecked;
                _role.ViewUser = _checkViewuser.IsChecked;
                _role.ViewThongKe = _checkViewThongKe.IsChecked;
                _role.EditAll = _checkEditAll.IsChecked;
                _role.EditDocGia = _checkEditDocGia.IsChecked;
                _role.EditSach = _checkEditSach.IsChecked;
                _role.EditSachMuon = _checkEditSM.IsChecked;
                _role.EditUser = _checkEdituser.IsChecked;
                _role.DeleteAll = _checkDeleteAll.IsChecked;
                _role.DeleteDocGia = _checkDeleteDocGia.IsChecked;
                _role.DeleteSach = _checkDeleteSach.IsChecked;
                _role.DeleteSachMuon = _checkDeleteSM.IsChecked;
                _role.DeleteUser = _checkDeleteuser.IsChecked;
                if (rolecontroll.Add(_role))
                {
                    MessageBox.Show(
                            "Thêm mới thành công",
                            "Thêm mới role",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show(
                          "Thêm mới thất bại",
                          "Thêm mới role",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
                }
                _btnaddpermiss.Content = "Add new";
                _btncanceladdpermiss.IsEnabled = false;

                _btneditpermiss.IsEnabled = true;
                _btndeletepermiss.IsEnabled = true;

                _btnloadpermiss.IsEnabled = true;
                gridPerMiss.IsEnabled = true;

                LoadRoleTable();
            }
            catch { }
        }
        public void LoadRoleTable()
        {
            gridPerMiss.ItemsSource = rolecontroll.ListRole;
            gridPerMiss.RefreshData();
        }
        private void gridPerMiss_SelectedItemChanged(object sender, DevExpress.Xpf.Grid.SelectedItemChangedEventArgs e)
        {
            try
            {
                RoleModel select = gridPerMiss.SelectedItem as RoleModel;

                Role _role = rolecontroll.GetById(select.IdRole);
                _txtrolename.Text = _role.RoleName;
                _checkAddAll.IsChecked = _role.AddAll;
                _checkAddDocGia.IsChecked = _role.AddDocGia;
                _checkAddSach.IsChecked = _role.AddSach;
                _checkAddSM.IsChecked = _role.AddSachMuon;
                _checkAdduser.IsChecked = _role.AddUser;
                _checkViewAll.IsChecked = _role.ViewAll;
                _checkViewDocGia.IsChecked = _role.ViewDocGia;
                _checkViewSach.IsChecked = _role.ViewSach;
                _checkViewSM.IsChecked = _role.ViewSachMuon;
                _checkViewuser.IsChecked = _role.ViewUser;
                _checkViewThongKe.IsChecked = _role.ViewThongKe;
                _checkEditAll.IsChecked = _role.EditAll;
                _checkEditDocGia.IsChecked = _role.EditDocGia;
                _checkEditSach.IsChecked = _role.EditSach;
                _checkEditSM.IsChecked = _role.EditSachMuon;
                _checkEdituser.IsChecked = _role.EditUser;
                _checkDeleteAll.IsChecked = _role.DeleteAll;
                _checkDeleteDocGia.IsChecked = _role.DeleteDocGia;
                _checkDeleteSach.IsChecked = _role.DeleteSach;
                _checkDeleteSM.IsChecked = _role.DeleteSachMuon;
                _checkDeleteuser.IsChecked = _role.DeleteUser;
            }
            catch { }
        }

        private void _btneditpermiss_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn sửa không", "Lưu role", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    RoleModel select = gridPerMiss.SelectedItem as RoleModel;

                    Role _role = rolecontroll.GetById(select.IdRole);




                    if (String.IsNullOrWhiteSpace(_txtrolename.Text))
                    {
                        MessageBox.Show("Role Name không được để trống.",
                    "Thêm mới Role",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                        return;
                    }
                    _role.RoleName = _txtrolename.Text;
                    _role.AddAll = _checkAddAll.IsChecked;
                    _role.AddDocGia = _checkAddDocGia.IsChecked;
                    _role.AddSach = _checkAddSach.IsChecked;
                    _role.AddSachMuon = _checkAddSM.IsChecked;
                    _role.AddUser = _checkAdduser.IsChecked;
                    _role.ViewAll = _checkViewAll.IsChecked;
                    _role.ViewDocGia = _checkViewDocGia.IsChecked;
                    _role.ViewSach = true;
                    _role.ViewSachMuon = _checkViewSM.IsChecked;
                    _role.ViewUser = _checkViewuser.IsChecked;
                    _role.ViewThongKe = _checkViewThongKe.IsChecked;
                    _role.EditAll = _checkEditAll.IsChecked;
                    _role.EditDocGia = _checkEditDocGia.IsChecked;
                    _role.EditSach = _checkEditSach.IsChecked;
                    _role.EditSachMuon = _checkEditSM.IsChecked;
                    _role.EditUser = _checkEdituser.IsChecked;
                    _role.DeleteAll = _checkDeleteAll.IsChecked;
                    _role.DeleteDocGia = _checkDeleteDocGia.IsChecked;
                    _role.DeleteSach = _checkDeleteSach.IsChecked;
                    _role.DeleteSachMuon = _checkDeleteSM.IsChecked;
                    _role.DeleteUser = _checkDeleteuser.IsChecked;
                    if (rolecontroll.Edit(_role))
                    {
                        MessageBox.Show(
                           "Cập nhật thành công",
                           "Cập Nhật role",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                           "Cập nhật thất bại",
                           "Cập Nhật role",
                           MessageBoxButton.OK,
                           MessageBoxImage.Error);
                    }
                    LoadRoleTable();

                }
                catch { }
            }
        }

        private void _btndeletepermiss_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult re;
            re = MessageBox.Show("Bạn có muốn xoa không", "Lưu User", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (re == MessageBoxResult.Yes)
            {
                try
                {
                    RoleModel select = gridPerMiss.SelectedItem as RoleModel;
                    if (rolecontroll.Delete(select.IdRole))
                    {
                        MessageBox.Show(
                           "Xóa thành công",
                           "Xóa role",
                           MessageBoxButton.OK,
                           MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                           "Xóa thất bại",
                           "Xóa role",
                           MessageBoxButton.OK,
                           MessageBoxImage.Error);
                    }
                    LoadRoleTable();

                }
                catch { }
            }
        }

        private void _btncanceladdpermiss_Click(object sender, RoutedEventArgs e)
        {
            _btnaddpermiss.Content = "Add new";
            _btncanceladdpermiss.IsEnabled = false;

            _btneditpermiss.IsEnabled = true;
            _btndeletepermiss.IsEnabled = true;

            _btnloadpermiss.IsEnabled = true;
            gridPerMiss.IsEnabled = true;

            LoadRoleTable();
        }

        private void _btnloadpermiss_Click(object sender, RoutedEventArgs e)
        {
            LoadRoleTable();
        }
    }
}
