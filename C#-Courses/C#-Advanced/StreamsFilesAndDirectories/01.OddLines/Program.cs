namespace _01.OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\01. Odd Lines\Input.txt";
            string outputPath = @"D:\Ivaylo\C#-Basics_06_24\C#-Advanced\File-Streams-And-Directories\Resources\01. Odd Lines\Output.txt";

            using StreamReader sr = new StreamReader(inputPath);
            using StreamWriter sw = new StreamWriter(outputPath);

            int index = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (index % 2 == 1)
                {
                    sw.WriteLine(line);
                }

                index++;
            }
        }
    }
}
