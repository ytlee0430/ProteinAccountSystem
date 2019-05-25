using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CommonUtility.Entity;
using CommonUtility.Enum;
using Newtonsoft.Json;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseProductRepository
    {
        public ProteinDB ProteinDbContext;

        public PhuraseProductRepository()
        {
            ProteinDbContext = new ProteinDB();
        }

        public bool AddItem(PhuraseProductModel product)
        {
            try
            {
                ProteinDbContext.PhuraseProducts.Add(
                    new PhuraseProductEntity
                    {
                        Count = product.Count,
                        ProductMoney = product.ProductMoney,
                        ProductMoneyWithoutTax = product.ProductMoneyWithoutTax,
                        ProductName = product.ProductName
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

        public List<PhuraseProductModel> GetList(Expression<Func<PhuraseProductEntity, bool>> exp)
        {
            try
            {
                return ProteinDbContext.PhuraseProducts.Where(exp).Select(product => new PhuraseProductModel
                {
                    Key = product.Key,
                    Count = product.Count,
                    ProductMoney = product.ProductMoney,
                    ProductMoneyWithoutTax = product.ProductMoneyWithoutTax,
                    ProductName = product.ProductName
                }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateItem(PhuraseProductModel product)
        {
            try
            {
                var entity = ProteinDbContext.PhuraseProducts.FirstOrDefault(i => product.Key == i.Key);
                if (entity == null)
                {
                    return false;
                }
                entity.Key = product.Key;
                entity.Count = product.Count;
                entity.ProductMoney = product.ProductMoney;
                entity.ProductMoneyWithoutTax = product.ProductMoneyWithoutTax;
                entity.ProductName = product.ProductName;
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateItems(List<PhuraseProductModel> updateProducts)
        {
            try
            {
                var updateEntity = ProteinDbContext.PhuraseProducts.Where(p => updateProducts.Any(product => product.Key == p.Key));

                foreach (var entity in updateEntity)
                {
                    var product = updateProducts.First(i => i.Key == entity.Key);
                    entity.Key = product.Key;
                    entity.Count = product.Count;
                    entity.ProductMoney = product.ProductMoney;
                    entity.ProductMoneyWithoutTax = product.ProductMoneyWithoutTax;
                    entity.ProductName = product.ProductName;
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

        public bool DeleteItem(PhuraseProductModel detail)
        {
            try
            {
                var entity = ProteinDbContext.PhuraseProducts.FirstOrDefault(i => detail.Key == i.Key);
                if (entity == null)
                {
                    return false;
                }

                ProteinDbContext.PhuraseProducts.Remove(entity);
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
