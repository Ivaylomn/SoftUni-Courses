using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface IEngineer
    {
        public ICollection<IRepair> Repairs { get; }
    }
}
