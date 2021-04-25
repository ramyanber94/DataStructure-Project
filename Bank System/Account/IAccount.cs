using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Account
{
    interface IAccount
    {

        public bool deposit(double amount);

        public bool withdraw(double amount);
    }
}
