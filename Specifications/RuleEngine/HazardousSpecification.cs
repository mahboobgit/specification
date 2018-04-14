using Specifications.Models;
namespace Specifications.RuleEngine
{
    public class HazardousSpecification : Specification<Order>
    {
        public override bool IsSatisfied(Order candidate)
        {
            return candidate.IsFlamable;
        }
    }
}
