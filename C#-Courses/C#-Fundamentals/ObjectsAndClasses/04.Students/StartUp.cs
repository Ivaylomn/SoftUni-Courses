namespace _04.Students
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                string firstName = commandArgs[0];
                string lastName = commandArgs[1];
                int age = int.Parse(commandArgs[2]);
                string homeTown = commandArgs[3];

                Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student(firstName, lastName, age, homeTown));
                }
                else
                {
                    student.Age = age;
                }

                command = Console.ReadLine();
            }

            string city = Console.ReadLine();

            List<Student> filteredStudents = students.Where(x => x.HomeTown == city).ToList();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        public class Student
        {
            public Student(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
