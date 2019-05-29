using CodeFirstORM.Entity;

namespace CodeFirstORM
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProteinDB : DbContext
    {
        public ProteinDB()
            : base("name=ProteinDB")
        {
        }

        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<PhuraseDetailEntity> PhuraseDetails { get; set; }
    }
}