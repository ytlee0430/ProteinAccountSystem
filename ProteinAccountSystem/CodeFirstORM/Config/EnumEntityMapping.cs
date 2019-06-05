using CodeFirstORM.Entity;
using System.Data.Entity.ModelConfiguration;

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