using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, CorpEnum corp) 
            : base(id, firstName, lastName, salary)
        {
            Corp = corp;
        }

        public CorpEnum Corp { get; }
    }
}
