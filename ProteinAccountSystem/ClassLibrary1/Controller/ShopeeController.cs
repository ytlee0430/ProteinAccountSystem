using CommonUtility.Entity;
using CommonUtility.Enum;
using CommonUtility.Interface;
using Controller.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controller
{
    public class ShopeeController : IController
    {
        //TODO: 用介面 service自已開一個方案 interface 開在common裡
        private ImportExcelSevice _ImportExcelSevice = new ImportExcelSevice();
        //TODO: 用介面 service自已開一個方案 interface 開在common裡
        private StockService _stockService = new StockService();
        //TODO: 用介面 service自已開一個方案 interface 開在common裡S
        private ShippmentService _shippmentService = new ShippmentService();

        private List<PhuraseDetailModel> _phuraseDetailModels = new List<PhuraseDetailModel>();
        public bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "")
        {
            throw new NotImplementedException();
        }

        public List<Item> GetItems(BrandEnum brand, FlavorEnum flavor, ProductionType type, ProductionDetail detail)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 匯入出貨資料流程
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool importShipDataProcess(string path)
        {
            _phuraseDetailModels = _ImportExcelSevice.AnalyzeShipData(path);
            _stockService.AddDBlientPhuraseRecord(_phuraseDetailModels);
            _stockService.UpdateDBStorage(_phuraseDetailModels);

            return true;
        }

        public bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData)
        {
            return _stockService.AddDBlientPhuraseRecord(stockData);
        }
        public bool UpdateDBStorage(List<PhuraseDetailModel> stockData)
        {
            return _stockService.UpdateDBStorage(stockData);
        }

        public bool CreateShippmentTickets()
        {
            if (!_phuraseDetailModels.Any())
                return false;

            var result = _shippmentService.CreateShippmentTicket(_phuraseDetailModels);

            _phuraseDetailModels.Clear();
            return result;

        }

        //TODO:移除
        public bool UpdateDBStorage(string itemCode, int storage)
        {
            throw new NotImplementedException();
        }

        //TODO:移除
        public bool UpdateWebsiteStorage(string itemCode, int storage)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 取得庫存
        /// </summary>
        /// <returns></returns>
        public List<Item> GetStorage(BrandEnum brand, FlavorEnum flavor, PackageEnum package, ProductionType productionType, ProductionDetail productionDetailType)
        {
            return _stockService.GetStorage(brand, flavor, package, productionType, productionDetailType);
        }
    }
}
