using MilitaryElite.Enums;

namespace MilitaryElite.Contracts
{
    public interface IMissions
    {
        public string CodeName { get; }

        public StateEnum State { get; }

        void CompleteMission();
    }
}
