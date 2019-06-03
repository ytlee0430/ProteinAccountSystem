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
        private IExcelExportService _excelExportService;
        public ShopeeController(IAnalyzeExcelService analyzeExcelService, IStockService stockService, IShippmentService shippmentService, ICreateSaleService createSaleService, IAccountingService accountingService, IExcelExportService excelExportService)
        {
            _analyzeExcelService = analyzeExcelService;
            _stockService = stockService;
            _shippmentService = shippmentService;
            _createSaleService = createSaleService;
            _accountingService = accountingService;
            _excelExportService = excelExportService;
        }


        private List<PhuraseDetailModel> _phuraseDetailModels = new List<PhuraseDetailModel>();
        public bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "")
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 匯入出貨資料流程
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool ImportShipDataProcess(string path)
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
            return _accountingService.WriteOffMoney(datas.Select(s => s.OrderNumber).ToList());
        }

        public void AddPhuraseProduct(string itemItemCode, int count, int saleMoney)
        {
            _createSaleService.AddPhuraseProduct(itemItemCode, count, saleMoney);
        }

        public PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, int plat)
        {
            return _createSaleService.CreateSale(shopeeFee, receiptnumber, plat);
        }

        public bool UpdateDBItems(List<ItemViewModel> list)
        {
            return _stockService.UpdateDBItems(list);
        }

        public bool ExportStockExcel(List<ItemViewModel> storages, string path)
        {
            return _excelExportService.ExportExcel(storages, path);
        }

        public bool AddDBStorage(Item item)
        {
            return _stockService.AddDBStorage(item);
        }

        public bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData)
        {
            return _stockService.AddDBlientPhuraseRecord(stockData);
        }

        public bool UpdateDBStorage(List<PhuraseDetailModel> stockData)
        {
            return _stockService.UpdateDBStorage(stockData);
        }

        public bool CreateShippmentTickets(string path)
        {
            if (!_phuraseDetailModels.Any())
                return false;

            var result = _shippmentService.CreateShippmentTicket(_phuraseDetailModels, path);

            _phuraseDetailModels.Clear();
            return result;

        }

        /// <summary>
        /// 取得庫存
        /// </summary>
        /// <returns></returns>
        public List<ItemViewModel> GetStorage(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero)
        {
            return _stockService.GetDBStorage(brand, flavor, package, productionType, productionDetailType, showZero);
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
            return _stockService.GetSalesRecords(searchModel);
        }

        public bool WriteOffSelectedMoney(List<PhuraseDetailModel> dataSource)
        {
            return _accountingService.WriteOffMoney(dataSource);
        }
    }
}
