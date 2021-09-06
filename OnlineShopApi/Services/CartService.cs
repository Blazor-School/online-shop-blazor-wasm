using OnlineShopApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopApi.Services
{
    public class CartService
    {
        private readonly List<Guid> _itemIds;
        private readonly ProductService _productService;

        public CartService(ProductService productService)
        {
            _itemIds = new();
            _productService = productService;
        }

        public void AddToCart(Guid id)
        {
            _itemIds.Add(id);
        }

        public bool IsInCart(Guid id)
        {
            bool result = _itemIds.Contains(id);

            return result;
        }

        public List<Product> GetProductsInCart()
        {
            var result = _productService.GetAllProducts()
                .Where(p => _itemIds.Contains(p.Id))
                .ToList();

            return result;
        }
    }
}
