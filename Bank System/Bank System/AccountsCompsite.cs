
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class AccountsCompsite
    {
        Dictionary<string , Account> accounts = new Dictionary<string, Account>();

        public void AddAccount(Account account , string id)
        {

            accounts.Add(id , account);
        }

        public Dictionary<string, Account> getAccount(string id)
        {
            Console.Write("Account Type: "+accounts[id].Name +" "+"Account balance: " + accounts[id].balance);
            return accounts;
        }
        public string getAccounts()
        {
            string msg = "";
            foreach (var account in accounts)
            {
                msg += "Account Type: " + account.Value.Name + " " + "Account balance: " + account.Value.balance;
            }
            return msg;
        }
    }
}
