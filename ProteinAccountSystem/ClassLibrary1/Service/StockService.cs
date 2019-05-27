using CodeFirstORM;
using CommonUtility.Entity;
using Controller.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.DBLayer;

namespace Controller.Service
{
    public class StockService : IStock
    {
        /// <summary>
        /// 加入用戶購買紀錄到資料庫
        /// </summary>
        /// <param name="stockData"></param>
        /// <returns></returns>
        public bool AddDBlientPhuraseRecord(List<PhuraseDetailModel> stockData)
        {
            var repo = new PhuraseDetailRepository();
            return repo.AddItems(stockData);
        }

        /// <summary>
        /// 更新db庫存數量
        /// </summary>
        /// <param name="stockData"></param>
        /// <returns></returns>
        public bool UpdateDBStorage(List<PhuraseDetailModel> stockData)
        {
            Dictionary<string, int> codeToNumDic = new Dictionary<string, int>();

            foreach (var detail in stockData)
                foreach (var product in detail.Products)
                {
                    if (!codeToNumDic.TryGetValue(product.ItemCode, out int num))
                        codeToNumDic[product.ItemCode] = 1;
                    else
                        codeToNumDic[product.ItemCode] = num + 1;
                }

            var repo = new ItemRepository();
            var items = repo.GetList(p => codeToNumDic.ContainsKey(p.ItemCode));

            foreach (var item in items)
                item.Storage -= codeToNumDic[item.ItemCode];

            return repo.UpdateItems(items);
        }

    }
}
