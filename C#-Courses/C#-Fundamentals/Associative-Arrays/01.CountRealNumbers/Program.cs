using System.Collections.Immutable;

namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, double> keyValuePairs = new SortedDictionary<double, double>();

            foreach (var item in numbers)
            {
                if (!keyValuePairs.ContainsKey(item)) 
                {
                    keyValuePairs.Add(item, 0);
                }

                keyValuePairs[item]++;
            }

            foreach (var pair in keyValuePairs) 
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
