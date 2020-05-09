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
    /// Interaction logic for ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Window
    {
        string Email;
        public ChangePass(string Email)
        {
            InitializeComponent();
           
            string text = File.ReadAllText(Extention.path + @"\ADMINPanel\History.txt");

            History.Text = text;

            this.Email = Email;
            
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void confirmbtn_Click(object sender, RoutedEventArgs e)
        {
            string path = Extention.path + @"\ADMINPanel\Password.txt";
            StreamReader reader = new StreamReader(path);
            string pass = reader.ReadLine();
            reader.Close();

            pass = Extention.DeCode(pass);

            if (CurrentPass.Password == pass)
            {

                if (NewPass.Password == RNPass.Password)
                {

                    if (pass == NewPass.Password)
                    {
                        MessageBox.Show("The password does not changed becuase it's the same of first one !!!", "Does not changed", MessageBoxButton.OK, MessageBoxImage.Warning);
                        goto End;
                    }

                    string code = Extention.Code(NewPass.Password);

                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(code);
                    writer.Close();
                    MessageBox.Show("Password changed successfuly .", "Done !!!", MessageBoxButton.OK, MessageBoxImage.Information);

                    DateTime today = DateTime.Now;
                    today.ToString("yyyy-MM-dd_HH:mm:ss");

                    string text = File.ReadAllText(Extention.path + @"\ADMINPanel\History.txt");
                    text += "==========================" + '\n' + '\'' + pass + '\'' + " Changed at " + today + " By " + Email + " To " + '\'' + NewPass.Password + '\'' + '\n';
                    File.WriteAllText(Extention.path + @"\ADMINPanel\History.txt", text);

                    History.Text = text;
                    CurrentPass.Password = "";
                    NewPass.Password = "";
                    RNPass.Password = "";

                }
                else
                {
                    MessageBox.Show("New password and its repeat is not match .", "Not match", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Current password is incorrect .", "incorrect", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        End:
            ;

        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            NewPass.Password = "";
            RNPass.Password = "";
            CurrentPass.Password = "";
        }

        private void NPassCheck(object sender, RoutedEventArgs e)
        {
            if (NewPass.Password == null || NewPass.Password == "")
            {
                confirmbtn.IsEnabled = false;
            }
            else
            {
                confirmbtn.IsEnabled = true;
            }
        }

        private void RNPassCheck(object sender, RoutedEventArgs e)
        {
            if (RNPass.Password == null || RNPass.Password == "")
            {
                confirmbtn.IsEnabled = false;
            }
            else
            {
                confirmbtn.IsEnabled = true;
            }
        }
    }
}
