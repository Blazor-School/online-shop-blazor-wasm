using Microsoft.AspNetCore.Mvc;
using OnlineShopApi.Services;
using System;

namespace OnlineShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        [Route("[action]")]
        [HttpPost]
        public IActionResult AddToCart([FromBody] Guid id)
        {
            _cartService.AddToCart(id);

            return Ok();
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult IsItemInCart(Guid id)
        {
            bool result = _cartService.IsInCart(id);

            return Ok(result);
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetCartItems()
        {
            var result = _cartService.GetProductsInCart();

            return Ok(result);
        }
    }
}