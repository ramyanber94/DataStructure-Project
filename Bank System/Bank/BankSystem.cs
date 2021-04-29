
using Bank_System;
using Container.Accounts;
using Stripe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container.Customers
{
    public static class BankSystem
    {
        
        private static Dictionary<string, CustomerAccount> customers = new Dictionary<string, CustomerAccount>();

        public static void createAccount(string customerID)
        {
            CustomerAccount customer;
            if (customers.ContainsKey(customerID))
            {
                customers.TryGetValue(customerID, out customer);
                Console.WriteLine("Welcome Mr/Miss "+customer.Name);
            }
            else {
                Console.WriteLine("Customer Name");
                string customerName = Console.ReadLine();
                Console.WriteLine("Date of birth");
                string dob = Console.ReadLine();
                customer = new CustomerAccount(customerName, customerID, dob);
                customers.Add(customerID,customer);
            }
            Bank_System.Account account;
            Console.WriteLine("Account ID");
            string accountId = Console.ReadLine();
            Console.WriteLine("Type of Account");
            string AccountName = Console.ReadLine();
            switch (AccountName)
            {
                case "debit":
                    account = AccountFactory.GetAccount(AccountName, accountId);
                    customer.Accounts.AddAccount(account);
                    break;
                case "credit":
                    account = AccountFactory.GetAccount(AccountName, accountId);
                    Console.WriteLine("Which type of credit you want? ");
                    string type = Console.ReadLine();
                    if (type.Equals("normal"))
                    {
                        account = AccountFactory.GetAccount(AccountName, accountId);
                    }
                    if (type.Equals("master"))
                    {
                        account = new MasterCard(accountId, type);
                    }
                    else
                    {
                        account = new VisaCard(accountId, type);
                    }
                    customer.Accounts.AddAccount(account);
                    break;
                case "saving":
                    account = AccountFactory.GetAccount(AccountName, accountId);
                    customer.Accounts.AddAccount(account);
                  
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.WriteLine(customer.Accounts.getAccount(accountId).Name + " Created successfully");
        }

        public static void getAccounts()
        {
            foreach (var user in customers.Values)
            {
                Console.WriteLine("Customer Name: " + user.Name + " , Customer ID: " + user.ID
                         + " , Day of brith: " + user.DOB + " , Cards : " + user.Accounts.getAccounts());
            }
        }
        public static void deposit()
        {
            Console.WriteLine("Enter Customer ID: ");
            string customerID = Console.ReadLine();
            if (customers.ContainsKey(customerID))
            {
                Console.WriteLine("Account ID");
                string AccountID = Console.ReadLine();
                Console.WriteLine("Ammount: ");
                string amount = Console.ReadLine();
                foreach (var item in customers.Values)
                {

                    if (item.Accounts.getAccount(AccountID) != null)
                    {
                        item.Accounts.getAccount(AccountID).deposit(Double.Parse(amount));
                    }
                }
            }
        }

        public static void withdraw()
        {
            Console.WriteLine("Enter Customer ID: ");
            string customerID = Console.ReadLine();
            if (customers.ContainsKey(customerID))
            {
                Console.WriteLine("Account ID");
                string AccountID = Console.ReadLine();
                Console.WriteLine("Ammount: ");
                string amount = Console.ReadLine();
                foreach (var item in customers.Values)
                {

                    if (item.Accounts.getAccount(AccountID) != null)
                    {
                        item.Accounts.getAccount(AccountID).withdraw(Double.Parse(amount));
                    }
                }
            }
        }
    }
}
