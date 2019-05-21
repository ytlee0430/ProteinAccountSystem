using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM
{
    public class BloggingContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }
}
