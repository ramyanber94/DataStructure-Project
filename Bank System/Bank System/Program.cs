using System;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the bank system");
            Console.WriteLine("Front Desk press 1");
            Console.WriteLine("User press 2");
            Console.WriteLine("Employee press 3");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("welcome front desk");
                    Class1 front = new Class1();
                    front.getFrontDeskMenu();
                    break;
                case "2":
                    Console.WriteLine("wlecome user");
                    break;
                case "3":
                    Console.WriteLine("welcome Employee");
                    break;
                default:
                    break;

            }
        }
    }
}
