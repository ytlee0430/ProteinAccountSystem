using Common.Entity;
using Common.Entity.Dto;
using Common.Interface.Controller;
using Common.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Controller.Controller
{
    public class MainFormController : IMainFormController
    {
        private IAccountingService _accountingService;
        private IAnalyzeExcelService _analyzeExcelService;
        private ICreateSaleService _createSaleService;
        private IEnumService _enumService;
        private IExcelExportService _excelExportService;
        private List<PhuraseDetailModel> _phuraseDetailModels = new List<PhuraseDetailModel>();
        private IShippmentService _shippmentService;
        private IStockService _stockService;

        public MainFormController(IAnalyzeExcelService analyzeExcelService, IStockService stockService, IShippmentService shippmentService, ICreateSaleService createSaleService, IAccountingService accountingService, IExcelExportService excelExportService, IEnumService enumService)
        {
            _analyzeExcelService = analyzeExcelService;
            _stockService = stockService;
            _shippmentService = shippmentService;
            _createSaleService = createSaleService;
            _accountingService = accountingService;
            _excelExportService = excelExportService;
            _enumService = enumService;
        }

        public bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData)
        {
            return _stockService.AddDBlientPhuraseRecord(stockData);
        }

        public bool AddDBStorage(Item item)
        {
            return _stockService.AddDBStorage(item);
        }

        public bool AddDBStorages(List<Item> list)
        {
            return _stockService.AddDBStorages(list);
        }

        public bool AddEnumValue(string description, string keyword, int enumClass, int parentType)
        {
            return _enumService.AddEnumValue(description, keyword, enumClass, parentType);
        }

        public void AddPhuraseProduct(Item Item, int count, int saleMoney)
        {
            _createSaleService.AddPhuraseProduct(Item, count, saleMoney);
        }

        public bool CreateInvoice(string itemCode, int number, int price, string EINNnumber = "")
        {
            throw new NotImplementedException();
        }

        public PhuraseDetailModel CreateSale(int shopeeFee, string receiptnumber, int plat, string companyName, string invoiceNumber)
        {
            return _createSaleService.CreateSale(shopeeFee, receiptnumber, plat, companyName, invoiceNumber);
        }

        public bool CreateShippmentTickets(string path)
        {
            if (!_phuraseDetailModels.Any())
                return false;

            var result = _shippmentService.CreateShippmentTicket(_phuraseDetailModels, path);

            _phuraseDetailModels.Clear();
            return result;
        }

        public bool ExportSaleRecordExcel(List<PhuraseDetailModel> list, string path)
        {
            return _excelExportService.ExportExcel(list, path);
        }

        public bool ExportStockExcel(List<ItemViewModel> storages, string path)
        {
            return _excelExportService.ExportExcel(storages, path);
        }

        public List<EnumModel> GetEnums(int selectedIndex)
        {
            return _enumService.GetEnums(selectedIndex);
        }

        /// <summary>
        /// 取得銷售紀錄
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="writeOffMoneyState"></param>
        /// <returns></returns>
        public SaleRecordPagingDto GetSalesRecords(SearchModel searchModel, int pageIndex)
        {
            return _stockService.GetSalesRecords(searchModel, pageIndex);
        }

        public List<PhuraseDetailModel> GetSalesRecords(SearchModel searchModel)
        {
            return _stockService.GetSalesRecords(searchModel);
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
        /// 匯入出貨資料流程
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool ImportShipDataProcess(string path)
        {
            _phuraseDetailModels = _analyzeExcelService.AnalyzeShipData(path);
            _stockService.GenerateProductItemCode(_phuraseDetailModels);
            _stockService.AddDBlientPhuraseRecord(_phuraseDetailModels);
            _stockService.UpdateDBStorage(_phuraseDetailModels);

            return true;
        }

        public bool importWirteOffMoneyDataProcess(string path)
        {
            var datas = _analyzeExcelService.AnalyzeShipData(path);
            return _accountingService.WriteOffMoney(datas.Select(s => s.OrderNumber).ToList());
        }

        public bool UpdateDBItems(List<ItemViewModel> list)
        {
            return _stockService.UpdateDBItems(list);
        }

        public bool UpdateDBStorage(List<PhuraseDetailModel> stockData)
        {
            return _stockService.UpdateDBStorage(stockData);
        }

        public bool UpdateSalesRecords(List<PhuraseDetailModel> dataSource)
        {
            return _accountingService.UpdateSalesRecords(dataSource);
        }
    }
}