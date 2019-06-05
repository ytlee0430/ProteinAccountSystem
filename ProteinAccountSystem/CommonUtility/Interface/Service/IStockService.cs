using Common.Entity;
using Common.Entity.Dto;
using System.Collections.Generic;

namespace Common.Interface.Service
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
    }
}