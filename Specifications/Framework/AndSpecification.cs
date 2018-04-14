using System;
namespace Specifications
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(ISpecification<T> left, ISpecification<T> right) : base(left, right) 
        {
        }

        public override bool IsSatisfied(T candidate)
        {
            return _left.IsSatisfied(candidate) && _right.IsSatisfied(candidate);
        }
    }
}
