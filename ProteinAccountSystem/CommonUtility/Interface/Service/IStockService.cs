using System.Collections.Generic;
using Common.Entity;
using Common.Enum;

namespace Common.Interface.Service
{
    public interface IStockService
    {
        bool UpdateDBStorage(List<PhuraseDetailModel> stockData);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData);

        List<Item> GetStorage(BrandEnum brand, FlavorEnum flavor, PackageEnum package, ProductionType productionType, ProductionDetail productionDetailType);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);

        List<PhuraseDetailModel> UpdateProductItemCode(List<PhuraseDetailModel> models);
    }
}
