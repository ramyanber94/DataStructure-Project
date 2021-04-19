using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    class getMenus
    {
        public static void AbstractFactory()
        {
            Console.WriteLine("which Factory:");
            string phoneCategory = Console.ReadLine();

            PhoneFactory phoneFactory = PhoneFactory.getPhoneFactory(phoneCategory);

            Console.WriteLine("What is the type:");
            string type = Console.ReadLine();
            switch (type)
            {
                case "Mobile":
                    Mobile mobile = phoneFactory.getPhone();
                    Console.WriteLine(mobile.ModelName);
                    break;
                case "Tablet":
                    Tablet tablet = phoneFactory.getTablet();
                    Console.WriteLine(tablet.ModelName);
                    break;
                default:
                    break;
            }
        }
    }
}
