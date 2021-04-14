using System;
using System.Collections.Generic;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# tutorial");
            Console.WriteLine("Facade press 1");
            Console.WriteLine("Abstract Factory press 2");
            Console.WriteLine("Adapter press 3");
            Console.WriteLine("Prototype press 4");
            Console.WriteLine("Singleton press 5");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Welcome Facade");
                    break;
                case "2":
                    Console.WriteLine("Welcome Abstract Factory");
                    break;
                case "3":
                    Console.WriteLine("Welcome Adapter");
                    break;
                case "4":
                    Console.WriteLine("Welcome Prototype");
                    break;
                case "5":
                    Console.WriteLine("Welcome Singleton");
                    break;
                default:
                    break;

            }
        }
    }
}
