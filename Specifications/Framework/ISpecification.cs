using System;
namespace Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T candidate);

        ISpecification<T> And(ISpecification<T> entity);

        ISpecification<T> Or(ISpecification<T> entity);

        ISpecification<T> Not();
    }
}
    