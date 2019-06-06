using Common.Entity;
using Common.Interface.Service;
using Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Service
{
    public class CreateSaleService : ICreateSaleService
    {
        private readonly List<PhuraseProductModel> _phurases = new List<PhuraseProductModel>();

        public void AddPhuraseProduct(Item item, int count, int saleMoney)
        {
            var name = Enums.BrandEnum[item.Brand].Description + " " + Enums.ProductionEnum[item.ProductionType].Description + " " + Enums.BrandEnum[item.ProductionDetailType].Description + " " + Enums.FlavorEnum[item.Flavor].Description + " " + Enums.PackageEnum[item.Package].Description;

            _phurases.Add(new PhuraseProductModel()
            {
                ItemCode = item.ItemCode,
                Count = count,
                ProductMoney = saleMoney,
                ProductMoneyWithoutTax = Convert.ToInt32(saleMoney / 1.05),
                Brand = item.Brand,
                Flavor = item.Flavor,
                Package = item.Package,
                ProductionDetailType = item.ProductionDetailType,
                ProductionType = item.ProductionType,
                ProductName = name,
            });
        }

        public PhuraseDetailModel CreateSale(int shoppeeFee, string receiptnumber, int saleWay, string companyName, string invoiceNumber)
        {
            var model = new PhuraseDetailModel
            {
                Products = _phurases.ToList(),
                TotalMoney = _phurases.Sum(x => x.ProductMoney * x.Count) + shoppeeFee,
                TransferMoney = shoppeeFee,
                TotalTax =
                    Convert.ToInt32((_phurases.Sum(x => x.ProductMoneyWithoutTax * x.Count) + shoppeeFee) * 0.05),
                ReceiptNumber = receiptnumber,
                Plat = saleWay,
                CompanyName = companyName,
                CompanyInvoiceNumber = invoiceNumber
            };
            _phurases.Clear();
            return model;
        }
    }
}