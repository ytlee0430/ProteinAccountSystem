using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CommonUtility.Entity;
using CommonUtility.Enum;

namespace CodeFirstORM.DBLayer
{
    public class ItemRepository
    {
        public ProteinDB ProteinDbContext;

        public ItemRepository()
        {
            ProteinDbContext = new ProteinDB();
        }

        public bool AddItem(Item item)
        {
            try
            {
                ProteinDbContext.Items.Add(
                    new ItemEntity()
                    {
                        Brand = (int)item.Brand,
                        Cost = item.Cost,
                        Discount = item.Discount,
                        Flavor = (int)item.Flavor,
                        ItemCode = item.ItemCode,
                        NetPrice = item.NetPrice,
                        Package = (int)item.Package,
                        ProductionType = (int)item.ProductionType,
                        Storage = item.Storage,
                        Tax = item.Tax,
                        ExpiredDate = item.ExpiredDate
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

        public List<Item> GetList(Expression<Func<ItemEntity, bool>> exp)
        {
            try
            {
                return ProteinDbContext.Items.Where(exp).Select(i => new Item
                {
                    Key = i.Key,
                    Brand = (BrandEnum)i.Brand,
                    Cost = i.Cost,
                    Discount = i.Discount,
                    Flavor = (FlavorEnum)i.Flavor,
                    ItemCode = i.ItemCode,
                    NetPrice = i.NetPrice,
                    Package = (PackageEnum)i.Package,
                    ProductionType = (ProductionType)i.ProductionType,
                    Storage = i.Storage,
                    Tax = i.Tax,
                    ExpiredDate = i.ExpiredDate
                }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            return new List<Item>();
        }


        public bool UpdateItem(Item item)
        {
            try
            {
                var entity = ProteinDbContext.Items.FirstOrDefault(i => item.Key == i.Key);
                if (entity == null)
                {
                    return false;
                }
                entity.Key = item.Key;
                entity.Brand = (int)item.Brand;
                entity.Cost = item.Cost;
                entity.Discount = item.Discount;
                entity.Flavor = (int)item.Flavor;
                entity.ItemCode = item.ItemCode;
                entity.NetPrice = item.NetPrice;
                entity.Package = (int)item.Package;
                entity.ProductionType = (int)item.ProductionType;
                entity.Storage = item.Storage;
                entity.Tax = item.Tax;
                entity.ExpiredDate = item.ExpiredDate;

                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        public bool UpdateItems(IEnumerable<Item> updateItems)
        {
            try
            {
                var updateEntity = ProteinDbContext.Items.Where(i => updateItems.Any(item => item.Key == i.Key));

                foreach (var entity in updateEntity)
                {
                    var item = updateItems.First(i => i.Key == entity.Key);
                    entity.Key = item.Key;
                    entity.Brand = (int)item.Brand;
                    entity.Cost = item.Cost;
                    entity.Discount = item.Discount;
                    entity.Flavor = (int)item.Flavor;
                    entity.ItemCode = item.ItemCode;
                    entity.NetPrice = item.NetPrice;
                    entity.Package = (int)item.Package;
                    entity.ProductionType = (int)item.ProductionType;
                    entity.Storage = item.Storage;
                    entity.Tax = item.Tax;
                    entity.ExpiredDate = item.ExpiredDate;
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

        public bool DeleteItem(Item item)
        {
            try
            {
                var entity = ProteinDbContext.Items.FirstOrDefault(i => item.Key == i.Key);
                if (entity == null)
                {
                    return false;
                }

                ProteinDbContext.Items.Remove(entity);
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;

        }


        public Expression<Func<ItemEntity, bool>> GetItemExp(BrandEnum brand, FlavorEnum flavor, PackageEnum package, ProductionType productionType, ProductionDetail productionDetailType)
        {
            Expression<Func<ItemEntity, bool>> itemWhere = c => true;

            if (brand != BrandEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Brand == (int)brand;
            }
            if (flavor != FlavorEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Flavor == (int)flavor;
            }
            if (package != PackageEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Package == (int)package;
            }
            if (productionType != ProductionType.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.ProductionType == (int)productionType;
            }
            if (productionDetailType != ProductionDetail.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.ProductionDetailType == (int)productionDetailType;
            }

            return itemWhere;
        }
    }
}
