using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class employee
    {
 
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public employee(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"{PhoneNumber}";
        }

    }
}
