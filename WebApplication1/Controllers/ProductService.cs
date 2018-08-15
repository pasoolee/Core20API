using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Api.Dtos;

namespace WebApplication1.Api.Services
{
    public class ProductService
    {
        public static ProductService Current { get; } = new ProductService();
        public List<Product> Products { get; }
        private ProductService()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "milk",
                    Price = 2.5f
                },
                new Product
                {
                    Id = 2,
                    Name = "bread",
                    Price = 4.5f
                },
                new Product
                {
                    Id = 3,
                    Name = "beer",
                    Price = 7.5f
                }

             };
        }
    }
}
