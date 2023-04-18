using System;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;  
        }

        public string Name { get; private set; }

        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("Name: {0}, Age: {1}", Name, Age));

            return sb.ToString().TrimEnd();
        }
    }
}
