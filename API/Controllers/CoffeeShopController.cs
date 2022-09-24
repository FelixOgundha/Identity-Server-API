using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ICoffeeShopServices _coffeeShopService;

        public CoffeeShopController(ICoffeeShopServices coffeeShopService)
        {
          _coffeeShopService = coffeeShopService;
        }

        // GET: Coffee Shops
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var coffeeShops = await _coffeeShopService.List();

            return Ok(coffeeShops);
        }
    }
}
