using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Enum;
using Newtonsoft.Json;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseDetailRepository
    {
        public ProteinDB ProteinDbContext;

        public PhuraseDetailRepository()
        {
            ProteinDbContext = new ProteinDB();
        }

        public bool AddItem(PhuraseDetailModel detail)
        {
            try
            {
                ProteinDbContext.PhuraseDetails.Add(
                    new PhuraseDetailEntity()
                    {
                        Account = detail.Account,
                        DeliveryNumber = detail.DeliveryNumber,
                        OrderNumber = detail.OrderNumber,
                        Plat = (int)detail.Plat,
                        Products = JsonConvert.SerializeObject(detail.Products),
                        TotalMoney = detail.TotalMoney,
                        TotalTax = detail.TotalTax,
                        TransferMoney = detail.TransferMoney,
                        TransferMoneyWithoutTax = detail.TransferMoneyWithoutTax,
                        Remark = detail.Remark,
                        ReceiptNumber = detail.ReceiptNumber,
                        IsWriteOffMoney = detail.IsWriteOffMoney,
                        Manager = detail.Manager,
                        OrderCreateTime = detail.OrderCreateTime,
                        CompanyInvoiceNumber = detail.CompanyInvoiceNumber,
                        CompanyName = detail.CompanyName
                    }
                    );
                ProteinDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public bool AddItems(List<PhuraseDetailModel> details)
        {
            try
            {
                foreach (var detail in details)
                {
                    ProteinDbContext.PhuraseDetails.Add(
                        new PhuraseDetailEntity()
                        {
                            Account = detail.Account,
                            DeliveryNumber = detail.DeliveryNumber,
                            OrderNumber = detail.OrderNumber,
                            Plat = (int)detail.Plat,
                            Products = JsonConvert.SerializeObject(detail.Products),
                            TotalMoney = detail.TotalMoney,
                            TotalTax = detail.TotalTax,
                            TransferMoney = detail.TransferMoney,
                            TransferMoneyWithoutTax = detail.TransferMoneyWithoutTax,
                            Remark = detail.Remark,
                            ReceiptNumber = detail.ReceiptNumber,
                            IsWriteOffMoney = detail.IsWriteOffMoney,
                            Manager = detail.Manager,
                            OrderCreateTime = detail.OrderCreateTime,
                            CompanyInvoiceNumber = detail.CompanyInvoiceNumber,
                            CompanyName = detail.CompanyName
                        }
                    );
                }
                ProteinDbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }


        public List<PhuraseDetailModel> GetList(Expression<Func<PhuraseDetailEntity, bool>> exp)
        {
            try
            {
                return ProteinDbContext.PhuraseDetails.Where(exp).Select(detail => new PhuraseDetailModel
                {
                    Key = detail.Key,
                    Account = detail.Account,
                    DeliveryNumber = detail.DeliveryNumber,
                    OrderNumber = detail.OrderNumber,
                    Plat = (PlatEnum)detail.Plat,
                    Products = JsonConvert.DeserializeObject<List<PhuraseProductModel>>(detail.Products),
                    TotalMoney = detail.TotalMoney,
                    TotalTax = detail.TotalTax,
                    TransferMoney = detail.TransferMoney,
                    TransferMoneyWithoutTax = detail.TransferMoneyWithoutTax,
                    Remark = detail.Remark,
                    ReceiptNumber = detail.ReceiptNumber,
                    IsWriteOffMoney = detail.IsWriteOffMoney,
                    Manager = detail.Manager,
                    OrderCreateTime = detail.OrderCreateTime,
                    CompanyInvoiceNumber = detail.CompanyInvoiceNumber,
                    CompanyName = detail.CompanyName
                }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool UpdateItem(PhuraseDetailModel detail)
        {
            try
            {
                var entity = ProteinDbContext.PhuraseDetails.FirstOrDefault(i => detail.Key == i.Key);
                if (entity == null)
                {
                    return false;
                }
                entity.Account = detail.Account;
                entity.DeliveryNumber = detail.DeliveryNumber;
                entity.OrderNumber = detail.OrderNumber;
                entity.Plat = (int)detail.Plat;
                entity.Products = JsonConvert.SerializeObject(detail.Products);
                entity.TotalMoney = detail.TotalMoney;
                entity.TotalTax = detail.TotalTax;
                entity.TransferMoney = detail.TransferMoney;
                entity.TransferMoneyWithoutTax = detail.TransferMoneyWithoutTax;
                entity.Remark = detail.Remark;
                entity.ReceiptNumber = detail.ReceiptNumber;
                entity.IsWriteOffMoney = detail.IsWriteOffMoney;
                entity.Manager = detail.Manager;
                entity.OrderCreateTime = detail.OrderCreateTime;
                entity.CompanyInvoiceNumber = detail.CompanyInvoiceNumber;
                entity.CompanyName = detail.CompanyName;
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateItems(List<PhuraseDetailModel> updateDetails)
        {
            try
            {
                var updateEntity = ProteinDbContext.PhuraseDetails.Where(d => updateDetails.Any(detail => detail.Key == d.Key));

                foreach (var entity in updateEntity)
                {
                    var detail = updateDetails.First(i => i.Key == entity.Key);
                    entity.Account = detail.Account;
                    entity.DeliveryNumber = detail.DeliveryNumber;
                    entity.OrderNumber = detail.OrderNumber;
                    entity.Plat = (int)detail.Plat;
                    entity.Products = JsonConvert.SerializeObject(detail.Products);
                    entity.TotalMoney = detail.TotalMoney;
                    entity.TotalTax = detail.TotalTax;
                    entity.TransferMoney = detail.TransferMoney;
                    entity.TransferMoneyWithoutTax = detail.TransferMoneyWithoutTax;
                    entity.Remark = detail.Remark;
                    entity.ReceiptNumber = detail.ReceiptNumber;
                    entity.IsWriteOffMoney = detail.IsWriteOffMoney;
                    entity.Manager = detail.Manager;
                    entity.OrderCreateTime = detail.OrderCreateTime;
                    entity.CompanyInvoiceNumber = detail.CompanyInvoiceNumber;
                    entity.CompanyName = detail.CompanyName;
                }
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public bool DeleteItem(PhuraseDetailModel detail)
        {
            try
            {
                var entity = ProteinDbContext.PhuraseDetails.FirstOrDefault(i => detail.Key == i.Key);
                if (entity == null)
                {
                    return false;
                }

                ProteinDbContext.PhuraseDetails.Remove(entity);
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;

        }

    }
}
