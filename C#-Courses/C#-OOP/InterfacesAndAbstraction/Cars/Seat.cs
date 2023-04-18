using Cars.Contracts;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; }
        public string Color { get; }

        public string Start()
            => "Engine start";

        public string Stop()
            => "Breaaaak!";

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{Color} {GetType().Name} {Model}");
            stringBuilder.AppendLine(Start());
            stringBuilder.AppendLine(Stop());

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
