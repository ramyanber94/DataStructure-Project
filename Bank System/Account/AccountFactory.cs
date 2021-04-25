using Bank_System.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Account
{
    class AccountFactory
    {
        internal static AbstractAccount GetAccount(string type , string id)
        {
                AbstractAccount model;
                switch (type)
                {
                    case "debit":
                        model = new DebitCard(id , "debit");
                        break;
                    case "credit":
                        model = new Credit_card(id, "credit");
                        break;
                    case "saving":
                        model = new Saving_Account(id , "saving");
                        break;
                    default:
                        model = new Saving_Account(id , "saving");
                        break;
                }
            return model;
        }
            
        }
    }

