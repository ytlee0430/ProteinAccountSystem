using System.Collections.Generic;
using Common.Entity;
using Common.Entity.Dto;
using Common.Enum;

namespace Common.Interface.Controller
{
    public interface IMainFormController
    {
        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        bool ImportShipDataProcess(string path);


        bool CreateShippmentTickets(string path);

        List<ItemViewModel> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> phuraseDetailModels);

        bool UpdateDBStorage(List<PhuraseDetailModel> list);

        SaleRecordPagingDto GetSalesRecords(SearchModel searchModel, int pageIndex);
        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        bool importWirteOffMoneyDataProcess(string path);

        void AddPhuraseProduct(Item Item, int count, int saleMoney);

        PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, int plat, string companyName, string invoiceNumber);

        bool UpdateDBItems(List<ItemViewModel> list);

        bool ExportStockExcel(List<ItemViewModel> storages, string path);

        bool AddDBStorage(Item item);

        bool UpdateSalesRecords(List<PhuraseDetailModel> dataSource);
        bool AddDBStorages(List<Item> list);
        bool ExportSaleRecordExcel(List<PhuraseDetailModel> list, string path);

        List<EnumModel> GetEnums(int selectedIndex);

        bool AddEnumValue(string description, string keyword, int enumClass, int value);
    }
}
