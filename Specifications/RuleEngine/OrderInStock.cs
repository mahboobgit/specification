using Specifications.Models;

namespace Specifications.RuleEngine
{
    public class OrderInStock : Specification<Order>
    {
        public override bool IsSatisfied(Order candidate)
        {
            return candidate.InStock;
        }
    }
}
