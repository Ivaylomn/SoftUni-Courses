namespace ConsoleApp1
{
    public class Song
    {
        private string name;
        private string time;
        private string type;

        public Song(string name, string time, string type)
        {
            Name = name;
            Time = time;
            Type = type;
        }


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Time
        {
            get => time;
            private set
            {
                time = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            private set
            {
                type = value;
            }
        }
    }
}
