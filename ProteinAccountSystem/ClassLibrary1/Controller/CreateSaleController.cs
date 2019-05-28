using CommonUtility.Entity;
using Controller.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CreateSaleController : ICreateSaleController
    {
        List<PhuraseProductModel> _phurases = new List<PhuraseProductModel>();
        public void AddPhuraseProduct(Item model)
        {
            //_phurases.Add(new PhuraseProductModel()
            //{
            //    ItemCode = item.ItemCode,
            //    Count = (int)nudCount.Value,
            //    ProductMoney = Convert.ToInt32(tbxSalePrice),
            //    ProductMoneyWithoutTax = Convert.ToInt32(Convert.ToInt32(tbxSalePrice) / 1.05),
            //});
            //_phurases.Add(model);
        }

        public List<PhuraseDetailModel> CreateSale()
        {
            throw new NotImplementedException();
        }
    }
}
