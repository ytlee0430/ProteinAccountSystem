﻿using System;
using System.Linq.Expressions;
using ProteinSystem.Repository.Entity;
using ProteinSystem.Repository.RepositoryBase;
using ProteinSystem.Repository.Utils;

namespace ProteinSystem.Repository.DBLayer
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