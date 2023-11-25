namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digit = "";
            string letter = "";
            string other = "";
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    digit += item;
                }
                else if (char.IsLetter(item)) 
                {
                    letter += item;
                }
                else
                {
                    other += item;
                }
            }

            Console.WriteLine(digit);
            Console.WriteLine(leter);
            Console.WriteLine(other);
        }
    }
}
