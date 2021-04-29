
using Bank_System;
using Container.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class MasterCard : AccountDecorator
    {
        public double minBalance = -5000000;
        public double dailyWithdrawLimit = 70000;
        public MasterCard(string id , string name) : base(id , name)
        {
        }

        public override bool deposit(double amount)
        {
            this.ammount = amount;
            this.balance = balance + ammount;
            Console.WriteLine("You account balance has been deposited.Balance is: " + balance);
            return true;
        }

        public Account getMasterCard (Credit_card creditAccount)
        {
            if(creditAccount.id == id)
            {
                creditAccount.dailyWithdrawLimit += 100000;
                return creditAccount;
            }
            else
            {
                return null;
            }

        }

        public override bool withdraw(double amount)
        {
            this.ammount = amount;
            if (amount < this.minBalance)
            {
                Console.WriteLine("Your Account don't have sufficient ammount of money!");
                return false;
            }
            else if (amount > dailyWithdrawLimit)
            {
                Console.WriteLine("You can not withdraw more than 20000.");
                return false;
            }
            else
            {
                this.balance = balance - ammount;
                Console.WriteLine("You account balance has been withdrawed.Balance is: " + balance);
                return true;
            }
        }
    }
}
