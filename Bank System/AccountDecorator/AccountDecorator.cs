
using Bank_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container.Accounts
{
    abstract class AccountDecorator : Account
    {
            protected Credit_card account;

            public AccountDecorator(string id, string name) : base(id, name) { }
            public Account getCredit(Credit_card account)
            {
                this.account = account;
                return account;
            }
    }
}
