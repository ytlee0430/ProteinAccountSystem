using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entity;
using Common.Enum;

namespace Common.Interface
{
    public interface IController
    {
        bool UpdateWebsiteStorage(string itemCode, int storage);

        bool UpdateDBStorage(string itemCode, int storage);

        bool CreateInvoice(string itemCode, int number,int price, string EINNnumber = "");

        List<Item> GetItems(BrandEnum brand, FlavorEnum flavor, ProductionType type, ProductionDetail detail);

        bool ImportExcel(FileStream fileStream);
    }
}
