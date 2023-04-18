using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public string PartName { get; }

        public int Worked { get; }
    }
}
