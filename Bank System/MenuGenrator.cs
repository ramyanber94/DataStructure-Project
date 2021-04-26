using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class MenuGenrator
    {
        public void createAccount()
        {
            Console.WriteLine("Customer Name");
            string customerName = Console.ReadLine();
            Console.WriteLine("Date of birth");
            string dob = Console.ReadLine();
            Console.WriteLine("Account ID");
            string AccountID = Console.ReadLine();
            Console.WriteLine("Type of Account");
            string AccountName = Console.ReadLine();
            Console.WriteLine("Customer ID");
            string customerID = Console.ReadLine();
            BankSystem.BankSystem.createAccount(AccountID, AccountName, customerName, customerID, dob);
        }

        public void showAllData()
        {
            BankSystem.BankSystem.getAccounts();
        }

        public void deposit()
        {
            Console.WriteLine("Account ID");
            string AccountID = Console.ReadLine();
            Console.WriteLine("Ammount: ");
            string amount = Console.ReadLine();
            BankSystem.BankSystem.deposit(AccountID, Double.Parse(amount));
        }
    }
}
