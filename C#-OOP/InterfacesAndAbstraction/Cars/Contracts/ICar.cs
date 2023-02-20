namespace Cars.Contracts
{
    public interface ICar
    {
        public string Model { get; }

        public string Color { get; }

        string Start();

        string Stop();
    }
}
