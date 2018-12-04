using System;

namespace General.Contracts
{
    public interface IBuilder<Tin,Tout>
    {
        Tout Build(Tin input);
    }
}
