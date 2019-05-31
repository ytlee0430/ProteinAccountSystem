using System.Collections.Generic;
using Common.Entity;
using Common.Enum;

namespace Common.Interface.Service
{
    public interface IStockService
    {
        bool UpdateDBStorage(List<PhuraseDetailModel> stockData);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData);

        List<Item> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        List<PhuraseDetailModel> UpdateProductItemCode(List<PhuraseDetailModel> models);
    }
}
