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
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        string[] Goodsname;

        string path = Extention.path + @"\GOODS\";

        static public ObservableCollection<Goods> items;

        public AdminPanel()
        {
            InitializeComponent();

            items = new ObservableCollection<Goods>();

            UserPanel.userlist(out Goodsname);

            for (int i = 0; i < Goodsname.Length; ++i)
            {
                string a, b, c;
                int d, e;

                string temp = path;
                temp += Goodsname[i] + ".txt";

                StreamReader reader = new StreamReader(temp);

                a = reader.ReadLine();
                d = int.Parse(reader.ReadLine());
                e = int.Parse(reader.ReadLine());
                b = reader.ReadLine();
                c = reader.ReadLine();

                reader.Close();

                items.Add(new Goods() { Name = a, Price = d, ID = e, Pro1 = b, Pro2 = c });

            }

            ManageList.ItemsSource = items;



        }

        private void exitbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void serchbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int bugfounder = int.Parse(Searchbar.Text);

                string path = Extention.path;
                path += @"\GOODS\";

                string input = Searchbar.Text;

                string output = "";

                string[] property;

                UserPanel.userlist(out property);

                if (property.Length != 0)
                {
                    bool flag = true;
                    for(int i = 0; i < property.Length; ++i)
                    {
                        StreamReader reader = new StreamReader(path + property[i] + ".txt");
                        string a = reader.ReadLine();
                        string b = reader.ReadLine();
                        output = reader.ReadLine();
                        string c = reader.ReadLine();
                        string d = reader.ReadLine();
                        reader.Close();
                        if (input == output)
                        {
                            flag = false;

                            string message = "Name :" + a + '\n' + "Cost :" + b + '\n' + "ID :" + output + '\n' + "Pro 1 :" + c + '\n' + "Pro 2 :" + d;
                            
                            MessageBox.Show(message, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        }
                        
                    }
                    if (flag)
                    {
                        MessageBox.Show("This goods not found in our store .", "Not found", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("There isn't any goods in store .");
                }


            }
            catch
            {
                MessageBox.Show("Please enter numberic ID .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        

        private void Showbtn_Click(object sender, RoutedEventArgs e)
        {
            string path = Extention.path + @"\USERPanel\Customer Info.txt";
            StreamReader reader = new StreamReader(path);

            showcustomer win = new showcustomer();
            win.List.Text = "";

            bool flag = true;

            while (!reader.EndOfStream)
            {
                flag = false;
                win.List.Text += reader.ReadLine() + '\n';
            }

            reader.Close();

            if (flag)
            {
                win.List.Text = "Empty";
            }

            win.ShowDialog();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            int[] IDNum = new int[items.Count];
            for(int i = 0; i < IDNum.Length; ++i)
            {
                IDNum[i] = items[i].ID;
            }

            AddGoodsPanel win = new AddGoodsPanel(IDNum);
            win.ShowDialog();

        }

        private void removebtn_Click(object sender, RoutedEventArgs e)
        {
            string willdeleted;
            try
            {
                MessageBoxResult r = MessageBox.Show("Are you sure ?", "Attention !!!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    willdeleted = items[ManageList.SelectedIndex].ID.ToString();
                    items.RemoveAt(ManageList.SelectedIndex);

                    string temppath = path + willdeleted + ".txt";

                    
                    File.Delete(temppath);

                    MessageBox.Show("This goods deleted successfully .", "Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Chgpassbtn_Click(object sender, RoutedEventArgs e)
        {
            ChangePass win = new ChangePass(AdminEmail.Text);
            win.ShowDialog();
        }
    }
}
