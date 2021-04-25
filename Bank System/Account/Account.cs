using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Account
{
    abstract class AbstractAccount : IAccount
    {
        public double ammount { get; set; }
        public double balance { get; set; }
        public  string id { get; internal set; }
        public string Name { get; set; }

        public AbstractAccount(string id , string name)
        {
            this.id = id;
            this.Name = name;
        }

        public abstract bool deposit(double amount);

        public bool withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
