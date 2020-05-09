using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnlineStoreWPF
{
    public abstract class Reapeted
    {
        private string name;
        private string id;

        public string ID
        {
            get
            {
                return this.id;
            }
            protected set
            {
                this.id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }

        protected void addtolist(string username, string password, string type)
        {
            DateTime today = DateTime.Now;
            today.ToString("yyyy-MM-dd_HH:mm:ss");

            string path = Extention.path;
            path += @"\USERPanel\Customer Info.txt";
            File.AppendAllText(path, type + "   " + today + Environment.NewLine + username + Environment.NewLine + password + Environment.NewLine + Environment.NewLine);
        }

        public virtual int SpecialOff(int count)
        {
            return 0;
        }

    }

    public class Student : Reapeted
    {
        public Student(string name,string id)
        {
            Name = name;
            ID = id;
            addtolist(name, id, "Student");
        }

        public override int SpecialOff(int count)
        {
            return 20;
        }

    }

    public class Teacher : Reapeted
    {
        public int hell = 0;
        public Teacher(string name, string id)
        {
            Name = name;
            ID = id;
            addtolist(name, id, "Teacher");
        }

        public override int SpecialOff(int count)
        {
            if (count >= 3)
            {
                return 15;
            }
            else
            {
                return 0;
            }
        }


    }

    public class Customer : Reapeted
    {
        public Customer(string name, string id)
        {
            Name = name;
            ID = id;
            addtolist(name, id, "Customer");
        }

        public override int SpecialOff(int count)
        {
            if (count >= 5)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
    }

}
