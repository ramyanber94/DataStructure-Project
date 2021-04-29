using Container.Customers;
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
            BankSystem.createAccount(AccountID, AccountName, customerName, customerID, dob);
        }

        public void showAllData()
        {
            BankSystem.getAccounts();
        }

        public void showAccount()
        {
            Console.WriteLine("Enter the account ID: ");
            string id = Console.ReadLine();
            BankSystem.getAccount(id);
        }

        public void deposit()
        {
            Console.WriteLine("Account ID");
            string AccountID = Console.ReadLine();
            Console.WriteLine("Ammount: ");
            string amount = Console.ReadLine();
            BankSystem.deposit(AccountID, Double.Parse(amount));
        }

        public void withdraw()
        {
            Console.WriteLine("Account ID");
            string AccountID = Console.ReadLine();
            Console.WriteLine("Ammount: ");
            string amount = Console.ReadLine();
            BankSystem.withdraw(AccountID, Double.Parse(amount));
        }
    }
}
