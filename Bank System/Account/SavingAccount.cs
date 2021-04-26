using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Saving_Account : Account
    {

        public Saving_Account(string id ,string name) : base(id,name) {
            name = "saving";
        }
   

        public override bool deposit(double amount)
        {
            this.ammount = amount;
            this.balance = balance + ammount;
            Console.WriteLine("You account balance has been deposited.Balance is: " + balance);
            return true;
        }

        public override bool withdraw(double amount)
        {
            this.ammount = amount;
            this.balance = balance - ammount;
            Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);
            return true;
        }
    }
}
