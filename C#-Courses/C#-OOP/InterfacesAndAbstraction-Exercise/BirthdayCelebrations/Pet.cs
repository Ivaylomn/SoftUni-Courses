namespace BirthdayCelebrations
{
    public class Pet : IBirthdate
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }

        public string Birthday { get; set; }
    }
}
