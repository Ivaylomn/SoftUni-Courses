using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, CorpEnum corp, ICollection<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corp)
        {
            Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }
    }
}
