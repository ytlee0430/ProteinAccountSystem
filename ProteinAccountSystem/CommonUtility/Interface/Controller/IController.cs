using System.Collections.Generic;
using Common.Entity;
using Common.Enum;

namespace Common.Interface.Controller
{
    public interface IController
    {
        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        bool ImportShipDataProcess(string path);


        bool CreateShippmentTickets(string path);

        List<ItemViewModel> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> phuraseDetailModels);

        bool UpdateDBStorage(List<PhuraseDetailModel> list);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        bool importWirteOffMoneyDataProcess(string path);

        void AddPhuraseProduct(string itemItemCode, int count, int saleMoney);

        PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, int plat);

        bool UpdateDBItems(List<ItemViewModel> list);

        bool ExportStockExcel(List<ItemViewModel> storages, string path);

        bool AddDBStorage(Item item);

        bool WriteOffSelectedMoney(List<PhuraseDetailModel> dataSource);
        bool AddDBStorages(List<Item> list);
        bool ExportSaleRecordExcel(List<PhuraseDetailModel> list, string path);
    }
}
