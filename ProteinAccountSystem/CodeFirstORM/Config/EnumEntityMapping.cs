using CodeFirstORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM.Config
{
    public class EnumEntityMapping : EntityTypeConfiguration<EnumEntity>
    {
        public EnumEntityMapping()
        {
            ToTable("EnumEntities");
            HasRequired(x => x.EnumClass).WithMany(s => s.Enums).HasForeignKey(x => x.ForeignKey).WillCascadeOnDelete(true);
        }
    }
}
