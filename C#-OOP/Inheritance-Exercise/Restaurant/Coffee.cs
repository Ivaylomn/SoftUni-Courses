namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) 
            : base(name, 3.50M, 30)
        {
            Caffeine = caffeine;  
        }

        public double Caffeine { get; set; }
    }
}
