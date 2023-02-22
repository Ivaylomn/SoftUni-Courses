using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ICommando
    {
        public ICollection<IMissions> Missions { get; }
    }
}
