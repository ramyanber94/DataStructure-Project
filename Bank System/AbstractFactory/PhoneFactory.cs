using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    internal abstract class PhoneFactory
    {
        public static PhoneFactory getPhoneFactory(string phoneCategory)
        {
            if (phoneCategory.Equals("Nokia")) return new NokiaPhoneFactory();
            if (phoneCategory.Equals("Samsung")) return new SamsungPhoneFactory();
            if (phoneCategory.Equals("Iphone")) return new IphonePhoneFactory();
            else return null;
        }
        internal abstract Mobile getPhone();
        internal abstract Tablet getTablet();
    }
}
