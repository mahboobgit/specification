using System;
using Specifications.Framework;
using Specifications.Models;
using Specifications.RuleEngine;

namespace SpecificationPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Specification Pattern Demo");


            RushOrderSpecification specification = new RushOrderSpecification();
            bool response = specification.IsSatisfied(
                new Order
                {
                    InStock = true,
                    IsFlamable = false,
                    Qty = 120,
                    TotalAmount = 101
                });


            Console.WriteLine($"Can order by placed? {response}");

            Console.ReadKey();

        }
    }
}
