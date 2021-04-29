
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
        private static Dictionary<CustomerAccount, object> userAccount = new Dictionary<CustomerAccount, object>();
        private static Hashtable personCards = new Hashtable();
        private static List<Bank_System.Account> cards = new List<Bank_System.Account>();
        private static CustomerAccount customer = new CustomerAccount();

        public static void createAccount(string accountId , string AccountName , string customerName , string customerID , string DOB)
        {
            customer = new CustomerAccount(customerName, customerID, DOB);
            Bank_System.Account account;
            switch (AccountName)
            {
                case "debit":
                    account = AccountFactory.GetAccount("debit", accountId);
                    customer.Accounts.AddAccount(account , accountId);
                    break;
                case "credit":
                    account = new Credit_card(accountId, "credit");
                    Console.WriteLine("Which type of credit you want? ");
                    string type = Console.ReadLine();
                    if (type.Equals("Master"))
                    {
                        account = new Accounts.MasterCard(accountId, "Master");
                        cards.Add(account);
                        foreach (var c in cards)
                        {
                            customer.Accounts.AddAccount(c, accountId);
                        }
                    }
                    else
                    {
                        account = new VisaCard(accountId, "Visa");                 
                        customer.Accounts.AddAccount(account, accountId);
                        
                    }
                    break;
                case "saving":
                    account = AccountFactory.GetAccount("saving", accountId);
                    cards.Add(account);
                    foreach (var c in cards)
                    {
                        customer.Accounts.AddAccount(c, accountId);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            userAccount.Add(customer, cards);
        }

        public static void getAccounts()
        {
            foreach (var user in userAccount)
            {
                Console.WriteLine($"{user.Key.ToString()} , {user.Key.Accounts.getAccounts()}");
            }
        }
        public static void deposit(string id , double ammount)
        {
            foreach (var item in customer.Accounts.getAccount(id))
            {
                item.Value.deposit(ammount);
            }
            
        }

        public static void withdraw(string id , double ammount)
        {
            foreach (var item in customer.Accounts.getAccount(id))
            {
                item.Value.withdraw(ammount);
            }
        }
        public static void getAccount(string id)
        {
            foreach (var user in userAccount)
            {
                Console.WriteLine($"{user.Key.ToString()} , {user.Key.Accounts.getAccount(id)}");
            }

        }
    }
}
