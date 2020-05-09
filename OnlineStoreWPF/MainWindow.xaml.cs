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

namespace OnlineStoreWPF
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

        

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin win = new AdminLogin();
            win.ShowDialog();

        }

        

        private void User_Click(object sender, RoutedEventArgs e)
        {
            UserLogin win = new UserLogin();
            win.ShowDialog();
            
        }

        
    }
}
