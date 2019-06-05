using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entity;

namespace Common.Utils
{
    public static class ProductUtilities
    {
        public static string GetItemCodes(Item item)
        {
            var type = ((int)item.ProductionType).ToString("00");
            var brand = ((int)item.Brand).ToString("00");
            var productionDetailType = ((int)item.ProductionDetailType).ToString("00");
            var package = ((int)item.Package).ToString("00");
            var flavor = ((int)item.Flavor).ToString("00");
            return type + brand + productionDetailType + package + flavor;
        }

    }
}
