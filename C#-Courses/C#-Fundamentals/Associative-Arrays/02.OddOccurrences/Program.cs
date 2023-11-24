namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            foreach (var key in input) 
            {
                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs.Add(key, 0);
                }

                keyValuePairs[key]++;
            }

            foreach (var keyValue in keyValuePairs) 
            {
                if (keyValue.Value % 2 == 1)
                {
                    Console.Write(keyValue.Key + " ");
                }
            }
        }
    }
}
