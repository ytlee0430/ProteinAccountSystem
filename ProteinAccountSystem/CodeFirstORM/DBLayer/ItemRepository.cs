using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;
using Z.EntityFramework.Plus;

namespace CodeFirstORM.DBLayer
{
    public class ItemRepository : RepositoryBase<ItemEntity>
    {
        public ItemRepository() : base(new ProteinDB())
        {
        }

        public Expression<Func<ItemEntity, bool>> GetItemExp(int brand, int flavor, int package, int productionType, int productionDetailType)
        {
            Expression<Func<ItemEntity, bool>> itemWhere = c => true;

            if (brand != -1)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Brand == brand;
            }
            if (flavor != -1)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Flavor == flavor;
            }
            if (package != -1)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.Package == package;
            }
            if (productionType != -1)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.ProductionType == productionType;
            }
            if (productionDetailType != -1)
            {
                var prefix = itemWhere.Compile();
                itemWhere = c => prefix(c) && c.ProductionDetailType == productionDetailType;
            }

            return itemWhere;
        }
    }
}
