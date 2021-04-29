
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class AccountsCompsite
    {
        public List<Account> cards = new List<Account>();
  
        public void AddAccount(Account account)
        {

            cards.Add(account);
        }

        public Account getAccount(string id)
        {
            
            foreach (var item in cards)
            {
                if (id == item.id)
                { 
                    return item;
                }
            }

            return null;
        }
        public string getAccounts()
        {
            string msg = "";
            foreach (var card in cards)
            {
                msg += "\n Card type: " + card.Name + " , Card ID: " + card.id + " , Card balance: " + card.balance;
                
            }
            return msg;
        }
    }
}
