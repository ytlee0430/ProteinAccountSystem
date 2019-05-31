using CodeFirstORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM.RepositoryBase
{
    public interface IDatabaseContext
    {
        DbSet<ItemEntity> Items { get; set; }
        DbSet<PhuraseDetailEntity> PhuraseDetails { get; set; }
        DbSet<PhuraseProductEntity> PhuraseProducts { get; set; }
        DbSet<EnumEntity> EnumEntities { get; set; }
        DbSet<EnumClassEntity> EnumClassEntities { get; set; }
        DbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();
    }
}
