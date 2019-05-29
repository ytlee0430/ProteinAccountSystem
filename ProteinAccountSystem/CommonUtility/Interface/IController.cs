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
        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        List<Item> GetItems(BrandEnum brand, FlavorEnum flavor, ProductionType type, ProductionDetail detail);

        bool importShipDataProcess(string path);


        bool CreateShippmentTickets();

        List<Item> GetStorage(BrandEnum brand, FlavorEnum flavor, PackageEnum package, ProductionType productionType, ProductionDetail productionDetailType);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> phuraseDetailModels);

        bool UpdateDBStorage(List<PhuraseDetailModel> list);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        bool importWirteOffMoneyDataProcess(string path);
    }
}
