using System.Collections.Generic;
using Common.Entity;
using Common.Entity.Dto;
using Common.Enum;

namespace Common.Interface.Service
{
    public interface IStockService
    {
        bool UpdateDBStorage(List<PhuraseDetailModel> stockData);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData);

        List<ItemViewModel> GetDBStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero);

        SaleRecordPagingDto GetSalesRecords(SearchModel searchModel, int pageIndex);

        List<PhuraseDetailModel> UpdateProductItemCode(List<PhuraseDetailModel> models);

        bool UpdateDBItems(List<ItemViewModel> list);

        bool AddDBStorage(Item item);
        bool AddDBStorages(List<Item> list);
        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);
    }
}
