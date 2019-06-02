using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;
using CodeFirstORM.Utils;
using Z.EntityFramework.Plus;

namespace CodeFirstORM.DBLayer
{
    public class ItemRepository : RepositoryBase<ItemEntity>
    {
        public ItemRepository() : base(new ProteinDB())
        {
        }

        public Expression<Func<ItemEntity, bool>> GetItemExp(int brand, int flavor, int package, int productionType, int productionDetailType, bool showZero)
        {
            Expression<Func<ItemEntity, bool>> itemWhere = c => true;

            if (brand > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Brand == brand);
            }
            if (flavor > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Flavor == flavor);
            }
            if (package > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Package == package);
            }
            if (productionType > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.ProductionType == productionType);
            }
            if (productionDetailType > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.ProductionDetailType == productionDetailType);
            }

            if (!showZero)
            {
                itemWhere = itemWhere.AndAlso(c => c.Storage > 0);
            }

            return itemWhere;
        }
    }
}
