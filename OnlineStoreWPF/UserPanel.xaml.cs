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
    /// Interaction logic for UserPanel.xaml
    /// </summary>
    /// 

    public enum TGoods { Magazines, Books, Videos };

    public partial class UserPanel : Window
    {
        public enum Type { Student, Teacher, Customer};
        

        public Student TOS = null;  //Type Of Student
        public Teacher TOT = null;  //Type Of Teacher
        public Customer TOC = null;  //Type Of Customer

        public Type flag;

        public string[] GoodsName;

        public string path = Extention.path + @"\GOODS\";

        int Capacity = 0;
        
        int totalprice = 0;

        int counter = 0;

        int Posoflast = 1;

        public int[] constant;

        public List<Goods> items;
       

        public UserPanel(Reapeted obj)
        {
            InitializeComponent();

            userlist(out GoodsName);

            items = new List<Goods>();
            

            constant = new int[100];


            for (int i = 0; i < GoodsName.Length; ++i)
            {
                string a, b, c;
                int d, e;

                
                TGoods TGS;

                string temp = path;
                temp += GoodsName[i] + ".txt";

                StreamReader reader = new StreamReader(temp);

                a = reader.ReadLine();
                d = int.Parse(reader.ReadLine());
                e = int.Parse(reader.ReadLine());
                b = reader.ReadLine();
                c = reader.ReadLine();
                TGS = (TGoods)Enum.Parse(typeof(TGoods), reader.ReadLine());
                
                reader.Close();

                items.Add(new Goods() { Name = a, Price=d, ID=e, Pro1 = b, Pro2 = c, Type=TGS });


            }

            lvUsers.ItemsSource = items;
          


            if (obj is Student)
            {
                TOS = (obj as Student);
                flag = Type.Student;
                
            }
            else if(obj is Teacher)
            {
                TOT = (obj as Teacher);
                flag = Type.Teacher;
                
            }
            else
            {
                TOC = (obj as Customer);
                flag = Type.Customer;
                
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult q = MessageBox.Show("Are you sure ?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (q == MessageBoxResult.Yes)
            {
                MessageBox.Show("Thanks for choosing us .Have a good time .", "Good Bye", MessageBoxButton.OK, MessageBoxImage.Information);
                
                this.Close();
            }
            
            
        }

        private void gotocart_Click(object sender, RoutedEventArgs e)
        {
            TabCon.SelectedItem = CartTab;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            TabCon.SelectedItem = AvaiTab;
        }


        public static void userlist(out string[] files)
        {
            string path = Extention.path;
            path += @"\GOODS";

            files = System.IO.Directory.GetFiles(path, "*.txt");


            for (int i = 0; i < files.Length; ++i)
            {
                
                files[i] = files[i].Remove(0, path.Length + 1);

                files[i] = files[i].Remove(files[i].Length - 4);

            }
        }

        private void PaymentBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                PaymentPage win;

                int countof = cartlv.Items.Count;

                if (TOS != null)
                {
                    win = new PaymentPage(TOS);
                }
                else if (TOT != null)
                {
                    win = new PaymentPage(TOT);
                }
                else
                {
                    win = new PaymentPage(TOC);
                }


                for (int i = 0; i < cartlv.Items.Count; ++i)
                {
                    win.Fitem.Add(items[constant[i]]);

                    //win.FinalList.Items.Add(cartlv.Items[i]);
                }
                win.FinalList.ItemsSource = win.Fitem;

                win.totalpay.Text = Currentpay.Text;

                win.Calculate();

                win.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Addto_Click(object sender, RoutedEventArgs e)
        {
            if (Capacity <= 20)
            {
                string temp = Currentpay.Text;
                int temp2 = int.Parse(temp.Remove(temp.Length - 2));

                cartlv.Items.Add(lvUsers.SelectedItem);

                int newprice = items[lvUsers.SelectedIndex].Price;

                totalprice = temp2 + newprice;

                constant[counter] = lvUsers.SelectedIndex;

                ++counter;

                Currentpay.Text = totalprice.ToString() + " $";

                string goodsname = items[lvUsers.SelectedIndex].Name;

                MessageBox.Show(goodsname + " added to cart .",goodsname,MessageBoxButton.OK,MessageBoxImage.Information);

                ++Capacity;
            }
            else
            {
                MessageBox.Show("Your cart is overflowed . The maximum size is 20 .", "Cart Overflowed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CartList(object sender, SelectionChangedEventArgs e)
        {

        }



        int privase = 1000;

        private void RemoveClick(object sender, RoutedEventArgs e)
        {
            int stack = cartlv.SelectedIndex;

            MessageBox.Show("Stack : " + stack.ToString() + "   " + "Privase : " + privase.ToString());
            
            cartlv.Items.Remove(cartlv.SelectedItem);

            --Capacity;

            string temp = Currentpay.Text;

            int temp2 = int.Parse(temp.Remove(temp.Length - 2));

            
            if (stack + 1 <= privase)
            {
               
                temp2 -= items[constant[stack]].Price;
            }
            else
            {
                
                temp2 -= items[constant[stack + Posoflast]].Price;
                ++Posoflast;
            }
            privase = stack;


            Currentpay.Text = temp2.ToString() + " $";

            
        }

        private void RemoveAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult r = MessageBox.Show("Are you sure ?", "Alert !!!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (r == MessageBoxResult.Yes)
            {
                for (int i = cartlv.Items.Count - 1; i >= 0; --i)
                {
                    cartlv.Items.RemoveAt(i);
                }

                Capacity = 0;

                Currentpay.Text = "0 $";
            }
        }




    }


    public class Goods
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public int Price { get; set; }

        public string Pro1 { get; set; }

        public string Pro2 { get; set; }

        public TGoods Type { get; set; }
        
    }





}
