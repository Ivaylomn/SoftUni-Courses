namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> truckTour = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] petrolInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

                truckTour.Enqueue(petrolInfo);
                //or.
                //truckTour.Enqueue(new int[] {petrolInfo[0], petrolInfo[1]});
            }

            int startIndex = 0;

            while (true)
            {
                int currentPetrol = 0;

                foreach (var item in truckTour)
                {
                    int truckPetrol = item[0];
                    int truckDistance = item[1];

                    currentPetrol += truckPetrol;
                    currentPetrol -= truckDistance;

                    if (currentPetrol < 0)
                    {
                        int[] element = truckTour.Dequeue();
                        truckTour.Enqueue(element);
                        startIndex++;
                        break;
                    }
                }

                if (currentPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }

            }
        }
    }
}