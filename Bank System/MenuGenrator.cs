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
        public Employees employees = new Employees();
        public void createAccount()
        { 
            Console.WriteLine("Customer ID");
            string customerID = Console.ReadLine();
            BankSystem.createAccount(customerID);
        }

        public void showAllData()
        {
            BankSystem.getAccounts();
        }


        public void deposit()
        {
            BankSystem.deposit();
        }

        public void withdraw()
        {
            BankSystem.withdraw();
        }
        public void contactUS()
        {
            employees.getEmployees();
        }
    }
}
