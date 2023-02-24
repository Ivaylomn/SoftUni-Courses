using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (SumDividesEight(i) && HasOneOdd(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool SumDividesEight(int x)
        {
            string number = x.ToString();
            double sum = 0;
            foreach (var VARIABLE in number)
            {
                sum += (int)char.GetNumericValue(VARIABLE);
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasOneOdd(int x)
        {
            string number = x.ToString();
            foreach (var VARIABLE in number)
            {
                if ((int)char.GetNumericValue(VARIABLE) % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

