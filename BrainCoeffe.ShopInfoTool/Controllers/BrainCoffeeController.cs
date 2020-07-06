using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainCoeffe.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrainCoeffe.ShopInfoTool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrainCoffeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCoffeeShops()
        {
            var coffeeShopProvider = new CoffeeShopDataProvider();
            var coffeeShopList = coffeeShopProvider.LoadCoffeeShops();

            if(!coffeeShopList.Any())
            {
                return NotFound();
            }

            return Ok(coffeeShopList);
        }

        [HttpGet("{loc}")]
        public IActionResult GetCoffeeShopsWithName(string loc)
        {
            var coffeeShopProvider = new CoffeeShopDataProvider();
            var coffeeShopList = coffeeShopProvider.LoadCoffeeShops();

            var foundCoffeeShops = coffeeShopList
                .Where(x => x.Location.StartsWith(loc, StringComparison.OrdinalIgnoreCase));

            if (!foundCoffeeShops.Any())
            {
                return NotFound();
            }

            return Ok(foundCoffeeShops);
        }
    }
}
