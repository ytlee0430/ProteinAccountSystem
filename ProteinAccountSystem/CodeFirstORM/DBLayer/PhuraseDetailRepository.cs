using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
                var detailEntity = Mapper.Map<PhuraseDetailEntity>(detail);
                ProteinDbContext.PhuraseDetails.Add(detailEntity);
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool AddItems(List<PhuraseDetailModel> details)
        {
            try
            {
                var detailEntitys = Mapper.Map<List<PhuraseDetailEntity>>(details);
                foreach (var detail in detailEntitys)
                    ProteinDbContext.PhuraseDetails.Add(detail);
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<PhuraseDetailModel> GetList(Expression<Func<PhuraseDetailEntity, bool>> exp)
        {
            try
            {
                return Mapper.Map<List<PhuraseDetailModel>>(ProteinDbContext.PhuraseDetails.Where(exp));
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
                var itemEntity = Mapper.Map<PhuraseDetailEntity>(detail);
                //Mapper 後判斷與調整實體狀態
                var entry = ProteinDbContext.Entry(itemEntity);

                if (entry.State == EntityState.Detached)
                {
                    var set = ProteinDbContext.Set<PhuraseDetailEntity>();
                    var attachedEntity = set.Find(itemEntity.Key);

                    if (attachedEntity != null)
                    {
                        var attachedEntry = ProteinDbContext.Entry(attachedEntity);
                        attachedEntry.CurrentValues.SetValues(itemEntity);
                    }
                    else
                    {
                        entry.State = EntityState.Modified;
                    }
                }
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
                    entity.Products = Mapper.Map<ICollection<PhuraseProductEntity>>(detail.Products).ToList();
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
        }

    }
}
