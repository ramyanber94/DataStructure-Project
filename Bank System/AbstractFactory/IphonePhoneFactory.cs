namespace Bank_System
{
    internal class IphonePhoneFactory : PhoneFactory
    {
        internal override Mobile getPhone()
        {
            return new IphoneMobile("Iphone mobile");
        }

        internal override Tablet getTablet()
        {
            return new IphoneTablet("Iphone tablet");
        }
    }
}