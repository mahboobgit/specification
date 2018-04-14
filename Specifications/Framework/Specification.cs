using System;
namespace Specifications
{
    public abstract class Specification<T> : ISpecification<T>
    {

        public abstract bool IsSatisfied(T candidate);


        public ISpecification<T> And(ISpecification<T> entity)
        {
            return new AndSpecification<T>(this, entity);
        }

       
        public ISpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> entity)
        {
            return new OrSpecification<T>(this, entity);
        }
    }
}
