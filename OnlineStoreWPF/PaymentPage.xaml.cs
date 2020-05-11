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
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Window
    {
        public List<Goods> Fitem;

        public Reapeted TypeOfCustomer;
        public PaymentPage(Reapeted obj)
        {
            InitializeComponent();

            Fitem = new List<Goods>();

            TypeOfCustomer = obj;

        }

        private void backbtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        bool flag = true;
        int stackchance = 0;
        private void chancebtn_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                flag = false;
                int[] chance = { 0, 2, 3, 5, 7, 10, 15, 25, 30 };
                Random r = new Random();
                
                int temp = int.Parse(Offbox.Text.Remove(Offbox.Text.Length-2));

                stackchance = chance[r.Next(9)];
                temp += stackchance;

                Offbox.Text = temp.ToString() + " %";

                double newprice = double.Parse(taxpay.Text.Remove(taxpay.Text.Length - 1));

                newprice *= (100 - temp);
                newprice /= 100;

                finalpay.Text = newprice.ToString() + " $";

            }
            else
            {
                string message = "Sorry !!! you have tried your chance recently and got " + stackchance + " percent off .";
                MessageBox.Show(message, "Ops !!!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FinalList.Items.Count != 0)
            {
                MessageBoxResult r = MessageBox.Show("Are you sure ?", "Finish the shoping .", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (r == MessageBoxResult.Yes)
                {
                    EndOfBuy EWin = new EndOfBuy();

                    EWin.Totalpay.Text = finalpay.Text;

                    EWin.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Your cart is empty .", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }



        public void Calculate()
        {
            Books b;
            Videos v;
            Magazines m;

            double OutputPrice = 0;


            for(int i = 0; i < Fitem.Count; ++i)
            {
                TGoods temp = Fitem[i].Type;

                if (temp == TGoods.Books)
                {
                    b = new Books(Fitem[i].Name, Fitem[i].Price, Fitem[i].ID, Fitem[i].Pro1, Fitem[i].Pro2);

                    OutputPrice += b.Outputcost();
                }
                else if (temp == TGoods.Videos)
                {
                    string x = Fitem[i].Pro1;
                    string y = Fitem[i].Pro2;

                    x = x.Remove(x.Length - 4);
                    y = y.Remove(y.Length - 4);

                    
                    v = new Videos(Fitem[i].Name, Fitem[i].Price, Fitem[i].ID, x, y);

                    OutputPrice += v.Outputcost();
                }
                else
                {
                    string y = Fitem[i].Pro2;
                    y = y.Remove(y.Length - 5);

                    m = new Magazines(Fitem[i].Name, Fitem[i].Price, Fitem[i].ID, Fitem[i].Pro1, y);

                    OutputPrice += m.Outputcost();
                }

            }

            double TP = double.Parse(totalpay.Text.Remove(totalpay.Text.Length - 1));

            taxpay.Text = OutputPrice.ToString() + " $";

            int tempoff = TypeOfCustomer.SpecialOff(Fitem.Count);

            double FNpay = ((double)((100 - tempoff) * OutputPrice) / 100);

            finalpay.Text = FNpay.ToString() + " $";


            Offbox.Text = tempoff.ToString() + " %";


        }

    }
}
