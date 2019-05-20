using CommonUtility.Entity;
using CommonUtility.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommonUtility.Interface
{
    public interface IController
    {
        bool UpdateWebsiteStorage(string itemCode, int storage);

        bool UpdateDBStorage(string itemCode, int storage);

        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        List<Item> GetItems(BrandEnum brand, FlavorEnum flavor, ProductionType type, ProductionDetail detail);

        bool ImportExcel(string path);
    }
}
