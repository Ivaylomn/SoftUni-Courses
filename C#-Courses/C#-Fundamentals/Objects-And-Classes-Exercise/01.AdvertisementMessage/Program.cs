namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<string> phrase = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.",
                    "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int a = rnd.Next(phrase.Count - 1);
                int b = rnd.Next(phrase.Count - 1);
                int c = rnd.Next(phrase.Count - 1);
                int e = rnd.Next(phrase.Count - 1);

                Console.WriteLine($"{phrase[a]} {events[b]} {authors[c]} {cities[e]}");
            }
        }
    }
}