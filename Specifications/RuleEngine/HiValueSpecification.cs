using System;
using Specifications.Models;

namespace Specifications.RuleEngine
{
    public class HiValueSpecification : Specification<Order>
    {
        
        public override bool IsSatisfied(Order candidate)
        {
            return candidate.TotalAmount > 100;
        }
    }
}
