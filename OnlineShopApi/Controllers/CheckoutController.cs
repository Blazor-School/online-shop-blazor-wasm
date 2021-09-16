using Microsoft.AspNetCore.Mvc;
using OnlineShopApi.Models;

namespace OnlineShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        [Route("[action]")]
        [HttpPost]
        public IActionResult Checkout(CheckoutInfo checkoutInfo)
        {
            return Ok($"Thank you {checkoutInfo.Name}, we will deliver to {checkoutInfo.Address}.");
        }
    }
}
