using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM
{
    public class ProteinContext : DbContext
    {
        public ProteinContext()
        {
        }

        public ProteinContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<PhuraseDetailEntity> PhuraseDetails { get; set; }
        public DbSet<PhuraseProductEntity> PhuraseProducts { get; set; }
    }
}
