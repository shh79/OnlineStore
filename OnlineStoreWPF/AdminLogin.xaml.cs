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
using System.IO;

namespace OnlineStoreWPF
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            string path = Extention.path;
            path += @"\ADMINPanel\Password.txt";

            StreamReader read = new StreamReader(path);
            string pass = read.ReadLine();
            read.Close();

            pass = Extention.DeCode(pass);

            if (UserNamebox.Text == "Developer") {
                try
                {
                    DateTime today = DateTime.Now;
                    today.ToString("yyyy-mm-dd");

                    string date = today.ToString();

                    string[] sep = date.Split('/');

                    sep[2] = sep[2].Remove(4);

                    int devpass = 0;

                    for (int i = 0; i < sep.Length; ++i)
                    {
                        devpass += int.Parse(sep[i]);
                    }

                    
                    if (PassBox.Password == devpass.ToString())
                    {
                        string restorepass = "0000";

                        restorepass = Extention.Code(restorepass);

                        StreamWriter writer = new StreamWriter(path);
                        writer.WriteLine(restorepass);
                        writer.Close();

                        MessageBox.Show("Now your forgotten password changed and your current password is \'0000\'", "Password Changed !!!", MessageBoxButton.OK, MessageBoxImage.Warning);

                        AdminPanel win = new AdminPanel();
                        win.AdminEmail.Text = UserNamebox.Text;
                        win.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Your username is your Email and should be in correct format .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (Extention.isValidEmail(UserNamebox.Text))
            {
                
                if (PassBox.Password == pass)
                {
                    AdminPanel win = new AdminPanel();
                    win.AdminEmail.Text = UserNamebox.Text;
                    win.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password is incorrect .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Your username is your Email and should be in correct format .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UserNamebox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void PCheck(object sender, RoutedEventArgs e)
        {
            if (PassBox.Password == null || PassBox.Password=="")
            {
                Log_button.IsEnabled = false;
            }
            else
            {
                Log_button.IsEnabled = true;
            }
        }
    }

    
}
