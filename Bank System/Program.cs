using System;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            MenuGenrator menu = new MenuGenrator();
            Console.WriteLine("****  Welcome to Bank Management System  ***");
            while (true)
            {
                Console.WriteLine("\nWhat you want to do:");
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Show account information");
                Console.WriteLine("3. Deposit from account");
                Console.WriteLine("4. Withdraw from account");
                Console.WriteLine("5. Show all account with id");
                Console.WriteLine("6. Contact US");
                Console.WriteLine("7. Clear screen");
                Console.WriteLine("0. Exit");
                object ob1 = Console.ReadLine();
                input = Convert.ToString(ob1);

                if (input == "1")
                {
                    menu.createAccount();
                }
                else if (input == "2")
                {
                    menu.showAccount();
                }
                else if (input == "3")
                {
                    menu.deposit();
                }
                else if (input == "4")
                {
                    menu.withdraw();
                }
                else if (input == "5")
                {
                    menu.showAllData();
                }
                else if (input == "6")
                {
                    Employees employees = new Employees();
                    employees.getEmployees();
                }
                else if (input == "7")
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();


            
            
            }
        }
    }
}
