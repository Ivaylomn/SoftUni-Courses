using Cars.Contracts;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; }
        public string Color { get; }
        public int Battery { get; }

        public string Start()
            => "Engine start";

        public string Stop()
            => "Breaaaak!";

        public override string ToString() 
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{Color} {GetType().Name} {Model} with {Battery} Batteries");
            stringBuilder.AppendLine(Start());
            stringBuilder.AppendLine(Stop());

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
