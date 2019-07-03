using Common.Entity;
using Common.Entity.Dto;
using System;
using System.Collections.Generic;
using Common.Enum;

namespace Common.Interface.Controller
{
    public interface IMainFormController
    {
        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> phuraseDetailModels);

        bool AddDBStorage(Item item);

        bool AddDBStorages(List<Item> list);

        bool AddEnumValue(string description, string keyword, int enumClass, int value);

        bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "");

        /// <summary>
        /// 將已勾選項目批量印出寄件單
        /// </summary>
        /// <param name="list"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        bool CreatShippmentTicks(List<PhuraseDetailModel> list, string path);

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

        void CreateSale(int shopeeFee, string receiptnumber, int plat, string companyName, string invoiceNumber,
            DateTime saleTime, string customerName, List<PhuraseProductModel> phurases);

        bool DeleteSale(List<int> deleteIndexes);

        List<PhuraseProductViewModel> AnalyzeSaleRecord(AnalyzeType flavorOnly, DateTime startDate, DateTime endDate);
    }
}