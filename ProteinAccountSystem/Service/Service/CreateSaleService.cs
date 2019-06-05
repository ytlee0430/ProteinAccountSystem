using System;
using System.Collections.Generic;
using System.Linq;
using Common.Entity;
using Common.Enum;
using Common.Interface.Service;
using Common.Utils;

namespace Service.Service
{
    public class CreateSaleService : ICreateSaleService
    {
        List<PhuraseProductModel> _phurases = new List<PhuraseProductModel>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemCode"></param>
        /// <param name="count"></param>
        /// <param name="saleMoney"></param>
        public void AddPhuraseProduct(Item Item, int count, int saleMoney)
        {
            var name = ((BrandEnum)Item.Brand).GetDescriptionText() + " " + ((ProductionType)Item.ProductionType).GetDescriptionText() + " " + ((ProductionDetail)Item.ProductionDetailType).GetDescriptionText() + " " + ((FlavorEnum)Item.Flavor).GetDescriptionText() + " " + ((PackageEnum)Item.Package).GetDescriptionText();

            _phurases.Add(new PhuraseProductModel()
            {
                ItemCode = Item.ItemCode,
                Count = count,
                ProductMoney = saleMoney,
                ProductMoneyWithoutTax = Convert.ToInt32(saleMoney / 1.05),
                Brand = Item.Brand,
                Flavor = Item.Flavor,
                Package = Item.Package,
                ProductionDetailType = Item.ProductionDetailType,
                ProductionType = Item.ProductionType,
                ProductName = name,
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shoppeeFee"></param>
        /// <param name="receiptnumber"></param>
        /// <param name="saleWay"></param>
        /// <returns></returns>
        public PhuraseDetailModel CreateSale(int shoppeeFee, string receiptnumber, int saleWay, string companyName, string invoiceNumber)
        {
            var model = new PhuraseDetailModel();
            model.Products = _phurases.ToList();
            model.TotalMoney = _phurases.Sum(x => x.ProductMoney * x.Count) + shoppeeFee;
            model.TransferMoney = shoppeeFee;
            model.TotalTax = Convert.ToInt32((_phurases.Sum(x => x.ProductMoneyWithoutTax * x.Count) + shoppeeFee) * 0.05);
            model.ReceiptNumber = receiptnumber;
            model.Plat = saleWay;
            model.CompanyName = companyName;
            model.CompanyInvoiceNumber = invoiceNumber;
            _phurases.Clear();
            return model;
        }
    }
}
