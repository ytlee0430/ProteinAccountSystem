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
using Z.EntityFramework.Plus;

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
                var items = Mapper.Map<List<Item>>(entitys);
                return items;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public bool UpdateItem(Item item)
        {
            try
            {
                var itemEntity = Mapper.Map<ItemEntity>(item);
                //Mapper 後判斷與調整實體狀態
                var entry = ProteinDbContext.Entry(itemEntity);

                if (entry.State == EntityState.Detached)
                {
                    var set = ProteinDbContext.Set<ItemEntity>();
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

        public bool UpdateItems(IEnumerable<Item> updateItems)
        {
            try
            {
                foreach (var item in updateItems)
                {
                    var itemEntity = Mapper.Map<ItemEntity>(item);
                    //Mapper 後判斷與調整實體狀態
                    var entry = ProteinDbContext.Entry(itemEntity);

                    if (entry.State == EntityState.Detached)
                    {
                        var set = ProteinDbContext.Set<ItemEntity>();
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
                }
                return ProteinDbContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteItem(Item item)
        {
            try
            {
               return  ProteinDbContext.Items.Where(i => i.Key == item.Key).Delete() > 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
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
