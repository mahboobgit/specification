using System;
namespace Specifications.Framework
{
    public class OrSpecification<T>: CompositeSpecification<T>
    {
        public OrSpecification(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsSatisfied(T candidate)
        {
            return _left.IsSatisfied(candidate) || _right.IsSatisfied(candidate);
        }
    }
}
