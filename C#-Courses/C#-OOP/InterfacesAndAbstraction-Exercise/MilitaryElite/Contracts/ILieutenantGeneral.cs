using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ILieutenantGeneral
    {
        public ICollection<IPrivate> Privates { get; }
    }
}
