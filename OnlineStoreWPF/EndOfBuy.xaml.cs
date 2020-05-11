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
using System.Text.RegularExpressions;
using System.IO;

namespace OnlineStoreWPF
{
    /// <summary>
    /// Interaction logic for EndOfBuy.xaml
    /// </summary>
    public partial class EndOfBuy : Window
    {
        public EndOfBuy()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Confirmbtn_Click(object sender, RoutedEventArgs e)
        {
            if (validDay())
            {
                if (validID())
                {
                    if (validcheck())
                    {
                        MessageBox.Show("Thanks for shoping . Have good day .", "Thanks", MessageBoxButton.OK, MessageBoxImage.Information);
                        Application.Current.Windows[Application.Current.Windows.Count - 3].Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fill all of fields .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Credit Card ID is invalid .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Expire date is invalid .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public bool validcheck()
        {
            if(ID1.Text!=string.Empty && ID2.Text != string.Empty && ID3.Text != string.Empty && ID4.Text != string.Empty)
            {
                if(Month.Text!=string.Empty && Day.Text != string.Empty)
                {
                    if (CCV2.Text != string.Empty)
                    {
                        if (PassCode.Password != string.Empty)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool validID()
        {
            if(ID1.Text.Length==4 && ID2.Text.Length == 4 && ID3.Text.Length == 4 && ID4.Text.Length == 4)
            {
                return true;
            }
            return false;
        }

        public bool validDay()
        {
            int temp = int.Parse(Day.Text);
            if (temp <= 31 && temp > 0)
            {
                return true;
            }
            return false;
        }

        private void PassCheck(object sender, RoutedEventArgs e)
        {
            if (PassCode.Password == string.Empty)
            {
                Confirmbtn.IsEnabled = false;
            }
            else
            {
                Confirmbtn.IsEnabled = true;
            }
        }
    }
}
