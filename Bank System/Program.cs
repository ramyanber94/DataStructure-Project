using Bank_System.Account;
using Bank_System.Customer;
using System;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount customer = new CustomerAccount("Ramy" , "123" , "1994");

            AbstractAccount account = AccountFactory.GetAccount("credit", "123");
            account.deposit(1000);
            customer.Accounts.AddAccount(account, account.id);

            Console.WriteLine(customer.DOB + customer.Name + customer.ID + customer.Accounts.getAccount(account.id));
        }
    }
}
