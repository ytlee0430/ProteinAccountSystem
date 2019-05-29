using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface IStock
    {
        bool UpdateDBStorage(List<PhuraseDetailModel> stockData);

        bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData);

        List<Item> GetStorage(CommonUtility.Enum.BrandEnum brand, CommonUtility.Enum.FlavorEnum flavor, CommonUtility.Enum.PackageEnum package, CommonUtility.Enum.ProductionType productionType, CommonUtility.Enum.ProductionDetail productionDetailType);

        List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel);
    }
}
