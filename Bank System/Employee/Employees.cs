using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Employees
    {
        public void getEmployees()
        {
            Hashtable peopleList = new Hashtable();
            peopleList["John Doe"] = new employee("416111111");
            peopleList["Jane Smith"] = new employee("647111111");
            peopleList["Will Hunt"] = new employee("4167777777");
            peopleList["David Cod"] = new employee("6475555555");
            Console.WriteLine("Name");
            foreach (DictionaryEntry item in peopleList)
            {
                Console.WriteLine(item.Key);
            }
            Console.Write("Enter a Name to find PhoneNo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Phone number of" + " " + name + " " + "is" + " " + peopleList[name]);
        }
    }
}
