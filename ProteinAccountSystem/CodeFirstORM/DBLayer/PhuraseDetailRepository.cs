using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;
using CodeFirstORM.Utils;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseDetailRepository : RepositoryBase<PhuraseDetailEntity>
    {
        private readonly object _lock = new object();

        public PhuraseDetailRepository() : base(new ProteinDB())
        {
        }

        public override IQueryable<PhuraseDetailEntity> GetAll()
        {
            return _database.Set<PhuraseDetailEntity>().Include(e => e.Products);
        }

        public override PhuraseDetailEntity Get(int id)
        {
            return _database.Set<PhuraseDetailEntity>().Include(e => e.Products).Single(p => p.Key == id);
        }

        public override IQueryable<PhuraseDetailEntity> Get(Expression<Func<PhuraseDetailEntity, bool>> exp)
        {
            return _database.Set<PhuraseDetailEntity>().Include(e => e.Products).Where(exp);
        }

        public override bool Add(PhuraseDetailEntity entity)
        {
            lock (_lock)
            {
                entity.Key = _database.PhuraseDetails.Any() ?
                    _database.PhuraseDetails.Max(e => e.Key) + 1 : 0;
                return base.Add(entity);
            }
        }

        public override bool Add(IEnumerable<PhuraseDetailEntity> entitis)
        {
            lock (_lock)
            {
                var maxKey = _database.PhuraseDetails.Any() ?
                    _database.PhuraseDetails.Max(e => e.Key) : -1;

                foreach (var entity in entitis)
                {
                    maxKey++;
                    entity.Key = maxKey;
                }
                return base.Add(entitis);
            }
        }

        public Expression<Func<PhuraseDetailEntity, bool>> GetDetailExp(int brand, int flavor, int package, int productionType,
            int productionDetailType, int isWriteOffMoney, string keyWord, DateTime startTime, DateTime endTime)
        {
            Expression<Func<PhuraseDetailEntity, bool>> itemWhere = c => true;

            if (brand > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.Brand == brand));
            }
            if (flavor > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.Flavor == flavor));
            }
            if (package > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.Package == package));
            }
            if (productionType > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.ProductionType == productionType));
            }
            if (productionDetailType > 0)
            {
                itemWhere = itemWhere.AndAlso(c => c.Products.Any(x => x.ProductionDetailType == productionDetailType));
            }

            if (isWriteOffMoney != -1)
            {
                itemWhere = itemWhere.AndAlso(c => c.IsWriteOffMoney == (isWriteOffMoney == 1));
            }

            if (keyWord != "")
            {
                itemWhere = itemWhere.AndAlso(c => c.Account == keyWord || c.OrderNumber == keyWord || c.CompanyInvoiceNumber == keyWord || c.CompanyName == keyWord);
            }

            if (endTime != DateTime.MaxValue)
            {
                itemWhere = itemWhere.AndAlso(c => c.OrderCreateTime < endTime);
            }

            if (startTime != DateTime.MinValue)
            {
                itemWhere = itemWhere.AndAlso(c => c.OrderCreateTime > startTime);
            }
            return itemWhere;
        }

    }
}
