using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;

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

    }
}
