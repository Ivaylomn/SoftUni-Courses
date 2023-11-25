
namespace TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end") 
            {
                //Reversed with LINQ
                //string reversedWord = new string (input.Reverse().ToArray());

                string reversedWord = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedWord += input[i];
                }

                Console.WriteLine($"{input} = {reversedWord}");

                input = Console.ReadLine();
            }
        }
    }
}
