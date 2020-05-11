using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreWPF
{
    

    abstract class Media
    {

        private string name;
        private int cost;
        private int id;
        public Media(string name,int cost,int id)
        {
            this.name = name;
            this.cost = cost;
            this.id = id;
        }

        public virtual int Tax()
        {
            return this.cost;
        }

        public double Outputcost()
        {
            double totaltax = (double)Tax();
            totaltax /= 100;
            totaltax = 1 + totaltax;

            return (cost * totaltax);
        }
    }
  
    class Books : Media
    {
        
        private string writer, publisher;
        public Books(string name, int cost, int id, string writer, string publisher) : base(name, cost, id)
        {
            this.writer = writer;
            this.publisher = publisher;
            
        }

        public override int Tax()
        {
            return 10;
        }
    }

    class Videos : Media
    {
        private int time, count;
        public Videos(string name, int cost, int id, string time, string count) : base(name, cost, id)
        {
            this.count = int.Parse(count);
            this.time = int.Parse(time);
        }

        public override int Tax()
        {
            int tax1 = (count * 3);
            int tax2 = ((time / 60) * 5);
            return (tax1 + tax2);
        }

        
    }

    class Magazines : Media
    {
        private string publisher;
        private int page;
      
        public Magazines(string name, int cost, int id, string publisher, string page) : base(name, cost, id)
        {
            this.page = int.Parse(page);
            this.publisher = publisher;
        }

        public override int Tax()
        {
            if (page >= 1 && page <= 20)
            {
                return 2;
            }
            else if (page >= 21 && page <= 50)
            {
                return 3;
            }
            else
            {
                return 5;
            }
        }
    }
}
