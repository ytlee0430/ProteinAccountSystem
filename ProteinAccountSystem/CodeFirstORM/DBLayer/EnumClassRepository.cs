using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;

namespace CodeFirstORM.DBLayer
{
    public class EnumClassRepository : RepositoryBase<EnumClassEntity>
    {
        private readonly object _lock = new object();
        public EnumClassRepository() : base(new ProteinDB())
        {
        }

        public override IQueryable<EnumClassEntity> GetAll()
        {
            return _database.Set<EnumClassEntity>().Include(e => e.Enums);
        }

        public override EnumClassEntity Get(int id)
        {
            return _database.Set<EnumClassEntity>().Include(e => e.Enums).Single(p => p.Key == id);
        }

        public override IQueryable<EnumClassEntity> Get(Expression<Func<EnumClassEntity, bool>> exp)
        {
            return _database.Set<EnumClassEntity>().Include(e=>e.Enums).Where(exp);
        }

        public override bool Add(EnumClassEntity entity)
        {
            lock (_lock)
            {
                entity.Key = _database.EnumClassEntities.Any()?
                    _database.EnumClassEntities.Max(e => e.Key) + 1 : 0;
                return base.Add(entity);
            }
        }

        public override bool Add(IEnumerable<EnumClassEntity> entitis)
        {
            lock (_lock)
            {
                var maxKey = _database.EnumClassEntities.Any()?
                    _database.EnumClassEntities.Max(e => e.Key) : -1;

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
