using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentity> identities = new List<IIdentity>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitedCommand = command.Split();

                if (splitedCommand.Length == 3)
                {
                    string name = splitedCommand[0];
                    int age = int.Parse(splitedCommand[1]);
                    string id = splitedCommand[2];

                    Citizen citizen = new Citizen(name, age, id);

                    identities.Add(citizen);
                }
                else if (splitedCommand.Length == 2)
                {
                    Robot robot = new Robot(splitedCommand[0], splitedCommand[1]);

                    identities.Add(robot);
                }

                command = Console.ReadLine();
            }

            string lastThreeNumbers = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var identity in identities)
            {
                string id = identity.Id;
                string currentLastThreElements = id.Substring(id.Length - lastThreeNumbers.Length, lastThreeNumbers.Length);

                if (currentLastThreElements == lastThreeNumbers)
                {
                    sb.AppendLine(id);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
