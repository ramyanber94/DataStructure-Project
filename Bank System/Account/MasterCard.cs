using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Account
{
    class MasterCard : AccountDecorator
    {
        public MasterCard(string id , string name) : base(id , name)
        {
        }

        public override bool deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public AbstractAccount getMasterCard (Credit_card creditAccount)
        {
            if(creditAccount.id == id)
            {
                creditAccount.dailyWithdrawLimit += 100000;
                return creditAccount;
            }
            else
            {
                return null;
            }

        }
    }
}
