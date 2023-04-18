namespace Telephony
{
    public class Smartphone : ISmartphone
    {

        public string Browses(string website)
        {
            return $"Browsing: {website}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
