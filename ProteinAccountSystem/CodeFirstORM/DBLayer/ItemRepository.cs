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
                Mapper.Initialize(x => x.CreateMap<Item, ItemEntity>());
                var itemEntity = Mapper.Map<ItemEntity>(item);

                ProteinDbContext.Items.Add(itemEntity);
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
                var entitys = ProteinDbContext.Items.Where(exp);
                Mapper.Initialize(x => x.CreateMap<List<ItemEntity>, List<Item>>());
                var items = Mapper.Map<List<Item>>(entitys);
                return items;
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
