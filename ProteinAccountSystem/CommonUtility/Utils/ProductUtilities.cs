using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtility.Utils
{
    public static class ProductUtilities
    {

        public static string GetItemCodes(Item item)
        {
            var type = (int)item.ProductionType < 10 ? "0" + ((int)item.ProductionType).ToString() : ((int)item.ProductionType).ToString();
            var brand = (int)item.Brand < 10 ? "0" + ((int)item.Brand).ToString() : ((int)item.Brand).ToString();
            var productionDetailType = (int)item.ProductionDetailType < 10 ? "0" + ((int)item.ProductionDetailType).ToString() : ((int)item.ProductionDetailType).ToString();
            var package = (int)item.Package < 10 ? "0" + ((int)item.Package).ToString() : ((int)item.Package).ToString();
            var flavor = (int)item.Flavor < 10 ? "0" + ((int)item.Flavor).ToString() : ((int)item.Flavor).ToString();

            return type + brand + productionDetailType + package + flavor;

        }
    }
}
