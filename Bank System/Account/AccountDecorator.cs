using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Account
{
    abstract class AccountDecorator : AbstractAccount
    {
        protected Credit_card account;

        public AccountDecorator(string id , string name) : base(id , name) { }
        public AbstractAccount getCredit(Credit_card account) {
            return account;
        } 
    }
}
