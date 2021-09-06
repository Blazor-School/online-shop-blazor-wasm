using OnlineShopApi.Models;
using System;
using System.Collections.Generic;

namespace OnlineShopApi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "All roads lead to Blazor Server",
                    Description = "A tutorial book for Blazor Server technology"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "All roads lead to Blazor WASM",
                    Description = "A tutorial book for Blazor WASM technology."
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "How to be a good web programmer?",
                    Description = "Follow the journey of a programmer."
                }
            };
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
