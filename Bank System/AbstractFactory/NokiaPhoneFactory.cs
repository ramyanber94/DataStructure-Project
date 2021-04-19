namespace Bank_System
{
    internal class NokiaPhoneFactory : PhoneFactory
    {
        internal override Mobile getPhone()
        {
            return new NokiaMobile("Nokia Phone");
        }

        internal override Tablet getTablet()
        {
            return new NokiaTablet("Nokia tablet");
        }
    }
}