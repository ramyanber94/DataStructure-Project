using Bank_System.Account;
using Bank_System.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Bank_System
{
    class AccountsCompsite 
    {
        Dictionary<string , AbstractAccount> accounts = new Dictionary<string , AbstractAccount>();

        public void AddAccount(AbstractAccount account , string id)
        {
            accounts.Add(id , account);
        }

        public string getAccount(string id)
        {
            return accounts[id].Name;
        }
    }
}
