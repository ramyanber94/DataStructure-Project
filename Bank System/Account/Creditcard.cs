﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Credit_card : Account
    {
        public double minBalance = -100000;
        public double dailyWithdrawLimit = 20000;

        public Credit_card(string id , string name) : base(id , name) {
            name = "credit";
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
