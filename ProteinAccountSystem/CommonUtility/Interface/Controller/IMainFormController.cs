using Common.Entity;
using Common.Entity.Dto;
using System.Collections.Generic;

namespace Common.Interface.Controller
{
    public interface IMainFormController
    {
        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> phuraseDetailModels);

        bool AddDBStorage(Item item);

        bool AddDBStorages(List<Item> list);

        bool AddEnumValue(string description, string keyword, int enumClass, int value);

        void AddPhuraseProduct(Item item, int count, int saleMoney);

        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, int plat, string companyName, string invoiceNumber);

        bool CreateShippmentTickets(string path);

        bool ExportSaleRecordExcel(List<PhuraseDetailModel> list, string path);

        bool ExportStockExcel(List<ItemViewModel> storages, string path);

        List<EnumModel> GetEnums(int selectedIndex);

        SaleRecordPagingDto GetSalesRecords(SearchModel searchModel, int pageIndex);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        List<ItemViewModel> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero);

        bool ImportShipDataProcess(string path);

        bool ImportWirteOffMoneyDataProcess(string path);

        bool UpdateDBItems(List<ItemViewModel> list);

        bool UpdateDBStorage(List<PhuraseDetailModel> list);

        bool UpdateSalesRecords(List<PhuraseDetailModel> dataSource);
    }
}