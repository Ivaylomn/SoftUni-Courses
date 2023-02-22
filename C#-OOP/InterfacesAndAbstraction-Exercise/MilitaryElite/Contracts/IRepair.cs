namespace MilitaryElite.Contracts
{
    public interface IRepair
    {
        public string PartName { get; }

        public int Worked { get; }
    }
}
