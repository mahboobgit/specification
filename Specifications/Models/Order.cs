
namespace Specifications.Models
{
    public class Order
    {
        public int Qty { get; set; }
        public bool InStock { get; set; }
        public int TotalAmount { get; set; }
        public bool IsFlamable { get; set; }
    }
}
