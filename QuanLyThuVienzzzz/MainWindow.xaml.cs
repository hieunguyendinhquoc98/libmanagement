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

namespace QuanLyThuVienzzzz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_DangNhap(object sender, RoutedEventArgs e)
        {
            LoginWindow lgWd = new LoginWindow();
            lgWd.ShowDialog();
        }

        private void NhapSach_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void DocGia_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void NhanVien_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Sach_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StaffWindow s = new StaffWindow();
            s.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StaffManagerWindow s1 = new StaffManagerWindow();
            s1.Show();
        }
    }
}
