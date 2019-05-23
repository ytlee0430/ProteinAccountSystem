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
        private ImportExcelSevice _ImportExcelSevice = new ImportExcelSevice();
        private StockService _stockService = new StockService();
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
            var datas = _ImportExcelSevice.AnalyzeShipData(path);
            _phuraseDetailModels = _stockService.GetPhuraseDetailModels(datas);

            _stockService.AddClientPhuraseRecord(_phuraseDetailModels);
            _stockService.UpdateDBStorage(_phuraseDetailModels);

            return true;
        }

        public bool CreateShippmentTickets()
        {
            if (!_phuraseDetailModels.Any())
                return false;

            return _shippmentService.CreateShippmentTicket(_phuraseDetailModels);
        }


        public bool UpdateDBStorage(string itemCode, int storage)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWebsiteStorage(string itemCode, int storage)
        {
            throw new NotImplementedException();
        }
    }
}
