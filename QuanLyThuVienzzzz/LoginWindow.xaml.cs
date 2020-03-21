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

namespace QuanLyThuVienzzzz
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_DangKy(object sender, RoutedEventArgs e)
        {
            this.Close();
            CreateAccount CrAcc = new CreateAccount();
            CrAcc.ShowDialog();
        }

        private void Button_DangNhap(object sender, RoutedEventArgs e)
        {

        }
    }
}
