using Common.Entity;
using Common.Enum;

namespace Common.Interface.Service
{
    public interface ICreateSaleService
    {
        void AddPhuraseProduct(string itemCode, int count, int saleMoney);

        PhuraseDetailModel CreateSale(int shoppeeFee, string receiptnumber, int saleWay);
    }
}
