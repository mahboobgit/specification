using System;
namespace Specifications.Framework
{
    public class NotSpecification<T> : Specification<T>
    {
        ISpecification<T> _entity;

        public NotSpecification(ISpecification<T> entity)
        {
            _entity = entity;
        }

        public override bool IsSatisfied(T candidate)
        {
            return !_entity.IsSatisfied(candidate);
        }
    }
}
