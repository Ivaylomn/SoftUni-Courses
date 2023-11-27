using System.Text.RegularExpressions;
using System.Xml;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}\b";



            var matchedFhone = Regex.Matches(input, pattern);

            var phoneMatches = matchedFhone
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
