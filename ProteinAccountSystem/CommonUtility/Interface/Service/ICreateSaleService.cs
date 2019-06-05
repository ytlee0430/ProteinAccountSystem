using Common.Entity;

namespace Common.Interface.Service
{
    public interface ICreateSaleService
    {
        void AddPhuraseProduct(Item item, int count, int saleMoney);

        PhuraseDetailModel CreateSale(int shoppeeFee, string receiptnumber, int saleWay, string companyName, string invoiceNumber);
    }
}