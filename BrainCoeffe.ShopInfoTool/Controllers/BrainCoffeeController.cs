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
    }
}
