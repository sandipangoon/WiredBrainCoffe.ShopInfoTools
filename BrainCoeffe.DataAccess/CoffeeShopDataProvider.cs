using BrainCoeffe.DataAccess.Model;
using System.Collections.Generic;

namespace BrainCoeffe.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 120 };
            yield return new CoffeeShop { Location = "London", BeansInStockInKg = 130 };
            yield return new CoffeeShop { Location = "Paris", BeansInStockInKg = 210 };
        }
    }
}
