using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account : IAccount
    {
        public double ammount { get; set; }
        public double balance { get; set; }
        public  string id { get; internal set; }
        public string Name { get; set; }

        public Account(string id , string name)
        {
            this.id = id;
            this.Name = name;
        }

        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);
    }
}
