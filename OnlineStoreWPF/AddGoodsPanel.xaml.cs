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
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace OnlineStoreWPF
{
    /// <summary>
    /// Interaction logic for AddGoodsPanel.xaml
    /// </summary>
    public partial class AddGoodsPanel : Window
    {
        public AddGoodsPanel()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void New(object sender, RoutedEventArgs e)
        {
            DelShared();
        }

        private void DelShared()
        {
            Namebox.Text = "";
            IDBox.Text = "";
            PriceBox.Text = "";
            Pro1Box.Text = "";
            Pro2Box.Text = "";
            VideoCH.IsChecked = false;
            BookCH.IsChecked = false;
            MagazineCH.IsChecked = false;
        }

        private void MagazineCH_Checked(object sender, RoutedEventArgs e)
        {
            VideoCH.IsChecked = false;
            BookCH.IsChecked = false;

            Pro1Box.Text = "Name Of Publisher";
            Pro2Box.Text = "Count Of Page";

        }

        private void VideoCH_Checked(object sender, RoutedEventArgs e)
        {
            MagazineCH.IsChecked = false;
            BookCH.IsChecked = false;

            Pro1Box.Text = "Time Of Video";
            Pro2Box.Text = "Count Of DVD";

        }

        private void BookCH_Checked(object sender, RoutedEventArgs e)
        {
            VideoCH.IsChecked = false;
            MagazineCH.IsChecked = false;

            Pro1Box.Text = "Name Of Author";
            Pro2Box.Text = "Name Of Publisher";

        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            bool CHflag = false;
            bool Fillflag = false;

            Checkingrule(ref CHflag, ref Fillflag);
            try
            {
                if (CHflag && Fillflag)
                {
                    string n, p1, p2;
                    int id, pr;
                    TGoods type;

                    n = Namebox.Text;
                    p1 = Pro1Box.Text;
                    p2 = Pro2Box.Text;

                    id = int.Parse(IDBox.Text);
                    pr = int.Parse(PriceBox.Text);

                    if (BookCH.IsChecked == true)
                    {
                        type = TGoods.Books;
                    }
                    else if (VideoCH.IsChecked == true)
                    {
                        type = TGoods.Videos;
                    }
                    else
                    {
                        type = TGoods.Magazines;
                    }

                    AdminPanel.items.Add(new Goods { ID = id, Name = n, Price = pr, Pro1 = p1, Pro2 = p2, Type = type });

                    string path=Extention.path + @"\GOODS\";
                    path += id.ToString() + ".txt";

                    StreamWriter writer = new StreamWriter(path);

                    writer.WriteLine(n);
                    writer.WriteLine(pr);
                    writer.WriteLine(id);
                    writer.WriteLine(p1);
                    writer.WriteLine(p2);
                    writer.WriteLine(type.ToString());

                    writer.Close();

                    MessageBox.Show("The new goods added succssfully .", "New Goods Added", MessageBoxButton.OK, MessageBoxImage.Information);

                    DelShared();
                    
                }
                else
                {
                    MessageBox.Show("Please fill all of field and check the boxes .", "Alert !!!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("ID and Price should be in numbric format .", "Error !!!", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }


        private void Checkingrule(ref bool flag1,ref bool flag2)
        {


            if((VideoCH.IsChecked==true) || (MagazineCH.IsChecked == true) || (BookCH.IsChecked == true))
            {
                flag1 = true;
            }
            else
            {
                flag1 = false;
            }

            if(Namebox.Text==string.Empty || IDBox.Text==string.Empty || PriceBox.Text==string.Empty || Pro1Box.Text==string.Empty || Pro2Box.Text == string.Empty)
            {
                flag2 = false;
            }
            else
            {
                flag2 = true;
            }


        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
