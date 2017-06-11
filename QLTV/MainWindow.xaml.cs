using DevExpress.Xpf.Core;
using QLTV.Controllers;
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

namespace QLTV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            ApplicationThemeHelper.ApplicationThemeName = "Office2010Blue";
           
            InitializeComponent();
          
        }
        private int idmain { get; set; }
      

      
        private void _btnlogin_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                UserController us = new UserController();

                if ((bool)us.Login(_txtuser.Text,_txtpassword.Password))
                {
                    App.Role = App.usercontroll.GetRolebyUserName(_txtuser.Text);
                    MessageBox.Show( "Đăng nhập Thành công.");
                    frmMain fr = new frmMain();       
                    fr.Show();
                  
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Đăng nhập Thất Bại.");

                }
            }
            catch { };
        }

        private void _btnexit_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
