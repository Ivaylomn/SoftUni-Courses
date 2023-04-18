using MilitaryElite.Contracts;
using MilitaryElite.Enums;

namespace MilitaryElite.Models
{
    public class Mission : IMissions
    {
        public string CodeName { get; }

        public StateEnum State { get; }

        public void CompleteMission()
        {
            throw new System.NotImplementedException();
        }
    }
}
