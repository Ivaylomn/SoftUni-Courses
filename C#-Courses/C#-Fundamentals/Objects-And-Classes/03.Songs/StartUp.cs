namespace Songs
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_");
                string name = input[1];
                string time = input[2];
                string type = input[0];

                Song song = new(name, time, type);

                songs.Add(song);
            }
            
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in songs.Where(x => x.Type == typeList))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }

    }
}