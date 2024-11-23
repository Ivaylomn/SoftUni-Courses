namespace _03.WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTextPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\03. Word Count\text.txt";
            string inputWordsPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\03. Word Count\words.txt";
            string outputPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\03. Word Count\Output.txt";

            string alltext = File.ReadAllText(inputTextPath);
            string matchedWords = File.ReadAllText(inputWordsPath);

            string[] arrWords = matchedWords.Split();
            string[] arrText = alltext.Split();

            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (string word in arrWords)
            {
                if (!counter.ContainsKey(word))
                {
                    counter.Add(word, 0);
                }
            }

            foreach (var item in arrText)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
            }

            using StreamWriter writer = new StreamWriter(outputPath);
            foreach (var item in counter)
            {
                writer.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
