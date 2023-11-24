using System.Runtime.CompilerServices;

namespace _07.VehicleCatalogue
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split("/");

                string brand = commandArgs[1];
                string model = commandArgs[2];

                if (commandArgs[0] == "Car")
                {
                    int horsePower = int.Parse(commandArgs[3]);
                    Car car = new Car()
                    {
                        Model = model,
                        Brand = brand,
                        HorsePower = horsePower
                    };

                    catalog.Cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(commandArgs[3]);
                    Truck truck = new Truck()
                    {
                        Model = model,
                        Brand = brand,
                        Weight = weight
                    };

                    catalog.Trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            foreach (var car in catalog.Cars.OrderBy(c => c.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine(catalog.Trucks.Count > 0 ? "Trucks:" : "");
            foreach (var truck in catalog.Trucks.OrderBy(t => t.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
