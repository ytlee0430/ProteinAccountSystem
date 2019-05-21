using CommonUtility.Entity;
using Controller.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Service
{
    public class StockService : IStock
    {
        public bool AddClientPhuraseRecord(List<string> stockData)
        {
            var models = GetPhuraseDetailModel(stockData);

            throw new NotImplementedException();
        }

        private List<PhuraseDetailModel> GetPhuraseDetailModel(List<string> phuraseModels)
        {
            return new List<PhuraseDetailModel>();
        }

        public bool UpdateDBStorage(List<string> stockData)
        {
            var models = GetItemModel(stockData);

            throw new NotImplementedException();
        }

        private List<Item> GetItemModel(List<string> phuraseModels)
        {
            return new List<Item>();
        }
    }
}
