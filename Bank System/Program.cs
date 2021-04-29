using System;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****  Welcome to Bank Management System  ***");
            int opt = 1;
            MenuGenrator menus = new MenuGenrator();
            do
            {
                Console.WriteLine("\nWhat you want to do:");
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Deposit from account");
                Console.WriteLine("3. Withdraw from account");
                Console.WriteLine("4. Show all account with id");
                Console.WriteLine("5. Contact US");
                Console.WriteLine("6. Clear screen");
                Console.WriteLine("0. Exit");
                string input = (Console.ReadLine());
                try
                {
                    opt = Int32.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Invalid option {input} selected.");
                }
                switch (opt)
                {
                    case 1:
                        menus.createAccount();
                        break;
                    case 2:
                        menus.deposit();
                        break;
                    case 3:
                        menus.withdraw();
                        break;
                    case 4:
                        menus.showAllData();
                        break;
                    case 5:
                        menus.contactUS();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    default:

                        break;
                }
            } while (opt != 0);
        }
    }
}
