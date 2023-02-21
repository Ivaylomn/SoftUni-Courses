using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthdate> birthdates = new List<IBirthdate>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitedCommand = command.Split();

                if (splitedCommand[0] == "Citizen")
                {
                    Citizen citizen = new Citizen(splitedCommand[1], int.Parse(splitedCommand[2]),
                                                  splitedCommand[3], splitedCommand[4]);

                    birthdates.Add(citizen);
                }
                else if (splitedCommand[0] == "Pet")
                {
                    Pet pet = new Pet(splitedCommand[1], splitedCommand[2]);

                    birthdates.Add(pet);
                }
                else if (splitedCommand[0] == "Robot")
                {
                    Robot robot = new Robot(splitedCommand[1], splitedCommand[2]);
                }

                command = Console.ReadLine();
            }

            string year = Console.ReadLine();

            foreach (var birthdate in birthdates)
            {
                if (birthdate.Birthday.EndsWith(year))
                {
                    Console.WriteLine(birthdate.Birthday);
                }
            }
        }
    }
}
