namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWords; i++)
            {
                string input = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (!keyValuePairs.ContainsKey(input))
                {
                    keyValuePairs.Add(input, new List<string>());
                }

                keyValuePairs[input].Add(synonyms);
            }

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
