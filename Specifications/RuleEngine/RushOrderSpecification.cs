using Specifications.Models;

namespace Specifications.RuleEngine
{
    public class RushOrderSpecification : Specification<Order>
    {

        HiValueSpecification greaterThan100 = new HiValueSpecification();
        OrderInStock orderInStock = new OrderInStock();
        HazardousSpecification isHazardeous = new HazardousSpecification();

        public override bool IsSatisfied(Order candidate)
        {
             return greaterThan100
                    .And(orderInStock)
                    .And(isHazardeous.Not()) 
                    .IsSatisfied(candidate);
        }
    }
}
