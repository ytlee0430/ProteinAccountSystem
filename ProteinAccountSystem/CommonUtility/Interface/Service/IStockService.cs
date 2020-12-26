using System;
using System.Collections.Generic;
using ProteinSystem.Entity;
using ProteinSystem.Entity.Dto;

namespace ProteinSystem.Interface.Service
{
    public interface IStockService
    {
        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData);

        bool AddDBStorage(Item item);

        bool AddDBStorages(List<Item> list);

        void GenerateProductItemCode(List<PhuraseDetailModel> models);

        List<ItemViewModel> GetDBStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero);

        SaleRecordPagingDto GetSalesRecords(SearchModel searchModel, int pageIndex);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        bool UpdateDBItems(List<ItemViewModel> list);

        bool UpdateDBStorage(List<PhuraseDetailModel> stockData);

        List<PhuraseDetailModel> AddSalesRecordIfNotExist(List<PhuraseDetailModel> phuraseDetailModels);

        bool DeleteSale(List<int> deleteIndexes);

        List<PhuraseProductModel> GetSaleProducts(DateTime startDate, DateTime endDate);
    }
}