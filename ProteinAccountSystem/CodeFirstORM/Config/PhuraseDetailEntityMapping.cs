using CodeFirstORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM.Config
{
    public class PhuraseProductEntityMapping : EntityTypeConfiguration<PhuraseProductEntity>    {        public PhuraseProductEntityMapping()        {            ToTable("PhuraseProducts");            HasRequired(x => x.PhuraseDetail).WithMany(s => s.Products).HasForeignKey(x => x.PhuraseDetailEntityKey).WillCascadeOnDelete(true);        }    }
}
