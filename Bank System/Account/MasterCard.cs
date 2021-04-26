using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
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

        public Account getMasterCard (Credit_card creditAccount)
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

        public override bool withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
