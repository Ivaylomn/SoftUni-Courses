namespace _02.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\02. Line Numbers\Input.txt";
            string outputPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\02. Line Numbers\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);
            using StreamWriter writer = new StreamWriter(outputPath);

            int count = 1;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                writer.WriteLine($"{count}. {line}");
                count++;
            }
        }
    }
}
