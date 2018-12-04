using System;

namespace General.Contracts
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
