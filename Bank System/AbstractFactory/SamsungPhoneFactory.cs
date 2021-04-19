namespace Bank_System
{
    internal class SamsungPhoneFactory : PhoneFactory
    {
        internal override Mobile getPhone()
        {
            return new SamsungMobile("Samsung Phone");
        }

        internal override Tablet getTablet()
        {
            return new SamsungTablet("Samsung tablet");
        }
    }
}