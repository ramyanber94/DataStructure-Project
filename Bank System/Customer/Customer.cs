using Bank_System.Bank_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System.Customer
{
    class CustomerAccount
    {
       
        public string Name { get; set; }
        public string ID { get; set; }
        public string DOB { get; set; }
        public AccountsCompsite Accounts = new AccountsCompsite();
        public CustomerAccount()
        {
        }

        public CustomerAccount(string name, string id, string dob)
        {
            this.Name = name;
            this.ID = id;
            this.DOB = dob;
        }
        
    }
}
