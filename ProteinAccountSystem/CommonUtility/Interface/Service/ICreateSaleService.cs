using Common.Entity;
using Common.Enum;

namespace Common.Interface.Service
{
    public interface ICreateSaleService
    {
        void AddPhuraseProduct(Item Item, int count, int saleMoney);

        PhuraseDetailModel CreateSale(int shoppeeFee, string receiptnumber, int saleWay, string companyName, string invoiceNumber);
    }
}
