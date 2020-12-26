using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Repository.RepositoryBase
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