using MilitaryElite.Contracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] splitedInput = input.Split();
                int id = int.Parse(splitedInput[1]);
                string firstName = splitedInput[2];
                string lastName = splitedInput[3];

                if (splitedInput[0] == "Private")
                {
                    decimal salary = decimal.Parse(splitedInput[4]);
                    Private @private = new Private(id, firstName, lastName, salary);

                    soldiers.Add(@private);
                }
                else if (splitedInput[0] == "Spy")
                {
                    int codeNumber = int.Parse(splitedInput[4]);
                    Spy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(spy);
                }
                else if (splitedInput[0] == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(splitedInput[4]);



                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary,);
                }

                input = Console.ReadLine();
            }
        }
    }
}
