using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string password = string.Empty;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            int counter = 0;
            string curentPasword = string.Empty;
            while (curentPasword != password)
            {
                curentPasword = Console.ReadLine();

                if (curentPasword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }

                counter++;

                if (counter > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
