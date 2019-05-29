using CommonUtility.Entity;
using CommonUtility.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    public interface ICreateSaleController
    {
        void AddPhuraseProduct(string itemCode, int count, int saleMoney);

        PhuraseDetailModel CreateSale(int shoppeeFee, string receiptnumber, PlatEnum saleWay);
    }
}
