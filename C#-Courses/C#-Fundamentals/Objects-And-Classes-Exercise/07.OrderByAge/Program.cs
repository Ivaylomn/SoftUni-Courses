using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    public class Person
    {
        public Person(string name, string idNumber, int age)
        {
            Name = name;
            IdNumber = idNumber;
            Age = age;
        }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {IdNumber} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPerson = new List<Person>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] personInfo = command.Split();

                Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                allPerson.Add(person);

                command = Console.ReadLine();
            }

            foreach (var item in allPerson.OrderBy(p => p.Age))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
