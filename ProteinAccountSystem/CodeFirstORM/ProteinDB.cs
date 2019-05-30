using CodeFirstORM.Entity;

namespace CodeFirstORM
{
    using CodeFirstORM.RepositoryBase;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Linq;
    using System.Reflection;

    public class ProteinDB : DbContext , IDatabaseContext
    {
        public ProteinDB()
            : base("name=ProteinDB")
        {
        }

        public IDbSet<ItemEntity> Items { get; set; }
        public IDbSet<PhuraseDetailEntity> PhuraseDetails { get; set; }
        public IDbSet<PhuraseProductEntity> PhuraseProducts { get; set; }
      
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace)
                    && type.BaseType != null
                    && type.BaseType.IsGenericType
                    && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)
                );

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }


    }
}