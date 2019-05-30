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
    public class ItemRepository : RepositoryBase<ItemEntity>
    {
        public ItemRepository() : base(new ProteinDB())
        {
        }

        public Expression<Func<ItemEntity, bool>> GetItemExp(BrandEnum brand, FlavorEnum flavor, PackageEnum package, ProductionType productionType, ProductionDetail productionDetailType)
        {
            Expression<Func<ItemEntity, bool>> itemWhere = c => true;

            if (brand != BrandEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Brand == brand;
            }
            if (flavor != FlavorEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Flavor == flavor;
            }
            if (package != PackageEnum.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Package == package;
            }
            if (productionType != ProductionType.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.ProductionType == productionType;
            }
            if (productionDetailType != ProductionDetail.Null)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.ProductionDetailType == productionDetailType;
            }

            return itemWhere;
        }
    }
}
