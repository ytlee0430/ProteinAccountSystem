using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using Common.Entity;
using Common.Enum;
using Common.Interface.Controller;
using Common.Interface.Service;

namespace Controller.Controller
{
    public class ShopeeController : IController
    {
        private IAnalyzeExcelService _analyzeExcelService;
        private IStockService _stockService;
        private IShippmentService _shippmentService;
        private ICreateSaleService _createSaleService;
        private IAccountingService _accountingService;
        public ShopeeController(IAnalyzeExcelService analyzeExcelService, IStockService stockService, IShippmentService shippmentService, ICreateSaleService createSaleService, IAccountingService accountingService)
        {
            _analyzeExcelService = analyzeExcelService;
            _stockService = stockService;
            _shippmentService = shippmentService;
            _createSaleService = createSaleService;
            _accountingService = accountingService;
        }


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
            _phuraseDetailModels = _analyzeExcelService.AnalyzeShipData(path);
            _phuraseDetailModels = _stockService.UpdateProductItemCode(_phuraseDetailModels);
            _stockService.AddDBlientPhuraseRecord(_phuraseDetailModels);
            _stockService.UpdateDBStorage(_phuraseDetailModels);

            return true;
        }

        public bool importWirteOffMoneyDataProcess(string path)
        {
            var datas = _analyzeExcelService.AnalyzeShipData(path);
            return _accountingService.WriteOffMoney(datas);
        }

        public void AddPhuraseProduct(string itemItemCode, int count, int saleMoney)
        {
            _createSaleService.AddPhuraseProduct(itemItemCode, count, saleMoney);
        }

        public PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, PlatEnum plat)
        {
            return _createSaleService.CreateSale(shopeeFee, receiptnumber, plat);
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

        /// <summary>
        /// 取得庫存
        /// </summary>
        /// <returns></returns>
        public List<Item> GetStorage(BrandEnum brand, FlavorEnum flavor, PackageEnum package, ProductionType productionType, ProductionDetail productionDetailType)
        {
            return _stockService.GetStorage(brand, flavor, package, productionType, productionDetailType);
        }

        /// <summary>
        /// 取得銷售紀錄
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="writeOffMoneyState"></param>
        /// <returns></returns>
        public List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel)
        {
            List<PhuraseDetailModel> a = _stockService.GetSalesRecords(searchModel);
            return a;
        }
    }
}
