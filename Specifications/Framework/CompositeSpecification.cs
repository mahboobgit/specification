using System;
namespace Specifications
{
    public abstract class CompositeSpecification<T> : Specification<T> 
    {


        protected ISpecification<T> _left;

        protected ISpecification<T> _right;

        public CompositeSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }
    }
}
