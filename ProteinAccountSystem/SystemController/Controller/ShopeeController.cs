using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entity;
using Common.Enum;
using Common.Interface;

namespace SystemController
{
    public class ShopeeController : IController
    {
        public bool UpdateWebsiteStorage(string itemCode, int storage)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDBStorage(string itemCode, int storage)
        {
            throw new NotImplementedException();
        }

        public bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "")
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItems(BrandEnum brand, FlavorEnum flavor, ProductionType type)
        {
            throw new NotImplementedException();
        }
    }
}
