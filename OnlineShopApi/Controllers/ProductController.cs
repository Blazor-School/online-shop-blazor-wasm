using Microsoft.AspNetCore.Mvc;
using OnlineShopApi.Services;

namespace OnlineShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [Route("[action]")]
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var allProducts = _productService.GetAllProducts();

            return Ok(allProducts);
        }
    }
}
