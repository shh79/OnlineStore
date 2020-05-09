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

namespace OnlineStoreWPF
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void PassBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void UserNamebox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            bool flag1=false, flag2=false;

            if (StuCH.IsChecked==true || TeCH.IsChecked==true || CUCH.IsChecked==true) 
            {
                if (UserNamebox.Text == "")
                {
                    flag1 = true;
                }
                if (PassBox.Text == "")
                {
                    flag2 = true;
                }

                if (flag1 && flag2)
                {
                    MessageBox.Show("User name and password can not be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (flag1)
                {
                    MessageBox.Show("User name can not be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (flag2)
                {
                    MessageBox.Show("Password can not be empty.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (rule())
                    {
                        work();
                    }
                    else
                    {
                        MessageBox.Show("Password is invalid .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check your account type.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private bool rule()
        {
            try
            {
                if (StuCH.IsChecked == true)
                {
                    return (Extention.STUCode(int.Parse(PassBox.Text)));
                }
                else if (TeCH.IsChecked == true)
                {
                    return true;
                }
                else
                {
                    return (Extention.Melicode(PassBox.Text));
                }

            }
            catch
            {
                MessageBox.Show("Student ID is a number that start with \'9\' or National ID contain ten numbers .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

           
        }

        private void work()
        {
            string username = UserNamebox.Text;
            string passbar = PassBox.Text;

            if (StuCH.IsChecked == true)
            {
                Student stu = new Student(username, passbar);
                UserPanel UP = new UserPanel(stu);
                UP.ShowDialog();

            }
            else if (TeCH.IsChecked == true)
            {
                Teacher tea = new Teacher(username, passbar);
                UserPanel UP = new UserPanel(tea);
                UP.ShowDialog();
            }
            else
            {
                Customer cus = new Customer(username, passbar);
                UserPanel UP = new UserPanel(cus);
                UP.ShowDialog();
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StuCH_Checked(object sender, RoutedEventArgs e)
        {
            TeCH.IsChecked = false;
            CUCH.IsChecked = false;
            PassBox.Text = "Student ID";
        }

        private void TeCH_Checked(object sender, RoutedEventArgs e)
        {
            StuCH.IsChecked = false;
            CUCH.IsChecked = false;
            PassBox.Text = "Teaching place";
        }

        private void CUCH_Checked(object sender, RoutedEventArgs e)
        {
            StuCH.IsChecked = false;
            TeCH.IsChecked = false;
            PassBox.Text = "National ID";
        }
    }
}
