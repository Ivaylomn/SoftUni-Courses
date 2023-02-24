namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValidPassword = true;

            if (!PasswordLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValidPassword = false;
            }

            if (ConsistOfLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValidPassword = false;
            }

            if (!ContainsDigitCount(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValidPassword = false;
            }

            if (isValidPassword)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsDigitCount(string password, int count)
        {
            int digitCount = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;

                    if (digitCount == count)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool ConsistOfLettersAndDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool PasswordLenght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}