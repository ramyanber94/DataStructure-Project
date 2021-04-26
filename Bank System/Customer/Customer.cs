using Bank_Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Customer
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

        public override string ToString()
        {
            return "Customer Name: "+Name+" "+ "Customer ID: " + ID+" "+ "Date of birth: " + DOB;
        }
    }
}
