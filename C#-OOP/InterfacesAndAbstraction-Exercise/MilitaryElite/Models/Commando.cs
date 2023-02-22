using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System.Collections.Generic;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, CorpEnum corp, ICollection<IMissions> missions) 
            : base(id, firstName, lastName, salary, corp)
        {
            Missions = missions; 
        }

        public ICollection<IMissions> Missions { get; }
    }
}
