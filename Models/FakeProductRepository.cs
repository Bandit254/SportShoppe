using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportShoppe.Models
{
    public class FakeProductRepository  /* : IProductRepository */
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "Zach's Signature Model Football", Price = 54 },
            new Product {Name = "Surf Board", Price = 179 },
            new Product {Name = "Running Shoes", Price = 95 }
        }.AsQueryable<Product>();
    }
}
