using Microsoft.Win32.SafeHandles;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
            foreach (var item in numbers)
            {
                if (!item.All(i => char.IsDigit(i)))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                if (item.Length == 10)
                {
                    ISmartphone smartphone = new Smartphone();
                    Console.WriteLine(smartphone.Call(item));
                }
                else if (item.Length == 7)
                {
                    IStationaryPhone stationaryPhone = new StationaryPhone();
                    Console.WriteLine(stationaryPhone.Call(item));
                }
            }

            foreach (var web in websites)
            {
                if (web.Any(w => char.IsDigit(w)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                ISmartphone smartphone = new Smartphone();
                Console.WriteLine(smartphone.Browses(web));
            }
        }
    }
}
