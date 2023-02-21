namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public string Call(string number)
        {
            return $"Dialing... {number}";
        }
    }
}
