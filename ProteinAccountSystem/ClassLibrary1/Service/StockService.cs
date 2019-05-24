using CodeFirstORM;
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
        public bool AddClientPhuraseRecord(List<PhuraseDetailModel> stockData)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDBStorage(List<PhuraseDetailModel> stockData)
        {
         
            throw new NotImplementedException();
        }

     

        /// <summary>
        /// 將excel資料轉成model
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public List<PhuraseDetailModel> GetPhuraseDetailModels(List<string> datas)
        {
            var result = new List<PhuraseDetailModel>();
            foreach (var item in datas)
            {
                var a = item.Split(',');
               
                //找出相同訂單號碼的資料
                var sameOrderNumber = datas.Select(x => x.Split(',')[0] == a[0]).ToList();
                var products = new List<PhuraseProductModel>();
                foreach (var str in sameOrderNumber)
                {
                    var b = item.Split(',');
                    products.Add(new PhuraseProductModel()
                    {
                        ProductName = b[18],
                        Count = Convert.ToInt32(b[19]),
                        ProductMoney = Convert.ToInt32(b[5]),
                        ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToInt32(b[5]) / 1.05),
                    });
                }

                result.Add(new PhuraseDetailModel()
                {
                    OrderNumber = a[0],
                    Account = a[3],
                    TransferMoney = Convert.ToInt32(a[6]),
                    TotalMoney = Convert.ToInt32(a[7]),
                    Products = products,
                    TotalTax = Convert.ToInt32(Convert.ToInt32(a[7]) / 1.05),
                    TransferMoneyWithoutTax = Convert.ToInt32(a[7]) - Convert.ToInt32(Convert.ToInt32(a[7]) / 1.05),
                    DeliveryNumber = a[40],
                    Remark = a[45],
                });
            }

            return result;
        }
    }
}
